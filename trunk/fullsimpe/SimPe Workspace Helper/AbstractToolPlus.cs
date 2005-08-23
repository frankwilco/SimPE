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

namespace SimPe.Interfaces
{
	/// <summary>
	/// Abstract Implementation for <see cref="SimPe.Interfaces.IToolExt"/> classes
	/// </summary>
	public abstract class AbstractToolPlus : AbstractTool, SimPe.Interfaces.IToolPlus
	{
		#region ITool Member

		public abstract SimPe.Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package);
		public abstract bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package);

		#endregion

		public static SimPe.Interfaces.Files.IPackedFileDescriptor ExtractFileDescriptor(SimPe.Events.ResourceEventArgs e) 
		{
			if (e==null) return null;
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = null;
			if (e.Count>0) 
			{
				if (e[0].HasFileDescriptor)
					pfd = e[0].Resource.FileDescriptor;
				
			}

			

			return pfd;
		}

		public static SimPe.Interfaces.Files.IPackageFile ExtractPackage(SimPe.Events.ResourceEventArgs e) 
		{
			if (e==null) return null;
			SimPe.Interfaces.Files.IPackageFile pkg = null;
			if (e.Count>0) 
			{
				if (e[0].HasPackage)
					pkg = e[0].Resource.Package;
			}

			if (pkg==null && e.Loaded) pkg=e.LoadedPackage.Package;

			return pkg;
		}		

		#region IToolPlus Member

		public virtual void Execute(object sender, SimPe.Events.ResourceEventArgs e)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = ExtractFileDescriptor(e);
			SimPe.Interfaces.Files.IPackageFile pkg = ExtractPackage(e);

			if (!IsEnabled(pfd, pkg)) return;
			
			SimPe.Interfaces.Plugin.IToolResult ires = ShowDialog(ref pfd, ref pkg);

			if (e.Count>0) 
			{
				e[0].ChangedFile = ires.ChangedFile;
				e[0].ChangedPackage = ires.ChangedPackage;
			}
		}

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = ExtractFileDescriptor(e);
			SimPe.Interfaces.Files.IPackageFile pkg = ExtractPackage(e);		
			
			return IsEnabled(pfd, pkg);
		}

		#endregion
	}
}
