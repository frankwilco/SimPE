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
using System.Drawing;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// Contain a Template Package
	/// </summary>
	public class PhotoStudioTemplate
	{
		Interfaces.Files.IPackageFile package;
		SimPe.PackedFiles.Wrapper.Cpf pset;
		SimPe.PackedFiles.Wrapper.Str ctss;

		/// <summary>
		/// Create a new Instance and load the main Template Files
		/// </summary>
		/// <param name="package"></param>
		public PhotoStudioTemplate(Interfaces.Files.IPackageFile package)
		{
			this.package = package;

			Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(0xEBCF3E27, 0xffffffff, 0xffffffff, 0xffffffff);
			pset = new SimPe.PackedFiles.Wrapper.Cpf();
			ctss = null;
			if (pfd!=null)
			{
				pset.ProcessData(pfd, package);

				pfd = package.FindFile(Data.MetaData.CTSS_FILE, 0xffffffff, 0xffffffff, pset.GetSaveItem("description").UIntegerValue);
				if (pfd!=null) 
				{
					ctss = new SimPe.PackedFiles.Wrapper.Str();
					ctss.ProcessData(pfd, package);
				}
			}
		}

		/// <summary>
		/// eturns the Base Package
		/// </summary>
		public Interfaces.Files.IPackageFile Package 
		{
			get { return package; }
		}

		/// <summary>
		/// The Title of this Package
		/// </summary>
		public string Title 
		{
			get 
			{
				if (ctss==null) return package.FileName;
				SimPe.PackedFiles.Wrapper.StrItemList items = ctss.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				if (items.Length>0) return items[0].Title;

				return package.FileName;
			}
		}

		/// <summary>
		/// The Type of the Template
		/// </summary>
		/// <remarks>
		/// 0x01 : Picture Template
		/// </remarks>
		public uint Type
		{
			get { return pset.GetSaveItem("type").UIntegerValue; }
		}

		/// <summary>
		/// The Name of the Texture File
		/// </summary>
		public string TxtrFile
		{
			get { return pset.GetSaveItem("texture").StringValue; }
		}

		/// <summary>
		/// Returns the Image of the stored Texture
		/// </summary>
		public Image Texture
		{
			get 
			{
				try 
				{
					SimPe.Plugin.Txtr txtr = new Txtr(null, false);

					//load TXTR
					Interfaces.Files.IPackedFileDescriptor[] pfd = package.FindFile(TxtrFile+"_txtr", 0x1C4A276C);
					if (pfd.Length>0) 
					{
						txtr.ProcessData(pfd[0], package);
					}

					SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)txtr.Blocks[0];
					return id.MipMapBlocks[0].MipMaps[id.MipMapBlocks[0].MipMaps.Length-1].Texture;
				} 
				catch (Exception) {
					return new Bitmap(1, 1);
				}
			}
		}

		/// <summary>
		/// The Name of the MATD File
		/// </summary>
		public string MatdFile
		{
			get { return pset.GetSaveItem("materialDescription").StringValue; }
		}

		/// <summary>
		/// The Instance of the MMAT File
		/// </summary>
		/// <remarks>group=0xffffffff, subType=0x00000000</remarks>
		public uint MmatInstance
		{
			get { return pset.GetSaveItem("materialOverride").UIntegerValue; }
		}

		/// <summary>
		/// Returns the Rectangle you should place the Custom Image to
		/// </summary>
		public System.Drawing.Rectangle TargetRectangle
		{
			get 
			{
				return new System.Drawing.Rectangle(
					pset.GetSaveItem("left").IntegerValue,
					pset.GetSaveItem("top").IntegerValue,
					pset.GetSaveItem("width").IntegerValue,
					pset.GetSaveItem("height").IntegerValue
					);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			System.Drawing.Rectangle rect = TargetRectangle;
			return rect.Width.ToString()+"x"+rect.Height.ToString()+": "+Title;
		}

	}
}
