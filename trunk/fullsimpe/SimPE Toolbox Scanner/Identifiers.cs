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
using SimPe.Interfaces.Plugin.Scanner;

namespace SimPe.Plugin.Identifiers
{
	/// <summary>
	/// Comapers two IIdentifierBase Instances
	/// </summary>
	internal class PluginScannerBaseComparer : System.Collections.IComparer
	{
		#region IComparer Member

		public int Compare(object x, object y)
		{
			if (x==null) 
			{
				if (y==null) return 0;
				else return 1;
			}

			IScannerPluginBase ix = (IScannerPluginBase)x;
			IScannerPluginBase iy = (IScannerPluginBase)y;

			return ix.Index-iy.Index;
		}

		#endregion

	}


	/// <summary>
	/// Identifies a Recolor Package
	/// </summary>
	internal class CepIdentifier : IIdentifier
	{
		public CepIdentifier() {}

		#region IIdentifierBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 100; }
		}

		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Identifier; }
		}
		#endregion

		#region IIdentifier Member

		public SimPe.Cache.PackageType GetType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			string name = System.IO.Path.GetFileName(pkg.FileName).Trim().ToLower();
			if (name == System.IO.Path.GetFileName(Data.MetaData.GMND_PACKAGE).Trim().ToLower()) 
				return SimPe.Cache.PackageType.CEP;
			if (name == System.IO.Path.GetFileName(Data.MetaData.MMAT_PACKAGE).Trim().ToLower()) 
				return SimPe.Cache.PackageType.CEP;
			return SimPe.Cache.PackageType.Unknown;
		}

		#endregion
	}

	/// <summary>
	/// Identifies a Recolor Package
	/// </summary>
	internal class SimIdentifier : IIdentifier
	{
		public SimIdentifier() {}

		#region IIdentifierBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 300; }
		}

		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Identifier; }
		}
		#endregion

		#region IIdentifier Member

		public SimPe.Cache.PackageType GetType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg.FindFiles(0xCCCEF852).Length!=0) return SimPe.Cache.PackageType.Sim; //Facial Structure
			if (pkg.FindFiles(0xAC598EAC).Length!=0) return SimPe.Cache.PackageType.Sim; //Age Data
			return SimPe.Cache.PackageType.Unknown;
		}

		#endregion
	}

	/// <summary>
	/// Identifies a Recolor Package
	/// </summary>
	internal class ObjectIdentifier : IIdentifier
	{
		public ObjectIdentifier() {}

		#region IIdentifierBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 600; }
		}

		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Identifier; }
		}
		#endregion

		#region IIdentifier Member

		public SimPe.Cache.PackageType GetType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg.FindFiles(Data.MetaData.OBJD_FILE).Length==0) return SimPe.Cache.PackageType.Unknown;

			if (pkg.FindFiles(0x484F5553).Length>0) return SimPe.Cache.PackageType.Lot; //HOUS Resources
			if (pkg.FindFilesByGroup(Data.MetaData.CUSTOM_GROUP).Length>0) return SimPe.Cache.PackageType.Object;
			else return SimPe.Cache.PackageType.MaxisObject;
		}

		#endregion
	}

	/// <summary>
	/// Identifies a Recolor Package
	/// </summary>
	internal class CpfIdentifier : IIdentifier
	{
		public CpfIdentifier() {}

		#region IIdentifierBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 400; }
		}

		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Identifier; }
		}
		#endregion

		#region IIdentifier Member

		public SimPe.Cache.PackageType GetType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.GZPS);
			if (pfds.Length==0) pfds = pkg.FindFiles(Data.MetaData.XOBJ); //Object XML
			if (pfds.Length==0) pfds = pkg.FindFiles(0x2C1FD8A1); //TextureOverlay XML
			if (pfds.Length==0) pfds = pkg.FindFiles(0x8C1580B5); //Hairtone XML
			if (pfds.Length==0) pfds = pkg.FindFiles(0x0C1FE246); //Mesh Overlay XML
			if (pfds.Length==0) pfds = pkg.FindFiles(Data.MetaData.XROF); //Object XML
			if (pfds.Length==0) pfds = pkg.FindFiles(Data.MetaData.XFLR); //Object XML
			if (pfds.Length==0) pfds = pkg.FindFiles(Data.MetaData.XFNC); //Object XML

			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
				cpf.ProcessData(pfds[0], pkg, false);

				string type = cpf.GetSaveItem("type").StringValue.Trim().ToLower();

				switch (type) 
				{
					case "wall" : 
					{
						return SimPe.Cache.PackageType.Wallpaper;
					}
					case "terrainpaint":
					{
						return SimPe.Cache.PackageType.Terrain;
					}
					case "floor" : 
					{
						return SimPe.Cache.PackageType.Floor;
					}
					case "roof" : 
					{
						return SimPe.Cache.PackageType.Roof;
					}					
					case "fence" : 
					{
						return SimPe.Cache.PackageType.Fence;
					}
					case "skin" :
					{
						uint cat = cpf.GetSaveItem("category").UIntegerValue;

						if ((cat & (uint)Data.SkinCategories.Skin) != 0) return SimPe.Cache.PackageType.Skin;
						else return SimPe.Cache.PackageType.Cloth;
					}
					case "meshoverlay":
					case "textureoverlay":
					{						
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Blush) return SimPe.Cache.PackageType.Blush;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Eye) return SimPe.Cache.PackageType.Eye;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.EyeBrow) return SimPe.Cache.PackageType.EyeBrow;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.EyeShadow) return SimPe.Cache.PackageType.EyeShadow;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Glasses) return SimPe.Cache.PackageType.Glasses;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Lipstick) return SimPe.Cache.PackageType.Lipstick;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Mask) return SimPe.Cache.PackageType.Mask;
						if (cpf.GetSaveItem("subtype").UIntegerValue == (uint)Data.TextureOverlayTypes.Beard) return SimPe.Cache.PackageType.Beard;

						if (type=="meshoverlay") return SimPe.Cache.PackageType.Accessory;
						return SimPe.Cache.PackageType.Makeup;
					}
					case "hairtone":
					{
						return SimPe.Cache.PackageType.Hair;
					}					
				}
			}

			return SimPe.Cache.PackageType.Unknown;
		}

		#endregion
	}

	/// <summary>
	/// Identifies a Recolor Package
	/// </summary>
	internal class ReColorIdentifier : IIdentifier
	{
		public ReColorIdentifier() {}

		#region IIdentifierBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 200; }
		}

		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Identifier; }
		}
		#endregion

		#region IIdentifier Member

		public SimPe.Cache.PackageType GetType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg.FindFiles(Data.MetaData.TXMT).Length==0) return SimPe.Cache.PackageType.Unknown;
			if (pkg.FindFiles(Data.MetaData.OBJD_FILE).Length!=0) return SimPe.Cache.PackageType.Unknown;
			if (pkg.FindFiles(Data.MetaData.GZPS).Length!=0) return SimPe.Cache.PackageType.Unknown;
			if (pkg.FindFiles(0xCCA8E925).Length!=0) return SimPe.Cache.PackageType.Unknown; //Object XML
			if (pkg.FindFiles(Data.MetaData.REF_FILE).Length!=0) return SimPe.Cache.PackageType.Unknown;
			foreach (uint type in Data.MetaData.RcolList) 
			{
				if (type == Data.MetaData.TXMT) continue;
				if (type == Data.MetaData.TXTR) continue;
				if (type == Data.MetaData.LIFO) continue;

				if (pkg.FindFiles(type).Length!=0) 
				{
					return SimPe.Cache.PackageType.Unknown;
				}
			}

			return SimPe.Cache.PackageType.Recolor;
		}

		#endregion
	}	
}
