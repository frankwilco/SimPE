using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Registry Keys for the Object Workshop
	/// </summary>
	class SimsRegistry : System.IDisposable
	{
		XmlRegistryKey xrk;		
		Sims form;
		public SimsRegistry(Sims form)
		{
			this.form = form;
			xrk = Helper.WindowsRegistry.PluginRegistryKey;
			
			form.cbNpc.Checked = this.ShowNPCs;
			form.cbNpc.CheckedChanged += new EventHandler(cbNpc_CheckedChanged);

			form.cbTownie.Checked = this.ShowTownies;
			form.cbTownie.CheckedChanged += new EventHandler(cbTownie_CheckedChanged);

			form.cbdetail.Checked = this.ShowDetails;
			form.cbdetail.CheckedChanged += new EventHandler(cbdetail_CheckedChanged);

			form.sorter.CurrentColumn = this.SortedColumn;
			form.sorter.Sorting = this.SortOrder;
			form.sorter.Changed += new EventHandler(sorter_Changed);
		}

		#region Properties
		public  bool ShowTownies
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				object o = rkf.GetValue("ShowTownies", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				rkf.SetValue("ShowTownies", value);
			}
		}

		public bool ShowNPCs
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				object o = rkf.GetValue("ShowNPCs", false);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				rkf.SetValue("ShowNPCs", value);
			}
		}

		public bool ShowDetails
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				object o = rkf.GetValue("ShowDetails", true);
				return Convert.ToBoolean(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				rkf.SetValue("ShowDetails", value);
			}
		}

		public int SortedColumn
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				object o = rkf.GetValue("SortedColumn", 3);
				return Convert.ToInt32(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				rkf.SetValue("SortedColumn", value);
			}
		}

		public System.Windows.Forms.SortOrder SortOrder
		{
			get 
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				object o = rkf.GetValue("SortOrder", (int)System.Windows.Forms.SortOrder.Ascending);
				return (System.Windows.Forms.SortOrder)Convert.ToInt32(o);
			}
			set
			{
				XmlRegistryKey rkf = xrk.CreateSubKey("SimBrowser");
				rkf.SetValue("SortOrder", (int)value);
			}
		}

		#endregion
		

		#region IDisposable Member

		public void Dispose()
		{
			

			form = null;
			xrk = null;
		}

		#endregion

		private void cbNpc_CheckedChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.CheckBox cb = sender as System.Windows.Forms.CheckBox;
			this.ShowNPCs = cb.Checked;
		}

		private void cbTownie_CheckedChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.CheckBox cb = sender as System.Windows.Forms.CheckBox;
			this.ShowTownies = cb.Checked;
		}

		private void cbdetail_CheckedChanged(object sender, EventArgs e)
		{
			System.Windows.Forms.CheckBox cb = sender as System.Windows.Forms.CheckBox;
			this.ShowDetails = cb.Checked;
		}

		private void sorter_Changed(object sender, EventArgs e)
		{
			SimPe.ColumnSorter cs = sender as SimPe.ColumnSorter;
			this.SortedColumn = cs.CurrentColumn;
			this.SortOrder = cs.Sorting;
		}
	}
}
