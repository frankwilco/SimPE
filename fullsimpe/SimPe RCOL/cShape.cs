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
using System.Drawing;
using System.Collections;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	public class ShapePart 
	{
		string type;
		public string Subset 
		{
			get { return type; }
			set { type = value; }
		}

		string desc;
		public string FileName 
		{
			get { return desc; }
			set { desc = value; }
		}

		byte[] data;
		public byte[] Data 
		{
			get { return data; }
			set 
			{
				if (value.Length==9) 
				{
					data = value;
				} 
				else if (value.Length>9) 
				{
					data = new byte[9];
					for (int i=0; i<9; i++) data[i] = value[i];
				} 
				else 
				{
					data = new byte[9];
					for (int i=0; i<value.Length; i++) data[i] = value[i];
				}
			}
		}

		public ShapePart()
		{
			data = new byte[9];
			type = "";
			desc = "";
		}
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			type = reader.ReadString();
			desc = reader.ReadString();
			data = reader.ReadBytes(9);
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
			writer.Write(type);
			writer.Write(desc);
			writer.Write(data);
		}

		public override string ToString()
		{
			string name = type+": "+desc;
			return name;
		}
	}

	/// <summary>
	/// A Shape Item
	/// </summary>
	public class ShapeItem 
	{
		Shape parent;

		int unknown1;
		public int Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		byte unknown2;
		public byte Unknown2 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		int unknown3;
		public int Unknown3 
		{
			get { return unknown3; }
			set { unknown3 = value; }
		}

		byte unknown4;
		public byte Unknown4 
		{
			get { return unknown4; }
			set { unknown4 = value; }
		}

		string filename;
		public string FileName 
		{
			get { return filename; }
			set { filename = value; }
		}

		public ShapeItem(Shape parent)
		{
			this.parent = parent;
			filename = "";
		}


		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			unknown1 = reader.ReadInt32();
			unknown2 = reader.ReadByte();
			if ((parent.Version == 0x07) || (parent.Version == 0x06)) 
			{
				filename = "";
				unknown3 = reader.ReadInt32();
				unknown4 = reader.ReadByte();
			} 
			else 
			{
				filename = reader.ReadString();
				unknown3 = 0;
				unknown4 = 0;
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
			writer.Write(unknown1);
			writer.Write(unknown2);
			if ((parent.Version == 0x07) || (parent.Version == 0x06)) 
			{
				writer.Write(unknown3);
				writer.Write(unknown4);
			} 
			else 
			{
				writer.Write(filename);
			}
		}

		public override string ToString()
		{
			string name = "0x" + Helper.HexString((uint)unknown1) + " - 0x" + Helper.HexString(unknown2);
			if ((parent.Version == 0x07) || (parent.Version == 0x06)) return name + " - 0x" + Helper.HexString((uint)unknown3) + " - 0x" + Helper.HexString(unknown4);
			else return name+": "+filename;
		}

	}

	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Shape
		: AbstractRcolBlock, IScenegraphBlock
	{
		#region Attributes
		uint[] unknown;
		public uint[] Unknwon 
		{
			get { return unknown; }
			set { unknown = value; }
		}

		ShapeItem[] items;
		public ShapeItem[] Items 
		{
			get { return items; }
			set { items = value; }
		}

		ShapePart[] parts;
		public ShapePart[] Parts 
		{
			get { return parts; }
			set { parts = value; }
		}


		ObjectGraphNode ogn;
		public ObjectGraphNode GraphNode 
		{
			get { return ogn; }
			set { ogn = value; }
		}

		ReferentNode refnode;
		public ReferentNode RefNode 
		{
			get { return refnode; }
		}
		#endregion
		/*public Rcol Parent 
		{
			get { return parent; }
		}*/

		/// <summary>
		/// Constructor
		/// </summary>
		public Shape(Rcol parent) : base(parent)
		{
			sgres = new SGResource(null);
			refnode = new ReferentNode(null);
			ogn = new ObjectGraphNode(null);

			unknown = new uint[0];
			items = new ShapeItem[0];
			parts = new ShapePart[0];
			BlockID = 0xFC6EB1F7;
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			string s = reader.ReadString();

			sgres.BlockID = reader.ReadUInt32();
			sgres.Unserialize(reader);
			
			s = reader.ReadString();
			refnode.BlockID = reader.ReadUInt32();
			refnode.Unserialize(reader);

			s = reader.ReadString();
			ogn.BlockID = reader.ReadUInt32();
			ogn.Unserialize(reader);

			if (version!=0x06) unknown = new uint[reader.ReadUInt32()];
			else unknown = new uint[0];
			for (int i=0; i<unknown.Length; i++) unknown[i] = reader.ReadUInt32();
			
			items = new ShapeItem[reader.ReadUInt32()];
			for (int i=0; i<items.Length; i++) 
			{
				items[i] = new ShapeItem(this);
				items[i].Unserialize(reader);
			}

			parts = new ShapePart[reader.ReadUInt32()];
			for (int i=0; i<parts.Length; i++) 
			{
				parts[i] = new ShapePart();
				parts[i].Unserialize(reader);
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
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);
			writer.Write(sgres.Register(null));
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);
			
			writer.Write(refnode.Register(null));
			writer.Write(refnode.BlockID);
			refnode.Serialize(writer);

			writer.Write(ogn.Register(null));
			writer.Write(ogn.BlockID);
			ogn.Serialize(writer);

			if (version!=0x06) 
			{
				writer.Write((uint)unknown.Length);
				for (int i=0; i<unknown.Length; i++) writer.Write(unknown[i]);
			}
			
			writer.Write((uint)items.Length);
			for (int i=0; i<items.Length; i++) items[i].Serialize(writer);
			

			writer.Write((uint)parts.Length);
			for (int i=0; i<parts.Length; i++) parts[i].Serialize(writer);
		}

		fShapeRefNode form = null;
		ShpeForm sform = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tGenericRcol;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			if (sform==null) sform = new ShpeForm();
			form.tb_ver.Text = "0x"+Helper.HexString(this.version);	
			form.gen_pg.SelectedObject = this;
		
			sform.lbunk.Items.Clear();
			sform.lbitem.Items.Clear();
			sform.lbpart.Items.Clear();
			sform.lbnode.Items.Clear();
			try 
			{
				Shape wrp = this;
				
				foreach (uint val in wrp.Unknwon) sform.lbunk.Items.Add(val);
				foreach (ShapeItem item in wrp.Items) sform.lbitem.Items.Add(item);
				foreach (ShapePart part in wrp.Parts) sform.lbpart.Items.Add(part);
				foreach (ObjectGraphNodeItem ogni in wrp.GraphNode.Items) form.lb_ogn.Items.Add(ogni);
				form.tb_ogn_file.Text = wrp.GraphNode.FileName;
				form.tb_ogn_ver.Text = Helper.HexString(wrp.GraphNode.Version);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			} 
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			sform.tabPage1.Tag = this;
			tc.TabPages.Add(sform.tabPage1);

			sform.tabPage2.Tag = this;
			tc.TabPages.Add(sform.tabPage2);

			sform.tabPage3.Tag = this;
			tc.TabPages.Add(sform.tabPage3);

			form.tObjectGraphNode.Tag = this.GraphNode;
			tc.TabPages.Add(form.tObjectGraphNode);
		}

		#region IScenegraphItem Member
		
		public void ReferencedItems(Hashtable refmap, uint parentgroup)
		{
			ArrayList list = new ArrayList();
			foreach (ShapePart part in Parts) 
			{
				list.Add(SimPe.Plugin.ScenegraphHelper.BuildPfd(part.FileName.Trim()+"_txmt", SimPe.Plugin.ScenegraphHelper.TXMT, parentgroup));
			}
			refmap["Subsets"] = list;

			list = new ArrayList();
			foreach (ShapeItem item in Items) 
			{
				list.Add(SimPe.Plugin.ScenegraphHelper.BuildPfd(item.FileName.Trim(), SimPe.Plugin.ScenegraphHelper.GMND, parentgroup));
			}
			refmap["Models"] = list;
		}

		#endregion

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}
}
