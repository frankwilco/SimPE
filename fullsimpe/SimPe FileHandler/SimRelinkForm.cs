using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für SimRelinkForm.
	/// </summary>
	public class SimRelinkForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox cbfile;
		private System.Windows.Forms.Button btlink;
		private System.ComponentModel.IContainer components;

		public SimRelinkForm()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SimRelinkForm));
			this.label1 = new System.Windows.Forms.Label();
			this.lv = new System.Windows.Forms.ListView();
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.cbfile = new System.Windows.Forms.CheckBox();
			this.btlink = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Character File:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.HideSelection = false;
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = new System.Drawing.Point(32, 96);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(392, 176);
			this.lv.TabIndex = 1;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
			// 
			// ilist
			// 
			this.ilist.ImageSize = new System.Drawing.Size(64, 64);
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(408, 64);
			this.label2.TabIndex = 2;
			this.label2.Text = "Relinking a Sim is a dangerous Task. If you link a Character File to this Sim, al" +
				"l Sims that are currently linked to that File will disapear!!! So Please think t" +
				"wice before Relinking a Sim, and make sure you have a Backup copy!";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbfile
			// 
			this.cbfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbfile.Checked = true;
			this.cbfile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbfile.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbfile.Location = new System.Drawing.Point(16, 280);
			this.cbfile.Name = "cbfile";
			this.cbfile.Size = new System.Drawing.Size(168, 24);
			this.cbfile.TabIndex = 3;
			this.cbfile.Text = "Change in Character File";
			// 
			// btlink
			// 
			this.btlink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btlink.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btlink.Location = new System.Drawing.Point(349, 280);
			this.btlink.Name = "btlink";
			this.btlink.TabIndex = 4;
			this.btlink.Text = "Relink";
			this.btlink.Click += new System.EventHandler(this.btlink_Click);
			// 
			// SimRelinkForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(432, 310);
			this.Controls.Add(this.btlink);
			this.Controls.Add(this.cbfile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SimRelinkForm";
			this.Text = "SimRelinkForm";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Returns the Path where you can Find the Character Files in
		/// </summary>
		/// <param name="neighborhoodfl"></param>
		/// <returns></returns>
		public static string GetCharacterPath(string neighborhoodfl)
		{
			string path = System.IO.Path.GetDirectoryName(neighborhoodfl);
			return System.IO.Path.Combine(path, "Characters");
		}

		bool ok = false;

		/// <summary>
		/// Show the Relink Screen
		/// </summary>
		/// <param name="path">The Path where to look for character Files</param>
		/// <param name="wrp">The Sim Description Wrapper</param>
		/// <returns>The new SimID</returns>
		public static uint Execute(SimPe.PackedFiles.Wrapper.SDesc wrp) 
		{
			WaitingScreen.Wait();
			Hashtable ht = wrp.nameprovider.StoredData;
			
			SimRelinkForm srf = new SimRelinkForm();
			foreach (SimPe.Data.Alias a in ht.Values){
				ListViewItem lvi = new ListViewItem(a.Name + " "+(string)a.Tag[2]);
				lvi.Tag = a;

				if (a.Tag[1]!=null) 
				{
					lvi.ImageIndex = srf.ilist.Images.Count;
					Image img = SimPe.Plugin.ImageLoader.Preview((Image)a.Tag[1], srf.ilist.ImageSize);

					if (wrp.sdescprovider.FindSim(a.Id)!=null) 
					{
						Graphics gr = Graphics.FromImage(img);
						gr.FillRectangle(new Pen(Color.FromArgb(0x60, Color.Red), 1).Brush, 0, 0, img.Width, img.Height);
					}

					srf.ilist.Images.Add(img);					
				}

				srf.lv.Items.Add(lvi);
			}
			srf.lv.Sort();
			srf.btlink.Enabled = false;
			srf.ok = false;
			WaitingScreen.Stop(srf);

			srf.ShowDialog();

			if (srf.ok) 
			{
				SimPe.Data.Alias a = (SimPe.Data.Alias)srf.lv.SelectedItems[0].Tag;
				SimPe.Packages.GeneratableFile pkg = new SimPe.Packages.GeneratableFile((string)a.Tag[0]);

				Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.OBJD_FILE);
				if (pfds.Length==1) 
				{
					SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
					objd.ProcessData(pfds[0], pkg);

					if (srf.cbfile.Checked) 
					{
						objd.Guid = wrp.SimId;
						objd.SynchronizeUserData();
						pkg.Save();
					} 
					else 
					{
						wrp.SimId = objd.Guid;
					}
				}
			}

			return wrp.SimId;
	}

		private void lv_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			btlink.Enabled = (lv.SelectedItems.Count==1);
		}

		private void btlink_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}
	}
}
