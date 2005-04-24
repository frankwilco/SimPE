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
using System.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	internal class InstructionItem 
	{
		public const int Height = 32;
		public Label lable;
		public Wrapper.Instruction instruction;
		public int index;
		public Connector TrueConnect 
		{
			get 
			{
				Connector c = new Connector();
				c.start = index;
				c.stop = instruction.Target1;
				c.lane = 0;
				c.truerule = true;
				return c;
			}
		}
		public Connector FalseConnect
		{
			get 
			{
				Connector c = new Connector();
				c.start = index;
				c.stop = instruction.Target2;
				c.lane = 0;
				c.truerule = false;
				return c;
			}
		}

		public static Connector[] Connectors(InstructionItem[] items)
		{
			if (items==null) return new Connector[0];
			Connector[] cs = new Connector[items.Length*2];
			for (int i=0; i<items.Length; i++)
			{
				cs[i*2] = items[i].TrueConnect;
				cs[i*2+1] = items[i].FalseConnect;
			}

			return cs;
		}

		public static Instruction[] Instructions(InstructionItem[] items)
		{
			if (items==null) return new Instruction[0];
			Instruction[] ins = new Instruction[items.Length];
			for (int i=0; i<items.Length; i++)
			{
				ins[i] = items[i].instruction;
			}

			return ins;
		}
	}

	/// <summary>
	/// Used for Instruction Connectors
	/// </summary>
	internal class Connector 
	{
		public int start;
		public int stop;
		public int lane;

		public bool truerule;

		/// <summary>
		/// Returns the Distance of start and stop
		/// </summary>
		public int Distance 
		{
			get { return Math.Abs(stop - start); }
		}

		/// <summary>
		/// Returns the Upper EdgePOint (smaler number)
		/// </summary>
		public int Top 
		{
			get { return Math.Min(start, stop); }
		}

		/// <summary>
		/// Returns the Lower EdgePOint (bigger number)
		/// </summary>
		public int Bottom
		{
			get { return Math.Max(start, stop); }
		}

		/// <summary>
		/// True if the passed Connector has a collision with this one
		/// </summary>
		/// <param name="c">The Connector to check against</param>
		/// <returns>true on Collision</returns>
		public bool HasCollisionWith(Connector c)
		{
			/*if (start == c.start) return false;
			if (stop == c.stop) return false;*/
			if (Bottom <= c.Top ) return false;
			if (Top >= c.Bottom) return false;

			return true;
		}

		/// <summary>
		/// Resolves all lane Collisions
		/// </summary>
		/// <param name="connectors">List of connectors</param>
		public static void ResolveCollisions(Connector[] connectors) 
		{
			foreach (Connector c in connectors) c.lane = 3;

			/*for (int i=0; i<connectors.Length-1; i++) 
			{
				for (int j=i+1; j<connectors.Length; j++) 
				{
					if (connectors[i].HasCollisionWith(connectors[j])) 
					{
						connectors[i].lane = nextfreelane++;
						break;
					}
				}
			}*/

			foreach (Connector c1 in connectors) 
			{
				int countsub = 0;
				foreach (Connector c2 in connectors) 
				{
					if ((c2.Top>=c1.Top) && (c2.Bottom<=c1.Bottom)) countsub ++;					
				}
				c1.lane += countsub - 1;
			}
		}
	}
}
