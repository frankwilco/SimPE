using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace SimPe.Plugin.Tool.Window
{
	/// <summary>
	/// Tool that should automatically repair corrupted packages
	/// </summary>
	public class PackageRepairTool : SimPe.Interfaces.IToolPlus
	{		
		public PackageRepairTool()
		{
		}
		#region IToolPlus Member

		public void Execute(object sender, SimPe.Events.ResourceEventArgs e)
		{
			PackageRepairForm f = new PackageRepairForm();
			if (e.Loaded) 
			{
				string flname = e.LoadedPackage.Package.SaveFileName;
				e.LoadedPackage.Package.Close(true);
				f.Setup(flname);
			}
			f.ShowDialog();
		}

		public bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			return !e.Loaded;
		}

		#endregion

		#region IToolExt Member

		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{				
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public bool Visible
		{
			get
			{
				return true;
			}
		}

		public Image Icon
		{
			get
			{
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.repair.png"));
			}
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Package Tool\\Repair Package...";
		}

		#endregion
	}
}
