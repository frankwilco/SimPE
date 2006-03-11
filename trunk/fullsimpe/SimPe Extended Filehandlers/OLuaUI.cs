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
		private System.Windows.Forms.Button btSave;
		private System.Windows.Forms.Button btLoad;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ObjLua()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.button2.Enabled = Helper.QARelease;
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
			this.btSave = new System.Windows.Forms.Button();
			this.btLoad = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tv
			// 
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(8, 40);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(552, 320);
			this.tv.TabIndex = 0;
			// 
			// btSave
			// 
			this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btSave.Location = new System.Drawing.Point(96, 368);
			this.btSave.Name = "btSave";
			this.btSave.TabIndex = 1;
			this.btSave.Text = "Export...";
			this.btSave.Click += new System.EventHandler(this.btSave_Click);
			// 
			// btLoad
			// 
			this.btLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btLoad.Location = new System.Drawing.Point(8, 368);
			this.btLoad.Name = "btLoad";
			this.btLoad.TabIndex = 2;
			this.btLoad.Text = "Import...";
			this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Name:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbName
			// 
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbName.Location = new System.Drawing.Point(64, 8);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(496, 21);
			this.tbName.TabIndex = 4;
			this.tbName.Text = "";
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(485, 368);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "Commit";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(176, 368);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(120, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Export to Source...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ObjLua
			// 
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btLoad);
			this.Controls.Add(this.btSave);
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

			TreeNode cltn = new TreeNode("Locals");			
			tn.Nodes.Add(cltn);
			int ct = 0;
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaLocalVar c in fkt.Locals)
			{
				TreeNode scltn = new TreeNode(Helper.HexString(ct++)+": "+c.ToString());
				scltn.Tag = c;

				cltn.Nodes.Add(scltn);
			}

			TreeNode cutn = new TreeNode("UpValues");			
			tn.Nodes.Add(cutn);
			ct = 0;
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaUpValue c in fkt.UpValues)
			{
				TreeNode scutn = new TreeNode(Helper.HexString(ct++)+": "+c.ToString());
				scutn.Tag = c;

				cutn.Nodes.Add(scutn);
			}

			TreeNode cstn = new TreeNode("SourceLines");			
			tn.Nodes.Add(cstn);
			ct = 0;
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaSourceLine c in fkt.SourceLine)
			{
				TreeNode scstn = new TreeNode(Helper.HexString(ct++)+": "+c.ToString());
				scstn.Tag = c;

				cstn.Nodes.Add(scstn);
			}

			TreeNode ftn = new TreeNode("Functions");			
			tn.Nodes.Add(ftn);
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaFunction olf in fkt.Functions)
			{
				AddFunction(ftn.Nodes, olf);
			}
			

			TreeNode cdtn = new TreeNode("Instructions");			
			tn.Nodes.Add(cdtn);
			ct = 0;
			foreach (SimPe.PackedFiles.Wrapper.ObjLuaCode c in fkt.Codes)
			{
				TreeNode scdtn = new TreeNode(Helper.HexString(ct++)+": "+c.ToString());
				scdtn.Tag = c;

				cdtn.Nodes.Add(scdtn);
			}

			
		}

		SimPe.PackedFiles.Wrapper.ObjLua lua;
		protected SimPe.PackedFiles.Wrapper.ObjLua Wrapper 
		{
			get { return lua;}
		}

		#region IPackedFileUI Member

		public void UpdateGUI(IFileWrapper wrapper)
		{
			lua = (SimPe.PackedFiles.Wrapper.ObjLua)wrapper;
			
			tv.Nodes.Clear();
			AddFunction(tv.Nodes, lua.Root);

			tbName.Text = lua.FileName;
			tv.ExpandAll();
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

		private void btSave_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = SimPe.ExtensionProvider.BuildFilterString(new SimPe.ExtensionType[] {SimPe.ExtensionType.LuaScript, SimPe.ExtensionType.AllFiles});
			sfd.FileName = Wrapper.FileName;
			if (sfd.ShowDialog()==DialogResult.OK)			
				Wrapper.ExportLua(sfd.FileName);			
		}

		private void btLoad_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = SimPe.ExtensionProvider.BuildFilterString(new SimPe.ExtensionType[] {SimPe.ExtensionType.LuaScript, SimPe.ExtensionType.AllFiles});
			ofd.FileName = Wrapper.FileName;
			if (ofd.ShowDialog()==DialogResult.OK)			
				Wrapper.ImportLua(ofd.FileName);

			Wrapper.SynchronizeUserData(true, false);
			UpdateGUI(Wrapper);
		}

		private void tbName_TextChanged(object sender, System.EventArgs e)
		{
			Wrapper.FileName = tbName.Text;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Wrapper.SynchronizeUserData(true, false);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = SimPe.ExtensionProvider.BuildFilterString(new SimPe.ExtensionType[] {SimPe.ExtensionType.LuaScript, SimPe.ExtensionType.AllFiles});
			sfd.FileName = Wrapper.FileName;
			if (sfd.ShowDialog()==DialogResult.OK)	
			{		
				string src = Wrapper.ToSource();
				System.IO.StreamWriter sw = System.IO.File.CreateText(sfd.FileName);
				try 
				{
					sw.Write(src);
				} 					
				finally 
				{
					sw.Close();
				}
			}
		}

		
	}
}
