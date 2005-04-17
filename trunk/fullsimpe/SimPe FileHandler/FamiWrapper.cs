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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// The Type of this Memory
	/// </summary>
	enum MemoryType : ushort 
	{
		GoodMemory = 0x0000,
		BadMemory = 0xfff8
	}

	public class FamiFlags : FlagBase 
	{
		public FamiFlags(ushort flags) : base(flags) {}

		public bool HasPhone
		{
			get { return GetBit((byte)0); }
			set { SetBit((byte)0, value); }
		}

		public bool HasBaby
		{
			get { return GetBit((byte)1); }
			set { SetBit((byte)1, value); }
		}

		public bool NewLot
		{
			get { return GetBit((byte)2); }
			set { SetBit((byte)2, value); }
		}

		public bool HasComputer
		{
			get { return GetBit((byte)3); }
			set { SetBit((byte)3, value); }
		}
	}
	/// <summary>
	/// Represents a PackedFile in Fami Format
	/// </summary>
	public class Fami : AbstractWrapper, IFileWrapper, IFileWrapperSaveExtension
	{
		/// <summary>
		/// Instance Number of the TExtfile containing the Family Name
		/// </summary>
		private uint strinstance;

		/// <summary>
		/// Instance Number of the Lot this Familie lives in
		/// </summary>
		private uint lotinstance;

		/// <summary>
		/// Money of the Family
		/// </summary>
		private int money;

		/// <summary>
		/// Friends of this Family
		/// </summary>
		private uint friends;

		

		/// <summary>
		/// The Members of this Family
		/// </summary>
		private uint[] sims; 

		private uint id;
		private uint version;
		private uint unknown;
		private uint flags;
		private uint albumGUID;
		
		/// <summary>
		/// Returns/Sets the Flags
		/// </summary>
		public uint Flags 
		{
			get { return flags; }
			set { flags = value; }
		}

		/// <summary>
		/// Returns/Sets the Story Telling Album GUID
		/// </summary>
		public uint AlbumGUID 
		{
			get { return albumGUID; }
			set { albumGUID = value; }
		}

		/// <summary>
		/// Returns/Sets the amount of Money the Family posesses
		/// </summary>
		public int Money
		{
			get 
			{
				return money;
			}
			set 
			{
				money = value;
			}
		}

		/// <summary>
		/// Returns the Number of Family friends
		/// </summary>
		public uint Friends
		{
			get { return friends; }
			set { friends = value; }
		}

		/// <summary>
		/// Returns/Sets the Sim Id's for Familymembers
		/// </summary>
		public uint[] Members 
		{
			get 
			{
				return sims;
			}
			set 
			{
				sims = value;
				if (sims==null) sims = new uint[0];
			}
		}

		/// <summary>
		/// Returns the FirstName of a Sim the Sims
		/// </summary>
		/// <remarks>If no SimName Provider is available, all Names will be empty</remarks>
		public string[] SimNames 
		{
			get 
			{
				string[] names = new string[sims.Length];
				if (nameprovider!=null) 
				{
					
					for (int i=0; i<sims.Length; i++)
					{
						names[i] = nameprovider.FindName(sims[i]).Name;
					}
					
				} 				
				return names;
			}
		}

		/// <summary>
		/// Returns a Descriptor for the Lot the Family lives in, or null if none assigned
		/// </summary>
		public uint LotInstance
		{
			get { return lotinstance; }
			set { lotinstance = value; }
		}

		uint subhood;
		public uint SubHoodNumber
		{
			get { return subhood; }
			set { subhood = value; }
		}

		/// <summary>
		/// Returns the Name of the Family
		/// </summary>
		public string Name 
		{
			get 
			{
				string name=Localization.Manager.GetString("Unknwon");
				try 
				{
					IPackedFileDescriptor pfd = package.FindFile(Data.MetaData.STRING_FILE, 0, this.FileDescriptor.Group, this.FileDescriptor.Instance);


					//foudn a Text Resource
					if (pfd!=null) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new Str();
						str.ProcessData(pfd, package);

						SimPe.PackedFiles.Wrapper.StrItemList items = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
						if (items.Length>0) name = items[0].Title;
					}
				} 
				catch (Exception){}
				return name;
			}

			set 
			{
				try 
				{
					IPackedFileDescriptor pfd = package.FindFile(Data.MetaData.STRING_FILE, 0, this.FileDescriptor.Group, this.FileDescriptor.Instance);

					// found a Text Resource
					if (pfd!=null) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new Str();
						str.ProcessData(pfd, package);

						foreach(SimPe.PackedFiles.Wrapper.StrLanguage lng in str.Languages)
						{
							if (lng == null) continue;
							if (str.LanguageItems(lng)[0x0] != null) str.LanguageItems(lng)[0x0].Title = value;
						}

						str.SynchronizeUserData();
					}
				} 
				catch (Exception){}
			}
		}

		/// <summary>
		/// Stores null or a valid Name Provider
		/// </summary>
		SimPe.Interfaces.Providers.ISimNames nameprovider;

		/// <summary>
		/// Returns the Name Provider
		/// </summary>
		internal SimPe.Interfaces.Providers.ISimNames NameProvider 
		{
			get 
			{
				return nameprovider;
			}
		}

		/// <summary>
		/// Returns the Description File for the passed Sim id
		/// </summary>
		/// <param name="simid">id of the Sim</param>
		/// <returns>The Description file for the Sim</returns>
		/// <remarks>
		/// If the Description file does not exist in 
		/// the current Package, it will be added!
		/// </remarks>
		/// <exception cref="Exception">Thrown when ProcessData was not called.</exception>
		public SDesc GetDescriptionFile(uint simid)
		{
			if (package==null) throw new Exception("No package loaded!");

			SDesc sdesc = SDesc.FindForSimId(simid, package);
			if (sdesc==null) 
			{
				sdesc = new SDesc(null, null, null);
				sdesc.SimId = simid;
				sdesc.CharacterDescription.Age = 28;
				
				IPackedFileDescriptor[] files = package.FindFiles(SimPe.Data.MetaData.SIM_DESCRIPTION_FILE);
				sdesc.Instance = 0;
				foreach(IPackedFileDescriptor pfd in files) 
				{
					if (pfd.Instance>sdesc.Instance) sdesc.Instance=(ushort)pfd.Instance;
				}
				sdesc.Instance++;

				IPackedFileDescriptor fd = package.Add(SimPe.Data.MetaData.SIM_DESCRIPTION_FILE, 0x0, FileDescriptor.Group, sdesc.Instance);
				sdesc.Save(fd);				
			}

			return sdesc;
		}

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.Fami();
		}

		public Fami(SimPe.Interfaces.Providers.ISimNames names) : base()
		{
			id = 0x46414D49;
			version = 0x0000004E;
			unknown = 0;
			nameprovider = names;
			flags = 0x04;
		}

		protected override void Unserialize(System.IO.BinaryReader reader)
		{						
			id = reader.ReadUInt32();
			version = reader.ReadUInt32();
			unknown = reader.ReadUInt32();
			lotinstance = reader.ReadUInt32();
			strinstance = reader.ReadUInt32();
			money = reader.ReadInt32();
			friends = reader.ReadUInt32();
			this.flags = reader.ReadUInt32();
			uint count = reader.ReadUInt32();
			sims = new uint[count];

			for (int i=0; i< sims.Length; i++)
			{
				sims[i] = reader.ReadUInt32();
			}
			this.albumGUID = reader.ReadUInt32(); //relations??
			if (version==0x4f) this.subhood = reader.ReadUInt32();
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(id);
			writer.Write(version);
			writer.Write(unknown);
			writer.Write(lotinstance);
			writer.Write(strinstance);
			writer.Write(money);
			writer.Write(friends);
			writer.Write((uint)this.Flags);
			writer.Write((uint)sims.Length);
			
			for (int i=0; i< sims.Length; i++)
			{
				writer.Write((uint)sims[i]);
			}
			writer.Write(this.albumGUID);

			if (version==0x4f) writer.Write(this.subhood);
		}
		#endregion

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return  new AbstractWrapperInfo(
				"FAMi Wrapper",
				"Quaxi",
				"---",
				3
				); 
		}
		#endregion

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								  0x46414D49 
							   };
				return Types;
			}
		}


		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {
								(byte)'I',
								(byte)'M',
								(byte)'A',
								(byte)'F' 						 
							 };
				return sig;
			}
		}		

		

		#endregion
	}
}
