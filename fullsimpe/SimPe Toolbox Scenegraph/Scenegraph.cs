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
using SimPe.Interfaces;
using Ambertation.Graph;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ScenegraphForm.
	/// </summary>
	public class ScenegraphForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbrefnames;
		private System.Windows.Forms.TextBox tbflname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pb;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ScenegraphForm()
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ScenegraphForm));
			this.panel2 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbrefnames = new System.Windows.Forms.ComboBox();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.panel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.groupBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(8, 350);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(792, 120);
			this.panel2.TabIndex = 4;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.cbrefnames);
			this.groupBox1.Controls.Add(this.tbflname);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(0, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(784, 108);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Properties";
			// 
			// cbrefnames
			// 
			this.cbrefnames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbrefnames.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbrefnames.Location = new System.Drawing.Point(24, 80);
			this.cbrefnames.Name = "cbrefnames";
			this.cbrefnames.Size = new System.Drawing.Size(752, 21);
			this.cbrefnames.TabIndex = 3;
			// 
			// tbflname
			// 
			this.tbflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbflname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbflname.Location = new System.Drawing.Point(24, 40);
			this.tbflname.Name = "tbflname";
			this.tbflname.ReadOnly = true;
			this.tbflname.Size = new System.Drawing.Size(752, 21);
			this.tbflname.TabIndex = 2;
			this.tbflname.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Reference Name:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "FileName:";
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.pb);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(792, 342);
			this.panel1.TabIndex = 5;
			// 
			// pb
			// 
			this.pb.BackColor = System.Drawing.Color.Transparent;
			this.pb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pb.Location = new System.Drawing.Point(0, 0);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(4000, 1400);
			this.pb.TabIndex = 4;
			this.pb.TabStop = false;
			// 
			// ScenegraphForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 470);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.DockPadding.Left = 8;
			this.DockPadding.Top = 8;
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ScenegraphForm";
			this.Text = "Scenegraph";
			this.panel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		
		public void GraphItemClick(object sender, EventArgs e) 
		{
			GraphItem gi = (GraphItem)sender;
			Hashtable ht = null;
			if (gi.Tag.GetType()==typeof(string)) 
			{				
				this.tbflname.Text = (string)gi.Tag;
				this.cbrefnames.Items.Clear();
				cbrefnames.Text = "";
			} 
			else if (gi.Tag.GetType()==typeof(GenericRcol)) 
			{
				GenericRcol rcol = (GenericRcol)gi.Tag;
				this.tbflname.Text = rcol.FileName;
				this.cbrefnames.Items.Clear();
				cbrefnames.Text = "";
				ht = rcol.ReferenceChains;
			} 
			else if (gi.Tag.GetType()==typeof(SimPe.Plugin.MmatWrapper))
			{
				SimPe.Plugin.MmatWrapper mmat = (SimPe.Plugin.MmatWrapper)gi.Tag;
				this.tbflname.Text = mmat.GetSaveItem("subsetName").StringValue;				
				this.cbrefnames.Items.Clear();
				cbrefnames.Text = "";
				ht = mmat.ReferenceChains;
			}

			if (ht!=null)
				foreach (string s in ht.Keys) 
					foreach(Interfaces.Files.IPackedFileDescriptor pfd in (ArrayList)ht[s])
					{
						this.cbrefnames.Items.Add(pfd.Filename);
					}

			if (cbrefnames.Items.Count>0) cbrefnames.SelectedIndex = 0;
		}

		
		/// <summary>
		/// Build the SceneGraph
		/// </summary>
		/// <param name="prov"></param>
		/// <param name="simpe_pkg"></param>
		public void Execute(IProviderRegistry prov, SimPe.Interfaces.Files.IPackageFile simpe_pkg) 
		{
			try 
			{
				WaitingScreen.Wait();
				SimPe.Interfaces.Files.IPackageFile orgpkg = simpe_pkg;

				DateTime start = DateTime.Now;
				FileTable.FileIndex.Load();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fileindex = FileTable.FileIndex.Clone();				
				fileindex.AddIndexFromPackage(simpe_pkg);

				SimPe.Interfaces.Scenegraph.IScenegraphFileIndex oldfileindex = FileTable.FileIndex;				
				FileTable.FileIndex = fileindex;

				//find txtr File
				/*WaitingScreen.UpdateMessage("Collecting Global Files");
				string[] modelnames = Scenegraph.FindModelNames(simpe_pkg);				
				try 
				{					
					ObjectCloner oc = new ObjectCloner();
					oc.RcolModelClone(modelnames, false, false);
					simpe_pkg = oc.Package;
				} 
				catch (ScenegraphException) {}*/

				FileTable.FileIndex = oldfileindex;

				GraphBuilder gb = new GraphBuilder(pb, new EventHandler(GraphItemClick));
				gb.BuildGraph(simpe_pkg, fileindex);
				gb.FindUnused(orgpkg);
				
				WaitingScreen.Stop();
				TimeSpan runtime = DateTime.Now.Subtract(start);
				if (Helper.WindowsRegistry.HiddenMode)
					Text = "Runtime: "+runtime.TotalSeconds+" sek. = " + runtime.TotalMinutes+ " min.";
				ShowDialog();
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				WaitingScreen.Stop();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
