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
	public class SurgeryTool : Interfaces.ITool
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

		internal SurgeryTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;

			if (registry==null) registry = new SimPe.Registry();
		}

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			if (package==null) return false;
			if (prov.SimNameProvider == null) return false;
			return Helper.IsNeighborhoodFile(package.FileName);
			
		}

		Surgery surg;
		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			if (package==null) return new Plugin.ToolResult(false, false);
			if (surg==null) surg = new Surgery();
			surg.Text = "Sims Surgery Tool";

			return surg.Execute(ref pfd, ref package, prov);
		}

		public override string ToString()
		{
			return "Sims Surgery...";
		}

		#endregion
	}
}
