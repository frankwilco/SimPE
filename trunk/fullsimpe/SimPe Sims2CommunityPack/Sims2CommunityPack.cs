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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using System.Xml;

namespace SimPe.Packages
{
	/// <summary>
	/// This class contains static Methods you can use to Handle S2CP Files
	/// </summary>
	public class Sims2CommunityPack
	{
		/// <summary>
		/// Defines the Default Compression that is used
		/// </summary>
		public const CompressionStrength DEFAULT_COMPRESSION_STRENGTH = CompressionStrength.None;

		/// <summary>
		/// Enumerates the Strength of the Used Compression
		/// </summary>
		public enum CompressionStrength:int 
		{
			/// <summary>
			/// Don't use any kind of compression
			/// </summary>
			None = 0x00,
			/// <summary>
			/// Fastest Compression (biggest Size)
			/// </summary>
			Fastest = 0x01,
			/// <summary>
			/// 
			/// </summary>
			Faster = 0x02,
			/// <summary>
			/// 
			/// </summary>
			Fast = 0x03,
			/// <summary>
			/// Default Compression Strength
			/// </summary>
			Default = 0x04,
			/// <summary>
			/// 
			/// </summary>
			Slow = 0x05,
			/// <summary>
			/// 
			/// </summary>
			Slower = 0x07,
			/// <summary>
			/// Slowest compression (smallest File)
			/// </summary>
			Slowest = 0x09
		}

		/// <summary>
		/// Decompress <paramref name="instream">input</paramref> writing 
		/// decompressed data to <paramref name="outstream">output stream</paramref>
		/// </summary>
		/// <param name="instream">Compressed Data</param>
		/// <param name="outstream">Uncompressed Data</param>
		/// <remarks>Overwritten, because i needed the <paramref name="outstream">output stream</paramref> 
		/// to Seek to the Beginning</remarks>
		protected static void Decompress(Stream instream, Stream outstream) 
		{
			ICSharpCode.SharpZipLib.BZip2.BZip2.Decompress(instream, outstream);
			outstream.Seek(0, System.IO.SeekOrigin.Begin);
		}
		
		/// <summary>
		/// Compress <paramref name="instream">input stream</paramref> sending 
		/// result to <paramref name="outputstream">output stream</paramref>
		/// </summary>
		/// <param name="outstream"></param>
		/// <param name="instream"></param>
		/// <param name="strength">Strngth of the Compression</param>
		/// <remarks>I had to change the Origial Compression Methode in a way that it woun't close 
		/// the <paramref name="instream">input stream</paramref> and that it seeks to the Beginning 
		/// of it on startup</remarks>
		protected static void Compress(Stream instream, Stream outstream, CompressionStrength strength) 
		{			
			System.IO.Stream bos = outstream;
			System.IO.Stream bis = instream;
			bis.Seek(0, System.IO.SeekOrigin.Begin);
			int ch = bis.ReadByte();
			ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream bzos = new ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(bos, (int)strength);
			while (ch != -1) 
			{
				bzos.WriteByte((byte)ch);
				ch = bis.ReadByte();
			}
			bzos.Close();
		}
	

		/// <summary>
		/// Create a Sims2CommunityPack File
		/// </summary>
		/// <param name="file">The Descriptors of the Package to inlcude</param>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		/// <returns>The MemoryStream containing the S2CP File</returns>
		public static MemoryStream Create(S2CPDescriptor file, bool extension) 
		{
			S2CPDescriptor[] ms = new S2CPDescriptor[1];
			ms[0] = file;
			return Create(ms, extension);
		}

