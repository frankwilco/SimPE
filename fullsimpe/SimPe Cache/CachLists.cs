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
using SimPe;

namespace SimPe.Cache
{

	/// <summary>
	/// Typesave ArrayList for ICacheItem Objects
	/// </summary>
	public class CacheItems : ArrayList 
	{
		public new ICacheItem this[int index]
		{
			get { return ((ICacheItem)base[index]); }
			set { base[index] = value; }
		}

		public ICacheItem this[uint index]
		{
			get { return ((ICacheItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(ICacheItem item)
		{
			return base.Add(item);
		}

		public void Insert(int index, ICacheItem item)
		{
			base.Insert(index, item);
		}

		public void Remove(ICacheItem item)
		{
			base.Remove(item);
		}

		public bool Contains(ICacheItem item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			CacheItems list = new CacheItems();
			foreach (ICacheItem item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for CacheContainer Objects
	/// </summary>
	public class CacheContainers : ArrayList 
	{
		public new CacheContainer this[int index]
		{
			get { return ((CacheContainer)base[index]); }
			set { base[index] = value; }
		}

		public CacheContainer this[uint index]
		{
			get { return ((CacheContainer)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(CacheContainer item)
		{
			return base.Add(item);
		}

		public void Insert(int index, CacheContainer item)
		{
			base.Insert(index, item);
		}

		public void Remove(CacheContainer item)
		{
			base.Remove(item);
		}

		public bool Contains(CacheContainer item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			CacheContainers list = new CacheContainers();
			foreach (CacheContainer item in this) list.Add(item);

			return list;
		}

	}
}
