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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin.TabPage
{
	/// <summary>
	/// Zusammenfassung für MatdForm.
	/// </summary>
	public class MaterialDefinitionCategories : 
		System.Windows.Forms.TabPage
		//System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;		

		public MaterialDefinitionCategories()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();			
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				Tag = null;
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
			this.pg = new System.Windows.Forms.PropertyGrid();			
			this.SuspendLayout();
			// 
			// tMaterialDefinitionCategories
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.pg);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tMaterialDefinitionCategories";
			this.Size = new System.Drawing.Size(744, 238);
			this.TabIndex = 3;
			this.Text = "Categorized Properties";
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(8, 8);
			this.pg.Name = "pg";
			this.pg.Size = new System.Drawing.Size(728, 224);
			this.pg.TabIndex = 0;
			this.pg.Text = "MaterialDefinition Properties";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;			
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_PropertyValueChanged);
			// 
			// MatdForm
			// 			
			this.ResumeLayout(false);

		}
		#endregion

		
		private System.Windows.Forms.PropertyGrid pg;


						
				

		

		/*private void SelectListFile(object sender, System.EventArgs e)
		{
			if (tblistfile.Tag!=null) return;
			if (lbfl.SelectedIndex<0) return;
			
			try 
			{
				tblistfile.Tag = true;
				tblistfile.Text = (string)lbfl.Items[lbfl.SelectedIndex];
			} 
			catch (Exception) {}
			finally 
			{
				tblistfile.Tag = null;
			}
		}

		private void ChangeListFile(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (tblistfile.Tag!=null) return;
			if (lbfl.SelectedIndex<0) return;
			
			try 
			{
				tblistfile.Tag = true;
				lbfl.Items[lbfl.SelectedIndex] = tblistfile.Text;

				MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
				md.Listing[lbfl.SelectedIndex] = tblistfile.Text;

				md.Changed = true;
			} 
			catch (Exception) {}
			finally 
			{
				tblistfile.Tag = null;
			}
		}

		private void Delete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (lbfl.SelectedIndex<0) return;
			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Listing = (string[])Helper.Delete(md.Listing, lbfl.Items[lbfl.SelectedIndex]);

			lbfl.Items.Remove(lbfl.Items[lbfl.SelectedIndex]);

			md.Changed = true;			
		}

		private void Add(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			lbfl.Items.Add(tblistfile.Text);
			lbfl.SelectedIndex = lbfl.Items.Count-1;

			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Listing = (string[])Helper.Add(md.Listing, tblistfile.Text);

			md.Changed = true;
		}	*/	

		Ambertation.PropertyObjectBuilderExt pob;
		internal void SetupGrid(SimPe.Plugin.MaterialDefinition md)
		{
			pg.SelectedObject = null;
			/*if (this.tGrid.Tag==null) return;
			MaterialDefinition md = (MaterialDefinition)this.tGrid.Tag;*/

			//Build the table for the current MMAT
			Hashtable ht = new Hashtable();

			foreach (MaterialDefinitionProperty mdp in md.Properties) 
			{
				if (SimPe.Plugin.MaterialDefinition.PropertyParser.Properties.ContainsKey(mdp.Name)) 
				{
					Ambertation.PropertyDescription pd = ((Ambertation.PropertyDescription)SimPe.Plugin.MaterialDefinition.PropertyParser.Properties[mdp.Name]).Clone();
					pd.Property = mdp.Value;
					ht[mdp.Name] = pd;
				} 
				else 
				{
					ht[mdp.Name] = mdp.Value;
				}
			}

			pob = new Ambertation.PropertyObjectBuilderExt(ht);
			pg.SelectedObject = pob.Instance;
		}

		private void pg_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (this.Tag==null) return;
			if (pob==null) return;
			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			object o = pob.Properties[e.ChangedItem.Label];
			if (o is Boolean)
			{
				if ((bool)o) md.GetProperty(e.ChangedItem.Label).Value = "1";
				else md.GetProperty(e.ChangedItem.Label).Value = "0";
			} else md.GetProperty(e.ChangedItem.Label).Value = o.ToString();

			md.Parent.Changed = true;
		}

		internal void TxmtChangeTab(object sender, System.EventArgs e)
		{
			if (this.Tag==null) return;
			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			if (Parent==null) return;
			if (((TabControl)Parent).SelectedTab == this) 
			{
				md.Refresh();
			} 
		}		
	}
}
