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
using SimPe.Data;

namespace SimPe.PackedFiles.Wrapper.Supporting
{
	/// <summary>
	/// This Class handles the instance -> Name assignemnet
	/// </summary>
	public class FamilyTieCommon 
	{
		/// <summary>
		/// The Parent Wrapper
		/// </summary>
		Wrapper.FamilyTies famt;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="siminstance">Instance of the Sim</param>
		/// <param name="famt">The Parent Wrapper</param>
		public FamilyTieCommon(ushort siminstance, Wrapper.FamilyTies famt) 
		{
			this.siminstance = siminstance;
			this.famt = famt;
			sdesc = null;
		}

		/// <summary>
		/// The instance of the Target sim
		/// </summary>
		protected ushort siminstance;

		/// <summary>
		/// Returns / Sets the Instance of the Target Sim
		/// </summary>
		public ushort Instance 
		{
			get { return siminstance; }
			set 
			{ 
				if (siminstance != value) sdesc = null;
				siminstance = value; 
			}
		}

		/// <summary>
		/// name of the sim
		/// </summary>
		protected SDesc sdesc;

		/// <summary>
		/// Loads the Description File for a Sim
		/// </summary>
		protected void LoadSDesc()
		{
			if (sdesc==null) 
			{
				sdesc = new SDesc(famt.NameProvider, null, null);

				try 
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = famt.Package.FindFile(MetaData.SIM_DESCRIPTION_FILE, 0, famt.FileDescriptor.Group, siminstance);
					sdesc.ProcessData(pfd, famt.Package);					
				} 
				catch (Exception) {}
			}
		}

		/// <summary>
		/// Returns the Name of the sim
		/// </summary>
		public string SimName 
		{
			get 
			{
				LoadSDesc();
				return sdesc.SimName;
			}
		}

		/// <summary>
		/// Returns the Name of the sim
		/// </summary>
		public string SimFamilyName 
		{
			get 
			{
				LoadSDesc();
				return sdesc.SimFamilyName;
			}
		}

		/// <summary>
		/// Overrides the default ToString Method
		/// </summary>
		/// <returns>A String describing the Object</returns>
		public override string ToString()
		{
			return SimName+" "+SimFamilyName+" (0x"+Helper.HexString(siminstance)+")";
		}
	}

	/// <summary>
	/// A Sim that is stored within a FamilyTie File
	/// </summary>
	public class FamilyTieSim : FamilyTieCommon
	{		
		/// <summary>
		/// The ties he perticipates in
		/// </summary>
		FamilyTieItem[] ties;

		/// <summary>
		/// This is only stored for Savety reasons
		/// </summary>
		int blockdelimiter;

		

		/// <summary>
		/// Constructor for a new participation sim
		/// </summary>
		/// <param name="siminstance">Instance of the Sim</param>
		/// <param name="ties">the ties he perticipates in</param>
		/// <param name="famt">The Parent Wrapper</param>
		public FamilyTieSim(ushort siminstance, FamilyTieItem[] ties, Wrapper.FamilyTies famt) : base(siminstance, famt) 
		{
			this.ties = ties;
			blockdelimiter = 0x00000001;
		}

		

		/// <summary>
		/// Returns / Sets the ties he perticipates in
		/// </summary>
		public FamilyTieItem[] Ties 
		{
			get { return ties; }
			set { ties = value; }
		}

		/// <summary>
		/// Returns / Sets the Block Delimiter
		/// </summary>
		internal int BlockDelimiter 
		{
			get { return blockdelimiter; }
			set { blockdelimiter = value; }
		}

		

	}

	/// <summary>
	/// Contains one FamilyTie
	/// </summary>
	public class FamilyTieItem : FamilyTieCommon
	{
		/// <summary>
		/// The Type of the tie
		/// </summary>
		MetaData.FamilyTieTypes type;

		/// <summary>
		/// Creates a new FamilyTie
		/// </summary>
		/// <param name="type">The Type of the tie</param>
		/// <param name="siminstance">The instance of the Target sim</param>
		/// <param name="famt">The Parent Wrapper</param>
		public FamilyTieItem(MetaData.FamilyTieTypes type, ushort siminstance, Wrapper.FamilyTies famt) : base(siminstance, famt)
		{
			this.type = type;
		}

		/// <summary>
		/// Returns / Sets the Type of the Tie
		/// </summary>
		public MetaData.FamilyTieTypes Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Overrides the default ToString Method
		/// </summary>
		/// <returns>A String describing the Object</returns>
		public override string ToString()
		{
			return ((LocalizedFamilyTieTypes)type).ToString()+": "+base.ToString ();
		}

	}
}
