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
	/// Represents a PackedFile in SDsc Format
	/// </summary>
	public class ObjLua : AbstractWrapper
		, System.Collections.IEnumerable
		, SimPe.Interfaces.Plugin.IFileWrapper
		, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper		
	{
		#region Attributes
		uint id;
		string flname;
		byte[] header;
		ArrayList items;
		bool complete;
		public bool Complete
		{
			get { return complete; }
		}
		#endregion

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Object LUA Wrapper",
				"Quaxi",
				"LUA Resources are external Resources, which contain additional SimAntic Scripts.",
				1,
				null
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.ObjLua();
		}
		

		public ObjLua() : base()
		{			
			header = new byte[0x32];
			items = new ArrayList();
			flname = "";
		}

		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			items.Clear();

			flname = Helper.ToString(reader.ReadBytes(0x40));
			id = reader.ReadUInt32();
			header = reader.ReadBytes(header.Length);

			

			while (reader.BaseStream.Position<reader.BaseStream.Length)
			{
				ObjLuaFunction olf = new ObjLuaFunction(this);
				olf.Unserialize(reader);
				items.Add(olf);
			}

		}


		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(Helper.ToBytes(flname, 0x40));
			writer.Write(id);
			writer.Write(header);

			///TODO: complete this write
		}
		#endregion

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0x61754C1B
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

		#region IEnumerable Members
		public System.Collections.IEnumerator GetEnumerator ()
		{
			return items.GetEnumerator();
		}
		#endregion
	}

	public class ObjLuaFunction : System.IDisposable, System.Collections.IEnumerable
	{
	

		#region Attributes
		ObjLua parent;
	
		ArrayList items;
		ObjLuaBinaryData data;
		#endregion

		public ObjLuaFunction(ObjLua parent) 
		{
			this.parent = parent;
			items = new ArrayList();
			data = new ObjLuaBinaryData(this);
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			int ct = reader.ReadInt32();
			for (int i=0; i<ct; i++)
			{
				ObjLuaInstruction item = new ObjLuaInstruction(this);
				item.Unserialize(reader);

				items.Add(item);
			}
			data.Unserialize(reader);
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			
		}

		

		#region IDisposable Member

		public void Dispose()
		{
			parent = null;
			if (items!=null) items.Clear();
			items = null;
		}

		#endregion

		public override string ToString()
		{
			return items.Count.ToString()+" Instructions";
		}
		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return items.GetEnumerator();
		}

		#endregion
	}

	public class ObjLuaBinaryData : System.IDisposable
	{
		public enum Type : uint
		{
			Variable = 0x00000000,
			Unknown1 = 0x00000001,
			Unknown2 = 0x00000002			
		}
		#region Attributes
		ObjLuaFunction parent;
	
		Type type;
		public Type BinaryType
		{
			get { return type; }
			set { type = value; }
		}


		

		uint[] bdata;
		byte[] badd;
		
		#endregion

		public ObjLuaBinaryData(ObjLuaFunction parent) 
		{
			this.parent = parent;
			
			bdata = new uint[0];
			badd = new byte[0];
			
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			type = (Type)reader.ReadUInt32();

			uint ct = 0;
			if (type==Type.Variable) 
				ct = reader.ReadUInt32();			
			else if (type==Type.Unknown1 || type==Type.Unknown2)
				ct = 6;
			else 
				throw new Exception("Unknown Memory Type: 0x"+Helper.HexString((uint)type)+", 0x"+Helper.HexString(reader.BaseStream.Position-0x40));
			
			

			bdata = new uint[ct];
			for (int i=0; i<bdata.Length; i++) 
				bdata[i] = reader.ReadUInt32();

			/*if (bdata.Length>0) 
			{
				if (bdata[0]!=0x000000005) 
				{
					badd = new byte[28];
					for (int i=0; i<badd.Length; i++) 
						badd[i] = reader.ReadByte();
				}
			}*/
		}

		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			
		}
		#region IDisposable Member

		public void Dispose()
		{
			parent = null;			

			badd = null;
			bdata = null;
		}

		#endregion		

	}



	public class ObjLuaInstruction : System.IDisposable
	{
		public enum Type : byte
		{
			Empty = 0x00,
			Data = 0x03,
			String = 0x04
		}

		#region Attributes
		ObjLuaFunction parent;
	
		Type type;
		public Type InstructionType
		{
			get { return type; }
			set { type = value; }
		}

		string str;
		public string String
		{
			get { return str; }
			set { str = value; }
		}

		uint[] data;
		public uint Unknown1
		{
			get { return data[0]; }
			set { data[0] = value; }
		}
		public uint Unknown2
		{
			get { return data[1]; }
			set { data[1] = value; }
		}

		uint[] bdata;
		byte[] badd;
		byte[] bheader;
		
		#endregion

		public ObjLuaInstruction(ObjLuaFunction parent) 
		{
			this.parent = parent;
			str = "";
			data = new uint[2];
			bdata = new uint[0];
			badd = new byte[0];
			bheader = new byte[3];
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			type = (Type)reader.ReadByte();

			str = "";
			bdata = new uint[0];
			badd = new byte[0];
			if (type==Type.String) 
			{
				int ct = reader.ReadInt32();
				byte[] data = reader.ReadBytes(ct);
				str = Helper.ToString(data);
			} 
			else if (type==Type.Data) 
			{
				data[0] = reader.ReadUInt32();
				data[1] = reader.ReadUInt32();
			}
			else if (type==Type.Empty) 
			{
				/*bheader = reader.ReadBytes(bheader.Length);
				bdata = new uint[reader.ReadUInt32()];
				for (int i=0; i<bdata.Length; i++) 
					bdata[i] = reader.ReadUInt32();

				if (bdata.Length>0) 
				{
					if (bdata[0]!=0x000000005) 
					{
						badd = new byte[28];
						for (int i=0; i<badd.Length; i++) 
							badd[i] = reader.ReadByte();
					}
				}*/
			} 
			else 
			{
				throw new Exception("Unknown Instruction Format: 0x"+Helper.HexString((byte)type)+", 0x"+Helper.HexString(reader.BaseStream.Position-0x40));
			}
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			
		}
		#region IDisposable Member

		public void Dispose()
		{
			parent = null;
			str = null;

			badd = null;
			bheader = null;
			bdata = null;
			data = null;
		}

		#endregion

		public override string ToString()
		{
			string s = type.ToString()+": ";
			if (type == Type.String) s += str;
			else if (type == Type.Data) s += "0x"+Helper.HexString(this.Unknown1)+", "+"0x"+Helper.HexString(this.Unknown2);			
										 
			return s;
		}

	}
}
