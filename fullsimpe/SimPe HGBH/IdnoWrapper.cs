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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Available Neighborhood Types
	/// </summary>
	public enum NeighborhoodType:uint 
	{
		Unknown = 0x00,
		Normal = 0x01,
		University = 0x02,
		Downtown = 0x03,
		Suburb = 0x04
	}

	/// <summary>
	/// Known Neighborhhod Versions
	/// </summary>
	public enum NeighborhoodVersion:uint
	{
		Unknown = 0x00,
		Sims2 = 0x03,
		Sims2_University = 0x05,
		Sims2_Nightlife = 0x07,
		Sims2_Business = 0x08
	}

	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Idno
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{		

		#region Attributes
		uint version;
		/// <summary>
		/// Returns the Version of this File
		/// </summary>
		public NeighborhoodVersion Version 
		{
			get { return (NeighborhoodVersion)version; }
		}

		NeighborhoodType type;
		/// <summary>
		/// Returns the Type of this Neighborhood
		/// </summary>
		public NeighborhoodType Type 
		{
			get { return type; }
			set { type = value; }
		}

		string name;
		/// <summary>
		/// Returns the nametag of this Neighborhood
		/// </summary>
		public string OwnerName
		{
			get { return name; }
			set { name = value; }
		}

		uint uid;
		/// <summary>
		/// Returns the nametag of this owning Neighborhood
		/// </summary>
		public uint Uid
		{
			get { return uid; }
			set { uid = value; }
		}

		string subname;
		/// <summary>
		/// Returns the nametag of this Neighborhood
		/// </summary>
		public string SubName
		{
			get { return subname; }
			set { subname = value; }
		}

		byte[] over;
		#endregion

		#region static Methods
		/// <summary>
		/// Load the IdNo stored in the passed package
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns></returns>
		public static Idno FromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg==null) return null;
			Interfaces.Files.IPackedFileDescriptor idno = pkg.FindFile(Data.MetaData.IDNO, 0, Data.MetaData.LOCAL_GROUP, 1);
			if (idno!=null) 
			{
				SimPe.Plugin.Idno wrp = new Idno();
				wrp.ProcessData(idno, pkg);

				return wrp;
			}

			return null;
		}

		/// <summary>
		/// Assigns a unique uid to the idno
		/// </summary>
		/// <param name="idno">the idno object</param>
		/// <param name="filename">the Filename</param>
		/// <param name="scanall">
		///   true, if you want to scan all package Files in the Folder 
		///   (otherwise only Neighborhood Files are scanned!)
		///  </param>
		/// <remarks>
		/// </remarks>
		public static void MakeUnique(Idno idno, string filename, bool scanall) 
		{
			MakeUnique(idno, filename, Helper.WindowsRegistry.SimSavegameFolder, scanall);
		}

		/// <summary>
		/// Assigns a unique uid to the idno
		/// </summary>
		/// <param name="idno">the idno object</param>
		/// <param name="filename">the Filename</param>
		/// <param name="folder">The folder you want to scan (recursive)</param>
		/// <param name="scanall">
		///   true, if you want to scan all package Files in the Folder 
		///   (otherwise only Neighborhood Files are scanned!)
		///  </param>
		/// <remarks>
		/// </remarks>
		public static void MakeUnique(Idno idno, string filename, string folder, bool scanall) 
		{
			Hashtable ids = FindUids(Helper.WindowsRegistry.SimSavegameFolder, scanall);
			MakeUnique(idno, filename, ids);
		}

		/// <summary>
		/// Assigns a unique uid to the idno
		/// </summary>
		/// <param name="idno">the idno object</param>
		/// <param name="filename">the Filename</param>
		/// <param name="ids">a Map of all available Group Ids (can be obtained by calling Idno::FindUids())</param>		
		/// <remarks>
		/// </remarks>
		public static void MakeUnique(Idno idno, string filename, Hashtable ids) 
		{
			if (idno==null) return;
			if (filename==null) return;

			filename = filename.Trim().ToLower();			


			if (ids.ContainsKey(filename)) idno.Uid = (uint)ids[filename];
			else idno.Uid = 1;
			
			uint max = 0;
			foreach (string flname in ids.Keys) 
			{
				uint id = (uint)ids[flname];
				if (id>max)	max=id;

				if (flname==filename) continue;				
				if (idno.Uid==id) idno.Uid = max+1;
			}			
		}


		/// <summary>
		/// Returns a Idno Object based on the Informations gathered from a FileName
		/// </summary>
		/// <param name="filename">The name of the Neighborhood File</param>
		/// <returns>
		/// null if the filename was not a valid Neighborhood name or an instance of the Idno Class
		/// </returns>
		/// <remarks>
		/// This Method will not assign a uid to the Idno. You can assign a unique uid 
		/// by calling Idno::MakeUnique
		/// </remarks>
		public static Idno FromName(string filename)
		{
			Idno idno = new Idno();

			filename = System.IO.Path.GetFileNameWithoutExtension(filename.Trim());
			string[] parts = filename.Split("_".ToCharArray(), 2);

			if (parts.Length!=2) return null;
			if (!parts[0].StartsWith("N")) return null;

			idno.OwnerName = parts[0];

			parts[1] = parts[1].ToLower();
			if (parts[1].StartsWith("university")) 
			{
				idno.Type = NeighborhoodType.University;
				parts[1] = "U"+parts[1].Replace("university", "");
				idno.SubName = parts[1];
			}			
			return idno;
		}

		/// <summary>
		/// Scan the passed Folder for Neighborhood Files and collect the assigned IDs
		/// </summary>
		/// <param name="folder">The Folder to scan (recursive)</param>
		/// <param name="scanall">
		///   true, if you want to scan all package Files in the Folder 
		///   (otherwise only Neighborhood Files are scanned!)
		///  </param>
		/// <returns>A Map for ids (key=filename, value=id)</returns>	
		public static Hashtable FindUids(string folder, bool scanall)
		{
			Hashtable ids = new Hashtable();
			FindUids(folder, ids, scanall);
			return ids;
		}		

		/// <summary>
		/// Scan the passed Folder for Neighborhood Files and collect the assigned IDs
		/// </summary>
		/// <param name="folder">The Folder to scan (recursive)</param>
		/// <param name="ids">A Map for ids (key=filename, value=id)</param>
		/// <param name="scanall">
		///   true, if you want to scan all package Files in the Folder 
		///   (otherwise only Neighborhood Files are scanned!)
		///  </param>
		static void FindUids(string folder, Hashtable ids, bool scanall)
		{
			WaitingScreen.UpdateMessage(folder);

			ArrayList names = new ArrayList();
			if (!scanall) 
			{
				string[] a = System.IO.Directory.GetFiles(folder, "N???_Neighborhood.package");			
				foreach (string s in a) names.Add(s);

				a = System.IO.Directory.GetFiles(folder, "N???_University???.package");
				foreach (string s in a) names.Add(s);
			} 
			else 
			{
				string[] a = System.IO.Directory.GetFiles(folder, "*.package");			
				foreach (string s in a) names.Add(s);
			}

			foreach (string name in names) 
			{
				SimPe.Packages.File fl = SimPe.Packages.File.LoadFromFile(name);
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = fl.FindFiles(Data.MetaData.IDNO);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					Idno idno = new Idno();
					idno.ProcessData(pfd, fl);

					ids[name.Trim().ToLower()] = idno.Uid;
				}
			}

			string[] d = System.IO.Directory.GetDirectories(folder, "*");
			foreach (string dir in d) FindUids(dir, ids, scanall);
		}
		#endregion		

		/// <summary>
		/// Make sure this contains a Unique ID!
		/// </summary>
		public void MakeUnique() 
		{
			bool wr = WaitingScreen.Running;
			if (!wr) WaitingScreen.Wait();
			Idno.MakeUnique(this, this.Package.FileName, true);
			if (!wr) WaitingScreen.Stop();
		}

		/// <summary>
		/// Make sure this contains a Unique ID!
		/// </summary>
		/// <param name="ids">a Map of all available Group Ids (can be obtained by calling Idno::FindUids())</param>
		public void MakeUnique(Hashtable ids) 
		{
			bool wr = WaitingScreen.Running;
			if (!wr) WaitingScreen.Wait();
			Idno.MakeUnique(this, this.Package.FileName, ids);
			if (!wr) WaitingScreen.Stop();
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		public Idno() : base()
		{
			if (Helper.WindowsRegistry.EPInstalled>=1) this.version = (uint)NeighborhoodVersion.Sims2_University;
			else this.version = (uint)NeighborhoodVersion.Sims2;

			this.type = NeighborhoodType.Normal;
			over = new byte[0];

			uid = 0;
			name = "Nxxx";
			subname = "";
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			return true;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new IdnoUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Neighborhood ID Wrapper",
				"Quaxi",
				"Contains the ID for this Neighborhood. The Neighborhood ID must be Unique for all packages the Game is loading.",
				3,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.idno.png"))
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			int ct = reader.ReadInt32();
			name = Helper.ToString(reader.ReadBytes(ct));
			uid = reader.ReadUInt32();

			if (version>=(int)NeighborhoodVersion.Sims2_University) 
			{
				type = (NeighborhoodType)reader.ReadUInt32();
				if ((int)type>=(int)NeighborhoodType.University) 
				{
					ct = reader.ReadInt32();
					subname = Helper.ToString(reader.ReadBytes(ct));				
				}
			} 
			else 
			{
				type = NeighborhoodType.Normal;
			}
			over = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		protected override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);

			byte[] b = Helper.ToBytes(name, 0);
			writer.Write((int)b.Length);
			writer.Write(b);
			writer.Write(uid);

			if (version>=(int)NeighborhoodVersion.Sims2_University) 
			{
				writer.Write((uint)type);
				if ((int)type>=(int)NeighborhoodType.University) 
				{
					b = Helper.ToBytes(subname, 0);
					writer.Write((int)b.Length);
					writer.Write(b);
				}
			}
			writer.Write(over);
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public byte[] FileSignature
		{
			get
			{
				return new byte[0];
			}
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								  Data.MetaData.IDNO
							   };
				return types;
			}
		}

		#endregion		
	}
}
