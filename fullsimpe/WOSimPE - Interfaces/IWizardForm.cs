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
	/// Used to notfy the Parent Form of Changes in one Step of the Wizard
	/// </summary>
	public delegate void ChangedContent(IWizardForm sender, bool autonext);

	/// <summary>
	/// Contains a Interface that can be used to Display the Wizard GUI
	/// </summary>
	public interface IWizardForm
	{
		/// <summary>
		/// Returns the Panel that should be displayed
		/// </summary>
		Panel WizardWindow 
		{
			get;
		}

		/// <summary>
		/// Returns a description for the current Step
		/// </summary>
		string WizardMessage
		{
			get;
		}

		/// <summary>
		/// Returns the Number of the current Step
		/// </summary>
		/// <remarks>Return 0 if it should just be the next Number</remarks>
		int WizardStep 
		{
			get;
		}

		
		/// <summary>
		/// This Method is called BEFORE the Panle get's displayed
		/// </summary>
		/// <param name="fkt">null or a Delegate to a Function that should be 
		/// called when the content of the Step Form changed</param>
		/// <returns>true, if the Step can be dieplayed now</returns>
		bool Init(ChangedContent fkt);

		/// <summary>
		/// Returns null, or the suggested next Wizard Step.
		/// </summary>
		/// <remarks>Null indicates that this is the final step</remarks>
		IWizardForm Next 
		{
			get;
		}
		
		/// <summary>
		/// Returns true, if it is possible to continue with the next Step
		/// </summary>
		bool CanContinue
		{
			get;
		}
	}
}
