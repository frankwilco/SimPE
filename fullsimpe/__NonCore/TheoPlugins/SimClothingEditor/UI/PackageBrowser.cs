using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SimPe.Data;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;


namespace SimPe.Plugin.UI
{
	public partial class PackageBrowser : Form
	{
		private List<ListViewItem> hiddenItems;
		private Dictionary<ListViewItem, int> hiddenItemIndexes;
		private PackageBrowserSettings settings;
		private FileDatabase database;

		public GenericCpfInfo SelectedItem
		{
			get
			{
				if (this.lvPackage.SelectedItems.Count > 0)
					return (GenericCpfInfo)this.lvPackage.SelectedItems[0].Tag;
				return null;
			}
		}


		protected List<ListViewItem> HiddenItems
		{
			get { return this.hiddenItems; }
		}

		public ListView ListControl
		{
			get { return this.lvPackage; }
		}

		public PackageBrowserSettings Settings
		{
			get { return this.settings; }
		}

		public FileDatabase FileDatabase
		{
			get { return this.database; }
			set { this.database = value; }
		}

		public PackageBrowser()
		{
			InitializeComponent();

			this.settings = PackageBrowserSettings.Instance;

			this.hiddenItems = new List<ListViewItem>();
			this.hiddenItemIndexes = new Dictionary<ListViewItem, int>();

			this.SetupControl();
		}

		void SetupControl()
		{
			EnumLocalizer e = new EnumLocalizer(typeof(View));

			if (OSFeature.Feature.GetVersionPresent(OSFeature.Themes) != null)
				this.tscbViewMode.Items.Add(e[View.Tile]);
			this.tscbViewMode.Items.Add(e[View.LargeIcon]);
			this.tscbViewMode.Items.Add(e[View.SmallIcon]);
			this.tscbViewMode.Items.Add(e[View.List]);
			this.tscbViewMode.Items.Add(e[View.Details]);

			View mode = this.Settings.ViewMode;
			for (int i = 0; i < this.tscbViewMode.Items.Count; i++)
			{
				EnumDescription option = (EnumDescription)this.tscbViewMode.Items[i];
				if (option.Value.Equals(mode))
				{
					this.tscbViewMode.SelectedIndex = i;
					break;
				}
			}


			this.showHiddenItemsToolStripMenuItem.Checked = this.Settings.ShowHiddenItems;
		}


		public void LoadItems()
		{
			WaitingScreen.Wait();
			try
			{
				if (!FileTable.FileIndex.Loaded)
					FileTable.FileIndex.Load();

				this.lvPackage.BeginUpdate();

				List<GenericCpfInfo> items = this.database.Items;
				for (int i = 0; i < items.Count; i++)
				{
					this.AddItem(items[i]);
				}

			}
			catch //(Exception x)
			{
			}
			finally
			{
				this.lvPackage.EndUpdate();
				WaitingScreen.Stop();
			}
		}

		void AddItem(GenericCpfInfo item)
		{
			ListViewItem lvi = this.CreateListItem(item);
			if (!
					(
						lvi == null
				||	(this.HiddenItems.Contains(lvi) && !this.Settings.ShowHiddenItems)
					)
				)
				this.ListControl.Items.Add(lvi);

		}

		protected virtual ListViewItem CreateListItem(GenericCpfInfo cpfInfo)
		{
			ListViewItem ret = new ListViewItem(System.IO.Path.GetFileName(cpfInfo.PropertySet.Package.FileName));
			ret.ToolTipText = String.Format("Name: {0}\r\nFamily: {1}", cpfInfo.Name, cpfInfo.Family);
			ret.Tag = cpfInfo;
			ret.SubItems.Add(cpfInfo.Name);
			ret.SubItems.Add(cpfInfo.Family.ToString());
			ret.SubItems.Add(cpfInfo.GeneticWeight.ToString());
			
			Image icon = this.GetListItemIcon(cpfInfo);
			if (icon != null)
			{
				ilPackage.Images.Add(ImageLoader.Preview(icon, ilPackage.ImageSize));
				ilPackageSmall.Images.Add(ImageLoader.Preview(icon, ilPackageSmall.ImageSize));
				ret.ImageIndex = ilPackage.Images.Count - 1;
			}

			if ((cpfInfo.Flags & CpfFlags.HideFromCatalog) == CpfFlags.HideFromCatalog)
				this.hiddenItems.Add(ret);

			return ret;
		}

