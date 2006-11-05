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
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// This class can be used to Load a Resource into the Plugin Area(s)
	/// </summary>
	public class ResourceLoader
	{
		TD.SandDock.TabControl dc;
		LoadedPackage pkg;

		/// <summary>
		/// keeps a list of loaded Resource/Wrappers
		/// </summary>
		Hashtable loaded;

		/// <summary>
		/// keeps a list of Resources that can only handle a single Instance
		/// </summary>
		Hashtable single;

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="dc">The document Container that receives the Plugins</param>
		/// <param name="lp">The Container for the currently loaded package</param>
		public ResourceLoader(TD.SandDock.TabControl dc, LoadedPackage lp)
		{
			this.dc = dc;
			pkg = lp;
			loaded = new Hashtable();
			single = new Hashtable();
		}		

		/// <summary>
		/// Load the assigned Wrapper, and initiate the Resource
		/// </summary>
		/// <param name="fii"></param>
		/// <returns></returns>
		public SimPe.Interfaces.Plugin.IFileWrapper GetWrapper(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
            if (fii == null) return null;

			//try by Type
			SimPe.Interfaces.Plugin.IFileWrapper wrapper = 
				(SimPe.Interfaces.Plugin.IFileWrapper)FileTable.WrapperRegistry.FindHandler(fii.FileDescriptor.Type);

			//try by Signature
			if (wrapper==null) 
			{
				SimPe.Interfaces.Files.IPackedFile pf = pkg.Package.Read(fii.FileDescriptor);
				wrapper = FileTable.WrapperRegistry.FindHandler(pf.GetUncompressedData(0x40));
			}

			return wrapper;
		}

		/// <summary>
		/// Load the assigned Wrapper, and initiate the Resource
		/// </summary>
		/// <param name="fii"></param>
		/// <returns></returns>
		public void LoadWrapper(ref SimPe.Interfaces.Plugin.IFileWrapper wrapper, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
			if (wrapper!=null) 
			{
				try 
				{
					wrapper = wrapper.Activate();
					wrapper.ProcessData(fii.Package.FindExactFile(fii.FileDescriptor), fii.Package);			
				} 
				catch(Exception ex) 
				{
					Helper.ExceptionMessage(ex);
				}
			}
		}

		/// <summary>
		/// The resource that should be added to the Container
		/// </summary>
		/// <param name="fii"></param>
		/// <param name="overload">Replace the currently active Document Tab with the new one</param>
		/// <returns>true, if the Plugin was loaded</returns>
		public bool AddResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, bool overload)
		{
			return AddResource(fii, false, overload);
		}

		/// <summary>
		/// If the Resource was already Loaded, this Method Wil Focus it and optional Reload the Content
		/// </summary>
		/// <param name="fii"></param>
		/// <param name="reload"></param>
		/// <returns>true, if a Document was highlighted</returns>
		bool FocusResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, bool reload)
		{
			//already in List
			if (SelectResource(fii)) 
			{
				if (reload) 
				{
					TD.SandDock.DockControl doc = this.GetDocument(fii);
					if (doc==null) return false;

					SimPe.Interfaces.Plugin.IFileWrapper wrp = (SimPe.Interfaces.Plugin.IFileWrapper)doc.Tag;
					if (UnloadWrapper(wrp)) 
					{
						wrp.ProcessData(fii);
						wrp.RefreshUI();
					}
				}
				return true;
			}

			return false;
		}

		/// <summary>
		/// Unload Documents handled by the Same Wrapper when the Wrapper 
		/// is not able to present Multiple Resources
		/// </summary>
		/// <param name="wrapper"></param>
		/// <returns>true, if the Wrapper was unloaded or allows Multiple Instances</returns>
		bool UnloadSingleInstanceWrappers(SimPe.Interfaces.Plugin.IFileWrapper wrapper, ref bool overload)
		{
			if (wrapper==null) return false;
			
			if (!wrapper.AllowMultipleInstances) 
			{
				string id = wrapper.GetType().ToString();
				if (single.ContainsKey(id)) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem oldfii = (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)single[id];
					if (!this.CloseDocument(oldfii)) return false;
					single.Remove(id);
					overload = false;
				}
			}

			return true;
		}

		/// <summary>
		/// Add the passed Wrapper (it's UI) as a new Document
		/// </summary>
		/// <param name="fii"></param>
		/// <param name="wrapper"></param>
		/// <param name="overload">Replace the currently active Document Tab with the new one</param>
		/// <returns>true, if the Resource was Presented succesfull</returns>
		bool Present(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Interfaces.Plugin.IFileWrapper wrapper, bool overload)
		{
			if (wrapper!=null) 
			{
				if (wrapper.FileDescriptor==null) return false;
				if (wrapper.Package==null) return false;

				//do not open Wrappers for deleted Descriptors
				if (wrapper.FileDescriptor!=null) if (wrapper.FileDescriptor.MarkForDelete) return false;

				TD.SandDock.DockControl doc = null;
				bool add = !overload;
				if (overload) doc = dc.SelectedPage;				
				if (doc == null) {
					add = true; 
					doc = new TD.SandDock.TabPage(); 
					doc.AllowClose=true; 
					doc.AllowDockCenter=true;
				}
				else if (!this.UnloadWrapper(doc)) return false;

				doc.Text = wrapper.ResourceName;
				doc.Tag = wrapper;		
				
				wrapper.FileDescriptor.Deleted += new EventHandler(DeletedDescriptor);
				wrapper.FileDescriptor.ChangedUserData += new SimPe.Events.PackedFileChanged(FileDescriptor_ChangedUserData);

				try 
				{					
					doc.Text = wrapper.ResourceName;
					

					Control pan = wrapper.UIHandler.GUIHandle; 
					if (pan!=null) 
					{
						
						doc.FloatingSize = pan.Size;
						doc.AllowFloat = true;	
						doc.AllowDockBottom = true;
						doc.AllowDockLeft = true;
						doc.AllowDockRight = true;
						doc.AllowDockTop = true;
						doc.AllowDockCenter = true;
						doc.AllowCollapse = true;

						if (add) dc.TabPages.Add(doc);
						pan.Parent = doc;
						pan.Left = 0;
						pan.Top = 0;
						pan.Width = doc.ClientRectangle.Width;
						pan.Height = doc.ClientRectangle.Height;
						pan.Dock = System.Windows.Forms.DockStyle.Fill;
						pan.Visible = true;

						//pan.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

						
						if (add) doc.Closing += new TD.SandDock.DockControlClosingEventHandler(CloseResourceDocument);
						dc.SelectedPage = (TD.SandDock.TabPage)doc;
						doc.Manager = dc.Manager;												
						doc.LayoutSystem.LockControls = false;						
						
						
						loaded[fii] = doc;

						if (!wrapper.AllowMultipleInstances) single[wrapper.GetType().ToString()] = fii;
						wrapper.LoadUI();
					}
					
					return true;
				} 
				catch(Exception ex) 
				{
					Helper.ExceptionMessage(ex);
				}
			}

			return false;
		}

		/// <summary>
		/// The resource that should be added to the Container
		/// </summary>
		/// <param name="fii"></param>
		/// <param name="reload">
		/// when the Resource is already visible, and this Argument is true, the Gui 
		/// will be reloaded. This means, that all unsaved changes will get lost!
		/// </param>
		/// <param name="overload">Replace the currently active Document Tab with the new one</param>
		/// <returns>true, if the Plugin was loaded</returns>
		public bool AddResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, bool reload, bool overload)
		{
			
			if (!pkg.Loaded) return false;

			//already Loaded?
			if (FocusResource(fii, reload)) return true;

			//only one File at a Time?
			if (!Helper.WindowsRegistry.MultipleFiles) this.Clear();

			//get the Wrapper
			SimPe.Interfaces.Plugin.IFileWrapper wrapper = GetWrapper(fii);

			//unload if only one instance can be loaded
			if (!UnloadSingleInstanceWrappers(wrapper, ref overload)) return false;

			//load the new Data into the Wrapper
			LoadWrapper(ref wrapper, fii);

			//Present the passed Wrapper
			return Present(fii, wrapper, overload);
		}

		/// <summary>
		/// Selects the Document that shows the selected Resource
		/// </summary>
		/// <param name="fii">The Resource you want to select</param>
		/// <returns>true, if that resource was found</returns>
		public bool SelectResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
            if (fii == null) return false;

			if (loaded.ContainsKey(fii))
			{
				TD.SandDock.DockControl doc = (TD.SandDock.DockControl)loaded[fii];					

				if (doc.Parent == null ) return true;
				if (doc.Parent is TD.SandDock.TabControl)
					((TD.SandDock.TabControl)doc.Parent).SelectedPage = (TD.SandDock.TabPage)doc;
				else 
					doc.LayoutSystem.SelectedControl = doc;
				

				return true;
			}

			return false;
		}

		/// <summary>
		/// Returns the Document that contains a given Resource
		/// </summary>
		/// <param name="fii">The Resource you want to select</param>
		/// <returns>the Document that contains the PluginView for the passed Resource (null if none)</returns>
		public TD.SandDock.DockControl GetDocument(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
			if (loaded.ContainsKey(fii)) return (TD.SandDock.DockControl)loaded[fii];	
			return null;
		}

		/// <summary>
		/// Returns the Document that contains a given Resource
		/// </summary>
		/// <param name="pfd">The Resource you want to select</param>
		/// <returns>the Document that contains the PluginView for the passed Resource (null if none)</returns>
		public TD.SandDock.DockControl GetDocument(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			foreach (TD.SandDock.DockControl doc in loaded.Values) 
			{
				SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)doc.Tag;
				if (wrapper!=null) 
					if (wrapper.FileDescriptor == pfd) return doc;
			}
			return null;
		}

		/// <summary>
		/// Returns the resource stored in a Document
		/// </summary>
		/// <param name="doc"></param>
		/// <returns></returns>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem GetResourceFromDocument(TD.SandDock.DockControl doc)
		{
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = null;
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem localfii in loaded.Keys) 
			{
				if (loaded[localfii] == doc) 
				{
					fii = localfii;
					break;
				}
			}

			return fii;
		}

		/// <summary>
		/// Removes the Resource from the internal storage
		/// </summary>
		/// <param name="fii"></param>
		/// <param name="wrapper"></param>
		public void RemoveResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Interfaces.Plugin.IFileWrapper wrapper) 
		{
			if (fii!=null) 
			{
				loaded.Remove(fii);
				if (wrapper!=null) single.Remove(wrapper.GetType().ToString());
			}
		}

		/// <summary>
		/// Close the given Document
		/// </summary>
		/// <param name="doc"></param>
		/// <returns>true, if the Document was closed</returns>
		public bool CloseDocument(TD.SandDock.DockControl doc)
		{			
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = GetResourceFromDocument(doc);
			if (fii!=null) return CloseDocument(fii);
			else 
			{
				doc.Close();
				return !doc.IsOpen;
			}
		}

		/// <summary>
		/// Closes the passed Document (which represents the passed Resource)
		/// </summary>
		/// <param name="fii">the Reource represented by the Document</param>
		/// <returns>true, if the Document was closed</returns>
		bool CloseDocument(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
			bool remain = false;
			TD.SandDock.DockControl doc = (TD.SandDock.DockControl)loaded[fii];
			if (doc!=null) doc.Close();	
			else RemoveResource(fii, null);

			if (doc!=null) 
			{
				if (doc.IsOpen) remain = true; 			
				else RemoveResource(fii, null);
			}			
	
			return !remain;
		}

		/// <summary>
		/// Cleanup Container
		/// </summary>
		/// <returns>true if all documents were closed</returns>
		public bool Clear()
		{
			ArrayList keys = new ArrayList();
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem s in loaded.Keys) keys.Add(s);
 
			bool remain = false;
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem k in keys)
				remain |= !CloseDocument(k);

			if (!remain) 
				loaded.Clear();
			return (loaded.Count==0);
		}

		/// <summary>
		/// Make sure all uncommited Changes are stored
		/// </summary>
		/// <returns>true if all documents were either commited or ignored</returns>
		public bool Flush()
		{			
			bool commited = true;
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem k in loaded.Keys) 
			{
				TD.SandDock.DockControl doc = GetDocument(k);
				if (doc!=null) 
				{
					SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)doc.Tag;
					commited &= UnloadWrapper(wrapper);
				}
			}

			return commited;
		}

		/// <summary>
		/// Make sure all Controls and Child Controls get disposed
		/// </summary>
		/// <param name="ctrls"></param>
		void DisposeSubControls(Control.ControlCollection ctrls)
		{
			if (ctrls==null) return;

			foreach (Control c in ctrls) 
			{	
				//DisposeSubControls(c.Controls);
				//c.Parent = null;
				c.Dispose();				
			}

			ctrls.Clear();
		}

		void ClearControls(Control c)
		{
			c.Tag = null;
			foreach (Control cc in c.Controls)							
				ClearControls(cc);
			
			c.Controls.Clear();
		}

		/// <summary>
		/// Call this if you want to unload a Wrapper
		/// </summary>
		/// <param name="doc">The document presenting the Wrapper</param>
		/// <returns>true, if the Wrapper was unloaded completley (false if User decided to answer with Cancel)</returns>
		bool UnloadWrapper(TD.SandDock.DockControl doc)
		{
			SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)doc.Tag;
			bool multi = wrapper.AllowMultipleInstances;
			bool res = UnloadWrapper(wrapper);
			if (res) 
			{
				//doc.Controls.Clear();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = this.GetResourceFromDocument(doc);
				RemoveResource(fii, wrapper);

				if (multi) 
				{
					DisposeSubControls(doc.Controls);
					ClearControls(doc);
				}
				else doc.Controls.Clear();						
				
				this.UnlinkWrapper(wrapper);
			}
				

			return res;
		}

		/// <summary>
		/// Call this if you want to unload a Wrapper
		/// </summary>
		/// <param name="wrapper"></param>
		/// <returns>true, if the Wrapper was unloaded completley (false if User decided to answer with Cancel)</returns>
		/// <remarks>When there are uncommited changes, the Method will 
		/// Prompt the User (if <see cref="SimPe.Helper.WindowsRegistry.Silent"/> is not set)
		/// if the changes should be commited</remarks>
		bool UnloadWrapper(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{			
			if (wrapper==null) return false;

			if (wrapper.GetType().GetInterface("IPackedFileSaveExtension", false) == typeof(SimPe.Interfaces.Plugin.Internal.IPackedFileSaveExtension)) 
			{
				SimPe.Interfaces.Plugin.Internal.IPackedFileSaveExtension wrp = (SimPe.Interfaces.Plugin.Internal.IPackedFileSaveExtension)wrapper;
				if ((wrp.Changed) && (!Helper.WindowsRegistry.Silent))
				{
					MessageBoxButtons mbb = MessageBoxButtons.YesNoCancel;
					//Deleted wrappers are Ignored!!!
					if (wrp.FileDescriptor!=null) 
						if (wrp.FileDescriptor.MarkForDelete) mbb = MessageBoxButtons.YesNo;

					string flname = null;
					if (wrapper!=null)
						if (wrapper.Package!=null) 
							flname=wrapper.Package.FileName;

					if (flname==null) flname = SimPe.Localization.Manager.GetString("unknown");
					DialogResult dr = SimPe.Message.Show(
						SimPe.Localization.Manager.GetString("savewrapperchanges").Replace("{name}", wrapper.ResourceName).Replace("{filename}", flname), 
						SimPe.Localization.Manager.GetString("savechanges?"),
						mbb);

					if (dr==DialogResult.Yes) wrp.SynchronizeUserData();
					else if (dr==DialogResult.Cancel) return false;
					else if (dr==DialogResult.No) wrp.Changed=false;
				}
			}						

			//we cannot unload the wrapper here!!!
			return true;
		}

		void UnlinkWrapper(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			if (wrapper.FileDescriptor!=null) 
			{
				wrapper.FileDescriptor.ChangedUserData -= new SimPe.Events.PackedFileChanged(FileDescriptor_ChangedUserData);
				wrapper.FileDescriptor.Deleted -= new EventHandler(DeletedDescriptor);	
			}
			
			if (wrapper.AllowMultipleInstances) wrapper.Dispose();
		}

		/// <summary>
		/// this is called whenever a Document gets closed
		/// </summary>
		/// <param name="sender">a <see cref="TD.SandDock.DockControl"/> Object</param>
		/// <param name="e">the Cancel Arguments</param>
		private void CloseResourceDocument(object sender, TD.SandDock.DockControlClosingEventArgs e)
		{

			SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)((TD.SandDock.DockControl)sender).Tag;
			bool multi = wrapper.AllowMultipleInstances;
			e.Cancel = !UnloadWrapper(wrapper);	
			

			if (!e.Cancel) 
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = GetResourceFromDocument((TD.SandDock.DockControl)sender);				
				RemoveResource(fii, wrapper);			
				
				if (multi) DisposeSubControls(((TD.SandDock.DockControl)sender).Controls);				
				((TD.SandDock.DockControl)sender).Controls.Clear();													

				UnlinkWrapper(wrapper);
			}
		}

		/// <summary>
		/// Called when a Descriptor get's marked for Deletion
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DeletedDescriptor(object sender, EventArgs e)
		{
			SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor) sender;	
			TD.SandDock.DockControl doc = this.GetDocument(pfd);
			if (doc!=null) this.CloseDocument(doc);
		}

		/// <summary>
		/// Called whenever the Data stored in the Filedescriptor gets changed
		/// </summary>
		/// <param name="sender"></param>
		private void FileDescriptor_ChangedUserData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
		{
			SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor) sender;	
			TD.SandDock.DockControl doc = this.GetDocument(pfd);
			if (doc!=null) 
			{
				SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)doc.Tag;
				if (wrapper!=null)
					if (wrapper.Package!=null)
					{
						string flname = wrapper.Package.FileName;
						if (flname==null) flname="";
						System.Windows.Forms.DialogResult dr = System.Windows.Forms.DialogResult.Yes;
						if (!Helper.WindowsRegistry.Silent)
							dr = Message.Show(SimPe.Localization.GetString("reschanged").Replace("{name}", doc.Text).Replace("{filename}", flname), SimPe.Localization.GetString("changed?"), System.Windows.Forms.MessageBoxButtons.YesNo);

						if (dr==System.Windows.Forms.DialogResult.Yes) 
						{
							wrapper.Refresh();
						}
					}
			}
		}

		
	}
}
