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
using System.Windows.Forms;
using SourceGrid2;

namespace Ambertation.Editors
{
	/// <summary>
	/// Positions a Hexeditro Component within a Panel
	/// </summary>
	public class HexEditor
	{
		/// <summary>
		/// The Grid Control
		/// </summary>
		private Grid hexgrid;
		/// <summary>
		/// The Rich Text Control
		/// </summary>
		private RichTextBox rtb;
		/// <summary>
		/// Stores the AutoScroll Location of the Panel
		/// </summary>
		private Point pt;
		
		/// <summary>
		/// Number of (Data)Columns Per Row
		/// </summary>
		private int columns;
		/// <summary>
		/// Current Offset within the File
		/// </summary>
		private int offset;
		/// <summary>
		/// Maximum size that can be Handled by the System
		/// </summary>
		private uint maxsize = 0x0800;

		/// <summary>
		/// true, if the Selection change was triggert by a SelectionChange Event
		/// </summary>
		/// <remarks>
		/// This is used to prevent Endless loops when changing the Selection in the 
		/// Text Box, which will change the Selection in the Grid, which wil fire the 
		/// SelectionChangedEvent of the Grid, that would change the Selection of the 
		/// Textbox again...
		/// </remarks>
		private bool autochange;
		/// <summary>
		/// Turns off the synchonised Selection update;
		/// </summary>
		private bool updateoff;
		/// <summary>
		/// if true, a value of 0 wont't be displayed in the grid
		/// </summary>
		private bool hide_00;

		/// <summary>
		/// stores the Data
		/// </summary>
		private byte[] data;

		/// <summary>
		/// Fills the given Panel with the HexEditro Controls
		/// </summary>
		/// <param name="panel">The Panel that should contain the HexEditor</param>
		/// <param name="data">The Binary Data displayed in the Editor</param>
		/// <param name="columns">Number of Columns per row</param>
		public HexEditor(Panel panel, Byte[] data, int columns)
		{
			
			hide_00 = false;
			updateoff = true;
			panel.AutoScroll = true;

			this.columns = columns;
			Font font = new Font("Courier New", 9);

			//Add a Pint Handler to the Panle
			pt = new Point(0, 0);
			panel.Paint += new PaintEventHandler(this.Paint);

			hexgrid = new SourceGrid2.Grid();
			hexgrid.Parent = panel;
			hexgrid.Location = new Point(0, 0);
			hexgrid.AutoSizeMinWidth = 5;
			hexgrid.BackColor = System.Drawing.SystemColors.AppWorkspace;
			
			
			hexgrid.BorderStyle = BorderStyle.None;
			hexgrid.ColumnsCount = columns+1;
			hexgrid.FixedRows = 1;
			hexgrid.FixedColumns = 1;

			hexgrid.Selection.CellGotFocus += new CellGotFocusEventHandler(CellGotFocusEventHandler);
			hexgrid.Selection.SelectionMode = GridSelectionMode.Cell;
			hexgrid.Selection.EnableMultiSelection = false;
			hexgrid.Selection.BorderMode = SelectionBorderMode.Selection;

			rtb = new RichTextBox();
			rtb.Parent = panel;			
			rtb.BorderStyle = BorderStyle.None;			
			rtb.Font = font;
			rtb.HideSelection = false;
			rtb.ReadOnly = true;
			rtb.SelectionChanged += new EventHandler(SelectionChanged);
			rtb.Anchor = (AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right);
			
			
			updateoff = false;
			Data = data;
			
		}

		/// <summary>
		/// Changes the Database displayed by the System
		/// </summary>
		public Byte[] Data
		{
			set
			{
				this.data = value;
				updateoff = true;
				offset = 0;
				hexgrid.Height = 10;
				rtb.Height = 10;
				hexgrid.Parent.Visible = false;
				FillGrid(value);

				rtb.Location = new Point(hexgrid.Location.X + hexgrid.Width + 2, hexgrid.Rows[0].Height);
				rtb.Height = hexgrid.Height - hexgrid.Rows[0].Height;
				rtb.Width = Math.Max(hexgrid.Parent.ClientRectangle.Width - (hexgrid.Location.X + hexgrid.Width + 4), columns*8); 
				FillText(value);
				hexgrid.Parent.Visible = true;
				updateoff = false;
			}
		}


		

		#region Selection handlers
		/// <summary>
		/// Used to store the last AutoScroll Position
		/// </summary>
		/// <param name="sender">The sending Panel</param>
		/// <param name="e">The Arguments</param>
		private void Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//Load Parent Panel
			Panel p = (Panel)sender;

