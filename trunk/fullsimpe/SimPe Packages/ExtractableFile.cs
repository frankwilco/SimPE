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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Collections.IO;

namespace SimPe.Packages
{
	/// <summary>
	/// Extends the Püackage Files for Extraction Methods
	/// </summary>
	public class ExtractableFile : File
	{
		/// <summary>
		/// Constructor For the Class
		/// </summary>
		/// <param name="br">The BinaryReader representing the Package File</param>
		internal ExtractableFile(BinaryReader br) : base(br) {}
		internal ExtractableFile(string flname) : base(flname) {}

		/// <summary>
		/// Init the Clone for this Package
		/// </summary>
		/// <returns>An INstance of this Class</returns>
		protected override Interfaces.Files.IPackageFile NewCloneBase() 
		{
			ExtractableFile fl = new ExtractableFile((BinaryReader)null);
			fl.header = this.header;
			
			return fl;
		}

		/// <summary>
		/// Extracts the Content of a Packed File and returs them as a MemoryStream
		/// </summary>
		/// <param name="pfd">The PackedFileDescriptor</param>
		/// <returns>The MemoryStream representing the PackedFile</returns>
		public System.IO.MemoryStream Extract(PackedFileDescriptor pfd) 
		{			
			IPackedFile pf = base.Read(pfd);
			return new MemoryStream(pf.UncompressedData);			
		}

		/// <summary>
		/// Stores a MemoryStream to a File
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <param name="pf">
		/// The Memorystream representing the PackedFile. If null and pfd is not null, the Packedfile
		/// will be loaded with Extract().
		/// </param>
		/// <param name="pfd">
		/// The description of the File, or null. If not null an additional XML File will be created
		/// representing the Information like TypeId, SubId, Instance and Group.		
		/// </param>
		/// <param name="meta">set false if you do not want to create the Meta Xml File</param>
		/// 
		public void SavePackedFile(string flname, MemoryStream pf, PackedFileDescriptor pfd, bool meta)
		{
			if (pfd!=null) 
			{
				if (pf==null) pf = Extract(pfd);
				if (meta) SaveMetaInfo(flname+".xml", pfd);
			}

			if (pf!=null) SavePackedFile(flname, pf);			
		}

		/// <summary>
		/// Saves thhe MemoryStream to a File on the local Filesystem
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <param name="pf">The Memorystream representing the Data</param>
		protected void SavePackedFile(string flname, MemoryStream pf)
		{
			StreamItem si = StreamFactory.GetStreamItem(flname, false);
			
			System.IO.FileStream fs = null;
			if (si==null) 
			{
				fs = new FileStream(flname, System.IO.FileMode.Create);
			} 
			else 
			{
				fs = si.FileStream;
				si.SetFileAccess(FileAccess.Write);
			}

			try 
			{
				byte[] d = pf.ToArray();
				fs.Write(d, 0, d.Length);
			} 
			finally 
			{
				fs.Close();
			}
		}

		/// <summary>
		/// Saves Metainformations about a PackedFile as xml output
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <param name="pfd">The description of the File</param>
		protected void SaveMetaInfo(string flname, PackedFileDescriptor pfd)
		{

			System.IO.TextWriter fs = System.IO.File.CreateText(flname);
			try 
			{				
				fs.WriteLine("<?xml version=\"1.0\" encoding=\""+fs.Encoding.HeaderName+"\" ?>");
				fs.WriteLine("<package type=\""+((uint)Header.IndexType).ToString()+"\">");
				fs.Write(pfd.GenerateXmlMetaInfo());
				fs.WriteLine("</package>");
			} 
			finally 
			{
				fs.Close();
			}
		}

		/// <summary>
		/// Generates a Package XML File containing all informations needed to recreate the Package
		/// </summary>
		/// <returns>The Package Content as XML encoded File</returns>
		public string GeneratePackageXML()
		{
			return GeneratePackageXML(true);
		}

		/// <summary>
		/// Generates a Package XML File containing all informations needed to recreate the Package
		/// </summary>
		/// <param name="header">true, if you want to generate the xml Header</param>
		/// <returns>The Package Content as XML encoded File</returns>
		public string GeneratePackageXML(bool header)
		{
			string xml = "";
			if (header) xml += "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>" + Helper.lbr;
			xml += "<package type=\""+((uint)Header.IndexType).ToString()+"\">" + Helper.lbr;
			PackedFileDescriptors list = fileindex.Flatten();

			
			foreach(PackedFileDescriptor pfd in list) 
			{
				xml += pfd.GenerateXmlMetaInfo() + Helper.lbr;
			}
			xml += "</package>" + Helper.lbr;

			return xml;
		}

		/// <summary>
		/// Generates a Package XML File containing all informations needed to recreate the Package
		/// </summary>
		/// <param name="flname">The Filename for the File</param>		
		public void GeneratePackageXML(string flname)
		{
			System.IO.TextWriter fs = System.IO.File.CreateText(flname);
			try 
			{				
				fs.WriteLine("<?xml version=\"1.0\" encoding=\""+fs.Encoding.HeaderName+"\" ?>");
				fs.Write(GeneratePackageXML(false));				
			} 
			finally 
			{
				fs.Close();
			}
		}
	}
}
