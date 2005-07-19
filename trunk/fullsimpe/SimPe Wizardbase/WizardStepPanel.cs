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
using System.Drawing;
using System.ComponentModel;

namespace SimPe.Wizards
{
	/// <summary>
	/// Abstract Implementaion of a Wizard Step
	/// </summary>
	[ToolboxBitmapAttribute(typeof(Panel))]
	public class WizardStepPanel : Panel
	{
		public WizardStepPanel()
		{
			this.BackColor = Color.Transparent;
			
			
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (this.DesignMode) 
			{
				SizeF sz = e.Graphics.MeasureString(HintName, Font);
				e.Graphics.DrawString(HintName, Font, new SolidBrush(Color.FromArgb(130,ForeColor)), (int)(Width-sz.Width)-2, (int)(Height-sz.Height)-2);
			}
		}

		internal string HintName 
		{
			get { return "Step "+index.ToString()+" ("+Name/*+" in "+this.ParentWizard.Text*/+")"; }
		}

		#region IWizardStep Member

		[Browsable(false)]
		public  System.Windows.Forms.Control Client
		{
			get 
			{
				return this;
			}
		}

		internal void SetupParent(Wizard parent)
		{
			this.parent = parent;
			index = 0;
			if (parent==null) return;
			index = ((Wizard)parent).Controls.Count-1;
			first = (index==0);		

			parent.Aborted += new WizardHandle(OnAborted);
			parent.Finished += new WizardHandle(OnFinished);
			parent.Loaded += new WizardHandle(OnLoaded);
		}	
	
		internal void RemoveParent(Wizard parent)
		{			
			if (parent==null) return;
			parent.Aborted -= new WizardHandle(OnAborted);
			parent.Finished -= new WizardHandle(OnFinished);
			parent.Loaded -= new WizardHandle(OnLoaded);
		}	

		Wizard parent;
		public Wizard ParentWizard
		{
			get
			{				
				return parent;
			}				
		}

		bool first;
		public bool First
		{
			get
			{				
				return first;
			}
			set 
			{
				first = value;
			}
		}

		bool last;
		public bool Last
		{
			get
			{			
				return last;
			}
			set 
			{
				last = value;
			}
		}

		int index;
		public int Index
		{
			get
			{
				return index;
			}
		}

		protected void OnLoaded(Wizard sender)
		{
			if (Loaded!=null) Loaded(sender, this);
		}

		protected void OnAborted(Wizard sender)
		{
			if (Aborted!=null) Aborted(sender, this);
		}

		protected void OnFinished(Wizard sender)
		{
			if (Finished!=null) Finished(sender, this);
		}

		internal void OnPrepare(Wizard sender, int target)
		{
			if (Prepare!=null) Prepare(sender, this, target);
		}

		internal void OnRollback(Wizard sender, int target)
		{
			if (Rollback!=null) Rollback(sender, this, target);
		}

		internal void OnShow(Wizard sender, WizardEventArgs e)
		{
			if (Activate!=null) Activate(sender, e);
		}

		public event WizardStepHandle Loaded;
		public event WizardStepHandle Aborted;
		public event WizardStepHandle Finished;

		public event WizardStepChangeHandle Prepare;
		public event WizardStepChangeHandle Rollback;
		public event WizardChangeHandle Activate;

		#endregion
		
	}
}
