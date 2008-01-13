using System;
using System.Collections;
using System.Text;
using System.Drawing;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.Wrapper
{

	/// <summary>
	/// This class is a wrapper around a <see cref="Cpf" /> instance, providing
	/// quick access to the most common properties.
	/// </summary>
	public abstract class GenericCpfInfo : AbstractCpfInfo
	{
		/// <summary>
		/// Gets or sets the parsed value of the "type" property.
		/// </summary>
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
		public Guid Family
		{
			get { return Utility.ParseGuid(CpfItem("family")); }
			set { this.SetValue("family", value.ToString()); }
		}

		/// <summary>
		/// Gets or sets the string value of the "name" property.
		/// </summary>
		public string Name
		{
			get { return CpfItem("name").StringValue; }
			set { this.SetValue("name", value); }
		}

		/// <summary>
		/// Gets or sets the parsed value of the bitflag property "flags".
		/// </summary>
		public CpfFlags Flags
		{
			get { return (CpfFlags)CpfItem("flags").UIntegerValue; }
			set { this.SetValue("flags", Convert.ToUInt32(value)); }
		}

		/// <summary>
		/// Gets or sets the integer value of the "version" property.
		/// </summary>
		public uint Version
		{
			get { return this.CpfItem("version").UIntegerValue; }
			set { this.CpfItem("version").UIntegerValue = value; }
		}


		public GenericCpfInfo()
		{
		}


		public abstract void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd);


	}

	/// <remarks>
	/// These values are used in different contexts:
	/// Hairtone is used in XHTN resources, Skin and
	/// TextureOverlay/MeshOverlay are used in GZPSsses,
	/// Skintone is used by XSTN
	/// </remarks>
	public enum CpfType
	{
		Unsupported = 0,
		Hairtone,
		Skintone,
		Skin,
		TextureOverlay,
		MeshOverlay,
		ModelMaterial
	}

}
