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

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für SelectSimFolder.
	/// </summary>
	class SelectSimFolder : System.Windows.Forms.Form
	{
		class FolderWrapper
		{
			string name, folder;
			public FolderWrapper(string name, string folder)
			{
				this.name = SimPe.Localization.GetString(name);
				this.folder = folder;
			}

			public string Folder 
			{
				get {return folder;}
			}

			public override string ToString()
			{
				return folder;
				return name+": "+folder;
			}

		}
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.ComboBox tbFolder;
		private SteepValley.Windows.Forms.XPLine xpLine1;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Button btOK;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SelectSimFolder()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			
			this.tbFolder.Items.Add(new FolderWrapper("Original Game", SimPe.Helper.WindowsRegistry.RealGamePath));
			this.tbFolder.Items.Add(new FolderWrapper("University", SimPe.Helper.WindowsRegistry.RealEP1GamePath));
			this.tbFolder.Items.Add(new FolderWrapper("Nightlife", SimPe.Helper.WindowsRegistry.RealEP2GamePath));
			this.tbFolder.Items.Add(new FolderWrapper("Open for Business", SimPe.Helper.WindowsRegistry.RealEP3GamePath));
			this.tbFolder.Items.Add(new FolderWrapper("Savegame", SimPe.Helper.WindowsRegistry.RealSavegamePath));
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
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.xpLine1 = new SteepValley.Windows.Forms.XPLine();
			this.tbFolder = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.btOK);
			this.xpGradientPanel1.Controls.Add(this.btCancel);
			this.xpGradientPanel1.Controls.Add(this.xpLine1);
			this.xpGradientPanel1.Controls.Add(this.tbFolder);
			this.xpGradientPanel1.Controls.Add(this.button1);
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(674, 80);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// btOK
			// 
			this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btOK.Location = new System.Drawing.Point(512, 52);
			this.btOK.Name = "btOK";
			this.btOK.TabIndex = 6;
			this.btOK.Text = "OK";
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btCancel.Location = new System.Drawing.Point(592, 52);
			this.btCancel.Name = "btCancel";
			this.btCancel.TabIndex = 5;
			this.btCancel.Text = "Cancel";
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// xpLine1
			// 
			this.xpLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpLine1.BackColor = System.Drawing.Color.Transparent;
			this.xpLine1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.xpLine1.LineColor = System.Drawing.SystemColors.Desktop;
			this.xpLine1.Location = new System.Drawing.Point(0, 32);
			this.xpLine1.Name = "xpLine1";
			this.xpLine1.ShadowColor = System.Drawing.Color.Transparent;
			this.xpLine1.Size = new System.Drawing.Size(672, 16);
			this.xpLine1.TabIndex = 4;
			// 
			// tbFolder
			// 
			this.tbFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbFolder.Location = new System.Drawing.Point(64, 8);
			this.tbFolder.Name = "tbFolder";
			this.tbFolder.Size = new System.Drawing.Size(520, 21);
			this.tbFolder.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(592, 8);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "Browse...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Folder:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// SelectSimFolder
			// 
			this.AcceptButton = this.btOK;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size(674, 80);
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SelectSimFolder";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select Sim Folder";
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public static string ShowDialog(string path)
		{
			SelectSimFolder f = new SelectSimFolder();
			f.tbFolder.Text = path;

			if (f.ShowDialog()==DialogResult.OK)
				return f.tbFolder.Text;

			return path;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbFolder.Text))
				fbd.SelectedPath = tbFolder.Text;

			if (fbd.ShowDialog()==DialogResult.OK)
				tbFolder.Text = fbd.SelectedPath;
		}

		

		private void btOK_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void btCancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
		

		
	}

	/// <summary>
	/// a type editor for db connections
	/// </summary>
	public class SelectSimFolderUITypeEditor : 
		System.Drawing.Design.UITypeEditor 
	{
		
		/// <summary>
		/// constructor
		/// </summary>
		public SelectSimFolderUITypeEditor() 
		{
				
		}

		/// <summary>
		/// display a modal form 
		/// </summary>
		/// <param name="context">
		/// see documentation on ITypeDescriptorContext
		/// </param>
		/// <returns>
		/// the style of the editor
		/// </returns>
		public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(
			System.ComponentModel.ITypeDescriptorContext context) 
		{

			return System.Drawing.Design.UITypeEditorEditStyle.Modal ;
		}

		/// <summary>
		/// used to show the connection
		/// </summary>
		/// <param name="context">
		/// see documentation on ITypeDescriptorContext
		/// </param>
		/// <param name="provider">
		/// see documentation on IServiceProvider
		/// </param>
		/// <param name="value">
		/// the value prior to editing
		/// </param>
		/// <returns>
		/// the new connection string after editing
		/// </returns>
		public override object EditValue(
			System.ComponentModel.ITypeDescriptorContext context,
			System.IServiceProvider provider, 
			object value) 
		{
			return this.EditValue(value as string);
		}			

		/// <summary>
		/// show the form for the new connection 
		/// string based on an an existing one
		/// </summary>
		/// <param name="value">
		/// the value prior to editing
		/// </param>
		/// <returns>
		/// the new connection string after editing
		/// </returns>
		public string EditValue(string value) 
		{
			return SimPe.SelectSimFolder.ShowDialog(value);
		}
	}
}
