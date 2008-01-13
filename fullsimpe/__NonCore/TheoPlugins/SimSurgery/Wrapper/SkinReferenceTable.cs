using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Data;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.Wrapper
{
	
	/// <summary>
	/// This class manipulates both the AGED and the 3IDR resources, 
	/// providing an abstraction for the sim's clothing matrix.
	/// </summary>
	public class SkinReferenceTable : AbstractRefInfo, IEnumerable<SkinReferenceItem>
	{
		AgeData ageData;
		List<SkinReferenceItem> items;

		public SkinReferenceItem this[SkinCategory category, OutfitType outfit]
		{
			get	{	return this.FindItem(category, outfit); }
		}

		public virtual AgeData AgeData
		{
			get	{ return this.ageData; }
			set {
				if (value == null)
					throw new ArgumentNullException();
				this.ageData = value;
				this.ReferenceFile = value.ReferenceFile;
				this.UpdateItems();
			}
		}

		public SkinReferenceTable(AgeData ageData)
		{
			this.items = new List<SkinReferenceItem>();
			this.AgeData = ageData;
		}

		void UpdateItems()
		{
			this.items.Clear();
			for (int i = 0; i < this.ageData.List.Count; i++)
			{
				ReferenceIndex r = this.ageData.List[i];
				SkinReferenceItem item = new SkinReferenceItem(r);
				item.FileDescriptor = this.ReferenceFile.Items[r.Index];
				this.items.Add(item);
			}

		}

		public void Add(IPackedFileDescriptor pfd, SkinCategory category, OutfitType outfit)
		{
			SkinReferenceItem item = this.FindItem(category, outfit);
			if (item == null)
			{
				item = new SkinReferenceItem();
				item.Category = category;
				item.Outfit = outfit;
				item.FileDescriptor = pfd;

				this.Add(item);
			}
			else
			{
				item.FileDescriptor = pfd;
				this.ReferenceFile.Items[item.ReferenceIndex.Index] = new RefFileItem(pfd, this.ReferenceFile);
			}
		}


		public void Add(SkinReferenceItem item)
		{
			if (item == null)
				return;

			SkinReferenceItem current = this.FindItem(item.Category, item.Outfit);
			if (current == null)
			{
				// add
				this.items.Add(item);

				// set new index
				item.ReferenceIndex.Index = this.ReferenceFile.Items.Length;

				// add file descriptor to 3idr list
				List<IPackedFileDescriptor> refItems = new List<IPackedFileDescriptor>(this.ReferenceFile.Items);
				refItems.Add(new RefFileItem(item.FileDescriptor, this.ReferenceFile));
				this.ReferenceFile.Items = refItems.ToArray();
				
				// add reference to agedata list
				this.ageData.List.Add(item.ReferenceIndex);
			}
			else
			{
				// replace
				ReferenceIndex index = current.ReferenceIndex;
				this.ReferenceFile.Items[index.Index] = new RefFileItem(item.FileDescriptor, this.ReferenceFile);
			}

		}

		public SkinReferenceItem FindItem(SkinCategory category, OutfitType outfit)
		{
			SkinReferenceItem ret = this.items.Find(
				delegate(SkinReferenceItem item) {
					return (item.Category == category && item.Outfit == outfit);
				});
			return ret;
		}

		public virtual void CommitChanges()
		{
			this.ageData.CommitChanges();
			this.ReferenceFile.SynchronizeUserData();
		}

		#region IEnumerable<SkinItem> Members

		public IEnumerator<SkinReferenceItem> GetEnumerator()
		{
			return this.items.GetEnumerator();
		}

		#endregion

		#region IEnumerable Members

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		#endregion
	}

	public class SkinReferenceItem
	{
		IPackedFileDescriptor pfdCpf;
		ReferenceIndex index;

		public IPackedFileDescriptor FileDescriptor
		{
			get { return pfdCpf; }
			set {
				if (value == null)
					throw new ArgumentNullException();

				if (value.Type != Utility.DataType.GZPS)
					throw new ArgumentException();

				pfdCpf = value;
			}
		}

		public OutfitType Outfit
		{
			get { return this.ReferenceIndex.Outfit; }
			set { this.ReferenceIndex.Outfit = value; }
		}
		
		public SkinCategory Category
		{
			get { return this.ReferenceIndex.Category; }
			set { this.ReferenceIndex.Category = value; }
		}

		internal ReferenceIndex ReferenceIndex
		{
			get {
				if (index == null)
					index = new ReferenceIndex("1", 0, 0);
				return index;
			}
			set { index = value; }
		}

		public SkinReferenceItem()
		{
		}

		internal SkinReferenceItem(ReferenceIndex index)
		{
			this.index = index;
		}

	}

}
