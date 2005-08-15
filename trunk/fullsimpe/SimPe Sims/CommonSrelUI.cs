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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CommonSrel));
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
			this.label91.AccessibleDescription = resources.GetString("label91.AccessibleDescription");
			this.label91.AccessibleName = resources.GetString("label91.AccessibleName");
			this.label91.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label91.Anchor")));
			this.label91.AutoSize = ((bool)(resources.GetObject("label91.AutoSize")));
			this.label91.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label91.Dock")));
			this.label91.Enabled = ((bool)(resources.GetObject("label91.Enabled")));
			this.label91.Font = ((System.Drawing.Font)(resources.GetObject("label91.Font")));
			this.label91.Image = ((System.Drawing.Image)(resources.GetObject("label91.Image")));
			this.label91.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.ImageAlign")));
			this.label91.ImageIndex = ((int)(resources.GetObject("label91.ImageIndex")));
			this.label91.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label91.ImeMode")));
			this.label91.Location = ((System.Drawing.Point)(resources.GetObject("label91.Location")));
			this.label91.Name = "label91";
			this.label91.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label91.RightToLeft")));
			this.label91.Size = ((System.Drawing.Size)(resources.GetObject("label91.Size")));
			this.label91.TabIndex = ((int)(resources.GetObject("label91.TabIndex")));
			this.label91.Text = resources.GetString("label91.Text");
			this.label91.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.TextAlign")));
			this.label91.Visible = ((bool)(resources.GetObject("label91.Visible")));
			// 
			// cbfamtype
			// 
			this.cbfamtype.AccessibleDescription = resources.GetString("cbfamtype.AccessibleDescription");
			this.cbfamtype.AccessibleName = resources.GetString("cbfamtype.AccessibleName");
			this.cbfamtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamtype.Anchor")));
			this.cbfamtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamtype.BackgroundImage")));
			this.cbfamtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamtype.Dock")));
			this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbfamtype.Enabled = ((bool)(resources.GetObject("cbfamtype.Enabled")));
			this.cbfamtype.Font = ((System.Drawing.Font)(resources.GetObject("cbfamtype.Font")));
			this.cbfamtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamtype.ImeMode")));
			this.cbfamtype.IntegralHeight = ((bool)(resources.GetObject("cbfamtype.IntegralHeight")));
			this.cbfamtype.ItemHeight = ((int)(resources.GetObject("cbfamtype.ItemHeight")));
			this.cbfamtype.Location = ((System.Drawing.Point)(resources.GetObject("cbfamtype.Location")));
			this.cbfamtype.MaxDropDownItems = ((int)(resources.GetObject("cbfamtype.MaxDropDownItems")));
			this.cbfamtype.MaxLength = ((int)(resources.GetObject("cbfamtype.MaxLength")));
			this.cbfamtype.Name = "cbfamtype";
			this.cbfamtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamtype.RightToLeft")));
			this.cbfamtype.Size = ((System.Drawing.Size)(resources.GetObject("cbfamtype.Size")));
			this.cbfamtype.TabIndex = ((int)(resources.GetObject("cbfamtype.TabIndex")));
			this.cbfamtype.Text = resources.GetString("cbfamtype.Text");
			this.cbfamtype.Visible = ((bool)(resources.GetObject("cbfamtype.Visible")));
			this.cbfamtype.SelectedIndexChanged += new System.EventHandler(this.ChangedRelation);
			// 
			// cbbest
			// 
			this.cbbest.AccessibleDescription = resources.GetString("cbbest.AccessibleDescription");
			this.cbbest.AccessibleName = resources.GetString("cbbest.AccessibleName");
			this.cbbest.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbest.Anchor")));
			this.cbbest.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbest.Appearance")));
			this.cbbest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbest.BackgroundImage")));
			this.cbbest.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.CheckAlign")));
			this.cbbest.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbest.Dock")));
			this.cbbest.Enabled = ((bool)(resources.GetObject("cbbest.Enabled")));
			this.cbbest.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbest.FlatStyle")));
			this.cbbest.Font = ((System.Drawing.Font)(resources.GetObject("cbbest.Font")));
			this.cbbest.Image = ((System.Drawing.Image)(resources.GetObject("cbbest.Image")));
			this.cbbest.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.ImageAlign")));
			this.cbbest.ImageIndex = ((int)(resources.GetObject("cbbest.ImageIndex")));
			this.cbbest.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbest.ImeMode")));
			this.cbbest.Location = ((System.Drawing.Point)(resources.GetObject("cbbest.Location")));
			this.cbbest.Name = "cbbest";
			this.cbbest.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbest.RightToLeft")));
			this.cbbest.Size = ((System.Drawing.Size)(resources.GetObject("cbbest.Size")));
			this.cbbest.TabIndex = ((int)(resources.GetObject("cbbest.TabIndex")));
			this.cbbest.Text = resources.GetString("cbbest.Text");
			this.cbbest.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.TextAlign")));
			this.cbbest.Visible = ((bool)(resources.GetObject("cbbest.Visible")));
			this.cbbest.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbfamily
			// 
			this.cbfamily.AccessibleDescription = resources.GetString("cbfamily.AccessibleDescription");
			this.cbfamily.AccessibleName = resources.GetString("cbfamily.AccessibleName");
			this.cbfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamily.Anchor")));
			this.cbfamily.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfamily.Appearance")));
			this.cbfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamily.BackgroundImage")));
			this.cbfamily.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.CheckAlign")));
			this.cbfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamily.Dock")));
			this.cbfamily.Enabled = ((bool)(resources.GetObject("cbfamily.Enabled")));
			this.cbfamily.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfamily.FlatStyle")));
			this.cbfamily.Font = ((System.Drawing.Font)(resources.GetObject("cbfamily.Font")));
			this.cbfamily.Image = ((System.Drawing.Image)(resources.GetObject("cbfamily.Image")));
			this.cbfamily.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.ImageAlign")));
			this.cbfamily.ImageIndex = ((int)(resources.GetObject("cbfamily.ImageIndex")));
			this.cbfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamily.ImeMode")));
			this.cbfamily.Location = ((System.Drawing.Point)(resources.GetObject("cbfamily.Location")));
			this.cbfamily.Name = "cbfamily";
			this.cbfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamily.RightToLeft")));
			this.cbfamily.Size = ((System.Drawing.Size)(resources.GetObject("cbfamily.Size")));
			this.cbfamily.TabIndex = ((int)(resources.GetObject("cbfamily.TabIndex")));
			this.cbfamily.Text = resources.GetString("cbfamily.Text");
			this.cbfamily.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.TextAlign")));
			this.cbfamily.Visible = ((bool)(resources.GetObject("cbfamily.Visible")));
			this.cbfamily.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbmarried
			// 
			this.cbmarried.AccessibleDescription = resources.GetString("cbmarried.AccessibleDescription");
			this.cbmarried.AccessibleName = resources.GetString("cbmarried.AccessibleName");
			this.cbmarried.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbmarried.Anchor")));
			this.cbmarried.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbmarried.Appearance")));
			this.cbmarried.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmarried.BackgroundImage")));
			this.cbmarried.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.CheckAlign")));
			this.cbmarried.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbmarried.Dock")));
			this.cbmarried.Enabled = ((bool)(resources.GetObject("cbmarried.Enabled")));
			this.cbmarried.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbmarried.FlatStyle")));
			this.cbmarried.Font = ((System.Drawing.Font)(resources.GetObject("cbmarried.Font")));
			this.cbmarried.Image = ((System.Drawing.Image)(resources.GetObject("cbmarried.Image")));
			this.cbmarried.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.ImageAlign")));
			this.cbmarried.ImageIndex = ((int)(resources.GetObject("cbmarried.ImageIndex")));
			this.cbmarried.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbmarried.ImeMode")));
			this.cbmarried.Location = ((System.Drawing.Point)(resources.GetObject("cbmarried.Location")));
			this.cbmarried.Name = "cbmarried";
			this.cbmarried.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbmarried.RightToLeft")));
			this.cbmarried.Size = ((System.Drawing.Size)(resources.GetObject("cbmarried.Size")));
			this.cbmarried.TabIndex = ((int)(resources.GetObject("cbmarried.TabIndex")));
			this.cbmarried.Text = resources.GetString("cbmarried.Text");
			this.cbmarried.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.TextAlign")));
			this.cbmarried.Visible = ((bool)(resources.GetObject("cbmarried.Visible")));
			this.cbmarried.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbengaged
			// 
			this.cbengaged.AccessibleDescription = resources.GetString("cbengaged.AccessibleDescription");
			this.cbengaged.AccessibleName = resources.GetString("cbengaged.AccessibleName");
			this.cbengaged.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbengaged.Anchor")));
			this.cbengaged.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbengaged.Appearance")));
			this.cbengaged.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbengaged.BackgroundImage")));
			this.cbengaged.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.CheckAlign")));
			this.cbengaged.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbengaged.Dock")));
			this.cbengaged.Enabled = ((bool)(resources.GetObject("cbengaged.Enabled")));
			this.cbengaged.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbengaged.FlatStyle")));
			this.cbengaged.Font = ((System.Drawing.Font)(resources.GetObject("cbengaged.Font")));
			this.cbengaged.Image = ((System.Drawing.Image)(resources.GetObject("cbengaged.Image")));
			this.cbengaged.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.ImageAlign")));
			this.cbengaged.ImageIndex = ((int)(resources.GetObject("cbengaged.ImageIndex")));
			this.cbengaged.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbengaged.ImeMode")));
			this.cbengaged.Location = ((System.Drawing.Point)(resources.GetObject("cbengaged.Location")));
			this.cbengaged.Name = "cbengaged";
			this.cbengaged.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbengaged.RightToLeft")));
			this.cbengaged.Size = ((System.Drawing.Size)(resources.GetObject("cbengaged.Size")));
			this.cbengaged.TabIndex = ((int)(resources.GetObject("cbengaged.TabIndex")));
			this.cbengaged.Text = resources.GetString("cbengaged.Text");
			this.cbengaged.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.TextAlign")));
			this.cbengaged.Visible = ((bool)(resources.GetObject("cbengaged.Visible")));
			this.cbengaged.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbsteady
			// 
			this.cbsteady.AccessibleDescription = resources.GetString("cbsteady.AccessibleDescription");
			this.cbsteady.AccessibleName = resources.GetString("cbsteady.AccessibleName");
			this.cbsteady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsteady.Anchor")));
			this.cbsteady.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbsteady.Appearance")));
			this.cbsteady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsteady.BackgroundImage")));
			this.cbsteady.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.CheckAlign")));
			this.cbsteady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsteady.Dock")));
			this.cbsteady.Enabled = ((bool)(resources.GetObject("cbsteady.Enabled")));
			this.cbsteady.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbsteady.FlatStyle")));
			this.cbsteady.Font = ((System.Drawing.Font)(resources.GetObject("cbsteady.Font")));
			this.cbsteady.Image = ((System.Drawing.Image)(resources.GetObject("cbsteady.Image")));
			this.cbsteady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.ImageAlign")));
			this.cbsteady.ImageIndex = ((int)(resources.GetObject("cbsteady.ImageIndex")));
			this.cbsteady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsteady.ImeMode")));
			this.cbsteady.Location = ((System.Drawing.Point)(resources.GetObject("cbsteady.Location")));
			this.cbsteady.Name = "cbsteady";
			this.cbsteady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsteady.RightToLeft")));
			this.cbsteady.Size = ((System.Drawing.Size)(resources.GetObject("cbsteady.Size")));
			this.cbsteady.TabIndex = ((int)(resources.GetObject("cbsteady.TabIndex")));
			this.cbsteady.Text = resources.GetString("cbsteady.Text");
			this.cbsteady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.TextAlign")));
			this.cbsteady.Visible = ((bool)(resources.GetObject("cbsteady.Visible")));
			this.cbsteady.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cblove
			// 
			this.cblove.AccessibleDescription = resources.GetString("cblove.AccessibleDescription");
			this.cblove.AccessibleName = resources.GetString("cblove.AccessibleName");
			this.cblove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblove.Anchor")));
			this.cblove.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cblove.Appearance")));
			this.cblove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblove.BackgroundImage")));
			this.cblove.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.CheckAlign")));
			this.cblove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblove.Dock")));
			this.cblove.Enabled = ((bool)(resources.GetObject("cblove.Enabled")));
			this.cblove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cblove.FlatStyle")));
			this.cblove.Font = ((System.Drawing.Font)(resources.GetObject("cblove.Font")));
			this.cblove.Image = ((System.Drawing.Image)(resources.GetObject("cblove.Image")));
			this.cblove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.ImageAlign")));
			this.cblove.ImageIndex = ((int)(resources.GetObject("cblove.ImageIndex")));
			this.cblove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblove.ImeMode")));
			this.cblove.Location = ((System.Drawing.Point)(resources.GetObject("cblove.Location")));
			this.cblove.Name = "cblove";
			this.cblove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblove.RightToLeft")));
			this.cblove.Size = ((System.Drawing.Size)(resources.GetObject("cblove.Size")));
			this.cblove.TabIndex = ((int)(resources.GetObject("cblove.TabIndex")));
			this.cblove.Text = resources.GetString("cblove.Text");
			this.cblove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.TextAlign")));
			this.cblove.Visible = ((bool)(resources.GetObject("cblove.Visible")));
			this.cblove.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbcrush
			// 
			this.cbcrush.AccessibleDescription = resources.GetString("cbcrush.AccessibleDescription");
			this.cbcrush.AccessibleName = resources.GetString("cbcrush.AccessibleName");
			this.cbcrush.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcrush.Anchor")));
			this.cbcrush.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcrush.Appearance")));
			this.cbcrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcrush.BackgroundImage")));
			this.cbcrush.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.CheckAlign")));
			this.cbcrush.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcrush.Dock")));
			this.cbcrush.Enabled = ((bool)(resources.GetObject("cbcrush.Enabled")));
			this.cbcrush.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcrush.FlatStyle")));
			this.cbcrush.Font = ((System.Drawing.Font)(resources.GetObject("cbcrush.Font")));
			this.cbcrush.Image = ((System.Drawing.Image)(resources.GetObject("cbcrush.Image")));
			this.cbcrush.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.ImageAlign")));
			this.cbcrush.ImageIndex = ((int)(resources.GetObject("cbcrush.ImageIndex")));
			this.cbcrush.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcrush.ImeMode")));
			this.cbcrush.Location = ((System.Drawing.Point)(resources.GetObject("cbcrush.Location")));
			this.cbcrush.Name = "cbcrush";
			this.cbcrush.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcrush.RightToLeft")));
			this.cbcrush.Size = ((System.Drawing.Size)(resources.GetObject("cbcrush.Size")));
			this.cbcrush.TabIndex = ((int)(resources.GetObject("cbcrush.TabIndex")));
			this.cbcrush.Text = resources.GetString("cbcrush.Text");
			this.cbcrush.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.TextAlign")));
			this.cbcrush.Visible = ((bool)(resources.GetObject("cbcrush.Visible")));
			this.cbcrush.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbbuddie
			// 
			this.cbbuddie.AccessibleDescription = resources.GetString("cbbuddie.AccessibleDescription");
			this.cbbuddie.AccessibleName = resources.GetString("cbbuddie.AccessibleName");
			this.cbbuddie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbuddie.Anchor")));
			this.cbbuddie.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbuddie.Appearance")));
			this.cbbuddie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbuddie.BackgroundImage")));
			this.cbbuddie.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.CheckAlign")));
			this.cbbuddie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbuddie.Dock")));
			this.cbbuddie.Enabled = ((bool)(resources.GetObject("cbbuddie.Enabled")));
			this.cbbuddie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbuddie.FlatStyle")));
			this.cbbuddie.Font = ((System.Drawing.Font)(resources.GetObject("cbbuddie.Font")));
			this.cbbuddie.Image = ((System.Drawing.Image)(resources.GetObject("cbbuddie.Image")));
			this.cbbuddie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.ImageAlign")));
			this.cbbuddie.ImageIndex = ((int)(resources.GetObject("cbbuddie.ImageIndex")));
			this.cbbuddie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbuddie.ImeMode")));
			this.cbbuddie.Location = ((System.Drawing.Point)(resources.GetObject("cbbuddie.Location")));
			this.cbbuddie.Name = "cbbuddie";
			this.cbbuddie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbuddie.RightToLeft")));
			this.cbbuddie.Size = ((System.Drawing.Size)(resources.GetObject("cbbuddie.Size")));
			this.cbbuddie.TabIndex = ((int)(resources.GetObject("cbbuddie.TabIndex")));
			this.cbbuddie.Text = resources.GetString("cbbuddie.Text");
			this.cbbuddie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.TextAlign")));
			this.cbbuddie.Visible = ((bool)(resources.GetObject("cbbuddie.Visible")));
			this.cbbuddie.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbfriend
			// 
			this.cbfriend.AccessibleDescription = resources.GetString("cbfriend.AccessibleDescription");
			this.cbfriend.AccessibleName = resources.GetString("cbfriend.AccessibleName");
			this.cbfriend.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfriend.Anchor")));
			this.cbfriend.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfriend.Appearance")));
			this.cbfriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfriend.BackgroundImage")));
			this.cbfriend.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.CheckAlign")));
			this.cbfriend.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfriend.Dock")));
			this.cbfriend.Enabled = ((bool)(resources.GetObject("cbfriend.Enabled")));
			this.cbfriend.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfriend.FlatStyle")));
			this.cbfriend.Font = ((System.Drawing.Font)(resources.GetObject("cbfriend.Font")));
			this.cbfriend.Image = ((System.Drawing.Image)(resources.GetObject("cbfriend.Image")));
			this.cbfriend.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.ImageAlign")));
			this.cbfriend.ImageIndex = ((int)(resources.GetObject("cbfriend.ImageIndex")));
			this.cbfriend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfriend.ImeMode")));
			this.cbfriend.Location = ((System.Drawing.Point)(resources.GetObject("cbfriend.Location")));
			this.cbfriend.Name = "cbfriend";
			this.cbfriend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfriend.RightToLeft")));
			this.cbfriend.Size = ((System.Drawing.Size)(resources.GetObject("cbfriend.Size")));
			this.cbfriend.TabIndex = ((int)(resources.GetObject("cbfriend.TabIndex")));
			this.cbfriend.Text = resources.GetString("cbfriend.Text");
			this.cbfriend.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.TextAlign")));
			this.cbfriend.Visible = ((bool)(resources.GetObject("cbfriend.Visible")));
			this.cbfriend.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// cbenemy
			// 
			this.cbenemy.AccessibleDescription = resources.GetString("cbenemy.AccessibleDescription");
			this.cbenemy.AccessibleName = resources.GetString("cbenemy.AccessibleName");
			this.cbenemy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbenemy.Anchor")));
			this.cbenemy.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbenemy.Appearance")));
			this.cbenemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbenemy.BackgroundImage")));
			this.cbenemy.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.CheckAlign")));
			this.cbenemy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbenemy.Dock")));
			this.cbenemy.Enabled = ((bool)(resources.GetObject("cbenemy.Enabled")));
			this.cbenemy.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbenemy.FlatStyle")));
			this.cbenemy.Font = ((System.Drawing.Font)(resources.GetObject("cbenemy.Font")));
			this.cbenemy.Image = ((System.Drawing.Image)(resources.GetObject("cbenemy.Image")));
			this.cbenemy.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.ImageAlign")));
			this.cbenemy.ImageIndex = ((int)(resources.GetObject("cbenemy.ImageIndex")));
			this.cbenemy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbenemy.ImeMode")));
			this.cbenemy.Location = ((System.Drawing.Point)(resources.GetObject("cbenemy.Location")));
			this.cbenemy.Name = "cbenemy";
			this.cbenemy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbenemy.RightToLeft")));
			this.cbenemy.Size = ((System.Drawing.Size)(resources.GetObject("cbenemy.Size")));
			this.cbenemy.TabIndex = ((int)(resources.GetObject("cbenemy.TabIndex")));
			this.cbenemy.Text = resources.GetString("cbenemy.Text");
			this.cbenemy.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.TextAlign")));
			this.cbenemy.Visible = ((bool)(resources.GetObject("cbenemy.Visible")));
			this.cbenemy.CheckedChanged += new System.EventHandler(this.ChangedState);
			// 
			// pbDay
			// 
			this.pbDay.AccessibleDescription = resources.GetString("pbDay.AccessibleDescription");
			this.pbDay.AccessibleName = resources.GetString("pbDay.AccessibleName");
			this.pbDay.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbDay.Anchor")));
			this.pbDay.AutoScroll = ((bool)(resources.GetObject("pbDay.AutoScroll")));
			this.pbDay.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbDay.AutoScrollMargin")));
			this.pbDay.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbDay.AutoScrollMinSize")));
			this.pbDay.BackColor = System.Drawing.Color.Transparent;
			this.pbDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbDay.BackgroundImage")));
			this.pbDay.DisplayOffset = 0;
			this.pbDay.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbDay.Dock")));
			this.pbDay.DockPadding.Bottom = 5;
			this.pbDay.Enabled = ((bool)(resources.GetObject("pbDay.Enabled")));
			this.pbDay.Font = ((System.Drawing.Font)(resources.GetObject("pbDay.Font")));
			this.pbDay.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbDay.ImeMode")));
			this.pbDay.LabelText = resources.GetString("pbDay.LabelText");
			this.pbDay.LabelWidth = ((int)(resources.GetObject("pbDay.LabelWidth")));
			this.pbDay.Location = ((System.Drawing.Point)(resources.GetObject("pbDay.Location")));
			this.pbDay.Maximum = 200;
			this.pbDay.Name = "pbDay";
			this.pbDay.NumberFormat = "N0";
			this.pbDay.NumberOffset = -100;
			this.pbDay.NumberScale = 1;
			this.pbDay.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbDay.RightToLeft")));
			this.pbDay.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbDay.Size = ((System.Drawing.Size)(resources.GetObject("pbDay.Size")));
			this.pbDay.Style = Ambertation.Windows.Forms.ProgresBarStyle.Simple;
			this.pbDay.TabIndex = ((int)(resources.GetObject("pbDay.TabIndex")));
			this.pbDay.TextboxWidth = ((int)(resources.GetObject("pbDay.TextboxWidth")));
			this.pbDay.TokenCount = 30;
			this.pbDay.UnselectedColor = System.Drawing.Color.Black;
			this.pbDay.Value = 100;
			this.pbDay.Visible = ((bool)(resources.GetObject("pbDay.Visible")));
			this.pbDay.Changed += new System.EventHandler(this.ChangedDay);
			// 
			// pbLife
			// 
			this.pbLife.AccessibleDescription = resources.GetString("pbLife.AccessibleDescription");
			this.pbLife.AccessibleName = resources.GetString("pbLife.AccessibleName");
			this.pbLife.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbLife.Anchor")));
			this.pbLife.AutoScroll = ((bool)(resources.GetObject("pbLife.AutoScroll")));
			this.pbLife.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbLife.AutoScrollMargin")));
			this.pbLife.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbLife.AutoScrollMinSize")));
			this.pbLife.BackColor = System.Drawing.Color.Transparent;
			this.pbLife.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLife.BackgroundImage")));
			this.pbLife.DisplayOffset = 0;
			this.pbLife.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbLife.Dock")));
			this.pbLife.DockPadding.Bottom = 5;
			this.pbLife.Enabled = ((bool)(resources.GetObject("pbLife.Enabled")));
			this.pbLife.Font = ((System.Drawing.Font)(resources.GetObject("pbLife.Font")));
			this.pbLife.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbLife.ImeMode")));
			this.pbLife.LabelText = resources.GetString("pbLife.LabelText");
			this.pbLife.LabelWidth = ((int)(resources.GetObject("pbLife.LabelWidth")));
			this.pbLife.Location = ((System.Drawing.Point)(resources.GetObject("pbLife.Location")));
			this.pbLife.Maximum = 200;
			this.pbLife.Name = "pbLife";
			this.pbLife.NumberFormat = "N0";
			this.pbLife.NumberOffset = -100;
			this.pbLife.NumberScale = 1;
			this.pbLife.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbLife.RightToLeft")));
			this.pbLife.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbLife.Size = ((System.Drawing.Size)(resources.GetObject("pbLife.Size")));
			this.pbLife.Style = Ambertation.Windows.Forms.ProgresBarStyle.Simple;
			this.pbLife.TabIndex = ((int)(resources.GetObject("pbLife.TabIndex")));
			this.pbLife.TextboxWidth = ((int)(resources.GetObject("pbLife.TextboxWidth")));
			this.pbLife.TokenCount = 30;
			this.pbLife.UnselectedColor = System.Drawing.Color.Black;
			this.pbLife.Value = 100;
			this.pbLife.Visible = ((bool)(resources.GetObject("pbLife.Visible")));
			this.pbLife.Changed += new System.EventHandler(this.ChangedLife);
			// 
			// tbRel
			// 
			this.tbRel.AccessibleDescription = resources.GetString("tbRel.AccessibleDescription");
			this.tbRel.AccessibleName = resources.GetString("tbRel.AccessibleName");
			this.tbRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbRel.Anchor")));
			this.tbRel.AutoSize = ((bool)(resources.GetObject("tbRel.AutoSize")));
			this.tbRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbRel.BackgroundImage")));
			this.tbRel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbRel.Dock")));
			this.tbRel.Enabled = ((bool)(resources.GetObject("tbRel.Enabled")));
			this.tbRel.Font = ((System.Drawing.Font)(resources.GetObject("tbRel.Font")));
			this.tbRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbRel.ImeMode")));
			this.tbRel.Location = ((System.Drawing.Point)(resources.GetObject("tbRel.Location")));
			this.tbRel.MaxLength = ((int)(resources.GetObject("tbRel.MaxLength")));
			this.tbRel.Multiline = ((bool)(resources.GetObject("tbRel.Multiline")));
			this.tbRel.Name = "tbRel";
			this.tbRel.PasswordChar = ((char)(resources.GetObject("tbRel.PasswordChar")));
			this.tbRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbRel.RightToLeft")));
			this.tbRel.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbRel.ScrollBars")));
			this.tbRel.Size = ((System.Drawing.Size)(resources.GetObject("tbRel.Size")));
			this.tbRel.TabIndex = ((int)(resources.GetObject("tbRel.TabIndex")));
			this.tbRel.Text = resources.GetString("tbRel.Text");
			this.tbRel.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbRel.TextAlign")));
			this.tbRel.Visible = ((bool)(resources.GetObject("tbRel.Visible")));
			this.tbRel.WordWrap = ((bool)(resources.GetObject("tbRel.WordWrap")));
			this.tbRel.TextChanged += new System.EventHandler(this.ChangedRelationText);
			// 
			// CommonSrel
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
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
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CommonSrel";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

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
			if (this.cbfamtype.SelectedIndex>0) 			
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
