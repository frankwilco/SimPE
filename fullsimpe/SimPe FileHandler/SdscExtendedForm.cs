using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für SdscExtendedForm.
	/// </summary>
	public class SdscExtendedForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PropertyGrid pg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton rbhex;
		private System.Windows.Forms.RadioButton rbdec;
		private System.Windows.Forms.RadioButton rbbin;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SdscExtendedForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SdscExtendedForm));
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rbhex = new System.Windows.Forms.RadioButton();
			this.rbdec = new System.Windows.Forms.RadioButton();
			this.rbbin = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(8, 40);
			this.pg.Name = "pg";
			this.pg.Size = new System.Drawing.Size(544, 280);
			this.pg.TabIndex = 0;
			this.pg.Text = "propertyGrid1";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rbhex);
			this.panel1.Controls.Add(this.rbdec);
			this.panel1.Controls.Add(this.rbbin);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(544, 32);
			this.panel1.TabIndex = 1;
			// 
			// rbhex
			// 
			this.rbhex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbhex.Location = new System.Drawing.Point(432, 8);
			this.rbhex.Name = "rbhex";
			this.rbhex.TabIndex = 6;
			this.rbhex.Text = "Hexadecimal";
			this.rbhex.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// rbdec
			// 
			this.rbdec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbdec.Location = new System.Drawing.Point(352, 8);
			this.rbdec.Name = "rbdec";
			this.rbdec.Size = new System.Drawing.Size(72, 24);
			this.rbdec.TabIndex = 5;
			this.rbdec.Text = "Decimal";
			this.rbdec.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// rbbin
			// 
			this.rbbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbbin.Location = new System.Drawing.Point(280, 8);
			this.rbbin.Name = "rbbin";
			this.rbbin.Size = new System.Drawing.Size(64, 24);
			this.rbbin.TabIndex = 4;
			this.rbbin.Text = "Binary";
			this.rbbin.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(392, 328);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(477, 328);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// SdscExtendedForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(560, 358);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pg);
			this.DockPadding.All = 8;
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SdscExtendedForm";
			this.Text = "Extended Sdsc Browser";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		Ambertation.PropertyObjectBuilder pob;
		Hashtable names;
		bool propchanged;
		SimPe.Plugin.WantNameLoader wnl;
		short[] shortdata;
		string GetName(int i)
		{
			//string name = Helper.MinStrLength(i.ToString(), 4) + ": ";
            string name = Helper.HexString(0x0a + 2 * i) + ": ";
			name += ((string)names[i]);

			return name;
		}

		void LoadWantTable(SDescVersions version) 
		{			
			wnl = null;
			if (version==SDescVersions.BaseGame) 
			{				
				string flname = System.IO.Path.Combine(PathProvider.Global.GetExpansion(Expansions.BaseGame).InstallFolder, @"TSData\Res\Objects\objects.package");
				if (System.IO.File.Exists(flname))
				{
					SimPe.Packages.File fl = SimPe.Packages.File.LoadFromFile(flname);
					Interfaces.Files.IPackedFileDescriptor pfd = fl.FindFile(0x53545223, 0, 0x7FE59FD0, 0xc8);

					if (pfd!=null) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new Str();
						str.ProcessData(pfd, fl);

						SimPe.PackedFiles.Wrapper.StrItemList list = str.LanguageItems(1);
						string xml = "<wantSimulator>"+Helper.lbr;
						xml += "  <persondata>"+Helper.lbr;
						for (int sid=0; sid<list.Length; sid++)
						{
							SimPe.PackedFiles.Wrapper.StrItem si = list[sid];
							xml += "    <persondata id=\""+(sid+1).ToString()+"\" name=\""+si.Title+"\" /> "+Helper.lbr;
						}
						xml += "  </persondata>"+Helper.lbr;
						xml += "</wantSimulator>"+Helper.lbr;

						wnl = new SimPe.Plugin.WantNameLoader(xml);
					}
				}
			} 			
			
			if (wnl==null) 
			{
				FileTable.FileIndex.Load();
				wnl = new SimPe.Plugin.WantNameLoader(version);
			}
		}

		void ShowData(byte[] data)
		{
			shortdata = new short[(data.Length-0xA) / 2 +1];
			int j=0;
			for (int i=0xa; i<data.Length-1; i +=2) 
			{
				try 
				{
					shortdata[j++] = BitConverter.ToInt16(data, i);
				} 
				catch 
				{
					break;
				}
			}
	
			FileTable.FileIndex.Load();
						

			propchanged = false;
			this.pg.SelectedObject = null;
			
			names = new Hashtable();
			ArrayList ns = wnl.GetNames(SimPe.Plugin.WantType.Undefined);

			
			
			int max = -1;
			foreach (SimPe.Interfaces.IAlias a in ns) 
			{
				max = (int)Math.Max(a.Id, max);
				names[(int)a.Id] = a.Name;							
			}
			max++;
			
			
			Hashtable ht = new Hashtable();
			for (int i=0; i<Math.Min(max, shortdata.Length); i++)
			{
				string name = GetName(i);				
				if (!ht.Contains(name)) ht.Add(name, shortdata[i]);
			}

			pob = new Ambertation.PropertyObjectBuilder(ht);
			this.pg.SelectedObject = pob.Instance;
		}

		void UpdateData(byte[] data)
		{
			if (!propchanged) return;
			propchanged = false;

			try 
			{
				Hashtable ht = pob.Properties;

				for (int i=0; i<shortdata.Length; i++)
				{
					
					string name = GetName(i);					
					if (ht.Contains(name)) shortdata[i] = (short)ht[name];
				}

				int j=0;
				for (int i=0xa; i<data.Length-1; i +=2) 
				{
					try 
					{
						byte[] d = BitConverter.GetBytes(shortdata[j++]);
						data[i] = d[0];
						data[i+1] = d[1];
					} 
					catch 
					{
						break;
					}
				}				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}

		}

		private void DigitChanged(object sender, System.EventArgs e)
		{
			if (rbhex.Checked) Ambertation.BaseChangeShort.DigitBase = 16;
			else if (rbbin.Checked) Ambertation.BaseChangeShort.DigitBase = 2;			
			else Ambertation.BaseChangeShort.DigitBase = 10;

			this.pg.Refresh();		
		}

		private void PropChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			propchanged = true;
		}


		/// <summary>
		/// Execute the Extended Form
		/// </summary>
		/// <param name="wrp">the sdsc you want to show</param>
		/// <returns>true, if something was changed</returns>
		public static bool Execute(SimPe.PackedFiles.Wrapper.SDesc wrp) 
		{
			SdscExtendedForm f = new SdscExtendedForm();
			f.LoadWantTable(wrp.Version);
			byte[] data = wrp.CurrentStateData.ToArray();

			f.rbhex.Checked = (Ambertation.BaseChangeShort.DigitBase==16);
			f.rbbin.Checked = (Ambertation.BaseChangeShort.DigitBase==2);
			f.rbdec.Checked = (!f.rbhex.Checked && !f.rbbin.Checked);
			f.propchanged = false;

			
			f.ShowData(data);
			f.ok = false;
			f.Text += " (version="+wrp.Version.ToString()+")";
			f.ShowDialog();
			
			if (f.ok) 
			{
				f.UpdateData(data);
				wrp.FileDescriptor.UserData = data;
				wrp.ProcessData(wrp.FileDescriptor, wrp.Package);				
			}
			return f.ok;
		}

		bool ok;
		private void button1_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}
