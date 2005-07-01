using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// This is a HexEdit Control
	/// </summary>
	public class HexEditControl : UserControl
	{		
		#region Properties
		HexViewControl hvc;
		/// <summary>
		/// Returns the embedded HexViewControl
		/// </summary>
		public HexViewControl Viewer 
		{
			get { return hvc; }
			set 
			{
				if (hvc!=null) 
				{
					hvc.DataChanged -= new EventHandler(hvc_DataChanged);
					hvc.SelectionChanged -= new EventHandler(hvc_DataChanged);
				}

				hvc = value;

				if (hvc!=null) 
				{
					hvc.DataChanged += new EventHandler(hvc_DataChanged);
					hvc.SelectionChanged += new EventHandler(hvc_DataChanged);
				}
			}
		}

		bool vert;
		/// <summary>
		/// Display the Editor for Vertical Alignment
		/// </summary>
		public bool Vertical 
		{
			get {return vert;}
			set {
				if (vert!=value) 
				{
					CeanInterface();
					vert = true;
					BuildInterface();
				}
			}
		}

		HexViewControl.ViewState vs;
		/// <summary>
		/// Returns / sets the current ViewState
		/// </summary>
		public HexViewControl.ViewState View
		{
			get {return vs; }
			set {
				if (vs!=value) 
				{
					vs = value; 
					if (hvc!=null) 
					{
						hvc_DataChanged(hvc, null);
						hvc.View = vs;
					}
				}
			}
		}
		#endregion

		bool edit;
		public HexEditControl()
		{			
			//this.AutoScroll = true;
			vert = false;
			vs = HexViewControl.ViewState.Hex;
			edit = false;
			BuildInterface();
		}
		
		#region GUI	
		TextBox[] boxes;
		Label CreateLabel(int left, ref int top, int width, string text, Control parent)
		{
			Label lb = new Label();
			lb.Parent = parent;
			lb.Width = width;
			lb.Text = text;
			lb.Left = left;
			lb.Top = top;

			lb.TextAlign = ContentAlignment.BottomRight;

			top += lb.Height;
			left += lb.Width;

			return lb;
		}

		TextBox CreateTextBox(int left, int bottom, int width, string text, Control parent)
		{
			TextBox lb = new TextBox();
			lb.Parent = parent;
			lb.Width = width;
			lb.Text = text;
			lb.Left = left;
			lb.Top = bottom - lb.Height;
			lb.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular, Font.Unit);
			
			return lb;
		}

		RadioButton CreateRadioButton(int left, ref int top, int width, string text, Control parent)
		{
			RadioButton lb = new RadioButton();
			lb.Parent = parent;
			lb.Width = width;
			lb.Text = text;
			lb.Left = left;
			lb.Top = top;
			lb.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular, Font.Unit);
			lb.FlatStyle = FlatStyle.System;
			
			top += lb.Height - 4;
			return lb;
		}

		CheckBox CreateCheckBox(int left, ref int top, int width, string text, Control parent)
		{
			CheckBox lb = new CheckBox();
			lb.Parent = parent;
			lb.Width = width;
			lb.Text = text;
			lb.Left = left;
			lb.Top = top;
			lb.Font = new Font(Font.FontFamily, Font.Size, FontStyle.Regular, Font.Unit);
			lb.FlatStyle = FlatStyle.System;
			
			top += lb.Height - 4;
			return lb;
		}


		void CeanInterface()
		{
			foreach (Control c in Controls) c.Dispose();
			this.Controls.Clear();
		}

		void BuildInterface()
		{		
			boxes = new TextBox[11];
			GroupBox mgb = new GroupBox();			
			mgb.Parent = this;
			mgb.Dock = DockStyle.Fill;
			mgb.FlatStyle = FlatStyle.System;
			mgb.Text = "Selected Values:";
			mgb.Font = new Font(mgb.Font.FontFamily, mgb.Font.Size, FontStyle.Bold, mgb.Font.Unit);	
		
			Panel gb = new Panel();
			gb.Parent = mgb;
			gb.Dock = DockStyle.Fill;
			gb.AutoScroll = true;
		

			int top=8;
			int left=8;

			if (vert) 
			{
				Label lb = CreateLabel(left, ref top, 60, "Byte:", gb);
				boxes[0] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 35, "", gb);

				lb = CreateLabel(left, ref top, 60, "Short:", gb);
				boxes[1] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 50, "", gb);
				
				lb = CreateLabel(left, ref top, 60, "Int:", gb);
				boxes[2] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 80, "", gb);

				lb = CreateLabel(left, ref top, 60, "Long:", gb);
				boxes[3] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 135, "", gb);

				lb = CreateLabel(left, ref top, 60, "Single:", gb);
				boxes[4] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 125, "", gb);

				lb = CreateLabel(left, ref top, 60, "Double:", gb);
				boxes[5] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 155, "", gb);

				lb = CreateLabel(left, ref top, 60, "Binary:", gb);
				boxes[6] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 70, "", gb);
				boxes[7] = CreateTextBox(left + lb.Width + 4 + boxes[6].Width + 4, lb.Bottom, boxes[6].Width, "", gb);
				boxes[8] = CreateTextBox(left + lb.Width + 4 + (4 + boxes[6].Width)*2, lb.Bottom, boxes[6].Width, "", gb);
				boxes[9] = CreateTextBox(left + lb.Width + 4 + (4 + boxes[6].Width)*3, lb.Bottom, boxes[6].Width, "", gb);

				/*lb = CreateLabel(left, ref top, 60, "String:", gb);			
				boxes[10] = CreateTextBox(left + lb.Width + 4, lb.Bottom, this.Width- (left + lb.Width + 12), "", gb);
				boxes[10].Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;*/

				//Height = top + 8 + gb.Top;
			} 
			else 
			{
				Label lb = CreateLabel(left, ref top, 60, "Byte:", gb);
				boxes[0] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 35, "0xFF", gb);

				lb = CreateLabel(left, ref top, 60, "Short:", gb);
				boxes[1] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 50, "0xFFFF", gb);

				lb = CreateLabel(left, ref top, 60, "Single:", gb);
				boxes[4] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 125, "", gb);

				lb = CreateLabel(left, ref top, 60, "Binary:", gb);
				boxes[6] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 70, "", gb);
				boxes[7] = CreateTextBox(left + lb.Width + 4 + boxes[6].Width + 4, lb.Bottom, boxes[6].Width, "", gb);
				boxes[8] = CreateTextBox(left + lb.Width + 4 + (4 + boxes[6].Width)*2, lb.Bottom, boxes[6].Width, "", gb);
				boxes[9] = CreateTextBox(left + lb.Width + 4 + (4 + boxes[6].Width)*3, lb.Bottom, boxes[6].Width, "", gb);

				/*lb = CreateLabel(left, ref top, 60, "String:", gb);			
				boxes[10] = CreateTextBox(left + lb.Width + 4, lb.Bottom, this.Width- (left + lb.Width + 12), "", gb);
				boxes[10].Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;*/
				//Height = top + 8 + gb.Top;

				top=8;
				left=210;
				lb = CreateLabel(left, ref top, 60, "Int:", gb);
				boxes[2] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 80, "0xFFFFFFFF", gb);

				lb = CreateLabel(left, ref top, 60, "Long:", gb);
				boxes[3] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 135, "0xFFFFFFFFFFFFFFFF", gb);

				lb = CreateLabel(left, ref top, 60, "Double:", gb);
				boxes[5] = CreateTextBox(left + lb.Width + 4, lb.Bottom, 155, "", gb);
			}

			top = 8;
			RadioButton rb = CreateRadioButton(gb.Width-114, ref top, 110, "Hex", gb);
			rb.Checked = true;
			rb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rb.CheckedChanged += new EventHandler(rbhex_CheckedChanged);

			rb = CreateRadioButton(gb.Width-114, ref top, 110, "signed Dec.", gb);
			rb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rb.CheckedChanged += new EventHandler(rbsdec_CheckedChanged);

			rb = CreateRadioButton(gb.Width-114, ref top, 110, "unsigned Dec.", gb);
			rb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			rb.CheckedChanged += new EventHandler(rbudec_CheckedChanged);

			top += 8;
			CheckBox cb = CreateCheckBox(gb.Width-114, ref top, 110, "Highlight Zeros", gb);
			cb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			cb.CheckedChanged += new EventHandler(cb_CheckedChanged);

			boxes[0].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[0].Leave += new EventHandler(tbbyte_TextLeave);
			boxes[0].KeyUp +=new KeyEventHandler(tbbyte_KeyUp);

			boxes[1].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[1].Leave += new EventHandler(tbshort_TextLeave);
			boxes[1].KeyUp +=new KeyEventHandler(tbshort_KeyUp);

			boxes[2].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[2].Leave += new EventHandler(tbint_TextLeave);
			boxes[2].KeyUp +=new KeyEventHandler(tbint_KeyUp);

			boxes[3].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[3].Leave += new EventHandler(tblong_TextLeave);
			boxes[3].KeyUp +=new KeyEventHandler(tblong_KeyUp);

			boxes[4].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[4].Leave += new EventHandler(tbsingle_TextLeave);
			boxes[4].KeyUp +=new KeyEventHandler(tbsingle_KeyUp);

			boxes[5].TextChanged += new EventHandler(HexEditControl_TextChanged);
			boxes[5].Leave += new EventHandler(tbdouble_TextLeave);
			boxes[5].KeyUp +=new KeyEventHandler(tbdouble_KeyUp);

			for (int i=6; i<10; i++) 
			{
				boxes[i].TextChanged += new EventHandler(HexEditControl_TextChanged);
				boxes[i].Leave += new EventHandler(tbbin_TextLeave);
				boxes[i].KeyUp +=new KeyEventHandler(tbbin_KeyUp);
			}

		}
		#endregion

		internal static string BinaryString(byte val)
		{
			string res = "";
			while (val>0) 
			{
				res = (val%2).ToString()+res;
				val /= 2;
			}
			if (res=="") res = "0";
			return res;
		}

		private void hvc_DataChanged(object sender, EventArgs e)
		{
			if (edit) return;
			if (sender==null) return;

			edit = true;
			HexViewControl hvc = (HexViewControl)sender;
			if (vs==HexViewControl.ViewState.Hex) 
			{
				boxes[0].Text = "0x"+HexViewControl.SetLength(hvc.SelectedByte.ToString("x"), 2, '0');
				boxes[1].Text = "0x"+HexViewControl.SetLength(hvc.SelectedUShort.ToString("x"), 4, '0');
				boxes[2].Text = "0x"+HexViewControl.SetLength(hvc.SelectedUInt.ToString("x"), 8, '0');
				boxes[3].Text = "0x"+HexViewControl.SetLength(hvc.SelectedULong.ToString("x"), 16, '0');
			} 
			else if (vs==HexViewControl.ViewState.UnsignedDec) 
			{
				boxes[0].Text = hvc.SelectedByte.ToString();
				boxes[1].Text = hvc.SelectedUShort.ToString();
				boxes[2].Text = hvc.SelectedUInt.ToString();
				boxes[3].Text = hvc.SelectedULong.ToString();
			} 
			else 
			{
				boxes[0].Text = hvc.SelectedByte.ToString();
				boxes[1].Text = hvc.SelectedShort.ToString();
				boxes[2].Text = hvc.SelectedInt.ToString();
				boxes[3].Text = hvc.SelectedLong.ToString();
			}

			boxes[4].Text = hvc.SelectedFloat.ToString();
			boxes[5].Text = hvc.SelectedDouble.ToString();
			byte[] b = BitConverter.GetBytes(hvc.SelectedUInt);
			boxes[6].Text = HexViewControl.SetLength(BinaryString(b[0]), 8, '0');
			boxes[7].Text = HexViewControl.SetLength(BinaryString(b[1]), 8, '0');
			boxes[8].Text = HexViewControl.SetLength(BinaryString(b[2]), 8, '0');
			boxes[9].Text = HexViewControl.SetLength(BinaryString(b[3]), 8, '0');	
		
			edit = false;
		}

		private void rbhex_CheckedChanged(object sender, EventArgs e)
		{
			View = HexViewControl.ViewState.Hex;
		}

		private void rbsdec_CheckedChanged(object sender, EventArgs e)
		{
			View = HexViewControl.ViewState.SignedDec;
		}

		private void rbudec_CheckedChanged(object sender, EventArgs e)
		{
			View = HexViewControl.ViewState.UnsignedDec;
		}

		private void cb_CheckedChanged(object sender, EventArgs e)
		{
			if (hvc!=null) hvc.HighlightZeor = ((CheckBox)sender).Checked;
		}

		private void HexEditControl_TextChanged(object sender, EventArgs e)
		{
			if (edit) return;
			((TextBox)sender).Tag = true;
		}

		#region Byte
		private void tbbyte_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					if (vs==HexViewControl.ViewState.Hex) hvc.SelectedByte = Convert.ToByte(((TextBox)sender).Text, 16);
					else hvc.SelectedByte = Convert.ToByte(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tbbyte_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbbyte_TextLeave(sender, null);
			}
		}
		#endregion

		#region Short
		private void tbshort_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					if (vs==HexViewControl.ViewState.Hex) hvc.SelectedUShort = Convert.ToUInt16(((TextBox)sender).Text, 16);
					else if (vs==HexViewControl.ViewState.UnsignedDec) hvc.SelectedUShort = Convert.ToUInt16(((TextBox)sender).Text);
					else hvc.SelectedShort = Convert.ToInt16(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tbshort_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbshort_TextLeave(sender, null);
			}
		}
		#endregion

		#region Int
		private void tbint_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					if (vs==HexViewControl.ViewState.Hex) hvc.SelectedUInt = Convert.ToUInt32(((TextBox)sender).Text, 16);
					else if (vs==HexViewControl.ViewState.UnsignedDec) hvc.SelectedUInt = Convert.ToUInt32(((TextBox)sender).Text);
					else hvc.SelectedInt = Convert.ToInt32(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tbint_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbint_TextLeave(sender, null);
			}
		}
		#endregion

		#region Long
		private void tblong_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					if (vs==HexViewControl.ViewState.Hex) hvc.SelectedULong = Convert.ToUInt64(((TextBox)sender).Text, 16);
					else if (vs==HexViewControl.ViewState.UnsignedDec) hvc.SelectedULong = Convert.ToUInt64(((TextBox)sender).Text);
					else hvc.SelectedLong = Convert.ToInt64(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tblong_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tblong_TextLeave(sender, null);
			}
		}
		#endregion

		#region Single
		private void tbsingle_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					hvc.SelectedFloat = Convert.ToSingle(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tbsingle_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbsingle_TextLeave(sender, null);
			}
		}
		#endregion

		#region Double
		private void tbdouble_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					hvc.SelectedDouble = Convert.ToDouble(((TextBox)sender).Text);
				}
			} 
			catch {}
		}

		private void tbdouble_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbdouble_TextLeave(sender, null);
			}
		}
		#endregion

		#region Binary
		private void tbbin_TextLeave(object sender, EventArgs e)
		{
			if  (((TextBox)sender).Tag == null) return;
			try 
			{
				if (hvc!=null) 
				{
					byte[] b = new byte[4];
					b[0] = Convert.ToByte(boxes[6].Text, 2);
					b[1] = Convert.ToByte(boxes[7].Text, 2);
					b[2] = Convert.ToByte(boxes[8].Text, 2);
					b[3] = Convert.ToByte(boxes[9].Text, 2);
					
					hvc.SelectedUInt = BitConverter.ToUInt32(b, 0);
				}
			} 
			catch {}
		}

		private void tbbin_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) 
			{
				((TextBox)sender).Tag = true;
				tbbin_TextLeave(sender, null);
			}
		}
		#endregion
		
	}
}
