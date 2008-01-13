using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;


namespace SimPe.Plugin.UI
{

	public class PreferencesPanel : System.Windows.Forms.TabPage
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		protected System.ComponentModel.Container components = null;
		private System.Windows.Forms.ToolTip toolTip1;

		private PackageSettings settings;

		public PackageSettings Settings
		{
			get { return this.settings; }
			set 
			{
				this.settings = value;
				this.OnSettingsChanged();
			}
		}

		protected ToolTip ToolTipControl
		{
			get { return this.toolTip1; }
		}
		
		public PreferencesPanel()
		{
			this.components = new System.ComponentModel.Container();
			this.toolTip1 = new ToolTip(this.components);
		}


		protected virtual void OnSettingsChanged()
		{
		}

		public virtual void OnCommitSettings()
		{
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}


	}
}
