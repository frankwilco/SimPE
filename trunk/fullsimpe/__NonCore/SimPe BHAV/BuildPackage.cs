/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 by Peter L Jones                                   *
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
using System.Collections.Generic;
using System.Text;
using SimPe;
using SimPe.Interfaces;
using SimPe.Packages;

namespace SimPe.Plugin
{
    class BuildPackage : ICommandLine
    {
        #region ICommandLine Members
        public bool Parse(List<string> argv)
        {
            int i = ArgParser.Parse(argv, "-build");
            if (i < 0) return false;

            Splash.Screen.SetMessage("Building Package...");

            string output = "";
            string input = "";

            while (argv.Count - i > 0 && input.Length == 0 && output.Length == 0)
            {
                if (ArgParser.Parse(argv, i, "-desc", ref input)) continue;
                if (ArgParser.Parse(argv, i, "-out", ref output)) continue;
                SimPe.Message.Show(Help()[0]);
                return true;
            }

            if (input.Length == 0 || output.Length == 0)
            {
                SimPe.Message.Show(Help()[0]);
                return true;
            }
            if (!System.IO.File.Exists(input))
            {
                SimPe.Message.Show(Help()[0]);
                return true;
            }

            GeneratableFile pkg = GeneratableFile.LoadFromStream(XmlPackageReader.OpenExtractedPackage(null, input));
            pkg.Save(output);

            Splash.Screen.SetMessage("");
            return true;
        }
        public string[] Help() { return new string[] { "-build -desc <input> -out <output>", "" }; }
        #endregion
    }

}
