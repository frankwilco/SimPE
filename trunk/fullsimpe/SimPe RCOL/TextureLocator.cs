using System;
using System.Collections;

namespace SimPe.Plugin
{
	/// <summary>
	/// Used to find the Texture for a given Subset
	/// </summary>
	public class TextureLocator : System.IDisposable
	{
		SimPe.Interfaces.Files.IPackageFile package;
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fii;
		public TextureLocator(SimPe.Interfaces.Files.IPackageFile package)
		{
			this.package = package;
			fii = SimPe.FileTable.FileIndex.AddNewChild();

			//fii.AddIndexFromPackage(package);
		}

		/// <summary>
		/// Find the GMND that is referencing the passed gmdc
		/// </summary>
		/// <param name="gmdc"></param>
		/// <param name="flname">null, or the Filename of a package to search in</param>
		/// <returns>null or the found gmnd</returns>
		public Rcol FindReferencingGMND(Rcol gmdc, string flname)
		{
			if (gmdc==null) return null;

			SimPe.Interfaces.Files.IPackageFile lpackage = package;
			if (flname!=null) lpackage = SimPe.Packages.File.LoadFromFile(flname);

			Interfaces.Files.IPackedFileDescriptor[] pfds = lpackage.FindFiles(0x7BA3838C);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				Rcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, lpackage);
				foreach (Interfaces.Files.IPackedFileDescriptor rpfd in rcol.ReferencedFiles) 
				{
					if ((gmdc.FileDescriptor.Group == rpfd.Group) &&
						(gmdc.FileDescriptor.Instance == rpfd.Instance) &&
						(gmdc.FileDescriptor.SubType == rpfd.SubType) &&
						(gmdc.FileDescriptor.Type == rpfd.Type)) 
					{
						return rcol;
					}
				}
			}

