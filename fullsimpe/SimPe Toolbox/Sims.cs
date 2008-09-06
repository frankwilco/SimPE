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
	/// Zusammenfassung für Sims.
	/// </summary>
	public class Sims : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList iListSmall;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.Label lbUbi;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ColumnHeader chKind;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.ComponentModel.IContainer components;
        private FlowLayoutPanel flowLayoutPanel1;
        internal CheckBox cbNpc;
        internal CheckBox cbTownie;
        internal CheckBox ckbPlayable;
        internal CheckBox cbdetail;
        internal CheckBox ckbUnEditable;

		SimsRegistry reg;
		public Sims()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			sorter = new ColumnSorter();

			reg = new SimsRegistry(this);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (reg!=null) reg.Dispose();
				reg = null;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sims));
            this.ilist = new System.Windows.Forms.ImageList(this.components);
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.chKind = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.iListSmall = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbUbi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbNpc = new System.Windows.Forms.CheckBox();
            this.cbTownie = new System.Windows.Forms.CheckBox();
            this.ckbPlayable = new System.Windows.Forms.CheckBox();
            this.cbdetail = new System.Windows.Forms.CheckBox();
            this.ckbUnEditable = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilist
            // 
            this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilist, "ilist");
            this.ilist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lv
            // 
            resources.ApplyResources(this.lv, "lv");
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.chKind,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader10});
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.LargeImageList = this.ilist;
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.SmallImageList = this.iListSmall;
            this.lv.StateImageList = this.iListSmall;
            this.toolTip1.SetToolTip(this.lv, resources.GetString("lv.ToolTip"));
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DoubleClick += new System.EventHandler(this.Open);
            this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortList);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // chKind
            // 
            resources.ApplyResources(this.chKind, "chKind");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader9
            // 
            resources.ApplyResources(this.columnHeader9, "columnHeader9");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // columnHeader8
            // 
            resources.ApplyResources(this.columnHeader8, "columnHeader8");
            // 
            // columnHeader10
            // 
            resources.ApplyResources(this.columnHeader10, "columnHeader10");
            // 
            // iListSmall
            // 
            this.iListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.iListSmall, "iListSmall");
            this.iListSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.Open);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Name = "panel2";
            // 
            // lbUbi
            // 
            this.lbUbi.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.lbUbi, "lbUbi");
            this.lbUbi.ForeColor = System.Drawing.Color.Brown;
            this.lbUbi.Name = "lbUbi";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.YellowGreen;
            this.panel3.Name = "panel3";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.ckbPlayable);
            this.flowLayoutPanel1.Controls.Add(this.cbTownie);
            this.flowLayoutPanel1.Controls.Add(this.cbNpc);
            this.flowLayoutPanel1.Controls.Add(this.ckbUnEditable);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // cbNpc
            // 
            resources.ApplyResources(this.cbNpc, "cbNpc");
            this.cbNpc.Name = "cbNpc";
            this.cbNpc.CheckedChanged += new System.EventHandler(this.ckbFilter_CheckedChanged);
            // 
            // cbTownie
            // 
            resources.ApplyResources(this.cbTownie, "cbTownie");
            this.cbTownie.Name = "cbTownie";
            this.cbTownie.CheckedChanged += new System.EventHandler(this.ckbFilter_CheckedChanged);
            // 
            // ckbPlayable
            // 
            resources.ApplyResources(this.ckbPlayable, "ckbPlayable");
            this.ckbPlayable.Checked = true;
            this.ckbPlayable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbPlayable.Name = "ckbPlayable";
            this.ckbPlayable.UseVisualStyleBackColor = true;
            this.ckbPlayable.CheckedChanged += new System.EventHandler(this.ckbFilter_CheckedChanged);
            // 
            // cbdetail
            // 
            resources.ApplyResources(this.cbdetail, "cbdetail");
            this.cbdetail.Checked = true;
            this.cbdetail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbdetail.Name = "cbdetail";
            this.cbdetail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbUnEditable
            // 
            resources.ApplyResources(this.ckbUnEditable, "ckbUnEditable");
            this.ckbUnEditable.Name = "ckbUnEditable";
            this.ckbUnEditable.UseVisualStyleBackColor = true;
            this.ckbUnEditable.CheckedChanged += new System.EventHandler(this.ckbFilter_CheckedChanged);
            // 
            // Sims
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.cbdetail);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbUbi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Sims";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void AddImage(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc) 
		{
			if (sdesc.Image!=null) 
			{
				if ((sdesc.Unlinked!=0x00) || (!sdesc.AvailableCharacterData) || sdesc.IsNPC)
				{
					Image img = (Image)sdesc.Image.Clone();
					System.Drawing.Graphics g = Graphics.FromImage(img);
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

					Pen pen = new Pen(Data.MetaData.SpecialSimColor, 3);

					g.FillRectangle(pen.Brush, 0, 0, img.Width, img.Height);

					int pos = 2;
					if (sdesc.Unlinked!=0x00) 
					{
						g.FillRectangle(new SolidBrush(Data.MetaData.UnlinkedSim), pos, 2, 25, 25);
						pos += 28;
					}
					if (!sdesc.AvailableCharacterData) 
					{
						g.FillRectangle(new SolidBrush(Data.MetaData.InactiveSim), pos, 2, 25, 25);
						pos += 28;
					}
					if (sdesc.IsNPC) 
					{
						g.FillRectangle(new SolidBrush(Data.MetaData.NPCSim), pos, 2, 25, 25);
						pos += 28;
					}

					this.ilist.Images.Add(img);
					this.iListSmall.Images.Add(ImageLoader.Preview(img, iListSmall.ImageSize));
				} 				
				else 
				{
					this.ilist.Images.Add(sdesc.Image);
					this.iListSmall.Images.Add(ImageLoader.Preview(sdesc.Image, iListSmall.ImageSize));
				}
			} 
			else 
			{
				//this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")));
				//this.iListSmall.Images.Add(ImageLoader.Preview(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")), iListSmall.ImageSize));
                this.ilist.Images.Add(new Bitmap(sdesc.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png")));
                this.iListSmall.Images.Add(ImageLoader.Preview(new Bitmap(sdesc.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png")), iListSmall.ImageSize));
            }
		}

		protected void AddSim(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc) 
		{
			//if (!sdesc.HasImage) return;

			AddImage(sdesc);
			ListViewItem lvi = new ListViewItem();
			lvi.Text = sdesc.SimName +" "+sdesc.SimFamilyName;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.Tag = sdesc;

			lvi.SubItems.Add(sdesc.HouseholdName);
            if (sdesc.University.OnCampus == 0x1)
                lvi.SubItems.Add(Localization.Manager.GetString("YoungAdult"));
            else
                lvi.SubItems.Add(new Data.LocalizedLifeSections(sdesc.CharacterDescription.LifeSection).ToString());

			string kind = "";
            if (realIsNPC(sdesc)) kind = "NPC";
            else if (realIsTownie(sdesc)) kind = "Townie";
            else if (realIsPlayable(sdesc)) kind = "Playable";
            else if (realIsUneditable(sdesc)) kind = "Uneditable";
            lvi.SubItems.Add(kind);

			if (sdesc.University.OnCampus==0x1) lvi.SubItems.Add(Localization.Manager.GetString("yes")); else lvi.SubItems.Add(Localization.Manager.GetString("no"));
			lvi.SubItems.Add("0x"+Helper.HexString(sdesc.FileDescriptor.Instance));

			string avl = "";
			if (!sdesc.AvailableCharacterData) avl += "no Character File";
			if (sdesc.Unlinked!=0x00) 
			{
				if (avl!="") avl+=", ";
				avl += "Unlinked";
			}
			if (avl=="") avl="OK";
			lvi.SubItems.Add(avl);
			lvi.SubItems.Add("0x"+Helper.HexString(sdesc.SimId));

			if (System.IO.File.Exists(sdesc.CharacterFileName)) 
			{
				System.IO.Stream s = System.IO.File.OpenRead(sdesc.CharacterFileName);
				double sz = s.Length / 1024.0;				
				s.Close();
				s.Dispose();
				s = null;
				lvi.SubItems.Add(System.IO.Path.GetFileNameWithoutExtension(sdesc.CharacterFileName));
				lvi.SubItems.Add(sz.ToString("N2")+"kb");
			} 
			else 
			{
				lvi.SubItems.Add("---");
				lvi.SubItems.Add("---");
			}
		
			
			//toolTip1.SetToolTip(lvi, sdesc.CharacterFileName);
			lv.Items.Add(lvi);
		}

		protected void FillList()
		{
            this.Cursor = Cursors.WaitCursor;
            ilist.Images.Clear();
			this.iListSmall.Images.Clear();
			lv.BeginUpdate();
			lv.Items.Clear();
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			foreach(Interfaces.Files.IPackedFileDescriptor spfd in pfds) 
			{
				WaitingScreen.Wait();
				PackedFiles.Wrapper.ExtSDesc sdesc = new SimPe.PackedFiles.Wrapper.ExtSDesc();
				sdesc.ProcessData(spfd, package);

                bool doAdd = false;
                doAdd |= (this.cbNpc.Checked && realIsNPC(sdesc));
                doAdd |= (this.cbTownie.Checked && realIsTownie(sdesc));
                doAdd |= (this.ckbPlayable.Checked && realIsPlayable(sdesc));
                doAdd |= (this.ckbUnEditable.Checked && realIsUneditable(sdesc));
                
                //WaitingScreen.UpdateImage(ImageLoader.Preview(sdesc.Image, new Size(64, 64)));
				if (doAdd) AddSim(sdesc);
			}

			sorter.Sorting = lv.Sorting;
			lv.Sort();

			lv.EndUpdate();
			WaitingScreen.Stop(this);
            this.Cursor = Cursors.Default;
        }

        private bool realIsNPC(PackedFiles.Wrapper.ExtSDesc sdesc)
        {
            return sdesc.FamilyInstance == 0x7fff;
            /*if (sdesc.IsNPC) return true;
            if (sdesc.CharacterDescription.NPCType == 0) return false;
            if (sdesc.FamilyInstance != 0x7fff) return false;
            return true;*/
        }

        private bool realIsTownie(PackedFiles.Wrapper.ExtSDesc sdesc)
        {
            return sdesc.FamilyInstance < 0x7fff && sdesc.FamilyInstance >= 0x7fe0;
            /*return sdesc.IsTownie;*/
        }

        private bool realIsPlayable(PackedFiles.Wrapper.ExtSDesc sdesc)
        {
            return sdesc.FamilyInstance < 0x7fe0 && sdesc.FamilyInstance > 0;
            /*return !realIsNPC(sdesc) && !realIsTownie(sdesc);*/
        }

        private bool realIsUneditable(PackedFiles.Wrapper.ExtSDesc sdesc)
        {
            return sdesc.FamilyInstance == 0;
        }

		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		SimPe.Interfaces.Files.IPackageFile package;
		public Interfaces.Plugin.IToolResult Execute(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov) 
		{
			this.package = package;
			
			lv.ListViewItemSorter = sorter;
			this.Cursor = Cursors.WaitCursor;
			
			SimPe.Plugin.Idno idno = SimPe.Plugin.Idno.FromPackage(package);
			if (idno!=null) this.lbUbi.Visible = (idno.Type != NeighborhoodType.Normal );
			this.pfd = null;
			
			
			lv.Sorting = SortOrder.Ascending;
			sorter.CurrentColumn = 3;

			FillList();
			
			this.Cursor = Cursors.Default;
			
			RemoteControl.ShowSubForm(this);

			this.package = null;

			if (this.pfd!=null) pfd = this.pfd;
			return new Plugin.ToolResult((this.pfd!=null), false);
		}

		private void Open(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<1) return;
			
			pfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)((PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag).FileDescriptor;
			Close();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbdetail.Checked) lv.View = View.Details;
			else lv.View = View.LargeIcon;
		}

		internal ColumnSorter sorter;
		private void SortList(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if (sorter.CurrentColumn == e.Column) 
			{				
				if (lv.Sorting == SortOrder.Ascending) lv.Sorting = SortOrder.Descending;
				else lv.Sorting = SortOrder.Ascending;
			} 
			else 
			{
				sorter.CurrentColumn = e.Column;
				lv.ListViewItemSorter = sorter;
			}
			sorter.Sorting = lv.Sorting;
			lv.Sort();
		}

        private void ckbFilter_CheckedChanged(object sender, System.EventArgs e)
        {
            if (package != null)
                this.FillList();
        }
	}
}
