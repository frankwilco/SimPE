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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// Zusammenfassung für LabledProgressBar.
	/// </summary>
	[ToolboxBitmapAttribute(typeof(ProgressBar)), DefaultEvent("ChangedValue")]
	public class LabeledProgressBar : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel pntb;
		private System.Windows.Forms.Panel pnlb;
		private System.Windows.Forms.Panel pn;
		private System.Windows.Forms.Label lb;
		private Ambertation.Windows.Forms.SubExtProgressBar pb;
		private System.Windows.Forms.TextBox tb;
		
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LabeledProgressBar()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint 
				| ControlStyles.DoubleBuffer
				,true);

			
			BackColor = Color.Transparent;
			ns = 1f;
			
			internalupdate =false;
			nf = "N0";
			nsu = "";
			npre = "";
			no = 0;
			dno = 0;

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			pb.TokenWidth = 8;
			pb.Maximum = 100;
			pb.Value = 0;
			pb.TabStop = false;
			Update();
		}

		#region Public Properties
		
		public ProgresBarStyle Style
		{
			get {return pb.Style; }
			set
			{
				pb.Style = value;
			}
		}

		public Color SelectedColor
		{
			get {return pb.SelectedColor; }
			set
			{
				pb.SelectedColor = value;
			}
		}

		public Color UnselectedColor
		{
			get {return pb.UnselectedColor; }
			set
			{
				pb.UnselectedColor = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int TokenWidth
		{
			get {return pb.TokenWidth; }
			set
			{
				pb.TokenWidth = value;
			}
		}

		public int TokenCount
		{
			get {return pb.TokenCount; }
			set
			{
				pb.TokenCount = value;
			}
		}

		[Localizable(true)]
		public int TextboxWidth
		{
			get { return pntb.Width; }
			set { pntb.Width = value; }
		}		

		[Localizable(true)]
		public string LabelText
		{
			get { return lb.Text; }
			set { lb.Text = value; }
		}

		[Localizable(true)]
		public int LabelWidth
		{
			get { return pnlb.Width; }
			set { pnlb.Width = value; }
		}

		public int Maximum
		{
			get { return pb.Maximum; }
			set 
			{
				pb.Maximum = Math.Max(1, value);
				Update();
			}
		}

		public int Value
		{
			get { return pb.Value+this.NumberOffset; }
			set 
			{
				pb.Value = value-this.NumberOffset;
				Update();
			}
		}

		double ns;
		public double NumberScale
		{
			get { return ns; }
			set 
			{
				ns = value;
				if (ns==0) ns = 1;
				Update();
			}
		}

		string nf;
		public string NumberFormat
		{
			get { return nf; }
			set 
			{
				nf = value;
				Update();
			}
		}

		string npre;
		string NumberPrefix
		{
			get { return npre; }
			set 
			{
				npre = value;
				Update();
			}
		}

		string nsu;
		string NumberSuffix
		{
			get { return nsu; }
			set 
			{
				nsu = value;
				Update();
			}
		}

		int no;
		public int NumberOffset
		{
			get { return no; }
			set 
			{
				no = value;
				Update();
			}
		}

		int dno;
		public int DisplayOffset
		{
			get { return dno; }
			set 
			{
				dno = value;
				Update();
			}
		}
		#endregion

		#region Events
		public event System.EventHandler Changed;
		public event EventHandler ChangedValue;

		protected void FireChangedEvent(bool both)
		{
			if (Changed!=null && both) Changed(this, new EventArgs());
			if (ChangedValue!=null) ChangedValue(this, new EventArgs());
		}
		#endregion

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

		#region von Designer
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.pn = new System.Windows.Forms.Panel();
			this.pb = new Ambertation.Windows.Forms.SubExtProgressBar();
			this.lb = new System.Windows.Forms.Label();
			this.pntb = new System.Windows.Forms.Panel();
			this.tb = new System.Windows.Forms.TextBox();
			this.pnlb = new System.Windows.Forms.Panel();
			this.pn.SuspendLayout();
			this.pntb.SuspendLayout();
			this.pnlb.SuspendLayout();
			this.SuspendLayout();
			// 
			// pn
			// 
			this.pn.Controls.Add(this.pb);
			this.pn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pn.DockPadding.Left = 8;
			this.pn.DockPadding.Right = 4;
			this.pn.Location = new System.Drawing.Point(80, 0);
			this.pn.Name = "pn";
			this.pn.Size = new System.Drawing.Size(280, 15);
			this.pn.TabIndex = 0;
			// 
			// pb
			// 
			this.pb.BackColor = System.Drawing.Color.Transparent;
			this.pb.BorderColor = System.Drawing.Color.FromArgb(((System.Byte)(100)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pb.Gradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.pb.GradientEndColor = System.Drawing.Color.White;
			this.pb.GradientStartColor = System.Drawing.Color.White;
			this.pb.Location = new System.Drawing.Point(8, 0);
			this.pb.Maximum = 100;
			this.pb.Minimum = 0;
			this.pb.Name = "pb";
			this.pb.ProgressBackColor = System.Drawing.SystemColors.Window;
			this.pb.Quality = true;
			this.pb.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pb.Size = new System.Drawing.Size(268, 15);
			this.pb.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pb.TabIndex = 0;
			this.pb.UnselectedColor = System.Drawing.Color.Black;
			this.pb.Value = 0;
			this.pb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_MouseUp);
			this.pb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb_MouseMove);
			this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDown);
			// 
			// lb
			// 
			this.lb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb.Location = new System.Drawing.Point(0, -8);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(80, 23);
			this.lb.TabIndex = 0;
			this.lb.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// pntb
			// 
			this.pntb.Controls.Add(this.tb);
			this.pntb.Dock = System.Windows.Forms.DockStyle.Right;
			this.pntb.Location = new System.Drawing.Point(360, 0);
			this.pntb.Name = "pntb";
			this.pntb.Size = new System.Drawing.Size(40, 15);
			this.pntb.TabIndex = 1;
			// 
			// tb
			// 
			this.tb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tb.Location = new System.Drawing.Point(0, 1);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(40, 14);
			this.tb.TabIndex = 0;
			this.tb.Text = "";
			this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// pnlb
			// 
			this.pnlb.Controls.Add(this.lb);
			this.pnlb.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnlb.Location = new System.Drawing.Point(0, 0);
			this.pnlb.Name = "pnlb";
			this.pnlb.Size = new System.Drawing.Size(80, 15);
			this.pnlb.TabIndex = 2;
			// 
			// LabeledProgressBar
			// 
			this.Controls.Add(this.pn);
			this.Controls.Add(this.pnlb);
			this.Controls.Add(this.pntb);
			this.DockPadding.Bottom = 5;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LabeledProgressBar";
			this.Size = new System.Drawing.Size(400, 20);
			this.pn.ResumeLayout(false);
			this.pntb.ResumeLayout(false);
			this.pnlb.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		bool internalupdate;
		public new void Update()
		{			
			if (internalupdate) return;
			internalupdate = true;
			try 
			{
				double disp = ((float)Value) * ns + dno;
				tb.Text = npre + disp.ToString(nf) + nsu;
			}
			catch {}
			finally 
			{
				internalupdate = false;
			}

		}
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            pb.Visible = this.Visible;            
        }
		

		private void tb_TextChanged(object sender, System.EventArgs e)
		{
			
			if (internalupdate) 
			{
				FireChangedEvent(true);
				return;
			}
			internalupdate = true;
			try 
			{
				int val = (int)((((Convert.ToDouble(tb.Text)-dno) / ns)) );
				Value = Math.Max(pb.Minimum, Math.Min(pb.Maximum, val));				
			}
			catch {}
			finally 
			{
				FireChangedEvent(true);
				internalupdate = false;
			}	
		
			
		}

		private void ProgressBarUpdate(System.Windows.Forms.MouseEventArgs e) 
		{
			if (e!=null) 
			{
				int nval = Math.Max(pb.Minimum, Math.Min(pb.Maximum, Convert.ToInt32(Math.Round(((double)e.X / (double)pb.SensitiveWidth) * pb.Maximum))));			
				bool update = nval != pb.Value;
				pb.Value = nval;
				if (update) FireChangedEvent(false);
				Update();
			}
		}
	
		private void pb_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Left) ProgressBarUpdate(e);		
		}

		private void pb_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			if (e.Button==MouseButtons.Left) ProgressBarUpdate(e);							
		}

		private void pb_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Left) ProgressBarUpdate(e);		
		}

		protected override void OnResize(EventArgs e)
		{		
			base.OnResize(e);
			/*tb.Left = this.Width-tb.Width;
			tb.Top = pb.Bottom-tb.Height+1;
			lb.Top = pb.Bottom-lb.Height+1;
			pb.SetBounds(
				lb.Right+8,
				pb.Top,
				tb.Left - pb.Left - 8,
				pb.Height
				);*/
		}

		public void CompleteRedraw() 
		{
			pb.CompleteRedraw();
			pb.Refresh();
		}


		private void lb_SizeChanged(object sender, System.EventArgs e)
		{			
			
			//OnResize(e);
		}
	}
}
