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
			if (!lk) return true;
			e = FixMouseEventArgs(e);
			

			down = true;
			
			SetMousePos(e.X, e.Y);

			return true;
		}

		internal bool OnMouseUp(MouseEventArgs e)
		{
			if (!this.BoundingRectangle.Contains(e.X, e.Y) && !down) return false;
			e = FixMouseEventArgs(e);			
			down = false;	
			return true;
		}		

		internal bool OnMouseMove(MouseEventArgs e)
		{				
			if (!this.BoundingRectangle.Contains(e.X, e.Y) && !down) return false;
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
