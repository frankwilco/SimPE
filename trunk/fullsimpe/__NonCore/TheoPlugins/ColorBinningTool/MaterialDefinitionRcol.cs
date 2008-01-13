using System;
using System.Collections;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{
	public class MaterialDefinitionRcol : GenericRcol
	{
		RcolTable textures;
		MaterialDefinition mmatd;
		HairColor colorBin;

		public RcolTable Textures
		{
			get {
				if (this.textures == null)
					this.textures = new RcolTable();
				return this.textures;
			}
			set { this.textures = value; }
		}


		public MaterialDefinition MaterialDefinition
		{
			get { 
				if (this.mmatd == null)
				{
					if (!Utility.IsNullOrEmpty(this.Blocks))
						this.mmatd = this.Blocks[0] as MaterialDefinition;
				}
				return this.mmatd;
			}
		}

		public HairColor ColorBin
		{
			get { return this.colorBin; }
			set { this.colorBin = value; }
		}


		public string BaseTextureName
		{
			get 
			{
				if (this.MaterialDefinition != null)
					return this.mmatd.GetProperty("stdMatBaseTextureName").Value;
				return String.Empty;
			}
			set
			{
				if (this.MaterialDefinition != null)
					this.mmatd.GetProperty("stdMatBaseTextureName").Value = value;
			}
		}


		public string NormalMapTextureName
		{
			get 
			{
				if (this.MaterialDefinition != null)
					return mmatd.GetProperty("stdMatNormalMapTextureName").Value;
				return String.Empty;
			}
			set
			{
				if (this.MaterialDefinition != null)
					mmatd.GetProperty("stdMatNormalMapTextureName").Value = value;
			}
		}


		public MaterialDefinitionRcol()
		{
		}


		public Hashtable GetTextureDescriptor()
		{
			Hashtable ret = new Hashtable();

			if (this.ReferenceChains.ContainsKey("stdMatBaseTextureName"))
			{
				ArrayList list = this.ReferenceChains["stdMatBaseTextureName"] as ArrayList;
				if (!Utility.IsNullOrEmpty(list))
				{
					IPackedFileDescriptor pfd = list[0] as IPackedFileDescriptor;
					if (pfd != null)
						ret.Add(TextureType.Base, pfd);
				}
			}

			if (this.ReferenceChains.ContainsKey("stdMatNormalMapTextureName"))
			{
				ArrayList list = this.ReferenceChains["stdMatNormalMapTextureName"] as ArrayList;
				if (!Utility.IsNullOrEmpty(list))
				{
					IPackedFileDescriptor pfd = list[0] as IPackedFileDescriptor;
					if (pfd != null)
						ret.Add(TextureType.NormalMap, pfd);
				}

			}

							
			return ret;
		}


		public Hashtable GetTextureDescriptorNames()
		{
			Hashtable ret = new Hashtable();
			
			if (this.MaterialDefinition != null)
				foreach (MaterialDefinitionProperty mmatp in mmatd.Properties)
				{
					if (String.Compare(mmatp.Name, "stdMatBaseTextureName", true) == 0)
						ret.Add(TextureType.Base, mmatp.Value);
					else
						if (String.Compare(mmatp.Name, "stdMatNormalMapTextureName", true) == 0)
						ret.Add(TextureType.NormalMap, mmatp.Value);
				}
			
			return ret;
		}


		public void SetTextureDescriptorNames(Hashtable txtrRef)
		{
			if (this.MaterialDefinition != null)
			{
				foreach (DictionaryEntry de in txtrRef)
				{
					string key = String.Format("stdMat{0}TextureName", de.Key);
					MaterialDefinitionProperty prop = mmatd.GetProperty(key);
					prop.Value = Convert.ToString(de.Value);
				}

			}
		}

	}

	public enum TextureType
	{
		Base,
		NormalMap
	}

}
