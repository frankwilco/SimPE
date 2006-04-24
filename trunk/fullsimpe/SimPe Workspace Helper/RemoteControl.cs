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
using SimPe.Interfaces;

namespace SimPe
{
	/// <summary>
	/// This calss can be used to control SimPE from a Plugin.
	/// </summary>
	public class RemoteControl
	{
		public class ControlEventArgs : System.EventArgs 
		{
			object[] data;
			uint target;
			public ControlEventArgs(uint target) : this(target, new object[0]) {}
			public ControlEventArgs(uint target, object data) : this(target, new object[]{data}) {}
			public ControlEventArgs(uint target, object[] data)
			{
				if (data==null) data = new object[0];
				this.data = data;

				this.target = target;
			}

			public uint TargetType
			{
				get {return target;}
			}

			public object Item
			{
				get 
				{ 
					if (data.Length==0) return null;
					else return data[0];
				}
			}

			public object Items
			{
				get 
				{
					return data;
				}
			}
		}

		struct MessageQueueItemInfo
		{
			public uint target;
			public ControlEvent fkt;
		}

		public delegate void ControlEvent(object sender, ControlEventArgs e);
		static System.Collections.ArrayList events = new System.Collections.ArrayList();

		public static void HookToMessageQueue(uint type, ControlEvent fkt)
		{
			MessageQueueItemInfo mqi = new MessageQueueItemInfo();
			mqi.target = type;
			mqi.fkt = fkt;

			events.Add(mqi);
		}

		public static void UnhookFromMessageQueue(uint type, ControlEvent fkt)
		{
			for (int i=events.Count-1; i>=0; i--)
			{
				MessageQueueItemInfo mqi = (MessageQueueItemInfo)events[i];
				if (mqi.target == type)
					if (mqi.fkt == fkt)
						events.RemoveAt(i);
			}
		}


		public static void AddMessage(object sender, ControlEventArgs e)
		{
			foreach (MessageQueueItemInfo mqi in events)
			{
				if (mqi.target == e.TargetType || mqi.target==0xffffffff || e.TargetType==0xffffffff)
					mqi.fkt(sender, e);
			}
		}

		/// <summary>
		/// Delegate you have to implement for the remote Package opener
		/// </summary>
		public delegate bool OpenPackageDelegate(string filename);

		/// <summary>
		/// Delegate you have to implement for the remote Package opener
		/// </summary>
		public delegate bool OpenMemPackageDelegate(SimPe.Interfaces.Files.IPackageFile pkg);

		/// <summary>
		/// Delegate you have to implement for the Remote PackedFile Opener
		/// </summary>
		public delegate bool OpenPackedFileDelegate(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii);

		/// <summary>
		/// Used to show/hide a Dock
		/// </summary>
		public delegate void ShowDockDelegate(TD.SandDock.DockControl doc, bool hide);

		#region Application Form
		static System.Windows.Forms.Form appform;
		/// <summary>
		/// Returns the Main Application Form
		/// </summary>
		public static System.Windows.Forms.Form ApplicationForm
		{
			get {return appform;}
			set {
				appform = value;
				if (appform!=null)
					appstate = appform.WindowState;
				else
					appstate = System.Windows.Forms.FormWindowState.Maximized;
			}
		}

		static bool VisibleForm(System.Windows.Forms.Form form)
		{
			if (!form.ShowInTaskbar) return false;
			if (form.FormBorderStyle == System.Windows.Forms.FormBorderStyle.FixedToolWindow) return false;
			if (form.FormBorderStyle == System.Windows.Forms.FormBorderStyle.SizableToolWindow) return false;
			if (form.MinimizeBox == false) return false;

			return true;
		}

		public static void ShowSubForm(System.Windows.Forms.Form form)
		{
			if (VisibleForm(form)) HideApplicationForm();
			form.ShowDialog(ApplicationForm);
			if (VisibleForm(form)) ShowApplicationForm();
		}

		public static void HideApplicationForm()
		{
			if (ApplicationForm==null) return;
			
			if (ApplicationForm.Visible) 
			{
				ApplicationForm.Hide();
				ApplicationForm.ShowInTaskbar = true;
			}
		}

