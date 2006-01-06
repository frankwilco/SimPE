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

namespace SimPe.Interfaces
{
	/// <summary>
	/// This defines Methods that a concrete Serializer has to implement
	/// </summary>
	public interface ISerializeFormater
	{
		string Seperator 
		{
			get;
		}

		string SaveStr(string val);

		/// <summary>
		/// Format a SubProerty of the Object (a Property that contains another serializable Object)
		/// </summary>
		/// <param name="name">Name of the Property</param>
		/// <param name="val">Value of the Property</param>
		/// <returns></returns>
		string SubProperty(string name, string val);

		/// <summary>
		/// Format a Property of the Object (a Peroperty that does not contain a serializable Object
		/// </summary>
		/// <param name="name"></param>
		/// <param name="val"></param>
		/// <returns></returns>
		string Property(string name, string val);

		/// <summary>
		/// Format a Property with the Value null
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		string NullProperty(string name);

		/// <summary>
		/// Serialize the passed Object of the given Type with the given List of Properties
		/// </summary>
		/// <param name="o"></param>
		/// <param name="t"></param>
		/// <param name="ps"></param>
		/// <returns></returns>
		string Serialize(Object o, Type t, PropertyInfo[] ps);

		/// <summary>
		/// Serialize the passed Header Information for the passed Object
		/// </summary>
		/// <param name="o"></param>
		/// <param name="t"></param>
		/// <param name="ps"></param>
		/// <returns></returns>
		string SerializeHeader(Object o, Type t, PropertyInfo[] ps);

		/// <summary>
		/// Serializes the given Wrapper,Descriptor Information
		/// </summary>
		/// <param name="wrapper"></param>
		/// <param name="pfd"></param>
		/// <returns></returns>
		string SerializeTGI(SimPe.Interfaces.Plugin.Internal.IPackedFileName wrapper, SimPe.Interfaces.Files.IPackedFileDescriptorBasic pfd);

		string SerializeTGIHeader();

		string Concat(string[] props);

		string ConcatHeader(string[] props);
	}
}
