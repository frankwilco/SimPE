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
	public class ObjectCacheFile: CacheFile
	{
		/// <summary>
		/// Creaet a new Instance for an empty File
		/// </summary>
		public ObjectCacheFile() : base()
		{
			DEFAULT_TYPE = ContainerType.Object;
		}		

		/// <summary>
		/// Add a Object Item to the Cache
		/// </summary>
		/// <param name="oci">The Cache Item</param>
		/// <param name="filename">name of the package File where the Object was in</param>
		public void AddItem(ObjectCacheItem oci, string filename) 
		{
			CacheContainer mycc = this.UseConatiner(ContainerType.Object, filename);						
			mycc.Items.Add(oci);
		}

		FileIndex fi;
		/// <summary>
		/// Return the FileIndex represented by the Cached Files
		/// </summary>
		public FileIndex FileIndex 
		{
			get { 
				if (fi==null) LoadObjects();
				return fi; 
			}
		}

		/// <summary>
		/// Creates a FileIndex with all available MMAT Files
		/// </summary>
		/// <returns>the FileIndex</returns>
		/// <remarks>
		/// The Tags of the FileDescriptions contain the MMATCachItem Object, 
		/// the FileNames of the FileDescriptions contain the Name of the package File
		/// </remarks>
		public void LoadObjects()
		{
			fi = new FileIndex(new ArrayList());
			fi.Duplicates = true;
			
			foreach (CacheContainer cc in Containers) 
			{
				if (cc.Type==ContainerType.Object && cc.Valid) 
				{
					foreach (ObjectCacheItem mci in cc.Items) 
					{
						Interfaces.Files.IPackedFileDescriptor pfd = mci.FileDescriptor;
						pfd.Filename = cc.FileName;
						fi.AddIndexFromPfd(pfd, null, FileIndex.GetLocalGroup(pfd.Filename));
					}
				}
			}//foreach
		}

	}
}