			//store old scrollbar Position
			//if (p.AutoScrollPosition.Y>=0) 
			{
				pt = p.AutoScrollPosition;
			}
		}

		/// <summary>
		/// EventHandler for a Selection Change in The TextBox
		/// </summary>
		/// <param name="sender">The Sending RichTextBox</param>
		/// <param name="e">Parameters</param>
		protected void SelectionChanged(object sender, EventArgs e)
		{
			if (updateoff) return;

			int col = rtb.SelectionStart % (columns+1) ;
			int row = (rtb.SelectionStart - col) / (columns+1) ;
			offset = (col) + ((row) * (columns));

			GoTo(offset);
		}
		#endregion

		/// <summary>
		/// EventHandler for a Selection Change in the Grid
		/// </summary>
		/// <param name="sender">Sennding Object (the Cell)</param>
		/// <param name="e">Parameters</param>
		protected void CellGotFocusEventHandler(object sender, CellGotFocusEventArgs e)
		{			
			if (updateoff) return;
			offset = (e.Position.Column-1) + ((e.Position.Row-1) * (columns));
			GoTo(offset);
		}

		/// <summary>
		/// Fills the Grid with Binary Data
		/// </summary>
		/// <param name="data">The data to fill into the Grid</param>
		/// <remarks>The Grid will be cleard before the fill</remarks>
		protected void FillGrid(Byte[] data)
		{
			hexgrid.RowsCount = 0;
			hexgrid.Rows.Insert(0);
			hexgrid[0,0] = new SourceGrid2.Cells.Real.Cell("");
			hexgrid[0,0].VisualModel = new SourceGrid2.VisualModels.FlatHeader(true);
			hexgrid[0,0].Grid.BorderStyle = BorderStyle.None;
			
			
			for (int i=1; i<hexgrid.ColumnsCount; i++) 
			{
				hexgrid[0,i] = new SourceGrid2.Cells.Real.Header(MinLen((i-1).ToString("X"), 2, '0'));
				hexgrid[0,i].VisualModel = new SourceGrid2.VisualModels.FlatHeader(true);
				hexgrid[0,i].Grid.BorderStyle = BorderStyle.None;
			}
			
			uint ct=0;
			int row = 0;
			if (data!=null)
			{
				while (ct<Math.Min(MaxSize, data.Length)) 
				{
					int col = (int)(ct%(hexgrid.ColumnsCount-1));
					if (col==0) 
					{
						row ++;
						hexgrid.Rows.Insert(row);
						hexgrid[row, 0] = new SourceGrid2.Cells.Real.Header("0x"+MinLen(ct.ToString("X").ToString(), 8, '0'));
						hexgrid[row, 0].VisualModel = new SourceGrid2.VisualModels.FlatHeader(true);
						hexgrid[row, 0].Grid.BorderStyle = BorderStyle.None;
					}
					if ((data[ct]==0) && (hide_00)) 
					{
						hexgrid[row, col+1] = new SourceGrid2.Cells.Real.Cell("");
					} 
					else 
					{
						hexgrid[row, col+1] = new SourceGrid2.Cells.Real.Cell(MinLen(data[ct].ToString("X"), 2, '0'));
					}
					hexgrid[row, col+1].Grid.BorderStyle = BorderStyle.None;
					ct++;
				} //while
			}

			hexgrid.AutoStretchColumnsToFitWidth = false;
			hexgrid.AutoSize();

			hexgrid.Width = 0;
			for (int i=0; i<hexgrid.ColumnsCount; i++) 
			{
				hexgrid.Columns[i].Width -= 10;
				if (((i%4)==0) && (i!=0)) hexgrid.Columns[i].Width += 10;
				hexgrid.Width += hexgrid.Columns[i].Width;				
			}
			
			hexgrid.Height = 0;
			for (int i=0; i<hexgrid.RowsCount; i++) 
			{
				hexgrid.Rows[i].Height = 15;
				hexgrid.Height += hexgrid.Rows[i].Height;
			}
		}

