using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using TD.SandDock;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Summary description for DoackableObjectWorkshop.
	/// </summary>
	public class dcObjectWorkshop : TD.SandDock.UserDockableWindow
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private SimPe.Wizards.Wizard wizard1;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel2;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple2;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel3;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple1;
		private Ambertation.Windows.Forms.XPTaskBoxSimple gbRecolor;
		private Ambertation.Windows.Forms.TransparentCheckBox cbColorExt;
		private Ambertation.Windows.Forms.XPTaskBoxSimple gbClone;
		private Ambertation.Windows.Forms.TransparentCheckBox cbanim;
		private Ambertation.Windows.Forms.TransparentCheckBox cbwallmask;
		private Ambertation.Windows.Forms.TransparentCheckBox cbparent;
		private Ambertation.Windows.Forms.TransparentCheckBox cbclean;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfix;
		private Ambertation.Windows.Forms.TransparentCheckBox cbdefault;
		private Ambertation.Windows.Forms.TransparentCheckBox cbgid;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button3;
		private TD.SandBar.FlatComboBox cbTask;
		private System.Windows.Forms.Label label3;
		private SimPe.Wizards.WizardStepPanel wizardStepPanel4;
		private System.Windows.Forms.Panel pnWait;
		private System.Windows.Forms.Label lberr;
		private System.Windows.Forms.Label lbfinload;
		private System.Windows.Forms.Label lbwait;
		private Ambertation.Windows.Forms.AnimatedImagelist animatedImagelist1;
		private System.Windows.Forms.Label lbfinished;
		private TD.SandBar.ToolBar toolBar1;
		private TD.SandBar.ButtonItem biPrev;
		private TD.SandBar.ButtonItem biNext;
		private TD.SandBar.ButtonItem biFinish;
		private TD.SandBar.ButtonItem biAbort;
		private TD.SandBar.ButtonItem biCatalog;
		private SimPe.Plugin.Tool.Dockable.ObjectPreview op1;
		private System.Windows.Forms.Label label4;
		private SimPe.Plugin.Tool.Dockable.ObjectPreview op2;
		private System.Windows.Forms.ImageList ilist;
		private System.ComponentModel.IContainer components;

		public dcObjectWorkshop()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			wizard1.Start();
			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.toolBar1);
			tm.AddControl(this.splitter1);

			biFinish.Visible = wizard1.FinishEnabled;
			this.biAbort.Visible = wizard1.PrevEnabled;
			biNext.Enabled = wizard1.NextEnabled;
			biPrev.Enabled = wizard1.PrevEnabled;

			this.cbTask.SelectedIndex = 0;
			ilist.ImageSize = new Size(Helper.WindowsRegistry.OWThumbSize, Helper.WindowsRegistry.OWThumbSize);
			this.Guid = new System.Guid("42807573-e8db-405b-95fa-28913d1e292a");
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(dcObjectWorkshop));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.wizard1 = new SimPe.Wizards.Wizard();
			this.wizardStepPanel1 = new SimPe.Wizards.WizardStepPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.wizardStepPanel2 = new SimPe.Wizards.WizardStepPanel();
			this.lb = new System.Windows.Forms.ListBox();
			this.tv = new System.Windows.Forms.TreeView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.xpTaskBoxSimple2 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.wizardStepPanel3 = new SimPe.Wizards.WizardStepPanel();
			this.xpTaskBoxSimple1 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
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
			this.pnWait = new System.Windows.Forms.Panel();
			this.lberr = new System.Windows.Forms.Label();
			this.lbfinload = new System.Windows.Forms.Label();
			this.lbwait = new System.Windows.Forms.Label();
			this.animatedImagelist1 = new Ambertation.Windows.Forms.AnimatedImagelist();
			this.lbfinished = new System.Windows.Forms.Label();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biPrev = new TD.SandBar.ButtonItem();
			this.biNext = new TD.SandBar.ButtonItem();
			this.biFinish = new TD.SandBar.ButtonItem();
			this.biAbort = new TD.SandBar.ButtonItem();
			this.biCatalog = new TD.SandBar.ButtonItem();
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.xpGradientPanel1.SuspendLayout();
			this.wizard1.SuspendLayout();
			this.wizardStepPanel1.SuspendLayout();
			this.wizardStepPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.wizardStepPanel3.SuspendLayout();
			this.gbRecolor.SuspendLayout();
			this.gbClone.SuspendLayout();
			this.panel2.SuspendLayout();
			this.wizardStepPanel4.SuspendLayout();
			this.pnWait.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.wizard1);
			this.xpGradientPanel1.Controls.Add(this.toolBar1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(336, 541);
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
			this.wizard1.Size = new System.Drawing.Size(336, 517);
			this.wizard1.TabIndex = 4;
			this.wizard1.ChangedPrevState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedPrevState);
			this.wizard1.ChangedFinishState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedFinishState);
			this.wizard1.ChangedNextState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedNextState);
			this.wizard1.ShowStep += new SimPe.Wizards.WizardChangeHandle(this.wizard1_ShowStep);
			// 
			// wizardStepPanel1
			// 
			this.wizardStepPanel1.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel1.Controls.Add(this.label4);
			this.wizardStepPanel1.Controls.Add(this.button2);
			this.wizardStepPanel1.Controls.Add(this.label1);
			this.wizardStepPanel1.Controls.Add(this.label2);
			this.wizardStepPanel1.Controls.Add(this.button1);
			this.wizardStepPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel1.First = false;
			this.wizardStepPanel1.Last = false;
			this.wizardStepPanel1.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel1.Name = "wizardStepPanel1";
			this.wizardStepPanel1.Size = new System.Drawing.Size(320, 501);
			this.wizardStepPanel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label4.Location = new System.Drawing.Point(0, 453);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(320, 48);
			this.label4.TabIndex = 26;
			this.label4.Text = "Biggest thanks go to Numenor and RGiles for making the Object Workshop possible i" +
				"n the first place, and their constant help in the developing process.";
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
			this.label1.Size = new System.Drawing.Size(320, 32);
			this.label1.TabIndex = 22;
			this.label1.Text = "Welcome to the new Object Workshop. ";
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 60);
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
			this.wizardStepPanel2.Controls.Add(this.lb);
			this.wizardStepPanel2.Controls.Add(this.tv);
			this.wizardStepPanel2.Controls.Add(this.splitter1);
			this.wizardStepPanel2.Controls.Add(this.panel1);
			this.wizardStepPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel2.First = false;
			this.wizardStepPanel2.Last = false;
			this.wizardStepPanel2.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel2.Name = "wizardStepPanel2";
			this.wizardStepPanel2.Size = new System.Drawing.Size(320, 501);
			this.wizardStepPanel2.TabIndex = 1;
			this.wizardStepPanel2.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel2_Activate);
			this.wizardStepPanel2.Prepare += new SimPe.Wizards.WizardStepChangeHandle(this.wizardStepPanel2_Prepare);
			// 
			// lb
			// 
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb.Location = new System.Drawing.Point(0, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(320, 351);
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
			this.tv.Size = new System.Drawing.Size(320, 362);
			this.tv.TabIndex = 2;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.SystemColors.Highlight;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 362);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(320, 3);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.xpTaskBoxSimple2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 365);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(320, 136);
			this.panel1.TabIndex = 1;
			// 
			// xpTaskBoxSimple2
			// 
			this.xpTaskBoxSimple2.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple2.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple2.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpTaskBoxSimple2.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple2.DockPadding.Left = 4;
			this.xpTaskBoxSimple2.DockPadding.Right = 4;
			this.xpTaskBoxSimple2.DockPadding.Top = 44;
			this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple2.HeaderText = "Selected Object";
			this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple2.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple2.Icon")));
			this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple2.Location = new System.Drawing.Point(0, 0);
			this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
			this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple2.Size = new System.Drawing.Size(320, 136);
			this.xpTaskBoxSimple2.TabIndex = 4;
			// 
			// wizardStepPanel3
			// 
			this.wizardStepPanel3.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel3.Controls.Add(this.xpTaskBoxSimple1);
			this.wizardStepPanel3.Controls.Add(this.gbRecolor);
			this.wizardStepPanel3.Controls.Add(this.gbClone);
			this.wizardStepPanel3.Controls.Add(this.panel2);
			this.wizardStepPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel3.First = false;
			this.wizardStepPanel3.Last = false;
			this.wizardStepPanel3.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel3.Name = "wizardStepPanel3";
			this.wizardStepPanel3.Size = new System.Drawing.Size(320, 501);
			this.wizardStepPanel3.TabIndex = 2;
			this.wizardStepPanel3.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel3_Activate);
			this.wizardStepPanel3.Activated += new SimPe.Wizards.WizardStepHandle(this.wizardStepPanel3_Activated);
			// 
			// xpTaskBoxSimple1
			// 
			this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpTaskBoxSimple1.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple1.DockPadding.Left = 4;
			this.xpTaskBoxSimple1.DockPadding.Right = 4;
			this.xpTaskBoxSimple1.DockPadding.Top = 44;
			this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple1.HeaderText = "Selected Object";
			this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple1.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple1.Icon")));
			this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple1.Location = new System.Drawing.Point(0, 372);
			this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
			this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple1.Size = new System.Drawing.Size(320, 129);
			this.xpTaskBoxSimple1.TabIndex = 3;
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
			this.gbRecolor.Size = new System.Drawing.Size(320, 76);
			this.gbRecolor.TabIndex = 1;
			this.gbRecolor.Visible = false;
			// 
			// cbColorExt
			// 
			this.cbColorExt.Checked = true;
			this.cbColorExt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbColorExt.Enabled = false;
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
			this.gbClone.Size = new System.Drawing.Size(320, 216);
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
			this.cbfix.CheckedChanged += new System.EventHandler(this.cbfix_CheckedChanged);
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
			this.panel2.Size = new System.Drawing.Size(320, 80);
			this.panel2.TabIndex = 2;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(235, 48);
			this.button3.Name = "button3";
			this.button3.TabIndex = 2;
			this.button3.Text = "Start";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cbTask
			// 
			this.cbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTask.Items.AddRange(new object[] {
														"Recolor",
														"Clone"});
			this.cbTask.Location = new System.Drawing.Point(8, 24);
			this.cbTask.Name = "cbTask";
			this.cbTask.Size = new System.Drawing.Size(302, 21);
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
			this.wizardStepPanel4.Controls.Add(this.pnWait);
			this.wizardStepPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.wizardStepPanel4.First = false;
			this.wizardStepPanel4.Last = true;
			this.wizardStepPanel4.Location = new System.Drawing.Point(8, 8);
			this.wizardStepPanel4.Name = "wizardStepPanel4";
			this.wizardStepPanel4.Size = new System.Drawing.Size(320, 501);
			this.wizardStepPanel4.TabIndex = 3;
			this.wizardStepPanel4.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel4_Activate);
			this.wizardStepPanel4.Activated += new SimPe.Wizards.WizardStepHandle(this.wizardStepPanel4_Activated);
			// 
			// pnWait
			// 
			this.pnWait.Controls.Add(this.lberr);
			this.pnWait.Controls.Add(this.lbfinload);
			this.pnWait.Controls.Add(this.lbwait);
			this.pnWait.Controls.Add(this.animatedImagelist1);
			this.pnWait.Controls.Add(this.lbfinished);
			this.pnWait.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnWait.Location = new System.Drawing.Point(0, 0);
			this.pnWait.Name = "pnWait";
			this.pnWait.Size = new System.Drawing.Size(320, 80);
			this.pnWait.TabIndex = 0;
			// 
			// lberr
			// 
			this.lberr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lberr.Location = new System.Drawing.Point(32, 16);
			this.lberr.Name = "lberr";
			this.lberr.Size = new System.Drawing.Size(280, 56);
			this.lberr.TabIndex = 4;
			this.lberr.Text = "SimPE was unable to create the Object. A possible reason could be, that the selec" +
				"ted Object is not CEP enabled, or that you did Interrupt the creation process.";
			// 
			// lbfinload
			// 
			this.lbfinload.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbfinload.Location = new System.Drawing.Point(32, 8);
			this.lbfinload.Name = "lbfinload";
			this.lbfinload.Size = new System.Drawing.Size(192, 23);
			this.lbfinload.TabIndex = 3;
			this.lbfinload.Text = "Object was created and loaded.";
			this.lbfinload.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lbwait
			// 
			this.lbwait.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbwait.Location = new System.Drawing.Point(32, 8);
			this.lbwait.Name = "lbwait";
			this.lbwait.Size = new System.Drawing.Size(80, 23);
			this.lbwait.TabIndex = 1;
			this.lbwait.Text = "Please Wait";
			this.lbwait.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// animatedImagelist1
			// 
			this.animatedImagelist1.BackColor = System.Drawing.Color.Transparent;
			this.animatedImagelist1.CurrentIndex = 0;
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
			this.animatedImagelist1.Location = new System.Drawing.Point(8, 16);
			this.animatedImagelist1.Name = "animatedImagelist1";
			this.animatedImagelist1.Size = new System.Drawing.Size(16, 16);
			this.animatedImagelist1.TabIndex = 0;
			// 
			// lbfinished
			// 
			this.lbfinished.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbfinished.Location = new System.Drawing.Point(32, 8);
			this.lbfinished.Name = "lbfinished";
			this.lbfinished.Size = new System.Drawing.Size(120, 23);
			this.lbfinished.TabIndex = 2;
			this.lbfinished.Text = "Object was created.";
			this.lbfinished.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
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
																			  this.biAbort,
																			  this.biCatalog});
			this.toolBar1.Location = new System.Drawing.Point(0, 0);
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Hide;
			this.toolBar1.Renderer = new TD.SandBar.WhidbeyRenderer();
			this.toolBar1.Size = new System.Drawing.Size(336, 24);
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
			// biAbort
			// 
			this.biAbort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biAbort.Image = ((System.Drawing.Image)(resources.GetObject("biAbort.Image")));
			this.biAbort.Text = "Startover";
			this.biAbort.Activate += new System.EventHandler(this.biAbort_Activate);
			// 
			// biCatalog
			// 
			this.biCatalog.Checked = true;
			this.biCatalog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biCatalog.Text = "Catalog";
			this.biCatalog.Activate += new System.EventHandler(this.Activate_biCatalog);
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = new System.Drawing.Size(16, 16);
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// dcObjectWorkshop
			// 
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(298, 465);
			this.Controls.Add(this.xpGradientPanel1);
			this.FloatingSize = new System.Drawing.Size(300, 550);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "dcObjectWorkshop";
			this.Size = new System.Drawing.Size(336, 541);
			this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
			this.Text = "Object Workshop";
			this.xpGradientPanel1.ResumeLayout(false);
			this.wizard1.ResumeLayout(false);
			this.wizardStepPanel1.ResumeLayout(false);
			this.wizardStepPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.wizardStepPanel3.ResumeLayout(false);
			this.gbRecolor.ResumeLayout(false);
			this.gbClone.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.wizardStepPanel4.ResumeLayout(false);
			this.pnWait.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void wizard1_ChangedFinishState(SimPe.Wizards.Wizard sender)
		{
			biFinish.Visible = sender.FinishEnabled;
		}

		private void wizard1_ChangedNextState(SimPe.Wizards.Wizard sender)
		{
			biNext.Enabled = sender.NextEnabled;
		}

		private void wizard1_ChangedPrevState(SimPe.Wizards.Wizard sender)
		{			
			biPrev.Enabled = sender.PrevEnabled;
			this.biAbort.Visible = biPrev.Enabled;
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
			if (wizard1.CurrentStep == this.wizardStepPanel3) Activate_biNext(sender, e);
			else wizard1.Finish();
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
					tv.Enabled = false;
					lb.Enabled = false;
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

		delegate TreeNode GetParentNodeHandler(TreeNodeCollection nodes, string[] names, int id, SimPe.Cache.ObjectCacheItem oci, SimPe.Data.Alias a, ImageList ilist);
		

		private void ol_LoadedItem(SimPe.Cache.ObjectCacheItem oci, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Data.Alias a)
		{
			if (a==null) return;

			
			string[][] cats = oci.ObjectCategory;
			foreach (string[] ss in cats)				
			{
				this.tv.BeginInvoke(new GetParentNodeHandler(ObjectLoader.GetParentNode), new object[] {tv.Nodes, ss, 0, oci, a, ilist});				
			}

			//if (oci.Thumbnail!=null) a.Name = "* "+a.Name;				
			lb.Items.Add(a);			
		}

		private void ol_Finished(object sender, EventArgs e)
		{
			lb.Sorted = true;	
			tv.Enabled = true;
			lb.Enabled = true;
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
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);

			package = null;
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				package = SimPe.Packages.GeneratableFile.LoadFromFile(ofd.FileName);
				wizard1.JumpToStep(2);
			}
		}

		SimPe.Packages.GeneratableFile package;
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
			} 
			else lastselected = null;
					
			UpdateObjectPreview(op1);
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
					
			UpdateObjectPreview(op1);
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
			

			package = null;
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

			tv.SelectedNode = null;
			lb.SelectedIndex = -1;
		}		
		

		private void wizardStepPanel4_Activate(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardEventArgs e)
		{
			e.CanFinish = false;			 
			
			this.animatedImagelist1.Stop();
			this.lbwait.Visible = true;
			this.lbfinished.Visible = false;
			this.lbfinload.Visible = false;
			this.lberr.Visible = false;
		}

		private void wizardStepPanel4_Activated(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardStepPanel step)
		{
			this.animatedImagelist1.Start();
			SimPe.Packages.GeneratableFile package = null;
			if (lastselected ==null && this.package==null) 
			{
				sender.FinishEnabled = false;
			} 
			else 
			{				
				FileTable.FileIndex.Load();
				SimPe.Interfaces.IAlias a = null;
				Interfaces.Files.IPackedFileDescriptor pfd = null;
				uint localgroup = Data.MetaData.LOCAL_GROUP;
				if (this.package!=null) 
				{
					if (this.package.FileName!=null) 
					{
						SimPe.Interfaces.Wrapper.IGroupCacheItem gci = SimPe.FileTable.GroupCache.GetItem(this.package.FileName);
						if (gci!=null) localgroup = gci.LocalGroup;
					}
				} 
				else 
				{
					a = this.lastselected;
					pfd =(Interfaces.Files.IPackedFileDescriptor)a.Tag[0];			
					localgroup = (uint)a.Tag[1];
				}
				
				ObjectWorkshopSettings settings;

				//Clone an Object
				if (this.cbTask.SelectedIndex==1) 
				{
					OWCloneSettings cs = new OWCloneSettings();
					cs.IncludeWallmask = this.cbwallmask.Checked;
					cs.OnlyDefaultMmats = this.cbdefault.Checked;
					cs.IncludeAnimationResources = this.cbanim.Checked;
					cs.CustomGroup = this.cbgid.Checked;
					cs.FixResources = this.cbfix.Checked;
					cs.RemoveUselessResource = this.cbclean.Checked;
					cs.StandAloneObject = this.cbparent.Checked;

					settings = cs;
				} 					
				else  //Recolor a Object
				
					settings = new OWRecolorSettings();
				
				try 
				{
					package = ObjectWorkshopHelper.Start(this.package, a, ref pfd, localgroup, settings);
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(ex);
				}

				


				this.animatedImagelist1.Stop();
				if (package!=null) this.lbfinload.Visible = settings.RemoteResult;
				else this.lberr.Visible = true;
				
			}

			this.lbwait.Visible = false;
			this.lbfinished.Visible = !this.lbfinload.Visible && !lberr.Visible;
		}

		private void wizardStepPanel3_Activate(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardEventArgs e)
		{			
			e.CanFinish = lastselected!=null;
			e.EnableNext = false;		
			UpdateObjectPreview(op2);
		}

		void UpdateObjectPreview(ObjectPreview op)
		{
			if (lastselected!=null) op.SetFromObjectCacheItem((SimPe.Cache.ObjectCacheItem)lastselected.Tag[3]);			
			else if (package!=null)	op.SetFromPackage(package);
			else op.SelectedObject = null;
		}

		private void biAbort_Activate(object sender, System.EventArgs e)
		{
			wizard1.JumpToStep(0);
		}

		private void cbfix_CheckedChanged(object sender, System.EventArgs e)
		{
			cbclean.Enabled = cbfix.Checked;
		}

		private void wizardStepPanel3_Activated(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardStepPanel step)
		{
			
		}

	}
}
