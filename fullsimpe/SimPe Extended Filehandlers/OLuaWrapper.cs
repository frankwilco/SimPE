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
	public class ObjLua : AbstractWrapper, SimPe.Interfaces.Plugin.IFileWrapper, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper
	{
		#region Attributes
		uint id;
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
		}

		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			items.Clear();

			id = reader.ReadUInt32();
			header = reader.ReadBytes(header.Length);

			int ct = reader.ReadInt32();
			for (int i=0; i<ct; i++)
			{
				ObjLuaInstruction item = new ObjLuaInstruction(this);
				item.Unserialize(reader);

				items.Add(item);
			}

			complete = reader.BaseStream.Position==reader.BaseStream.Length;
		}


		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(id);
			writer.Write(header);

			writer.Write((int)items.Count);
			foreach( ObjLuaInstruction item in items)
				item.Serialize(writer);
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

	}


	public class ObjLuaInstruction : System.IDisposable
	{
		public enum Type : byte
		{
			Unknown = 0x00,
			Data = 0x03,
			String = 0x04
		}

		#region Attributes
		ObjLua parent;
	
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
			get { return data[10]; }
			set { data[1] = value; }
		}

		uint[] bdata;
		byte[] badd;
		byte[] bheader;
		
		#endregion

		public ObjLuaInstruction(ObjLua parent) 
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
			else if (type==Type.Data) 
			{
				bheader = reader.ReadBytes(bheader.Length);
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
				}
			} 
			else 
			{
				throw new Exception("Unknown Format: 0x"+Helper.ToString((byte)type));
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
	}
}
