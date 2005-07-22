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
using Ambertation.Windows.Forms.Graph;
using System.Drawing;

namespace Ambertation.Collections
{
	public class GraphItemChangedEventArgs : System.EventArgs 
	{
		GraphItemBase gi;
		public GraphItemBase GraphItem
		{
			get {return gi; }
		}

		string txt;
		public string Text 
		{
			get { return txt; }
		}
		bool add;
		public  bool Added
		{
			get {return add;}
		}
		public  bool Removed
		{
			get {return !add;}
		}

		bool inter;
		public bool Internal
		{
			get { return inter; }
		}

		internal GraphItemChangedEventArgs(GraphItemBase gi, string text, bool add, bool inter)
		{
			this.gi = gi;
			this.add = add;
			this.inter = inter;
			this.txt = text;
		}
	}

	public delegate void GraphItemsChanged(GraphItems sender, GraphItemChangedEventArgs e);

	/// <summary>
	/// Typesave ArrayList for GraphItem Objects
	/// </summary>
	public class GraphItems : ArrayList 
	{
		public event GraphItemsChanged ItemsChanged;

		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GraphItemBase this[int index]
		{
			get { return ((GraphItemBase)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GraphItemBase this[uint index]
		{
			get { return ((GraphItemBase)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GraphItemBase item, string text)
		{
			return SilentAdd(item, text, false);
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GraphItemBase item)
		{
			return SilentAdd(item, "", false);
		}

		internal int SilentAdd(GraphItemBase item, string text, bool inter) 
		{
			if (this.Contains(item)) 
				return -1;			
			int res =  base.Add(item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new GraphItemChangedEventArgs(item, text, true, inter));
			return res;
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, string text, GraphItemBase item)
		{
			if (this.Contains(item)) return;			
			base.Insert(index, item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new GraphItemChangedEventArgs(item, text, true, false));
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GraphItemBase item)
		{
			if (this.Contains(item)) return;			
			base.Insert(index, item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new GraphItemChangedEventArgs(item, "", true, false));
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GraphItemBase item)
		{
			this.SilentRemove(item, false);
		}

		internal void SilentRemove(GraphItemBase item,  bool inter)
		{
			base.Remove(item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new GraphItemChangedEventArgs(item, "", false, inter));
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GraphItemBase item)
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
			GraphItems list = new GraphItems();
			foreach (GraphItemBase item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for GraphItem Objects
	/// </summary>
	public class GraphElements : ArrayList 
	{
		public event System.EventHandler ItemsChanged;

		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GraphPanelElement this[int index]
		{
			get { return ((GraphPanelElement)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GraphPanelElement this[uint index]
		{
			get { return ((GraphPanelElement)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GraphPanelElement item)
		{
			return SilentAdd(item,  false);
		}

		internal int SilentAdd(GraphPanelElement item, bool inter) 
		{
			if (this.Contains(item)) 
				return -1;			
			int res =  base.Add(item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new System.EventArgs());
			return res;
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GraphPanelElement item)
		{
			if (this.Contains(item)) return;			
			base.Insert(index, item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new System.EventArgs());
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GraphPanelElement item)
		{
			this.SilentRemove(item, false);
		}

		internal void SilentRemove(GraphPanelElement item, bool inter)
		{
			base.Remove(item);
			if (this.ItemsChanged!=null) this.ItemsChanged(this, new System.EventArgs());
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GraphPanelElement item)
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
			GraphElements list = new GraphElements();
			foreach (GraphPanelElement item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for PropertyItem Objects
	/// </summary>
	public class PropertyItems : ArrayList 
	{		
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new PropertyItem this[int index]
		{
			get { return ((PropertyItem)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public PropertyItem this[uint index]
		{
			get { return ((PropertyItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public PropertyItem this[string name]
		{
			get { 
				int index = this.GetIndexOf(name);
				if (index>=0) return this[index]; 

				PropertyItem pi = new PropertyItem(name, null);
				Add(pi);
				return pi;
			}
			set { 
				int index = this.GetIndexOf(name);
				if (index>=0) this[index] = value; 
				else Add(name, value);
			}
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(PropertyItem item)
		{
			return base.Add(item);			
		}

		public int Add(string name, object val)
		{
			return Add(new PropertyItem(name, val));
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, PropertyItem item)
		{
			base.Insert(index, item);			
		}

		public void Insert(int index, string name, object val)
		{
			
			base.Insert(index, new PropertyItem(name, val));			
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(PropertyItem item)
		{
			base.Remove(item);			
		}

		public void Remove(string name)
		{
			int index = GetIndexOf(name);
			if (index>=0) base.RemoveAt(index);			
		}

		public int GetIndexOf(string name)
		{
			name = name.Trim().ToLower();
			for (int i=0; i<this.Count; i++)
				if (this[i].Name.Trim().ToLower() == name) return i;
			return -1;
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(PropertyItem item)
		{
			return base.Contains(item);
		}
		
		public bool Contains(string name)
		{
			return (GetIndexOf(name)>=0);
		}

		/// <summary>
		/// Number of stored Elements
		/// </summary>
		public int Length 
		{
			get { return this.Count; }
		}

		public string[] Keys
		{
			get 
			{
				string[] res = new string[this.Count];
				int ct=0;
				foreach (PropertyItem item in this) res[ct++] = item.Name;
				return res;
			}
		}

		public object[] Values
		{
			get 
			{
				object[] res = new object[this.Count];
				int ct=0;
				foreach (PropertyItem item in this) res[ct++] = item.Value;
				return res;
			}
		}

		/// <summary>
		/// Create a clone of this Object
		/// </summary>
		/// <returns>The clone</returns>
		public override object Clone()
		{
			PropertyItems list = new PropertyItems();
			foreach (PropertyItem item in this) list.Add(item);

			return list;
		}
	}	

	/// <summary>
	/// Typesave ArrayList for Image Objects
	/// </summary>
	public class Images : ArrayList
	{
		
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Image this[int index]
		{
			get { return ((Image)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Image this[uint index]
		{
			get { return ((Image)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(Image item)
		{
			return base.Add(item);			
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, Image item)
		{
			base.Insert(index, item);			
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(Image item)
		{
			base.Remove(item);			
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Image item)
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
			Images list = new Images();
			foreach (Image item in this) list.Add(item);

			return list;
		}
	}
}
