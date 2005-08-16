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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Zusammenfassung für ImportJointAnim.
	/// </summary>
	public class ImportJointAnim : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chAction;
		private System.Windows.Forms.ColumnHeader chTarget;
		private System.Windows.Forms.ColumnHeader chCount;
		private Ambertation.Windows.Forms.XPTaskBoxSimple gbgroups;
		private System.Windows.Forms.ComboBox cbnames;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.ComboBox cbaction;
		private Ambertation.Windows.Forms.TransparentCheckBox cbDiscard;
		private System.Windows.Forms.ColumnHeader chDuration;
		private System.Windows.Forms.ColumnHeader chDiscardZero;
		private Ambertation.Windows.Forms.TransparentCheckBox cbRemove;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImportJointAnim()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.gbgroups);

			this.cbaction.Items.Add(AnimImporterAction.Nothing);
			this.cbaction.Items.Add(AnimImporterAction.Replace);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImportJointAnim));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.gbgroups = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.cbRemove = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbDiscard = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbnames = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbname = new System.Windows.Forms.Label();
			this.cbaction = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lv = new System.Windows.Forms.ListView();
			this.chName = new System.Windows.Forms.ColumnHeader();
			this.chAction = new System.Windows.Forms.ColumnHeader();
			this.chTarget = new System.Windows.Forms.ColumnHeader();
			this.chCount = new System.Windows.Forms.ColumnHeader();
			this.chDuration = new System.Windows.Forms.ColumnHeader();
			this.chDiscardZero = new System.Windows.Forms.ColumnHeader();
			this.label1 = new System.Windows.Forms.Label();
			this.xpGradientPanel1.SuspendLayout();
			this.gbgroups.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.gbgroups);
			this.xpGradientPanel1.Controls.Add(this.button1);
			this.xpGradientPanel1.Controls.Add(this.lv);
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(824, 438);
			this.xpGradientPanel1.TabIndex = 13;
			// 
			// gbgroups
			// 
			this.gbgroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbgroups.BackColor = System.Drawing.Color.Transparent;
			this.gbgroups.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.gbgroups.BorderColor = System.Drawing.SystemColors.Window;
			this.gbgroups.Controls.Add(this.cbRemove);
			this.gbgroups.Controls.Add(this.cbDiscard);
			this.gbgroups.Controls.Add(this.cbnames);
			this.gbgroups.Controls.Add(this.label2);
			this.gbgroups.Controls.Add(this.label3);
			this.gbgroups.Controls.Add(this.lbname);
			this.gbgroups.Controls.Add(this.cbaction);
			this.gbgroups.DockPadding.Bottom = 4;
			this.gbgroups.DockPadding.Left = 4;
			this.gbgroups.DockPadding.Right = 4;
			this.gbgroups.DockPadding.Top = 44;
			this.gbgroups.Enabled = false;
			this.gbgroups.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.gbgroups.HeaderText = "Animationjoint Settings";
			this.gbgroups.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.gbgroups.IconLocation = new System.Drawing.Point(4, 12);
			this.gbgroups.IconSize = new System.Drawing.Size(32, 32);
			this.gbgroups.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.gbgroups.Location = new System.Drawing.Point(536, 32);
			this.gbgroups.Name = "gbgroups";
			this.gbgroups.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.gbgroups.Size = new System.Drawing.Size(280, 168);
			this.gbgroups.TabIndex = 14;
			// 
			// cbRemove
			// 
			this.cbRemove.Checked = true;
			this.cbRemove.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbRemove.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbRemove.Location = new System.Drawing.Point(112, 84);
			this.cbRemove.Name = "cbRemove";
			this.cbRemove.Size = new System.Drawing.Size(160, 24);
			this.cbRemove.TabIndex = 7;
			this.cbRemove.Text = "Remove unneeded Frames";
			this.cbRemove.CheckedChanged += new System.EventHandler(this.cbRemove_CheckedChanged);
			// 
			// cbDiscard
			// 
			this.cbDiscard.Checked = true;
			this.cbDiscard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbDiscard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbDiscard.Location = new System.Drawing.Point(112, 64);
			this.cbDiscard.Name = "cbDiscard";
			this.cbDiscard.Size = new System.Drawing.Size(128, 24);
			this.cbDiscard.TabIndex = 6;
			this.cbDiscard.Text = "Discard Keyframe 0";
			this.cbDiscard.CheckedChanged += new System.EventHandler(this.cbDiscard_CheckedChanged);
			// 
			// cbnames
			// 
			this.cbnames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbnames.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbnames.Location = new System.Drawing.Point(112, 136);
			this.cbnames.Name = "cbnames";
			this.cbnames.Size = new System.Drawing.Size(160, 21);
			this.cbnames.TabIndex = 5;
			this.cbnames.Visible = false;
			this.cbnames.SelectedIndexChanged += new System.EventHandler(this.cbnames_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "Joint Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Action:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lbname
			// 
			this.lbname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbname.Location = new System.Drawing.Point(112, 40);
			this.lbname.Name = "lbname";
			this.lbname.Size = new System.Drawing.Size(160, 23);
			this.lbname.TabIndex = 2;
			this.lbname.Text = "---";
			this.lbname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// cbaction
			// 
			this.cbaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbaction.Location = new System.Drawing.Point(112, 112);
			this.cbaction.Name = "cbaction";
			this.cbaction.Size = new System.Drawing.Size(160, 21);
			this.cbaction.TabIndex = 3;
			this.cbaction.SelectedIndexChanged += new System.EventHandler(this.cbaction_SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(744, 410);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.chName,
																				 this.chAction,
																				 this.chTarget,
																				 this.chCount,
																				 this.chDuration,
																				 this.chDiscardZero});
			this.lv.FullRowSelect = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 32);
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(520, 400);
			this.lv.TabIndex = 0;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
			// 
			// chName
			// 
			this.chName.Text = "Name";
			this.chName.Width = 130;
			// 
			// chAction
			// 
			this.chAction.Text = "Action";
			this.chAction.Width = 69;
			// 
			// chTarget
			// 
			this.chTarget.Text = "Target";
			this.chTarget.Width = 118;
			// 
			// chCount
			// 
			this.chCount.Text = "Frames";
			this.chCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// chDuration
			// 
			this.chDuration.Text = "Duration";
			this.chDuration.Width = 56;
			// 
			// chDiscardZero
			// 
			this.chDiscardZero.Text = "Zero";
			this.chDiscardZero.Width = 36;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Importable Joints:";
			// 
			// ImportJointAnim
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(824, 438);
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ImportJointAnim";
			this.Text = "Import Animation";
			this.xpGradientPanel1.ResumeLayout(false);
			this.gbgroups.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public static bool Execute(ImportedFrameBlocks amb, GeometryDataContainer gmdc)
		{
			ImportJointAnim f = new ImportJointAnim();
			f.ok = false;
			f.cbnames.Items.Clear();
			foreach (AnimationFrameBlock afb in gmdc.LinkedAnimation.Part2)			
				f.cbnames.Items.Add(afb);
			

			f.lv.Items.Clear();
			foreach (ImportedFrameBlock ifb in amb)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = ifb.ImportedName;
				lvi.SubItems.Add(ifb.Action.ToString());
				if (ifb.Target!=null) lvi.SubItems.Add(ifb.Target.ToString());
				else lvi.SubItems.Add("---");
				lvi.SubItems.Add(ifb.FrameBlock.FrameCount.ToString());
				lvi.SubItems.Add(ifb.FrameBlock.GetDuration().ToString());
				if (ifb.DiscardZeroFrame) lvi.SubItems.Add("no");
				else lvi.SubItems.Add("yes");

				lvi.ForeColor = ifb.MarkColor;
				lvi.Tag = ifb;

				if (ifb.Target!=null) f.lv.Items.Insert(0, lvi);
				else f.lv.Items.Add(lvi);
			}
			f.ShowDialog();

			return f.ok;
		}

		private void lv_SelectedIndexChanged(object sender, System.EventArgs e)
		{	
			gbgroups.Enabled = false;
			if (lv.SelectedItems.Count>0) 
			{				
				object o = lv.SelectedItems[0].Tag;
				if (o is ImportedFrameBlock) SelectJoint();				
			}	
		}

		/// <summary>
		/// A Bone was selected
		/// </summary>
		void SelectJoint() 
		{			
			gbgroups.Enabled = true;
			this.Tag = true;
			try 
			{
				ImportedFrameBlock a = (ImportedFrameBlock)lv.SelectedItems[0].Tag;

				this.cbDiscard.Checked = a.DiscardZeroFrame;
				this.cbRemove.Checked = a.RemoveUnneeded;

				cbaction.SelectedIndex = 0;
				for (int i=0; i<cbaction.Items.Count; i++)
				{
					AnimImporterAction ea = (AnimImporterAction)cbaction.Items[i];
					if (ea==a.Action) 
					{
						cbaction.SelectedIndex = i;
						break;
					}
				}
				lbname.Text = a.ImportedName;
				

				cbnames.SelectedIndex = -1;
				if (a.Target!=null) 
				{
					for (int i=0; i<cbnames.Items.Count; i++) 
					{
						AnimationFrameBlock afb = (AnimationFrameBlock)cbnames.Items[i];					
						if (afb==a.Target) 
						{
							cbnames.SelectedIndex = i;
							break;
						}
					}
				}
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		private void cbaction_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			cbnames.Visible = ((AnimImporterAction)cbaction.SelectedItem) == AnimImporterAction.Replace;
			if (this.Tag!=null) return;			

			for (int i=0; i<lv.SelectedItems.Count; i++) 
			{
				ImportedFrameBlock a = (ImportedFrameBlock)lv.SelectedItems[i].Tag;
				a.Action = (AnimImporterAction)cbaction.SelectedItem;
				lv.SelectedItems[i].SubItems[1].Text = a.Action.ToString();
				lv.SelectedItems[i].ForeColor = a.MarkColor;
			}
		}

		private void cbnames_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			for (int i=0; i<lv.SelectedItems.Count; i++) 
			{
				ImportedFrameBlock a = (ImportedFrameBlock)lv.SelectedItems[i].Tag;
				a.Target = (AnimationFrameBlock)cbnames.SelectedItem;
				lv.SelectedItems[i].SubItems[2].Text = a.Target.ToString();
				lv.SelectedItems[i].ForeColor = a.MarkColor;
			}
		}

		private void cbDiscard_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			for (int i=0; i<lv.SelectedItems.Count; i++) 
			{
				ImportedFrameBlock a = (ImportedFrameBlock)lv.SelectedItems[i].Tag;
				a.DiscardZeroFrame = cbDiscard.Checked;
				if (a.DiscardZeroFrame) lv.SelectedItems[i].SubItems[5].Text = "no";
				else lv.SelectedItems[i].SubItems[5].Text = "yes";
				lv.SelectedItems[i].ForeColor = a.MarkColor;
			}
		}

		bool ok;
		private void button1_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}

		private void cbRemove_CheckedChanged(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			for (int i=0; i<lv.SelectedItems.Count; i++) 
			{
				ImportedFrameBlock a = (ImportedFrameBlock)lv.SelectedItems[i].Tag;
				a.RemoveUnneeded = cbRemove.Checked;				
			}
		}
	}
}
