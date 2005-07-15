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

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This is a Dragable Panel
	/// </summary>
	public abstract class DragPanel : GraphPanelElement
	{

		public DragPanel()
		{
			fnt = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			//SetStyle(ControlStyles.Selectable, true);
			down = false;
			lk = true;
			focused = false;
		}		

		#region Properties
		bool down;
		/// <summary>
		/// True, if the Mouse is currently down
		/// </summary>
		[Browsable( false )]
		public bool Down
		{
			get {return down; }
		}

		bool focused;
		public bool Focused 
		{
			get { return focused; }
		}

		bool lk;
		public bool Movable
		{
			get { return lk; }
			set { 
				if (lk!=value) 
				{
					lk = value;  
					this.Invalidate();
				}
			}
		}

		Font fnt;
		public Font Font
		{
			get { return fnt; }
			set 
			{ 
				if (fnt!=value) 
				{
					fnt = value;  
					this.Invalidate();
				}
			}
		}
		#endregion


		Point lastpos;
		void SetMousePos(int x, int y)
		{
			lastpos = new Point(x, y);
		}
		
		#region Event Override
		protected MouseEventArgs FixMouseEventArgs(MouseEventArgs e)
		{
			return new MouseEventArgs(e.Button, e.Clicks, e.X-Left, e.Y-Top, e.Delta);
		}

		internal bool OnMouseDown(MouseEventArgs e)
		{			
			

			if (!this.BoundingRectangle.Contains(e.X, e.Y)) return false;
			if (e.Clicks==1 && this.Click!=null) Click(this, new System.EventArgs());
			else if (e.Clicks==2 && this.DoubleClick!=null) 
			{
				DoubleClick(this, new System.EventArgs());
				return true;
			}
			else if (MouseDown!=null) MouseDown(this, FixMouseEventArgs(e));
			if (!lk) return true;
			e = FixMouseEventArgs(e);
			

			if (e.Button==MouseButtons.Left) 
			{
				down = true;			
				SetMousePos(e.X, e.Y);
			}

			
			return true;
		}

		internal bool OnMouseUp(MouseEventArgs e)
		{
			if (!this.BoundingRectangle.Contains(e.X, e.Y) && !down) return false;
			if (MouseUp!=null) MouseUp(this, FixMouseEventArgs(e));
			e = FixMouseEventArgs(e);			
			down = false;
			
			return true;
		}		

		internal bool OnMouseMove(MouseEventArgs e)
		{				
			if (!this.BoundingRectangle.Contains(e.X, e.Y) && !down) return false;
			
			if (MouseMove!=null) MouseMove(this, FixMouseEventArgs(e));
			if (!lk) return true;
			if (!down) return true;			
			e = FixMouseEventArgs(e);
			

			Point delta = new Point(Left + e.X -lastpos.X , Top+e.Y-lastpos.Y);			

			this.SetBounds(delta.X, delta.Y, Width, Height);			
			return true;
		}		

		internal override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus(e);
			down = false;
		}

		internal override void OnGotFocus(EventArgs e)
		{
			base.OnGotFocus(e);
			this.SendToFront();
		}

		#endregion

		#region Events
		public event System.Windows.Forms.MouseEventHandler MouseMove;
		public event System.Windows.Forms.MouseEventHandler MouseUp;
		public event System.Windows.Forms.MouseEventHandler MouseDown;
		public event System.EventHandler DoubleClick;
		public event System.EventHandler Click;
		#endregion

		internal void SetFocus(bool val)
		{
			if (focused!=val)
			{
				this.focused = val;				
				if (focused) 
					this.OnGotFocus(new System.EventArgs());
				else 
					this.OnLostFocus(new System.EventArgs());
			}
		}

		internal override void ChangedParent()
		{
			base.ChangedParent ();
			if (Parent!=null) this.Movable = !Parent.LockItems;
		}

	}
}
