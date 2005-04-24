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
using SimPe.PackedFiles.Wrapper;
using SimPe.PackedFiles.UserInterface;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ImportSemiTool.
	/// </summary>
	public class ImportSemiTool : Interfaces.ITool
	{
		IWrapperRegistry reg;
		IProviderRegistry prov;
		internal ImportSemiTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;
		}

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			if (prov==null) return false;
			if (prov.OpcodeProvider==null) return false;

			if (package==null) return false;
			/*uint group = 0xffffffff;
			if (pfd!=null) group = pfd.Group;

			Interfaces.Files.IPackedFileDescriptor gpfd = package.FindFile(Data.MetaData.GLOB_FILE, 0, group, 1);
			if (gpfd==null) return false;

			prov.OpcodeProvider.LoadPackage();
			if (prov.OpcodeProvider.BasePackage==null) return false;*/

			return true;
		}

		ImportSemi isg;
		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			if (isg==null) isg = new ImportSemi();

			isg.Execute(package, this.reg, this.prov);
			return new SimPe.Plugin.ToolResult(false, true);
		}

		public override string ToString()
		{
			return "Import Semi Globals...";
		}

		#endregion
	}
}
