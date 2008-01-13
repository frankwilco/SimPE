using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.UI.Controls
{
	public partial class PackageSelector : UserControl
	{
		[Category("Behavior")]
		public event EventHandler SelectedItemChanged;

		[Category("Behavior")]
		public event EventHandler<ObjectBuilderEventArgs<PackageBrowser>> CreatePackageBrowser;


		FileDatabase files;
		GenericCpfInfo selectedItem;

		public FileDatabase FileDatabase
		{
			get { return this.files; }
			set { this.files = value; }
		}

		public GenericCpfInfo SelectedItem
		{
			get { return this.selectedItem; }
		}



	

		public PackageSelector()
		{
			InitializeComponent();
		}

		#region Event Handlers

		/*
		 * Select Skintone
		 */
		private void SelectPackage(object sender, EventArgs e)
		{
			WaitingScreen.Wait();
			// TODO: Localize message
			WaitingScreen.UpdateMessage("Loading...");

			ObjectBuilderEventArgs<PackageBrowser> args = new ObjectBuilderEventArgs<PackageBrowser>();
			this.OnCreatePackageBrowser(args);
			if (args.Object != null)
			{
				PackageBrowser browser = args.Object;
				browser.FormClosed += new FormClosedEventHandler(packageBrowser_FormClosed);
				browser.Show(this);
			}
			
			WaitingScreen.Stop();
		}

		void packageBrowser_FormClosed(object sender, FormClosedEventArgs e)
		{
			PackageBrowser browser = (PackageBrowser)sender;
			DialogResult result = browser.DialogResult;
			if (result == DialogResult.OK)
			{
				selectedItem = browser.SelectedItem;
				if (selectedItem != null)
				{
					this.pbPackageIcon.Image = ImageLoader.Preview(selectedItem.Icon, this.pbPackageIcon.Size);
					this.toolTip1.SetToolTip(this.pbPackageIcon, String.Format("Name: {0}\r\nFamily: {1}", selectedItem.Name, selectedItem.Family));
				}
				
				this.OnSelectedItemChanged(EventArgs.Empty);
			}

		}

		private void pbPackage_Click(object sender, EventArgs e)
		{
			this.SelectPackage(sender, null);
		}

		private void RemovePackage(object sender, EventArgs e)
		{
			this.selectedItem = null;
			this.pbPackageIcon.Image = null;
			this.toolTip1.RemoveAll();
			this.OnSelectedItemChanged(EventArgs.Empty);
		}

		#endregion

		protected void OnSelectedItemChanged(EventArgs e)
		{
			if (this.SelectedItemChanged != null)
				this.SelectedItemChanged(this, e);
		}

		protected void OnCreatePackageBrowser(ObjectBuilderEventArgs<PackageBrowser> e)
		{
			if (this.CreatePackageBrowser != null)
				this.CreatePackageBrowser(this, e);
		}


	}


	public class ObjectBuilderEventArgs<T> : EventArgs
	{
		T obj;

		public T Object
		{
			get { return this.obj; }
			set { this.obj = value; }
		}

		public ObjectBuilderEventArgs()
		{
		}

	}

}
