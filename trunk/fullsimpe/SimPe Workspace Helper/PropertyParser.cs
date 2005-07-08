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

namespace Ambertation
{
	

	/// <summary>
	/// Read an XML Description File and create a List of available Properties
	/// </summary>
	public class PropertyParser
	{
		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="filename">Name of the File to parse</param>
		/// <remarks>If the File is not available, an empty 
		/// Proprties hashtable will be returned!</remarks>
		public PropertyParser(string filename)
		{
			
			props = null;
			flname = filename;
		}

		string flname;
		protected Hashtable props;
		protected Hashtable enums;

		/// <summary>
		/// Return all known Properties
		/// </summary>
		public Hashtable Properties 
		{
			get { 
				if (props==null) Load();
				return props; 
			}
		}

		/// <summary>
		/// Creat an object of a given type
		/// </summary>
		/// <param name="typename"></param>
		/// <param name="value"></param>
		/// <returns></returns>
		protected virtual object BuildValue(string typename, string value) 
		{			
			Object o = 0;

			if (typename=="int") 
			{
				if (value==null) o=0;
				else o=System.Convert.ToInt32(value);
			} 
			else if (typename=="short")
			{
				if (value==null) o=0;
				else o=System.Convert.ToInt16(value);
			} 
			else if (typename=="bool") 
			{
				if (value==null) o=false;
				else o=(System.Convert.ToInt16(value)!=0);
			} 
			else if (typename=="color")
			{
				if (value==null) o=FloatColor.FromColor(System.Drawing.Color.Black);
				else 
				{
					o = FloatColor.FromString(value);					
				}
			} 

			else if ((typename=="float") || (typename=="transparence"))
			{
				if (value==null) o=(double)1.0;
				else o=(double)System.Convert.ToDouble(value, System.Globalization.CultureInfo.InvariantCulture);
			} 
			else if ((typename=="string") || (typename=="txtrref") || (typename=="guid")|| (typename=="vector2f") || (typename=="vector3f"))
			{
				if (value==null) o="";
				else o=value;
			} 
			else if (typename.StartsWith("enum:")) 
			{				
				string[] parts = typename.Split(":".ToCharArray(), 2);
				typename = parts[1];

				if (enums.ContainsKey(typename)) 
				{
					Type t = (Type)enums[typename];
					if (value==null) o =System.Enum.ToObject(t, t.GetFields()[0].GetValue(null));
					else o = System.Enum.ToObject(t, System.Convert.ToInt32(value));
				} 
				else 
				{
					parts = typename.Split(",".ToCharArray(), 2);
					Assembly a = this.GetType().Assembly;
					if (parts.Length>1) 
					{
						a = System.Reflection.Assembly.LoadFrom(parts[0]);
						typename = parts[1];
					}

					Type t = a.GetType(typename);
					if (t!=null) 
						if (t.IsEnum)
						{						
							if (value==null) 
								o = System.Enum.ToObject(t, System.Convert.ToInt32(0));
							else 
								o = System.Enum.ToObject(t, System.Convert.ToInt32(value));
						}
				}
			}
			else if (typename.StartsWith("class:")) 
			{				
				string[] parts = typename.Split(":".ToCharArray(), 2);
				typename = parts[1];

				parts = typename.Split(",".ToCharArray(), 2);
				Assembly a = this.GetType().Assembly;
				if (parts.Length>1) 
				{
					a = System.Reflection.Assembly.LoadFrom(parts[0]);
					typename = parts[1];
				}

				Type t = a.GetType(typename);
				if (t!=null)
					if (t.GetInterface("Ambertation.IPropertyClass") == typeof(Ambertation.IPropertyClass)) 
						o = System.Activator.CreateInstance(t, new object[] {(object)value});				
			}
						

			return o;
		}

		/// <summary>
		/// Read a Category Node
		/// </summary>
		/// <param name="node">the node that stores a category</param>
		protected virtual void HandleCategory(XmlNode node) 
		{
			string cat = node.Attributes["name"].Value;
			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name=="property") HandleProperty(subnode, cat);
			}
		}

		/// <summary>
		/// Read additional Data
		/// </summary>
		/// <param name="node"></param>
		/// <param name="node"></param>
		/// <param name="pd"></param>
		protected virtual void HandleProperty(XmlNode node,PropertyDescription pd) 
		{
		}

		/// <summary>
		/// Read a Property Node
		/// </summary>
		/// <param name="node">the node that stores the Propery</param>
		protected virtual void HandleProperty(XmlNode node, string cat) 
		{
			object def = 0;
			string desc = null;
			string name = "Unknown";

			string typename = node.Attributes["type"].Value;
			def = BuildValue(typename, null);
			bool ro = false;

			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name=="name") 
					name = subnode.InnerText;

				if (subnode.Name=="help") 
					desc = subnode.InnerText;

				if (subnode.Name=="default") def = BuildValue(typename, subnode.InnerText);

				if (subnode.Name=="readonly") 
					ro = true;
			}

			PropertyDescription pd = new PropertyDescription(cat, desc, def, ro);
			HandleProperty(node, pd);

			if (props.ContainsKey(name)) props[name] = pd;
			else props.Add(name, pd);
		}

		/// <summary>
		/// Read a Enum Node
		/// </summary>
		/// <param name="node">the node that stores the Propery</param>
		protected virtual void HandleEnum(ModuleBuilder myModBuilder, XmlNode node) 
		{
			string name = node.Attributes["name"].Value;
			
			// Create a dynamic Enum.
			EnumBuilder myEnumBuilder = myModBuilder.DefineEnum("SimPe.Plugins.Dinamic.Enums."+name, 
				TypeAttributes.Public, typeof(Int32));
			
			foreach (XmlNode subnode in node) 
			{
				if (subnode.Name=="field") 
					myEnumBuilder.DefineLiteral(
						subnode.InnerText, 
						(object)System.Convert.ToInt32(subnode.Attributes["value"].Value)
					);				
			}

			Type t = myEnumBuilder.CreateType();
			enums[name] = t;			
		}

		/// <summary>
		/// Load the Properties from the File
		/// </summary>
		protected void Load()
		{					
			AppDomain myDomain = Thread.GetDomain();
			AssemblyName myAsmName = new AssemblyName();
			myAsmName.Name = "SaveEmittedAssembly";

			AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
				AssemblyBuilderAccess.Run);

			// Create a dynamic module.
			ModuleBuilder myModBuilder = myAsmBuilder.DefineDynamicModule("EmittedModule");

			props = new Hashtable();
			enums = new Hashtable();
			if (!System.IO.File.Exists(flname)) return;	

			//read XML File
			System.Xml.XmlDocument xmlfile = new XmlDocument();
			xmlfile.Load(flname);

			//seek Root Node
			XmlNodeList XMLData = xmlfile.GetElementsByTagName("properties");					

			//Process all Root Node Entries
			for (int i=0; i<XMLData.Count; i++)
			{
				XmlNode node = XMLData.Item(i);	
				foreach (XmlNode subnode in node) 
				{
					if (subnode.Name=="property") HandleProperty(subnode, (string)null);
					if (subnode.Name=="category") HandleCategory(subnode);
					if (subnode.Name=="enum") HandleEnum(myModBuilder, subnode);
				}
			}
		}
	}
}
