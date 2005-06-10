using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// The Form that is displayed when a Meshgroup is imported
	/// </summary>
	internal class ImportGmdcGroupsForm : System.Windows.Forms.Form
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
		private System.Windows.Forms.ColumnHeader chVertex;
		private System.Windows.Forms.ColumnHeader chFace;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbscale;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbopacity;
		private System.Windows.Forms.ColumnHeader chBones;
		private System.Windows.Forms.GroupBox gbbones;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cbboneaction;
		private System.Windows.Forms.Label lbbonename;
		private System.Windows.Forms.ComboBox cbbones;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbcleanbn;
		private System.Windows.Forms.CheckBox cbcleangrp;
		private System.Windows.Forms.CheckBox cbupdatecres;
		/// <summary>
		/// Needed Designervar.
		/// </summary>
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Default Constructor
		/// </summary>
		public ImportGmdcGroupsForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			GmdcImporterAction[] actions = (GmdcImporterAction[])System.Enum.GetValues(typeof(GmdcImporterAction));
			foreach (GmdcImporterAction a in actions) this.cbaction.Items.Add(a);

			//cbboneaction.Items.Add(GmdcImporterAction.Nothing);
			cbboneaction.Items.Add(GmdcImporterAction.Add);
			cbboneaction.Items.Add(GmdcImporterAction.Replace);			
			cbboneaction.Items.Add(GmdcImporterAction.Update);
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
			this.chVertex = new System.Windows.Forms.ColumnHeader();
			this.chFace = new System.Windows.Forms.ColumnHeader();
			this.chBones = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.gbsettings = new System.Windows.Forms.GroupBox();
			this.cbopacity = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbscale = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbaction = new System.Windows.Forms.ComboBox();
			this.lbname = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cbnames = new System.Windows.Forms.ComboBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.gbbones = new System.Windows.Forms.GroupBox();
			this.cbboneaction = new System.Windows.Forms.ComboBox();
			this.lbbonename = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.cbbones = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbupdatecres = new System.Windows.Forms.CheckBox();
			this.cbcleanbn = new System.Windows.Forms.CheckBox();
			this.cbcleangrp = new System.Windows.Forms.CheckBox();
			this.gbsettings.SuspendLayout();
			this.gbbones.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
																				 this.chVertex,
																				 this.chFace,
																				 this.chBones});
			this.lv.FullRowSelect = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 32);
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(486, 420);
			this.lv.TabIndex = 0;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 131;
			// 
			// chAction
			// 
			this.chAction.Text = "Action";
			this.chAction.Width = 71;
			// 
			// chTarget
			// 
			this.chTarget.Text = "Target";
			this.chTarget.Width = 114;
			// 
			// chVertex
			// 
			this.chVertex.Text = "Vertices/Parent Bone";
			this.chVertex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chFace
			// 
			this.chFace.Text = "Faces";
			this.chFace.Width = 49;
			// 
			// chBones
			// 
			this.chBones.Text = "Joints";
			this.chBones.Width = 52;
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
			this.gbsettings.Controls.Add(this.cbopacity);
			this.gbsettings.Controls.Add(this.label5);
			this.gbsettings.Controls.Add(this.tbscale);
			this.gbsettings.Controls.Add(this.label4);
			this.gbsettings.Controls.Add(this.cbaction);
			this.gbsettings.Controls.Add(this.lbname);
			this.gbsettings.Controls.Add(this.label3);
			this.gbsettings.Controls.Add(this.label2);
			this.gbsettings.Controls.Add(this.cbnames);
			this.gbsettings.Controls.Add(this.tbname);
			this.gbsettings.Enabled = false;
			this.gbsettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbsettings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbsettings.Location = new System.Drawing.Point(504, 168);
			this.gbsettings.Name = "gbsettings";
			this.gbsettings.Size = new System.Drawing.Size(280, 152);
			this.gbsettings.TabIndex = 2;
			this.gbsettings.TabStop = false;
			this.gbsettings.Text = "Group Settings:";
			// 
			// cbopacity
			// 
			this.cbopacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbopacity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbopacity.Items.AddRange(new object[] {
														   "Opaque (Normal)",
														   "Shadow",
														   "Invisible"});
			this.cbopacity.Location = new System.Drawing.Point(112, 72);
			this.cbopacity.Name = "cbopacity";
			this.cbopacity.Size = new System.Drawing.Size(160, 21);
			this.cbopacity.TabIndex = 9;
			this.cbopacity.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 23);
			this.label5.TabIndex = 8;
			this.label5.Text = "Opacity:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbscale
			// 
			this.tbscale.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbscale.Location = new System.Drawing.Point(112, 48);
			this.tbscale.Name = "tbscale";
			this.tbscale.ReadOnly = true;
			this.tbscale.Size = new System.Drawing.Size(136, 21);
			this.tbscale.TabIndex = 7;
			this.tbscale.Text = "1";
			this.tbscale.TextChanged += new System.EventHandler(this.tbscale_TextChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Scale:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbaction
			// 
			this.cbaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbaction.Location = new System.Drawing.Point(112, 96);
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
			this.lbname.Text = "---";
			this.lbname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 96);
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
			this.cbnames.Location = new System.Drawing.Point(112, 120);
			this.cbnames.Name = "cbnames";
			this.cbnames.Size = new System.Drawing.Size(160, 21);
			this.cbnames.TabIndex = 5;
			this.cbnames.Visible = false;
			this.cbnames.SelectedIndexChanged += new System.EventHandler(this.cbnames_SelectedIndexChanged);
			// 
			// tbname
			// 
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(112, 120);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(160, 21);
			this.tbname.TabIndex = 4;
			this.tbname.Text = "";
			this.tbname.Visible = false;
			this.tbname.TextChanged += new System.EventHandler(this.tbname_TextChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(710, 436);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// gbbones
			// 
			this.gbbones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbbones.Controls.Add(this.cbboneaction);
			this.gbbones.Controls.Add(this.lbbonename);
			this.gbbones.Controls.Add(this.label9);
			this.gbbones.Controls.Add(this.label10);
			this.gbbones.Controls.Add(this.cbbones);
			this.gbbones.Enabled = false;
			this.gbbones.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbbones.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbbones.Location = new System.Drawing.Point(504, 328);
			this.gbbones.Name = "gbbones";
			this.gbbones.Size = new System.Drawing.Size(280, 104);
			this.gbbones.TabIndex = 10;
			this.gbbones.TabStop = false;
			this.gbbones.Text = "Bone Settings:";
			// 
			// cbboneaction
			// 
			this.cbboneaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbboneaction.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbboneaction.Location = new System.Drawing.Point(112, 48);
			this.cbboneaction.Name = "cbboneaction";
			this.cbboneaction.Size = new System.Drawing.Size(160, 21);
			this.cbboneaction.TabIndex = 3;
			this.cbboneaction.SelectedIndexChanged += new System.EventHandler(this.cbboneaction_SelectedIndexChanged);
			// 
			// lbbonename
			// 
			this.lbbonename.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbbonename.Location = new System.Drawing.Point(112, 24);
			this.lbbonename.Name = "lbbonename";
			this.lbbonename.Size = new System.Drawing.Size(160, 23);
			this.lbbonename.TabIndex = 2;
			this.lbbonename.Text = "---";
			this.lbbonename.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 48);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(88, 23);
			this.label9.TabIndex = 1;
			this.label9.Text = "Action:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(16, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(88, 23);
			this.label10.TabIndex = 0;
			this.label10.Text = "Bone Name:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbbones
			// 
			this.cbbones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbones.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbbones.Location = new System.Drawing.Point(112, 72);
			this.cbbones.Name = "cbbones";
			this.cbbones.Size = new System.Drawing.Size(160, 21);
			this.cbbones.TabIndex = 5;
			this.cbbones.Visible = false;
			this.cbbones.SelectedIndexChanged += new System.EventHandler(this.cbbones_SelectedIndexChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.cbupdatecres);
			this.groupBox1.Controls.Add(this.cbcleanbn);
			this.groupBox1.Controls.Add(this.cbcleangrp);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(502, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 128);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Global Settings:";
			// 
			// cbupdatecres
			// 
			this.cbupdatecres.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbupdatecres.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbupdatecres.Location = new System.Drawing.Point(16, 72);
			this.cbupdatecres.Name = "cbupdatecres";
			this.cbupdatecres.Size = new System.Drawing.Size(260, 48);
			this.cbupdatecres.TabIndex = 2;
			this.cbupdatecres.Text = "Also replace initial Bone Location and Hirarchy. (This can potatially change your" +
				" Original Game Files!)";
			// 
			// cbcleanbn
			// 
			this.cbcleanbn.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbcleanbn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbcleanbn.Location = new System.Drawing.Point(16, 44);
			this.cbcleanbn.Name = "cbcleanbn";
			this.cbcleanbn.Size = new System.Drawing.Size(256, 24);
			this.cbcleanbn.TabIndex = 1;
			this.cbcleanbn.Text = "Remove unref. Joints after Import";
			// 
			// cbcleangrp
			// 
			this.cbcleangrp.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbcleangrp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbcleangrp.Location = new System.Drawing.Point(16, 24);
			this.cbcleangrp.Name = "cbcleangrp";
			this.cbcleangrp.Size = new System.Drawing.Size(224, 24);
			this.cbcleangrp.TabIndex = 0;
			this.cbcleangrp.Text = "Remove all Groups before Import";
			// 
			// ImportGmdcGroupsForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(790, 464);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.gbsettings);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gbbones);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ImportGmdcGroupsForm";
			this.Text = "Mesh Group Importer";
			this.gbsettings.ResumeLayout(false);
			this.gbbones.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
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

		/// <summary>
		/// A Group was selected
		/// </summary>
		void SelectGroup() 
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
				tbscale.Text = a.Scale.ToString("N9");

				if (a.Group.Opacity>=0x10) cbopacity.SelectedIndex = 0;
				else if (a.Group.Opacity>0) cbopacity.SelectedIndex = 1;
				else cbopacity.SelectedIndex = 2;
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		/// <summary>
		/// A Bone was selected
		/// </summary>
		void SelectBone() 
		{
			gbbones.Enabled = true;
			this.Tag = true;
			try 
			{
				ImportedBone a = (ImportedBone)lv.SelectedItems[0].Tag;

				cbboneaction.SelectedIndex = 0;
				for (int i=0; i<cbboneaction.Items.Count; i++)
				{
					GmdcImporterAction ea = (GmdcImporterAction)cbboneaction.Items[i];
					if (ea==a.Action) 
					{
						cbboneaction.SelectedIndex = i;
						break;
					}
				}
				lbbonename.Text = a.ImportedName;
				try 
				{
					cbbones.SelectedIndex = a.TargetIndex;
				} 
				catch 
				{
					cbbones.SelectedIndex = cbbones.Items.Count-1;
				}
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		private void listView1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			gbsettings.Enabled = false;
			gbbones.Enabled = false;
			if (lv.SelectedItems.Count>0) 
			{
				object o = lv.SelectedItems[0].Tag;
				if (o.GetType()==typeof(ImportedGroup)) SelectGroup();
				else SelectBone();
			}	
		}

		/// <summary>
		/// Show the Group Import Dialog
		/// </summary>
		/// <param name="gmdc">The Target Gmdc File</param>
		/// <param name="actions">An array containing all wanted Import Actions</param>
		/// <param name="joints">An array of all Joints that should be imported</param>
		/// <returns>DialogResult.OK or DialogResult.Cancel</returns>
		public static ImportOptions Execute(SimPe.Plugin.GeometryDataContainer gmdc, ImportedGroups actions, ImportedBones joints)
		{
			ImportGmdcGroupsForm f = new ImportGmdcGroupsForm();			
			foreach (GmdcGroup g in gmdc.Groups) f.cbnames.Items.Add(g.Name);
			for (int i=0; i<gmdc.Joints.Length; i++) f.cbbones.Items.Add("Bone "+i.ToString());				

			foreach (ImportedGroup a in actions)
			{
				if (a.TargetName=="") a.TargetName = a.Group.Name;
				ListViewItem lvi = new ListViewItem(a.Group.Name);
				lvi.SubItems.Add(a.Action.ToString());
				lvi.SubItems.Add(a.TargetName);				
				lvi.SubItems.Add(a.VertexCount.ToString());
				lvi.SubItems.Add(a.FaceCount.ToString());
				lvi.SubItems.Add(a.Group.UsedJoints.Count.ToString());
				lvi.Tag = a;
				lvi.ForeColor = a.MarkColor;

				f.lv.Items.Add(lvi);
			}

			int ct = 0;
			foreach (ImportedBone a in joints)
			{
				if (ct<gmdc.Joints.Length && a.TargetIndex==-1) 
				{
					a.TargetIndex = ct;
					a.Action = GmdcImporterAction.Replace;
				}
				ct++;

				ListViewItem lvi = new ListViewItem("(Bone) "+a.ImportedName);
				lvi.SubItems.Add(a.Action.ToString());
				lvi.SubItems.Add("Bone "+a.TargetIndex.ToString());				
				lvi.SubItems.Add(a.ParentName);
				lvi.SubItems.Add("-");
				lvi.SubItems.Add("-");
				lvi.Tag = a;
				lvi.ForeColor = a.MarkColor;

				f.lv.Items.Add(lvi);
			}
			if (f.lv.Items.Count>0) f.lv.Items[0].Selected=true;

			f.ok = false;
			f.ShowDialog();

			//Builk the Result
			DialogResult dr = DialogResult.Cancel;
			if (f.ok) dr =  DialogResult.OK;
			ImportOptions io = new ImportOptions(dr, f.cbcleangrp.Checked, f.cbcleanbn.Checked, f.cbupdatecres.Checked);
			return io;
		}

		void SetMostLikeName(ImportedGroup a)
		{
			if (a.TargetName==null) a.TargetName="";
			if (a.TargetName.Trim()!="") return;

			for (int i=0; i<cbnames.Items.Count; i++) 
			{
				string s = (string)cbnames.Items[i];
				s = s.Trim();
				if (a.Group.Name.ToLower().Trim()==s.ToLower()) 
				{
					a.TargetName = s;
					cbnames.SelectedIndex = i;
					break;
				}
			}
			
		}

		private void cbaction_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count>0) 
			{				
									
				if (this.Tag==null) 
				{
					try 
					{
						for (int i=0; i<lv.SelectedItems.Count; i++)
						{
							object o = lv.SelectedItems[i].Tag;
							if (o.GetType()!=typeof(ImportedGroup)) continue;
							ImportedGroup a = (ImportedGroup)lv.SelectedItems[i].Tag;

							a.Action = (GmdcImporterAction)cbaction.Items[cbaction.SelectedIndex];
							lv.SelectedItems[i].SubItems[1].Text = a.Action.ToString();

							lv.SelectedItems[i].ForeColor = a.MarkColor;

							this.Tag = true;
							if (i==0)  //change Display ony on the first Selected Item
							{
								switch (a.Action) 
								{
									case GmdcImporterAction.Update:
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
								} //switch
							} //if i==0
							
							//try to find a likley Group for the Replace/Update
							if (a.Action==GmdcImporterAction.Replace || a.Action==GmdcImporterAction.Update) 
							{
								SetMostLikeName(a);
								lv.SelectedItems[i].SubItems[2].Text = cbnames.Text;
							}
						} //for i
					}//try
					finally { this.Tag = null; }
				} //if Tag													
			}
		}
	


		private void tbname_TextChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count>0) 
			{				
				try 
				{
					for (int i=0; i<lv.SelectedItems.Count; i++)
					{
						object o = lv.SelectedItems[i].Tag;
						if (o.GetType()!=typeof(ImportedGroup)) continue;
						GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[i].Tag;					
						a.TargetName = tbname.Text;

						lv.SelectedItems[i].SubItems[2].Text = a.TargetName;
					}
				} 
				finally { this.Tag = null; }
			}
		}

		private void cbnames_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count>0) 
			{				
				try 
				{
					for (int i=0; i<lv.SelectedItems.Count; i++)
					{
						object o = lv.SelectedItems[i].Tag;
						if (o.GetType()!=typeof(ImportedGroup)) continue;
						GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[i].Tag;					
						a.TargetName = cbnames.Text;					

						lv.SelectedItems[i].SubItems[2].Text = a.TargetName;
					}
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

		private void tbscale_TextChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count>0) 
			{				
				try 
				{
					for (int i=0; i<lv.SelectedItems.Count; i++)
					{
						object o = lv.SelectedItems[i].Tag;
						if (o.GetType()!=typeof(ImportedGroup)) continue;
						GmdcGroupImporterAction a = (GmdcGroupImporterAction)lv.SelectedItems[i].Tag;					
						a.Scale = Convert.ToSingle(tbscale.Text);

						//lv.SelectedItems[i].SubItems[2].Text = a.TargetName;
					}
				} 
				catch {}
				finally { this.Tag = null; }
			}
		}

		private void textBox1_TextChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count>0) 
			{				
				try 
				{
					for (int i=0; i<lv.SelectedItems.Count; i++)
					{
						object o = lv.SelectedItems[i].Tag;
						if (o.GetType()!=typeof(ImportedGroup)) continue;
						ImportedGroup a = (ImportedGroup)lv.SelectedItems[i].Tag;	
				
						if (cbopacity.SelectedIndex==0) a.Group.Opacity = 0xffffffff;
						else if (cbopacity.SelectedIndex==1) a.Group.Opacity = 3;
						else a.Group.Opacity = 0;						

						//lv.SelectedItems[i].SubItems[2].Text = a.TargetName;
					}
				} 
				catch {}
				finally { this.Tag = null; }
			}
		}

		private void cbboneaction_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count>0) 
			{		
				if (this.Tag==null) 
				{
					try 
					{					
					
						for (int i=0; i<lv.SelectedItems.Count; i++)
						{
							object o = lv.SelectedItems[i].Tag;
							if (o.GetType()!=typeof(ImportedBone)) continue;

							ImportedBone a = (ImportedBone)o;

							a.Action = (GmdcImporterAction)cbboneaction.Items[cbboneaction.SelectedIndex];
							lv.SelectedItems[i].SubItems[1].Text = a.Action.ToString();

							lv.SelectedItems[i].ForeColor = a.MarkColor;

							this.Tag = true;
							if (i==0)  //change Display ony on the first Selected Item
							{
								switch (a.Action) 
								{
									case GmdcImporterAction.Update:
									case GmdcImporterAction.Replace: 
									{										
										cbbones.Visible = true;
										break;
									}									
									default:
									{										
										cbbones.Visible = false;
										break;
									}
								} //switch
							} //if i==0
							
							//try to find a likley Group for the Replace/Update
							/*if (a.Action==GmdcImporterAction.Replace || a.Action==GmdcImporterAction.Update) 
							{
								SetMostLikeName(a);
								lv.SelectedItems[i].SubItems[2].Text = cbnames.Text;
							}*/
						} //for i
								
					} //try
					finally { this.Tag = null; }
				} //if Tag		
			}
		}

		private void cbbones_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			if (lv.SelectedItems.Count>0) 
			{				
				try 
				{
					for (int i=0; i<lv.SelectedItems.Count; i++)
					{
						object o = lv.SelectedItems[i].Tag;
						if (o.GetType()!=typeof(ImportedBone)) continue;

						ImportedBone a = (ImportedBone)o;				
						a.TargetIndex = cbbones.SelectedIndex;					

						lv.SelectedItems[i].SubItems[2].Text = "Bone "+a.TargetIndex.ToString();
					}
				} 
				finally { this.Tag = null; }
			}
		}
	}
}
