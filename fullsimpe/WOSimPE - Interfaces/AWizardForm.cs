using System;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für AWizardForm.
	/// </summary>
	public abstract class AWizardForm : IWizardForm
	{
		/// <summary>
		/// The Update delegate
		/// </summary>
		protected SimPe.Wizards.ChangedContent update;
		

		/// <summary>
		/// Triggers the Update Delegate
		/// </summary>
		public void Update()
		{
			Update(false);
		}

		/// <summary>
		/// Triggers the Update Delegate
		/// </summary>
		public void Update(bool autonext)
		{
			if (update!=null) update(this, autonext);
		}

		/// <summary>
		/// Called in the normal Init method
		/// </summary>
		protected abstract bool Init();
		#region IWizardForm Member

		public abstract System.Windows.Forms.Panel WizardWindow
		{
			get;
		}

		public abstract string WizardMessage
		{
			get;
		}

		public abstract int WizardStep
		{
			get;
		}

		public bool Init(SimPe.Wizards.ChangedContent fkt)
		{
			update = fkt;
			return Init();
		}

		public abstract IWizardForm Next
		{
			get;
		}

		public abstract bool CanContinue
		{
			get;
		}

		#endregion
	}
}
