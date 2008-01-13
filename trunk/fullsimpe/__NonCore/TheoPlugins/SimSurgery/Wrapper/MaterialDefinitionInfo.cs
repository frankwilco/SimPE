using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Plugin.Helper;
using SimPe.Data;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin.Wrapper
{
	public class MaterialDefinitionInfo : AbstractRcolInfo
	{
		MaterialDefinition mmatd;
		List<string> textureNames;
		List<Guid> layerGuids;

		public MaterialDefinition MaterialDefinition
		{
			get
			{
				if (this.mmatd == null)
				{
					if (!Utility.IsNullOrEmpty(this.RcolFile.Blocks))
						this.mmatd = this.RcolFile.Blocks[0] as MaterialDefinition;
				}
				return this.mmatd;
			}
		}

		public string BaseTextureName
		{
			get	{	return this.GetProperty("stdMatBaseTextureName");	}
			set	{	this.SetProperty("stdMatBaseTextureName", value);	}
		}

		public string NormalMapTextureName
		{
			get	{ return this.GetProperty("stdMatNormalMapTextureName"); }
			set	{ this.SetProperty("stdMatNormalMapTextureName", value); }
		}

		protected int TextureCount
		{
			get
			{
				string prop = this.GetProperty("numTexturesToComposite");
				if (prop != null)
					return Convert.ToInt32(prop);
				return -1;
			}
			set
			{
				this.SetProperty("numTexturesToComposite", value);
			}
		}

		public List<string> TextureNames
		{
			get
			{
				if (this.textureNames == null)
				{
					int count = this.TextureCount;
					this.textureNames = new List<string>(count);
					for (int i = 0; i < count; i++)
					{
						string md = this.GetProperty(String.Format("baseTexture{0}", i));
						if (md != null)
							this.textureNames.Add(md);
						else
							this.textureNames.Add("");
					}
				}
				return this.textureNames;
			}
		}


		protected int OverlayCount
		{
			get
			{
				string prop = this.GetProperty("cafNumOverlays");
				if (prop != null)
					return Convert.ToInt32(prop);
				return -1;
			}
			set
			{
				this.SetProperty("cafNumOverlays", value);
			}
		}

		public List<Guid> OverlayGuids
		{
			get
			{
				if (this.layerGuids == null)
				{
					int count = this.OverlayCount;
					this.layerGuids = new List<Guid>(count);
					for (int i = 0; i < count; i++)
					{
						string md = this.GetProperty(String.Format("cafOverlay{0}", i));
						if (md != null)
						{
							if (md.EndsWith(","))
								md = md.Remove(md.Length - 1);
							this.layerGuids.Add(Utility.ParseGuid(md));
						}
						else
							this.layerGuids.Add(Guid.Empty);
					}

				}
				return this.layerGuids;
			}
		}

		public Guid Skintone
		{
			get { return Utility.ParseGuid(GetProperty("cafSkinTone")); }
			set { this.SetProperty("cafSkinTone", value); }
		}

		public Guid Hairtone
		{
			get	{ return Utility.ParseGuid(GetProperty("cafHairTone")); }
			set	{	this.SetProperty("cafHairTone", value); }
		}

		public Ages Age
		{
			get
			{
				try {
					uint age = 1u << Convert.ToInt32(this.GetProperty("paramAge"));
					return (Ages)age;
				}
				catch {
				}
				return (Ages)0;
			}
		}

		public SimGender Gender
		{
		  get
		  {
				// LOL
				uint gender = Convert.ToUInt32(this.GetProperty("paramGender"));
				switch (gender)
				{
					case 0:
						return SimGender.Male;

					case 1:
						return SimGender.Female;
				}
				return SimGender.Unspecified;
		  }
		}

		protected string CompositeBaseTextureName
		{
			get { return this.GetProperty("compositeBaseTextureName"); }
			set	{ this.SetProperty("compositeBaseTextureName", value); }
		}


		protected string GetProperty(string name)
		{
			if (this.MaterialDefinition != null)
			{
				MaterialDefinitionProperty md = this.MaterialDefinition.GetProperty(name);
				if (md != null)
					return md.Value;
			}
			return null;
		}

		protected void SetProperty(string name, object value)
		{
			if (this.MaterialDefinition != null)
			{
				MaterialDefinitionProperty md = new MaterialDefinitionProperty();
				md.Name = name;
				md.Value = Convert.ToString(value);

				this.MaterialDefinition.Add(md);
				/*
				this.MaterialDefinition.GetProperty(name);
				if (md != null)
					md.Value = Convert.ToString(value);
				*/
			}
		}

		public MaterialDefinitionInfo(GenericRcol rcol) : base(rcol)
		{
		}

		public MaterialDefinitionInfo(IPackedFileDescriptor pfd, IPackageFile package) : base(new GenericRcol())
		{
			this.RcolFile.ProcessData(pfd, package);
		}

		public MaterialDefinitionInfo(IScenegraphFileIndexItem item) : base(new GenericRcol())
		{
			this.RcolFile.ProcessData(item, false);
		}

		public override void CommitChanges()
		{
			this.UpdateTextureList();

			this.UpdateOverlayGuidList();

			this.UpdateCompositeTextureName();

			base.CommitChanges();
		}


		void UpdateCompositeTextureName()
		{
			bool change = true;
			StringBuilder txmtname = new StringBuilder();
			for (int i = 0; i < this.TextureNames.Count; i++)
			{
				string name = this.TextureNames[i];
				if (!name.EndsWith("_txtr", StringComparison.InvariantCultureIgnoreCase))
					name += "_txtr";
				name = Utility.FindTxtrName(name);

				if (name.Length == 0)
					change = false;

				if (i != 0)
					txmtname.Append("_");
				txmtname.Append(name);
			}

			if (change)
			{
				this.CompositeBaseTextureName = txmtname.ToString();

				this.MaterialDefinition.Listing = new string[] {
					txmtname.ToString()
				};
			}

		}

		void UpdateOverlayGuidList()
		{
			this.OverlayCount = this.OverlayGuids.Count;
			for (int i = 0; i < this.OverlayGuids.Count; i++)
				this.SetProperty(
					String.Format("cafOverlay{0}", i),
					String.Format("{0},", this.OverlayGuids[i])
					);
		}

		void UpdateTextureList()
		{
			this.TextureCount = this.TextureNames.Count;
			for (int i = 0; i < this.TextureNames.Count; i++)
				this.SetProperty(
					String.Format("baseTexture{0}", i),
					this.TextureNames[i]
					);
		}

		#region Helper methods

		public static List<MaterialDefinitionInfo> FindMaterials(IPackageFile package)
		{
			List<MaterialDefinitionInfo> ret = new List<MaterialDefinitionInfo>();

			IPackedFileDescriptor[] pfds = package.FindFiles(Utility.DataType.TXMT);
			foreach (IPackedFileDescriptor pfd in pfds)
				ret.Add(new MaterialDefinitionInfo(pfd, package));

			return ret;
		}

		public static MaterialDefinitionInfo FindMaterial(List<MaterialDefinitionInfo> list, Ages age, SimGender gender)
		{
			if (Utility.IsNullOrEmpty(list))
				return null;

			MaterialDefinitionInfo ret = null;

			foreach (MaterialDefinitionInfo md in list)
			{
				ret = md;
				if (
					(md.Age == age) &&
					(md.Gender == gender)
					)
					break;
			}

			return ret;
		}

		#endregion


	}
}
