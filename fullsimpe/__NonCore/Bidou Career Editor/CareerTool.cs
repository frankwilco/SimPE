/***************************************************************************
 *   Original (C) Bidou, assumed to be licenced as part of SimPE           *
 *   Pet updates copyright (C) 2007 by Peter L Jones                       *
 *   Updates copyright (C) 2008 by Peter L Jones                           *
 *   pljones@users.sf.net                                                  *
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
	public class CareerTool : Interfaces.ITool
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

		internal CareerTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;

			if (registry==null) registry = Helper.WindowsRegistry;
		}

		#region ITool Member

		internal static string DefaultCareerFile		
		{
			get 
			{
                if (SimPe.PathProvider.Global.EPInstalled == 1)
					return System.IO.Path.Combine(Helper.SimPeDataPath, "ep1base.career");
				else
					return System.IO.Path.Combine(Helper.SimPeDataPath, "base.career");
			}
		}

        public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
        {
            return true;
        }

        private bool IsReallyEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
        {
            if (System.IO.File.Exists(DefaultCareerFile)) return true;

            if (package == null)
            {
                System.Windows.Forms.MessageBox.Show("You do not have a package open and the Default Career File was not found.");
                return false;
            }
            Interfaces.Files.IPackedFileDescriptor[] globals = package.FindFiles(Data.MetaData.GLOB_FILE);
            if (globals.Length == 1)
            {
                SimPe.Plugin.Glob glob = new SimPe.Plugin.Glob();
                glob.ProcessData(globals[0], package);
                if (glob.SemiGlobalName == "JobDataGlobals") return true;
            }
            System.Windows.Forms.MessageBox.Show("This package does not contain a career.");
            return false;
        }

		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
            if (!IsReallyEnabled(pfd, package)) return new SimPe.Plugin.ToolResult(false, false);

			CareerEditor careerEditor = new CareerEditor();			
			return careerEditor.Execute(ref pfd, ref package, prov);
		}

		public override string ToString()
		{
			return "Bidou's Career Editor...";
		}

		#endregion
	}
}
