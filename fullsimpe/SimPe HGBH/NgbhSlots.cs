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
	/// Collection of <see cref="SimPe.Plugin.NgbhSlot"/> Objects
	/// </summary>
	public class NgbhSlots : System.IDisposable, System.Collections.IEnumerable
	{
		ArrayList list = new ArrayList();
		Ngbh parent;

		Data.NeighborhoodSlots type;
		public Data.NeighborhoodSlots Type
		{
			get {return type;}
		}
		internal NgbhSlots(Ngbh parent, Data.NeighborhoodSlots type)
		{
			list = new ArrayList();
			this.parent = parent;
			this.type = type;
		}

		public NgbhSlot AddNew(uint inst)
		{
			NgbhSlot s = new NgbhSlot(parent, type);
			s.SlotID = inst;

			Add(s);

			return s;
		}

		public void Add(NgbhSlot item)
		{
			list.Add(item);
			if (parent!=null) parent.Changed = true;
		}

		public void Remove(NgbhSlot item)
		{
			list.Remove(item);
			if (parent!=null) parent.Changed = true;
		}

		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
			if (parent!=null) parent.Changed = true;
		}

		public void Clear()
		{
			list.Clear();
			if (parent!=null) parent.Changed = true;
		}

		public bool Contains(NgbhSlot item)
		{
			return list.Contains(item);
		}

		public NgbhSlot this[int index]
		{
			get {return list[index] as NgbhSlot;}
			set {
				list[index] = value;
				if (parent!=null) parent.Changed = true;
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

		public NgbhSlots Clone()
		{
			return Clone(this.parent);
		}

		public NgbhSlots Clone(Ngbh newparent)
		{
			NgbhSlots ret = new NgbhSlots(newparent, type);
			foreach (NgbhSlot s in list)
				ret.Add(s);

			return ret;
		}

		/// <summary>
		/// Returns a List of all items stored for a Sim in the gven Slot
		/// </summary>
		/// <param name="slots">The Slots of a sertain Block</param>
		/// <param name="instance">Instance Number of a Sim</param>
		/// <returns>the Slot for the given Sim or null</returns>
		public NgbhSlot GetInstanceSlot(uint instance)
		{
			return GetInstanceSlot(instance, false);
		}

		/// <summary>
		/// Returns a List of all items stored for a Sim in the gven Slot
		/// </summary>
		/// <param name="slots">The Slots of a sertain Block</param>
		/// <param name="instance">Instance Number of a Sim</param>
		/// <returns>the Slot for the given Sim or null</returns>
		public NgbhSlot GetInstanceSlot(uint instance, bool create)
		{
			foreach (NgbhSlot s in list) if (s.SlotID == instance) return s;

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
