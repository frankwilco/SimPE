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
	/// Zusammenfassung für WantsForm.
	/// </summary>
	public class WantsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		internal System.Windows.Forms.Panel wantsPanel;
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tblife;
		private System.Windows.Forms.TabPage tbwant;
		private System.Windows.Forms.TabPage tbfear;
		private System.Windows.Forms.TabPage tbhist;
		internal System.Windows.Forms.ImageList iwant;
		internal System.Windows.Forms.ImageList ifear;
		internal System.Windows.Forms.ImageList ihist;
		internal System.Windows.Forms.ImageList ilife;
		internal System.Windows.Forms.ListView lvwant;
		internal System.Windows.Forms.ListView lvfear;
		internal System.Windows.Forms.ListView lvlife;
		internal System.Windows.Forms.TreeView tvhist;
		internal System.Windows.Forms.Label lbsimname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbversion;
		private System.Windows.Forms.TextBox tbguid;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.TextBox tbprop;
		private System.Windows.Forms.TextBox tbsiminst;
		private System.Windows.Forms.TextBox tbindex;
		private System.Windows.Forms.TextBox tbunknown1;
		internal System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.TextBox tbunknown2;
		private System.Windows.Forms.TextBox tbpoints;
		private System.Windows.Forms.GroupBox gbprop;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.TreeView tv;
		internal System.Windows.Forms.ImageList itv;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.CheckBox cblock;
		private System.Windows.Forms.ComboBox cbsel;
		private System.ComponentModel.IContainer components;

		public WantsForm()
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
			this.components = new System.ComponentModel.Container();
			this.wantsPanel = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.gbprop = new System.Windows.Forms.GroupBox();
			this.cblock = new System.Windows.Forms.CheckBox();
			this.tv = new System.Windows.Forms.TreeView();
			this.itv = new System.Windows.Forms.ImageList(this.components);
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.tbpoints = new System.Windows.Forms.TextBox();
			this.tbunknown2 = new System.Windows.Forms.TextBox();
			this.tbunknown1 = new System.Windows.Forms.TextBox();
			this.tbindex = new System.Windows.Forms.TextBox();
			this.tbsiminst = new System.Windows.Forms.TextBox();
			this.tbprop = new System.Windows.Forms.TextBox();
			this.tbval = new System.Windows.Forms.TextBox();
			this.tbguid = new System.Windows.Forms.TextBox();
			this.tbversion = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tbwant = new System.Windows.Forms.TabPage();
			this.lvwant = new System.Windows.Forms.ListView();
			this.iwant = new System.Windows.Forms.ImageList(this.components);
			this.tbfear = new System.Windows.Forms.TabPage();
			this.lvfear = new System.Windows.Forms.ListView();
			this.ifear = new System.Windows.Forms.ImageList(this.components);
			this.tbhist = new System.Windows.Forms.TabPage();
			this.tvhist = new System.Windows.Forms.TreeView();
			this.ihist = new System.Windows.Forms.ImageList(this.components);
			this.tblife = new System.Windows.Forms.TabPage();
			this.lvlife = new System.Windows.Forms.ListView();
			this.ilife = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbsimname = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.cbsel = new System.Windows.Forms.ComboBox();
			this.wantsPanel.SuspendLayout();
			this.gbprop.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tbwant.SuspendLayout();
			this.tbfear.SuspendLayout();
			this.tbhist.SuspendLayout();
			this.tblife.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// wantsPanel
			// 
			this.wantsPanel.AutoScroll = true;
			this.wantsPanel.Controls.Add(this.linkLabel1);
			this.wantsPanel.Controls.Add(this.gbprop);
			this.wantsPanel.Controls.Add(this.tabControl1);
			this.wantsPanel.Controls.Add(this.panel2);
			this.wantsPanel.Location = new System.Drawing.Point(16, 8);
			this.wantsPanel.Name = "wantsPanel";
			this.wantsPanel.Size = new System.Drawing.Size(768, 344);
			this.wantsPanel.TabIndex = 20;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(707, 319);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(53, 17);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Commit";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Commit);
			// 
			// gbprop
			// 
			this.gbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gbprop.Controls.Add(this.cbsel);
			this.gbprop.Controls.Add(this.cblock);
			this.gbprop.Controls.Add(this.tv);
			this.gbprop.Controls.Add(this.cbtype);
			this.gbprop.Controls.Add(this.tbpoints);
			this.gbprop.Controls.Add(this.tbunknown2);
			this.gbprop.Controls.Add(this.tbunknown1);
			this.gbprop.Controls.Add(this.tbindex);
			this.gbprop.Controls.Add(this.tbsiminst);
			this.gbprop.Controls.Add(this.tbprop);
			this.gbprop.Controls.Add(this.tbval);
			this.gbprop.Controls.Add(this.tbguid);
			this.gbprop.Controls.Add(this.tbversion);
			this.gbprop.Controls.Add(this.label10);
			this.gbprop.Controls.Add(this.label9);
			this.gbprop.Controls.Add(this.label8);
			this.gbprop.Controls.Add(this.label7);
			this.gbprop.Controls.Add(this.label6);
			this.gbprop.Controls.Add(this.label4);
			this.gbprop.Controls.Add(this.label3);
			this.gbprop.Controls.Add(this.label2);
			this.gbprop.Controls.Add(this.label1);
			this.gbprop.Controls.Add(this.pb);
			this.gbprop.Controls.Add(this.label5);
			this.gbprop.Enabled = false;
			this.gbprop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbprop.Location = new System.Drawing.Point(336, 32);
			this.gbprop.Name = "gbprop";
			this.gbprop.Size = new System.Drawing.Size(424, 284);
			this.gbprop.TabIndex = 2;
			this.gbprop.TabStop = false;
			this.gbprop.Text = "Properties:";
			// 
			// cblock
			// 
			this.cblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cblock.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cblock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cblock.Location = new System.Drawing.Point(272, 184);
			this.cblock.Name = "cblock";
			this.cblock.Size = new System.Drawing.Size(72, 24);
			this.cblock.TabIndex = 22;
			this.cblock.Text = "Locked:";
			this.cblock.CheckedChanged += new System.EventHandler(this.ChangedText);
			// 
			// tv
			// 
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tv.HideSelection = false;
			this.tv.ImageList = this.itv;
			this.tv.Location = new System.Drawing.Point(8, 80);
			this.tv.Name = "tv";
			this.tv.Size = new System.Drawing.Size(224, 168);
			this.tv.TabIndex = 21;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectWant);
			// 
			// itv
			// 
			this.itv.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.itv.ImageSize = new System.Drawing.Size(16, 16);
			this.itv.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// cbtype
			// 
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = false;
			this.cbtype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbtype.Location = new System.Drawing.Point(56, 256);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(88, 21);
			this.cbtype.TabIndex = 19;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.ChangeType);
			// 
			// tbpoints
			// 
			this.tbpoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbpoints.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbpoints.Location = new System.Drawing.Point(328, 160);
			this.tbpoints.Name = "tbpoints";
			this.tbpoints.Size = new System.Drawing.Size(88, 21);
			this.tbpoints.TabIndex = 18;
			this.tbpoints.Text = "0";
			this.tbpoints.TextChanged += new System.EventHandler(this.ChangedText);
			// 
			// tbunknown2
			// 
			this.tbunknown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbunknown2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbunknown2.Location = new System.Drawing.Point(328, 136);
			this.tbunknown2.Name = "tbunknown2";
			this.tbunknown2.Size = new System.Drawing.Size(88, 21);
			this.tbunknown2.TabIndex = 17;
			this.tbunknown2.Text = "0";
			this.tbunknown2.TextChanged += new System.EventHandler(this.ChangedText);
			// 
			// tbunknown1
			// 
			this.tbunknown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbunknown1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbunknown1.Location = new System.Drawing.Point(328, 104);
			this.tbunknown1.Name = "tbunknown1";
			this.tbunknown1.ReadOnly = true;
			this.tbunknown1.Size = new System.Drawing.Size(56, 21);
			this.tbunknown1.TabIndex = 16;
			this.tbunknown1.Text = "0x00";
			// 
			// tbindex
			// 
			this.tbindex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbindex.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbindex.Location = new System.Drawing.Point(328, 80);
			this.tbindex.Name = "tbindex";
			this.tbindex.ReadOnly = true;
			this.tbindex.Size = new System.Drawing.Size(88, 21);
			this.tbindex.TabIndex = 15;
			this.tbindex.Text = "0x00000000";
			// 
			// tbsiminst
			// 
			this.tbsiminst.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbsiminst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbsiminst.Location = new System.Drawing.Point(328, 48);
			this.tbsiminst.Name = "tbsiminst";
			this.tbsiminst.ReadOnly = true;
			this.tbsiminst.Size = new System.Drawing.Size(56, 21);
			this.tbsiminst.TabIndex = 14;
			this.tbsiminst.Text = "0x0000";
			// 
			// tbprop
			// 
			this.tbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbprop.Location = new System.Drawing.Point(328, 232);
			this.tbprop.Name = "tbprop";
			this.tbprop.Size = new System.Drawing.Size(88, 21);
			this.tbprop.TabIndex = 13;
			this.tbprop.Text = "0";
			this.tbprop.TextChanged += new System.EventHandler(this.ChangedText);
			// 
			// tbval
			// 
			this.tbval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.tbval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbval.Location = new System.Drawing.Point(328, 256);
			this.tbval.Name = "tbval";
			this.tbval.Size = new System.Drawing.Size(88, 21);
			this.tbval.TabIndex = 12;
			this.tbval.Text = "0x00000000";
			this.tbval.TextChanged += new System.EventHandler(this.ChangedText);
			// 
			// tbguid
			// 
			this.tbguid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbguid.Location = new System.Drawing.Point(88, 56);
			this.tbguid.Name = "tbguid";
			this.tbguid.ReadOnly = true;
			this.tbguid.Size = new System.Drawing.Size(88, 21);
			this.tbguid.TabIndex = 11;
			this.tbguid.Text = "0x00000000";
			// 
			// tbversion
			// 
			this.tbversion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbversion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbversion.Location = new System.Drawing.Point(328, 24);
			this.tbversion.Name = "tbversion";
			this.tbversion.ReadOnly = true;
			this.tbversion.Size = new System.Drawing.Size(88, 21);
			this.tbversion.TabIndex = 10;
			this.tbversion.Text = "0x00000000";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(248, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(72, 24);
			this.label10.TabIndex = 9;
			this.label10.Text = "Influence:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(248, 104);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(72, 24);
			this.label9.TabIndex = 8;
			this.label9.Text = "Flags:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(264, 160);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 24);
			this.label8.TabIndex = 7;
			this.label8.Text = "Points:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(272, 80);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(48, 24);
			this.label7.TabIndex = 6;
			this.label7.Text = "Index:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(248, 232);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 24);
			this.label6.TabIndex = 5;
			this.label6.Text = "Amount:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 256);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Type:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Want GUID:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(232, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Sim Inst.:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(224, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Version:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pb
			// 
			this.pb.Location = new System.Drawing.Point(184, 24);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(56, 56);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pb.TabIndex = 20;
			this.pb.TabStop = false;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(144, 256);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Value:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.tabControl1.Controls.Add(this.tbwant);
			this.tabControl1.Controls.Add(this.tbfear);
			this.tabControl1.Controls.Add(this.tbhist);
			this.tabControl1.Controls.Add(this.tblife);
			this.tabControl1.Location = new System.Drawing.Point(8, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 304);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.SelectTab);
			// 
			// tbwant
			// 
			this.tbwant.Controls.Add(this.lvwant);
			this.tbwant.Location = new System.Drawing.Point(4, 22);
			this.tbwant.Name = "tbwant";
			this.tbwant.Size = new System.Drawing.Size(312, 278);
			this.tbwant.TabIndex = 1;
			this.tbwant.Text = "Wants";
			// 
			// lvwant
			// 
			this.lvwant.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvwant.HideSelection = false;
			this.lvwant.LargeImageList = this.iwant;
			this.lvwant.Location = new System.Drawing.Point(8, 8);
			this.lvwant.MultiSelect = false;
			this.lvwant.Name = "lvwant";
			this.lvwant.Size = new System.Drawing.Size(296, 264);
			this.lvwant.TabIndex = 0;
			this.lvwant.SelectedIndexChanged += new System.EventHandler(this.SelectWant);
			// 
			// iwant
			// 
			this.iwant.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.iwant.ImageSize = new System.Drawing.Size(44, 44);
			this.iwant.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tbfear
			// 
			this.tbfear.Controls.Add(this.lvfear);
			this.tbfear.Location = new System.Drawing.Point(4, 22);
			this.tbfear.Name = "tbfear";
			this.tbfear.Size = new System.Drawing.Size(312, 278);
			this.tbfear.TabIndex = 2;
			this.tbfear.Text = "Fears";
			// 
			// lvfear
			// 
			this.lvfear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvfear.HideSelection = false;
			this.lvfear.LargeImageList = this.ifear;
			this.lvfear.Location = new System.Drawing.Point(8, 8);
			this.lvfear.MultiSelect = false;
			this.lvfear.Name = "lvfear";
			this.lvfear.Size = new System.Drawing.Size(296, 264);
			this.lvfear.TabIndex = 1;
			this.lvfear.SelectedIndexChanged += new System.EventHandler(this.SelectWant);
			// 
			// ifear
			// 
			this.ifear.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ifear.ImageSize = new System.Drawing.Size(44, 44);
			this.ifear.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tbhist
			// 
			this.tbhist.Controls.Add(this.tvhist);
			this.tbhist.Location = new System.Drawing.Point(4, 22);
			this.tbhist.Name = "tbhist";
			this.tbhist.Size = new System.Drawing.Size(312, 278);
			this.tbhist.TabIndex = 3;
			this.tbhist.Text = "History";
			// 
			// tvhist
			// 
			this.tvhist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tvhist.HideSelection = false;
			this.tvhist.ImageList = this.ihist;
			this.tvhist.Location = new System.Drawing.Point(8, 8);
			this.tvhist.Name = "tvhist";
			this.tvhist.Size = new System.Drawing.Size(296, 264);
			this.tvhist.TabIndex = 0;
			this.tvhist.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SeletTv);
			// 
			// ihist
			// 
			this.ihist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ihist.ImageSize = new System.Drawing.Size(16, 16);
			this.ihist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tblife
			// 
			this.tblife.Controls.Add(this.lvlife);
			this.tblife.Location = new System.Drawing.Point(4, 22);
			this.tblife.Name = "tblife";
			this.tblife.Size = new System.Drawing.Size(312, 278);
			this.tblife.TabIndex = 0;
			this.tblife.Text = "Lifetime Wants";
			// 
			// lvlife
			// 
			this.lvlife.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvlife.HideSelection = false;
			this.lvlife.LargeImageList = this.ilife;
			this.lvlife.Location = new System.Drawing.Point(8, 8);
			this.lvlife.MultiSelect = false;
			this.lvlife.Name = "lvlife";
			this.lvlife.Size = new System.Drawing.Size(296, 264);
			this.lvlife.TabIndex = 1;
			this.lvlife.SelectedIndexChanged += new System.EventHandler(this.SelectWant);
			// 
			// ilife
			// 
			this.ilife.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilife.ImageSize = new System.Drawing.Size(44, 44);
			this.ilife.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.lbsimname);
			this.panel2.Controls.Add(this.label27);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 24);
			this.panel2.TabIndex = 0;
			// 
			// lbsimname
			// 
			this.lbsimname.AutoSize = true;
			this.lbsimname.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbsimname.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbsimname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lbsimname.Location = new System.Drawing.Point(216, 4);
			this.lbsimname.Name = "lbsimname";
			this.lbsimname.Size = new System.Drawing.Size(23, 19);
			this.lbsimname.TabIndex = 1;
			this.lbsimname.Text = "---";
			this.lbsimname.Click += new System.EventHandler(this.lbsimname_Click);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(214, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Wants and Fears Viewer for";
			// 
			// cbsel
			// 
			this.cbsel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbsel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbsel.Location = new System.Drawing.Point(200, 256);
			this.cbsel.Name = "cbsel";
			this.cbsel.Size = new System.Drawing.Size(120, 21);
			this.cbsel.TabIndex = 23;
			this.cbsel.SelectedIndexChanged += new System.EventHandler(this.cbsel_SelectedIndexChanged);
			// 
			// WantsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(864, 358);
			this.Controls.Add(this.wantsPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "WantsForm";
			this.Text = "WantsForm";
			this.wantsPanel.ResumeLayout(false);
			this.gbprop.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tbwant.ResumeLayout(false);
			this.tbfear.ResumeLayout(false);
			this.tbhist.ResumeLayout(false);
			this.tblife.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Want wrapper;		

		internal void AddWantToList(ListView lv, ImageList il, WantItem wnt)
		{
			ListViewItem lvi = new ListViewItem();
			lvi.Text = wnt.ToString();
			lvi.Tag = wnt;

			if (wnt.Information.Icon!=null) 
			{
				lvi.ImageIndex = il.Images.Count;
				il.Images.Add(wnt.Information.Icon);
				WaitingScreen.Update(wnt.Information.Icon, wnt.ToString());
			}
			
			lv.Items.Add(lvi);
		}

		void LoadHistory() 
		{
			lasttve = null;
			WaitingScreen.Wait();
			tvhist.BeginUpdate();
			foreach (WantItemContainer wic in wrapper.History) this.AddWant(tvhist, wic);
			tvhist.EndUpdate();
			WaitingScreen.Stop();
		}

		internal void AddWant(TreeView tv, WantItemContainer wc)
		{
			TreeNode parent = new TreeNode(wc.ToString());
			parent.Tag = wc;

			if (wc.Information.Icon!=null) {
				parent.SelectedImageIndex = ihist.Images.Count;
				parent.ImageIndex = ihist.Images.Count;
				ihist.Images.Add(wc.Information.Icon);

				WaitingScreen.Update(wc.Information.Icon, wc.ToString());
			}

			foreach (WantItem wi in wc.Items) 
			{
				TreeNode node = new TreeNode(wi.ToString());
				node.ImageIndex = parent.ImageIndex;
				node.SelectedImageIndex = parent.SelectedImageIndex;
				node.Tag = wi;

				parent.Nodes.Add(node);
			}

			tv.Nodes.Add(parent);
		}		

		void SelectTvNode(WantItem wi) 
		{
			foreach (TreeNode parent in tv.Nodes) 
			{
				foreach (TreeNode node in parent.Nodes) 
				{
					WantInformation winfo = (WantInformation)node.Tag;
					if (wi!=null) 
					{
						if (winfo.Guid == wi.Guid) 
						{
							tv.SelectedNode = node;
							node.Parent.Expand();
							node.EnsureVisible();
							return;
						}
					}
				}
			}
		}

		void ShowWantItem(WantItem wi)
		{
			lastwi = wi;
			
			this.tbversion.Text = "0x"+Helper.HexString(wi.Version);
			this.tbsiminst.Text = "0x"+Helper.HexString(wi.SimInstance);
			this.tbguid.Text = "0x"+Helper.HexString(wi.Guid);
			this.tbval.Text = "0x"+Helper.HexString(wi.Value);
			this.tbprop.Text = wi.Property.ToString();
			this.tbindex.Text = "0x"+Helper.HexString(wi.Index);
			this.tbpoints.Text = wi.Score.ToString();
			this.tbunknown1.Text = "0x"+Helper.HexString((byte)wi.Flag.Value);
			this.tbunknown2.Text = wi.Influence.ToString();	
			this.cblock.Checked = wi.Flag.Locked;

			this.pb.Image = wi.Information.Icon;

			this.cbtype.SelectedIndex=0;
			for (int i=1; i<cbtype.Items.Count; i++)
			{
				WantType wt = (WantType)cbtype.Items[i];
				if (wt==wi.Type) 
				{
					cbtype.SelectedIndex = i;
					break;
				}
			}

			//if (this.Tag!=null) return;
			this.Tag = true;
			try 
			{
				SelectTvNode(wi);
			} 
			finally 
			{
				this.Tag = null; 
			}
		}

		internal WantItem lastwi;
		internal ListViewItem lastlvi;
		private void SelectWant(object sender, System.EventArgs e)
		{
			ListView lv = (ListView)sender;			
			gbprop.Enabled = false;
			lastwi = null;
			if (lv.SelectedItems.Count==0) return;
			gbprop.Enabled = true;

			WantItem wi = (WantItem)lv.SelectedItems[0].Tag;
			lastlvi = lv.SelectedItems[0];

			if (this.Tag!=null) return;
			this.Tag = true;
			ShowWantItem(wi);
			this.Tag = null;
		}

		private void cbsel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbsel.SelectedIndex<0) return;
			Data.Alias a = (Data.Alias)cbsel.Items[cbsel.SelectedIndex];
			tbval.Text = "0x"+Helper.HexString(a.Id);
		}

		private void ChangeType(object sender, System.EventArgs e)
		{
			this.cbsel.Items.Clear();
			ArrayList list = WantLoader.WantNameLoader.GetNames((WantType)cbtype.Items[cbtype.SelectedIndex]);
			int ct=0;
			foreach (Data.Alias a in list) 
			{
				cbsel.Items.Add(a);
				if (lastwi!=null) if (a.Id == lastwi.Value) cbsel.SelectedIndex=ct;
				ct++;
			}
		}

		private void lbsimname_Click(object sender, System.EventArgs e)
		{
			try 
			{
				if (wrapper.Changed) 
				{
					if (MessageBox.Show(SimPe.Localization.Manager.GetString("open_wnt_from_sdsc"), SimPe.Localization.Manager.GetString("question"), MessageBoxButtons.YesNo)==DialogResult.Yes)
						wrapper.SynchronizeUserData();
				}

				//Open File
				
				Interfaces.Files.IPackedFileDescriptor pfd = wrapper.Package.NewDescriptor(Data.MetaData.SIM_DESCRIPTION_FILE, wrapper.FileDescriptor.SubType, wrapper.FileDescriptor.Group, wrapper.FileDescriptor.Instance); //try a W&f File
				pfd = wrapper.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Commit(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			wrapper.SynchronizeUserData();
		}

		private void ChangedText(object sender, System.EventArgs e)
		{
			if (lastwi==null) return;
			if (this.Tag != null) return;
			this.Tag = true;

			try 
			{
				lastwi.Influence = Convert.ToInt32(this.tbunknown2.Text);
				lastwi.Score = Convert.ToInt32(this.tbpoints.Text);
				lastwi.Value = Convert.ToUInt32(this.tbval.Text, 16);

				lastwi.Flag.Locked = cblock.Checked;
				wrapper.Changed = true;

				if (this.lastlvi!=null) lastlvi.Text = lastwi.ToString();
			} 
			catch {}
			finally 
			{
				this.Tag = null;
			}
		}

		private void SelectTab(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedIndex==2 && tvhist.Nodes.Count==0) LoadHistory();

			if (tabControl1.SelectedIndex==0) SelectWant(lvwant, (System.EventArgs)null);
			else if (tabControl1.SelectedIndex==1) SelectWant(lvfear, (System.EventArgs)null);
			else if (tabControl1.SelectedIndex==3) SelectWant(lvlife, (System.EventArgs)null);
			else SeletTv(null, lasttve);			
		}

		System.Windows.Forms.TreeViewEventArgs lasttve;
		private void SeletTv(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			lastwi = null;
			gbprop.Enabled = false;
			if (e==null) return;			
			if (e.Node == null) return;
			
			
			lasttve = e;
			TreeNode node = e.Node;

			
			if (node.Tag.GetType() == typeof(WantItem)) 
			{
				//gbprop.Enabled = true;

				WantItem wi = (WantItem)node.Tag;
				ShowWantItem(wi);
				//lastwi = null;
			}
		}

		internal void ListWants()
		{
			if (tv.Nodes.Count>0) return;

			itv.Images.Add(new System.Drawing.Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.subitems.png")));
			itv.Images.Add(new System.Drawing.Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.nothumb.png")));
			bool running = WaitingScreen.Running;
			WaitingScreen.Wait();
			System.Collections.Hashtable ht = new Hashtable();
			string max = " / "+WantLoader.Wants.Keys.Count.ToString();
			int ct = 0;
			foreach (uint guid in WantLoader.Wants.Keys)
			{
				ct++;
				WantInformation wi = WantInformation.LoadWant(guid);
				ArrayList al = (ArrayList)ht[wi.XWant.Folder];
				if (al==null) 
				{
					al = new ArrayList();
					ht[wi.XWant.Folder] = al;
				}

				wi.prefix = "    ";
				al.Add(wi);

				if ((ct%3)==1) WaitingScreen.Update(wi.Icon, ct.ToString()+max);

				//if ((Helper.DebugMode) && (ct>200)) break;
			}

			foreach (string k in ht.Keys) 
			{
				TreeNode parent = new TreeNode(k);
				
				foreach (WantInformation wi in (ArrayList)ht[k]) 
				{
					TreeNode node = new TreeNode(wi.Name);
					node.Tag = wi;

					if (wi.Icon!=null) 
					{
						node.ImageIndex = itv.Images.Count;						
						itv.Images.Add(wi.Icon);
					} 
					else 
					{
						node.ImageIndex = 1;		
					}
					node.SelectedImageIndex = node.ImageIndex;
					parent.Nodes.Add(node);
				}
				tv.Nodes.Add(parent);
			}
			tv.Sorted = true;

			if (!running) WaitingScreen.Stop();
		}

		private void SelectWant(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (this.Tag!=null) return;
			if (e==null) return;
			if (e.Node == null) return;
			if (e.Node.Tag == null) return;

			WantInformation wi = (WantInformation)e.Node.Tag;
			this.tbguid.Text = "0x"+Helper.HexString(wi.Guid);
			pb.Image = wi.Icon;

			if (lastlvi!=null) 
			{				
				if (lastlvi.ImageIndex>=0) 
					lastlvi.ListView.LargeImageList.Images[lastlvi.ImageIndex] = ImageLoader.Preview(wi.Icon, lastlvi.ListView.LargeImageList.ImageSize);
				lastlvi.Text = wi.Name;

				
			}

			if (lastwi!=null) 
			{
				lastwi.Guid = wi.Guid;
				lastwi.Type = wi.XWant.WantType;
				lastwi.Influence = wi.XWant.Influence;
				lastwi.Score = wi.XWant.Score;
				lastlvi.Text = lastwi.ToString();

				wrapper.Changed = true;

				this.ShowWantItem(lastwi);
			}

			if (lastlvi!=null)  lastlvi.ListView.Refresh();
		}
	}

}
