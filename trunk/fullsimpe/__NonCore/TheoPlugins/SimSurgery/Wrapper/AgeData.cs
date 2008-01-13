using System;
using System.Collections.Generic;
using System.Text;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Interfaces.Files;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.Wrapper
{

	/// <remarks>
	/// Wrapper for AGED resources.
	/// </remarks>
	public sealed class AgeData : AbstractCpfInfo, IReferenceInfo
	{
		RefFile refFile;
		List<ReferenceIndex> list;

		public RefFile ReferenceFile
		{
			get
			{
				if (this.refFile == null)
				{
					try
					{
						IPackedFileDescriptor pfd = this.Package.FindFile(MetaData.REF_FILE, this.PropertySet.FileDescriptor.SubType, this.PropertySet.FileDescriptor.Group, this.PropertySet.FileDescriptor.Instance);
						if (pfd != null)
						{
							refFile = new RefFile();
							refFile.ProcessData(pfd, this.Package);
						}
					}
					catch
					{
					}
				}
				return refFile;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public Guid Hairtone
		{
			get { return Utility.ParseGuid(CpfItem("haircolor")); }
			set { this.SetValue("haircolor", value.ToString()); }
		}

		public Guid Skintone
		{
			get { return Utility.ParseGuid(CpfItem("skincolor")); }
			set { this.SetValue("skincolor", value.ToString()); }
		}

		public Guid Eyecolor
		{
			get { return Utility.ParseGuid(CpfItem("eyecolor")); }
			set { this.SetValue("eyecolor", value.ToString()); }
		}

		public Ages Age
		{
			get { return (Ages)CpfItem("age").UIntegerValue; }
			set { this.SetValue("age", Convert.ToUInt32(value)); }
		}

		public SimGender Gender
		{
			get { return (SimGender)CpfItem("gender").UIntegerValue; }
			set { this.SetValue("gender", Convert.ToUInt32(value)); }
		}

		public float HeightMultiplier
		{
			get { return this.CpfItem("stretch").SingleValue; }
			set { this.SetValue("stretch", value); }
		}

		/// <summary>
		/// Gets the index in the ReferenceFile that links to
		/// the CRES resource of the sim's skeleton.
		/// </summary>
		public uint SkeletonResourceIndex
		{
			get { return this.CpfItem("skeletonkeyidx").UIntegerValue; }
		}

		internal List<ReferenceIndex> List
		{
			get
			{
				if (this.list == null)
				{
					this.list = new List<ReferenceIndex>();
					uint count = this.CpfItem("listcnt").UIntegerValue;
					for (int i = 0; i < count; i++)
					{
						ReferenceIndex item = new ReferenceIndex(
							this.CpfItem(String.Format("ls{0}", i)).StringValue,
							this.CpfItem(String.Format("lk{0}", i)).UIntegerValue,
							this.CpfItem(String.Format("le{0}_0", i)).UIntegerValue
							);

						this.list.Add(item);
					}
				}
				return this.list;
			}
		}



		public AgeData()
		{
		}

		public AgeData(IPackedFileDescriptor pfd, IPackageFile package) : this()
		{
			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package);
		}

		public override void CommitChanges()
		{
			if (this.list != null)
			{
				for (int i = 0; i < this.list.Count; i++)
				{
					ReferenceIndex item = this.list[i];
					this.SetValue(String.Format("ls{0}", i), item.S);
					this.SetValue(String.Format("lk{0}", i), item.K);
					this.SetValue(String.Format("le{0}_0", i), item.Index);
				}

				this.SetValue("listcnt", (uint)this.list.Count);
			}
			base.CommitChanges();
		}



		public static SkinCategory CategoryConvert(SkinCategories category)
		{
			switch (category)
			{
				case SkinCategories.Everyday:
					return SkinCategory.Everyday;

				default:
					return (SkinCategory)Convert.ToUInt32(category);
			}
		}

		public static SkinCategories CategoryConvert(SkinCategory category)
		{
			switch (category)
			{
				case SkinCategory.Everyday:
				case SkinCategory.Unknown:
					return SkinCategories.Everyday;

				default:
					return (SkinCategories)Convert.ToUInt32(category);
			}
		}


	}


	/// <summary>
	/// The purpose of this information is to build the sim's clothing wardrobe
	/// </summary>
	internal sealed class ReferenceIndex
	{
		/// <summary>
		/// Unknown. Always "1"
		/// </summary>
		internal string S;

		/// <summary>
		/// High word defines the SkinCategory, low word defines the OutfitType
		/// </summary>
		internal uint K;


		private int e0;

		/// <summary>
		/// Index in the 3IDR resource
		/// </summary>
		public int Index
		{
			get { return e0; }
			set { e0 = value; }
		}

		/// <summary>
		/// Attention! the coded category uses 0x01 as everyday instead of 0x07
		/// </summary>
		public SkinCategory Category
		{
			get
			{
				// TODO: use another enum :P
				return (SkinCategory)((K >> 0x10) & 0x0000FFFF);
			}
			set
			{
				K = (K & 0x0000FFFF) | (Convert.ToUInt32(value) << 0x10);
			}
		}

		public OutfitType Outfit
		{
			get
			{
				return (OutfitType)(K & 0x0000FFFF);
			}
			set
			{
				K = (uint)(K & 0xFFFF0000u) | (Convert.ToUInt32(value));
			}
		}

		public ReferenceIndex()
		{
		}

		public ReferenceIndex(string s, uint k, uint e0)
		{
			this.S = s;
			this.K = k;
			this.e0 = (int)e0;
		}
	}


	public enum SkinCategory : uint
	{
		None = 0x00,
		Everyday = 0x01,
		Swimwear = 0x08,
		PJ = 0x10,
		Formal = 0x20,
		Undies = 0x40,
		Skin = 0x80,
		Pregnant = 0x100,
		Activewear = 0x200,
		Unknown = 0x400
	}


}
