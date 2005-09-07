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
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// This is a basic Structure that describes what Features should be enabled during  a OW Task
	/// </summary>
	public class ObjectWorkshopSettings : SimPe.Plugin.CloneSettings
	{	
		internal ObjectWorkshopSettings() : base()
		{
			remote = true;
			remoteres = false;
		}

		bool remote, remoteres, remndeftxt;
		public bool OpenWithRemoteControl
		{
			get { return remote; }
			set { remote = value; }
		}

		public bool RemoveNonDefaultTextReferences
		{
			get { return remndeftxt; }
			set { remndeftxt = value; }
		}

		public bool RemoteResult
		{
			get {return remoteres;}
		}

		internal void SetRemoteResult(bool res)
		{
			remoteres = res;
		}
	}

	/// <summary>
	/// All Settings for a Clone
	/// </summary>
	public class OWCloneSettings : ObjectWorkshopSettings
	{
		public OWCloneSettings() : base()
		{
			grp = true;
			fix = true;
			rem = true;
			alone = false;
			updatedesc = false;
			price = 0;
			title = "";
			desc = "";
			RemoveNonDefaultTextReferences = true;
		}

		bool grp, fix, rem, alone, updatedesc;

		public bool CustomGroup
		{
			get { return grp; }
			set { grp = value;}
		}

		public bool FixResources
		{
			get { return fix; }
			set { fix = value;}
		}

		public bool RemoveUselessResource
		{
			get { return rem; }
			set { rem = value;}
		}

		public bool StandAloneObject
		{
			get { return alone; }
			set { alone = value;}
		}

		public bool ChangeObjectDescription
		{
			get { return updatedesc; }
			set { updatedesc = value;}
		}

		short price;
		string desc, title;
		public short Price 
		{
			get { return price; }
			set { price = value;}
		}

		public string Title 
		{
			get { return title; }
			set { title = value;}
		}

		public string Description 
		{
			get { return desc; }
			set { desc = value;}
		}
	}

	/// <summary>
	/// All Settings for a Recolor
	/// </summary>
	public class OWRecolorSettings : ObjectWorkshopSettings
	{
		public OWRecolorSettings() : base()
		{
			this.IncludeAnimationResources = false;
			this.IncludeWallmask = false;
		}
	}

	public class ObjectWorkshopHelper 
	{
		/// <summary>
		/// Clone an object based on way Files are linked
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="localgroup"></param>
		/// <param name="onlydefault"></param>
		protected static SimPe.Packages.GeneratableFile RecolorClone(CloneSettings.BaseResourceType br, SimPe.Packages.GeneratableFile ppkg, Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, ObjectWorkshopSettings settings) 
		{
			SimPe.Packages.GeneratableFile package = null;
			if (ppkg!=null) package = (SimPe.Packages.GeneratableFile)ppkg.Clone();
			else 
			{
				package = SimPe.Packages.GeneratableFile.CreateNew();
				//Get the Base Object Data from the Objects.package File
				string[] modelname = new string[0];
				if (br == CloneSettings.BaseResourceType.Objd) modelname = BaseClone(pfd, localgroup, package);
				else 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fii = FileTable.FileIndex.FindFile(pfd, null);
					if (fii.Length>0) 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor cpfd = fii[0].FileDescriptor.Clone();
						cpfd = cpfd.Clone();
						cpfd.UserData = fii[0].Package.Read(fii[0].FileDescriptor).UncompressedData;
						package.Add(cpfd);
					}
				}
				ObjectCloner objclone = new ObjectCloner(package);
				ArrayList exclude = new ArrayList();

			

				//allways for recolors
				if (settings is OWRecolorSettings) 
				{
					exclude.Add("stdMatEnvCubeTextureName");
					exclude.Add("TXTR");
				} 
				else 
				{
					exclude.Add("tsMaterialsMeshName");								
					exclude.Add("TXTR");
					exclude.Add("stdMatEnvCubeTextureName");								
				}

				//do the recolor
				objclone.Setup.OnlyDefaultMmats = (settings.OnlyDefaultMmats && br!=CloneSettings.BaseResourceType.Xml);
				objclone.Setup.UpdateMmatGuids = objclone.Setup.OnlyDefaultMmats ;
				objclone.Setup.IncludeWallmask = settings.IncludeWallmask;
				objclone.Setup.BaseResource = br;
				objclone.Setup.IncludeAnimationResources = settings.IncludeAnimationResources;
				objclone.Setup.KeepOriginalMesh = settings.KeepOriginalMesh;
				objclone.RcolModelClone(modelname, exclude);

				//for clones only when cbparent is checked
				if (settings is OWCloneSettings) 
				{
					if (((OWCloneSettings)settings).StandAloneObject || br==CloneSettings.BaseResourceType.Xml)
					{
						string[] names = Scenegraph.LoadParentModelNames(package, true);
						SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(null);

						ObjectCloner pobj = new ObjectCloner(pkg);
						pobj.Setup.OnlyDefaultMmats = (settings.OnlyDefaultMmats && br!=CloneSettings.BaseResourceType.Xml);;
						pobj.Setup.UpdateMmatGuids = pobj.Setup.OnlyDefaultMmats;
						pobj.Setup.IncludeWallmask = settings.IncludeWallmask;
						pobj.Setup.IncludeAnimationResources = settings.IncludeAnimationResources;
						pobj.Setup.BaseResource = br;
						pobj.Setup.KeepOriginalMesh = settings.KeepOriginalMesh;
						pobj.RcolModelClone(names, exclude);
						pobj.AddParentFiles(modelname, package);				
					} 
					else			
					{
						string[] modelnames = modelname;
						if (!((OWCloneSettings)settings).RemoveUselessResource) modelnames = null;
						objclone.RemoveSubsetReferences(Scenegraph.GetParentSubsets(package), modelnames);
					}
				}
			}

			return package;
		}

		/// <summary>
		/// Reads all Data from the Objects.package blonging to the same group as the passed pfd
		/// </summary>
		/// <param name="pfd">Desciptor for one of files belonging to the Object (Name Map)</param>
		/// <param name="objpkg">The Object Package you wanna process</param>
		/// <param name="package">The package that should get the Files</param>
		/// <returns>The Modlename of that Object or null if none</returns>
		public static string[] BaseClone(Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, SimPe.Packages.File package) 
		{
			//Get the Base Object Data from the Objects.package File
			
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] files = FileTable.FileIndex.FindFileByGroup(localgroup);

			ArrayList list = new ArrayList();
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in files) 
			{
				Interfaces.Files.IPackedFile file = item.Package.Read(item.FileDescriptor);

				SimPe.Packages.PackedFileDescriptor npfd = new SimPe.Packages.PackedFileDescriptor();

				npfd.UserData = file.UncompressedData;
				npfd.Group = item.FileDescriptor.Group;
				npfd.Instance = item.FileDescriptor.Instance;
				npfd.SubType = item.FileDescriptor.SubType;
				npfd.Type = item.FileDescriptor.Type;

				if (package.FindFile(npfd)==null)
					package.Add(npfd);

				if ((npfd.Instance == 0x85) && (npfd.Type == Data.MetaData.STRING_FILE)) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
					str.ProcessData(npfd, item.Package);
					SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
					for (int i=1; i<items.Length; i++) list.Add(items[i].Title);
				}
			}

			string[] refname = new string[list.Count];
			list.CopyTo(refname);

			return refname;
		}

		protected static SimPe.Packages.GeneratableFile ReColorXObject(CloneSettings.BaseResourceType br, SimPe.Packages.GeneratableFile pkg, Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, ObjectWorkshopSettings settings) 
		{
			settings.KeepOriginalMesh = true;
			SimPe.Packages.GeneratableFile package = pkg;
			// we need packages in the Gmaes and the Download Folder
			
			if (( (!System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) || (!System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) ) && (settings is OWCloneSettings)) 
			{
				if (Message.Show(Localization.Manager.GetString("OW_Warning"), "Warning", MessageBoxButtons.YesNo)==DialogResult.No) return package;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			if (sfd.ShowDialog()!=DialogResult.OK) return package;			

			//create a Cloned Object to get all needed Files for the Process			
			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Collecting needed Files");
			
			if ((package==null) && (pfd!=null)) package = RecolorClone(br, package, pfd, localgroup, settings);
			WaitingScreen.Stop();
					
			package.FileName = sfd.FileName;		
			package.Save();
							
			return package;
		}

		protected static SimPe.Packages.GeneratableFile ReColor(CloneSettings.BaseResourceType br, SimPe.Packages.GeneratableFile pkg, Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, ObjectWorkshopSettings settings) 
		{
			SimPe.Packages.GeneratableFile package = pkg;
			// we need packages in the Gmaes and the Download Folder
			
			if (( (!System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) || (!System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) ) && (settings is OWCloneSettings)) 
			{
				if (Message.Show(Localization.Manager.GetString("OW_Warning"), "Warning", MessageBoxButtons.YesNo)==DialogResult.No) return package;
			}

			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			if (sfd.ShowDialog()!=DialogResult.OK) return package;			

			//create a Cloned Object to get all needed Files for the Process			
			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Collecting needed Files");
			
			if ((package==null) && (pfd!=null)) package = RecolorClone(br, package, pfd, localgroup, settings);
			WaitingScreen.Stop();
			
			
			/*if (settings is OWRecolorSettings) 
			{
				ObjectRecolor or = new ObjectRecolor(package);
				or.EnableColorOptions();
				or.LoadReferencedMATDs();				

				//load all Pending Textures
				ObjectCloner oc = new ObjectCloner(package);				
			}*/

			SimPe.Packages.GeneratableFile dn_pkg = null;
			if (System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) dn_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.GMND_PACKAGE);
			else dn_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);

			SimPe.Packages.GeneratableFile gm_pkg = null;
			if (System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) gm_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.MMAT_PACKAGE);
			else gm_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
			
			SimPe.Packages.GeneratableFile npackage = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);

			//Create the Templae for an additional MMAT
			npackage.FileName = sfd.FileName;	

			ColorOptions cs = new ColorOptions(package);
			cs.Create(npackage);

			npackage.Save();
			package = npackage;
						

			WaitingScreen.Stop();
