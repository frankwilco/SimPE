/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
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
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtSrelUI.
	/// </summary>
	public class CommonSrel : System.Windows.Forms.UserControl
    {
        #region Form fields
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label91;
        private ComboBox cbfamtype;
        private TextBox tbRel;
        private LabeledProgressBar pbDay;
        private LabeledProgressBar pbLife;
        private TableLayoutPanel tableLayoutPanel1;
        private TransparentCheckBox cblove;
        private TransparentCheckBox cbcrush;
        private TransparentCheckBox cbengaged;
        private TransparentCheckBox cbmarried;
        private TransparentCheckBox cbbuddie;
        private TransparentCheckBox cbfriend;
        private TransparentCheckBox cbsteady;
        private TransparentCheckBox cbenemy;
        private TransparentCheckBox cbfamily;
        private TransparentCheckBox cbbest;
        private TransparentCheckBox cbBFF;

        /// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public CommonSrel()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			InitComboBox();

			tbRel.Visible = Helper.WindowsRegistry.HiddenMode;
            ltcb = new List<TransparentCheckBox>(new TransparentCheckBox[] {
                cbcrush, cblove, cbengaged, cbmarried, cbfriend, cbbuddie, cbsteady, cbenemy,
                null, null, null, null, null, null, cbfamily, cbbest,
                cbBFF, null, null, null, null, null, null, null,
                null, null, null, null, null, null, null, null,
            });
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonSrel));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label91 = new System.Windows.Forms.Label();
            this.cbfamtype = new System.Windows.Forms.ComboBox();
            this.tbRel = new System.Windows.Forms.TextBox();
            this.pbDay = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbLife = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbcrush = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbfamily = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cblove = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbengaged = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbmarried = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbfriend = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbbuddie = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbsteady = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbbest = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbenemy = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbBFF = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Controls.Add(this.pbDay);
            this.flowLayoutPanel2.Controls.Add(this.pbLife);
            this.flowLayoutPanel2.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Controls.Add(this.label91);
            this.flowLayoutPanel1.Controls.Add(this.cbfamtype);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.Name = "label91";
            // 
            // cbfamtype
            // 
            resources.ApplyResources(this.cbfamtype, "cbfamtype");
            this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfamtype.Name = "cbfamtype";
            // 
            // tbRel
            // 
            this.tbRel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbRel, "tbRel");
            this.tbRel.Name = "tbRel";
            // 
            // pbDay
            // 
            resources.ApplyResources(this.pbDay, "pbDay");
            this.pbDay.BackColor = System.Drawing.Color.Transparent;
            this.pbDay.DisplayOffset = 0;
            this.pbDay.Maximum = 200;
            this.pbDay.Name = "pbDay";
            this.pbDay.NumberFormat = "N0";
            this.pbDay.NumberOffset = -100;
            this.pbDay.NumberScale = 1;
            this.pbDay.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbDay.Style = Ambertation.Windows.Forms.ProgresBarStyle.Simple;
            this.pbDay.TokenCount = 30;
            this.pbDay.UnselectedColor = System.Drawing.Color.Black;
            this.pbDay.Value = 100;
            // 
            // pbLife
            // 
            resources.ApplyResources(this.pbLife, "pbLife");
            this.pbLife.BackColor = System.Drawing.Color.Transparent;
            this.pbLife.DisplayOffset = 0;
            this.pbLife.Maximum = 200;
            this.pbLife.Name = "pbLife";
            this.pbLife.NumberFormat = "N0";
            this.pbLife.NumberOffset = -100;
            this.pbLife.NumberScale = 1;
            this.pbLife.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbLife.Style = Ambertation.Windows.Forms.ProgresBarStyle.Simple;
            this.pbLife.TokenCount = 30;
            this.pbLife.UnselectedColor = System.Drawing.Color.Black;
            this.pbLife.Value = 100;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.cbcrush, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbfamily, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbRel, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.cblove, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbengaged, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbmarried, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbfriend, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbbuddie, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbsteady, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbbest, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbenemy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbBFF, 3, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // cbcrush
            // 
            resources.ApplyResources(this.cbcrush, "cbcrush");
            this.cbcrush.Name = "cbcrush";
            this.cbcrush.UseVisualStyleBackColor = false;
            this.cbcrush.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbfamily
            // 
            resources.ApplyResources(this.cbfamily, "cbfamily");
            this.cbfamily.Name = "cbfamily";
            this.cbfamily.UseVisualStyleBackColor = false;
            this.cbfamily.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cblove
            // 
            resources.ApplyResources(this.cblove, "cblove");
            this.cblove.Name = "cblove";
            this.cblove.UseVisualStyleBackColor = false;
            this.cblove.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbengaged
            // 
            resources.ApplyResources(this.cbengaged, "cbengaged");
            this.cbengaged.Name = "cbengaged";
            this.cbengaged.UseVisualStyleBackColor = false;
            this.cbengaged.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbmarried
            // 
            resources.ApplyResources(this.cbmarried, "cbmarried");
            this.cbmarried.Name = "cbmarried";
            this.cbmarried.UseVisualStyleBackColor = false;
            this.cbmarried.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbfriend
            // 
            resources.ApplyResources(this.cbfriend, "cbfriend");
            this.cbfriend.Name = "cbfriend";
            this.cbfriend.UseVisualStyleBackColor = false;
            this.cbfriend.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbbuddie
            // 
            resources.ApplyResources(this.cbbuddie, "cbbuddie");
            this.cbbuddie.Name = "cbbuddie";
            this.cbbuddie.UseVisualStyleBackColor = false;
            this.cbbuddie.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbsteady
            // 
            resources.ApplyResources(this.cbsteady, "cbsteady");
            this.cbsteady.Name = "cbsteady";
            this.cbsteady.UseVisualStyleBackColor = false;
            this.cbsteady.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbbest
            // 
            resources.ApplyResources(this.cbbest, "cbbest");
            this.cbbest.Name = "cbbest";
            this.cbbest.UseVisualStyleBackColor = false;
            this.cbbest.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbenemy
            // 
            resources.ApplyResources(this.cbenemy, "cbenemy");
            this.cbenemy.Name = "cbenemy";
            this.cbenemy.UseVisualStyleBackColor = false;
            this.cbenemy.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbBFF
            // 
            resources.ApplyResources(this.cbBFF, "cbBFF");
            this.cbBFF.Name = "cbBFF";
            this.cbBFF.UseVisualStyleBackColor = false;
            this.cbBFF.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // CommonSrel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "CommonSrel";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


        SimPe.PackedFiles.Wrapper.ExtSrel srel;
		public SimPe.PackedFiles.Wrapper.ExtSrel Srel
		{
			get {return srel;}
			set 
			{
				srel = value;
				UpdateContent();

				/*if (value!=null) 
				{
					if (srel==null) 
					{
						srel = value;
						UpdateContent();
					} 
					else if (srel.FileDescriptor==null) 
					{
						srel = value;
						UpdateContent();
					} 
					else if (srel.FileDescriptor.Equals(value.FileDescriptor))
					{
						srel = value;
						UpdateContent();
					}
				} */
			}
		}

		public event EventHandler ChangedContent;
		protected void InitComboBox()
		{
			this.cbfamtype.Items.Clear();
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Unset_Unknown));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Aunt));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Child));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Cousin));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Grandchild));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Gradparent));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Nice_Nephew));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Parent));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Sibling));
			this.cbfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Spouses));
		}

		bool intern;
        List<TransparentCheckBox> ltcb;

        protected void UpdateContent()
		{
			this.Enabled = (Srel!=null);
			if (Srel==null) return;
			intern = true;
			this.pbDay.Value = Srel.Shortterm;
			this.pbLife.Value = Srel.Longterm;

            Boolset bs = Srel.RelationState.Value;
            for (int i = 0; i < bs.Length; i++) if (ltcb[i] != null) ltcb[i].Checked = bs[i];
            if (Srel.RelationState2 != null)
            {
                bs = Srel.RelationState2.Value;
                for (int i = 0; i < bs.Length; i++) if (ltcb[i + 16] != null)
                    {
                        ltcb[i + 16].Enabled = true;
                        ltcb[i + 16].Checked = bs[i];
                    }
            }
            else
                for (int i = 0; i < bs.Length; i++) if (ltcb[i + 16] != null) ltcb[i + 16].Enabled = false;

			this.cbfamtype.SelectedIndex = 0;
			for (int i=1; i<this.cbfamtype.Items.Count; i++) 
				if (this.cbfamtype.Items[i] == new Data.LocalizedRelationshipTypes(srel.FamilyRelation)) 
				{
					this.cbfamtype.SelectedIndex = i;
					break;
				}

			this.tbRel.Text = "0x"+Helper.HexString((uint)srel.FamilyRelation);
			intern = false;

			if (ChangedContent!=null) ChangedContent(this, new EventArgs());
		}

		private void ChangedLife(object sender, System.EventArgs e)
		{
			if (pbLife.Value<0) 
			{
				if (pbLife.SelectedColor!=Color.OrangeRed) 
				{					
					pbLife.SelectedColor = Color.OrangeRed;
					pbLife.CompleteRedraw();
				}
			}
			else 
			{
				if (pbLife.SelectedColor!=Color.Lime) 
				{					
					pbLife.SelectedColor = Color.Lime;
					pbLife.CompleteRedraw();
				}
			}

			if (intern) return;
			Srel.Longterm = pbLife.Value;
			Srel.Changed = true;
		}

		private void ChangedDay(object sender, System.EventArgs e)
		{
			if (pbDay.Value<0) 
			{
				if (pbDay.SelectedColor!=Color.OrangeRed) 
				{					
					pbDay.SelectedColor = Color.OrangeRed;
					pbDay.CompleteRedraw();
				}
			}
			else 
			{
				if (pbDay.SelectedColor!=Color.Lime) 
				{					
					pbDay.SelectedColor = Color.Lime;
					pbDay.CompleteRedraw();
				}
			}

			if (intern) return;
			Srel.Shortterm = pbDay.Value;
			Srel.Changed = true;
		}

		private void ChangedRelation(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (this.cbfamtype.SelectedIndex>=0) 			
				this.tbRel.Text = "0x"+Helper.HexString((uint)((Data.MetaData.RelationshipTypes)((Data.LocalizedRelationshipTypes)cbfamtype.SelectedItem)));
			
		}

		private void ChangedRelationText(object sender, System.EventArgs e)
		{
			if (intern) return;
			Srel.FamilyRelation = (Data.LocalizedRelationshipTypes)Helper.StringToUInt32(this.tbRel.Text, (uint)Srel.FamilyRelation, 16);
			Srel.Changed = true;
		}

		private void ChangedState(object sender, System.EventArgs e)
		{
			if (intern) return;

            int i = ltcb.IndexOf((TransparentCheckBox)sender);
            if (i >= 0)
            {
                Boolset val = (i < 16) ? Srel.RelationState.Value : Srel.RelationState2.Value;
                val[i & 0x0f] = ((TransparentCheckBox)sender).Checked;
                if (i < 16) Srel.RelationState.Value = val;
                else Srel.RelationState2.Value = val;
                Srel.Changed = true;
            }
		}

		public SimPe.PackedFiles.Wrapper.ExtSDesc SourceSim
		{
			get { 
				if (Srel==null) return null;
				return Srel.SourceSim; 
			}
		}

		public SimPe.PackedFiles.Wrapper.ExtSDesc TargetSim
		{
			get { 
				if (Srel==null) return null;
				return Srel.TargetSim; 
			}
		}

		
		public string SourceSimName
		{
			get { 
				if (Srel==null) return SimPe.Localization.GetString("Unknown");
				return Srel.SourceSimName; 
			}
		}

		public string TargetSimName
		{
			get { 
				if (Srel==null) return SimPe.Localization.GetString("Unknown");
				return Srel.TargetSimName; 
			}
		}

		public Image Image
		{
			get { 
				if (Srel==null) return null;
				return Srel.Image;
			}
		}
	}
}
