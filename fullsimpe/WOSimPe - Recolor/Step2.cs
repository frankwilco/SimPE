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
			Step1.Form.Recolor2();			
			return true;
		}

		public override string WizardMessage
		{
			get
			{
				return "Recolor the loaded texture Files";
			}
		}

		public override bool CanContinue
		{
			get
			{
				return (Step1.Form.lv.Items.Count>0);
			}
		}

		public override int WizardStep
		{
			get
			{
				return 4;
			}
		}

		public override IWizardForm Next
		{
			get
			{
				if (Step1.Form.step3==null) Step1.Form.step3 = new Step3();
				return Step1.Form.step3;
			}
		}

		#endregion
	}
}
