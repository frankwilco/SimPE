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
	internal class ObjdItem 
	{
		public ushort val;
		public long position;
	}

	/// <summary>
	/// Represents a PackedFile in SDsc Format
	/// </summary>
	public class Objd : AbstractWrapper, SimPe.Interfaces.Plugin.IFileWrapper, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
	{
		/// <summary>
		///the stored Filename		
		/// </summary>
        private byte[] filename;

		/// <summary>
		/// The Type of this File
		/// </summary>
		private ushort type; 

		/// <summary>
		/// Spaces of unknown Data
		/// </summary>
		private byte[] reserved_01;
		/// <summary>
		/// Spaces of unknown Data
		/// </summary>
		private byte[] reserved_02;
		

		/// <summary>
		/// Returns the Name of a Sim
		/// </summary>
		/*public string SimName
		{
			get 
			{
				string n = FileName;
				int p = n.IndexOf(" - ");
				if (p==-1) return "Unknown";
				else 
				{
					p += 3;
					return n.Substring(p, n.Length - p).Trim();
				}
				
			}			
		}*/


		/// <summary>
		/// Returns/Sets the Name of a Sim
		/// </summary>
		public string FileName
		{
			get 
			{
				/*string s = "";
				System.IO.MemoryStream ms = new System.IO.MemoryStream(filename);
				System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
				try 
				{
					while (br.BaseStream.Position < br.BaseStream.Length)
					{
						if (br.PeekChar()==0) break;
						s += br.ReadChar();
					}
				} 
				catch (Exception) {};*/
				return Helper.ToString(filename);
			}		
			set 
			{
				filename = Helper.SetLength(Helper.ToBytes(value, 64), 64);
			}
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint Guid
		{
			get { return SimId; }
			set { SimId = value; }
		}

		uint guid, proxyguid, originalguid;
		ushort ctssid;

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint SimId
		{
			get { return guid; }
			set { guid = value; }
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint ProxyGuid
		{
			get { return proxyguid; }
			set { proxyguid = value; }
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint OriginalGuid
		{
			get { return originalguid; }
			set { originalguid = value; }
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		protected uint InternalGUID
		{
			get { 
				uint simid = (uint)((GetAttributeShort("guid_2 - Read Only") << 16) + GetAttributeShort("guid_1 - Read Only"));
				return simid;	
			}
			set { 
				uint simid = value; 
				ObjdItem guid1 = (ObjdItem)attr["guid_1 - Read Only"];
				if (guid1==null) guid1 = new ObjdItem();
				guid1.val = (ushort)(simid & 0xffff);
				attr["guid_1 - Read Only"] = guid1;

				ObjdItem guid2 = (ObjdItem)attr["guid_2 - Read Only"];
				if (guid2==null) guid1 = new ObjdItem();
				guid2.val = (ushort)((simid >> 16) & 0xffff);
				attr["guid_2 - Read Only"] = guid2;
			}
		}

		/// <summary>
		/// Returns the Template GUID
		/// </summary>
		protected uint InternalTemplateGUID
		{
			get 
			{ 
				uint simid = (uint)((GetAttributeShort("Proxy GUID 2") << 16) + GetAttributeShort("Proxy GUID 1"));
				return simid;	
			}
			set 
			{ 
				uint simid = value; 
				ObjdItem guid1 = (ObjdItem)attr["Proxy GUID 1"];
				if (guid1==null) guid1 = new ObjdItem();
				guid1.val = (ushort)(simid & 0xffff);
				attr["guid_1 - Read Only"] = guid1;

				ObjdItem guid2 = (ObjdItem)attr["Proxy GUID 2"];
				if (guid2==null) guid1 = new ObjdItem();
				guid2.val = (ushort)((simid >> 16) & 0xffff);
				attr["guid_2 - Read Only"] = guid2;
			}
		}

		/// <summary>
		/// Returns the Original GUID
		/// </summary>
		protected uint InternalOriginalGUID
		{
			get 
			{ 
				uint simid = (uint)((GetAttributeShort("original guid 2 - Read Only") << 16) + GetAttributeShort("original guid 1 - Read Only"));
				return simid;	
			}
			set 
			{ 
				uint simid = value; 
				ObjdItem guid1 = (ObjdItem)attr["original guid 1 - Read Only"];
				if (guid1==null) guid1 = new ObjdItem();
				guid1.val = (ushort)(simid & 0xffff);
				attr["guid_1 - Read Only"] = guid1;

				ObjdItem guid2 = (ObjdItem)attr["original guid 2 - Read Only"];
				if (guid2==null) guid1 = new ObjdItem();
				guid2.val = (ushort)((simid >> 16) & 0xffff);
				attr["guid_2 - Read Only"] = guid2;
			}
		}


		/// <summary>
		/// returns the Instance of the assigned Catalog Description
		/// </summary>
		public ushort CTSSId 
		{
			get { return ctssid; }
		}

		/// <summary>
		/// Retursn / Sets the Type of an Object
		/// </summary>
		public ushort Type 
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Returns a stored Attribute as Unsigned short Value
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public ushort GetAttributeShort(string name) 
		{
			object o = attr[name];
			if (o==null) return 0;
			else return ((ObjdItem)o).val;
		}

		/// <summary>
		/// Returns the position of the Attribute in the Stream
		/// </summary>
		/// <param name="name">Name of the Attribute</param>
		/// <returns></returns>
		public long GetAttributePosition(string name) 
		{
			object o = attr[name];
			if (o==null) return 0;
			else return ((ObjdItem)o).position;
		}

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"OBJD Wrapper",
				"Quaxi",
				"---",
				3
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.Objd();
		}

		Interfaces.Providers.IOpcodeProvider opcodes;
		public Objd(Interfaces.Providers.IOpcodeProvider opcodes) : base()
		{			
			filename = new byte[0];
			reserved_01 = new byte[0];
			reserved_02 = new byte[0];
			items = new ArrayList();
			attr = new Hashtable();
			this.opcodes = opcodes;
			type = 1;
		}

		protected override void Unserialize(System.IO.BinaryReader reader)
		{						
			attr = new Hashtable();
			filename = reader.ReadBytes(0x40);	
			long pos = reader.BaseStream.Position;
			if (reader.BaseStream.Length>=0x54) 
			{
				reader.BaseStream.Seek(0x52, System.IO.SeekOrigin.Begin);
				type = reader.ReadUInt16();
			} 
			else type = 0;

			if (reader.BaseStream.Length>=0x60) 
			{
				reader.BaseStream.Seek(0x5C, System.IO.SeekOrigin.Begin);
				guid = reader.ReadUInt32();
			} 
			else guid = 0;

			if (reader.BaseStream.Length>=0x7E) 
			{
				reader.BaseStream.Seek(0x7A, System.IO.SeekOrigin.Begin);
				proxyguid = reader.ReadUInt32();
			} 
			else proxyguid = 0;

			if (reader.BaseStream.Length>=0x94) 
			{
				reader.BaseStream.Seek(0x92, System.IO.SeekOrigin.Begin);
				ctssid = reader.ReadUInt16();
			} 
			else ctssid = 0;

			if (reader.BaseStream.Length>=0xD0) 
			{
				reader.BaseStream.Seek(0xCC, System.IO.SeekOrigin.Begin);
				originalguid = reader.ReadUInt32();
			} 
			else originalguid = 0;
			
			
			reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);

			ArrayList names = new ArrayList();			
			if (opcodes!=null) names = opcodes.OBJDDescription(type);
			if (names.Count == 0)
			{
				/*reserved_01 = reader.ReadBytes(0x1C);			
				//simid = reader.ReadUInt32();
				ObjdItem item = new ObjdItem();
				item.position = reader.BaseStream.Position;
				item.val = reader.ReadUInt16();
				attr["guid_1 - Read Only"] = item;

				item = new ObjdItem();
				item.position = reader.BaseStream.Position;
				item.val = reader.ReadUInt16();
				attr["guid_2 - Read Only"] = item;				
				reserved_02 = reader.ReadBytes((int)(reader.BaseStream.Length - (reader.BaseStream.Position)));

				item = new ObjdItem();
				item.position = reader.BaseStream.Position;
				if (reader.BaseStream.Length>=0x90) 
				{
					reader.BaseStream.Seek(0x8E, System.IO.SeekOrigin.Begin);
					item.val = reader.ReadUInt16();

					ObjdItem item2 = new ObjdItem();
					item2.position = reader.BaseStream.Position;
					item2.val = reader.ReadUInt16();
					attr["function sort flags"] = item2;
				} 
				else item.val = 0;
				attr["room sort flags"] = item;

				item = new ObjdItem();
				item.position = reader.BaseStream.Position;
				if (reader.BaseStream.Length>=0x94) 
				{
					reader.BaseStream.Seek(0x92, System.IO.SeekOrigin.Begin);
					item.val = reader.ReadUInt16();
				} 
				else item.val = 0;
				attr["catalog strings id"] = item;	*/			
			} 
			else 
			{
								
				foreach (string name in names) 
				{
					if (reader.BaseStream.Position > reader.BaseStream.Length-2) break;
					ObjdItem item = new ObjdItem();
					item.position = reader.BaseStream.Position;
					item.val = reader.ReadUInt16();
					string sname = name;
					if (name.Trim()=="") sname = "0x"+Helper.HexString((uint)item.position);
					attr[sname] = item;
				}

				/*guid = this.InternalGUID;
				proxyguid = this.InternalTemplateGUID;
				originalguid = this.InternalOriginalGUID;*/
			}
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(filename);

			ArrayList names = new ArrayList();			
			if (opcodes!=null) names = opcodes.OBJDDescription(type);
			if (names.Count == 0) 
			{
				writer.Write(reserved_01);			
				//writer.Write(simid);
				writer.Write(this.GetAttributeShort("guid_1 - Read Only"));
				writer.Write(this.GetAttributeShort("guid_2 - Read Only"));
				writer.Write(reserved_02);	
			} 
			else 
			{
				/*this.InternalGUID = guid;
				this.InternalOriginalGUID = originalguid;
				this.InternalTemplateGUID = proxyguid;*/
				foreach (string name in names) 
				{
					
					string sname = name;
					if (sname.Trim()=="") 
						sname = "0x"+Helper.HexString((uint)writer.BaseStream.Position);
					if (attr[sname]==null) 
						break;
					writer.Write(this.GetAttributeShort(sname));
				}
				ctssid = this.GetAttributeShort("catalog strings id");
			}

			writer.BaseStream.Seek(0x52, System.IO.SeekOrigin.Begin);
			writer.Write(type);

			writer.BaseStream.Seek(0x5C, System.IO.SeekOrigin.Begin);
			writer.Write(guid);

			writer.BaseStream.Seek(0x7A, System.IO.SeekOrigin.Begin);
			writer.Write(proxyguid);

			writer.BaseStream.Seek(0x92, System.IO.SeekOrigin.Begin);
			writer.Write(ctssid);

			writer.BaseStream.Seek(0xCC, System.IO.SeekOrigin.Begin);
			writer.Write(originalguid);
		}
		#endregion

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0x4F424A44
							   };
				return Types;
			}
		}


		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {					 
							 };
				return sig;
			}
		}		

		

		#endregion

		#region IPackedFileProperties Member

		Hashtable attr;
		ArrayList items;
		/*public IPackedFileProperties[] Items
		{
			get
			{
				if (items==null) items = new ArrayList();
				IPackedFileProperties[] i = new IPackedFileProperties[items.Count];
				items.CopyTo(i);
				return i;
			}
		}*/

		public System.Collections.Hashtable Attributes
		{
			get
			{
				if (attr==null) attr = new Hashtable();
				return attr;
			}
		}

		#endregion
	}
}
