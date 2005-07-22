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

namespace SimPe.Plugin
{
	public class SkinChain 
	{
		protected SimPe.PackedFiles.Wrapper.Cpf cpf;

		public SkinChain(SimPe.PackedFiles.Wrapper.Cpf cpf) 
		{
			this.cpf = cpf;
		}

		public SimPe.PackedFiles.Wrapper.Cpf Cpf 
		{
			get 
			{
				return cpf;
			}
		}

		public uint Category 
		{
			get 
			{
				try 
				{
					if (Cpf!=null) 
					{
						SimPe.PackedFiles.Wrapper.CpfItem citem = Cpf.GetItem("category");
						if (citem!=null) return citem.UIntegerValue;
					
					}
				} 
				catch (Exception) {}
				return 0;
			}
		}

		public uint Age
		{
			get 
			{
				try 
				{
					if (Cpf!=null) 
					{
						SimPe.PackedFiles.Wrapper.CpfItem citem = Cpf.GetItem("age");
						if (citem!=null) return citem.UIntegerValue;
					
					}
				} 
				catch (Exception) {}
				return 0;
			}
		}

		public string Name
		{
			get 
			{
				try 
				{
					if (Cpf!=null) 
					{
						SimPe.PackedFiles.Wrapper.CpfItem citem = Cpf.GetItem("name");
						if (citem!=null) return citem.StringValue;
					
					}
				} 
				catch (Exception) {}
				return "";
			}
		}

		protected RefFile ReferenceFile
		{
			get
			{
				if (Cpf!=null) 
				{
					try 
					{
						Interfaces.Files.IPackedFileDescriptor pfd = Cpf.Package.FindFile(0xAC506764, Cpf.FileDescriptor.SubType, Cpf.FileDescriptor.Group, Cpf.FileDescriptor.Instance);
						if (pfd != null) 
						{
							RefFile reffile = new RefFile();
							reffile.ProcessData(pfd, Cpf.Package);

							return reffile;
						}
					}
					catch {}
				}
				return null;
			}
		}

		public GenericRcol TXMT
		{
			get 
			{
				RefFile reffile = this.ReferenceFile;
				if (reffile!=null) 
				{
					try 
					{
						foreach (Interfaces.Files.IPackedFileDescriptor pfd in reffile.Items) 
						{	
							if (pfd.Type == Data.MetaData.TXMT) 
							{
								Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(pfd, null);
								if (items.Length>0) 
								{
									SimPe.Plugin.GenericRcol rcol= new GenericRcol(null, false);
									rcol.ProcessData(items[0]);

									return rcol;
								}
							}
						}
					}
					catch {}
				}

				return null;
			}
		}

		public GenericRcol TXTR
		{
			get 
			{
				GenericRcol txmt = this.TXMT;
				if (txmt!=null) 
				{
					try 
					{
						MaterialDefinition md = (MaterialDefinition)txmt.Blocks[0];
						string txtrname = md.FindProperty("stdMatBaseTextureName").Value.Trim().ToLower();
						if (!txtrname.EndsWith("_txtr")) txtrname += "_txtr";

						Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(txtrname, Data.MetaData.TXTR, Data.MetaData.LOCAL_GROUP, true);
						if (item!=null) 
						{
							SimPe.Plugin.GenericRcol rcol= new GenericRcol(null, false);
							rcol.ProcessData(item);

							return rcol;
						}
 
					}
					catch {}
				}

				return null;
			}
		}

		public string CategoryNames 
		{
			get 
			{
				string scat = "";
				uint cat = this.Category;
				Array a = System.Enum.GetValues(typeof(Data.SkinCategories));
				foreach (Data.SkinCategories k in a) 
				{
					if ((cat & (uint)k) == (uint)k) 
					{
						if (scat != "") scat += ", ";
						scat += k.ToString();
					}
				}

				return scat;
			}
		}

		public string AgeNames 
		{
			get 
			{
				string sage = "";
				uint age = this.Age;
				Array a = System.Enum.GetValues(typeof(Data.Ages));
				foreach (Data.Ages k in a) 
				{
					if ((age & (uint)k) == (uint)k) 
					{
						if (sage != "") sage += ", ";
						sage += k.ToString();
					}
				}

				return sage;
			}
		}

		public override string ToString()
		{
			return "Category="+CategoryNames+"; Age="+AgeNames+"; Name="+Name;									
		}

	}
	/// <summary>
	/// A Item in a 3IDR File
	/// </summary>
	public class RefFileItem : SimPe.Packages.PackedFileDescriptor
	{
		RefFile parent;
		public RefFileItem (RefFile parent)
		{
			this.parent = parent;
		}

		public RefFileItem (Interfaces.Files.IPackedFileDescriptor pfd, RefFile parent)
		{
			this.parent = parent;
			this.Group = pfd.Group;
			this.Type = pfd.Type;
			this.SubType = pfd.SubType;
			this.Instance = pfd.Instance;
		}

		SkinChain skin;
		public SkinChain Skin
		{
			get 
			{
				if ((skin==null) && (this.Type==Data.MetaData.GZPS) && (parent!=null))
				{
					try 
					{
						FileTable.FileIndex.Load();
						Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(this, parent.Package);
						if (items.Length>0) 
						{
							SimPe.PackedFiles.Wrapper.Cpf cpff = new SimPe.PackedFiles.Wrapper.Cpf();
							cpff.ProcessData(items[0]);

							skin = new SkinChain(cpff);
						}
					} 
					catch {}
				}
				return skin;
			}

			set {skin = value; }
		}
		
		public override string ToString()
		{
			string name = base.ToString();			
			
			
		
			if (Skin!=null) 
			{
				name = "Category="+Skin.CategoryNames+"; Age="+Skin.AgeNames+"; Name="+Skin.Name;
				name += " ("+base.ToString()+")";
			}
			return name;
		}

	}

	internal class CpfListItem : SkinChain
	{
		string name;
		uint category;
		internal CpfListItem(SimPe.PackedFiles.Wrapper.Cpf cpf) : base(cpf)
		{
			this.cpf = cpf;
			name = Localization.Manager.GetString("Unknown");
			category = 0;
			if (cpf!=null) 
			{
				foreach (SimPe.PackedFiles.Wrapper.CpfItem citem in cpf.Items) if (citem.Name.ToLower() == "name") name = citem.StringValue;
				foreach (SimPe.PackedFiles.Wrapper.CpfItem citem in cpf.Items) if (citem.Name.ToLower() == "category") category = citem.UIntegerValue;
			} 

			name = name.Replace("CASIE_", "");
		}

		public new string Name 
		{
			get { return name; }
		}

		internal SimPe.PackedFiles.Wrapper.Cpf File 
		{
			get { return cpf; }
		}

		public override string ToString()
		{
			return "0x"+Helper.HexString((ushort)category)+": "+name;
		}

	}
}
