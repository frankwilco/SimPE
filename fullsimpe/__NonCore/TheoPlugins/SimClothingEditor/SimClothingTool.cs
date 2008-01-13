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
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Plugin;
using System.Windows.Forms;
using System.Drawing;
using System.Resources;
using System.Reflection;
using SimPe.Plugin.UI;


namespace SimPe.Plugin
{

	public class SimClothingTool : ITool, IToolExt
	{
		static Registry registry;

		IWrapperRegistry reg;
		IProviderRegistry prov;
		

		/// <summary>
		/// Windows Registry Link
		/// </summary>
		internal static Registry WindowsRegistry
		{
			get { return registry; }
		}


		internal SimClothingTool(IWrapperRegistry reg, IProviderRegistry prov)
		{
			this.reg = reg;
			this.prov = prov;

			if (registry == null)
				registry = SimPe.Helper.WindowsRegistry;
		}

		#region ITool Members

		public bool IsEnabled(IPackedFileDescriptor pfd, IPackageFile package)
		{
			return true;
		}

		
		public IToolResult ShowDialog(ref IPackedFileDescriptor pfd, ref IPackageFile package)
		{
			MainForm form = new MainForm();

			if (!FileTable.FileIndex.Loaded)
				FileTable.FileIndex.Load();

			return form.Execute(ref pfd, ref package, prov);
		}

		public override string ToString()
		{
			return "Sim Clothing Tool";
		}

		#endregion

		#region IToolExt Members

		public Image Icon
		{
			get { return null; }
		}

		public Shortcut Shortcut
		{
			get { return Shortcut.None; }
		}

		public bool Visible
		{
			get { return true; }
		}

		#endregion

	}

}
