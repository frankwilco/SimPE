using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für RenameForm.
	/// </summary>
	public class RenameForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.LinkLabel llname;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox cbv2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RenameForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(RenameForm));
			this.lv = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.tbname = new System.Windows.Forms.TextBox();
			this.llname = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.cbv2 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.columnHeader1,
																				 this.columnHeader2,
																				 this.columnHeader3});
			this.lv.FullRowSelect = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.LabelEdit = true;
			this.lv.Location = new System.Drawing.Point(16, 88);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(682, 208);
			this.lv.TabIndex = 0;
			this.lv.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 336;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Type";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "original Name";
			this.columnHeader3.Width = 256;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "ModelName:";
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Location = new System.Drawing.Point(24, 32);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(674, 21);
			this.tbname.TabIndex = 2;
			this.tbname.Text = "";
			// 
			// llname
			// 
			this.llname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llname.AutoSize = true;
			this.llname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llname.Location = new System.Drawing.Point(647, 56);
			this.llname.Name = "llname";
			this.llname.Size = new System.Drawing.Size(49, 17);
			this.llname.TabIndex = 4;
			this.llname.TabStop = true;
			this.llname.Text = "Update";
			this.llname.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateNames);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(623, 304);
			this.button1.Name = "button1";
			this.button1.TabIndex = 5;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbv2
			// 
			this.cbv2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbv2.Location = new System.Drawing.Point(16, 304);
			this.cbv2.Name = "cbv2";
			this.cbv2.Size = new System.Drawing.Size(280, 24);
			this.cbv2.TabIndex = 6;
			this.cbv2.Text = "University Ready v2 (sug. by Numenor)";
			// 
			// RenameForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(712, 332);
			this.Controls.Add(this.cbv2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.llname);
			this.Controls.Add(this.tbname);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lv);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "RenameForm";
			this.Text = "Scenegraph rename Wizard";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Find the Modelname of the Original Object
		/// </summary>
		/// <param name="package">The Package containing the Data</param>
		/// <returns>The Modelname</returns>
		public static string FindMainOldName(SimPe.Interfaces.Files.IPackageFile package)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.STRING_FILE);
			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				if (pfd.Instance == 0x85) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
					str.ProcessData(pfd, package);

					if (str.Items.Length>1) 
					{
						return str.Items[1].Title;
					}
				}
			}

			pfds = package.FindFiles(0x4C697E5A);
			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
				cpf.ProcessData(pfd, package);

				if (cpf.GetSaveItem("modelName").StringValue.Trim()!="") return cpf.GetSaveItem("modelName").StringValue.Trim();
				
			}

			return "SimPE";
		}

		public static Hashtable GetNames(bool auto, SimPe.Interfaces.Files.IPackageFile package, ListView lv, string username) 
		{
			if (lv!=null) lv.Items.Clear();
			Hashtable ht = new Hashtable();
			string old = Hashes.StripHashFromName(FindMainOldName(package).ToLower().Trim());
			if (old.EndsWith("_cres")) old = old.Substring(0, old.Length-5);

			//load all Rcol Files
			foreach (uint type in Data.MetaData.RcolList) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(type);
				foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, package);
					string newname = Hashes.StripHashFromName(rcol.FileName.Trim().ToLower());
					if (newname==null) newname="";
					if (newname=="") newname="SimPE_dummy_"+username;
					if (old==null) old = "";
					if (old=="") old = " ";
					if (auto) 
					{
						string secname = newname.Replace(old, username);
						if ((secname==newname) && (old!=username.Trim().ToLower())) secname = username+"__"+secname;
						newname = secname;
					}

					if (lv!=null)
					{
						ListViewItem lvi = new ListViewItem(Hashes.StripHashFromName(newname));
						lvi.SubItems.Add(Data.MetaData.FindTypeAlias(type).shortname);
						lvi.SubItems.Add(Hashes.StripHashFromName(rcol.FileName));

						lv.Items.Add(lvi);
					}

					ht[Hashes.StripHashFromName(rcol.FileName.Trim().ToLower())] = Hashes.StripHashFromName(newname);
				}
			}

			return ht;
		}


		protected  Hashtable GetReplacementMap()
		{
			Hashtable ht = new Hashtable();
			foreach (ListViewItem lvi in lv.Items)
			{
				string oldname = lvi.SubItems[2].Text.Trim().ToLower();
				string newname = lvi.Text.Trim();

				string ext = "_"+lvi.SubItems[1].Text.Trim().ToLower();
				if (!newname.ToLower().EndsWith(ext)) newname = newname + ext;

				ht.Add(Hashes.StripHashFromName(oldname), Hashes.StripHashFromName(newname));
			}

			return ht;
		}

		SimPe.Interfaces.Files.IPackageFile package;
		public static Hashtable Execute(SimPe.Interfaces.Files.IPackageFile package, bool uniquename, ref FixVersion ver) 
		{						
			RenameForm rf = new RenameForm();
			rf.ok = false;
			rf.package = package;
			rf.cbv2.Checked = (ver==FixVersion.UniversityReady2);

			string old = Hashes.StripHashFromName(FindMainOldName(package).ToLower().Trim());
			if (old.IndexOf("_cres")==old.Length-5) old = old.Substring(0, old.Length-5);
			if (uniquename) rf.tbname.Text = old+"-"+System.Guid.NewGuid().ToString();
			else rf.tbname.Text = old;

			GetNames(uniquename, package, rf.lv, rf.tbname.Text);
			rf.ShowDialog();


			if (rf.ok)
			{
				if (rf.cbv2.Checked) ver = FixVersion.UniversityReady2;
				else ver = FixVersion.UniversityReady;
				return rf.GetReplacementMap();
			}
			else 
				return null;
		}

		private void UpdateNames(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			GetNames(true, package, lv, tbname.Text);
		}

		bool ok;
		private void button1_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}
	}
}
