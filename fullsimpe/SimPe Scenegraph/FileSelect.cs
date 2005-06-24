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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für FileSelect.
	/// </summary>
	public class FileSelect : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tc;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TreeView tvfemale;
		private System.Windows.Forms.TreeView tvmale;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		
		public FileSelect()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			Hashtable map = new Hashtable();

			CreateCategoryNodes(ref map, tvfemale, 1);
			CreateCategoryNodes(ref map, tvmale, 2);

			FillCategoryNodes(map);
		}

		/// <summary>
		/// Add the category Nodes to the Treeview
		/// </summary>
		/// <param name="map">a map that can be used to fill thenodes</param>
		/// <param name="tv">the TreeView to fill</param>
		void CreateCategoryNodes(ref Hashtable map, TreeView tv, uint gender) 
		{
			Array cats = System.Enum.GetValues(typeof(Data.SkinCategories));
			Array ages = System.Enum.GetValues(typeof(Data.Ages));

			foreach (Data.Ages a in ages) 
			{
				TreeNode node = new TreeNode(a.ToString());
				Hashtable catmap = (Hashtable)map[(uint)a];
				if (catmap == null) 
				{
					catmap = new Hashtable();
					map[(uint)a] = catmap;
				}

				tv.Nodes.Add(node);

				foreach (Data.SkinCategories c in cats) 
				{
					TreeNode catnode = new TreeNode(c.ToString());
					Hashtable list = (Hashtable)catmap[(uint)c];
					if (list==null) 
					{
						list = new Hashtable();
						catmap[(uint)c] = list;
					}
					list[gender] = catnode;

					node.Nodes.Add(catnode);
				}
			}
		}

		void FillCategoryNodes(Hashtable mmap) 
		{
			WaitingScreen.Wait();
			try 
			{
				FileTable.FileIndex.Load();
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.GZPS, true);
				foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					SimPe.PackedFiles.Wrapper.Cpf skin = new SimPe.PackedFiles.Wrapper.Cpf();
					skin.ProcessData(item);

					if (skin.GetSaveItem("type").StringValue=="skin") 
					{
						bool added = false;
						uint skinage = skin.GetSaveItem("age").UIntegerValue;
						uint skincat = skin.GetSaveItem("category").UIntegerValue;
						if ((skincat&(uint)Data.SkinCategories.Skin)==(uint)Data.SkinCategories.Skin) skincat = (uint)Data.SkinCategories.Skin;
						if (skin.GetSaveItem("override0subset").StringValue.Trim().ToLower().StartsWith("hair")) skincat = (uint)Data.SkinCategories.Skin;
						if (skin.GetSaveItem("override0subset").StringValue.Trim().ToLower().StartsWith("bang")) skincat = (uint)Data.SkinCategories.Skin;
						uint skinsex = skin.GetSaveItem("gender").UIntegerValue;
						string name = skin.GetSaveItem("name").StringValue;
						foreach (uint age in mmap.Keys) 
						{
							if ((age&skinage)==age) 
							{
								Hashtable cats = (Hashtable)mmap[age];
								foreach (uint cat in cats.Keys) 
								{
									if ((cat&skincat)==cat) 
									{
										Hashtable sex = (Hashtable)cats[cat];
										foreach (uint g in sex.Keys) 
										{
											if ((g&skinsex)==g) 
											{
												TreeNode parent = (TreeNode)sex[g];
												TreeNode node = new TreeNode(name);
												node.Tag = skin;
												parent.Nodes.Add(node);

												added = true;
											}
										}
									}
								}
							}
						} //foreach age

						if (!added) 
						{
							TreeNode tn = new TreeNode(name);
							tn.Tag = skin;
							tvmale.Nodes.Add(tn);
							tvfemale.Nodes.Add((TreeNode)tn.Clone());
						}
					}
				}
			} 
			finally 
			{
				WaitingScreen.Stop();
			}
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FileSelect));
			this.button1 = new System.Windows.Forms.Button();
			this.tc = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tvfemale = new System.Windows.Forms.TreeView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tvmale = new System.Windows.Forms.TreeView();
			this.pb = new System.Windows.Forms.PictureBox();
			this.lbname = new System.Windows.Forms.Label();
			this.tc.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(576, 544);
			this.button1.Name = "button1";
			this.button1.TabIndex = 1;
			this.button1.Text = "Use";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tc
			// 
			this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tc.Controls.Add(this.tabPage1);
			this.tc.Controls.Add(this.tabPage2);
			this.tc.Location = new System.Drawing.Point(8, 8);
			this.tc.Name = "tc";
			this.tc.SelectedIndex = 0;
			this.tc.Size = new System.Drawing.Size(560, 560);
			this.tc.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tvfemale);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(552, 534);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Female";
			// 
			// tvfemale
			// 
			this.tvfemale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tvfemale.HideSelection = false;
			this.tvfemale.ImageIndex = -1;
			this.tvfemale.Location = new System.Drawing.Point(8, 8);
			this.tvfemale.Name = "tvfemale";
			this.tvfemale.SelectedImageIndex = -1;
			this.tvfemale.Size = new System.Drawing.Size(536, 520);
			this.tvfemale.TabIndex = 0;
			this.tvfemale.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Select);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tvmale);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(552, 534);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Male";
			// 
			// tvmale
			// 
			this.tvmale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tvmale.HideSelection = false;
			this.tvmale.ImageIndex = -1;
			this.tvmale.Location = new System.Drawing.Point(8, 7);
			this.tvmale.Name = "tvmale";
			this.tvmale.SelectedImageIndex = -1;
			this.tvmale.Size = new System.Drawing.Size(536, 520);
			this.tvmale.TabIndex = 1;
			this.tvmale.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Select);
			// 
			// pb
			// 
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb.Location = new System.Drawing.Point(576, 8);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(216, 184);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb.TabIndex = 3;
			this.pb.TabStop = false;
			// 
			// lbname
			// 
			this.lbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbname.Location = new System.Drawing.Point(576, 216);
			this.lbname.Name = "lbname";
			this.lbname.Size = new System.Drawing.Size(216, 192);
			this.lbname.TabIndex = 5;
			this.lbname.Text = "label1";
			// 
			// FileSelect
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(794, 576);
			this.Controls.Add(this.lbname);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.tc);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FileSelect";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Skin Select";
			this.tc.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		bool ok ;
		

		static FileSelect form = null;
		public static SimPe.Interfaces.Files.IPackedFileDescriptor Execute()
		{
			if (form==null) form = new FileSelect();
			return form.DoExecute();
		}

		TreeNode last;
		protected SimPe.Interfaces.Files.IPackedFileDescriptor DoExecute()
		{	
			lbname.Text = "";
			ok = false;
			last = null;
			button1.Enabled = false;
			this.ShowDialog();

			if ((ok)  && (last!=null))
			{
				SimPe.PackedFiles.Wrapper.Cpf cpf = (SimPe.PackedFiles.Wrapper.Cpf)last.Tag;					
				return cpf.FileDescriptor;				
			}

			return null;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}

		private void Select(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			pb.Image = null;
			button1.Enabled = false;
			lbname.Text = "";
			last = null;
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;
			button1.Enabled = true;
			last = e.Node;

			SkinChain sc = new SkinChain((SimPe.PackedFiles.Wrapper.Cpf)e.Node.Tag);
			GenericRcol rcol = sc.TXTR;

			if (rcol!=null) 
			{
				ImageData id = (ImageData)rcol.Blocks[0];
				MipMap mm = id.GetLargestTexture(pb.Size);
				if (mm!=null) pb.Image = ImageLoader.Preview(mm.Texture, pb.Size);
			}

			lbname.Text = "Name: "+Helper.lbr+sc.Name+Helper.lbr+Helper.lbr;
			lbname.Text += "Category: "+Helper.lbr+sc.CategoryNames+Helper.lbr+Helper.lbr;
			lbname.Text += "Age: "+Helper.lbr+sc.AgeNames+Helper.lbr+Helper.lbr;
			lbname.Text += "Override: "+Helper.lbr+sc.Cpf.GetSaveItem("override0subset").StringValue+Helper.lbr+Helper.lbr;
			lbname.Text += "Group: "+Helper.lbr+Helper.HexString(sc.Cpf.FileDescriptor.Group)+Helper.lbr+Helper.lbr;
		}
	}
}
