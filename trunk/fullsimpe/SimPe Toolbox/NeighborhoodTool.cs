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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ImportSemiTool.
	/// </summary>
	public class NeighborhoodTool : Interfaces.ITool
	{
		/// <summary>
		/// Windows Registry Link
		/// </summary>
		static SimPe.Registry registry;
		internal static Registry WindowsRegistry 
		{
			get { return registry; }
		}

		IWrapperRegistry reg;
		IProviderRegistry prov;

		internal NeighborhoodTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;

			if (registry==null) registry = Helper.WindowsRegistry;
		}

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			return true;
		}

		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			if (!System.IO.Directory.Exists(registry.NeighborhoodFolder)) 
			{
				System.Windows.Forms.MessageBox.Show("The Folder "+registry.NeighborhoodFolder+" was not found.\nPlease specify the correct SaveGame Folder in the Options Dialog.");
				return new ToolResult(false, false);
			}

			if (package!=null) 
			{
				if (package.HasUserChanges) 
				{
					if (System.Windows.Forms.MessageBox.Show(Localization.Manager.GetString("unsavedchanges"), Localization.Manager.GetString("savechanges?"), System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No) return new Plugin.ToolResult(false, false);
				}
			}
			NeighborhoodForm nf = new NeighborhoodForm();
			nf.Text = Localization.Manager.GetString("neighborhoodbrowser");

			Interfaces.Plugin.IToolResult ret = nf.Execute(registry.NeighborhoodFolder, ref package, prov);
			if (ret.ChangedPackage) pfd = null;
			return ret;
		}

		public override string ToString()
		{
			return "Neighborhood\\"+Localization.Manager.GetString("neighborhoodbrowser")+"...";
		}

		#endregion
	}
}
