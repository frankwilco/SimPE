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

namespace SimPe.Events 
{
	/// <summary>
	/// This Event is called, when the Theme should be changed
	/// </summary>
	public delegate void ChangedThemeEvent(GuiTheme gt);
}

namespace SimPe
{
	/// <summary>
	/// Available Themes
	/// </summary>
	public enum GuiTheme : byte 
	{
		/// <summary>
		/// Classic Flat Win2K/Office 2002 Look
		/// </summary>
		Everett = 0,
		/// <summary>
		/// New Office 2003 Look
		/// </summary>
		Office2003 = 1,
		/// <summary>
		/// New look introduced by VS 2005
		/// </summary>
		Whidbey = 2,
        /// <summary>
        /// Glossy looking controls
        /// </summary>
        Glossy = 3
	}

	/// <summary>
	/// Classes used to manage the Theme of our GUI
	/// </summary>
	public class ThemeManager : System.IDisposable
	{
		#region Fields, Properties, Constructors
		GuiTheme ctheme;
		System.Collections.ArrayList ctrls;

		public GuiTheme CurrentTheme
		{
			get { return ctheme; }
			set { 
				if (ctheme!=value) 
				{
					ctheme = value; 
					SetTheme();
					if (ChangedTheme!=null) ChangedTheme(value);
				}
			}
		}

		Color clight, c, cdark;
        System.Windows.Forms.ToolStripRenderer whidbey;
        System.Windows.Forms.ToolStripRenderer whidbeysquare;
        System.Windows.Forms.ToolStripRenderer square;
        MediaPlayerRenderer mediaplayer;
        MediaPlayerRenderer mediaplayerwhidbey;
        ToolStripColorTable colortable;
        MediaPlayerToolStripColorTable mpcolortable;

        Ambertation.Renderer.GlossyRenderer glossy;
        Ambertation.Renderer.GlossyRenderer glossysquare;
		public ThemeManager(GuiTheme t) 
		{
            colortable = new ToolStripColorTable();
            mpcolortable = new MediaPlayerToolStripColorTable();

            mediaplayer = new MediaPlayerRenderer();
            mediaplayerwhidbey = new MediaPlayerRenderer(mpcolortable);
            whidbey = new Ambertation.Renderer.AdvancedToolStripProfessionalRenderer(colortable);
            whidbeysquare = new ToolStripProfessionalSquareRenderer(colortable);
            square = new ToolStripProfessionalSquareRenderer();

            glossysquare = new Ambertation.Renderer.GlossyRenderer();
            glossy = new Ambertation.Renderer.GlossyRenderer();
            glossy.RenderRoundedEdges = true;

			ctheme = t;
			parent = null;
			ctrls = new System.Collections.ArrayList();

            Ambertation.Windows.Forms.WhidbeyColorTable rend = new Ambertation.Windows.Forms.WhidbeyColorTable();
            
			clight = rend.DockButtonHighlightBackgroundBottom;
            c = Ambertation.Drawing.GraphicRoutines.InterpolateColors(rend.DockButtonBackgroundBottom, rend.DockBorderColor, 0.5f); ;
            cdark = rend.DockBorderColor;
		}

		~ThemeManager()
		{
			try 
			{
				this.Dispose();
			} 
			catch {}
		}
	
		/// <summary>
		/// Creates a Child Theme Manager and returns it
		/// </summary>
		/// <returns></returns>
		public ThemeManager CreateChild()
		{
			ThemeManager tm = new ThemeManager(this.ctheme);
			tm.Parent = this;
			return tm;
		}
		#endregion

		#region Apply Themes
        void SetTheme(System.Windows.Forms.ToolStrip sdm)
        {
            if (sdm.Parent is System.Windows.Forms.ToolStripContainer)
            {
                if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
                else if (ctheme == GuiTheme.Office2003) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
                else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
                else sdm.Renderer = whidbey;
            }
            else
            {
                if (sdm.Renderer is MediaPlayerRenderer)
                {
                    if (ctheme == GuiTheme.Everett) sdm.Renderer = mediaplayerwhidbey;
                    else if (ctheme == GuiTheme.Office2003) sdm.Renderer = mediaplayer;
                    else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
                    else sdm.Renderer = mediaplayerwhidbey;
                }
                else if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
                else if (ctheme == GuiTheme.Office2003) sdm.Renderer = square;
                else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossysquare;
                else sdm.Renderer = whidbeysquare;
            }
        }

