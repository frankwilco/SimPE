using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step3 :IWizardFinish
	{
		public Step3()
		{
			
		}
		#region IWizardFinish Member
		public void Finit()
		{
			System.Windows.Forms.MessageBox.Show("Done!");
		}
		#endregion

		#region IWizardForm Member

		public System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Step1.Form.pnwizard3;
			}
		}

		public bool Init(SimPe.Wizards.ChangedContent fkt)
		{
			return true;
		}

		public string WizardMessage
		{
			get
			{
				return "This will be your last Step with the Wizards of SimPE";
			}
		}

		public bool CanContinue
		{
			get
			{
				return true;
			}
		}

		public int WizardStep
		{
			get
			{
				return 4;
			}
		}

		public IWizardForm Next
		{
			get
			{
				return null;
			}
		}

		#endregion
	}
}
