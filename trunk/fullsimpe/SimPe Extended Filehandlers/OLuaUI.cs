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
using SimPe.Interfaces.Plugin;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für OLuaUI.
	/// </summary>
	public class ObjLua : System.Windows.Forms.UserControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private System.Windows.Forms.CheckBox cbComplete;
		private System.Windows.Forms.ListBox lb;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ObjLua()
		{
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
			this.cbComplete = new System.Windows.Forms.CheckBox();
			this.lb = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// cbComplete
			// 
			this.cbComplete.Enabled = false;
			this.cbComplete.Location = new System.Drawing.Point(8, 8);
			this.cbComplete.Name = "cbComplete";
			this.cbComplete.TabIndex = 0;
			this.cbComplete.Text = "Complete";
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.IntegralHeight = false;
			this.lb.Location = new System.Drawing.Point(8, 32);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(552, 360);
			this.lb.TabIndex = 1;
			// 
			// ObjLua
			// 
			this.Controls.Add(this.lb);
			this.Controls.Add(this.cbComplete);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ObjLua";
			this.Size = new System.Drawing.Size(568, 400);
			this.ResumeLayout(false);

		}
		#endregion


		#region IPackedFileUI Member

		public void UpdateGUI(IFileWrapper wrapper)
		{
			SimPe.PackedFiles.Wrapper.ObjLua lua = (SimPe.PackedFiles.Wrapper.ObjLua)wrapper;

			this.cbComplete.Checked = lua.Complete;
			lb.Items.Clear();
		}

		public Control GUIHandle
		{
			get
			{
				return this;
			}
		}

		#endregion

		#region IDisposable Member

		void System.IDisposable.Dispose()
		{
			this.Dispose(true);
		}

		#endregion
	}
}
