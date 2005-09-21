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
using SimPe.Interfaces.Plugin;
using SimPe.PackedFiles.Wrapper;

namespace SimPe
{
	/// <summary>
	/// This class will build a virtual .package Resource containing all Lua Scripts
	/// </summary>
	public class ObjLuaLoader
	{

		static SimPe.Packages.GeneratableFile pkg;

		/// <summary>
		/// Create the virtual Lua Package
		/// </summary>
		static void CreatePackge()
		{
			pkg = SimPe.Packages.File.CreateNew();

			LoadFromFolder(System.IO.Path.Combine(SimPe.Helper.WindowsRegistry.SimsEP2Path, "TSData/Res/ObjectScripts"), "globalObjLua", 0x0);
			LoadFromFolder(System.IO.Path.Combine(SimPe.Helper.WindowsRegistry.SimsEP2Path, "TSData/Res/ObjectScripts"), "ObjLua", 0x2000);
		}

		/// <summary>
		/// Load availabe lua resources from the FileSystem
		/// </summary>
		/// <param name="dir">The directory you want to scan</param>
		/// <param name="ext">The fiel extension to check</param>
		/// <param name="group">The group you want to assigne the loaded Files to</param>
		/// <remarks>Instance of the loaded resources will be the hash over the FeleName</remarks>
		static void LoadFromFolder(string dir, string ext, uint group)
		{
			if (!System.IO.Directory.Exists(dir)) return;
			
			string[] fls = System.IO.Directory.GetFiles(dir, "*."+ext);
			foreach (string fl in fls)
			{
				string name = System.IO.Path.GetFileName(fl);
				System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.MemoryStream());
				try 
				{
					bw.Write(Helper.ToBytes(name, 0x40));

					System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.Open(fl, System.IO.FileMode.Open));
					try 
					{
						bw.Write(br.ReadBytes((int)br.BaseStream.Length));
					} 
					finally 
					{
						br.Close();
					}

					br = new System.IO.BinaryReader(bw.BaseStream);
					br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

					
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.NewDescriptor(
						0x61754C1B, 
						Hashes.SubTypeHash(name),
						group,
						Hashes.InstanceHash(name)
						);

					pfd.UserData = br.ReadBytes((int)br.BaseStream.Length);
					pfd.Changed = false;
					pkg.Add(pfd);
				} 
				finally 
				{
					bw.Close();
				}
			}
		}

		/// <summary>
		/// Returns a virtual Package, containing LUA Resources
		/// </summary>
		public static SimPe.Packages.GeneratableFile VirtualPackage
		{
			get 
			{
				if (pkg==null) CreatePackge();
				return pkg;
			}
		}
	}
}
