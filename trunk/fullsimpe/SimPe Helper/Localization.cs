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
using System.Resources;
using System.Globalization;
using System.Threading;



namespace SimPe
{
	/// <summary>
	/// Supports the Localization
	/// </summary>
	public class Localization
	{
		/// <summary>
		/// The Resource Class
		/// </summary>
		private static ResourceManager resource = null;

		/// <summary>
		/// Initializes the Resource
		/// </summary>
		protected static void Initialize() 
		{					
			Localization l = new Localization();
			System.Reflection.Assembly myAssembly;
			myAssembly = l.GetType().Assembly;			

			resource = new ResourceManager(typeof(Localization));					
		}

		/// <summary>
		/// Returns a translated String
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		/// <remarks>If there is no Translation, the passsed string will be returned</remarks>
		public static string GetString(string name)
		{
			string res = Manager.GetString(name);
			if (res==null) res = Manager.GetString(name.Trim().ToLower());
			if (res==null) res = name;

			return res;
		}

		/// <summary>
		/// Returns the currrent Resource Manager
		/// </summary>
		public static ResourceManager Manager 
		{
			get { 
				if (resource==null) Initialize();
				return resource; 
			}
		}

		/// <summary>
		/// Returns the current Culture
		/// </summary>
		public static CultureInfo Culture 
		{
			get { return Thread.CurrentThread.CurrentUICulture; }
		}
	}
}
