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
using System.IO;
using System.Collections;
using SimPe.Data;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Providers
{
	/// <summary>
	/// Provides an Alias Matching a SimID with it's Name
	/// </summary>
	public class Skins : SimCommonPackage, Interfaces.Providers.ISkinProvider
	{
		/// <summary>
		/// List of known Opcode Names
		/// </summary>
		private ArrayList sets;	

		/// <summary>
		/// List of known Opcode Names
		/// </summary>
		private ArrayList matds;
	
		/// <summary>
		/// List of known Opcode Names
		/// </summary>
		private ArrayList refs;

		/// <summary>
		/// Available Textures
		/// </summary>
		private Hashtable txtrs;
		

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public Skins() : base(null) {
			
		}

		protected void LoadSkinFormPackage(SimPe.Interfaces.Files.IPackageFile package)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0xEBCF3E27);

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfd, package);
					sets.Add(cpf);
				} 
				catch (Exception) {}
			}
		}

		protected void LoadSkinImageFormPackage(SimPe.Interfaces.Files.IPackageFile package)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0xAC506764);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				try 
				{
					SimPe.Plugin.RefFile reffile = new SimPe.Plugin.RefFile();
					reffile.ProcessData(pfd, package);
					refs.Add(reffile);
				} 
				catch (Exception) {}
			}

			pfds = package.FindFiles(0x49596978);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				try 
				{
					SimPe.Plugin.Rcol matd = new SimPe.Plugin.GenericRcol(null, true);
					matd.ProcessData(pfd, package);
					matds.Add(matd);
				} 
				catch (Exception) {}
			}

			//Material Files
			Interfaces.Files.IPackedFileDescriptor[] nmap_pfd = package.FindFiles(Data.MetaData.NAME_MAP);
			pfds = package.FindFiles(0x49596978);
			Plugin.Nmap nmap = new SimPe.Plugin.Nmap(null);
			if (nmap_pfd.Length>0) nmap.ProcessData(nmap_pfd[0], package);
			bool check = false;
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				try 
				{
					SimPe.Plugin.Rcol matd = new SimPe.Plugin.GenericRcol(null, true);
					check = false;

					foreach (Interfaces.Files.IPackedFileDescriptor epfd in nmap.Items) 
					{
						if ( 
							(epfd.Group == pfd.Group) &&
							(epfd.Instance == pfd.Instance)
							)
						{
							matd.FileDescriptor = pfd;
							matd.Package = package;
							matds.Add(matd);
							check = true;
						}
					}

					//not found in the FileMap, so process Normally
					if (!check) 
					{
						matd.ProcessData(pfd, package);
						matds.Add(matd);
					}
				} 
				catch (Exception) {}
			}

			//Texture Files
			nmap_pfd = package.FindFiles(Data.MetaData.NAME_MAP);
			pfds = package.FindFiles(0x1C4A276C);
			check = false;
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				try 
				{
					SimPe.Plugin.Txtr txtr = new SimPe.Plugin.Txtr(null, true);
					check = false;

					foreach (Interfaces.Files.IPackedFileDescriptor epfd in nmap.Items) 
					{
						if ( 
							(epfd.Group == pfd.Group) &&
							(epfd.Instance == pfd.Instance)
							)
						{
							txtr.FileDescriptor = pfd;
							txtr.Package = package;
							txtrs.Add(epfd.Filename, txtr);
							continue;
						}
					}

					//not found in the FileMap, so process Normally
					if (!check) 
					{
						txtr.ProcessData(pfd, package);
						foreach (SimPe.Plugin.ImageData id in txtr.Blocks) 
						{
							txtrs.Add(id.NameResource.FileName.ToLower(), txtr);
						}
					}
				} 
				catch (Exception) {}
			}
		
			 
			
		}

		/// <summary>
		/// Loads available Skin Files
		/// </summary>
		protected void LoadSkins()
		{
			LoadPackage();

			sets = new ArrayList();
			LoadSkinFormPackage(BasePackage);
			LoadUserPackages();
		}

		/// <summary>
		/// Loads available Skin Files
		/// </summary>
		protected void LoadSkinImages()
		{
			LoadPackage();

			matds = new ArrayList();
			refs = new ArrayList();
			txtrs = new Hashtable();
			//LoadSkinImageFormPackage(BasePackage);
			LoadUserImagePackages();

			/*Registry reg = new Registry();
			string file = System.IO.Path.Combine(reg.SimsPath, "TSData\\Res\\Sims3D\\Sims07.package");				
			if (System.IO.File.Exists(file)) 
			{
				SimPe.Interfaces.Files.IPackageFile package = new SimPe.Packages.File(file);
				LoadSkinImageFormPackage(package);
			} 		
	
			file = System.IO.Path.Combine(reg.SimsPath, "TSData\\Res\\Sims3D\\Sims02.package");				
			if (System.IO.File.Exists(file)) 
			{
				SimPe.Interfaces.Files.IPackageFile package = new SimPe.Packages.File(file);
				LoadSkinImageFormPackage(package);
			} */		
		}
		
		protected void LoadUserPackages()
		{
			string path = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");
			if (!System.IO.Directory.Exists(path)) return;

			string[] files = System.IO.Directory.GetFiles(path, "*.package");
			foreach (string file in files) 
			{
				SimPe.Packages.File package = new SimPe.Packages.File(file);
				LoadSkinFormPackage(package);
				//package.Reader.Close();
			}
		}

		protected void LoadUserImagePackages()
		{
			string path = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");
			if (!System.IO.Directory.Exists(path)) return;

			string[] files = System.IO.Directory.GetFiles(path, "*.package");
			foreach (string file in files) 
			{
				SimPe.Packages.File package = new SimPe.Packages.File(file);
				LoadSkinImageFormPackage(package);
				//package.Reader.Close();
			}
		}

		/// <summary>
		/// Loads the ObjectsPackage if not already loaded
		/// </summary>
		public void LoadPackage() 
		{
			if (BasePackage==null) 
			{
				Registry reg = new Registry();
				string file = System.IO.Path.Combine(reg.SimsPath, "TSData\\Res\\Catalog\\Skins\\Skins.package");				
				if (System.IO.File.Exists(file)) 
				{
					BasePackage = new Packages.File(file);
				} 
				else 
				{
					BasePackage = null;
				}
			}
		}

		/// <summary>
		/// Returns the Property Set (=cpf) of a Skin
		/// </summary>
		/// <param name="spfd">The File Description of the File you are looking for</param>
		/// <returns>null or the Property Set File</returns>
		public object FindSet(Interfaces.Files.IPackedFileDescriptor spfd)
		{
			if (sets==null) this.LoadSkins();
			if (sets==null) return null;
			foreach (SimPe.PackedFiles.Wrapper.Cpf cpf in sets)
			{
				Interfaces.Files.IPackedFileDescriptor pfd = cpf.FileDescriptor;
				if (
					(pfd.Group == spfd.Group) &&
					(pfd.SubType == spfd.SubType) &&
					(pfd.Instance == spfd.Instance) &&
					(pfd.Type == spfd.Type)
					) 
				{
					return cpf;
				}
			}

			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ocpf">The MMAT or Property Set describing the Model</param>
		/// <returns>The Texture or null</returns>
		public object FindTxtrName(object ocpf) 
		{
			SimPe.PackedFiles.Wrapper.Cpf cpf = (SimPe.PackedFiles.Wrapper.Cpf)ocpf;
			SimPe.PackedFiles.Wrapper.CpfItem item = cpf.GetSaveItem("name");

			if (cpf.Package != BasePackage) 
			{
				string name = FindTxtrName(cpf.FileDescriptor);
				return FindUserTxtr(name);
			}
			else 
			{
				string name = FindTxtrName(item.StringValue+"_txmt");
				return FindTxtr(name);
			}
		}

		/// <summary>
		/// Returns the Property Set (=cpf) of a Skin
		/// </summary>
		/// <param name="spfd">The File Description of the File you are looking for</param>
		/// <returns>null or the Property Set File</returns>
		public string FindTxtrName(string matdname)
		{
			if (matdname==null) return null;
			string file = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res\\Sims3D\\Sims02.package");				
			
			if (System.IO.File.Exists(file)) 
			{
				SimPe.Interfaces.Files.IPackageFile package = new SimPe.Packages.File(file);
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(matdname.Replace("CASIE_", ""), 0x49596978);
				if (pfds.Length==0) pfds = package.FindFile(matdname, 0x49596978);
				//try another Package
				/*if (pfds.Length==0) 
				{
					file = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res\\Sims3D\\Sims07.package");				
					if (System.IO.File.Exists(file)) 
					{
						package = new SimPe.Packages.File(file);
						pfds = package.FindFile(matdname, 0x49596978);
					}
				}*/

				//look for the right one
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Rcol rcol = new SimPe.Plugin.GenericRcol(null, false);
					rcol.ProcessData(pfd, package);
					if ((rcol.FileName.Trim().ToLower()==matdname.Trim().ToLower()) || (rcol.FileName.Trim().ToLower()==matdname.Replace("CASIE_", "").Trim().ToLower()))
					{
						foreach (SimPe.Plugin.MaterialDefinition md in rcol.Blocks)
						{
							return md.GetProperty("stdMatBaseTextureName").Value+"_txtr";
						}
					}
				}
			} 	
			return null;
		}

		public string FindTxtrName(Interfaces.Files.IPackedFileDescriptor spfd) {
			if (matds==null) this.LoadSkinImages();
			if (matds==null) return "";
			if (refs==null) return "";
			foreach (SimPe.Plugin.RefFile reff in refs)
			{
				Interfaces.Files.IPackedFileDescriptor pfd = reff.FileDescriptor;
				if (
					(pfd.Group == spfd.Group) &&
					(pfd.SubType == spfd.SubType) &&
					(pfd.Instance == spfd.Instance)
					) 
				{
					foreach (SimPe.Interfaces.Files.IPackedFileDescriptor refpfd in reff.Items) 
					{
						//found a MATD Reference File
						if (refpfd.Type == 0x49596978) 
						{
							foreach (SimPe.Plugin.Rcol matd in matds) 
							{
								pfd = matd.FileDescriptor;
								if (
									(pfd.Group == refpfd.Group) &&
									(pfd.SubType == refpfd.SubType) &&
									(pfd.Instance == refpfd.Instance)
									) 
								{
									foreach (SimPe.Plugin.MaterialDefinition md in matd.Blocks)
									{
										return md.GetProperty("stdMatBaseTextureName").Value;
									}
								}
							}
						}
					} //foreach matd
				}
			}

			return "";
		}

		public object FindTxtr(string name) 
		{
			if (name==null) return null;
			string file = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res\\Sims3D\\Sims07.package");				
			if (System.IO.File.Exists(file)) 
			{
				SimPe.Interfaces.Files.IPackageFile package = new SimPe.Packages.File(file);
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(name, 0x1C4A276C);

				//look for the right one
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Txtr rcol = new SimPe.Plugin.Txtr(null, false);
					rcol.ProcessData(pfd, package);
					if (rcol.FileName.Trim().ToLower()==name.Trim().ToLower()) return rcol;
				}
			}

			return null;
		}

		public object FindUserTxtr(string name)  {
			if (txtrs==null) this.LoadSkinImages();
			if (txtrs==null) return null;

			name = name.ToLower();
			SimPe.Plugin.Txtr txtr = (SimPe.Plugin.Txtr)txtrs[name];
			if (txtr==null) txtr = (SimPe.Plugin.Txtr)txtrs[name+"_txtr"];
			if (txtr==null) return null;

			if (txtr.Fast) 
			{
				txtr.Fast = false;
				SimPe.Packages.File fl = new SimPe.Packages.File(txtr.Package.FileName);
				Interfaces.Files.IPackedFileDescriptor pfd = fl.FindFile(txtr.FileDescriptor.Type, txtr.FileDescriptor.SubType, txtr.FileDescriptor.Group, txtr.FileDescriptor.Instance);
				txtr.ProcessData(pfd, fl);
				//fl.Reader.Close();
			}

			return txtr;
		}

		/// <summary>
		/// Returns a list of all known memories
		/// </summary>
		public ArrayList StoredSkins
		{
			get { 
				LoadPackage();
				if (this.sets==null) LoadSkins();
				return this.sets; 
			}			
		}


		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected override void BasePackageChanged() 
		{
			sets = null;
			matds = null;
			txtrs = null;
			refs = null;
		}
	}
}
