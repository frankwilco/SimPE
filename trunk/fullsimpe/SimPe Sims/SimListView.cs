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
			LargeImageList.ImageSize = new Size(64, 64);
			
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
			//Image imgbig = SimPoolControl.CreateItem(sdesc).SourceImage;
			Image imgbig = sdesc.Image;
			if (imgbig.Width<16) imgbig = null;

			if (imgbig!=null) 			
				imgbig = Ambertation.Drawing.GraphicRoutines.KnockoutImage(imgbig, new Point(0, 0), Color.Magenta);								
			else 
				imgbig = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png"));			

			imgbig = Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(imgbig, this.LargeImageList.ImageSize, 8, Color.FromArgb(90, Color.Black), SimPe.PackedFiles.Wrapper.SimPoolControl.GetImagePanelColor(sdesc), Color.White, Color.FromArgb(80, Color.White), true, 0, 0);
			//imgbig = Ambertation.Drawing.GraphicRoutines.ScaleImage(imgbig, this.LargeImageList.ImageSize.Width, this.LargeImageList.ImageSize.Height, true);

			this.LargeImageList.Images.Add(imgbig);

			SteepValley.Windows.Forms.XPListViewItem lvi = new SteepValley.Windows.Forms.XPListViewItem();
			lvi.Text = " "+sdesc.SimName+" "+sdesc.SimFamilyName;
			if (this.Columns.Count>1) lvi.SubItems.Add("    "+Columns[1].Text+": "+sdesc.HouseholdName);
			if (this.Columns.Count>2) lvi.SubItems.Add("    "+Columns[2].Text+": 0x"+Helper.HexString(sdesc.SimId));
			if (this.Columns.Count>3) lvi.SubItems.Add("    "+Columns[3].Text+": 0x"+Helper.HexString((ushort)sdesc.FileDescriptor.Instance));
			if (this.Columns.Count>4) lvi.SubItems.Add("    "+Columns[4].Text+": "+new Data.LocalizedLifeSections(sdesc.CharacterDescription.LifeSection).ToString());
			lvi.ImageIndex = LargeImageList.Images.Count-1;
			
			
			
			this.Items.Add(lvi);
			return lvi;
		}		
		
		

	}
}
