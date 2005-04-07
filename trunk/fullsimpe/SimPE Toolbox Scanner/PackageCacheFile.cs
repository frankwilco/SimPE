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
using SimPe;
using SimPe.Plugin;


namespace SimPe.Cache
{
	/// <summary>
	/// Contains an Instance of a CacheFile
	/// </summary>
	internal class PackageCacheFile: CacheFile
	{
		public static string CacheFileName
		{
			get { return Helper.GetSimPeLanguageCache("scanner_"); }
		}

		/// <summary>
		/// Creaet a new Instance for an empty File
		/// </summary>
		public PackageCacheFile() : base()
		{
			DEFAULT_TYPE = ContainerType.Package;
		}		

		/// <summary>
		/// Load/Add a Cache Item for the passed File
		/// </summary>
		/// <param name="filename">The Name of the File</param>
		public ScannerItem LoadItem(string filename) 
		{
			CacheContainer mycc = this.UseConatiner(ContainerType.Package, filename);
			
			if (mycc.Items.Count==0) 
			{
				PackageCacheItem pci = new PackageCacheItem();
				ScannerItem item = new ScannerItem(pci, mycc);	
				item.FileName = filename;
				pci.Name = System.IO.Path.GetFileNameWithoutExtension(filename);						
				mycc.Items.Add(pci);

				return item;
			} 
			else 
			{
				ScannerItem item = new ScannerItem((PackageCacheItem)mycc.Items[0], mycc);
				item.FileName = filename;

				return item;
			}
		}

		Hashtable map;
		/// <summary>
		/// Return the FileIndex represented by the Cached Files
		/// </summary>
		public Hashtable Map 
		{
			get { 
				if (map==null) LoadFiles();
				return map; 
			}
		}

		/// <summary>
		/// Creates the Map
		/// </summary>
		/// <returns>the FileIndex</returns>
		/// <remarks>
		/// The Tags of the FileDescriptions contain the MMATCachItem Object, 
		/// the FileNames of the FileDescriptions contain the Name of the package File
		/// </remarks>
		public void LoadFiles()
		{
			map = new Hashtable();
			

			foreach (CacheContainer cc in Containers) 
			{
				if (cc.Type==ContainerType.Package && cc.Valid) 
				{
					foreach (PackageCacheItem item in cc.Items) 
					{
						ScannerItem si = new ScannerItem(item, cc);
						si.FileName = cc.FileName;
						map[si.FileName.Trim().ToLower()] = item;
					}
				}
			}//foreach
		}			
	}
}
