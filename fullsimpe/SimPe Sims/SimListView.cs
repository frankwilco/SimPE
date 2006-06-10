using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.PackedFiles.Wrapper
{	
	/// <summary>
	/// Zusammenfassung für SimListView.
	/// </summary>
	public class SimListView : SteepValley.Windows.Forms.XPListView
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        static Size ICON_SIZE = new Size(64, 64);

		SimPe.ColumnsSorter s;
		public SimListView()
		{
			SetStyle(ControlStyles.UserMouse, true);
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.HideSelection = false;
			this.FullRowSelect = true;
			this.MultiSelect = false;			

			this.LargeImageList = new ImageList();


			LargeImageList.ColorDepth = ColorDepth.Depth32Bit;
            LargeImageList.ImageSize = ICON_SIZE;
			
			s = new SimPe.ColumnsSorter(new int[]{1,0});
			this.ListViewItemSorter = s;
		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				Clear();
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
			components = new System.ComponentModel.Container();
		}
		#endregion
		
		public new void Clear()
		{
			Items.Clear();
			LargeImageList.Images.Clear();	
			this.ListViewItemSorter = s;
		}

        public SteepValley.Windows.Forms.XPListViewItem Add(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc)
        {
            return Add(sdesc, SimPe.PackedFiles.Wrapper.SimPoolControl.GetImagePanelColor(sdesc));
        }

        public Image GetSimIcon(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc, Color bgcol)
        {
            return BuildSimPreviewImage(bgcol, sdesc.Image, sdesc.SimId);
        }

		public SteepValley.Windows.Forms.XPListViewItem Add(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc, Color bgcol)
		{
            Image imgbig = BuildSimPreviewImage(bgcol, sdesc.Image, sdesc.SimId);
            return Add(sdesc, imgbig);
        }

        public SteepValley.Windows.Forms.XPListViewItem Add(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc, Image imgbig) 
        {
			SteepValley.Windows.Forms.XPListViewItem lvi = new SteepValley.Windows.Forms.XPListViewItem();
			try 
			{
				this.LargeImageList.Images.Add(imgbig);
				lvi.ImageIndex = LargeImageList.Images.Count-1;				
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			
			lvi.Text = " "+sdesc.SimName+" "+sdesc.SimFamilyName;
			if (this.Columns.Count>1) lvi.SubItems.Add("    "+Columns[1].Text+": "+sdesc.HouseholdName);
			if (this.Columns.Count>2) lvi.SubItems.Add("    "+Columns[2].Text+": 0x"+Helper.HexString(sdesc.SimId));
			if (this.Columns.Count>3) lvi.SubItems.Add("    "+Columns[3].Text+": 0x"+Helper.HexString((ushort)sdesc.FileDescriptor.Instance));
			if (this.Columns.Count>4) lvi.SubItems.Add("    "+Columns[4].Text+": "+new Data.LocalizedLifeSections(sdesc.CharacterDescription.LifeSection).ToString());							
			
			
			this.Items.Add(lvi);
			return lvi;
		}

        static System.Collections.Generic.Dictionary<uint, Image> simicons = new System.Collections.Generic.Dictionary<uint, Image>();

        public static Image BuildSimPreviewImage(SimPe.PackedFiles.Wrapper.ExtSDesc sdesc, Color bgcol)
        {
            return BuildSimPreviewImage(bgcol, sdesc.Image, sdesc.SimId);
        }
        protected static Image BuildSimPreviewImage(Color bgcol, Image imgbig, uint guid)
        {
            if (simicons.ContainsKey(guid))
            {
                Image img = simicons[guid];
                if (img != null) return (Image)img.Clone();
            }

            if (imgbig != null)
                if (imgbig.Width < 16)
                    imgbig = null;

            if (imgbig != null)
                imgbig = Ambertation.Drawing.GraphicRoutines.KnockoutImage(imgbig, new Point(0, 0), Color.Magenta);
            else
                imgbig = Image.FromStream(
                    typeof(SimListView).Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png")
                );

            imgbig = Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(
                imgbig,
                ICON_SIZE,
                8,
                Color.FromArgb(90, Color.Black),
                bgcol,
                Color.White,
                Color.FromArgb(80, Color.White),
                true,
                0,
                0
                );

            simicons[guid] = imgbig;
            return (Image)imgbig.Clone();
        }		
		
		

	}
}
