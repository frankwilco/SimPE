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
using SimPe.Geometry;
using System.ComponentModel;
using System.Collections;

namespace SimPe.Plugin
{
	public class TransformNodeItem 
	{
		public TransformNodeItem()
		{
			unknown1 = 1;
			unknown2 = 0;
		}

		ushort unknown1;
		public ushort Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		public int ChildNode 
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
			unknown1 = reader.ReadUInt16();
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
	/// Zusammenfassung für cTransformNode.
	/// </summary>
	public class TransformNode
		: AbstractCresChildren
	{
		/// <summary>
		/// this value in Joint Reference tells us that the 
		/// Node is not directly linked to a joint
		/// </summary>
		public const int NO_JOINT= 0x7fffffff;
		#region Attributes
		
		CompositionTreeNode ctn;
		ObjectGraphNode ogn;
		
		TransformNodeItems items;
		public TransformNodeItems Items 
		{
			get { return items; }
			set { items = value; }
		}

		public ObjectGraphNode ObjectGraphNode 
		{
			get { return ogn; }
		}

		public CompositionTreeNode CompositionTreeNode 
		{
			get { return ctn; }
		}

		VectorTransformation trans;
		public VectorTransformation Transformation 
		{
			get { return trans; }
			set { trans = value; }
		}
		int unknown;

		public Vector3f Translation 
		{
			get { return trans.Translation; }			
		}

		public float TransformX 
		{
			get { return (float)trans.Translation.X; }
			set { trans.Translation.X = value; }
		}
		public float TransformY 
		{
			get { return (float)trans.Translation.Y; }
			set { trans.Translation.Y = value; }
		}
		public float TransformZ 
		{
			get { return (float)trans.Translation.Z; }
			set { trans.Translation.Z = value; }
		}

		
		public float RotationX 
		{
			get { return (float)trans.Rotation.X; }
			set { trans.Rotation.X = value; }
		}
		public float RotationY 
		{
			get { return (float)trans.Rotation.Y; }
			set { trans.Rotation.Y = value; }
		}
		public float RotationZ 
		{
			get { return (float)trans.Rotation.Z; }
			set { trans.Rotation.Z = value; }
		}
		public float RotationW 
		{
			get { return (float)trans.Rotation.W; }
			set { trans.Rotation.W = value; }
		}

		public Quaternion Rotation 
		{
			get { return trans.Rotation; }
			set { trans.Rotation= value; }
		}

		public int JointReference 
		{
			get { return unknown; }
			set { unknown = value; }
		}

		[BrowsableAttribute(false)]
		public override TransformNode StoredTransformNode
		{
			get { return this; }
		}
		#endregion
		
		/// <summary>
		/// Constructor
		/// </summary>
		public TransformNode(Rcol parent) : base(parent)
		{
			ctn = new CompositionTreeNode(parent);
			ogn = new ObjectGraphNode(parent);

			items = new TransformNodeItems();

			trans = new VectorTransformation(VectorTransformation.TransformOrder.TranslateRotate);

			version = 0x07;
			BlockID = 0x65246462;

			unknown = NO_JOINT;
		}

		#region AbstractCresChildren Member
		public override string GetName()
		{
			return ogn.FileName;
		}
		/// <summary>
		/// Returns a List of all Child Blocks referenced by this Element
		/// </summary>
		[BrowsableAttribute(false)]
		public override IntArrayList ChildBlocks 
		{
			get 
			{
				IntArrayList l = new IntArrayList();
				foreach (TransformNodeItem tni in items) 
				{
					l.Add(tni.ChildNode);
				}
				return l;
			}
		}
	
		[BrowsableAttribute(false)]
		public override int ImageIndex 
		{
			get { 
				if (unknown==NO_JOINT) return 0; //clear
				return 1; //bone
			}
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

			string name = reader.ReadString();
			uint myid = reader.ReadUInt32();		
			ctn.Unserialize(reader);
			ctn.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
			ogn.Unserialize(reader);
			ogn.BlockID = myid;

			//items = new TransformNodeItem[];
			uint count = reader.ReadUInt32();
			items.Clear();
			for(int i=0; i<count; i++)
			{
				TransformNodeItem tni = new TransformNodeItem();
				tni.Unserialize(reader);
				items.Add(tni);
			}

			trans.Order = VectorTransformation.TransformOrder.TranslateRotate;
			trans.Unserialize(reader);
#if DEBUG
			trans.Name = this.ogn.FileName;
#endif
			//trans.Rotation = Quaternion.FromAxisAngle(trans.Rotation.X, trans.Rotation.Y, trans.Rotation.Z, Quaternion.DegToRad(trans.Rotation.W));
			

			unknown = reader.ReadInt32();
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

			writer.Write(ctn.BlockName);
			writer.Write(ctn.BlockID);
			ctn.Serialize(writer);

			writer.Write(ogn.BlockName);
			writer.Write(ogn.BlockID);
			ogn.Serialize(writer);

			writer.Write((uint)items.Length);
			for(int i=0; i<items.Length; i++)
			{
				items[i].Serialize(writer);
			}

			trans.Order = VectorTransformation.TransformOrder.TranslateRotate;
			trans.Serialize(writer);

			writer.Write(unknown);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tTransformNode;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			form.tb_tn_a.Tag = true;
			
			form.lb_tn.Items.Clear();
			for(int i=0; i<this.items.Length; i++) form.lb_tn.Items.Add(items[i]);

			form.tb_tn_ver.Text = "0x"+Helper.HexString(this.version);
			form.tb_tn_ukn.Text = "0x"+Helper.HexString(this.unknown);

			form.tb_tn_tx.Text = trans.Translation.X.ToString("N6");
			form.tb_tn_ty.Text = trans.Translation.Y.ToString("N6");
			form.tb_tn_tz.Text = trans.Translation.Z.ToString("N6");

			/*form.tb_tn_rx.Text = trans.Rotation.X.ToString("N6");
			form.tb_tn_ry.Text = trans.Rotation.Y.ToString("N6");
			form.tb_tn_rz.Text = trans.Rotation.Z.ToString("N6");
			form.tb_tn_rw.Text = trans.Rotation.W.ToString("N6");

			form.tb_tn_ax.Text = trans.Rotation.Axis.X.ToString("N6");
			form.tb_tn_ay.Text = trans.Rotation.Axis.Y.ToString("N6");
			form.tb_tn_az.Text = trans.Rotation.Axis.Z.ToString("N6");
			form.tb_tn_a.Text = Quaternion.RadToDeg(trans.Rotation.Angle).ToString("N6");*/
			form.TNUpdateTextValues(trans.Rotation, true, true, true);

			form.tb_tn_a.Tag = null;
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.ogn.AddToTabControl(tc);
			this.ctn.AddToTabControl(tc);
		}

		public override string ToString()
		{
			string s ="";
			if (this.unknown!=NO_JOINT) s += "[Joint"+this.unknown.ToString()+"] - ";
			s += this.ogn.FileName;
			
			s += ": "+trans.ToString() + " ("+base.ToString ()+")";
			return s;
		}

		/// <summary>
		/// Remove the Child with the given Index from the List
		/// </summary>
		/// <param name="index"></param>
		/// <returns>True, when the Child was found</returns>
		public bool RemoveChild(int index) 
		{
			for (int i=0; i<Items.Length; i++) 
			{
				if (Items[i].ChildNode == index) 
				{
					Items.RemoveAt(i);
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Add the Child with the given Index from the List
		/// </summary>
		/// <param name="index"></param>
		/// <returns>True, when the Child was added</returns>
		public bool AddChild(int index) 
		{
			for (int i=0; i<Items.Length; i++) 
			{
				if (Items[i].ChildNode == index) 
				{
					return false;
				}
			}

			TransformNodeItem tni = new TransformNodeItem();
			tni.ChildNode = index;
			items.Add(tni);
			return false;
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for TransformNodeItem Objects
	/// </summary>
	public class TransformNodeItems : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new TransformNodeItem this[int index]
		{
			get { return ((TransformNodeItem)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public TransformNodeItem this[uint index]
		{
			get { return ((TransformNodeItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(TransformNodeItem item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, TransformNodeItem item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(TransformNodeItem item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(TransformNodeItem item)
		{
			return base.Contains(item);
		}		

		/// <summary>
		/// Number of stored Elements
		/// </summary>
		public int Length 
		{
			get { return this.Count; }
		}

		/// <summary>
		/// Create a clone of this Object
		/// </summary>
		/// <returns>The clone</returns>
		public override object Clone()
		{
			TransformNodeItems list = new TransformNodeItems();
			foreach (TransformNodeItem item in this) list.Add(item);

			return list;
		}

		
	}
	#endregion
}
