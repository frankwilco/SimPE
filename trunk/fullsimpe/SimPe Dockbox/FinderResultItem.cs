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

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// this interface must be implemented by Result Items in order to be handled by the Result Browser
	/// </summary>
	internal interface IFinderResultItem
	{
		/// <summary>
		/// Open the Resource in SimPE
		/// </summary>
		/// <returns>true, if the Resource was opened</returns>
		bool OpenResource();		
	}

	/// <summary>
	/// Represents one found Resource, you need to override <see cref="Open"/> with a specific Implementation.
	/// </summary>
	internal class FinderResultItem : SteepValley.Windows.Forms.XPListViewItem, IFinderResultItem
	{
		public FinderResultItem() : this("") {}
		public FinderResultItem(string text) : base()
		{
			this.Text = text;			
		}

		public virtual bool OpenResource()
		{
			return true;
		}		
	}

	/// <summary>
	/// Represents a found <see cref="SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem"/> Resource.
	/// </summary>
	internal class ScenegraphResultItem : FinderResultItem
	{
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii;
        public ScenegraphResultItem(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
            : base(SimPe.Localization.GetString("Unknown")) 
		{
            this.fii = fii;
            SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp = FileTable.WrapperRegistry.FindHandler(fii.FileDescriptor.Type);
            if (wrp != null)
            {
                ((SimPe.Interfaces.Plugin.AbstractWrapper)wrp).Package = fii.Package;
                ((SimPe.Interfaces.Plugin.AbstractWrapper)wrp).FileDescriptor = fii.FileDescriptor;
                this.Text = wrp.ResourceName;
            }
            else this.Text = fii.FileDescriptor.ToString();

            this.SubItems.Add("0x" + Helper.HexString(fii.FileDescriptor.Type));
            this.SubItems.Add("0x" + Helper.HexString(fii.FileDescriptor.Group));
            this.SubItems.Add("0x" + Helper.HexString(fii.FileDescriptor.LongInstance));
            this.SubItems.Add("0x" + Helper.HexString(fii.FileDescriptor.Offset));
            this.SubItems.Add("0x" + Helper.HexString(fii.FileDescriptor.Size));
            this.SubItems.Add(fii.Package.SaveFileName);
            /*this.SubItems.Add("    Type: 0x"+Helper.HexString(fii.FileDescriptor.Type));
            this.SubItems.Add("    Group: 0x"+Helper.HexString(fii.FileDescriptor.Group));
            this.SubItems.Add("    Instance: 0x"+Helper.HexString(fii.FileDescriptor.LongInstance));						
            this.SubItems.Add("    Offset: 0x"+Helper.HexString(fii.FileDescriptor.Offset));
            this.SubItems.Add("    Size: 0x"+Helper.HexString(fii.FileDescriptor.Size));
            this.SubItems.Add("    "+fii.Package.SaveFileName);*/
        }

        public ScenegraphResultItem(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
            : this(new FileIndexItem(pfd, pkg))
        {
			
		}

		public override bool OpenResource()
		{
			return SimPe.RemoteControl.OpenPackedFileFkt(this.fii);	
		}		
	}
}
