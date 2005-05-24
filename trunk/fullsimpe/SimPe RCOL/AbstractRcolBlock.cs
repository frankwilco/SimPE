using System;
using System.Collections;
using System.Windows.Forms;
using System.ComponentModel;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// You need to implement is to provide a new RCOL Block
	/// </summary>
	public abstract class AbstractRcolBlock : IRcolBlock
	{
		protected SGResource sgres;
		/// <summary>
		/// Returns / Sets the cSGResource of this Block, or null if none is avilable
		/// </summary>
		[BrowsableAttribute(false)]
		public SGResource NameResource
		{
			get { return sgres; }
			set { sgres = value; }
		}		

		protected uint version;
		[ReadOnly(true)]
		public uint Version 
		{
			get { return version; }
			set { version = value; }
		}

		protected Rcol parent;
		[BrowsableAttribute(false)]
		public Rcol Parent 
		{
			get { return parent; }
			set { parent = value; }
		}

		public AbstractRcolBlock()
		{
			sgres = null;
			blockid = 0;
			version = 0;
		}

		public AbstractRcolBlock(Rcol parent)
		{			
			this.parent = (Rcol)parent;
			if (parent!=null) this.Register(Rcol.Tokens);
			sgres = null;
			blockid = 0;
			version = 0;
		}

		/// <summary>
		/// Data was changed
		/// </summary>
		[BrowsableAttribute(false)]
		public bool Changed 
		{
			get { return parent.Changed; }
			set { 
				if (parent!=null)
					parent.Changed = value; 
			}
		}

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected virtual void InitTabPage() 
		{
		}

		/// <summary>
		/// Add this Class to the tabControl
		/// </summary>
		/// <param name="tc">The tabControl the Page will be added to</param>
		public void AddToTabControl(TabControl tc)
		{
			if (TabPage!=null) 
			{
				TabPage.Tag = null;
				InitTabPage();
			}
			AddToTabControl(tc, this);
			this.ExtendTabControl(tc);
		}

		/// <summary>
		/// Add the TabPage (assigned to a RcolBlock) to the tabControl
		/// </summary>
		/// <param name="tc">The tabControl the Page will be added to</param>
		/// <param name="rb">The RcolBlock</param>
		public static void AddToTabControl(TabControl tc, IRcolBlock rb)
		{
			if (rb.TabPage!=null) 
			{
				rb.TabPage.Tag = rb;
				rb.TabPage.Text = rb.BlockName;
				tc.TabPages.Add(rb.TabPage);
			}
		}

		#region IRcolBlock Members
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public abstract void Unserialize(System.IO.BinaryReader reader);

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public abstract void Serialize(System.IO.BinaryWriter writer);

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public IRcolBlock Create()
		{
			return Create(this.GetType(), this.parent);
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public static IRcolBlock Create(Type type, Rcol parent)
		{
			object[] args = new object[1];
			args[0] = parent;
			IRcolBlock irb = (IRcolBlock)Activator.CreateInstance(type, args);
			return irb;
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public static IRcolBlock Create(Type type, Rcol parent, uint id)
		{
			IRcolBlock irb = Create(type, parent);
			irb.BlockID = id;
			return irb;
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public IRcolBlock Create(uint id)
		{
			return Create(this.GetType(), this.parent, id);
		}

		/// <summary>
		/// Registers the Object in the given Hashtable
		/// </summary>
		/// <param name="listing"></param>
		/// <returns>The Name of the Class Type</returns>
		public string Register(Hashtable listing)
		{
			string name = BlockName;
			if (listing!=null) if (!listing.ContainsKey(name)) listing.Add(name, this.GetType());
			return name;
		}

		uint blockid;

		/// <summary>
		/// Returns the ID used for this Block
		/// </summary>
		[BrowsableAttribute(false)]
		public uint BlockID
		{
			get{ return blockid; }
			set { blockid = value; }
		}

		protected string blockname;

		/// <summary>
		/// if not null this is the default name for the Block in the Rcol
		/// </summary>
		[BrowsableAttribute(false)]
		public virtual string BlockName 
		{
			get 
			{
				if (blockname==null) 
				{
					return "c"+this.GetType().Name;
				} 
				else return blockname;
			}
			set { blockname = value; }
		}

		/// <summary>
		/// Returns a tabPage that contains a GUI for this Element
		/// </summary>
		[BrowsableAttribute(false)]
		public virtual System.Windows.Forms.TabPage TabPage 
		{
			get { return null; }
		}

		/// <summary>
		/// Adds more TabPages (which are needed to process the Class) to the Control
		/// </summary>
		/// <param name="tc">The TabControl the Pages will be added to</param>
		public virtual void ExtendTabControl(TabControl tc) {}
		#endregion

		public override string ToString() 
		{
			if (this.sgres==null) 
			{
				return this.BlockName;
			} 
			else 
			{
				return sgres.FileName + " ("+this.BlockName+")";
			}
		}
	}
}
