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
using System.ComponentModel;

namespace SimPe
{
	/// <summary>
	/// This is used to display Paths in the Options Dialog
	/// </summary>
    public class PathSettings : SimPe.GlobalizedObject
	{
		Registry r;
        static PathSettings ps;
        public static PathSettings Global
        {
            get
            {
                if (ps == null) { ps = CreateInstance(); }
                return ps;
            }
        }

        static PathSettings CreateInstance()
        {
            string src = "using System;\n";
            src += "using System.ComponentModel;\n";
            src += "namespace SimPe{\n";
            src += "public class RuntimePathSettings : PathSettings { \n";

            src += "\tpublic RuntimePathSettings() : base(Helper.WindowsRegistry){\n";
            src += "\t}\n\n\n";

            foreach (ExpansionItem ei in PathProvider.Global.Expansions)
            {
                src += "\t[Category(\"" + ei.Flag.Class + "\"), System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]\n";
                src += "\tpublic string "+ei.ShortId+"Path\n";
                src += "\t{\n";
                src += "\t\tget {\n";
                src += "\t\t\treturn GetPath(@\""+ei.InstallFolder+"\", @\""+ei.RealInstallFolder+"\");\n";
                src += "\t\t}\n";
                src += "\t\tset {PathProvider.Global.GetExpansion(" + ei.Version + ").InstallFolder = value;}\n";
                src += "\t}\n\n";
            }        
            
            src += "}}\n";
            //Console.WriteLine(src);

            try
            {
                System.Reflection.Assembly a = Ambertation.RuntimeCompiler.Compile(src, new string[] { "SimPe.Helper.dll", "System.Drawing.dll" });
                return (PathSettings)Ambertation.RuntimeCompiler.CreateInstance(a, "SimPe.RuntimePathSettings", new object[0]);
            }
            catch
            {
                return null;
            }
        }

		protected PathSettings(Registry r)
		{
			this.r = r;
		}

		protected string GetPath(string userpath, string defpath)
		{
			if (userpath==null) userpath="";
			if (userpath.Trim()=="") return defpath;
			return userpath;
		}

		[Category("BaseGame"),System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor))]
		public string SaveGamePath
		{
			get 
			{
                return GetPath(PathProvider.SimSavegameFolder, PathProvider.RealSavegamePath);
			}
            set { PathProvider.SimSavegameFolder = value; }
		}
	}
}
