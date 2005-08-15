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
using SimPe.Geometry;

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Enumerates possible action for a Joint Animation
	/// </summary>
	public enum AnimImporterAction : byte
	{
		/// <summary>
		/// Ignore the Animation
		/// </summary>
		Nothing = 0x00,
		/// <summary>
		/// Replace the existing Animation <see cref="ImportedFrameBlock.Target"/> with the one stored in the <see cref="ImportedFrameBlock.FrameBlock"/> Member
		/// </summary>
		Replace = 0x01,
		/// <summary>
		/// Add the Animation stored in the <see cref="ImportedFrameBlock.FrameBlock"/> Member
		/// </summary>
		//Add = 0x02		
	}

	/// <summary>
	/// This class contains all Data Needed to import one <see cref="AnimationFrameBlock"/> 
	/// </summary>
	public class ImportedFrameBlock
	{
		/// <summary>
		/// internal Attribute
		/// </summary>
		AnimImporterAction action;
		/// <summary>
		/// Returns/Sets the action that should be performed
		/// </summary>
		public AnimImporterAction Action 
		{
			get { return action; }
			set { action = value; }
		}		

		

		/// <summary>
		/// The name of the Imported Bone		
		/// </summary>
		public string ImportedName 
		{
			get { return afb.Name; }
		}

		/// <summary>
		/// internal Attribute
		/// </summary>
		AnimationFrameBlock target;

		/// <summary>
		/// The Animation that should get Replaced
		/// </summary>
		public AnimationFrameBlock Target 
		{
			get { return target; }
			set { target = value; }
		}

		bool dz;
		/// <summary>
		/// true if the First Frame (TimeCode 0) should be ignored during the Import
		/// </summary>
		public bool DiscardZeroFrame
		{
			get { return dz; }
			set { dz = value; }
		}

		bool ruf;
		/// <summary>
		/// Remove all Keyframes that are not needed by the Animation?
		/// </summary>
		public bool RemoveUnneeded
		{
			get { return ruf; }
			set { ruf = value; }
		}

		AnimationFrameBlock afb;
		/// <summary>
		/// The new Bone
		/// </summary>
		public AnimationFrameBlock FrameBlock
		{
			get { return afb; }
		}				
		
		/// <summary>
		/// Returns the color that should be used to display this Group in the "Import Groups" ListView
		/// </summary>
		public System.Drawing.Color MarkColor 
		{
			get 
			{				
				if (Action==AnimImporterAction.Nothing) return System.Drawing.Color.Silver;
				if (Target==null) return System.Drawing.Color.Red;
				return System.Drawing.Color.DarkBlue;
			}
		}		

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="parent">The gmdc that should act as Parent</param>
		public ImportedFrameBlock(AnimationFrameBlock afb)
		{
			dz = false;
			ruf = true;
			this.afb = afb;				
			action = AnimImporterAction.Nothing;
		}		

		/// <summary>
		/// Tries to find a <see cref="AnimationFrameBlock"/>  with the same Name in the passed <see cref="AnimationMeshBlock" />.
		/// </summary>
		public void FindTarget(AnimationMeshBlock amb)
		{
			action = AnimImporterAction.Nothing;
			foreach (AnimationFrameBlock afb in amb.Part2)
				if (afb.Name == ImportedName)
				{
					action = AnimImporterAction.Replace;
					target = afb;
					break;
				}
		}

		/// <summary>
		/// Replaces the Frames within <see cref="Target"/>, with the ones stored in <see cref="FrameBlock"/>
		/// </summary>
		/// <param name="amb"></param>
		public void ReplaceFrames()
		{
			if (Target==null) return;
			Target.ClearFrames();
			Target.CreateBaseAxisSet(AnimationTokenType.SixByte);
			foreach (AnimationFrame af in FrameBlock.Frames)
				if (!this.DiscardZeroFrame || af.TimeCode!=0)
					Target.AddFrame(af.TimeCode, af.X, af.Y, af.Z, af.Linear);

			if (ruf) Target.RemoveUnneededFrames();
		}
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for <see cref="ImportedGroup"/> Objects
	/// </summary>
	public class ImportedFrameBlocks : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new ImportedFrameBlock this[int index]
		{
			get { return ((ImportedFrameBlock)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public ImportedFrameBlock this[uint index]
		{
			get { return ((ImportedFrameBlock)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(ImportedFrameBlock item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, ImportedFrameBlock item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(ImportedFrameBlock item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(ImportedFrameBlock item)
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
			ImportedFrameBlocks list = new ImportedFrameBlocks();
			foreach (ImportedFrameBlock item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
