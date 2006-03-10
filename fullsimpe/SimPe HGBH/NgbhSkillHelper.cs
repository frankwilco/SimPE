using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhSkillHelper.
	/// </summary>
	[System.ComponentModel.DefaultEvent("AddedNewItem")]
	public class NgbhSkillHelper : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		SimPe.ThemeManager tm;
		public NgbhSkillHelper()
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
		
			try 
			{
				tm = SimPe.ThemeManager.Global.CreateChild();
				tm.AddControl(this.xpBadges);
				tm.AddControl(this.xpSkills);

				this.xpBadges.Visible = Helper.WindowsRegistry.EPInstalled>=3;
				SetContent();
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
				if (tm!=null) 
				{
					tm.Clear();
					tm.Parent = null;
					tm = null;
				}
				
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhSkillHelper));
			this.badges = new SimPe.Plugin.NgbhSkillHelperElement();
			this.xpBadges = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.xpSkills = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.skills = new SimPe.Plugin.NgbhSkillHelperElement();
			this.xpBadges.SuspendLayout();
			this.xpSkills.SuspendLayout();
			this.SuspendLayout();
			// 
			// badges
			// 
			this.badges.AccessibleDescription = resources.GetString("badges.AccessibleDescription");
			this.badges.AccessibleName = resources.GetString("badges.AccessibleName");
			this.badges.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("badges.Anchor")));
			this.badges.AutoScroll = ((bool)(resources.GetObject("badges.AutoScroll")));
			this.badges.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("badges.AutoScrollMargin")));
			this.badges.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("badges.AutoScrollMinSize")));
			this.badges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("badges.BackgroundImage")));
			this.badges.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("badges.Dock")));
			this.badges.Enabled = ((bool)(resources.GetObject("badges.Enabled")));
			this.badges.Font = ((System.Drawing.Font)(resources.GetObject("badges.Font")));
			this.badges.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("badges.ImeMode")));
			this.badges.Location = ((System.Drawing.Point)(resources.GetObject("badges.Location")));
			this.badges.Name = "badges";
			this.badges.NgbhResource = null;
			this.badges.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("badges.RightToLeft")));
			this.badges.ShowBadges = true;
			this.badges.ShowSkills = false;
			this.badges.ShowToddlerSkills = false;
			this.badges.Size = ((System.Drawing.Size)(resources.GetObject("badges.Size")));
			this.badges.Slot = null;
			this.badges.TabIndex = ((int)(resources.GetObject("badges.TabIndex")));
			this.badges.Visible = ((bool)(resources.GetObject("badges.Visible")));
			this.badges.AddedNewItem += new System.EventHandler(this.skills_AddedNewItem);
			this.badges.ChangedItem += new System.EventHandler(this.skills_ChangedItem);
			// 
			// xpBadges
			// 
			this.xpBadges.AccessibleDescription = resources.GetString("xpBadges.AccessibleDescription");
			this.xpBadges.AccessibleName = resources.GetString("xpBadges.AccessibleName");
			this.xpBadges.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpBadges.Anchor")));
			this.xpBadges.AutoScroll = ((bool)(resources.GetObject("xpBadges.AutoScroll")));
			this.xpBadges.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpBadges.AutoScrollMargin")));
			this.xpBadges.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpBadges.AutoScrollMinSize")));
			this.xpBadges.BackColor = System.Drawing.Color.Transparent;
			this.xpBadges.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpBadges.BackgroundImage")));
			this.xpBadges.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpBadges.BorderColor = System.Drawing.SystemColors.Window;
			this.xpBadges.Controls.Add(this.badges);
			this.xpBadges.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpBadges.Dock")));
			this.xpBadges.DockPadding.Bottom = 4;
			this.xpBadges.DockPadding.Left = 4;
			this.xpBadges.DockPadding.Right = 4;
			this.xpBadges.DockPadding.Top = 44;
			this.xpBadges.Enabled = ((bool)(resources.GetObject("xpBadges.Enabled")));
			this.xpBadges.Font = ((System.Drawing.Font)(resources.GetObject("xpBadges.Font")));
			this.xpBadges.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpBadges.HeaderText = resources.GetString("xpBadges.HeaderText");
			this.xpBadges.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpBadges.Icon = ((System.Drawing.Image)(resources.GetObject("xpBadges.Icon")));
			this.xpBadges.IconLocation = new System.Drawing.Point(4, 0);
			this.xpBadges.IconSize = new System.Drawing.Size(48, 48);
			this.xpBadges.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpBadges.ImeMode")));
			this.xpBadges.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpBadges.Location = ((System.Drawing.Point)(resources.GetObject("xpBadges.Location")));
			this.xpBadges.Name = "xpBadges";
			this.xpBadges.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpBadges.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpBadges.RightToLeft")));
			this.xpBadges.Size = ((System.Drawing.Size)(resources.GetObject("xpBadges.Size")));
			this.xpBadges.TabIndex = ((int)(resources.GetObject("xpBadges.TabIndex")));
			this.xpBadges.Text = resources.GetString("xpBadges.Text");
			this.xpBadges.Visible = ((bool)(resources.GetObject("xpBadges.Visible")));
			// 
			// xpSkills
			// 
			this.xpSkills.AccessibleDescription = resources.GetString("xpSkills.AccessibleDescription");
			this.xpSkills.AccessibleName = resources.GetString("xpSkills.AccessibleName");
			this.xpSkills.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpSkills.Anchor")));
			this.xpSkills.AutoScroll = ((bool)(resources.GetObject("xpSkills.AutoScroll")));
			this.xpSkills.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpSkills.AutoScrollMargin")));
			this.xpSkills.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpSkills.AutoScrollMinSize")));
			this.xpSkills.BackColor = System.Drawing.Color.Transparent;
			this.xpSkills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpSkills.BackgroundImage")));
			this.xpSkills.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpSkills.BorderColor = System.Drawing.SystemColors.Window;
			this.xpSkills.Controls.Add(this.skills);
			this.xpSkills.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpSkills.Dock")));
			this.xpSkills.DockPadding.Bottom = 4;
			this.xpSkills.DockPadding.Left = 4;
			this.xpSkills.DockPadding.Right = 4;
			this.xpSkills.DockPadding.Top = 44;
			this.xpSkills.Enabled = ((bool)(resources.GetObject("xpSkills.Enabled")));
			this.xpSkills.Font = ((System.Drawing.Font)(resources.GetObject("xpSkills.Font")));
			this.xpSkills.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpSkills.HeaderText = resources.GetString("xpSkills.HeaderText");
			this.xpSkills.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpSkills.Icon = ((System.Drawing.Image)(resources.GetObject("xpSkills.Icon")));
			this.xpSkills.IconLocation = new System.Drawing.Point(4, 0);
			this.xpSkills.IconSize = new System.Drawing.Size(48, 48);
			this.xpSkills.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpSkills.ImeMode")));
			this.xpSkills.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpSkills.Location = ((System.Drawing.Point)(resources.GetObject("xpSkills.Location")));
			this.xpSkills.Name = "xpSkills";
			this.xpSkills.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpSkills.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpSkills.RightToLeft")));
			this.xpSkills.Size = ((System.Drawing.Size)(resources.GetObject("xpSkills.Size")));
			this.xpSkills.TabIndex = ((int)(resources.GetObject("xpSkills.TabIndex")));
			this.xpSkills.Text = resources.GetString("xpSkills.Text");
			this.xpSkills.Visible = ((bool)(resources.GetObject("xpSkills.Visible")));
			// 
			// skills
			// 
			this.skills.AccessibleDescription = resources.GetString("skills.AccessibleDescription");
			this.skills.AccessibleName = resources.GetString("skills.AccessibleName");
			this.skills.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("skills.Anchor")));
			this.skills.AutoScroll = ((bool)(resources.GetObject("skills.AutoScroll")));
			this.skills.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("skills.AutoScrollMargin")));
			this.skills.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("skills.AutoScrollMinSize")));
			this.skills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("skills.BackgroundImage")));
			this.skills.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("skills.Dock")));
			this.skills.Enabled = ((bool)(resources.GetObject("skills.Enabled")));
			this.skills.Font = ((System.Drawing.Font)(resources.GetObject("skills.Font")));
			this.skills.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("skills.ImeMode")));
			this.skills.Location = ((System.Drawing.Point)(resources.GetObject("skills.Location")));
			this.skills.Name = "skills";
			this.skills.NgbhResource = null;
			this.skills.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("skills.RightToLeft")));
			this.skills.ShowBadges = false;
			this.skills.ShowSkills = true;
			this.skills.ShowToddlerSkills = true;
			this.skills.Size = ((System.Drawing.Size)(resources.GetObject("skills.Size")));
			this.skills.Slot = null;
			this.skills.TabIndex = ((int)(resources.GetObject("skills.TabIndex")));
			this.skills.Visible = ((bool)(resources.GetObject("skills.Visible")));
			this.skills.AddedNewItem += new System.EventHandler(this.skills_AddedNewItem);
			this.skills.ChangedItem += new System.EventHandler(this.skills_ChangedItem);
			// 
			// NgbhSkillHelper
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.xpSkills);
			this.Controls.Add(this.xpBadges);
			this.DockPadding.All = 8;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NgbhSkillHelper";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.xpBadges.ResumeLayout(false);
			this.xpSkills.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		NgbhSlot slot;
		[System.ComponentModel.Browsable(false)]
		public NgbhSlot Slot
		{
			get {return slot;}
			set 
			{
				slot = value;
				SetContent();				
			}
		}

		Ngbh ngbh;
		private SimPe.Plugin.NgbhSkillHelperElement badges;
		private SimPe.Plugin.NgbhSkillHelperElement skills;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpBadges;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpSkills;
				
		[System.ComponentModel.Browsable(false)]
		public Ngbh NgbhResource
		{
			get {return ngbh;}
			set 
			{
				ngbh = value;
				pc_SelectedSimChanged(pc, null, null);
				SetContent();				
			}
		}

		SimPe.PackedFiles.Wrapper.SimPoolControl pc;
		public SimPe.PackedFiles.Wrapper.SimPoolControl SimPoolControl
		{
			get {return pc;}
			set 
			{
				if (pc!=null) pc.SelectedSimChanged -= new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(pc_SelectedSimChanged);
				pc = value;
				
				if (pc!=null) 
				{
					pc.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(pc_SelectedSimChanged);
					pc_SelectedSimChanged(pc, null, null);
				}
			}
		}

		void SetContent()
		{
			badges.Slot = slot;
			skills.Slot = slot;

			if (pc!=null) 
			{
				if (pc.SelectedSim!=null) SetImage(pc.SelectedSim.Image);
				else SetImage(new Bitmap(1,1));
			}
		}

		void SetImage(Image img)
		{
			img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new Point(0), Color.Transparent, true);
			img = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, 48, 48, true);

			this.xpBadges.Icon = img;
			this.xpSkills.Icon = img;			
		}

		private void pc_SelectedSimChanged(object sender, Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			
			if (ngbh!=null && pc!=null) 
			{
				
				if (pc.SelectedSim!=null) {
					this.Slot = ngbh.GetSlots(Data.NeighborhoodSlots.SimsIntern).GetInstanceSlot(pc.SelectedSim.FileDescriptor.Instance);	
					SetImage(pc.SelectedSim.Image);
				}
				else 
				{
					this.Slot = null;
					
				}
			}
		}
		

		private void skills_AddedNewItem(object sender, System.EventArgs e)
		{
			if (AddedNewItem!=null) AddedNewItem(this, e);
		}	

		private void skills_ChangedItem(object sender, System.EventArgs e)
		{
			if (ChangedItem!=null) ChangedItem(this, e);
		}
	
		public event EventHandler AddedNewItem;
		public event EventHandler ChangedItem;
	}
}
