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
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "TimeCode:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Parameter:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 56);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Unknown 1:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(0, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Unknown 2:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbEvent
			// 
			this.cbEvent.Location = new System.Drawing.Point(144, 0);
			this.cbEvent.Name = "cbEvent";
			this.cbEvent.Size = new System.Drawing.Size(64, 24);
			this.cbEvent.TabIndex = 4;
			this.cbEvent.Text = "Flagged";
			this.cbEvent.CheckedChanged += new System.EventHandler(this.cbEvent_CheckedChanged);
			// 
			// tbTimeCode
			// 
			this.tbTimeCode.Location = new System.Drawing.Point(72, 0);
			this.tbTimeCode.Name = "tbTimeCode";
			this.tbTimeCode.Size = new System.Drawing.Size(56, 20);
			this.tbTimeCode.TabIndex = 5;
			this.tbTimeCode.Text = "";
			this.tbTimeCode.TextChanged += new System.EventHandler(this.tbTimeCode_TextChanged);
			// 
			// tbParameter
			// 
			this.tbParameter.Location = new System.Drawing.Point(72, 32);
			this.tbParameter.Name = "tbParameter";
			this.tbParameter.Size = new System.Drawing.Size(56, 20);
			this.tbParameter.TabIndex = 6;
			this.tbParameter.Text = "66666";
			this.tbParameter.TextChanged += new System.EventHandler(this.tbParameter_TextChanged);
			// 
			// tbU1
			// 
			this.tbU1.Location = new System.Drawing.Point(72, 56);
			this.tbU1.Name = "tbU1";
			this.tbU1.Size = new System.Drawing.Size(56, 20);
			this.tbU1.TabIndex = 8;
			this.tbU1.Text = "66666";
			this.tbU1.TextChanged += new System.EventHandler(this.tbU1_TextChanged);
			// 
			// tbU2
			// 
			this.tbU2.Location = new System.Drawing.Point(72, 80);
			this.tbU2.Name = "tbU2";
			this.tbU2.Size = new System.Drawing.Size(56, 20);
			this.tbU2.TabIndex = 10;
			this.tbU2.Text = "66666";
			this.tbU2.TextChanged += new System.EventHandler(this.tbU2_TextChanged);
			// 
			// tbU2Float
			// 
			this.tbU2Float.Location = new System.Drawing.Point(144, 80);
			this.tbU2Float.Name = "tbU2Float";
			this.tbU2Float.Size = new System.Drawing.Size(96, 20);
			this.tbU2Float.TabIndex = 13;
			this.tbU2Float.Text = "0.0000";
			this.tbU2Float.TextChanged += new System.EventHandler(this.tbU2Float_TextChanged);
			// 
			// tbU1Float
			// 
			this.tbU1Float.Location = new System.Drawing.Point(144, 56);
			this.tbU1Float.Name = "tbU1Float";
			this.tbU1Float.Size = new System.Drawing.Size(96, 20);
			this.tbU1Float.TabIndex = 12;
			this.tbU1Float.Text = "0.0000";
			this.tbU1Float.TextChanged += new System.EventHandler(this.tbU1Float_TextChanged);
			// 
			// tbParameterFloat
			// 
			this.tbParameterFloat.Location = new System.Drawing.Point(144, 32);
			this.tbParameterFloat.Name = "tbParameterFloat";
			this.tbParameterFloat.Size = new System.Drawing.Size(96, 20);
			this.tbParameterFloat.TabIndex = 11;
			this.tbParameterFloat.Text = "0.0000";
			this.tbParameterFloat.TextChanged += new System.EventHandler(this.tbParameterFloat_TextChanged);
			// 
			// tbU2Hex
			// 
			this.tbU2Hex.Location = new System.Drawing.Point(256, 80);
			this.tbU2Hex.Name = "tbU2Hex";
			this.tbU2Hex.Size = new System.Drawing.Size(56, 20);
			this.tbU2Hex.TabIndex = 16;
			this.tbU2Hex.Text = "0x0000";
			this.tbU2Hex.TextChanged += new System.EventHandler(this.tbU2Hex_TextChanged);
			// 
			// tbU1Hex
			// 
			this.tbU1Hex.Location = new System.Drawing.Point(256, 56);
			this.tbU1Hex.Name = "tbU1Hex";
			this.tbU1Hex.Size = new System.Drawing.Size(56, 20);
			this.tbU1Hex.TabIndex = 15;
			this.tbU1Hex.Text = "0x0000";
			this.tbU1Hex.TextChanged += new System.EventHandler(this.tbU1Hex_TextChanged);
			// 
			// tbParameterHex
			// 
			this.tbParameterHex.Location = new System.Drawing.Point(256, 32);
			this.tbParameterHex.Name = "tbParameterHex";
			this.tbParameterHex.Size = new System.Drawing.Size(56, 20);
			this.tbParameterHex.TabIndex = 14;
			this.tbParameterHex.Text = "0x0000";
			this.tbParameterHex.TextChanged += new System.EventHandler(this.tbParameterHex_TextChanged);
			// 
			// tbU2Bin
			// 
			this.tbU2Bin.Location = new System.Drawing.Point(328, 80);
			this.tbU2Bin.Name = "tbU2Bin";
			this.tbU2Bin.Size = new System.Drawing.Size(112, 20);
			this.tbU2Bin.TabIndex = 19;
			this.tbU2Bin.Text = "0000000000000000";
			// 
			// tbU1Bin
			// 
			this.tbU1Bin.Location = new System.Drawing.Point(328, 56);
			this.tbU1Bin.Name = "tbU1Bin";
			this.tbU1Bin.Size = new System.Drawing.Size(112, 20);
			this.tbU1Bin.TabIndex = 18;
			this.tbU1Bin.Text = "0000000000000000";
			// 
			// tbParameterBin
			// 
			this.tbParameterBin.Location = new System.Drawing.Point(328, 32);
			this.tbParameterBin.Name = "tbParameterBin";
			this.tbParameterBin.Size = new System.Drawing.Size(112, 20);
			this.tbParameterBin.TabIndex = 17;
			this.tbParameterBin.Text = "0000000000000000";
			this.tbParameterBin.TextChanged += new System.EventHandler(this.tbParameterBin_TextChanged);
			// 
			// llDelete
			// 
			this.llDelete.Location = new System.Drawing.Point(392, 0);
			this.llDelete.Name = "llDelete";
			this.llDelete.Size = new System.Drawing.Size(48, 23);
			this.llDelete.TabIndex = 20;
			this.llDelete.TabStop = true;
			this.llDelete.Text = "Delete";
			this.llDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llDelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llDelete_LinkClicked);
			// 
			// llAdd
			// 
			this.llAdd.Location = new System.Drawing.Point(312, 0);
			this.llAdd.Name = "llAdd";
			this.llAdd.Size = new System.Drawing.Size(72, 23);
			this.llAdd.TabIndex = 21;
			this.llAdd.TabStop = true;
			this.llAdd.Text = "Create";
			this.llAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
			// 
			// cbParentLock
			// 
			this.cbParentLock.Location = new System.Drawing.Point(216, 0);
			this.cbParentLock.Name = "cbParentLock";
			this.cbParentLock.Size = new System.Drawing.Size(96, 24);
			this.cbParentLock.TabIndex = 22;
			this.cbParentLock.Text = "Parent locked";
			this.cbParentLock.CheckedChanged += new System.EventHandler(this.cbParentLock_CheckedChanged);
			// 
			// AnimAxisTransformControl
			// 
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
			this.Name = "AnimAxisTransformControl";
			this.Size = new System.Drawing.Size(448, 104);
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

				cbEvent.Checked = aat.Flag;
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
					tbParameterFloat.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

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
			aat.Flag = cbEvent.Checked;
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
						val = AnimationFrame.FromCompressedFloat(Convert.ToSingle(tbParameterFloat.Text), aat.Parent.Parent.TransformationType);
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
					tbParameterFloat.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

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
					tbParameterFloat.Text = AnimationFrame.GetCompressedFloat(val, aat.Parent.Parent.TransformationType).ToString("N8");

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
