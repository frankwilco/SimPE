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
using SimPe.Interfaces.Files;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class CompressedFileList
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		, System.Collections.IEnumerable
		, System.Collections.IEnumerator
		, System.IDisposable
	{
		#region Attributes
		Data.MetaData.IndexTypes iformat;
		/// <summary>
		/// Returns or Sets wether the type of the Index
		/// </summary>
		public Data.MetaData.IndexTypes IndexType
		{
			get { return iformat; }
			set { iformat = value; }
		}

		

		/// <summary>
		/// Contains all available Items
		/// </summary>		
		private Hashtable items;
		ArrayList ordered;

		/// <summary>
		/// Returns/Sets the Constants
		/// </summary>
		/*public ClstItem[] Items
		{
			get { 
				return items;	
			}
			set 
			{
				items = value;
			}
		}*/
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		internal CompressedFileList() : this(Data.MetaData.IndexTypes.ptShortFileIndex){}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="type">ize of the Package Index</param>
		public CompressedFileList(Data.MetaData.IndexTypes type) : base()
		{		
			iformat = type;
			items = new Hashtable();
			ordered = new ArrayList();
			Reset();
		}

		/// <summary>
		/// Constructor, Initializes the Object with Data from the File
		/// </summary>
		/// <param name="type">ize of the Package Index</param>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		public CompressedFileList(IPackedFileDescriptor pfd, IPackageFile package) : base()
		{		
			iformat = package.Header.IndexType;
			items = new Hashtable();
			ordered = new ArrayList();
			this.ProcessData(pfd, package);
		}

		/// <summary>
		/// Returns the Number of the File matching the passed Descriptor
		/// </summary>
		/// <param name="pfd">A PackedFileDescriptor</param>
		/// <returns>-1 if none was foudn or the index number of the first matching file</returns>
		public int FindFile(IPackedFileDescriptor pfd)
		{
			if (items == null) 
				return -1;

			object o = items[new ClstItem(pfd, this.IndexType)];
			if (o!=null) 
				return (int)o;			

			return -1;
		}

		/// <summary>
		/// Adds a new File to the Items
		/// </summary>
		/// <param name="item">the new File</param>
		public void Add(ClstItem item) 
		{
			if (item==null) return;
			if (items.ContainsKey(item)) 
			{
				throw new Warning("Duplicated Entry in Directory of Compressed Files!", "The Resource "+item.ToString()+" was added twice!");
			} 
			else 
			{
				items.Add(item, items.Count);
				ordered.Add(item);
			}
		}

		public ClstItem this[int index]
		{
			get 
			{
				return (ClstItem)ordered[index];
			} 
			set 
			{
				ordered[index] = value;
			}
		}

		public int Length
		{
			get { return ordered.Count; }
		}

		public void Clear()
		{
			items.Clear();
			ordered.Clear();
		}

		
		#region IWrapper member
		public override bool CheckVersion(uint version) { return true; }
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new UserInterface.ClstForm();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Compressed File Directory Wrapper",
				"Quaxi",
				"This File contains a List of all compressed Files that are stored within this Package.",
				4,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.clst.png"))
				);   
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			this.IndexType = package.Header.IndexType;
			long count = 0;
			if(iformat == Data.MetaData.IndexTypes.ptLongFileIndex) 
				count = reader.BaseStream.Length / 0x14;
			else
				count = reader.BaseStream.Length / 0x10;
			items.Clear();

			long pos = reader.BaseStream.Position;
			bool switch_t = false;
			for (int i=0; i< count; i++) 
			{
				ClstItem item = new ClstItem(this.IndexType);
				item.Unserialize(reader);
				

				if ((i==2)  && (!switch_t))
				{
					switch_t = true;
					if (Package.FindFile(item.Type, item.SubType, item.Group, item.Instance)==null) 
					{
						i=0;
						if (iformat == Data.MetaData.IndexTypes.ptLongFileIndex) iformat = Data.MetaData.IndexTypes.ptShortFileIndex;
						else iformat = Data.MetaData.IndexTypes.ptLongFileIndex;

						reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
						item = new ClstItem(this.IndexType);
						item.Unserialize(reader);
					}
				}

				Add(item);//items[i] = item;
			}
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		protected override void Serialize(System.IO.BinaryWriter writer)
		{			
			foreach (ClstItem item in items.Keys) 
			{
				item.Serialize(writer, this.IndexType);
			}
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public byte[] FileSignature
		{
			get
			{
				Byte[] sig = {
								 
							 };
				return sig;
			}
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								  0xE86B1EEF	//clst 	
							   };
			
				return types;
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
		int cur;
		public void Reset()
		{
			cur = -1;
		}

		public object Current
		{
			get
			{
				if (cur<ordered.Count && cur>=0) return this[cur];
				return null;
			}
		}

		public bool MoveNext()
		{
			if (cur<ordered.Count-1 && cur>=-1) cur++;
			else return false;

			return true;
		}

		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			if (items!=null) this.items.Clear();
			if (ordered!=null) this.ordered.Clear();
		}

		#endregion
	}
}
