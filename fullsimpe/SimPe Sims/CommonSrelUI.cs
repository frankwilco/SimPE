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
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
            this.label91 = new System.Windows.Forms.Label();
            this.cbfamtype = new System.Windows.Forms.ComboBox();
            this.cbbest = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbfamily = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbmarried = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbengaged = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbsteady = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cblove = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbcrush = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbbuddie = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbfriend = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.cbenemy = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.pbDay = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbLife = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.tbRel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label91
            // 
            resources.ApplyResources(this.label91, "label91");
            this.label91.Name = "label91";
            // 
            // cbfamtype
            // 
            this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbfamtype, "cbfamtype");
            this.cbfamtype.Name = "cbfamtype";
            this.cbfamtype.SelectedIndexChanged += new System.EventHandler(this.ChangedRelation);
            // 
            // cbbest
            // 
            resources.ApplyResources(this.cbbest, "cbbest");
            this.cbbest.Name = "cbbest";
            this.cbbest.UseVisualStyleBackColor = false;
            this.cbbest.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbfamily
            // 
            resources.ApplyResources(this.cbfamily, "cbfamily");
            this.cbfamily.Name = "cbfamily";
            this.cbfamily.UseVisualStyleBackColor = false;
            this.cbfamily.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbmarried
            // 
            resources.ApplyResources(this.cbmarried, "cbmarried");
            this.cbmarried.Name = "cbmarried";
            this.cbmarried.UseVisualStyleBackColor = false;
            this.cbmarried.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbengaged
            // 
            resources.ApplyResources(this.cbengaged, "cbengaged");
            this.cbengaged.Name = "cbengaged";
            this.cbengaged.UseVisualStyleBackColor = false;
            this.cbengaged.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbsteady
            // 
            resources.ApplyResources(this.cbsteady, "cbsteady");
            this.cbsteady.Name = "cbsteady";
            this.cbsteady.UseVisualStyleBackColor = false;
            this.cbsteady.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cblove
            // 
            resources.ApplyResources(this.cblove, "cblove");
            this.cblove.Name = "cblove";
            this.cblove.UseVisualStyleBackColor = false;
            this.cblove.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbcrush
            // 
            resources.ApplyResources(this.cbcrush, "cbcrush");
            this.cbcrush.Name = "cbcrush";
            this.cbcrush.UseVisualStyleBackColor = false;
            this.cbcrush.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbbuddie
            // 
            resources.ApplyResources(this.cbbuddie, "cbbuddie");
            this.cbbuddie.Name = "cbbuddie";
            this.cbbuddie.UseVisualStyleBackColor = false;
            this.cbbuddie.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbfriend
            // 
            resources.ApplyResources(this.cbfriend, "cbfriend");
            this.cbfriend.Name = "cbfriend";
            this.cbfriend.UseVisualStyleBackColor = false;
            this.cbfriend.CheckedChanged += new System.EventHandler(this.ChangedState);
            // 
            // cbenemy
            // 
            resources.ApplyResources(this.cbenemy, "cbenemy");
            this.cbenemy.Name = "cbenemy";
            this.cbenemy.UseVisualStyleBackColor = false;
            this.cbenemy.CheckedChanged += new System.EventHandler(this.ChangedState);
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
            this.pbDay.Changed += new System.EventHandler(this.ChangedDay);
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
            this.pbLife.Changed += new System.EventHandler(this.ChangedLife);
            // 
            // tbRel
            // 
            this.tbRel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbRel, "tbRel");
            this.tbRel.Name = "tbRel";
            this.tbRel.TextChanged += new System.EventHandler(this.ChangedRelationText);
            // 
            // CommonSrel
            // 
            this.Controls.Add(this.tbRel);
            this.Controls.Add(this.pbLife);
            this.Controls.Add(this.pbDay);
            this.Controls.Add(this.label91);
            this.Controls.Add(this.cbfamtype);
            this.Controls.Add(this.cbbest);
            this.Controls.Add(this.cbbuddie);
            this.Controls.Add(this.cbfriend);
            this.Controls.Add(this.cbfamily);
            this.Controls.Add(this.cbenemy);
            this.Controls.Add(this.cbmarried);
            this.Controls.Add(this.cbengaged);
            this.Controls.Add(this.cbsteady);
            this.Controls.Add(this.cblove);
            this.Controls.Add(this.cbcrush);
            resources.ApplyResources(this, "$this");
            this.Name = "CommonSrel";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		private System.Windows.Forms.Label label91;
		private System.Windows.Forms.ComboBox cbfamtype;
		private Ambertation.Windows.Forms.TransparentCheckBox cbbest;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfamily;
		private Ambertation.Windows.Forms.TransparentCheckBox cbmarried;
		private Ambertation.Windows.Forms.TransparentCheckBox cbengaged;
		private Ambertation.Windows.Forms.TransparentCheckBox cbsteady;
		private Ambertation.Windows.Forms.TransparentCheckBox cblove;
		private Ambertation.Windows.Forms.TransparentCheckBox cbcrush;
		private Ambertation.Windows.Forms.TransparentCheckBox cbbuddie;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfriend;
		private Ambertation.Windows.Forms.TransparentCheckBox cbenemy;
		private Ambertation.Windows.Forms.LabeledProgressBar pbDay;
		private Ambertation.Windows.Forms.LabeledProgressBar pbLife;
		private System.Windows.Forms.TextBox tbRel;

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
		protected void UpdateContent()
		{
			this.Enabled = (Srel!=null);
			if (Srel==null) return;
			intern = true;
			this.pbDay.Value = Srel.Shortterm;
			this.pbLife.Value = Srel.Longterm;

			this.cbenemy.Checked = Srel.RelationState.IsEnemy;
			this.cbfriend.Checked = Srel.RelationState.IsFriend;
			this.cbbuddie.Checked = Srel.RelationState.IsBuddie;
			this.cbcrush.Checked = Srel.RelationState.HasCrush;
			this.cblove.Checked = Srel.RelationState.InLove;
			this.cbsteady.Checked = Srel.RelationState.GoSteady;
			this.cbengaged.Checked = Srel.RelationState.IsEngaged;
			this.cbmarried.Checked = Srel.RelationState.IsMarried;
			this.cbbest.Checked = Srel.RelationState.IsKnown;
			this.cbfamily.Checked = Srel.RelationState.IsFamilyMember;

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

			Srel.RelationState.IsEnemy = this.cbenemy.Checked;
			Srel.RelationState.IsFriend = this.cbfriend.Checked;
			Srel.RelationState.IsBuddie = this.cbbuddie.Checked;
			Srel.RelationState.HasCrush = this.cbcrush.Checked;
			Srel.RelationState.InLove = this.cblove.Checked;
			Srel.RelationState.GoSteady = this.cbsteady.Checked;
			Srel.RelationState.IsEngaged = this.cbengaged.Checked;
			Srel.RelationState.IsMarried = this.cbmarried.Checked;
			Srel.RelationState.IsKnown = this.cbbest.Checked;
			Srel.RelationState.IsFamilyMember = this.cbfamily.Checked;

			Srel.Changed = true;
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
