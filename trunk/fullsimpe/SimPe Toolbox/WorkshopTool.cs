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
	public class WorkshopTool : Interfaces.AbstractTool, Interfaces.ITool
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
		Workshop ws;

		internal WorkshopTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;

			if (registry==null) registry = Helper.WindowsRegistry;

			ws = new Workshop();
		}

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			return true;
		}

		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			
			SimPe.Interfaces.Files.IPackageFile pkg = ws.Execute(prov, package);

			if (pkg!=null) 
			{
				if (pkg.Reader!=null) 
				{
					if (!pkg.Reader.BaseStream.CanWrite) new ToolResult(false, false);
				}

				package = pkg;
				return new ToolResult(false, true);
			} 
			else 
			{
				return new ToolResult(false, false);
			}
		}

		public override string ToString()
		{
			return "Object Creation\\Object Workshop...";
		}

		#endregion

		#region IToolExt Member
		public override System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.CtrlW;
			}
		}
		#endregion
	}
}
