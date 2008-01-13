using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SimPe.Interfaces.Scenegraph;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.UI
{
	public partial class SkinBrowser : PackageBrowser
	{
		public SkinBrowser()
		{
			InitializeComponent();
		}

		public SkinBrowser(FileDatabase database) : this()
		{
			this.FileDatabase = database;

			this.LoadItems();
		}

		protected override Image GetListItemIcon(GenericCpfInfo cpfInfo)
		{
			Image icon = base.GetListItemIcon(cpfInfo);
			if (icon == null)
			{
				icon = Utility.BaseIconTable.GetSkinIcon(cpfInfo.Family);
				cpfInfo.Icon = icon;
			}
			return icon;
		}

	}

}