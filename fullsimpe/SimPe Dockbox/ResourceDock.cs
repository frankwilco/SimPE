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
using Ambertation.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Zusammenfassung für ResourceDock.
	/// </summary>
	public class ResourceDock : System.Windows.Forms.Form
	{
		private DockManager manager;
		internal Ambertation.Windows.Forms.DockPanel dcWrapper;
		internal Ambertation.Windows.Forms.DockPanel dcResource;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
		internal System.Windows.Forms.Panel pntypes;
		internal System.Windows.Forms.TextBox tbinstance;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbgroup;
		internal System.Windows.Forms.ComboBox cbtypes;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.ComboBox cbComp;
		internal System.Windows.Forms.TextBox tbinstance2;
		internal System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label lbAuthor;
		internal System.Windows.Forms.Label lbVersion;
		internal System.Windows.Forms.Label lbDesc;
		internal System.Windows.Forms.Label lbComp;
		internal Ambertation.Windows.Forms.DockPanel dcPackage;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
		internal System.Windows.Forms.PropertyGrid pgHead;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ColumnHeader clOffset;
		private System.Windows.Forms.ColumnHeader clSize;
		internal Ambertation.Windows.Forms.DockPanel dcConvert;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel4;
		private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;
		private System.Windows.Forms.TextBox tbHex;
		private System.Windows.Forms.TextBox tbDec;
		internal Ambertation.Windows.Forms.DockPanel dcHex;
		internal Ambertation.Windows.Forms.HexViewControl hvc;
		private System.Windows.Forms.TextBox tbBin;
		internal System.Windows.Forms.Button button1;
		private Ambertation.Windows.Forms.HexEditControl hexEditControl1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		internal System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbFloat;
        private DockContainer dockBottom;
		private System.ComponentModel.IContainer components;

		public ResourceDock()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			ThemeManager tm = ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.xpGradientPanel2);
			tm.AddControl(this.xpGradientPanel3);
			tm.AddControl(this.xpGradientPanel4);

            this.lv.View = System.Windows.Forms.View.Details;
			foreach (SimPe.Data.TypeAlias a in SimPe.Helper.TGILoader.FileTypes) 
				cbtypes.Items.Add(a);			
			cbtypes.Sorted = true;
			tbFloat.Width = tbBin.Width;
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
            Ambertation.Windows.Forms.WhidbeyRenderer whidbeyRenderer2 = new Ambertation.Windows.Forms.WhidbeyRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceDock));
            this.manager = new Ambertation.Windows.Forms.DockManager();
            this.dockBottom = new Ambertation.Windows.Forms.DockContainer();
            this.dcConvert = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel4 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.tbFloat = new System.Windows.Forms.TextBox();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.dcHex = new Ambertation.Windows.Forms.DockPanel();
            this.hvc = new Ambertation.Windows.Forms.HexViewControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.hexEditControl1 = new Ambertation.Windows.Forms.HexEditControl();
            this.dcResource = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbComp = new System.Windows.Forms.Label();
            this.cbComp = new System.Windows.Forms.ComboBox();
            this.pntypes = new System.Windows.Forms.Panel();
            this.tbinstance2 = new System.Windows.Forms.TextBox();
            this.tbinstance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbtype = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbgroup = new System.Windows.Forms.TextBox();
            this.cbtypes = new System.Windows.Forms.ComboBox();
            this.dcPackage = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.lv = new System.Windows.Forms.ListView();
            this.clOffset = new System.Windows.Forms.ColumnHeader();
            this.clSize = new System.Windows.Forms.ColumnHeader();
            this.label4 = new System.Windows.Forms.Label();
            this.pgHead = new System.Windows.Forms.PropertyGrid();
            this.dcWrapper = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.lbName = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
            this.manager.SuspendLayout();
            this.dockBottom.SuspendLayout();
            this.dcConvert.SuspendLayout();
            this.xpGradientPanel4.SuspendLayout();
            this.dcHex.SuspendLayout();
            this.panel1.SuspendLayout();
            this.dcResource.SuspendLayout();
            this.xpGradientPanel1.SuspendLayout();
            this.pntypes.SuspendLayout();
            this.dcPackage.SuspendLayout();
            this.xpGradientPanel3.SuspendLayout();
            this.dcWrapper.SuspendLayout();
            this.xpGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // sandDockManager1
            // 
            this.manager.Controls.Add(this.dockBottom);
            this.manager.DefaultSize = new System.Drawing.Size(100, 100);
            resources.ApplyResources(this.manager, "sandDockManager1");
            this.manager.DragBorder = true;
            this.manager.Manager = this.manager;
            this.manager.Name = "sandDockManager1";
            this.manager.NoCleanup = false;
            this.manager.Renderer = whidbeyRenderer2;
            this.manager.TabImage = null;
            this.manager.TabText = "";
            // 
            // dockBottom
            // 
            this.dockBottom.Controls.Add(this.dcPackage);
            this.dockBottom.Controls.Add(this.dcResource);
            this.dockBottom.Controls.Add(this.dcWrapper);
            this.dockBottom.Controls.Add(this.dcHex);
            this.dockBottom.Controls.Add(this.dcConvert);
            resources.ApplyResources(this.dockBottom, "dockBottom");
            this.dockBottom.DragBorder = true;
            this.dockBottom.Manager = this.manager;
            this.dockBottom.Name = "dockBottom";
            this.dockBottom.NoCleanup = false;
            this.dockBottom.TabImage = null;
            this.dockBottom.TabText = "";
            // 
            // dcConvert
            // 
            this.dcConvert.AllowClose = true;
            this.dcConvert.AllowDockBottom = true;
            this.dcConvert.AllowDockCenter = true;
            this.dcConvert.AllowDockLeft = true;
            this.dcConvert.AllowDockRight = true;
            this.dcConvert.AllowDockTop = true;
            this.dcConvert.AllowFloat = true;
            resources.ApplyResources(this.dcConvert, "dcConvert");
            this.dcConvert.CanUndock = true;
            this.dcConvert.Controls.Add(this.xpGradientPanel4);
            this.dcConvert.DockContainer = this.dockBottom;
            this.dcConvert.DragBorder = false;
            this.dcConvert.FloatingSize = new System.Drawing.Size(856, 382);
            this.dcConvert.Image = ((System.Drawing.Image)(resources.GetObject("dcConvert.Image")));
            this.dcConvert.Manager = this.manager;
            this.dcConvert.Name = "dcConvert";
            this.dcConvert.ShowCloseButton = true;
            this.dcConvert.ShowCollapseButton = true;
            this.dcConvert.TabImage = ((System.Drawing.Image)(resources.GetObject("dcConvert.TabImage")));
            this.dcConvert.TabText = "Converter";
            // 
            // xpGradientPanel4
            // 
            this.xpGradientPanel4.Controls.Add(this.tbFloat);
            this.xpGradientPanel4.Controls.Add(this.tbBin);
            this.xpGradientPanel4.Controls.Add(this.tbDec);
            this.xpGradientPanel4.Controls.Add(this.tbHex);
            resources.ApplyResources(this.xpGradientPanel4, "xpGradientPanel4");
            this.xpGradientPanel4.Name = "xpGradientPanel4";
            // 
            // tbFloat
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbFloat, "Float");
            resources.ApplyResources(this.tbFloat, "tbFloat");
            this.tbFloat.Name = "tbFloat";
            this.tbFloat.TextChanged += new System.EventHandler(this.FloatChanged);
            // 
            // tbBin
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbBin, "Binary");
            resources.ApplyResources(this.tbBin, "tbBin");
            this.tbBin.Name = "tbBin";
            this.tbBin.SizeChanged += new System.EventHandler(this.tbBin_SizeChanged);
            this.tbBin.TextChanged += new System.EventHandler(this.BinChanged);
            // 
            // tbDec
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbDec, "Decimal");
            resources.ApplyResources(this.tbDec, "tbDec");
            this.tbDec.Name = "tbDec";
            this.tbDec.TextChanged += new System.EventHandler(this.DecChanged);
            // 
            // tbHex
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbHex, "Hex.");
            resources.ApplyResources(this.tbHex, "tbHex");
            this.tbHex.Name = "tbHex";
            this.tbHex.TextChanged += new System.EventHandler(this.HexChanged);
            // 
            // dcHex
            // 
            this.dcHex.AllowClose = true;
            this.dcHex.AllowDockBottom = true;
            this.dcHex.AllowDockCenter = true;
            this.dcHex.AllowDockLeft = true;
            this.dcHex.AllowDockRight = true;
            this.dcHex.AllowDockTop = true;
            this.dcHex.AllowFloat = true;
            resources.ApplyResources(this.dcHex, "dcHex");
            this.dcHex.CanUndock = true;
            this.dcHex.Controls.Add(this.hvc);
            this.dcHex.Controls.Add(this.panel1);
            this.dcHex.Controls.Add(this.hexEditControl1);
            this.dcHex.DockContainer = this.dockBottom;
            this.dcHex.DragBorder = false;
            this.dcHex.FloatingSize = new System.Drawing.Size(856, 382);
            this.dcHex.Image = ((System.Drawing.Image)(resources.GetObject("dcHex.Image")));
            this.dcHex.Manager = this.manager;
            this.dcHex.Name = "dcHex";
            this.dcHex.ShowCloseButton = true;
            this.dcHex.ShowCollapseButton = true;
            this.dcHex.TabImage = ((System.Drawing.Image)(resources.GetObject("dcHex.TabImage")));
            this.dcHex.TabText = "Hex";
            this.dcHex.VisibleChanged += new System.EventHandler(this.dcHex_VisibleChanged);
            // 
            // hvc
            // 
            this.hvc.Blocks = ((byte)(2));
            this.hvc.CharBoxWidth = 220;
            this.hvc.CurrentRow = 0;
            this.hvc.Data = new byte[0];
            resources.ApplyResources(this.hvc, "hvc");
            this.hvc.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.hvc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.hvc.HeadColor = System.Drawing.Color.DarkOrange;
            this.hvc.HeadForeColor = System.Drawing.Color.SeaShell;
            this.hvc.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.hvc.HighlightForeColor = System.Drawing.SystemColors.HighlightText;
            this.hvc.HighlightZeros = false;
            this.hvc.Name = "hvc";
            this.hvc.Offset = 0;
            this.hvc.OffsetBoxWidth = 83;
            this.hvc.SelectedByte = ((byte)(0));
            this.hvc.SelectedChar = '\0';
            this.hvc.SelectedDouble = 0;
            this.hvc.SelectedFloat = 0F;
            this.hvc.SelectedInt = 0;
            this.hvc.SelectedLong = ((long)(0));
            this.hvc.SelectedShort = ((short)(0));
            this.hvc.SelectedUInt = ((uint)(0u));
            this.hvc.SelectedULong = ((ulong)(0ul));
            this.hvc.SelectedUShort = ((ushort)(0));
            this.hvc.Selection = new byte[0];
            this.hvc.SelectionColor = System.Drawing.SystemColors.Highlight;
            this.hvc.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.hvc.ShowGrid = true;
            this.hvc.View = Ambertation.Windows.Forms.HexViewControl.ViewState.Hex;
            this.hvc.ZeroCellColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(49)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hexEditControl1
            // 
            resources.ApplyResources(this.hexEditControl1, "hexEditControl1");
            this.hexEditControl1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hexEditControl1.LabelFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexEditControl1.Name = "hexEditControl1";
            this.hexEditControl1.TabStop = false;
            this.hexEditControl1.TextBoxFont = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexEditControl1.Vertical = false;
            this.hexEditControl1.View = Ambertation.Windows.Forms.HexViewControl.ViewState.Hex;
            this.hexEditControl1.Viewer = this.hvc;
            // 
            // dcResource
            // 
            this.dcResource.AllowClose = true;
            this.dcResource.AllowDockBottom = true;
            this.dcResource.AllowDockCenter = true;
            this.dcResource.AllowDockLeft = true;
            this.dcResource.AllowDockRight = true;
            this.dcResource.AllowDockTop = true;
            this.dcResource.AllowFloat = true;
            resources.ApplyResources(this.dcResource, "dcResource");
            this.dcResource.CanUndock = true;
            this.dcResource.Controls.Add(this.xpGradientPanel1);
            this.dcResource.DockContainer = this.dockBottom;
            this.dcResource.DragBorder = false;
            this.dcResource.FloatingSize = new System.Drawing.Size(856, 382);
            this.dcResource.Image = ((System.Drawing.Image)(resources.GetObject("dcResource.Image")));
            this.dcResource.Manager = this.manager;
            this.dcResource.Name = "dcResource";
            this.dcResource.ShowCloseButton = true;
            this.dcResource.ShowCollapseButton = true;
            this.dcResource.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResource.TabImage")));
            this.dcResource.TabText = "Resource";
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.Controls.Add(this.linkLabel1);
            this.xpGradientPanel1.Controls.Add(this.lbComp);
            this.xpGradientPanel1.Controls.Add(this.cbComp);
            this.xpGradientPanel1.Controls.Add(this.pntypes);
            resources.ApplyResources(this.xpGradientPanel1, "xpGradientPanel1");
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbComp
            // 
            this.lbComp.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lbComp, "lbComp");
            this.lbComp.Name = "lbComp";
            // 
            // cbComp
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.cbComp, "");
            this.cbComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbComp, "cbComp");
            this.cbComp.Items.AddRange(new object[] {
            resources.GetString("cbComp.Items"),
            resources.GetString("cbComp.Items1"),
            resources.GetString("cbComp.Items2")});
            this.cbComp.Name = "cbComp";
            this.cbComp.SelectedIndexChanged += new System.EventHandler(this.cbComp_SelectedIndexChanged);
            // 
            // pntypes
            // 
            this.pntypes.BackColor = System.Drawing.Color.Transparent;
            this.pntypes.Controls.Add(this.tbinstance2);
            this.pntypes.Controls.Add(this.tbinstance);
            this.pntypes.Controls.Add(this.label11);
            this.pntypes.Controls.Add(this.tbtype);
            this.pntypes.Controls.Add(this.label8);
            this.pntypes.Controls.Add(this.label9);
            this.pntypes.Controls.Add(this.label10);
            this.pntypes.Controls.Add(this.tbgroup);
            this.pntypes.Controls.Add(this.cbtypes);
            resources.ApplyResources(this.pntypes, "pntypes");
            this.pntypes.Name = "pntypes";
            // 
            // tbinstance2
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbinstance2, "");
            resources.ApplyResources(this.tbinstance2, "tbinstance2");
            this.tbinstance2.Name = "tbinstance2";
            this.tbinstance2.Leave += new System.EventHandler(this.tbinstance2_TextChanged);
            this.tbinstance2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance2_KeyUp);
            this.tbinstance2.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // tbinstance
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbinstance, "");
            resources.ApplyResources(this.tbinstance, "tbinstance");
            this.tbinstance.Name = "tbinstance";
            this.tbinstance.Leave += new System.EventHandler(this.tbinstance_TextChanged);
            this.tbinstance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance_KeyUp);
            this.tbinstance.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbtype
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbtype, "");
            resources.ApplyResources(this.tbtype, "tbtype");
            this.tbtype.Name = "tbtype";
            this.tbtype.Leave += new System.EventHandler(this.tbtype_TextChanged2);
            this.tbtype.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbtype_KeyUp);
            this.tbtype.TextChanged += new System.EventHandler(this.tbtype_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbgroup
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbgroup, "");
            resources.ApplyResources(this.tbgroup, "tbgroup");
            this.tbgroup.Name = "tbgroup";
            this.tbgroup.Leave += new System.EventHandler(this.tbgroup_TextChanged);
            this.tbgroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbgroup_KeyUp);
            this.tbgroup.TextChanged += new System.EventHandler(this.TextChanged);
            // 
            // cbtypes
            // 
            resources.ApplyResources(this.cbtypes, "cbtypes");
            this.xpCueBannerExtender1.SetCueBannerText(this.cbtypes, "");
            this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtypes.Name = "cbtypes";
            this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.cbtypes_SelectedIndexChanged);
            // 
            // dcPackage
            // 
            this.dcPackage.AllowClose = true;
            this.dcPackage.AllowDockBottom = true;
            this.dcPackage.AllowDockCenter = true;
            this.dcPackage.AllowDockLeft = true;
            this.dcPackage.AllowDockRight = true;
            this.dcPackage.AllowDockTop = true;
            this.dcPackage.AllowFloat = true;
            resources.ApplyResources(this.dcPackage, "dcPackage");
            this.dcPackage.CanUndock = true;
            this.dcPackage.Controls.Add(this.xpGradientPanel3);
            this.dcPackage.DockContainer = this.dockBottom;
            this.dcPackage.DragBorder = false;
            this.dcPackage.FloatingSize = new System.Drawing.Size(856, 382);
            this.dcPackage.Image = ((System.Drawing.Image)(resources.GetObject("dcPackage.Image")));
            this.dcPackage.Manager = this.manager;
            this.dcPackage.Name = "dcPackage";
            this.dcPackage.ShowCloseButton = true;
            this.dcPackage.ShowCollapseButton = true;
            this.dcPackage.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPackage.TabImage")));
            this.dcPackage.TabText = "Package ";
            // 
            // xpGradientPanel3
            // 
            this.xpGradientPanel3.Controls.Add(this.lv);
            this.xpGradientPanel3.Controls.Add(this.label4);
            this.xpGradientPanel3.Controls.Add(this.pgHead);
            resources.ApplyResources(this.xpGradientPanel3, "xpGradientPanel3");
            this.xpGradientPanel3.Name = "xpGradientPanel3";
            // 
            // lv
            // 
            resources.ApplyResources(this.lv, "lv");
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clOffset,
            this.clSize});
            this.lv.FullRowSelect = true;
            this.lv.GridLines = true;
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv.HideSelection = false;
            this.lv.Name = "lv";
            this.lv.UseCompatibleStateImageBehavior = false;
            
            // 
            // clOffset
            // 
            resources.ApplyResources(this.clOffset, "clOffset");
            // 
            // clSize
            // 
            resources.ApplyResources(this.clSize, "clSize");
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pgHead
            // 
            resources.ApplyResources(this.pgHead, "pgHead");
            this.pgHead.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.pgHead.Name = "pgHead";
            this.pgHead.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
            this.pgHead.ToolbarVisible = false;
            // 
            // dcWrapper
            // 
            this.dcWrapper.AllowClose = true;
            this.dcWrapper.AllowDockBottom = true;
            this.dcWrapper.AllowDockCenter = true;
            this.dcWrapper.AllowDockLeft = true;
            this.dcWrapper.AllowDockRight = true;
            this.dcWrapper.AllowDockTop = true;
            this.dcWrapper.AllowFloat = true;
            resources.ApplyResources(this.dcWrapper, "dcWrapper");
            this.dcWrapper.CanUndock = true;
            this.dcWrapper.Controls.Add(this.xpGradientPanel2);
            this.dcWrapper.DockContainer = this.dockBottom;
            this.dcWrapper.DragBorder = false;
            this.dcWrapper.FloatingSize = new System.Drawing.Size(856, 382);
            this.dcWrapper.Image = ((System.Drawing.Image)(resources.GetObject("dcWrapper.Image")));
            this.dcWrapper.Manager = this.manager;
            this.dcWrapper.Name = "dcWrapper";
            this.dcWrapper.ShowCloseButton = true;
            this.dcWrapper.ShowCollapseButton = true;
            this.dcWrapper.TabImage = ((System.Drawing.Image)(resources.GetObject("dcWrapper.TabImage")));
            this.dcWrapper.TabText = "Wrapper";
            // 
            // xpGradientPanel2
            // 
            this.xpGradientPanel2.Controls.Add(this.lbName);
            this.xpGradientPanel2.Controls.Add(this.pb);
            this.xpGradientPanel2.Controls.Add(this.lbDesc);
            this.xpGradientPanel2.Controls.Add(this.lbVersion);
            this.xpGradientPanel2.Controls.Add(this.lbAuthor);
            this.xpGradientPanel2.Controls.Add(this.label5);
            this.xpGradientPanel2.Controls.Add(this.label2);
            this.xpGradientPanel2.Controls.Add(this.label1);
            this.xpGradientPanel2.Controls.Add(this.label3);
            resources.ApplyResources(this.xpGradientPanel2, "xpGradientPanel2");
            this.xpGradientPanel2.Name = "xpGradientPanel2";
            // 
            // lbName
            // 
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Name = "lbName";
            // 
            // pb
            // 
            this.pb.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pb, "pb");
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // lbDesc
            // 
            resources.ApplyResources(this.lbDesc, "lbDesc");
            this.lbDesc.BackColor = System.Drawing.Color.Transparent;
            this.lbDesc.Name = "lbDesc";
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Name = "lbVersion";
            // 
            // lbAuthor
            // 
            resources.ApplyResources(this.lbAuthor, "lbAuthor");
            this.lbAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lbAuthor.Name = "lbAuthor";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // ResourceDock
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.manager);
            this.Name = "ResourceDock";
            this.Load += new System.EventHandler(this.ResourceDock_Load);
            this.manager.ResumeLayout(false);
            this.dockBottom.ResumeLayout(false);
            this.dcConvert.ResumeLayout(false);
            this.xpGradientPanel4.ResumeLayout(false);
            this.xpGradientPanel4.PerformLayout();
            this.dcHex.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.dcResource.ResumeLayout(false);
            this.xpGradientPanel1.ResumeLayout(false);
            this.pntypes.ResumeLayout(false);
            this.pntypes.PerformLayout();
            this.dcPackage.ResumeLayout(false);
            this.xpGradientPanel3.ResumeLayout(false);
            this.dcWrapper.ResumeLayout(false);
            this.xpGradientPanel2.ResumeLayout(false);
            this.xpGradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		internal SimPe.Events.ResourceEventArgs items;
		internal LoadedPackage guipackage;
		
		private void ResourceDock_Load(object sender, System.EventArgs e)
		{
		
		}

		private void cbtypes_SelectedIndexChanged(object sender, System.EventArgs e)
		{			
			if (cbtypes.Tag != null) return;
			tbtype.Text = "0x"+Helper.HexString(((SimPe.Data.TypeAlias)cbtypes.Items[cbtypes.SelectedIndex]).Id);			
			this.tbtype.Tag = true;
			tbtype_TextChanged2(this.tbtype, e);
		}

		private void tbtype_TextChanged(object sender, System.EventArgs e)
		{
			cbtypes.Tag = true;
			Data.TypeAlias a = Data.MetaData.FindTypeAlias(Helper.HexStringToUInt(tbtype.Text));

			int ct=0;
			foreach(Data.TypeAlias i in cbtypes.Items) 
			{								
				if (i==a) 
				{
					cbtypes.SelectedIndex = ct;
					cbtypes.Tag = null;
					return;
				}
				ct++;
			}

			cbtypes.SelectedIndex = -1;
			cbtypes.Tag = null;	
			TextChanged(sender, null);
		}

		private void tbtype_TextChanged2(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;
			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Type = Convert.ToUInt32(tbtype.Text, 16);
					
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}			
			guipackage.PauseIndexChangedEvents();
			guipackage.RestartIndexChangedEvents();
		}

		private void tbgroup_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Group = Convert.ToUInt32(tbgroup.Text, 16);
					
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.PauseIndexChangedEvents();
			guipackage.RestartIndexChangedEvents();
		}

		private void tbinstance_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;


				try
				{
					e.Resource.FileDescriptor.Instance = Convert.ToUInt32(tbinstance.Text, 16);

					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			
			guipackage.PauseIndexChangedEvents();
			guipackage.RestartIndexChangedEvents();
			
		}

		private void tbinstance2_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;


				try
				{
					e.Resource.FileDescriptor.SubType = Convert.ToUInt32(tbinstance2.Text, 16);
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.PauseIndexChangedEvents();
			guipackage.RestartIndexChangedEvents();
		}
		

		private void cbComp_SelectedIndexChanged(object sender, System.EventArgs ea)
		{
			if (this.cbComp.SelectedIndex<0) return;
			if (this.cbComp.SelectedIndex>1) return;
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;

				try
				{
					e.Resource.FileDescriptor.MarkForReCompress = (cbComp.SelectedIndex==1);
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.PauseIndexChangedEvents();
			guipackage.RestartIndexChangedEvents();
		}

		private void tbtype_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbtype_TextChanged2(sender, null);
			}
		}

		private void tbgroup_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbgroup_TextChanged(sender, null);
			}
		}

		private void tbinstance_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbinstance_TextChanged(sender, null);
			}
		}

		private void tbinstance2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbinstance2_TextChanged(sender, null);
			}
		}

		#region Hex <-> Dec Converter
		bool sysupdate = false;
		void SetConverted(object exclude, long val)
		{
			if (exclude!=this.tbDec) this.tbDec.Text = val.ToString();
			if (exclude!=this.tbHex) this.tbHex.Text = Helper.HexString(val);		
			if (exclude!=this.tbBin) this.tbBin.Text = Convert.ToString(val, 2);;	
			if (exclude!=this.tbFloat) this.tbFloat.Text = BitConverter.ToSingle(BitConverter.GetBytes((int)val), 0).ToString();			
		}
		void ClearConverted(object exclude)
		{
			if (exclude!=this.tbDec) this.tbDec.Text = "";
			if (exclude!=this.tbHex) this.tbHex.Text = "";	
			if (exclude!=this.tbBin) this.tbBin.Text = "";	
			if (exclude!=this.tbFloat) this.tbFloat.Text = "";	
		}
		private void FloatChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				float f = Convert.ToSingle(tbFloat.Text);
				long val = BitConverter.ToInt32(BitConverter.GetBytes(f), 0);
				SetConverted(this.tbFloat, val);
			} 
			catch 
			{
				ClearConverted(this.tbFloat);
			}
			sysupdate = false;
		}
		private void BinChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				long val = Convert.ToInt64(tbBin.Text.Replace(" ", ""), 2);
				SetConverted(this.tbBin, val);
			} 
			catch
			{
				ClearConverted(this.tbBin);
			}
			sysupdate = false;
		}
		private void HexChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				long val = Convert.ToInt64(tbHex.Text.Replace(" ", ""), 16);				
				SetConverted(this.tbHex, val);
			} 
			catch{
				ClearConverted(this.tbHex);
			}
			sysupdate = false;
		}

		private void DecChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				long val = Convert.ToInt64(tbDec.Text);				
				SetConverted(this.tbDec, val);
			} 
			catch (Exception) {
				ClearConverted(this.tbDec);
			}
			sysupdate = false;
		}
		#endregion

		internal SimPe.Interfaces.Files.IPackedFileDescriptor hexpfd;
		private new void TextChanged(object sender, System.EventArgs e)
		{
			if (items==null) return;
			((TextBox)sender).Tag = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			hexpfd.UserData = hvc.Data;
		}		

		private void dcHex_VisibleChanged(object sender, System.EventArgs e)
		{
			this.hvc.Visible = dcHex.Visible;							
			hvc.Refresh(true);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs ev)
		{
			if (items==null) return;			
			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Type = Convert.ToUInt32(tbtype.Text, 16);
					e.Resource.FileDescriptor.Group = Convert.ToUInt32(tbgroup.Text, 16);
					e.Resource.FileDescriptor.Instance = Convert.ToUInt32(tbinstance.Text, 16);
					e.Resource.FileDescriptor.SubType = Convert.ToUInt32(tbinstance2.Text, 16);
					e.Resource.FileDescriptor.MarkForReCompress = (cbComp.SelectedIndex==1 && !e.Resource.FileDescriptor.WasCompressed);

					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();		
		}

		private void tbBin_SizeChanged(object sender, System.EventArgs e)
		{
			tbFloat.Width = tbBin.Width;
		}

		

		


		
	}
}
