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

namespace SimPe.Plugin
{
	/// <summary>
	/// An Item stored in an BCON
	/// </summary>
	public class BconItem
	{
		Bcon parent;
		int index;
		string name;
		public BconItem(short val, int index, Bcon parent) 
		{
			this.parent = parent;
			this.index = index;
			this.val = val;
			name = null;
		}

		public int Index 
		{
			set {
				name = null;
				index = value;
			}
		}

		short val;
		public short Value 
		{
			get { return val; }
			set { val = value; }
		}

		public string Name 
		{
			get 
			{
				if (name!=null) return name;
				name = Localization.Manager.GetString("Unknown");
				try 
				{
					//get TRCN
					Interfaces.Files.IPackedFileDescriptor pfd = parent.Package.FindFile(0x5452434E, parent.FileDescriptor.SubType, parent.FileDescriptor.Group, parent.FileDescriptor.Instance);
					if (pfd!=null) 
					{
						Trcn trcn = new Trcn();
						trcn.ProcessData(pfd, parent.Package);
						foreach (TrcnItem ti in trcn.Labels) 
						{
							if (ti.LineNumber == (index+1)) 
							{
								name = ti.Name;
								continue;
							}
						}
					}
				} 
				catch (Exception) {}

				name = "0x"+Helper.HexString((byte)(index))+" "+name;
				return name;
			}
		}

		
		public override string ToString()
		{
			string name = Name+": 0x"+Helper.HexString((ushort)val);
			return name;
		}

	}
}
