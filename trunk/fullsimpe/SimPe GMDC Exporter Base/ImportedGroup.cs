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

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Enumerates possible action for Mesh Groups
	/// </summary>
	public enum GmdcImporterAction : byte
	{
		/// <summary>
		/// Ignor this Group
		/// </summary>
		Nothing = 0x00,
		/// <summary>
		/// Replace the existing Group with an imported Group
		/// </summary>
		Replace = 0x01,
		/// <summary>
		/// Add an imported Group
		/// </summary>
		Add = 0x02,
		/// <summary>
		/// Add an imported Group and give a new Name
		/// </summary>
		Rename = 0x03
	}

	/// <summary>
	/// This class is generated for each available and imported Group, 
	/// and determins the Behaviour during the Import
	/// </summary>
	public class GmdcGroupImporterAction 
	{
		string newname;
		public string TargetName 
		{
			get { return newname; }
			set { newname = value; }
		}

		GmdcImporterAction action;
		public GmdcImporterAction Action 
		{
			get { return action; }
			set { action = value; }
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="currentname">The current Name of the Group</param>
		public GmdcGroupImporterAction()
		{		
			action = GmdcImporterAction.Add;
		}
	}

	/// <summary>
	/// This class contains all Data Needed to import one Mesh Group
	/// </summary>
	public class ImportedGroup : GmdcGroupImporterAction
	{
		GmdcGroup group;
		public GmdcGroup Group
		{
			get { return group; }
		}

		GmdcLink link;		
		public GmdcLink Link
		{
			get { return link; }
		}

		GmdcElements elements;
		public GmdcElements Elements
		{
			get { return elements; }
		}


		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="parent">The gmdc that should act as Parent</param>
		public ImportedGroup(GeometryDataContainer parent)
		{
			group = new GmdcGroup(parent);
			link = new GmdcLink(parent);
			elements = new GmdcElements();
		}
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for GmdcLink Objects
	/// </summary>
	public class ImportedGroups : ArrayList 
	{
		public new ImportedGroup this[int index]
		{
			get { return ((ImportedGroup)base[index]); }
			set { base[index] = value; }
		}

		public ImportedGroup this[uint index]
		{
			get { return ((ImportedGroup)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(ImportedGroup item)
		{
			return base.Add(item);
		}

		public void Insert(int index, ImportedGroup item)
		{
			base.Insert(index, item);
		}

		public void Remove(ImportedGroup item)
		{
			base.Remove(item);
		}

		public bool Contains(ImportedGroup item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			ImportedGroups list = new ImportedGroups();
			foreach (ImportedGroup item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