        void SetTheme(Ambertation.Windows.Forms.DockManager mng)
        {
            if (ctheme == GuiTheme.Everett) mng.Renderer = new Ambertation.Windows.Forms.ClassicRenderer();
            else if (ctheme == GuiTheme.Glossy) mng.Renderer = new Ambertation.Windows.Forms.GlossyRenderer();
            else mng.Renderer = new Ambertation.Windows.Forms.WhidbeyRenderer();
        }

        void SetTheme(System.Windows.Forms.ToolStripContainer sdm)
        {
            SetTheme(sdm.TopToolStripPanel);
            SetTheme(sdm.RightToolStripPanel);
            SetTheme(sdm.BottomToolStripPanel);
            SetTheme(sdm.LeftToolStripPanel);
        }

        void SetTheme(System.Windows.Forms.ToolStripPanel sdm)
        {
            if (sdm.Parent is System.Windows.Forms.ToolStripContainer)
            {
                if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
                else if (ctheme == GuiTheme.Office2003) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
                else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
                else sdm.Renderer = whidbey;
            }
            else
            {
                if (sdm.Renderer is MediaPlayerRenderer)
                {
                    if (ctheme == GuiTheme.Everett) sdm.Renderer = mediaplayerwhidbey;
                    else if (ctheme == GuiTheme.Office2003) sdm.Renderer = mediaplayer;
                    else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
                    else sdm.Renderer = mediaplayerwhidbey;
                }
                else if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
                else if (ctheme == GuiTheme.Office2003) sdm.Renderer = square;
                else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossysquare;
                else sdm.Renderer = whidbeysquare;
            }
        }

        void SetTheme(System.Windows.Forms.MenuStrip sdm)
        {
            if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            else if (ctheme == GuiTheme.Office2003) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
            else sdm.Renderer = whidbey;            
        }

        void SetTheme(System.Windows.Forms.ContextMenuStrip sdm)
        {
            if (ctheme == GuiTheme.Everett) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            else if (ctheme == GuiTheme.Office2003) sdm.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            else if (ctheme == GuiTheme.Glossy) sdm.Renderer = glossy;
            else sdm.Renderer = whidbey;
        }

		void SetTheme(TD.SandDock.SandDockManager sdm) 
		{
			if (ctheme == GuiTheme.Everett) sdm.Renderer = new TD.SandDock.Rendering.EverettRenderer();
			else if (ctheme == GuiTheme.Office2003) sdm.Renderer = new TD.SandDock.Rendering.Office2003Renderer();            
			else sdm.Renderer = new TD.SandDock.Rendering.WhidbeyRenderer();
		}

		void SetTheme(Ambertation.Windows.Forms.XPTaskBoxSimple sdm) 
		{
			sdm.LeftHeaderColor = this.ThemeColor;
			sdm.RightHeaderColor = this.ThemeColorDark;
			sdm.BodyColor = this.ThemeColorLight;
		}

		

		

		void SetTheme(System.Windows.Forms.Splitter tb) 
		{			
			tb.BackColor = ThemeColorDark;
		}

		void SetTheme(System.Windows.Forms.Control c) 
		{
			c.BackColor = ThemeColorLight;
		}

		void SetTheme(SteepValley.Windows.Forms.XPGradientPanel gp) 
		{
			gp.StartColor = ThemeColorLight;
			gp.EndColor = ThemeColor;
		}

		void SetTheme(SimPe.Windows.Forms.WrapperBaseControl gp) 
		{
			gp.BackColor = ThemeColorLight;
			gp.GradientColor = ThemeColor;
		}

