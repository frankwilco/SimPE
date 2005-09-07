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
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ImageList ilist;
		private SimPe.Plugin.Tool.Dockable.ObjectPreview op1;
		private SimPe.Plugin.Tool.Dockable.ObjectPreview op2;
		private Ambertation.Windows.Forms.TransparentCheckBox cbRemTxt;
		private System.ComponentModel.IContainer components;

		public dcObjectWorkshop()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			//init the preview manually since the designer is way to stupid to do so >:-|
			this.op1 = new SimPe.Plugin.Tool.Dockable.ObjectPreview();
			this.op2 = new SimPe.Plugin.Tool.Dockable.ObjectPreview();

			// 
			// op1
			// 
			this.op1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.op1.BackColor = System.Drawing.Color.Transparent;
			this.op1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.op1.LoadCustomImage = true;
			this.op1.Location = new System.Drawing.Point(8, 44);
			this.op1.Name = "op1";
			this.op1.SelectedObject = null;
			this.op1.Size = new System.Drawing.Size(304, 88);
			this.op1.TabIndex = 0;
			this.xpTaskBoxSimple2.Controls.Add(this.op1);
			// 
			// op2
			// 
			this.op2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.op2.BackColor = System.Drawing.Color.Transparent;
			this.op2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.op2.LoadCustomImage = true;
			this.op2.Location = new System.Drawing.Point(8, 44);
			this.op2.Name = "op2";
			this.op2.SelectedObject = null;
			this.op2.Size = new System.Drawing.Size(304, 56);
			this.op2.TabIndex = 1;
			this.xpTaskBoxSimple1.Controls.Add(this.op2);

			//do the regular initialization Work
			wizard1.Start();
			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.toolBar1);
			tm.AddControl(this.splitter1);
			tm.AddControl(this.xpTaskBoxSimple1);
			tm.AddControl(this.xpTaskBoxSimple2);
			tm.AddControl(this.gbRecolor);
			tm.AddControl(this.gbClone);

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
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
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
			this.cbRemTxt = new Ambertation.Windows.Forms.TransparentCheckBox();
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
			this.animatedImagelist1 = new Ambertation.Windows.Forms.AnimatedImagelist();
			this.lbfinished = new System.Windows.Forms.Label();
			this.lberr = new System.Windows.Forms.Label();
			this.lbfinload = new System.Windows.Forms.Label();
			this.lbwait = new System.Windows.Forms.Label();
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
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
			this.xpGradientPanel1.Controls.Add(this.wizard1);
			this.xpGradientPanel1.Controls.Add(this.toolBar1);
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// wizard1
			// 
			this.wizard1.AccessibleDescription = resources.GetString("wizard1.AccessibleDescription");
			this.wizard1.AccessibleName = resources.GetString("wizard1.AccessibleName");
			this.wizard1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wizard1.Anchor")));
			this.wizard1.AutoScroll = ((bool)(resources.GetObject("wizard1.AutoScroll")));
			this.wizard1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wizard1.AutoScrollMargin")));
			this.wizard1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wizard1.AutoScrollMinSize")));
			this.wizard1.BackColor = System.Drawing.Color.Transparent;
			this.wizard1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizard1.BackgroundImage")));
			this.wizard1.Controls.Add(this.wizardStepPanel1);
			this.wizard1.Controls.Add(this.wizardStepPanel2);
			this.wizard1.Controls.Add(this.wizardStepPanel3);
			this.wizard1.Controls.Add(this.wizardStepPanel4);
			this.wizard1.CurrentStepNumber = 0;
			this.wizard1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wizard1.Dock")));
			this.wizard1.DockPadding.All = 8;
			this.wizard1.Enabled = ((bool)(resources.GetObject("wizard1.Enabled")));
			this.wizard1.FinishEnabled = false;
			this.wizard1.Font = ((System.Drawing.Font)(resources.GetObject("wizard1.Font")));
			this.wizard1.Image = null;
			this.wizard1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wizard1.ImeMode")));
			this.wizard1.Location = ((System.Drawing.Point)(resources.GetObject("wizard1.Location")));
			this.wizard1.Name = "wizard1";
			this.wizard1.NextEnabled = false;
			this.wizard1.PrevEnabled = false;
			this.wizard1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wizard1.RightToLeft")));
			this.wizard1.Size = ((System.Drawing.Size)(resources.GetObject("wizard1.Size")));
			this.wizard1.TabIndex = ((int)(resources.GetObject("wizard1.TabIndex")));
			this.wizard1.Text = resources.GetString("wizard1.Text");
			this.wizard1.Visible = ((bool)(resources.GetObject("wizard1.Visible")));
			this.wizard1.ChangedPrevState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedPrevState);
			this.wizard1.ChangedFinishState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedFinishState);
			this.wizard1.ChangedNextState += new SimPe.Wizards.WizardHandle(this.wizard1_ChangedNextState);
			this.wizard1.ShowStep += new SimPe.Wizards.WizardChangeHandle(this.wizard1_ShowStep);
			// 
			// wizardStepPanel1
			// 
			this.wizardStepPanel1.AccessibleDescription = resources.GetString("wizardStepPanel1.AccessibleDescription");
			this.wizardStepPanel1.AccessibleName = resources.GetString("wizardStepPanel1.AccessibleName");
			this.wizardStepPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wizardStepPanel1.Anchor")));
			this.wizardStepPanel1.AutoScroll = ((bool)(resources.GetObject("wizardStepPanel1.AutoScroll")));
			this.wizardStepPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel1.AutoScrollMargin")));
			this.wizardStepPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel1.AutoScrollMinSize")));
			this.wizardStepPanel1.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardStepPanel1.BackgroundImage")));
			this.wizardStepPanel1.Controls.Add(this.label4);
			this.wizardStepPanel1.Controls.Add(this.button2);
			this.wizardStepPanel1.Controls.Add(this.label1);
			this.wizardStepPanel1.Controls.Add(this.button1);
			this.wizardStepPanel1.Controls.Add(this.label2);
			this.wizardStepPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wizardStepPanel1.Dock")));
			this.wizardStepPanel1.Enabled = ((bool)(resources.GetObject("wizardStepPanel1.Enabled")));
			this.wizardStepPanel1.First = false;
			this.wizardStepPanel1.Font = ((System.Drawing.Font)(resources.GetObject("wizardStepPanel1.Font")));
			this.wizardStepPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wizardStepPanel1.ImeMode")));
			this.wizardStepPanel1.Last = false;
			this.wizardStepPanel1.Location = ((System.Drawing.Point)(resources.GetObject("wizardStepPanel1.Location")));
			this.wizardStepPanel1.Name = "wizardStepPanel1";
			this.wizardStepPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wizardStepPanel1.RightToLeft")));
			this.wizardStepPanel1.Size = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel1.Size")));
			this.wizardStepPanel1.TabIndex = ((int)(resources.GetObject("wizardStepPanel1.TabIndex")));
			this.wizardStepPanel1.Text = resources.GetString("wizardStepPanel1.Text");
			this.wizardStepPanel1.Visible = ((bool)(resources.GetObject("wizardStepPanel1.Visible")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// button2
			// 
			this.button2.AccessibleDescription = resources.GetString("button2.AccessibleDescription");
			this.button2.AccessibleName = resources.GetString("button2.AccessibleName");
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button2.Anchor")));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button2.Dock")));
			this.button2.Enabled = ((bool)(resources.GetObject("button2.Enabled")));
			this.button2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button2.FlatStyle")));
			this.button2.Font = ((System.Drawing.Font)(resources.GetObject("button2.Font")));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.ImageAlign")));
			this.button2.ImageIndex = ((int)(resources.GetObject("button2.ImageIndex")));
			this.button2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button2.ImeMode")));
			this.button2.Location = ((System.Drawing.Point)(resources.GetObject("button2.Location")));
			this.button2.Name = "button2";
			this.button2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button2.RightToLeft")));
			this.button2.Size = ((System.Drawing.Size)(resources.GetObject("button2.Size")));
			this.button2.TabIndex = ((int)(resources.GetObject("button2.TabIndex")));
			this.button2.Text = resources.GetString("button2.Text");
			this.button2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.TextAlign")));
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// wizardStepPanel2
			// 
			this.wizardStepPanel2.AccessibleDescription = resources.GetString("wizardStepPanel2.AccessibleDescription");
			this.wizardStepPanel2.AccessibleName = resources.GetString("wizardStepPanel2.AccessibleName");
			this.wizardStepPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wizardStepPanel2.Anchor")));
			this.wizardStepPanel2.AutoScroll = ((bool)(resources.GetObject("wizardStepPanel2.AutoScroll")));
			this.wizardStepPanel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel2.AutoScrollMargin")));
			this.wizardStepPanel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel2.AutoScrollMinSize")));
			this.wizardStepPanel2.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardStepPanel2.BackgroundImage")));
			this.wizardStepPanel2.Controls.Add(this.lb);
			this.wizardStepPanel2.Controls.Add(this.tv);
			this.wizardStepPanel2.Controls.Add(this.splitter1);
			this.wizardStepPanel2.Controls.Add(this.panel1);
			this.wizardStepPanel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wizardStepPanel2.Dock")));
			this.wizardStepPanel2.Enabled = ((bool)(resources.GetObject("wizardStepPanel2.Enabled")));
			this.wizardStepPanel2.First = false;
			this.wizardStepPanel2.Font = ((System.Drawing.Font)(resources.GetObject("wizardStepPanel2.Font")));
			this.wizardStepPanel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wizardStepPanel2.ImeMode")));
			this.wizardStepPanel2.Last = false;
			this.wizardStepPanel2.Location = ((System.Drawing.Point)(resources.GetObject("wizardStepPanel2.Location")));
			this.wizardStepPanel2.Name = "wizardStepPanel2";
			this.wizardStepPanel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wizardStepPanel2.RightToLeft")));
			this.wizardStepPanel2.Size = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel2.Size")));
			this.wizardStepPanel2.TabIndex = ((int)(resources.GetObject("wizardStepPanel2.TabIndex")));
			this.wizardStepPanel2.Text = resources.GetString("wizardStepPanel2.Text");
			this.wizardStepPanel2.Visible = ((bool)(resources.GetObject("wizardStepPanel2.Visible")));
			this.wizardStepPanel2.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel2_Activate);
			this.wizardStepPanel2.Prepare += new SimPe.Wizards.WizardStepChangeHandle(this.wizardStepPanel2_Prepare);
			// 
			// lb
			// 
			this.lb.AccessibleDescription = resources.GetString("lb.AccessibleDescription");
			this.lb.AccessibleName = resources.GetString("lb.AccessibleName");
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lb.Anchor")));
			this.lb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb.BackgroundImage")));
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lb.ColumnWidth = ((int)(resources.GetObject("lb.ColumnWidth")));
			this.lb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lb.Dock")));
			this.lb.Enabled = ((bool)(resources.GetObject("lb.Enabled")));
			this.lb.Font = ((System.Drawing.Font)(resources.GetObject("lb.Font")));
			this.lb.HorizontalExtent = ((int)(resources.GetObject("lb.HorizontalExtent")));
			this.lb.HorizontalScrollbar = ((bool)(resources.GetObject("lb.HorizontalScrollbar")));
			this.lb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lb.ImeMode")));
			this.lb.IntegralHeight = ((bool)(resources.GetObject("lb.IntegralHeight")));
			this.lb.ItemHeight = ((int)(resources.GetObject("lb.ItemHeight")));
			this.lb.Location = ((System.Drawing.Point)(resources.GetObject("lb.Location")));
			this.lb.Name = "lb";
			this.lb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lb.RightToLeft")));
			this.lb.ScrollAlwaysVisible = ((bool)(resources.GetObject("lb.ScrollAlwaysVisible")));
			this.lb.Size = ((System.Drawing.Size)(resources.GetObject("lb.Size")));
			this.lb.TabIndex = ((int)(resources.GetObject("lb.TabIndex")));
			this.lb.Visible = ((bool)(resources.GetObject("lb.Visible")));
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
			// 
			// tv
			// 
			this.tv.AccessibleDescription = resources.GetString("tv.AccessibleDescription");
			this.tv.AccessibleName = resources.GetString("tv.AccessibleName");
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tv.Anchor")));
			this.tv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tv.BackgroundImage")));
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tv.Dock")));
			this.tv.Enabled = ((bool)(resources.GetObject("tv.Enabled")));
			this.tv.Font = ((System.Drawing.Font)(resources.GetObject("tv.Font")));
			this.tv.ImageIndex = ((int)(resources.GetObject("tv.ImageIndex")));
			this.tv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tv.ImeMode")));
			this.tv.Indent = ((int)(resources.GetObject("tv.Indent")));
			this.tv.ItemHeight = ((int)(resources.GetObject("tv.ItemHeight")));
			this.tv.Location = ((System.Drawing.Point)(resources.GetObject("tv.Location")));
			this.tv.Name = "tv";
			this.tv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tv.RightToLeft")));
			this.tv.SelectedImageIndex = ((int)(resources.GetObject("tv.SelectedImageIndex")));
			this.tv.Size = ((System.Drawing.Size)(resources.GetObject("tv.Size")));
			this.tv.TabIndex = ((int)(resources.GetObject("tv.TabIndex")));
			this.tv.Text = resources.GetString("tv.Text");
			this.tv.Visible = ((bool)(resources.GetObject("tv.Visible")));
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackColor = System.Drawing.SystemColors.Highlight;
			this.splitter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitter1.BackgroundImage")));
			this.splitter1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitter1.Dock")));
			this.splitter1.Enabled = ((bool)(resources.GetObject("splitter1.Enabled")));
			this.splitter1.Font = ((System.Drawing.Font)(resources.GetObject("splitter1.Font")));
			this.splitter1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitter1.ImeMode")));
			this.splitter1.Location = ((System.Drawing.Point)(resources.GetObject("splitter1.Location")));
			this.splitter1.MinExtra = ((int)(resources.GetObject("splitter1.MinExtra")));
			this.splitter1.MinSize = ((int)(resources.GetObject("splitter1.MinSize")));
			this.splitter1.Name = "splitter1";
			this.splitter1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitter1.RightToLeft")));
			this.splitter1.Size = ((System.Drawing.Size)(resources.GetObject("splitter1.Size")));
			this.splitter1.TabIndex = ((int)(resources.GetObject("splitter1.TabIndex")));
			this.splitter1.TabStop = false;
			this.splitter1.Visible = ((bool)(resources.GetObject("splitter1.Visible")));
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.xpTaskBoxSimple2);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// xpTaskBoxSimple2
			// 
			this.xpTaskBoxSimple2.AccessibleDescription = resources.GetString("xpTaskBoxSimple2.AccessibleDescription");
			this.xpTaskBoxSimple2.AccessibleName = resources.GetString("xpTaskBoxSimple2.AccessibleName");
			this.xpTaskBoxSimple2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpTaskBoxSimple2.Anchor")));
			this.xpTaskBoxSimple2.AutoScroll = ((bool)(resources.GetObject("xpTaskBoxSimple2.AutoScroll")));
			this.xpTaskBoxSimple2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.AutoScrollMargin")));
			this.xpTaskBoxSimple2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.AutoScrollMinSize")));
			this.xpTaskBoxSimple2.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple2.BackgroundImage")));
			this.xpTaskBoxSimple2.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple2.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpTaskBoxSimple2.Dock")));
			this.xpTaskBoxSimple2.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple2.DockPadding.Left = 4;
			this.xpTaskBoxSimple2.DockPadding.Right = 4;
			this.xpTaskBoxSimple2.DockPadding.Top = 44;
			this.xpTaskBoxSimple2.Enabled = ((bool)(resources.GetObject("xpTaskBoxSimple2.Enabled")));
			this.xpTaskBoxSimple2.Font = ((System.Drawing.Font)(resources.GetObject("xpTaskBoxSimple2.Font")));
			this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple2.HeaderText = resources.GetString("xpTaskBoxSimple2.HeaderText");
			this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple2.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple2.Icon")));
			this.xpTaskBoxSimple2.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple2.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpTaskBoxSimple2.ImeMode")));
			this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple2.Location = ((System.Drawing.Point)(resources.GetObject("xpTaskBoxSimple2.Location")));
			this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
			this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpTaskBoxSimple2.RightToLeft")));
			this.xpTaskBoxSimple2.Size = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.Size")));
			this.xpTaskBoxSimple2.TabIndex = ((int)(resources.GetObject("xpTaskBoxSimple2.TabIndex")));
			this.xpTaskBoxSimple2.Text = resources.GetString("xpTaskBoxSimple2.Text");
			this.xpTaskBoxSimple2.Visible = ((bool)(resources.GetObject("xpTaskBoxSimple2.Visible")));
			// 
			// wizardStepPanel3
			// 
			this.wizardStepPanel3.AccessibleDescription = resources.GetString("wizardStepPanel3.AccessibleDescription");
			this.wizardStepPanel3.AccessibleName = resources.GetString("wizardStepPanel3.AccessibleName");
			this.wizardStepPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wizardStepPanel3.Anchor")));
			this.wizardStepPanel3.AutoScroll = ((bool)(resources.GetObject("wizardStepPanel3.AutoScroll")));
			this.wizardStepPanel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel3.AutoScrollMargin")));
			this.wizardStepPanel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel3.AutoScrollMinSize")));
			this.wizardStepPanel3.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardStepPanel3.BackgroundImage")));
			this.wizardStepPanel3.Controls.Add(this.xpTaskBoxSimple1);
			this.wizardStepPanel3.Controls.Add(this.gbRecolor);
			this.wizardStepPanel3.Controls.Add(this.gbClone);
			this.wizardStepPanel3.Controls.Add(this.panel2);
			this.wizardStepPanel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wizardStepPanel3.Dock")));
			this.wizardStepPanel3.Enabled = ((bool)(resources.GetObject("wizardStepPanel3.Enabled")));
			this.wizardStepPanel3.First = false;
			this.wizardStepPanel3.Font = ((System.Drawing.Font)(resources.GetObject("wizardStepPanel3.Font")));
			this.wizardStepPanel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wizardStepPanel3.ImeMode")));
			this.wizardStepPanel3.Last = false;
			this.wizardStepPanel3.Location = ((System.Drawing.Point)(resources.GetObject("wizardStepPanel3.Location")));
			this.wizardStepPanel3.Name = "wizardStepPanel3";
			this.wizardStepPanel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wizardStepPanel3.RightToLeft")));
			this.wizardStepPanel3.Size = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel3.Size")));
			this.wizardStepPanel3.TabIndex = ((int)(resources.GetObject("wizardStepPanel3.TabIndex")));
			this.wizardStepPanel3.Text = resources.GetString("wizardStepPanel3.Text");
			this.wizardStepPanel3.Visible = ((bool)(resources.GetObject("wizardStepPanel3.Visible")));
			this.wizardStepPanel3.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel3_Activate);
			this.wizardStepPanel3.Activated += new SimPe.Wizards.WizardStepHandle(this.wizardStepPanel3_Activated);
			// 
			// xpTaskBoxSimple1
			// 
			this.xpTaskBoxSimple1.AccessibleDescription = resources.GetString("xpTaskBoxSimple1.AccessibleDescription");
			this.xpTaskBoxSimple1.AccessibleName = resources.GetString("xpTaskBoxSimple1.AccessibleName");
			this.xpTaskBoxSimple1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpTaskBoxSimple1.Anchor")));
			this.xpTaskBoxSimple1.AutoScroll = ((bool)(resources.GetObject("xpTaskBoxSimple1.AutoScroll")));
			this.xpTaskBoxSimple1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.AutoScrollMargin")));
			this.xpTaskBoxSimple1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.AutoScrollMinSize")));
			this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple1.BackgroundImage")));
			this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpTaskBoxSimple1.Dock")));
			this.xpTaskBoxSimple1.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple1.DockPadding.Left = 4;
			this.xpTaskBoxSimple1.DockPadding.Right = 4;
			this.xpTaskBoxSimple1.DockPadding.Top = 44;
			this.xpTaskBoxSimple1.Enabled = ((bool)(resources.GetObject("xpTaskBoxSimple1.Enabled")));
			this.xpTaskBoxSimple1.Font = ((System.Drawing.Font)(resources.GetObject("xpTaskBoxSimple1.Font")));
			this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple1.HeaderText = resources.GetString("xpTaskBoxSimple1.HeaderText");
			this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple1.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple1.Icon")));
			this.xpTaskBoxSimple1.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple1.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpTaskBoxSimple1.ImeMode")));
			this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple1.Location = ((System.Drawing.Point)(resources.GetObject("xpTaskBoxSimple1.Location")));
			this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
			this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpTaskBoxSimple1.RightToLeft")));
			this.xpTaskBoxSimple1.Size = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.Size")));
			this.xpTaskBoxSimple1.TabIndex = ((int)(resources.GetObject("xpTaskBoxSimple1.TabIndex")));
			this.xpTaskBoxSimple1.Text = resources.GetString("xpTaskBoxSimple1.Text");
			this.xpTaskBoxSimple1.Visible = ((bool)(resources.GetObject("xpTaskBoxSimple1.Visible")));
			// 
			// gbRecolor
			// 
			this.gbRecolor.AccessibleDescription = resources.GetString("gbRecolor.AccessibleDescription");
			this.gbRecolor.AccessibleName = resources.GetString("gbRecolor.AccessibleName");
			this.gbRecolor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbRecolor.Anchor")));
			this.gbRecolor.AutoScroll = ((bool)(resources.GetObject("gbRecolor.AutoScroll")));
			this.gbRecolor.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("gbRecolor.AutoScrollMargin")));
			this.gbRecolor.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("gbRecolor.AutoScrollMinSize")));
			this.gbRecolor.BackColor = System.Drawing.Color.Transparent;
			this.gbRecolor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbRecolor.BackgroundImage")));
			this.gbRecolor.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gbRecolor.BorderColor = System.Drawing.SystemColors.Window;
			this.gbRecolor.Controls.Add(this.cbColorExt);
			this.gbRecolor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbRecolor.Dock")));
			this.gbRecolor.DockPadding.Bottom = 4;
			this.gbRecolor.DockPadding.Left = 4;
			this.gbRecolor.DockPadding.Right = 4;
			this.gbRecolor.DockPadding.Top = 44;
			this.gbRecolor.Enabled = ((bool)(resources.GetObject("gbRecolor.Enabled")));
			this.gbRecolor.Font = ((System.Drawing.Font)(resources.GetObject("gbRecolor.Font")));
			this.gbRecolor.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.gbRecolor.HeaderText = resources.GetString("gbRecolor.HeaderText");
			this.gbRecolor.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gbRecolor.Icon = ((System.Drawing.Image)(resources.GetObject("gbRecolor.Icon")));
			this.gbRecolor.IconLocation = new System.Drawing.Point(4, 12);
			this.gbRecolor.IconSize = new System.Drawing.Size(32, 32);
			this.gbRecolor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbRecolor.ImeMode")));
			this.gbRecolor.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.gbRecolor.Location = ((System.Drawing.Point)(resources.GetObject("gbRecolor.Location")));
			this.gbRecolor.Name = "gbRecolor";
			this.gbRecolor.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.gbRecolor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbRecolor.RightToLeft")));
			this.gbRecolor.Size = ((System.Drawing.Size)(resources.GetObject("gbRecolor.Size")));
			this.gbRecolor.TabIndex = ((int)(resources.GetObject("gbRecolor.TabIndex")));
			this.gbRecolor.Text = resources.GetString("gbRecolor.Text");
			this.gbRecolor.Visible = ((bool)(resources.GetObject("gbRecolor.Visible")));
			// 
			// cbColorExt
			// 
			this.cbColorExt.AccessibleDescription = resources.GetString("cbColorExt.AccessibleDescription");
			this.cbColorExt.AccessibleName = resources.GetString("cbColorExt.AccessibleName");
			this.cbColorExt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbColorExt.Anchor")));
			this.cbColorExt.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbColorExt.Appearance")));
			this.cbColorExt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbColorExt.BackgroundImage")));
			this.cbColorExt.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbColorExt.CheckAlign")));
			this.cbColorExt.Checked = true;
			this.cbColorExt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbColorExt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbColorExt.Dock")));
			this.cbColorExt.Enabled = ((bool)(resources.GetObject("cbColorExt.Enabled")));
			this.cbColorExt.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbColorExt.FlatStyle")));
			this.cbColorExt.Font = ((System.Drawing.Font)(resources.GetObject("cbColorExt.Font")));
			this.cbColorExt.Image = ((System.Drawing.Image)(resources.GetObject("cbColorExt.Image")));
			this.cbColorExt.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbColorExt.ImageAlign")));
			this.cbColorExt.ImageIndex = ((int)(resources.GetObject("cbColorExt.ImageIndex")));
			this.cbColorExt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbColorExt.ImeMode")));
			this.cbColorExt.Location = ((System.Drawing.Point)(resources.GetObject("cbColorExt.Location")));
			this.cbColorExt.Name = "cbColorExt";
			this.cbColorExt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbColorExt.RightToLeft")));
			this.cbColorExt.Size = ((System.Drawing.Size)(resources.GetObject("cbColorExt.Size")));
			this.cbColorExt.TabIndex = ((int)(resources.GetObject("cbColorExt.TabIndex")));
			this.cbColorExt.Text = resources.GetString("cbColorExt.Text");
			this.cbColorExt.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbColorExt.TextAlign")));
			this.cbColorExt.Visible = ((bool)(resources.GetObject("cbColorExt.Visible")));
			// 
			// gbClone
			// 
			this.gbClone.AccessibleDescription = resources.GetString("gbClone.AccessibleDescription");
			this.gbClone.AccessibleName = resources.GetString("gbClone.AccessibleName");
			this.gbClone.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbClone.Anchor")));
			this.gbClone.AutoScroll = ((bool)(resources.GetObject("gbClone.AutoScroll")));
			this.gbClone.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("gbClone.AutoScrollMargin")));
			this.gbClone.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("gbClone.AutoScrollMinSize")));
			this.gbClone.BackColor = System.Drawing.Color.Transparent;
			this.gbClone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbClone.BackgroundImage")));
			this.gbClone.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gbClone.BorderColor = System.Drawing.SystemColors.Window;
			this.gbClone.Controls.Add(this.cbRemTxt);
			this.gbClone.Controls.Add(this.cbanim);
			this.gbClone.Controls.Add(this.cbwallmask);
			this.gbClone.Controls.Add(this.cbparent);
			this.gbClone.Controls.Add(this.cbclean);
			this.gbClone.Controls.Add(this.cbfix);
			this.gbClone.Controls.Add(this.cbdefault);
			this.gbClone.Controls.Add(this.cbgid);
			this.gbClone.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbClone.Dock")));
			this.gbClone.DockPadding.Bottom = 4;
			this.gbClone.DockPadding.Left = 4;
			this.gbClone.DockPadding.Right = 4;
			this.gbClone.DockPadding.Top = 44;
			this.gbClone.Enabled = ((bool)(resources.GetObject("gbClone.Enabled")));
			this.gbClone.Font = ((System.Drawing.Font)(resources.GetObject("gbClone.Font")));
			this.gbClone.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.gbClone.HeaderText = resources.GetString("gbClone.HeaderText");
			this.gbClone.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gbClone.Icon = ((System.Drawing.Image)(resources.GetObject("gbClone.Icon")));
			this.gbClone.IconLocation = new System.Drawing.Point(4, 12);
			this.gbClone.IconSize = new System.Drawing.Size(32, 32);
			this.gbClone.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbClone.ImeMode")));
			this.gbClone.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.gbClone.Location = ((System.Drawing.Point)(resources.GetObject("gbClone.Location")));
			this.gbClone.Name = "gbClone";
			this.gbClone.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.gbClone.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbClone.RightToLeft")));
			this.gbClone.Size = ((System.Drawing.Size)(resources.GetObject("gbClone.Size")));
			this.gbClone.TabIndex = ((int)(resources.GetObject("gbClone.TabIndex")));
			this.gbClone.Text = resources.GetString("gbClone.Text");
			this.gbClone.Visible = ((bool)(resources.GetObject("gbClone.Visible")));
			// 
			// cbRemTxt
			// 
			this.cbRemTxt.AccessibleDescription = resources.GetString("cbRemTxt.AccessibleDescription");
			this.cbRemTxt.AccessibleName = resources.GetString("cbRemTxt.AccessibleName");
			this.cbRemTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbRemTxt.Anchor")));
			this.cbRemTxt.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbRemTxt.Appearance")));
			this.cbRemTxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbRemTxt.BackgroundImage")));
			this.cbRemTxt.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRemTxt.CheckAlign")));
			this.cbRemTxt.Checked = true;
			this.cbRemTxt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRemTxt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbRemTxt.Dock")));
			this.cbRemTxt.Enabled = ((bool)(resources.GetObject("cbRemTxt.Enabled")));
			this.cbRemTxt.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbRemTxt.FlatStyle")));
			this.cbRemTxt.Font = ((System.Drawing.Font)(resources.GetObject("cbRemTxt.Font")));
			this.cbRemTxt.Image = ((System.Drawing.Image)(resources.GetObject("cbRemTxt.Image")));
			this.cbRemTxt.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRemTxt.ImageAlign")));
			this.cbRemTxt.ImageIndex = ((int)(resources.GetObject("cbRemTxt.ImageIndex")));
			this.cbRemTxt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbRemTxt.ImeMode")));
			this.cbRemTxt.Location = ((System.Drawing.Point)(resources.GetObject("cbRemTxt.Location")));
			this.cbRemTxt.Name = "cbRemTxt";
			this.cbRemTxt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbRemTxt.RightToLeft")));
			this.cbRemTxt.Size = ((System.Drawing.Size)(resources.GetObject("cbRemTxt.Size")));
			this.cbRemTxt.TabIndex = ((int)(resources.GetObject("cbRemTxt.TabIndex")));
			this.cbRemTxt.Text = resources.GetString("cbRemTxt.Text");
			this.cbRemTxt.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRemTxt.TextAlign")));
			this.cbRemTxt.Visible = ((bool)(resources.GetObject("cbRemTxt.Visible")));
			// 
			// cbanim
			// 
			this.cbanim.AccessibleDescription = resources.GetString("cbanim.AccessibleDescription");
			this.cbanim.AccessibleName = resources.GetString("cbanim.AccessibleName");
			this.cbanim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbanim.Anchor")));
			this.cbanim.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbanim.Appearance")));
			this.cbanim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbanim.BackgroundImage")));
			this.cbanim.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbanim.CheckAlign")));
			this.cbanim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbanim.Dock")));
			this.cbanim.Enabled = ((bool)(resources.GetObject("cbanim.Enabled")));
			this.cbanim.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbanim.FlatStyle")));
			this.cbanim.Font = ((System.Drawing.Font)(resources.GetObject("cbanim.Font")));
			this.cbanim.Image = ((System.Drawing.Image)(resources.GetObject("cbanim.Image")));
			this.cbanim.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbanim.ImageAlign")));
			this.cbanim.ImageIndex = ((int)(resources.GetObject("cbanim.ImageIndex")));
			this.cbanim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbanim.ImeMode")));
			this.cbanim.Location = ((System.Drawing.Point)(resources.GetObject("cbanim.Location")));
			this.cbanim.Name = "cbanim";
			this.cbanim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbanim.RightToLeft")));
			this.cbanim.Size = ((System.Drawing.Size)(resources.GetObject("cbanim.Size")));
			this.cbanim.TabIndex = ((int)(resources.GetObject("cbanim.TabIndex")));
			this.cbanim.Text = resources.GetString("cbanim.Text");
			this.cbanim.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbanim.TextAlign")));
			this.cbanim.Visible = ((bool)(resources.GetObject("cbanim.Visible")));
			// 
			// cbwallmask
			// 
			this.cbwallmask.AccessibleDescription = resources.GetString("cbwallmask.AccessibleDescription");
			this.cbwallmask.AccessibleName = resources.GetString("cbwallmask.AccessibleName");
			this.cbwallmask.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbwallmask.Anchor")));
			this.cbwallmask.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbwallmask.Appearance")));
			this.cbwallmask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbwallmask.BackgroundImage")));
			this.cbwallmask.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwallmask.CheckAlign")));
			this.cbwallmask.Checked = true;
			this.cbwallmask.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbwallmask.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbwallmask.Dock")));
			this.cbwallmask.Enabled = ((bool)(resources.GetObject("cbwallmask.Enabled")));
			this.cbwallmask.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbwallmask.FlatStyle")));
			this.cbwallmask.Font = ((System.Drawing.Font)(resources.GetObject("cbwallmask.Font")));
			this.cbwallmask.Image = ((System.Drawing.Image)(resources.GetObject("cbwallmask.Image")));
			this.cbwallmask.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwallmask.ImageAlign")));
			this.cbwallmask.ImageIndex = ((int)(resources.GetObject("cbwallmask.ImageIndex")));
			this.cbwallmask.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbwallmask.ImeMode")));
			this.cbwallmask.Location = ((System.Drawing.Point)(resources.GetObject("cbwallmask.Location")));
			this.cbwallmask.Name = "cbwallmask";
			this.cbwallmask.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbwallmask.RightToLeft")));
			this.cbwallmask.Size = ((System.Drawing.Size)(resources.GetObject("cbwallmask.Size")));
			this.cbwallmask.TabIndex = ((int)(resources.GetObject("cbwallmask.TabIndex")));
			this.cbwallmask.Text = resources.GetString("cbwallmask.Text");
			this.cbwallmask.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwallmask.TextAlign")));
			this.cbwallmask.Visible = ((bool)(resources.GetObject("cbwallmask.Visible")));
			// 
			// cbparent
			// 
			this.cbparent.AccessibleDescription = resources.GetString("cbparent.AccessibleDescription");
			this.cbparent.AccessibleName = resources.GetString("cbparent.AccessibleName");
			this.cbparent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbparent.Anchor")));
			this.cbparent.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbparent.Appearance")));
			this.cbparent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbparent.BackgroundImage")));
			this.cbparent.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbparent.CheckAlign")));
			this.cbparent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbparent.Dock")));
			this.cbparent.Enabled = ((bool)(resources.GetObject("cbparent.Enabled")));
			this.cbparent.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbparent.FlatStyle")));
			this.cbparent.Font = ((System.Drawing.Font)(resources.GetObject("cbparent.Font")));
			this.cbparent.Image = ((System.Drawing.Image)(resources.GetObject("cbparent.Image")));
			this.cbparent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbparent.ImageAlign")));
			this.cbparent.ImageIndex = ((int)(resources.GetObject("cbparent.ImageIndex")));
			this.cbparent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbparent.ImeMode")));
			this.cbparent.Location = ((System.Drawing.Point)(resources.GetObject("cbparent.Location")));
			this.cbparent.Name = "cbparent";
			this.cbparent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbparent.RightToLeft")));
			this.cbparent.Size = ((System.Drawing.Size)(resources.GetObject("cbparent.Size")));
			this.cbparent.TabIndex = ((int)(resources.GetObject("cbparent.TabIndex")));
			this.cbparent.Text = resources.GetString("cbparent.Text");
			this.cbparent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbparent.TextAlign")));
			this.cbparent.Visible = ((bool)(resources.GetObject("cbparent.Visible")));
			// 
			// cbclean
			// 
			this.cbclean.AccessibleDescription = resources.GetString("cbclean.AccessibleDescription");
			this.cbclean.AccessibleName = resources.GetString("cbclean.AccessibleName");
			this.cbclean.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbclean.Anchor")));
			this.cbclean.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbclean.Appearance")));
			this.cbclean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbclean.BackgroundImage")));
			this.cbclean.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbclean.CheckAlign")));
			this.cbclean.Checked = true;
			this.cbclean.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbclean.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbclean.Dock")));
			this.cbclean.Enabled = ((bool)(resources.GetObject("cbclean.Enabled")));
			this.cbclean.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbclean.FlatStyle")));
			this.cbclean.Font = ((System.Drawing.Font)(resources.GetObject("cbclean.Font")));
			this.cbclean.Image = ((System.Drawing.Image)(resources.GetObject("cbclean.Image")));
			this.cbclean.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbclean.ImageAlign")));
			this.cbclean.ImageIndex = ((int)(resources.GetObject("cbclean.ImageIndex")));
			this.cbclean.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbclean.ImeMode")));
			this.cbclean.Location = ((System.Drawing.Point)(resources.GetObject("cbclean.Location")));
			this.cbclean.Name = "cbclean";
			this.cbclean.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbclean.RightToLeft")));
			this.cbclean.Size = ((System.Drawing.Size)(resources.GetObject("cbclean.Size")));
			this.cbclean.TabIndex = ((int)(resources.GetObject("cbclean.TabIndex")));
			this.cbclean.Text = resources.GetString("cbclean.Text");
			this.cbclean.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbclean.TextAlign")));
			this.cbclean.Visible = ((bool)(resources.GetObject("cbclean.Visible")));
			// 
			// cbfix
			// 
			this.cbfix.AccessibleDescription = resources.GetString("cbfix.AccessibleDescription");
			this.cbfix.AccessibleName = resources.GetString("cbfix.AccessibleName");
			this.cbfix.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfix.Anchor")));
			this.cbfix.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfix.Appearance")));
			this.cbfix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfix.BackgroundImage")));
			this.cbfix.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfix.CheckAlign")));
			this.cbfix.Checked = true;
			this.cbfix.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbfix.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfix.Dock")));
			this.cbfix.Enabled = ((bool)(resources.GetObject("cbfix.Enabled")));
			this.cbfix.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfix.FlatStyle")));
			this.cbfix.Font = ((System.Drawing.Font)(resources.GetObject("cbfix.Font")));
			this.cbfix.Image = ((System.Drawing.Image)(resources.GetObject("cbfix.Image")));
			this.cbfix.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfix.ImageAlign")));
			this.cbfix.ImageIndex = ((int)(resources.GetObject("cbfix.ImageIndex")));
			this.cbfix.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfix.ImeMode")));
			this.cbfix.Location = ((System.Drawing.Point)(resources.GetObject("cbfix.Location")));
			this.cbfix.Name = "cbfix";
			this.cbfix.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfix.RightToLeft")));
			this.cbfix.Size = ((System.Drawing.Size)(resources.GetObject("cbfix.Size")));
			this.cbfix.TabIndex = ((int)(resources.GetObject("cbfix.TabIndex")));
			this.cbfix.Text = resources.GetString("cbfix.Text");
			this.cbfix.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfix.TextAlign")));
			this.cbfix.Visible = ((bool)(resources.GetObject("cbfix.Visible")));
			this.cbfix.CheckedChanged += new System.EventHandler(this.cbfix_CheckedChanged);
			// 
			// cbdefault
			// 
			this.cbdefault.AccessibleDescription = resources.GetString("cbdefault.AccessibleDescription");
			this.cbdefault.AccessibleName = resources.GetString("cbdefault.AccessibleName");
			this.cbdefault.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbdefault.Anchor")));
			this.cbdefault.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbdefault.Appearance")));
			this.cbdefault.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbdefault.BackgroundImage")));
			this.cbdefault.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdefault.CheckAlign")));
			this.cbdefault.Checked = true;
			this.cbdefault.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbdefault.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbdefault.Dock")));
			this.cbdefault.Enabled = ((bool)(resources.GetObject("cbdefault.Enabled")));
			this.cbdefault.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbdefault.FlatStyle")));
			this.cbdefault.Font = ((System.Drawing.Font)(resources.GetObject("cbdefault.Font")));
			this.cbdefault.Image = ((System.Drawing.Image)(resources.GetObject("cbdefault.Image")));
			this.cbdefault.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdefault.ImageAlign")));
			this.cbdefault.ImageIndex = ((int)(resources.GetObject("cbdefault.ImageIndex")));
			this.cbdefault.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbdefault.ImeMode")));
			this.cbdefault.Location = ((System.Drawing.Point)(resources.GetObject("cbdefault.Location")));
			this.cbdefault.Name = "cbdefault";
			this.cbdefault.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbdefault.RightToLeft")));
			this.cbdefault.Size = ((System.Drawing.Size)(resources.GetObject("cbdefault.Size")));
			this.cbdefault.TabIndex = ((int)(resources.GetObject("cbdefault.TabIndex")));
			this.cbdefault.Text = resources.GetString("cbdefault.Text");
			this.cbdefault.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdefault.TextAlign")));
			this.cbdefault.Visible = ((bool)(resources.GetObject("cbdefault.Visible")));
			// 
			// cbgid
			// 
			this.cbgid.AccessibleDescription = resources.GetString("cbgid.AccessibleDescription");
			this.cbgid.AccessibleName = resources.GetString("cbgid.AccessibleName");
			this.cbgid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbgid.Anchor")));
			this.cbgid.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbgid.Appearance")));
			this.cbgid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbgid.BackgroundImage")));
			this.cbgid.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbgid.CheckAlign")));
			this.cbgid.Checked = true;
			this.cbgid.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbgid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbgid.Dock")));
			this.cbgid.Enabled = ((bool)(resources.GetObject("cbgid.Enabled")));
			this.cbgid.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbgid.FlatStyle")));
			this.cbgid.Font = ((System.Drawing.Font)(resources.GetObject("cbgid.Font")));
			this.cbgid.Image = ((System.Drawing.Image)(resources.GetObject("cbgid.Image")));
			this.cbgid.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbgid.ImageAlign")));
			this.cbgid.ImageIndex = ((int)(resources.GetObject("cbgid.ImageIndex")));
			this.cbgid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbgid.ImeMode")));
			this.cbgid.Location = ((System.Drawing.Point)(resources.GetObject("cbgid.Location")));
			this.cbgid.Name = "cbgid";
			this.cbgid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbgid.RightToLeft")));
			this.cbgid.Size = ((System.Drawing.Size)(resources.GetObject("cbgid.Size")));
			this.cbgid.TabIndex = ((int)(resources.GetObject("cbgid.TabIndex")));
			this.cbgid.Text = resources.GetString("cbgid.Text");
			this.cbgid.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbgid.TextAlign")));
			this.cbgid.Visible = ((bool)(resources.GetObject("cbgid.Visible")));
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.button3);
			this.panel2.Controls.Add(this.cbTask);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// button3
			// 
			this.button3.AccessibleDescription = resources.GetString("button3.AccessibleDescription");
			this.button3.AccessibleName = resources.GetString("button3.AccessibleName");
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button3.Anchor")));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button3.Dock")));
			this.button3.Enabled = ((bool)(resources.GetObject("button3.Enabled")));
			this.button3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button3.FlatStyle")));
			this.button3.Font = ((System.Drawing.Font)(resources.GetObject("button3.Font")));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.ImageAlign")));
			this.button3.ImageIndex = ((int)(resources.GetObject("button3.ImageIndex")));
			this.button3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button3.ImeMode")));
			this.button3.Location = ((System.Drawing.Point)(resources.GetObject("button3.Location")));
			this.button3.Name = "button3";
			this.button3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button3.RightToLeft")));
			this.button3.Size = ((System.Drawing.Size)(resources.GetObject("button3.Size")));
			this.button3.TabIndex = ((int)(resources.GetObject("button3.TabIndex")));
			this.button3.Text = resources.GetString("button3.Text");
			this.button3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.TextAlign")));
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cbTask
			// 
			this.cbTask.AccessibleDescription = resources.GetString("cbTask.AccessibleDescription");
			this.cbTask.AccessibleName = resources.GetString("cbTask.AccessibleName");
			this.cbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbTask.Anchor")));
			this.cbTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbTask.BackgroundImage")));
			this.cbTask.DefaultText = resources.GetString("cbTask.DefaultText");
			this.cbTask.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbTask.Dock")));
			this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTask.Enabled = ((bool)(resources.GetObject("cbTask.Enabled")));
			this.cbTask.Font = ((System.Drawing.Font)(resources.GetObject("cbTask.Font")));
			this.cbTask.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbTask.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbTask.ImeMode")));
			this.cbTask.IntegralHeight = ((bool)(resources.GetObject("cbTask.IntegralHeight")));
			this.cbTask.ItemHeight = ((int)(resources.GetObject("cbTask.ItemHeight")));
			this.cbTask.Items.AddRange(new object[] {
														resources.GetString("cbTask.Items"),
														resources.GetString("cbTask.Items1")});
			this.cbTask.Location = ((System.Drawing.Point)(resources.GetObject("cbTask.Location")));
			this.cbTask.MaxDropDownItems = ((int)(resources.GetObject("cbTask.MaxDropDownItems")));
			this.cbTask.MaxLength = ((int)(resources.GetObject("cbTask.MaxLength")));
			this.cbTask.Name = "cbTask";
			this.cbTask.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbTask.RightToLeft")));
			this.cbTask.Size = ((System.Drawing.Size)(resources.GetObject("cbTask.Size")));
			this.cbTask.TabIndex = ((int)(resources.GetObject("cbTask.TabIndex")));
			this.cbTask.Text = resources.GetString("cbTask.Text");
			this.cbTask.Visible = ((bool)(resources.GetObject("cbTask.Visible")));
			this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// wizardStepPanel4
			// 
			this.wizardStepPanel4.AccessibleDescription = resources.GetString("wizardStepPanel4.AccessibleDescription");
			this.wizardStepPanel4.AccessibleName = resources.GetString("wizardStepPanel4.AccessibleName");
			this.wizardStepPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wizardStepPanel4.Anchor")));
			this.wizardStepPanel4.AutoScroll = ((bool)(resources.GetObject("wizardStepPanel4.AutoScroll")));
			this.wizardStepPanel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel4.AutoScrollMargin")));
			this.wizardStepPanel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel4.AutoScrollMinSize")));
			this.wizardStepPanel4.BackColor = System.Drawing.Color.Transparent;
			this.wizardStepPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wizardStepPanel4.BackgroundImage")));
			this.wizardStepPanel4.Controls.Add(this.pnWait);
			this.wizardStepPanel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wizardStepPanel4.Dock")));
			this.wizardStepPanel4.Enabled = ((bool)(resources.GetObject("wizardStepPanel4.Enabled")));
			this.wizardStepPanel4.First = false;
			this.wizardStepPanel4.Font = ((System.Drawing.Font)(resources.GetObject("wizardStepPanel4.Font")));
			this.wizardStepPanel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wizardStepPanel4.ImeMode")));
			this.wizardStepPanel4.Last = true;
			this.wizardStepPanel4.Location = ((System.Drawing.Point)(resources.GetObject("wizardStepPanel4.Location")));
			this.wizardStepPanel4.Name = "wizardStepPanel4";
			this.wizardStepPanel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wizardStepPanel4.RightToLeft")));
			this.wizardStepPanel4.Size = ((System.Drawing.Size)(resources.GetObject("wizardStepPanel4.Size")));
			this.wizardStepPanel4.TabIndex = ((int)(resources.GetObject("wizardStepPanel4.TabIndex")));
			this.wizardStepPanel4.Text = resources.GetString("wizardStepPanel4.Text");
			this.wizardStepPanel4.Visible = ((bool)(resources.GetObject("wizardStepPanel4.Visible")));
			this.wizardStepPanel4.Activate += new SimPe.Wizards.WizardChangeHandle(this.wizardStepPanel4_Activate);
			this.wizardStepPanel4.Activated += new SimPe.Wizards.WizardStepHandle(this.wizardStepPanel4_Activated);
			// 
			// pnWait
			// 
			this.pnWait.AccessibleDescription = resources.GetString("pnWait.AccessibleDescription");
			this.pnWait.AccessibleName = resources.GetString("pnWait.AccessibleName");
			this.pnWait.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnWait.Anchor")));
			this.pnWait.AutoScroll = ((bool)(resources.GetObject("pnWait.AutoScroll")));
			this.pnWait.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnWait.AutoScrollMargin")));
			this.pnWait.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnWait.AutoScrollMinSize")));
			this.pnWait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnWait.BackgroundImage")));
			this.pnWait.Controls.Add(this.animatedImagelist1);
			this.pnWait.Controls.Add(this.lbfinished);
			this.pnWait.Controls.Add(this.lberr);
			this.pnWait.Controls.Add(this.lbfinload);
			this.pnWait.Controls.Add(this.lbwait);
			this.pnWait.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnWait.Dock")));
			this.pnWait.Enabled = ((bool)(resources.GetObject("pnWait.Enabled")));
			this.pnWait.Font = ((System.Drawing.Font)(resources.GetObject("pnWait.Font")));
			this.pnWait.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnWait.ImeMode")));
			this.pnWait.Location = ((System.Drawing.Point)(resources.GetObject("pnWait.Location")));
			this.pnWait.Name = "pnWait";
			this.pnWait.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnWait.RightToLeft")));
			this.pnWait.Size = ((System.Drawing.Size)(resources.GetObject("pnWait.Size")));
			this.pnWait.TabIndex = ((int)(resources.GetObject("pnWait.TabIndex")));
			this.pnWait.Text = resources.GetString("pnWait.Text");
			this.pnWait.Visible = ((bool)(resources.GetObject("pnWait.Visible")));
			// 
			// animatedImagelist1
			// 
			this.animatedImagelist1.AccessibleDescription = resources.GetString("animatedImagelist1.AccessibleDescription");
			this.animatedImagelist1.AccessibleName = resources.GetString("animatedImagelist1.AccessibleName");
			this.animatedImagelist1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("animatedImagelist1.Anchor")));
			this.animatedImagelist1.AutoScroll = ((bool)(resources.GetObject("animatedImagelist1.AutoScroll")));
			this.animatedImagelist1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("animatedImagelist1.AutoScrollMargin")));
			this.animatedImagelist1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("animatedImagelist1.AutoScrollMinSize")));
			this.animatedImagelist1.BackColor = System.Drawing.Color.Transparent;
			this.animatedImagelist1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("animatedImagelist1.BackgroundImage")));
			this.animatedImagelist1.CurrentIndex = 0;
			this.animatedImagelist1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("animatedImagelist1.Dock")));
			this.animatedImagelist1.DoEvents = false;
			this.animatedImagelist1.Enabled = ((bool)(resources.GetObject("animatedImagelist1.Enabled")));
			this.animatedImagelist1.Font = ((System.Drawing.Font)(resources.GetObject("animatedImagelist1.Font")));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource1"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource2"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource3"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource4"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource5"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource6"))));
			this.animatedImagelist1.Images.Add(((System.Drawing.Image)(resources.GetObject("resource7"))));
			this.animatedImagelist1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("animatedImagelist1.ImeMode")));
			this.animatedImagelist1.Location = ((System.Drawing.Point)(resources.GetObject("animatedImagelist1.Location")));
			this.animatedImagelist1.Name = "animatedImagelist1";
			this.animatedImagelist1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("animatedImagelist1.RightToLeft")));
			this.animatedImagelist1.Size = ((System.Drawing.Size)(resources.GetObject("animatedImagelist1.Size")));
			this.animatedImagelist1.TabIndex = ((int)(resources.GetObject("animatedImagelist1.TabIndex")));
			this.animatedImagelist1.Visible = ((bool)(resources.GetObject("animatedImagelist1.Visible")));
			// 
			// lbfinished
			// 
			this.lbfinished.AccessibleDescription = resources.GetString("lbfinished.AccessibleDescription");
			this.lbfinished.AccessibleName = resources.GetString("lbfinished.AccessibleName");
			this.lbfinished.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbfinished.Anchor")));
			this.lbfinished.AutoSize = ((bool)(resources.GetObject("lbfinished.AutoSize")));
			this.lbfinished.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbfinished.Dock")));
			this.lbfinished.Enabled = ((bool)(resources.GetObject("lbfinished.Enabled")));
			this.lbfinished.Font = ((System.Drawing.Font)(resources.GetObject("lbfinished.Font")));
			this.lbfinished.Image = ((System.Drawing.Image)(resources.GetObject("lbfinished.Image")));
			this.lbfinished.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfinished.ImageAlign")));
			this.lbfinished.ImageIndex = ((int)(resources.GetObject("lbfinished.ImageIndex")));
			this.lbfinished.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbfinished.ImeMode")));
			this.lbfinished.Location = ((System.Drawing.Point)(resources.GetObject("lbfinished.Location")));
			this.lbfinished.Name = "lbfinished";
			this.lbfinished.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbfinished.RightToLeft")));
			this.lbfinished.Size = ((System.Drawing.Size)(resources.GetObject("lbfinished.Size")));
			this.lbfinished.TabIndex = ((int)(resources.GetObject("lbfinished.TabIndex")));
			this.lbfinished.Text = resources.GetString("lbfinished.Text");
			this.lbfinished.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfinished.TextAlign")));
			this.lbfinished.Visible = ((bool)(resources.GetObject("lbfinished.Visible")));
			// 
			// lberr
			// 
			this.lberr.AccessibleDescription = resources.GetString("lberr.AccessibleDescription");
			this.lberr.AccessibleName = resources.GetString("lberr.AccessibleName");
			this.lberr.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lberr.Anchor")));
			this.lberr.AutoSize = ((bool)(resources.GetObject("lberr.AutoSize")));
			this.lberr.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lberr.Dock")));
			this.lberr.Enabled = ((bool)(resources.GetObject("lberr.Enabled")));
			this.lberr.Font = ((System.Drawing.Font)(resources.GetObject("lberr.Font")));
			this.lberr.Image = ((System.Drawing.Image)(resources.GetObject("lberr.Image")));
			this.lberr.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lberr.ImageAlign")));
			this.lberr.ImageIndex = ((int)(resources.GetObject("lberr.ImageIndex")));
			this.lberr.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lberr.ImeMode")));
			this.lberr.Location = ((System.Drawing.Point)(resources.GetObject("lberr.Location")));
			this.lberr.Name = "lberr";
			this.lberr.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lberr.RightToLeft")));
			this.lberr.Size = ((System.Drawing.Size)(resources.GetObject("lberr.Size")));
			this.lberr.TabIndex = ((int)(resources.GetObject("lberr.TabIndex")));
			this.lberr.Text = resources.GetString("lberr.Text");
			this.lberr.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lberr.TextAlign")));
			this.lberr.Visible = ((bool)(resources.GetObject("lberr.Visible")));
			// 
			// lbfinload
			// 
			this.lbfinload.AccessibleDescription = resources.GetString("lbfinload.AccessibleDescription");
			this.lbfinload.AccessibleName = resources.GetString("lbfinload.AccessibleName");
			this.lbfinload.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbfinload.Anchor")));
			this.lbfinload.AutoSize = ((bool)(resources.GetObject("lbfinload.AutoSize")));
			this.lbfinload.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbfinload.Dock")));
			this.lbfinload.Enabled = ((bool)(resources.GetObject("lbfinload.Enabled")));
			this.lbfinload.Font = ((System.Drawing.Font)(resources.GetObject("lbfinload.Font")));
			this.lbfinload.Image = ((System.Drawing.Image)(resources.GetObject("lbfinload.Image")));
			this.lbfinload.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfinload.ImageAlign")));
			this.lbfinload.ImageIndex = ((int)(resources.GetObject("lbfinload.ImageIndex")));
			this.lbfinload.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbfinload.ImeMode")));
			this.lbfinload.Location = ((System.Drawing.Point)(resources.GetObject("lbfinload.Location")));
			this.lbfinload.Name = "lbfinload";
			this.lbfinload.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbfinload.RightToLeft")));
			this.lbfinload.Size = ((System.Drawing.Size)(resources.GetObject("lbfinload.Size")));
			this.lbfinload.TabIndex = ((int)(resources.GetObject("lbfinload.TabIndex")));
			this.lbfinload.Text = resources.GetString("lbfinload.Text");
			this.lbfinload.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfinload.TextAlign")));
			this.lbfinload.Visible = ((bool)(resources.GetObject("lbfinload.Visible")));
			// 
			// lbwait
			// 
			this.lbwait.AccessibleDescription = resources.GetString("lbwait.AccessibleDescription");
			this.lbwait.AccessibleName = resources.GetString("lbwait.AccessibleName");
			this.lbwait.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbwait.Anchor")));
			this.lbwait.AutoSize = ((bool)(resources.GetObject("lbwait.AutoSize")));
			this.lbwait.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbwait.Dock")));
			this.lbwait.Enabled = ((bool)(resources.GetObject("lbwait.Enabled")));
			this.lbwait.Font = ((System.Drawing.Font)(resources.GetObject("lbwait.Font")));
			this.lbwait.Image = ((System.Drawing.Image)(resources.GetObject("lbwait.Image")));
			this.lbwait.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbwait.ImageAlign")));
			this.lbwait.ImageIndex = ((int)(resources.GetObject("lbwait.ImageIndex")));
			this.lbwait.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbwait.ImeMode")));
			this.lbwait.Location = ((System.Drawing.Point)(resources.GetObject("lbwait.Location")));
			this.lbwait.Name = "lbwait";
			this.lbwait.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbwait.RightToLeft")));
			this.lbwait.Size = ((System.Drawing.Size)(resources.GetObject("lbwait.Size")));
			this.lbwait.TabIndex = ((int)(resources.GetObject("lbwait.TabIndex")));
			this.lbwait.Text = resources.GetString("lbwait.Text");
			this.lbwait.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbwait.TextAlign")));
			this.lbwait.Visible = ((bool)(resources.GetObject("lbwait.Visible")));
			// 
			// toolBar1
			// 
			this.toolBar1.AccessibleDescription = resources.GetString("toolBar1.AccessibleDescription");
			this.toolBar1.AccessibleName = resources.GetString("toolBar1.AccessibleName");
			this.toolBar1.AddRemoveButtonsVisible = false;
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar1.Anchor")));
			this.toolBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar1.BackgroundImage")));
			this.toolBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar1.Dock")));
			this.toolBar1.DockLine = 1;
			this.toolBar1.DrawActionsButton = false;
			this.toolBar1.Enabled = ((bool)(resources.GetObject("toolBar1.Enabled")));
			this.toolBar1.FlipLastItem = true;
			this.toolBar1.Font = ((System.Drawing.Font)(resources.GetObject("toolBar1.Font")));
			this.toolBar1.Guid = new System.Guid("9261260f-4e3d-4d4f-8be9-9b0045f91adc");
			this.toolBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar1.ImeMode")));
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biPrev,
																			  this.biNext,
																			  this.biFinish,
																			  this.biAbort,
																			  this.biCatalog});
			this.toolBar1.Location = ((System.Drawing.Point)(resources.GetObject("toolBar1.Location")));
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Hide;
			this.toolBar1.Renderer = new TD.SandBar.WhidbeyRenderer();
			this.toolBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar1.RightToLeft")));
			this.toolBar1.Size = ((System.Drawing.Size)(resources.GetObject("toolBar1.Size")));
			this.toolBar1.TabIndex = ((int)(resources.GetObject("toolBar1.TabIndex")));
			this.toolBar1.Text = resources.GetString("toolBar1.Text");
			this.toolBar1.Visible = ((bool)(resources.GetObject("toolBar1.Visible")));
			// 
			// biPrev
			// 
			this.biPrev.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biPrev.Image = ((System.Drawing.Image)(resources.GetObject("biPrev.Image")));
			this.biPrev.ItemImportance = TD.SandBar.ItemImportance.Highest;
			this.biPrev.Text = resources.GetString("biPrev.Text");
			this.biPrev.ToolTipText = resources.GetString("biPrev.ToolTipText");
			this.biPrev.Activate += new System.EventHandler(this.Activate_biPrev);
			// 
			// biNext
			// 
			this.biNext.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biNext.Image = ((System.Drawing.Image)(resources.GetObject("biNext.Image")));
			this.biNext.ItemImportance = TD.SandBar.ItemImportance.Highest;
			this.biNext.Text = resources.GetString("biNext.Text");
			this.biNext.ToolTipText = resources.GetString("biNext.ToolTipText");
			this.biNext.Activate += new System.EventHandler(this.Activate_biNext);
			// 
			// biFinish
			// 
			this.biFinish.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biFinish.Image = ((System.Drawing.Image)(resources.GetObject("biFinish.Image")));
			this.biFinish.Text = resources.GetString("biFinish.Text");
			this.biFinish.ToolTipText = resources.GetString("biFinish.ToolTipText");
			this.biFinish.Activate += new System.EventHandler(this.ActivateFinish);
			// 
			// biAbort
			// 
			this.biAbort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biAbort.Image = ((System.Drawing.Image)(resources.GetObject("biAbort.Image")));
			this.biAbort.Text = resources.GetString("biAbort.Text");
			this.biAbort.ToolTipText = resources.GetString("biAbort.ToolTipText");
			this.biAbort.Activate += new System.EventHandler(this.biAbort_Activate);
			// 
			// biCatalog
			// 
			this.biCatalog.Checked = true;
			this.biCatalog.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.biCatalog.Text = resources.GetString("biCatalog.Text");
			this.biCatalog.ToolTipText = resources.GetString("biCatalog.ToolTipText");
			this.biCatalog.Activate += new System.EventHandler(this.Activate_biCatalog);
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// dcObjectWorkshop
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.xpGradientPanel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.FloatingSize = new System.Drawing.Size(300, 550);
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "dcObjectWorkshop";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
			this.TabText = resources.GetString("$this.TabText");
			this.Text = resources.GetString("$this.Text");
			this.ToolTipText = resources.GetString("$this.ToolTipText");
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

			if (oci.Class == SimPe.Cache.ObjectClass.XObject && !Helper.WindowsRegistry.HiddenMode) return;

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
					cs.RemoveNonDefaultTextReferences = this.cbRemTxt.Checked;

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
			UpdateEnabledOptions();
		}

		void UpdateEnabledOptions()
		{
			if (lastselected!=null) 
			{
				SimPe.Cache.ObjectCacheItem oci = (SimPe.Cache.ObjectCacheItem)lastselected.Tag[3];
				if (oci.Class != SimPe.Cache.ObjectClass.Object) 
				{
					cbclean.Enabled = false;
					cbdefault.Enabled = false;
					cbparent.Enabled = false;
					
					cbTask.SelectedIndex = 1;
					cbTask.Enabled = false;
				} 
				else 
				{
					cbclean.Enabled = true;
					cbdefault.Enabled = true;
					cbparent.Enabled = true;
					cbTask.Enabled = true;
				}
			}
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
			cbRemTxt.Enabled = cbfix.Checked;
			UpdateEnabledOptions();
		}

		private void wizardStepPanel3_Activated(SimPe.Wizards.Wizard sender, SimPe.Wizards.WizardStepPanel step)
		{
			
		}

	}
}
