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

namespace SimPe.PackedFiles.UserInterface 
{
	/// <summary>
	/// Abstract Base for some UIHandlers
	/// </summary>
	public abstract class UIBase
	{
		/// <summary>
		/// The Form containing the Panel
		/// </summary>
		internal static Elements form = null;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public UIBase ()
		{
			if (form==null)	form = new Elements();			
		}	
	
		

		#region IDisposable Member
		public virtual void Dispose()
		{
			
		}
		#endregion
	}
}
