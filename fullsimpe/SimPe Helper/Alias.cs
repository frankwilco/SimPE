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

namespace SimPe.Data
{
	/// <summary>
	/// Conects an value with a name
	/// </summary>
	public class Alias : SimPe.Interfaces.IAlias
	{
		/// <summary>
		/// Stores arbitary Data
		/// </summary>
		private object[] tag;

		/// <summary>
		/// The id Value
		/// </summary>
		private uint id;

		/// <summary>
		/// The long Name
		/// </summary>
		private string name;

		/// <summary>
		/// This is used to format the ToString() Output
		/// </summary>
		private string template;

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		public Alias(uint val, string name)
		{
			id = val;
			this.name = name;
#if DEBUG
			template = "{name} (0x{id})";
#else
			template = "{name} (0x{id})";
#endif
		}

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		/// <param name="template">The ToString Template</param>
		public Alias(uint val, string name, string template)
		{
			id = val;
			this.name = name;
			this.template = template;
		}

		/// <summary>
		/// Craetes a String from the Object
		/// </summary>
		/// <returns>Simply Returns the Name Attribute</returns>
		public override string ToString()
		{
			string ret = template;

			ret = ret.Replace("{name}", name);
			ret = ret.Replace("{id}", id.ToString("X"));

			if (tag!=null) 
			{
				for (int i=0; i<tag.Length; i++) 
				{
					object o = tag[i];
					if (o!=null) ret = ret.Replace("{"+i.ToString()+"}", o.ToString());
					else ret = ret.Replace("{"+i.ToString()+"}", "");
				}
			}

			return ret;
		}

		#region IAlias Member

		public uint Id
		{
			get
			{
				return id;
			}
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public object[] Tag 
		{
			get 
			{
				return tag;
			}
			set
			{
				tag = value;
			}
		}

		#endregion

		#region static Loader
		/// <summary>
		/// Load a List of Aliases form an XML File
		/// </summary>
		/// <param name="flname">Name of the File</param>
		/// <returns>The IAlias List</returns>
		public static SimPe.Interfaces.IAlias[] LoadFromXml(string flname)
		{
			if (!System.IO.File.Exists(flname)) return new SimPe.Interfaces.IAlias[0];

			try 
			{
				//read XML File
				System.Xml.XmlDocument xmlfile = new XmlDocument();
				xmlfile.Load(flname);

				
				//seek Root Node
				XmlNodeList XMLData = xmlfile.GetElementsByTagName("alias");					

				ArrayList list = new ArrayList();
				//Process all Root Node Entries
				for (int i=0; i<XMLData.Count; i++)
				{
					XmlNode node = XMLData.Item(i);	
					foreach (XmlNode subnode in node) 
					{
						if (subnode.LocalName.Trim().ToLower()=="item") 
						{
							string sval = subnode.Attributes["value"].Value.Trim().ToString();
							uint val = 0;

							if (sval.StartsWith("0x")) val = Convert.ToUInt32(sval, 16);
							else val = Convert.ToUInt32(sval);

							Alias a = new Alias(val, subnode.InnerText.Trim());
							list.Add((SimPe.Interfaces.IAlias)a);
						}
					}
				} // for i			

				SimPe.Interfaces.IAlias[] ret = new SimPe.Interfaces.IAlias[list.Count];
				list.CopyTo(ret);
				return ret;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}

			return new SimPe.Interfaces.IAlias[0];
		}
		#endregion
	}
}
