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
	/// Collection of <see cref="SimPe.Plugin.BnfoCustomerItem"/> Objects
	/// </summary>
	public class BnfoCustomerItems : System.IDisposable, System.Collections.IEnumerable
	{
		ArrayList list = new ArrayList();
		Bnfo parent;
		internal BnfoCustomerItems(Bnfo parent)
		{
			list = new ArrayList();
			this.parent = parent;
		}

		public BnfoCustomerItem AddNew(ushort inst)
		{
			BnfoCustomerItem s = new BnfoCustomerItem(parent);
			s.SimInstance = inst;

			Add(s);

			return s;
		}

		public void Add(BnfoCustomerItem item)
		{
			list.Add(item);
		}

		public void Remove(BnfoCustomerItem item)
		{
			list.Remove(item);
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		public void Clear()
		{
			list.Clear();
		}

		public bool Contains(BnfoCustomerItem item)
		{
			return list.Contains(item);
		}

		public BnfoCustomerItem this[int index]
		{
			get {return list[index] as BnfoCustomerItem;}
			set {list[index] = value;}
		}

		public int Count
		{
			get {return list.Count;}
		}

		public int Length
		{
			get {return list.Count;}
		}

		public BnfoCustomerItems Clone()
		{
			return Clone(this.parent);
		}

		public BnfoCustomerItems Clone(Bnfo newparent)
		{
			BnfoCustomerItems ret = new BnfoCustomerItems(newparent);
			foreach (BnfoCustomerItem s in list)
				ret.Add(s);

			return ret;
		}

		public BnfoCustomerItem GetInstanceItem(ushort instance)
		{
			return GetInstanceItem(instance, false);
		}

		public BnfoCustomerItem GetInstanceItem(ushort instance, bool create)
		{
			foreach (BnfoCustomerItem s in list) if (s.SimInstance == instance) return s;

			if (create)			
				return this.AddNew(instance);
			
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
