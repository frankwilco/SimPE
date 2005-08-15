using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Zusammenfassung für fAnimResourceConst.
	/// </summary>
	public class fAnimResourceConst : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tAnimResourceConst;
		private System.Windows.Forms.GroupBox groupBox12;
		internal System.Windows.Forms.TextBox tb_arc_ver;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.GroupBox groupBox2;
		internal System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.PropertyGrid pg;
		private System.Windows.Forms.LinkLabel llAdd;
		private System.Windows.Forms.LinkLabel llExport;
		private System.Windows.Forms.LinkLabel llImport;
		private System.Windows.Forms.CheckBox checkBox1;
		internal System.Windows.Forms.TabPage tMisc;
		private System.Windows.Forms.LinkLabel llClear;
		private System.Windows.Forms.LinkLabel llTxt;
		internal SimPe.Plugin.Anim.AnimMeshBlockControl ambc;
		internal System.Windows.Forms.TabPage tMesh;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fAnimResourceConst()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			
			llTxt.Visible = Helper.WindowsRegistry.HiddenMode;

			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
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
			this.ambc = new AnimMeshBlockControl();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tAnimResourceConst = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.llTxt = new System.Windows.Forms.LinkLabel();
			this.llClear = new System.Windows.Forms.LinkLabel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tv = new System.Windows.Forms.TreeView();
			this.llAdd = new System.Windows.Forms.LinkLabel();
			this.llExport = new System.Windows.Forms.LinkLabel();
			this.llImport = new System.Windows.Forms.LinkLabel();
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.tMisc = new System.Windows.Forms.TabPage();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.tb_arc_ver = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.tMesh = new System.Windows.Forms.TabPage();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.ambc = new SimPe.Plugin.Anim.AnimMeshBlockControl();
			this.tabControl1.SuspendLayout();
			this.tAnimResourceConst.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tMisc.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.tMesh.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tAnimResourceConst);
			this.tabControl1.Controls.Add(this.tMisc);
			this.tabControl1.Controls.Add(this.tMesh);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 288);
			this.tabControl1.TabIndex = 2;
			// 
			// tAnimResourceConst
			// 
			this.tAnimResourceConst.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tAnimResourceConst.Controls.Add(this.groupBox2);
			this.tAnimResourceConst.Location = new System.Drawing.Point(4, 22);
			this.tAnimResourceConst.Name = "tAnimResourceConst";
			this.tAnimResourceConst.Size = new System.Drawing.Size(792, 262);
			this.tAnimResourceConst.TabIndex = 6;
			this.tAnimResourceConst.Text = "Raw View";
			this.tAnimResourceConst.Visible = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.llTxt);
			this.groupBox2.Controls.Add(this.llClear);
			this.groupBox2.Controls.Add(this.checkBox1);
			this.groupBox2.Controls.Add(this.tv);
			this.groupBox2.Controls.Add(this.llAdd);
			this.groupBox2.Controls.Add(this.llExport);
			this.groupBox2.Controls.Add(this.llImport);
			this.groupBox2.Controls.Add(this.pg);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(776, 248);
			this.groupBox2.TabIndex = 39;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Content";
			// 
			// llTxt
			// 
			this.llTxt.Enabled = false;
			this.llTxt.Location = new System.Drawing.Point(640, 8);
			this.llTxt.Name = "llTxt";
			this.llTxt.Size = new System.Drawing.Size(56, 16);
			this.llTxt.TabIndex = 44;
			this.llTxt.TabStop = true;
			this.llTxt.Text = "Text";
			this.llTxt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTxt_LinkClicked);
			// 
			// llClear
			// 
			this.llClear.Enabled = false;
			this.llClear.Location = new System.Drawing.Point(480, 32);
			this.llClear.Name = "llClear";
			this.llClear.Size = new System.Drawing.Size(88, 16);
			this.llClear.TabIndex = 43;
			this.llClear.TabStop = true;
			this.llClear.Text = "Clear Frames";
			this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
			// 
			// checkBox1
			// 
			this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBox1.Location = new System.Drawing.Point(704, 32);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(56, 16);
			this.checkBox1.TabIndex = 42;
			this.checkBox1.Text = "Help";
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// tv
			// 
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.tv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tv.FullRowSelect = true;
			this.tv.HideSelection = false;
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(8, 24);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(296, 216);
			this.tv.TabIndex = 0;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// llAdd
			// 
			this.llAdd.Enabled = false;
			this.llAdd.Location = new System.Drawing.Point(400, 32);
			this.llAdd.Name = "llAdd";
			this.llAdd.Size = new System.Drawing.Size(80, 16);
			this.llAdd.TabIndex = 2;
			this.llAdd.TabStop = true;
			this.llAdd.Text = "Add Frame";
			this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
			// 
			// llExport
			// 
			this.llExport.Enabled = false;
			this.llExport.Location = new System.Drawing.Point(584, 32);
			this.llExport.Name = "llExport";
			this.llExport.Size = new System.Drawing.Size(48, 16);
			this.llExport.TabIndex = 40;
			this.llExport.TabStop = true;
			this.llExport.Text = "Export";
			this.llExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llExport_LinkClicked);
			// 
			// llImport
			// 
			this.llImport.Enabled = false;
			this.llImport.Location = new System.Drawing.Point(640, 32);
			this.llImport.Name = "llImport";
			this.llImport.Size = new System.Drawing.Size(56, 16);
			this.llImport.TabIndex = 41;
			this.llImport.TabStop = true;
			this.llImport.Text = "Import";
			this.llImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llImport_LinkClicked);
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(312, 24);
			this.pg.Name = "pg";
			this.pg.Size = new System.Drawing.Size(456, 216);
			this.pg.TabIndex = 1;
			this.pg.Text = "pg";
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// tMisc
			// 
			this.tMisc.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tMisc.Controls.Add(this.groupBox12);
			this.tMisc.Location = new System.Drawing.Point(4, 22);
			this.tMisc.Name = "tMisc";
			this.tMisc.Size = new System.Drawing.Size(792, 262);
			this.tMisc.TabIndex = 7;
			this.tMisc.Text = "Misc.";
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.tb_arc_ver);
			this.groupBox12.Controls.Add(this.label30);
			this.groupBox12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(8, 8);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(120, 72);
			this.groupBox12.TabIndex = 12;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Settings";
			// 
			// tb_arc_ver
			// 
			this.tb_arc_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_arc_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_arc_ver.Name = "tb_arc_ver";
			this.tb_arc_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_arc_ver.TabIndex = 24;
			this.tb_arc_ver.Text = "0x00000000";
			this.tb_arc_ver.TextChanged += new System.EventHandler(this.tb_arc_ver_TextChanged);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(8, 24);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(52, 17);
			this.label30.TabIndex = 23;
			this.label30.Text = "Version:";
			// 
			// tMesh
			// 
			this.tMesh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tMesh.Controls.Add(this.xpGradientPanel1);
			this.tMesh.Location = new System.Drawing.Point(4, 22);
			this.tMesh.Name = "tMesh";
			this.tMesh.Size = new System.Drawing.Size(792, 262);
			this.tMesh.TabIndex = 8;
			this.tMesh.Text = "Mesh Animations";
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.ambc);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.DockPadding.All = 8;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(792, 262);
			this.xpGradientPanel1.TabIndex = 2;
			// 
			// ambc
			// 
			this.ambc.BackColor = System.Drawing.Color.Transparent;
			this.ambc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ambc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.ambc.Location = new System.Drawing.Point(8, 8);
			this.ambc.MeshBlock = null;
			this.ambc.MeshBlocks = null;
			this.ambc.Name = "ambc";
			this.ambc.Size = new System.Drawing.Size(776, 246);
			this.ambc.TabIndex = 1;
			this.ambc.Changed += new System.EventHandler(this.ambc_Changed);
			// 
			// fAnimResourceConst
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(816, 350);
			this.Controls.Add(this.tabControl1);
			this.Name = "fAnimResourceConst";
			this.Text = "fAnimResourceConst";
			this.tabControl1.ResumeLayout(false);
			this.tAnimResourceConst.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tMisc.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.tMesh.ResumeLayout(false);
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			llAdd.Enabled = false;
			llTxt.Enabled = false;
			llClear.Enabled = false;
			llExport.Enabled = false;
			llImport.Enabled = false;
			pg.SelectedObject = null;
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;

			pg.SelectedObject = e.Node.Tag;


			if (e.Node.Tag is AnimationMeshBlock) 
			{
				llExport.Enabled = true;
				llImport.Enabled = true;
				llTxt.Enabled = true;
			}
			if (e.Node.Tag is AnimationFrameBlock) 
			{
				llAdd.Enabled = true;
				llClear.Enabled = true;
			}
			if (e.Node.Tag.GetType()==typeof(AnimationFrame[])) 
			{
				llAdd.Enabled = true;
				llClear.Enabled = true;
				/*#if DEBUG
				AnimationFrame[] afs = (AnimationFrame[])e.Node.Tag;

				

				System.IO.StreamWriter sw = System.IO.File.CreateText(@"G:\anim.txt");
				try 
				{

					sw.WriteLine(afs.Length.ToString());
					for (int i=0; i<afs.Length; i++) {
						if (afs[0].Type == FrameType.Translation) 
							sw.WriteLine((i+1).ToString()+" "+
								(afs[i].Float_X * -1 * Helper.WindowsRegistry.ImportExportScaleFactor).ToString("N12", System.Globalization.CultureInfo.InvariantCulture)+" "+
								(afs[i].Float_Z * Helper.WindowsRegistry.ImportExportScaleFactor).ToString("N12", System.Globalization.CultureInfo.InvariantCulture)+" "+
								(afs[i].Float_Y * Helper.WindowsRegistry.ImportExportScaleFactor).ToString("N12", System.Globalization.CultureInfo.InvariantCulture));
						else
							sw.WriteLine((i+1).ToString()+" "+
								(afs[i].Float_X * -1 ).ToString("N12", System.Globalization.CultureInfo.InvariantCulture)+" "+
								(afs[i].Float_Z).ToString("N12", System.Globalization.CultureInfo.InvariantCulture)+" "+
								(afs[i].Float_Y).ToString("N12", System.Globalization.CultureInfo.InvariantCulture));
					}			
				} 
				finally
				{
					sw.Close();
				}
				#endif*/
			}

		}

		private void tb_arc_ver_TextChanged(object sender, System.EventArgs e)
		{
			if (this.tb_arc_ver.Tag==null) return;
			try 
			{
				AbstractRcolBlock arb = (AbstractRcolBlock)this.tAnimResourceConst.Tag;

				arb.Version = Convert.ToUInt32(tb_arc_ver.Text, 16);
				arb.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		private void llAdd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AnimationFrameBlock ab2 = null;
			if (tv.SelectedNode.Tag is AnimationFrameBlock) 
			{
				ab2 = (AnimationFrameBlock)tv.SelectedNode.Tag;
			}
			else 
			{
				ab2 = (AnimationFrameBlock)tv.SelectedNode.Parent.Tag;
			}
			
			if (ab2.AxisCount!=3) return;

			ab2.AddFrame((short)(ab2.GetDuration()+1), 0, 0, 0, false);
		
			AnimResourceConst arc = (AnimResourceConst)tAnimResourceConst.Tag;
			arc.Refresh();
		}

		private void llExport_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AnimationMeshBlock ab1 = (AnimationMeshBlock)tv.SelectedNode.Tag;
			GenericRcol gmdc = ab1.FindUsedGMDC(ab1.FindDefiningCRES());
			if (gmdc!=null) 
			{
				GeometryDataContainer gdc = (GeometryDataContainer)gmdc.Blocks[0];
				gdc.LinkedAnimation = ab1;

				fGeometryDataContainer.StartExport(new System.Windows.Forms.SaveFileDialog(), gdc, ".txt", gdc.Groups, (SimPe.Plugin.Gmdc.ElementSorting)fGeometryDataContainer.DefaultSelectedAxisIndex);
			} 
			else 
			{
				Helper.ExceptionMessage(new Warning("Unable to Find Model File for \""+ab1.Name+"\".", "SimPe was not able to Find the Model File that defines the specified Hirarchy. The Animation will not get exported!"));
			}
		}

		private void llImport_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AnimationMeshBlock ab1 = (AnimationMeshBlock)tv.SelectedNode.Tag;
			GenericRcol gmdc = ab1.FindUsedGMDC(ab1.FindDefiningCRES());
			if (gmdc!=null) 
			{
				GeometryDataContainer gdc = (GeometryDataContainer)gmdc.Blocks[0];
				gdc.LinkedAnimation = ab1;

				fGeometryDataContainer.StartImport(new System.Windows.Forms.OpenFileDialog(), gdc, ".txt", (SimPe.Plugin.Gmdc.ElementSorting)fGeometryDataContainer.DefaultSelectedAxisIndex, true);				
			} 
			else 
			{
				Helper.ExceptionMessage(new Warning("Unable to Find Model File for \""+ab1.Name+"\".", "SimPe was not able to Find the Model File that defines the specified Hirarchy. The Animation will not get exported!"));
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			pg.HelpVisible = checkBox1.Checked;
		}

		private void llClear_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AnimationFrameBlock ab2 = null;
			if (tv.SelectedNode.Tag is AnimationFrameBlock) ab2 = (AnimationFrameBlock)tv.SelectedNode.Tag;
			else ab2 = (AnimationFrameBlock)tv.SelectedNode.Parent.Tag;
			
			ab2.ClearFrames();
		
			AnimResourceConst arc = (AnimResourceConst)tAnimResourceConst.Tag;
			arc.Refresh();
		}

		private void llTxt_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{

			AnimationMeshBlock ab1 = (AnimationMeshBlock)tv.SelectedNode.Tag;
			SaveFileDialog ofd = new SaveFileDialog();
			ofd.Filter = "TextFile (*.txt)|*.txt|All Files (*.*)|*.*";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamWriter sw = System.IO.File.CreateText(ofd.FileName);
				try 
				{
					sw.WriteLine(ab1.Name+"-----------------------------------");
					foreach (AnimationFrameBlock ab2 in ab1.Part2)
					{
						sw.WriteLine("--------------- "+ab2.ToString()+" ---------------");
						foreach (AnimationAxisTransformBlock aatb in ab2.AxisSet)
						{
							sw.WriteLine("    "+aatb.ToString()+":");
							foreach (AnimationAxisTransform aat in aatb)
							{
								sw.WriteLine("        "+aat.ToString());
							}
						}	
					}
				}
				finally
				{
					sw.Close();
				}
			
			}
		}

		private void ambc_Changed(object sender, System.EventArgs e)
		{
			AnimResourceConst arc = (AnimResourceConst)tMesh.Tag;
			arc.Parent.Changed = true;
		}
	}
}
