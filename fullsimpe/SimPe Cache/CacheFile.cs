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
using System.Collections;
using SimPe;
using SimPe.Packages;

namespace SimPe.Cache
{
	/// <summary>
	/// Contains an Instance of a CacheFile
	/// </summary>
	public class CacheFile
	{
		/// <summary>
		/// This is the 64-Bit Int, a cache File needs to start with
		/// </summary>
		public const ulong SIGNATURE = 0x45506d6953;

		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;


		/// <summary>
		/// Creaet a new Instance for an empty File
		/// </summary>
		public CacheFile()
		{
			version = VERSION;
			containers = new CacheContainers();
		}		

		/// <summary>
		/// Load a Cache File from the Disk
		/// </summary>
		/// <param name="flname">the name of the File</param>
		/// <exception cref="CacheException">Thrown if the File is not readable (ie, wrong Version or Signature)</exception>
		public void Load(string flname) 
		{
			this.filename = flname;
			containers.Clear();

			if (!System.IO.File.Exists(flname)) return;

			StreamItem si = StreamFactory.UseStream(flname, FileAccess.Read, true);
			try 
			{
				BinaryReader reader = new BinaryReader(si.FileStream);

				ulong sig = reader.ReadUInt64();
				if (sig!=SIGNATURE) throw new CacheException("Unknown Cache File Signature ("+Helper.HexString(sig)+")", flname, 0);

				version = reader.ReadByte();
				if (version>VERSION) throw new CacheException("Unable to read Cache", flname, version);

				int count = reader.ReadInt32();

				for (int i=0; i<count; i++) 
				{
					CacheContainer cc = new CacheContainer(ContainerType.None);
					cc.Load(reader);
					containers.Add(cc);
				}
			} 
			finally 
			{
				si.Close();
			}
		}

		/// <summary>
		/// Load a Cache File from the Disk
		/// </summary>
		/// <param name="flname">the name of the File</param>
		public void Save(string flname) 
		{
			this.filename = flname;
			this.version = VERSION;

			StreamItem si = StreamFactory.UseStream(flname, FileAccess.Write, true);
			try 
			{
				CleanUp();

				si.FileStream.Seek(0, SeekOrigin.Begin);
				si.FileStream.SetLength(0);
				BinaryWriter writer = new BinaryWriter(si.FileStream);

				writer.Write(SIGNATURE);
				writer.Write(version);

				writer.Write((int)containers.Count);
				ArrayList offsets = new ArrayList();
				//prepare the Index
				for (int i=0; i<containers.Count; i++) 
				{
					offsets.Add(writer.BaseStream.Position);
					containers[i].Save(writer, -1);				
				}

				//write the Data
				for (int i=0; i<containers.Count; i++) 
				{
					long offset = writer.BaseStream.Position;
					writer.BaseStream.Seek((long)offsets[i], SeekOrigin.Begin);
					containers[i].Save(writer, (int)offset);				
				}
			} 
			finally 
			{
				si.Close();
			}
		}

		public void CleanUp()
		{
			for (int i=containers.Count-1; i>=0; i--)
			{
				if (!containers[i].Valid) containers.RemoveAt(i);
			}
		}

		byte version;
		string filename;
		CacheContainers containers;

		/// <summary>
		/// Returns all Available Containers
		/// </summary>
		public CacheContainers Containers 
		{
			get { return containers; }
		}
	}
}
