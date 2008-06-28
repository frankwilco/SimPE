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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin.TabPage
{
	/// <summary>
	/// Zusammenfassung für MatdForm.
	/// </summary>
	public class MatdForm : 
		System.Windows.Forms.TabPage
		//System.Windows.Forms.UserControl
    {
        #region Form variables
        internal System.Windows.Forms.ListBox lbprop;
        internal System.Windows.Forms.GroupBox gbprop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbval;
        private System.Windows.Forms.LinkLabel lladd;
        internal System.Windows.Forms.LinkLabel lldel;
        private System.Windows.Forms.LinkLabel llscan;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Button btnImport;
        private Button btnExport;
        private Button btnMerge;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        /// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public MatdForm()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

            btnExport.Left = gbprop.Left;
            btnImport.Left = btnExport.Right + 12;
            btnMerge.Left = btnImport.Right + 12;
            btnExport.Top = btnImport.Top = btnMerge.Top = gbprop.Bottom + 12;

            llscan.Visible = Helper.DebugMode;

            this.UseVisualStyleBackColor = true;
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				Tag = null;
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
            this.llscan = new System.Windows.Forms.LinkLabel();
            this.lbprop = new System.Windows.Forms.ListBox();
            this.gbprop = new System.Windows.Forms.GroupBox();
            this.lldel = new System.Windows.Forms.LinkLabel();
            this.lladd = new System.Windows.Forms.LinkLabel();
            this.tbval = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbprop.SuspendLayout();
            this.SuspendLayout();
            // 
            // llscan
            // 
            this.llscan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llscan.Location = new System.Drawing.Point(432, 208);
            this.llscan.Name = "llscan";
            this.llscan.Size = new System.Drawing.Size(100, 23);
            this.llscan.TabIndex = 5;
            this.llscan.TabStop = true;
            this.llscan.Text = "scan";
            this.llscan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llscan_LinkClicked);
            // 
            // lbprop
            // 
            this.lbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbprop.IntegralHeight = false;
            this.lbprop.Location = new System.Drawing.Point(8, 8);
            this.lbprop.Name = "lbprop";
            this.lbprop.Size = new System.Drawing.Size(416, 224);
            this.lbprop.TabIndex = 3;
            this.lbprop.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            // 
            // gbprop
            // 
            this.gbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbprop.Controls.Add(this.lldel);
            this.gbprop.Controls.Add(this.lladd);
            this.gbprop.Controls.Add(this.tbval);
            this.gbprop.Controls.Add(this.tbname);
            this.gbprop.Controls.Add(this.label2);
            this.gbprop.Controls.Add(this.label1);
            this.gbprop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbprop.Location = new System.Drawing.Point(432, 8);
            this.gbprop.Name = "gbprop";
            this.gbprop.Size = new System.Drawing.Size(296, 104);
            this.gbprop.TabIndex = 4;
            this.gbprop.TabStop = false;
            this.gbprop.Text = "Property";
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.AutoSize = true;
            this.btnExport.Location = new System.Drawing.Point(354, 180);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 27);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export...";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.AutoSize = true;
            this.btnImport.Location = new System.Drawing.Point(390, 180);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 27);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "Import...";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerge.AutoSize = true;
            this.btnMerge.Location = new System.Drawing.Point(318, 180);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 27);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "Merge...";
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // lldel
            // 
            this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lldel.AutoSize = true;
            this.lldel.Location = new System.Drawing.Point(244, 80);
            this.lldel.Name = "lldel";
            this.lldel.Size = new System.Drawing.Size(55, 17);
            this.lldel.TabIndex = 5;
            this.lldel.TabStop = true;
            this.lldel.Text = "delete";
            this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletItem);
            // 
            // lladd
            // 
            this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lladd.AutoSize = true;
            this.lladd.Location = new System.Drawing.Point(208, 80);
            this.lladd.Name = "lladd";
            this.lladd.Size = new System.Drawing.Size(37, 17);
            this.lladd.TabIndex = 4;
            this.lladd.TabStop = true;
            this.lladd.Text = "add";
            this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddItem);
            // 
            // tbval
            // 
            this.tbval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbval.Location = new System.Drawing.Point(64, 48);
            this.tbval.Name = "tbval";
            this.tbval.Size = new System.Drawing.Size(224, 24);
            this.tbval.TabIndex = 3;
            this.tbval.TextChanged += new System.EventHandler(this.AutoChange);
            // 
            // tbname
            // 
            this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbname.Location = new System.Drawing.Point(64, 24);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(224, 24);
            this.tbname.TabIndex = 2;
            this.tbname.TextChanged += new System.EventHandler(this.AutoChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(432, 184);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "sort List";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "Material Definition Properties (xml)|*.xml";
            this.saveFileDialog1.Title = "Export Material Definition Properties";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "xml";
            this.openFileDialog1.Filter = "Material Definition Properties (xml)|*.xml|All files|*.*";
            this.openFileDialog1.Title = "Material Definition Properties";
            // 
            // MatdForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.llscan);
            this.Controls.Add(this.lbprop);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.gbprop);
            this.Controls.Add(this.linkLabel1);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "tMaterialDefinition";
            this.Size = new System.Drawing.Size(744, 238);
            this.Text = "Properties";
            this.gbprop.ResumeLayout(false);
            this.gbprop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		protected void Change()
		{
			if (this.Tag==null) return;
			if (this.lbprop.SelectedIndex<0) return;
			try 
			{
				tbname.Tag = true;								
				SimPe.Plugin.MaterialDefinitionProperty prop = (SimPe.Plugin.MaterialDefinitionProperty)lbprop.Items[lbprop.SelectedIndex];

				prop.Name = tbname.Text;
				prop.Value = tbval.Text;

				lbprop.Items[lbprop.SelectedIndex] = prop;

				SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
				md.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.Tag==null) return;
			
			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			md.Sort();
			md.Refresh();
		}

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbname.Tag!=null) return;
			if (this.lbprop.SelectedIndex>=0) Change();

		}

		private void SelectItem(object sender, System.EventArgs e)
		{
			lldel.Enabled = false;
			if (lbprop.SelectedIndex<0) return;
			lldel.Enabled = true;

			try 
			{
				tbname.Tag = true;
				SimPe.Plugin.MaterialDefinitionProperty prop = (SimPe.Plugin.MaterialDefinitionProperty)lbprop.Items[lbprop.SelectedIndex];
				this.tbname.Text = prop.Name;
				this.tbval.Text = prop.Value;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.Tag==null) return;
			SimPe.Plugin.MaterialDefinitionProperty prop = new MaterialDefinitionProperty();
			lbprop.Items.Add(prop);

			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			md.Properties = (MaterialDefinitionProperty[])Helper.Add(md.Properties, prop);

			md.Changed = true;
		}

		private void DeletItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.Tag==null) return;
			if (lbprop.SelectedIndex<0) return;

			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			md.Properties = (MaterialDefinitionProperty[])Helper.Delete(md.Properties, lbprop.Items[lbprop.SelectedIndex]);
			md.Changed = true;
			lbprop.Items.Remove(lbprop.Items[lbprop.SelectedIndex]);

			
		}		

		private void llscan_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
