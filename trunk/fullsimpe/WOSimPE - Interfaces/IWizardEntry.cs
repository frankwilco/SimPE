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

namespace SimPe.Wizards 
{
	/// <summary>
	/// Contains a Interface that must be implemented by the FIRST Step of a Wizard Chain
	/// </summary>
	public interface IWizardEntry : IWizardForm
	{
		/// <summary>
		/// Returns a short Description of this Wizard
		/// </summary>
		string WizardDescription
		{
			get;
		}

		/// <summary>
		/// Returns the Title of that Wizard
		/// </summary>
		string WizardCaption
		{
			get;
		}

		/// <summary>
		/// Returns a Image that should be displayed for this wizard
		/// </summary>
		/// <remarks>can be null</remarks>
		System.Drawing.Image WizardImage
		{
			get;
		}		
	}
}
