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

namespace SimPe.Packages
{
	/// <summary>
	/// Basic Descriptor used for Dependency Files
	/// </summary>
	public class S2CPDescriptorBase
	{
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="p">The Package this Object describes</param>
		public S2CPDescriptorBase(GeneratableFile p)
		{
			package = p;
			objectversion = "0";

			if (p!=null) 
			{
				name = System.IO.Path.GetFileName(p.FileName);
				if (name=="") name = Localization.Manager.GetString("Unknown")+".package";

				string author = "";
				string title = "";
				string description = "";
				string contact = "";
				string gameguid = "";
				guid = GetGlobalGuid(p, ref name, ref title, ref author, ref contact, ref description, ref gameguid);
			}
		}

		/// <summary>
		/// Reads the Guid from the Package
		/// </summary>
		/// <param name="p">The Package to load the Guid From</param>
		/// <param name="name">Returns the name stored in te package</param>
		/// <param name="title">The Title of this package</param>
		/// <param name="author">Author of this package</param>
		/// <param name="contact">How to contact the Author</param>
		/// <param name="description">Description of this Package</param>
		/// <param name="gameguid">The List of original Game Guids</param>
		/// <returns>null if no GUID Data was found, otherwise null</returns>
		public static string GetGlobalGuid(File p, ref string name, ref string title, ref string author, ref string contact, ref string description, ref string gameguid) 
		{
			string guid = null;

			Interfaces.Files.IPackedFileDescriptor pfd = p.FindFile(Data.MetaData.STRING_FILE, 0xffffffff, 0x00000000, 0xffffffff);
			if (pfd!=null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, p);
				SimPe.PackedFiles.Wrapper.StrItemList sitems = str.LanguageItems(1);

				if (sitems.Length>0) 
				{
					guid = sitems[0].Title;
					gameguid = sitems[0].Description;
				}
				else guid = System.Guid.NewGuid().ToString();

				if (sitems.Length>1) 
				{
					author = sitems[1].Title;
					contact = sitems[1].Description;
				}

				if (sitems.Length>2) 
				{
					name = sitems[1].Title;
				}				
			} 
			


			//Title and Description is stored in the CatalogString
			Interfaces.Files.IPackedFileDescriptor[] pfds = p.FindFiles(Data.MetaData.OBJD_FILE);
			
