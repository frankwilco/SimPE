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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class GlobUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		private BhavForm form;

		static System.Collections.ArrayList globs = null;
		static void BuildGlobList() 
		{
			if (globs!=null) return;
			globs = new System.Collections.ArrayList();

			FileTable.FileIndex.Load();
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] iglobs = FileTable.FileIndex.FindFile(Data.MetaData.GLOB_FILE, true);
			System.Collections.ArrayList names = new System.Collections.ArrayList();
			string max = " / "+iglobs.Length.ToString();
			int ct = 0;
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in iglobs) 
			{
				WaitingScreen.UpdateMessage(ct.ToString()+max);
				ct++;

				NamedGlob glob = new NamedGlob();
				glob.ProcessData(item.FileDescriptor, item.Package);

				if (!names.Contains(glob.SemiGlobalName.Trim().ToLower())) 
				{
					Data.SemiGlobalAlias g = new SimPe.Data.SemiGlobalAlias(true, glob.SemiGlobalGroup, glob.SemiGlobalName);
					globs.Add(g);
					names.Add(glob.SemiGlobalName.Trim().ToLower());
				}
			}
		}

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public GlobUI()
		{
			form = SimPe.Plugin.WrapperFactory.form;

			form.cbseminame.Items.Clear();
			BuildGlobList();
			foreach (Data.SemiGlobalAlias a in globs) if (a.Known) form.cbseminame.Items.Add(a);
		}
		#endregion

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Panel GUIHandle
		{
			get
			{
				return form.pnGlob;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <param name="wrapper">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrapper)
		{
			form.wrapper = (IFileWrapperSaveExtension)wrapper;

			Glob wrp = (Glob) wrapper;
			form.cbseminame.Tag = true;
			form.lbglobfile.Text = wrp.FileName;
			form.cbseminame.Text = wrp.SemiGlobalName;
			form.cbseminame.Tag = null;
		}		

		#endregion
	}
}
