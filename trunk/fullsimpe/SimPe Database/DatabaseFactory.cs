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
using System.IO;

namespace SimPe.Database
{    
    /// <summary>
	/// Lists all Plugins (=FileType Wrappers) available in this Package
	/// </summary>
	/// <remarks>
	/// GetWrappers() has to return a list of all Plugins provided by this Library. 
	/// If a Plugin isn't returned, SimPe won't recognize it!
	/// </remarks>
	public class DatabaseFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory, SimPe.Interfaces.Plugin.IToolFactory
	{
		internal static IToolPlugin[] Last;
        public DatabaseFactory()
		{
            LoadExternData();
        }

        #region Data preperation
        string ExeName
        {
            get { return System.IO.Path.Combine(SimPe.Helper.SimPePath, "sqlite.dll"); }
        }

        void LoadExternData()
        {            
            //if (!System.IO.File.Exists(ExeName))
            {
                string[] names = this.GetType().Assembly.GetManifestResourceNames();
                foreach (string name in names)
                {
                    string fname = name.Replace("SimPe.Database.", "");
                    fname = System.IO.Path.Combine(SimPe.Helper.SimPePath, fname);
                    if (!name.EndsWith(".dll")) continue;
                    System.IO.Stream s = this.GetType().Assembly.GetManifestResourceStream(name);
                    if (s != null)
                    {
                        System.IO.BinaryReader br = new BinaryReader(s);

                        try
                        {
                            System.IO.BinaryWriter bw = new BinaryWriter(System.IO.File.Create(fname));
                            try
                            {
                                while (br.BaseStream.Position < br.BaseStream.Length)
                                    bw.Write(br.ReadByte());
                            }
                            finally
                            {
                                bw.Close();
                            }
                        }
                        finally
                        {
                            br.Close();
                        }
                    }
                }
            }
        }
        #endregion

        #region AbstractWrapperFactory Member
        /// <summary>
		/// Returns a List of all available Plugins in this Package
		/// </summary>
		/// <returns>A List of all provided Plugins (=FileType Wrappers)</returns>
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{
				// TODO:  You can add more Wrappers here
				IWrapper[] wrappers = {
										  
									  };
				return wrappers;
			}
		}

		#endregion

		#region IToolFactory Member

        

		public IToolPlugin[] KnownTools
		{
			get
			{
                if (Last != null) return Last;

                Last = new IToolPlugin[]{
                        new SimPe.Database.DatabaseDock()
                    };
               
                return Last;
			}
		}
		#endregion
	}

}
