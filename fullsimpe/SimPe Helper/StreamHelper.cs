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

namespace SimPe
{
	/// <summary>
	/// Some usefull Methods to Read Data
	/// </summary>
	public class StreamHelper
	{
		/// <summary>
		/// Reads a string from the Stream, that is 32-Bit Length Encoded
		/// </summary>
		/// <param name="reader"></param>
		/// <returns></returns>
		public static string ReadString(System.IO.BinaryReader reader)
		{
			int ct = reader.ReadInt32();
			return Helper.ToString(reader.ReadBytes(ct));
		}

		/// <summary>
		/// Writes a 32-Bit Length Encoded String
		/// </summary>
		/// <param name="writer"></param>
		/// <param name="s"></param>
		public static void WriteString(System.IO.BinaryWriter writer, string s)
		{
			if (s.Length>0) 
			{
				writer.Write((uint)(s.Length));
				writer.Write(Helper.ToBytes(s, s.Length));
			}
			else 
			{
				writer.Write((uint)0);
			}
		}

        /// <summary>
        /// Reads a 0-terminated string
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public static string ReadPChar(System.IO.BinaryReader r)        
        {
            
            char b = r.ReadChar();
            string s = "";
            while (b != 0 && r.BaseStream.Position <= r.BaseStream.Length)
            {
                s += b;
                b = r.ReadChar();
            }
            return s;
        }

        /// <summary>
        /// Reads a 0-terminated string
        /// </summary>
        /// <param name="w"></param>
        /// <param name="s"></param>
        public static void WritePChar(System.IO.BinaryWriter w, string s)
        {
            foreach (char c in s) w.Write(c);
            w.Write((char)0);
        }
	}
}
