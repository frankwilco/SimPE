using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Files;
using SimPe.Interfaces;
using SimPe.Packages;

namespace SimPe.Plugin.UI
{
	public partial class MainForm : Form
	{
		IPackedFileDescriptor pfd;
		IPackageFile package;
		IProviderRegistry prov;

		public MainForm()
		{
			InitializeComponent();
		}

		public IToolResult Execute(ref IPackedFileDescriptor pfd, ref IPackageFile package, IProviderRegistry prov)
		{
			this.Cursor = Cursors.WaitCursor;

			this.pfd = null;
			this.prov = prov;
			this.package = package;

			this.Cursor = Cursors.Default;

			RemoteControl.ShowSubForm(this);

			return new ToolResult(false, false);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			if (!e.Cancel)
			{
				string filename = this.openFileDialog1.FileName;

				File simPackage = File.LoadFromFile(filename);
				if (simPackage != null)
				{
					this.clothingEditor1.SimPackage = simPackage;
				}

			}

		}


	}
}