#if DEBUG
			FileTable.FileIndex.Load();

			System.IO.StreamWriter sw = System.IO.File.CreateText(@"G:\txmt.txt");
			Hashtable ht = new Hashtable();
			FileTable.FileIndex.AddIndexFromFolder(@":G:\EA Games\Die Sims 2\");
			try 
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.TXMT, true);
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
				{
                    Rcol txmt = new SimPe.Plugin.GenericRcol(null, false);
					txmt.ProcessData(item);
                    SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)txmt.Blocks[0];
					foreach (MaterialDefinitionProperty mdp in md.Properties) 
					{
						if (!ht.ContainsKey(mdp.Name)) ht.Add(mdp.Name, "| " + mdp.Value + " | ");
						else 
						{
							string s = (string)ht[mdp.Name];
							if (s.IndexOf("| "+mdp.Value+" |")==-1) 
							{
								s += mdp.Value + " | ";
								ht[mdp.Name] = s;
							}
						}
					}
				}

				
				

				foreach (string k in ht.Keys) 
				{
					//if (!MaterialDefinition.PropertyParser.Properties.ContainsKey(k)) 
					{
						string v = (string)ht[k];
						string[] parts = v.Split("|".ToCharArray(), 3);
						sw.Write(k+"; ");
						sw.WriteLine((string)ht[k]);						
					}
			}
			} 
			finally 
			{
				sw.Close();
				sw.Dispose();
				sw = null;
			}
#endif
		}

		internal void TxmtChangeTab(object sender, System.EventArgs e)
		{
			if (this.Tag==null) return;
			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			if (Parent==null) return;			
			if (((TabControl)Parent).SelectedTab == this) 
			{
				md.Refresh();
			}
		}

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (this.Tag == null) return;

            saveFileDialog1.FileName = "";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr != DialogResult.OK) return;

            SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
            md.ExportProperties(saveFileDialog1.FileName);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            do_imp_mrg(true);
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            do_imp_mrg(false);
        }

        private void do_imp_mrg(bool imp)
        {
            if (this.Tag == null) return;

            openFileDialog1.FileName = "";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr != DialogResult.OK) return;

            SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
            if (imp) md.ImportProperties(openFileDialog1.FileName);
            else md.MergeProperties(openFileDialog1.FileName);
            md.Refresh();
        }
    }
}
