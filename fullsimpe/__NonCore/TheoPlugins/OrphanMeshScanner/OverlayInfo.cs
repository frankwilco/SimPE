using System;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Scenegraph;
using System.Drawing;
using System.Collections;
using SimPe.Plugin.Helper;


namespace SimPe.Plugin.Wrapper
{
	/// <summary>
	/// Represents a wrapper for the PropertySet resource.
	/// </summary>
	public class OverlayInfo : GenericCpfInfo
	{
		RefFile refFile;

		/// <summary>
		/// This is a hack.
		/// Needed only for items that have a <see cref="RefFile"/>
		/// resource associated with it.
		/// </summary>
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
		}

		public Guid Hairtone
		{
			get { return Utility.ParseGuid(CpfItem("hairtone")); }
			set { this.SetValue("hairtone", value.ToString()); }
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

		public TextureOverlayTypes TextureOverlayType
		{
			get { return (TextureOverlayTypes)CpfItem("subtype").UIntegerValue; }
			set { this.SetValue("subtype", Convert.ToUInt32(value)); }
		}

		public SkinCategories Category
		{
			get { return (SkinCategories)CpfItem("category").UIntegerValue; }
			set { this.SetValue("category", Convert.ToUInt32(value)); }
		}

		public OutfitType OutfitType
		{
			get { return (OutfitType)CpfItem("outfit").UIntegerValue; }
			set { this.SetValue("outfit", Convert.ToUInt32(value)); }
		}

		public Guid Skintone
		{
			get { return Utility.ParseGuid(CpfItem("skintone")); }
			set { this.SetValue("skintone", value.ToString()); }
		}

		public uint ResourceKeyIndex
		{
			get { return this.CpfItem("resourcekeyidx").UIntegerValue; }
			set { this.SetValue("resourcekeyidx", value); }
		}

		public uint ShapeKeyIndex
		{
			get { return this.CpfItem("shapekeyidx").UIntegerValue; }
			set { this.SetValue("shapekeyidx", value); }
		}

		public uint MaskResourceKeyIndex
		{
			get { return this.CpfItem("maskresourcekeyidx").UIntegerValue; }
			set { this.SetValue("maskresourcekeyidx", value); }
		}

		public OverlayInfo()
		{
		}

		public OverlayInfo(IScenegraphFileIndexItem item)
		{
			this.ProcessPackage(item.Package, item.FileDescriptor);
		}

		public OverlayInfo(Cpf propertySet)
		{
			this.PropertySet = propertySet;
		}

		public override void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd)
		{
			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package);
		}

	}


	public enum SimGender
	{
		Unspecified = 0,
		Female = 1,
		Male = 2,
		Both = Female | Male
	}

	public enum OutfitType : int
	{
		None = 0x00,
		Hair = 0x01,
		Face = 0x02,
		Bottom = 0x10,
		Top = 0x04,
		Body = 0x08
	}

}
