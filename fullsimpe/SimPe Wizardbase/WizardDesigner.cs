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
	internal class WizardDesigner : System.Windows.Forms.Design.ControlDesigner
	{
		public WizardDesigner()
		{
			wz = null;
			
		}

		private DesignerVerbCollection actions;
		public override System.ComponentModel.Design.DesignerVerbCollection Verbs
		{
			get
			{
				if(actions == null)
				{                     
					actions = new DesignerVerbCollection();                      
					actions.Add(new DesignerVerb("&Add Step", new EventHandler(AddStep)));   
					actions.Add(new DesignerVerb("Show &First Step", new EventHandler(ShowFirstStep)));			          
					actions.Add(new DesignerVerb("Show &Prev. Step", new EventHandler(ShowPrevStep)));
          			actions.Add(new DesignerVerb("Show &Next Step", new EventHandler(ShowNextStep)));		          
					actions.Add(new DesignerVerb("Show &Last Step", new EventHandler(ShowLastStep)));	
				}          

				return actions;     
			}
		}

		Wizard wz;
		public override void Initialize(IComponent component)
		{
			base.Initialize (component);
			wz = (Wizard)component;
			
			// Hook up events
			ISelectionService s = (ISelectionService) GetService(
				typeof(ISelectionService));
			IComponentChangeService c = (IComponentChangeService)
				GetService(typeof(IComponentChangeService));
			s.SelectionChanged += new EventHandler(OnSelectionChanged);
			c.ComponentRemoving += new ComponentEventHandler(
				OnComponentRemoving);
		}

		private void OnSelectionChanged(object sender, System.EventArgs e)
		{
			//MyControl.OnSelectionChanged();
		}

		private void OnComponentRemoving(object sender, ComponentEventArgs e)
		{					
			IComponentChangeService c = (IComponentChangeService)
				GetService(typeof(IComponentChangeService));
			WizardStepPanel button;
			IDesignerHost h = (IDesignerHost) GetService(typeof(IDesignerHost));
	
			// If the user is removing a button
			if (e.Component is WizardStepPanel)
			{
				button = (WizardStepPanel) e.Component;
				if (wz.Contains(button))
				{
					c.OnComponentChanging(wz, null);
					wz.Controls.Remove(button);
					c.OnComponentChanged(wz, null, null, null);
					return;
				}
			}
			// If the user is removing the control itself
			if (e.Component == wz)
			{
				for (int i = wz.Controls.Count - 1; i >= 0; i--)
				{
					button = (WizardStepPanel)wz.Controls[i];
					c.OnComponentChanging(wz, null);
					wz.Controls.Remove(button);
					h.DestroyComponent(button);
					c.OnComponentChanged(wz, null, null, null);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			ISelectionService s = (ISelectionService) GetService(
				typeof(ISelectionService));
			IComponentChangeService c = (IComponentChangeService)
				GetService(typeof(IComponentChangeService));
			// Unhook events
			s.SelectionChanged -= new EventHandler(OnSelectionChanged);
			c.ComponentRemoving -= new ComponentEventHandler(
				OnComponentRemoving);
			base.Dispose(disposing);
		}

		public override System.Collections.ICollection AssociatedComponents
		{
			get
			{
				return wz.Controls;
			}
		}

		private void ShowNextStep(object sender, System.EventArgs e)
		{
			wz.GoNext();
		}

		private void ShowPrevStep(object sender, System.EventArgs e)
		{
			wz.GoPrev();
		}

		private void ShowFirstStep(object sender, System.EventArgs e)
		{
			wz.JumpToStep(0);
		}

		private void ShowLastStep(object sender, System.EventArgs e)
		{
			wz.JumpToStep(wz.StepCount-1);
		}

		private void AddStep(object sender, System.EventArgs e)
		{
			WizardStepPanel pn;
			IDesignerHost h = (IDesignerHost) GetService(typeof(IDesignerHost));
	
			DesignerTransaction dt;
			IComponentChangeService c = (IComponentChangeService)
				GetService(typeof(IComponentChangeService));

			// Add a new button to the collection
			dt = h.CreateTransaction("Add Step");
			pn = (WizardStepPanel) h.CreateComponent(typeof(WizardStepPanel));
			((ComponentDesigner) h.GetDesigner(pn)).OnSetComponentDefaults();

			c.OnComponentChanging(wz, TypeDescriptor.GetProperties(this.wz)["Controls"]);
			c.OnComponentChanging(pn, null);
			wz.Controls.Add(pn);			
			c.OnComponentChanged(pn, null, null, null);
			c.OnComponentChanged(wz, TypeDescriptor.GetProperties(this.wz)["Controls"], null, null);
			dt.Commit();
		}		

		public override void OnSetComponentDefaults()
		{
			base.OnSetComponentDefaults ();
		}

	}
}
