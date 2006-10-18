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
using System.Data;
using SimPe.Events;
using Ambertation.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für MainForm.
	/// </summary>
	public partial class MainForm : System.Windows.Forms.Form
	{
		

		public MainForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

            SetupMainForm();
		}

        

		

		static string[] pargs;
		public static MainForm Global;
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			try 
			{
               /*Console.WriteLine(ExpansionLoader.Global.EPInstalled+" "+ExpansionLoader.Global.SPInstalled+" "+ExpansionLoader.Global.GameVersion);
                return;*/

				Commandline.CheckFiles();
			
				//do the real Startup
				pargs = args;
				//Application.EnableVisualStyles();
				Application.DoEvents();		
				Application.Idle += new EventHandler(Application_Idle);				

				if (!Commandline.ImportOldData()) return;

				if (!Commandline.Start(args))  
				{
					Helper.WindowsRegistry.UpdateSimPEDirectory();
					Global = new MainForm();
					Application.Run(Global);

                    
					Helper.WindowsRegistry.Flush();
					Helper.WindowsRegistry.Layout.Flush();
                    //ExpansionLoader.Global.Flush(); SimPE should not edit this File!
				}
			} 
			catch (Exception ex) 
			{
				try 
				{
					Helper.ExceptionMessage("SimPE will shutdown due to an unhandled Exception.", ex);
				} 
				catch (Exception ex2) 
				{
					
					MessageBox.Show("SimPE will shutdown due to an unhandled Exception.\n\nMessage: "+ex2.Message);
				}
			}

			try 
			{
				SimPe.Packages.StreamFactory.UnlockAll();
				SimPe.Packages.StreamFactory.CloseAll(true);
				SimPe.Packages.StreamFactory.CleanupTeleport();
			} 
			catch{}
		}

		private void ClosingForm(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = !this.ClosePackage();
			if (!e.Cancel) 
			{
				TreeBuilder.StopAll();
				Wait.Stop(); Wait.Bar = null;

                StoreLayout();
			}
		}

        

		#region Custom Attributes
		LoadedPackage package;
		TreeBuilder treebuilder;
		ViewFilter filter;
		TreeNodeTag lastusedtnt;
		TreeView lasttreeview;
		PluginManager plugger;
		ResourceLoader resloader;
		RemoteHandler remote;
		#endregion

		#region File Handling
		/// <summary>
		/// Commands called before a File is loaded
		/// </summary>
		void BeforeFileLoad(LoadedPackage sender, FileNameEventArg e)
		{
			if (!ClosePackage()) e.Cancel=true;
		}

		/// <summary>
		/// Commands that are called after the load
		/// </summary>
		/// <param name="sender"></param>
		void AfterFileLoad(LoadedPackage sender)
		{
			sender.UpdateProviders();	
			ShowNewFile(true);		
		}	
	
		/// <summary>
		/// Cammans needed before a File is saved
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BeforeFileSave(LoadedPackage sender, FileNameEventArg e)
		{
			if (!resloader.Flush()) e.Cancel=true;
		}

		/// <summary>
		/// Commands neede after a File Save
		/// </summary>
		/// <param name="sender"></param>
		private void AfterFileSave(LoadedPackage sender)
		{
			UpdateFileInfo();
			package.UpdateProviders();

			if (lasttreeview!=null) 
			{
				System.Windows.Forms.TreeViewEventArgs tvea = new TreeViewEventArgs(this.lasttreeview.SelectedNode, TreeViewAction.ByMouse);
				SelectResourceNode(this.lasttreeview, tvea);
			}
		}

		/// <summary>
		/// Called, whenever the Index of a Package was changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangedActiveIndex(object sender, EventArgs e)
		{
			//ShowNewFile();
			SelectResource(this.lv, false, true);
		}

		/// <summary>
		/// Called, whenever the Index of a Package was changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddedRemovedIndexResource(object sender, EventArgs e)
		{			
			UpdateFileIndex();
		}

		/// <summary>
		/// This Method displays the content of a File
		/// </summary>
		void UpdateFileInfo()
		{
			if (package.Loaded) Text = "SimPe - "+package.FileName;
			UpdateMenuItems();
		}

		/// <summary>
		/// Selects the <see cref="TreeNode"/> that has the same Name as the passed <see cref="TreeNodeTag"/>
		/// </summary>
		/// <param name="nodes">List of TreeNode Object</param>
		/// <param name="tnt"><see cref="TreeNodeTag"/> that should be used to find the matching TreeNode</param>
		/// <returns>true if a selection was made</returns>
		/// <remarks>also sets <see cref="lastusedtnt"/> to the selected Node</remarks>
		bool ReSelectTreeNode(TreeNodeCollection nodes, TreeNodeTag tnt)
		{
			if (this.lasttreeview==null || tnt==null || nodes==null) return false;

			foreach (TreeNode node in nodes)	
			{		
				if (node.Tag is TreeNodeTag)				
					if (((TreeNodeTag)node.Tag).Name == tnt.Name) 
					{
						node.TreeView.SelectedNode = node;
						this.lastusedtnt = (TreeNodeTag)node.Tag;
						return true;
					}

				if (ReSelectTreeNode(node.Nodes, tnt)) return true;
			}
			
			return false;
		}

        delegate bool ReSelectTreeNodeHandler(TreeNodeCollection nodes, TreeNodeTag tnt);
		
        void InvokeReSelectTreeNode(TreeNodeTag tnt)
        {
            if (this.lasttreeview.InvokeRequired)
                this.lasttreeview.Invoke(new ReSelectTreeNodeHandler(ReSelectTreeNode), new object[] { lasttreeview.Nodes, tnt });
            else
                ReSelectTreeNode(this.lasttreeview.Nodes, tnt);
        }

		TreeNodeTag reselecttnt;
		SimPe.Collections.PackedFileDescriptors reselectlist;
		private void TreeBuilder_Finished(object sender, EventArgs e)
		{
			if (sender == null) return;

			if (sender is TreeBuilderBase)
			{
				if (reselecttnt!=null && lasttreeview!=null) 
				{
					reselecttnt.Refresh(lv);
                    InvokeReSelectTreeNode(reselecttnt);				
				}
				
				reselecttnt = null;
			} 
			else if (sender is ResourceListerBase)
			{
				if (reselectlist!=null) 
				{
					lock (lv)
					{
						foreach (ListViewItem lvi in lv.Items) 
						{
							if (lvi==null) continue;
							if (lvi.Tag == null) continue;
							ListViewTag lvt = (ListViewTag)lvi.Tag;
							if (reselectlist.Contains(lvt.Resource.FileDescriptor)) lvi.Selected = true;
						}

						reselectlist.Clear();
					}
				}
			}

		}

		/// <summary>
		/// When adding removing a Resource, the ResourceList and ResourceTree need to be Updated.
		/// That is done in this Method
		/// </summary>
		void UpdateFileIndex()
		{			
			if (reselectlist==null) reselectlist = new SimPe.Collections.PackedFileDescriptors();
			foreach (ListViewItem lvi in lv.Items) 
			{
				ListViewTag lvt = (ListViewTag)lvi.Tag;
				if (lvi.Selected)
					reselectlist.Add(lvt.Resource.FileDescriptor);									
			}

			 //the TreeBuilder_Finished Event Handler is going to be called when ShowNewFile() finishes.
			reselecttnt = lastusedtnt;			
			ShowNewFile(false);							

			
			
		}



		/// <summary>
		/// This Method displays the content of a File
		/// </summary>
		void ShowNewFile(bool autoselect)
		{
			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
			tvInstance.Nodes.Clear();
			tvGroup.Nodes.Clear();
			tvType.Nodes.Clear();

			if (!Helper.WindowsRegistry.AsynchronLoad) lv.BeginUpdate();
			TreeBuilder.ClearListView(lv);

			
			SetupActiveResourceView(autoselect);	
			package.UpdateRecentFileMenu(this.miRecent);			

			UpdateFileInfo();
			if (!Helper.WindowsRegistry.AsynchronLoad) lv.EndUpdate();
		}

		

		/// <summary>
		/// Close the currently opened File
		/// </summary>
		/// <returns>true, if the File was closed</returns>
		bool ClosePackage()
		{
			if (!resloader.Clear()) return false;
			if (!package.Close()) return false;

			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
			return true;
		}
		#endregion

		

		

		#region ResourceView Toolbar
		/// <summary>
		/// Setup the Buttons on the ToolBar to connect to the TreeView
		/// </summary>
		void SetupResourceViewToolBar()
		{
			TreeBuilderList.TreeBuilder = this.treebuilder;
			TreeBuilderList.TreeBuilder.Finished += new EventHandler(TreeBuilder_Finished);
			this.biGroupList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.GroupView), tvGroup);
			this.biInstanceList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.InstanceView), tvInstance);
			this.biTypeList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.TypeView), tvType);			

			foreach (ToolStripItem c in tbResource.Items) 
			{
				if (c is ToolStripButton) 
				{
					ToolStripButton bi = (ToolStripButton)c;					
					TreeBuilderList tbl = (TreeBuilderList)bi.Tag;

					tbl.TreeView.Visible = bi.Checked;
					tbl.TreeView.BorderStyle = BorderStyle.None;
					tbl.TreeView.Top = this.tbResource.Height;
					tbl.TreeView.Left = 0;
					tbl.TreeView.Width = dcResource.ClientRectangle.Width;
					tbl.TreeView.Height = dcResource.ClientRectangle.Height - tbl.TreeView.Top;

					tbl.TreeView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
				}
			}
		}

		/// <summary>
		/// Choose one special View
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		internal void SelectResourceView(object sender, System.EventArgs e)
		{				
			if (sender is ToolStripButton) 
			{
				ToolStripButton setbi = (ToolStripButton)sender;
				setbi.Checked = true;
			}

			foreach (ToolStripItem c in tbResource.Items) 
			{
				if ((c is ToolStripButton) && (c!=sender))
				{
					ToolStripButton bi = (ToolStripButton)c;
					bi.Checked = false;
				}
			}

			SetupActiveResourceView(true);
		}

		/// <summary>
		/// Display the content of the current package in the choosen TreeView
		/// </summary>
		void SetupActiveResourceView(bool autoselect)
		{
			foreach (ToolStripItem c in tbResource.Items) 
			{
				if (c is ToolStripButton) 
				{
					ToolStripButton bi = (ToolStripButton)c;					
					TreeBuilderList tbl = (TreeBuilderList)bi.Tag;

					tbl.TreeView.Visible = bi.Checked;
					if (bi.Checked) 
					{
						if (tbl.TreeView.Nodes.Count==0)
						{							
							tbl.Generate(autoselect);							
							if (tbl.TreeView.Nodes.Count>0) lastusedtnt = (TreeNodeTag)tbl.TreeView.Nodes[0].Tag;							
						}

						this.SelectResourceNode(tbl.TreeView, new TreeViewEventArgs(tbl.TreeView.SelectedNode, TreeViewAction.ByMouse));
						//special Treatment for Neighborhood Files
						if (Helper.IsNeighborhoodFile(package.FileName) && tbl.TreeView.Nodes.Count>0) tvType.SelectedNode = tbl.TreeView.Nodes[0];
					}
				}
			}
		}
		#endregion

		#region Drag&Drop

		/// <summary>
		/// Returns the Names of the Dropped Files
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		string[] DragDropNames(System.Windows.Forms.DragEventArgs e) 
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

			if ( a != null )
			{
				string[] res = new string[a.Length];				
				for (int i=0; i<a.Length; i++) res[i] = a.GetValue(i).ToString();
				return res;
			}

			return new string[0];
		}

		/// <summary>
		/// Returns the Effect that should be displayed based on the Files
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		DragDropEffects DragDropEffect(string[] names)
		{
			if (names.Length==0) return DragDropEffects.None;

			ExtensionType et = ExtensionProvider.GetExtension(names[0]);
			if (names.Length==1) 
			{
				if (et == ExtensionType.Package || et == ExtensionType.DisabledPackage || et == ExtensionType.ExtrackedPackageDescriptor) 
					return DragDropEffects.Move;
				else if (et == ExtensionType.ExtractedFile || et == ExtensionType.ExtractedFileDescriptor)
					return DragDropEffects.Copy;
			} 
				
			return DragDropEffects.Copy;								
		}

		/// <summary>
		/// Someone tries to throw a File
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragEnterFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
			{
				try
				{
					e.Effect = DragDropEffect(DragDropNames(e));					
				} 
				catch (Exception)
				{
				}
				
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// <summary>
		/// A File has been dropped
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragDropFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				package.LoadOrImportFiles(DragDropNames(e), true);				
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}

		}
		#endregion

		
		

		void Activate_miOpen(object sender, System.EventArgs e)
		{
			ofd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				package.LoadFromFile(ofd.FileName);
			}
		}

		void SelectResourceNode(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			lastusedtnt = null;
			if(sender==null) return;
			lasttreeview = (TreeView)sender;
			
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;
			if (!(e.Node.Tag is TreeNodeTag)) return;

			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));			
			lastusedtnt = (TreeNodeTag)e.Node.Tag;
			lastusedtnt.Refresh(lv);		
		}

		private void SetFilter(object sender, System.EventArgs e)
		{
			try 
			{
				filter.Instance = Convert.ToUInt32(tbInst.Text, 16);
				filter.FilterInstance = (tbInst.Text.Trim()!="");
			} 
			catch 
			{
				filter.FilterInstance = false;
			}

			try 
			{
				filter.Group = Convert.ToUInt32(tbGrp.Text, 16);
				filter.FilterGroup = (tbGrp.Text.Trim()!="");
			} 
			catch 
			{
				filter.FilterGroup = false;
			}
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);
		}        
		
		//int ct = 0;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e">null to indicate, that his Method was called internal, and should NOT open a Resource!</param>
		private void SelectResource(object sender, System.EventArgs e)
		{            
			//ct++; this.Text=(ct/2).ToString();	//was used to test for a Bug related to opened Docks
			if (lv.SelectedItems.Count<=2) SelectResource(sender, false, false);                
			else DereferedResourceSelect();
		}

		private void Activate_miUpdate(object sender, System.EventArgs e)
		{
			About.ShowUpdate(true);
		}

		private void Activate_miAbout(object sender, System.EventArgs e)
		{
			About.ShowAbout();
		}

		private void Activate_miTutorials(object sender, System.EventArgs e)
		{
			About.ShowTutorials();
		}

		private void dc_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Middle && Helper.WindowsRegistry.FirefoxTabbing && dc.SelectedPage!=null) 
			{
				resloader.CloseDocument(dc.SelectedPage);
			}
		}		

		bool pressedalt;
		private void ResourceListKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			pressedalt = e.Alt;
		}

		private void ResourceListKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			pressedalt = false;
			if (e.KeyCode==Keys.A && e.Control) 
			{
				lv.Tag = true;
				lv.BeginUpdate();
				foreach (ListViewItem lvi in lv.Items) lvi.Selected = true;
				lv.EndUpdate();
				lv.Tag = null;
			}

			if (e.KeyCode==Keys.H && e.Control && e.Alt && e.Shift) 
			{
				Hidden f = new Hidden();
				f.ShowDialog();
			}
		}

		private void Activate_miNew(object sender, System.EventArgs e)
		{
			if (this.ClosePackage()) 
			{
				package.LoadFromPackage(SimPe.Packages.GeneratableFile.CreateNew());
			}
		}

		bool frommiddle = false;
		
		/// <summary>
		/// Selected Resource did change
		/// </summary>
		/// <param name="sender">The ResourceListView</param>
		/// <param name="fromdbl">Select was issued by a doubleClick</param>
		/// <param name="fromchg">Select was issued by an internal Change of a pfd Resource</param>
		/// <remarks>Uses the frommiddle field to determin if the middle Button was clicked</remarks>
        private void SelectResource(object sender, bool fromdbl, bool fromchg)
        {
            bool fm = frommiddle;
            if (!Helper.WindowsRegistry.FirefoxTabbing) fm = true;

            ResourceListView lv = (ResourceListView)sender;


            if (lv.SelectedItems.Count == 0)
            {
                plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
                return;
            }

            SimPe.Events.ResourceEventArgs res = new SimPe.Events.ResourceEventArgs(package);
            bool goon = (!fromdbl && !Helper.WindowsRegistry.SimpleResourceSelect && !frommiddle) || (lv.SelectedItems.Count > 1);

            lock (ResourceListView.SYNC)
            {
                try
                {
                    foreach (ListViewItem lvi in lv.SelectedItems)
                    {
                        ListViewTag lvt = (ListViewTag)lvi.Tag;
                        if (lvt == null) continue;

                        res.Items.Add(new SimPe.Events.ResourceContainer(lvt.Resource));

                        if (goon) continue;

                        //only the first one get's added to the Plugin View				
                        if ((lv.SelectedItems.Count == 1 && !fromchg && lv.Tag == null))
                            resloader.AddResource(lvt.Resource, !fm);

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

            //notify the Action Tools that the selection was changed
            plugger.ChangedGuiResourceEventHandler(this, res);
            lv.Focus();
        }

		private void ShowPreferences(object sender, System.EventArgs e)
		{
			OptionForm of = new OptionForm();
			of.NewTheme +=new ChangedThemeEvent(ChangedTheme);
			of.ResetLayout += new EventHandler(ResetLayout);
			of.UnlockDocks += new EventHandler(UnLockDocks);
			of.LockDocks += new EventHandler(LockDocks);

			System.Drawing.Icon icon = null;
			if (miPref.Image is System.Drawing.Bitmap)
				icon = System.Drawing.Icon.FromHandle(((System.Drawing.Bitmap)miPref.Image).GetHicon());

			of.Execute(icon);	
			package.UpdateRecentFileMenu(this.miRecent);
		}

		
		

		private void ClosedToolPlugin(object sender, PackageArg pk)
		{
			try 
			{
				if (pk.Result.ChangedPackage) package.LoadFromPackage((SimPe.Packages.GeneratableFile)pk.Package);	
				if (pk.Result.ChangedFile) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = new SimPe.Plugin.FileIndexItem(pk.FileDescriptor, pk.Package);
					resloader.AddResource(fii, true);															
					remote.FireLoadEvent(fii);
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		
		private void CreateNewDocumentContainer(object sender, System.EventArgs e)
		{
            DockPanel doc = new DockPanel();
			doc.Text = "Plugin";
            manager.DockPanel(doc, DockStyle.Bottom);
						
			
			doc.OpenFloating();
			doc.Closing += new DockPanel.ClosingHandler(CloseAdditionalDocContainer);
			doc.TabImage = dcPlugin.TabImage;
			doc.Text = dcPlugin.Text;
			doc.TabText = dcPlugin.TabText;
			doc.AutoScrollMinSize = dcPlugin.AutoScrollMinSize;
			

			TD.SandDock.TabControl dc = new TD.SandDock.TabControl();
			dc.Manager = this.dc.Manager;
			dc.Text = "Plugin";
			dc.Parent = doc;
			dc.Dock = DockStyle.Fill;
			
		}

        private void CloseAdditionalDocContainer(object sender, DockPanel.DockPanelClosingEvent e)
		{
			if (sender is TD.SandDock.DockControl) 
			{
				TD.SandDock.DockControl doc = (TD.SandDock.DockControl)sender;
				if (doc.Controls[0] is TD.SandDock.TabControl) 
				{
					TD.SandDock.TabControl dc = (TD.SandDock.TabControl)doc.Controls[0];
					bool closed = true;
					for (int i=dc.TabPages.Count-1; i>=0; i--) 
					{						
						TD.SandDock.DockControl d = dc.TabPages[i];
						if (!resloader.CloseDocument(d)) closed = false;;
					}

					e.Cancel = !closed;
				}
			}

		}

		private void Activate_miNoMeta(object sender, System.EventArgs e)
		{
			ToolStripMenuItem mi = (ToolStripMenuItem)sender;
			mi.Checked = !mi.Checked;

			Helper.WindowsRegistry.LoadMetaInfo = !mi.Checked;
		}

		private void Activate_miFileNames(object sender, System.EventArgs e)
		{
			ToolStripMenuItem mi = (ToolStripMenuItem)sender;
			mi.Checked = !mi.Checked;

			Helper.WindowsRegistry.DecodeFilenamesState = mi.Checked;
		}

		private void Activate_miExit(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Activate_miRunSims(object sender, System.EventArgs e)
		{
			
			if (!System.IO.File.Exists(SimPe.PathProvider.Global.SimsApplication)) return;

			System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = SimPe.PathProvider.Global.SimsApplication;
			if (Helper.WindowsRegistry.EnableSound) 
			{
				p.StartInfo.Arguments = "-w -r800x600 -skipintro -skipverify";
			} 
			else 
			{
				p.StartInfo.Arguments = "-w -r800x600 -nosound -skipintro -skipverify";
			}
			p.Start();
		}

		private void Activate_miSave(object sender, System.EventArgs e)
		{
			package.Save();
		}

		private void Activate_miSaveAs(object sender, System.EventArgs e)
		{
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			sfd.FileName = package.FileName;
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				package.Save(sfd.FileName, false);
				package.UpdateRecentFileMenu(this.miRecent);
			}
		}

		private void Activate_miClose(object sender, System.EventArgs e)
		{
			if (ClosePackage())
			{
				SimPe.Packages.StreamFactory.CloseAll(false);
				this.ShowNewFile(true);
			}							
		}

		private void SelectResourceDBClick(object sender, System.EventArgs e)
		{			
			SelectResource(sender, true, false);
		}				

		
		private void SortResourceListClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
            ResourceColumnSorter sorter = ((ResourceListView)sender).ListViewItemSorter as ResourceColumnSorter;
            if (sorter == null) return;

            if (sorter.CurrentColumn == e.Column)
                sorter.Asc=!sorter.Asc;
            else
                sorter.Asc = true;

            sorter.CurrentColumn = e.Column;
            ((ResourceListView)sender).Sort();			
		}

		private void SelectResource(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((e.Button == MouseButtons.Middle) || (e.Button == MouseButtons.Left && pressedalt))
			{
				ListViewItem lvi = lv.GetItemAt(e.X, e.Y);
				if (lvi!=null) 
				{
					lv.BeginUpdate();
					for (int i=lv.SelectedItems.Count-1; i>=0; i--)  lv.SelectedItems[i].Selected=false;

					frommiddle = true;
					lvi.Selected = true;
					lv.EndUpdate();
					frommiddle = false;
				}
			}
		}

		private void rh_LoadedResource(object sender, ResourceEventArgs es)
		{
			treebuilder.DeselectAll(lv);
			foreach (SimPe.Events.ResourceContainer e in es) 
			{
				if (e.HasResource) treebuilder.SelectResource(lv, e.Resource);	
			}
		}

        private void Activate_miOpenInEp(object sender, System.EventArgs e)
        {
            ToolStripMenuItem mi = sender as ToolStripMenuItem;
            if (mi != null)
            {
                ExpansionItem ei = mi.Tag as ExpansionItem;
                if (ei != null)
                {
                    ofd.InitialDirectory = System.IO.Path.Combine(ei.InstallFolder, "TSData\\Res");
                    ofd.FileName = "";
                    this.Activate_miOpen(sender, e);
                }
            }
            
            
        }

		private void Activate_miOpenSimsRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(SimPe.PathProvider.Global[Expansions.BaseGame].InstallFolder, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenDownloads(object sender, System.EventArgs e)
		{
            ofd.InitialDirectory = System.IO.Path.Combine(PathProvider.Global.SimSavegameFolder, "Downloads");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void SetRcolNameFilter(object sender, System.EventArgs e)
		{
			filter.FilterGroup = false;
			try 
			{
				string name = Hashes.StripHashFromName(tbRcolName.Text);
				filter.Instance = Hashes.InstanceHash(name);
				//filter.Group = Hashes.GroupHash(this.tbRcolName.Text);
				filter.FilterInstance = (name.Trim()!="");
				//filter.FilterGroup = filter.FilterInstance;
			} 
			catch 
			{
				filter.FilterInstance = false;				
			}
			
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);
		}

		private void tbRcolName_SizeChanged(object sender, System.EventArgs e)
		{
			if (tbRcolName.Right+8 > tbRcolName.Parent.Width) 
			{
				tbRcolName.Width = tbRcolName.Parent.Width - tbRcolName.Left - 8;
				this.cbsemig.Width = tbRcolName.Width;

				xpLinkedLabelIcon2.Left = tbRcolName.Right - xpLinkedLabelIcon2.Width;
				xpLinkedLabelIcon3.Left = xpLinkedLabelIcon2.Left;
			}
		}

		private void SetSemiGlobalFilter(object sender, System.EventArgs e)
		{
			filter.FilterInstance = false;
			try 
			{
				if (this.cbsemig.SelectedItem is Data.SemiGlobalAlias) 
				{
					Data.SemiGlobalAlias sga = (Data.SemiGlobalAlias)this.cbsemig.SelectedItem;
					if (sga!=null) 
					{
						string name = Hashes.StripHashFromName(tbRcolName.Text);
						filter.Group = sga.Id;					
						filter.FilterGroup = (cbsemig.Text.Trim()!="");					
					}
				} 
				else filter.FilterGroup = false;
			} 
			catch 
			{
				filter.FilterGroup = false;				
			}
			
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);		
		}

		private void sdm_DockControlActivated(object sender, TD.SandDock.DockControlEventArgs e)
		{
			if (!e.DockControl.Collapsed) lv.BringToFront();
		}

		#region Idle Actions
		static DateTime lastgc = DateTime.Now;
		static TimeSpan waitgc = new TimeSpan(0, 0, 15, 0, 0);
		static DateTime lastfi = DateTime.Now;
		static TimeSpan waitfi = new TimeSpan(0, 2, 10, 0, 0);
		private static void Application_Idle(object sender, EventArgs e)
		{
			/*DateTime now = DateTime.Now;
			if (now.Subtract(lastgc) > waitgc) 
			{
				GC.Collect();
				lastgc = now;
			}

			if (now.Subtract(lastfi) > waitfi) 
			{
				try 
				{
					FileTable.FileIndex.Load();
				} 
				catch {}
				lastfi = now;
			}*/
		}
		#endregion

		#region Dereffered ResourceSelection
		byte rst = 0;
		void DereferedResourceSelect()
		{
			rst = 0;
			resourceSelectionTimer.Enabled = true;
		}

		private void resourceSelectionTimer_Tick(object sender, System.EventArgs e)
		{
			rst++;
			if (rst==2) 
			{
				this.resourceSelectionTimer.Enabled = false;
				SelectResource(lv, false, false);
			}
		}
		#endregion

		private void Activate_miSaveCopyAs(object sender, System.EventArgs e)
		{
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);

			sfd.FileName = package.FileName;
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				SimPe.Packages.GeneratableFile gf = (SimPe.Packages.GeneratableFile)package.Package.Clone();
				gf.Save(sfd.FileName);	
				//package.UpdateRecentFileMenu(this.miRecent);
			}
		}

		private void Activate_biReset(object sender, System.EventArgs e)
		{
			ResetLayout(null, null);
            
            
		}

		void MakeFloatable(Ambertation.Windows.Forms.DockPanel dw, bool fl)
		{
            dw.ShowCloseButton = fl;
            dw.ShowCollapseButton = fl;
            dw.CanUndock = fl;
            dw.CanResize = fl;
		}

		void MakeFloatable(bool fl)
		{
            manager.SuspendLayout();
			foreach (object o in this.miWindow.DropDownItems)
			{
                ToolStripMenuItem mi = o as ToolStripMenuItem;
                if (mi == null) continue;
				if (mi.Tag==null) continue;
				DockPanel dw = mi.Tag as DockPanel;

				MakeFloatable(dw, fl);
			}

			MakeFloatable(this.dcFilter, fl);
			MakeFloatable(this.dcResource, fl);
			MakeFloatable(this.dcPlugin, fl);

			this.dcPlugin.AllowClose = false;
            manager.ResumeLayout();
		}

		private void UnLockDocks(object sender, EventArgs e)
		{
			MakeFloatable(true);
		}

		private void LockDocks(object sender, EventArgs e)
		{
			MakeFloatable(false);
		}		

        private void dcFilter_SizeChanged(object sender, EventArgs e)
        {
            cbsemig.Width = dcFilter.Width - 24;
        }

        void menuBarItem5_VisibleChanged(object sender, EventArgs e)
        {
            this.mbiTopics.Visible = mbiTopics.DropDownItems.Count > 0;
        }
		
	}
			
}
