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
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Packages
{
	/// <summary>
	/// A File within a Package
	/// </summary>
	public class PackedFile : IPackedFile
	{


		/// <summary>
		/// Constructor for the class
		/// </summary>
		/// <param name="content">The Content of the Packed File</param>
		internal PackedFile(Byte[] content)
		{
			data = content;
			headersize = 0;
			uncdata = null;
		}

		/// <summary>
		/// The Size of the PackedFile Header
		/// </summary>
		public int headersize;

		/// <summary>
		/// Returns true if the PackedFile is compressed
		/// </summary>
		public bool IsCompressed
		{
			get 
			{
				return ((headersize!=0) && (Signature==SimPe.Data.MetaData.COMPRESS_SIGNATURE));
			}
		}

		/// <summary>
		/// Size of the compressed File
		/// </summary>		
		internal Int32 size;

		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		public int Size
		{
			get 
			{
				return size;
			}
		}


		/// <summary>
		/// Compression Signature
		/// </summary>		
		internal Int16 signature;

		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		public int Signature
		{
			get 
			{
				return signature;
			}
		}



		/// <summary>
		/// Uncompressed Filesize
		/// </summary>		
		internal UInt32 uncsize;

		/// <summary>
		/// Returns the Uncompressed Filesize
		/// </summary>
		public uint UncompressedSize
		{
			get 
			{
				return uncsize;
			}
		}



		/// <summary>
		/// the File Data
		/// </summary>		
		public Byte[] data;
		
		/// <summary>
		/// the uncompressed Data
		/// </summary>
		internal Byte[] uncdata;

		/// <summary>
		/// Returns the Plain File Data (might be compressed)
		/// </summary>
		/// <remarks>
		/// All Header Informations are Cut from the Data, so you really 
		/// get the Data Stored in the PackedFile
		/// </remarks>
		public Byte[] Data
		{
			get 
			{
				if (headersize>0) 
				{
					Byte[] sub = new Byte[data.Length - headersize];
					for(int i=headersize; i<data.Length; i++) sub[i-headersize]=data[i];
					return sub;
				} 
				else 
				{
					return data;
				}
			}
		}

		/// <summary>
		/// Returns the Plain File Data. If the Packed File is compress it will be decompressed
		/// </summary>
		public Byte[] UncompressedData
		{
			get 
			{
				if (IsCompressed)
				{
					if (uncdata==null)	uncdata = Uncompress(data, UncompressedSize, this.headersize);
					return uncdata;
				}
				else 
				{
					return Data;
				}
			}
		}	
	
		/// <summary>
		/// Returns a part of the decompresed File
		/// </summary>
		/// <param name="size">max number of bytes to decompress</param>
		/// <returns>trhe decompressed Value</returns>
		public byte[] Decompress(long size) 
		{
			size = Math.Max(size, UncompressedSize);
			return Uncompress(data, (uint)size, this.headersize);
		}

		#region decompression

		/// <summary>
		/// Uncompresses the File Data passed
		/// </summary>
		/// <param name="data">Relevant File Data</param>
		/// <param name="targetSize">Size of the uncompressed Data</param>
		/// <returns>The uncompressed FileData</returns>
		public static Byte[] Uncompress(Byte[] data, uint targetSize, int offset)
		{
			Byte[] uncdata = null;
			int index = offset;			

			/*if (uncdata==null) 
			{
				try 
				{
					uncdata = new Byte[Convert.ToInt32(Math.Round(1.2*Math.Max(targetSize, data.Length)))];
				} 
				catch(Exception) {}
			}

			if (uncdata==null) 
			{
				uncdata = new Byte[Math.Max(targetSize, data.Length)];
			}*/

			try 
			{
				uncdata = new Byte[targetSize];
			} 
			catch(Exception) 
			{
				uncdata = new Byte[0];
			}
			
			int uncindex = 0;
			int plaincount = 0;
			int copycount = 0;
			int copyoffset = 0;
			Byte cc = 0;
			Byte cc1 = 0;
			Byte cc2 = 0;
			Byte cc3 = 0;
			int source;
			//System.IO.StreamWriter sw = new System.IO.StreamWriter(@"c:\decomp1.txt");
			try 
			{
				while ((index<data.Length) && (data[index] < 0xfc))
				{
					cc = data[index++];
				
					if ((cc&0x80)==0)
					{
						cc1 = data[index++];
						plaincount = (cc & 0x03);
						copycount = ((cc & 0x1C) >> 2) + 3;
						copyoffset = ((cc & 0x60) << 3) + cc1 +1;
					} 
					else if ((cc&0x40)==0)
					{
						cc1 = data[index++];
						cc2 = data[index++];
						plaincount = (cc1 & 0xC0) >> 6 ; 
						copycount = (cc & 0x3F) + 4 ;
						copyoffset = ((cc1 & 0x3F) << 8) + cc2 +1;							
					} 
					else if ((cc&0x20)==0)
					{
						cc1 = data[index++];
						cc2 = data[index++];
						cc3 = data[index++];
						plaincount = (cc & 0x03);
						copycount = ((cc & 0x0C) << 6) + cc3 + 5;
						copyoffset = ((cc & 0x10) << 12) + (cc1 << 8) + cc2 +1;
					} 
					else 
					{												
						plaincount = (cc - 0xDF) << 2; 
						copycount = 0;
						copyoffset = 0;				
					}

					//sw.WriteLine("pc="+plaincount+", cc="+copycount+", co="+copyoffset+", id="+cc);
					for (int i=0; i<plaincount; i++) uncdata[uncindex++] = data[index++];

					source = uncindex - copyoffset;	
					for (int i=0; i<copycount; i++) uncdata[uncindex++] = uncdata[source++];
							
				}//while
			} //try
			catch(Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
			//sw.Close();

			if (index<data.Length) 
			{
				plaincount = (data[index++] & 0x03);
				for (int i=0; i<plaincount; i++) 
				{
					if (uncindex>=uncdata.Length) break;
					uncdata[uncindex++] = data[index++];
				}
			}			
			/*if (uncdata.Length > uncindex) 
			{
				Byte[] ret = new Byte[uncindex-1];
				for (int i=0; i<ret.Length; i++) ret[i]=uncdata[i];
				return ret;
			} 
			else 
			{*/
				return uncdata;
			//}
		}
		#endregion		

		
	}
}
