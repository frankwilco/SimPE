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
using System.Collections;
using System.IO;

namespace SimPe
{
	/// <summary>
	/// Contains Parameters passed on the Commandline
	/// </summary>
	public class Parameters
	{
		string[] files;

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="param">Parameters passed on the Coammandline</param>
		public Parameters(string[] param)
		{
			ArrayList fllist = new ArrayList();
			foreach (string s in param) 
			{
				if (System.IO.File.Exists(s)) fllist.Add(s);
			}

			files = new string[fllist.Count];
			fllist.CopyTo(files);
		}

		/// <summary>
		/// Returns the Files passed on the Commandline
		/// </summary>
		public string[] Files 
		{
			get { return files; }
		}
	}
}
