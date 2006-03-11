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
using SimPe.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtNgbhUI.
	/// </summary>
	public class CregUI : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private SimPe.PackedFiles.Wrapper.Creg3UI creg3;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public CregUI()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CregUI));
			this.creg3 = new SimPe.PackedFiles.Wrapper.Creg3UI();
			this.SuspendLayout();
			// 
			// creg3
			// 
			this.creg3.AccessibleDescription = resources.GetString("creg3.AccessibleDescription");
			this.creg3.AccessibleName = resources.GetString("creg3.AccessibleName");
			this.creg3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("creg3.Anchor")));
			this.creg3.AutoScroll = ((bool)(resources.GetObject("creg3.AutoScroll")));
			this.creg3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("creg3.AutoScrollMargin")));
			this.creg3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("creg3.AutoScrollMinSize")));
			this.creg3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creg3.BackgroundImage")));
			this.creg3.Creg = null;
			this.creg3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("creg3.Dock")));
			this.creg3.Enabled = ((bool)(resources.GetObject("creg3.Enabled")));
			this.creg3.Font = ((System.Drawing.Font)(resources.GetObject("creg3.Font")));
			this.creg3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("creg3.ImeMode")));
			this.creg3.Location = ((System.Drawing.Point)(resources.GetObject("creg3.Location")));
			this.creg3.Name = "creg3";
			this.creg3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("creg3.RightToLeft")));
			this.creg3.Size = ((System.Drawing.Size)(resources.GetObject("creg3.Size")));
			this.creg3.TabIndex = ((int)(resources.GetObject("creg3.TabIndex")));
			this.creg3.Visible = ((bool)(resources.GetObject("creg3.Visible")));
			// 
			// CregUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.creg3);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CregUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.creg3, 0);
			this.ResumeLayout(false);

		}
		#endregion

		public Creg Creg
		{
			get { return (Creg)Wrapper; }
		}

		protected override void RefreshGUI()
		{
			this.creg3.Visible = false;
			if (Creg!=null) 
			{
				this.creg3.Visible = Creg.Group3!=null;
				creg3.Creg = Creg.Group3;

				this.Enabled = (creg3.Creg != null);
			}
		}

		public override void OnCommit()
		{
			Creg.SynchronizeUserData(true, false);
		}						
	}
}
