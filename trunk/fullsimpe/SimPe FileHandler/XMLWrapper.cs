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
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Represents a PackedFile in XmlFormat
	/// </summary>
	public class Xml : AbstractWrapper, SimPe.Interfaces.Plugin.IFileWrapper, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
	{
		/// <summary>
		/// the xml text
		/// </summary>
		protected string text;

		/// <summary>
		/// Returns the xml File as String
		/// </summary>
		public string Text
		{
			get
			{
				return text;
			}
			set 
			{
				text = value;
			}
		}
		
		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Default XML Wrapper",
				"Quaxi",
				"---",
				1
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.Xml();
		}

		public Xml() : base(){}

		protected override void Unserialize(System.IO.BinaryReader reader)
		{						
			System.IO.StreamReader sr = new System.IO.StreamReader(reader.BaseStream);
			text = sr.ReadToEnd();
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			byte[] data = new byte[Text.Length];
			for (int i=0; i<Text.Length; i++) data[i] = (byte)Text[i];			
			
			writer.Write(data);			
		}
		#endregion

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								 0x00000000 //UI Data  
							   };
				return Types;
			}
		}

		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {
								 (byte)'<',
								 (byte)'?',
								 (byte)'x',
								 (byte)'m',
								 (byte)'l'								 
							 };
				return sig;
			}
		}


		#endregion
	}
}
