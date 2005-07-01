using System;
using System.Windows.Forms;
using System.Drawing;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// This is a HexView Control
	/// </summary>
	public class HexViewControl : UserControl
	{
		/// <summary>
		/// Determins the ViewState of teh Control
		/// </summary>
		public enum ViewState
		{
			Hex,
			SignedDec,
			UnsignedDec
		}

		#region Constants
		/// <summary>
		/// The Size of a HexBlock (number of Columsn per Block)
		/// </summary>
		const int BLOCKSIZE = 8;
		/// <summary>
		/// Spacing between two HexBlocks
		/// </summary>
		const int BLOCKSPACING = 4;
		/// <summary>
		/// Spacing between two Columns
		/// </summary>
		const int COLSPACING = 1; 
		/// <summary>
		/// Spacing between the diffrent Windows
		/// </summary>
		const int WINDOWSPACING = 4;
		#endregion

		#region public Properties
		ViewState vs;
		/// <summary>
		/// Returns / sets the current ViewState
		/// </summary>
		public ViewState View
		{
			get {return vs; }
			set 
			{
				if (vs!=value) 
				{
					vs = value; 
					RedrawGraphics();
					Refresh();
				}
			}
		}

		bool hs;
		/// <summary>
		/// true, if you want to Highlight Zero Values
		/// </summary>
		public bool HighlightZeor 
		{
			get {return hs; }
			set 
			{
				if (hs!=value) 
				{
					hs = value; 
					RedrawGraphics();
					Refresh();
				}
			}
		}

		public override Font Font
		{
			get { return base.Font;	}
			set
			{
				base.Font = value;
				UpdateCharWidth();
			}
		}

		Image[] border;
		int offsetboxwidth;		
		/// <summary>
		/// The Width of the Offset Listing Box
		/// </summary>
		public int OffsetBoxWidth 
		{
			get { return offsetboxwidth; }
			set { 
				offsetboxwidth = Math.Abs(value); 
				Refresh();
			}
		}

		int charboxwidth;		
		/// <summary>
		/// The Width of the Character Listing Box
		/// </summary>
		public int CharBoxWidth 
		{
			get { return charboxwidth; }
			set { 
				charboxwidth = Math.Abs(value); 
				Refresh();
			}
		}
					

		Color fcfcol;
		/// <summary>
		/// Returns the BorderColor
		/// </summary>
		public Color FocusedForeColor
		{
			get { return fcfcol; }
			set { fcfcol = value; }
		}

		Color hcol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public Color HeadColor
		{
			get {return hcol;}
			set { hcol = value; }
		}

		Color hfcol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public Color HeadForeColor
		{
			get {return hfcol;}
			set { hfcol = value; }
		}

		Color hlcol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public Color HighlightColor
		{
			get {return hlcol;}
			set { hlcol = value; }
		}

		Color fccol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public Color ZeroCellColor
		{
			get {return fccol;}
			set { fccol = value; }
		}

		Color hlfcol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public Color HighlightForeColor
		{
			get {return hlfcol;}
			set { hlfcol = value; }
		}

		Color backcol;
		/// <summary>
		/// Save and set the Background Color
		/// </summary>
		public override Color BackColor
		{
			get {return backcol;}
			set { backcol = value; }
		}


		byte cols;
		/// <summary>
		/// Number of 8-Column Blocks to display
		/// </summary>
		public byte Blocks 
		{
			get {return cols;}
			set {cols = value; }
		}

		Font hfont;
		/// <summary>
		/// Returns the Font used for the Header
		/// </summary>
		public Font HeaderFont
		{
			get { return hfont; }
		}

		
		#endregion

		#region Properties
		Rectangle bm;
		/// <summary>
		/// Returns the Margin between the Content and the Border of a Box
		/// </summary>
		protected Rectangle BoxMargin 
		{
			get { return bm; }
			set { bm = value; }
		}

		byte[] data;
		/// <summary>
		/// The Content that should be displayed
		/// </summary>
		public byte[] Data 
		{
			get { return data; }
			set { 
				data = value; 
				if (data==null) data = new byte[0];
				UpdateRows();
				crow = 0;

				BeginUpdate();
				this.Select(-1, 0);
				this.Refresh();
				EndUpdate();

				if (DataChanged!=null) DataChanged(this, new EventArgs());
			}
		}

		/// <summary>
		/// Number of Columsn per Line
		/// </summary>
		public int Columns 
		{
			get { return cols * BLOCKSIZE; }
		}

		/// <summary>
		/// Returns a Brush in BackgroundColor
		/// </summary>
		protected SolidBrush BackBrush
		{
			get { return new SolidBrush(backcol); }
		}

		/// <summary>
		/// Returns a Brush in BackgroundColor
		/// </summary>
		protected SolidBrush HeadBackBrush
		{
			get { return new SolidBrush(HeadColor); }
		}

		/// <summary>
		/// Returns a Brush in ForeColor
		/// </summary>
		protected SolidBrush ForeBrush
		{
			get { return new SolidBrush(ForeColor); }
		}

		/// <summary>
		/// Returns a Brush in BackgroundColor
		/// </summary>
		protected SolidBrush HeadForeBrush
		{
			get { return new SolidBrush(HeadForeColor); }
		}

		/// <summary>
		/// Returns the Pen for the Background Color
		/// </summary>
		protected Pen BorderPen
		{
			get { return new Pen(fcfcol, 1); }
		}

		/// <summary>
		/// The Width of the Hex Listing Box, which is calculated by <see cref="Width"/> - (<see cref="OffsetBoxWidth"/> + <see cref="CharBoxWidth"/> + 8)
		/// </summary>
		protected float HexBoxWidth 
		{
			get { 
				float w = (float)(Width - (OffsetBoxWidth + CharBoxWidth + 2*WINDOWSPACING + 1)); 
				if (sb!=null) if (sb.Visible) w -= sb.Width + WINDOWSPACING;
				return w;
			}
		}

		/// <summary>
		/// Width of a single Column in the HexBox
		/// </summary>
		protected float HexBoxColumnWidth 
		{
			get { return (float)(HexBoxWidth - bm.Width - ((Columns-1) * COLSPACING) - bm.Left - ((Blocks-1)*BLOCKSPACING)) / (float)Columns; }
		}
			
		/// <summary>
		/// Number of Rows needed to display the Data
		/// </summary>
		public int Rows 
		{
			get { return Data.Length / Columns + 1; }
		}

		int crow;
		/// <summary>
		/// Sets / Returns the current Row
		/// </summary>
		public int CurrentRow
		{
			get { return crow; }
			set 
			{ 
				int v = Math.Max(0, Math.Min(value, Rows-1));				
				if (v!=crow) 
				{
					MoveRows(v-crow);
					crow = v;
					Refresh();
				}
			}
		}

		float hbrh;
		/// <summary>
		/// Returns the Height of one Row
		/// </summary>
		protected float HexBoxRowHeight
		{
			get { return hbrh; }
		}

		int selstart;
		/// <summary>
		/// Where does sthe selection start (-1 for nothing)
		/// </summary>
		public int SelectionStart 
		{
			get { return selstart; }
		}

		int sellen;
		/// <summary>
		/// How long is the Selection
		/// </summary>
		public int SelectionLength 
		{
			get { return sellen; }			
		}

		/// <summary>
		/// Where does the Selection End
		/// </summary>
		public int SelectionEnd 
		{
			get {return selstart + sellen -1;}
		}

		float cwidth;
		/// <summary>
		/// Returns the width of one Character in the CHarBox
		/// </summary>
		protected float CharWidth
		{
			get {return cwidth;}
		}
		
		#endregion

		#region Fields
		System.Windows.Forms.ScrollBar sb;
		#endregion

		#region Events
		/// <summary>
		/// Fires, when the USers Scrolls
		/// </summary>
		public event ScrollEventHandler Scroll;

		/// <summary>
		/// Fires, whenever the Selection get's changed
		/// </summary>
		public event System.EventHandler SelectionChanged;

		/// <summary>
		/// Fires, whenever the Data get's changed
		/// </summary>
		public event System.EventHandler DataChanged;
		#endregion

		#region Calulated Measurement
		/// <summary>
		/// Height of a single Column in the HexBox
		/// </summary>
		protected float UpdateHexBoxRowHeight()
		{
			SizeF layoutSize = new SizeF(HexBoxColumnWidth, 5000.0F);
			Graphics g = Graphics.FromHwnd(this.Handle);
			SizeF stringSize = g.MeasureString("0", Font, layoutSize);

			hbrh = stringSize.Height;
			return stringSize.Height;
		}

		/// <summary>
		/// Width of a Single Character
		/// </summary>
		protected float UpdateCharWidth()
		{
			cwidth = GetTextWidth("W", Font);
			return cwidth;
		}

		/// <summary>
		/// Width of a Text
		/// </summary>
		protected float GetTextWidth(string s, Font f)
		{
			SizeF layoutSize = new SizeF(HexBoxColumnWidth, 5000.0F);
			Graphics g = Graphics.FromHwnd(this.Handle);
			SizeF stringSize = g.MeasureString(s, f, layoutSize);
			
			return stringSize.Width;
		}

		/// <summary>
		/// Set the OffsetBox and Character Box to the size defined by the current Font
		/// </summary>
		public void MatchSize()
		{
	
			this.offsetboxwidth = (int)Math.Ceiling(GetTextWidth("00000000", HeaderFont)) + bm.Left + bm.Width;
			this.charboxwidth = Columns*((int)CharWidth + COLSPACING) + bm.Left + bm.Width;
		}

		/// <summary>
		/// Returns the Number of Rows that can be displayed on one Page
		/// </summary>
		/// <returns></returns>
		protected float GetHexBoxRowsPerPage()
		{
			int h = Height - (1 + bm.Top + bm.Height ) - (int)HexBoxRowHeight;
			return (float)((float)h / Math.Ceiling(HexBoxRowHeight + COLSPACING) +1);
		}

		/// <summary>
		/// Returns the Number of Pages needed to display the Data
		/// </summary>
		/// <returns></returns>
		protected int GetNumberOfPages()
		{
			return (int)Math.Max(0, Rows - (int)Math.Floor(GetHexBoxRowsPerPage())) +1 ;
		}

		/// <summary>
		/// Returns the Top Location of the given Row
		/// </summary>
		/// <param name="index"></param>
		protected int GetVisibleRowTop(int index)
		{
			index++;
			return (int)(index * (HexBoxRowHeight + COLSPACING) + bm.Top);
		}

		/// <summary>
		/// Returns the Left Location of the given Columns
		/// </summary>
		/// <param name="index"></param>
		protected int GetHexColLeft(int index)
		{
			return this.OffsetBoxWidth + WINDOWSPACING + (int)(index * (this.HexBoxColumnWidth + COLSPACING) + bm.Left) + (index / BLOCKSIZE) * BLOCKSPACING; 
		}
		
		/// <summary>
		/// Returns the Left Location of the given Columns
		/// </summary>
		/// <param name="index"></param>
		protected int GetCharColLeft(int index)
		{
			return this.OffsetBoxWidth + (int)this.HexBoxWidth + 2*WINDOWSPACING + (int)(index * ((int)this.CharWidth + COLSPACING) + bm.Left); 
		}
		
		#endregion

		/// <summary>
		/// Create a new Instance
		/// </summary>
		public HexViewControl()
		{
			vs = ViewState.Hex;
			offsetboxwidth = 100;
			charboxwidth = 200;
			cols = 2;

			Font = new Font("Courier New", 10, Font.Style, Font.Unit);
			hfont = new Font(Font.FontFamily, Font.Size, FontStyle.Bold, Font.Unit);

			backcol = SystemColors.ControlLightLight;
			fcfcol = Color.FromArgb(0x60, SystemColors.WindowFrame);
			hcol = SystemColors.InactiveCaption;
			hfcol = SystemColors.InactiveCaptionText;
			hlcol = SystemColors.Highlight;
			hlfcol = SystemColors.HighlightText;
			fccol = Color.FromArgb(0x30, Color.Red);

			data = new byte[0];

			selstart = -1;
			sellen = 0;

			bm = new Rectangle(6, 6, 6, 6);

			#region Add ScrollBar
			sb = new VScrollBar();
			sb.Parent = this;
			sb.Dock = DockStyle.Right;
			sb.Minimum = 0;
			sb.Maximum = Math.Max(0, (int)this.GetNumberOfPages()-1);
			sb.Visible = (sb.Minimum != sb.Maximum);
			sb.Scroll += new ScrollEventHandler(sb_Scroll);
			#endregion


			border = new Image[8];
			border[0] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.tl.png"));
			border[1] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.t.png"));
			border[2] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.tr.png"));
			border[3] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.r.png"));
			border[4] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.br.png"));
			border[5] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.b.png"));
			border[6] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.bl.png"));
			border[7] = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("Ambertation.Windows.Forms.l.png"));

			MatchSize();
			RedrawGraphics();
		}

		bool pause;
		bool refresh;
		/// <summary>
		/// No Refresh Evenst will be prcessed until you call <see cref="EndUpdate"/>
		/// </summary>
		public void BeginUpdate()
		{
			refresh = false;
			
			pause = true;
		}

		/// <summary>
		/// Refresh Events will be process again, if ther were Refresh Events 
		/// since the last call to <see cref="BeginUpdate"/>, Refresh will be called once
		/// </summary>
		public void EndUpdate()
		{
			pause = false;
			if (refresh) Refresh();			
			
		}

		/// <summary>
		/// Select the passed Range
		/// </summary>
		/// <param name="selstart">Start offset (or -1 for nothing)</param>
		/// <param name="sellen">Length of the Selection</param>
		public void Select(int selstart, int sellen)
		{			
			int olds = SelectionStart;
			int olde = SelectionEnd;
			this.sellen = Math.Min(data.Length-1-selstart, sellen);
			this.selstart = Math.Min(data.Length-1, selstart);
				
			UpdateSelectedRows(olds, olde);
			Refresh();	
			
			if (SelectionChanged!=null) SelectionChanged(this, new System.EventArgs());
		}

		/// <summary>
		/// Front fills the String
		/// </summary>
		/// <param name="s"></param>
		/// <param name="len"></param>
		/// <param name="fill"></param>
		/// <returns></returns>
		internal static string SetLength(string s, int len, char fill)
		{
			if (s.Length>len) return s.Substring(s.Length-len, len);
			while (s.Length<len) s = fill+s;
			return s;
		}

		#region Event Overrides
		protected override void OnResize(EventArgs e)
		{			
			base.OnResize(e);			
			RedrawGraphics();
			base.Refresh();			
		}

		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
			
		}


		protected override void OnPaint(PaintEventArgs e) 
		{
			e.Graphics.DrawImageUnscaled(cachedimage, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width+1, e.ClipRectangle.Height+1);			
		}

		public override void Refresh()
		{
			if (pause) 
			{
				refresh = true;
				return;
			}

			bool olvis = sb.Visible;
			sb.Maximum = Math.Max(0, (int)this.GetNumberOfPages()-1);
			sb.LargeChange = (int)this.GetHexBoxRowsPerPage();//sb.Maximum / 20;
			sb.Maximum += sb.LargeChange-1;
			sb.Visible = (sb.Minimum != sb.Maximum);

			if (olvis!=sb.Visible) this.RedrawGraphics();
			else UpdateGraphics();			

			base.Refresh ();
		}

		bool down;
		protected override void OnMouseDown(MouseEventArgs e)
		{
			Point acell = GetLocation(e.X, e.Y);			
			this.Select(GetOffset(acell), 1);
			down = true;
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (down) 
			{
				Point acell = GetLocation(e.X, e.Y);
				int of = GetOffset(acell);
				if (of==-1) 
				{
					Select(0, -1);
				}
				else if (of < this.SelectionStart) 
				{
					int len = this.SelectionStart - of;										
					Select(of, len+1);
				} 
				else 
				{
					this.Select(this.SelectionStart,of - this.SelectionStart+1);
				}
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			down = false;
		}

		private void sb_Scroll(object sender, ScrollEventArgs e)
		{
			
			CurrentRow = e.NewValue;
			//this.Refresh();			
			if (Scroll!=null) Scroll(this, e);
		}

		#endregion

		#region Manage Drawing
		
		Bitmap cachedimage;
		Bitmap[] rowimage;

		protected void SetGraphicsMode(Graphics g)
		{
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
			g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
		}

		protected void RedrawGraphics()
		{
			if (Width==0) return;
			if (Height==0) return;
			UpdateHexBoxRowHeight();
			UpdateRows();							
			if (cachedimage!=null) cachedimage.Dispose();			

			cachedimage = new Bitmap(Width, Height);
			Graphics g = Graphics.FromImage(cachedimage);
			SetGraphicsMode(g);			
			g.FillRectangle(new SolidBrush(base.BackColor), 0, 0, Width, Height);

			UpdateGraphics(g);
			g.Dispose();
		}

		protected void UpdateGraphics()
		{
			Graphics g = Graphics.FromImage(cachedimage);
			SetGraphicsMode(g);
			UpdateGraphics(g);
			g.Dispose();
		}

		protected void UpdateGraphics(Graphics g)
		{								
			PaintOffsetBox(g);
			PaintHexBox(g);
			PaintRows(g);
		}

		Point GetLocation(int x, int y)
		{
			x -= this.OffsetBoxWidth + WINDOWSPACING;
			y -= (int)this.HexBoxRowHeight;
			y -= bm.Top;
			y = (int)Math.Floor( y / (this.HexBoxRowHeight+COLSPACING));

			if (x<=this.HexBoxWidth) 
			{				
				x -= bm.Left;
				x = (int)Math.Floor(x / (this.HexBoxColumnWidth+COLSPACING));
				
			} 
			else 
			{
				x -= (int)this.HexBoxWidth + WINDOWSPACING;
				x -= bm.Left;
				x = (int)Math.Floor(x / (this.CharWidth));				
			}

			return new Point(Math.Max(0, Math.Min(x, Columns-1)), this.CurrentRow+y);
		}

		int GetOffset(Point p)
		{
			return p.X + p.Y*Columns;
		}
		/// <summary>
		/// Make sure selecte Rows are displayed correct
		/// </summary>
		protected void UpdateSelectedRows()
		{
			int offset = (this.CurrentRow) * Columns;

			if (offset>this.SelectionEnd) return;
			if (offset + this.GetHexBoxRowsPerPage()*Columns < this.SelectionStart) return;

			int delta = this.SelectionStart-offset;
			int first = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			delta = this.SelectionEnd-offset;
			int last = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			for (int i=first; i<=last; i++) 
				this.PaintRow(rowimage[i], i);	
		}

		/// <summary>
		/// Make sure selecte Rows are displayed correct
		/// </summary>
		protected void UpdateSelectedRows(int olds, int olde)
		{
			int offset = (this.CurrentRow) * Columns;

			if (offset>this.SelectionEnd) return;
			if (offset + this.GetHexBoxRowsPerPage()*Columns < this.SelectionStart) return;

			int delta = this.SelectionStart-offset;
			int first = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			delta = this.SelectionEnd-offset;
			int last = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			delta = olds-offset;
			int ofirst = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			delta = olde-offset;
			int olast = Math.Min(rowimage.Length-1, Math.Max(0, delta / Columns));

			if (olast<first || ofirst>last) 
			{
				for (int i=ofirst; i<=olast; i++) 
					this.PaintRow(rowimage[i], i);	
				for (int i=first; i<=last; i++) 
					this.PaintRow(rowimage[i], i);											
			} 
			else 
			{
				if (olds!=this.SelectionStart) 
				{
					int mfirst = Math.Min(ofirst, first);
					int mlast = Math.Max(ofirst, first);
					for (int i=mfirst; i<=mlast; i++) 
						this.PaintRow(rowimage[i], i);
				}

				if (olde!=this.SelectionEnd) 
				{
					int mfirst = Math.Min(olast, last);
					int mlast = Math.Max(olast, last);
					for (int i=mfirst; i<=mlast; i++) 
						this.PaintRow(rowimage[i], i);
				}
			}
			
		}

		/// <summary>
		/// Move the rows by the given Delta
		/// </summary>
		/// <param name="delta"></param>
		protected void MoveRows(int delta)
		{
			if (delta==0) return ;
			if (Math.Abs(delta)>=rowimage.Length) 
			{
				UpdateRows();
				return;
			}

			int start = 0;
			int end = rowimage.Length;			

			int go = start-delta;
			

			if (delta>0) 
			{
				for (int i=start; i<end; i++) 
				{
					go = i-delta;
				
					if (go>=0 && go<rowimage.Length) rowimage[go] = rowimage[i];				
				}
				for (int i=go+1; i<end; i++) 
				{
					rowimage[i] = new Bitmap(Width, (int)this.HexBoxRowHeight+COLSPACING);
					PaintRow(rowimage[i], i+delta);
				}
			} 
			else 
			{
				for (int i=end-1; i>=start; i--) 
				{
					go = i-delta;
				
					if (go>=0 && go<rowimage.Length) rowimage[go] = rowimage[i];				
				}
				for (int i=go-1; i>=0; i--) 
				{
					rowimage[i] = new Bitmap(Width, (int)this.HexBoxRowHeight+COLSPACING);
					PaintRow(rowimage[i], i+delta);
				}
			}
		}

		protected void UpdateRows()
		{
			if (rowimage!=null) foreach (Bitmap b in rowimage) b.Dispose();
			rowimage = new Bitmap[(int)this.GetHexBoxRowsPerPage()+2];
			for (int i=0; i<rowimage.Length; i++) 
			{
				rowimage[i] = new Bitmap(Width, (int)this.HexBoxRowHeight+COLSPACING);			
				PaintRow(rowimage[i], i);
			}
		}

		#endregion		

		#region Additional Painting Functions
		protected void DrawImageH(Graphics g, Image i, Rectangle dest, Rectangle src)
		{
			Rectangle rec = new Rectangle(dest.Left, dest.Top, src.Width, src.Height);

			while (rec.Left+src.Width<=dest.Right) 
			{
				g.DrawImage(i, rec, src, GraphicsUnit.Pixel);
				rec = new Rectangle(rec.Right, rec.Top, rec.Width, rec.Height);
			}

			rec = new Rectangle(rec.Left, rec.Top, dest.Left+dest.Width-rec.Left, rec.Height);
			g.DrawImage(i, rec, src, GraphicsUnit.Pixel);
		}

		protected void DrawImageV(Graphics g, Image i, Rectangle dest, Rectangle src)
		{
			Rectangle rec = new Rectangle(dest.Left, dest.Top, src.Width, src.Height);

			while (rec.Top+src.Height<=dest.Bottom) 
			{
				g.DrawImage(i, rec, src, GraphicsUnit.Pixel);
				rec = new Rectangle(rec.Left, rec.Bottom, rec.Width, rec.Height);
			}

			rec = new Rectangle(rec.Left, rec.Top, rec.Width, dest.Top+dest.Height-rec.Top);
			g.DrawImage(i, rec, src, GraphicsUnit.Pixel);
		}

		protected void DrawImageBox(Graphics g, int left, int top, int width, int height)
		{
			Rectangle src = new Rectangle(0, 0, bm.Left, bm.Top);

								
			g.DrawImage(border[0], new Rectangle(left, top, src.Width, src.Height), src, GraphicsUnit.Pixel);
			DrawImageH(g, border[1], new Rectangle(left+src.Width, top, width-2*src.Width+1, src.Height), src);
			g.DrawImage(border[2], new Rectangle(left+width-src.Width+1, top, src.Width, src.Height), src, GraphicsUnit.Pixel);
			DrawImageV(g, border[3], new Rectangle(left+width-src.Width+1, top+src.Height, src.Width, height-2*src.Height), src);
			g.DrawImage(border[4], new Rectangle(left+width-src.Width+1, top+height-src.Height, src.Width, src.Height), src, GraphicsUnit.Pixel);
			DrawImageH(g, border[5], new Rectangle(left+src.Width, top+height-src.Height, width-2*src.Width, src.Height), src);
			g.DrawImage(border[6], new Rectangle(left, top+height-src.Height, src.Width+1, src.Height), src, GraphicsUnit.Pixel);
			DrawImageV(g, border[7], new Rectangle(left, top+src.Height, src.Width, height-2*src.Height), src);
		}

		protected void DrawImageSide(Graphics g, int left, int top, int width, int height)
		{
			Rectangle src = new Rectangle(0, 0, bm.Left, bm.Top);

			DrawImageV(g, border[3], new Rectangle(left+width-src.Width+1, top, src.Width, height), src);
			DrawImageV(g, border[7], new Rectangle(left, top, src.Width, height), src);
		}

		protected void DrawBar(Graphics g, int left, int top, int width, int height, bool start, bool end)
		{
			SolidBrush b = new SolidBrush(this.HighlightColor);
			if (start) g.FillEllipse(b, left-COLSPACING, top, height-1, height-1);
			if (end) g.FillEllipse(b, left+width-height+COLSPACING, top, height-1, height-1);

			if (start) 
			{
				left += height/2 -COLSPACING;
				width -= height/2 - COLSPACING;
			}
			if (end) width -= height/2 + COLSPACING;
			Rectangle rect = new Rectangle(left, top, width, height);
			
			g.FillRectangle(b, rect);
		}

		protected void DrawHighlightedCell(Graphics g, int left, int top, int width, int height)
		{
			SolidBrush p = new SolidBrush(this.ZeroCellColor);
			g.FillEllipse(p, left-COLSPACING, top, width, height-1);
			g.DrawEllipse(this.BorderPen, left-COLSPACING, top, width, height-1);
		}
		#endregion

		#region Custom Drawing
		

		protected void DrawRowSelection(Graphics g, int offset, int height) 
		{
			if (SelectionLength<1 || SelectionStart<0) return;
			if (SelectionStart<offset+Columns && SelectionEnd>=offset) 
			{
				int start = offset;
				if (SelectionStart >= offset && SelectionStart<offset+Columns) 
					start = SelectionStart;

				int end = offset+Columns-1;
				if (SelectionEnd >= offset && SelectionEnd<offset+Columns)
					end = SelectionEnd;
			

				DrawBar(
					g, 
					this.GetHexColLeft(start%Columns) , 
					0, 
					this.GetHexColLeft(end%Columns) - this.GetHexColLeft(start%Columns) + (int)this.HexBoxColumnWidth, 
					height, 
					(SelectionStart >= offset && SelectionStart<offset+Columns), 
					(SelectionEnd >= offset && SelectionEnd<offset+Columns)
					);

				DrawBar(
					g, 
					this.GetCharColLeft(start%Columns) , 
					0, 
					this.GetCharColLeft(end%Columns) - this.GetCharColLeft(start%Columns) + (int)this.CharWidth, 
					height, 
					(SelectionStart >= offset && SelectionStart<offset+Columns), 
					(SelectionEnd >= offset && SelectionEnd<offset+Columns)
					);
			}
		}
		
		protected void PaintRow(Bitmap b, int row)
		{
			Graphics g = Graphics.FromImage(b);
			SetGraphicsMode(g);
			
			g.FillRectangle(this.BackBrush, -2, 0, this.OffsetBoxWidth, b.Height+2);
			g.FillRectangle(this.BackBrush, this.OffsetBoxWidth+WINDOWSPACING, -2, this.HexBoxWidth, b.Height+2);			
			g.FillRectangle(this.BackBrush, this.OffsetBoxWidth+this.HexBoxWidth+2*WINDOWSPACING, -2, this.CharBoxWidth, b.Height+2);			
			
			Rectangle clip = new Rectangle(bm.Left, 0, b.Width - bm.Left - bm.Width, b.Height);
						
			//Offset Number
			int left = bm.Left;
			int width = OffsetBoxWidth - bm.Left - bm.Width;
			int height = (int)this.HexBoxRowHeight;

			int delta = Columns;
			int offset = (this.CurrentRow+row) * delta;
						
			RectangleF dst = new RectangleF(left, 0, width, height);			
			if (offset<data.Length) g.DrawString(SetLength(offset.ToString("x"), 8, '0'), HeaderFont, ForeBrush, dst);			
			
			DrawRowSelection(g, offset, b.Height);
			
			
			width = (int)this.HexBoxColumnWidth + COLSPACING;						
			int cleft = (int)(this.OffsetBoxWidth + this.HexBoxWidth + 2*WINDOWSPACING + bm.Left);
			for (int c=0; c<Columns; c++) 
			{				
				
				if ((offset<data.Length) && offset>=0)
				{
					SolidBrush brush;
					if (offset>=this.SelectionStart && offset<=this.SelectionEnd ) brush = new SolidBrush(this.HighlightForeColor);				
					else brush = ForeBrush;
					

					left = this.GetHexColLeft(c);
					string txt;
					if (vs == ViewState.Hex)
						txt = SetLength(data[offset].ToString("x"), 2, '0');
					else 
						txt = data[offset].ToString();
					dst = new RectangleF(left, 0, width, height);	
					//if ( row == acell.Y && c==acell.X) DrawHighlightedCell(g, left, 0, width, height);
					g.DrawString(txt, Font, brush, dst);
					if (hs && data[offset]==0) this.DrawHighlightedCell(g, left, 0, width, height);
					
				
					txt = ((char)data[offset]).ToString();	
					dst = new RectangleF(cleft, 0, this.CharWidth, height);
					//if ( row == acell.Y && c==acell.X) DrawHighlightedCell(g, left, 0, width, height);
					g.DrawString(txt, Font, brush, dst);
				
					cleft+=(int)this.CharWidth+COLSPACING;
					offset++;
				}
			}
			
			DrawImageSide(g, 0, 0, this.OffsetBoxWidth, b.Height);
			DrawImageSide(g, this.OffsetBoxWidth+WINDOWSPACING, 0, (int)this.HexBoxWidth, b.Height);
			DrawImageSide(g, (int)(this.OffsetBoxWidth+this.HexBoxWidth+2*WINDOWSPACING), 0, this.CharBoxWidth, b.Height);
			g.Dispose();
		}

		protected void PaintRows(Graphics g)
		{
			if (rowimage.Length==0) return;
			Rectangle src = new Rectangle(0, 0, rowimage[0].Width-1, rowimage[0].Height-1);
			for (int r=0; r<rowimage.Length; r++)
			{
				int top = GetVisibleRowTop(r);
				g.DrawImage(rowimage[r], new Rectangle(0, top, src.Width, src.Height),src, GraphicsUnit.Pixel);
			}
		}

		protected void PaintOffsetBox(Graphics g)
		{			
			g.FillRectangle(this.BackBrush, 0, 0, this.OffsetBoxWidth, this.Height);	
			g.FillRectangle(this.HeadBackBrush, 0, 0, this.OffsetBoxWidth, this.HexBoxRowHeight+bm.Top-COLSPACING);
			DrawImageBox(g, 0, 0, this.OffsetBoxWidth, this.Height);			
		}

		protected void PaintHexBox(Graphics g)
		{			
			g.FillRectangle(this.BackBrush, this.OffsetBoxWidth+WINDOWSPACING, 0, this.HexBoxWidth, this.Height);			
			g.FillRectangle(this.BackBrush, this.OffsetBoxWidth+this.HexBoxWidth+2*WINDOWSPACING, 0, this.CharBoxWidth, this.Height);			

			g.FillRectangle(this.HeadBackBrush, this.OffsetBoxWidth+WINDOWSPACING, 0, this.HexBoxWidth, this.HexBoxRowHeight+bm.Top-COLSPACING);			
			g.FillRectangle(this.HeadBackBrush, this.OffsetBoxWidth+this.HexBoxWidth+2*WINDOWSPACING, 0, this.CharBoxWidth, this.HexBoxRowHeight+bm.Top-COLSPACING);
						

			int width = (int)this.HexBoxColumnWidth + COLSPACING;
			int top = bm.Top - 2*COLSPACING;
			int height = (int)this.HexBoxRowHeight;
			
			for (int c=0; c<Columns; c++) 
			{
				int left = this.GetHexColLeft(c);
				string txt = SetLength(c.ToString("x"), 2, '0');
				RectangleF dst = new RectangleF(left, top, width, height);					
				g.DrawString(txt, HeaderFont, HeadForeBrush, dst);								
			}
			DrawImageBox(g, (int)this.OffsetBoxWidth+WINDOWSPACING, 0, (int)this.HexBoxWidth, this.Height);
			DrawImageBox(g, (int)(this.OffsetBoxWidth+this.HexBoxWidth+2*WINDOWSPACING), 0, (int)this.CharBoxWidth, this.Height);			
		}		
		#endregion

		#region Data reading
		/// <summary>
		/// Returns/Sets the currently Selected Data
		/// </summary>
		/// <returns></returns>
		public byte[] Selection
		{
			get 
			{
				if (SelectionStart<0) return new byte[0];

				byte[] ret = new byte[SelectionLength];
				for (int i=SelectionStart; i<=SelectionEnd; i++) ret[i-SelectionStart] = data[i];
				return ret;
			}
			set 
			{
				if (SelectionStart<0) return;

				for (int i=0; i<Math.Min(SelectionLength, value.Length); i++)
					data[SelectionStart+i] = value[i];

				this.UpdateSelectedRows();
				Refresh();
			}
		}		

		/// <summary>
		/// Returns/Sets the selected Byte
		/// </summary>
		public byte SelectedByte
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<1) return 0;

				return data[SelectionStart];
			}
			set
			{	
				if (SelectionStart<0) return;
				if (data.Length-SelectionStart<1) return;
				
				data[SelectionStart] = value;
				
				this.UpdateSelectedRows();
				Refresh();

				if (DataChanged!=null) DataChanged(this, new EventArgs());
			}
		}

		

		void SetValue(object o) 
		{
			if (o==null) return;
			if (SelectionStart<0) return;

			byte[] val;
			if (o is char) val = BitConverter.GetBytes((char)o);
			else if (o is ushort) val = BitConverter.GetBytes((ushort)o);
			else if (o is short) val = BitConverter.GetBytes((short)o);
			else if (o is uint) val = BitConverter.GetBytes((uint)o);
			else if (o is int) val = BitConverter.GetBytes((int)o);
			else if (o is ulong) val = BitConverter.GetBytes((ulong)o);
			else if (o is long) val = BitConverter.GetBytes((long)o);
			else if (o is float) val = BitConverter.GetBytes((float)o);
			else if (o is double) val = BitConverter.GetBytes((double)o);
			else val = new byte[0];

			if (data.Length-SelectionStart<val.Length) return;
			int len = Math.Max(val.Length, SelectionLength);

			BeginUpdate();
			if  (len!=SelectionLength) Select(SelectionStart, len);
				
			for (int i=0; i<val.Length; i++) data[SelectionStart+i] = val[i];
				
			this.UpdateSelectedRows();
			Refresh();
			EndUpdate();

			if (DataChanged!=null) DataChanged(this, new EventArgs());
		}

		/// <summary>
		/// Returns/Sets the selected Character
		/// </summary>
		public char SelectedChar
		{
			get 
			{				
				if (SelectionStart<0) return (char)0;
				if (data.Length-SelectionStart<1) return (char)0;

				try 
				{
					return BitConverter.ToChar(data, SelectionStart);
				} 
				catch { return (char)0; }
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected unsigned Short
		/// </summary>
		public ushort SelectedUShort
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<2) return 0;

				return BitConverter.ToUInt16(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected  Short
		/// </summary>
		public short SelectedShort
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<2) return 0;

				return BitConverter.ToInt16(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected unsigned Integer
		/// </summary>
		public uint SelectedUInt
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<4) return 0;

				return BitConverter.ToUInt32(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected Integer
		/// </summary>
		public int SelectedInt
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<4) return 0;

				return BitConverter.ToInt32(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected unsigned Long Integer
		/// </summary>
		public ulong SelectedULong
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<8) return 0;

				return BitConverter.ToUInt64(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected Long Integer
		/// </summary>
		public long SelectedLong
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<8) return 0;

				return BitConverter.ToInt64(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected unsigned Integer
		/// </summary>
		public float SelectedFloat
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<4) return 0;

				return BitConverter.ToSingle(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}

		/// <summary>
		/// Returns/Sets the selected unsigned Integer
		/// </summary>
		public double SelectedDouble
		{
			get 
			{				
				if (SelectionStart<0) return 0;
				if (data.Length-SelectionStart<8) return 0;

				return BitConverter.ToDouble(data, SelectionStart);
			}
			set
			{	
				SetValue(value);
			}
		}
		#endregion
	}
}
