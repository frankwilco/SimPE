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
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class GenericRcol : Rcol, IScenegraphItem
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public GenericRcol(Interfaces.IProviderRegistry provider, bool fast) : base(provider, fast)
		{
		}

		public GenericRcol() : base() {}

		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new RcolUI();
		}		
		#endregion


		#region IFileWrapper Member
		public override string Description
		{
			get
			{
				string str = "filename=";
				str += this.FileName;
				str += ", references=";
				Hashtable map = this.ReferenceChains;
				foreach (string s in map.Keys) 
				{
					str += s+": ";
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in (ArrayList)map[s])
					{
						str += pfd.Filename+" ("+pfd.ToString()+") | ";						
					}
					if (((ArrayList)map[s]).Count>0) str = str.Substring(0, str.Length-2);
					str += ",";
				}
				if (map.Count>0) str = str.Substring(0, str.Length-1);

				return str;
			}
		}
		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public override uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								   ScenegraphHelper.TXMT,
								   ScenegraphHelper.CRES,
								   ScenegraphHelper.GMND,
								   ScenegraphHelper.GMDC,
								   ScenegraphHelper.SHPE,
								   Data.MetaData.ANIM,   //ANIM
								   0x4D51F042,	//CINE
								   Data.MetaData.LDIR,	
								   Data.MetaData.LAMB,
								   Data.MetaData.LPNT,
								   Data.MetaData.LSPT
							   };
				return types;
			}
		}

		#endregion		

		/// <summary>
		/// Subcallses can reimplement this Method to add additional References
		/// </summary>
		/// <param name="refmap">The Reference Map, Keys are the name of the Reference type, values are ArrayLists containing IPackedFileDescriptors</param>
		protected virtual void FindReferences(Hashtable refmap)
		{
		}


		/// <summary>
		/// Add te References stored in the Reference Section
		/// </summary>
		/// <param name="refmap">The Reference Map, Keys are the name of the Reference type, values are ArrayLists containing IPackedFileDescriptors</param>
		void FindGenericReferences(Hashtable refmap)
		{
			ArrayList list = new ArrayList();
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in this.ReferencedFiles) list.Add(pfd);
			
			refmap["Generic"] = list;

			//now check each stored block if it implements IScenegraphBlock
			foreach (IRcolBlock irb in this.Blocks)
			{
				if (typeof(IScenegraphBlock) == irb.GetType().GetInterface("IScenegraphBlock"))
				{
					IScenegraphBlock sgb = (IScenegraphBlock)irb;
					sgb.ReferencedItems(refmap, this.FileDescriptor.Group);
				}
			}
		}

		#region IScenegraphItem Member	
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem FindReferencedType(uint type)
		{
			

			foreach (ArrayList list in ReferenceChains.Values)
				foreach (object o in list)
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor opfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)o;					
					if (opfd.Type == type) 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor pfd = Package.FindFile(opfd);
						if (pfd==null) { opfd.Group = this.FileDescriptor.Group; pfd = Package.FindFile(opfd); }
						if (pfd==null) { opfd.Group = Data.MetaData.LOCAL_GROUP; pfd = Package.FindFile(opfd); }						
						SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = null;
						if (pfd == null) 
						{				
							FileTable.FileIndex.Load();
							SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile((SimPe.Interfaces.Files.IPackedFileDescriptor)o, null);										
							if (items.Length>0) item = items[0];
						}
						else 					
							item = FileTable.FileIndex.CreateFileIndexItem(pfd, Package);					

						if (item!=null) 
							return item;
					}
				}
			return null;
		}

		public Hashtable ReferenceChains
		{
			get
			{
				Hashtable refmap = new Hashtable();
				FindGenericReferences(refmap);
				FindReferences(refmap);
				return refmap;
			}
		}

		#endregion
	}
}
