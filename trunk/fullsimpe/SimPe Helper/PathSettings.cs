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
                src += "\t[Category(\"" + ei.Flag.Class + "\"), System.ComponentModel.Editor(typeof(SimPe.SelectSimFolderUITypeEditor), typeof(System.Drawing.Design.UITypeEditor)),\n";
                src += "\tDescription(\""+SimPe.Localization.GetString("[Description:]").Replace("{LongName}", ei.Name).Trim().Replace(Helper.lbr, "\\n")+"\"), ";
                src += "DisplayName(\""+ei.NameSortNumber+": "+ei.NameShorter+"\")]\n";
                src += "\tpublic string "+ei.ShortId+"Path\n";
                src += "\t{\n";
                src += "\t\tget {\n";
                src += "\t\t\treturn GetPath(PathProvider.Global.GetExpansion(" + ei.Version + "));\n";
                src += "\t\t}\n";
                src += "\t\tset {PathProvider.Global.GetExpansion(" + ei.Version + ").InstallFolder = value;}\n";
                src += "\t}\n\n";
            }        
            
            src += "}}\n";

            try
            {
                System.Reflection.Assembly a = SimPe.RuntimeCompiler.Compile(src, new string[] { 
                    System.IO.Path.Combine(Helper.SimPePath, "simpe.helper.dll"), 
                    "system.drawing.dll" });
                return (PathSettings)SimPe.RuntimeCompiler.CreateInstance(a, "SimPe.RuntimePathSettings", new object[0]);
            }
            catch (Exception ex)
            {
                if (Helper.DebugMode || Helper.QARelease)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(System.IO.Path.Combine(Helper.SimPePath, "RuntimePathSettings.cs"));
                    sw.Write(src);
                    sw.Close();

                    Helper.ExceptionMessage(ex);
                }
                return null;
            }
        }

		protected PathSettings(Registry r)
		{
			this.r = r;
		}

        protected string GetPath(ExpansionItem ei)
        {
            if (ei.InstallFolder == null) return ei.RealInstallFolder;
            if (ei.InstallFolder.Trim() == "") return ei.RealInstallFolder;
            return ei.InstallFolder;
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
