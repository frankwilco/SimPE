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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für BhavWizard.
	/// </summary>
	public class BhavWizard : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lbprimitives;
		private System.Windows.Forms.TabControl tcopcodes;
		private System.Windows.Forms.TabPage tbprimitive;
		private System.Windows.Forms.TabPage tbprivate;
		private System.Windows.Forms.TabPage tbsemi;
		private System.Windows.Forms.TabPage tbglobal;
		private System.Windows.Forms.ListBox lbprivate;
		private System.Windows.Forms.ListBox lbsemi;
		private System.Windows.Forms.ListBox lbglobal;
		private System.Windows.Forms.Button btuse;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BhavWizard()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbprimitives = new System.Windows.Forms.ListBox();
			this.tcopcodes = new System.Windows.Forms.TabControl();
			this.tbprimitive = new System.Windows.Forms.TabPage();
			this.tbprivate = new System.Windows.Forms.TabPage();
			this.tbsemi = new System.Windows.Forms.TabPage();
			this.tbglobal = new System.Windows.Forms.TabPage();
			this.lbprivate = new System.Windows.Forms.ListBox();
			this.lbsemi = new System.Windows.Forms.ListBox();
			this.lbglobal = new System.Windows.Forms.ListBox();
			this.btuse = new System.Windows.Forms.Button();
			this.tcopcodes.SuspendLayout();
			this.tbprimitive.SuspendLayout();
			this.tbprivate.SuspendLayout();
			this.tbsemi.SuspendLayout();
			this.tbglobal.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbprimitives
			// 
			this.lbprimitives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbprimitives.IntegralHeight = false;
			this.lbprimitives.Location = new System.Drawing.Point(8, 8);
			this.lbprimitives.Name = "lbprimitives";
			this.lbprimitives.Size = new System.Drawing.Size(432, 288);
			this.lbprimitives.Sorted = true;
			this.lbprimitives.TabIndex = 0;
			// 
			// tcopcodes
			// 
			this.tcopcodes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tcopcodes.Controls.Add(this.tbprimitive);
			this.tcopcodes.Controls.Add(this.tbglobal);
			this.tcopcodes.Controls.Add(this.tbsemi);
			this.tcopcodes.Controls.Add(this.tbprivate);
			this.tcopcodes.Location = new System.Drawing.Point(8, 8);
			this.tcopcodes.Name = "tcopcodes";
			this.tcopcodes.SelectedIndex = 0;
			this.tcopcodes.Size = new System.Drawing.Size(456, 328);
			this.tcopcodes.TabIndex = 1;
			// 
			// tbprimitive
			// 
			this.tbprimitive.Controls.Add(this.lbprimitives);
			this.tbprimitive.Location = new System.Drawing.Point(4, 22);
			this.tbprimitive.Name = "tbprimitive";
			this.tbprimitive.Size = new System.Drawing.Size(448, 302);
			this.tbprimitive.TabIndex = 0;
			this.tbprimitive.Text = "Primitives";
			// 
			// tbprivate
			// 
			this.tbprivate.Controls.Add(this.lbprivate);
			this.tbprivate.Location = new System.Drawing.Point(4, 22);
			this.tbprivate.Name = "tbprivate";
			this.tbprivate.Size = new System.Drawing.Size(448, 302);
			this.tbprivate.TabIndex = 1;
			this.tbprivate.Text = "Private";
			// 
			// tbsemi
			// 
			this.tbsemi.Controls.Add(this.lbsemi);
			this.tbsemi.Location = new System.Drawing.Point(4, 22);
			this.tbsemi.Name = "tbsemi";
			this.tbsemi.Size = new System.Drawing.Size(448, 302);
			this.tbsemi.TabIndex = 2;
			this.tbsemi.Text = "SemiGlobal";
			// 
			// tbglobal
			// 
			this.tbglobal.Controls.Add(this.lbglobal);
			this.tbglobal.Location = new System.Drawing.Point(4, 22);
			this.tbglobal.Name = "tbglobal";
			this.tbglobal.Size = new System.Drawing.Size(448, 302);
			this.tbglobal.TabIndex = 3;
			this.tbglobal.Text = "Global";
			// 
			// lbprivate
			// 
			this.lbprivate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbprivate.IntegralHeight = false;
			this.lbprivate.Location = new System.Drawing.Point(8, 7);
			this.lbprivate.Name = "lbprivate";
			this.lbprivate.Size = new System.Drawing.Size(432, 288);
			this.lbprivate.Sorted = true;
			this.lbprivate.TabIndex = 1;
			// 
			// lbsemi
			// 
			this.lbsemi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbsemi.IntegralHeight = false;
			this.lbsemi.Location = new System.Drawing.Point(8, 7);
			this.lbsemi.Name = "lbsemi";
			this.lbsemi.Size = new System.Drawing.Size(432, 288);
			this.lbsemi.Sorted = true;
			this.lbsemi.TabIndex = 1;
			// 
			// lbglobal
			// 
			this.lbglobal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbglobal.IntegralHeight = false;
			this.lbglobal.Location = new System.Drawing.Point(8, 7);
			this.lbglobal.Name = "lbglobal";
			this.lbglobal.Size = new System.Drawing.Size(432, 288);
			this.lbglobal.Sorted = true;
			this.lbglobal.TabIndex = 1;
			// 
			// btuse
			// 
			this.btuse.Location = new System.Drawing.Point(389, 344);
			this.btuse.Name = "btuse";
			this.btuse.TabIndex = 2;
			this.btuse.Text = "Use";
			this.btuse.Click += new System.EventHandler(this.UseOpcode);
			// 
			// BhavWizard
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(474, 376);
			this.Controls.Add(this.btuse);
			this.Controls.Add(this.tcopcodes);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "BhavWizard";
			this.ShowInTaskbar = false;
			this.Text = "Bhav Opcodes";
			this.tcopcodes.ResumeLayout(false);
			this.tbprimitive.ResumeLayout(false);
			this.tbprivate.ResumeLayout(false);
			this.tbsemi.ResumeLayout(false);
			this.tbglobal.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//the current SemiGroup
		uint semigroup = 0;

		//the returned Opcode
		ushort opcode = 0;

		public void Init(Bhav bhav)
		{
			this.lbprimitives.Items.Clear();
			this.lbglobal.Items.Clear();
			this.lbsemi.Items.Clear();

			if (bhav.Package == null) return;
			if (bhav.Opcodes == null) return;

			Interfaces.Files.IPackedFileDescriptor[] pfds = null;

			//Primitives
			ArrayList opcodes = bhav.Opcodes.StoredPrimitives;
			for (int i=0; i<opcodes.Count; i++)
			{
				string name = opcodes[i].ToString();
				if (!name.StartsWith("~"))
				{
					SimPe.Data.Alias a = new SimPe.Data.Alias((uint)i, name);
					this.lbprimitives.Items.Add(a);
				}
			}

			

			//Semi Global Group
			Glob glob = new Glob();
			Interfaces.Files.IPackedFileDescriptor gpfd = bhav.Package.FindFile(Data.MetaData.GLOB_FILE, 0, bhav.FileDescriptor.Group, 0x01);
			if (gpfd!=null) glob.ProcessData(gpfd, bhav.Package);
			uint semigroup = glob.SemiGlobalGroup;
			this.tbsemi.Text = glob.SemiGlobalName;

			//(Semi) Global BHAV
			pfds = bhav.Opcodes.BasePackage.FindFiles(Data.MetaData.BHAV_FILE);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				if ((pfd.Instance>=0x0100) && (pfd.Instance<0x1000) && (pfd.Group==0x7FD46CD0)) 
				{
					bhav.ProcessData(pfd, bhav.Opcodes.BasePackage);
					SimPe.Data.Alias a = new SimPe.Data.Alias(bhav.FileDescriptor.Instance, bhav.FileName);
					lbglobal.Items.Add(a);
				} 
			}

			if (lbglobal.Items.Count>0) lbglobal.SelectedIndex = 0;
			if (lbprimitives.Items.Count>0) lbprimitives.SelectedIndex = 0;
			if (lbprivate.Items.Count>0) lbprivate.SelectedIndex = 0;
		}

		public ushort Execute(Bhav bhav, Form form)
		{
			if (bhav.Package == null) return 0;
			if (bhav.Opcodes == null) return 0;

			form.Cursor = Cursors.WaitCursor;
			this.Cursor = Cursors.WaitCursor;
			Interfaces.Files.IPackedFileDescriptor[] pfds = null;

			//Local BHAV
			this.lbprivate.Items.Clear();
			pfds = bhav.Package.FindFiles(Data.MetaData.BHAV_FILE);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				if (bhav.FileDescriptor.Group != pfd.Group) continue;
				bhav.ProcessData(pfd, bhav.Package);
				SimPe.Data.Alias a = new SimPe.Data.Alias(bhav.FileDescriptor.Instance, bhav.FileName);
				lbprivate.Items.Add(a);
			}

			//Semi Global Group
			Glob glob = new Glob();
			Interfaces.Files.IPackedFileDescriptor gpfd = bhav.Package.FindFile(Data.MetaData.GLOB_FILE, 0, bhav.FileDescriptor.Group, 0x01);
			if (gpfd!=null) glob.ProcessData(gpfd, bhav.Package);

			if (semigroup != glob.SemiGlobalGroup) 
			{
				if (lbprimitives.Items.Count==0) Init(bhav);
				this.lbsemi.Items.Clear();
				semigroup = glob.SemiGlobalGroup;
				this.tbsemi.Text = glob.SemiGlobalName;

				//Semi Global BHAV
				pfds = bhav.Opcodes.BasePackage.FindFiles(Data.MetaData.BHAV_FILE);
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					if ((pfd.Instance>=0x2000) && (pfd.Group == semigroup))
					{
						bhav.ProcessData(pfd, bhav.Opcodes.BasePackage);
						SimPe.Data.Alias a = new SimPe.Data.Alias(bhav.FileDescriptor.Instance, bhav.FileName);
						lbsemi.Items.Add(a);
					}
				}

				if (lbsemi.Items.Count>0) lbsemi.SelectedIndex = 0;
			}
			
			form.Cursor = Cursors.Default;
			this.Cursor = Cursors.Default;
			this.ShowDialog();

			return opcode;
		}

		private void UseOpcode(object sender, System.EventArgs e)
		{
			if  (this.tcopcodes.SelectedIndex == 0)  
			{
				if (lbprimitives.SelectedIndex >= 0) opcode = (ushort)((SimPe.Data.Alias)lbprimitives.Items[lbprimitives.SelectedIndex]).Id;
			} 
			else if  (this.tcopcodes.SelectedIndex == 1)
			{
				if (lbglobal.SelectedIndex >= 0) opcode = (ushort)((SimPe.Data.Alias)lbglobal.Items[lbglobal.SelectedIndex]).Id;
			} 
			else if  (this.tcopcodes.SelectedIndex == 2)
			{
				if (lbsemi.SelectedIndex >= 0) opcode = (ushort)((SimPe.Data.Alias)lbsemi.Items[lbsemi.SelectedIndex]).Id;
			}
			else if  (this.tcopcodes.SelectedIndex == 3) 
			{
				if (lbprivate.SelectedIndex >= 0) opcode = (ushort)((SimPe.Data.Alias)lbprivate.Items[lbprivate.SelectedIndex]).Id;
			} 
			else 
			{
				opcode = 0;
			}

			Close();
		}
	}
}
