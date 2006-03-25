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

namespace SimPe.Plugin.Collections
{
	/// <summary>
	/// Collection of <see cref="SimPe.Plugin.NgbhItem"/> Objects
	/// </summary>
	public class NgbhItems : System.IDisposable, System.Collections.IEnumerable
	{
		ArrayList list = new ArrayList();
		NgbhSlotList parent;
		Ngbh ngbh;
		public NgbhSlotList Parent 
		{
			get {return parent;}
		}
		
		internal NgbhItems(NgbhSlotList parent)
		{
			this.parent = parent;
			if (parent!=null) ngbh = parent.Parent;
			list = new ArrayList();
		}

		public NgbhItem AddNew()
		{
			NgbhItem item = new NgbhItem(parent);
			Add(item);
			return item;
		}

		public NgbhItem InsertNew(int index)
		{
			NgbhItem item = new NgbhItem(parent);
			Insert(index, item);
			return item;
		}

		public NgbhItem AddNew(SimMemoryType type)
		{
			NgbhItem item = new NgbhItem(parent, type);
			Add(item);
			return item;
		}

		public NgbhItem InsertNew(int index, SimMemoryType type)
		{
			NgbhItem item = new NgbhItem(parent, type);
			Insert(index, item);
			return item;
		}

		public void Add(NgbhItem item)
		{
			list.Add(item);
			if (ngbh!=null) ngbh.Changed = true;
		}

		public void Insert(int index, NgbhItem item)
		{
			list.Insert(index, item);
			if (ngbh!=null) ngbh.Changed = true;
		}

		public void Remove(NgbhItem item)
		{
			list.Remove(item);
			if (ngbh!=null) ngbh.Changed = true;
		}

		public void Remove(NgbhItem[] items)
		{
			foreach (NgbhItem item in items)
				Remove(item);

			if (ngbh!=null) ngbh.Changed = true;
		}

		public void Remove(NgbhItems items)
		{
			foreach (NgbhItem item in items)
				Remove(item);

			if (ngbh!=null) ngbh.Changed = true;
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
			if (ngbh!=null) ngbh.Changed = true;
		}

		public void Clear()
		{
			list.Clear();
			if (ngbh!=null) ngbh.Changed = true;
		}

		public bool Contains(NgbhItem item)
		{
			return list.Contains(item);
		}

		public void Swap(int i1, int i2)
		{
			if (i1<0 || i2<0 || i1>=list.Count || i2>=list.Count) return;
			object o = list[i1];
			list[i1] = list[i2];
			list[i2] = o;

			if (ngbh!=null) ngbh.Changed = true;
		}

		public NgbhItem this[int index]
		{
			get {return list[index] as NgbhItem;}
			set {
				list[index] = value;
				if (ngbh!=null) ngbh.Changed = true;
			}
		}

		public int Count
		{
			get {return list.Count;}
		}

		public int Length
		{
			get {return list.Count;}
		}

		public NgbhItems Clone()
		{
			return Clone(this.parent);
		}

		public NgbhItems Clone(NgbhSlotList newparent)
		{
			NgbhItems ret = new NgbhItems(newparent);
			foreach (NgbhItem i in list)
				ret.Add(i);

			return ret;
		}

		public const uint MIN_INVENTORY_NUMBER = 1000;
		internal uint GetMaxInventoryNumber()
		{
			uint nr = MIN_INVENTORY_NUMBER - 1;
			foreach (NgbhItem i in list)			
				if (i.InventoryNumber>nr) nr = i.InventoryNumber;

			return nr;
		}

		public NgbhItem FindItemByGuid(uint guid)
		{
			foreach (NgbhItem i in list)
				if (i.Guid == guid) return i;
			return null;
		}

		#region IDisposable Member

		public void Dispose()
		{
			if (list!=null) list.Clear();
			list = null;
		}

		#endregion

		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion
	}
}
