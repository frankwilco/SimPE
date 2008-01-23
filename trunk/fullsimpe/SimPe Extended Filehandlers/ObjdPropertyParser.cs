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
using System.Xml;
using System.Collections;
using Ambertation;
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Globalization;

namespace SimPe.PackedFiles.Wrapper
{
	

	/// <summary>
	/// Read an XML Description File and create a List of available Properties
	/// </summary>
	public class ObjdPropertyParser  : Ambertation.PropertyParser
	{
		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="filename">Name of the File to parse</param>
		/// <remarks>If the File is not available, an empty 
		/// Proprties hashtable will be returned!</remarks>
		public ObjdPropertyParser(string filename) :base (filename)
		{		
			typemap = new Hashtable();
		}
		
		Hashtable typemap;
		public PropertyDescription GetDescriptor(ushort index)
		{
			if (props==null) this.Load();
            return (PropertyDescription)typemap[index];
		}

		/// <summary>
		/// Creat an object of a given type
		/// </summary>
		/// <param name="typename"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		protected override object BuildValue(string typename, string value) 
		{			
			return base.BuildValue(typename, value);
		}
		

		protected override void HandleProperty(XmlNode node, PropertyDescription pd)
		{
			base.HandleProperty(node, pd);

			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name=="index") 
				{
					try
					{
						ushort index = Convert.ToUInt16(subnode.InnerText);
                        if (!typemap.Contains(index))
                            typemap[index] = pd;
                    }
					catch {}
				}
					

			}
		}
		
		
	}
}
