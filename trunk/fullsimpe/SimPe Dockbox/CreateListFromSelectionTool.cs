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
using SimPe.Events;

namespace SimPe.Plugin.Tool
{
	/// <summary>
	/// Zusammenfassung für ImportSemiTool.
	/// </summary>
	public class CreateListFromSelectionTool : SimPe.Interfaces.IToolPlus	
	{
		internal CreateListFromSelectionTool() 
		{
			
		}

		static Report f;

		public static void WriteCSVItem(System.IO.StreamWriter sw, Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			if (wrapper!=null)
				sw.Write(wrapper.ResourceName.Replace(";", ",") + "; ");					
			else
				sw.Write(pfd.TypeName.ToString().Replace(";", ",") + "; ");					

			sw.Write("0x" + Helper.HexString(pfd.Type) + "; ");
			sw.Write("0x" + Helper.HexString(pfd.Group) + "; ");
			sw.Write("0x" + Helper.HexString(pfd.SubType) + "; ");
			sw.Write("0x" + Helper.HexString(pfd.Instance) + "; ");
					
			if (wrapper!=null) sw.Write(wrapper.Description);			
			sw.WriteLine(";");						
		}

		public static string ProcessItem(System.IO.StreamWriter sw, SimPe.Events.ResourceContainer e)
		{
			string error = "";
			if (!e.HasFileDescriptor) return "";
			if (!e.HasPackage) return "";

			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = e.Resource.FileDescriptor;
				SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)FileTable.WrapperRegistry.FindHandler(pfd.Type);				
				if (wrapper!=null) wrapper.ProcessData(e.Resource);
				WriteCSVItem(sw, pfd, wrapper);
					
			}
			catch (Exception ex)
			{
				error += ex.Message+Helper.lbr;
			}

			return error;
		}

		public static void Execute(SimPe.Events.ResourceContainers es)
		{
			WaitingScreen.Wait();
			System.IO.StreamWriter sw = new System.IO.StreamWriter(new System.IO.MemoryStream());
			string error = "";
			int ct = 0;
			string max = "/ "+es.Count.ToString();
			foreach (SimPe.Events.ResourceContainer e in es)
			{
				error += ProcessItem(sw, e);
				WaitingScreen.UpdateMessage((ct++).ToString()+" / "+max.ToString());
			}
			WaitingScreen.Stop();
		
			if (error!="") throw new Warning("Not all Selected Files were processed.", error);

			if (f==null) f= new Report();
			f.Execute(sw);
		}

		#region ITool Member

		public bool ChangeEnabledStateEventHandler(object sender, ResourceEventArgs e)
		{
			return (e.Loaded && e.HasFileDescriptor);
		}

		public void Execute(object sender, ResourceEventArgs es)
		{
			if (!ChangeEnabledStateEventHandler(sender, es)) return;

			Execute(es.Items);
		}

		


		public override string ToString()
		{
			return "Create Description\\from Selection...";
		}

		#endregion

		#region IToolExt Member
		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.CtrlD;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.selected.png"));
			}
		}

		#endregion
	}
}
