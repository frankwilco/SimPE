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

namespace SimPe.Plugin
{
	
	/// <summary>
	/// Zusammenfassung für WorkshopItems.
	/// </summary>
	public class WorkshopMMAT
	{

		/// <summary>
		/// Constructore
		/// </summary>
		/// <param name="subset">initial Name of the Subset</param>
		public WorkshopMMAT(string subset) 
		{
			this.subset = subset;
			this.mmats = new SimPe.PackedFiles.Wrapper.Cpf[0];
			this.objectStateIndex = new uint[0];
		}

		object[] tag;
		/// <summary>
		/// Arbitary Data
		/// </summary>
		public object[] Tag 
		{
			get { return tag; }
			set { tag = value; }
		}

		/// <summary>
		/// The name of the subset
		/// </summary>
		string subset = "";

		/// <summary>
		/// Returns the Name of the Subset
		/// </summary>
		public string Subset
		{
			get { return subset; }
			set { subset = value; }
		}

		SimPe.PackedFiles.Wrapper.Cpf[] mmats;
		/// <summary>
		/// The stored MMATs
		/// </summary>
		public SimPe.PackedFiles.Wrapper.Cpf[] MMATs
		{
			get { return mmats; }
		}

		/// <summary>
		/// adds the passed value if it doesn't already exist
		/// </summary>
		/// <param name="val">The value to add</param>
		public bool AddMMAT(SimPe.PackedFiles.Wrapper.Cpf mmat) 
		{			
			if (this.AddObjectStateIndex(mmat.GetItem("objectStateIndex").UIntegerValue))
			{
				mmats = (SimPe.PackedFiles.Wrapper.Cpf[])Helper.Add(mmats, mmat);
				return true;
			}
			return false;
		}
		

		/*/// <summary>
		/// all known Objects
		/// </summary>
		uint[] materialStateFlags;

		/// <summary>
		/// adds the passed value if it doesn't already exist
		/// </summary>
		/// <param name="val">The value to add</param>
		public bool AddMaterialStateFlags(uint val) 
		{
			bool check = false;
			foreach (uint i in materialStateFlags) 
			{
				if (i==val) 
				{
					check = true;
					break;
				}
			}

			if (!check) materialStateFlags = (uint[])Helper.Add(materialStateFlags, val);

			return !check;
		}

		/// <summary>
		/// Returns all known MaterialStateFlags for the SubSet
		/// </summary>
		public uint[] MaterialStateFlags
		{
			get { return materialStateFlags; }
		}*/

		/// <summary>
		/// all known values
		/// </summary>
		uint[] objectStateIndex;

		/// <summary>
		/// adds the passed value if it doesn't already exist
		/// </summary>
		/// <param name="val">The value to add</param>
		public bool AddObjectStateIndex(uint val) 
		{
			bool check = false;
			foreach (uint i in objectStateIndex) 
			{
				if (i==val) 
				{
					check = true;
					break;
				}
			}

			if (!check) objectStateIndex = (uint[])Helper.Add(objectStateIndex, val);

			return !check;
		}

		/// <summary>
		/// Returns all known ObjectStateIndex for the current subset
		/// </summary>
		public uint[] ObjectStateIndex
		{
			get { return objectStateIndex; }
		}

		public override string ToString()
		{
			return subset + " ("+this.objectStateIndex.Length.ToString()+")";
		}

	}
}
