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
using SimPe.Interfaces.Plugin.Internal;

namespace SimPe
{
	/// <summary>
	/// This is the default descriptive Serializer
	/// </summary>
	public abstract class AbstractSerializer : SimPe.Interfaces.ISerializeFormater
	{		

		public abstract string Seperator 
		{
			get ;
		}

		public abstract string SaveStr(string val);		

		

		/// <summary>
		/// Format a SubProerty of the Object (a Property that contains another serializable Object)
		/// </summary>
		/// <param name="name">Name of the Property</param>
		/// <param name="val">Value of the Property</param>
		/// <returns></returns>
		public abstract string SubProperty(string name, string val);

		/// <summary>
		/// Format a Property of the Object (a Peroperty that does not contain a serializable Object
		/// </summary>
		/// <param name="name"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		public abstract string Property(string name, string val);

		/// <summary>
		/// Format a Property with the Value null
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public abstract string NullProperty(string name);
		
		public virtual string SerializeTGIHeader()
		{
			return "Name"+Seperator+"Type"+Seperator+"Group"+Seperator+"Instance (Hi)"+Seperator+"Instance"+Seperator;
		}

		public virtual string SerializeHeader(Object o, Type t, PropertyInfo[] ps)
		{			
			string s = "";
			
			foreach (PropertyInfo p in ps)
			{
				if (!p.CanRead) continue;
				

				try 
				{
					if (s!="") s += Seperator;									
					s += p.Name;

					object v = p.GetValue(o, null);
					string ss = "";
					if (v is IPackedFileName) 	
					{
						ss = ((IPackedFileName)v).DescriptionHeader;
						s += ss;
					}
					if ((v is Serializer) && ss == "")
						s += Serializer.SerializeTypeHeader(v);
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

		public virtual string Serialize(Object o, Type t, PropertyInfo[] ps)
		{			
			string s = "";
			foreach (PropertyInfo p in ps)
			{
				if (!p.CanRead) continue;
				

				try 
				{
					if (s!="") s += Seperator;
					
				
					object v = p.GetValue(o, null);
					if (v==null) s += NullProperty(p.Name);
					
					
					if (v is Serializer) 					
						s += ((Serializer)v).ToString(p.Name);						
					else 
					{
						s += Property(p.Name, v.ToString());
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

		public virtual string SerializeTGI(SimPe.Interfaces.Plugin.Internal.IPackedFileName wrapper, SimPe.Interfaces.Files.IPackedFileDescriptorBasic pfd)
		{
			string s = "";
			if (wrapper!=null)
				s += SaveStr(wrapper.ResourceName) + Seperator;
			else
				s +=  SaveStr(pfd.TypeName.ToString()) + Seperator;		

			s += "0x" + Helper.HexString(pfd.Type) + Seperator;		
			s += "0x" + Helper.HexString(pfd.Group) + Seperator;		
			s += "0x" + Helper.HexString(pfd.SubType) + Seperator;		
			s += "0x" + Helper.HexString(pfd.Instance) + Seperator;										

			return s;
		}

		public virtual string Concat(string[] props)
		{
			string s = "";
			foreach(string p in props)
			{
				if (s!="") s+= Seperator;
				s += p;
			}
			return s;
		}

		public virtual string ConcatHeader(string[] props)
		{
			return this.Concat(props);
		}
	}
}
