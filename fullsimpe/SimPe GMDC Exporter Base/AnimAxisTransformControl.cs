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

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Zusammenfassung für AnimAxisTransformControl.
	/// </summary>
	public class AnimAxisTransformControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private Ambertation.Windows.Forms.TransparentCheckBox cbEvent;
		private System.Windows.Forms.TextBox tbTimeCode;
		private System.Windows.Forms.TextBox tbParameter;
		private System.Windows.Forms.TextBox tbU1;
		private System.Windows.Forms.TextBox tbU2;
		private System.Windows.Forms.TextBox tbU2Float;
		private System.Windows.Forms.TextBox tbU1Float;
		private System.Windows.Forms.TextBox tbParameterFloat;
		private System.Windows.Forms.TextBox tbU2Hex;
		private System.Windows.Forms.TextBox tbU1Hex;
		private System.Windows.Forms.TextBox tbParameterHex;
		private System.Windows.Forms.TextBox tbU2Bin;
		private System.Windows.Forms.TextBox tbU1Bin;
		private System.Windows.Forms.TextBox tbParameterBin;
		private System.Windows.Forms.LinkLabel llDelete;
		private System.Windows.Forms.LinkLabel llAdd;
		private Ambertation.Windows.Forms.TransparentCheckBox cbParentLock;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnimAxisTransformControl()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			CanCreate = false;
			Clear();

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnimAxisTransformControl));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbEvent = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.tbTimeCode = new System.Windows.Forms.TextBox();
			this.tbParameter = new System.Windows.Forms.TextBox();
			this.tbU1 = new System.Windows.Forms.TextBox();
			this.tbU2 = new System.Windows.Forms.TextBox();
			this.tbU2Float = new System.Windows.Forms.TextBox();
			this.tbU1Float = new System.Windows.Forms.TextBox();
			this.tbParameterFloat = new System.Windows.Forms.TextBox();
			this.tbU2Hex = new System.Windows.Forms.TextBox();
			this.tbU1Hex = new System.Windows.Forms.TextBox();
			this.tbParameterHex = new System.Windows.Forms.TextBox();
			this.tbU2Bin = new System.Windows.Forms.TextBox();
			this.tbU1Bin = new System.Windows.Forms.TextBox();
			this.tbParameterBin = new System.Windows.Forms.TextBox();
			this.llDelete = new System.Windows.Forms.LinkLabel();
			this.llAdd = new System.Windows.Forms.LinkLabel();
			this.cbParentLock = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// cbEvent
			// 
			this.cbEvent.AccessibleDescription = resources.GetString("cbEvent.AccessibleDescription");
			this.cbEvent.AccessibleName = resources.GetString("cbEvent.AccessibleName");
			this.cbEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbEvent.Anchor")));
			this.cbEvent.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbEvent.Appearance")));
			this.cbEvent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEvent.BackgroundImage")));
			this.cbEvent.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbEvent.CheckAlign")));
			this.cbEvent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbEvent.Dock")));
			this.cbEvent.Enabled = ((bool)(resources.GetObject("cbEvent.Enabled")));
			this.cbEvent.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbEvent.FlatStyle")));
			this.cbEvent.Font = ((System.Drawing.Font)(resources.GetObject("cbEvent.Font")));
			this.cbEvent.Image = ((System.Drawing.Image)(resources.GetObject("cbEvent.Image")));
			this.cbEvent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbEvent.ImageAlign")));
			this.cbEvent.ImageIndex = ((int)(resources.GetObject("cbEvent.ImageIndex")));
			this.cbEvent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbEvent.ImeMode")));
			this.cbEvent.Location = ((System.Drawing.Point)(resources.GetObject("cbEvent.Location")));
			this.cbEvent.Name = "cbEvent";
			this.cbEvent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbEvent.RightToLeft")));
			this.cbEvent.Size = ((System.Drawing.Size)(resources.GetObject("cbEvent.Size")));
			this.cbEvent.TabIndex = ((int)(resources.GetObject("cbEvent.TabIndex")));
			this.cbEvent.Text = resources.GetString("cbEvent.Text");
			this.cbEvent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbEvent.TextAlign")));
			this.cbEvent.Visible = ((bool)(resources.GetObject("cbEvent.Visible")));
			this.cbEvent.CheckedChanged += new System.EventHandler(this.cbEvent_CheckedChanged);
			// 
			// tbTimeCode
			// 
			this.tbTimeCode.AccessibleDescription = resources.GetString("tbTimeCode.AccessibleDescription");
			this.tbTimeCode.AccessibleName = resources.GetString("tbTimeCode.AccessibleName");
			this.tbTimeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbTimeCode.Anchor")));
			this.tbTimeCode.AutoSize = ((bool)(resources.GetObject("tbTimeCode.AutoSize")));
			this.tbTimeCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimeCode.BackgroundImage")));
			this.tbTimeCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbTimeCode.Dock")));
			this.tbTimeCode.Enabled = ((bool)(resources.GetObject("tbTimeCode.Enabled")));
			this.tbTimeCode.Font = ((System.Drawing.Font)(resources.GetObject("tbTimeCode.Font")));
			this.tbTimeCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbTimeCode.ImeMode")));
			this.tbTimeCode.Location = ((System.Drawing.Point)(resources.GetObject("tbTimeCode.Location")));
			this.tbTimeCode.MaxLength = ((int)(resources.GetObject("tbTimeCode.MaxLength")));
			this.tbTimeCode.Multiline = ((bool)(resources.GetObject("tbTimeCode.Multiline")));
			this.tbTimeCode.Name = "tbTimeCode";
			this.tbTimeCode.PasswordChar = ((char)(resources.GetObject("tbTimeCode.PasswordChar")));
			this.tbTimeCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbTimeCode.RightToLeft")));
			this.tbTimeCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbTimeCode.ScrollBars")));
			this.tbTimeCode.Size = ((System.Drawing.Size)(resources.GetObject("tbTimeCode.Size")));
			this.tbTimeCode.TabIndex = ((int)(resources.GetObject("tbTimeCode.TabIndex")));
			this.tbTimeCode.Text = resources.GetString("tbTimeCode.Text");
			this.tbTimeCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbTimeCode.TextAlign")));
			this.tbTimeCode.Visible = ((bool)(resources.GetObject("tbTimeCode.Visible")));
			this.tbTimeCode.WordWrap = ((bool)(resources.GetObject("tbTimeCode.WordWrap")));
			this.tbTimeCode.TextChanged += new System.EventHandler(this.tbTimeCode_TextChanged);
			// 
			// tbParameter
			// 
			this.tbParameter.AccessibleDescription = resources.GetString("tbParameter.AccessibleDescription");
			this.tbParameter.AccessibleName = resources.GetString("tbParameter.AccessibleName");
			this.tbParameter.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbParameter.Anchor")));
			this.tbParameter.AutoSize = ((bool)(resources.GetObject("tbParameter.AutoSize")));
			this.tbParameter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbParameter.BackgroundImage")));
			this.tbParameter.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbParameter.Dock")));
			this.tbParameter.Enabled = ((bool)(resources.GetObject("tbParameter.Enabled")));
			this.tbParameter.Font = ((System.Drawing.Font)(resources.GetObject("tbParameter.Font")));
			this.tbParameter.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbParameter.ImeMode")));
			this.tbParameter.Location = ((System.Drawing.Point)(resources.GetObject("tbParameter.Location")));
			this.tbParameter.MaxLength = ((int)(resources.GetObject("tbParameter.MaxLength")));
			this.tbParameter.Multiline = ((bool)(resources.GetObject("tbParameter.Multiline")));
			this.tbParameter.Name = "tbParameter";
			this.tbParameter.PasswordChar = ((char)(resources.GetObject("tbParameter.PasswordChar")));
			this.tbParameter.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbParameter.RightToLeft")));
			this.tbParameter.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbParameter.ScrollBars")));
			this.tbParameter.Size = ((System.Drawing.Size)(resources.GetObject("tbParameter.Size")));
			this.tbParameter.TabIndex = ((int)(resources.GetObject("tbParameter.TabIndex")));
			this.tbParameter.Text = resources.GetString("tbParameter.Text");
			this.tbParameter.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbParameter.TextAlign")));
			this.tbParameter.Visible = ((bool)(resources.GetObject("tbParameter.Visible")));
			this.tbParameter.WordWrap = ((bool)(resources.GetObject("tbParameter.WordWrap")));
			this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
			// 
			// tbU1
			// 
			this.tbU1.AccessibleDescription = resources.GetString("tbU1.AccessibleDescription");
			this.tbU1.AccessibleName = resources.GetString("tbU1.AccessibleName");
			this.tbU1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU1.Anchor")));
			this.tbU1.AutoSize = ((bool)(resources.GetObject("tbU1.AutoSize")));
			this.tbU1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU1.BackgroundImage")));
			this.tbU1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU1.Dock")));
			this.tbU1.Enabled = ((bool)(resources.GetObject("tbU1.Enabled")));
			this.tbU1.Font = ((System.Drawing.Font)(resources.GetObject("tbU1.Font")));
			this.tbU1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU1.ImeMode")));
			this.tbU1.Location = ((System.Drawing.Point)(resources.GetObject("tbU1.Location")));
			this.tbU1.MaxLength = ((int)(resources.GetObject("tbU1.MaxLength")));
			this.tbU1.Multiline = ((bool)(resources.GetObject("tbU1.Multiline")));
			this.tbU1.Name = "tbU1";
			this.tbU1.PasswordChar = ((char)(resources.GetObject("tbU1.PasswordChar")));
			this.tbU1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU1.RightToLeft")));
			this.tbU1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU1.ScrollBars")));
			this.tbU1.Size = ((System.Drawing.Size)(resources.GetObject("tbU1.Size")));
			this.tbU1.TabIndex = ((int)(resources.GetObject("tbU1.TabIndex")));
			this.tbU1.Text = resources.GetString("tbU1.Text");
			this.tbU1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU1.TextAlign")));
			this.tbU1.Visible = ((bool)(resources.GetObject("tbU1.Visible")));
			this.tbU1.WordWrap = ((bool)(resources.GetObject("tbU1.WordWrap")));
			this.tbU1.TextChanged += new System.EventHandler(this.tbU1_TextChanged);
			// 
			// tbU2
			// 
			this.tbU2.AccessibleDescription = resources.GetString("tbU2.AccessibleDescription");
			this.tbU2.AccessibleName = resources.GetString("tbU2.AccessibleName");
			this.tbU2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU2.Anchor")));
			this.tbU2.AutoSize = ((bool)(resources.GetObject("tbU2.AutoSize")));
			this.tbU2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU2.BackgroundImage")));
			this.tbU2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU2.Dock")));
			this.tbU2.Enabled = ((bool)(resources.GetObject("tbU2.Enabled")));
			this.tbU2.Font = ((System.Drawing.Font)(resources.GetObject("tbU2.Font")));
			this.tbU2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU2.ImeMode")));
			this.tbU2.Location = ((System.Drawing.Point)(resources.GetObject("tbU2.Location")));
			this.tbU2.MaxLength = ((int)(resources.GetObject("tbU2.MaxLength")));
			this.tbU2.Multiline = ((bool)(resources.GetObject("tbU2.Multiline")));
			this.tbU2.Name = "tbU2";
			this.tbU2.PasswordChar = ((char)(resources.GetObject("tbU2.PasswordChar")));
			this.tbU2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU2.RightToLeft")));
			this.tbU2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU2.ScrollBars")));
			this.tbU2.Size = ((System.Drawing.Size)(resources.GetObject("tbU2.Size")));
			this.tbU2.TabIndex = ((int)(resources.GetObject("tbU2.TabIndex")));
			this.tbU2.Text = resources.GetString("tbU2.Text");
			this.tbU2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU2.TextAlign")));
			this.tbU2.Visible = ((bool)(resources.GetObject("tbU2.Visible")));
			this.tbU2.WordWrap = ((bool)(resources.GetObject("tbU2.WordWrap")));
			this.tbU2.TextChanged += new System.EventHandler(this.tbU2_TextChanged);
			// 
			// tbU2Float
			// 
			this.tbU2Float.AccessibleDescription = resources.GetString("tbU2Float.AccessibleDescription");
			this.tbU2Float.AccessibleName = resources.GetString("tbU2Float.AccessibleName");
			this.tbU2Float.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU2Float.Anchor")));
			this.tbU2Float.AutoSize = ((bool)(resources.GetObject("tbU2Float.AutoSize")));
			this.tbU2Float.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU2Float.BackgroundImage")));
			this.tbU2Float.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU2Float.Dock")));
			this.tbU2Float.Enabled = ((bool)(resources.GetObject("tbU2Float.Enabled")));
			this.tbU2Float.Font = ((System.Drawing.Font)(resources.GetObject("tbU2Float.Font")));
			this.tbU2Float.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU2Float.ImeMode")));
			this.tbU2Float.Location = ((System.Drawing.Point)(resources.GetObject("tbU2Float.Location")));
			this.tbU2Float.MaxLength = ((int)(resources.GetObject("tbU2Float.MaxLength")));
			this.tbU2Float.Multiline = ((bool)(resources.GetObject("tbU2Float.Multiline")));
			this.tbU2Float.Name = "tbU2Float";
			this.tbU2Float.PasswordChar = ((char)(resources.GetObject("tbU2Float.PasswordChar")));
			this.tbU2Float.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU2Float.RightToLeft")));
			this.tbU2Float.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU2Float.ScrollBars")));
			this.tbU2Float.Size = ((System.Drawing.Size)(resources.GetObject("tbU2Float.Size")));
			this.tbU2Float.TabIndex = ((int)(resources.GetObject("tbU2Float.TabIndex")));
			this.tbU2Float.Text = resources.GetString("tbU2Float.Text");
			this.tbU2Float.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU2Float.TextAlign")));
			this.tbU2Float.Visible = ((bool)(resources.GetObject("tbU2Float.Visible")));
			this.tbU2Float.WordWrap = ((bool)(resources.GetObject("tbU2Float.WordWrap")));
			this.tbU2Float.TextChanged += new System.EventHandler(this.tbU2Float_TextChanged);
			// 
			// tbU1Float
			// 
			this.tbU1Float.AccessibleDescription = resources.GetString("tbU1Float.AccessibleDescription");
			this.tbU1Float.AccessibleName = resources.GetString("tbU1Float.AccessibleName");
			this.tbU1Float.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU1Float.Anchor")));
			this.tbU1Float.AutoSize = ((bool)(resources.GetObject("tbU1Float.AutoSize")));
			this.tbU1Float.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU1Float.BackgroundImage")));
			this.tbU1Float.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU1Float.Dock")));
			this.tbU1Float.Enabled = ((bool)(resources.GetObject("tbU1Float.Enabled")));
			this.tbU1Float.Font = ((System.Drawing.Font)(resources.GetObject("tbU1Float.Font")));
			this.tbU1Float.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU1Float.ImeMode")));
			this.tbU1Float.Location = ((System.Drawing.Point)(resources.GetObject("tbU1Float.Location")));
			this.tbU1Float.MaxLength = ((int)(resources.GetObject("tbU1Float.MaxLength")));
			this.tbU1Float.Multiline = ((bool)(resources.GetObject("tbU1Float.Multiline")));
			this.tbU1Float.Name = "tbU1Float";
			this.tbU1Float.PasswordChar = ((char)(resources.GetObject("tbU1Float.PasswordChar")));
			this.tbU1Float.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU1Float.RightToLeft")));
			this.tbU1Float.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU1Float.ScrollBars")));
			this.tbU1Float.Size = ((System.Drawing.Size)(resources.GetObject("tbU1Float.Size")));
			this.tbU1Float.TabIndex = ((int)(resources.GetObject("tbU1Float.TabIndex")));
			this.tbU1Float.Text = resources.GetString("tbU1Float.Text");
			this.tbU1Float.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU1Float.TextAlign")));
			this.tbU1Float.Visible = ((bool)(resources.GetObject("tbU1Float.Visible")));
			this.tbU1Float.WordWrap = ((bool)(resources.GetObject("tbU1Float.WordWrap")));
			this.tbU1Float.TextChanged += new System.EventHandler(this.tbU1Float_TextChanged);
			// 
			// tbParameterFloat
			// 
			this.tbParameterFloat.AccessibleDescription = resources.GetString("tbParameterFloat.AccessibleDescription");
			this.tbParameterFloat.AccessibleName = resources.GetString("tbParameterFloat.AccessibleName");
			this.tbParameterFloat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbParameterFloat.Anchor")));
			this.tbParameterFloat.AutoSize = ((bool)(resources.GetObject("tbParameterFloat.AutoSize")));
			this.tbParameterFloat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbParameterFloat.BackgroundImage")));
			this.tbParameterFloat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbParameterFloat.Dock")));
			this.tbParameterFloat.Enabled = ((bool)(resources.GetObject("tbParameterFloat.Enabled")));
			this.tbParameterFloat.Font = ((System.Drawing.Font)(resources.GetObject("tbParameterFloat.Font")));
			this.tbParameterFloat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbParameterFloat.ImeMode")));
			this.tbParameterFloat.Location = ((System.Drawing.Point)(resources.GetObject("tbParameterFloat.Location")));
			this.tbParameterFloat.MaxLength = ((int)(resources.GetObject("tbParameterFloat.MaxLength")));
			this.tbParameterFloat.Multiline = ((bool)(resources.GetObject("tbParameterFloat.Multiline")));
			this.tbParameterFloat.Name = "tbParameterFloat";
			this.tbParameterFloat.PasswordChar = ((char)(resources.GetObject("tbParameterFloat.PasswordChar")));
			this.tbParameterFloat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbParameterFloat.RightToLeft")));
			this.tbParameterFloat.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbParameterFloat.ScrollBars")));
			this.tbParameterFloat.Size = ((System.Drawing.Size)(resources.GetObject("tbParameterFloat.Size")));
			this.tbParameterFloat.TabIndex = ((int)(resources.GetObject("tbParameterFloat.TabIndex")));
			this.tbParameterFloat.Text = resources.GetString("tbParameterFloat.Text");
			this.tbParameterFloat.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbParameterFloat.TextAlign")));
			this.tbParameterFloat.Visible = ((bool)(resources.GetObject("tbParameterFloat.Visible")));
			this.tbParameterFloat.WordWrap = ((bool)(resources.GetObject("tbParameterFloat.WordWrap")));
			this.tbParameterFloat.TextChanged += new System.EventHandler(this.tbParameterFloat_TextChanged);
			// 
			// tbU2Hex
			// 
			this.tbU2Hex.AccessibleDescription = resources.GetString("tbU2Hex.AccessibleDescription");
			this.tbU2Hex.AccessibleName = resources.GetString("tbU2Hex.AccessibleName");
			this.tbU2Hex.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU2Hex.Anchor")));
			this.tbU2Hex.AutoSize = ((bool)(resources.GetObject("tbU2Hex.AutoSize")));
			this.tbU2Hex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU2Hex.BackgroundImage")));
			this.tbU2Hex.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU2Hex.Dock")));
			this.tbU2Hex.Enabled = ((bool)(resources.GetObject("tbU2Hex.Enabled")));
			this.tbU2Hex.Font = ((System.Drawing.Font)(resources.GetObject("tbU2Hex.Font")));
			this.tbU2Hex.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU2Hex.ImeMode")));
			this.tbU2Hex.Location = ((System.Drawing.Point)(resources.GetObject("tbU2Hex.Location")));
			this.tbU2Hex.MaxLength = ((int)(resources.GetObject("tbU2Hex.MaxLength")));
			this.tbU2Hex.Multiline = ((bool)(resources.GetObject("tbU2Hex.Multiline")));
			this.tbU2Hex.Name = "tbU2Hex";
			this.tbU2Hex.PasswordChar = ((char)(resources.GetObject("tbU2Hex.PasswordChar")));
			this.tbU2Hex.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU2Hex.RightToLeft")));
			this.tbU2Hex.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU2Hex.ScrollBars")));
			this.tbU2Hex.Size = ((System.Drawing.Size)(resources.GetObject("tbU2Hex.Size")));
			this.tbU2Hex.TabIndex = ((int)(resources.GetObject("tbU2Hex.TabIndex")));
			this.tbU2Hex.Text = resources.GetString("tbU2Hex.Text");
			this.tbU2Hex.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU2Hex.TextAlign")));
			this.tbU2Hex.Visible = ((bool)(resources.GetObject("tbU2Hex.Visible")));
			this.tbU2Hex.WordWrap = ((bool)(resources.GetObject("tbU2Hex.WordWrap")));
			this.tbU2Hex.TextChanged += new System.EventHandler(this.tbU2Hex_TextChanged);
			// 
			// tbU1Hex
			// 
			this.tbU1Hex.AccessibleDescription = resources.GetString("tbU1Hex.AccessibleDescription");
			this.tbU1Hex.AccessibleName = resources.GetString("tbU1Hex.AccessibleName");
			this.tbU1Hex.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU1Hex.Anchor")));
			this.tbU1Hex.AutoSize = ((bool)(resources.GetObject("tbU1Hex.AutoSize")));
			this.tbU1Hex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU1Hex.BackgroundImage")));
			this.tbU1Hex.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU1Hex.Dock")));
			this.tbU1Hex.Enabled = ((bool)(resources.GetObject("tbU1Hex.Enabled")));
			this.tbU1Hex.Font = ((System.Drawing.Font)(resources.GetObject("tbU1Hex.Font")));
			this.tbU1Hex.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU1Hex.ImeMode")));
			this.tbU1Hex.Location = ((System.Drawing.Point)(resources.GetObject("tbU1Hex.Location")));
			this.tbU1Hex.MaxLength = ((int)(resources.GetObject("tbU1Hex.MaxLength")));
			this.tbU1Hex.Multiline = ((bool)(resources.GetObject("tbU1Hex.Multiline")));
			this.tbU1Hex.Name = "tbU1Hex";
			this.tbU1Hex.PasswordChar = ((char)(resources.GetObject("tbU1Hex.PasswordChar")));
			this.tbU1Hex.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU1Hex.RightToLeft")));
			this.tbU1Hex.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU1Hex.ScrollBars")));
			this.tbU1Hex.Size = ((System.Drawing.Size)(resources.GetObject("tbU1Hex.Size")));
			this.tbU1Hex.TabIndex = ((int)(resources.GetObject("tbU1Hex.TabIndex")));
			this.tbU1Hex.Text = resources.GetString("tbU1Hex.Text");
			this.tbU1Hex.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU1Hex.TextAlign")));
			this.tbU1Hex.Visible = ((bool)(resources.GetObject("tbU1Hex.Visible")));
			this.tbU1Hex.WordWrap = ((bool)(resources.GetObject("tbU1Hex.WordWrap")));
			this.tbU1Hex.TextChanged += new System.EventHandler(this.tbU1Hex_TextChanged);
			// 
			// tbParameterHex
			// 
			this.tbParameterHex.AccessibleDescription = resources.GetString("tbParameterHex.AccessibleDescription");
			this.tbParameterHex.AccessibleName = resources.GetString("tbParameterHex.AccessibleName");
			this.tbParameterHex.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbParameterHex.Anchor")));
			this.tbParameterHex.AutoSize = ((bool)(resources.GetObject("tbParameterHex.AutoSize")));
			this.tbParameterHex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbParameterHex.BackgroundImage")));
			this.tbParameterHex.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbParameterHex.Dock")));
			this.tbParameterHex.Enabled = ((bool)(resources.GetObject("tbParameterHex.Enabled")));
			this.tbParameterHex.Font = ((System.Drawing.Font)(resources.GetObject("tbParameterHex.Font")));
			this.tbParameterHex.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbParameterHex.ImeMode")));
			this.tbParameterHex.Location = ((System.Drawing.Point)(resources.GetObject("tbParameterHex.Location")));
			this.tbParameterHex.MaxLength = ((int)(resources.GetObject("tbParameterHex.MaxLength")));
			this.tbParameterHex.Multiline = ((bool)(resources.GetObject("tbParameterHex.Multiline")));
			this.tbParameterHex.Name = "tbParameterHex";
			this.tbParameterHex.PasswordChar = ((char)(resources.GetObject("tbParameterHex.PasswordChar")));
			this.tbParameterHex.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbParameterHex.RightToLeft")));
			this.tbParameterHex.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbParameterHex.ScrollBars")));
			this.tbParameterHex.Size = ((System.Drawing.Size)(resources.GetObject("tbParameterHex.Size")));
			this.tbParameterHex.TabIndex = ((int)(resources.GetObject("tbParameterHex.TabIndex")));
			this.tbParameterHex.Text = resources.GetString("tbParameterHex.Text");
			this.tbParameterHex.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbParameterHex.TextAlign")));
			this.tbParameterHex.Visible = ((bool)(resources.GetObject("tbParameterHex.Visible")));
			this.tbParameterHex.WordWrap = ((bool)(resources.GetObject("tbParameterHex.WordWrap")));
			this.tbParameterHex.TextChanged += new System.EventHandler(this.tbParameterHex_TextChanged);
			// 
			// tbU2Bin
			// 
			this.tbU2Bin.AccessibleDescription = resources.GetString("tbU2Bin.AccessibleDescription");
			this.tbU2Bin.AccessibleName = resources.GetString("tbU2Bin.AccessibleName");
			this.tbU2Bin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU2Bin.Anchor")));
			this.tbU2Bin.AutoSize = ((bool)(resources.GetObject("tbU2Bin.AutoSize")));
			this.tbU2Bin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU2Bin.BackgroundImage")));
			this.tbU2Bin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU2Bin.Dock")));
			this.tbU2Bin.Enabled = ((bool)(resources.GetObject("tbU2Bin.Enabled")));
			this.tbU2Bin.Font = ((System.Drawing.Font)(resources.GetObject("tbU2Bin.Font")));
			this.tbU2Bin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU2Bin.ImeMode")));
			this.tbU2Bin.Location = ((System.Drawing.Point)(resources.GetObject("tbU2Bin.Location")));
			this.tbU2Bin.MaxLength = ((int)(resources.GetObject("tbU2Bin.MaxLength")));
			this.tbU2Bin.Multiline = ((bool)(resources.GetObject("tbU2Bin.Multiline")));
			this.tbU2Bin.Name = "tbU2Bin";
			this.tbU2Bin.PasswordChar = ((char)(resources.GetObject("tbU2Bin.PasswordChar")));
			this.tbU2Bin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU2Bin.RightToLeft")));
			this.tbU2Bin.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU2Bin.ScrollBars")));
			this.tbU2Bin.Size = ((System.Drawing.Size)(resources.GetObject("tbU2Bin.Size")));
			this.tbU2Bin.TabIndex = ((int)(resources.GetObject("tbU2Bin.TabIndex")));
			this.tbU2Bin.Text = resources.GetString("tbU2Bin.Text");
			this.tbU2Bin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU2Bin.TextAlign")));
			this.tbU2Bin.Visible = ((bool)(resources.GetObject("tbU2Bin.Visible")));
			this.tbU2Bin.WordWrap = ((bool)(resources.GetObject("tbU2Bin.WordWrap")));
			// 
			// tbU1Bin
			// 
			this.tbU1Bin.AccessibleDescription = resources.GetString("tbU1Bin.AccessibleDescription");
			this.tbU1Bin.AccessibleName = resources.GetString("tbU1Bin.AccessibleName");
			this.tbU1Bin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbU1Bin.Anchor")));
			this.tbU1Bin.AutoSize = ((bool)(resources.GetObject("tbU1Bin.AutoSize")));
			this.tbU1Bin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbU1Bin.BackgroundImage")));
			this.tbU1Bin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbU1Bin.Dock")));
			this.tbU1Bin.Enabled = ((bool)(resources.GetObject("tbU1Bin.Enabled")));
			this.tbU1Bin.Font = ((System.Drawing.Font)(resources.GetObject("tbU1Bin.Font")));
			this.tbU1Bin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbU1Bin.ImeMode")));
			this.tbU1Bin.Location = ((System.Drawing.Point)(resources.GetObject("tbU1Bin.Location")));
			this.tbU1Bin.MaxLength = ((int)(resources.GetObject("tbU1Bin.MaxLength")));
			this.tbU1Bin.Multiline = ((bool)(resources.GetObject("tbU1Bin.Multiline")));
			this.tbU1Bin.Name = "tbU1Bin";
			this.tbU1Bin.PasswordChar = ((char)(resources.GetObject("tbU1Bin.PasswordChar")));
			this.tbU1Bin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbU1Bin.RightToLeft")));
			this.tbU1Bin.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbU1Bin.ScrollBars")));
			this.tbU1Bin.Size = ((System.Drawing.Size)(resources.GetObject("tbU1Bin.Size")));
			this.tbU1Bin.TabIndex = ((int)(resources.GetObject("tbU1Bin.TabIndex")));
			this.tbU1Bin.Text = resources.GetString("tbU1Bin.Text");
			this.tbU1Bin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbU1Bin.TextAlign")));
			this.tbU1Bin.Visible = ((bool)(resources.GetObject("tbU1Bin.Visible")));
			this.tbU1Bin.WordWrap = ((bool)(resources.GetObject("tbU1Bin.WordWrap")));
			// 
			// tbParameterBin
			// 
			this.tbParameterBin.AccessibleDescription = resources.GetString("tbParameterBin.AccessibleDescription");
			this.tbParameterBin.AccessibleName = resources.GetString("tbParameterBin.AccessibleName");
			this.tbParameterBin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbParameterBin.Anchor")));
			this.tbParameterBin.AutoSize = ((bool)(resources.GetObject("tbParameterBin.AutoSize")));
			this.tbParameterBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbParameterBin.BackgroundImage")));
			this.tbParameterBin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbParameterBin.Dock")));
			this.tbParameterBin.Enabled = ((bool)(resources.GetObject("tbParameterBin.Enabled")));
			this.tbParameterBin.Font = ((System.Drawing.Font)(resources.GetObject("tbParameterBin.Font")));
			this.tbParameterBin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbParameterBin.ImeMode")));
			this.tbParameterBin.Location = ((System.Drawing.Point)(resources.GetObject("tbParameterBin.Location")));
			this.tbParameterBin.MaxLength = ((int)(resources.GetObject("tbParameterBin.MaxLength")));
			this.tbParameterBin.Multiline = ((bool)(resources.GetObject("tbParameterBin.Multiline")));
			this.tbParameterBin.Name = "tbParameterBin";
			this.tbParameterBin.PasswordChar = ((char)(resources.GetObject("tbParameterBin.PasswordChar")));
			this.tbParameterBin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbParameterBin.RightToLeft")));
			this.tbParameterBin.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbParameterBin.ScrollBars")));
			this.tbParameterBin.Size = ((System.Drawing.Size)(resources.GetObject("tbParameterBin.Size")));
			this.tbParameterBin.TabIndex = ((int)(resources.GetObject("tbParameterBin.TabIndex")));
			this.tbParameterBin.Text = resources.GetString("tbParameterBin.Text");
			this.tbParameterBin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbParameterBin.TextAlign")));
			this.tbParameterBin.Visible = ((bool)(resources.GetObject("tbParameterBin.Visible")));
			this.tbParameterBin.WordWrap = ((bool)(resources.GetObject("tbParameterBin.WordWrap")));
			this.tbParameterBin.TextChanged += new System.EventHandler(this.tbParameterBin_TextChanged);
			// 
			// llDelete
			// 
			this.llDelete.AccessibleDescription = resources.GetString("llDelete.AccessibleDescription");
			this.llDelete.AccessibleName = resources.GetString("llDelete.AccessibleName");
			this.llDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llDelete.Anchor")));
			this.llDelete.AutoSize = ((bool)(resources.GetObject("llDelete.AutoSize")));
			this.llDelete.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llDelete.Dock")));
			this.llDelete.Enabled = ((bool)(resources.GetObject("llDelete.Enabled")));
			this.llDelete.Font = ((System.Drawing.Font)(resources.GetObject("llDelete.Font")));
			this.llDelete.Image = ((System.Drawing.Image)(resources.GetObject("llDelete.Image")));
			this.llDelete.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llDelete.ImageAlign")));
			this.llDelete.ImageIndex = ((int)(resources.GetObject("llDelete.ImageIndex")));
			this.llDelete.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llDelete.ImeMode")));
			this.llDelete.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llDelete.LinkArea")));
			this.llDelete.Location = ((System.Drawing.Point)(resources.GetObject("llDelete.Location")));
			this.llDelete.Name = "llDelete";
			this.llDelete.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llDelete.RightToLeft")));
			this.llDelete.Size = ((System.Drawing.Size)(resources.GetObject("llDelete.Size")));
			this.llDelete.TabIndex = ((int)(resources.GetObject("llDelete.TabIndex")));
			this.llDelete.TabStop = true;
			this.llDelete.Text = resources.GetString("llDelete.Text");
			this.llDelete.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llDelete.TextAlign")));
			this.llDelete.Visible = ((bool)(resources.GetObject("llDelete.Visible")));
			this.llDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDelete_LinkClicked);
			// 
			// llAdd
			// 
			this.llAdd.AccessibleDescription = resources.GetString("llAdd.AccessibleDescription");
			this.llAdd.AccessibleName = resources.GetString("llAdd.AccessibleName");
			this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llAdd.Anchor")));
			this.llAdd.AutoSize = ((bool)(resources.GetObject("llAdd.AutoSize")));
			this.llAdd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llAdd.Dock")));
			this.llAdd.Enabled = ((bool)(resources.GetObject("llAdd.Enabled")));
			this.llAdd.Font = ((System.Drawing.Font)(resources.GetObject("llAdd.Font")));
			this.llAdd.Image = ((System.Drawing.Image)(resources.GetObject("llAdd.Image")));
			this.llAdd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llAdd.ImageAlign")));
			this.llAdd.ImageIndex = ((int)(resources.GetObject("llAdd.ImageIndex")));
			this.llAdd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llAdd.ImeMode")));
			this.llAdd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llAdd.LinkArea")));
			this.llAdd.Location = ((System.Drawing.Point)(resources.GetObject("llAdd.Location")));
			this.llAdd.Name = "llAdd";
			this.llAdd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llAdd.RightToLeft")));
			this.llAdd.Size = ((System.Drawing.Size)(resources.GetObject("llAdd.Size")));
			this.llAdd.TabIndex = ((int)(resources.GetObject("llAdd.TabIndex")));
			this.llAdd.TabStop = true;
			this.llAdd.Text = resources.GetString("llAdd.Text");
			this.llAdd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llAdd.TextAlign")));
			this.llAdd.Visible = ((bool)(resources.GetObject("llAdd.Visible")));
			this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
			// 
			// cbParentLock
			// 
			this.cbParentLock.AccessibleDescription = resources.GetString("cbParentLock.AccessibleDescription");
			this.cbParentLock.AccessibleName = resources.GetString("cbParentLock.AccessibleName");
			this.cbParentLock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbParentLock.Anchor")));
			this.cbParentLock.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbParentLock.Appearance")));
			this.cbParentLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbParentLock.BackgroundImage")));
			this.cbParentLock.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbParentLock.CheckAlign")));
			this.cbParentLock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbParentLock.Dock")));
			this.cbParentLock.Enabled = ((bool)(resources.GetObject("cbParentLock.Enabled")));
			this.cbParentLock.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbParentLock.FlatStyle")));
			this.cbParentLock.Font = ((System.Drawing.Font)(resources.GetObject("cbParentLock.Font")));
			this.cbParentLock.Image = ((System.Drawing.Image)(resources.GetObject("cbParentLock.Image")));
			this.cbParentLock.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbParentLock.ImageAlign")));
			this.cbParentLock.ImageIndex = ((int)(resources.GetObject("cbParentLock.ImageIndex")));
			this.cbParentLock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbParentLock.ImeMode")));
			this.cbParentLock.Location = ((System.Drawing.Point)(resources.GetObject("cbParentLock.Location")));
			this.cbParentLock.Name = "cbParentLock";
			this.cbParentLock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbParentLock.RightToLeft")));
			this.cbParentLock.Size = ((System.Drawing.Size)(resources.GetObject("cbParentLock.Size")));
			this.cbParentLock.TabIndex = ((int)(resources.GetObject("cbParentLock.TabIndex")));
			this.cbParentLock.Text = resources.GetString("cbParentLock.Text");
			this.cbParentLock.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbParentLock.TextAlign")));
			this.cbParentLock.Visible = ((bool)(resources.GetObject("cbParentLock.Visible")));
			this.cbParentLock.CheckedChanged += new System.EventHandler(this.cbParentLock_CheckedChanged);
			// 
			// AnimAxisTransformControl
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.cbParentLock);
			this.Controls.Add(this.llAdd);
			this.Controls.Add(this.llDelete);
			this.Controls.Add(this.tbU2Bin);
			this.Controls.Add(this.tbU1Bin);
			this.Controls.Add(this.tbParameterBin);
			this.Controls.Add(this.tbU2Hex);
			this.Controls.Add(this.tbU1Hex);
			this.Controls.Add(this.tbParameterHex);
			this.Controls.Add(this.tbU2Float);
			this.Controls.Add(this.tbU1Float);
			this.Controls.Add(this.tbParameterFloat);
			this.Controls.Add(this.tbU2);
			this.Controls.Add(this.tbU1);
			this.Controls.Add(this.tbParameter);
			this.Controls.Add(this.tbTimeCode);
			this.Controls.Add(this.cbEvent);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "AnimAxisTransformControl";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		#region Public properties
		AnimationAxisTransform aat;
		public AnimationAxisTransform AxisTransform
		{
			get {return aat;}
			set 
			{
				aat = value;
				if (aat!=null)
					if (aat.Parent==null) 
						aat=null;
				RefreshData();
			}
		}

		public bool CanCreate
		{
			get { return llAdd.Visible; }
			set { llAdd.Visible = value; }
		}
		#endregion

		internal void Clear()
		{
			this.cbParentLock.Checked = true;
			this.cbEvent.Checked = false;
			this.tbTimeCode.Text = "0";
			this.tbParameter.Text = "0";
			this.tbU1.Text = "0";
			this.tbU2.Text = "0";

			EnableTimeCode(false);
			EnableParameter(false);
			EnableU1(false);
			EnableU2(false);

			this.llAdd.Enabled = true;

			if (Cleared!=null) Cleared(this, new EventArgs());
		}

		protected void EnableTimeCode(bool enabled)
		{
			this.cbParentLock.Enabled = enabled;
			cbEvent.Enabled = enabled;
			tbTimeCode.Enabled = enabled;
		}

		protected void EnableParameter(bool enabled)
		{
			this.llDelete.Enabled = enabled;
			tbParameter.Enabled = enabled;
			tbParameterFloat.Enabled = enabled;
			tbParameterHex.Enabled = enabled;
			tbParameterBin.Enabled = enabled;
		}

		protected void EnableU1(bool enabled)
		{
			tbU1.Enabled = enabled;
			tbU1Float.Enabled = enabled;
			tbU1Hex.Enabled = enabled;
			tbU1Bin.Enabled = enabled;
		}

		protected void EnableU2(bool enabled)
		{
			tbU2.Enabled = enabled;
			tbU2Float.Enabled = enabled;
			tbU2Hex.Enabled = enabled;
			tbU2Bin.Enabled = enabled;
		}

		public void RefreshData()
		{
			Clear();

			if (aat!=null) 
			{
				this.llAdd.Enabled = false;
				intern = true;
				refresh = true;
				if (aat.Parent.Type== AnimationTokenType.TwoByte) EnableParameter(true);
				else if (aat.Parent.Type== AnimationTokenType.SixByte) 
				{
					EnableTimeCode(true);
					EnableParameter(true);
					EnableU1(true);
				} 
				else 
				{
					EnableTimeCode(true);
					EnableParameter(true);
					EnableU1(true);
					EnableU2(true);
				}

				cbEvent.Checked = aat.Linear;
				this.cbParentLock.Checked = aat.ParentLocked;
				tbTimeCode.Text = aat.TimeCode.ToString();
				tbParameter.Text = aat.Parameter.ToString();
				tbU1.Text = aat.Unknown1.ToString();
				tbU2.Text = aat.Unknown2.ToString();

				refresh = false;
				intern = false;
			}
		}

		bool intern, refresh;
		private void tbParameter_TextChanged(object sender, System.EventArgs e)
		{			
			if (intern && !refresh) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbParameter.Text, aat.Parameter, 10);

			tbParameterFloat.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null) 
				{
					float f = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType);
					if (aat.Parent.Parent.TransformationType== FrameType.Rotation) 
						f = (float)SimPe.Geometry.Quaternion.RadToDeg(f);
					tbParameterFloat.Text = f.ToString("N8");
				}

			tbParameterHex.Text = "0x"+Helper.HexString(val);
			tbParameterBin.Text = Convert.ToString(val, 2);

			if (!refresh) intern=false;
			if (intern || aat==null) return;
			aat.Parameter = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU2_TextChanged(object sender, System.EventArgs e)
		{			
			if (intern && !refresh) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU2.Text, aat.Unknown2, 10);

			tbU2Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU2Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU2Hex.Text = "0x"+Helper.HexString(val);
			tbU2Bin.Text = Convert.ToString(val, 2);

			if (!refresh) intern=false;
			if (intern || aat==null) return;
			aat.Unknown2 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU1_TextChanged(object sender, System.EventArgs e)
		{			
			if (intern && !refresh) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU1.Text, aat.Unknown1, 10);

			tbU1Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU1Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU1Hex.Text = "0x"+Helper.HexString(val);
			tbU1Bin.Text = Convert.ToString(val, 2);

			if (!refresh) intern=false;
			if (intern || aat==null) return;
			aat.Unknown1 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbTimeCode_TextChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			aat.TimeCode = Helper.StringToInt16(tbTimeCode.Text, aat.TimeCode, 10);
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void cbEvent_CheckedChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			aat.Linear = cbEvent.Checked;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbParameterFloat_TextChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			intern=true;
			short val = 0;
			if (aat!=null) 
			{
				try 
				{
					if (aat.Parent.Parent!=null) 
					{
						float f = Convert.ToSingle(tbParameterFloat.Text);
						if (aat.Parent.Parent.TransformationType == FrameType.Rotation)
							f = (float)SimPe.Geometry.Quaternion.DegToRad(f);
						val = AnimationFrame.FromCompressedFloat(f, aat.Parent.Parent.TransformationType);						
					}
				} 
				catch {}

				tbParameter.Text = val.ToString();
				tbParameterHex.Text = "0x"+Helper.HexString(val);
				tbParameterBin.Text = Convert.ToString(val, 2);
			}

			intern = false;
			aat.Parameter = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU1Float_TextChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			intern=true;
			short val = 0;
			if (aat!=null) 
			{
				try 
				{
					if (aat.Parent.Parent!=null)
						val = AnimationFrame.FromCompressedFloat(Convert.ToSingle(tbU1Float.Text), aat.Parent.Parent.TransformationType);
				} 
				catch {}

				tbU1.Text = val.ToString();
				tbU1Hex.Text = "0x"+Helper.HexString(val);
				tbU1Bin.Text = Convert.ToString(val, 2);
			}

			intern = false;
			aat.Unknown1 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU2Float_TextChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			intern=true;
			short val = 0;
			if (aat!=null) 
			{
				try 
				{
					if (aat.Parent.Parent!=null)
						val = AnimationFrame.FromCompressedFloat(Convert.ToSingle(tbU2Float.Text), aat.Parent.Parent.TransformationType);
				} 
				catch {}

				tbU2.Text = val.ToString();
				tbU2Hex.Text = "0x"+Helper.HexString(val);
				tbU2Bin.Text = Convert.ToString(val, 2);
			}

			intern = false;
			aat.Unknown2 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbParameterHex_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbParameterHex.Text, aat.Parameter, 16);

			tbParameterFloat.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null) 
				{
					float f = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType);
					if (aat.Parent.Parent.TransformationType== FrameType.Rotation) 
						f = (float)SimPe.Geometry.Quaternion.RadToDeg(f);
					tbParameterFloat.Text = f.ToString("N8");
				}

			tbParameter.Text = val.ToString();
			tbParameterBin.Text = Convert.ToString(val, 2);

			intern=false;
			if (aat==null) return;
			aat.Parameter = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU1Hex_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU1Hex.Text, aat.Unknown1, 16);

			tbU1Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU1Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU1.Text = val.ToString();
			tbU1Bin.Text = Convert.ToString(val, 2);

			intern=false;
			if (aat==null) return;
			aat.Unknown1 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU2Hex_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU2Hex.Text, aat.Unknown2, 16);

			tbU2Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU2Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU2.Text = val.ToString();
			tbU2Bin.Text = Convert.ToString(val, 2);

			intern=false;
			if (aat==null) return;
			aat.Unknown2 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbParameterBin_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbParameterBin.Text, aat.Parameter, 2);

			tbParameterFloat.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null) 
				{
					float f = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType);
					if (aat.Parent.Parent.TransformationType== FrameType.Rotation) 
						f = (float)SimPe.Geometry.Quaternion.RadToDeg(f);
					tbParameterFloat.Text = f.ToString("N8");
				}

			tbParameter.Text = val.ToString();
			tbParameterHex.Text = "0x"+Helper.HexString(val);

			intern=false;
			if (aat==null) return;
			aat.Parameter = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU1Bin_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU1Bin.Text, aat.Unknown1, 2);

			tbU1Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU1Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU1.Text = val.ToString();
			tbU1Hex.Text = "0x"+Helper.HexString(val);

			intern=false;
			if (aat==null) return;
			aat.Unknown1 = val;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void tbU2Bin_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;

			short val = 0;
			if (aat!=null) val = Helper.StringToInt16(tbU2Bin.Text, aat.Unknown2, 2);

			tbU2Float.Text = val.ToString();
			if (aat!=null) 				
				if (aat.Parent.Parent!=null)
					tbU2Float.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

			tbU2.Text = val.ToString();
			tbU2Hex.Text = "0x"+Helper.HexString(val);

			intern=false;
			if (aat==null) return;
			aat.Unknown2 = val;	
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void llDelete_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (aat==null) return;

			aat.Parent.Remove(aat);
			aat = null;
			if (Deleted!=null) Deleted(this, new System.EventArgs());
		}

		private void llAdd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (CreateClicked!=null) CreateClicked(this, new EventArgs());
		}

		private void cbParentLock_CheckedChanged(object sender, System.EventArgs e)
		{
			if (intern || aat==null) return;
			aat.ParentLocked = this.cbParentLock.Checked;
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		#region Events
		public event System.EventHandler Deleted;
		public event System.EventHandler Changed;
		public event System.EventHandler Cleared;		
		public event System.EventHandler CreateClicked;
		#endregion
	}
}
