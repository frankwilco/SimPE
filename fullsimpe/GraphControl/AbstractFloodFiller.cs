//**********************************************
// Project: Flood Fill Algorithms in C# & GDI+
// File Description: Flood Fill Class
//
// Copyright: Copyright 2003 by Justin Dunlap.
//    Any code herein can be used freely in your own 
//    applications, provided that:
//     * You agree that I am NOT to be held liable for
//       any damages caused by this code or its use.
//     * You give proper credit to me if you re-publish
//       this code.
//**********************************************
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Collections;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Ambertation.Drawing {
	using System;
	
	public enum FloodFillStyle
	{
		Linear,
		Queue,
		Recursive
	};

	/// <summary>
	/// TODO - Add class summary
	/// </summary>
	/// <remarks>
	/// 	created by - J Dunlap
	/// 	created on - 7/2/2003 11:44:33 PM
	/// </remarks>
	public abstract class AbstractFloodFiller : object {
		

		/*[DllImport("winmm.dll")]
		protected static extern int timeGetTime();*/

		//private members with public accessors

		protected Color m_fillcolorcolor=Color.Green;
		protected byte[] m_Tolerance=new byte[]{11,11,11};
		protected int m_TimeBenchmark=0;
		protected FloodFillStyle m_FillStyle=FloodFillStyle.Linear;
		protected bool m_FillDiagonal=false;
		protected Bitmap m_Bmp=null;
		protected Point m_Pt=new Point();
		
		//private members
		protected bool[,] PixelsChecked;		
		protected Queue CheckQueue=new Queue();
		
		
		/// <summary>
		/// Default constructor - initializes all fields to default values
		/// </summary>
		public AbstractFloodFiller() {
		}
		
		
		public Color FillColor
		{
			get
			{
				return m_fillcolorcolor;
			}
			set
			{
				m_fillcolorcolor=value;
			}
		}
		
		public byte[] Tolerance
		{
			get
			{
				return m_Tolerance;
			}
			set
			{
				m_Tolerance=value;
			}
		}
		
		public int TimeBenchmark
		{
			get
			{
				return m_TimeBenchmark;
			}
		}
		
		public bool FillDiagonal
		{
			get
			{
				return m_FillDiagonal;
			}
			set
			{
				m_FillDiagonal=value;
			}
		}
		
		public FloodFillStyle FillStyle
		{
			get
			{
				return m_FillStyle;
			}
			set
			{
				m_FillStyle=value;
			}
		}
		
		public Bitmap Bmp
		{
			get
			{
				return m_Bmp;
			}
			set
			{
				m_Bmp=value;
			}
		}
		
		public Point Pt
		{
			get
			{
				return m_Pt;
			}
			set
			{
				m_Pt=value;
			}
		}		
		
		
		public void FloodFill()
		{
			Exception ex=null;
			
			try
			{
				FloodFill(m_Bmp,m_Pt);
			}catch(Exception e){
				ex=e;
				OnFillFinished(new FillFinishedEventArgs(ex));
				return;
				
			}
			OnFillFinished(new FillFinishedEventArgs(ex));
		}
		
		//initializes the FloodFill operation
		public abstract void FloodFill(Bitmap bmp, Point pt);
		
		
		//**************
		//COLOR HELPER FUNCTIONS
		//**************
		public static byte GetR(int ARGB)
		{
			return LoByte((byte)LoWord(ARGB));
			
		}
		
		public static byte GetG(int ARGB)
		{
			return HiByte((short)LoWord(ARGB));
			
		}
		
		public static byte GetB(int ARGB)
		{
			return LoByte((byte)HiWord(ARGB));
			
		}
		
		public static byte GetA(int ARGB)
		{
			return HiByte((byte)HiWord(ARGB));
			
		}

		public static int RGBA(byte R, byte G, byte B, byte A)
		{
			return (int)(R+(G<<8)+(B<<16)+(A<<24));
		}

		public static int RGB(byte R, byte G, byte B)
		{
			return (int)(R+(G<<8)+(B<<16));
		}
		
		public static int BGRA(byte B, byte G, byte R, byte A)
		{
			return (int)(B+(G<<8)+(R<<16)+(A<<24));
		}
		
		public static short LoWord(int n)
		{
			return (short)(n & 0xffff);
		}

		public static short HiWord(int n)
		{
			return (short)((n >> 16) & 0xffff);
		}
		
		public static byte LoByte(short n)
		{
			return (byte)(n & 0xff);
		}

		public static byte HiByte(short n)
		{
			return (byte)((n >> 8) & 0xff);
		}
		
		
		//EVENTS/EVENT RAISERS
		//-------------
		
		//raised when a fill operation is finished
		public event FillFinishedEventHandler FillFinished;
		protected void OnFillFinished(FillFinishedEventArgs args)
		{
			if(FillFinished!=null)
				FillFinished.BeginInvoke(this,args,null,null);
		}
		
	}

	public delegate void FillFinishedEventHandler(object sender, FillFinishedEventArgs e);
	public class FillFinishedEventArgs : EventArgs
	{
		Exception m_exception=null;
		
		public FillFinishedEventArgs(Exception e)
		{
			m_exception=e;
		}
		
		public Exception exception
		{
			get
			{
				return m_exception;
			}
		}
	}

}
