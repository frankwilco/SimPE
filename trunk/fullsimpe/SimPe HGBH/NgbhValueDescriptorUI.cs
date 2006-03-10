using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhValueDescriptorUI.
	/// </summary>
	[System.ComponentModel.DefaultEvent("AddedNewItem")]
	public class NgbhValueDescriptorUI : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NgbhValueDescriptorUI()
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

			SetContent();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhValueDescriptorUI));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pb = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cb = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lb = new System.Windows.Forms.Label();
			this.ll = new System.Windows.Forms.LinkLabel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
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
			this.panel1.Controls.Add(this.pb);
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
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.AutoScroll = ((bool)(resources.GetObject("pb.AutoScroll")));
			this.pb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pb.AutoScrollMargin")));
			this.pb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pb.AutoScrollMinSize")));
			this.pb.BackColor = System.Drawing.Color.Transparent;
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.DisplayOffset = 0;
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.DockPadding.Bottom = 5;
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.LabelText = resources.GetString("pb.LabelText");
			this.pb.LabelWidth = ((int)(resources.GetObject("pb.LabelWidth")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Maximum = 100;
			this.pb.Name = "pb";
			this.pb.NumberFormat = "N0";
			this.pb.NumberOffset = 0;
			this.pb.NumberScale = 1;
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TextboxWidth = ((int)(resources.GetObject("pb.TextboxWidth")));
			this.pb.TokenCount = 10;
			this.pb.UnselectedColor = System.Drawing.Color.Black;
			this.pb.Value = 0;
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			this.pb.Changed += new System.EventHandler(this.pb_Changed);
			this.pb.Resize += new System.EventHandler(this.pb_Resize);
			this.pb.Load += new System.EventHandler(this.pb_Load);
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
			this.panel2.Controls.Add(this.cb);
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
			// cb
			// 
			this.cb.AccessibleDescription = resources.GetString("cb.AccessibleDescription");
			this.cb.AccessibleName = resources.GetString("cb.AccessibleName");
			this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cb.Anchor")));
			this.cb.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cb.Appearance")));
			this.cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cb.BackgroundImage")));
			this.cb.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cb.CheckAlign")));
			this.cb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cb.Dock")));
			this.cb.Enabled = ((bool)(resources.GetObject("cb.Enabled")));
			this.cb.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cb.FlatStyle")));
			this.cb.Font = ((System.Drawing.Font)(resources.GetObject("cb.Font")));
			this.cb.Image = ((System.Drawing.Image)(resources.GetObject("cb.Image")));
			this.cb.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cb.ImageAlign")));
			this.cb.ImageIndex = ((int)(resources.GetObject("cb.ImageIndex")));
			this.cb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cb.ImeMode")));
			this.cb.Location = ((System.Drawing.Point)(resources.GetObject("cb.Location")));
			this.cb.Name = "cb";
			this.cb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cb.RightToLeft")));
			this.cb.Size = ((System.Drawing.Size)(resources.GetObject("cb.Size")));
			this.cb.TabIndex = ((int)(resources.GetObject("cb.TabIndex")));
			this.cb.Text = resources.GetString("cb.Text");
			this.cb.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cb.TextAlign")));
			this.cb.Visible = ((bool)(resources.GetObject("cb.Visible")));
			this.cb.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.lb);
			this.panel3.Controls.Add(this.ll);
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			// 
			// lb
			// 
			this.lb.AccessibleDescription = resources.GetString("lb.AccessibleDescription");
			this.lb.AccessibleName = resources.GetString("lb.AccessibleName");
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lb.Anchor")));
			this.lb.AutoSize = ((bool)(resources.GetObject("lb.AutoSize")));
			this.lb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lb.Dock")));
			this.lb.Enabled = ((bool)(resources.GetObject("lb.Enabled")));
			this.lb.Font = ((System.Drawing.Font)(resources.GetObject("lb.Font")));
			this.lb.Image = ((System.Drawing.Image)(resources.GetObject("lb.Image")));
			this.lb.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lb.ImageAlign")));
			this.lb.ImageIndex = ((int)(resources.GetObject("lb.ImageIndex")));
			this.lb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lb.ImeMode")));
			this.lb.Location = ((System.Drawing.Point)(resources.GetObject("lb.Location")));
			this.lb.Name = "lb";
			this.lb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lb.RightToLeft")));
			this.lb.Size = ((System.Drawing.Size)(resources.GetObject("lb.Size")));
			this.lb.TabIndex = ((int)(resources.GetObject("lb.TabIndex")));
			this.lb.Text = resources.GetString("lb.Text");
			this.lb.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lb.TextAlign")));
			this.lb.Visible = ((bool)(resources.GetObject("lb.Visible")));
			// 
			// ll
			// 
			this.ll.AccessibleDescription = resources.GetString("ll.AccessibleDescription");
			this.ll.AccessibleName = resources.GetString("ll.AccessibleName");
			this.ll.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ll.Anchor")));
			this.ll.AutoSize = ((bool)(resources.GetObject("ll.AutoSize")));
			this.ll.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ll.Dock")));
			this.ll.Enabled = ((bool)(resources.GetObject("ll.Enabled")));
			this.ll.Font = ((System.Drawing.Font)(resources.GetObject("ll.Font")));
			this.ll.Image = ((System.Drawing.Image)(resources.GetObject("ll.Image")));
			this.ll.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("ll.ImageAlign")));
			this.ll.ImageIndex = ((int)(resources.GetObject("ll.ImageIndex")));
			this.ll.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ll.ImeMode")));
			this.ll.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("ll.LinkArea")));
			this.ll.Location = ((System.Drawing.Point)(resources.GetObject("ll.Location")));
			this.ll.Name = "ll";
			this.ll.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ll.RightToLeft")));
			this.ll.Size = ((System.Drawing.Size)(resources.GetObject("ll.Size")));
			this.ll.TabIndex = ((int)(resources.GetObject("ll.TabIndex")));
			this.ll.TabStop = true;
			this.ll.Text = resources.GetString("ll.Text");
			this.ll.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("ll.TextAlign")));
			this.ll.Visible = ((bool)(resources.GetObject("ll.Visible")));
			this.ll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_LinkClicked);
			// 
			// NgbhValueDescriptorUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NgbhValueDescriptorUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
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

		NgbhValueDescriptor des;
		private System.Windows.Forms.Panel panel1;
		private Ambertation.Windows.Forms.LabeledProgressBar pb;
		private System.Windows.Forms.Panel panel2;
		private Ambertation.Windows.Forms.TransparentCheckBox cb;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.LinkLabel ll;
		private System.Windows.Forms.Label lb;
		
				
		[System.ComponentModel.Browsable(false)]
		public NgbhValueDescriptor NgbhValueDescriptor
		{
			get {return des;}
			set 
			{
				des = value;
				SetContent();				
			}
		}

		NgbhValueDescriptorSelection vds;
		public NgbhValueDescriptorSelection NgbhValueDescriptorSelection
		{
			get {return vds;}
			set 
			{
				if (vds!=null) vds.SelectedDescriptorChanged -= new EventHandler(vds_SelectedDescriptorChanged);
				vds = value;
				if (vds!=null) vds.SelectedDescriptorChanged += new EventHandler(vds_SelectedDescriptorChanged);
			}
		}

		void SetVisible()
		{
			panel1.Visible = item!=null;
			if (des!=null)
				panel2.Visible = des.HasComplededFlag && item!=null;
			else
				panel2.Visible = false;
			
			panel3.Visible = des!=null && item==null;
		}

		NgbhItem item;
		bool inter;
		void SetContent()
		{		
			if (inter) return;
			inter = true;
			if (des!=null && slot!=null)
			{
				item = slot.FindItem(des.Guid);
				pb.NumberOffset = des.Minimum;
				pb.Maximum = des.Maximum;				
				
				if (item!=null) 			
				{	
					pb.Value = item.GetValue(des.DataNumber);
					if (des.HasComplededFlag)
						cb.Checked = item.GetValue(des.CompletedDataNumber)!=0;
				}
				else
					lb.Text = des.ToString();

				
				
								
				this.Enabled = true;
			} 	
			else 
			{
				this.Enabled = false;
			}
			

			SetVisible();
			inter = false;
		}

		private void vds_SelectedDescriptorChanged(object sender, EventArgs e)
		{
			this.NgbhValueDescriptor = vds.SelectedDescriptor;
		}

		private void pb_Resize(object sender, System.EventArgs e)
		{
			
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);
			pb.TokenCount = 10;			
		}

		public event EventHandler AddedNewItem;
		public event EventHandler ChangedItem;

		private void ll_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (item!=null) return;
			if (slot==null) return;
			if (des==null) return;
			
			if (des.Intern) item = slot.ItemsA.AddNew(SimMemoryType.Skill);
			else item = slot.ItemsB.AddNew(SimMemoryType.Skill);

			item.Guid = des.Guid;
			item.PutValue(des.DataNumber, 0);
			if (des.HasComplededFlag) item.PutValue(des.CompletedDataNumber, 0);
								
			SetContent();

			if (AddedNewItem!=null) AddedNewItem(this, new EventArgs());
		}

		private void cb_CheckedChanged(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;
			if (des==null) return;
			if (!des.HasComplededFlag) return;

			if (cb.Checked) item.PutValue(des.CompletedDataNumber, 1);
			else item.PutValue(des.CompletedDataNumber, 0);

			if (ChangedItem!=null) ChangedItem(this, new EventArgs());
		}

		private void pb_Changed(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;
			if (des==null) return;			

			item.PutValue(des.DataNumber, (ushort)pb.Value);
			
			if (ChangedItem!=null) ChangedItem(this, new EventArgs());
		}

		private void pb_Load(object sender, System.EventArgs e)
		{
		
		}

	}
}
