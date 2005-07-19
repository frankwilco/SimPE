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

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Zusammenfassung für ObjectWorkshopDock.
	/// </summary>
	public class ObjectWorkshopDock : System.Windows.Forms.Form
	{
		private TD.SandDock.SandDockManager sandDockManager1;
		private TD.SandDock.DockContainer leftSandDock;
		private TD.SandDock.DockContainer rightSandDock;
		private TD.SandDock.DockContainer bottomSandDock;
		private TD.SandDock.DockContainer topSandDock;
		internal TD.SandDock.DockControl dcObjectWorkshop;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private TD.SandBar.ToolBar toolBar1;
		private SimPe.Wizards.Wizard wizard1;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel2;
		private TD.SandBar.ButtonItem biPrev;
		private TD.SandBar.ButtonItem biNext;
		private TD.SandBar.ButtonItem biFinish;
		private System.Windows.Forms.ListBox lb;
		private TD.SandBar.ButtonItem biCatalog;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.ImageList ilist;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel3;
		private System.Windows.Forms.Panel panel2;
		private TD.SandBar.FlatComboBox cbTask;
		private System.Windows.Forms.Label label3;
		private Ambertation.Windows.Forms.XPTaskBoxSimple gbClone;
		private Ambertation.Windows.Forms.XPTaskBoxSimple gbRecolor;
		private Ambertation.Windows.Forms.TransparentCheckBox cbColorExt;
		private Ambertation.Windows.Forms.TransparentCheckBox cbanim;
		private Ambertation.Windows.Forms.TransparentCheckBox cbwallmask;
		private Ambertation.Windows.Forms.TransparentCheckBox cbparent;
		private Ambertation.Windows.Forms.TransparentCheckBox cbclean;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfix;
		private Ambertation.Windows.Forms.TransparentCheckBox cbdefault;
		private Ambertation.Windows.Forms.TransparentCheckBox cbgid;
		private System.Windows.Forms.Button button3;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel4;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.ComponentModel.IContainer components;

		public ObjectWorkshopDock()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			wizard1.Start();
			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.toolBar1);

			biFinish.Enabled = wizard1.FinishEnabled;
			biNext.Enabled = wizard1.NextEnabled;
			biPrev.Enabled = wizard1.PrevEnabled;

			this.cbTask.SelectedIndex = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ObjectWorkshopDock));
			this.sandDockManager1 = new TD.SandDock.SandDockManager();
			this.leftSandDock = new TD.SandDock.DockContainer();
			this.rightSandDock = new TD.SandDock.DockContainer();
			this.dcObjectWorkshop = new TD.SandDock.DockControl();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.wizard1 = new SimPe.Wizards.Wizard();
			this.wizardStepPanel1 = new SimPe.Wizards.WizardStepPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.wizardStepPanel2 = new SimPe.Wizards.WizardStepPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb = new System.Windows.Forms.ListBox();
			this.tv = new System.Windows.Forms.TreeView();
			this.wizardStepPanel3 = new SimPe.Wizards.WizardStepPanel();
			this.gbRecolor = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.cbColorExt = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.gbClone = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.cbanim = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbwallmask = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbparent = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbclean = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbfix = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbdefault = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbgid = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.cbTask = new TD.SandBar.FlatComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.wizardStepPanel4 = new SimPe.Wizards.WizardStepPanel();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biPrev = new TD.SandBar.ButtonItem();
			this.biNext = new TD.SandBar.ButtonItem();
			this.biFinish = new TD.SandBar.ButtonItem();
			this.biCatalog = new TD.SandBar.ButtonItem();
			this.bottomSandDock = new TD.SandDock.DockContainer();
			this.topSandDock = new TD.SandDock.DockContainer();
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.rightSandDock.SuspendLayout();
			this.dcObjectWorkshop.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.wizard1.SuspendLayout();
			this.wizardStepPanel1.SuspendLayout();
			this.wizardStepPanel2.SuspendLayout();
			this.wizardStepPanel3.SuspendLayout();
			this.gbRecolor.SuspendLayout();
			this.gbClone.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// sandDockManager1
			// 
			this.sandDockManager1.OwnerForm = this;
			// 
			// leftSandDock
			// 
			this.leftSandDock.Dock = System.Windows.Forms.DockStyle.Left;
			this.leftSandDock.Guid = new System.Guid("29c7afd3-bb98-4ad4-b3b8-b9c0bbf9aa5a");
			this.leftSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.leftSandDock.Location = new System.Drawing.Point(0, 0);
			this.leftSandDock.Manager = this.sandDockManager1;
			this.leftSandDock.Name = "leftSandDock";
			this.leftSandDock.Size = new System.Drawing.Size(0, 446);
			this.leftSandDock.TabIndex = 0;
			// 
			// rightSandDock
			// 
			this.rightSandDock.Controls.Add(this.dcObjectWorkshop);
			this.rightSandDock.Dock = System.Windows.Forms.DockStyle.Right;
			this.rightSandDock.Guid = new System.Guid("41289d25-7150-4714-9f24-9d6455431611");
			this.rightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											  new TD.SandDock.ControlLayoutSystem(260, 446, new TD.SandDock.DockControl[] {
																																																															  this.dcObjectWorkshop}, this.dcObjectWorkshop)});
			this.rightSandDock.Location = new System.Drawing.Point(360, 0);
			this.rightSandDock.Manager = this.sandDockManager1;
			this.rightSandDock.Name = "rightSandDock";
			this.rightSandDock.Size = new System.Drawing.Size(264, 446);
			this.rightSandDock.TabIndex = 1;
			// 
			// dcObjectWorkshop
			// 
			this.dcObjectWorkshop.AutoScroll = true;
			this.dcObjectWorkshop.AutoScrollMinSize = new System.Drawing.Size(260, 250);
			this.dcObjectWorkshop.Controls.Add(this.xpGradientPanel1);
			this.dcObjectWorkshop.FloatingSize = new System.Drawing.Size(260, 405);
			this.dcObjectWorkshop.Guid = new System.Guid("30ff233a-defb-4610-9db6-b342299947f4");
			this.dcObjectWorkshop.Location = new System.Drawing.Point(4, 18);
			this.dcObjectWorkshop.Name = "dcObjectWorkshop";
			this.dcObjectWorkshop.Size = new System.Drawing.Size(260, 405);
			this.dcObjectWorkshop.TabImage = ((System.Drawing.Image)(resources.GetObject("dcObjectWorkshop.TabImage")));
			this.dcObjectWorkshop.TabIndex = 0;
			this.dcObjectWorkshop.Text = "Object Workshop";
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.wizard1);
			this.xpGradientPanel1.Controls.Add(this.toolBar1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(260, 405);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// wizard1
			// 
			this.wizard1.BackColor = System.Drawing.Color.Transparent;
			this.wizard1.Controls.Add(this.wizardStepPanel1);
			this.wizard1.Controls.Add(this.wizardStepPanel2);
			this.wizard1.Controls.Add(this.wizardStepPanel3);
			this.wizard1.Controls.Add(this.wizardStepPanel4);
			this.wizard1.CurrentStepNumber = 0;
			this.wizard1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizard1.DockPadding.All = 8;
			this.wizard1.FinishEnabled = false;
			this.wizard1.Image = null;
			this.wizard1.Location = new System.Drawing.Point(0, 24);
			this.wizard1.Name = "wizard1";
			this.wizard1.NextEnabled = false;
			this.wizard1.PrevEnabled = false;
			this.wizard1.Size = new System.Drawing.Size(260, 381);
			this.wizard1.TabIndex = 4;
			this.wizard1.ChangedPrevState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedPrevState);
			this.wizard1.ChangedFinishState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedFinishState);
			this.wizard1.ChangedNextState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedNextState);
			this.wizard1.ShowStep += new SimPe.Wizards.WizardChangeHandle(this.wizard1_ShowStep);
			// 
			// wizardStepPanel1
			// 
			this.wizardStepPanel1.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel1.Controls.Add(this.button2);
			this.wizardStepPanel1.Controls.Add(this.label1);
			this.wizardStepPanel1.Controls.Add(this.label2);
			this.wizardStepPanel1.Controls.Add(this.button1);
			this.wizardStepPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel1.First = false;
			this.wizardStepPanel1.Last = false;
			this.wizardStepPanel1.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel1.Name = "wizardStepPanel1";
			this.wizardStepPanel1.Size = new System.Drawing.Size(244, 365);
			this.wizardStepPanel1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(24, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(112, 23);
			this.button2.TabIndex = 25;
			this.button2.Text = "Open...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(244, 32);
			this.label1.TabIndex = 22;
			this.label1.Text = "Welcome to the new Object Workshop. ";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(244, 60);
			this.label2.TabIndex = 23;
			this.label2.Text = "The Object Data is not yet loaded. Please choose \"Start\", to load the Object Brow" +
				"ser. Or click \"Open...\", to load a custom Package.";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(24, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 24;
			this.button1.Text = "Start";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// wizardStepPanel2
			// 
			this.wizardStepPanel2.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel2.Controls.Add(this.panel1);
			this.wizardStepPanel2.Controls.Add(this.lb);
			this.wizardStepPanel2.Controls.Add(this.tv);
			this.wizardStepPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel2.First = false;
			this.wizardStepPanel2.Last = false;
			this.wizardStepPanel2.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel2.Name = "wizardStepPanel2";
			this.wizardStepPanel2.Size = new System.Drawing.Size(244, 365);
			this.wizardStepPanel2.TabIndex = 1;
			this.wizardStepPanel2.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel2_Activate);
			this.wizardStepPanel2.Prepare += new SimPe.Wizards.WizardStepChangeHandle(this.wizardStepPanel2_Prepare);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 341);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(244, 24);
			this.panel1.TabIndex = 1;
			// 
			// lb
			// 
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb.Location = new System.Drawing.Point(0, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(244, 365);
			this.lb.TabIndex = 0;
			this.lb.Visible = false;
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
			// 
			// tv
			// 
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(0, 0);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(244, 365);
			this.tv.TabIndex = 2;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// wizardStepPanel3
			// 
			this.wizardStepPanel3.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel3.Controls.Add(this.gbRecolor);
			this.wizardStepPanel3.Controls.Add(this.gbClone);
			this.wizardStepPanel3.Controls.Add(this.panel2);
			this.wizardStepPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel3.First = false;
			this.wizardStepPanel3.Last = false;
			this.wizardStepPanel3.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel3.Name = "wizardStepPanel3";
			this.wizardStepPanel3.Size = new System.Drawing.Size(244, 365);
			this.wizardStepPanel3.TabIndex = 2;
			// 
			// gbRecolor
			// 
			this.gbRecolor.BackColor = System.Drawing.Color.Transparent;
			this.gbRecolor.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gbRecolor.BorderColor = System.Drawing.SystemColors.Window;
			this.gbRecolor.Controls.Add(this.cbColorExt);
			this.gbRecolor.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbRecolor.DockPadding.Bottom = 4;
			this.gbRecolor.DockPadding.Left = 4;
			this.gbRecolor.DockPadding.Right = 4;
			this.gbRecolor.DockPadding.Top = 44;
			this.gbRecolor.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.gbRecolor.HeaderText = "Recolor";
			this.gbRecolor.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gbRecolor.Icon = ((System.Drawing.Image)(resources.GetObject("gbRecolor.Icon")));
			this.gbRecolor.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.gbRecolor.Location = new System.Drawing.Point(0, 296);
			this.gbRecolor.Name = "gbRecolor";
			this.gbRecolor.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.gbRecolor.Size = new System.Drawing.Size(244, 76);
			this.gbRecolor.TabIndex = 1;
			this.gbRecolor.Visible = false;
			// 
			// cbColorExt
			// 
			this.cbColorExt.Checked = true;
			this.cbColorExt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbColorExt.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbColorExt.Location = new System.Drawing.Point(12, 48);
			this.cbColorExt.Name = "cbColorExt";
			this.cbColorExt.Size = new System.Drawing.Size(208, 24);
			this.cbColorExt.TabIndex = 5;
			this.cbColorExt.Text = "Create Color Extension Package";
			// 
			// gbClone
			// 
			this.gbClone.BackColor = System.Drawing.Color.Transparent;
			this.gbClone.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gbClone.BorderColor = System.Drawing.SystemColors.Window;
			this.gbClone.Controls.Add(this.cbanim);
			this.gbClone.Controls.Add(this.cbwallmask);
			this.gbClone.Controls.Add(this.cbparent);
			this.gbClone.Controls.Add(this.cbclean);
			this.gbClone.Controls.Add(this.cbfix);
			this.gbClone.Controls.Add(this.cbdefault);
			this.gbClone.Controls.Add(this.cbgid);
			this.gbClone.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbClone.DockPadding.Bottom = 4;
			this.gbClone.DockPadding.Left = 4;
			this.gbClone.DockPadding.Right = 4;
			this.gbClone.DockPadding.Top = 44;
			this.gbClone.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.gbClone.HeaderText = "Clone";
			this.gbClone.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gbClone.Icon = ((System.Drawing.Image)(resources.GetObject("gbClone.Icon")));
			this.gbClone.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.gbClone.Location = new System.Drawing.Point(0, 80);
			this.gbClone.Name = "gbClone";
			this.gbClone.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.gbClone.Size = new System.Drawing.Size(244, 216);
			this.gbClone.TabIndex = 0;
			// 
			// cbanim
			// 
			this.cbanim.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbanim.Location = new System.Drawing.Point(12, 188);
			this.cbanim.Name = "cbanim";
			this.cbanim.Size = new System.Drawing.Size(120, 24);
			this.cbanim.TabIndex = 16;
			this.cbanim.Text = "Pull Animations";
			// 
			// cbwallmask
			// 
			this.cbwallmask.Checked = true;
			this.cbwallmask.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbwallmask.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbwallmask.Location = new System.Drawing.Point(12, 164);
			this.cbwallmask.Name = "cbwallmask";
			this.cbwallmask.Size = new System.Drawing.Size(192, 24);
			this.cbwallmask.TabIndex = 15;
			this.cbwallmask.Text = "Pull Wallmasks (by Numenor)";
			// 
			// cbparent
			// 
			this.cbparent.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbparent.Location = new System.Drawing.Point(12, 116);
			this.cbparent.Name = "cbparent";
			this.cbparent.Size = new System.Drawing.Size(192, 24);
			this.cbparent.TabIndex = 14;
			this.cbparent.Text = "Create a stand-alone object";
			// 
			// cbclean
			// 
			this.cbclean.Checked = true;
			this.cbclean.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbclean.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbclean.Location = new System.Drawing.Point(24, 92);
			this.cbclean.Name = "cbclean";
			this.cbclean.Size = new System.Drawing.Size(272, 24);
			this.cbclean.TabIndex = 13;
			this.cbclean.Text = "Rem. useless Files (by  Numenor)";
			// 
			// cbfix
			// 
			this.cbfix.Checked = true;
			this.cbfix.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbfix.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbfix.Location = new System.Drawing.Point(12, 72);
			this.cbfix.Name = "cbfix";
			this.cbfix.Size = new System.Drawing.Size(224, 24);
			this.cbfix.TabIndex = 12;
			this.cbfix.Text = "Fix Cloned Files (by wes_h)";
			// 
			// cbdefault
			// 
			this.cbdefault.Checked = true;
			this.cbdefault.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbdefault.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbdefault.Location = new System.Drawing.Point(12, 140);
			this.cbdefault.Name = "cbdefault";
			this.cbdefault.Size = new System.Drawing.Size(224, 24);
			this.cbdefault.TabIndex = 11;
			this.cbdefault.Text = "Pull only default Color";
			// 
			// cbgid
			// 
			this.cbgid.Checked = true;
			this.cbgid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbgid.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cbgid.Location = new System.Drawing.Point(12, 48);
			this.cbgid.Name = "cbgid";
			this.cbgid.Size = new System.Drawing.Size(248, 24);
			this.cbgid.TabIndex = 10;
			this.cbgid.Text = "Set Custom Group ID (0x1c050000)";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.cbTask);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(244, 80);
			this.panel2.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(165, 48);
			this.button3.Name = "button3";
			this.button3.TabIndex = 2;
			this.button3.Text = "Start";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cbTask
			// 
			this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTask.Items.AddRange(new object[] {
														"Recolor",
														"Clone"});
			this.cbTask.Location = new System.Drawing.Point(8, 24);
			this.cbTask.Name = "cbTask";
			this.cbTask.Size = new System.Drawing.Size(232, 21);
			this.cbTask.TabIndex = 0;
			this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 8);
			this.label3.Name = "label3";
			this.label3.TabIndex = 1;
			this.label3.Text = "Task:";
			// 
			// wizardStepPanel4
			// 
			this.wizardStepPanel4.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel4.First = false;
			this.wizardStepPanel4.Last = true;
			this.wizardStepPanel4.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel4.Name = "wizardStepPanel4";
			this.wizardStepPanel4.Size = new System.Drawing.Size(244, 365);
			this.wizardStepPanel4.TabIndex = 3;
			this.wizardStepPanel4.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel4_Activate);
			this.wizardStepPanel4.Prepare += new SimPe.Wizards.WizardStepChangeHandle(this.wizardStepPanel4_Prepare);
			// 
			// toolBar1
			// 
			this.toolBar1.AddRemoveButtonsVisible = false;
			this.toolBar1.DockLine = 1;
			this.toolBar1.DrawActionsButton = false;
			this.toolBar1.FlipLastItem = true;
			this.toolBar1.Guid = new System.Guid("9261260f-4e3d-4d4f-8be9-9b0045f91adc");
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biPrev,
																			  this.biNext,
																			  this.biFinish,
																			  this.biCatalog});
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Hide;
			this.toolBar1.Renderer = new TD.SandBar.WhidbeyRenderer();
			this.toolBar1.Size = new System.Drawing.Size(260, 24);
			this.toolBar1.TabIndex = 17;
			this.toolBar1.Text = "toolBar1";
			// 
			// biPrev
			// 
			this.biPrev.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biPrev.Image = ((System.Drawing.Image)(resources.GetObject("biPrev.Image")));
			this.biPrev.ItemImportance = TD.SandBar.ItemImportance.Highest;
			this.biPrev.Text = "Previous  ";
			this.biPrev.Activate += new System.EventHandler(this.Activate_biPrev);
			// 
			// biNext
			// 
			this.biNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biNext.Image = ((System.Drawing.Image)(resources.GetObject("biNext.Image")));
			this.biNext.ItemImportance = TD.SandBar.ItemImportance.Highest;
			this.biNext.Text = "Next";
			this.biNext.Activate += new System.EventHandler(this.Activate_biNext);
			// 
			// biFinish
			// 
			this.biFinish.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biFinish.Image = ((System.Drawing.Image)(resources.GetObject("biFinish.Image")));
			this.biFinish.Text = "Finish";
			this.biFinish.Activate += new System.EventHandler(this.ActivateFinish);
			// 
			// biCatalog
			// 
			this.biCatalog.Checked = true;
			this.biCatalog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biCatalog.Text = "Catalog";
			this.biCatalog.Activate += new System.EventHandler(this.Activate_biCatalog);
			// 
			// bottomSandDock
			// 
			this.bottomSandDock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomSandDock.Guid = new System.Guid("89638049-982a-4d00-a8f1-23a966528555");
			this.bottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.bottomSandDock.Location = new System.Drawing.Point(0, 446);
			this.bottomSandDock.Manager = this.sandDockManager1;
			this.bottomSandDock.Name = "bottomSandDock";
			this.bottomSandDock.Size = new System.Drawing.Size(624, 0);
			this.bottomSandDock.TabIndex = 2;
			// 
			// topSandDock
			// 
			this.topSandDock.Dock = System.Windows.Forms.DockStyle.Top;
			this.topSandDock.Guid = new System.Guid("f0ca2696-d087-40e9-9fa1-82816573a9f7");
			this.topSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.topSandDock.Location = new System.Drawing.Point(0, 0);
			this.topSandDock.Manager = this.sandDockManager1;
			this.topSandDock.Name = "topSandDock";
			this.topSandDock.Size = new System.Drawing.Size(624, 0);
			this.topSandDock.TabIndex = 3;
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = new System.Drawing.Size(16, 16);
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ObjectWorkshopDock
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(624, 446);
			this.Controls.Add(this.leftSandDock);
			this.Controls.Add(this.rightSandDock);
			this.Controls.Add(this.bottomSandDock);
			this.Controls.Add(this.topSandDock);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ObjectWorkshopDock";
			this.Text = "ObjectWorkshopDock";
			this.rightSandDock.ResumeLayout(false);
			this.dcObjectWorkshop.ResumeLayout(false);
			this.xpGradientPanel1.ResumeLayout(false);
			this.wizard1.ResumeLayout(false);
			this.wizardStepPanel1.ResumeLayout(false);
			this.wizardStepPanel2.ResumeLayout(false);
			this.wizardStepPanel3.ResumeLayout(false);
			this.gbRecolor.ResumeLayout(false);
			this.gbClone.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void wizard1_ChangedFinishState(SimPe.Wizards.Wizard sender)
		{
			biFinish.Enabled = sender.FinishEnabled;
		}

		private void wizard1_ChangedNextState(SimPe.Wizards.Wizard sender)
		{
			biNext.Enabled = sender.NextEnabled;
		}

		private void wizard1_ChangedPrevState(SimPe.Wizards.Wizard sender)
		{			
			biPrev.Enabled = sender.PrevEnabled;
		}

		private void Activate_biPrev(object sender, System.EventArgs e)
		{
			wizard1.GoPrev();
		}

		private void Activate_biNext(object sender, System.EventArgs e)
		{
			wizard1.GoNext();
		}

		private void ActivateFinish(object sender, System.EventArgs e)
		{
			wizard1.Finish();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Activate_biNext(biNext, e);
		}

		private void wizardStepPanel2_Prepare(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardStepPanel step, int target)
		{
			if (target==step.Index) 
			{
				if (lb.Items.Count==0) 
				{			
					lastselected = null;
					this.ilist.Images.Clear();
					this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.subitems.png")));
					this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.nothumb.png")));
					this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.custom.png")));

					lb.Items.Clear();
					lb.Sorted = false;
					tv.Nodes.Clear();
					tv.Sorted = true;
					tv.ImageList = ilist;
				
					ObjectLoader ol = new ObjectLoader(null);
					ol.LoadedItem += new SimPe.Plugin.Tool.Dockable.ObjectLoader.LoadItemHandler(ol_LoadedItem);
					ol.Finished += new EventHandler(ol_Finished);
					ol.LoadData();				
				}
			}
		}

		delegate TreeNode GetParentNodeHandler(TreeNodeCollection nodes, string[] names, int id, SimPe.Cache.ObjectCacheItem oci, SimPe.Data.Alias a);
		TreeNode GetParentNode(TreeNodeCollection nodes, string[] names, int id, SimPe.Cache.ObjectCacheItem oci, SimPe.Data.Alias a)
		{	
			TreeNode ret = null;
			if (id<names.Length) 
			{	
				string name = names[id];
				foreach (TreeNode tn in nodes) 
				{
					if (tn.Text.Trim().ToLower() == name.Trim().ToLower())
					{
						ret = tn;
						if (id<names.Length-1) 
							ret = GetParentNode(tn.Nodes, names, id+1, oci, a);

						break;
					}
				}
			}

			if (ret==null) 
			{
				if (id<names.Length) ret = new TreeNode(names[id]);
				else ret = new TreeNode(SimPe.Localization.GetString("Unknown"));

				nodes.Add(ret);
				ret.SelectedImageIndex = 0;
				ret.ImageIndex = 0;
			}

			if (id==0) 
			{
				TreeNode tn = new TreeNode(a.ToString());
				tn.Tag = a;

				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag;
				string flname = "";
				if (fii.Package!=null)
					if (fii.Package.FileName!=null)
						flname = fii.Package.FileName.Trim().ToLower();

				if (flname.StartsWith(Helper.WindowsRegistry.SimSavegameFolder.Trim().ToLower())) 
				{
					tn.ImageIndex = 2;
				}
				else if (oci.Thumbnail!=null) 
				{
					Image img = oci.Thumbnail;
					//if (Helper.WindowsRegistry.GraphQuality) img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new System.Drawing.Point(0,0), System.Drawing.Color.Magenta);
					img = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, ilist.ImageSize.Width, ilist.ImageSize.Height, Helper.WindowsRegistry.GraphQuality);

					ilist.Images.Add(img);
					tn.ImageIndex = ilist.Images.Count-1;					
				}
				else
					tn.ImageIndex = 1;
				tn.SelectedImageIndex = tn.ImageIndex;
				ret.Nodes.Add(tn);
			}
			return ret;
		}

		private void ol_LoadedItem(SimPe.Cache.ObjectCacheItem oci, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Data.Alias a)
		{
			if (a==null) return;

			
			string[][] cats = oci.ObjectCategory;
			foreach (string[] ss in cats)				
			{
				this.tv.BeginInvoke(new GetParentNodeHandler(GetParentNode), new object[] {tv.Nodes, ss, 0, oci, a});				
			}

			if (oci.Thumbnail!=null) a.Name = "* "+a.Name;				
			lb.Items.Add(a);			
		}

		private void ol_Finished(object sender, EventArgs e)
		{
			lb.Sorted = true;	
		}

		private void Activate_biCatalog(object sender, System.EventArgs e)
		{
			biCatalog.Checked = !biCatalog.Checked;
			this.tv.Visible = biCatalog.Checked;
			this.lb.Visible = !biCatalog.Checked;
			
			lb_SelectedIndexChanged(lb, null);
			tv_AfterSelect(tv, null);
		}

		private void wizard1_ShowStep(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardEventArgs e)
		{
			this.biCatalog.Visible = (e.Step.Index==wizardStepPanel2.Index);			
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			wizard1.JumpToStep(2);
		}

		Data.Alias lastselected;
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (wizard1.CurrentStepNumber==this.wizardStepPanel2.Index && tv.Visible) 
			{
				if (tv.SelectedNode==null) wizard1.NextEnabled = false;
				else wizard1.NextEnabled = tv.SelectedNode.Tag!=null;
			}

			if (wizard1.NextEnabled) 
			{
				lastselected = (Data.Alias)tv.SelectedNode.Tag;
			} else lastselected = null;
		}

		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (wizard1.CurrentStepNumber==this.wizardStepPanel2.Index && lb.Visible) 
			{
				wizard1.NextEnabled = (lb.SelectedIndex>=0);
			}	
		
			if (wizard1.NextEnabled) 
			{
				lastselected = (Data.Alias)lb.SelectedItem;
			} 
			else lastselected = null;
		}

		private void cbTask_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbTask.SelectedIndex==1) 
			{
				gbRecolor.Visible = false;
				gbClone.Visible = true;
			} 
			else 
			{
				gbRecolor.Visible = true;
				gbClone.Visible = false;
			}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			Activate_biNext(biNext, e);
		}

		private void wizardStepPanel2_Activate(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardEventArgs e)
		{
			if (tv.Visible) 
			{
				if (tv.SelectedNode==null) e.EnableNext = false;
				else if (tv.SelectedNode.Tag==null) e.EnableNext = false;
				else e.EnableNext = true;
			} 
			else 
			{
				e.EnableNext = lb.SelectedIndex>=0;
			}
		}

		private void wizardStepPanel4_Prepare(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardStepPanel step, int target)
		{
			
		}
		SimPe.Packages.GeneratableFile package;

		/// <summary>
		/// Clone an object based on way Files are linked
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="localgroup"></param>
		/// <param name="onlydefault"></param>
		protected void RecolorClone(Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, bool onlydefault, bool wallmask, bool anim) 
		{
			package = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);

			//Get the Base Object Data from the Objects.package File
			string[] modelname = BaseClone(pfd, localgroup, package);
			ObjectCloner objclone = new ObjectCloner(package);
			ArrayList exclude = new ArrayList();

			

			//allways for recolors
			if (this.gbRecolor.Visible) 
			{
				exclude.Add("stdMatEnvCubeTextureName");
				exclude.Add("TXTR");
			} 
			else 
			{
				exclude.Add("tsMaterialsMeshName");
				

				//for clones only when cbparent is not checked
				//if (!this.cbparent.Checked) 
			{					
				exclude.Add("TXTR");
				exclude.Add("stdMatEnvCubeTextureName");					
			} 
			}

			//do the recolor
			objclone.Setup.OnlyDefaultMmats = onlydefault;
			objclone.Setup.UpdateMmatGuids = onlydefault;
			objclone.Setup.IncludeWallmask = wallmask;
			objclone.Setup.IncludeAnimationResources = anim;
			objclone.RcolModelClone(modelname, exclude);

			//for clones only when cbparent is checked
			if ((this.cbparent.Checked) && (!this.gbRecolor.Visible)) 
			{
				string[] names = Scenegraph.LoadParentModelNames(package, true);
				SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(null);

				ObjectCloner pobj = new ObjectCloner(pkg);
				pobj.Setup.OnlyDefaultMmats = onlydefault;
				pobj.Setup.UpdateMmatGuids = onlydefault;
				pobj.Setup.IncludeWallmask = wallmask;
				pobj.Setup.IncludeAnimationResources = anim;
				pobj.RcolModelClone(names, exclude);
				pobj.AddParentFiles(modelname, package);				
			}

			//for clones only when cbparent is not checked
			if ((!this.cbparent.Checked) && (!this.gbRecolor.Visible)) 
			{
				string[] modelnames = modelname;
				if (!cbclean.Checked) modelnames = null;
				objclone.RemoveSubsetReferences(Scenegraph.GetParentSubsets(package), modelnames);
			}
		}

		//SimPe.Packages.File[] objpkgs = null;
		/// <summary>
		/// Reads all Data from the Objects.package blonging to the same group as the passed pfd
		/// </summary>
		/// <param name="pfd">Desciptor for one of files belonging to the Object (Name Map)</param>
		/// <param name="objpkg">The Object Package you wanna process</param>
		/// <param name="package">The package that should get the Files</param>
		/// <returns>The Modlename of that Object or null if none</returns>
		public static string[] BaseClone(Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup, SimPe.Packages.File package) 
		{
			//Get the Base Object Data from the Objects.package File
			
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] files = FileTable.FileIndex.FindFileByGroup(localgroup);

			ArrayList list = new ArrayList();
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in files) 
			{
				Interfaces.Files.IPackedFile file = item.Package.Read(item.FileDescriptor);

				SimPe.Packages.PackedFileDescriptor npfd = new SimPe.Packages.PackedFileDescriptor();

				npfd.UserData = file.UncompressedData;
				npfd.Group = item.FileDescriptor.Group;
				npfd.Instance = item.FileDescriptor.Instance;
				npfd.SubType = item.FileDescriptor.SubType;
				npfd.Type = item.FileDescriptor.Type;

				if (package.FindFile(npfd)==null)
					package.Add(npfd);

				if ((npfd.Instance == 0x85) && (npfd.Type == Data.MetaData.STRING_FILE)) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
					str.ProcessData(npfd, item.Package);
					SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
					for (int i=1; i<items.Length; i++) list.Add(items[i].Title);
					//if (items.Length>1) refname = items[1].Title;
				}
			}

			string[] refname = new string[list.Count];
			list.CopyTo(refname);

			return refname;
		}

		protected void ReColor(Interfaces.Files.IPackedFileDescriptor pfd, uint localgroup) 
		{
			// we need packages in the Gmaes and the Download Folder
			
			if (( (!System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) || (!System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) ) && (!this.gbRecolor.Visible)) 
			{
				if (MessageBox.Show(Localization.Manager.GetString("OW_Warning"), "Warning", MessageBoxButtons.YesNo)==DialogResult.No) return;
			}

			if (this.cbColorExt.Checked) if (sfd.ShowDialog()!=DialogResult.OK) return;			

			//create a Cloned Object to get all needed Files for the Process
			bool old = cbgid.Checked;
			cbgid.Checked = false;
			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Collecting needed Files");
			if ((package==null) && (pfd!=null)) RecolorClone(pfd, localgroup, false, false, false);
			WaitingScreen.Stop(this);

			cbgid.Checked = old;
			
			if (this.gbRecolor.Visible) 
			{
				ObjectRecolor or = new ObjectRecolor(package);
				or.EnableColorOptions();
				or.LoadReferencedMATDs();				

				//load all Pending Textures
				ObjectCloner oc = new ObjectCloner(package);				
			}

			SimPe.Packages.GeneratableFile dn_pkg = null;
			if (System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) dn_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.GMND_PACKAGE);
			else dn_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);

			SimPe.Packages.GeneratableFile gm_pkg = null;
			if (System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) gm_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.MMAT_PACKAGE);
			else gm_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
			
			SimPe.Packages.GeneratableFile npackage = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
			//Create the Templae for an additional MMAT
			if (this.cbColorExt.Checked) 
			{
	
				npackage.FileName = sfd.FileName;	

				ColorOptions cs = new ColorOptions(package);
				cs.Create(npackage);

				npackage.Save();
				package = npackage;
			}			

			WaitingScreen.Stop(this);
