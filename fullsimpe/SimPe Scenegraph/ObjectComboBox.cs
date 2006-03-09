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
using SimPe.Cache;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für SimComboBox.
	/// </summary>
	[System.ComponentModel.DefaultEvent("SelectedObjectChanged")]
	public class ObjectComboBox : System.Windows.Forms.UserControl
	{
		static MemoryCacheFile cachefile;

		/// <summary>
		/// Returns the MemoryObject Cache
		/// </summary>
		public static MemoryCacheFile ObjectCache 
		{
			get 
			{
				if (cachefile==null) cachefile = MemoryCacheFile.InitCacheFile();				

				return cachefile;
			}
		}

		private TD.SandBar.FlatComboBox cb;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ObjectComboBox()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			
			loaded = false;	
			si = true;
			sm = false;
			st = false;		
			sjd = false;
			sa = false;
			sb = false;
			sk = false;
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
			this.cb = new TD.SandBar.FlatComboBox();
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
			// ObjectComboBox
			// 
			this.Controls.Add(this.cb);
			this.Name = "ObjectComboBox";
			this.Size = new System.Drawing.Size(150, 24);
			this.ResumeLayout(false);

		}
		#endregion

		void SetContent()
		{
			System.Collections.ArrayList names = new ArrayList();
			if (this.DesignMode) return;
			cb.Items.Clear();
			cb.Sorted = false;
			foreach (SimPe.Cache.MemoryCacheItem mci in ObjectCache.List)
			{
				bool use = false;
				if (this.ShowInventory && mci.IsInventory && !mci.IsToken && !mci.IsMemory && !mci.IsJobData) use = true;
				if (this.ShowTokens && mci.IsToken) use = true;
				if (this.ShowMemories && !mci.IsToken && mci.IsMemory) use = true;
				if (this.ShowJobData && mci.IsJobData) use = true;
				if (this.ShowAspiration && mci.IsAspiration) use = true;
				if (this.ShowBadge && mci.IsBadge) use = true;
				if (this.ShowSkill && mci.IsSkill) use = true;

				if (!use) continue;
				

				SimPe.Interfaces.IAlias a = new SimPe.Data.Alias(mci.Guid, mci.Name, new object[] {mci});

				if (names.Contains(a.ToString())) continue;
				names.Add(a.ToString());
				cb.Items.Add(a);
			}		
			cb.Sorted = true;
		}

		bool si, st, sm, sjd, sa, sb, sk;
		public bool ShowTokens
		{
			get {return st;}
			set 
			{
				if (st!=value)
				{
					st = value;
					SetContent();
				}
			}
		}

		public bool ShowAspiration
		{
			get {return sa;}
			set 
			{
				if (sa!=value)
				{
					sa = value;
					SetContent();
				}
			}
		}

		public bool ShowBadge
		{
			get {return sb;}
			set 
			{
				if (sb!=value)
				{
					sb = value;
					SetContent();
				}
			}
		}

		public bool ShowSkill
		{
			get {return sk;}
			set 
			{
				if (sk!=value)
				{
					sk = value;
					SetContent();
				}
			}
		}

		public bool ShowMemories
		{
			get {return sm;}
			set 
			{
				if (sm!=value)
				{
					sm = value;
					SetContent();
				}
			}
		}

		public bool ShowInventory
		{
			get {return si;}
			set 
			{
				if (si!=value)
				{
					si = value;
					SetContent();
				}
			}
		}

		public bool ShowJobData
		{
			get {return sjd;}
			set 
			{
				if (sjd!=value)
				{
					sjd = value;
					SetContent();
				}
			}
		}
		
		public uint SelectedGuid
		{
			get 
			{
				SimPe.Cache.MemoryCacheItem mci = SelectedItem;
				
				if (mci==null) return 0xffffffff;
				return mci.Guid;
			}
			set
			{
				int id = -1;
				int ct=0;
				foreach (SimPe.Interfaces.IAlias a in cb.Items)
				{
					SimPe.Cache.MemoryCacheItem mci = a.Tag[0] as SimPe.Cache.MemoryCacheItem;
					if (mci.Guid == value) 
					{
						id = ct;
						break;
					}					
					ct++;
				}
				

				cb.SelectedIndex = id;
			}
		}

		public SimPe.Cache.MemoryCacheItem SelectedItem
		{
			get 
			{
				if (cb.SelectedItem==null) return null;
				SimPe.Interfaces.IAlias a = cb.SelectedItem as SimPe.Interfaces.IAlias;
				return a.Tag[0] as SimPe.Cache.MemoryCacheItem;
			}
			set
			{
				int id = -1;
				if (value!=null) 
				{
					int ct=0;
					foreach (SimPe.Interfaces.IAlias a in cb.Items)
					{
						SimPe.Cache.MemoryCacheItem mci = a.Tag[0] as SimPe.Cache.MemoryCacheItem;
						if (mci.Guid == value.Guid) 
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

		bool loaded;
		public void Reload()
		{
			loaded = true;
			SetContent();
			base.Refresh();
		}

		public event EventHandler SelectedObjectChanged;
		private void cb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (SelectedObjectChanged!=null) SelectedObjectChanged(this, new EventArgs());
		}		

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged (e);
			if (!loaded && Visible) Reload();
		}

		private void cb_TextChanged(object sender, System.EventArgs e)
		{
			//cb.DroppedDown = true;
		}

	}
}
