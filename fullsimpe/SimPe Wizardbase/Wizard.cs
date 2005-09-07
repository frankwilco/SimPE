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
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections;

namespace SimPe.Wizards
{
	/// <summary>
	/// This implements a basic Wizard
	/// </summary>
	[Designer(typeof(SimPe.Wizards.WizardDesigner)), ToolboxBitmapAttribute(typeof(TabControl))]
	
	public class Wizard : Panel
	{
		int cur;
		

		public Wizard()
		{
			this.BackColor = Color.Transparent;
			this.DockPadding.All = 8;

			img = null;
			this.ControlAdded += new ControlEventHandler(Wizard_ControlAdded);
			this.ControlRemoved += new ControlEventHandler(Wizard_ControlRemoved);
		}			

		internal bool Contains(WizardStepPanel iws) 
		{
			return Controls.Contains(iws);
		}		

		#region IWizard Member

		[Browsable(false)]
		public Control WizardContainer 
		{
			get{ return this; }
			
		}		

		Image img;
		public virtual System.Drawing.Image Image
		{
			get{ return img;}
			set { img = value; }
		}

		public int StepCount
		{
			get { return Controls.Count; }
		}

		public int CurrentStepNumber
		{
			get { return cur; }
			set 
			{
				if (value == cur) this.JumpToStep(value);
			}
		}

		[Browsable(false)]
		public WizardStepPanel CurrentStep
		{
			get
			{
				return (WizardStepPanel)Controls[cur];
			}
		}

		bool ne;
		[Browsable(false)]
		public bool NextEnabled 
		{
			get {return ne;}
			set 
			{
				if (value!=ne)
				{
					ne = value;
					if (ChangedNextState!=null) ChangedNextState(this);
				}
			}
		}

		bool pe;
		[Browsable(false)]
		public bool PrevEnabled 
		{
			get {return pe;}
			set 
			{
				if (value!=pe)
				{
					pe = value;
					if (ChangedNextState!=null) ChangedPrevState(this);
				}
			}
		}

		bool fe;
		[Browsable(false)]
		public bool FinishEnabled 
		{
			get {return fe;}
			set 
			{
				if (value!=fe)
				{
					fe = value;
					if (ChangedNextState!=null) ChangedFinishState(this);
				}
			}
		}

		public bool JumpToStep(int nr)
		{
			
			if (nr<0) return false;
			if (nr>=Controls.Count) return false;
			
			if (this.DesignMode) 
			{
				this.CurrentStep.Client.Visible = false;
				this.cur = nr;
				this.CurrentStep.Client.Visible = true;
				return false;
			}
			if (nr>=cur) 
			{
				for (int i=cur+1; i<=nr; i++) 
				{
					((WizardStepPanel)Controls[i]).OnPrepare(this, nr);
					if (PrepareStep!=null) PrepareStep(this, (WizardStepPanel)Controls[i], nr);			
				}
			} 
			else 
			{
				for (int i=cur; i>nr; i--) 
				{
					((WizardStepPanel)Controls[i]).OnRollback(this, nr);	
					if (RollbackStep!=null) RollbackStep(this, (WizardStepPanel)Controls[i], nr);
				}

				((WizardStepPanel)Controls[nr]).OnPrepare(this, nr);
				if (PrepareStep!=null) PrepareStep(this, (WizardStepPanel)Controls[nr], nr);			
			}
			WizardEventArgs e = new WizardEventArgs(
				(WizardStepPanel)Controls[nr], 
				!((WizardStepPanel)Controls[nr]).Last, 
				!((WizardStepPanel)Controls[nr]).First, 
				((WizardStepPanel)Controls[nr]).Last);
			((WizardStepPanel)Controls[nr]).OnShow(this, e);

			if (e.Cancel) return false;
			if (ShowStep!=null) ShowStep(this, e);
			if (e.Cancel) return false;

			foreach (Control c in Controls) c.Visible = false;
			this.CurrentStep.Client.Visible = false;
			this.cur = nr;
			this.CurrentStep.Client.Visible = true;
			this.NextEnabled = e.EnableNext;
			this.PrevEnabled = e.EnablePrev;
			this.FinishEnabled = e.CanFinish;
		
		((WizardStepPanel)Controls[nr]).OnShowed(this);
			if (ShowedStep!=null) ShowedStep(this);
			return true;
		}

		public void Start()
		{
			if (Loaded!=null) Loaded(this);
			
			this.cur = 0;
			this.JumpToStep(0);
		}

		public bool GoNext()
		{
			return this.JumpToStep(this.CurrentStepNumber+1);
		}

		public bool GoPrev()
		{			
			return this.JumpToStep(this.CurrentStepNumber-1);
		}		

		public void Finish()
		{
			if (Finished!=null) Finished(this);
		}

		public void Abort()
		{
			if (Aborted!=null) Aborted(this);
		}

		public event SimPe.Wizards.WizardHandle Loaded;

		public event SimPe.Wizards.WizardHandle Aborted;

		public event SimPe.Wizards.WizardHandle Finished;

		public event SimPe.Wizards.WizardStepChangeHandle PrepareStep;

		public event SimPe.Wizards.WizardStepChangeHandle RollbackStep;

		public event SimPe.Wizards.WizardChangeHandle ShowStep;

		public event SimPe.Wizards.WizardHandle ShowedStep;

		public event SimPe.Wizards.WizardHandle ChangedNextState;

		public event SimPe.Wizards.WizardHandle ChangedPrevState;

		public event SimPe.Wizards.WizardHandle ChangedFinishState;

		#endregion		

		internal string HintName 
		{
			get { return Text+" ("+Name+")"; }
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			if (this.DesignMode) 
			{
				e.Graphics.DrawRectangle(new Pen(Color.FromArgb(90, Color.DarkRed),1), 0, 0, Width-1, Height-1);
				SizeF sz = e.Graphics.MeasureString(HintName, Font);
				e.Graphics.DrawString(HintName, Font, new SolidBrush(Color.FromArgb(90, Color.DarkRed)), 2, (int)(Height-sz.Height)-2);
			}
		}

		private void Wizard_ControlAdded(object sender, ControlEventArgs e)
		{
			//MessageBox.Show("adding");
			if (!(e.Control is WizardStepPanel)) 
			{
				Controls.Remove(e.Control);
				return;
			}			
			//MessageBox.Show("doadd");

			WizardStepPanel iws = null;
			for (int i=Controls.Count-1; i>=0; i--) 
			{
				Control c = Controls[i];
				if (c is WizardStepPanel) 
				{
					if (iws==null) iws = (WizardStepPanel)c;
					else 
					{
						((WizardStepPanel)c).Last = false;
						((WizardStepPanel)c).Visible = false;
					}
				}
				
			}
			if (iws==null) return;
			if (!this.DesignMode) iws.Client.Visible = false;						

			iws.SetupParent(this);
			iws.Client.Parent = this.WizardContainer;			
			iws.Dock = DockStyle.Fill;			
			iws.Last = true;
			iws.First = (Controls.Count==0);
			iws.Visible = false;						
		}

		private void Wizard_ControlRemoved(object sender, ControlEventArgs e)
		{			
			//MessageBox.Show("removing");
			if (!(e.Control is WizardStepPanel)) return;
			//MessageBox.Show("doremoving");
			WizardStepPanel iws  = (WizardStepPanel)e.Control;
			
			iws.RemoveParent(this);
			iws.Parent = null;
		}

		

	}

	
}
