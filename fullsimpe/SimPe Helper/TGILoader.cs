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
using System.Xml;

namespace SimPe
{
	/// <summary>
	/// Used to build the List of known TGI Types
	/// </summary>
	public class TGILoader
	{
		Hashtable map;
		Data.TypeAlias[] list;
		ArrayList alist;
		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="filename">The file that contains the TGI definition</param>
		public TGILoader(string filename)
		{
			map = new Hashtable();
			list = new Data.TypeAlias[0];
			alist = new ArrayList();
			LoadTGI(filename);			
		}

		/// <summary>
		/// Create a new Instance from the default File
		/// </summary>
		public TGILoader() : this (System.IO.Path.Combine(Helper.SimPeDataPath, "tgi.xml")) {}

		/// <summary>
		/// Load the Values from File
		/// </summary>
		/// <param name="xmlfilename"></param>
		void LoadTGI(string xmlfilename)
		{
			map.Clear();
			
			//read XML File
			System.Xml.XmlDocument xmlfile = new XmlDocument();
			xmlfile.Load(xmlfilename);

			//seek Root Node
			XmlNodeList XMLData = xmlfile.GetElementsByTagName("tgi");					

			//Process all Root Node Entries
			for (int i=0; i<XMLData.Count; i++)
			{
				XmlNode node = XMLData.Item(i);	
				ParseSubNode(node);				
			}	

			list = new Data.TypeAlias[alist.Count];
			alist.CopyTo(list);
			alist.Clear();
		}

		/// <summary>
		/// Parse the various TGI Fields
		/// </summary>
		/// <param name="node"></param>
		void ParseSubNode(XmlNode node)
		{
			foreach (XmlNode subnode in node) 
				if (subnode.Name=="type") LoadType(subnode);
		}

		/// <summary>
		/// Parse the various TGI Fields
		/// </summary>
		/// <param name="node"></param>
		void LoadType(XmlNode node)
		{			
			uint type = 0;
			try 
			{
				type = Convert.ToUInt32(node.Attributes["value"].Value, 16);
			} 
			catch {}

			bool known = false;
			string name = "";
			string shortname = "";
			string ext = "";
			bool contfl = false;
			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name=="know") known = true;
				if (subnode.Name=="embeddedfilename") contfl = true;
				if (subnode.Name=="name") name = subnode.InnerText;
				if (subnode.Name=="shortname") shortname = subnode.InnerText;
				if (subnode.Name=="extension") ext = subnode.InnerText;
			}

			Data.TypeAlias ta = new Data.TypeAlias(contfl, SimPe.Localization.GetString(shortname), type, SimPe.Localization.GetString(name), ext, known);
			map[type] = ta;
			alist.Add(ta);
		}

		/// <summary>
		/// Returns the Information about the given Type (or null if the Type is not known!)
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public Data.TypeAlias GetByType(uint type) 
		{
			return (Data.TypeAlias)map[type];
		}

		/// <summary>
		/// Returns a List of all available FileTypes
		/// </summary>
		public Data.TypeAlias[] FileTypes
		{
			get { return list; }
		}
	}
}