		/// <summary>
		/// Create a Sims2CommunityPack File
		/// </summary>
		/// <param name="files">List of Descriptors for all Packages to include</param>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		/// <returns>The MemoryStream containing the S2CP File</returns>
		public static MemoryStream Create(S2CPDescriptor[] files, bool extension) 
		{
			string xml = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + (char)0x0a;
			xml += "<Sims2Package type=\"Object\">" + (char)0x0a;
			xml += "<GameVersion>2141707388.153.1</GameVersion>" + (char)0x0a;

			int offset = 0;
			MemoryStream[] streams = new MemoryStream[files.Length];
			bool containscompress = false;
			for (int i=0; i<files.Length; i++)
			{
				if (files[i].Compressed != CompressionStrength.None) 
				{
					MemoryStream cms = new MemoryStream();
					Compress(files[i].Package.Build(), cms, files[i].Compressed);
					streams[i] = new MemoryStream(cms.ToArray());
					containscompress = true;
				} 
				else 
				{
					streams[i] = files[i].Package.Build();
				}
				MemoryStream m = streams[i];


				xml += "<PackagedFile>" + (char)0x0a;
				xml += "<Name><![CDATA["+files[i].Name+"]]></Name>" + (char)0x0a;
				xml += "<Crc>"+files[i].Crc+"</Crc>" + (char)0x0a;
				xml += "<Length>" + m.Length.ToString() + "</Length>" + (char)0x0a;
				xml += "<Type>"+files[i].Type+"</Type>" + (char)0x0a;
				xml += "<Offset>" + offset.ToString() + "</Offset>" + (char)0x0a;
				xml += "<Description><![CDATA["+files[i].Description+"]]></Description>" + (char)0x0a;

				if (extension) 
				{
					xml += "<Sims2CommuniytExt>" + (char)0x0a;
					xml += "<Compressed>"+((int)files[i].Compressed).ToString()+"</Compressed>" + (char)0x0a;
					xml += "<Author>" + (char)0x0a;
					xml += "<PersonalName><![CDATA["+files[i].Author+"]]></PersonalName>" + (char)0x0a;
					xml += "<Contact><![CDATA["+files[i].Contact+"]]></Contact>" + (char)0x0a;
					xml += "</Author>" + (char)0x0a;
					xml += "<Title><![CDATA["+files[i].Title+"]]></Title>" + (char)0x0a;
					if (files[i].ObjectVersion!="0") xml += "<ObjectVersion>"+files[i].ObjectVersion+"</ObjectVersion>" + (char)0x0a;
					xml += "<GlobalGUID><![CDATA["+files[i].Guid+"]]></GlobalGUID>" + (char)0x0a;
					xml += "<Dependency>" + (char)0x0a;
					foreach (S2CPDescriptorBase s2cpd in files[i].Dependency) 
					{
						xml += "<PackagedFile>" + (char)0x0a;
						xml += "<Name><![CDATA["+s2cpd.Name+"]]></Name>" + (char)0x0a;
						if (s2cpd.ObjectVersion!="0") xml += "<ObjectVersion>"+s2cpd.ObjectVersion+"</ObjectVersion>" + (char)0x0a;
						xml += "<GlobalGUID><![CDATA["+s2cpd.Guid+"]]></GlobalGUID>" + (char)0x0a;
						if (s2cpd.Optional) xml += "<Optional />" + (char)0x0a;
						xml += "</PackagedFile>" + (char)0x0a;
					}
					xml += "</Dependency>" + (char)0x0a;
					xml += "</Sims2CommuniytExt>" + (char)0x0a;
				}
				xml += "</PackagedFile>" + (char)0x0a;
				

				offset += (int)m.Length;
			}
			xml += "</Sims2Package>";

			MemoryStream ms = new MemoryStream();
			BinaryWriter bw = new BinaryWriter(ms);

			if (!containscompress) bw.Write(Helper.ToBytes("Sims2 Packager 1.0"));
			else bw.Write(Helper.ToBytes("Sims2 Packager x.1"));
			bw.Write((int)(22 + xml.Length));
			bw.Write(Helper.ToBytes(xml));

			for (int i=0; i<streams.Length; i++)
			{
				MemoryStream m = streams[i];
				bw.Write(m.ToArray());
			}
			

			return ms;
		}

