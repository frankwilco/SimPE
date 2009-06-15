/***************************************************************************
 *   Copyright (C) 2005 by Peter L Jones                                   *
 *   pljones@users.sf.net                                                  *
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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Wrapper;
using SimPe.Data;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Summary description for StrListViewer.
	/// </summary>
	public class StrListViewer : System.Windows.Forms.UserControl
	{
		#region Form elements

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public StrListViewer()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader colLine;
		private System.Windows.Forms.ColumnHeader colTitle;
		private System.Windows.Forms.ColumnHeader colDesc;
		private System.Windows.Forms.ContextMenu cmLangList;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.ContextMenu cmStrList;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;


		#region Str
		/// <summary>
		/// The Str wrapper handling the packed file data
		/// </summary>
		private SimPe.PackedFiles.Wrapper.Str wrapper;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;

		private StrLanguage currentLang = null;


		internal void UpdateGUI(Str wrp)
		{
			wrapper = wrp;
			this.treeView1.Nodes.Clear();
			this.listView1.Items.Clear();
			foreach (StrLanguage l in wrapper.Languages)
			{
				TreeNode node = new TreeNode();
				node.Tag = (object)l;
				node.Text = l.ToString();
				this.treeView1.Nodes.Add(node);
			}

		}
		#endregion

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.cmLangList = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.listView1 = new System.Windows.Forms.ListView();
			this.colLine = new System.Windows.Forms.ColumnHeader();
			this.colTitle = new System.Windows.Forms.ColumnHeader();
			this.colDesc = new System.Windows.Forms.ColumnHeader();
			this.cmStrList = new System.Windows.Forms.ContextMenu();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			//
			// treeView1
			//
			this.treeView1.ContextMenu = this.cmLangList;
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.ImageIndex = -1;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(216, 144);
			this.treeView1.Sorted = true;
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			//
			// cmLangList
			//
			this.cmLangList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem1,
																					   this.menuItem2,
																					   this.menuItem7,
																					   this.menuItem3,
																					   this.menuItem8,
																					   this.menuItem9});
			//
			// menuItem1
			//
			this.menuItem1.Index = 0;
			this.menuItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem1.Text = "&Copy";
			//
			// menuItem2
			//
			this.menuItem2.Index = 1;
			this.menuItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem2.Text = "&Paste";
			//
			// menuItem3
			//
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "&Set all to these";
			//
			// splitter1
			//
			this.splitter1.Location = new System.Drawing.Point(216, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 144);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			//
			// listView1
			//
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																						this.colLine,
																						this.colTitle,
																						this.colDesc});
			this.listView1.ContextMenu = this.cmStrList;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(219, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(621, 144);
			this.listView1.TabIndex = 2;
			this.listView1.View = System.Windows.Forms.View.Details;
			//
			// colLine
			//
			this.colLine.Text = "Line";
			this.colLine.Width = 36;
			//
			// colTitle
			//
			this.colTitle.Text = "Title";
			this.colTitle.Width = 246;
			//
			// colDesc
			//
			this.colDesc.Text = "Description";
			this.colDesc.Width = 307;
			//
			// cmStrList
			//
			this.cmStrList.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem11,
																					  this.menuItem12});
			//
			// menuItem4
			//
			this.menuItem4.Index = 1;
			this.menuItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.menuItem4.Text = "&Copy";
			//
			// menuItem5
			//
			this.menuItem5.Index = 2;
			this.menuItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.menuItem5.Text = "&Paste";
			//
			// menuItem6
			//
			this.menuItem6.Index = 3;
			this.menuItem6.Text = "&Set in all languages";
			//
			// menuItem7
			//
			this.menuItem7.Index = 2;
			this.menuItem7.Text = "Pas&te As...";
			//
			// menuItem8
			//
			this.menuItem8.Index = 4;
			this.menuItem8.Shortcut = System.Windows.Forms.Shortcut.Ins;
			this.menuItem8.Text = "&Add";
			//
			// menuItem9
			//
			this.menuItem9.Index = 5;
			this.menuItem9.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItem9.Text = "&Delete";
			//
			// menuItem10
			//
			this.menuItem10.DefaultItem = true;
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "&Edit";
			//
			// menuItem11
			//
			this.menuItem11.Index = 4;
			this.menuItem11.Shortcut = System.Windows.Forms.Shortcut.Ins;
			this.menuItem11.Text = "&Add";
			//
			// menuItem12
			//
			this.menuItem12.Index = 5;
			this.menuItem12.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.menuItem12.Text = "&Delete";
			//
			// StrListViewer
			//
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.treeView1);
			this.Name = "StrListViewer";
			this.Size = new System.Drawing.Size(840, 144);
			this.ResumeLayout(false);

		}
		#endregion

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			this.listView1.Items.Clear();
			StrLanguage l = (StrLanguage) e.Node.Tag;
			StrItemList items = wrapper.LanguageItems(l);
			if (items == null) return;

			for (int i = 0; i < items.Length; i++)
			{

				StrToken s = items[i];
				string[] ss = new string[3];
				ss[0] = i.ToString();
				ss[1] = s.Title;
				ss[2] = s.Description;
				ListViewItem v = new ListViewItem(ss);
				this.listView1.Items.Add(v);
			}
			currentLang = l;
		}
	}
}
