/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
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
using SimPe.Packages;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin
{
	/// <summary>
	/// Availalbe Fix Version
	/// </summary>
	public enum FixVersion :byte 
	{
		UniversityReady = 0x00,
		UniversityReady2 = 0x01
	}

	/// <summary>
	/// This class can Fix the Integrity of cloned Objects
	/// </summary>
	public class FixObject : FixGuid
	{

		static ArrayList types;
		FixVersion ver;
		public FixVersion FixVersion 
		{
			get {return ver; }
			set {ver = value; }
		}

		bool rndtr;
		public bool RemoveNonDefaultTextReferences
		{
			get {return rndtr;}
			set {rndtr = value; }
		}

		/// <summary>
		/// Creates a new Instance of this class
		/// </summary>
		/// <param name="package">The package you want to fix the Integrity in</param>
		/// <param name="ver">Fix Version that should be used</param>
		/// <param name="remndeftxt">Remove all Text Links that are not assigned to the Default Language</param>
		public FixObject(IPackageFile package, FixVersion ver, bool remndeftxt) : base (package)
		{
			this.ver = ver;
			this.rndtr = remndeftxt;
			if (types==null) 
			{
				types = new ArrayList();
				types.Add(Data.MetaData.TXMT);
				types.Add(Data.MetaData.TXTR);
				types.Add(Data.MetaData.LIFO);
				types.Add(Data.MetaData.GMND);
				//types.Add(Data.MetaData.MMAT);
			}
		}

		/// <summary>
		/// Returns a unique name tht is still working
		/// </summary>
		/// <param name="name">The existing Name of the Object</param>
		/// <param name="unique">a unique strung that sould be added</param>
		/// <param name="subsetname">the name of the Subset</param>
		/// <param name="ext">true, if you want the _txmt Extension</param>
		/// <returns>the new Name</returns>
		public static string GetUniqueTxmtName(string name, string unique, string subsetname, bool ext)
		{
			name = name.Trim();
			name = RenameForm.ReplaceOldUnique(name, "", false);
			
			if (name.ToLower().EndsWith("_txmt") ) 
				name = name.Substring(0, name.Length-5);
			

			string[] parts = name.Split("_".ToCharArray());
			if (parts.Length>0) 
			{
				//oild method used to assigne the additional Name to the subset Part, now we assign it to the ModelName-Part
				/*
				subsetname = subsetname.Trim().ToLower();
				name = "";
				bool foundsubset = false;
				bool addedunique = false;
				for (int i=0; i<parts.Length; i++) 
				{
					if (i!=0) name += "_";
					name += parts[i];

					if (foundsubset && !addedunique) 
					{
						name += unique;
						addedunique = true;
					}
					
					if (parts[i].ToLower()==subsetname) foundsubset=true;
					
				}
				if (!addedunique) name += unique;				*/

				name = "";
				bool first = true;
				foreach (string s in parts)
				{
					if (!first) name += "_";
					name += s;
					if (first) 
					{
						first = false;
						name += "-"+unique;
					} 
				}	
			} 
			else 
			{
				name += unique;				
			}

			if (ext) name += "_txmt";
			return name;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="map"></param>
		/// <param name="rcol"></param>
		/// <returns></returns>
		protected string FindReplacementName(Hashtable map, Rcol rcol)
		{
			string name = Hashes.StripHashFromName(rcol.FileName.Trim().ToLower());
			string newname = (string)map[name];
			string ext = Data.MetaData.FindTypeAlias(rcol.FileDescriptor.Type).shortname.Trim().ToLower();

			if (newname==null) 
			{
				newname = Hashes.StripHashFromName(name + "_" + ext);
				newname = (string)map[newname];
			}

			if (newname==null) newname = name;
			return newname;
		}

		/// <summary>
		/// Fix a Txtr Reference in the Properties of a TXMT File
		/// </summary>
		/// <param name="name"></param>
		/// <param name="matd"></param>
		void FixTxtrRef(string propname, MaterialDefinition matd, Hashtable map, Rcol rcol)
		{
			string reference = matd.GetProperty(propname).Value.Trim().ToLower();
			string newref = (string)map[Hashes.StripHashFromName(reference)+"_txtr"];

			if (newref!=null) 
			{
				newref = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+Hashes.StripHashFromName(newref);
				matd.GetProperty(propname).Value = newref.Substring(0, newref.Length-5);
			}

			for (int i=0; i<matd.Listing.Length; i++)
			{
				newref = (string)map[Hashes.StripHashFromName(matd.Listing[i].Trim().ToLower())+"_txtr"];
				if (newref!=null) 
				{
					matd.Listing[i] = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+Hashes.StripHashFromName(newref.Substring(0, newref.Length-5));
				}
			}

			string name = Hashes.StripHashFromName(rcol.FileName);
			if (name.Length>5) name = name.Substring(0, name.Length-5);
			matd.FileDescription = name;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="map"></param>
		/// <param name="rcol"></param>
		public void FixResource(Hashtable map, Rcol rcol)
		{
			switch (rcol.FileDescriptor.Type) 
			{
				case Data.MetaData.TXMT: //MATD
				{
					MaterialDefinition matd = (MaterialDefinition)rcol.Blocks[0];
					
					FixTxtrRef("stdMatBaseTextureName", matd, map, rcol);
					FixTxtrRef("stdMatNormalMapTextureName", matd, map, rcol);
					break;
				}

				case Data.MetaData.SHPE: //SHPE
				{
					Shape shp = (Shape)rcol.Blocks[0];
					foreach (ShapeItem item in shp.Items) 
					{
						string newref = (string)map[Hashes.StripHashFromName(item.FileName.Trim().ToLower())];
						if (newref!=null) item.FileName = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+newref;
					}

					foreach (ShapePart part in shp.Parts) 
					{
						string newref = (string)map[Hashes.StripHashFromName(part.FileName.Trim().ToLower())+"_txmt"];
						if (newref!=null) part.FileName = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+newref.Substring(0, newref.Length-5);
					}
					break;
				}

				case Data.MetaData.TXTR: //TXTR
				{
					ImageData id = (ImageData)rcol.Blocks[0];
					foreach (SimPe.Plugin.MipMapBlock mmb in id.MipMapBlocks) 
					{
						foreach (MipMap mm in mmb.MipMaps)
						{
							//this is a Lifo Reference
							if (mm.Texture == null) 
							{
								Interfaces.Files.IPackedFileDescriptor[] pfd = package.FindFile(mm.LifoFile, 0xED534136);
								if (pfd.Length>0) 
								{
									Lifo lifo = new Lifo(null, false);
									lifo.ProcessData(pfd[0], package);
									LevelInfo li = (LevelInfo)lifo.Blocks[0];

									mm.Texture = null;
									mm.Data = li.Data;

									pfd[0].MarkForDelete = true;
								} 
								else 
								{
									string newref = Hashes.StripHashFromName((string)map[mm.LifoFile.Trim().ToLower()]);
									if (newref!=null) mm.LifoFile = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+newref;
								}
							}
						}
					}
					break;
				}

				case Data.MetaData.CRES: //CRES
				{
					ResourceNode rn = (ResourceNode)rcol.Blocks[0];
					string name = Hashes.StripHashFromName(rcol.FileName);

					if (ver==FixVersion.UniversityReady2)
						rn.GraphNode.FileName = name;
					else if (ver==FixVersion.UniversityReady)
						rn.GraphNode.FileName = "##0x1c050000!"+name;

					break;
				}

				case Data.MetaData.GMND: //GMND
				{
					GeometryNode gn = (GeometryNode)rcol.Blocks[0];
					string name = Hashes.StripHashFromName(rcol.FileName);

					if (ver==FixVersion.UniversityReady2)
						gn.ObjectGraphNode.FileName = name;
					else if (ver==FixVersion.UniversityReady)
						gn.ObjectGraphNode.FileName = "##0x1c050000!"+name;

					break;
				}

				case Data.MetaData.LDIR:
				case Data.MetaData.LAMB:
				case Data.MetaData.LPNT:
				case Data.MetaData.LSPT: 
				{
					DirectionalLight dl = (DirectionalLight)rcol.Blocks[0];
					dl.LightT.NameResource.FileName = dl.NameResource.FileName;

					break;
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="map"></param>
		public void FixNames(Hashtable map) 
		{
			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);
				foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					string name = Hashes.StripHashFromName(FindReplacementName(map, rcol));
					//if (rcol.FileDescriptor.Type==Data.MetaData.TXMT || rcol.FileDescriptor.Type==Data.MetaData.TXTR) name = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+name;
					rcol.FileName = name;

					FixResource(map, rcol);
					rcol.SynchronizeUserData();
				}
			}
		}

		/// <summary>
		/// Remove some unreferenced and useless Files
		/// </summary>
		public void CleanUp() 
		{
            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Cleaning up");
			Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.MMAT);	//MMAT
			ArrayList mmats = new ArrayList();
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
				mmat.ProcessData(pfd, package);

				string content = Scenegraph.MmatContent(mmat);

				if (!mmats.Contains(content)) 
				{
					string txmtname = (string)Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue.Trim().ToLower())+"_txmt";
					string cresname = (string)Hashes.StripHashFromName(mmat.GetSaveItem("modelName").StringValue.Trim().ToLower());
				
					if (package.FindFile(Hashes.StripHashFromName(txmtname), 0x49596978).Length<0) pfd.MarkForDelete = true;
					if (package.FindFile(Hashes.StripHashFromName(cresname), 0xE519C933).Length<0) pfd.MarkForDelete = true;

					if (!pfd.MarkForDelete) mmats.Add(content);
				} 
				else 
				{
					pfd.MarkForDelete = true;
				}
			}
		}

		/// <summary>
		/// Fixes the Global Group
		/// </summary>
		public void FixGroup()
		{
			
			uint[] RCOLs =  {
								0xFB00791E, //ANIM
								0x4D51F042, //CINE
								0xE519C933, //CRES
								0xAC4F8687, //GMDC
								0x7BA3838C, //GMND
								0xC9C81B9B, //LGHT
								0xC9C81BA3, //LGHT
								0xC9C81BA9, //LGHT
								0xC9C81BAD, //LGHT
								0xED534136, //LIFO
								0xFC6EB1F7, //SHPE
								0x49596978, //TXMT, MATD
								0x1C4A276C  //TXTR
							};

            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Fixing Groups");
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in package.Index) 
			{
				

				bool RCOLcheck = types.Contains(pfd.Type);
				if (ver == FixVersion.UniversityReady) RCOLcheck = Data.MetaData.RcolList.Contains(pfd.Type);
				//foreach (uint tp in RCOLs) if (tp==pfd.Type) { RCOLcheck=true; break; }

				if (Data.MetaData.RcolList.Contains(pfd.Type)) 
				{
					SimPe.Plugin.GenericRcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					foreach (Interfaces.Files.IPackedFileDescriptor p in rcol.ReferencedFiles) 
					{
						if (ver == FixVersion.UniversityReady2) 
						{
							if (types.Contains(p.Type)) p.Group = Data.MetaData.CUSTOM_GROUP;
							else p.Group = Data.MetaData.LOCAL_GROUP;
						} 
						else 
						{
							if (Data.MetaData.RcolList.Contains(p.Type)) 
							{
								if (p.Type !=Data.MetaData.ANIM)
									p.Group = Data.MetaData.CUSTOM_GROUP;
								else
									p.Group = Data.MetaData.GLOBAL_GROUP;
							}
							else p.Group = Data.MetaData.LOCAL_GROUP;
						}
					}
					rcol.SynchronizeUserData();
				}

				if (RCOLcheck) 
				{
					if (pfd.Type != Data.MetaData.ANIM)
						pfd.Group = Data.MetaData.CUSTOM_GROUP;
					else 
						pfd.Group = Data.MetaData.GLOBAL_GROUP;
				}
				else 
				{
					pfd.Group = Data.MetaData.LOCAL_GROUP;
				}
				
			}

			//is this a Fence package? If so, do special FenceFixes
			if (package.FindFiles(Data.MetaData.XFNC).Length>0 /*|| package.FindFiles(Data.MetaData.XNGB).Length>0*/)
				this.FixFence();
		}

		/// <summary>
		/// Builds a Name map
		/// </summary>
		/// <param name="uniquename">true, if you want to create a unique name</param>
		/// <returns></returns>
		public Hashtable GetNameMap(bool uniquename) 
		{
			return RenameForm.Execute(package, uniquename, ref ver);
		}

		string BuildRefString(Interfaces.Files.IPackedFileDescriptor pfd)
		{
			return Helper.HexString(pfd.Group)+Helper.HexString(pfd.Type)+Helper.HexString(pfd.Instance)+Helper.HexString(pfd.SubType);
		}

		/// <summary>
		/// Runs the Fix Operation
		/// </summary>
		/// <param name="map">the map we have to use for name Replacements</param>		
		/// <param name="uniquefamily">change the family values in the MMAT Files</param>
		public void Fix(Hashtable map, bool uniquefamily)
		{
			string grouphash = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!";//"#0x"+Helper.HexString(package.FileGroupHash)+"!";
			

			Hashtable refmap = new Hashtable();
			Hashtable completerefmap = new Hashtable();

            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Fixing Names");
			FixNames(map);

			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);

				//build a List of RefItems
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					//rcol.FileName = Hashes.StripHashFromName(rcol.);
					/*if (types.Contains(pfd.Type)) rcol. = Hashes.StripHashFromName(rcol.);
					else rcol.FileName = grouphash + Hashes.StripHashFromName(rcol.FileName);*/

					foreach (Interfaces.Files.IPackedFileDescriptor rpfd in rcol.ReferencedFiles) 
					{
						string refstr = BuildRefString(rpfd);
						if (!refmap.Contains(refstr)) refmap.Add(refstr, null);
					}
					//rcol.SynchronizeUserData();
				}
			}

			//Updated TGI Values and update the refmap
            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Updating TGI Values");
			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);

				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					string refstr = BuildRefString(pfd);
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					//rcol.FileName = grouphash + Hashes.StripHashFromName(rcol.);
					rcol.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(rcol.FileName));
					rcol.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(rcol.FileName));

					if (refmap.Contains(refstr)) refmap[refstr] = rcol.FileDescriptor;
					completerefmap[refstr] = rcol.FileDescriptor;
				}
			}

			//Update the References			
            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Updating TGI References");
			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);

				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					foreach (Interfaces.Files.IPackedFileDescriptor rpfd in rcol.ReferencedFiles) 
					{
						string refstr = Helper.HexString(rpfd.Group)+Helper.HexString(rpfd.Type)+Helper.HexString(rpfd.Instance)+Helper.HexString(rpfd.SubType);

						if (ver == FixVersion.UniversityReady2) 
						{
							if (types.Contains(rpfd.Type)) rpfd.Group = Data.MetaData.CUSTOM_GROUP;
							else rpfd.Group = Data.MetaData.LOCAL_GROUP;
						}
						else 
						{
							if (rpfd.Type!=Data.MetaData.ANIM)
								rpfd.Group = Data.MetaData.CUSTOM_GROUP;
							else
								rpfd.Group = Data.MetaData.GLOBAL_GROUP;
						}

						if (refmap.Contains(refstr)) 
						{
							Interfaces.Files.IPackedFileDescriptor npfd = (Interfaces.Files.IPackedFileDescriptor)refmap[refstr];
							if (npfd!=null) 
							{
								rpfd.Instance = npfd.Instance;
								rpfd.SubType = npfd.SubType;								
							}
						}
					} //foreach

					rcol.SynchronizeUserData();
				}
			}

			//Make sure XObjects and Skins get Fixed Too
			FixXObject(map, completerefmap, grouphash);
			FixSkin(map, completerefmap, grouphash);

			//Make sure MMATs get fixed
			FixMMAT(map, uniquefamily, grouphash);

			//Make sure OBJd's get fixed too
			FixOBJd();

			//And finally the Root String
            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Updating Root");
			SimPe.Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.STRING_FILE);	
			string modelname = null;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, package);

				foreach (SimPe.PackedFiles.Wrapper.StrToken i in str.Items) 
				{
					string name = Hashes.StripHashFromName(i.Title.Trim().ToLower());					
					
					if (name=="") continue;
					if (pfd.Instance == 0x88) {if (!name.EndsWith("_txmt")) name += "_txmt";}
					else if (pfd.Instance == 0x85) {if (!name.EndsWith("_cres")) name += "_cres";}
					else if ((pfd.Instance == 0x81) || (pfd.Instance == 0x82) || (pfd.Instance == 0x86) || (pfd.Instance == 0x192)) {if (!name.EndsWith("_anim")) name += "_anim";}
					else continue;
					

					string newref = (string)map[name];
					if (newref!=null) i.Title = Hashes.StripHashFromName(newref.Substring(0, newref.Length-5));
					else i.Title = Hashes.StripHashFromName(i.Title);

					if (((ver == FixVersion.UniversityReady) || (pfd.Instance == 0x88)) && (newref!=null)) 
					{
						i.Title = Hashes.StripHashFromName(i.Title);
						
						if (!((pfd.Instance == 0x81) || (pfd.Instance == 0x82) || (pfd.Instance == 0x86) || (pfd.Instance == 0x192)))
							i.Title = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+i.Title;
					}
					else 
					{
						uint tp = Data.MetaData.ANIM;
						if (pfd.Instance==0x88) tp = Data.MetaData.TXMT;
						else if (pfd.Instance==0x85) tp = Data.MetaData.CRES;

						SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = FileTable.FileIndex.FindFileByName(i.Title, tp, Data.MetaData.LOCAL_GROUP, true);
						if (fii!=null)
							if (fii.FileDescriptor.Group == Data.MetaData.CUSTOM_GROUP) 						
								i.Title = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+Hashes.StripHashFromName(i.Title);						
					}
					
					if ((modelname==null) && (i.Language.Id==1) && (pfd.Instance==0x85)) 
						modelname = name.ToUpper().Replace("-", "_");
				}

				if (RemoveNonDefaultTextReferences)
					if (pfd.Instance == 0x88 || pfd.Instance == 0x85 || (pfd.Instance == 0x81) || (pfd.Instance == 0x82) || (pfd.Instance == 0x86) || (pfd.Instance == 0x192)) 				
						str.ClearNonDefault();				
					
				
				str.SynchronizeUserData();
			}

			//Now change the NREF

			if (modelname!=null) 
			{
				mpfds = package.FindFiles(0x4E524546);	
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
				{
					SimPe.PackedFiles.Wrapper.Nref nref = new SimPe.PackedFiles.Wrapper.Nref();
					nref.ProcessData(pfd, package);
					if (ver==FixVersion.UniversityReady)
						nref.FileName = "SIMPE_"+modelname;
					else
						nref.FileName = "SIMPE_v2_"+modelname;

					nref.SynchronizeUserData();
				}
			}
		}

		/// <summary>
		/// Make sure the fixes for OBJd Resources are considered
		/// </summary>
		/// <remarks>
		/// Currently this implements the Fixes needed for Rugs
		/// </remarks>
		void FixOBJd()
		{
            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Updating Object Descriuptions");
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);	//OBJd

			bool updaterugs = false;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd();
				objd.ProcessData(pfd, package);

				//is one of the objd's a rug?
				if (objd.FunctionSubSort == SimPe.Data.ObjFunctionSubSort.Decorative_Rugs) 
				{
					updaterugs = true;				
					break;
				}
			}

			//found at least one OBJd describing a Rug
			if (updaterugs) 
			{
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd();
					objd.ProcessData(pfd, package);

					//make sure the Type of a Rug is not a Tile, but Normal
					if (objd.Type == SimPe.Data.ObjectTypes.Tiles)
					{
						objd.Type = SimPe.Data.ObjectTypes.Normal;
						objd.SynchronizeUserData(true, true);
					}
				}
			}
		}

		/// <summary>
		/// This takes care of the MMAT Resources
		/// </summary>
		/// <param name="map"></param>
		/// <param name="uniquefamily"></param>
		/// <param name="grouphash"></param>
		void FixMMAT(Hashtable map, bool uniquefamily, string grouphash)
		{

            if (WaitingScreen.Running) WaitingScreen.UpdateMessage("Updating Material Overrides");
			Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.MMAT);	//MMAT
			Hashtable familymap = new Hashtable();
			uint mininst = 0x5000;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.Plugin.MmatWrapper mmat = new SimPe.Plugin.MmatWrapper();
				mmat.ProcessData(pfd, package);
				//make the MMAT Instance number unique
				pfd.Instance = mininst++;

				//get unique family value
				if (uniquefamily) 
				{
					string family = mmat.GetSaveItem("family").StringValue;
					string nfamily = (string)familymap[family];

					if (nfamily==null) 
					{
						nfamily = System.Guid.NewGuid().ToString();
						familymap[family] = nfamily;
					}

					mmat.Family = nfamily;					
				}


				string newref = (string)map[Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue.Trim().ToLower())+"_txmt"];
				if (newref!=null) 
				{
					newref = Hashes.StripHashFromName(newref);
					newref = newref.Substring(0, newref.Length-5); 
					mmat.Name =  grouphash + newref;
				} 
				else 
				{
					mmat.Name = grouphash + Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue);
				}

				newref = (string)map[Hashes.StripHashFromName(mmat.ModelName.Trim().ToLower())];
				if (newref!=null) 
				{
					newref = Hashes.StripHashFromName(newref);
					mmat.ModelName = newref; 
				}
				else mmat.ModelName = Hashes.StripHashFromName(mmat.ModelName);

				if (ver == FixVersion.UniversityReady)  
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(mmat.ModelName, Data.MetaData.CRES, Data.MetaData.GLOBAL_GROUP, true);
					
					bool addfl = true;
					if (item!=null)						
						if (item.FileDescriptor.Group==Data.MetaData.GLOBAL_GROUP) addfl=false;					

					if (addfl)	
						mmat.ModelName = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+mmat.ModelName;
				}

				//mmat.FileDescriptor.Group = Data.MetaData.LOCAL_GROUP;
				mmat.SynchronizeUserData();
			}
		}

		#region Fix Skins
		void FixCpfProperties(SimPe.PackedFiles.Wrapper.Cpf cpf, string[] props, Hashtable namemap, string prefix, string sufix)
		{
			foreach (string p in props)
			{
				SimPe.PackedFiles.Wrapper.CpfItem item = cpf.GetItem(p);
				if (item==null) continue;

				string name = Hashes.StripHashFromName(item.StringValue.Trim().ToLower());
				if (!name.EndsWith(sufix)) name+=sufix;
				string newname = (string)namemap[name];

				if (newname!=null) 
				{
					if (newname.EndsWith(sufix)) newname = newname.Substring(0, newname.Length-sufix.Length);
					item.StringValue = prefix+newname;
				}
			}
		}

		void FixCpfProperties(SimPe.PackedFiles.Wrapper.Cpf cpf, string[] props, uint val)
		{
			foreach (string p in props)
			{
				SimPe.PackedFiles.Wrapper.CpfItem item = cpf.GetItem(p);
				if (item==null) continue;

				item.UIntegerValue = val;
			}
		}

		SimPe.PackedFiles.Wrapper.CpfItem FixCpfProperties(SimPe.PackedFiles.Wrapper.Cpf cpf, string prop, uint val)
		{
			SimPe.PackedFiles.Wrapper.CpfItem item = cpf.GetItem(prop);
			if (item==null) return null;

			item.UIntegerValue = val;
			return item;
		}

		void FixFence()
		{
			Hashtable shpnamemap = new Hashtable();
			GenericRcol rcol = new GenericRcol();
			uint[] types = new uint[]{Data.MetaData.SHPE, Data.MetaData.CRES};
			
			//now fix the texture References in those Resources
			foreach (uint t in types)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(t);				
								
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{								

					//fix the references to the SHPE Resources, to mirror the fact 
					//that they are in the Global Group now
					if (t==Data.MetaData.CRES || t==Data.MetaData.GMND) 
					{		
						rcol.ProcessData(pfd, package);

						string shpname = null;

						if (t==Data.MetaData.CRES) 
						{
							SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)rcol.Blocks[0];
							rn.GraphNode.FileName = Hashes.StripHashFromName(rn.GraphNode.FileName);

							//generate the name for the connected SHPE Resource
							foreach (SimPe.Interfaces.Scenegraph.IRcolBlock irb in rcol.Blocks)
							{
								if (irb is SimPe.Plugin.ShapeRefNode) 
								{
									ShapeRefNode srn = (ShapeRefNode)irb;
									shpname = rcol.FileName.Trim().ToLower().Replace("_cres", "").Replace("_", "").Trim();
									srn.StoredTransformNode.ObjectGraphNode.FileName = shpname;
									shpname = rcol.FileName.Replace("_cres", "").Trim()+"_"+shpname+"_shpe";
								}
							}
						} 
						else if (t==Data.MetaData.GMND)
						{
							SimPe.Plugin.GeometryNode gn = (SimPe.Plugin.GeometryNode)rcol.Blocks[0];							
							gn.ObjectGraphNode.FileName = Hashes.StripHashFromName(gn.ObjectGraphNode.FileName);
						}
						
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor rpfd in rcol.ReferencedFiles) 
						{							
							//SHPE Resources get a new Name, so fix the Instance of the reference at this point
							if (rpfd.Type == Data.MetaData.SHPE) 
							{
								shpnamemap[rpfd.LongInstance] = shpname;
								rpfd.Instance = Hashes.InstanceHash(shpname);
								rpfd.SubType = Hashes.SubTypeHash(shpname);
							}

							rpfd.Group = Data.MetaData.GLOBAL_GROUP;
						}

						rcol.SynchronizeUserData();
					}

					pfd.Group = Data.MetaData.GLOBAL_GROUP;
				}				
			}

			//we need some special Adjustments for SHPE Resources, as their name has to match a certain pattern
			SimPe.Interfaces.Files.IPackedFileDescriptor[] spfds = package.FindFiles(Data.MetaData.SHPE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in spfds)
			{	
				if (shpnamemap[pfd.LongInstance]==null) continue;
				rcol.ProcessData(pfd, package);
				rcol.FileName = (string)shpnamemap[pfd.LongInstance];
				rcol.FileDescriptor.Instance = Hashes.InstanceHash(rcol.FileName);
				rcol.FileDescriptor.SubType = Hashes.SubTypeHash(rcol.FileName);

				rcol.SynchronizeUserData();
			}
		}

		protected void FixSkin(Hashtable namemap, Hashtable refmap, string grphash)
		{
			SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
			Random rnd = new Random();

			//set list of critical types
			uint[] types = new uint[]{Data.MetaData.XOBJ, Data.MetaData.XFLR, Data.MetaData.XFNC, Data.MetaData.XROF, Data.MetaData.XNGB};
			string[] txtr_props = new string[] {"textureedges", "texturetop", "texturetopbump", "texturetrim", "textureunder", "texturetname", "texturetname" };
			string[] txmt_props = new string[] {"material", "diagrail", "post", "rail"};
			string[] cres_props = new string[] {"diagrail", "post", "rail"};
			string[] cres_props_ngb = new string[] {"modelname"};
			string[] groups = new string[] {"stringsetgroupid", "resourcegroupid"};	
			string[] set_to_guid = new string[] {}; //"thumbnailinstanceid"

			//now fix the texture References in those Resources
			foreach (uint t in types)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(t);

				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					cpf.ProcessData(pfd, package);
					uint guid = (uint)rnd.Next();

					string pfx = grphash; if (t==Data.MetaData.XFNC) pfx = "";

					FixCpfProperties(cpf, txtr_props, namemap, pfx, "_txtr");
					FixCpfProperties(cpf, txmt_props, namemap, pfx, "_txmt");
					FixCpfProperties(cpf, cres_props, namemap, pfx, "_cres");
					if (pfd.Type == Data.MetaData.XNGB) 
						FixCpfProperties(cpf, cres_props_ngb, namemap, pfx, "_cres");

					FixCpfProperties(cpf, groups, Data.MetaData.LOCAL_GROUP);
					FixCpfProperties(cpf, set_to_guid, guid);
#if DEBUG
					FixCpfProperties(cpf, "guid", (uint)((guid & 0x00fffffe) | 0xfb000001));
#else
					
					FixCpfProperties(cpf, "guid", (uint)((guid & 0xfffffffe) | 0x00000001));
#endif
					
					cpf.SynchronizeUserData();
				}
			}			
		}
		#endregion

		#region Fix Xml Based Objects
		protected void FixXObject(Hashtable namemap, Hashtable refmap, string grphash)
		{
			//set list of critical types
			uint[] types = new uint[]{Data.MetaData.REF_FILE};
			
			SimPe.Plugin.RefFile fl = new RefFile();

			//now fix the texture References in those Resources
			foreach (uint t in types)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(t);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					fl.ProcessData(pfd, package);

					foreach (SimPe.Packages.PackedFileDescriptor rfi in fl.Items)
					{
						string name = this.BuildRefString(rfi);
						SimPe.Interfaces.Files.IPackedFileDescriptor npfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)refmap[name];
						if (npfd!=null)
						{
							rfi.Group = npfd.Group;
							rfi.LongInstance = npfd.LongInstance;
						}
					}

					fl.SynchronizeUserData();
				}
			}
		}
		#endregion
	}
}
