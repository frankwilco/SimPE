using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for HairtonePreferences.
	/// </summary>
	public class HairtonePreferences : PreferencesPanel
	{
		private System.Windows.Forms.CheckBox cbHat;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.ComboBox cbDefaultProxy;
		private System.Windows.Forms.Label label1;

		public HairtonePreferences()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.BuildProxyItemList();

			this.Text = "Hairtone";
			
		}

		void BuildProxyItemList()
		{
			Array values = Enum.GetValues(typeof(HairColor));

			this.SuspendLayout();
			int i = -1;
			
			this.cbDefaultProxy.Items.Add("<unchanged>");

			while (++i < values.Length - 2)
			{
				HairColor key = (HairColor)values.GetValue(i);
				this.cbDefaultProxy.Items.Add(key);
			}

			this.cbDefaultProxy.SelectedIndex = 0;

			this.ResumeLayout();

		}


		protected override void OnSettingsChanged()
		{

			if (this.Settings is HairtoneSettings)
			{
				HairtoneSettings hset = (HairtoneSettings)this.Settings;
				this.SetProxyGuid(hset.DefaultProxy);
				this.cbHat.Checked = hset.IsHat;
			}

		}

		public override void OnCommitSettings()
		{
			if (this.Settings is HairtoneSettings)
			{
				HairtoneSettings hset = (HairtoneSettings)this.Settings;
				if (this.cbDefaultProxy.SelectedIndex == 0)
				{
					hset.DefaultProxy = Guid.Empty;
				}
				else
				{
					object key = this.cbDefaultProxy.SelectedItem;
					hset.DefaultProxy = new Guid(Convert.ToUInt32(key), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}

				hset.IsHat = this.cbHat.Checked;
			}

		}


		void SetProxyGuid(Guid id)
		{
			if (id != Guid.Empty)
			{
				uint index = BitConverter.ToUInt32(id.ToByteArray(), 0); // dirty trick
				if (index < this.cbDefaultProxy.Items.Count)
					this.cbDefaultProxy.SelectedIndex = (int)index;
			}
			else
			{
				this.cbDefaultProxy.SelectedIndex = 0;
			}
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbHat = new System.Windows.Forms.CheckBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.cbDefaultProxy = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbHat
			// 
			this.cbHat.Location = new System.Drawing.Point(184, 24);
			this.cbHat.Name = "cbHat";
			this.cbHat.TabIndex = 16;
			this.cbHat.Text = "Hat";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.cbDefaultProxy);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Location = new System.Drawing.Point(8, 8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(144, 40);
			this.panel3.TabIndex = 15;
			// 
			// cbDefaultProxy
			// 
			this.cbDefaultProxy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDefaultProxy.Location = new System.Drawing.Point(0, 16);
			this.cbDefaultProxy.Name = "cbDefaultProxy";
			this.cbDefaultProxy.Size = new System.Drawing.Size(136, 21);
			this.cbDefaultProxy.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Proxy for Custom colors";
			// 
			// HairtonePreferences
			// 
			this.Controls.Add(this.cbHat);
			this.Controls.Add(this.panel3);
			this.Name = "HairtonePreferences";
			this.Size = new System.Drawing.Size(296, 88);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