#if DEBUG
#else
			if (package!=npackage) package = null;			
#endif
		}

		private void wizardStepPanel4_Activate(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardEventArgs e)
		{
			if (lastselected ==null) 
			{
				e.CanFinish = false;
			} 
			else 
			{				
				SimPe.Interfaces.IAlias a = this.lastselected;
				Interfaces.Files.IPackedFileDescriptor pfd =(Interfaces.Files.IPackedFileDescriptor)a.Tag[0];			
				uint localgroup = (uint)a.Tag[1];

				if (this.gbClone.Visible) 
				{
					package = null;
					this.RecolorClone(pfd, localgroup, this.cbdefault.Checked, this.cbwallmask.Checked, this.cbanim.Checked);
					FixObject fo = new FixObject(package, FixVersion.UniversityReady);
					System.Collections.Hashtable map = null;
					
					if (this.cbfix.Checked) 
					{
						map = fo.GetNameMap(true);
						if (map==null) return;
				
						if (sfd.ShowDialog()==DialogResult.OK) 
						{
							WaitingScreen.Wait();
							package.FileName = sfd.FileName;
							fo.Fix(map, true);

							if (cbclean.Checked) fo.CleanUp();
							package.Save();
							
						} 
						else 
						{
							package = null;
						}
					}

					if ((this.cbgid.Checked) && (package!=null))
					{
						WaitingScreen.Wait();
						fo.FixGroup();
						if (this.cbfix.Checked) package.Save();
					}

					//select a resource to display in SimPE
					pfd=null;
					if (package!=null) 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
						if (pfds.Length>0) pfd = pfds[0];
					} 
				} 
				else 
				{
					package = null;
					ReColor(pfd, localgroup);

					//select a resource for display in SimPE
					pfd=null;
					if (package!=null) 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.TXTR);
						if (pfds.Length>0) pfd = pfds[0];
					} 
				}

				bool res = false;
				if (package!=null) 
					if (SimPe.RemoteControl.OpenMemoryPackage(package) && pfd!=null)
						res = SimPe.RemoteControl.OpenPackedFile(pfd, package);


				WaitingScreen.Stop();
			}
		}

		
	}
}
