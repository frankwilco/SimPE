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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Generic UI Handler, which is able to Display Properties in a ListView
	/// </summary>
	public class Generic : GenericUIBase, IPackedFileUI
	{
		/// <summary>
		/// Used to Convert Property contents.
		/// </summary>
		/// <param name="name">The Name of the Property</param>
		/// <param name="item">The Item the property is in.</param>
		/// <param name="o">The value of the Property</param>
		/// <returns>
		/// null, if the default Converter has to handle this 
		/// Property, or the converted String
		/// </returns>
		/// <remarks>This Method can be used by derived Classes to implement Property dependend 
		/// Conversions while generating the ListView.</remarks>		
		protected virtual string PropertyToString(string name, SimPe.PackedFiles.Wrapper.GenericCommon item, object o)
		{
			return null;
		}

		/// <summary>
		/// Converts an Object to a valid String
		/// </summary>
		/// <param name="o">The Object you want to convert</param>
		/// <returns>The String represented by the Object</returns>
		public string ToString(object o) 
		{
			return ToString(null, null, o);
		}

		/// <summary>
		/// Converts an Object from a Generic.Common Property List into a valid String
		/// </summary>
		/// <param name="name">The Name of the Property that will be converted. null if no property</param>
		/// <param name="item">The Item the property is in.</param>
		/// <param name="o">The Object you want to convert</param>
		/// <returns>The String represented by the Object</returns>
		/// <remarks>
		/// The name Parameter was intorduces for derived classes who need special Conversion for special
		/// Property values. When ToString gets a name value not equal to null, it will call the PropertyToString()
		/// Method. When this Method returns null, the default Conversion will be executed, otherwise the returned
		/// String will be passed to the caller.
		/// </remarks>
		public string ToString(string name, Wrapper.GenericCommon item, object o) 
		{
			if (o==null) return "";

			if ((name!=null) && (item!=null))
			{
				string ret = PropertyToString(name, item, o);
				if (ret!=null) return ret;
			}
			
			if ( (o.GetType().IsValueType) ) 
			{
				if (o.GetType() == System.Type.GetType("System.byte")) return "0x"+((byte)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.short")) return "0x"+((short)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.ushort")) return "0x"+((ushort)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.int")) return "0x"+((int)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.uint")) return "0x"+((uint)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.Int16")) return "0x"+((Int16)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.UInt16")) return "0x"+((UInt16)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.Int32")) return "0x"+((Int32)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.UInt32")) return "0x"+((UInt32)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.Int64")) return "0x"+((Int64)o).ToString("X");
				if (o.GetType() == System.Type.GetType("System.UInt64")) return "0x"+((UInt64)o).ToString("X");
			}

			if (o.GetType() == System.Type.GetType("System.Byte[]")) 
			{
				string s="";				
				foreach(byte b in (byte[])o) s += SimPe.PackedFiles.Wrapper.GenericCommon.ToPrintableChar((char)b, '.');
				return s;
			}
			return o.ToString();
		}

		#region IPackedFileHandler Member

		public virtual Panel GUIHandle
		{
			get 
			{
				return form.ListPanel;
			}
		}

		public void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper)	
		{						
			SimPe.PackedFiles.Wrapper.Generic generic = (SimPe.PackedFiles.Wrapper.Generic)wrapper;
			
			
			if (wrapper.GetType().GetInterface("SimPe.Interfaces.Plugin.IFileWrapperSaveExtension", true)!=null)
			{
				form.wrapper = (SimPe.Interfaces.Plugin.IFileWrapperSaveExtension)wrapper;
				form.lllvcommit.Enabled = true;
			} 
			else 
			{
				form.wrapper = null;
				form.lllvcommit.Enabled = false;
			}

			//visualStyleLinkLabel1
			IPackedFileDescriptor pfd = wrapper.FileDescriptor;
			form.listList.Items.Clear();
			form.listList.Columns.Clear();
			form.listBanner.Text = "[Can't process unknown type 0x"+pfd.Type.ToString("X")+"]";
			
			try
			{
				SimPe.PackedFiles.Wrapper.Generic.CreateFileObject cfo = (SimPe.PackedFiles.Wrapper.Generic.CreateFileObject)generic.Subhandlers[pfd.Type];			
				SimPe.PackedFiles.Wrapper.Generic file= generic;				

				form.listBanner.Text = file.GetTypeName(pfd.Type)+" "+Localization.Manager.GetString("viewer");

				//clear the Item Panel
				form.itemPanel.Controls.Clear();
			
				//create Columns
				SimPe.PackedFiles.Wrapper.GenericCommon common = file.Attributes;
				if (file.Count>0) common = file.GetItem(0);
				string[] names = common.Names;
				int size = 0;

				if (names.Length==0) return;

				int[] lengths = new int[names.Length];
				for (int i=0; i<names.Length; i++)
				{
					string s = names[i];
					int thissize = Math.Max(190, s.Length*15);
					size += thissize;
				
					if (i==names.Length-1) 
						thissize = Math.Max(thissize, form.listList.Width - size);

				
					form.listList.Columns.Add(s, thissize, System.Windows.Forms.HorizontalAlignment.Left);

					Label lb = new Label();
					lb.Parent = form.itemPanel;
					lb.Location = new Point(0, i*21+4);
					lb.Text = names[i];
					lb.AutoSize = true;
					lb.BackColor = Color.Transparent;

					TextBox tb = new TextBox();
					tb.Parent = form.itemPanel;
					tb.Location = new Point(lb.Width+8, i*21);
					tb.Text = "";
					tb.Width = form.itemPanel.ClientRectangle.Width - tb.Left;
					tb.Tag = i;
					lengths[i] = 0;
				}
						
			
				if (file.Count>0) //we have FileItems
				{				
					for (uint i=0; i<file.Count; i++)
					{
						SimPe.PackedFiles.Wrapper.GenericItem fileitem = file.GetItem(i);
				
						if (fileitem!=null) 
						{
							string name = ToString(names[0], fileitem, fileitem.Properties[names[0]]);
							ListViewItem item = new ListViewItem(name);
							lengths[0] = (int)Math.Max(lengths[0], name.Length);
							for (int k=1; k<names.Length; k++) 
							{
								name = ToString(names[k], fileitem, fileitem.Properties[names[k]]);
								item.SubItems.Add(name);
								lengths[k] = (int)Math.Max(lengths[k], name.Length);
							}

							item.Tag = fileitem;
							form.listList.Items.Add(item);				
						}
					}
				}

				
				for (int i=0; i<form.listList.Columns.Count; i++)
				{
					ColumnHeader h = form.listList.Columns[i];
					h.Width = (int)Math.Min(200, lengths[i]*10);
				}
				

				if (form.listList.Items.Count==1) 
				{
					form.listBanner.Text += " ("+form.listList.Items.Count.ToString()+" Item)";
				} 
				else 
				{
					form.listBanner.Text += " ("+form.listList.Items.Count.ToString()+" Items)";
				}
			} 
			catch ( Exception ex) 
			{
				if (Helper.DebugMode) form.listBanner.Text += " ["+ex.Message+"]";
			}
			
			//form.listList.Sort();
			form.listList.ListViewItemSorter = null;
		}

		

		#endregion
	}
}
