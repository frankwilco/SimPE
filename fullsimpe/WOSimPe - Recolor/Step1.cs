using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Step1.
	/// </summary>
	public class Step1 : AWizardForm, IWizardEntry
	{
		static RecolorWizardForm dwf;

		/// <summary>
		/// Returns the Main Form
		/// </summary>
		public static RecolorWizardForm Form
		{
			get { 
				if (dwf==null) dwf = new RecolorWizardForm();
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
				return "Use this Wizard to create Recolors of Objects that shipped with The Sims 2.";
			}
		}

		public string WizardCaption
		{
			get
			{
				return "Recolors";
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

		public override System.Windows.Forms.Panel WizardWindow
		{
			get
			{
				return Form.pnwizard1;
			}
		}

		protected override bool Init()
		{
			if (Form.step1==null) Form.step1 = this;
				
			Form.BuildList();
			return true;
		}

		public override string WizardMessage
		{
			get
			{
				return "Select the Object you want to Recolor";
			}
		}

		public override bool CanContinue
		{
			get
			{
				if (Form.selectedlv==null) return false;
				return (Form.selectedlv.SelectedItems.Count>0);
			}
		}

		public override int WizardStep
		{
			get
			{
				return 2;
			}
		}

		public override IWizardForm Next
		{
			get
			{
				if (Form.step1b==null) Form.step1b = new Step1b();
				return Form.step1b;
			}
		}

		#endregion
	}
}
