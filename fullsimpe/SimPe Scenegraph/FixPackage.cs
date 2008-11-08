/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   peter@users.sf.net                                                    *
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
using System.Collections.Generic;
using System.Text;
using SimPe;
using SimPe.Interfaces;
using SimPe.Packages;

namespace SimPe.Plugin
{
    public class FixPackage : ICommandLine
    {
        #region ICommandLine Members

        public bool Parse(List<string> argv)
        {
            int i = ArgParser.Parse(argv, "-fix");
            if (i < 0) return false;

            string modelname = "";
            string prefix = "";
            string package = "";
            string vertxt = "";
            FixVersion ver = FixVersion.UniversityReady;

            while (argv.Count > i)
            {
                if (ArgParser.Parse(argv, i, "-package", ref package)) continue;
                if (ArgParser.Parse(argv, i, "-modelname", ref modelname)) continue;
                if (ArgParser.Parse(argv, i, "-prefix", ref prefix)) continue;
                if (ArgParser.Parse(argv, i, "-fixversion", ref vertxt))
                {
                    switch (vertxt.Trim().ToLower())
                    {
                        case "uni1": ver = FixVersion.UniversityReady; break;
                        case "uni2": ver = FixVersion.UniversityReady2; break;
                    }
                    continue;
                }
                SimPe.Message.Show(Help()[0]);
                return true;
            }

            Fix(package, prefix + modelname, ver);
            return true;
        }

        public string[] Help()
        {
            return new string[] { "-fix -package <pkg> -modelname <mdl> -prefix <pfx> -fixversion uni1|uni2", null };
        }

        #endregion


        public static void Fix(string package, string modelname, FixVersion ver)
        {
            if (System.IO.File.Exists(package))
            {
                SimPe.Packages.GeneratableFile pkg = SimPe.Packages.GeneratableFile.LoadFromFile(package);

                System.Collections.Hashtable map = RenameForm.GetNames((modelname.Trim() != ""), pkg, null, modelname);
                FixObject fo = new FixObject(pkg, ver, false);
                fo.Fix(map, false);
                fo.CleanUp();
                fo.FixGroup();

                pkg.Save();
            }
        }
    }
}
