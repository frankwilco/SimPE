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
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Abstract Class for implementing new generic FileFormats
	/// </summary>
	public abstract class Generic : SimPe.Interfaces.Plugin.AbstractWrapper, ICollection, IEnumerator, SimPe.Interfaces.Plugin.IFileWrapper
	{
		/// <summary>
		/// Content of the File as Byte Array
		/// </summary>
		private System.IO.BinaryReader reader;

		/// <summary>
		/// Contains the available Items
		/// </summary>
		protected GenericItem[] items;

		/// <summary>
		/// Attributes of the File itself
		/// </summary>
		protected GenericCommon attributes;

		/// <summary>
		/// Returns the Fiel Attributes
		/// </summary>
		public GenericCommon Attributes 
		{
			get 
			{
				return attributes; 
			}
		}

		/// <summary>
		/// Adds a new Entry to the File
		/// </summary>
		/// <param name="fi">The FileItem you want to add</param>
		public void Add(GenericItem fi)
		{
			if (items==null) items = new GenericItem[0];

			GenericItem[] fis = new GenericItem[items.Length+1];
			items.CopyTo(fis, 0);
			fis[fis.Length-1] = fi;

			items = fis;
		}

		/// <summary>
		/// Preparse som Data Structures for the use with ParseData
		/// </summary>
		protected void PrepareData()
		{
			items = null;
		}

		/// <summary>Handles the Taskt neccesary to Parse a File
		/// </summary>
		/// <remarks>
		/// Firs the position of the Reader is set to 0, the the ParseHeader implementation is called. 
		/// If the items Structure is initialized, the ParseFileItem() implementation is called for each 
		/// of the available Items.
		/// </remarks>
		protected void ParseData() 
		{
			PrepareData();			
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);			
			ParseHeader();

			for (int i=0; i<Count; i++) 
			{
				items[i] = new GenericItem();				
				ParseFileItem(items[i]);				
			}
		}		

		/// <summary>
		/// Returns the Number of available Fileitems
		/// </summary>
		public int Count
		{
			get
			{
				if (items!=null) 
				{
					return items.Length;
				} 
				else 
				{
					return 0;
				}
			}
		}

		

		/// <summary>
		/// Returns the Item stored at the given Index
		/// </summary>
		/// <param name="index">The Item Number (0-Based)</param>
		/// <returns>The Entry stored at the given index</returns>
		public GenericItem GetItem(uint index)
		{
			return items[index];
		}

		/// <summary>
		/// Returns the File Items
		/// </summary>
		public GenericItem[] Items 
		{
			get 
			{
				return items;
			}
		}

		/// <summary>
		/// Returns the File Reader
		/// </summary>
		protected System.IO.BinaryReader Reader
		{
			get 
			{
				return reader;
			}
		}

		#region Subhandler Management
		/// <summary>
		/// This delegate is used to register FileHandlers to this generic Handler
		/// </summary>
		/// <remarks>
		/// Subhandlers are used to tell the Generic Handler which FileTypes it should process. 
		/// You can make an association between a FileType and a Methode, that can create a 
		/// File Object for that type. Whenever the generic Handler Processes a File it will 
		/// check it's list of registred Subhandlers to select an apropriate one.<br />
		/// Unfortunatly you can use this Method only with Type-based Assignements opposed to
		/// Signaturebased ones! For them you must override the core Methods FileSignature(),
		/// ProcessData() and CreateSignatureBasedFileObject().
		/// </remarks>
		public delegate SimPe.PackedFiles.Wrapper.Generic CreateFileObject(IPackedFileWrapper wrapper);

		/// <summary>
		/// If no Handler was registred for the Type, the system tries to find
		/// a Signature Based Handler. This Function must return a File Object based on the 
		/// Signature. By Default this Method returns null, so you eventually have to overload 
		/// it
		/// </summary>
		/// <param name="type">The PackedFiles Type</param>
		/// <param name="data">The Binary Data</param>
		/// <returns>in this implementation allways null</returns>
		internal virtual SimPe.PackedFiles.Wrapper.Generic CreateSignatureBasedFileObject(IPackedFileWrapper wrapper)
		{
			return null;
		}

		/// <summary>
		/// Keys of this Hashtable represent the Type ID of the Fiole you want to process, the values
		/// must be CreateFileObject delegates.
		/// </summary>
		protected Hashtable subhandlers = new Hashtable();

		/// <summary>
		/// Retursn the List of SubHandlers
		/// </summary>
		internal Hashtable Subhandlers 
		{
			get 
			{
				return subhandlers;
			}
		}

		/// <summary>
		/// Registers a new Type based SubHandler
		/// </summary>
		/// <param name="type">The Type you want to assign a SubHandler to</param>
		/// <param name="fkt">The Delegate that is used to create the File Object</param>
		/// <returns>true, if the handler was registred</returns>
		protected bool Register(uint type, CreateFileObject fkt) 
		{
			if (subhandlers.ContainsKey(type)) return false;

			subhandlers.Add(type, fkt);
			return true;
		}

		#endregion

		#region Abstract Interface
		/// <summary>
		/// Handles some initializing Tasks for the Binary Data before it is used with the BinaryReader.
		/// This implementation is a simple Placeholder, so you don't have to generate an empty method in
		/// each new class!
		/// </summary>
		/// <remarks>Can be used to determin the count of FileItems based on the Size of the Binary Data</remarks>		
		protected virtual void InitData() 
		{
		}

		/// <summary>
		/// Parses the Header of the File represented by the Reader. This is called when the parsing of the Files 
		/// starts, and can be used to read Header Data.
		/// You also should initialize the items structure (set the length of the Array). If it is not set at this 
		/// point, the ParseFileItem function will never be called!
		/// </summary>
		protected abstract void ParseHeader();

		/// <summary>
		/// Processes the Data stored in the File for one FileItem. This Function is called Count times in a 
		/// sequence.
		/// </summary>
		/// <param name="item">The FileItem you have to assigne the current Data to</param>
		protected abstract void ParseFileItem(GenericItem item);

		/// <summary>
		/// Returns the Name for the currently processed FileType
		/// </summary>
		/// <param name="type">The Type ID of the FIle</param>
		/// <returns>The Name for the given ID</returns>
		public abstract string GetTypeName(uint type);
		#endregion


		#region ICollection Member

		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		public void CopyTo(Array array, int index)
		{
			for (int i=index; i<items.Length; i++)
			{
				array.SetValue(items[i], (i-index));
			}
		}

		public object SyncRoot
		{
			get
			{
				return null;
			}
		}

		#endregion

		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return this;
		}

		#endregion

		#region IEnumerator Member

		private int currentindex;
		public void Reset()
		{
			 currentindex = 0;
		}

		public object Current
		{
			get
			{
				return items[currentindex];
			}
		}

		public bool MoveNext()
		{
			if (currentindex<items.Length-1) 
			{
				currentindex++;
				return true;
			}

			return false;

		}

		#endregion

		#region AbstractHandler Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.Generic();
		}

		public Generic() : base()
		{
			attributes = new ImplementedGenericCommon();
			subhandlers = new Hashtable();
		}

		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			this.reader = reader;
			PrepareData();
			InitData();
			try 
			{
				ParseData();			
			} 
			catch (Exception e) 
			{
				string a = e.Message;
			}			 
			
		}
		#endregion

		#region IFileWrapper Member

		public  uint[] AssignableTypes
		{
			get 
			{				
				uint[] types = new uint[subhandlers.Keys.Count];
				subhandlers.Keys.CopyTo(types, 0);
				return types;
			}
		}

		public virtual Byte[] FileSignature
		{
			get 
			{
				return new Byte[0];
			}
		}

		#endregion
	}
}