		public static void ShowApplicationForm()
		{			
			if (ApplicationForm==null) return;
			if (!ApplicationForm.Visible) 
			{
				ApplicationForm.Show();
				ApplicationForm.ShowInTaskbar = true;
			}			
		}

		static System.Windows.Forms.FormWindowState appstate;
		public static void MinimizeApplicationForm()
		{
			if (ApplicationForm==null) return;
			
			if (ApplicationForm.WindowState!=System.Windows.Forms.FormWindowState.Minimized)
			{
				appstate = ApplicationForm.WindowState;
				ApplicationForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
			}
		}

		public static void RestoreApplicationForm()
		{
			
			if (ApplicationForm==null) return;
			if (ApplicationForm.WindowState==System.Windows.Forms.FormWindowState.Minimized)
				ApplicationForm.WindowState = appstate;
		}
		#endregion

		static ShowDockDelegate sdd;
		/// <summary>
		/// Returns/Sets the ShowDock Delegate
		/// </summary>
		public static ShowDockDelegate ShowDockFkt
		{
			get { return sdd; }
			set { sdd = value; }
		}

		static OpenPackedFileDelegate opf;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenPackedFileDelegate OpenPackedFileFkt
		{
			get { return opf; }
			set { opf = value; }
		}

		static OpenPackageDelegate op;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenPackageDelegate OpenPackageFkt
		{
			get { return op; }
			set { op = value; }
		}

		/// <summary>
		/// Show/Hide a given Dock
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="hide"></param>
		public static void ShowDock(TD.SandDock.DockControl doc, bool hide)
		{
			if (sdd==null) return;
			sdd(doc, hide);
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="filename">The Filename of the package</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackage(string filename) 
		{
			if (op==null) return false;

			try 
			{
				return op(filename);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to open a Package in the SimPE GUI. (file="+filename+")", ex);
			}
			return false;
		}

		static OpenMemPackageDelegate omp;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenMemPackageDelegate OpenMemoryPackageFkt
		{
			get { return omp; }
			set { omp = value; }
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="filename">The Filename of the package</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenMemoryPackage(SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			if (omp==null) return false;

			try 
			{
				return omp(pkg);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to open a Package in the SimPE GUI. (package="+pkg.ToString()+")", ex);
			}
			return false;
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <param name="pkg">The package the descriptor is in</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackedFile(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			return OpenPackedFile(FileTable.FileIndex.CreateFileIndexItem(pfd, pkg));
		}


		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackedFile(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii) 
		{
			if (opf==null) return false;

			try 
			{
				return opf(fii);
			} 
			catch (Exception ex) 
			{                
				Helper.ExceptionMessage("Unable to open a resource in the SimPE GUI. ("+fii.ToString()+")", ex);
			}
			return false;
		}

		/// <summary>
		/// Displays a certain Help Topic
		/// </summary>
		/// <param name="url">Url (can be a local File) of the Help Document</param>
		public static void ShowHelp(string url)
		{
			System.Windows.Forms.Help.ShowHelp(ApplicationForm, url);
		}

		/// <summary>
		/// Displays a certain Help Topic
		/// </summary>
		/// <param name="url">Url (can be a local File) of the Help Document</param>
		/// <param name="topic">the Topic in that document</param>
		/// <remarks>Produces an URL like "url#topic"</remarks>
		public static void ShowHelp(string url, string topic)
		{
			System.Windows.Forms.Help.ShowHelp(ApplicationForm, url, topic);
		}

		/// <summary>
		/// Displays a Form, with the passed Custom Settings
		/// </summary>
		/// <param name="settings"></param>
		public static void ShowCustomSettings(SimPe.Interfaces.ISettings settings)
		{
			System.Windows.Forms.Form f = new System.Windows.Forms.Form();
			f.Text = settings.ToString();
			f.Width = 400;
			f.Height = 300;
			f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			f.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

			System.Windows.Forms.PropertyGrid pg = new System.Windows.Forms.PropertyGrid();
			f.Controls.Add(pg);
			pg.Dock = System.Windows.Forms.DockStyle.Fill;
			pg.SelectedObject = settings.GetSettingsObject();

			RemoteControl.ShowSubForm(f);
			f.Dispose();
		}
	}
}
