using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Zusammenfassung für ImportGmdcGroupsForm.
	/// </summary>
	public class ImportGmdcGroupsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chAction;
		private System.Windows.Forms.ColumnHeader chTarget;
		private System.Windows.Forms.GroupBox gbsettings;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.ComboBox cbaction;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.ComboBox cbnames;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImportGmdcGroupsForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			GmdcImporterAction[] actions = (GmdcImporterAction[])System.Enum.GetValues(typeof(GmdcImporterAction));
			foreach (GmdcImporterAction a in actions) this.cbaction.Items.Add(a);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImportGmdcGroupsForm));
			this.lv = new System.Windows.Forms.ListView();
			this.chName = new System.Windows.Forms.ColumnHeader();
			this.chAction = new System.Windows.Forms.ColumnHeader();
			this.chTarget = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.gbsettings = new System.Windows.Forms.GroupBox();
			this.cbaction = new System.Windows.Forms.ComboBox();
			this.lbname = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbnames = new System.Windows.Forms.ComboBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.gbsettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.chName,
																				 this.chAction,
																				 this.chTarget,
																				 this.columnHeader1,
																				 this.columnHeader2,
																				 this.columnHeader3});
			this.lv.FullRowSelect = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 32);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(368, 280);
			this.lv.TabIndex = 0;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 132;
			// 
			// chAction
			// 
			this.chAction.Text = "Action";
			this.chAction.Width = 71;
			// 
			// chTarget
			// 
			this.chTarget.Text = "Target";
			this.chTarget.Width = 137;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Importable Mesh Groups:";
			// 
			// gbsettings
			// 
			this.gbsettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbsettings.Controls.Add(this.cbaction);
			this.gbsettings.Controls.Add(this.lbname);
			this.gbsettings.Controls.Add(this.label3);
			this.gbsettings.Controls.Add(this.label2);
			this.gbsettings.Controls.Add(this.cbnames);
			this.gbsettings.Controls.Add(this.tbname);
			this.gbsettings.Enabled = false;
			this.gbsettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbsettings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbsettings.Location = new System.Drawing.Point(384, 32);
			this.gbsettings.Name = "gbsettings";
			this.gbsettings.Size = new System.Drawing.Size(280, 104);
			this.gbsettings.TabIndex = 2;
			this.gbsettings.TabStop = false;
			this.gbsettings.Text = "Settings:";
			// 
			// cbaction
			// 
			this.cbaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbaction.Location = new System.Drawing.Point(112, 48);
			this.cbaction.Name = "cbaction";
			this.cbaction.Size = new System.Drawing.Size(160, 21);
			this.cbaction.TabIndex = 3;
			this.cbaction.SelectedIndexChanged += new System.EventHandler(this.cbaction_SelectedIndexChanged);
			// 
			// lbname
			// 
			this.lbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbname.Location = new System.Drawing.Point(112, 24);
			this.lbname.Name = "lbname";
			this.lbname.Size = new System.Drawing.Size(160, 23);
			this.lbname.TabIndex = 2;
			this.lbname.Text = "label4";
			this.lbname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Action:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Group Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbnames
			// 
			this.cbnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbnames.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbnames.Location = new System.Drawing.Point(112, 72);
			this.cbnames.Name = "cbnames";
			this.cbnames.Size = new System.Drawing.Size(160, 21);
			this.cbnames.TabIndex = 5;
			this.cbnames.Visible = false;
			this.cbnames.SelectedIndexChanged += new System.EventHandler(this.cbnames_SelectedIndexChanged);
			// 
			// tbname
			// 
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(112, 72);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(160, 21);
			this.tbname.TabIndex = 4;
			this.tbname.Text = "";
			this.tbname.Visible = false;
			this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(576, 288);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Vertices";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Normals";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "UVCoords";
			// 
			// ImportGmdcGroupsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(672, 318);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gbsettings);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ImportGmdcGroupsForm";
			this.Text = "Mesh Group Importer";
			this.gbsettings.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new ImportGmdcGroupsForm());
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			gbsettings.Enabled = false;
			if (lv.SelectedItems.Count==1) 
			{
				gbsettings.Enabled = true;
				this.Tag = true;
				try 
				{
					ImportedGroup a = (ImportedGroup)lv.SelectedItems[0].Tag;

					this.lbname.Text = a.Group.Name;
					cbaction.SelectedIndex = 0;
					for (int i=0; i<cbaction.Items.Count; i++)
					{
						GmdcImporterAction ea = (GmdcImporterAction)cbaction.Items[i];
						if (ea==a.Action) 
						{
							cbaction.SelectedIndex = i;
							break;
						}
					}
					tbname.Text = a.TargetName;					
				} 
				finally 
				{
					this.Tag = null;
				}
			}

			if (tbname.Text=="") tbname.Text = this.lbname.Text;
		}

		/// <summary>
		/// Show the Group Import Dialog
		/// </summary>
		/// <param name="gmdc">The Target Gmdc File</param>
		/// <param name="actions">An array containing all wanted Import Actions</param>
		/// <returns>DialogResult.OK or DialogResult.Cancel</returns>
		public static DialogResult Execute(SimPe.Plugin.GeometryDataContainer gmdc, ImportedGroups actions)
		{
			ImportGmdcGroupsForm f = new ImportGmdcGroupsForm();			
			foreach (GmdcGroup g in gmdc.Groups) f.cbnames.Items.Add(g.Name);

			foreach (ImportedGroup a in actions)
			{
				ListViewItem lvi = new ListViewItem(a.Group.Name);
				lvi.SubItems.Add(a.Action.ToString());
				lvi.SubItems.Add(a.TargetName);

				//Get Counts
				int vc = 0;
				int vnc = 0;
				int vtc = 0;
				foreach (int i in a.Link.Items1) 
				{
					if (a.Elements[i].Identity == ElementIdentity.Vertex) vc += a.Elements[i].Values.Count;
					else if (a.Elements[i].Identity == ElementIdentity.Normal) vnc += a.Elements[i].Values.Count;
					else if (a.Elements[i].Identity == ElementIdentity.UVCoordinate) vtc += a.Elements[i].Values.Count;
				}

				lvi.SubItems.Add(vc.ToString());
				lvi.SubItems.Add(vnc.ToString());
				lvi.SubItems.Add(vtc.ToString());
				lvi.Tag = a;

				f.lv.Items.Add(lvi);
			}
			if (f.lv.Items.Count>0) f.lv.Items[0].Selected=true;

			f.ok = false;
			f.ShowDialog();

			if (f.ok) return DialogResult.OK;

			return DialogResult.Cancel;
		}

		private void cbaction_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count==1) 
			{				
				try 
				{
					GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[0].Tag;
					if (this.Tag==null) 
					{
						a.Action = (GmdcImporterAction)cbaction.Items[cbaction.SelectedIndex];
						lv.SelectedItems[0].SubItems[1].Text = a.Action.ToString();

						if (a.Action == GmdcImporterAction.Nothing) lv.SelectedItems[0].ForeColor = Color.Silver;
						else lv.SelectedItems[0].ForeColor = SystemColors.WindowText;
					}

					this.Tag = true;
					switch (a.Action) 
					{
						case GmdcImporterAction.Replace: 
						{
							tbname.Visible = false;
							cbnames.Visible = true;
							break;
						}
						case GmdcImporterAction.Rename: 
						{
							tbname.Visible = true;
							cbnames.Visible = false;
							break;
						}
						default:
						{
							tbname.Visible = false;
							cbnames.Visible = false;
							break;
						}
					}
				} 
				finally { this.Tag = null; }
			}
		}


		private void tbname_TextChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count==1) 
			{				
				try 
				{
					GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[0].Tag;					
					a.TargetName = tbname.Text;

					lv.SelectedItems[0].SubItems[2].Text = a.TargetName;
				} 
				finally { this.Tag = null; }
			}
		}

		private void cbnames_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count==1) 
			{				
				try 
				{
					GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[0].Tag;					
					a.TargetName = cbnames.Text;					

					lv.SelectedItems[0].SubItems[2].Text = a.TargetName;
				} 
				finally { this.Tag = null; }
			}
		}

		bool ok;
		private void button1_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}
	}
}