		protected virtual Image GetListItemIcon(GenericCpfInfo cpfInfo)
		{
			return cpfInfo.Icon;
		}


		protected void ProcessListItems(bool showHidden)
		{
			this.lvPackage.BeginUpdate();
			if (!showHidden)
			{
				foreach (ListViewItem item in this.hiddenItems)
					this.hiddenItemIndexes[item] = item.Index;

				foreach (ListViewItem item in this.hiddenItems)
					item.Remove();
			}
			else
			{
				foreach (ListViewItem item in this.hiddenItems)
				{
					if (this.hiddenItemIndexes.ContainsKey(item))
						this.lvPackage.Items.Insert(this.hiddenItemIndexes[item], item);
					else
						this.lvPackage.Items.Add(item);
				}
			}
			this.lvPackage.EndUpdate();
		}


		#region Event Handlers

		/*
		 * Exit functions
		 */
		private void btCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void lvPackage_DoubleClick(object sender, EventArgs e)
		{
			if (this.lvPackage.SelectedItems.Count > 0)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void lvPackage_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (
				e.KeyChar == (char)Keys.Enter &&
				lvPackage.SelectedItems.Count > 0
				)
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}



		/*
		 * Add package file
		 */
		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.dlgOpenPackage.ShowDialog();
		}

		private void dlgOpenPackage_FileOk(object sender, CancelEventArgs e)
		{
			if (!e.Cancel)
			{
				if (this.dlgOpenPackage.FileNames.Length > 0)
				{
					for (int i = 0; i < this.dlgOpenPackage.FileNames.Length; i++)
					{
						string filename = this.dlgOpenPackage.FileNames[i];

						int newIndex = this.database.Items.Count;

						this.database.AddPackage(filename);

						int count = this.database.Items.Count;

						for (int j = newIndex; j < count; j++)
						{
							this.AddItem(this.database.Items[j]);
						}

						
						
					}

				}

			}

		}



		/*
		 * Change view
		 */
		private void tscbViewMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnumDescription option = (EnumDescription)this.tscbViewMode.SelectedItem;
			this.Settings.ViewMode = (View)option.Value;
			this.lvPackage.BeginUpdate();
			this.lvPackage.View = (View)option.Value;
			switch (this.lvPackage.View)
			{
				case View.Tile:
				case View.LargeIcon:
					this.lvPackage.Alignment = ListViewAlignment.Top;
					break;

				case View.List:
				case View.SmallIcon:
					this.lvPackage.Alignment = ListViewAlignment.Left;
					break;

				default:
					this.lvPackage.Alignment = ListViewAlignment.Default;
					break;
			}
			this.lvPackage.EndUpdate();
		}

		private void showHiddenItemsToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			bool showHidden = this.showHiddenItemsToolStripMenuItem.Checked;
			this.Settings.ShowHiddenItems = showHidden;

			ProcessListItems(showHidden);
		}


		/*
		 * List Sorting
		 */
		private void Handle_ListView_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			ListView lv = sender as ListView;
			if (lv != null)
			{
				if (lv.ListViewItemSorter == null)
					lv.ListViewItemSorter = new ColumnSorter();

				ColumnSorter cmp = lv.ListViewItemSorter as ColumnSorter;
				if (cmp.CurrentColumn != e.Column)
				{
					cmp.CurrentColumn = e.Column;
					cmp.Sorting = SortOrder.Descending; // reset order on column change
				}

				cmp.Sorting ^= (SortOrder.Ascending | SortOrder.Descending); // toggle me

				lv.Sort();
			}
		}



		/*
		 * Listview Misc.
		 */
		private void lvPackage_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		#endregion




	}

}