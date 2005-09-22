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
		private System.Windows.Forms.TreeView tv;
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
			this.tv = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// tv
			// 
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(8, 8);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(552, 384);
			this.tv.TabIndex = 0;
			// 
			// ObjLua
			// 
			this.Controls.Add(this.tv);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ObjLua";
			this.Size = new System.Drawing.Size(568, 400);
			this.ResumeLayout(false);

		}
		#endregion

		void AddFunction(System.Windows.Forms.TreeNodeCollection nodes, SimPe.PackedFiles.Wrapper.ObjLuaFunction fkt)
		{			
			TreeNode tn = new TreeNode(fkt.ToString());
			tn.Tag = fkt;
			nodes.Add(tn);

			TreeNode ctn = new TreeNode("Constants");			
			tn.Nodes.Add(ctn);
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaConstant olc in fkt.Constants)
			{
				TreeNode sctn = new TreeNode(olc.ToString());
				sctn.Tag = olc;

				ctn.Nodes.Add(sctn);
			}

			TreeNode ftn = new TreeNode("Functions");			
			tn.Nodes.Add(ftn);
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaFunction olf in fkt.Functions)
			{
				AddFunction(ftn.Nodes, olf);
			}
			

			TreeNode cdtn = new TreeNode("Instructions");			
			tn.Nodes.Add(cdtn);
			int ct = 0;
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaCode c in fkt.Codes)
			{
				TreeNode scdtn = new TreeNode(Helper.HexString(ct++)+": "+c.ToString());
				scdtn.Tag = c;

				cdtn.Nodes.Add(scdtn);
			}
		}

		#region IPackedFileUI Member

		public void UpdateGUI(IFileWrapper wrapper)
		{
			SimPe.PackedFiles.Wrapper.ObjLua lua = (SimPe.PackedFiles.Wrapper.ObjLua)wrapper;
			
			tv.Nodes.Clear();
			AddFunction(tv.Nodes, lua.Root);
			//tv.ExpandAll();
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
