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
using System.Drawing;
using System.Windows.Forms;

namespace SimPe.Wizards
{
	public class WizardEventArgs : System.EventArgs 
	{
		WizardStepPanel step;
		bool enablenext, enableprev, c, canfin;

		public WizardStepPanel Step
		{
			get {return step;}
		}

		public bool EnableNext
		{
			get { return this.enablenext; }
			set {this.enablenext = value; }
		}

		public bool EnablePrev
		{
			get { return this.enableprev; }
			set {this.enableprev = value; }
		}

		public bool CanFinish
		{
			get { return this.canfin; }
			set {this.canfin = value; }
		}

		

		public bool Cancel
		{
			get { return c; }
			set { c = value; }
		}

		public WizardEventArgs(WizardStepPanel step, bool ennext, bool enprev, bool canfin)
		{
			this.step = step;
			this.enablenext = ennext;
			this.enableprev = enprev;
			this.canfin = canfin;
			c = false;
		}
	}

	public delegate void WizardHandle(Wizard sender);
	public delegate void WizardShowedHandle(Wizard sender, int source);
	public delegate void WizardChangeHandle(Wizard sender, WizardEventArgs e);
	public delegate void WizardStepHandle(Wizard sender, WizardStepPanel step);
	public delegate void WizardStepChangeHandle(Wizard sender, WizardStepPanel step, int target);	
}
