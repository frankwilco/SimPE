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
using System.Drawing;
using System.Collections;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces.Files;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für Generic.
	/// </summary>
	public class GenericTree : Generic
	{
		#region IPackedFileHandler Member

		public override Panel GUIHandle
		{
			get 
			{
				return form.TreePanel;
			}
		}

		public new void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			SimPe.PackedFiles.Wrapper.Generic generic = (SimPe.PackedFiles.Wrapper.Generic)wrapper;
			form.mytree.Visible = true;
			IPackedFileDescriptor pfd = wrapper.FileDescriptor;
			form.mytree.Nodes.Clear();
			form.treeBanner.Text = "[Can't process unknown type 0x"+pfd.Type.ToString("X")+"]";
			
			SimPe.PackedFiles.Wrapper.Generic.CreateFileObject cfo = (SimPe.PackedFiles.Wrapper.Generic.CreateFileObject)generic.Subhandlers[pfd.Type];			
			SimPe.PackedFiles.Wrapper.Generic file= null;

			//no Type Handler, so try to load a Signature Based Handler
			if (cfo==null) file = generic.CreateSignatureBasedFileObject(wrapper);

			//neither signature Based Handler nor Type SubHandler -> return
			if ((cfo==null) && (file==null)) return;

			//found a type based SubHander, so load it. Otherwise an existing Signature
			//Based filehandler will be used
			if (cfo!=null) file = cfo(wrapper);

			form.treeBanner.Text = file.GetTypeName(pfd.Type)+" Viewer";

			//clear the Item Panel
			form.treeItemPanel.Controls.Clear();
			
			//create Columns in Item Panel
			SimPe.PackedFiles.Wrapper.GenericCommon common = file.Attributes;
			if (file.Count>0) common = file.GetItem(0);
			string[] names = common.Names;
			//int size = 0;

			if (names.Length==0) return;
			for (int i=0; i<names.Length; i++)
			{
				string s = names[i];
				
				Label lb = new Label();
				lb.Parent = form.treeItemPanel;
				lb.Location = new Point(0, i*21+4);
				lb.Text = names[i];
				lb.AutoSize = true;
				lb.BackColor = Color.Transparent;

				TextBox tb = new TextBox();
				tb.Parent = form.treeItemPanel;
				tb.Location = new Point(lb.Width+8, i*21);
				tb.Text = "";
				tb.Width = form.treeItemPanel.ClientRectangle.Width - tb.Left;
				tb.Tag = i;
			}
						
			
			if (file.Count>0) //we have FileItems
			{								
				AddTreeNodes(file.Items, null, names);
			} 
			

			if (form.listList.Items.Count==1) 
			{
				form.listBanner.Text += " ("+form.listList.Items.Count.ToString()+" Item)";
			} 
		}

		protected void AddTreeNodes(Wrapper.GenericItem[] items, TreeNode parent, string[] names) 
		{
			for (uint i=0; i<items.Length; i++)
				{
					SimPe.PackedFiles.Wrapper.GenericItem fileitem = items[i];					
					if (fileitem!=null) 
					{
						string text = ToString(names[0], fileitem, fileitem.Properties[names[0]]) + " (";
						for (int k=1; k<names.Length; k++) 
						{
							if (k>1) text+=", ";
							text += names[k]+"="+ToString(names[k], fileitem, fileitem.Properties[names[k]]);						
						}
						text += ")";
						TreeNode node = new TreeNode(text);	
						node.Tag = fileitem;

						if (fileitem.Count>0) 
						{
							AddTreeNodes(fileitem.Subitems, node, names);
							
						}

						if (parent==null)
							form.mytree.Nodes.Add(node);
						else 
							parent.Nodes.Add(node);
					}
				}
		}

		

		#endregion
	}
}
