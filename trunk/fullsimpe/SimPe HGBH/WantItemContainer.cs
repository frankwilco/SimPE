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
	/// Zusammenfassung für WantItemContainer.
	/// </summary>
	public class WantItemContainer
	{
		uint guid;
		WantItem[] items;
		public WantItem[] Items
		{
			get { return items; }
			set { items = value; }
		}

		/// <summary>
		/// Returns Informations about the Selected want
		/// </summary>
		public WantInformation Information 
		{
			get 
			{
				return WantInformation.LoadWant(guid);
			}
		}

		Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		public WantItemContainer(Interfaces.IProviderRegistry provider)
		{
			items = new WantItem[0];	
			this.provider = provider;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			guid = reader.ReadUInt32();
			items = new WantItem[reader.ReadUInt32()];

			for (int i=0; i<items.Length; i++) 
			{
				items[i] = new WantItem(provider);
				items[i].Unserialize(reader);
			}
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public  void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(guid);
			writer.Write((uint)items.Length);

			for (int i=0; i<items.Length; i++) 
			{
				items[i].Serialize(writer);
			}
		}

		public override string ToString()
		{
			return Information.Name+ " (count="+items.Length.ToString()+")";
		}
	}
}
