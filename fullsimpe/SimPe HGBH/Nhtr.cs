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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{		
	public enum NhtrVersions : uint
	{
		Business = 0x04
	}
	/// <summary>
	/// Wrapper for 0xABD0DC63 , which apear to be the "Neighborhood terrain" Resource
	/// </summary>
	public class Nhtr : AbstractWrapper
		, SimPe.Interfaces.Plugin.IFileWrapper
		, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper		
	{
		

		#region Attributes
		uint ver;		

		public NhtrVersions Version
		{
			get {return (NhtrVersions)ver; }
			set {ver = (uint)value;}
		}

		NhtrList[] items;
		public NhtrList[] Items
		{
			get {return items;}
		}
		
		
		#endregion

		
		public Nhtr() : base()
		{			
			Ambertation.BaseChangeableNumber.DigitBase = 16;
			Version = NhtrVersions.Business;
			NhtrListType[] types = Enum.GetValues(typeof(NhtrListType)) as NhtrListType[];
			items = new NhtrList[types.Length];
			foreach (NhtrListType tp in types)
				items[(int)tp] = new NhtrList(this, tp);			
		}

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Neighborhood Terrain Wrapper",
				"TickleOnTheTum, jaxad0127 and Quaxi",
				"Contains Informations about the Neighborhood Terrain.",
				3,
				null
				); 
		}
		#endregion

		

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new NhtrUI();
		}						
		
		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			
			ver = reader.ReadUInt32();
			foreach (NhtrList list in items)
			{
				list.Clear();
				list.Unserialize(reader);
			}
			
			//Console.WriteLine(reader.BaseStream.Position - reader.BaseStream.Length);			
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(ver);
			foreach (NhtrList list in items)			
				list.Serialize(writer);			
		}		
		#endregion

		

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0xABD0DC63
							   };
				return Types;
			}
		}


		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {					 
							 };
				return sig;
			}
		}		
		
		#endregion		
	}

}
