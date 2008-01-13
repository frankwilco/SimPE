using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimPe.Data;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin.UI
{
	public partial class FilePackageView : UserControl
	{

		public ListView FileListView
		{
			get { return this.lvPackages; }
		}

		public ListView PropertyListView
		{
			get { return this.lvPropertySet; }
		}


		public FilePackageView()
		{
			InitializeComponent();
		}


		public void AddPackageFile(IPackageFile package)
		{
		}


		ListViewItem CreateListItem(RecolorItem item)
		{
			ListViewItem li = new ListViewItem();
			li.Text = item.Name;
			li.SubItems.Add(item.Gender.ToString());
			li.SubItems.Add(Enum.Format(typeof(Ages), item.Age, "G"));
			li.SubItems.Add(item.Materials.Count.ToString());
			li.Tag = item;
			li.ToolTipText = String.Format("Original hairtone: {0}", item.Hairtone);

			li.Checked = item.Enabled;
			if (item.HasChanges)
				li.Font = new Font(li.Font, FontStyle.Italic);
			return li;
		}

	}
}
