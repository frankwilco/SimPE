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
using System.ComponentModel;

namespace SimPe.Plugin
{
	public class ResourceNodeItem 
	{
		short unknown1;
		public short Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get { return unknown2; }
			set { unknown2= value; }
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			unknown1 = reader.ReadInt16();
			unknown2 = reader.ReadInt32();
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
		}

		public override string ToString()
		{
			return "0x"+Helper.HexString((ushort)unknown1) + " 0x" + Helper.HexString((uint)unknown2);
		}

	}

	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class ResourceNode
		: AbstractCresChildren
	{
		#region Attributes
		byte typecode;
		public byte TypeCode 
		{
			get { return typecode; }
		}

		ObjectGraphNode ogn;
		public ObjectGraphNode GraphNode 
		{
			get { return ogn; }
		}

		CompositionTreeNode ctn;
		public CompositionTreeNode TreeNode 
		{
			get { return ctn; }
		}

		ResourceNodeItem[] items;
		public ResourceNodeItem[] Items 
		{
			get { return items; }
			set { items = value; }
		}

		int unknown1;
		public int Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		[BrowsableAttribute(false)]
		public override TransformNode StoredTransformNode
		{
			get { return null; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public ResourceNode(Rcol parent) : base(parent)
		{
			sgres = new SGResource(null);
			ogn = new ObjectGraphNode(null);
			ctn = new CompositionTreeNode(null);
			items = new ResourceNodeItem[0];

			version = 0x07;
			typecode = 0x01;
			BlockID = 0xE519C933;
		}



		#region AbstractCresChildren Member
		public override string GetName()
		{
			return ogn.FileName;
		}
		/// <summary>
		/// Returns a List of all Child Blocks referenced by this Element
		/// </summary>
		public override IntArrayList ChildBlocks 
		{
			get 
			{
				IntArrayList l = new IntArrayList();
				foreach (ResourceNodeItem rni in items) 
				{
					l.Add((rni.Unknown2 >> 24) & 0xff);
				}
				return l;
			}
		}	

		[BrowsableAttribute(false)]
		public override int ImageIndex 
		{
			get 
			{ 
				return 3; //mesh 
			}
		}

		/// <summary>
		/// Add a ChildNode (and all it's subChilds) to a TreeNode
		/// </summary>
		/// <param name="parent">The parent TreeNode</param>
		/// <param name="index">The Index of the Child Block in the Parent</param>
		/// <param name="child">The ChildBlock (can be null)</param>
		protected void AddChildNode(System.Windows.Forms.TreeNodeCollection parent, int index, SimPe.Interfaces.Scenegraph.ICresChildren child) 
		{
			//Make the user aware, that a Node was left out!
			if (child==null) 
			{
				System.Windows.Forms.TreeNode unode = new System.Windows.Forms.TreeNode("[Error: Unsupported Child on Index "+index.ToString()+"]");
				unode.Tag = index;
				unode.ImageIndex = 4;
				unode.SelectedImageIndex = 4;
				parent.Add(unode);
				return;
			}

			System.Windows.Forms.TreeNode node = new System.Windows.Forms.TreeNode("0x"+index.ToString("X")+": "+child.ToString());
			node.Tag = index;
			node.ImageIndex = child.ImageIndex;
			node.SelectedImageIndex = node.ImageIndex;
			parent.Add(node);

			foreach (int i in child.ChildBlocks) AddChildNode(node.Nodes, i, child.GetBlock(i));
		}
		#endregion
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			typecode = reader.ReadByte();

			string fldsc = reader.ReadString();
			uint myid = reader.ReadUInt32();

			if (typecode==0x01) 
			{
				sgres.Unserialize(reader);
				sgres.BlockID = myid;

				fldsc = reader.ReadString();
				myid = reader.ReadUInt32();
				ctn.Unserialize(reader);
				ctn.BlockID = myid;

				fldsc = reader.ReadString();
				myid = reader.ReadUInt32();
				ogn.Unserialize(reader);
				ogn.BlockID = myid;

				items = new ResourceNodeItem[reader.ReadByte()];
				for (int i=0; i<items.Length; i++) 
				{
					items[i] = new ResourceNodeItem();
					items[i].Unserialize(reader);
				}
				unknown1 = reader.ReadInt32();
			} 
			else if (typecode==0x00) 
			{
				ogn.Unserialize(reader);
				ogn.BlockID = myid;

				items = new ResourceNodeItem[1];
				items[0] = new ResourceNodeItem();
				items[0].Unserialize(reader);
			} 
			else 
			{
				throw new Exception("Unknown ResourceNode 0x"+Helper.HexString(version)+", 0x"+Helper.HexString(typecode));
			}
			unknown2 = reader.ReadInt32();
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
			writer.Write(typecode);

			if (typecode==0x01) 
			{
				writer.Write(sgres.BlockName);
				writer.Write(sgres.BlockID);
				sgres.Serialize(writer);

				writer.Write(ctn.BlockName);
				writer.Write(ctn.BlockID);
				ctn.Serialize(writer);

				writer.Write(ogn.BlockName);
				writer.Write(ogn.BlockID);
				ogn.Serialize(writer);

				writer.Write((byte)items.Length);
				for (int i=0; i<items.Length; i++) items[i].Serialize(writer);
				
				writer.Write(unknown1);
			} 
			else if (typecode==0x00) 
			{
				writer.Write(ogn.BlockName);
				writer.Write(ogn.BlockID);
				ogn.Serialize(writer);

				if (items.Length<1) items = new ResourceNodeItem[1];
				items[0].Serialize(writer);
			} 
			else 
			{
				throw new Exception("Unknown ResourceNode 0x"+Helper.HexString(version)+", 0x"+Helper.HexString(typecode));
			}
			writer.Write(unknown2);
		}

		TabPage.ResourceNode tResourceNode;		
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (tResourceNode==null) tResourceNode = new SimPe.Plugin.TabPage.ResourceNode();
				return tResourceNode;
			}
		}

		TabPage.Cres tCres;
		public override System.Windows.Forms.TabPage ResourceTabPage
		{
			get
			{
				if (tCres==null) tCres = new SimPe.Plugin.TabPage.Cres();
				return tCres;
			}
		}

		#endregion

		/// <summary>
		/// Init the Ressource Cres
		/// </summary>
		protected override void InitResourceTabPage()
		{
			if (tResourceNode==null) tResourceNode = new SimPe.Plugin.TabPage.ResourceNode();
			if (tCres==null) tCres = new SimPe.Plugin.TabPage.Cres();

			this.tCres.cres_tv.Nodes.Clear();
			tCres.tbfjoint.Text = "";
			AddChildNode(this.tCres.cres_tv.Nodes, 0, this);
			this.tCres.cres_tv.ExpandAll();
		}

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (tResourceNode==null) tResourceNode = new SimPe.Plugin.TabPage.ResourceNode();
			
			tResourceNode.lb_rn.Items.Clear();
			for(int i=0; i<this.items.Length; i++) tResourceNode.lb_rn.Items.Add(items[i]);

			tResourceNode.tb_rn_uk1.Text = "0x"+Helper.HexString((uint)this.unknown1);
			tResourceNode.tb_rn_uk2.Text = "0x"+Helper.HexString((uint)this.unknown2);
			tResourceNode.tb_rn_ver.Text = "0x"+Helper.HexString(this.version);
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			if (typecode==0x1)this.ctn.AddToTabControl(tc);
			this.ogn.AddToTabControl(tc);
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.tResourceNode!=null) this.tResourceNode.Dispose();
			tResourceNode = null;
			if (tCres!=null) tCres.Dispose();
			tCres = null;
			sgres = null;
			ogn = null;
			ctn = null;
			items = new ResourceNodeItem[0];
		}

		#endregion
	}
}