			uint ctssid = 1;
			uint group = 0xffffffff;
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfds[0], p);
				ctssid = objd.CTSSId;
				group = objd.FileDescriptor.Group;
			}
			

			pfd = p.FindFile(Data.MetaData.CTSS_FILE, 0, group, ctssid);
			if (pfd!=null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, p);
				SimPe.PackedFiles.Wrapper.StrItemList sitems = str.LanguageItems(1);

				if (sitems.Length>0) 
				{
					title = sitems[0].Title;
				}

				if (sitems.Length>1) 
				{
					description = sitems[1].Title;
				}
			}
			return guid;
		}

		/// <summary>
		/// Possible results of a Validation
		/// </summary>
		/// <remarks>CRCMismath is not used yet</remarks>
		public enum ValidationState 
		{
			/// <summary>
			/// The Data is consistent
			/// </summary>
			OK = 0x00,
			/// <summary>
			/// The CRC from the XMl and the actual CRC do not match
			/// </summary>
			CRCMismatch = 0x01,
			/// <summary>
			/// The GlobalGUID from the Xml and the GlobalGUID stored in the package do not match
			/// </summary>
			GlobalGUIDMismatch = 0x02,
			/// <summary>
			/// The Name from the Xml and the one stored in the package do not match
			/// </summary>
			NameMismatch = 0x03,
			/// <summary>
			/// The Name of teh Author does not match
			/// </summary>
			AuthorMismatch = 0x04,
			/// <summary>
			/// The original Guids have changed
			/// </summary>
			GameGuidMismatch = 0x05,
			/// <summary>
			/// The Data could not be validated
			/// </summary>
			UnableToValidate = 0xff
		};

		/// <summary>
		/// validates the package aginst the stored GUID/Name
		/// </summary>
		/// <remarks>If you have loaded a Package from a S2CP File, the GUID and Name Attributes of this Object
		/// will contain the values stored in the Describing XML. You can validate those Values against the Data 
		/// stored in the Package itself with this Method.</remarks>
		public virtual ValidationState Valid
		{
			get 
			{
				if (package==null) return ValidationState.UnableToValidate;

				string n = "-";
				string t = "-";
				string a = "-";
				string c = "-";
				string d = "-";
				string gg = "-";
				string g = GetGlobalGuid(this.package, ref n,ref t, ref a, ref c, ref d, ref gg);

				if (g!=guid) return ValidationState.GlobalGUIDMismatch;
				if (n!=name) return ValidationState.NameMismatch;

				return ValidationState.OK;
			}
		}

		/// <summary>
		/// If this Dependency Optional
		/// </summary>
		protected bool optional;
		/// <summary>
		/// If this Dependency Optional
		/// </summary>
		public bool Optional
		{
			get { return optional; }
			set { optional = value; }
		}

		/// <summary>
		/// Filename of the container Package (can return null)
		/// </summary>
		protected string name;
		/// <summary>
		/// Returns/Sets the Filename of the container Package (can return null)
		/// </summary>
		public string Name
		{
			get 
			{ 
				return name; 
			}
			set { name = value; }
		}

		/// <summary>
		/// Description for the File
		/// </summary>
		protected string objectversion;
		/// <summary>
		/// Returns/Sets the Description for the File
		/// </summary>
		public string ObjectVersion
		{
			get { return objectversion; }
			set { objectversion = value; }
		}

		/// <summary>
		/// The guid for the File or (can return null)
		/// </summary>
		protected string guid;
		/// <summary>
		/// Returns/Sets the The guid for the File or (can return null)
		/// </summary>
		public string Guid
		{
			get 
			{ 
				return guid; 
			}
			set { guid = value; }
		}

		/// <summary>
		/// The associated Package
		/// </summary>
		protected GeneratableFile package;
		/// <summary>
		/// Returns/Sets the The associated Package
		/// </summary>
		public GeneratableFile Package
		{
			get { return package; }
			set { package = value; }
		}

		/// <summary>
		/// Retursn a descriptive String for the Object
		/// </summary>
		/// <returns>The Description of this Object</returns>
		public override string ToString()
		{
			if (Guid!=null) 
			{
				return Name + " (" + Guid + ")";
			} 
			else 
			{
				return Name + " (No GUID assigned yet!)";
			}
		}

	}
	/// <summary>
	/// Descriptor for a Packed file in the the S2CP
	/// </summary>
	public class S2CPDescriptor : S2CPDescriptorBase
	{
		/// <summary>
		/// Creates a new Insttance
		/// </summary>
		/// <param name="p">The Package this Object describes</param>
		/// <param name="author">Author of this Package</param>
		/// <param name="contact">How to contact the Autor</param>
		/// <param name="title">Title of this Package</param>
		/// <param name="description">Description for the Package</param>
		/// <param name="compressed">true if this Package should be stored compressed</param>
		/// <param name="extension">true, if you wnt to use the Community Extionsins (Will create a textFile in the Package if needed)</param>
		/// <param name="dependency">Objects this one depends on</param>
		public S2CPDescriptor(GeneratableFile p, string author, string contact, string title, string description, Sims2CommunityPack.CompressionStrength compressed, S2CPDescriptorBase[] dependency, bool extension)
			: base (p)
		{
			type = "Object";
			gameversion = "2141707388.153.1";
			this.description = description;
			this.compressed = compressed;
			objectversion = "1.0";
			crc = "0";
			this.author = author;
			this.contact = contact;
			this.title = title;
			gameguid = this.GameGuid;
			
			if (dependency==null) dep = new S2CPDescriptorBase[0];
			else dep = dependency;
			
			if (extension) 
			{
				if (p!=null) guid = GetSetGlobalGuid(p, ref name, ref this.title, ref this.author, ref this.contact, ref this.description, ref gameguid);
			} 
		}

		/// <summary>
		/// Updates the S2CP ID File with the cuurrent settings
		/// </summary>
		/// <param name="p">The Package to change/read from</param>
		/// <param name="guid">The packages GUID</param>
		/// <param name="name">The Name for the Package (used if the File is created)</param>
		/// <param name="author">Author of this package</param>
		/// <param name="contact">How to contact the Author</param>
		/// <param name="gameguid">The List of original Game Guids</param>
		/// <returns>the stored or the new GlobalGUID</returns>
		public static void UpdateGlobalGuid(File p, string guid, string name, string author, string contact, string gameguid) 
		{	
			Interfaces.Files.IPackedFileDescriptor pfd = p.FindFile(Data.MetaData.STRING_FILE, 0xffffffff, 0x00000000, 0xffffffff);
			SimPe.PackedFiles.Wrapper.Str str = null;
			if (pfd==null) 
			{
				str = new SimPe.PackedFiles.Wrapper.Str();

				str.FileDescriptor = new SimPe.Packages.PackedFileDescriptor();
				str.FileDescriptor.Type = Data.MetaData.STRING_FILE;
				str.FileDescriptor.Group = 0;
				str.FileDescriptor.SubType = 0xffffffff;
				str.FileDescriptor.Instance = 0xffffffff;
				str.SynchronizeUserData();
				str.Package = p;

				p.Add(str.FileDescriptor);
			} 
			else 
			{
				str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, p);
			}

			SimPe.PackedFiles.Wrapper.StrLanguageList lng = new SimPe.PackedFiles.Wrapper.StrLanguageList();
			lng.Add(new SimPe.PackedFiles.Wrapper.StrLanguage(1));
			str.Languages = lng;

			if (guid==null) guid = System.Guid.NewGuid().ToString();
			str.Items = new SimPe.PackedFiles.Wrapper.StrItemList();
			str.Items.Add(new SimPe.PackedFiles.Wrapper.StrItem(lng[0], guid, gameguid));
			str.Items.Add(new SimPe.PackedFiles.Wrapper.StrItem(lng[0], author, contact));
			str.Items.Add(new SimPe.PackedFiles.Wrapper.StrItem(lng[0], name, ""));
			
			str.SynchronizeUserData();
		}

		/// <summary>
		/// Updates the S2CP ID File with the cuurrent settings
		/// </summary>
		/// <param name="p">The Package to change/read from</param>
		/// <param name="title">Title of this Object</param>
		/// <param name="description">Description of this Package</param>
		/// <returns>the stored or the new GlobalGUID</returns>
		public static void UpdateGlobalGuid(File p, string title, string description) 
		{	
			Interfaces.Files.IPackedFileDescriptor pfd = null;
			SimPe.PackedFiles.Wrapper.Str str = null;

			SimPe.PackedFiles.Wrapper.StrLanguage[] lng = new SimPe.PackedFiles.Wrapper.StrLanguage[1];
			lng[0] = new SimPe.PackedFiles.Wrapper.StrLanguage(1);

			//Title and Description is stored in the CatalogString
			Interfaces.Files.IPackedFileDescriptor[] pfds = p.FindFiles(Data.MetaData.OBJD_FILE);
			uint ctssid = 1;
			uint group = 0xffffffff;
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfds[0], p);
				ctssid = objd.CTSSId;
				group = objd.FileDescriptor.Group;
			}

			pfd = p.FindFile(Data.MetaData.CTSS_FILE, 0, group, ctssid);
			if (pfd==null) 
			{
				str = new SimPe.PackedFiles.Wrapper.Str();

				str.FileDescriptor = new SimPe.Packages.PackedFileDescriptor();
				str.FileDescriptor.Type = Data.MetaData.CTSS_FILE;
				str.FileDescriptor.Group = 0xffffffff;
				str.FileDescriptor.SubType = 0x00000000;
				str.FileDescriptor.Instance = 0x1;

				str.Languages.Add(lng[0]);

				p.Add(str.FileDescriptor);
			} 
			else 
			{
				str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, p);
			}

			SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
			if (str.Items.Length>0)	str.Items[0].Title = title;
			else					str.Add(new SimPe.PackedFiles.Wrapper.StrItem(lng[0], title, ""));

			if (str.Items.Length>1) str.Items[1].Title = description;
			else					str.Add(new SimPe.PackedFiles.Wrapper.StrItem(lng[0], description, ""));

			str.SynchronizeUserData();
		}

		/// <summary>
		/// Synchronizes the S2CP ID File with the current Settings
		/// </summary>
		public void Update() 
		{
			UpdateGlobalGuid(this.Package, this.guid, this.name, this.author, this.contact, this.gameguid);
			UpdateGlobalGuid(this.Package, this.title, this.description);
		}

		/// <summary>
		/// Adds theGlobalGUID Data to the package if it is missing and generates a new GUID for it.
		/// </summary>
		/// <param name="p">The Package to change/read from</param>
		/// <param name="name">The Name for the Package (used if the File is created)</param>
		/// <param name="title">Title of this Object</param>
		/// <param name="author">Author of this package</param>
		/// <param name="contact">How to contact the Author</param>
		/// <param name="description">Description of this Package</param>
		/// <param name="gameguid">The List of original Game Guids</param>
		/// <returns>the stored or the new GlobalGUID</returns>
		/// <remarks>If the GlobalGUID File does exist, the Data from this File will be returned and no new
		/// GlobalGUID will be returned</remarks>
		public static string GetSetGlobalGuid(File p, ref string name, ref string title, ref string author, ref string contact, ref string description, ref string gameguid) 
		{
			string guid = null;

			Interfaces.Files.IPackedFileDescriptor pfd = p.FindFile(Data.MetaData.STRING_FILE, 0xffffffff, 0x00000000, 0xffffffff);
			if (pfd==null) 
			{
				guid = System.Guid.NewGuid().ToString();
				UpdateGlobalGuid(p, guid, name, author, contact, gameguid);
			} 
			else 
			{
				guid = GetGlobalGuid(p, ref name, ref title, ref author, ref contact, ref description, ref gameguid);
			}

			Interfaces.Files.IPackedFileDescriptor[] pfds = p.FindFiles(Data.MetaData.OBJD_FILE);
			uint ctssid = 1;
			uint group = 0xffffffff;
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfds[0], p);
				ctssid = objd.CTSSId;
				group = objd.FileDescriptor.Group;
			}

			pfd = p.FindFile(Data.MetaData.CTSS_FILE, 0, group, ctssid);
			if (pfd==null) 
			{
				UpdateGlobalGuid(p, title, description);
			} 
			else 
			{
				guid = GetGlobalGuid(p, ref name, ref title, ref author, ref contact, ref description, ref gameguid);
			}


			return guid;
		}

		/// <summary>
		/// validates the package aginst the stored GUID/Name
		/// </summary>
		/// <remarks>If you have loaded a Package from a S2CP File, the GUID and Name Attributes of this Object
		/// will contain the values stored in the Describing XML. You can validate those Values against the Data 
		/// stored in the Package itself with this Method.</remarks>
		public override ValidationState Valid
		{
			get 
			{
				if (package==null) return ValidationState.UnableToValidate;

				string n = "-";
				string t = "-";
				string a = "-";
				string c = "-";
				string d = "-";
				string gg = "-";
				string g = GetGlobalGuid(this.package, ref n, ref t, ref a, ref c, ref d, ref gg);

				if (g!=guid) return ValidationState.GlobalGUIDMismatch;
				if (n!=name) return ValidationState.NameMismatch;
				if (a!=author) return ValidationState.AuthorMismatch;
				if (gg!=GameGuid) return ValidationState.GameGuidMismatch;

				return ValidationState.OK;
			}
		}

		/// <summary>
		/// Returns a list of objects this one depends on
		/// </summary>
		S2CPDescriptorBase[] dep;
		/// <summary>
		/// Returns/Sets the  list of objects this one depends on
		/// </summary>
		public S2CPDescriptorBase[] Dependency 
		{
			get { return dep; }
			set { dep = value; }
		}

		/// <summary>
		/// Title of the Package
		/// </summary>
		string title;
		/// <summary>
		/// Returns/Sets the Title of the Package
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Type of the Package
		/// </summary>
		string type;
		/// <summary>
		/// Returns/Sets the Type of the Package
		/// </summary>
		public string Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Versionnumber of the Game
		/// </summary>
		string gameversion;
		/// <summary>
		/// Returns/Sets the Versionnumber of the Game
		/// </summary>
		public string GameVersion
		{
			get { return gameversion; }
			set { gameversion = value; }
		}

		/// <summary>
		/// Description for the File
		/// </summary>
		string crc;
		/// <summary>
		/// Returns/Sets the Description for the File
		/// </summary>
		public string Crc
		{
			get { return crc; }
			set { crc = value; }
		}

		/// <summary>
		/// Description for the File
		/// </summary>
		string description;
		/// <summary>
		/// Returns/Sets the Description for the File
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Author of the File
		/// </summary>
		string author;
		/// <summary>
		/// Returns/Sets the Author of the File
		/// </summary>
		public string Author
		{
			get { return author; }
			set { author = value; }
		}

		/// <summary>
		/// Author of the File
		/// </summary>
		string contact;
		/// <summary>
		/// Returns/Sets the Contact Person of the File
		/// </summary>
		public string Contact
		{
			get { return contact; }
			set { contact = value; }
		}

		string gameguid;
		/// <summary>
		/// Returns a Space seperated List of all Guids stored in the Package
		/// </summary>
		public string GameGuid
		{
			get 
			{
				if (gameguid!=null) return gameguid;
				if (package==null) return "";

				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
				gameguid = "";
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
					objd.ProcessData(pfd, package);
					gameguid += " "+objd.Guid.ToString();
				}

				return gameguid.Trim();
			}
			set { gameguid = value; }
		}

		/// <summary>
		/// File is compressed
		/// </summary>
		Sims2CommunityPack.CompressionStrength compressed;
		/// <summary>
		/// Returns /Sets wether the File sould be Compressed or Not
		/// </summary>
		/// <remarks>After the Description is loaded form a s2cp File, this Property 
		/// Indicates if the Package was compressed or not</remarks>
		public Sims2CommunityPack.CompressionStrength Compressed 
		{
			get { return compressed; }
			set { compressed = value; }
		}

		/// <summary>
		/// Retursn a descriptive String for the Object
		/// </summary>
		/// <returns>The Description of this Object</returns>
		public override string ToString()
		{
			if (Guid!=null) 
			{
				return Name + " (" + Guid + ", Compression="+Compressed.ToString()+", State="+Valid.ToString()+")";
			} 
			else 
			{
				return Name + " (No GUID assigned yet, Compression="+Compressed.ToString()+")";
			}
		}

	}
}
