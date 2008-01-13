using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Data;
using SimPe.PackedFiles.Wrapper;
using System.Drawing;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.Wrapper
{

	/// <summary>
	/// This class represents a wrapper for the SkintoneXML (XSTN) resource.
	/// </summary>
	public class SkinInfo : GenericCpfInfo
	{
		private static List<IScenegraphFileIndexItem> sfItems;

		private uint packageHash;
		private List<TextureOverlayInfo> items;

		/// <summary>
		/// Gets a list of <see cref="SkinItem"/> objects linked to the XSTN resource.
		/// </summary>
		/// <remarks>
		/// The actual linking is made by the value of the "skintone" property... LOL
		/// </remarks>
		public List<TextureOverlayInfo> Items
		{
			get {
				if (this.items == null)
					this.items = this.GetSkinItems();
				return this.items;
			}
		}

		public uint PackageHash
		{
			get { return this.packageHash; }
			set { this.packageHash = value; }
		}

		/// <summary>
		/// This is bad, but it could be worse :P
		/// </summary>
		internal static List<IScenegraphFileIndexItem> PropertySets
		{
			get
			{
				if (sfItems == null)
					sfItems = new List<IScenegraphFileIndexItem>(FileTable.FileIndex.FindFile(MetaData.GZPS, true));
				return sfItems;
			}
		}

		public SkinInfo()
		{
		}

		public SkinInfo(IScenegraphFileIndexItem item)
		{
			if (item != null)
				this.ProcessPackage(item.Package, item.FileDescriptor);
		}

		public SkinInfo(IPackageFile package, IPackedFileDescriptor pfdXstn)
		{
			this.ProcessPackage(package, pfdXstn);
		}

		public override void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfdXstn)
		{
			if (pfdXstn == null)
				throw new ArgumentNullException();

			// TODO: disregard type checking?
			if (pfdXstn.Type != Utility.DataType.XSTN)
				throw new ArgumentException("The PackedFileDescriptor must be of type 'XSTN'");

			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfdXstn, package, false);

		}

		public IPackedFileDescriptor[] FindFiles(uint type)
		{
			if (this.Package != null)
				return this.Package.FindFiles(type);
			return new IPackedFileDescriptor[0];
		}


		private List<TextureOverlayInfo> GetSkinItems()
		{
			List<TextureOverlayInfo> ret = new List<TextureOverlayInfo>();
			if (
				this.PropertySet.FileDescriptor == null ||
				this.Package == null
				)
				return ret;

			// Get the GZPS resources of the same group
			List<IScenegraphFileIndexItem> sfItems = PropertySets.FindAll(
					delegate(IScenegraphFileIndexItem item)
					{
						return (item.FileDescriptor.Group == this.PropertySet.FileDescriptor.Group);
					}
				);

			if (Utility.IsNullOrEmpty(sfItems))
				sfItems = new List<IScenegraphFileIndexItem>(FileTable.FileIndex.FindFile(MetaData.GZPS, this.PropertySet.FileDescriptor.Group));

			foreach (IScenegraphFileIndexItem sfItem in sfItems)
			{
				Cpf cpf = new Cpf();
				cpf.ProcessData(sfItem);
				string family = this.Family.ToString();

				// WTF?
				if (
					cpf.GetSaveItem("skintone").StringValue == family ||
					cpf.GetSaveItem("family").StringValue == family
					)
				{
					TextureOverlayInfo item = new TextureOverlayInfo(cpf);
					ret.Add(item);
				}

			}

			return ret;
		}

		private uint GetPackageHash()
		{
			Random rn = new Random();
			uint ret = ((uint)rn.Next(0xffffff) | 0xff000000u);
			foreach (IPackedFileDescriptor pfd in this.Package.Index)
			{
				//This is a scenegraph Resource so get the Hash from there!
				if (MetaData.RcolList.Contains(pfd.Type))
				{
					using (Rcol rcol = new GenericRcol(null, false))
					{
						rcol.ProcessData(pfd, this.Package);
						ret = Hashes.GroupHash(rcol.FileName);
					}
					break;

				}
			}
			return ret;
		}


		private uint GetScenegraphGroup(IPackageFile package)
		{
			uint ret = 0;
			foreach (IPackedFileDescriptor pfd in this.Package.Index)
				if (MetaData.RcolList.Contains(pfd.Type))
				{
					ret = pfd.Group;
					break;
				}
			return ret;
		}

	}
}
