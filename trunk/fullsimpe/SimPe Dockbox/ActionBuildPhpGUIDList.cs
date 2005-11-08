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

namespace SimPe.Plugin.Tool.Action
{	
	/// <summary>
	/// The ReloadFileTable Action
	/// </summary>
	public class ActionBuildPhpGuidList : SimPe.Interfaces.IToolAction
	{
		
		#region IToolAction Member

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			return true;								
		}
		
		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;
			
			SimPe.FileTable.FileIndex.Load();
			
			System.IO.StreamWriter sw = new System.IO.StreamWriter(new System.IO.MemoryStream());
			try 
			{
				System.Collections.ArrayList guids = new System.Collections.ArrayList();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = SimPe.FileTable.FileIndex.FindFile(Data.MetaData.OBJD_FILE, true);
				sw.WriteLine("<?");
				sw.WriteLine("$guids = array(");
				sw.Write("    ");
				Wait.SubStart(items.Length);
				int ct = 0;
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					
					
					
					SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
					objd.ProcessData(item);

					if (guids.Contains(objd.Guid)) continue;
					if (objd.Type == SimPe.Data.ObjectTypes.Memory) continue;
					if (objd.Type == SimPe.Data.ObjectTypes.Person) continue;
					
					if (ct>0) sw.Write(",");
					ct++;
					Wait.Progress = ct;
					sw.Write("array(");
					sw.Write("0x"+Helper.HexString(objd.Guid));
					guids.Add(objd.Guid);
					sw.Write(", '");
					sw.Write("Maxis: "+objd.FileName.Replace("'", "").Replace("\\", "").Replace("\"", ""));
					/*SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] list = SimPe.FileTable.FileIndex.FindFile(Data.MetaData.CTSS_FILE, objd.FileDescriptor.Group, objd.CTSSInstance, null);
					if (list.Length==0) sw.Write(objd.FileName.Replace("'", "").Replace("\\", "").Replace("\"", ""));
					else 
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str(1);
						str.ProcessData(list[0]);
						SimPe.PackedFiles.Wrapper.StrItemList strs = str.LanguageItems(SimPe.Data.MetaData.Languages.English);
						if (strs.Count==0) sw.Write(objd.FileName.Replace("'", "").Replace("\\", "").Replace("\"", ""));
						else sw.Write(strs[0].Title.Replace("'", "").Replace("\\", "").Replace("\"", ""));
					}*/
					sw.WriteLine("')");
				}
				Wait.SubStop();
				sw.WriteLine(");");
				sw.WriteLine("?>");

				Report f = new Report();
				f.Execute(sw);
			}
			finally 
			{
				sw.Close();
			}
		}

		#endregion		

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Build GUID List";
		}
		#endregion

		#region IToolExt Member
		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		public virtual bool Visible 
		{
			get {return true;}
		}

		#endregion
	}
}

