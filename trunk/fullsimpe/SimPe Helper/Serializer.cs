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
using System.Reflection;

namespace SimPe
{
	/// <summary>
	/// Provides Methods to serialize Object Properties
	/// </summary>
	public class Serializer
	{
		public virtual string GetPropertyDescription()
		{
			return SimPe.Serializer.Serialize(this);			
		}

		public override string ToString()
		{
			return ToString(this.GetType().Name);
		}

		public  string ToString(string name)
		{
			return SubProperty(name, this.GetPropertyDescription());
		}

		static string SaveStr(string val)
		{
			return val.Replace(";", ",").Replace("{", "[").Replace("}", "]");
		}

		public static string SubProperty(string name, string val)
		{
			if (val==null) val="";
			return name+"={"+val+"}";
		}

		public static string Property(string name, string val)
		{
			if (val==null) val="";
			return name+"="+SaveStr(val)+"";
		}

		public const string SEPERATOR = ";";


		public static string Serialize(object o)
		{
			Type t = o.GetType();
			PropertyInfo[] ps = t.GetProperties();

			string s = "";
			foreach (PropertyInfo p in ps)
			{
				if (!p.CanRead) continue;
				

				try 
				{
					if (s!="") s += SEPERATOR;
					
				
					object v = p.GetValue(o, null);
					if (v==null) s += p.Name+"=NULL";
					
					
					if (v is Serializer) 					
						s += ((Serializer)v).ToString(p.Name);						
					else 
					{
						s += p.Name+"=";
						s += SaveStr(v.ToString());
					}
				}
				catch (Exception ex)
				{
					Helper.ExceptionMessage(ex);
				}
				finally 
				{
					
				}
			}

			return s;
		}
	}
}