		/// <summary>
		/// Parse the Dependency Node in an XML
		/// </summary>
		/// <param name="dep">The Dependency Node</param>
		/// <returns>The Descriptor of the DependencyPackage (the package value is NULL)</returns>
		/// <remarks>The Descriptor won't contain the package Data. Yo you have to find the Matching Package 
		/// by the returned GUID and Name</remarks>
		protected static S2CPDescriptorBase ParesDependingPackedFile(XmlNode dep)
		{
			S2CPDescriptorBase s2cp = new S2CPDescriptorBase(null);
			s2cp.Optional = false;
			foreach (XmlNode subnode in dep) 
			{
				switch (subnode.LocalName) 
				{
					case "Name": 
					{
						s2cp.Name = subnode.InnerText;
						break;
					}
					case "ObjectVersion": 
					{
						s2cp.ObjectVersion = subnode.InnerText;
						break;
					}
					case "GlobalGUID": 
					{
						s2cp.Guid = subnode.InnerText;
						break;
					}
					case "Optional":
					{
						s2cp.Optional = true;
						break;
					}
				} //switch
			} //foreach

			return s2cp;
		}

		/// <summary>
		/// Reads a package from the Stream
		/// </summary>
		/// <param name="reader">The S2CP Stream</param>
		/// <param name="offset">The starting offset</param>
		/// <param name="length">The Length of the Package</param>
		/// <param name="desc">Package Description</param>
		/// <returns>The Package</returns>
		protected static SimPe.Packages.GeneratableFile LoadPackage(BinaryReader reader, int offset, int length, SimPe.Packages.S2CPDescriptor desc)
		{
			reader.BaseStream.Seek(offset, System.IO.SeekOrigin.Begin);
			MemoryStream ms = new MemoryStream(reader.ReadBytes(length));

			if (desc.Compressed == CompressionStrength.None) 
			{
				SimPe.Packages.GeneratableFile pkg = GeneratableFile.LoadFromStream(new BinaryReader(ms));
				return pkg;
			} 
			else 
			{
				MemoryStream unc = new MemoryStream();
				Decompress(ms, unc);
				SimPe.Packages.GeneratableFile pkg = GeneratableFile.LoadFromStream(new BinaryReader(unc));
				pkg.FileName = desc.Name;
				return pkg;
			}
		}

		/// <summary>
		/// Parse the packedFile Node in an XML
		/// </summary>
		/// <param name="reader">The source Stream of the S2CP File</param>
		/// <param name="pfile">The PackedFile Node</param>
		/// <param name="offset">The Ofset for the package Data</param>
		/// <returns>The Descriptor of the PackedFile</returns>
		/// <remarks>The GUIDs and the Names of the Descriptors are the ones stored in the
		/// XML Data not the ones from the Package. So you have to <seealso cref="SimPe.Packages.S2CPDescriptorBase.Valid"/><see cref="SimPe.Packages.S2CPDescriptorBase.Valid"/> the Content with the Package.</remarks>
		protected static S2CPDescriptor ParesPackedFile(BinaryReader reader, XmlNode pfile, int offset)
		{
			S2CPDescriptor s2cp = new S2CPDescriptor(null, "", "", "", "", Sims2CommunityPack.CompressionStrength.None, null, true);
			int pkglen = 0;
			int pkgoffset = 0;
			foreach (XmlNode mainnode in pfile) 
			{
				switch (mainnode.LocalName) 
				{
					case "Name": 
					{
						s2cp.Name = mainnode.InnerText;
						break;
					}
					case "Description": 
					{
						s2cp.Description = mainnode.InnerText;
						break;
					}
					case "Crc": 
					{
						s2cp.Crc = mainnode.InnerText;
						break;
					}
					case "Length": 
					{
						pkglen = Convert.ToInt32(mainnode.InnerText);
						break;
					}
					case "Offset": 
					{
						pkgoffset = Convert.ToInt32(mainnode.InnerText);
						break;
					}
					case "Sims2CommuniytExt": 
					{
						foreach (XmlNode subnode in mainnode) 
						{
							switch (subnode.LocalName) 
							{
								case "Author": 
								{
									foreach (XmlNode authnode in subnode) 
									{
										switch (authnode.LocalName) 
										{
											case "PersonalName": 
											{
												s2cp.Author = authnode.InnerText;
												break;
											}
											case "Contact": 
											{
												s2cp.Contact = authnode.InnerText;
												break;
											}
										}//switch
									}
									break;
								}
								case "Title": 
								{
									s2cp.Title = subnode.InnerText;
									break;
								}
								case "ObjectVersion": 
								{
									s2cp.ObjectVersion = subnode.InnerText;
									break;
								}
								case "GlobalGUID": 
								{
									s2cp.Guid = subnode.InnerText;
									break;
								}
								case "Compressed": 
								{
									s2cp.Compressed = (CompressionStrength)Convert.ToInt32(subnode.InnerText);
									break;
								}
					
								case "Dependency": 
								{
									ArrayList al = new ArrayList();
									foreach (XmlNode dep in subnode) 
									{
										if (dep.LocalName=="PackagedFile") 
										{
											al.Add(ParesDependingPackedFile(dep));
										}
									}
									S2CPDescriptorBase[] deps = new S2CPDescriptorBase[al.Count];
									al.CopyTo(deps);
									s2cp.Dependency = deps;
									break;
								}
							}
						}
						break;
					}					
				} //switch
			} //foreach

			s2cp.Package = LoadPackage(reader, offset+pkgoffset, pkglen, s2cp);
			return s2cp;
		}

