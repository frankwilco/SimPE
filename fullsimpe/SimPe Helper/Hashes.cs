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
using Classless.Hasher;

namespace SimPe
{
	/// <summary>
	/// Contains needed Hash Algorithms
	/// </summary>
	public class Hashes
	{
		static CRC crc24 = new CRC(CRCParameters.GetParameters(CRCStandard.CRC24));
		static CRC crc32 = new CRC(new Classless.Hasher.CRCParameters(32, 0x04C11DB7, 0xffffffff, 0, false));

		public static CRC Crc24 
		{
			get { return crc24; }
		}

		public static CRC Crc32 
		{
			get { return crc32; }
		}

		/// <summary>
		/// Seed Value for Group CRC-24 hash
		/// </summary>
		public const uint CRC24Seed = 0x00B704CE;

		/// <summary>
		/// Poly Value for CRC-24 Hash
		/// </summary>
		public const uint CRC24Poly = 0x01864CFB;

		/// <summary>
		/// Seed Value for Group CRC-32 hash
		/// </summary>
		public const uint CRC32Seed = 0x00B704CE;

		/// <summary>
		/// Poly Value for CRC-32 Hash
		/// </summary>
		public const uint CRC32Poly = 0x01864CFB;

		/// <summary>
		/// Returns the CRC24 Hash of a byte Array
		/// </summary>
		/// <param name="seed"></param>
		/// <param name="poly"></param>
		/// <param name="octets"></param>
		/// <returns>The CRS-24 hash Value</returns>
		public static long CRC24(uint seed, uint poly, char[] octets)
		{
			long crc = seed;
			int i;

			for (int index=0; index<octets.Length; index++)
			{
				crc ^= octets[index] << 16;
				for (i = 0; i < 8; i++) 
				{
					crc <<= 1;
					if ((crc & 0x1000000) != 0)
						crc ^= poly;
				}
			}
			return (crc & 0x00ffffff);
		}

		public static ulong ToLong(byte[] input)
		{
			ulong ret = 0;
			foreach (byte b in input)
			{
				ret = ret << 8;
				ret += b;
			}

			return ret;
		}

		/// <summary>
		/// Returns the Group hash for a File
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static uint FileGroupHash(string filename) 
		{
			return Data.MetaData.CUSTOM_GROUP;
			/*filename = filename.Trim().ToLower();
			byte[] rt = crc24.ComputeHash(Helper.ToBytes(filename, 0));//CRC24Seed, CRC24Poly, filename.ToCharArray());

			return (uint)(ToLong(rt) | 0x7f000000);*/
		}

		/// <summary>
		/// Returns the NREF Group Hash
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static uint GroupHash(string name)
		{
			name = name.Trim().ToLower();
			byte[] rt = crc24.ComputeHash(Helper.ToBytes(name, 0));//CRC24Seed, CRC24Poly, filename.ToCharArray());

			return (uint)(ToLong(rt) | 0x7f000000);
		}

		/// <summary>
		/// Returns the Instance Hash for a File
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static uint InstanceHash(string filename) 
		{
			filename = filename.Trim().ToLower();
			byte[] rt = crc24.ComputeHash(Helper.ToBytes(filename, 0));//CRC24Seed, CRC24Poly, filename.ToCharArray());

			return (uint)(ToLong(rt) | 0xff000000);
		}

		/// <summary>
		/// Returns the Instance Hash for a File
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static uint SubTypeHash(string filename) 
		{
			filename = filename.Trim().ToLower();
			byte[] rt = crc32.ComputeHash(Helper.ToBytes(filename, 0));//CRC24Seed, CRC24Poly, filename.ToCharArray());

			return (uint)ToLong(rt);
		}

		/// <summary>
		/// Retruns the Filename without the Hash
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static string StripHashFromName(string filename) 
		{
			if (filename == null) return "";

			if (filename.IndexOf("#")==0) 
			{
				if (filename.IndexOf("!")>=1) 
				{
					string[] part = filename.Split("!".ToCharArray(), 2);
					return part[1];
				}
			}

			return filename;
		}

		/// <summary>
		/// Retruns the Group Specified by the Group Hash
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="defgroup"></param>
		/// <returns></returns>
		public static uint GetHashGroupFromName(string filename, uint defgroup) 
		{
			if (filename.IndexOf("#")==0) 
			{
				if (filename.IndexOf("!")>=1) 
				{
					string[] part = filename.Split("!".ToCharArray(), 2);
					
					string hash = part[0].Replace("#", "").Replace("!", "");
					try 
					{
						return Convert.ToUInt32(hash, 16);
					} 
					catch (Exception)
					{
						return defgroup;
					}
				}
			}

			return defgroup;
		}

		/// <summary>
		/// Creates a hashed Filename
		/// </summary>
		/// <param name="hash"></param>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static string AssembleHashedFileName(uint hash, string filename)
		{
			return "#0x"+Helper.MinStrLength(hash.ToString("x"),8)+"!"+filename;
		}
	}
}
