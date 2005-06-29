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

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für WaitingForm.
	/// </summary>
	internal class WaitingForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		internal System.Windows.Forms.PictureBox pb;
		internal System.Windows.Forms.Timer timer1;
		internal System.Windows.Forms.Label lbwait;
		private System.Windows.Forms.Label lbmsg;
		internal System.Windows.Forms.PictureBox pbsimpe;
		private System.ComponentModel.IContainer components;

		public WaitingForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			defimg = true;
			cycles = 20;
			alpha = 0xff;
			//timer1.Enabled = true;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(WaitingForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbmsg = new System.Windows.Forms.Label();
			this.lbwait = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.PictureBox();
			this.pbsimpe = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
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
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.lbmsg);
			this.panel1.Controls.Add(this.lbwait);
			this.panel1.Controls.Add(this.pb);
			this.panel1.Controls.Add(this.pbsimpe);
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
			// lbmsg
			// 
			this.lbmsg.AccessibleDescription = resources.GetString("lbmsg.AccessibleDescription");
			this.lbmsg.AccessibleName = resources.GetString("lbmsg.AccessibleName");
			this.lbmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbmsg.Anchor")));
			this.lbmsg.AutoSize = ((bool)(resources.GetObject("lbmsg.AutoSize")));
			this.lbmsg.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbmsg.Dock")));
			this.lbmsg.Enabled = ((bool)(resources.GetObject("lbmsg.Enabled")));
			this.lbmsg.Font = ((System.Drawing.Font)(resources.GetObject("lbmsg.Font")));
			this.lbmsg.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(204)), ((System.Byte)(211)), ((System.Byte)(213)));
			this.lbmsg.Image = ((System.Drawing.Image)(resources.GetObject("lbmsg.Image")));
			this.lbmsg.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbmsg.ImageAlign")));
			this.lbmsg.ImageIndex = ((int)(resources.GetObject("lbmsg.ImageIndex")));
			this.lbmsg.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbmsg.ImeMode")));
			this.lbmsg.Location = ((System.Drawing.Point)(resources.GetObject("lbmsg.Location")));
			this.lbmsg.Name = "lbmsg";
			this.lbmsg.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbmsg.RightToLeft")));
			this.lbmsg.Size = ((System.Drawing.Size)(resources.GetObject("lbmsg.Size")));
			this.lbmsg.TabIndex = ((int)(resources.GetObject("lbmsg.TabIndex")));
			this.lbmsg.Text = resources.GetString("lbmsg.Text");
			this.lbmsg.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbmsg.TextAlign")));
			this.lbmsg.Visible = ((bool)(resources.GetObject("lbmsg.Visible")));
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
			this.lbwait.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
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
			// pbsimpe
			// 
			this.pbsimpe.AccessibleDescription = resources.GetString("pbsimpe.AccessibleDescription");
			this.pbsimpe.AccessibleName = resources.GetString("pbsimpe.AccessibleName");
			this.pbsimpe.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbsimpe.Anchor")));
			this.pbsimpe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbsimpe.BackgroundImage")));
			this.pbsimpe.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbsimpe.Dock")));
			this.pbsimpe.Enabled = ((bool)(resources.GetObject("pbsimpe.Enabled")));
			this.pbsimpe.Font = ((System.Drawing.Font)(resources.GetObject("pbsimpe.Font")));
			this.pbsimpe.Image = ((System.Drawing.Image)(resources.GetObject("pbsimpe.Image")));
			this.pbsimpe.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbsimpe.ImeMode")));
			this.pbsimpe.Location = ((System.Drawing.Point)(resources.GetObject("pbsimpe.Location")));
			this.pbsimpe.Name = "pbsimpe";
			this.pbsimpe.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbsimpe.RightToLeft")));
			this.pbsimpe.Size = ((System.Drawing.Size)(resources.GetObject("pbsimpe.Size")));
			this.pbsimpe.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbsimpe.SizeMode")));
			this.pbsimpe.TabIndex = ((int)(resources.GetObject("pbsimpe.TabIndex")));
			this.pbsimpe.TabStop = false;
			this.pbsimpe.Text = resources.GetString("pbsimpe.Text");
			this.pbsimpe.Visible = ((bool)(resources.GetObject("pbsimpe.Visible")));
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// WaitingForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(102)), ((System.Byte)(153)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.CausesValidation = false;
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "WaitingForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.ShowInTaskbar = false;
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal void ChangeImage(Image img) 
		{
			defimg = false;
			cycles = 0;

			//lbwait.ForeColor = Color.AliceBlue;
			//PicAlpha(0xff);
			try 
			{
				pb.Image = img;
			} 
			catch {}
		}

		internal void ChangeMessage(string msg)
		{
			cycles = 0;
			lbmsg.Text = msg;
		}

		void PicAlpha(int a)
		{
			alpha = a;
			if (alpha<0) alpha = 0;
			if (alpha>0xff) alpha = 0xff;
			if (alpha==0) pb.Tag = true;
			else if (alpha==0xff) pb.Tag = null;

			lbwait.ForeColor = Color.FromArgb(alpha, lbwait.ForeColor);
		}
	
		internal bool defimg;
		internal long cycles;
		internal int alpha;
		internal void timer1_Tick(object sender, System.EventArgs e)
		{
			cycles++;

			//if(cycles>20) 
			{
				if (pb.Tag!=null) PicAlpha(alpha+10);
				else PicAlpha(alpha-10);
				//System.Windows.Forms.Application.DoEvents();
			}			
		}
 
		
	}
}
