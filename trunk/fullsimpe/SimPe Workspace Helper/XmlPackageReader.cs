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
using System.Xml;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Handles Extracted Pakage Files
	/// </summary>
	public class XmlPackageReader
	{
		/// <summary>
		/// Creates a Package File from a previously extracted Package
		/// </summary>
		/// <param name="filename">Filename of package.xml File describing the Package</param>
		/// <param name="pb">A Progressbar indicating the progress</param>
		/// <returns>Binary Reader representing the Package File</returns>
		public static System.IO.BinaryReader OpenExtractedPackage(ProgressBar pb, string filename) 
		{
			string path = System.IO.Path.GetDirectoryName(filename);			
			System.Xml.XmlDocument xmlfile = new XmlDocument();
			xmlfile.Load(filename);

			//Root Node suchen
			XmlNodeList XMLData = xmlfile.GetElementsByTagName("package");

			ArrayList list = new ArrayList();
			//Alle Eintr&auml;ge im Root Node verarbeiten
			Data.MetaData.IndexTypes type = Data.MetaData.IndexTypes.ptShortFileIndex;
			for (int i=0; i<XMLData.Count; i++)
			{
				XmlNode node = XMLData.Item(i);

				object o = node.Attributes["type"].Value; if (o==null) o="1";
				type = (Data.MetaData.IndexTypes)uint.Parse(o.ToString());
				
				if (pb!=null) pb.Maximum = node.ChildNodes.Count;
				int count = 0;
				foreach (XmlNode subnode in node) 
				{
					if (pb!=null) 
					{
						pb.Value = count++;
						System.Windows.Forms.Application.DoEvents();
					}
					///a New FileItem
					if (subnode.LocalName == "packedfile") 
					{
						list.Add(CreateDescriptor(path, subnode));
					}
				}
			}			

			SimPe.Packages.GeneratableFile file = SimPe.Packages.GeneratableFile.CreateNew();
			file.BeginUpdate();
			file.Header.IndexType = type;

			foreach(SimPe.Packages.PackedFileDescriptor pfd in list) 
			{
				file.Add(pfd);
				if (pfd.Type == Packages.File.FILELIST_TYPE) 
				{
					file.FileList = pfd;
				}
			}

			System.IO.MemoryStream ms = file.Build();
			file.EndUpdate();
			if (pb!=null) pb.Value = pb.Maximum;
			return new System.IO.BinaryReader(ms);
		}

		/// <summary>
		/// Loads a previously extracted File
		/// </summary>
		/// <param name="filename">name of the xml Description File</param>
		/// <returns>a FileDescription where you have to put the UserData in</returns>
		public static SimPe.Packages.PackedFileDescriptor OpenExtractedPackedFile(string filename)  
		{
			string path = System.IO.Path.GetDirectoryName(filename);			
			System.Xml.XmlDocument xmlfile = new XmlDocument();
			xmlfile.Load(filename);

			//Root Node suchen
			XmlNodeList XMLData = xmlfile.GetElementsByTagName("package");

			for (int i=0; i<XMLData.Count; i++)
			{
				XmlNode node = XMLData.Item(i);

				object o = node.Attributes["type"].Value; if (o==null) o="1";				
				foreach (XmlNode subnode in node) 
				{		
					///a New FileItem
					if (subnode.LocalName == "packedfile") 
					{
						return CreateDescriptor(path, subnode);
					}
				}
			}		

			return null;
		}

		/// <summary>
		/// Creates a new File Descriptor (with Userdata) as defined by the XmlNode
		/// </summary>
		/// <param name="parentpath">The Path where the Package xml is located</param>
		/// <param name="node">packedfile XML-Node</param>
		/// <returns>A PackedFile Descriptor</returns>
		protected static SimPe.Packages.PackedFileDescriptor CreateDescriptor(string parentpath, XmlNode node) 
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			foreach(XmlNode subnode in node) 
			{
				switch (subnode.Name) 
				{
					case "type": 
					{
						foreach (XmlNode typenode in subnode) 
						{
							switch (typenode.Name) 
							{
								case "number":
								{
									pfd.Type = Convert.ToUInt32(typenode.InnerText);
									break;
								}
							}
						}
						break;
					}
					case "classid": 
					{
						pfd.SubType = Convert.ToUInt32(subnode.InnerText);
						break;
					}
					case "group": 
					{
						pfd.Group = Convert.ToUInt32(subnode.InnerText);
						break;
					}
					case "instance": 
					{
						pfd.Instance = Convert.ToUInt32(subnode.InnerText);
						break;
					}
				}
			}

			//now load the Files Data
			object flname = node.Attributes["name"].Value; if (flname==null) flname="";
			object path = node.Attributes["path"].Value; if (path==null) path="";
			pfd.Path = path.ToString();
			pfd.Filename = flname.ToString();

			flname = System.IO.Path.Combine(parentpath, System.IO.Path.Combine(path.ToString(), flname.ToString()));

			if (File.Exists(flname.ToString())) 
			{
                FileStream fs = System.IO.File.OpenRead(flname.ToString());
				System.IO.BinaryReader mbr = new System.IO.BinaryReader(fs);
				try 
				{
					byte[] data = new byte[mbr.BaseStream.Length];
					for (int i=0; i<data.Length; i++) data[i] = mbr.ReadByte();
					pfd.UserData = data;
				} 
				finally 
				{
					mbr.Close();
                    mbr = null;
                    fs.Close();
                    fs.Dispose();
                    fs = null;
				}
			}

			return pfd;
		}
	}
}
