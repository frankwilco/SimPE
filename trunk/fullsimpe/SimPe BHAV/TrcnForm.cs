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
using SimPe.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TrcnForm.
	/// </summary>
	public class TrcnForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public TrcnForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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
			this.TrcnPanel = new System.Windows.Forms.Panel();
			this.btcommit = new System.Windows.Forms.Button();
			this.gbprop = new System.Windows.Forms.GroupBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.tbval = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbprop = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbTrcn = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.TrcnPanel.SuspendLayout();
			this.gbprop.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// TrcnPanel
			// 
			this.TrcnPanel.Controls.Add(this.btcommit);
			this.TrcnPanel.Controls.Add(this.gbprop);
			this.TrcnPanel.Controls.Add(this.lbprop);
			this.TrcnPanel.Controls.Add(this.panel2);
			this.TrcnPanel.Location = new System.Drawing.Point(8, 8);
			this.TrcnPanel.Name = "TrcnPanel";
			this.TrcnPanel.Size = new System.Drawing.Size(768, 232);
			this.TrcnPanel.TabIndex = 20;
			// 
			// btcommit
			// 
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btcommit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btcommit.Location = new System.Drawing.Point(685, 140);
			this.btcommit.Name = "btcommit";
			this.btcommit.TabIndex = 5;
			this.btcommit.Text = "Commit";
			this.btcommit.Click += new System.EventHandler(this.Commit);
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
			this.gbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbprop.Location = new System.Drawing.Point(464, 32);
			this.gbprop.Name = "gbprop";
			this.gbprop.Size = new System.Drawing.Size(296, 104);
			this.gbprop.TabIndex = 4;
			this.gbprop.TabStop = false;
			this.gbprop.Text = "Properties";
			// 
			// lldel
			// 
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lldel.AutoSize = true;
			this.lldel.Location = new System.Drawing.Point(244, 80);
			this.lldel.Name = "lldel";
			this.lldel.Size = new System.Drawing.Size(44, 17);
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
			this.lladd.Size = new System.Drawing.Size(28, 17);
			this.lladd.TabIndex = 4;
			this.lladd.TabStop = true;
			this.lladd.Text = "add";
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddItem);
			// 
			// tbval
			// 
			this.tbval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbval.Location = new System.Drawing.Point(64, 48);
			this.tbval.Name = "tbval";
			this.tbval.Size = new System.Drawing.Size(224, 21);
			this.tbval.TabIndex = 3;
			this.tbval.Text = "";
			this.tbval.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(64, 24);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(224, 21);
			this.tbname.TabIndex = 2;
			this.tbname.Text = "";
			this.tbname.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Line:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// lbprop
			// 
			this.lbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbprop.IntegralHeight = false;
			this.lbprop.Location = new System.Drawing.Point(8, 32);
			this.lbprop.Name = "lbprop";
			this.lbprop.Size = new System.Drawing.Size(448, 192);
			this.lbprop.TabIndex = 3;
			this.lbprop.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.lbTrcn);
			this.panel2.Controls.Add(this.label27);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 24);
			this.panel2.TabIndex = 0;
			// 
			// lbTrcn
			// 
			this.lbTrcn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbTrcn.AutoSize = true;
			this.lbTrcn.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.lbTrcn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbTrcn.Location = new System.Drawing.Point(104, 8);
			this.lbTrcn.Name = "lbTrcn";
			this.lbTrcn.Size = new System.Drawing.Size(42, 17);
			this.lbTrcn.TabIndex = 3;
			this.lbTrcn.Text = "no File";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(88, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Trcn Editor";
			// 
			// TrcnForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 246);
			this.Controls.Add(this.TrcnPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "TrcnForm";
			this.Text = "TrcnForm";
			this.TrcnPanel.ResumeLayout(false);
			this.gbprop.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.Panel TrcnPanel;
		internal System.Windows.Forms.ListBox lbprop;
		private System.Windows.Forms.Panel panel2;
		internal System.Windows.Forms.Label lbTrcn;
		private System.Windows.Forms.Label label27;
		internal System.Windows.Forms.GroupBox gbprop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.LinkLabel lladd;
		internal System.Windows.Forms.LinkLabel lldel;
		private System.Windows.Forms.Button btcommit;

		internal IFileWrapperSaveExtension wrapper;

		private void SelectItem(object sender, System.EventArgs e)
		{
			lldel.Enabled = false;
			if (lbprop.SelectedIndex<0) return;
			lldel.Enabled = true;

			try 
			{
				tbname.Tag = true;
				TrcnItem prop = (TrcnItem)lbprop.Items[lbprop.SelectedIndex];
				this.tbname.Text = prop.Name;
				this.tbval.Text = "0x"+Helper.HexString((uint)(prop.LineNumber-1));
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

		protected void Change()
		{
			try 
			{
				tbname.Tag = true;
				SimPe.Plugin.TrcnItem prop;
				if (this.lbprop.SelectedIndex<0) prop = new TrcnItem((Trcn)wrapper);
				else prop = (SimPe.Plugin.TrcnItem)lbprop.Items[lbprop.SelectedIndex];

				prop.Name = tbname.Text;
				prop.LineNumber = Convert.ToInt32(tbval.Text, 16)+1;

				if (this.lbprop.SelectedIndex<0) lbprop.Items.Add(prop);
				else lbprop.Items[lbprop.SelectedIndex] = prop;

				wrapper.Changed = true;
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

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbname.Tag!=null) return;
			if (this.lbprop.SelectedIndex>=0) Change();

		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbprop.SelectedIndex = -1;
			Change();
			lbprop.SelectedIndex = lbprop.Items.Count-1;
		}

		private void DeletItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbprop.SelectedIndex<0) return;
			lbprop.Items.Remove(lbprop.Items[lbprop.SelectedIndex]);
			wrapper.Changed = true;
		}

		private void Commit(object sender, System.EventArgs e)
		{
			try 
			{
				Trcn wrp = (Trcn)wrapper;
				SimPe.Plugin.TrcnItem[] items = new TrcnItem[lbprop.Items.Count];

				for (int i=0; i<items.Length; i++)
				{
					items[i] = (SimPe.Plugin.TrcnItem)lbprop.Items[i];
				}

				wrp.Labels = items;
				wrp.SynchronizeUserData();

				MessageBox.Show(Localization.Manager.GetString("commited"));
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}
	}
}
