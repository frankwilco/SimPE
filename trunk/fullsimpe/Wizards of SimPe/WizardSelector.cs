using System;
using System.Collections;

namespace SimPe.Wizards
{
	/// <summary>
	/// Used to find all plugin Wizards
	/// </summary>
	public class WizardSelector
	{
		ArrayList wizards;


		/// <summary>
		/// Create a new Instance
		/// </summary>
		public WizardSelector()
		{
			wizards = new ArrayList();
			LoadWizards();
		}

		/// <summary>
		/// Returns all Loded Wizards
		/// </summary>
		public ArrayList Wizards
		{
			get { return wizards; }
		}

		/// <summary>
		/// Returns the Folder where Wizard Plugins are stored
		/// </summary>
		public string WizardFolder
		{
			get 
			{
				return System.IO.Path.Combine(Helper.SimPePath, "Plugins\\");
			}
		}

		protected void LoadWizards()
		{
			wizards.Clear();
			if (!System.IO.Directory.Exists(WizardFolder)) return;

			string[] plugins = System.IO.Directory.GetFiles(WizardFolder, "*.wizard.dll");
			foreach (string plugin in plugins) 
			{
				object[] objs = SimPe.LoadFileWrappers.LoadPlugins(plugin, typeof(IWizardEntry));
				foreach (object o in objs) 
				{
					IWizardEntry bid = (IWizardEntry)o;
					wizards.Add(bid);
				}
			}
		}
	}
}
