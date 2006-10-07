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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für SimComboBox.
	/// </summary>
	[System.ComponentModel.DefaultEvent("SelectedSimChanged")]
	public class SimComboBox : System.Windows.Forms.UserControl
	{
		private Ambertation.Windows.Forms.FlatComboBox cb;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimComboBox()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			cb.Sorted = true;
			try 
			{
				if (!this.DesignMode)
					SimPe.FileTable.ProviderRegistry.SimDescriptionProvider.ChangedPackage += new EventHandler(SimDescriptionProvider_ChangedPackage);
				needreload = true;
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
				SimPe.FileTable.ProviderRegistry.SimDescriptionProvider.ChangedPackage -= new EventHandler(SimDescriptionProvider_ChangedPackage);
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
			this.cb = new Ambertation.Windows.Forms.FlatComboBox();
			this.SuspendLayout();
			// 
			// cb
			// 
			this.cb.Dock = System.Windows.Forms.DockStyle.Top;
			this.cb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cb.Location = new System.Drawing.Point(0, 0);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(150, 21);
			this.cb.TabIndex = 0;
			this.cb.TextChanged += new System.EventHandler(this.cb_TextChanged);
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// SimComboBox
			// 
			this.Controls.Add(this.cb);
			this.Name = "SimComboBox";
			this.Size = new System.Drawing.Size(150, 24);
			this.ResumeLayout(false);

		}
		#endregion

		void SetContent()
		{
			cb.Items.Clear();
			cb.Sorted = false;
			foreach (SimPe.PackedFiles.Wrapper.ExtSDesc sdsc in FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance.Values)
			{
				SimPe.Interfaces.IAlias a = new SimPe.Data.StaticAlias(sdsc.SimId, sdsc.SimName+" "+sdsc.SimFamilyName, new object[] {sdsc});
				cb.Items.Add(a);
			}
			cb.Sorted = true;
		}

		public ushort SelectedSimInstance
		{
			get 
			{
				SimPe.PackedFiles.Wrapper.ExtSDesc sdsc = SelectedSim;
				if (sdsc!=null) return sdsc.Instance;
				return 0xffff;
			}
			set 
			{
				int id = -1;
				
				int ct=0;
				foreach (SimPe.Interfaces.IAlias a in cb.Items)
				{
					SimPe.PackedFiles.Wrapper.ExtSDesc s = a.Tag[0] as SimPe.PackedFiles.Wrapper.ExtSDesc;
					if (s.Instance == value) 
					{
						id = ct;
						break;
					}					
					ct++;
				}			
				cb.SelectedIndex = id;
			}
		}

		public uint SelectedSimId
		{
			get 
			{
				SimPe.PackedFiles.Wrapper.ExtSDesc sdsc = SelectedSim;
				if (sdsc!=null) return sdsc.SimId;
				return 0xffffffff;
			}
			set 
			{
				int id = -1;
				
				int ct=0;
				foreach (SimPe.Interfaces.IAlias a in cb.Items)
				{
					SimPe.PackedFiles.Wrapper.ExtSDesc s = a.Tag[0] as SimPe.PackedFiles.Wrapper.ExtSDesc;
					if (s.SimId == value) 
					{
						id = ct;
						break;
					}					
					ct++;
				}			
				cb.SelectedIndex = id;
			}
		}

		public SimPe.PackedFiles.Wrapper.ExtSDesc SelectedSim
		{
			get 
			{
				if (cb.SelectedItem==null) return null;
				SimPe.Interfaces.IAlias a = cb.SelectedItem as SimPe.Interfaces.IAlias;
				return a.Tag[0] as SimPe.PackedFiles.Wrapper.ExtSDesc;
			}
			set
			{
				int id = -1;
				if (value!=null) 
				{
					int ct=0;
					foreach (SimPe.Interfaces.IAlias a in cb.Items)
					{
						SimPe.PackedFiles.Wrapper.ExtSDesc s = a.Tag[0] as SimPe.PackedFiles.Wrapper.ExtSDesc;
						if (s.Instance == value.Instance) 
						{
							id = ct;
							break;
						}					
						ct++;
					}
				}

				cb.SelectedIndex = id;
			}
		}

		public void Reload()
		{
			needreload = false;
			SetContent();
			base.Refresh();
		}

		public event EventHandler SelectedSimChanged;
		private void cb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (SelectedSimChanged!=null) SelectedSimChanged(this, new EventArgs());
		}

		bool needreload;
		private void SimDescriptionProvider_ChangedPackage(object sender, EventArgs e)
		{
			needreload = true;
			if (this.Visible) Reload();
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged (e);
			if (needreload && Visible) Reload();
		}

		private void cb_TextChanged(object sender, System.EventArgs e)
		{
			//cb.DroppedDown = true;
		}

	}
}
