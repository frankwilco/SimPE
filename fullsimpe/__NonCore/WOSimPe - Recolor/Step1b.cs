using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step1b : AWizardForm
	{
		

		public Step1b()
		{
			
		}

		#region IWizardForm Member

		public override System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Step1.Form.pnwizard1b;
			}
		}

		protected override bool Init()
		{
			SimPe.Plugin.SubsetSelectForm.ImageSize = new System.Drawing.Size(60, 60);
			return Step1.Form.Recolor();
		}

		public override string WizardMessage
		{
			get
			{
				return "Select the Subsets you want to Recolor and the Basetexture for each Subset";
			}
		}

		public override bool CanContinue
		{
			get
			{
				if (Step1.Form.ssf==null) return false;
				return Step1.Form.ssf.button1.Enabled;
			}
		}

		public override int WizardStep
		{
			get
			{
				return 3;
			}
		}		

		public override IWizardForm Next
		{
			get
			{
				if (Step1.Form.step2==null) Step1.Form.step2 = new Step2();
				return Step1.Form.step2;
			}
		}

		#endregion
	}
}
