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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtSrelUI.
	/// </summary>
	public class ExtSrel : SimPe.Windows.Forms.WrapperBaseControl, IPackedFileUI
	{
		private CommonSrel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbsims;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExtSrel()
		{
			Text = SimPe.Localization.GetString("Sim Relation Editor");

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			// TODO: Initialisierungen nach dem Aufruf von InitializeComponent hinzufügen

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExtSrel));
			this.panel1 = new SimPe.PackedFiles.UserInterface.CommonSrel();
			this.label1 = new System.Windows.Forms.Label();
			this.lbsims = new System.Windows.Forms.Label();
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
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.Srel = null;
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackColor = System.Drawing.Color.Transparent;
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
			// lbsims
			// 
			this.lbsims.AccessibleDescription = resources.GetString("lbsims.AccessibleDescription");
			this.lbsims.AccessibleName = resources.GetString("lbsims.AccessibleName");
			this.lbsims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbsims.Anchor")));
			this.lbsims.AutoSize = ((bool)(resources.GetObject("lbsims.AutoSize")));
			this.lbsims.BackColor = System.Drawing.Color.Transparent;
			this.lbsims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbsims.Dock")));
			this.lbsims.Enabled = ((bool)(resources.GetObject("lbsims.Enabled")));
			this.lbsims.Font = ((System.Drawing.Font)(resources.GetObject("lbsims.Font")));
			this.lbsims.Image = ((System.Drawing.Image)(resources.GetObject("lbsims.Image")));
			this.lbsims.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbsims.ImageAlign")));
			this.lbsims.ImageIndex = ((int)(resources.GetObject("lbsims.ImageIndex")));
			this.lbsims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbsims.ImeMode")));
			this.lbsims.Location = ((System.Drawing.Point)(resources.GetObject("lbsims.Location")));
			this.lbsims.Name = "lbsims";
			this.lbsims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbsims.RightToLeft")));
			this.lbsims.Size = ((System.Drawing.Size)(resources.GetObject("lbsims.Size")));
			this.lbsims.TabIndex = ((int)(resources.GetObject("lbsims.TabIndex")));
			this.lbsims.Text = resources.GetString("lbsims.Text");
			this.lbsims.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbsims.TextAlign")));
			this.lbsims.Visible = ((bool)(resources.GetObject("lbsims.Visible")));
			// 
			// ExtSrel
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.lbsims);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ExtSrel";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Commited += new System.EventHandler(this.ExtSrel_Commited);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lbsims, 0);
			this.ResumeLayout(false);

		}
		#endregion

		public SimPe.PackedFiles.Wrapper.ExtSrel Srel
		{
			get { return (SimPe.PackedFiles.Wrapper.ExtSrel)Wrapper;}
		}

		protected override void RefreshGUI()
		{
			base.RefreshGUI ();
			panel1.Srel = this.Srel;
		}

		private void ExtSrel_Commited(object sender, System.EventArgs e)
		{
			Srel.SynchronizeUserData();
		}

	}
}
