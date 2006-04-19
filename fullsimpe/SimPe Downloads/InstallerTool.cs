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
	public class InstallerTool : SimPe.Interfaces.IToolPlus
	{		
		public InstallerTool()
		{
		}
		#region IToolPlus Member

		public void Execute(object sender, SimPe.Events.ResourceEventArgs e)
		{
			InstallerForm f = new InstallerForm();
			f.ShowDialog();
		}

		public bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			return true;
		}

		#endregion

		#region IToolExt Member

		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{				
				return System.Windows.Forms.Shortcut.CtrlShiftI;
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
                System.IO.Stream s = this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Downloads.setup.png");
                if (s == null) return null;
				return System.Drawing.Image.FromStream(s);
			}
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Content Preview...";
		}

		#endregion
	}
}
