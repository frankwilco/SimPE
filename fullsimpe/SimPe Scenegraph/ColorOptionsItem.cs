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
using SimPe.Packages;
using SimPe.Interfaces.Files;


namespace SimPe.Plugin
{
	/// <summary>
	/// contains a Subset
	/// </summary>
	public class SubsetItem
	{
		public SubsetItem(string name, bool slave) 
		{
			this.Name = name;
			this.Slave = slave;
		}

		public string Name;
		public bool Slave;
	}

	/// <summary>
	/// Just a helper Class for the ColorOPtions class
	/// </summary>
	public class ColorOptionsItem 
	{
		public ColorOptionsItem(SimPe.PackedFiles.Wrapper.Cpf mmat) 
		{
			this.MMAT = mmat;

			Subset = mmat.GetSaveItem("subsetName").StringValue.Trim().ToLower();
			Family = mmat.GetSaveItem("family").StringValue.Trim().ToLower();
			Guid = mmat.GetSaveItem("objectGUID").UIntegerValue;
			Default = mmat.GetSaveItem("defaultMaterial").BooleanValue;
			matd = null;
		}

		public string Subset;
		public uint Guid;
		public string Family;
		public bool Default;

		public SimPe.PackedFiles.Wrapper.Cpf MMAT;

		public SimPe.Plugin.Rcol matd;
		/// <summary>
		/// Returns the linked MATD or null if none was found
		/// </summary>
		public SimPe.Plugin.Rcol MATD 
		{
			get 
			{
				if (matd==null) 
				{
					string flname = Hashes.StripHashFromName(MMAT.GetSaveItem("name").StringValue.Trim()+"_txmt".ToLower());

					Interfaces.Files.IPackedFileDescriptor[] pfds = MMAT.Package.FindFile(flname);
					for (int i=0; i<pfds.Length; i++)
					{
						matd = new GenericRcol(null, false);
						matd.ProcessData(pfds[0], MMAT.Package);

						if (matd.FileName.Trim().ToLower()==flname) break;
					}
				}

				return matd;
			}
		}

		public SimPe.Plugin.Txtr txtr;
		/// <summary>
		/// Returns the linked TXTR or null if none was found
		/// </summary>
		public SimPe.Plugin.Txtr TXTR
		{
			get 
			{
				if (MATD==null) return null;

				if (txtr==null)
				{
					SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)matd.Blocks[0];
					string flname = Hashes.StripHashFromName(md.GetProperty("stdMatBaseTextureName").Value.Trim()+"_txtr".ToLower());

					Interfaces.Files.IPackedFileDescriptor[] pfds = MMAT.Package.FindFile(flname);
					for (int i=0; i<pfds.Length; i++)
					{
						txtr = new Txtr(null, false);
						txtr.ProcessData(pfds[0], MMAT.Package);

						if (txtr.FileName.Trim().ToLower()==flname) break;
					}
				}

				return txtr;
			}
		}

		/// <summary>
		/// retunrs the Txtr Name as referenced by the MATD
		/// </summary>
		public string TxtrRef
		{
			get 
			{
				if (MATD==null) return "";

				MaterialDefinition md = (MaterialDefinition)MATD.Blocks[0];
				return Hashes.StripHashFromName(md.GetProperty("stdMatBaseTextureName").Value);
			}
		}

		
		/// <summary>
		/// Checks if this is a slave Subset
		/// </summary>
		/// <param name="subset"></param>
		/// <param name="subsets"></param>
		/// <returns></returns>
		public bool IsSlave(string subset, SubsetItem[] subsets) 
		{
			subset = Hashes.StripHashFromName(subset).Trim().ToLower();
			foreach (SubsetItem i in subsets) 
			{
				if ((i.Slave) && (i.Name.Trim().ToLower()==subset)) return true;
			}

			return false;
		}

		/// <summary>
		/// Fix all links
		/// </summary>
		public string Fix(string family, uint group, ref int ct, Hashtable matdrep, Hashtable txtrrep, ArrayList guids)
		{
			//make sure the references are loaded
			txtr = TXTR;
	
			string groups = "#0x"+Helper.HexString(group)+"!";
			groups = "##0x1c050000!";
			MMAT.GetSaveItem("family").StringValue = family;
			string matdname = Hashes.StripHashFromName(MMAT.GetSaveItem("name").StringValue) + "_" + family; 
			if (matdrep[MMAT.GetSaveItem("name").StringValue]==null) 
			{
				matdrep.Add(MMAT.GetSaveItem("name").StringValue, groups+matdname);
				MMAT.GetSaveItem("name").StringValue = groups+matdname;
			} 
			else 
			{
				MMAT.GetSaveItem("name").StringValue = (string)matdrep[MMAT.GetSaveItem("name").StringValue];
			}

			//make sure we use a supported GUID
			if (guids.Count>0) 
			{
				if (!guids.Contains(MMAT.GetSaveItem("objectGUID").UIntegerValue))
					MMAT.GetSaveItem("objectGUID").UIntegerValue = (uint)guids[0];
			}

			MMAT.GetSaveItem("defaultMaterial").BooleanValue = false;
			MMAT.FileDescriptor.Instance = (uint)(0x4000 + ct++);
			MMAT.FileDescriptor.Group = 0xffffffff;

			string txtrname = groups + "_" + family;
			string org = "";
			if (MATD!=null) 
			{
				MaterialDefinition md = (MaterialDefinition)MATD.Blocks[0];
				md.FileDescription = matdname;
				MATD.FileName = groups + matdname + "_txmt";	
				SimPe.Packages.PackedFileDescriptor matdpfd = new PackedFileDescriptor();

				matdpfd.Type = MATD.FileDescriptor.Type;
				MATD.FileDescriptor = matdpfd;
				MATD.FileDescriptor.Group = 0x1c050000; //group; //0x1C0532FA;
				
				MATD.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(MATD.FileName));
				MATD.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(MATD.FileName));

				org = TxtrRef;	
				string realtxtrname = ""; //Hashes.StripHashFromName(md.GetProperty("stdMatBaseTextureName").Value);
				if (TXTR!=null) 
				{
					realtxtrname = Hashes.StripHashFromName(TXTR.FileName);
					if (realtxtrname.Length>5) realtxtrname = realtxtrname.Substring(0, realtxtrname.Length-5);

				}

				//we foudn a texture
				if (realtxtrname.Trim()!="") 
				{
					txtrname =  realtxtrname + "_" + family;
					if (txtrrep[realtxtrname]==null) 
					{
						txtrrep.Add(realtxtrname, txtrname);
						txtrrep.Add(txtrname, txtrname);
					} 
					else 
					{
						txtrname = (string)txtrrep[realtxtrname];
					}
				
					md.GetProperty("stdMatBaseTextureName").Value = /*groups +*/ Hashes.StripHashFromName(txtrname);

					string[] files = new string[1];
					files[0] = /*groups +*/ Hashes.StripHashFromName(txtrname);
					md.Listing = files;
				}
			}

			
			if (TXTR!=null) 
			{							
				TXTR.FileName = groups + txtrname + "_txtr";
				SimPe.Packages.PackedFileDescriptor txtrpfd = new PackedFileDescriptor();

				txtrpfd.Type = TXTR.FileDescriptor.Type;
				TXTR.FileDescriptor = txtrpfd;
				TXTR.FileDescriptor.Group = 0x1c050000; //group; //0x1C0532FA;
				
				TXTR.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(TXTR.FileName));
				TXTR.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(TXTR.FileName));
			}

			return org;
		}
	}
}
