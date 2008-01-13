using System;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Scenegraph;
using System.Drawing;
using System.Collections.Generic;
using SimPe.Plugin.Helper;
using System.ComponentModel;


namespace SimPe.Plugin.Wrapper
{
	/// <summary>
	/// Represents a wrapper for the PropertySet resource.
	/// </summary>
	public class TextureOverlayInfo : GenericCpfInfo
	{
		List<MaterialDefinitionInfo> materials;
		List<OverrideItem> overrides;

		[Category("Genetics")]
		public Guid Hairtone
		{
			get { return Utility.ParseGuid(CpfItem("hairtone")); }
			set { this.SetValue("hairtone", value.ToString()); }
		}

		[Category("Sim")]
		public Ages Age
		{
			get { return (Ages)CpfItem("age").UIntegerValue; }
			set { this.SetValue("age", Convert.ToUInt32(value)); }
		}

		[Category("Sim")]
		public SimGender Gender
		{
			get { return (SimGender)CpfItem("gender").UIntegerValue; }
			set { this.SetValue("gender", Convert.ToUInt32(value)); }
		}

		[Category("General")]
		public TextureOverlayTypes TextureOverlayType
		{
			get
			{
				if (this.ContainsItem("subtype"))
					return (TextureOverlayTypes)CpfItem("subtype").UIntegerValue;
				return TextureOverlayTypes.Beard;
			}
			set { this.SetValue("subtype", Convert.ToUInt32(value)); }
		}

		[Category("General")]
		public SkinCategories Category
		{
			get { return (SkinCategories)CpfItem("category").UIntegerValue; }
			set { this.SetValue("category", Convert.ToUInt32(value)); }
		}

		[Category("General")]
		public OutfitType OutfitType
		{
			get {
				if (this.ContainsItem("outfit"))
					return (OutfitType)CpfItem("outfit").UIntegerValue;
				else
					if (this.ContainsItem("parts"))
						return (OutfitType)CpfItem("parts").UIntegerValue;
				return OutfitType.None;
			}
			set {
				this.SetValue("outfit", Convert.ToUInt32(value));
				if (this.Version >= 4)
					this.SetValue("parts", Convert.ToUInt32(value));
			}
		}

		[Category("Genetics")]
		public Guid Skintone
		{
			get { return Utility.ParseGuid(CpfItem("skintone")); }
			set { this.SetValue("skintone", value.ToString()); }
		}

		internal uint OverrideCount
		{
			get { return CpfItem("numoverrides").UIntegerValue; }
		}

		[Category("Advanced")]
		public List<OverrideItem> OverrideList
		{
			get
			{
				if (this.overrides == null)
				{
					this.overrides = new List<OverrideItem>();
					uint count = this.CpfItem("numoverrides").UIntegerValue;
					for (int i = 0; i < count; i++)
					{
						OverrideItem item = new OverrideItem();
						item.Shape = this.CpfItem(String.Format("override{0}shape", i)).UIntegerValue;
						item.ResourceKeyIndex = this.CpfItem(String.Format("override{0}resourcekeyidx", i)).UIntegerValue;
						item.Subset = this.CpfItem(String.Format("override{0}subset", i)).StringValue;

						this.overrides.Add(item);
					}
				}
				return this.overrides;
			}
		}

		[Category("Advanced")]
		public List<MaterialDefinitionInfo> MaterialDefinitions
		{
			get
			{
				if (this.materials == null)
				{
					RefFile refFile = this.ReferenceFile;
					if (refFile != null)
					{
						this.materials = new List<MaterialDefinitionInfo>();
						try
						{
							if (this.OverrideList.Count > 0)
							{
								//foreach (IPackedFileDescriptor pfd in refFile.Items)
								foreach (OverrideItem item in this.OverrideList)
								{
									IPackedFileDescriptor pfd = refFile.Items[item.ResourceKeyIndex];
									if (pfd.Type == Utility.DataType.TXMT)
									{
										MaterialDefinitionInfo rcol = this.GetMaterialInfo(pfd);
										if (rcol != null)
											this.materials.Add(rcol);
									}
									else
									{
										// oops, there's some error in the Cpf!!
									}

								}
							}


						}
						catch
						{
						}
					}
				}

				return this.materials;
			}
		}


		public TextureOverlayInfo()
		{
		}

		public TextureOverlayInfo(Cpf propertySet)
		{
			this.PropertySet = propertySet;
		}

		public override void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd)
		{
			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package);
		}

		protected MaterialDefinitionInfo GetMaterialInfo(IPackedFileDescriptor pfd)
		{
			IScenegraphFileIndexItem[] sfItems = FileTableBase.FileIndex.FindFile(pfd, null);
			if (sfItems.Length > 0)
			{
				MaterialDefinitionInfo ret = new MaterialDefinitionInfo(sfItems[0]);
				return ret;
			}
			return null;
		}

		public override void CommitChanges()
		{
			if (this.overrides != null)
			{
				for (int i = 0; i < this.overrides.Count; i++)
				{
					OverrideItem item = this.overrides[i];
					this.SetValue(String.Format("override{0}shape", i), item.Shape);
					this.SetValue(String.Format("override{0}resourcekeyidx", i), item.ResourceKeyIndex);
					this.SetValue(String.Format("override{0}subset", i), item.Subset);
				}

				this.SetValue("numoverrides", (uint)this.overrides.Count);
			}
			base.CommitChanges();
		}

		public sealed class OverrideItem
		{
			uint shape;

			public uint Shape
			{
				get { return shape; }
				set { shape = value; }
			}

			string subset;

			public string Subset
			{
				get { return subset; }
				set { subset = value; }
			}

			uint resourcekeyindex;

			public uint ResourceKeyIndex
			{
				get { return resourcekeyindex; }
				set { resourcekeyindex = value; }
			}

			public OverrideItem()
			{
			}

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
		None = 0x0000,
		Hair = 0x0001,
		Face = 0x0002,
		
		Top = 0x0004,
		Body = 0x0008,
		Bottom = 0x0010,

		Tail = 0x0040,
		Ears = 0x0200
	}

}
