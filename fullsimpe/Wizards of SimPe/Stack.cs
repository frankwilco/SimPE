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
using System.Collections;

namespace SimPe.Wizards
{
	/// <summary>
	/// Just a quick Stack Implementation
	/// </summary>
	public class Stack
	{
		ArrayList stack;

		/// <summary>
		/// Init a new Stack
		/// </summary>
		public Stack()
		{
			stack = new ArrayList();
		}

		/// <summary>
		/// true if the Stack is Empty
		/// </summary>
		public bool IsEmpty
		{
			get { return stack.Count==0; }
		}

		/// <summary>
		/// Number of Items on the Stack
		/// </summary>
		public int Count
		{
			get { return stack.Count; }
		}

		/// <summary>
		/// Add a new Object to the Stack
		/// </summary>
		/// <param name="obj">The Object you yant to put on the Stack</param>
		public void Push(IWizardForm obj)
		{
			stack.Add(obj);
		}
		/// <summary>
		/// Returns the last Item put on the STack
		/// </summary>
		/// <returns>null or the last Item</returns>
		public IWizardForm Tail()
		{
			if (!IsEmpty) 
				return (IWizardForm)stack[stack.Count-1];

			return null;
		}

		/// <summary>
		/// Remove the last Stack Item
		/// </summary>
		/// <returns>The Removed item</returns>
		/// <remarks>Returns null if the stack was empty</remarks>
		public IWizardForm Pop()
		{
			if (!IsEmpty) 
			{
				IWizardForm wf = Tail();
				stack.Remove(wf);
				return wf;
			}

			return null;
		}
	}
}
