using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step2 : AWizardForm
	{
		

		public Step2()
		{
			
		}

		#region IWizardForm Member

		public override System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Step1.Form.pnwizard2;
			}
		}

		protected override bool Init()
		{
			return true;
		}

		public override string WizardMessage
		{
			get
			{
				return "This will be your second Step with the Wizards of SimPE";
			}
		}

		public override bool CanContinue
		{
			get
			{
				return Step1.Form.cbstep2.Checked;
			}
		}

		public override int WizardStep
		{
			get
			{
				return 3;
			}
		}

		Step3 step3;
		public override IWizardForm Next
		{
			get
			{
				if (step3==null) step3 = new Step3();
				return step3;
			}
		}

		#endregion
	}
}
