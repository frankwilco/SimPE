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
	/// This class represents a wrapper for the XSTN and XHTN resources.
	/// </summary>
	public class SkinInfo : GenericCpfInfo, ICloneable
	{
		private uint packageHash;
		private List<TextureOverlayInfo> items;

		/// <summary>
		/// Gets a list of <see cref="SkinItem"/> objects linked to the resource.
		/// </summary>
		/// <remarks>
		/// The actual linking is made by the value of the "family" property... LOL
		/// </remarks>
		public List<TextureOverlayInfo> Items
		{
			get {
				if (this.items == null)
					this.items = new List<TextureOverlayInfo>();
				return this.items;
			}
		}

		public uint PackageHash
		{
			get { return this.packageHash; }
			set { this.packageHash = value; }
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

		internal void AddItem(TextureOverlayInfo item)
		{
			if (this.items == null)
				this.items = new List<TextureOverlayInfo>();
			if (!this.items.Contains(item))
				this.items.Add(item);
		}

		public override void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd)
		{
			if (pfd == null)
				throw new ArgumentNullException();

			// TODO: disregard type checking?
			/*
			if (pfdXstn.Type != Utility.DataType.XSTN)
				throw new ArgumentException("The PackedFileDescriptor must be of type 'XSTN'");
			*/

			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package, false);

		}

		public IPackedFileDescriptor[] FindFiles(uint type)
		{
			if (this.Package != null)
				return this.Package.FindFiles(type);
			return new IPackedFileDescriptor[0];
		}


		public SkinInfo Clone()
		{
			SkinInfo ret = new SkinInfo(this.Package, this.PropertySet.FileDescriptor);
			return ret;
		}

		object ICloneable.Clone()
		{
			return this.Clone();
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
