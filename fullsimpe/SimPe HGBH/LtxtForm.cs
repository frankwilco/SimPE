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
	/// Zusammenfassung für LtxtForm.
	/// </summary>
	public class LtxtForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel ltxtPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox tblotname;
		internal System.Windows.Forms.TextBox tbhousename;
		internal System.Windows.Forms.TextBox tbname;
		internal System.Windows.Forms.TextBox tbdata;
		internal System.Windows.Forms.TextBox tblotinst;
		internal System.Windows.Forms.ComboBox cbtype;
		internal System.Windows.Forms.TextBox tbhouseinst;
		internal System.Windows.Forms.TextBox tbtype;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LtxtForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			wrapper = null;
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
			this.ltxtPanel = new System.Windows.Forms.Panel();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.tbhouseinst = new System.Windows.Forms.TextBox();
			this.tblotinst = new System.Windows.Forms.TextBox();
			this.tbdata = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.tbhousename = new System.Windows.Forms.TextBox();
			this.tblotname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.ltxtPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ltxtPanel
			// 
			this.ltxtPanel.AutoScroll = true;
			this.ltxtPanel.Controls.Add(this.tbtype);
			this.ltxtPanel.Controls.Add(this.cbtype);
			this.ltxtPanel.Controls.Add(this.tbhouseinst);
			this.ltxtPanel.Controls.Add(this.tblotinst);
			this.ltxtPanel.Controls.Add(this.tbdata);
			this.ltxtPanel.Controls.Add(this.tbname);
			this.ltxtPanel.Controls.Add(this.tbhousename);
			this.ltxtPanel.Controls.Add(this.tblotname);
			this.ltxtPanel.Controls.Add(this.label7);
			this.ltxtPanel.Controls.Add(this.label6);
			this.ltxtPanel.Controls.Add(this.label5);
			this.ltxtPanel.Controls.Add(this.label4);
			this.ltxtPanel.Controls.Add(this.label3);
			this.ltxtPanel.Controls.Add(this.label2);
			this.ltxtPanel.Controls.Add(this.label1);
			this.ltxtPanel.Controls.Add(this.button1);
			this.ltxtPanel.Controls.Add(this.panel2);
			this.ltxtPanel.Location = new System.Drawing.Point(16, 8);
			this.ltxtPanel.Name = "ltxtPanel";
			this.ltxtPanel.Size = new System.Drawing.Size(652, 232);
			this.ltxtPanel.TabIndex = 20;
			// 
			// tbtype
			// 
			this.tbtype.Location = new System.Drawing.Point(252, 88);
			this.tbtype.Name = "tbtype";
			this.tbtype.ReadOnly = true;
			this.tbtype.Size = new System.Drawing.Size(48, 21);
			this.tbtype.TabIndex = 18;
			this.tbtype.Text = "0x00";
			// 
			// cbtype
			// 
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Location = new System.Drawing.Point(136, 88);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(112, 21);
			this.cbtype.TabIndex = 17;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.SelectType);
			// 
			// tbhouseinst
			// 
			this.tbhouseinst.Location = new System.Drawing.Point(136, 64);
			this.tbhouseinst.Name = "tbhouseinst";
			this.tbhouseinst.Size = new System.Drawing.Size(48, 21);
			this.tbhouseinst.TabIndex = 16;
			this.tbhouseinst.Text = "0x00";
			this.tbhouseinst.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tblotinst
			// 
			this.tblotinst.Location = new System.Drawing.Point(136, 40);
			this.tblotinst.Name = "tblotinst";
			this.tblotinst.Size = new System.Drawing.Size(48, 21);
			this.tblotinst.TabIndex = 15;
			this.tblotinst.Text = "0x00";
			this.tblotinst.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbdata
			// 
			this.tbdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbdata.Location = new System.Drawing.Point(328, 56);
			this.tbdata.Multiline = true;
			this.tbdata.Name = "tbdata";
			this.tbdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbdata.Size = new System.Drawing.Size(312, 48);
			this.tbdata.TabIndex = 14;
			this.tbdata.Text = "";
			this.tbdata.TextChanged += new System.EventHandler(this.ChangeData);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Location = new System.Drawing.Point(160, 168);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(480, 21);
			this.tbname.TabIndex = 13;
			this.tbname.Text = "";
			this.tbname.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbhousename
			// 
			this.tbhousename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbhousename.Location = new System.Drawing.Point(160, 144);
			this.tbhousename.Name = "tbhousename";
			this.tbhousename.Size = new System.Drawing.Size(480, 21);
			this.tbhousename.TabIndex = 12;
			this.tbhousename.Text = "";
			this.tbhousename.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tblotname
			// 
			this.tblotname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tblotname.Location = new System.Drawing.Point(160, 120);
			this.tblotname.Name = "tblotname";
			this.tblotname.Size = new System.Drawing.Size(480, 21);
			this.tblotname.TabIndex = 11;
			this.tblotname.Text = "";
			this.tblotname.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(320, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(102, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Unknown Data:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(48, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Unknown Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(64, 152);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "House Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 128);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lot Name (Address):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(21, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(108, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "House Instance:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Lot Instance:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(66, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Lot Type:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(565, 199);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Commit";
			this.button1.Click += new System.EventHandler(this.Commit);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.label27);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(652, 24);
			this.panel2.TabIndex = 0;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(169, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Lot Description Editor";
			// 
			// LtxtForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(864, 318);
			this.Controls.Add(this.ltxtPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LtxtForm";
			this.Text = "LtxtForm";
			this.ltxtPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Ltxt wrapper;

		private void SelectType(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			if (cbtype.SelectedIndex>0) tbtype.Text = "0x"+Helper.HexString((byte)((Ltxt.LotType)cbtype.Items[cbtype.SelectedIndex]));
			try 
			{
				wrapper.Type = (Ltxt.LotType)Convert.ToByte(tbtype.Text, 16);
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Commit(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void CommonChange(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.LotInstance = Convert.ToByte(this.tblotinst.Text, 16);
				wrapper.HouseInstance = Convert.ToByte(this.tbhouseinst.Text, 16);

				wrapper.LotName = tblotname.Text;
				wrapper.HouseName = tbhousename.Text;
				wrapper.Name = tbname.Text;

				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void ChangeData(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.Unknown = Helper.SetLength(Helper.HexListToBytes(this.tbdata.Text), 0x55);
				
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}
	}
}
