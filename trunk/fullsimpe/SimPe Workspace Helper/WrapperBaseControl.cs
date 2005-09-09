using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
	/// <summary>
	/// Zusammenfassung für WrapperBaseControl.
	/// </summary>
	[ToolboxBitmapAttribute(typeof(Panel))]
	public class WrapperBaseControl : System.Windows.Forms.UserControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public WrapperBaseControl()
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

			headcol = Color.FromArgb(120, 0, 0, 0);
			headforecol = Color.White;
			Font = new Font("tahoma", this.Font.Size, this.Font.Style, this.Font.Unit);
			headfont = new Font(this.Font.FontFamily, 9.75f, FontStyle.Bold, this.Font.Unit);
			
			gradcol = SystemColors.InactiveCaption;
			this.mGradient = LinearGradientMode.ForwardDiagonal;
			BackColor = SystemColors.InactiveCaptionText;	
		
			tm = ThemeManager.Global.CreateChild();
			tm.AddControl(this);

			txt = "";

			//this.D = new Rectangle(0, 24, Width, Height-24);
		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (tm!=null) tm.Clear();				
				tm = null;
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Public Properties
		string txt;
		[Localizable(true)]
		public string HeaderText
		{
			get
			{
				return txt;
			}
			set
			{
				if (txt!=value) 
				{
					txt = value;
					this.Refresh();
				}
			}
		}

		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				HeaderText = value;
			}
		}


		Color headcol, headforecol;
		Font headfont;

		public Color HeadBackColor
		{
			get { return headcol; }
			set 
			{
				if (value!=headcol)
				{
					headcol = value;
					Invalidate();
				}
			}
		}

		public Color HeadForeColor
		{
			get { return headforecol; }
			set 
			{
				if (value!=headforecol)
				{
					headforecol = value;
					this.Invalidate();
				}
			}
		}

		

		public Font HeadFont
		{
			get { return headfont; }
			set 
			{
				if (value!=headfont)
				{
					headfont = value;
					Invalidate();
				}
			}
		}

		public int HeaderHeight
		{
			get {return 24;}
		}

		private System.Windows.Forms.Button btCommit;
		LinearGradientMode mGradient;
		Color gradcol;		
	
		public Color GradientColor
		{
			get { return gradcol; }
			set 
			{
				if (value!=gradcol)
				{
					gradcol = value;
					this.Invalidate();
				}
			}
		}

		public LinearGradientMode Gradient
		{
			get
			{
				return this.mGradient;
			}
			set
			{
				this.mGradient = value;
			}
		}
		#endregion

		#region Properties
		SimPe.ThemeManager tm;
		

		[Browsable(false)]
		public SimPe.ThemeManager ThemeManager
		{
			get { return tm; }
		}

		SimPe.Interfaces.Plugin.IFileWrapper wrp;
		[Browsable(false)]
		public SimPe.Interfaces.Plugin.IFileWrapper  Wrapper
		{
			get { return wrp; }
		}
		#endregion

		#region Events
		public event System.EventHandler Commited;
		#endregion

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(WrapperBaseControl));
			this.btCommit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btCommit
			// 
			this.btCommit.AccessibleDescription = resources.GetString("btCommit.AccessibleDescription");
			this.btCommit.AccessibleName = resources.GetString("btCommit.AccessibleName");
			this.btCommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btCommit.Anchor")));
			this.btCommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCommit.BackgroundImage")));
			this.btCommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btCommit.Dock")));
			this.btCommit.Enabled = ((bool)(resources.GetObject("btCommit.Enabled")));
			this.btCommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btCommit.FlatStyle")));
			this.btCommit.Font = ((System.Drawing.Font)(resources.GetObject("btCommit.Font")));
			this.btCommit.Image = ((System.Drawing.Image)(resources.GetObject("btCommit.Image")));
			this.btCommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btCommit.ImageAlign")));
			this.btCommit.ImageIndex = ((int)(resources.GetObject("btCommit.ImageIndex")));
			this.btCommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btCommit.ImeMode")));
			this.btCommit.Location = ((System.Drawing.Point)(resources.GetObject("btCommit.Location")));
			this.btCommit.Name = "btCommit";
			this.btCommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btCommit.RightToLeft")));
			this.btCommit.Size = ((System.Drawing.Size)(resources.GetObject("btCommit.Size")));
			this.btCommit.TabIndex = ((int)(resources.GetObject("btCommit.TabIndex")));
			this.btCommit.Text = resources.GetString("btCommit.Text");
			this.btCommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btCommit.TextAlign")));
			this.btCommit.Visible = ((bool)(resources.GetObject("btCommit.Visible")));
			this.btCommit.Click += new System.EventHandler(this.btCommit_Click);
			// 
			// WrapperBaseControl
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.btCommit);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "WrapperBaseControl";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			base.OnPaintBackground (pevent);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint (e);

			if ((this.Width > 0) && (this.Height > 0))
			{
				Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
				LinearGradientBrush b = new LinearGradientBrush(rec, this.BackColor, this.GradientColor, this.Gradient);
				e.Graphics.FillRectangle(b, rec);
				b.Dispose();
				

				//Draw the HeadLine
				SolidBrush bg = new SolidBrush(this.HeadBackColor);
				SolidBrush fb = new SolidBrush(this.HeadForeColor);
				e.Graphics.FillRectangle(bg, 0, 0, Width, HeaderHeight);
				SizeF sz = e.Graphics.MeasureString(HeaderText, this.HeadFont);
				int dist = (int)((HeaderHeight-sz.Height) / 2);
				e.Graphics.DrawString(HeaderText, this.HeadFont, fb, dist, dist);
				bg.Dispose();
				fb.Dispose();
			}
		}

		private void btCommit_Click(object sender, System.EventArgs e)
		{
			if (Commited!=null) Commited(this, e);
		}

		#region IPackedFileUI Member
		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get { return this; }
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <remarks>attr.Tag is used to let TextChanged event handlers know the change is being
		/// made internally rather than by the users.</remarks>
		/// <param name="wrp">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrp)
		{
			this.wrp = wrp;
			RefreshGUI();
		}	
		#endregion

		/// <summary>
		/// Implement this Method in derrived classes
		/// </summary>
		protected virtual void RefreshGUI()
		{
		}

		protected override void OnResize(EventArgs e)
		{
			base.OnResize (e);
			this.btCommit.Left = this.Width - 4 - btCommit.Width;
		}

	}
}
