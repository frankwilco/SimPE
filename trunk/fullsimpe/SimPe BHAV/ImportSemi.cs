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
	/// Zusammenfassung für ImportSemi.
	/// </summary>
	public class ImportSemi : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btimport;
		private System.Windows.Forms.ComboBox cbsemi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel llscan;
		private System.Windows.Forms.CheckedListBox lbfiles;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.CheckBox cbfix;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox cbname;
		private System.ComponentModel.IContainer components;

		public ImportSemi()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("getting all SemiGlobal Groups");
			FileTable.FileIndex.Load();

			Interfaces.Scenegraph.IScenegraphFileIndexItem[] globs = FileTable.FileIndex.FindFile(Data.MetaData.GLOB_FILE, true);
			ArrayList names = new ArrayList();
			string max = " / "+globs.Length.ToString();
			int ct = 0;
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in globs) 
			{
				if (ct%17==0) WaitingScreen.UpdateMessage(ct.ToString()+max);
				ct++;

				SimPe.Plugin.NamedGlob glob = new SimPe.Plugin.NamedGlob();
				glob.ProcessData(item.FileDescriptor, item.Package);

				if (!names.Contains(glob.SemiGlobalName.Trim().ToLower())) 
				{
					cbsemi.Items.Add(glob);
					names.Add(glob.SemiGlobalName.Trim().ToLower());
				}
			}
			cbsemi.Sorted = true;

			WaitingScreen.Stop();
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImportSemi));
			this.btimport = new System.Windows.Forms.Button();
			this.cbsemi = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.llscan = new System.Windows.Forms.LinkLabel();
			this.lbfiles = new System.Windows.Forms.CheckedListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cbfix = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cbname = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btimport
			// 
			this.btimport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btimport.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btimport.Location = new System.Drawing.Point(437, 360);
			this.btimport.Name = "btimport";
			this.btimport.TabIndex = 1;
			this.btimport.Text = "Import";
			this.btimport.Click += new System.EventHandler(this.ImportFiles);
			// 
			// cbsemi
			// 
			this.cbsemi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbsemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsemi.Location = new System.Drawing.Point(16, 32);
			this.cbsemi.Name = "cbsemi";
			this.cbsemi.Size = new System.Drawing.Size(496, 21);
			this.cbsemi.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.TabIndex = 3;
			this.label1.Text = "Semi Global:";
			// 
			// llscan
			// 
			this.llscan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llscan.AutoSize = true;
			this.llscan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llscan.Location = new System.Drawing.Point(479, 56);
			this.llscan.Name = "llscan";
			this.llscan.Size = new System.Drawing.Size(33, 17);
			this.llscan.TabIndex = 4;
			this.llscan.TabStop = true;
			this.llscan.Text = "scan";
			this.llscan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ScanSemiGlobals);
			// 
			// lbfiles
			// 
			this.lbfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbfiles.CheckOnClick = true;
			this.lbfiles.HorizontalScrollbar = true;
			this.lbfiles.IntegralHeight = false;
			this.lbfiles.Location = new System.Drawing.Point(16, 96);
			this.lbfiles.Name = "lbfiles";
			this.lbfiles.Size = new System.Drawing.Size(496, 256);
			this.lbfiles.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 80);
			this.label2.Name = "label2";
			this.label2.TabIndex = 6;
			this.label2.Text = "Files:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(16, 352);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(76, 17);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "uncheck all";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// cbfix
			// 
			this.cbfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbfix.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbfix.Location = new System.Drawing.Point(256, 360);
			this.cbfix.Name = "cbfix";
			this.cbfix.Size = new System.Drawing.Size(176, 24);
			this.cbfix.TabIndex = 8;
			this.cbfix.Text = "Fix Package References";
			this.toolTip1.SetToolTip(this.cbfix, "Check this Option if you want to Fix references form TTABs and BHAVs in this pack" +
				"age to the imported SemiGLobals.");
			// 
			// cbname
			// 
			this.cbname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbname.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbname.Location = new System.Drawing.Point(120, 360);
			this.cbname.Name = "cbname";
			this.cbname.Size = new System.Drawing.Size(128, 24);
			this.cbname.TabIndex = 9;
			this.cbname.Text = "Add name Prefix";
			this.toolTip1.SetToolTip(this.cbname, "Check this Option if you want to Fix references form TTABs and BHAVs in this pack" +
				"age to the imported SemiGLobals.");
			// 
			// ImportSemi
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(522, 392);
			this.Controls.Add(this.cbname);
			this.Controls.Add(this.cbfix);
			this.Controls.Add(this.lbfiles);
			this.Controls.Add(this.llscan);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.cbsemi);
			this.Controls.Add(this.btimport);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ImportSemi";
			this.Text = "Import SemiGlobals";
			this.ResumeLayout(false);

		}
		#endregion

		SimPe.Interfaces.Files.IPackageFile package;
		SimPe.Interfaces.IWrapperRegistry reg;
		SimPe.Interfaces.IProviderRegistry prov;
		public void Execute(SimPe.Interfaces.Files.IPackageFile package, SimPe.Interfaces.IWrapperRegistry reg, SimPe.Interfaces.IProviderRegistry prov) 
		{
			this.package = package;
			this.reg = reg;
			this.prov = prov;

			btimport.Enabled = false;
			lbfiles.Items.Clear();
			this.ShowDialog();
		}

		private void ScanSemiGlobals(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			lbfiles.Items.Clear();
			this.btimport.Enabled = false;

			if (cbsemi.SelectedIndex<0) return;
			ArrayList loaded = new ArrayList();

			try 
			{
				SimPe.Plugin.NamedGlob glob = (SimPe.Plugin.NamedGlob)cbsemi.Items[cbsemi.SelectedIndex];
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileByGroup(glob.SemiGlobalGroup);
				
				lbfiles.Sorted = false;
				foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					if (item.FileDescriptor.Type == Data.MetaData.BHAV_FILE) 
					{
						SimPe.Plugin.Bhav bhav = new SimPe.Plugin.Bhav(null);
						bhav.ProcessData(item);
						item.FileDescriptor.Filename = item.FileDescriptor.TypeName.shortname + ": " + bhav.FileName + " ("+item.FileDescriptor.ToString()+")";
					} 
					else if (item.FileDescriptor.Type == Data.MetaData.STRING_FILE)  
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
						str.ProcessData(item);
						item.FileDescriptor.Filename = item.FileDescriptor.TypeName.shortname + ": " + str.FileName + " ("+item.FileDescriptor.ToString()+")";
					} 
					else if (item.FileDescriptor.Type == 0x42434F4E)  //BCON
					{
						SimPe.Plugin.Bcon bcon = new SimPe.Plugin.Bcon();
						bcon.ProcessData(item);
						item.FileDescriptor.Filename = item.FileDescriptor.TypeName.shortname + ": " + bcon.FileName + " ("+item.FileDescriptor.ToString()+")";
					}
					else 
					{
						item.FileDescriptor.Filename = item.FileDescriptor.ToString();
					}

					if (!loaded.Contains(item.FileDescriptor)) 
					{
						lbfiles.Items.Add(item, ((item.FileDescriptor.Type==Data.MetaData.BHAV_FILE) || (item.FileDescriptor.Type==0x42434F4E)));
						loaded.Add(item.FileDescriptor);
					}
				}
				lbfiles.Sorted = true;
				this.btimport.Enabled = (lbfiles.Items.Count>0);
			} 
			catch (Exception){}

			this.Cursor = Cursors.Default;
		}

		private void ImportFiles(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			//first find the highest Instance of a BHAV, BCON in the package
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.BHAV_FILE);
			uint maxbhavinst = 0x1000;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) if ((pfd.Instance<0x2000) && (pfd.Instance>maxbhavinst)) maxbhavinst = pfd.Instance;
			Hashtable bhavalias = new Hashtable();
			maxbhavinst++;
			
			//her is the BCOn part
			pfds = package.FindFiles(0x42434F4E);
			uint maxbconinst = 0x1000;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) if ((pfd.Instance<0x2000) && (pfd.Instance>maxbconinst)) maxbconinst = pfd.Instance;
			Hashtable bconalias = new Hashtable();
			maxbconinst++;


			ArrayList bhavs = new ArrayList();
			ArrayList ttabs = new ArrayList();	
			package.BeginUpdate();
			try 
			{
				for (int i=0; i<lbfiles.Items.Count; i++) 
				{
					if (!lbfiles.GetItemChecked(i)) continue;
					Interfaces.Scenegraph.IScenegraphFileIndexItem item = (Interfaces.Scenegraph.IScenegraphFileIndexItem)lbfiles.Items[i];
					SimPe.Packages.PackedFileDescriptor npfd = new SimPe.Packages.PackedFileDescriptor();
					npfd.Type = item.FileDescriptor.Type;
					npfd.Group = item.FileDescriptor.Group;
					npfd.Instance = item.FileDescriptor.Instance;
					npfd.SubType = item.FileDescriptor.SubType;
					npfd.UserData = item.Package.Read(item.FileDescriptor).UncompressedData;
					package.Add(npfd);

					if (npfd.Type == Data.MetaData.BHAV_FILE)
					{
						maxbhavinst++;
						npfd.Group = 0xffffffff;
						bhavalias[(ushort)npfd.Instance] = (ushort)maxbhavinst;
						npfd.Instance = maxbhavinst;

						SimPe.Plugin.Bhav bhav = new SimPe.Plugin.Bhav(prov.OpcodeProvider);
						bhav.ProcessData(npfd, package);
						if (cbname.Checked)	bhav.FileName = "["+cbsemi.Text+"] "+bhav.FileName;
						bhav.SynchronizeUserData();

						bhavs.Add(bhav);
					} 
					else if (npfd.Type == 0x42434F4E) //BCON
					{
						npfd.Instance = maxbconinst++;
						npfd.Group = 0xffffffff;
						bconalias[(ushort)npfd.Instance] = (ushort)npfd.Instance;

						SimPe.Plugin.Bcon bcon = new SimPe.Plugin.Bcon();
						bcon.ProcessData(npfd, package);
						if (cbname.Checked)	bcon.FileName = "["+cbsemi.Text+"] "+bcon.FileName;
						bcon.SynchronizeUserData();
					} 
					else if  (npfd.Type == 0x54544142) //TTAB
					{
						SimPe.Plugin.Ttab ttab = new SimPe.Plugin.Ttab(prov.OpcodeProvider);
						ttab.ProcessData(npfd, package);

						ttabs.Add(ttab);
					}	
				}

				if (cbfix.Checked) 
				{
					pfds = package.FindFiles(Data.MetaData.BHAV_FILE);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
					{
						SimPe.Plugin.Bhav bhav = new SimPe.Plugin.Bhav(prov.OpcodeProvider);
						bhav.ProcessData(pfd, package);

						bhavs.Add(bhav);
					}

					pfds = package.FindFiles(0x54544142);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
					{
						SimPe.Plugin.Ttab ttab = new SimPe.Plugin.Ttab(prov.OpcodeProvider);
						ttab.ProcessData(pfd, package);

						ttabs.Add(ttab);
					}
				}

				//Relink all SemiGlobals in imported BHAV's
				foreach (SimPe.Plugin.Bhav bhav in bhavs) 
				{
					foreach (SimPe.PackedFiles.Wrapper.Instruction i in bhav)
					{
						if (bhavalias.Contains(i.OpCode)) i.OpCode = (ushort)bhavalias[i.OpCode];
					}
					bhav.SynchronizeUserData();
				}

				//Relink all TTAbs
				foreach (SimPe.Plugin.Ttab ttab in ttabs) 
				{
                    foreach (SimPe.PackedFiles.Wrapper.TtabItem item in ttab)
					{
						if (bhavalias.Contains(item.Guardian)) item.Guardian = (ushort)bhavalias[item.Guardian];
						if (bhavalias.Contains(item.Action)) item.Action = (ushort)bhavalias[item.Action];
					}
					ttab.SynchronizeUserData();
				}
		
			} 
			finally 
			{
				package.EndUpdate();
			}
			this.Cursor = Cursors.Default;
			Close();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			for (int i=0; i<lbfiles.Items.Count; i++)
			{
				lbfiles.SetItemChecked(i, false);
			}
		}
	}
}
