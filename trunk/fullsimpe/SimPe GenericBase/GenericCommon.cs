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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Just for this Library to create a GenericCommon Object
	/// </summary>
	internal class ImplementedGenericCommon : GenericCommon
	{
	}

	/// <summary>
	/// Basic Class for Generic.File and GenericItem. Implements the property System.
	/// </summary>
	public abstract class GenericCommon
	{
		/// <summary>
		/// Delegate for an Alternative Set of Property Names
		/// </summary>
		public delegate string[] GetAlternativeNames();

		/// <summary>
		/// Set this Delegate to use another Set of Names
		/// </summary>
		/// <remarks>
		/// When this var is null, the Names Property will return all Keys stored in properties, 
		/// when you assign a Function to this Attribute, the Names Property will return the return 
		/// Value of the assigned Function.
		/// </remarks>
		private GetAlternativeNames getaltnames;

		/// <summary>
		/// Properties of the File
		/// </summary>
		private Hashtable properties;

		/// <summary>
		/// Arbitary Data
		/// </summary>
		private object tag;

		/// <summary>
		/// Constructor for the class
		/// </summary>
		public GenericCommon()
		{
			properties = new Hashtable();
			getaltnames = null;
		}

		/// <summary>
		/// Returns the property List
		/// </summary>
		public Hashtable Properties
		{
			get
			{
				return GetProperties();
			}
		}

		/// <summary>
		/// Returns the property List
		/// </summary>
		protected Hashtable GetProperties()
		{
			return properties;
		}

		/// <summary>
		/// Changes the delaget for the Names retrival
		/// </summary>
		public GetAlternativeNames NameDelegate
		{
			set 
			{
				getaltnames = value;
			}
		}

		/// <summary>
		/// Returns a list of all available Property names
		/// </summary>
		public string[] Names 
		{
			get 
			{
				if (getaltnames==null) 
				{
					string[] names = new string[properties.Keys.Count];
					properties.Keys.CopyTo(names, 0);
					return  names;
				} 
				else 
				{
					return getaltnames();
				}
			}
		}

		/// <summary>
		/// Converts an Object into a ByteArray
		/// </summary>
		/// <param name="o">The Object to Convert</param>
		/// <returns>A Byte Array</returns>
		public static byte[] ToByteArray(object o) 
		{			
			if (o==null) return new byte[0];
			if (o.GetType().Name=="String") 
			{
				string s = o.ToString();
				byte[] data = new byte[s.Length];
				for (int i=0; i<data.Length; i++) data[i]=(byte)s[i];
				return data;
			} 
			else 
			{
				try 
				{
					return (byte[])o;
				} 
				catch (Exception) 
				{
					return new byte[0];
				}
			}
		}

		/// <summary>
		/// Generates a Character that can be Printed
		/// </summary>
		/// <param name="c">The Input Character</param>
		/// <param name="alt">The Character to return when the input is not displayable</param>
		/// <returns>alt or c</returns>
		public static char ToPrintableChar(char c, char alt)
		{
			if ((c>0x1F) && (c<0xff) && (c!=0xAD) && ((c<0x7F) || (c>0x9F))) return c;
			else return alt;
		}

		/// <summary>
		/// Retursn or Sets the Arbitary Data stored with this Item
		/// </summary>
		public object Tag 
		{
			get 
			{
				return tag;
			}
			set 
			{
				tag = value;
			}
		}
	}
}
