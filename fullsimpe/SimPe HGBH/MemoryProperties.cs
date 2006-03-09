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
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(0, 0);
			this.pg.Name = "pg";
			this.pg.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pg.Size = new System.Drawing.Size(460, 272);
			this.pg.TabIndex = 0;
			this.pg.Text = "pg";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_PropertyValueChanged);
			// 
			// tabControl2
			// 
			this.tabControl2.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											new TD.SandDock.DocumentLayoutSystem(464, 328, new TD.SandDock.DockControl[] {
																																																															 this.tabPage3,
																																																															 this.tabPage4}, this.tabPage3)});
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.Size = new System.Drawing.Size(464, 328);
			this.tabControl2.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.AutoScroll = true;
			this.tabPage3.Controls.Add(this.panel2);
			this.tabPage3.Controls.Add(this.pnValue);
			this.tabPage3.Controls.Add(this.pnInventory);
			this.tabPage3.Controls.Add(this.pnOwner);
			this.tabPage3.Controls.Add(this.pnSelection);
			this.tabPage3.Controls.Add(this.pnListing);
			this.tabPage3.Controls.Add(this.pnFlags);
			this.tabPage3.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage3.Guid = new System.Guid("4e851d66-304f-4d0f-9896-8d73154946f3");
			this.tabPage3.Location = new System.Drawing.Point(2, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(460, 304);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.TabText = "Properties";
			this.tabPage3.Text = "Properties";
			this.tabPage3.VisibleChanged += new System.EventHandler(this.tabPage3_VisibleChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnObjectGuid);
			this.panel2.Controls.Add(this.pnSubject);
			this.panel2.Controls.Add(this.pnSub2);
			this.panel2.Controls.Add(this.pnSub1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 208);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(460, 80);
			this.panel2.TabIndex = 18;
			// 
			// pnObjectGuid
			// 
			this.pnObjectGuid.Controls.Add(this.cbSubjectObj);
			this.pnObjectGuid.Controls.Add(this.label5);
			this.pnObjectGuid.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnObjectGuid.Location = new System.Drawing.Point(16, 48);
			this.pnObjectGuid.Name = "pnObjectGuid";
			this.pnObjectGuid.Size = new System.Drawing.Size(444, 24);
			this.pnObjectGuid.TabIndex = 17;
			// 
			// cbSubjectObj
			// 
			this.cbSubjectObj.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbSubjectObj.Location = new System.Drawing.Point(80, 0);
			this.cbSubjectObj.Name = "cbSubjectObj";
			// TODO: Beim Generieren des Codes für 'this.cbSubjectObj.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbSubjectObj.SelectedItem = null;
			this.cbSubjectObj.ShowAspiration = true;
			this.cbSubjectObj.ShowBadge = true;
			this.cbSubjectObj.ShowInventory = true;
			this.cbSubjectObj.ShowJobData = true;
			this.cbSubjectObj.ShowMemories = true;
			this.cbSubjectObj.ShowSkill = true;
			this.cbSubjectObj.ShowTokens = false;
			this.cbSubjectObj.Size = new System.Drawing.Size(360, 21);
			this.cbSubjectObj.TabIndex = 17;
			this.cbSubjectObj.SelectedObjectChanged += new System.EventHandler(this.cbSubjectObj_SelectedObjectChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Object:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnSubject
			// 
			this.pnSubject.Controls.Add(this.label4);
			this.pnSubject.Controls.Add(this.cbSubject);
			this.pnSubject.Controls.Add(this.llme2);
			this.pnSubject.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnSubject.Location = new System.Drawing.Point(16, 24);
			this.pnSubject.Name = "pnSubject";
			this.pnSubject.Size = new System.Drawing.Size(444, 24);
			this.pnSubject.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 23);
			this.label4.TabIndex = 14;
			this.label4.Text = "Sim:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbSubject
			// 
			this.cbSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbSubject.Location = new System.Drawing.Point(80, 0);
			this.cbSubject.Name = "cbSubject";
			this.cbSubject.SelectedSim = null;
			// TODO: Beim Generieren des Codes für 'this.cbSubject.SelectedSimId' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.cbSubject.SelectedSimInstance' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt16. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbSubject.Size = new System.Drawing.Size(336, 24);
			this.cbSubject.TabIndex = 16;
			this.cbSubject.SelectedSimChanged += new System.EventHandler(this.cbSubject_SelectedSimChanged);
			// 
			// llme2
			// 
			this.llme2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llme2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llme2.Location = new System.Drawing.Point(416, 8);
			this.llme2.Name = "llme2";
			this.llme2.Size = new System.Drawing.Size(24, 16);
			this.llme2.TabIndex = 17;
			this.llme2.TabStop = true;
			this.llme2.Text = "Me";
			this.llme2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llme2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// pnSub2
			// 
			this.pnSub2.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnSub2.Location = new System.Drawing.Point(0, 24);
			this.pnSub2.Name = "pnSub2";
			this.pnSub2.Size = new System.Drawing.Size(16, 56);
			this.pnSub2.TabIndex = 18;
			// 
			// pnSub1
			// 
			this.pnSub1.Controls.Add(this.label6);
			this.pnSub1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnSub1.Location = new System.Drawing.Point(0, 0);
			this.pnSub1.Name = "pnSub1";
			this.pnSub1.Size = new System.Drawing.Size(460, 24);
			this.pnSub1.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(0, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(72, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Subject...";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnValue
			// 
			this.pnValue.Controls.Add(this.tbValue);
			this.pnValue.Controls.Add(this.label8);
			this.pnValue.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnValue.Location = new System.Drawing.Point(0, 176);
			this.pnValue.Name = "pnValue";
			this.pnValue.Size = new System.Drawing.Size(460, 32);
			this.pnValue.TabIndex = 21;
			this.pnValue.Visible = false;
			// 
			// tbValue
			// 
			this.tbValue.Location = new System.Drawing.Point(80, 0);
			this.tbValue.Name = "tbValue";
			this.tbValue.Size = new System.Drawing.Size(56, 21);
			this.tbValue.TabIndex = 13;
			this.tbValue.Text = "";
			this.tbValue.TextChanged += new System.EventHandler(this.tbValue_TextChanged);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 23);
			this.label8.TabIndex = 12;
			this.label8.Text = "Value:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnInventory
			// 
			this.pnInventory.Controls.Add(this.tbInv);
			this.pnInventory.Controls.Add(this.label7);
			this.pnInventory.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnInventory.Location = new System.Drawing.Point(0, 144);
			this.pnInventory.Name = "pnInventory";
			this.pnInventory.Size = new System.Drawing.Size(460, 32);
			this.pnInventory.TabIndex = 19;
			this.pnInventory.Visible = false;
			// 
			// tbInv
			// 
			this.tbInv.Location = new System.Drawing.Point(80, 0);
			this.tbInv.Name = "tbInv";
			this.tbInv.Size = new System.Drawing.Size(56, 21);
			this.tbInv.TabIndex = 13;
			this.tbInv.Text = "";
			this.tbInv.TextChanged += new System.EventHandler(this.tbInv_TextChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(0, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Inventory #:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnOwner
			// 
			this.pnOwner.Controls.Add(this.cbOwner);
			this.pnOwner.Controls.Add(this.llme);
			this.pnOwner.Controls.Add(this.label3);
			this.pnOwner.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnOwner.Location = new System.Drawing.Point(0, 120);
			this.pnOwner.Name = "pnOwner";
			this.pnOwner.Size = new System.Drawing.Size(460, 24);
			this.pnOwner.TabIndex = 15;
			// 
			// cbOwner
			// 
			this.cbOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbOwner.Location = new System.Drawing.Point(80, 0);
			this.cbOwner.Name = "cbOwner";
			this.cbOwner.SelectedSim = null;
			// TODO: Beim Generieren des Codes für 'this.cbOwner.SelectedSimId' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.cbOwner.SelectedSimInstance' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt16. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbOwner.Size = new System.Drawing.Size(352, 24);
			this.cbOwner.TabIndex = 16;
			this.cbOwner.SelectedSimChanged += new System.EventHandler(this.cbOwner_SelectedSimChanged);
			// 
			// llme
			// 
			this.llme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llme.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llme.Location = new System.Drawing.Point(424, 8);
			this.llme.Name = "llme";
			this.llme.Size = new System.Drawing.Size(32, 16);
			this.llme.TabIndex = 15;
			this.llme.TabStop = true;
			this.llme.Text = "Me";
			this.llme.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llme.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llme_LinkClicked);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 14;
			this.label3.Text = "Owner:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnSelection
			// 
			this.pnSelection.Controls.Add(this.lbtype);
			this.pnSelection.Controls.Add(this.label2);
			this.pnSelection.Controls.Add(this.pb);
			this.pnSelection.Controls.Add(this.cbtype);
			this.pnSelection.Controls.Add(this.cbObjs);
			this.pnSelection.Controls.Add(this.cbToks);
			this.pnSelection.Controls.Add(this.cbMems);
			this.pnSelection.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnSelection.Location = new System.Drawing.Point(0, 56);
			this.pnSelection.Name = "pnSelection";
			this.pnSelection.Size = new System.Drawing.Size(460, 64);
			this.pnSelection.TabIndex = 14;
			// 
			// lbtype
			// 
			this.lbtype.Location = new System.Drawing.Point(0, 8);
			this.lbtype.Name = "lbtype";
			this.lbtype.Size = new System.Drawing.Size(56, 23);
			this.lbtype.TabIndex = 8;
			this.lbtype.Text = "Type:";
			this.lbtype.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pb
			// 
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pb.Location = new System.Drawing.Point(392, 0);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(64, 64);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pb.TabIndex = 13;
			this.pb.TabStop = false;
			// 
			// cbtype
			// 
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = false;
			this.cbtype.Enum = null;
			this.cbtype.Location = new System.Drawing.Point(64, 8);
			this.cbtype.Name = "cbtype";
			this.cbtype.ResourceManager = null;
			this.cbtype.Size = new System.Drawing.Size(320, 21);
			this.cbtype.TabIndex = 0;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.cbtype_SelectedIndexChanged);
			// 
			// cbObjs
			// 
			this.cbObjs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbObjs.Location = new System.Drawing.Point(64, 32);
			this.cbObjs.Name = "cbObjs";
			// TODO: Beim Generieren des Codes für 'this.cbObjs.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbObjs.SelectedItem = null;
			this.cbObjs.ShowAspiration = false;
			this.cbObjs.ShowBadge = false;
			this.cbObjs.ShowInventory = true;
			this.cbObjs.ShowJobData = false;
			this.cbObjs.ShowMemories = false;
			this.cbObjs.ShowSkill = false;
			this.cbObjs.ShowTokens = false;
			this.cbObjs.Size = new System.Drawing.Size(320, 21);
			this.cbObjs.TabIndex = 12;
			this.cbObjs.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// cbToks
			// 
			this.cbToks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbToks.Location = new System.Drawing.Point(64, 32);
			this.cbToks.Name = "cbToks";
			// TODO: Beim Generieren des Codes für 'this.cbToks.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbToks.SelectedItem = null;
			this.cbToks.ShowAspiration = false;
			this.cbToks.ShowBadge = false;
			this.cbToks.ShowInventory = false;
			this.cbToks.ShowJobData = false;
			this.cbToks.ShowMemories = false;
			this.cbToks.ShowSkill = false;
			this.cbToks.ShowTokens = true;
			this.cbToks.Size = new System.Drawing.Size(320, 21);
			this.cbToks.TabIndex = 10;
			this.cbToks.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// cbMems
			// 
			this.cbMems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbMems.Location = new System.Drawing.Point(64, 32);
			this.cbMems.Name = "cbMems";
			// TODO: Beim Generieren des Codes für 'this.cbMems.SelectedGuid' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.cbMems.SelectedItem = null;
			this.cbMems.ShowAspiration = false;
			this.cbMems.ShowBadge = false;
			this.cbMems.ShowInventory = false;
			this.cbMems.ShowJobData = false;
			this.cbMems.ShowMemories = true;
			this.cbMems.ShowSkill = false;
			this.cbMems.ShowTokens = false;
			this.cbMems.Size = new System.Drawing.Size(320, 21);
			this.cbMems.TabIndex = 9;
			this.cbMems.SelectedObjectChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// pnListing
			// 
			this.pnListing.Controls.Add(this.rbObjs);
			this.pnListing.Controls.Add(this.rbToks);
			this.pnListing.Controls.Add(this.rbMems);
			this.pnListing.Controls.Add(this.label10);
			this.pnListing.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnListing.Location = new System.Drawing.Point(0, 32);
			this.pnListing.Name = "pnListing";
			this.pnListing.Size = new System.Drawing.Size(460, 24);
			this.pnListing.TabIndex = 23;
			// 
			// rbObjs
			// 
			this.rbObjs.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbObjs.Location = new System.Drawing.Point(216, 4);
			this.rbObjs.Name = "rbObjs";
			this.rbObjs.Size = new System.Drawing.Size(64, 24);
			this.rbObjs.TabIndex = 18;
			this.rbObjs.Text = "Objects";
			this.rbObjs.CheckedChanged += new System.EventHandler(this.rbObjs_CheckedChanged);
			// 
			// rbToks
			// 
			this.rbToks.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbToks.Location = new System.Drawing.Point(144, 4);
			this.rbToks.Name = "rbToks";
			this.rbToks.Size = new System.Drawing.Size(64, 24);
			this.rbToks.TabIndex = 17;
			this.rbToks.Text = "Tokens";
			this.rbToks.CheckedChanged += new System.EventHandler(this.rbToks_CheckedChanged);
			// 
			// rbMems
			// 
			this.rbMems.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbMems.Location = new System.Drawing.Point(64, 4);
			this.rbMems.Name = "rbMems";
			this.rbMems.Size = new System.Drawing.Size(72, 24);
			this.rbMems.TabIndex = 16;
			this.rbMems.Text = "Memories";
			this.rbMems.CheckedChanged += new System.EventHandler(this.rbMems_CheckedChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(0, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Listing:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pnFlags
			// 
			this.pnFlags.Controls.Add(this.cbVis);
			this.pnFlags.Controls.Add(this.cbCtrl);
			this.pnFlags.Controls.Add(this.tbFlag);
			this.pnFlags.Controls.Add(this.label9);
			this.pnFlags.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnFlags.Location = new System.Drawing.Point(0, 0);
			this.pnFlags.Name = "pnFlags";
			this.pnFlags.Size = new System.Drawing.Size(460, 32);
			this.pnFlags.TabIndex = 22;
			// 
			// cbVis
			// 
			this.cbVis.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbVis.Location = new System.Drawing.Point(216, 8);
			this.cbVis.Name = "cbVis";
			this.cbVis.Size = new System.Drawing.Size(64, 24);
			this.cbVis.TabIndex = 16;
			this.cbVis.Text = "Visible";
			this.cbVis.CheckedChanged += new System.EventHandler(this.cbVis_CheckedChanged);
			// 
			// cbCtrl
			// 
			this.cbCtrl.Enabled = false;
			this.cbCtrl.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbCtrl.Location = new System.Drawing.Point(144, 8);
			this.cbCtrl.Name = "cbCtrl";
			this.cbCtrl.Size = new System.Drawing.Size(72, 24);
			this.cbCtrl.TabIndex = 15;
			this.cbCtrl.Text = "Controler";
			this.cbCtrl.CheckedChanged += new System.EventHandler(this.cbAct_CheckedChanged);
			// 
			// tbFlag
			// 
			this.tbFlag.Location = new System.Drawing.Point(64, 8);
			this.tbFlag.Name = "tbFlag";
			this.tbFlag.ReadOnly = true;
			this.tbFlag.Size = new System.Drawing.Size(56, 21);
			this.tbFlag.TabIndex = 14;
			this.tbFlag.Text = "";
			this.tbFlag.TextChanged += new System.EventHandler(this.tbFlag_TextChanged);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(0, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "Flags:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage4.Controls.Add(this.pg);
			this.tabPage4.Controls.Add(this.panel1);
			this.tabPage4.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage4.Guid = new System.Guid("3b0d25ef-e354-4693-8339-f171a2b4f000");
			this.tabPage4.Location = new System.Drawing.Point(2, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(460, 304);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.TabText = "Raw Data";
			this.tabPage4.Text = "Raw Data";
			this.tabPage4.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.llSetRawLength);
			this.panel1.Controls.Add(this.tbRawLength);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 272);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(460, 32);
			this.panel1.TabIndex = 9;
			// 
			// llSetRawLength
			// 
			this.llSetRawLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llSetRawLength.Location = new System.Drawing.Point(168, 8);
			this.llSetRawLength.Name = "llSetRawLength";
			this.llSetRawLength.Size = new System.Drawing.Size(48, 23);
			this.llSetRawLength.TabIndex = 9;
			this.llSetRawLength.TabStop = true;
			this.llSetRawLength.Text = "Set";
			this.llSetRawLength.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.llSetRawLength.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetRawLength_LinkClicked);
			// 
			// tbRawLength
			// 
			this.tbRawLength.Location = new System.Drawing.Point(64, 8);
			this.tbRawLength.Name = "tbRawLength";
			this.tbRawLength.TabIndex = 8;
			this.tbRawLength.Text = "0";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Length:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// MemoryProperties
			// 
			this.Controls.Add(this.tabControl2);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "MemoryProperties";
			this.Size = new System.Drawing.Size(464, 328);
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
			SetContent();
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
