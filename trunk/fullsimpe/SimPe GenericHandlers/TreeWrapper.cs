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
using System.IO;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.PackedFiles.Wrapper
{

	/// <summary>
	/// Handles Test Conform Files
	/// </summary>
	public class Tree : Generic
	{
		/// <summary>
		/// Constructor of the class
		/// </summary>
		/// <param name="filecontent">Content of the File as Byte Array</param>
		public Tree() : base() 	
		{
			Register(0x54524545, new CreateFileObject(CreateSTRFile)); //TREE			
		}

		/// <summary>
		/// Creates a STR File Reader
		/// </summary>
		/// <param name="data">The Binary Data of the File</param>
		/// <returns>The Reder in a generic Format</returns>
		protected SimPe.PackedFiles.Wrapper.Generic CreateSTRFile(IPackedFileWrapper wrapper)
		{
			return this;
		}
	
		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"TREE Wrapper",
				"Quaxi",
				"---",
				1
				); 
		}
		#endregion
		
		#region Generic.File Member		
		
		protected override void ParseHeader()
		{
			string filename = Helper.ToString(Reader.ReadBytes(0x40));
			uint version = Reader.ReadUInt32();
			uint unknown_0 = Reader.ReadUInt32();
			uint header = Reader.ReadUInt32();
			uint unknown_1 = Reader.ReadUInt32();
			uint unknown_2 = Reader.ReadUInt32();
			uint unknown_3 = Reader.ReadUInt32();
			uint unknown_4 = Reader.ReadUInt32();
			uint count = Reader.ReadUInt32();
			//uint unknown_5 = Reader.ReadUInt32();

			items = new GenericItem[count];
		}
		
		protected override void ParseFileItem(GenericItem item)
		{
			item.Properties["Zero1"] = Reader.ReadUInt32();
			item.Properties["Zero2"] = Reader.ReadUInt32();
			item.Properties["Block1"] = Reader.ReadUInt16();
			item.Properties["Block2"] = Reader.ReadUInt16();
			item.Properties["Block3"] = Reader.ReadUInt16();
			item.Properties["Block4"] = Reader.ReadUInt16();
			item.Properties["Block5"] = Reader.ReadUInt16();
			item.Properties["Block6"] = Reader.ReadUInt16();
			item.Properties["Block7"] = Reader.ReadUInt16();
			item.Properties["Block8"] = Reader.ReadUInt16();
			item.Properties["Block9"] = Reader.ReadUInt16();
			
			//item.Properties["Zero3"] = Reader.ReadUInt32();

			byte len = Reader.ReadByte();
			item.Properties["Name"] = Helper.ToString(Reader.ReadBytes(len));
		}

		public override string GetTypeName(uint type)
		{
			return "Experimental TREE Viewer ("+items.Length.ToString()+" Items)";
		}
		#endregion		
	}
}