		/// <summary>
		/// Opens a Sim2Pack File
		/// </summary>
		/// <param name="filename">Filename of the S2CP File</param>
		/// <returns>List of all Package descriptors</returns>
		/// <remarks>The GUIDs/Names included in the S2CPDescriptor are the ones found in the Xml Description, 
		/// you need to check them with the GUIDs stored in the packges itself to 
		/// <see cref="SimPe.Packages.S2CPDescriptorBase.Valid"/>
		/// <seealso cref="SimPe.Packages.S2CPDescriptorBase.Valid"/> the Content</remarks>
		public static S2CPDescriptor[] Open(string filename) 
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.OpenRead(filename));
			return Open(br);
		}

		/// <summary>
		/// Opens a Sim2Pack File
		/// </summary>
		/// <param name="reader">The Stream containing the File</param>
		/// <returns>List of all Package descriptors</returns>
		/// <remarks>The GUIDs/Names included in the S2CPDescriptor are the ones found in the Xml Description, 
		/// you need to check them with the GUIDs stored in the packges itself to 
		/// <see cref="SimPe.Packages.S2CPDescriptorBase.Valid"/>
		/// <seealso cref="SimPe.Packages.S2CPDescriptorBase.Valid"/> the Content</remarks>
		public static S2CPDescriptor[] Open(BinaryReader reader)
		{
			
			//BinaryReader reader = new BinaryReader(s2cp);
			byte[] header = reader.ReadBytes(18);
			int offset = reader.ReadInt32();
			string xml = Helper.ToString(reader.ReadBytes((int)(offset - reader.BaseStream.Position)));

			System.Xml.XmlDocument xmlfile = new XmlDocument();
			xmlfile.LoadXml(xml);

			//Root Node suchen
			XmlNodeList XMLData = xmlfile.GetElementsByTagName("Sims2Package");

			ArrayList list = new ArrayList();
			//Alle Eintr&auml;ge im Root Node verarbeiten
			//Data.MetaData.IndexTypes type = Data.MetaData.IndexTypes.ptShortFileIndex;
			for (int i=0; i<XMLData.Count; i++)
			{
				XmlNode node = XMLData.Item(i);
				foreach (XmlNode pfile in node) 
				{
					//a New FileItem
					if (pfile.LocalName == "PackagedFile") 
					{
						list.Add(ParesPackedFile(reader, pfile, offset));
					}
				} //foreach pfile
			} // for i

			S2CPDescriptor[] res = new S2CPDescriptor[list.Count];
			list.CopyTo(res);
			return res;
		}

		/// <summary>
		/// Displays a Save Dialog for the S2CP Files
		/// </summary>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		public static bool ShowSaveDialog(bool extension) 
		{
			return ShowSaveDialog((SimPe.Packages.GeneratableFile)null, extension);
		}

		/// <summary>
		/// Displays a Save Dialog for the S2CP Files
		/// </summary>
		/// <param name="package">The package that should be added to the S2CP Files (the user can add more!)</param>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		public static bool ShowSaveDialog(SimPe.Packages.GeneratableFile package, bool extension) 
		{

			SimPe.Packages.GeneratableFile[] fls = null;

			if (package!=null) 
			{
				fls = new SimPe.Packages.GeneratableFile[1];
				fls[0] = package;
			} 
			else 
			{
				fls = new SimPe.Packages.GeneratableFile[0];
			}

			return ShowSaveDialog(fls, extension);
		}

		/// <summary>
		/// Displays a Save Dialog for the Sims2Pack Files
		/// </summary>
		/// <param name="packages">The packages that should be added to the Sims2Pack Files (the user can add more!)</param>
		/// a normal Sims2Pack File will be generated</param>
		/// <returns>true if the File was saved</returns>
		public static bool ShowSimpleSaveDialog(SimPe.Packages.GeneratableFile[] packages) 
		{
			SaveSims2Pack form = new SaveSims2Pack();
			bool extension = false;
			S2CPDescriptor[] desc = form.Execute(packages, ref extension);

			if (desc!=null) 
			{
				MemoryStream ms = Create(desc, extension);

				System.IO.FileStream fs = new FileStream(form.tbflname.Text, FileMode.Create);
				try 
				{
					fs.Write(ms.ToArray(), 0, (int)ms.Length);
				} 
				finally 
				{
					fs.Close();
					fs.Dispose();
					fs = null;
				}
				return true;
			}

			return false;
		}

		/// <summary>
		/// Displays a Save Dialog for the S2CP Files
		/// </summary>
		/// <param name="packages">The packages that should be added to the S2CP Files (the user can add more!)</param>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		/// <returns>true if the File was saved</returns>
		public static bool ShowSaveDialog(SimPe.Packages.GeneratableFile[] packages, bool extension) 
		{
			SaveSims2CommunityPack form = new SaveSims2CommunityPack();
			S2CPDescriptor[] desc = form.Execute(packages, ref extension);

			if (desc!=null) 
			{
				MemoryStream ms = Create(desc, extension);

				System.IO.FileStream fs = new FileStream(form.tbflname.Text, FileMode.Create);
				try 
				{
					fs.Write(ms.ToArray(), 0, (int)ms.Length);
				} 
				finally 
				{
					fs.Close();
					fs.Dispose();
					fs = null;
				}
				return true;
			}

			return false;
		}

		/// <summary>
		/// Show the Package Selector Dialog for a Sims2Pack File
		/// </summary>
		/// <param name="filename">The Filename of the Sims2Pack File</param>
		/// <param name="selmode">Selection Mode for the Listview</param>
		/// <returns>All Packages that were selected in the Dialog by the User or null 
		/// if the User Cancled the Dialog</returns>
		public static S2CPDescriptor[] ShowSimpleOpenDialog(string filename, System.Windows.Forms.SelectionMode selmode) 
		{
			SaveSims2Pack form = new SaveSims2Pack();
			return form.Execute(Open(filename), selmode);
		}

		/// <summary>
		/// Show the Package Selector Dialog for a S2CP File
		/// </summary>
		/// <param name="filename">The Filename of the S2CP File</param>
		/// <param name="selmode">Selection Mode for the Listview</param>
		/// <returns>All Packages that were selected in the Dialog by the User or null 
		/// if the User Cancled the Dialog</returns>
		public static S2CPDescriptor[] ShowOpenDialog(string filename, System.Windows.Forms.SelectionMode selmode) 
		{
			SaveSims2CommunityPack form = new SaveSims2CommunityPack();
			return form.Execute(Open(filename), selmode);
		}
	}
}
