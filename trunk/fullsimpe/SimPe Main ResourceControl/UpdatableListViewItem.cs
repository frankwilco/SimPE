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
using System.Windows.Forms;
using System.Collections;

namespace SimPe
{
	/// <summary>
	/// This class is used to notify a ListViewItem of a state Change
	/// </summary>
	public class UpdatableListViewItem : ListViewItem, System.IDisposable
	{
		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		SimPe.Interfaces.Files.IPackageFile pkg;

		/// <summary>
		/// Create a new Instance with the passed Descriptor
		/// </summary>
		/// <param name="pfd"></param>
		public UpdatableListViewItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg) : base("")
		{
			this.pfd = pfd;
			this.pkg = pkg;
			ChangeDescription();

			Tag = new ListViewTag(pfd, pkg);
			pfd.DescriptionChanged += new EventHandler(pfd_DescriptionChanged);
			pfd.ChangedData += new SimPe.Events.PackedFileChanged(pfd_ChangedUserData);			
		}

		
		~UpdatableListViewItem()
		{
			Close();
		}

		public void Close()
		{
			if (pfd!=null)
			{
				pfd.DescriptionChanged -= new EventHandler(pfd_DescriptionChanged);
				pfd.ChangedData -= new SimPe.Events.PackedFileChanged(pfd_ChangedUserData);
			}

			if (Tag!=null)
				if (Tag is ListViewTag)
					((ListViewTag)Tag).Dispose();

			Tag = null;
			pfd = null;
			pkg = null;
		}

		void pfd_DescriptionChanged(object sender, EventArgs e)
		{
			ChangeDescription();
		}

		private void pfd_ChangedUserData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
		{
			ChangeDescription();
		}

		/// <summary>
		/// Set the Description for this ListViewItem
		/// </summary>
		void ChangeDescription()
		{
			while (SubItems.Count<6) SubItems.Add("");

			SubItems[0].Text = GetName();
			SubItems[1].Text = "0x"+Helper.HexString(pfd.Group);
			SubItems[2].Text = "0x"+Helper.HexString(pfd.SubType);
			SubItems[3].Text = "0x"+Helper.HexString(pfd.Instance);						
			SubItems[4].Text = "0x"+Helper.HexString(pfd.Offset);
			SubItems[5].Text = "0x"+Helper.HexString(pfd.Size);

			ForeColor = System.Drawing.SystemColors.WindowText;
			Font = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Regular, Font.Unit);

			if (pfd.MarkForDelete) 
			{
				ForeColor = System.Drawing.SystemColors.GrayText;
				Font = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Strikeout, Font.Unit);
			}
			if (pfd.MarkForReCompress || (pfd.WasCompressed && !pfd.HasUserdata))
			{
				ForeColor = System.Drawing.SystemColors.Highlight;
				Font = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style, Font.Unit);
			}
			
			if (pfd.MarkForReCompress)
				Font = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style | System.Drawing.FontStyle.Bold, Font.Unit);

			if (pfd.Changed)
				Font = new System.Drawing.Font(Font.FontFamily, Font.Size, Font.Style | System.Drawing.FontStyle.Italic, Font.Unit);						
		}

		/// <summary>
		/// Try to load the name for this Item
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			string name = Data.MetaData.FindTypeAlias(pfd.Type).ToString();
			
			//User want's the real Filename
			if (Helper.WindowsRegistry.DecodeFilenamesState) 
			{
				SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp = FileTable.WrapperRegistry.FindHandler(pfd.Type);
				if (wrp!=null) 
				{		
					SimPe.Interfaces.Files.IPackedFileDescriptor bakpfd = null;
					SimPe.Interfaces.Files.IPackageFile bakpkg = null;
					if (wrp is SimPe.Interfaces.Plugin.AbstractWrapper) 
					{	
						SimPe.Interfaces.Plugin.AbstractWrapper awrp = (SimPe.Interfaces.Plugin.AbstractWrapper)wrp;
						if (!awrp.AllowMultipleInstances) 
						{
							bakpfd = awrp.FileDescriptor;
							bakpkg = awrp.Package;
						} 

						awrp.FileDescriptor = pfd;
						awrp.Package = pkg;
						
					}
					try 
					{
						name = wrp.ResourceName;	
					}
#if DEBUG
					catch (Exception ex)
					{
						name = ex.Message;
					}
#else
					catch{}
#endif
					finally 
					{
						if (bakpfd!=null || bakpkg!=null)
							if (wrp is SimPe.Interfaces.Plugin.AbstractWrapper) 
							{	
								SimPe.Interfaces.Plugin.AbstractWrapper awrp = (SimPe.Interfaces.Plugin.AbstractWrapper)wrp;
								if (!awrp.AllowMultipleInstances) 
								{
									awrp.FileDescriptor = bakpfd;
									awrp.Package = bakpkg;
								} 
							}
					}

					this.ImageIndex = wrp.WrapperDescription.IconIndex;
				} 
				else this.ImageIndex = 0;
			}

			return name;
		}		
		#region IDisposable Member

		public void Dispose()
		{
			Close();
		}

		#endregion
	}

}
