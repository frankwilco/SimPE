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
using System.Windows.Forms;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class RcolUI : IPackedFileUI
	{
		#region Code to Startup the UI

		
		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		//internal NgbhForm form;
		RcolForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public RcolUI()
		{
			form = new RcolForm();
		}
		#endregion

		

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get
			{
				if (form==null) return null;
				return form;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <param name="wrapper">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrapper)
		{			
			Rcol wrp = (Rcol) wrapper;
			form.wrapper = wrp;

			form.cbitem.Items.Clear();
			foreach (IRcolBlock rb in wrp.Blocks) SimPe.CountedListItem.AddHex(form.cbitem, rb);
			if (form.cbitem.Items.Count>0) form.cbitem.SelectedIndex = 0;
			else form.BuildChildTabControl(null);

			form.lbref.Items.Clear();
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in wrp.ReferencedFiles) form.lbref.Items.Add(pfd);
			if (form.lbref.Items.Count>0) form.lbref.SelectedIndex = 0;

			form.tbResource.TabPages.Remove(form.tpref);
			form.tv.Nodes.Clear();
			if (typeof(IScenegraphItem)==wrp.GetType().GetInterface("IScenegraphItem")) 
			{
				form.tbResource.TabPages.Add(form.tpref);
				System.Collections.Hashtable refmap = ((IScenegraphItem)wrp).ReferenceChains;
				foreach (string k in refmap.Keys) 
				{
					System.Collections.ArrayList l = (System.Collections.ArrayList)refmap[k];
					TreeNode node = new TreeNode(k);

					foreach (Interfaces.Files.IPackedFileDescriptor pfd in l) 
					{
						TreeNode child = new TreeNode(pfd.Filename+": "+pfd.ToString());
						child.Tag = pfd;
						node.Nodes.Add(child);
					}

					form.tv.Nodes.Add(node);
				}
			} 
			form.tbResource.SelectedIndex = 0;

			if (wrp.Blocks.Length>0) ((AbstractRcolBlock)wrp.Blocks[0]).AddToResourceTabControl(form.tbResource, form.cbitem);

            form.Enabled = !wrp.Duff;
			
		}		

		#endregion
		
		#region IDisposable Member
		public virtual void Dispose()
		{
			this.form.Dispose();
		}
		#endregion
	}
}
