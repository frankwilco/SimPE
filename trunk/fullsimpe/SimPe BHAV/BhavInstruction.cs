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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für BhavInstruction.
	/// </summary>
	public class BhavInstruction : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel pnExpression;
		private System.Windows.Forms.ComboBox cbtype1;
		private System.Windows.Forms.ComboBox cbtype2;
		private System.Windows.Forms.ComboBox cboperand;
		private System.Windows.Forms.TextBox tbval1;
		private System.Windows.Forms.TextBox tbval2;
		private System.Windows.Forms.ComboBox cbmotiv1;
		private System.Windows.Forms.ComboBox cbmotiv2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BhavInstruction()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			FormLoad();
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
			this.pnExpression = new System.Windows.Forms.Panel();
			this.cboperand = new System.Windows.Forms.ComboBox();
			this.tbval2 = new System.Windows.Forms.TextBox();
			this.cbtype2 = new System.Windows.Forms.ComboBox();
			this.tbval1 = new System.Windows.Forms.TextBox();
			this.cbtype1 = new System.Windows.Forms.ComboBox();
			this.cbmotiv1 = new System.Windows.Forms.ComboBox();
			this.cbmotiv2 = new System.Windows.Forms.ComboBox();
			this.pnExpression.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnExpression
			// 
			this.pnExpression.Controls.Add(this.cbmotiv2);
			this.pnExpression.Controls.Add(this.cbmotiv1);
			this.pnExpression.Controls.Add(this.cboperand);
			this.pnExpression.Controls.Add(this.tbval2);
			this.pnExpression.Controls.Add(this.cbtype2);
			this.pnExpression.Controls.Add(this.tbval1);
			this.pnExpression.Controls.Add(this.cbtype1);
			this.pnExpression.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnExpression.Location = new System.Drawing.Point(8, 8);
			this.pnExpression.Name = "pnExpression";
			this.pnExpression.Size = new System.Drawing.Size(328, 120);
			this.pnExpression.TabIndex = 0;
			// 
			// cboperand
			// 
			this.cboperand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboperand.Location = new System.Drawing.Point(24, 48);
			this.cboperand.Name = "cboperand";
			this.cboperand.Size = new System.Drawing.Size(288, 21);
			this.cboperand.TabIndex = 4;
			// 
			// tbval2
			// 
			this.tbval2.Location = new System.Drawing.Point(192, 80);
			this.tbval2.Name = "tbval2";
			this.tbval2.Size = new System.Drawing.Size(120, 21);
			this.tbval2.TabIndex = 3;
			this.tbval2.Text = "";
			// 
			// cbtype2
			// 
			this.cbtype2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype2.Location = new System.Drawing.Point(16, 80);
			this.cbtype2.Name = "cbtype2";
			this.cbtype2.Size = new System.Drawing.Size(168, 21);
			this.cbtype2.TabIndex = 2;
			this.cbtype2.SelectedIndexChanged += new System.EventHandler(this.SelectVal2Name);
			// 
			// tbval1
			// 
			this.tbval1.Location = new System.Drawing.Point(192, 16);
			this.tbval1.Name = "tbval1";
			this.tbval1.Size = new System.Drawing.Size(120, 21);
			this.tbval1.TabIndex = 1;
			this.tbval1.Text = "";
			// 
			// cbtype1
			// 
			this.cbtype1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype1.Location = new System.Drawing.Point(16, 16);
			this.cbtype1.Name = "cbtype1";
			this.cbtype1.Size = new System.Drawing.Size(168, 21);
			this.cbtype1.TabIndex = 0;
			this.cbtype1.SelectedIndexChanged += new System.EventHandler(this.SelectVal1Name);
			// 
			// cbmotiv1
			// 
			this.cbmotiv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmotiv1.Location = new System.Drawing.Point(192, 16);
			this.cbmotiv1.Name = "cbmotiv1";
			this.cbmotiv1.Size = new System.Drawing.Size(120, 21);
			this.cbmotiv1.TabIndex = 5;
			this.cbmotiv1.Visible = false;
			this.cbmotiv1.SelectedIndexChanged += new System.EventHandler(this.Motive1Changed);
			// 
			// cbmotiv2
			// 
			this.cbmotiv2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmotiv2.Location = new System.Drawing.Point(192, 80);
			this.cbmotiv2.Name = "cbmotiv2";
			this.cbmotiv2.Size = new System.Drawing.Size(120, 21);
			this.cbmotiv2.TabIndex = 6;
			this.cbmotiv2.Visible = false;
			this.cbmotiv2.SelectedIndexChanged += new System.EventHandler(this.Motive2Changed);
			// 
			// BhavInstruction
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(640, 366);
			this.Controls.Add(this.pnExpression);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "BhavInstruction";
			this.Text = "Instruction Container";
			this.pnExpression.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormLoad()
		{
			if (WrapperFactory.Provider==null) return;

			foreach (string s in WrapperFactory.Provider.OpcodeProvider.StoredExpressionOperators) this.cboperand.Items.Add(s);
			foreach (string s in WrapperFactory.Provider.OpcodeProvider.StoredDataNames) 
			{
				this.cbtype1.Items.Add(s);
				this.cbtype2.Items.Add(s);
			}

			foreach (string s in WrapperFactory.Provider.OpcodeProvider.StoredMotives) 
			{
				this.cbmotiv1.Items.Add(s);
			}
		}

		byte[] ops;
		internal void Execute(byte[] ops) 
		{
			byte n1 = ops[0x06];
			byte n2 = ops[0x07];
			byte op = ops[0x05];

			int val1 = (ops[0x01] << 8) | ops[0x00];
			int val2 = (ops[0x03] << 8) | ops[0x02];

			tbval1.Text = "0x"+Helper.HexString((ushort)val1);
			tbval2.Text = "0x"+Helper.HexString((ushort)val2);

			if (cbtype1.Items.Count>n1) cbtype1.SelectedIndex = n1;
			if (cbtype2.Items.Count>n2) cbtype2.SelectedIndex = n2;

			if (cboperand.Items.Count>op) cboperand.SelectedIndex = op;

			this.ops = ops;
		}

		internal byte[] Write()
		{
			try 
			{
				ops[0x06] = (byte)cbtype1.SelectedIndex;
				ops[0x07] = (byte)cbtype2.SelectedIndex;
				ops[0x05] = (byte)cboperand.SelectedIndex;

				cbtype1.SelectedIndex = 0;
				cbtype2.SelectedIndex = 0;

				int val1 = Convert.ToUInt16(tbval1.Text, 16);
				int val2 = Convert.ToUInt16(tbval2.Text, 16);

				ops[0x00] = (byte)(val1 & 0xff);
				ops[0x01] = (byte)((val1 >> 8) & 0xff);

				ops[0x02] = (byte)(val2 & 0xff);
				ops[0x03] = (byte)((val2 >> 8) & 0xff);

				return ops;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
				return null;
			}

			
		}

		private void SelectVal1Name(object sender, System.EventArgs e)
		{
			this.cbmotiv1.Visible = (cbtype1.SelectedIndex==0x0E);
			this.tbval1.Visible = !cbmotiv1.Visible;

			//constant
			if (cbtype1.SelectedIndex==0x1a) 
			{
				if (tbval1.Text.IndexOf(":")==-1) 
				{
					try 
					{
						ushort val = Convert.ToUInt16(tbval1.Text, 16);
						tbval1.Text = "0x"+Helper.HexString(InstructionName.ConstantValueParser(val)[0])+":0x"+Helper.HexString((byte)InstructionName.ConstantValueParser(val)[1]);
					} 
					catch (Exception) {}
				}
			} 
			else if (cbtype1.SelectedIndex==0xe) 
			{
				try 
				{
					ushort val = Convert.ToUInt16(tbval1.Text, 16);
					this.cbmotiv1.SelectedIndex = val;
				} 
				catch (Exception) {}
			}
			else 
			{
				if (tbval1.Text.IndexOf(":")!=-1) 
				{
					string[] s = tbval1.Text.Split(":".ToCharArray(), 2);
					
					try 
					{
						ushort[] b = new ushort[2];
						b[0] = Convert.ToUInt16(s[0], 16);
						b[1] = Convert.ToUInt16(s[1], 16);
						tbval1.Text = "0x"+Helper.HexString(InstructionName.ConstantValueParser(b));

					} 
					catch (Exception) {}
				}
			}
		}

		private void SelectVal2Name(object sender, System.EventArgs e)
		{
			this.cbmotiv2.Visible = (cbtype2.SelectedIndex==0x0E);
			this.tbval2.Visible = !cbmotiv2.Visible;
			//constant
			if (cbtype2.SelectedIndex==0x1a) 
			{
				if (tbval2.Text.IndexOf(":")==-1) 
				{
					try 
					{
						ushort val = Convert.ToUInt16(tbval2.Text, 16);
						tbval2.Text = "0x"+Helper.HexString(InstructionName.ConstantValueParser(val)[0])+":0x"+Helper.HexString((byte)InstructionName.ConstantValueParser(val)[1]);
					} 
					catch (Exception) {}
				}
			}
			else if (cbtype2.SelectedIndex==0xe) 
			{
				try 
				{
					ushort val = Convert.ToUInt16(tbval2.Text, 16);
					this.cbmotiv2.SelectedIndex = val;
				} 
				catch (Exception) {}
			}
			else
			{
				if (tbval2.Text.IndexOf(":")!=-1) 
				{
					string[] s = tbval2.Text.Split(":".ToCharArray(), 2);
					
					try 
					{
						ushort[] b = new ushort[2];
						b[0] = Convert.ToUInt16(s[0], 16);
						b[1] = Convert.ToUInt16(s[1], 16);
						tbval2.Text = "0x"+Helper.HexString(InstructionName.ConstantValueParser(b));

					} 
					catch (Exception) {}
				}
			}
		}

		private void Motive1Changed(object sender, System.EventArgs e)
		{
			tbval1.Text = "0x"+Helper.HexString((ushort)this.cbmotiv1.SelectedIndex);
		}

		private void Motive2Changed(object sender, System.EventArgs e)
		{
			tbval2.Text = "0x"+Helper.HexString((ushort)this.cbmotiv2.SelectedIndex);
		}
	}
}
