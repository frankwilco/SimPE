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
using System.Collections.Generic;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Manages the dynamic loading of Exporter Plugins
	/// </summary>
	public class ExporterLoader
	{
		static IGmdcExporter[] exporters;
		/// <summary>
		/// Return a List of all available Exporters
		/// </summary>
		public static IGmdcExporter[] Exporters 
		{
			get { 
				if (exporters==null) LoadExporters();
				return exporters; 
			}
		}

		static IGmdcImporter[] importers;
		/// <summary>
		/// Return a List of all available Importers
		/// </summary>
		public static IGmdcImporter[] Importers 
		{
			get 
			{ 
				if (importers==null) LoadExporters();
				return importers; 
			}
		}

        /// <summary>
        /// Returns a list of Exporters stored in th epassed file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<IGmdcExporter> GetExporters(string file)
        {
            List<IGmdcExporter> list = new List<IGmdcExporter>();

            object[] plugs = SimPe.LoadFileWrappers.LoadPlugins(file, typeof(SimPe.Plugin.Gmdc.IGmdcExporter));
            foreach (IGmdcExporter p in plugs)            
                list.Add(p);            

            return list;
        }

        /// <summary>
        /// Returns a list of Exporters stored in th epassed file
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public static List<IGmdcImporter> GetImporters(string file)
        {
            List<IGmdcImporter> list = new List<IGmdcImporter>();

            object[] plugs = SimPe.LoadFileWrappers.LoadPlugins(file, typeof(SimPe.Plugin.Gmdc.IGmdcImporter));
            foreach (IGmdcImporter p in plugs)
                list.Add(p);

            return list;
        }

		/// <summary>
		/// Find all available Exporters in the Plugin Folder (everything with the Extension *.exporter.dll)
		/// </summary>
		static void LoadExporters()
		{
			string[] files = System.IO.Directory.GetFiles(Helper.SimPePluginPath, "*.exporter.dll");

			System.Collections.ArrayList list = new System.Collections.ArrayList();
			System.Collections.ArrayList imlist = new System.Collections.ArrayList();
			foreach (string file in files) 
			{
				object[] plugs = SimPe.LoadFileWrappers.LoadPlugins(file, typeof(SimPe.Plugin.Gmdc.IGmdcExporter));
				foreach (IGmdcExporter p in plugs) 
				{
					if (p.Version==1) list.Add(p);					
				} //foreach

				plugs = SimPe.LoadFileWrappers.LoadPlugins(file, typeof(SimPe.Plugin.Gmdc.IGmdcImporter));
				foreach (IGmdcImporter p in plugs) 
				{
					if (p.Version==1) imlist.Add(p);					
				} //foreach
			}

			exporters = new IGmdcExporter[list.Count];
			list.CopyTo(exporters);

			importers = new IGmdcImporter[imlist.Count];
			imlist.CopyTo(importers);
		}

		/// <summary>
		/// Returns null or the Exporter that can create a File with teh given Extension
		/// </summary>
		/// <param name="fileext"></param>
		/// <returns>null or an IGmdcExporter Instance</returns>
		public static IGmdcExporter FindExporterByExtension(string fileext)
		{
			int res = FindFirstIndexByExtension(fileext);
			if (res==-1) return null;
			else return Exporters[res];
		}

		/// <summary>
		/// Finds the first Exporter that registred for the passed File Extension
		/// </summary>
		/// <param name="fileext">The File Extension</param>
		/// <returns>The Index of the Exporter or -1</returns>
		public static int FindFirstIndexByExtension(string fileext)
		{
			int[] res = FindIndexByExtension(fileext);
			if (res.Length==0) return -1;
			else return res[0];
		}



		/// <summary>
		/// Finds the Exporter that registred for the passed File Extension
		/// </summary>
		/// <param name="fileext"></param>
		/// <returns>An Array of all Exporters that Registred for that Extension</returns>
		public static int[] FindIndexByExtension(string fileext)
		{
			fileext = fileext.Trim().ToLower();
			if (!fileext.StartsWith(".")) fileext = "."+fileext;

			System.Collections.ArrayList list = new System.Collections.ArrayList();
			for (int i=0; i<Exporters.Length; i++)
			{
				IGmdcExporter e = Exporters[i];
				if (e.FileExtension.Trim().ToLower()==fileext) list.Add(i);
			}

			int[] res = new int[list.Count];
			list.CopyTo(res);

			return res;
		}

		/// <summary>
		/// Finds the first Exporter that registred for the passed File Extension
		/// </summary>
		/// <param name="fileext">The File Extension</param>
		/// <returns>The Index of the Exporter or -1</returns>
		public static int FindFirstImporterIndexByExtension(string fileext)
		{
			int[] res = FindImporterIndexByExtension(fileext);
			if (res.Length==0) return -1;
			else return res[0];
		}


		/// <summary>
		/// Finds the Exporter that registred for the passed File Extension
		/// </summary>
		/// <param name="fileext"></param>
		/// <returns>An Array of all Exporters that Registred for that Extension</returns>
		public static int[] FindImporterIndexByExtension(string fileext)
		{
			fileext = fileext.Trim().ToLower();
			if (!fileext.StartsWith(".")) fileext = "."+fileext;

			System.Collections.ArrayList list = new System.Collections.ArrayList();
			for (int i=0; i<Importers.Length; i++)
			{
				IGmdcImporter e = Importers[i];
				if (e.FileExtension.Trim().ToLower()==fileext) list.Add(i);
			}

			int[] res = new int[list.Count];
			list.CopyTo(res);

			return res;
		}
	}
}
