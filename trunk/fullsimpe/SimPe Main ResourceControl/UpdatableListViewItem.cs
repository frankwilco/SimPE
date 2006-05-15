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
	public class ResourceListViewItem :  ListViewItem, System.IDisposable
	{
        static System.Drawing.Font regular = null;
        static System.Drawing.Font strike = null;
        

		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		SimPe.Interfaces.Files.IPackageFile pkg;
        ResourceListView parent;
       
        string[] content;
        System.Drawing.Color fg;
        System.Drawing.Font font;
        int imageindex;
                
        /// <summary>
		/// Create a new Instance with the passed Descriptor
		/// </summary>
		/// <param name="pfd"></param>
		public ResourceListViewItem(ResourceListView parent, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg)
		{
            if (regular==null) {
                regular = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Regular, Font.Unit);
                strike = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Strikeout, Font.Unit);
            }
        
            this.parent = parent;
			this.pfd = pfd;
			this.pkg = pkg;
            content = new string[6];
			ChangeDescription();

			Tag = new ListViewTag(pfd, pkg);
			pfd.DescriptionChanged += new EventHandler(pfd_DescriptionChanged);
			pfd.ChangedData += new SimPe.Events.PackedFileChanged(pfd_ChangedUserData);			
		}

		
		~ResourceListViewItem()
		{
			Close();
		}
        

        internal string[] Content
        {
            get { return content; }
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

        bool load;
        /// <summary>
		/// Set the Description for this ListViewItem
		/// </summary>
        void LoadName()
        {
            if (Helper.WindowsRegistry.AsynchronSort /*&& !parent.Sorter.ForceLoad*/)
            {
                load = false;
                content[0] = pfd.TypeName.ToString();
            }
            else
            {
                DerefferedLoadName();
                BuildItem();
            }
        }

        public void ForceLoad()
        {
            if (!load)
            {
                DerefferedLoadName();                                
                BuildItem();
            }
        }
        
		/// <summary>
		/// Set the Description for this ListViewItem
		/// </summary>
		void ChangeDescription()
		{                       
            content[1] = "0x" + Helper.HexString(pfd.Group);
            content[2] = "0x" + Helper.HexString(pfd.SubType);
            content[3] = "0x" + Helper.HexString(pfd.Instance);
            content[4] = "0x" + Helper.HexString(pfd.Offset);
            content[5] = "0x" + Helper.HexString(pfd.Size);

			fg = System.Drawing.SystemColors.WindowText;
            font = regular;

			if (pfd.MarkForDelete) 
			{
				fg = System.Drawing.SystemColors.GrayText;
                font = strike;
			}
			if (pfd.MarkForReCompress || (pfd.WasCompressed && !pfd.HasUserdata))
			{
				fg = System.Drawing.SystemColors.Highlight;
				//font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style, font.Unit);
			}
			
			if (pfd.MarkForReCompress)
				font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style | System.Drawing.FontStyle.Bold, font.Unit);

			if (pfd.Changed)
				font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style | System.Drawing.FontStyle.Italic, font.Unit);

            LoadName();
		}

      
        void BuildItem()
        {
            SubItems.Clear();
            Text = content[0];
            for (int i=1; i<content.Length; i++)
                SubItems.Add(content[i]);

            ForeColor = fg;
            Font = font;
            ImageIndex = imageindex;            
        }        
        
		/// <summary>
		/// Try to load the name for this Item
		/// </summary>
		/// <returns></returns>
        public void DerefferedLoadName()
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

                    this.imageindex = wrp.WrapperDescription.IconIndex;
				}
                else this.imageindex = 0;
			}

            load = true;
            content[0] = name;
		}		
		#region IDisposable Member

		public void Dispose()
		{
			Close();
		}

		#endregion
	}

}
