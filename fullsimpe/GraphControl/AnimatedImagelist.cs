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
using Ambertation.Collections;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// A Control that allows you to display the content of an Image List animated
	/// </summary>
	[Designer(typeof(AnimationDesigner)), ToolboxBitmapAttribute(typeof(ImageList))]
	public class AnimatedImagelist : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnimatedImagelist()
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

			index = 0;
			BackColor = Color.Transparent;
			timer = new Timer();
			timer.Enabled = false;

			timer.Tick += new EventHandler(timer_Tick);

			list = new Images();
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

		#region Properties
		Timer timer;
		public Timer Timer
		{
			get { return timer; }
		}
		#endregion
		#region public Properties		

		int index;
		public int CurrentIndex 
		{
			get {return index;}
			set 
			{
				if (index!=value) 
				{					
					index = Math.Min(list.Count-1, value);					
					index = Math.Max(0, value);
					this.Invalidate();
				}
			}
		}

		Images list;
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public Images Images
		{
			get { return list; }
			set { list = value; }
		}
		#endregion

		#region Event override
		protected override void OnPaint(PaintEventArgs e)
		{
			e.Graphics.FillRectangle(new SolidBrush(this.BackColor), e.ClipRectangle);
			
			//alist.Draw(e.Graphics, 0, 0, index);
			if (index>=0 && index<list.Count) 
				e.Graphics.DrawImage(
					Ambertation.Drawing.GraphicRoutines.ScaleImage(list[index], this.Width, this.Height, true),
					e.ClipRectangle,
					e.ClipRectangle,
					GraphicsUnit.Pixel
					);
			
		}

		#endregion

		[Browsable(false)]
		public bool Running
		{
			get { return timer.Enabled; }
		}

		public void Start()
		{
			timer.Enabled = true;
		}

		public void Pause()
		{
			timer.Enabled = false;
		}

		public void Stop()
		{
			Pause();
			index = 0;			
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		private void timer_Tick(object sender, EventArgs e)
		{
			if (index<0) index = 0;
			else if (index >=list.Count-1) index = 0;
			else index++;
			
			Refresh();
			Application.DoEvents();
		}
	}
}
