using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using SimPe.Data;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{

	[Serializable]
	public class PackageSettings : IPackageSettings, IXmlSerializable
	{
		bool disableOriginal = true;
		bool outputSingle;
		bool pinheadMode = true;
		Guid familyGuid;
		string description;
		bool flagHidden;
		bool reCompressTextures;
		bool renameFiles = true;
		bool reusePackages = true;
		RecolorType mode = RecolorType.Unsupported;
		StringCollection ngbhFileList;
	

		[Category("Output")]
		public bool DisableOriginalPackages
		{
			get { return this.disableOriginal; }
			set { this.disableOriginal = value; }
		}

		[Category("Output")]
		public bool GenerateSinglePackage
		{
			get { return this.outputSingle; }
			set { this.outputSingle = value; }
		}

		[Category("Output")]
		public bool CompressTextures
		{
			get { return this.reCompressTextures; }
			set { this.reCompressTextures = value; }
		}

		[Category("Output")]
		public bool RenameFiles
		{
			get { return this.renameFiles; }
			set { this.renameFiles = value; }
		}


		[Category("Output")]
		public bool ReusePackages
		{
		  get { return this.reusePackages; }
		  set { this.reusePackages = value; }
		}

		[Category("Package")]
		public Guid FamilyGuid
		{
			get { return this.familyGuid; }
			set { this.familyGuid = value; }
		}

		[Category("Output")]
		public bool KeepDisabledItems
		{
			get { return this.pinheadMode; }
			set { this.pinheadMode = value; }
		}

		[Category("Package")]
		public string Description
		{
			get { return this.description; }
			set { this.description = value; }
		}

		[Category("Package")]
		public bool HideFromCatalog
		{
			get { return this.flagHidden; }
			set { this.flagHidden = value; }
		}

		[Category("Neighborhood")]
		public StringCollection ScanNGBHFiles
		{
			get
			{
				if (this.ngbhFileList == null)
					this.ngbhFileList = new StringCollection();
				return this.ngbhFileList;
			}
		}

		public virtual RecolorType PackageType
		{
			get { return this.mode; }
		}

		public PackageSettings()
		{
		}

		public PackageSettings(PackageSettings settings)
		{
			if (settings != null)
			{
				this.description = settings.description;
				this.disableOriginal = settings.disableOriginal;
				this.familyGuid = settings.familyGuid;
				this.flagHidden = settings.flagHidden;
				this.mode = settings.mode;
				this.outputSingle = settings.outputSingle;
				this.pinheadMode = settings.pinheadMode;
				this.renameFiles = settings.renameFiles;
				this.reusePackages = settings.reusePackages;
				this.reCompressTextures = settings.reCompressTextures;
				if (!Utility.IsNullOrEmpty(settings.ngbhFileList))
					foreach (string s in settings.ngbhFileList)
						this.ScanNGBHFiles.Add(s);
			}
		}


		public PackageSettings(PackageSettings settings, RecolorType type) : this(settings)
		{
			this.mode = type;
		}

		#region IXmlSerializable Members

		public virtual void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("Output");

			PropertyInfo[] props = this.GetType().GetProperties();
			foreach (PropertyInfo prop in props)
			{
				foreach (CategoryAttribute cat in prop.GetCustomAttributes(typeof(CategoryAttribute), true))
				{
					if (String.Compare(cat.Category, "Output", true) == 0)
					{
						writer.WriteStartElement(prop.Name);
						writer.WriteString(Convert.ToString(prop.GetValue(this, null)));
						writer.WriteEndElement();
					}
				}
			}

			writer.WriteEndElement();
		}

		System.Xml.Schema.XmlSchema IXmlSerializable.GetSchema()
		{
			return null;
		}

		public virtual void ReadXml(XmlReader reader)
		{
			reader.MoveToContent();

			while (reader.Read())
			{
				if (
					reader.NodeType == XmlNodeType.Element && 
					!reader.IsEmptyElement
					)
				{
					try 
					{
						string val = reader.ReadString();
						PropertyInfo prop = this.GetType().GetProperty(reader.Name);
						if (prop != null)
						{
							object o = Convert.ChangeType(val, prop.PropertyType);
							prop.SetValue(this, o, null);
						}
					}
					catch
					{
						// die silently

					}

				}
																															
			}

		}

		#endregion
	}


	public class HairtoneSettings : PackageSettings
	{
		Guid defaultProxy;
		bool isHat;

		/// <summary>
		/// Gets or sets the value that is applied to the proxy property 
		/// of the HairtoneXML resource of custom hair packages.
		/// </summary>
		[Category("Hairtone")]
		public Guid DefaultProxy
		{
			get { return this.defaultProxy; }
			set { this.defaultProxy = value; }
		}


		/// <summary>
		/// Gets or sets a flag indicating if the respective hairtone
		/// package refers to a hat. Used mainly for turn-on / turn-off
		/// in NL.
		/// </summary>
		[Category("Hairtone")]
		public bool IsHat
		{
			get { return this.isHat; }
			set { this.isHat = value; }
		}

		public override RecolorType PackageType
		{
			get { return RecolorType.Hairtone; }
		}


		public HairtoneSettings()
		{
		}

		public HairtoneSettings(PackageSettings settings) : base(settings)
		{
			if (settings is HairtoneSettings)
			{
				this.isHat = ((HairtoneSettings)settings).isHat;
				this.defaultProxy = ((HairtoneSettings)settings).defaultProxy;
			}
		}

	}


	public class SkintoneSettings : PackageSettings
	{
		float genetic;

		[Category("Skintone")]
		public float GeneticWeight
		{
			get { return this.genetic; }
			set { this.genetic = value; }
		}
		
		public override RecolorType PackageType
		{
			get { return RecolorType.Skintone; }
		}


		public SkintoneSettings()
		{
		}

		public SkintoneSettings(PackageSettings settings) : base(settings)
		{
			if (settings is SkintoneSettings)
			{
				this.genetic = ((SkintoneSettings)settings).genetic;
			}
		}

	}

	public class ClothingSettings : PackageSettings
	{
		ShoeType shoe;
		OutfitType outfit;
		SkinCategories category;
		SimGender gender;
		Ages age;
		SpeciesType species;
		TextureOverlayTypes overlayType;

		public TextureOverlayTypes OverlayType
		{
			get { return overlayType; }
			set { overlayType = value; }
		}

		public SpeciesType Species
		{
			get { return species; }
			set { species = value; }
		}

		public ShoeType ShoeType
		{
			get { return this.shoe; }
			set { this.shoe = value; }
		}

		public OutfitType OutfitType
		{
			get { return this.outfit; }
			set { this.outfit = value; }
		}

		public SkinCategories Category
		{
			get { return this.category; }
			set { this.category = value; }
		}

		public SimGender Gender
		{
			get { return this.gender; }
			set { this.gender = value; }
		}

		public Ages Age
		{
			get { return this.age; }
			set { this.age = value; }
		}

		public override RecolorType PackageType
		{
			get { return RecolorType.Skin; }
		}

		public ClothingSettings()
		{
		}

		public ClothingSettings(PackageSettings settings) : base(settings)
		{
			if (settings is ClothingSettings)
			{
				ClothingSettings cSettings = (ClothingSettings)settings;
				this.age = cSettings.age;
				this.category = cSettings.category;
				this.gender = cSettings.gender;
				this.shoe = cSettings.shoe;
				this.outfit = cSettings.outfit;
				this.species = cSettings.species;
			}
		}


	}

	public interface IPackageSettings
	{
		Guid FamilyGuid { get; set; }

		string Description	{ get; set; }

		bool HideFromCatalog { get; set; }

		RecolorType PackageType { get; }

	}


}
