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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbsims;
		private SimPe.PackedFiles.UserInterface.CommonSrel sc;
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbsims = new System.Windows.Forms.Label();
			this.sc = new SimPe.PackedFiles.UserInterface.CommonSrel();
			this.SuspendLayout();
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
			// sc
			// 
			this.sc.AccessibleDescription = resources.GetString("sc.AccessibleDescription");
			this.sc.AccessibleName = resources.GetString("sc.AccessibleName");
			this.sc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("sc.Anchor")));
			this.sc.AutoScroll = ((bool)(resources.GetObject("sc.AutoScroll")));
			this.sc.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("sc.AutoScrollMargin")));
			this.sc.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("sc.AutoScrollMinSize")));
			this.sc.BackColor = System.Drawing.Color.Transparent;
			this.sc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sc.BackgroundImage")));
			this.sc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("sc.Dock")));
			this.sc.Enabled = ((bool)(resources.GetObject("sc.Enabled")));
			this.sc.Font = ((System.Drawing.Font)(resources.GetObject("sc.Font")));
			this.sc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("sc.ImeMode")));
			this.sc.Location = ((System.Drawing.Point)(resources.GetObject("sc.Location")));
			this.sc.Name = "sc";
			this.sc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("sc.RightToLeft")));
			this.sc.Size = ((System.Drawing.Size)(resources.GetObject("sc.Size")));
			this.sc.Srel = null;
			this.sc.TabIndex = ((int)(resources.GetObject("sc.TabIndex")));
			this.sc.Visible = ((bool)(resources.GetObject("sc.Visible")));
			// 
			// ExtSrel
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.sc);
			this.Controls.Add(this.lbsims);
			this.Controls.Add(this.label1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ExtSrel";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Commited += new System.EventHandler(this.ExtSrel_Commited);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lbsims, 0);
			this.Controls.SetChildIndex(this.sc, 0);
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
			sc.Srel = this.Srel;
			
			this.lbsims.Text = sc.SourceSimName + " "+SimPe.Localization.GetString("towards") + " "+sc.TargetSimName;
		}

		private void ExtSrel_Commited(object sender, System.EventArgs e)
		{
			Srel.SynchronizeUserData();
		}

	}
}
