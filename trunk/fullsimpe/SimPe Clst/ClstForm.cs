/***************************************************************************
 *   Copyright (C) 2005 by Peter L Jones                                   *
 *   peter@drealm.info                                                     *
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
using SimPe.Interfaces.Plugin;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Summary description for BconForm.
	/// </summary>
	public class ClstForm : System.Windows.Forms.Form, IPackedFileUI
	{
		#region Form elements
		private System.Windows.Forms.Label lbformat;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox lbclst;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Panel clstPanel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public ClstForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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


		#region CompressedFileList
		private CompressedFileList wrapper;
		#endregion

		#region IPackedFileUI Member
		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get
			{
				return clstPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <remarks>attr.Tag is used to let TextChanged event handlers know the change is being
		/// made internally rather than by the users.</remarks>
		/// <param name="wrp">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrp)
		{
			wrapper = (CompressedFileList)wrp;

			lbformat.Text = wrapper.IndexType.ToString();

			lbclst.Items.Clear();
			foreach (ClstItem i in wrapper.Items)
				if (i!=null) 
					lbclst.Items.Add(i);
				else 
					lbclst.Items.Add("Error");
		}		
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ClstForm));
			this.clstPanel = new System.Windows.Forms.Panel();
			this.lbformat = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lbclst = new System.Windows.Forms.ListBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.clstPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// clstPanel
			// 
			this.clstPanel.AccessibleDescription = resources.GetString("clstPanel.AccessibleDescription");
			this.clstPanel.AccessibleName = resources.GetString("clstPanel.AccessibleName");
			this.clstPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("clstPanel.Anchor")));
			this.clstPanel.AutoScroll = ((bool)(resources.GetObject("clstPanel.AutoScroll")));
			this.clstPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("clstPanel.AutoScrollMargin")));
			this.clstPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("clstPanel.AutoScrollMinSize")));
			this.clstPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clstPanel.BackgroundImage")));
			this.clstPanel.Controls.Add(this.lbformat);
			this.clstPanel.Controls.Add(this.label9);
			this.clstPanel.Controls.Add(this.lbclst);
			this.clstPanel.Controls.Add(this.panel4);
			this.clstPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("clstPanel.Dock")));
			this.clstPanel.Enabled = ((bool)(resources.GetObject("clstPanel.Enabled")));
			this.clstPanel.Font = ((System.Drawing.Font)(resources.GetObject("clstPanel.Font")));
			this.clstPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("clstPanel.ImeMode")));
			this.clstPanel.Location = ((System.Drawing.Point)(resources.GetObject("clstPanel.Location")));
			this.clstPanel.Name = "clstPanel";
			this.clstPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("clstPanel.RightToLeft")));
			this.clstPanel.Size = ((System.Drawing.Size)(resources.GetObject("clstPanel.Size")));
			this.clstPanel.TabIndex = ((int)(resources.GetObject("clstPanel.TabIndex")));
			this.clstPanel.Text = resources.GetString("clstPanel.Text");
			this.clstPanel.Visible = ((bool)(resources.GetObject("clstPanel.Visible")));
			// 
			// lbformat
			// 
			this.lbformat.AccessibleDescription = resources.GetString("lbformat.AccessibleDescription");
			this.lbformat.AccessibleName = resources.GetString("lbformat.AccessibleName");
			this.lbformat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbformat.Anchor")));
			this.lbformat.AutoSize = ((bool)(resources.GetObject("lbformat.AutoSize")));
			this.lbformat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbformat.Dock")));
			this.lbformat.Enabled = ((bool)(resources.GetObject("lbformat.Enabled")));
			this.lbformat.Font = ((System.Drawing.Font)(resources.GetObject("lbformat.Font")));
			this.lbformat.Image = ((System.Drawing.Image)(resources.GetObject("lbformat.Image")));
			this.lbformat.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbformat.ImageAlign")));
			this.lbformat.ImageIndex = ((int)(resources.GetObject("lbformat.ImageIndex")));
			this.lbformat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbformat.ImeMode")));
			this.lbformat.Location = ((System.Drawing.Point)(resources.GetObject("lbformat.Location")));
			this.lbformat.Name = "lbformat";
			this.lbformat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbformat.RightToLeft")));
			this.lbformat.Size = ((System.Drawing.Size)(resources.GetObject("lbformat.Size")));
			this.lbformat.TabIndex = ((int)(resources.GetObject("lbformat.TabIndex")));
			this.lbformat.Text = resources.GetString("lbformat.Text");
			this.lbformat.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbformat.TextAlign")));
			this.lbformat.Visible = ((bool)(resources.GetObject("lbformat.Visible")));
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
			// lbclst
			// 
			this.lbclst.AccessibleDescription = resources.GetString("lbclst.AccessibleDescription");
			this.lbclst.AccessibleName = resources.GetString("lbclst.AccessibleName");
			this.lbclst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbclst.Anchor")));
			this.lbclst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbclst.BackgroundImage")));
			this.lbclst.ColumnWidth = ((int)(resources.GetObject("lbclst.ColumnWidth")));
			this.lbclst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbclst.Dock")));
			this.lbclst.Enabled = ((bool)(resources.GetObject("lbclst.Enabled")));
			this.lbclst.Font = ((System.Drawing.Font)(resources.GetObject("lbclst.Font")));
			this.lbclst.HorizontalExtent = ((int)(resources.GetObject("lbclst.HorizontalExtent")));
			this.lbclst.HorizontalScrollbar = ((bool)(resources.GetObject("lbclst.HorizontalScrollbar")));
			this.lbclst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbclst.ImeMode")));
			this.lbclst.IntegralHeight = ((bool)(resources.GetObject("lbclst.IntegralHeight")));
			this.lbclst.ItemHeight = ((int)(resources.GetObject("lbclst.ItemHeight")));
			this.lbclst.Location = ((System.Drawing.Point)(resources.GetObject("lbclst.Location")));
			this.lbclst.Name = "lbclst";
			this.lbclst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbclst.RightToLeft")));
			this.lbclst.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbclst.ScrollAlwaysVisible")));
			this.lbclst.Size = ((System.Drawing.Size)(resources.GetObject("lbclst.Size")));
			this.lbclst.Sorted = true;
			this.lbclst.TabIndex = ((int)(resources.GetObject("lbclst.TabIndex")));
			this.lbclst.Visible = ((bool)(resources.GetObject("lbclst.Visible")));
			// 
			// panel4
			// 
			this.panel4.AccessibleDescription = resources.GetString("panel4.AccessibleDescription");
			this.panel4.AccessibleName = resources.GetString("panel4.AccessibleName");
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel4.Anchor")));
			this.panel4.AutoScroll = ((bool)(resources.GetObject("panel4.AutoScroll")));
			this.panel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMargin")));
			this.panel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMinSize")));
			this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Controls.Add(this.label12);
			this.panel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel4.Dock")));
			this.panel4.Enabled = ((bool)(resources.GetObject("panel4.Enabled")));
			this.panel4.Font = ((System.Drawing.Font)(resources.GetObject("panel4.Font")));
			this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel4.ImeMode")));
			this.panel4.Location = ((System.Drawing.Point)(resources.GetObject("panel4.Location")));
			this.panel4.Name = "panel4";
			this.panel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel4.RightToLeft")));
			this.panel4.Size = ((System.Drawing.Size)(resources.GetObject("panel4.Size")));
			this.panel4.TabIndex = ((int)(resources.GetObject("panel4.TabIndex")));
			this.panel4.Text = resources.GetString("panel4.Text");
			this.panel4.Visible = ((bool)(resources.GetObject("panel4.Visible")));
			// 
			// label12
			// 
			this.label12.AccessibleDescription = resources.GetString("label12.AccessibleDescription");
			this.label12.AccessibleName = resources.GetString("label12.AccessibleName");
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label12.Anchor")));
			this.label12.AutoSize = ((bool)(resources.GetObject("label12.AutoSize")));
			this.label12.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label12.Dock")));
			this.label12.Enabled = ((bool)(resources.GetObject("label12.Enabled")));
			this.label12.Font = ((System.Drawing.Font)(resources.GetObject("label12.Font")));
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.ImageAlign")));
			this.label12.ImageIndex = ((int)(resources.GetObject("label12.ImageIndex")));
			this.label12.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label12.ImeMode")));
			this.label12.Location = ((System.Drawing.Point)(resources.GetObject("label12.Location")));
			this.label12.Name = "label12";
			this.label12.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label12.RightToLeft")));
			this.label12.Size = ((System.Drawing.Size)(resources.GetObject("label12.Size")));
			this.label12.TabIndex = ((int)(resources.GetObject("label12.TabIndex")));
			this.label12.Text = resources.GetString("label12.Text");
			this.label12.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.TextAlign")));
			this.label12.Visible = ((bool)(resources.GetObject("label12.Visible")));
			// 
			// ClstForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.clstPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "ClstForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.clstPanel.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
