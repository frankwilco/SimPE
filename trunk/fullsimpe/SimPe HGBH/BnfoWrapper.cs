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
	public enum BnfoVersions : uint
	{
		Business = 0x04
	}
	/// <summary>
	/// Wrapper for 0x104F6A6E , which apear to be the "Business info Resource"
	/// </summary>
	public class Bnfo : AbstractWrapper
		, SimPe.Interfaces.Plugin.IFileWrapper
		, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper		
	{
		

		#region Attributes
		uint ver;
		public BnfoVersions Version
		{
			get {return (BnfoVersions)ver; }
			set {ver = (uint)value;}
		}

		uint level1, level2;
		public uint CurrentBusinessState
		{
			get {return level1;}
			set {level1 = value;}
		}
		public uint MaxSeenBusinessState
		{
			get {return level2;}
			set {level2 = value;}
		}

		uint unk1, unk2;
		uint empct;

		Collections.BnfoCustomerItems citems;
		public Collections.BnfoCustomerItems CustomerItems
		{
			get {return citems;}
		}
		#endregion

		
		public Bnfo() : base()
		{			
			Version = BnfoVersions.Business;
			citems = new SimPe.Plugin.Collections.BnfoCustomerItems(this);
		}

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Business Info Wrapper",
				"Quaxi",
				"Contains Informations about the Business on a Lot (like Cutomer Loiality)",
				1,
				null
				); 
		}
		#endregion

		

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new BnfoUI();
		}
		

		

		byte[] over;
		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			ver = reader.ReadUInt32();
			level1 = reader.ReadUInt32();
			level2 = reader.ReadUInt32();
			unk1 = reader.ReadUInt32();
			unk2 = reader.ReadUInt32();
			empct = reader.ReadUInt32();

			int ct = reader.ReadInt32();
			citems.Clear();
			for (int i=0; i<ct; i++)
			{
				BnfoCustomerItem item = new BnfoCustomerItem(this);
				item.Unserialize(reader);
				
				citems.Add(item);
			}
#if TRACE
			Console.WriteLine("Employes: "+empct.ToString());
			Console.WriteLine("Server Customers: "+ct.ToString());
#endif
			long pos = reader.BaseStream.Position;
			over = reader.ReadBytes((int)(reader.BaseStream.Length - pos));

			reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
			ct = reader.ReadInt32();
			for (int i=0; i<ct; i++)
				reader.ReadBytes(86);


#if TRACE
			Console.WriteLine("Employes: "+reader.BaseStream.Position.ToString("X"));
#endif
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(ver);;
			writer.Write(level1);
			writer.Write(level2);
			writer.Write(unk1);
			writer.Write(unk2);
			writer.Write(empct);

			writer.Write((int)citems.Count);
			foreach (BnfoCustomerItem item in citems)
				item.Serialize(writer);

			writer.Write(over);
		}		
		#endregion

		

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0x104F6A6E
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
