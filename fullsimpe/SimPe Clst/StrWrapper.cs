/***************************************************************************
 *   Copyright (C) 2005 by Peter L Jones                                   *
 *   peter@drealm.info                                                     *
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
		/// Contains the Filename
		/// </summary>
		byte[] filename;

		/// <summary>
		/// Format Code of the FIle
		/// </summary>
		SimPe.Data.MetaData.FormatCode format;

		/// <summary>
		/// Contains all StrItems by Language
		/// </summary>
		Hashtable lines;

		/// <summary>
		/// Maximum Number of Lines to load
		/// </summary>
		int limit;
		#endregion

		#region Accessor methods
		/// <summary>
		/// Returns the Filename
		/// </summary>
		public string FileName 
		{
			get { return Helper.ToString(filename); }
			set
			{
				if (value.Length < 64)
				{
					char[] cs = value.ToCharArray();
					for (int i = 0; i < value.Length; i++)
						filename[i] = (byte)cs[i];
					for (int i = value.Length; i < 64; i++)
						filename[i] = 0;
				}
			}
		}

		/// <summary>
		/// Returns /Sets the Format Code
		/// </summary>
		public SimPe.Data.MetaData.FormatCode Format
		{
			get { return format; }			
			set { format = value; } // should check it's valid
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
		#endregion

		#region Extended accessor methods

		/// <summary>
		/// Gets or Sets the list of languages in the file
		/// </summary>
		/// <remarks>Adds empty lists when setting for missing languages</remarks>
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
		/// Adds a new String Item
		/// </summary>
		/// <param name="item">The Item you want to add</param>
		public void Add(StrToken item)
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
		public void Remove(StrToken item)
		{
			StrItemList lng = (StrItemList)lines[item.Language.Id];
			if (lng != null) lng.Remove(item);
		}


		/// <summary>
		/// StrItemList interface to the lines hashtable
		/// </summary>
		public StrItemList Items
		{
			get 
			{ 
				StrItemList items = new StrItemList();
				StrLanguageList lngs = Languages;
				foreach (StrLanguage k in lngs) items.AddRange((StrItemList)lines[k.Id]);

				return items;
			}			
			set 
			{
				lines = new Hashtable();
				foreach (StrToken i in value) this.Add(i);
			}
		}

		/// <summary>
		/// Returns all Language-specific Strings
		/// </summary>
		/// <param name="l">the Language</param>
		/// <returns>List of Strings</returns>
		public StrItemList LanguageItems(StrLanguage l) 
		{			
			if (l==null) return new StrItemList();			
			return LanguageItems((Data.MetaData.Languages)l.Id);
		}

		/// <summary>
		/// Returns all Language-specific Strings
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
		public StrToken FallbackedLanguageItem(Data.MetaData.Languages l, int index)
		{
			StrItemList list = this.LanguageItems(l);
			StrToken name;
			if (list.Length>index) name = list[index];
			else name = new StrToken(0, 0, "", "");
			 
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
			StrItemList fallback = null;	
			if (this.Languages.Contains(Data.MetaData.Languages.English))
				fallback = LanguageItems(Data.MetaData.Languages.English);	
			else if (this.Languages.Count==1)
			{
				fallback = LanguageItems(Languages[0]);	
			}
			else fallback = LanguageItems(Data.MetaData.Languages.English);	
					

			for (int i=0; i<fallback.Length; i++) 
				if (real.Length <= i) real.Add(fallback[i]);
				else if ((real[i] == null) || (real[i].Title.Trim() == ""))
					real[i] = fallback[i];
			return real;
		}
		

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
		/// Removes all String Items that are not assigned to the Default Language
		/// </summary>
		public void ClearNonDefault()
		{			
			StrItemList sil = this.Items;
			foreach (StrToken si in sil) 
				if (si.Language.Id!=1) 
					this.Remove(si);
		}

		/// <summary>
		/// Copy the content of the Default Language down to the other Languages
		/// </summary>
		public void CopyFromDefaultToAll()
		{
			StrItemList sil = this.Items;
			StrItemList def = this.LanguageItems(new StrLanguage(1));
			foreach (StrToken si in sil) 
				if (si.Language.Id!=1) 				
					if (si.Index>0 && si.Index<def.Count)
					{
						si.Title = def[si.Index].Title;
						si.Description = def[si.Index].Description;
					}				
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
			return new UserInterface.StrForm();
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
				"This File contains Text Resources in various Languages.",
				9,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.txt.png"))
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
			
			byte[] fi = reader.ReadBytes(0x40);

			SimPe.Data.MetaData.FormatCode fo = (SimPe.Data.MetaData.FormatCode)reader.ReadUInt16();
			if (fo != Data.MetaData.FormatCode.normal) return;

			ushort count = reader.ReadUInt16();

			filename = fi;
			format = fo;
			lines = new Hashtable();

			if ((limit != 0) && (count > limit)) count = (ushort)limit;	// limit number of StrItem entries loaded
			for (int i = 0; i < count; i++) StrToken.Unserialize(reader, lines);
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

			foreach (StrToken i in items) 
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
				foreach (StrToken i in this.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode))
					if (i.Title != "")
						return n + ", first=" + i.Title;
				return n + " (no strings)";
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
		/// Returns a list of File Types this Plugin can process
		/// </summary>
		public uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								   0x53545223,  //STR#
								   0x54544173,  //Pie String (TTAB)
								   0x43545353   //CTSS
							   };
			
				return types;
			}
		}

		#endregion		
	}
}