		/// <summary>
		/// Apply a Theme to the passed object
		/// </summary>
		/// <param name="o"></param>
		public void Theme(object o) 
		{
            if (o is TD.SandDock.SandDockManager) SetTheme((TD.SandDock.SandDockManager)o);
            else if (o is Ambertation.Windows.Forms.DockManager) SetTheme((Ambertation.Windows.Forms.DockManager)o);
            else if (o is SteepValley.Windows.Forms.XPGradientPanel) SetTheme((SteepValley.Windows.Forms.XPGradientPanel)o);
            else if (o is SimPe.Windows.Forms.WrapperBaseControl) SetTheme((SimPe.Windows.Forms.WrapperBaseControl)o);
            else if (o is System.Windows.Forms.Splitter) SetTheme((System.Windows.Forms.Splitter)o);
            else if (o is Ambertation.Windows.Forms.XPTaskBoxSimple) SetTheme((Ambertation.Windows.Forms.XPTaskBoxSimple)o);
            else if (o is System.Windows.Forms.ContextMenuStrip) SetTheme((System.Windows.Forms.ContextMenuStrip)o);
            else if (o is System.Windows.Forms.MenuStrip) SetTheme((System.Windows.Forms.MenuStrip)o);
            else if (o is System.Windows.Forms.ToolStrip) SetTheme((System.Windows.Forms.ToolStrip)o);
            else if (o is System.Windows.Forms.ToolStripContainer) SetTheme((System.Windows.Forms.ToolStripContainer)o);
            else if (o is System.Windows.Forms.Control) SetTheme((System.Windows.Forms.Control)o);			
		}
		#endregion

		#region Default Colors
		public Color ThemeColor
		{
			get 
			{
				if (ctheme == GuiTheme.Office2003) return SystemColors.InactiveCaption;
				else if (ctheme == GuiTheme.Everett) return SystemColors.ControlDark;
                else if (ctheme == GuiTheme.Glossy) return Color.FromArgb(0xAD, 0xBC, 0xCE);
				else return c;
			}
		}

		public Color ThemeColorLight
		{
			get 
			{
                if (ctheme == GuiTheme.Office2003) return SystemColors.InactiveCaptionText;
                else if (ctheme == GuiTheme.Everett) return SystemColors.ControlLight;
                else if (ctheme == GuiTheme.Glossy) return Color.FromArgb(0xDB, 0xE4, 0xEE);
                else return clight;
			}
		}

		public Color ThemeColorDark
		{
			get 
			{
				if (ctheme == GuiTheme.Office2003) return SystemColors.Highlight;
				else if (ctheme == GuiTheme.Everett) return SystemColors.ControlDarkDark;
                else if (ctheme == GuiTheme.Glossy) return Color.FromArgb(0x75, 0x84, 0x97);
				else return cdark;
			}
		}
		#endregion

		#region Manage
		public void AddControl(object o) 
		{
			if (!ctrls.Contains(o)) 
			{
				ctrls.Add(o);
				Theme(o);
			}
		}

		public void Clear()
		{
			ctrls.Clear();
		}

		public void RemoveControl(object o) 
		{
			ctrls.Remove(o);
		}

		public void SetTheme()
		{

			foreach (object o in ctrls) Theme(o);
		}
		#endregion

		#region Events
		protected event SimPe.Events.ChangedThemeEvent ChangedTheme;

		/// <summary>
		/// Called when the Theme in the parent was changed
		/// </summary>
		/// <param name="t"></param>
		void ThemeWasChanged(GuiTheme t) 
		{
			this.CurrentTheme = t;
		}

		ThemeManager parent;
		/// <summary>
		/// Set the Parent Theme Manager
		/// </summary>
		public ThemeManager Parent 
		{
			get { return parent; }
			set 
			{
				if (parent!=null) parent.ChangedTheme -= new SimPe.Events.ChangedThemeEvent(ThemeWasChanged);
				parent = value;
				if (parent!=null) parent.ChangedTheme += new SimPe.Events.ChangedThemeEvent(ThemeWasChanged);
			}
		}

		
		#endregion

		static ThemeManager tm;
		/// <summary>
		/// Returns the Main ThemeManager
		/// </summary>
		public static ThemeManager Global 
		{
			get 
			{ 
				if (tm==null) tm = new ThemeManager((GuiTheme)Helper.WindowsRegistry.Layout.SelectedTheme);
				return tm;
			}
		}
		#region IDisposable Member

		public void Dispose()
		{
			this.Parent = null;
			this.Clear();
		}

		#endregion
	}
}