			return null;
		}

		/// <summary>
		/// Find the SHPE that is referencing the passed GMND
		/// </summary>
		/// <param name="gmnd"></param>
		/// <param name="flname">null, or the Filename of a package to search in</param>
		/// <returns>null or the first found shpe</returns>
		public Rcol FindReferencingSHPE(Rcol gmnd, string flname)
		{
			if (gmnd==null) return null;

			SimPe.Interfaces.Files.IPackageFile lpackage = package;
			if (flname!=null) lpackage = SimPe.Packages.File.LoadFromFile(flname);

			Interfaces.Files.IPackedFileDescriptor[] pfds = lpackage.FindFiles(0xFC6EB1F7);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				Rcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, lpackage);
				
				Shape shp = (Shape)rcol.Blocks[0];
				foreach (ShapeItem i in shp.Items) 
				{
					if (Hashes.StripHashFromName(i.FileName).Trim().ToLower()==Hashes.StripHashFromName(gmnd.FileName).Trim().ToLower())
					{
						return rcol;
					}
				}
			}

			return null;
		}

		/// <summary>
		/// Find the TXMTs that are referenced by the passed Shape
		/// </summary>
		/// <param name="shpe"></param>
		/// <param name="flname">null, or the Filename of a package to search in</param>
		/// <returns>null or the first found shpe</returns>
		public Hashtable FindReferencedTXMT(Rcol shpe, string flname)
		{
			Hashtable ht = new Hashtable();
			if (shpe==null) return ht;

			SimPe.Interfaces.Files.IPackageFile lpackage = package;
			if (flname!=null) lpackage = SimPe.Packages.File.LoadFromFile(flname);

			Shape shp = (Shape)shpe.Blocks[0];			
			foreach (ShapePart p in shp.Parts) 
			{
				string txmtflname = Hashes.StripHashFromName(p.FileName).Trim().ToLower()+"_txmt";
				string subset = p.Subset.Trim().ToLower();

				Interfaces.Files.IPackedFileDescriptor[] pfds = lpackage.FindFile(txmtflname, 0x49596978);
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, lpackage);

					if (Hashes.StripHashFromName(rcol.FileName).Trim().ToLower()==txmtflname)
					{
						if (!ht.Contains(subset)) ht.Add(subset, rcol);
					}
				}
			}			
			
			return ht;
		}

		/// <summary>
		/// Find the TXTRs that are referenced by the passed TXMTs
		/// </summary>
		/// <param name="txmts"></param>
		/// <param name="flname">null, or the Filename of a package to search in</param>
		/// <returns>null or the first found shpe</returns>
		public Hashtable FindReferencedTXTR(Hashtable txmts, string flname)
		{
			Hashtable ht = new Hashtable();
			if (txmts==null) return ht;

			SimPe.Interfaces.Files.IPackageFile lpackage = package;
			if (flname!=null) lpackage = SimPe.Packages.File.LoadFromFile(flname);

			foreach (string subset in txmts.Keys)
			{
				Rcol rcol = (Rcol)txmts[subset];
				MaterialDefinition txmt = (MaterialDefinition)rcol.Blocks[0];
				string txtrname = Hashes.StripHashFromName(txmt.GetProperty("stdMatBaseTextureName").Value)+"_txtr";
				txtrname = txtrname.Trim().ToLower();
				
				Interfaces.Files.IPackedFileDescriptor[] pfds = lpackage.FindFile(txtrname, 0x1C4A276C);
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					Rcol txtr = new GenericRcol(null, false);
					txtr.ProcessData(pfd, lpackage);

					if (Hashes.StripHashFromName(txtr.FileName).Trim().ToLower()==txtrname)
					{
						if (!ht.Contains(subset)) ht.Add(subset, txtr);
					}
				}
			}
			
			
			return ht;
		}

		/// <summary>
		/// Collec all Material
		/// </summary>
		/// <param name="gmdc">The GMDC File you want to find the Textures for</param>
		/// <returns>The Keys of the Hashtabel are the Subset names and the Values are the TXTR Files</returns>
		public Hashtable FindMaterials(Rcol gmdc)
		{
			Rcol gmnd = this.FindReferencingGMND(gmdc, null);
			Rcol shpe = this.FindReferencingSHPE(gmnd, null);
			Hashtable txmts = this.FindReferencedTXMT(shpe, null);
			return txmts;
		}

		/// <summary>
		/// Collec all Textures
		/// </summary>
		/// <param name="gmdc">The GMDC File you want to find the Textures for</param>
		/// <returns>The Keys of the Hashtabel are the Subset names and the Values are the TXTR Files</returns>
		public Hashtable FindTextures(Rcol gmdc)
		{
			Rcol gmnd = this.FindReferencingGMND(gmdc, null);
			Rcol shpe = this.FindReferencingSHPE(gmnd, null);
			Hashtable txmts = this.FindReferencedTXMT(shpe, null);
			Hashtable txtrs = this.FindReferencedTXTR(txmts, null);
			return txtrs;
		}

		public Hashtable GetMaterials(Hashtable txmts, Ambertation.Scenes.Scene scn)
		{
			Hashtable list = new Hashtable();

			foreach (string s in txmts.Keys) 
			{
				Rcol rcol = (Rcol)txmts[s];
				MaterialDefinition md = (MaterialDefinition)rcol.Blocks[0];

				list[s] = md.ToSceneMaterial(scn, Hashes.StripHashFromName(rcol.FileName));
			}
			return list;
		}

		/// <summary>
		/// Retusn a Hashtable that contains the largest Images of the passed Textures
		/// </summary>
		/// <param name="txtrs"></param>
		/// <returns>The Keys of the Hashtabel are the Subset names, the values contain ImageStreams</returns>
		public Hashtable GetLargestImages(Hashtable txtrs)
		{
			Hashtable list = new Hashtable();
			foreach (string s in txtrs.Keys) 
			{
				Rcol rcol = (Rcol)txtrs[s];
				ImageData id = (ImageData)rcol.Blocks[0];

				id.GetReferencedLifos();
				System.Drawing.Image img = id.LargestTexture.Texture;//null;
				/*foreach (MipMapBlock mmp in id.MipMapBlocks) 
				{
					foreach (MipMap mm in mmp.MipMaps)
					{
						if (mm.Texture!=null) img=mm.Texture;
					}
				}*/

				
				if (img!=null) 
				{
					//img.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
					System.IO.MemoryStream ms = new System.IO.MemoryStream();
					img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
					ms.Seek(0, System.IO.SeekOrigin.Begin);
					list.Add(s, ms);
				}
			}

			return list;
		}
		#region IDisposable Member

		public void Dispose()
		{
			SimPe.FileTable.FileIndex.RemoveChild(fii);
			fii.Clear();
		}

		#endregion
	}
}
