using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step1 :IWizardEntry
	{
		static DemoWizardForm dwf;

		/// <summary>
		/// Returns the Main Form
		/// </summary>
		public static DemoWizardForm Form
		{
			get { 
				if (dwf==null) dwf = new DemoWizardForm();
				return dwf; 
			}
		}

		public Step1()
		{
			
		}

		#region IWizardEntry Member

		public string WizardDescription
		{
			get
			{
				return "This Wizard was created for testing purpose. To see if the Infrastructure works.";
			}
		}

		public string WizardCaption
		{
			get
			{
				return "Start the Demo";
			}
		}

		public System.Drawing.Image WizardImage
		{
			get
			{
				return Form.pb.Image;
			}
		}

		#endregion

		#region IWizardForm Member

		public System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Form.pnwizard1;
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
				return "This will be your first Step with the Wizards of SimPE";
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
				return 2;
			}
		}

		public IWizardForm Next
		{
			get
			{
				if (Form.step2==null) Form.step2 = new Step2();
				return Form.step2;
			}
		}

		#endregion
	}
}
