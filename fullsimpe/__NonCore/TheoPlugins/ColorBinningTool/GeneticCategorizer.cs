/***************************************************************************
 *   Copyright (C) 2006 Theophilus A. Gottlieb                             *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;

using SimPe.Data;
using SimPe.Events;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using System.Collections.Generic;

namespace SimPe.Plugin
{
	/// <summary>
	/// A big mess
	/// </summary>
	public class GeneticCategorizer : System.ComponentModel.Component
	{
		PackageInfoTable packages;
		ListDictionary recolorItems;
		Hashtable loadedFiles;
		PackageSettings settings;
		SimDNASanitizer dnaTool;

		public PackageSettings Settings
		{
			get {
				return this.settings;
			}
			set {
				this.settings = value;
			}
		}

		public bool IsEmpty
		{
			get { return this.packages.Count == 0; }
		}

		public GeneticCategorizer()
		{
			this.dnaTool = new SimDNASanitizer();
			this.packages = new PackageInfoTable();
			this.recolorItems = new ListDictionary();
			this.loadedFiles = new Hashtable();
			//this.settings = new PackageSettings();
		}

		public GeneticCategorizer(System.ComponentModel.IContainer container) : this()
		{
			if (container != null)
				container.Add(this);

			
		}

		public bool AddPackage(HairColor key, string fileName)
		{
			bool ret = false;
			GeneratableFile file = File.LoadFromFile(fileName, true);
			if (ret = this.AddPackage(key, file))
			{
				this.loadedFiles[key] = fileName;
			}
			return ret;
		}

		PackageSettings GetSettings(RecolorType type)
		{
			PackageSettings ret = null;
			switch (type)
			{
				case RecolorType.Hairtone:
					ret = new HairtoneSettings(this.settings);
					break;

				case RecolorType.Skintone:
					ret = new SkintoneSettings(this.settings);
					break;
/*
				case RecolorType.Skin:
					ret = new ClothingSettings(this.settings);
					break;
*/
				default:
					ret = new PackageSettings(this.settings, type);
					break;
			}
			
			return ret;
		}

		protected virtual bool AddPackage(HairColor key, IPackageFile package)
		{
			if (package != null)
			{
				if (!this.packages.ContainsKey(key))
				{
					// I am shameless, I am ashamed!
					IPackageFile package_clone = null;

					if (!this.settings.ReusePackages)
					{
						package_clone = package.Clone();

						// just testing...
						((File)package_clone).FileName = package.FileName;

						if (package is IDisposable)
							((IDisposable)package).Dispose();
						else
							package.Close();
					}
					else
					{
						package_clone = package;
					}

					PackageInfo pnfo = new PackageInfo(package_clone);
					this.packages.Add(key, pnfo);
					
					pnfo.RecolorItems = this.GetRecolorItems(key);

					#region Determine package type

					RecolorType newType = RecolorType.Unsupported;
					if (pnfo.PropertySet != null)
					{
						newType = pnfo.Type;
					}
					else
					{
						RecolorItem[] items = this.GetRecolorItems(key);
						foreach (RecolorItem item in items)
						{
							RecolorType type = item.Type;
							if (type != RecolorType.Unsupported)
							{
								newType = type;
								break;
							}
						}

					}

					#endregion

					if (
						this.settings == null ||
						this.settings.PackageType == RecolorType.Unsupported
						)
					{
						this.settings = this.GetSettings(newType);
					}
					else
						if (newType != this.settings.PackageType)
					{
						this.Clear(key);
						Helper.ExceptionMessage(new ApplicationException(String.Format("The package being added is not a {0}", this.settings.PackageType)));
						return false;
					}

					if (pnfo.Package != null)
					{
						if ((pnfo.Flags & PropertySetFlags.HideFromCatalog) == PropertySetFlags.HideFromCatalog)
							this.settings.HideFromCatalog = true;

						if (this.settings is SkintoneSettings)
						{
							((SkintoneSettings)this.settings).GeneticWeight = pnfo.PropertySet.GetSaveItem("genetic").SingleValue;
						}
						else
							if (this.settings is HairtoneSettings)
						{
							((HairtoneSettings)this.settings).IsHat = ((pnfo.Flags & PropertySetFlags.IsHat) == PropertySetFlags.IsHat);
						}

						if (this.settings.FamilyGuid == Guid.Empty)
							this.settings.FamilyGuid = pnfo.Family;

					}

					if (!FileTable.FileIndex.Loaded)
						FileTable.FileIndex.Load();

					FileTable.FileIndex.AddIndexFromPackage(package_clone, false);

					if (Utility.IsNullOrEmpty(this.settings.Description))
						this.settings.Description = pnfo.Description; //this.GetPackageText(key);

					return true;
				}
			}
			return false;
		}


		public void Clear(HairColor key)
		{
			if (this.packages.ContainsKey(key))
			{
				this.packages.RemovePackage(key);
				this.recolorItems.Remove(key);
				this.loadedFiles.Remove(key);
				//this.loadedTextures.Clear();

				if (this.packages.Count == 0)
					this.settings = null; //mode = RecolorType.Unsupported;
			}
		}

		public void Clear()
		{
			this.packages.RemoveAll();
			this.recolorItems.Clear();
			this.loadedFiles.Clear();
			//this.loadedTextures.Clear();
			this.settings = null; //.mode = RecolorType.Unsupported;
		}

		public bool Contains(HairColor key)
		{
			return this.packages.ContainsKey(key);
		}

		public bool MovePackage(HairColor currentKey, HairColor newKey)
		{

			if (
				this.packages.ContainsKey(currentKey) &&
			 !this.packages.ContainsKey(newKey)
				)
			{
				this.packages.Add(newKey, this.packages[currentKey]);
				this.packages.Remove(currentKey);

				if (this.loadedFiles[currentKey] != null)
				{
					this.loadedFiles.Add(newKey, this.loadedFiles[currentKey]);
					this.loadedFiles.Remove(currentKey);
				}

				if (this.recolorItems[currentKey] != null)
				{
					this.recolorItems.Add(newKey, this.recolorItems[currentKey]);
					this.recolorItems.Remove(currentKey);

					foreach (RecolorItem item in this.GetRecolorItems(newKey))
					{
						bool greyRecolor = (item.Age == Ages.Elder ^ newKey == HairColor.Grey) &&	newKey != HairColor.Custom;
						if (!greyRecolor)
							item.ColorBin = newKey;
						else
							item.ColorBin = HairColor.Grey;
					}

				}
				
				this.loadedTextures.Clear();

				return true;
			}

			return false;
		}

		public RecolorItem[] GetRecolorItems(HairColor key)
		{
			if (!this.recolorItems.Contains(key))
			{
				ArrayList list = new ArrayList();

				PackageInfo pnfo = this.packages[key];
				if (pnfo != null)
				{
					IPackedFileDescriptor[] files = pnfo.FindFiles(SimPe.Data.MetaData.GZPS);
					if (Utility.IsNullOrEmpty(files))
						files = pnfo.FindFiles(Utility.DataType.XTOL);
					if (Utility.IsNullOrEmpty(files))
						files = pnfo.FindFiles(Utility.DataType.XMOL);

					list.AddRange(ProcessCpfItems(files, pnfo.Package));
				}

				foreach (RecolorItem item in list)
				{
					bool greyRecolor = (item.Age == Ages.Elder ^ key == HairColor.Grey) &&	key != HairColor.Custom;
					if (!greyRecolor)
						item.ColorBin = key;
					else
						item.ColorBin = HairColor.Grey;
				}
				
				this.recolorItems[key] = list.ToArray(typeof(RecolorItem));
			}
		
			return (RecolorItem[])this.recolorItems[key];
		}

		private ArrayList ProcessCpfItems(IPackedFileDescriptor[] cpfs, IPackageFile package)
		{
			ArrayList ret = new ArrayList();
			if (!Utility.IsNullOrEmpty(cpfs))
			{
				int i = -1;
				while (++i < cpfs.Length)
				{
					Cpf cpf = new Cpf();
					IPackedFileDescriptor pfd = cpfs[i];

					cpf.ProcessData(pfd, package);

					RecolorItem item = new RecolorItem(cpf);

					// fix for 0.2.28.3 blunder
					if (item.ContainsItem("subtype"))
					{
						CpfItem ci = item.GetProperty("subtype");
						switch (ci.Datatype)
						{
							case MetaData.DataTypes.dtBoolean:
							case MetaData.DataTypes.dtInteger:
							case MetaData.DataTypes.dtSingle:
							case MetaData.DataTypes.dtString:
							case MetaData.DataTypes.dtUInteger:
								break;

							default:
								List<CpfItem> items = new List<CpfItem>();
								foreach (CpfItem c in item.PropertySet.Items)
									if (c.Name != "subtype")
										items.Add(c);
								item.PropertySet.Items = items.ToArray();
								break;
						}
					} //end fix

					item.Materials.AddRange(this.GetMaterials(package, cpf));
					if (Utility.EnumTest(item.Flags, PropertySetFlags.HideFromCatalog))
						item.Enabled = false;

					ret.Add(item);
				}

			}
			return ret;
		}

		public PackageInfo GetPackageInfo(HairColor key)
		{
			if (this.packages.ContainsKey(key))
				return this.packages[key];
			return null;
		}

		public void RevertToBaseTextures(RcolTable materials)
		{
			ArrayList temp = new ArrayList();
/*
			if (!this.settings.KeepDisabledItems)
			{
				IPackedFileDescriptor[] txmts = GetTextureDescriptor(materials);
				foreach (IPackedFileDescriptor pfd in txmts)
					pfd.MarkForDelete = true;
			}
*/
			foreach (MaterialDefinitionRcol rcol in materials)
			{
				if (rcol.MaterialDefinition != null)
				{
					MaterialDefinition mmatd = rcol.MaterialDefinition;

					if (!Utility.IsNullOrEmpty(mmatd.Listing))
					{
						string baseTextureName = mmatd.Listing[0];

						if (mmatd.Listing.Length == 1)
						{
							string newTextureName = this.NewTextureName(baseTextureName, rcol.ColorBin);
							rcol.BaseTextureName = newTextureName;
						}
						else
						{
							string newTextureName = this.NewTextureName(mmatd.Listing[1], rcol.ColorBin);
							rcol.NormalMapTextureName = baseTextureName;
							rcol.BaseTextureName = newTextureName;
						}

						this.ReloadTextureDescriptor(rcol);

					}

				}

			}


		}


		string NewTextureName(string baseTextureName, HairColor key)
		{
			if (key == HairColor.Custom)
				return baseTextureName;

			string[] parts = baseTextureName.Split('-');
			System.Text.StringBuilder str = new System.Text.StringBuilder();
			for (int i = 0; i < parts.Length - 1; i++)
			{
				str.Append(parts[i]);
				str.Append("-");
			}
			str.Append(key.ToString().ToLower());

			return str.ToString();
		}


		public IPackedFileDescriptor[] GetTextureDescriptor(RcolTable table)
		{
			ArrayList ret = new ArrayList();

			foreach (Rcol rcol in table)
			{
				IPackedFileDescriptor[] txtr = GetTextureDescriptor(rcol);
				if (!Utility.IsNullOrEmpty(txtr))
					ret.AddRange(txtr);

			}
			return (IPackedFileDescriptor[])ret.ToArray(typeof(IPackedFileDescriptor));
		}


		IScenegraphFileIndexItem FindFileByReference(IPackedFileDescriptor reference)
		{
			if (!FileTable.FileIndex.Loaded)
				FileTable.FileIndex.Load();

			IScenegraphFileIndexItem ret = null;

			// find in local packages
			foreach (DictionaryEntry de in this.packages)
			{
				object key = de.Key;
				PackageInfo pnfo = de.Value as PackageInfo;

				IPackedFileDescriptor local = pnfo.Package.FindFile(reference.Type, reference.SubType, reference.Group, reference.Instance);
				if (local != null)
				{
					ret = new FileIndexItem(local, pnfo.Package);
					break;
				}


			}

			if (ret == null)
			{
				// find in all packages
				IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileByGroupAndInstance(reference.Group, reference.LongInstance);
				if (!Utility.IsNullOrEmpty(items))
				{
					foreach (IScenegraphFileIndexItem sfi in items)
					{
						if (sfi.FileDescriptor.Type == reference.Type)
						{
							ret = sfi;
							break;
						}
					}

				}

			}

			if (ret == null)
			{
				IScenegraphFileIndexItem[] sfi = FileTable.FileIndex.FindFileDiscardingGroup(reference); //, pnfo.Package);
				if (!Utility.IsNullOrEmpty(sfi))
					ret = sfi[0];
			}


			return ret;
		}

		public System.Drawing.Image GetImage(Rcol rcol, System.Drawing.Size size)
		{

			MaterialDefinitionRcol txmt = rcol as MaterialDefinitionRcol;
			if (txmt != null)
			{
				if (!Utility.IsNullOrEmpty(txmt.Textures))
				{
					Txtr txtr = txmt.Textures[0] as Txtr;
					if (!Utility.IsNullOrEmpty(txtr.Blocks))
					{
						ImageData data1 = (ImageData)txtr.Blocks[0];
						MipMap map1 = data1.GetLargestTexture(size);
						if (map1.Texture != null)
						{
							return ImageLoader.Preview(map1.Texture, size);
						}
					}
				}
			}

			return null;
		}

		public Rcol[] GetMaterials(IPackageFile package, Cpf cpf)
		{
			ArrayList ret = new ArrayList();

			ResourceReference[] rrs = this.FindTXMTReferences(package, cpf.FileDescriptor.Group, cpf.FileDescriptor.Instance);
			foreach (ResourceReference rr in rrs)
			{
				IPackedFileDescriptor pfd = package.FindFile(rr.Type, rr.SubType, rr.Group, rr.Instance);
				if (pfd != null)
				{
					MaterialDefinitionRcol rcol = new MaterialDefinitionRcol(); // GenericRcol(null, false);
					
					rcol.ProcessData(pfd, package, false);

					this.ReloadTextureDescriptor(rcol);
					
					ret.Add(rcol);

				}

			}

			return (Rcol[])ret.ToArray(typeof(Rcol));
		}

		public void ReloadTextureDescriptor(MaterialDefinitionRcol rcol)
		{
			rcol.Textures.Clear();
			rcol.Textures.AddRange(this.GetMaterialTextures(rcol));
		}

		public IPackedFileDescriptor[] GetTextureDescriptor(Rcol rcol)
		{
			MaterialDefinitionRcol mmat = rcol as MaterialDefinitionRcol;
			if (mmat != null)
				return mmat.Textures.GetFileDescriptor();
			return new IPackedFileDescriptor[0];
		}

		Hashtable loadedTextures = new Hashtable();

		public Rcol[] GetMaterialTextures(MaterialDefinitionRcol rcol)
		{
			ArrayList ret = new ArrayList();

			Hashtable table = rcol.GetTextureDescriptor();

			IPackedFileDescriptor pfdBaseTexture = table[TextureType.Base] as IPackedFileDescriptor;
			if (pfdBaseTexture != null)
			{
				ResourceReference key = new ResourceReference(pfdBaseTexture);

				IScenegraphFileIndexItem item = this.FindFileByReference(pfdBaseTexture);
				if (item != null)
				{
					Txtr txtr = null;
					if (!this.loadedTextures.ContainsKey(key))
					{
						txtr = new Txtr(null, false);
						txtr.ProcessData(item.FileDescriptor, item.Package, false);
						this.loadedTextures.Add(key, txtr);
					}
					else
						txtr = this.loadedTextures[key] as Txtr;
					ret.Add(txtr);
				}
			}

			if (table.ContainsKey(TextureType.NormalMap))
			{
				IPackedFileDescriptor pfdNormalMapTexture = table[TextureType.NormalMap] as IPackedFileDescriptor;
				if (pfdNormalMapTexture != null)
				{
					ResourceReference key = new ResourceReference(pfdNormalMapTexture);

					IScenegraphFileIndexItem item = this.FindFileByReference(pfdNormalMapTexture);
					if (item != null)
					{
						Txtr txtr = null;
						if (!this.loadedTextures.ContainsKey(key))
						{
							txtr = new Txtr(null, false);
							txtr.ProcessData(item.FileDescriptor, item.Package, false);
							this.loadedTextures.Add(key, txtr);
						}
						else
							txtr = this.loadedTextures[key] as Txtr;
						ret.Add(txtr);
					}
				}
			}

			return (Rcol[])ret.ToArray(typeof(Rcol));
		}


		private ResourceReference[] FindTXMTReferences(IPackageFile package, uint refGroup, uint refInstance)
		{
			ArrayList ret = new ArrayList();

			IPackedFileDescriptor[] pfds = Utility.FindFiles(package, Data.MetaData.REF_FILE, refGroup, refInstance);
			if (!Utility.IsNullOrEmpty(pfds))
			{
				// we're not even trying to touch these, so let's just release
				// their resources after we take a peek...
				using (RefFile refFile = new RefFile()) 
				{
					foreach (IPackedFileDescriptor pfd in pfds) // there should be only one!
					{
						try {
							refFile.ProcessData(pfd, package, false);
							foreach (IPackedFileDescriptor ptr in refFile.Items)
								if (ptr.Type == SimPe.Data.MetaData.TXMT)
									ret.Add(new ResourceReference(ptr));
						}
						catch {
						}
						finally {
							refFile.Package = null;
							refFile.FileDescriptor = null;
						}
					}

				} //using

			}
			return (ResourceReference[])ret.ToArray(typeof(ResourceReference));
		}


		IPackedFileDescriptor Get3IDRResource(RecolorItem item)
		{
			if (item.PropertySet != null)
			{
				IPackedFileDescriptor[] pfds = Utility.FindFiles(item.PropertySet.Package, Data.MetaData.REF_FILE, item.PropertySet.FileDescriptor.Group, item.PropertySet.FileDescriptor.Instance);
				if (pfds.Length == 1)
					return pfds[0];
			}
			return null;
		}



		protected void SanitizeFilenames(PackageInfo pnfo)
		{

			foreach (RecolorItem item in pnfo.RecolorItems)
			{
				foreach (MaterialDefinitionRcol txmt in item.Materials)
				{
					txmt.FileName = String.Format("#0x{0:x8}!{1}", pnfo.PackageHash, Hashes.StripHashFromName(txmt.FileName));

					foreach (Txtr txtr in txmt.Textures)
					{
						try 
						{
							txtr.FileName = String.Format("#0x{0:x8}!{1}", pnfo.PackageHash, Hashes.StripHashFromName(txtr.FileName));
						}
						catch (Exception x)
						{
							x.GetType();
						}
						finally
						{
						}
					}
				
				}
				
			}

		}


		/// <summary>
		/// This is where color binning happens...
		/// </summary>
		/// <param name="key">The color key to categorize</param>
		/// <returns></returns>
		protected virtual GeneratableFile ProcessPackage(HairColor key)
		{
			GeneratableFile ret = null;
			
			PackageInfo pnfo = this.packages[key];
			if (pnfo != null)
			{
				//Experimental
				//this.SanitizeFilenames(pnfo);
				ret = pnfo.Package as GeneratableFile;
			}
			
			if (ret != null)
			{
				Guid hairtoneGuid = new Guid((uint)key, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				ArrayList keep = new ArrayList();
				ArrayList discard = new ArrayList();

				RecolorItem[] items = this.GetRecolorItems(key);
				foreach (RecolorItem item in items)
				{
					item.Pinned = this.settings.KeepDisabledItems || this.settings.HideFromCatalog;

					// used to check if a given set of textures can be deleted
					IPackedFileDescriptor[] txtr = GetTextureDescriptor(item.Materials);
					
					if (item.Enabled || item.Pinned)
					{
						keep.AddRange(txtr);
						foreach (IPackedFileDescriptor pfd in txtr)
							if (discard.Contains(pfd))
								discard.Remove(pfd);
					}
					else
					{
						foreach (IPackedFileDescriptor pfd in txtr)
							if (!keep.Contains(pfd))
								discard.Add(pfd);
					}

					item.Family = this.settings.FamilyGuid;

					
					switch (this.settings.PackageType)
					{

						// this is the hairtone processing
						case RecolorType.Hairtone:
						case RecolorType.TextureOverlay:
						case RecolorType.MeshOverlay:

							if (
								(
								item.Type == RecolorType.TextureOverlay ||
								item.Type == RecolorType.MeshOverlay
								) && 
								(
								item.TextureOverlayType != TextureOverlayTypes.EyeBrow &&
								item.TextureOverlayType != TextureOverlayTypes.Beard)
								)
								goto default;

							if (key == HairColor.Custom)
								hairtoneGuid = item.Family;

							// special case
							// TODO: re-check conditions
							if (
								item.Age == SimPe.Data.Ages.Elder &&
								key != HairColor.Custom
								)
								item.Hairtone = Utility.HairtoneGuid.Grey;
							else
								item.Hairtone = hairtoneGuid;

							#region New name
							string oldName = item.Name;
							System.Text.StringBuilder str = new System.Text.StringBuilder();
							str.Append(oldName.Split('_')[0]);
							str.Append("_");
							// special case (again)
							if (item.Age == SimPe.Data.Ages.Elder)
								str.Append(HairColor.Grey.ToString().ToLower());
							else
								str.Append(key.ToString().ToLower());
							item.Name = str.ToString();
							#endregion

							break;

						/* it's done in the UI :P
						
						case RecolorType.Skin:
							ClothingSettings cset = (ClothingSettings)this.settings;
							item.Age = cset.Age;
							item.Gender = cset.Gender;
							item.SetValue("outfit", Convert.ToInt32(cset.OutfitType));
							item.SetValue("category", Convert.ToUInt32(cset.Category));
							item.SetValue("shoe", Convert.ToUInt32(cset.ShoeType));

							break;
*/
						default:
							break;
					}

					// global hide from catalog.
					if (this.settings.HideFromCatalog)
					{
						item.Pinned = true;
						item.Enabled = false;
					}

					// process textures
					if (this.settings.CompressTextures)
						foreach (MaterialDefinitionRcol mmat in item.Materials)
							foreach (Txtr textr in mmat.Textures)
								if (textr.Package == pnfo.Package) // this is important!!
									textr.FileDescriptor.MarkForReCompress = true;


					item.CommitChanges();
				}

				// textures deemed unnecessary are now marked for deletion
				IPackedFileDescriptor[] textureFiles = ret.FindFiles(SimPe.Data.MetaData.TXTR);
				foreach (IPackedFileDescriptor pfd in textureFiles)
					if (!keep.Contains(pfd))
						pfd.MarkForDelete = true;
				

				if (pnfo.PropertySet != null)
				{
					// could be out of this block,
					// but only makes sense if there
					// is a GZPS to be modified!
					if (this.settings.HideFromCatalog)
					{
						pnfo.Pinned = true;
						pnfo.Enabled = false;
					}

					if (pnfo.Type == RecolorType.Hairtone)
					{
						this.dnaTool.GuidTable[pnfo.Family] = hairtoneGuid;

						HairtoneSettings hset = (HairtoneSettings)this.settings;

						pnfo.Name = key.ToString();
						if (key != HairColor.Custom)
							pnfo.SetValue("proxy", hairtoneGuid.ToString());
						else
							if (hset.DefaultProxy != Guid.Empty)
							pnfo.SetValue("proxy", hset.DefaultProxy.ToString());

						if (hset.IsHat)
							pnfo.Flags |= PropertySetFlags.IsHat; // | PropertySetFlags.Unknown2;
						else
							pnfo.Flags &= ~PropertySetFlags.IsHat;

						foreach (RecolorItem item in items)
							if (hset.IsHat)
								item.Flags |= PropertySetFlags.IsHat; // | PropertySetFlags.Unknown2);
							else
								item.Flags &= ~PropertySetFlags.IsHat;

					}
					else
						if (pnfo.Type == RecolorType.Skintone)
					{
						SkintoneSettings sset = (SkintoneSettings)this.settings;
						pnfo.PropertySet.GetItem("genetic").SingleValue = sset.GeneticWeight;
					}

					pnfo.Family = this.settings.FamilyGuid;
				
				}

				pnfo.Description = this.settings.Description;
				
				pnfo.CommitChanges();
			}
			return ret;
		}


		/// <summary>
		/// Processes all color keys and saves the files,
		/// abiding by the output options :)
		/// </summary>
		/// <param name="fileName"></param>
		/// <returns></returns>
		public int ProcessPackages(string fileName)
		{
			int ret = 0;
			Array values = Enum.GetValues(typeof(HairColor));
			ListDictionary files = new ListDictionary();

			
			// intermediate step: determine which color keys have packages
			int i = -1;
			while (++i < values.Length)
			{
				HairColor key = (HairColor)values.GetValue(i);
				GeneratableFile file = this.ProcessPackage(key);
				if (file != null)
					files.Add(key, file);
			}


			if (this.settings.DisableOriginalPackages && !this.settings.RenameFiles)
				foreach (DictionaryEntry de in files)
				{
					HairColor key = (HairColor)de.Key;
					this.DisablePackage(key);
				}

			if (this.settings.GenerateSinglePackage)
			{
				// create THE output file
				GeneratableFile file = GeneratableFile.LoadFromFile(null);
				foreach (DictionaryEntry de in files)
				{
					GeneratableFile package = de.Value as GeneratableFile;
					foreach (IPackedFileDescriptor pfd in package.Index)
					{
						if (!pfd.MarkForDelete)
						{
							IPackedFile fl = package.Read(pfd);
							IPackedFileDescriptor newpfd = file.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
							newpfd.UserData = fl.UncompressedData;
							newpfd.MarkForReCompress = pfd.MarkForReCompress;
							file.Add(newpfd);
						}
					}
				}

				this.SaveFile(file, fileName); // done!

			}
			else
			{
				// just save each file
				foreach (DictionaryEntry de in files)
				{
					HairColor key = (HairColor)de.Key;
					GeneratableFile package = de.Value as GeneratableFile;
					SaveFile(package, fileName, key);

				}
			}

			if (this.settings.DisableOriginalPackages && this.settings.RenameFiles)
				foreach (DictionaryEntry de in files)
				{
					HairColor key = (HairColor)de.Key;
					this.DisablePackage(key);
				}

			if (!Utility.IsNullOrEmpty(this.settings.ScanNGBHFiles))
				this.RepairDNA();

			return ret;
		}

		private void SaveFile(GeneratableFile file, string fileName, HairColor key)
		{
			string filename = Convert.ToString(this.loadedFiles[key]);
			if (this.settings.RenameFiles)
			{
				// generate new name
				filename = String.Format("{0}_{1}.package", System.IO.Path.GetFileNameWithoutExtension(fileName), key);
			}

			this.SaveFile(file, filename);
		}

		private void SaveFile(GeneratableFile file, string fileName)
		{
			using (file)
			{
				file.Save(fileName);
			}
			StreamFactory.CloseStream(fileName);
		}

		private void DisablePackage(HairColor key)
		{
			string originalFilePath = "";
			try
			{
				originalFilePath = Convert.ToString(this.loadedFiles[key]);
				if (
					System.IO.Path.GetExtension(originalFilePath) != DisabledPackageFileExtension &&
					System.IO.File.Exists(originalFilePath)
					)
					System.IO.File.Move(originalFilePath, System.IO.Path.ChangeExtension(originalFilePath, DisabledPackageFileExtension));
			}
			catch (Exception x)
			{
				Helper.ExceptionMessage("Cannot move file " + originalFilePath, x);
			}

		}

		const string DisabledPackageFileExtension = ".packagedisabled";

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				// dispose loaded package files
				foreach (PackageInfo file in this.packages.Values)
					file.Dispose();
				this.Clear();
			}
			base.Dispose (disposing);
		}

		protected void RepairDNA()
		{

			foreach (string filename in this.settings.ScanNGBHFiles)
			{
				LoadedPackage package = new LoadedPackage();
				package.LoadFromFile(filename);

				ResourceEventArgs e = new ResourceEventArgs(package);

				this.dnaTool.ExecuteEventHandler(this, e);

				if (this.dnaTool.HasChanges)
					package.Save();

			}

		}

	}


}
