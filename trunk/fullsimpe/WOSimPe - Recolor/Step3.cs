using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step3 :AWizardForm, IWizardFinish
	{
		public Step3()
		{
			
		}
		#region IWizardFinish Member
		public void Finit()
		{
			Step1.Form.SaveRecolor();
			System.Windows.Forms.MessageBox.Show("The Recolor was saved.");
		}
		#endregion

		#region IWizardForm Member

		public override System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Step1.Form.pnwizard3;
			}
		}

		protected override bool Init()
		{
			Step1.Form.lberr.Visible = System.IO.File.Exists(Step1.Form.GetPackageFilename);
			return true;
		}

		public override string WizardMessage
		{
			get
			{
				return "Specify the Name of your Recolor";
			}
		}

		public override bool CanContinue
		{
			get
			{
				return ((!System.IO.File.Exists(Step1.Form.GetPackageFilename)) || (Step1.Form.cbover.Checked));
			}
		}

		public override int WizardStep
		{
			get
			{
				return 5;
			}
		}

		public override IWizardForm Next
		{
			get
			{
				return null;
			}
		}

		#endregion
	}
}
