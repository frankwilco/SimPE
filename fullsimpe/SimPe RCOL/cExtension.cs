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
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/*public class Point3D : SimPe.Geometry.Vector3i
	{
		public Point3D(int x, int y, int z) : base (x, y, z)
		{			
		}

		internal Point3D() : base ()
		{
		}	

		public override string ToString()
		{
			return X.ToString()+"/"+Y.ToString()+"/"+Z.ToString();
		}

	}

	public class Point4D : Point3D
	{
		int r;
		public Point4D() : base() {}
		public Point4D(int x, int y, int z) : base (x, y, z) {}
		public Point4D(int x, int y, int z, int r)  : base (x, y, z)
		{
			this.r = r;
		}

		public int R 
		{
			get { return r; }
			set { r = value; }
		}

		public override string ToString()
		{
			return X.ToString()+"/"+Y.ToString()+"/"+Z.ToString()+"/"+r.ToString();
		}
	}*/

	public class ExtensionItem 
	{
		//Known Types
		public enum ItemTypes:byte 
		{
			Value = 0x02,
			Float = 0x03,
			Translation = 0x05,
			String = 0x06,
			Array = 0x07,
			Rotation = 0x08,
			Binary = 0x09
		}

		#region Attributes
		ItemTypes typecode;
		public ItemTypes Typecode
		{
			get { return typecode; }
			set { typecode = value; }
		}

		string varname;
		public string Name 
		{
			get { 
				if (varname==null) return "";
				return varname; 
			}
			set { varname = value; }
		}

		int val;
		public int Value
		{
			get { return val; }
			set { val = value; }
		}

		float single;
		public float Single
		{
			get { return single; }
			set { single = value; }
		}

		Vector3f translation;
		public Vector3f Translation
		{
			get { return translation; }
			set { translation = value; }
		}

		string str;
		public string String
		{
			get { return str; }
			set { str = value; }
		}

		ExtensionItem[] ei;
		public ExtensionItem[] Items
		{
			get { return ei; }
			set { ei = value; }
		}

		Quaternion rotation;
		public Quaternion Rotation
		{
			get { return rotation; }
			set { rotation = value; }
		}

		byte[] data;
		public byte[] Data
		{
			get { return data; }
			set { data = value; }
		}

		#endregion

		public ExtensionItem()
		{
			varname = "";
			translation = new Vector3f();
			single = 0;
			ei = new ExtensionItem[0];
			rotation = new Quaternion();
			data = new byte[0];
			str = "";
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			typecode = (ItemTypes)reader.ReadByte();
			varname = reader.ReadString();

			switch (typecode) 
			{
				case ItemTypes.Value: 
				{
					val = reader.ReadInt32();
					break;
				}
				case ItemTypes.Float:
				{
					single = reader.ReadSingle();
					break;
				}
				case ItemTypes.Translation: 
				{
					translation.Unserialize(reader);
					break;
				}
				case ItemTypes.String: 
				{
					str = reader.ReadString();
					break;
				}
				case ItemTypes.Array: 
				{
					ei = new ExtensionItem[reader.ReadUInt32()];
					for (int i=0; i<ei.Length; i++) 
					{
						ei[i] = new ExtensionItem();
						ei[i].Unserialize(reader);
					}
					break;
				}
				case ItemTypes.Rotation: 
				{
					rotation.Unserialize(reader);
					break;
				}
				case ItemTypes.Binary: 
				{
					int len = reader.ReadInt32();
					data = reader.ReadBytes(len);
					break;
				}
				default: 
				{
					throw new Exception("Unknown Extension Item 0x"+Helper.HexString((byte)typecode)+"\n\nPosition: 0x"+Helper.HexString(reader.BaseStream.Position));
				}
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
		public void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write((byte)typecode);
			writer.Write(varname);

			switch (typecode) 
			{
				case ItemTypes.Value: 
				{
					writer.Write(val);
					break;
				}
				case ItemTypes.Float: 
				{
					writer.Write(single);
					break;
				}
				case ItemTypes.Translation: 
				{
					translation.Serialize(writer);
					break;
				}
				case ItemTypes.String: 
				{
					writer.Write(str);
					break;
				}
				case ItemTypes.Array: 
				{
					writer.Write((uint)ei.Length);
					for (int i=0; i<ei.Length; i++) 
					{
						ei[i].Serialize(writer);
					}
					break;
				}
				case ItemTypes.Rotation: 
				{
					rotation.Serialize(writer);
					break;
				}
				case ItemTypes.Binary: 
				{
					writer.Write((int)data.Length);
					writer.Write(data);
					break;
				}
				default: 
				{
					throw new Exception("Unknown Extension Item 0x"+Helper.HexString((byte)typecode));
				}
			}
		}

		public override string ToString()
		{
			string name = this.varname+" = ("+typecode.ToString()+") ";
			switch (typecode) 
			{
				case ItemTypes.Value: 
				{
					name += val.ToString();
					break;
				}
				case ItemTypes.Float: 
				{
					name += single.ToString();
					break;
				}
				case ItemTypes.Translation: 
				{
					name += translation.ToString();
					break;
				}
				case ItemTypes.String: 
				{
					name += str;
					break;
				}
				case ItemTypes.Array: 
				{
					name += this.ei.Length.ToString() + " items";
					break;
				}
				case ItemTypes.Rotation: 
				{
					name += rotation.ToString();
					break;
				}
				case ItemTypes.Binary: 
				{
					name += Helper.BytesToHexList(data);
					break;
				}
				
			}
			return name;
		}

	}

	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Extension
		: AbstractRcolBlock
	{
		#region Attributes

		byte typecode;
		public byte TypeCode 
		{
			get { return typecode; }
			set {typecode = value; }
		}

		string varname;
		public string VarName 
		{
			get {
				if (varname==null) return "";
				return varname; 
			}
			set {varname = value; }
		}

		ExtensionItem[] items;
		public ExtensionItem[] Items 
		{
			get { return items; }
			set { items = value; }
		}

		byte[] data;

		//int unknown1;
		//int unknown2;
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public Extension(Rcol parent) : base( parent)
		{
			items = new ExtensionItem[0];
			version = 0x03;
			typecode = 0x07;
			data = new byte[0];
			varname = "";
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader) { Unserialize(reader, 0); }

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader, uint ver)
		{
			version = reader.ReadUInt32();
			typecode = reader.ReadByte();

			if ((typecode<0x07))
			{
				int sz = 16;
				if ((typecode!=0x03) || (ver==4)) sz += 15;
				if ((typecode<=0x03) && (version==3)) 
				{
					if (ver==5) sz = 31;
					else sz = 15;
				}
				if ((typecode<=0x03) && ver==4) sz = 31;

				items = new ExtensionItem[1];
				ExtensionItem ei = new ExtensionItem();
				ei.Typecode = ExtensionItem.ItemTypes.Binary;
				ei.Data = reader.ReadBytes(sz);
				items[0] = ei;
			} 
			else 
			{
				varname = reader.ReadString();
			
				items = new ExtensionItem[reader.ReadUInt32()];
				for (int i=0; i<items.Length; i++)
				{
					items[i] = new ExtensionItem();
					items[i].Unserialize(reader);
				}
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
		public override void Serialize(System.IO.BinaryWriter writer) { Serialize(writer, 0); }

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public void Serialize(System.IO.BinaryWriter writer, uint ver)
		{
			writer.Write(version);
			writer.Write(typecode);

			if (typecode<0x07) 
			{
				int sz = 16;
				if ((typecode!=0x03) || (ver==4)) sz += 15;
				if ((typecode<=0x03) && (version==3)) 
				{
					if (ver==5) sz = 31;
					else sz = 15;
				}				
				if ((typecode<=0x03) && ver==4) sz = 31;

				if (items.Length>0) data = items[0].Data;
				
				data = Helper.SetLength(data, sz);
				writer.Write(data);				
			} 
			else 
			{
				writer.Write(varname);
			
				writer.Write((uint)items.Length);
				for (int i=0; i<items.Length; i++) items[i].Serialize(writer);
			}
		}

		TabPage.Extension form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new TabPage.Extension(); 
				return form;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new TabPage.Extension(); 
			
			form.tb_ver.Text = "0x"+Helper.HexString(version);
			form.tb_type.Text = "0x"+Helper.HexString(typecode);
			form.tb_name.Text = this.varname;

			form.lb_items.Items.Clear();
			foreach (ExtensionItem ei in items) form.lb_items.Items.Add(ei);

			form.gbIems.Tag = this.items;
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
			form = null;
		}

		#endregion
	}
}