#if DEBUG
#else
			if (package!=npackage) package = null;			
#endif

			return package;
		}

		public static SimPe.Packages.GeneratableFile Start(SimPe.Packages.GeneratableFile pkg, SimPe.Interfaces.IAlias a, ref Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, ObjectWorkshopSettings settings)
		{			
			SimPe.Packages.GeneratableFile package = pkg;
			SimPe.Plugin.CloneSettings.BaseResourceType br = SimPe.Plugin.CloneSettings.BaseResourceType.Objd;
			if (pfd!=null) 
				if (pfd.Type!=Data.MetaData.OBJD_FILE) 
					br = SimPe.Plugin.CloneSettings.BaseResourceType.Xml;
			if (settings is OWCloneSettings) 
			{
				OWCloneSettings cs = (OWCloneSettings)settings;				
				
				package = RecolorClone(br, package, pfd, localgroup, settings);						
					

				FixObject fo = new FixObject(package, FixVersion.UniversityReady, settings.RemoveNonDefaultTextReferences);
				System.Collections.Hashtable map = null;
					
				if (cs.FixResources) 
				{
					map = fo.GetNameMap(true);
					if (map==null) return package;
				
					SaveFileDialog sfd = new SaveFileDialog();
					sfd.Filter = ExtensionProvider.BuildFilterString(
						new SimPe.ExtensionType[] {
													  SimPe.ExtensionType.Package,
													  SimPe.ExtensionType.AllFiles
												  }
						);
					if (sfd.ShowDialog()==DialogResult.OK) 
					{
						WaitingScreen.Wait();
						package.FileName = sfd.FileName;
						fo.Fix(map, true);

						if (cs.RemoveUselessResource && br!=SimPe.Plugin.CloneSettings.BaseResourceType.Xml) 
							fo.CleanUp();
						package.Save();
							
					} 
					else 
					{
						package = null;
					}
				}

				if ((cs.CustomGroup) && (package!=null))
				{
					WaitingScreen.Wait();
					fo.FixGroup();
					if (cs.FixResources) package.Save();
				}

				if (cs.ChangeObjectDescription) UpdateDescription(cs, package);

				//select a resource to display in SimPE
				pfd=null;
				if (package!=null) 
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
					if (pfds.Length>0) pfd = pfds[0];
				} 
			} 
			else 
			{
				/*if (br == SimPe.Plugin.CloneSettings.BaseResourceType.Xml)
					package = ReColorXObject(br, package, pfd, localgroup, new OWRecolorSettings());
				else*/
					package = ReColor(br, package, pfd, localgroup, new OWRecolorSettings());

				//select a resource for display in SimPE
				pfd=null;
				if (package!=null) 
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.TXTR);
					if (pfds.Length>0) pfd = pfds[0];
				} 
			}	

			settings.SetRemoteResult(false);
			if (settings.OpenWithRemoteControl)
			{				
				if (package!=null) 
					if (SimPe.RemoteControl.OpenMemoryPackage(package) && pfd!=null)
						settings.SetRemoteResult(SimPe.RemoteControl.OpenPackedFile(pfd, package));
			}

			WaitingScreen.Stop();
		
			return package;
		}

		#region Update Object Description
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cs"></param>
		/// <param name="cpf"></param>
		/// <returns>ResourceDescriptor for the references String</returns>
		protected static SimPe.Interfaces.Files.IPackedFileDescriptor UpdateDescription(OWCloneSettings cs, SimPe.Packages.GeneratableFile package, SimPe.PackedFiles.Wrapper.ExtObjd obj)
		{
			obj.Price = cs.Price;
			obj.Data[0x22] = (short)Math.Floor(cs.Price * 0.035); // sale price
			obj.Data[0x23] = (short)Math.Floor(cs.Price * 0.15); // initial depreciation
			obj.Data[0x24] = (short)Math.Floor(cs.Price * 0.10); // daily depreciation
			obj.Data[0x25] = 0; // self depreciation
			obj.Data[0x26] = (short)Math.Floor(cs.Price * 0.40); // depreciation limit
			obj.SynchronizeUserData();
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(Data.MetaData.CTSS_FILE, 0, obj.FileDescriptor.Group, obj.CTSSInstance);			
			
			return pfd;
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cs"></param>
		/// <param name="cpf"></param>
		/// <returns>ResourceDescriptor for the references String</returns>
		protected static SimPe.Interfaces.Files.IPackedFileDescriptor UpdateDescription(OWCloneSettings cs, SimPe.Packages.GeneratableFile package, SimPe.PackedFiles.Wrapper.Cpf cpf)
		{
			cpf.GetSaveItem("cost").UIntegerValue = (uint)cs.Price;
			cpf.GetSaveItem("name").StringValue = cs.Title.Replace("\n", " ").Replace("\t", "    ").Replace("\r", " ");
			cpf.GetSaveItem("description").StringValue = cs.Description.Replace("\n", " ").Replace("\t", "    ").Replace("\r", " ");
			cpf.SynchronizeUserData();
			
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(cpf.GetSaveItem("stringsetrestypeid").UIntegerValue, 0, cpf.GetSaveItem("stringsetgroupid").UIntegerValue, cpf.GetSaveItem("stringsetid").UIntegerValue);			
			
			return pfd;
		}

		protected static void UpdateDescription(OWCloneSettings cs, SimPe.PackedFiles.Wrapper.Str str)
		{
			str.ClearNonDefault();
			while (str.Items.Length<2) str.Add(new SimPe.PackedFiles.Wrapper.StrItem(str.Items.Length, 1, "", ""));

			str.Items[0].Title = cs.Title;
			str.Items[1].Title = cs.Description;

			str.SynchronizeUserData();
		}

		protected static void UpdateDescription(OWCloneSettings cs, SimPe.Packages.GeneratableFile package)
		{
			//change the price in the OBJd
			SimPe.PackedFiles.Wrapper.ExtObjd obj = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
			SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{				
				obj.ProcessData(pfd, package);

				SimPe.Interfaces.Files.IPackedFileDescriptor spfd = UpdateDescription(cs, package, obj);

				if (spfd!=null) 
				{
					str.ProcessData(spfd, package);
					UpdateDescription(cs, str);
				}
			}

			//change Price, Title, Desc in the XObj Files
			uint[] types = new uint[] {Data.MetaData.XFNC, Data.MetaData.XROF, Data.MetaData.XFLR, Data.MetaData.XOBJ};
			SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();			
			foreach (uint t in types) 
			{
				pfds = package.FindFiles(t);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					cpf.ProcessData(pfd, package);
					SimPe.Interfaces.Files.IPackedFileDescriptor spfd = UpdateDescription(cs, package, cpf);

					if (spfd!=null) 
					{
						str.ProcessData(spfd, package);
						UpdateDescription(cs, str);
					}
				}
			}

			if (package.FileName!=null) package.Save();
		}
		#endregion
	}
}
