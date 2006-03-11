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

namespace SimPe.PackedFiles.Wrapper
{
	public interface ICregGroup
	{
		uint Group
		{ 
			get;
		}		
	}
	
	/// <summary>
	/// Wrapper for 0xCDB467B8, which apear to be an Exchnge ID
	/// </summary>
	public class Creg : AbstractWrapper
		, SimPe.Interfaces.Plugin.IFileWrapper
		, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper		
	{
		

		#region Attributes
		ICregGroup grp;
		public ICregGroup Group
		{
			get {return grp;}
			set {grp = value;}
		}

		public Creg3 Group3
		{
			get {return grp as Creg3;}
		}
		#endregion

		
	

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Content Registry Wrapper",
				"Quaxi",
				"Used to Identify custom Content, and keep track of avilable Game Content",
				1,
				null
				); 
		}
		#endregion

		

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new UserInterface.CregUI();
		}
		

		public Creg() : base()
		{			
			grp = new Creg3();
			unk = new byte[0];
		}

		
		byte[] unk;
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			if (this.FileDescriptor.Group == 0x03) 
			{
				Creg3 c = new Creg3();
				c.Unserialize(reader);
				grp = c;
			}
			else 
			{
				unk = reader.ReadBytes((int)reader.BaseStream.Length);
			}
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			if (this.Group3!=null)
				this.Group3.Serialize(writer);
			else
				writer.Write(unk);
		}		
		#endregion

		

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0xCDB467B8
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
