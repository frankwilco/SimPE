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

namespace SimPe
{
	/// <summary>
	/// Describes Values used to Filter the ResourceView
	/// </summary>
	public class ViewFilter : SimPe.Windows.Forms.IResourceViewFilter
	{
		/// <summary>
		/// Create a new instance
		/// </summary>
		public ViewFilter()
		{
			doinst = false;
			dogrp = false;
			
			act = dogrp||doinst;
		}

		uint inst;
		bool doinst;
		/// <summary>
		/// The Filter Instance
		/// </summary>
		public uint Instance
		{
			get { return inst; }
			set{
                if (inst != value)
                {
                    inst = value;
                    if (ChangedFilter != null && FilterInstance) ChangedFilter(this, new EventArgs());
                }
            }
		}

		/// <summary>
		/// true if you want to filter by Instance
		/// </summary>
		public bool FilterInstance 
		{
			get { return doinst; }
			set{
                if (doinst != value)
                {
                    doinst = value;
                    act = dogrp || doinst;
                    if (ChangedFilter != null) ChangedFilter(this, new EventArgs());
                }
			}
		}

		uint grp;
		bool dogrp;
		/// <summary>
		/// The Filter Instance
		/// </summary>
		public uint Group
		{
			get { return grp; }
			set{
                if (grp != value)
                {
                    grp = value;
                    if (ChangedFilter != null && FilterGroup) ChangedFilter(this, new EventArgs());
                }
            }
		}

		/// <summary>
		/// true if you want to filter by Instance
		/// </summary>
		public bool FilterGroup 
		{
			get { return dogrp; }
			set{
                if (dogrp != value)
                {
                    dogrp = value;
                    act = dogrp || doinst;
                    if (ChangedFilter != null ) ChangedFilter(this, new EventArgs());
                }
			}
		}

		bool act;
		/// <summary>
		/// true, if at least one Filter is active
		/// </summary>
		public bool Active
		{
			get { return act; }
		}
		/// <summary>
		/// returns true, if the passed Item should be filtered
		/// </summary>
		public bool IsFiltered(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			if (dogrp) if (pfd.Group!=grp) return true;
			if (doinst) if (pfd.Instance!=inst) return true;
			return false; 
		}

        public event EventHandler ChangedFilter;
	}
}
