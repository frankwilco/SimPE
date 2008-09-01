/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 Peter L Jones                                      *
 *   pljones@users.sf.net                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für LtxtForm.
	/// </summary>
	public class LtxtForm : System.Windows.Forms.Form
    {
        #region Form controls
        internal System.Windows.Forms.Panel ltxtPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox tblotname;
        internal System.Windows.Forms.TextBox tbdesc;
		internal System.Windows.Forms.TextBox tbRoads;
		internal System.Windows.Forms.ComboBox cbtype;
		internal System.Windows.Forms.TextBox tbrotation;
		internal System.Windows.Forms.TextBox tbtype;
		internal System.Windows.Forms.TextBox tbver;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbsubver;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbhg;
		internal System.Windows.Forms.TextBox tbwd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox tbtop;
		internal System.Windows.Forms.TextBox tbleft;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		internal Ambertation.Windows.Forms.EnumComboBox cborient;
		internal System.Windows.Forms.TextBox tbinst;
        private System.Windows.Forms.Label label15;
		internal System.Windows.Forms.TextBox tbu2;
		private System.Windows.Forms.Label label18;
		internal System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		internal System.Windows.Forms.TextBox tbz;
		internal System.Windows.Forms.TextBox tbData;
		internal System.Windows.Forms.TextBox tbu0;
		private System.Windows.Forms.Label label21;
		internal System.Windows.Forms.PictureBox pb;
        internal TextBox tbu4;
        private Label label22;
        internal TextBox tbu3;
        private Label label16;
        internal TextBox tbTexture;
        private Label label6;
        private Label label24;
        private Label label25;
        internal TextBox tbowner;
        internal TextBox tbu5;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public LtxtForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			wrapper = null;
            this.cborient.ResourceManager = SimPe.Localization.Manager;
            this.cborient.Enum = typeof(Plugin.LotOrientation);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LtxtForm));
            this.ltxtPanel = new System.Windows.Forms.Panel();
            this.tbu4 = new System.Windows.Forms.TextBox();
            this.tbu5 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbowner = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbu3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbu0 = new System.Windows.Forms.TextBox();
            this.tbu2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbz = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.ListBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.tbinst = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cborient = new Ambertation.Windows.Forms.EnumComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbtop = new System.Windows.Forms.TextBox();
            this.tbleft = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbhg = new System.Windows.Forms.TextBox();
            this.tbwd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbsubver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbver = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbtype = new System.Windows.Forms.TextBox();
            this.tbrotation = new System.Windows.Forms.TextBox();
            this.tbRoads = new System.Windows.Forms.TextBox();
            this.tbTexture = new System.Windows.Forms.TextBox();
            this.tbdesc = new System.Windows.Forms.TextBox();
            this.tblotname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.ltxtPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // ltxtPanel
            // 
            resources.ApplyResources(this.ltxtPanel, "ltxtPanel");
            this.ltxtPanel.Controls.Add(this.tbu4);
            this.ltxtPanel.Controls.Add(this.tbu5);
            this.ltxtPanel.Controls.Add(this.label19);
            this.ltxtPanel.Controls.Add(this.label25);
            this.ltxtPanel.Controls.Add(this.tbData);
            this.ltxtPanel.Controls.Add(this.label24);
            this.ltxtPanel.Controls.Add(this.tbowner);
            this.ltxtPanel.Controls.Add(this.label16);
            this.ltxtPanel.Controls.Add(this.tbu3);
            this.ltxtPanel.Controls.Add(this.label22);
            this.ltxtPanel.Controls.Add(this.tbu0);
            this.ltxtPanel.Controls.Add(this.tbu2);
            this.ltxtPanel.Controls.Add(this.label21);
            this.ltxtPanel.Controls.Add(this.label18);
            this.ltxtPanel.Controls.Add(this.tbz);
            this.ltxtPanel.Controls.Add(this.label20);
            this.ltxtPanel.Controls.Add(this.lb);
            this.ltxtPanel.Controls.Add(this.cbtype);
            this.ltxtPanel.Controls.Add(this.tbinst);
            this.ltxtPanel.Controls.Add(this.label15);
            this.ltxtPanel.Controls.Add(this.cborient);
            this.ltxtPanel.Controls.Add(this.label14);
            this.ltxtPanel.Controls.Add(this.tbtop);
            this.ltxtPanel.Controls.Add(this.tbleft);
            this.ltxtPanel.Controls.Add(this.label12);
            this.ltxtPanel.Controls.Add(this.label13);
            this.ltxtPanel.Controls.Add(this.tbhg);
            this.ltxtPanel.Controls.Add(this.tbwd);
            this.ltxtPanel.Controls.Add(this.label9);
            this.ltxtPanel.Controls.Add(this.label8);
            this.ltxtPanel.Controls.Add(this.tbsubver);
            this.ltxtPanel.Controls.Add(this.label11);
            this.ltxtPanel.Controls.Add(this.tbver);
            this.ltxtPanel.Controls.Add(this.label10);
            this.ltxtPanel.Controls.Add(this.tbtype);
            this.ltxtPanel.Controls.Add(this.tbrotation);
            this.ltxtPanel.Controls.Add(this.tbRoads);
            this.ltxtPanel.Controls.Add(this.tbTexture);
            this.ltxtPanel.Controls.Add(this.tbdesc);
            this.ltxtPanel.Controls.Add(this.tblotname);
            this.ltxtPanel.Controls.Add(this.label7);
            this.ltxtPanel.Controls.Add(this.label6);
            this.ltxtPanel.Controls.Add(this.label5);
            this.ltxtPanel.Controls.Add(this.label4);
            this.ltxtPanel.Controls.Add(this.label3);
            this.ltxtPanel.Controls.Add(this.label2);
            this.ltxtPanel.Controls.Add(this.label1);
            this.ltxtPanel.Controls.Add(this.button1);
            this.ltxtPanel.Controls.Add(this.panel2);
            this.ltxtPanel.Controls.Add(this.pb);
            this.ltxtPanel.Name = "ltxtPanel";
            // 
            // tbu4
            // 
            resources.ApplyResources(this.tbu4, "tbu4");
            this.tbu4.Name = "tbu4";
            this.tbu4.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbu5
            // 
            resources.ApplyResources(this.tbu5, "tbu5");
            this.tbu5.Name = "tbu5";
            this.tbu5.TextChanged += new System.EventHandler(this.ChangeApartment);
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label25
            // 
            resources.ApplyResources(this.label25, "label25");
            this.label25.Name = "label25";
            // 
            // tbData
            // 
            resources.ApplyResources(this.tbData, "tbData");
            this.tbData.Name = "tbData";
            this.tbData.TextChanged += new System.EventHandler(this.ChangeData);
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // tbowner
            // 
            resources.ApplyResources(this.tbowner, "tbowner");
            this.tbowner.Name = "tbowner";
            this.tbowner.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tbu3
            // 
            resources.ApplyResources(this.tbu3, "tbu3");
            this.tbu3.Name = "tbu3";
            this.tbu3.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // tbu0
            // 
            resources.ApplyResources(this.tbu0, "tbu0");
            this.tbu0.Name = "tbu0";
            this.tbu0.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbu2
            // 
            resources.ApplyResources(this.tbu2, "tbu2");
            this.tbu2.Name = "tbu2";
            this.tbu2.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label21
            // 
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // tbz
            // 
            resources.ApplyResources(this.tbz, "tbz");
            this.tbz.Name = "tbz";
            this.tbz.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // lb
            // 
            resources.ApplyResources(this.lb, "lb");
            this.lb.MultiColumn = true;
            this.lb.Name = "lb";
            this.lb.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbtype, "cbtype");
            this.cbtype.Name = "cbtype";
            this.cbtype.SelectedIndexChanged += new System.EventHandler(this.SelectType);
            // 
            // tbinst
            // 
            resources.ApplyResources(this.tbinst, "tbinst");
            this.tbinst.Name = "tbinst";
            this.tbinst.ReadOnly = true;
            this.tbinst.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // cborient
            // 
            this.cborient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cborient.Enum = null;
            resources.ApplyResources(this.cborient, "cborient");
            this.cborient.Name = "cborient";
            this.cborient.ResourceManager = null;
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // tbtop
            // 
            resources.ApplyResources(this.tbtop, "tbtop");
            this.tbtop.Name = "tbtop";
            this.tbtop.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbleft
            // 
            resources.ApplyResources(this.tbleft, "tbleft");
            this.tbleft.Name = "tbleft";
            this.tbleft.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbhg
            // 
            resources.ApplyResources(this.tbhg, "tbhg");
            this.tbhg.Name = "tbhg";
            this.tbhg.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbwd
            // 
            resources.ApplyResources(this.tbwd, "tbwd");
            this.tbwd.Name = "tbwd";
            this.tbwd.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbsubver
            // 
            resources.ApplyResources(this.tbsubver, "tbsubver");
            this.tbsubver.Name = "tbsubver";
            this.tbsubver.ReadOnly = true;
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // tbver
            // 
            resources.ApplyResources(this.tbver, "tbver");
            this.tbver.Name = "tbver";
            this.tbver.ReadOnly = true;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbtype
            // 
            resources.ApplyResources(this.tbtype, "tbtype");
            this.tbtype.Name = "tbtype";
            this.tbtype.ReadOnly = true;
            // 
            // tbrotation
            // 
            resources.ApplyResources(this.tbrotation, "tbrotation");
            this.tbrotation.Name = "tbrotation";
            this.tbrotation.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbRoads
            // 
            resources.ApplyResources(this.tbRoads, "tbRoads");
            this.tbRoads.Name = "tbRoads";
            this.tbRoads.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbTexture
            // 
            resources.ApplyResources(this.tbTexture, "tbTexture");
            this.tbTexture.Name = "tbTexture";
            this.tbTexture.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tbdesc
            // 
            resources.ApplyResources(this.tbdesc, "tbdesc");
            this.tbdesc.Name = "tbdesc";
            this.tbdesc.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // tblotname
            // 
            resources.ApplyResources(this.tblotname, "tblotname");
            this.tblotname.Name = "tblotname";
            this.tblotname.TextChanged += new System.EventHandler(this.CommonChange);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.Commit);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label27);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Name = "panel2";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // pb
            // 
            resources.ApplyResources(this.pb, "pb");
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // LtxtForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.ltxtPanel);
            this.Name = "LtxtForm";
            this.ltxtPanel.ResumeLayout(false);
            this.ltxtPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		internal Ltxt wrapper;

		private void SelectType(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			if (cbtype.SelectedIndex>0) tbtype.Text = "0x"+Helper.HexString((byte)((Ltxt.LotType)cbtype.Items[cbtype.SelectedIndex]));
			try 
			{
				wrapper.Type = (Ltxt.LotType)Convert.ToByte(tbtype.Text, 16);
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Commit(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void CommonChange(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.Unknown0 = Helper.StringToUInt32(tbu0.Text, wrapper.Unknown0, 16);
                wrapper.Unknown3 = Helper.StringToFloat(tbu3.Text, wrapper.Unknown3);
                wrapper.Unknown4 = Helper.StringToUInt32(tbu4.Text, wrapper.Unknown4, 16);

                wrapper.LotRoads = Convert.ToByte(this.tbRoads.Text, 16);
				wrapper.LotRotation = Convert.ToByte(this.tbrotation.Text, 16);

				wrapper.LotSize = new Size(
					Helper.StringToInt32(tbwd.Text, wrapper.LotSize.Width, 10), 
					Helper.StringToInt32(tbhg.Text, wrapper.LotSize.Height, 10));

				wrapper.LotPosition = new Point(
					Helper.StringToInt32(tbleft.Text, wrapper.LotPosition.X, 10), 
					Helper.StringToInt32(tbtop.Text, wrapper.LotPosition.Y, 10));

				wrapper.LotElevation = Helper.StringToFloat(tbz.Text, wrapper.LotElevation);

                wrapper.Orientation = (LotOrientation)cborient.SelectedValue;

				wrapper.LotName = tblotname.Text;
				wrapper.LotDesc = tbdesc.Text;
                wrapper.Texture = tbTexture.Text;
				wrapper.Unknown2 = (byte)Helper.StringToUInt16(tbu2.Text, wrapper.Unknown2, 16);
                wrapper.OwnerInstance = Helper.StringToUInt32(tbowner.Text, wrapper.OwnerInstance, 16);

				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void ChangeData(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.Followup = Helper.SetLength(Helper.HexListToBytes(this.tbData.Text), 0x55);
				
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

        private void ChangeApartment(object sender, System.EventArgs e)
        {
            if (wrapper == null) return;
            try
            {
                wrapper.Unknown5 = Helper.SetLength(Helper.HexListToBytes(this.tbData.Text), 14);

                wrapper.Changed = true;
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("", ex);
            }
        }

		private void label18_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
