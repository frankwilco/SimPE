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
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This Class provides Methods to clone ingame Objects
	/// </summary>
	public class ObjectCloner
	{
		/// <summary>
		/// The Base Package
		/// </summary>
		IPackageFile package;

		/// <summary>
		/// The Base Package
		/// </summary>
		public IPackageFile Package
		{
			get { return package; }
		}

		/// <summary>
		/// Creates a new Isntance based on an existing Package
		/// </summary>
		/// <param name="package">The Package that should receive the Clone</param>
		public ObjectCloner(IPackageFile package) 
		{
			this.package = package;
		}

		/// <summary>
		/// Creates a new Instance and a new Package
		/// </summary>
		public ObjectCloner() 
		{
			package = new GeneratableFile((System.IO.BinaryReader)null);
		}

		/// <summary>
		/// Find the second MMAT that matches the state
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static Interfaces.Files.IPackedFileDescriptor[] FindStateMatchingMatd(string name, IPackageFile package)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = null;

			//railingleft1 railingleft2 railingleft3 railingleft4
			if (name.EndsWith("_clean")) 
			{
				name = name.Substring(0, name.Length-6)+"_dirty";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			} 
			else if (name.EndsWith("_dirty")) 
			{
				name = name.Substring(0, name.Length-6)+"_clean";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			else if (name.EndsWith("_lit")) 
			{
				name = name.Substring(0, name.Length-4)+"_unlit";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			else if (name.EndsWith("_unlit")) 
			{
				name = name.Substring(0, name.Length-6)+"_lit";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			else if (name.EndsWith("_on")) 
			{
				name = name.Substring(0, name.Length-3)+"_off";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			else if (name.EndsWith("_off")) 
			{
				name = name.Substring(0, name.Length-4)+"_on";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			} 
			else if (name.EndsWith("_shadeinside")) 
			{
				name = name.Substring(0, name.Length-4)+"_shadeoutside";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			else if (name.EndsWith("_shadeoutside")) 
			{
				name = name.Substring(0, name.Length-4)+"_shadeinside";
				pfds = package.FindFile(name+"_txmt", 0x49596978);
			}
			return pfds;
		}		

		/// <summary>
		/// Returns the Primary Guid of the Object
		/// </summary>
		/// <returns>0 or the default guid</returns>
		public uint GetPrimaryGuid()
		{
			uint guid = 0;
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(Data.MetaData.OBJD_FILE, 0, 0x41A7);
			if (pfds.Length==0) pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData(pfds[0], package);
				guid = objd.Guid;
			}
			return guid;
		}

		/// <summary>
		/// Load a List of all available GUIDs in the package
		/// </summary>
		/// <returns>The list of GUIDs</returns>
		public ArrayList GetGuidList()
		{
			ArrayList list = new ArrayList();
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData(pfd, package);
				list.Add(objd.Guid);
			}

			return list;
		}

		/// <summary>
		/// Updates the MMATGuids
		/// </summary>
		/// <param name="guids">list of allowed GUIDS</param>
		/// <param name="primary">the guid you want to use if the guid was not allowed</param>
		public void UpdateMMATGuids(ArrayList guids, uint primary)
		{
			if (primary==0) return;

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.MMAT);
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
				mmat.ProcessData(pfd, package);

				if (!guids.Contains(mmat.GetSaveItem("objectGUID").UIntegerValue)) 
				{
					mmat.GetSaveItem("objectGUID").UIntegerValue = primary;
					mmat.SynchronizeUserData();
				}
			}
		}

		/// <summary>
		/// Clone a InGane Object based on the relations of the RCOL Files
		/// </summary>
		/// <param name="pkg">The package that should contain the Clone</param>
		/// <param name="modelname">The Name of the Model</param>
		/// <param name="loadparent">true if you want to load Parent Objects</param>
		public void RcolModelClone(string modelname, bool onlydefault) 
		{
			if (modelname==null) return;

			string[] ms = new string[1];
			ms[0] = modelname;
			RcolModelClone(ms, onlydefault);
		}

		/// <summary>
		/// Clone a InGame Object based on the relations of the RCOL Files
		/// </summary>
		/// <param name="modelnames">The Name of the Model</param>
		/// <param name="loadparent">true if you want to load Parent Objects</param>
		public void RcolModelClone(string[] modelnames, bool onlydefault) {
			RcolModelClone(modelnames, onlydefault, onlydefault, true, new ArrayList());
		}

		/// <summary>
		/// Clone a InGane Object based on the relations of the RCOL Files
		/// </summary>
		/// <param name="onlydefault">true if you only want default MMAT Files</param>
		/// <param name="updateguid">update the GUIDs in the MMAT Files</param>
		/// <param name="exception">true if you want to load Parent Objects</param>
		/// <param name="exclude">List of ReferenceNames that should be excluded</param>
		public void RcolModelClone(string[] modelnames, bool onlydefault, bool updateguid, bool exception, ArrayList exclude) 
		{
			if (modelnames==null) return;

			SimPe.FileTable.FileIndex.Load();
			WaitingScreen.UpdateMessage("Walking Scenegraph");
			Scenegraph sg = new Scenegraph(modelnames, exclude);
			WaitingScreen.UpdateMessage("Collect Slave TXMTs");
			sg.AddSlaveTxmts(sg.GetSlaveSubsets());
			
			WaitingScreen.UpdateMessage("Building Package");
			sg.BuildPackage(package);
			WaitingScreen.UpdateMessage("Collect MMAT Files");
			sg.AddMaterialOverrides(package, onlydefault, true, exception);
			WaitingScreen.UpdateMessage("Collect Slave TXMTs");
			Scenegraph.AddSlaveTxmts(package, Scenegraph.GetSlaveSubsets(package));
			

			if (updateguid) 
			{
				WaitingScreen.UpdateMessage("Fixing MMAT Files");
				this.UpdateMMATGuids(this.GetGuidList(), this.GetPrimaryGuid());			
			}
		}
	}
}
