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
using SimPe.Interfaces.Plugin;
using System.Windows.Forms;
using System.Xml;


namespace SimPe.Plugin
{
	/// <summary>
	/// This class is able to load the Names for some special Want Items
	/// </summary>
	public class WantNameLoader
	{
		Hashtable map;
		/// <summary>
		/// Returns a List with all known Names
		/// </summary>
		public Hashtable Map 
		{
			get { return map; }
		}

		/// <summary>
		/// Create a New Instance
		/// </summary>
		public WantNameLoader()
		{
			ParseXml();
		}

		/// <summary>
		/// Parse a complrete Subnode
		/// </summary>
		/// <param name="name">The tage name we are looking for</param>
		/// <param name="node">The SubNode</param>
		/// <returns>A List of all found Entries (key=id, value=name)</returns>
		Hashtable ParseSubNode(string name, XmlNode node)
		{
			Hashtable ht = new Hashtable();
			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name==name) 
				{
					uint id = Convert.ToUInt32(subnode.Attributes["id"].Value, 16);
					string n = subnode.Attributes["name"].Value;

					ht[id] = n;
				}
			}

			return ht;
		}		

		/// <summary>
		/// Create a HashTable with the needed Names from the UI xml File
		/// </summary>
		void ParseXml()
		{
			map = new Hashtable();
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(0x00000000, 0xCDA53B6F, 0x2D7EE26B);
			if (items.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Xml xml = new SimPe.PackedFiles.Wrapper.Xml();
				xml.ProcessData(items[0]);

				//read XML File
				System.Xml.XmlDocument xmlfile = new XmlDocument();
				xmlfile.LoadXml(xml.Text);

				//seek Root Node
				XmlNodeList XMLData = xmlfile.GetElementsByTagName("wantSimulator");					

				//Process all Root Node Entries
				for (int i=0; i<XMLData.Count; i++)
				{
					XmlNode node = XMLData.Item(i);	
					foreach (XmlNode subnode in node) 
					{
						switch (subnode.Name) 
						{
							case "categories": 
							{
								map[WantType.Category] = ParseSubNode("category", subnode);
								break;
							}
							case "skills":
							{
								map[WantType.Skill] = ParseSubNode("skill", subnode);
								break;
							}
							case "careers":
							{
								map[WantType.Career] = ParseSubNode("career", subnode);
								break;
							}
						} //switch
					}
				} //for i
			}
		}

		/// <summary>
		/// Adds the currently Available SimNames to the Map
		/// </summary>
		/// <remarks>Feeds the IProviderRegistry set in the FileTable!</remarks>
		public void AddSimNames() 
		{
			Hashtable ht = new Hashtable();
			map[WantType.Sim] = ht;

			if (FileTable.ProviderRegistry==null) return;

			foreach (ushort inst in FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance.Keys) 
			{
				SimPe.Interfaces.Wrapper.ISDesc isdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(inst);
				SimPe.PackedFiles.Wrapper.SDesc sdsc = (SimPe.PackedFiles.Wrapper.SDesc)isdsc;
				sdsc.SetProviders(FileTable.ProviderRegistry);
				Data.Alias a = new SimPe.Data.Alias(inst, sdsc.SimName+" "+sdsc.SimFamilyName+" ("+sdsc.HouseholdName+")");
				ht[(uint)inst] = a.Name;
			}
		}

		/// <summary>
		/// Returns the Name of a Want (or null if none was found)
		/// </summary>
		/// <param name="wt">The Type of the Want</param>
		/// <param name="id">The id of the String</param>
		/// <returns>The Name or null</returns>
		public string FindName(WantType wt, uint id)
		{
			Hashtable ht = (Hashtable)Map[wt];
			if (ht!=null) 
			{
				return (string)ht[id];
			}

			return null;
		}

		/// <summary>
		/// Returns an ArrayLIst of Alias Object with all available Names for this Type
		/// </summary>
		/// <param name="wt">The Type of the Want</param>
		/// <returns>List of Alias Items</returns>
		public ArrayList GetNames(WantType wt) 
		{
			ArrayList ret = new ArrayList();
			Hashtable ht = (Hashtable)Map[wt];
			if (ht!=null) 
			{
				foreach (uint t in ht.Keys) 
				{
					Data.Alias a = new SimPe.Data.Alias(t, (string)ht[t], "{name}");
					ret.Add(a);
				}
			}

			return ret;
		}
	}
}
