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
using System.IO;

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Interface for a PackedFile object
	/// </summary>
	public interface IPackedFile
	{
		/// <summary>
		/// Returns true if the PackedFile is compressed
		/// </summary>
		bool IsCompressed
		{
			get;
		}


		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		int Size
		{
			get;
		}


		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		ushort Signature
		{
			get;
		}


		/// <summary>
		/// Returns the Uncompressed Filesize
		/// </summary>
		uint UncompressedSize
		{
			get;
		}



		/// <summary>
		/// Returns the Plain File Data (might be compressed)
		/// </summary>
		/// <remarks>
		/// All Header Informations are Cut from the Data, so you really 
		/// get the Data Stored in the PackedFile
		/// </remarks>
		Byte[] Data
		{
			get;
		}	
	
		/// <summary>
		/// Returns the Plain File Data (might be compressed)
		/// </summary>
		/// <remarks>
		/// Header Informations are Included
		/// </remarks>
		Byte[] PlainData
		{
			get;
		}	

		/// <summary>
		/// Returns the Plain File Data. If the Packed File is compress it will be decompressed
		/// </summary>
		byte[] UncompressedData
		{
			get;
		}

		/// <summary>
		/// Returns the Uncompressed Data
		/// </summary>
		/// <param name="maxsize">Maximum Number of Bytes that should be returned</param>
		/// <returns></returns>
		Byte[] GetUncompressedData(int maxsize);

		/// <summary>
		/// Returns a part of the decompresed File
		/// </summary>
		/// <param name="size">max number of bytes to decompress</param>
		/// <returns>trhe decompressed Value</returns>
	    byte[] Decompress(long size);

        /// <summary>
        /// Returns the Plain File Data. If the Packed File is compress it will be decompressed
        /// </summary>
        System.IO.Stream UncompressedStream { get;}
	}
}
