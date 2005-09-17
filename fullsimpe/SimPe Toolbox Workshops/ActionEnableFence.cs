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
	public class ActionEnableFenceInOriginalGame : SimPe.Interfaces.IToolAction
	{
		
		#region IToolAction Member

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if  (!es.Loaded) return false;								

			if (es.LoadedPackage.Package.FindFiles(Data.MetaData.XFNC).Length>0) return true;

			return false;
		}
		

		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;
			
			if (Message.Show("Making a Fence compatible with the Original Game, is a nasty Hack, which can cause conflicts in the Game. I would not suggest to do this, if you plan to Release the Fence!\n\nIf you still want to offer the Fence for the original Game, please consider to release it in two seperate Packages. One with the Fence for University and higher, and one for the Original Game.\n\nDo you really want to make this Fence compatible with the original Game?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No) return;
		
			
			
			try 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = e.LoadedPackage.Package.FindFiles(Data.MetaData.XFNC);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfd, e.LoadedPackage.Package);

					uint guid = cpf.GetSaveItem("guid").UIntegerValue;
					//load the Descriptor for the String Resource
					SimPe.Interfaces.Files.IPackedFileDescriptor p = e.LoadedPackage.Package.FindFile(
						cpf.GetSaveItem("stringsetrestypeid").UIntegerValue,
						0,
						cpf.GetSaveItem("stringsetgroupid").UIntegerValue,
						cpf.GetSaveItem("stringsetid").UIntegerValue
						);

					//change the Properties
					cpf.GetSaveItem("resourcegroupid").UIntegerValue = 0x4c8cc5c0;
					cpf.GetSaveItem("resourceid").UIntegerValue = guid;
					cpf.GetSaveItem("stringsetgroupid").UIntegerValue = guid;

					cpf.SynchronizeUserData(true, true);

					//change the Descriptor for the XML
					cpf.FileDescriptor.Instance = guid;
					cpf.FileDescriptor.Group = 0x4c8cc5c0;
					
					//change the descriptor for the CTSS
					if (p!=null) p.Group = guid;
				}
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}
		}

		#endregion		

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Fix Fence";
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
