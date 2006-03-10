using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Cache;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MemoryProperties.
	/// </summary>
	
	public class MemoryProperties : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MemoryProperties()
		{
			try 
			{
				SetStyle(
					ControlStyles.SupportsTransparentBackColor |
					ControlStyles.AllPaintingInWmPaint |
					//ControlStyles.Opaque |
					ControlStyles.UserPaint |
					ControlStyles.ResizeRedraw 
					| ControlStyles.DoubleBuffer
					,true);
				// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
				InitializeComponent();

			
				this.cbtype.Enum = typeof(SimMemoryType);
				this.cbtype.ResourceManager = SimPe.Localization.Manager;								

				SetContent();
				this.Enabled = false;
				cbCtrl.Enabled = Helper.WindowsRegistry.HiddenMode;
			}
			catch {}
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MemoryProperties));
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.tabControl2 = new TD.SandDock.TabControl();
			this.tabPage3 = new TD.SandDock.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnObjectGuid = new System.Windows.Forms.Panel();
			this.cbSubjectObj = new SimPe.PackedFiles.Wrapper.ObjectComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pnSubject = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.cbSubject = new SimPe.PackedFiles.Wrapper.SimComboBox();
			this.llme2 = new System.Windows.Forms.LinkLabel();
			this.pnSub2 = new System.Windows.Forms.Panel();
			this.pnSub1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.pnValue = new System.Windows.Forms.Panel();
			this.tbValue = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pnInventory = new System.Windows.Forms.Panel();
			this.tbInv = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnOwner = new System.Windows.Forms.Panel();
			this.cbOwner = new SimPe.PackedFiles.Wrapper.SimComboBox();
			this.llme = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.pnSelection = new System.Windows.Forms.Panel();
			this.lbtype = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.PictureBox();
			this.cbtype = new Ambertation.Windows.Forms.EnumComboBox();
			this.cbObjs = new SimPe.PackedFiles.Wrapper.ObjectComboBox();
			this.cbToks = new SimPe.PackedFiles.Wrapper.ObjectComboBox();
			this.cbMems = new SimPe.PackedFiles.Wrapper.ObjectComboBox();
			this.pnListing = new System.Windows.Forms.Panel();
			this.rbObjs = new System.Windows.Forms.RadioButton();
			this.rbToks = new System.Windows.Forms.RadioButton();
			this.rbMems = new System.Windows.Forms.RadioButton();
			this.label10 = new System.Windows.Forms.Label();
			this.pnFlags = new System.Windows.Forms.Panel();
			this.cbVis = new System.Windows.Forms.CheckBox();
			this.cbCtrl = new System.Windows.Forms.CheckBox();
			this.tbFlag = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage4 = new TD.SandDock.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.llSetRawLength = new System.Windows.Forms.LinkLabel();
			this.tbRawLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnObjectGuid.SuspendLayout();
			this.pnSubject.SuspendLayout();
			this.pnSub1.SuspendLayout();
			this.pnValue.SuspendLayout();
			this.pnInventory.SuspendLayout();
			this.pnOwner.SuspendLayout();
			this.pnSelection.SuspendLayout();
			this.pnListing.SuspendLayout();
			this.pnFlags.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pg
			// 
			this.pg.AccessibleDescription = resources.GetString("pg.AccessibleDescription");
			this.pg.AccessibleName = resources.GetString("pg.AccessibleName");
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pg.Anchor")));
			this.pg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pg.BackgroundImage")));
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pg.Dock")));
			this.pg.Enabled = ((bool)(resources.GetObject("pg.Enabled")));
			this.pg.Font = ((System.Drawing.Font)(resources.GetObject("pg.Font")));
			this.pg.HelpVisible = ((bool)(resources.GetObject("pg.HelpVisible")));
			this.pg.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pg.ImeMode")));
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = ((System.Drawing.Point)(resources.GetObject("pg.Location")));
			this.pg.Name = "pg";
			this.pg.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pg.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pg.RightToLeft")));
			this.pg.Size = ((System.Drawing.Size)(resources.GetObject("pg.Size")));
			this.pg.TabIndex = ((int)(resources.GetObject("pg.TabIndex")));
			this.pg.Text = resources.GetString("pg.Text");
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.Visible = ((bool)(resources.GetObject("pg.Visible")));
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_PropertyValueChanged);
			// 
			// tabControl2
			// 
			this.tabControl2.AccessibleDescription = resources.GetString("tabControl2.AccessibleDescription");
			this.tabControl2.AccessibleName = resources.GetString("tabControl2.AccessibleName");
			this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl2.Anchor")));
			this.tabControl2.AutoScroll = ((bool)(resources.GetObject("tabControl2.AutoScroll")));
			this.tabControl2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabControl2.AutoScrollMargin")));
			this.tabControl2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabControl2.AutoScrollMinSize")));
			this.tabControl2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl2.BackgroundImage")));
			this.tabControl2.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl2.Dock")));
			this.tabControl2.Enabled = ((bool)(resources.GetObject("tabControl2.Enabled")));
			this.tabControl2.Font = ((System.Drawing.Font)(resources.GetObject("tabControl2.Font")));
			this.tabControl2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl2.ImeMode")));
			this.tabControl2.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											new TD.SandDock.DocumentLayoutSystem(464, 328, new TD.SandDock.DockControl[] {
																																																															 this.tabPage3,
																																																															 this.tabPage4}, this.tabPage3)});
			this.tabControl2.Location = ((System.Drawing.Point)(resources.GetObject("tabControl2.Location")));
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl2.RightToLeft")));
			this.tabControl2.Size = ((System.Drawing.Size)(resources.GetObject("tabControl2.Size")));
			this.tabControl2.TabIndex = ((int)(resources.GetObject("tabControl2.TabIndex")));
			this.tabControl2.Text = resources.GetString("tabControl2.Text");
			this.tabControl2.Visible = ((bool)(resources.GetObject("tabControl2.Visible")));
			// 
			// tabPage3
			// 
			this.tabPage3.AccessibleDescription = resources.GetString("tabPage3.AccessibleDescription");
			this.tabPage3.AccessibleName = resources.GetString("tabPage3.AccessibleName");
			this.tabPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage3.Anchor")));
			this.tabPage3.AutoScroll = ((bool)(resources.GetObject("tabPage3.AutoScroll")));
			this.tabPage3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMargin")));
			this.tabPage3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMinSize")));
			this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Controls.Add(this.pnValue);
			this.tabPage3.Controls.Add(this.pnInventory);
			this.tabPage3.Controls.Add(this.pnOwner);
			this.tabPage3.Controls.Add(this.pnSelection);
			this.tabPage3.Controls.Add(this.pnListing);
			this.tabPage3.Controls.Add(this.pnFlags);
			this.tabPage3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage3.Dock")));
			this.tabPage3.Enabled = ((bool)(resources.GetObject("tabPage3.Enabled")));
			this.tabPage3.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage3.Font = ((System.Drawing.Font)(resources.GetObject("tabPage3.Font")));
			this.tabPage3.Guid = new System.Guid("4e851d66-304f-4d0f-9896-8d73154946f3");
			this.tabPage3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage3.ImeMode")));
			this.tabPage3.Location = ((System.Drawing.Point)(resources.GetObject("tabPage3.Location")));
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage3.RightToLeft")));
			this.tabPage3.Size = ((System.Drawing.Size)(resources.GetObject("tabPage3.Size")));
			this.tabPage3.TabIndex = ((int)(resources.GetObject("tabPage3.TabIndex")));
			this.tabPage3.TabText = resources.GetString("tabPage3.TabText");
			this.tabPage3.Text = resources.GetString("tabPage3.Text");
			this.tabPage3.ToolTipText = resources.GetString("tabPage3.ToolTipText");
			this.tabPage3.Visible = ((bool)(resources.GetObject("tabPage3.Visible")));
			this.tabPage3.VisibleChanged += new System.EventHandler(this.tabPage3_VisibleChanged);
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
			this.panel2.Controls.Add(this.pnObjectGuid);
			this.panel2.Controls.Add(this.pnSubject);
			this.panel2.Controls.Add(this.pnSub2);
			this.panel2.Controls.Add(this.pnSub1);
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
			// pnObjectGuid
			// 
			this.pnObjectGuid.AccessibleDescription = resources.GetString("pnObjectGuid.AccessibleDescription");
			this.pnObjectGuid.AccessibleName = resources.GetString("pnObjectGuid.AccessibleName");
			this.pnObjectGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnObjectGuid.Anchor")));
			this.pnObjectGuid.AutoScroll = ((bool)(resources.GetObject("pnObjectGuid.AutoScroll")));
			this.pnObjectGuid.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnObjectGuid.AutoScrollMargin")));
			this.pnObjectGuid.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnObjectGuid.AutoScrollMinSize")));
			this.pnObjectGuid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnObjectGuid.BackgroundImage")));
			this.pnObjectGuid.Controls.Add(this.cbSubjectObj);
			this.pnObjectGuid.Controls.Add(this.label5);
			this.pnObjectGuid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnObjectGuid.Dock")));
			this.pnObjectGuid.Enabled = ((bool)(resources.GetObject("pnObjectGuid.Enabled")));
			this.pnObjectGuid.Font = ((System.Drawing.Font)(resources.GetObject("pnObjectGuid.Font")));
			this.pnObjectGuid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnObjectGuid.ImeMode")));
			this.pnObjectGuid.Location = ((System.Drawing.Point)(resources.GetObject("pnObjectGuid.Location")));
			this.pnObjectGuid.Name = "pnObjectGuid";
			this.pnObjectGuid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnObjectGuid.RightToLeft")));
			this.pnObjectGuid.Size = ((System.Drawing.Size)(resources.GetObject("pnObjectGuid.Size")));
			this.pnObjectGuid.TabIndex = ((int)(resources.GetObject("pnObjectGuid.TabIndex")));
			this.pnObjectGuid.Text = resources.GetString("pnObjectGuid.Text");
			this.pnObjectGuid.Visible = ((bool)(resources.GetObject("pnObjectGuid.Visible")));
			// 
			// cbSubjectObj
			// 
			this.cbSubjectObj.AccessibleDescription = resources.GetString("cbSubjectObj.AccessibleDescription");
			this.cbSubjectObj.AccessibleName = resources.GetString("cbSubjectObj.AccessibleName");
			this.cbSubjectObj.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbSubjectObj.Anchor")));
			this.cbSubjectObj.AutoScroll = ((bool)(resources.GetObject("cbSubjectObj.AutoScroll")));
			this.cbSubjectObj.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbSubjectObj.AutoScrollMargin")));
			this.cbSubjectObj.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbSubjectObj.AutoScrollMinSize")));
			this.cbSubjectObj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbSubjectObj.BackgroundImage")));
			this.cbSubjectObj.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbSubjectObj.Dock")));
			this.cbSubjectObj.Enabled = ((bool)(resources.GetObject("cbSubjectObj.Enabled")));
			this.cbSubjectObj.Font = ((System.Drawing.Font)(resources.GetObject("cbSubjectObj.Font")));
			this.cbSubjectObj.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbSubjectObj.ImeMode")));
			this.cbSubjectObj.Location = ((System.Drawing.Point)(resources.GetObject("cbSubjectObj.Location")));
			this.cbSubjectObj.Name = "cbSubjectObj";
			this.cbSubjectObj.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbSubjectObj.RightToLeft")));
			// TODO: Beim Generieren des Codes für 'this.cbSubjectObj.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbSubjectObj.SelectedItem = null;
			this.cbSubjectObj.ShowAspiration = true;
			this.cbSubjectObj.ShowBadge = true;
			this.cbSubjectObj.ShowInventory = true;
			this.cbSubjectObj.ShowJobData = true;
			this.cbSubjectObj.ShowMemories = true;
			this.cbSubjectObj.ShowSkill = true;
			this.cbSubjectObj.ShowTokens = false;
			this.cbSubjectObj.Size = ((System.Drawing.Size)(resources.GetObject("cbSubjectObj.Size")));
			this.cbSubjectObj.TabIndex = ((int)(resources.GetObject("cbSubjectObj.TabIndex")));
			this.cbSubjectObj.Visible = ((bool)(resources.GetObject("cbSubjectObj.Visible")));
			this.cbSubjectObj.SelectedObjectChanged += new System.EventHandler(this.cbSubjectObj_SelectedObjectChanged);
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// pnSubject
			// 
			this.pnSubject.AccessibleDescription = resources.GetString("pnSubject.AccessibleDescription");
			this.pnSubject.AccessibleName = resources.GetString("pnSubject.AccessibleName");
			this.pnSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSubject.Anchor")));
			this.pnSubject.AutoScroll = ((bool)(resources.GetObject("pnSubject.AutoScroll")));
			this.pnSubject.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSubject.AutoScrollMargin")));
			this.pnSubject.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSubject.AutoScrollMinSize")));
			this.pnSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSubject.BackgroundImage")));
			this.pnSubject.Controls.Add(this.label4);
			this.pnSubject.Controls.Add(this.cbSubject);
			this.pnSubject.Controls.Add(this.llme2);
			this.pnSubject.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSubject.Dock")));
			this.pnSubject.Enabled = ((bool)(resources.GetObject("pnSubject.Enabled")));
			this.pnSubject.Font = ((System.Drawing.Font)(resources.GetObject("pnSubject.Font")));
			this.pnSubject.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSubject.ImeMode")));
			this.pnSubject.Location = ((System.Drawing.Point)(resources.GetObject("pnSubject.Location")));
			this.pnSubject.Name = "pnSubject";
			this.pnSubject.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSubject.RightToLeft")));
			this.pnSubject.Size = ((System.Drawing.Size)(resources.GetObject("pnSubject.Size")));
			this.pnSubject.TabIndex = ((int)(resources.GetObject("pnSubject.TabIndex")));
			this.pnSubject.Text = resources.GetString("pnSubject.Text");
			this.pnSubject.Visible = ((bool)(resources.GetObject("pnSubject.Visible")));
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
			// cbSubject
			// 
			this.cbSubject.AccessibleDescription = resources.GetString("cbSubject.AccessibleDescription");
			this.cbSubject.AccessibleName = resources.GetString("cbSubject.AccessibleName");
			this.cbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbSubject.Anchor")));
			this.cbSubject.AutoScroll = ((bool)(resources.GetObject("cbSubject.AutoScroll")));
			this.cbSubject.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbSubject.AutoScrollMargin")));
			this.cbSubject.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbSubject.AutoScrollMinSize")));
			this.cbSubject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbSubject.BackgroundImage")));
			this.cbSubject.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbSubject.Dock")));
			this.cbSubject.Enabled = ((bool)(resources.GetObject("cbSubject.Enabled")));
			this.cbSubject.Font = ((System.Drawing.Font)(resources.GetObject("cbSubject.Font")));
			this.cbSubject.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbSubject.ImeMode")));
			this.cbSubject.Location = ((System.Drawing.Point)(resources.GetObject("cbSubject.Location")));
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbSubject.RightToLeft")));
			this.cbSubject.SelectedSim = null;
			// TODO: Beim Generieren des Codes für 'this.cbSubject.SelectedSimId' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.cbSubject.SelectedSimInstance' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt16. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbSubject.Size = ((System.Drawing.Size)(resources.GetObject("cbSubject.Size")));
			this.cbSubject.TabIndex = ((int)(resources.GetObject("cbSubject.TabIndex")));
			this.cbSubject.Visible = ((bool)(resources.GetObject("cbSubject.Visible")));
			this.cbSubject.SelectedSimChanged += new System.EventHandler(this.cbSubject_SelectedSimChanged);
			// 
			// llme2
			// 
			this.llme2.AccessibleDescription = resources.GetString("llme2.AccessibleDescription");
			this.llme2.AccessibleName = resources.GetString("llme2.AccessibleName");
			this.llme2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llme2.Anchor")));
			this.llme2.AutoSize = ((bool)(resources.GetObject("llme2.AutoSize")));
			this.llme2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llme2.Dock")));
			this.llme2.Enabled = ((bool)(resources.GetObject("llme2.Enabled")));
			this.llme2.Font = ((System.Drawing.Font)(resources.GetObject("llme2.Font")));
			this.llme2.Image = ((System.Drawing.Image)(resources.GetObject("llme2.Image")));
			this.llme2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llme2.ImageAlign")));
			this.llme2.ImageIndex = ((int)(resources.GetObject("llme2.ImageIndex")));
			this.llme2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llme2.ImeMode")));
			this.llme2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llme2.LinkArea")));
			this.llme2.Location = ((System.Drawing.Point)(resources.GetObject("llme2.Location")));
			this.llme2.Name = "llme2";
			this.llme2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llme2.RightToLeft")));
			this.llme2.Size = ((System.Drawing.Size)(resources.GetObject("llme2.Size")));
			this.llme2.TabIndex = ((int)(resources.GetObject("llme2.TabIndex")));
			this.llme2.TabStop = true;
			this.llme2.Text = resources.GetString("llme2.Text");
			this.llme2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llme2.TextAlign")));
			this.llme2.Visible = ((bool)(resources.GetObject("llme2.Visible")));
			this.llme2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// pnSub2
			// 
			this.pnSub2.AccessibleDescription = resources.GetString("pnSub2.AccessibleDescription");
			this.pnSub2.AccessibleName = resources.GetString("pnSub2.AccessibleName");
			this.pnSub2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSub2.Anchor")));
			this.pnSub2.AutoScroll = ((bool)(resources.GetObject("pnSub2.AutoScroll")));
			this.pnSub2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSub2.AutoScrollMargin")));
			this.pnSub2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSub2.AutoScrollMinSize")));
			this.pnSub2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSub2.BackgroundImage")));
			this.pnSub2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSub2.Dock")));
			this.pnSub2.Enabled = ((bool)(resources.GetObject("pnSub2.Enabled")));
			this.pnSub2.Font = ((System.Drawing.Font)(resources.GetObject("pnSub2.Font")));
			this.pnSub2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSub2.ImeMode")));
			this.pnSub2.Location = ((System.Drawing.Point)(resources.GetObject("pnSub2.Location")));
			this.pnSub2.Name = "pnSub2";
			this.pnSub2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSub2.RightToLeft")));
			this.pnSub2.Size = ((System.Drawing.Size)(resources.GetObject("pnSub2.Size")));
			this.pnSub2.TabIndex = ((int)(resources.GetObject("pnSub2.TabIndex")));
			this.pnSub2.Text = resources.GetString("pnSub2.Text");
			this.pnSub2.Visible = ((bool)(resources.GetObject("pnSub2.Visible")));
			// 
			// pnSub1
			// 
			this.pnSub1.AccessibleDescription = resources.GetString("pnSub1.AccessibleDescription");
			this.pnSub1.AccessibleName = resources.GetString("pnSub1.AccessibleName");
			this.pnSub1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSub1.Anchor")));
			this.pnSub1.AutoScroll = ((bool)(resources.GetObject("pnSub1.AutoScroll")));
			this.pnSub1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSub1.AutoScrollMargin")));
			this.pnSub1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSub1.AutoScrollMinSize")));
			this.pnSub1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSub1.BackgroundImage")));
			this.pnSub1.Controls.Add(this.label6);
			this.pnSub1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSub1.Dock")));
			this.pnSub1.Enabled = ((bool)(resources.GetObject("pnSub1.Enabled")));
			this.pnSub1.Font = ((System.Drawing.Font)(resources.GetObject("pnSub1.Font")));
			this.pnSub1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSub1.ImeMode")));
			this.pnSub1.Location = ((System.Drawing.Point)(resources.GetObject("pnSub1.Location")));
			this.pnSub1.Name = "pnSub1";
			this.pnSub1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSub1.RightToLeft")));
			this.pnSub1.Size = ((System.Drawing.Size)(resources.GetObject("pnSub1.Size")));
			this.pnSub1.TabIndex = ((int)(resources.GetObject("pnSub1.TabIndex")));
			this.pnSub1.Text = resources.GetString("pnSub1.Text");
			this.pnSub1.Visible = ((bool)(resources.GetObject("pnSub1.Visible")));
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Enabled = ((bool)(resources.GetObject("label6.Enabled")));
			this.label6.Font = ((System.Drawing.Font)(resources.GetObject("label6.Font")));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			// 
			// pnValue
			// 
			this.pnValue.AccessibleDescription = resources.GetString("pnValue.AccessibleDescription");
			this.pnValue.AccessibleName = resources.GetString("pnValue.AccessibleName");
			this.pnValue.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnValue.Anchor")));
			this.pnValue.AutoScroll = ((bool)(resources.GetObject("pnValue.AutoScroll")));
			this.pnValue.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnValue.AutoScrollMargin")));
			this.pnValue.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnValue.AutoScrollMinSize")));
			this.pnValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnValue.BackgroundImage")));
			this.pnValue.Controls.Add(this.tbValue);
			this.pnValue.Controls.Add(this.label8);
			this.pnValue.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnValue.Dock")));
			this.pnValue.Enabled = ((bool)(resources.GetObject("pnValue.Enabled")));
			this.pnValue.Font = ((System.Drawing.Font)(resources.GetObject("pnValue.Font")));
			this.pnValue.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnValue.ImeMode")));
			this.pnValue.Location = ((System.Drawing.Point)(resources.GetObject("pnValue.Location")));
			this.pnValue.Name = "pnValue";
			this.pnValue.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnValue.RightToLeft")));
			this.pnValue.Size = ((System.Drawing.Size)(resources.GetObject("pnValue.Size")));
			this.pnValue.TabIndex = ((int)(resources.GetObject("pnValue.TabIndex")));
			this.pnValue.Text = resources.GetString("pnValue.Text");
			this.pnValue.Visible = ((bool)(resources.GetObject("pnValue.Visible")));
			// 
			// tbValue
			// 
			this.tbValue.AccessibleDescription = resources.GetString("tbValue.AccessibleDescription");
			this.tbValue.AccessibleName = resources.GetString("tbValue.AccessibleName");
			this.tbValue.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbValue.Anchor")));
			this.tbValue.AutoSize = ((bool)(resources.GetObject("tbValue.AutoSize")));
			this.tbValue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbValue.BackgroundImage")));
			this.tbValue.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbValue.Dock")));
			this.tbValue.Enabled = ((bool)(resources.GetObject("tbValue.Enabled")));
			this.tbValue.Font = ((System.Drawing.Font)(resources.GetObject("tbValue.Font")));
			this.tbValue.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbValue.ImeMode")));
			this.tbValue.Location = ((System.Drawing.Point)(resources.GetObject("tbValue.Location")));
			this.tbValue.MaxLength = ((int)(resources.GetObject("tbValue.MaxLength")));
			this.tbValue.Multiline = ((bool)(resources.GetObject("tbValue.Multiline")));
			this.tbValue.Name = "tbValue";
			this.tbValue.PasswordChar = ((char)(resources.GetObject("tbValue.PasswordChar")));
			this.tbValue.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbValue.RightToLeft")));
			this.tbValue.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbValue.ScrollBars")));
			this.tbValue.Size = ((System.Drawing.Size)(resources.GetObject("tbValue.Size")));
			this.tbValue.TabIndex = ((int)(resources.GetObject("tbValue.TabIndex")));
			this.tbValue.Text = resources.GetString("tbValue.Text");
			this.tbValue.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbValue.TextAlign")));
			this.tbValue.Visible = ((bool)(resources.GetObject("tbValue.Visible")));
			this.tbValue.WordWrap = ((bool)(resources.GetObject("tbValue.WordWrap")));
			this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Enabled = ((bool)(resources.GetObject("label8.Enabled")));
			this.label8.Font = ((System.Drawing.Font)(resources.GetObject("label8.Font")));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			// 
			// pnInventory
			// 
			this.pnInventory.AccessibleDescription = resources.GetString("pnInventory.AccessibleDescription");
			this.pnInventory.AccessibleName = resources.GetString("pnInventory.AccessibleName");
			this.pnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnInventory.Anchor")));
			this.pnInventory.AutoScroll = ((bool)(resources.GetObject("pnInventory.AutoScroll")));
			this.pnInventory.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnInventory.AutoScrollMargin")));
			this.pnInventory.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnInventory.AutoScrollMinSize")));
			this.pnInventory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInventory.BackgroundImage")));
			this.pnInventory.Controls.Add(this.tbInv);
			this.pnInventory.Controls.Add(this.label7);
			this.pnInventory.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnInventory.Dock")));
			this.pnInventory.Enabled = ((bool)(resources.GetObject("pnInventory.Enabled")));
			this.pnInventory.Font = ((System.Drawing.Font)(resources.GetObject("pnInventory.Font")));
			this.pnInventory.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnInventory.ImeMode")));
			this.pnInventory.Location = ((System.Drawing.Point)(resources.GetObject("pnInventory.Location")));
			this.pnInventory.Name = "pnInventory";
			this.pnInventory.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnInventory.RightToLeft")));
			this.pnInventory.Size = ((System.Drawing.Size)(resources.GetObject("pnInventory.Size")));
			this.pnInventory.TabIndex = ((int)(resources.GetObject("pnInventory.TabIndex")));
			this.pnInventory.Text = resources.GetString("pnInventory.Text");
			this.pnInventory.Visible = ((bool)(resources.GetObject("pnInventory.Visible")));
			// 
			// tbInv
			// 
			this.tbInv.AccessibleDescription = resources.GetString("tbInv.AccessibleDescription");
			this.tbInv.AccessibleName = resources.GetString("tbInv.AccessibleName");
			this.tbInv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbInv.Anchor")));
			this.tbInv.AutoSize = ((bool)(resources.GetObject("tbInv.AutoSize")));
			this.tbInv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbInv.BackgroundImage")));
			this.tbInv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbInv.Dock")));
			this.tbInv.Enabled = ((bool)(resources.GetObject("tbInv.Enabled")));
			this.tbInv.Font = ((System.Drawing.Font)(resources.GetObject("tbInv.Font")));
			this.tbInv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbInv.ImeMode")));
			this.tbInv.Location = ((System.Drawing.Point)(resources.GetObject("tbInv.Location")));
			this.tbInv.MaxLength = ((int)(resources.GetObject("tbInv.MaxLength")));
			this.tbInv.Multiline = ((bool)(resources.GetObject("tbInv.Multiline")));
			this.tbInv.Name = "tbInv";
			this.tbInv.PasswordChar = ((char)(resources.GetObject("tbInv.PasswordChar")));
			this.tbInv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbInv.RightToLeft")));
			this.tbInv.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbInv.ScrollBars")));
			this.tbInv.Size = ((System.Drawing.Size)(resources.GetObject("tbInv.Size")));
			this.tbInv.TabIndex = ((int)(resources.GetObject("tbInv.TabIndex")));
			this.tbInv.Text = resources.GetString("tbInv.Text");
			this.tbInv.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbInv.TextAlign")));
			this.tbInv.Visible = ((bool)(resources.GetObject("tbInv.Visible")));
			this.tbInv.WordWrap = ((bool)(resources.GetObject("tbInv.WordWrap")));
			this.tbInv.TextChanged += new System.EventHandler(this.tbInv_TextChanged);
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
			// 
			// pnOwner
			// 
			this.pnOwner.AccessibleDescription = resources.GetString("pnOwner.AccessibleDescription");
			this.pnOwner.AccessibleName = resources.GetString("pnOwner.AccessibleName");
			this.pnOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnOwner.Anchor")));
			this.pnOwner.AutoScroll = ((bool)(resources.GetObject("pnOwner.AutoScroll")));
			this.pnOwner.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnOwner.AutoScrollMargin")));
			this.pnOwner.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnOwner.AutoScrollMinSize")));
			this.pnOwner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnOwner.BackgroundImage")));
			this.pnOwner.Controls.Add(this.cbOwner);
			this.pnOwner.Controls.Add(this.llme);
			this.pnOwner.Controls.Add(this.label3);
			this.pnOwner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnOwner.Dock")));
			this.pnOwner.Enabled = ((bool)(resources.GetObject("pnOwner.Enabled")));
			this.pnOwner.Font = ((System.Drawing.Font)(resources.GetObject("pnOwner.Font")));
			this.pnOwner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnOwner.ImeMode")));
			this.pnOwner.Location = ((System.Drawing.Point)(resources.GetObject("pnOwner.Location")));
			this.pnOwner.Name = "pnOwner";
			this.pnOwner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnOwner.RightToLeft")));
			this.pnOwner.Size = ((System.Drawing.Size)(resources.GetObject("pnOwner.Size")));
			this.pnOwner.TabIndex = ((int)(resources.GetObject("pnOwner.TabIndex")));
			this.pnOwner.Text = resources.GetString("pnOwner.Text");
			this.pnOwner.Visible = ((bool)(resources.GetObject("pnOwner.Visible")));
			// 
			// cbOwner
			// 
			this.cbOwner.AccessibleDescription = resources.GetString("cbOwner.AccessibleDescription");
			this.cbOwner.AccessibleName = resources.GetString("cbOwner.AccessibleName");
			this.cbOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbOwner.Anchor")));
			this.cbOwner.AutoScroll = ((bool)(resources.GetObject("cbOwner.AutoScroll")));
			this.cbOwner.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbOwner.AutoScrollMargin")));
			this.cbOwner.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbOwner.AutoScrollMinSize")));
			this.cbOwner.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbOwner.BackgroundImage")));
			this.cbOwner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbOwner.Dock")));
			this.cbOwner.Enabled = ((bool)(resources.GetObject("cbOwner.Enabled")));
			this.cbOwner.Font = ((System.Drawing.Font)(resources.GetObject("cbOwner.Font")));
			this.cbOwner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbOwner.ImeMode")));
			this.cbOwner.Location = ((System.Drawing.Point)(resources.GetObject("cbOwner.Location")));
			this.cbOwner.Name = "cbOwner";
			this.cbOwner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbOwner.RightToLeft")));
			this.cbOwner.SelectedSim = null;
			// TODO: Beim Generieren des Codes für 'this.cbOwner.SelectedSimId' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.cbOwner.SelectedSimInstance' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt16. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbOwner.Size = ((System.Drawing.Size)(resources.GetObject("cbOwner.Size")));
			this.cbOwner.TabIndex = ((int)(resources.GetObject("cbOwner.TabIndex")));
			this.cbOwner.Visible = ((bool)(resources.GetObject("cbOwner.Visible")));
			this.cbOwner.SelectedSimChanged += new System.EventHandler(this.cbOwner_SelectedSimChanged);
			// 
			// llme
			// 
			this.llme.AccessibleDescription = resources.GetString("llme.AccessibleDescription");
			this.llme.AccessibleName = resources.GetString("llme.AccessibleName");
			this.llme.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llme.Anchor")));
			this.llme.AutoSize = ((bool)(resources.GetObject("llme.AutoSize")));
			this.llme.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llme.Dock")));
			this.llme.Enabled = ((bool)(resources.GetObject("llme.Enabled")));
			this.llme.Font = ((System.Drawing.Font)(resources.GetObject("llme.Font")));
			this.llme.Image = ((System.Drawing.Image)(resources.GetObject("llme.Image")));
			this.llme.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llme.ImageAlign")));
			this.llme.ImageIndex = ((int)(resources.GetObject("llme.ImageIndex")));
			this.llme.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llme.ImeMode")));
			this.llme.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llme.LinkArea")));
			this.llme.Location = ((System.Drawing.Point)(resources.GetObject("llme.Location")));
			this.llme.Name = "llme";
			this.llme.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llme.RightToLeft")));
			this.llme.Size = ((System.Drawing.Size)(resources.GetObject("llme.Size")));
			this.llme.TabIndex = ((int)(resources.GetObject("llme.TabIndex")));
			this.llme.TabStop = true;
			this.llme.Text = resources.GetString("llme.Text");
			this.llme.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llme.TextAlign")));
			this.llme.Visible = ((bool)(resources.GetObject("llme.Visible")));
			this.llme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llme_LinkClicked);
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
			// pnSelection
			// 
			this.pnSelection.AccessibleDescription = resources.GetString("pnSelection.AccessibleDescription");
			this.pnSelection.AccessibleName = resources.GetString("pnSelection.AccessibleName");
			this.pnSelection.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSelection.Anchor")));
			this.pnSelection.AutoScroll = ((bool)(resources.GetObject("pnSelection.AutoScroll")));
			this.pnSelection.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSelection.AutoScrollMargin")));
			this.pnSelection.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSelection.AutoScrollMinSize")));
			this.pnSelection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSelection.BackgroundImage")));
			this.pnSelection.Controls.Add(this.lbtype);
			this.pnSelection.Controls.Add(this.label2);
			this.pnSelection.Controls.Add(this.pb);
			this.pnSelection.Controls.Add(this.cbtype);
			this.pnSelection.Controls.Add(this.cbObjs);
			this.pnSelection.Controls.Add(this.cbToks);
			this.pnSelection.Controls.Add(this.cbMems);
			this.pnSelection.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSelection.Dock")));
			this.pnSelection.Enabled = ((bool)(resources.GetObject("pnSelection.Enabled")));
			this.pnSelection.Font = ((System.Drawing.Font)(resources.GetObject("pnSelection.Font")));
			this.pnSelection.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSelection.ImeMode")));
			this.pnSelection.Location = ((System.Drawing.Point)(resources.GetObject("pnSelection.Location")));
			this.pnSelection.Name = "pnSelection";
			this.pnSelection.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSelection.RightToLeft")));
			this.pnSelection.Size = ((System.Drawing.Size)(resources.GetObject("pnSelection.Size")));
			this.pnSelection.TabIndex = ((int)(resources.GetObject("pnSelection.TabIndex")));
			this.pnSelection.Text = resources.GetString("pnSelection.Text");
			this.pnSelection.Visible = ((bool)(resources.GetObject("pnSelection.Visible")));
			// 
			// lbtype
			// 
			this.lbtype.AccessibleDescription = resources.GetString("lbtype.AccessibleDescription");
			this.lbtype.AccessibleName = resources.GetString("lbtype.AccessibleName");
			this.lbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbtype.Anchor")));
			this.lbtype.AutoSize = ((bool)(resources.GetObject("lbtype.AutoSize")));
			this.lbtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbtype.Dock")));
			this.lbtype.Enabled = ((bool)(resources.GetObject("lbtype.Enabled")));
			this.lbtype.Font = ((System.Drawing.Font)(resources.GetObject("lbtype.Font")));
			this.lbtype.Image = ((System.Drawing.Image)(resources.GetObject("lbtype.Image")));
			this.lbtype.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtype.ImageAlign")));
			this.lbtype.ImageIndex = ((int)(resources.GetObject("lbtype.ImageIndex")));
			this.lbtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbtype.ImeMode")));
			this.lbtype.Location = ((System.Drawing.Point)(resources.GetObject("lbtype.Location")));
			this.lbtype.Name = "lbtype";
			this.lbtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbtype.RightToLeft")));
			this.lbtype.Size = ((System.Drawing.Size)(resources.GetObject("lbtype.Size")));
			this.lbtype.TabIndex = ((int)(resources.GetObject("lbtype.TabIndex")));
			this.lbtype.Text = resources.GetString("lbtype.Text");
			this.lbtype.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtype.TextAlign")));
			this.lbtype.Visible = ((bool)(resources.GetObject("lbtype.Visible")));
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
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pb.SizeMode")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TabStop = false;
			this.pb.Text = resources.GetString("pb.Text");
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			// 
			// cbtype
			// 
			this.cbtype.AccessibleDescription = resources.GetString("cbtype.AccessibleDescription");
			this.cbtype.AccessibleName = resources.GetString("cbtype.AccessibleName");
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtype.Anchor")));
			this.cbtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtype.BackgroundImage")));
			this.cbtype.DefaultText = resources.GetString("cbtype.DefaultText");
			this.cbtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtype.Dock")));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = ((bool)(resources.GetObject("cbtype.Enabled")));
			this.cbtype.Enum = null;
			this.cbtype.Font = ((System.Drawing.Font)(resources.GetObject("cbtype.Font")));
			this.cbtype.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtype.ImeMode")));
			this.cbtype.IntegralHeight = ((bool)(resources.GetObject("cbtype.IntegralHeight")));
			this.cbtype.ItemHeight = ((int)(resources.GetObject("cbtype.ItemHeight")));
			this.cbtype.Location = ((System.Drawing.Point)(resources.GetObject("cbtype.Location")));
			this.cbtype.MaxDropDownItems = ((int)(resources.GetObject("cbtype.MaxDropDownItems")));
			this.cbtype.MaxLength = ((int)(resources.GetObject("cbtype.MaxLength")));
			this.cbtype.Name = "cbtype";
			this.cbtype.ResourceManager = null;
			this.cbtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtype.RightToLeft")));
			this.cbtype.Size = ((System.Drawing.Size)(resources.GetObject("cbtype.Size")));
			this.cbtype.TabIndex = ((int)(resources.GetObject("cbtype.TabIndex")));
			this.cbtype.Text = resources.GetString("cbtype.Text");
			this.cbtype.Visible = ((bool)(resources.GetObject("cbtype.Visible")));
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
			// 
			// cbObjs
			// 
			this.cbObjs.AccessibleDescription = resources.GetString("cbObjs.AccessibleDescription");
			this.cbObjs.AccessibleName = resources.GetString("cbObjs.AccessibleName");
			this.cbObjs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbObjs.Anchor")));
			this.cbObjs.AutoScroll = ((bool)(resources.GetObject("cbObjs.AutoScroll")));
			this.cbObjs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbObjs.AutoScrollMargin")));
			this.cbObjs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbObjs.AutoScrollMinSize")));
			this.cbObjs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbObjs.BackgroundImage")));
			this.cbObjs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbObjs.Dock")));
			this.cbObjs.Enabled = ((bool)(resources.GetObject("cbObjs.Enabled")));
			this.cbObjs.Font = ((System.Drawing.Font)(resources.GetObject("cbObjs.Font")));
			this.cbObjs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbObjs.ImeMode")));
			this.cbObjs.Location = ((System.Drawing.Point)(resources.GetObject("cbObjs.Location")));
			this.cbObjs.Name = "cbObjs";
			this.cbObjs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbObjs.RightToLeft")));
			// TODO: Beim Generieren des Codes für 'this.cbObjs.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbObjs.SelectedItem = null;
			this.cbObjs.ShowAspiration = false;
			this.cbObjs.ShowBadge = false;
			this.cbObjs.ShowInventory = true;
			this.cbObjs.ShowJobData = false;
			this.cbObjs.ShowMemories = false;
			this.cbObjs.ShowSkill = false;
			this.cbObjs.ShowTokens = false;
			this.cbObjs.Size = ((System.Drawing.Size)(resources.GetObject("cbObjs.Size")));
			this.cbObjs.TabIndex = ((int)(resources.GetObject("cbObjs.TabIndex")));
			this.cbObjs.Visible = ((bool)(resources.GetObject("cbObjs.Visible")));
			this.cbObjs.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// cbToks
			// 
			this.cbToks.AccessibleDescription = resources.GetString("cbToks.AccessibleDescription");
			this.cbToks.AccessibleName = resources.GetString("cbToks.AccessibleName");
			this.cbToks.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbToks.Anchor")));
			this.cbToks.AutoScroll = ((bool)(resources.GetObject("cbToks.AutoScroll")));
			this.cbToks.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbToks.AutoScrollMargin")));
			this.cbToks.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbToks.AutoScrollMinSize")));
			this.cbToks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbToks.BackgroundImage")));
			this.cbToks.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbToks.Dock")));
			this.cbToks.Enabled = ((bool)(resources.GetObject("cbToks.Enabled")));
			this.cbToks.Font = ((System.Drawing.Font)(resources.GetObject("cbToks.Font")));
			this.cbToks.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbToks.ImeMode")));
			this.cbToks.Location = ((System.Drawing.Point)(resources.GetObject("cbToks.Location")));
			this.cbToks.Name = "cbToks";
			this.cbToks.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbToks.RightToLeft")));
			// TODO: Beim Generieren des Codes für 'this.cbToks.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbToks.SelectedItem = null;
			this.cbToks.ShowAspiration = false;
			this.cbToks.ShowBadge = false;
			this.cbToks.ShowInventory = false;
			this.cbToks.ShowJobData = false;
			this.cbToks.ShowMemories = false;
			this.cbToks.ShowSkill = false;
			this.cbToks.ShowTokens = true;
			this.cbToks.Size = ((System.Drawing.Size)(resources.GetObject("cbToks.Size")));
			this.cbToks.TabIndex = ((int)(resources.GetObject("cbToks.TabIndex")));
			this.cbToks.Visible = ((bool)(resources.GetObject("cbToks.Visible")));
			this.cbToks.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// cbMems
			// 
			this.cbMems.AccessibleDescription = resources.GetString("cbMems.AccessibleDescription");
			this.cbMems.AccessibleName = resources.GetString("cbMems.AccessibleName");
			this.cbMems.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbMems.Anchor")));
			this.cbMems.AutoScroll = ((bool)(resources.GetObject("cbMems.AutoScroll")));
			this.cbMems.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cbMems.AutoScrollMargin")));
			this.cbMems.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cbMems.AutoScrollMinSize")));
			this.cbMems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbMems.BackgroundImage")));
			this.cbMems.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbMems.Dock")));
			this.cbMems.Enabled = ((bool)(resources.GetObject("cbMems.Enabled")));
			this.cbMems.Font = ((System.Drawing.Font)(resources.GetObject("cbMems.Font")));
			this.cbMems.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbMems.ImeMode")));
			this.cbMems.Location = ((System.Drawing.Point)(resources.GetObject("cbMems.Location")));
			this.cbMems.Name = "cbMems";
			this.cbMems.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbMems.RightToLeft")));
			// TODO: Beim Generieren des Codes für 'this.cbMems.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbMems.SelectedItem = null;
			this.cbMems.ShowAspiration = false;
			this.cbMems.ShowBadge = false;
			this.cbMems.ShowInventory = false;
			this.cbMems.ShowJobData = false;
			this.cbMems.ShowMemories = true;
			this.cbMems.ShowSkill = false;
			this.cbMems.ShowTokens = false;
			this.cbMems.Size = ((System.Drawing.Size)(resources.GetObject("cbMems.Size")));
			this.cbMems.TabIndex = ((int)(resources.GetObject("cbMems.TabIndex")));
			this.cbMems.Visible = ((bool)(resources.GetObject("cbMems.Visible")));
			this.cbMems.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// pnListing
			// 
			this.pnListing.AccessibleDescription = resources.GetString("pnListing.AccessibleDescription");
			this.pnListing.AccessibleName = resources.GetString("pnListing.AccessibleName");
			this.pnListing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnListing.Anchor")));
			this.pnListing.AutoScroll = ((bool)(resources.GetObject("pnListing.AutoScroll")));
			this.pnListing.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnListing.AutoScrollMargin")));
			this.pnListing.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnListing.AutoScrollMinSize")));
			this.pnListing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnListing.BackgroundImage")));
			this.pnListing.Controls.Add(this.rbObjs);
			this.pnListing.Controls.Add(this.rbToks);
			this.pnListing.Controls.Add(this.rbMems);
			this.pnListing.Controls.Add(this.label10);
			this.pnListing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnListing.Dock")));
			this.pnListing.Enabled = ((bool)(resources.GetObject("pnListing.Enabled")));
			this.pnListing.Font = ((System.Drawing.Font)(resources.GetObject("pnListing.Font")));
			this.pnListing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnListing.ImeMode")));
			this.pnListing.Location = ((System.Drawing.Point)(resources.GetObject("pnListing.Location")));
			this.pnListing.Name = "pnListing";
			this.pnListing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnListing.RightToLeft")));
			this.pnListing.Size = ((System.Drawing.Size)(resources.GetObject("pnListing.Size")));
			this.pnListing.TabIndex = ((int)(resources.GetObject("pnListing.TabIndex")));
			this.pnListing.Text = resources.GetString("pnListing.Text");
			this.pnListing.Visible = ((bool)(resources.GetObject("pnListing.Visible")));
			// 
			// rbObjs
			// 
			this.rbObjs.AccessibleDescription = resources.GetString("rbObjs.AccessibleDescription");
			this.rbObjs.AccessibleName = resources.GetString("rbObjs.AccessibleName");
			this.rbObjs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbObjs.Anchor")));
			this.rbObjs.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbObjs.Appearance")));
			this.rbObjs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbObjs.BackgroundImage")));
			this.rbObjs.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbObjs.CheckAlign")));
			this.rbObjs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbObjs.Dock")));
			this.rbObjs.Enabled = ((bool)(resources.GetObject("rbObjs.Enabled")));
			this.rbObjs.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbObjs.FlatStyle")));
			this.rbObjs.Font = ((System.Drawing.Font)(resources.GetObject("rbObjs.Font")));
			this.rbObjs.Image = ((System.Drawing.Image)(resources.GetObject("rbObjs.Image")));
			this.rbObjs.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbObjs.ImageAlign")));
			this.rbObjs.ImageIndex = ((int)(resources.GetObject("rbObjs.ImageIndex")));
			this.rbObjs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbObjs.ImeMode")));
			this.rbObjs.Location = ((System.Drawing.Point)(resources.GetObject("rbObjs.Location")));
			this.rbObjs.Name = "rbObjs";
			this.rbObjs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbObjs.RightToLeft")));
			this.rbObjs.Size = ((System.Drawing.Size)(resources.GetObject("rbObjs.Size")));
			this.rbObjs.TabIndex = ((int)(resources.GetObject("rbObjs.TabIndex")));
			this.rbObjs.Text = resources.GetString("rbObjs.Text");
			this.rbObjs.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbObjs.TextAlign")));
			this.rbObjs.Visible = ((bool)(resources.GetObject("rbObjs.Visible")));
			this.rbObjs.CheckedChanged += new System.EventHandler(this.rbObjs_CheckedChanged);
			// 
			// rbToks
			// 
			this.rbToks.AccessibleDescription = resources.GetString("rbToks.AccessibleDescription");
			this.rbToks.AccessibleName = resources.GetString("rbToks.AccessibleName");
			this.rbToks.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbToks.Anchor")));
			this.rbToks.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbToks.Appearance")));
			this.rbToks.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbToks.BackgroundImage")));
			this.rbToks.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbToks.CheckAlign")));
			this.rbToks.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbToks.Dock")));
			this.rbToks.Enabled = ((bool)(resources.GetObject("rbToks.Enabled")));
			this.rbToks.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbToks.FlatStyle")));
			this.rbToks.Font = ((System.Drawing.Font)(resources.GetObject("rbToks.Font")));
			this.rbToks.Image = ((System.Drawing.Image)(resources.GetObject("rbToks.Image")));
			this.rbToks.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbToks.ImageAlign")));
			this.rbToks.ImageIndex = ((int)(resources.GetObject("rbToks.ImageIndex")));
			this.rbToks.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbToks.ImeMode")));
			this.rbToks.Location = ((System.Drawing.Point)(resources.GetObject("rbToks.Location")));
			this.rbToks.Name = "rbToks";
			this.rbToks.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbToks.RightToLeft")));
			this.rbToks.Size = ((System.Drawing.Size)(resources.GetObject("rbToks.Size")));
			this.rbToks.TabIndex = ((int)(resources.GetObject("rbToks.TabIndex")));
			this.rbToks.Text = resources.GetString("rbToks.Text");
			this.rbToks.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbToks.TextAlign")));
			this.rbToks.Visible = ((bool)(resources.GetObject("rbToks.Visible")));
			this.rbToks.CheckedChanged += new System.EventHandler(this.rbToks_CheckedChanged);
			// 
			// rbMems
			// 
			this.rbMems.AccessibleDescription = resources.GetString("rbMems.AccessibleDescription");
			this.rbMems.AccessibleName = resources.GetString("rbMems.AccessibleName");
			this.rbMems.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbMems.Anchor")));
			this.rbMems.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbMems.Appearance")));
			this.rbMems.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbMems.BackgroundImage")));
			this.rbMems.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbMems.CheckAlign")));
			this.rbMems.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbMems.Dock")));
			this.rbMems.Enabled = ((bool)(resources.GetObject("rbMems.Enabled")));
			this.rbMems.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbMems.FlatStyle")));
			this.rbMems.Font = ((System.Drawing.Font)(resources.GetObject("rbMems.Font")));
			this.rbMems.Image = ((System.Drawing.Image)(resources.GetObject("rbMems.Image")));
			this.rbMems.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbMems.ImageAlign")));
			this.rbMems.ImageIndex = ((int)(resources.GetObject("rbMems.ImageIndex")));
			this.rbMems.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbMems.ImeMode")));
			this.rbMems.Location = ((System.Drawing.Point)(resources.GetObject("rbMems.Location")));
			this.rbMems.Name = "rbMems";
			this.rbMems.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbMems.RightToLeft")));
			this.rbMems.Size = ((System.Drawing.Size)(resources.GetObject("rbMems.Size")));
			this.rbMems.TabIndex = ((int)(resources.GetObject("rbMems.TabIndex")));
			this.rbMems.Text = resources.GetString("rbMems.Text");
			this.rbMems.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbMems.TextAlign")));
			this.rbMems.Visible = ((bool)(resources.GetObject("rbMems.Visible")));
			this.rbMems.CheckedChanged += new System.EventHandler(this.rbMems_CheckedChanged);
			// 
			// label10
			// 
			this.label10.AccessibleDescription = resources.GetString("label10.AccessibleDescription");
			this.label10.AccessibleName = resources.GetString("label10.AccessibleName");
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label10.Anchor")));
			this.label10.AutoSize = ((bool)(resources.GetObject("label10.AutoSize")));
			this.label10.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label10.Dock")));
			this.label10.Enabled = ((bool)(resources.GetObject("label10.Enabled")));
			this.label10.Font = ((System.Drawing.Font)(resources.GetObject("label10.Font")));
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.ImageAlign")));
			this.label10.ImageIndex = ((int)(resources.GetObject("label10.ImageIndex")));
			this.label10.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label10.ImeMode")));
			this.label10.Location = ((System.Drawing.Point)(resources.GetObject("label10.Location")));
			this.label10.Name = "label10";
			this.label10.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label10.RightToLeft")));
			this.label10.Size = ((System.Drawing.Size)(resources.GetObject("label10.Size")));
			this.label10.TabIndex = ((int)(resources.GetObject("label10.TabIndex")));
			this.label10.Text = resources.GetString("label10.Text");
			this.label10.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.TextAlign")));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			// 
			// pnFlags
			// 
			this.pnFlags.AccessibleDescription = resources.GetString("pnFlags.AccessibleDescription");
			this.pnFlags.AccessibleName = resources.GetString("pnFlags.AccessibleName");
			this.pnFlags.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnFlags.Anchor")));
			this.pnFlags.AutoScroll = ((bool)(resources.GetObject("pnFlags.AutoScroll")));
			this.pnFlags.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnFlags.AutoScrollMargin")));
			this.pnFlags.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnFlags.AutoScrollMinSize")));
			this.pnFlags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnFlags.BackgroundImage")));
			this.pnFlags.Controls.Add(this.cbVis);
			this.pnFlags.Controls.Add(this.cbCtrl);
			this.pnFlags.Controls.Add(this.tbFlag);
			this.pnFlags.Controls.Add(this.label9);
			this.pnFlags.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnFlags.Dock")));
			this.pnFlags.Enabled = ((bool)(resources.GetObject("pnFlags.Enabled")));
			this.pnFlags.Font = ((System.Drawing.Font)(resources.GetObject("pnFlags.Font")));
			this.pnFlags.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnFlags.ImeMode")));
			this.pnFlags.Location = ((System.Drawing.Point)(resources.GetObject("pnFlags.Location")));
			this.pnFlags.Name = "pnFlags";
			this.pnFlags.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnFlags.RightToLeft")));
			this.pnFlags.Size = ((System.Drawing.Size)(resources.GetObject("pnFlags.Size")));
			this.pnFlags.TabIndex = ((int)(resources.GetObject("pnFlags.TabIndex")));
			this.pnFlags.Text = resources.GetString("pnFlags.Text");
			this.pnFlags.Visible = ((bool)(resources.GetObject("pnFlags.Visible")));
			// 
			// cbVis
			// 
			this.cbVis.AccessibleDescription = resources.GetString("cbVis.AccessibleDescription");
			this.cbVis.AccessibleName = resources.GetString("cbVis.AccessibleName");
			this.cbVis.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbVis.Anchor")));
			this.cbVis.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbVis.Appearance")));
			this.cbVis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbVis.BackgroundImage")));
			this.cbVis.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbVis.CheckAlign")));
			this.cbVis.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbVis.Dock")));
			this.cbVis.Enabled = ((bool)(resources.GetObject("cbVis.Enabled")));
			this.cbVis.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbVis.FlatStyle")));
			this.cbVis.Font = ((System.Drawing.Font)(resources.GetObject("cbVis.Font")));
			this.cbVis.Image = ((System.Drawing.Image)(resources.GetObject("cbVis.Image")));
			this.cbVis.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbVis.ImageAlign")));
			this.cbVis.ImageIndex = ((int)(resources.GetObject("cbVis.ImageIndex")));
			this.cbVis.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbVis.ImeMode")));
			this.cbVis.Location = ((System.Drawing.Point)(resources.GetObject("cbVis.Location")));
			this.cbVis.Name = "cbVis";
			this.cbVis.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbVis.RightToLeft")));
			this.cbVis.Size = ((System.Drawing.Size)(resources.GetObject("cbVis.Size")));
			this.cbVis.TabIndex = ((int)(resources.GetObject("cbVis.TabIndex")));
			this.cbVis.Text = resources.GetString("cbVis.Text");
			this.cbVis.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbVis.TextAlign")));
			this.cbVis.Visible = ((bool)(resources.GetObject("cbVis.Visible")));
			this.cbVis.CheckedChanged += new System.EventHandler(this.cbVis_CheckedChanged);
			// 
			// cbCtrl
			// 
			this.cbCtrl.AccessibleDescription = resources.GetString("cbCtrl.AccessibleDescription");
			this.cbCtrl.AccessibleName = resources.GetString("cbCtrl.AccessibleName");
			this.cbCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbCtrl.Anchor")));
			this.cbCtrl.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbCtrl.Appearance")));
			this.cbCtrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbCtrl.BackgroundImage")));
			this.cbCtrl.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbCtrl.CheckAlign")));
			this.cbCtrl.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbCtrl.Dock")));
			this.cbCtrl.Enabled = ((bool)(resources.GetObject("cbCtrl.Enabled")));
			this.cbCtrl.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbCtrl.FlatStyle")));
			this.cbCtrl.Font = ((System.Drawing.Font)(resources.GetObject("cbCtrl.Font")));
			this.cbCtrl.Image = ((System.Drawing.Image)(resources.GetObject("cbCtrl.Image")));
			this.cbCtrl.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbCtrl.ImageAlign")));
			this.cbCtrl.ImageIndex = ((int)(resources.GetObject("cbCtrl.ImageIndex")));
			this.cbCtrl.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbCtrl.ImeMode")));
			this.cbCtrl.Location = ((System.Drawing.Point)(resources.GetObject("cbCtrl.Location")));
			this.cbCtrl.Name = "cbCtrl";
			this.cbCtrl.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbCtrl.RightToLeft")));
			this.cbCtrl.Size = ((System.Drawing.Size)(resources.GetObject("cbCtrl.Size")));
			this.cbCtrl.TabIndex = ((int)(resources.GetObject("cbCtrl.TabIndex")));
			this.cbCtrl.Text = resources.GetString("cbCtrl.Text");
			this.cbCtrl.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbCtrl.TextAlign")));
			this.cbCtrl.Visible = ((bool)(resources.GetObject("cbCtrl.Visible")));
			this.cbCtrl.CheckedChanged += new System.EventHandler(this.cbAct_CheckedChanged);
			// 
			// tbFlag
			// 
			this.tbFlag.AccessibleDescription = resources.GetString("tbFlag.AccessibleDescription");
			this.tbFlag.AccessibleName = resources.GetString("tbFlag.AccessibleName");
			this.tbFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbFlag.Anchor")));
			this.tbFlag.AutoSize = ((bool)(resources.GetObject("tbFlag.AutoSize")));
			this.tbFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFlag.BackgroundImage")));
			this.tbFlag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbFlag.Dock")));
			this.tbFlag.Enabled = ((bool)(resources.GetObject("tbFlag.Enabled")));
			this.tbFlag.Font = ((System.Drawing.Font)(resources.GetObject("tbFlag.Font")));
			this.tbFlag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbFlag.ImeMode")));
			this.tbFlag.Location = ((System.Drawing.Point)(resources.GetObject("tbFlag.Location")));
			this.tbFlag.MaxLength = ((int)(resources.GetObject("tbFlag.MaxLength")));
			this.tbFlag.Multiline = ((bool)(resources.GetObject("tbFlag.Multiline")));
			this.tbFlag.Name = "tbFlag";
			this.tbFlag.PasswordChar = ((char)(resources.GetObject("tbFlag.PasswordChar")));
			this.tbFlag.ReadOnly = true;
			this.tbFlag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbFlag.RightToLeft")));
			this.tbFlag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbFlag.ScrollBars")));
			this.tbFlag.Size = ((System.Drawing.Size)(resources.GetObject("tbFlag.Size")));
			this.tbFlag.TabIndex = ((int)(resources.GetObject("tbFlag.TabIndex")));
			this.tbFlag.Text = resources.GetString("tbFlag.Text");
			this.tbFlag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbFlag.TextAlign")));
			this.tbFlag.Visible = ((bool)(resources.GetObject("tbFlag.Visible")));
			this.tbFlag.WordWrap = ((bool)(resources.GetObject("tbFlag.WordWrap")));
			this.tbFlag.TextChanged += new System.EventHandler(this.tbFlag_TextChanged);
			// 
			// label9
			// 
			this.label9.AccessibleDescription = resources.GetString("label9.AccessibleDescription");
			this.label9.AccessibleName = resources.GetString("label9.AccessibleName");
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
			this.label9.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label9.Dock")));
			this.label9.Enabled = ((bool)(resources.GetObject("label9.Enabled")));
			this.label9.Font = ((System.Drawing.Font)(resources.GetObject("label9.Font")));
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.ImageAlign")));
			this.label9.ImageIndex = ((int)(resources.GetObject("label9.ImageIndex")));
			this.label9.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label9.ImeMode")));
			this.label9.Location = ((System.Drawing.Point)(resources.GetObject("label9.Location")));
			this.label9.Name = "label9";
			this.label9.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label9.RightToLeft")));
			this.label9.Size = ((System.Drawing.Size)(resources.GetObject("label9.Size")));
			this.label9.TabIndex = ((int)(resources.GetObject("label9.TabIndex")));
			this.label9.Text = resources.GetString("label9.Text");
			this.label9.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.TextAlign")));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
			// 
			// tabPage4
			// 
			this.tabPage4.AccessibleDescription = resources.GetString("tabPage4.AccessibleDescription");
			this.tabPage4.AccessibleName = resources.GetString("tabPage4.AccessibleName");
			this.tabPage4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage4.Anchor")));
			this.tabPage4.AutoScroll = ((bool)(resources.GetObject("tabPage4.AutoScroll")));
			this.tabPage4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMargin")));
			this.tabPage4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMinSize")));
			this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
			this.tabPage4.Controls.Add(this.pg);
			this.tabPage4.Controls.Add(this.panel1);
			this.tabPage4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage4.Dock")));
			this.tabPage4.Enabled = ((bool)(resources.GetObject("tabPage4.Enabled")));
			this.tabPage4.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage4.Font = ((System.Drawing.Font)(resources.GetObject("tabPage4.Font")));
			this.tabPage4.Guid = new System.Guid("3b0d25ef-e354-4693-8339-f171a2b4f000");
			this.tabPage4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage4.ImeMode")));
			this.tabPage4.Location = ((System.Drawing.Point)(resources.GetObject("tabPage4.Location")));
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage4.RightToLeft")));
			this.tabPage4.Size = ((System.Drawing.Size)(resources.GetObject("tabPage4.Size")));
			this.tabPage4.TabIndex = ((int)(resources.GetObject("tabPage4.TabIndex")));
			this.tabPage4.TabText = resources.GetString("tabPage4.TabText");
			this.tabPage4.Text = resources.GetString("tabPage4.Text");
			this.tabPage4.ToolTipText = resources.GetString("tabPage4.ToolTipText");
			this.tabPage4.Visible = ((bool)(resources.GetObject("tabPage4.Visible")));
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
			this.panel1.Controls.Add(this.llSetRawLength);
			this.panel1.Controls.Add(this.tbRawLength);
			this.panel1.Controls.Add(this.label1);
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
			// llSetRawLength
			// 
			this.llSetRawLength.AccessibleDescription = resources.GetString("llSetRawLength.AccessibleDescription");
			this.llSetRawLength.AccessibleName = resources.GetString("llSetRawLength.AccessibleName");
			this.llSetRawLength.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llSetRawLength.Anchor")));
			this.llSetRawLength.AutoSize = ((bool)(resources.GetObject("llSetRawLength.AutoSize")));
			this.llSetRawLength.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llSetRawLength.Dock")));
			this.llSetRawLength.Enabled = ((bool)(resources.GetObject("llSetRawLength.Enabled")));
			this.llSetRawLength.Font = ((System.Drawing.Font)(resources.GetObject("llSetRawLength.Font")));
			this.llSetRawLength.Image = ((System.Drawing.Image)(resources.GetObject("llSetRawLength.Image")));
			this.llSetRawLength.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llSetRawLength.ImageAlign")));
			this.llSetRawLength.ImageIndex = ((int)(resources.GetObject("llSetRawLength.ImageIndex")));
			this.llSetRawLength.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llSetRawLength.ImeMode")));
			this.llSetRawLength.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llSetRawLength.LinkArea")));
			this.llSetRawLength.Location = ((System.Drawing.Point)(resources.GetObject("llSetRawLength.Location")));
			this.llSetRawLength.Name = "llSetRawLength";
			this.llSetRawLength.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llSetRawLength.RightToLeft")));
			this.llSetRawLength.Size = ((System.Drawing.Size)(resources.GetObject("llSetRawLength.Size")));
			this.llSetRawLength.TabIndex = ((int)(resources.GetObject("llSetRawLength.TabIndex")));
			this.llSetRawLength.TabStop = true;
			this.llSetRawLength.Text = resources.GetString("llSetRawLength.Text");
			this.llSetRawLength.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llSetRawLength.TextAlign")));
			this.llSetRawLength.Visible = ((bool)(resources.GetObject("llSetRawLength.Visible")));
			this.llSetRawLength.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetRawLength_LinkClicked);
			// 
			// tbRawLength
			// 
			this.tbRawLength.AccessibleDescription = resources.GetString("tbRawLength.AccessibleDescription");
			this.tbRawLength.AccessibleName = resources.GetString("tbRawLength.AccessibleName");
			this.tbRawLength.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbRawLength.Anchor")));
			this.tbRawLength.AutoSize = ((bool)(resources.GetObject("tbRawLength.AutoSize")));
			this.tbRawLength.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbRawLength.BackgroundImage")));
			this.tbRawLength.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbRawLength.Dock")));
			this.tbRawLength.Enabled = ((bool)(resources.GetObject("tbRawLength.Enabled")));
			this.tbRawLength.Font = ((System.Drawing.Font)(resources.GetObject("tbRawLength.Font")));
			this.tbRawLength.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbRawLength.ImeMode")));
			this.tbRawLength.Location = ((System.Drawing.Point)(resources.GetObject("tbRawLength.Location")));
			this.tbRawLength.MaxLength = ((int)(resources.GetObject("tbRawLength.MaxLength")));
			this.tbRawLength.Multiline = ((bool)(resources.GetObject("tbRawLength.Multiline")));
			this.tbRawLength.Name = "tbRawLength";
			this.tbRawLength.PasswordChar = ((char)(resources.GetObject("tbRawLength.PasswordChar")));
			this.tbRawLength.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbRawLength.RightToLeft")));
			this.tbRawLength.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbRawLength.ScrollBars")));
			this.tbRawLength.Size = ((System.Drawing.Size)(resources.GetObject("tbRawLength.Size")));
			this.tbRawLength.TabIndex = ((int)(resources.GetObject("tbRawLength.TabIndex")));
			this.tbRawLength.Text = resources.GetString("tbRawLength.Text");
			this.tbRawLength.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbRawLength.TextAlign")));
			this.tbRawLength.Visible = ((bool)(resources.GetObject("tbRawLength.Visible")));
			this.tbRawLength.WordWrap = ((bool)(resources.GetObject("tbRawLength.WordWrap")));
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
			// MemoryProperties
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.tabControl2);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "MemoryProperties";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnObjectGuid.ResumeLayout(false);
			this.pnSubject.ResumeLayout(false);
			this.pnSub1.ResumeLayout(false);
			this.pnValue.ResumeLayout(false);
			this.pnInventory.ResumeLayout(false);
			this.pnOwner.ResumeLayout(false);
			this.pnSelection.ResumeLayout(false);
			this.pnListing.ResumeLayout(false);
			this.pnFlags.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		NgbhItem item;
		private System.Windows.Forms.PropertyGrid pg;
		private TD.SandDock.TabControl tabControl2;
		private TD.SandDock.TabPage tabPage3;
		private TD.SandDock.TabPage tabPage4;
		private System.Windows.Forms.TextBox tbRawLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel llSetRawLength;
		private System.Windows.Forms.Label lbtype;
		private Ambertation.Windows.Forms.EnumComboBox cbtype;
		private SimPe.PackedFiles.Wrapper.ObjectComboBox cbMems;
		private SimPe.PackedFiles.Wrapper.ObjectComboBox cbToks;
		private System.Windows.Forms.Label label2;
		private SimPe.PackedFiles.Wrapper.ObjectComboBox cbObjs;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Panel pnSelection;
		private System.Windows.Forms.Panel pnOwner;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.LinkLabel llme;
		SimPe.PackedFiles.Wrapper.SimComboBox cbOwner;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel pnSubject;
		private SimPe.PackedFiles.Wrapper.SimComboBox cbSubject;
		private SimPe.PackedFiles.Wrapper.ObjectComboBox cbSubjectObj;
		private System.Windows.Forms.Panel pnObjectGuid;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.LinkLabel llme2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnSub2;
		private System.Windows.Forms.Panel pnSub1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel pnInventory;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbInv;
		private System.Windows.Forms.Panel pnValue;
		private System.Windows.Forms.TextBox tbValue;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel pnFlags;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox cbVis;
		private System.Windows.Forms.TextBox tbFlag;
		private System.Windows.Forms.CheckBox cbCtrl;
		private System.Windows.Forms.Panel pnListing;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.RadioButton rbMems;
		private System.Windows.Forms.RadioButton rbToks;
		private System.Windows.Forms.RadioButton rbObjs;
	
		[System.ComponentModel.Browsable(false)]
		public NgbhItem Item
		{
			get {return item;}
			set 
			{
				item = value;
				SetContent();
			}
		}

		Plugin.NgbhItemsListView nilv;
		public Plugin.NgbhItemsListView NgbhItemsListView
		{
			get {return nilv;}
			set 
			{
				if (nilv!=null) nilv.SelectedIndexChanged -= new EventHandler(nilv_SelectedIndexChanged);
				nilv = value;
				if (nilv!=null) nilv.SelectedIndexChanged += new EventHandler(nilv_SelectedIndexChanged);

				nilv_SelectedIndexChanged(null, null);
			}
		}

		public event EventHandler ChangedItem;
		protected void UpdateNgbhItemsListView()
		{
			if (nilv!=null) nilv.UpdateSelected(item);
		}
		protected void FireChangeEvent()
		{			
			UpdateNgbhItemsListView();
			if (ChangedItem!=null) ChangedItem(this, new EventArgs());
		}

		bool inter;
		bool chgraw;
		void SetContent()
		{
			if (inter) return;	inter = true;
			chgraw = false;
			pg.SelectedObject = null;
			pb.Image = null;
			if (item!=null)
			{
				this.Enabled = true;
				Hashtable ht = new Hashtable();
				byte ct=0;
				foreach (string v in item.MemoryCacheItem.ValueNames)
					ht[Helper.HexString(ct)+": "+v] = new Ambertation.BaseChangeableNumber(item.GetValue(ct++));

				while (ct<item.Data.Length) 				
					ht[Helper.HexString(ct)+":"] = new Ambertation.BaseChangeableNumber(item.GetValue(ct++));				

				Ambertation.PropertyObjectBuilderExt pob = new Ambertation.PropertyObjectBuilderExt(ht);
				
				pg.SelectedObject = pob.Instance;

				this.tbRawLength.Text = item.Data.Length.ToString();
				this.cbtype.SelectedValue = item.MemoryType;

				UpdateSelectedItem();

				pb.Image = item.MemoryCacheItem.Image;

				SelectOwner(this.cbOwner, item);
				SelectSubject(item);

				tbInv.Text = item.InventoryNumber.ToString();
				this.tbValue.Text = item.Value.ToString();
				UpdateFlagsValue();
			} 
			else 
			{
				this.Enabled = false;
			}
			inter = false;
		}

		void UpdateFlagsValue()
		{
			this.tbFlag.Text = "0x" + Helper.HexString(item.Flags.Value);
		}

		void UpdateSelectedItem()
		{
			bool use = (!item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory);			
			this.cbMems.Visible = use;
			this.rbMems.Checked = use;
			if (use) SelectNgbhItem(cbMems, item);


			use = item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory;
			this.cbToks.Visible = use;
			this.rbToks.Checked = use;
			if (use)  SelectNgbhItem(cbToks, item);

			use = (!item.MemoryCacheItem.IsToken && item.MemoryCacheItem.IsInventory);
			this.cbObjs.Visible = use;
			this.rbObjs.Checked = use;
			if (use) SelectNgbhItem(cbObjs, item);
		}

		void SelectNgbhItem(SimPe.PackedFiles.Wrapper.ObjectComboBox cb, NgbhItem item)
		{
			cb.SelectedGuid = item.Guid;
		}

		void SelectOwner(SimPe.PackedFiles.Wrapper.SimComboBox cb, NgbhItem item)
		{
			cb.SelectedSimInstance = item.OwnerInstance;
		}

		void SelectSubject(NgbhItem item)
		{
			this.cbSubject.SelectedSimId = item.SubjectGuid;
			if (item.MemoryType == SimMemoryType.Object)
				this.cbSubjectObj.SelectedGuid = item.ReferencedObjectGuid;
			else
				this.cbSubjectObj.SelectedGuid = item.SubjectGuid;
		}

		private void nilv_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (nilv!=null) 
			{
				Plugin.NgbhItemsListViewItem lvi = nilv.SelectedItem;
				if (lvi!=null)
					Item = lvi.Item;
				else 
					Item = null;
			} 
			else 
				Item = null;
		}

		private void llSetRawLength_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.item!=null)
			{
				ushort[] ndata = new ushort[Helper.StringToInt32(this.tbRawLength.Text, item.Data.Length, 10)];
				for (int i=0; i<ndata.Length; i++)
					if (i<item.Data.Length) ndata[i] = item.Data[i];
					else ndata[i] = 0;
				item.Data = ndata;
				SetContent();
			}
		}

		private void ChangeGuid(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;
			SimPe.PackedFiles.Wrapper.ObjectComboBox cb = sender as SimPe.PackedFiles.Wrapper.ObjectComboBox;
			item.Guid = cb.SelectedGuid;
			SetContent();
			this.FireChangeEvent();							
		}

		private void pg_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (item==null) return;
			string[] n = e.ChangedItem.Label.Split(new char[] {':'}, 2);
			if (n.Length>0)
			{
				int v = Helper.StringToInt32(n[0], -1, 16);
				if (v>=0) 
				{
					item.PutValue(v, (ushort)((Ambertation.BaseChangeableNumber)e.ChangedItem.Value).Value);
					chgraw = true;
					UpdateNgbhItemsListView();
				}
			}
		}

		private void tabPage3_VisibleChanged(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Visible && chgraw) 
			{
				SetContent();				
			}
		}

		private void cbtype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			SimMemoryType smt = (SimMemoryType)cbtype.SelectedValue;

			this.pnOwner.Visible = (smt==SimMemoryType.Memory || smt==SimMemoryType.Gossip || smt == SimMemoryType.GossipInventory);
			this.pnSub1.Visible = (smt==SimMemoryType.Memory || smt==SimMemoryType.Gossip);
			this.pnSub2.Visible = this.pnSub1.Visible;
			this.pnSubject.Visible = (smt==SimMemoryType.Memory || smt==SimMemoryType.Gossip);
			this.pnObjectGuid.Visible = (smt==SimMemoryType.Memory || smt==SimMemoryType.Gossip || smt== SimMemoryType.Object);

			this.pnInventory.Visible = (smt==SimMemoryType.Inventory || smt==SimMemoryType.GossipInventory);
			this.pnValue.Visible = (smt==SimMemoryType.Skill || smt == SimMemoryType.Badge || smt==SimMemoryType.ValueToken);
			this.pnFlags.Visible = true;

			this.pnListing.Visible = Helper.WindowsRegistry.HiddenMode;
		}

		void SetMe(SimPe.PackedFiles.Wrapper.SimComboBox cb)
		{
			if (item==null) return;
			cb.SelectedSimInstance = (ushort)item.ParentSlot.SlotID;
		}
		private void llme_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			SetMe(this.cbOwner);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			SetMe(this.cbSubject);
		}

		private void cbOwner_SelectedSimChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			item.OwnerInstance = cbOwner.SelectedSimInstance;
			
			SetContent();
			this.FireChangeEvent();
		}

		private void cbSubject_SelectedSimChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			inter = true;
			this.cbSubjectObj.SelectedGuid = 0xffffffff;
			item.SetSubject(this.cbSubject.SelectedSimInstance, this.cbSubject.SelectedSimId);
			inter = false;

			SetContent();
			this.FireChangeEvent();			
		}

		private void cbSubjectObj_SelectedObjectChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			inter = true;
			
			this.cbSubject.SelectedSimId = 0xffffffff;
			if (item.MemoryType == SimMemoryType.Object)
				item.ReferencedObjectGuid = this.cbSubjectObj.SelectedGuid;
			else
				item.SetSubject(0, this.cbSubjectObj.SelectedGuid);
			inter = false;

			SetContent();
			this.FireChangeEvent();			
		}

		private void tbInv_TextChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			item.InventoryNumber = Helper.StringToUInt32(this.tbInv.Text, item.InventoryNumber, 10);
			SetContent();
			this.FireChangeEvent();
		}

		private void tbValue_TextChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			item.Value = Helper.StringToUInt16(this.tbInv.Text, item.Value, 10);			
			this.FireChangeEvent();
		}

		private void tbFlag_TextChanged(object sender, System.EventArgs e)
		{
			if (item==null) return;
			this.cbCtrl.Checked = item.Flags.IsControler;
			this.cbVis.Checked = item.Flags.IsVisible;
		}

		private void cbVis_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			inter = true;
			item.Flags.IsVisible = this.cbVis.Checked;
			UpdateFlagsValue();
			inter = false;
			SetContent();
			this.FireChangeEvent();
		}

		private void cbAct_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;

			inter = true;
			item.Flags.IsControler = this.cbCtrl.Checked;
			UpdateFlagsValue();
			inter = false;
			SetContent();
			this.FireChangeEvent();
		}

		private void rbObjs_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			cbObjs.Visible = true;
			cbMems.Visible = false;
			cbToks.Visible = false;
		}

		private void rbMems_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			cbObjs.Visible = false;
			cbMems.Visible = true;
			cbToks.Visible = false;
		}

		private void rbToks_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			cbObjs.Visible = false;
			cbMems.Visible = false;
			cbToks.Visible = true;
		}

		
			
	}
}