		/// <summary>
		/// Fills the TextBox with the Binary Data
		/// </summary>
		/// <param name="data">The data to fill into the Grid</param>
		/// <remarks>The TextBox will be cleard before the fill</remarks>
		protected void FillText(Byte[] data)
		{
			rtb.Text = "";
			const string lbr = "\n";
			
			uint ct=0;
			if (data!=null)
			{
				while (ct<Math.Min(MaxSize, data.Length)) 
				{
					int col = (int)(ct%(columns));
					if ((col==0) && (ct!=0))
					{
						rtb.Text += lbr;
					}

					char c = (char)data[ct];

					if ((c>0x1F) && (c<0xff) && (c!=0xAD) && ((c<0x7F) || (c>0x9F))) rtb.Text += c.ToString();
					else rtb.Text += ".";
					ct++;
				}//while
			}
		}

				/// <summary>
		/// Reads or Sets the 0 Behaviour of the grid;
		/// </summary>
		public bool HideZeros
		{
			get 
			{
				return hide_00;
			}
			set 
			{
				hide_00 = value;
			}
		}

		/// <summary>
		/// Reads or Sets the Maximum Number Of Characters to Display
		/// </summary>
		public uint MaxSize 
		{
			get 
			{
				return maxsize;
			}
			set
			{
				maxsize = value;
			}
		}

		/// <summary>
		/// Selects the Bayte on the given offset
		/// </summary>
		/// <param name="offset">The offset within the File</param>
		protected void GoTo(int offset)
		{
			if (this.autochange) return;

			this.offset = offset;
			int col = offset % (columns) ;
			int row = (offset - col) / (columns) ;

			if (row+1 >= hexgrid.RowsCount) return;
			if (col+1 >= hexgrid.ColumnsCount) return;

			//Load Parent Panel
			Panel p = (Panel)hexgrid.Parent;

			//calculate Position of the Selection
			p.AutoScrollPosition = pt;
			

			//Set The Selection within the Grid
			this.autochange = true;
			hexgrid.Selection.Clear();
			hexgrid.Selection.Add(new Position(row+1, col+1));			

			//get the offset within the RichTextBox
			offset = (col) + ((row) * (columns+1));
			rtb.SelectionStart = offset;
			rtb.SelectionLength = 1;
			
			//calculate Position of the Selection			
			int top = 0;
			for (int i=0; i<Math.Min(row+1, hexgrid.RowsCount); i++) 
				top += hexgrid.Rows[i].Height;

			//only move if the new Position is not within visible Range
			if ( ((p.AutoScrollPosition.Y + p.ClientRectangle.Height) < -top) || (p.AutoScrollPosition.Y> -top) )
			{
				p.AutoScrollPosition = new Point(0, top);
				pt = p.AutoScrollPosition;
			}
			this.autochange = false;			

			//call event Handler if available
			if (this.OnSelectionChange!=null) 
			{				
				OnSelectionChange(this, new EventArgs());
			}			
		}

		/// <summary>
		/// Reads or Changes the current Offset
		/// </summary>
		public int Offset
		{
			get 
			{
				return offset;
			}
			set 
			{
				GoTo(value);
			}
		}

		/// <summary>
		/// Returns the current selection as Byte Value
		/// </summary>
		public byte ByteValue 
		{
			get 
			{
				if (data==null) return 0;
				if ((offset>=0) && (offset<data.Length)) return data[offset];
				else return 0;
			}
		}

		/// <summary>
		/// Returns the current selection as Byte Value
		/// </summary>
		public ushort ShortValue 
		{
			get 
			{
				if (data==null) return 0;
				if ((offset>=0) && (offset+1<data.Length)) 
				{
					return (ushort)((data[offset+1] << 8) + data[offset]);
				}
				else return 0;
			}
		}

		/// <summary>
		/// Returns the current selection as Byte Value
		/// </summary>
		public uint IntValue 
		{
			get 
			{
				if (data==null) return 0;
				if ((offset>=0) && (offset+3<data.Length)) 
				{
					return (uint)(((((data[offset+3] << 8) + data[offset+2]) << 8) + data[offset+1]) << 8) + data[offset];
				}
				else return 0;
			}
		}

		#region Events
		/// <summary>
		/// Called whan the Selection changed
		/// </summary>
		public EventHandler OnSelectionChange = null;
		#endregion

		/// <summary>
		/// Adds fill Characcters to the String until it has at least the passed length
		/// </summary>
		/// <param name="s">The SOurce String</param>
		/// <param name="len">Wanted Length</param>
		/// <param name="fill">Fill Character</param>
		/// <returns>A String that is at least len Charcters long</returns>
		/// <remarks>The String will be filled from the Front (number fill, right aligned)</remarks>
		protected static string MinLen(string s, uint len, char fill)
		{
			while (s.Length<len) s = fill.ToString() + s;

			return s;
		}
	}
}
