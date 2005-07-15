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

		/// <summary>
		/// Creates a new Instance of this class
		/// </summary>
		/// <param name="package">The package you want to fix the Integrity in</param>
		public FixObject(IPackageFile package, FixVersion ver) : base (package)
		{
			this.ver = ver;
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

			if (name.ToLower().EndsWith("_txmt") ) name = name.Substring(0, name.Length-5);

			string[] parts = name.Split("_".ToCharArray());
			if (parts.Length>1) 
			{
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
				if (!addedunique) name += unique;				
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
					string reference = matd.GetProperty("stdMatBaseTextureName").Value.Trim().ToLower();
					string newref = (string)map[Hashes.StripHashFromName(reference)+"_txtr"];

					if (newref!=null) 
					{
						newref = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+Hashes.StripHashFromName(newref);
						matd.GetProperty("stdMatBaseTextureName").Value = newref.Substring(0, newref.Length-5);
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
			WaitingScreen.UpdateMessage("Cleaning up");
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

			WaitingScreen.UpdateMessage("Fixing Groups");
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
							if (Data.MetaData.RcolList.Contains(p.Type)) p.Group = Data.MetaData.CUSTOM_GROUP;
							else p.Group = Data.MetaData.LOCAL_GROUP;
						}
					}
					rcol.SynchronizeUserData();
				}

				if (RCOLcheck) 
				{
					pfd.Group = Data.MetaData.CUSTOM_GROUP;
				}
				else 
				{
					pfd.Group = Data.MetaData.LOCAL_GROUP;
				}
				
			}
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

		/// <summary>
		/// Runs the Fix Operation
		/// </summary>
		/// <param name="map">the map we have to use for name Replacements</param>
		
		/// <param name="uniquefamily">change the family values in the MMAT Files</param>
		public void Fix(Hashtable map, bool uniquefamily)
		{
			string grouphash = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!";//"#0x"+Helper.HexString(package.FileGroupHash)+"!";
			

			Hashtable refmap = new Hashtable();

			WaitingScreen.UpdateMessage("Fixing Names");
			FixNames(map);

			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);

				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					//rcol.FileName = Hashes.StripHashFromName(rcol.);
					/*if (types.Contains(pfd.Type)) rcol. = Hashes.StripHashFromName(rcol.);
					else rcol.FileName = grouphash + Hashes.StripHashFromName(rcol.FileName);*/

					foreach (Interfaces.Files.IPackedFileDescriptor rpfd in rcol.ReferencedFiles) 
					{
						string refstr = Helper.HexString(rpfd.Group)+Helper.HexString(rpfd.Type)+Helper.HexString(rpfd.Instance)+Helper.HexString(rpfd.SubType);
						if (!refmap.Contains(refstr)) refmap.Add(refstr, null);
					}
					rcol.SynchronizeUserData();
				}
			}

			//Updated TGI Values and update the refmap
			WaitingScreen.UpdateMessage("Udating TGI Values");
			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);

				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					string refstr = Helper.HexString(pfd.Group)+Helper.HexString(pfd.Type)+Helper.HexString(pfd.Instance)+Helper.HexString(pfd.SubType);
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);

					//rcol.FileName = grouphash + Hashes.StripHashFromName(rcol.);
					rcol.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(rcol.FileName));
					rcol.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(rcol.FileName));

					if (refmap.Contains(refstr)) refmap[refstr] = rcol.FileDescriptor;
				}
			}

			//Update the References			
			WaitingScreen.UpdateMessage("Udating TGI References");
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
							rpfd.Group = Data.MetaData.CUSTOM_GROUP;
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

			//Now Fix the MMAT
			WaitingScreen.UpdateMessage("Udating Material Overrides");
			Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.MMAT);	//MMAT
			Hashtable familymap = new Hashtable();
			uint mininst = 0x5000;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
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

					mmat.GetSaveItem("family").StringValue = nfamily;
				}


				string newref = (string)map[Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue.Trim().ToLower())+"_txmt"];
				if (newref!=null) 
				{
					newref = Hashes.StripHashFromName(newref);
					newref = newref.Substring(0, newref.Length-5); 
					mmat.GetSaveItem("name").StringValue = grouphash + newref;
				} 
				else 
				{
					mmat.GetSaveItem("name").StringValue = grouphash + Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue);
				}

				newref = (string)map[Hashes.StripHashFromName(mmat.GetSaveItem("modelName").StringValue.Trim().ToLower())];
				if (newref!=null) 
				{
					newref = Hashes.StripHashFromName(newref);
					mmat.GetSaveItem("modelName").StringValue = newref; 
				}
				else mmat.GetSaveItem("modelName").StringValue = Hashes.StripHashFromName(mmat.GetSaveItem("modelName").StringValue);

				if (ver == FixVersion.UniversityReady)  mmat.GetSaveItem("modelName").StringValue = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+mmat.GetSaveItem("modelName").StringValue;

				//mmat.FileDescriptor.Group = Data.MetaData.LOCAL_GROUP;
				mmat.SynchronizeUserData();
			}

			//And finally the Root String
			WaitingScreen.UpdateMessage("Udating Root");
			mpfds = package.FindFiles(Data.MetaData.STRING_FILE);	
			string modelname = null;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, package);

				foreach (SimPe.PackedFiles.Wrapper.StrItem i in str.Items) 
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
						i.Title = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+i.Title;
					
					if ((modelname==null) && (i.Language.Id==1) && (pfd.Instance==0x85)) 
						modelname = name.ToUpper().Replace("-", "_");
				}
				
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
	}
}
