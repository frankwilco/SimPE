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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Str
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
		/// <summary>
		/// Maximum Number of Lines to load
		/// </summary>
		int limit;

		/// <summary>
		/// Contains the Filename
		/// </summary>
		byte[] filename;	
	
		/// <summary>
		/// Returns the Filename
		/// </summary>
		public string FileName 
		{
			get { return Helper.ToString(filename); }
		}

		/// <summary>
		/// Format Code of the FIle
		/// </summary>
		SimPe.Data.MetaData.FormatCode format;

			/// <summary>
		/// Returns /Sets the Format Code
		/// </summary>
		public SimPe.Data.MetaData.FormatCode Format
		{
			get { return format; }			
			set { format = value; }
		}
		
		/// <summary>
		/// Returns/Sets the Constants
		/// </summary>
		public StrItemList Items
		{
			get { 
				StrItemList items = new StrItemList();
				StrLanguageList lngs = Languages;
				foreach (StrLanguage k in lngs) items.AddRange((StrItemList)lines[k.Id]);

				return items;
			}			
			set {
				lines = new Hashtable();
				foreach (StrItem i in value) this.Add(i);
			}
		}

		/// <summary>
		/// Returns/Sets all stored lines
		/// </summary>
		/// <remarks>This is the fastes way to acces the String Items!</remarks>
		public Hashtable Lines
		{
			get { return lines; }
			set { lines = value; }
		}

		/// <summary>
		/// Returns the list of Languages
		/// </summary>
		public StrLanguageList Languages 
		{
			get 
			{
				StrLanguageList lngs = new StrLanguageList();
				foreach (byte k in lines.Keys) lngs.Add(k);
				lngs.Sort();

				return lngs;
			}
			set 
			{
				foreach (StrLanguage l in value) 
				{
					if (!lines.ContainsKey(l.Id)) lines.Add(l.Id, new StrItemList());
				}
			}
		}

		/// <summary>
		/// Contains all StrItems by Language
		/// </summary>
		Hashtable lines;
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public Str(int limit) : base()
		{		
			filename = new byte[64];
			format = SimPe.Data.MetaData.FormatCode.normal;
			lines = new Hashtable();
			this.limit = limit;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Str() : base()
		{		
			filename = new byte[64];
			format = SimPe.Data.MetaData.FormatCode.normal;
			lines = new Hashtable();
			this.limit = 0;
		}

		/// <summary>
		/// Returns all Langugae specific Strings
		/// </summary>
		/// <param name="l">the Language</param>
		/// <returns>List of Strings</returns>
		public StrItemList LanguageItems(StrLanguage l) 
		{			
			if (l==null) return new StrItemList();			
			return LanguageItems((Data.MetaData.Languages)l.Id);
		}

		/// <summary>
		/// Returns all Langugae specific Strings
		/// </summary>
		/// <param name="l">the Language</param>
		/// <returns>List of Strings</returns>
		public StrItemList LanguageItems(Data.MetaData.Languages l) 
		{	
			
			StrItemList items = (StrItemList)lines[(byte)l];
			if (items==null) items = new StrItemList();
			
			return items;
		}

		/// <summary>
		/// Returns a Language String (if available in the passed Language)
		/// </summary>
		/// <param name="l">the Language</param>
		/// <returns>List of Strings</returns>
		public StrItem FallbackedLanguageItem(Data.MetaData.Languages l, int index)
		{
			StrItemList list = this.LanguageItems(l);
			StrItem name = null;
			if (list.Length>index) name = list[index];

			if (name==null) name = new StrItem();
			 
			if (name.Title.Trim()=="") 
			{
				list = this.LanguageItems(1);
				if (list.Length>index) name = list[index];
			}
			

			return name;
		}

		/// <summary>
		/// Returns all Langugae specific Strings, if the String is not included in the passed 
		/// Language the Fallback String (use en) will be returned
		/// </summary>
		/// <param name="l">the Language</param>
		/// <returns>List of Strings</returns>
		public StrItemList FallbackedLanguageItems(Data.MetaData.Languages l)
		{
			if (l==Data.MetaData.Languages.English) return this.LanguageItems(l);

			StrItemList real = (StrItemList)LanguageItems(l).Clone();
			StrItemList fallback = LanguageItems(Data.MetaData.Languages.English);			

			int ct = Math.Min(real.Length, fallback.Length);
			for (int i=0; i<fallback.Length; i++) 
			{
				if (real.Length<=i) real.Add(null);
	
				if (real[i]==null)
				{
					StrItem item = new StrItem();
					item.Language = new StrLanguage((byte)l);
					item.Index = i;
					real[i] = item;
				}			

				if (real[i].Title.Trim()=="") 
				{
					real[i] = fallback[i];					
				}
			}

			return real;
		}
		

		/// <summary>
		/// Ensures that all String Items are Valid
		/// </summary>
		public void MakeValid()		
		{
			foreach (StrItem i in this.Items)i.MakeValid();			
		}

		/// <summary>
		/// Adds a new String Item
		/// </summary>
		/// <param name="item">The Item you want to add</param>
		public void Add(StrItem item)
		{
			StrItemList lng = (StrItemList)lines[item.Language.Id];
			if (lng == null) 
			{
				lng = new StrItemList();
				lines[item.Language.Id] = lng;
			}

			lng.Add(item);
		}		

		/// <summary>
		/// Removes this Item From the List
		/// </summary>
		/// <param name="item">The Item you want to remove</param>
		public void Remove(StrItem item)
		{
			StrItemList lng = (StrItemList)lines[item.Language.Id];
			if (lng != null) lng.Remove(item);
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			return true;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new UserInterface.StrUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Text List Wrapper",
				"Quaxi",
				"---",
				9
				);  
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			lines = new Hashtable();
			if (reader.BaseStream.Length <= 0x40) return;
			
			filename = reader.ReadBytes(0x40);
			format = (SimPe.Data.MetaData.FormatCode) reader.ReadUInt16();

			if (format!=Data.MetaData.FormatCode.normal) return;

			ushort count = reader.ReadUInt16();
			for (int i=0; i<count; i++) 
			{
				StrItem item = new StrItem();
				item.Unserialize(reader, lines);
				
				//load a limited Number
				if (limit!=0) if (i+1>=limit) return;
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
			writer.Write(filename);
			writer.Write((ushort)format);
			ArrayList lngs = this.Languages;

			ArrayList items = new ArrayList();
			foreach (StrLanguage k in lngs) items.AddRange((ArrayList)lines[k.Id]);
			writer.Write((ushort)items.Count);

			foreach (StrItem i in items) 
			{
				i.Serialize(writer);
			}//foreach language
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member
		public override string Description
		{
			get
			{
				string n = "filename="+this.FileName+", languages="+this.Languages.Length.ToString()+", lines="+this.Items.Length.ToString();
				StrItemList list = this.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				foreach (StrItem i in list) 
				{
					n +=", first="+i.Title;
					if (i.Title!="") break;
				}
				return n;
			}
		}
		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public byte[] FileSignature
		{
			get
			{
				return new byte[0];
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
								   0x53545223,  //STR#
								   0x54544173,  //Pie String
								   0x43545353  //CTSS	
							   };
			
				return types;
			}
		}

		#endregion		
	}
}
