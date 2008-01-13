using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Plugin.Helper;
using System.ComponentModel;

namespace SimPe.Plugin.Wrapper
{

	/// <summary>
	/// This class is a wrapper around a <see cref="Cpf" /> instance, providing
	/// quick access to the most common properties.
	/// </summary>
	public abstract class GenericCpfInfo : AbstractCpfInfo
	{
		private RefFile refFile;
		private Image icon;

		/// <summary>
		/// This is a hack.
		/// Needed only for items that have a <see cref="RefFile"/>
		/// resource associated with it.
		/// </summary>
		[Browsable(false)]
		public RefFile ReferenceFile
		{
			get
			{
				if (this.refFile == null)
				{
					try
					{
						IPackedFileDescriptor pfd = this.PropertySet.Package.FindFile(MetaData.REF_FILE, this.PropertySet.FileDescriptor.SubType, this.PropertySet.FileDescriptor.Group, this.PropertySet.FileDescriptor.Instance);
						if (pfd != null)
						{
							refFile = new RefFile();
							refFile.ProcessData(pfd, this.PropertySet.Package);
						}
					}
					catch
					{
					}
				}
				return refFile;
			}
		}

		/// <summary>
		/// This is a hack.
		/// Needed only for items that have a catalog image (IMG) resource.
		/// </summary>
		[Browsable(false)]
		public Image Icon
		{
			get
			{
				if (this.icon == null)
					this.icon = this.GetIcon();
				return this.icon;
			}
			set
			{
				this.icon = value;
			}
		}

		/// <summary>
		/// Gets or sets the parsed value of the "type" property.
		/// </summary>
		[Category("General")]
		public CpfType Type
		{
			get
			{
				CpfType ret = CpfType.Unsupported;
				try
				{
					ret = (CpfType)Enum.Parse(
						typeof(CpfType),
						CpfItem("type").StringValue,
						true
						);
				}
				catch
				{
				}
				return ret;
			}
		}

		/// <summary>
		/// Gets or sets the Guid value of the "family" property.
		/// </summary>
		[Category("Advanced")]
		public Guid Family
		{
			get { return Utility.ParseGuid(CpfItem("family")); }
			set { this.SetValue("family", value.ToString()); }
		}

		/// <summary>
		/// Gets or sets the string value of the "name" property.
		/// </summary>
		[Category("General")]
		public string Name
		{
			get { return CpfItem("name").StringValue; }
			set { this.SetValue("name", value); }
		}

		/// <summary>
		/// Gets or sets the parsed value of the bitflag property "flags".
		/// </summary>
		[Category("Advanced")]
		public CpfFlags Flags
		{
			get { return (CpfFlags)CpfItem("flags").UIntegerValue; }
			set { this.SetValue("flags", Convert.ToUInt32(value)); }
		}

		/// <summary>
		/// Gets or sets the integer value of the "version" property.
		/// </summary>
		[Category("Advanced")]
		public uint Version
		{
			get { return this.CpfItem("version").UIntegerValue; }
			set { this.CpfItem("version").UIntegerValue = value; }
		}

		/// <summary>
		/// Gets or sets the <see cref="System.Single"/> value of the "genetic" property.
		/// </summary>
		[Category("Advanced")]
		public float GeneticWeight
		{
			get { return this.CpfItem("genetic").SingleValue; }
			set { this.CpfItem("genetic").SingleValue = value; }
		}


		public GenericCpfInfo()
		{
		}

		private Image GetIcon()
		{
			Image ret = null;
			IScenegraphFileIndexItem[] sfItems = FileTable.FileIndex.FindFile(Utility.DataType.IMG, this.PropertySet.FileDescriptor.Group);
			if (sfItems.Length > 0)
			{
				IScenegraphFileIndexItem sfItem = sfItems[0];

				Picture img = new Picture();
				img.ProcessData(sfItem);

				ret = img.Image;
			}
			return ret;
		}

		public abstract void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd);


	}
}
