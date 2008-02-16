using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Component to display Details about a passed Object
	/// </summary>
	public class SimpleObjectPreview : System.Windows.Forms.UserControl
	{


		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		protected System.Windows.Forms.Label lbName;
		protected System.Windows.Forms.Label lbPrice;
		protected System.Windows.Forms.PictureBox pb;
		protected System.Windows.Forms.Label lbAbout;
		protected Ambertation.Windows.Forms.FlatComboBox cbCat;
		private System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label lbExpansion;
		private System.Windows.Forms.Label label6;
		protected System.Windows.Forms.Label lbVert;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimpleObjectPreview()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			BackColor = Color.Transparent;
			loadimg = true;
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			BuildDefaultImage();
			ClearScreen();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleObjectPreview));
            this.pb = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbAbout = new System.Windows.Forms.Label();
            this.cbCat = new Ambertation.Windows.Forms.FlatComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbExpansion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbVert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pb
            // 
            this.pb.AccessibleDescription = null;
            this.pb.AccessibleName = null;
            resources.ApplyResources(this.pb, "pb");
            this.pb.BackColor = System.Drawing.Color.Transparent;
            this.pb.BackgroundImage = null;
            this.pb.Font = null;
            this.pb.ImageLocation = null;
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbName
            // 
            this.lbName.AccessibleDescription = null;
            this.lbName.AccessibleName = null;
            resources.ApplyResources(this.lbName, "lbName");
            this.lbName.Font = null;
            this.lbName.Name = "lbName";
            // 
            // lbPrice
            // 
            this.lbPrice.AccessibleDescription = null;
            this.lbPrice.AccessibleName = null;
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Font = null;
            this.lbPrice.Name = "lbPrice";
            // 
            // lbAbout
            // 
            this.lbAbout.AccessibleDescription = null;
            this.lbAbout.AccessibleName = null;
            resources.ApplyResources(this.lbAbout, "lbAbout");
            this.lbAbout.Font = null;
            this.lbAbout.Name = "lbAbout";
            // 
            // cbCat
            // 
            this.cbCat.AccessibleDescription = null;
            this.cbCat.AccessibleName = null;
            resources.ApplyResources(this.cbCat, "cbCat");
            this.cbCat.BackgroundImage = null;
            this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCat.Font = null;
            this.cbCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbCat.Name = "cbCat";
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbExpansion
            // 
            this.lbExpansion.AccessibleDescription = null;
            this.lbExpansion.AccessibleName = null;
            resources.ApplyResources(this.lbExpansion, "lbExpansion");
            this.lbExpansion.Font = null;
            this.lbExpansion.Name = "lbExpansion";
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbVert
            // 
            this.lbVert.AccessibleDescription = null;
            this.lbVert.AccessibleName = null;
            resources.ApplyResources(this.lbVert, "lbVert");
            this.lbVert.Font = null;
            this.lbVert.Name = "lbVert";
            // 
            // SimpleObjectPreview
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.lbVert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbExpansion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCat);
            this.Controls.Add(this.lbAbout);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.lbPrice);
            this.Name = "SimpleObjectPreview";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Public Properties
		protected SimPe.PackedFiles.Wrapper.ExtObjd objd;
		[Browsable(false)]
		public SimPe.PackedFiles.Wrapper.ExtObjd SelectedObject 
		{
			get { return objd; }
			set 
			{
				if (objd!=value || value==null)
				{
					objd = value;
					UpdateScreen();
				}
			}
		}	
	
		bool loadimg;
		public bool LoadCustomImage
		{
			get { return loadimg; }
			set {loadimg = value;}
		}

		[Browsable(false)]
		public virtual bool Loaded
		{
			get { return objd!=null; }
		}

		[Browsable(false)]
		public string Title
		{
			get { return this.lbName.Text; }
		}

		[Browsable(false)]
		public string Description
		{
			get { return this.lbAbout.Text; }
		}

		[Browsable(false)]
		public short Price
		{
			get { return Helper.StringToInt16(this.lbPrice.Text.Replace(" $", ""), 0, 10); }
		}
		#endregion

		#region Thumbnails
		/// <summary>
		/// Returns the Instance Number for the assigned Thumbnail
		/// </summary>
		/// <param name="group">The Group of the Object</param>
		/// <param name="modelname">The Name of teh Model (inst 0x86)</param>
		/// <returns>Instance of the Thumbnail</returns>
		public static uint ThumbnailHash(uint group, string modelname) 
		{
			string name = group.ToString()+modelname;
			return (uint)Hashes.ToLong(Hashes.Crc32.ComputeHash(Helper.ToBytes(name.Trim().ToLower())));
		}

		static SimPe.Packages.File thumbs = null;

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname) 
		{
			return GetThumbnail(group, modelname, null);
		}
		
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message) 
		{
			
			if (thumbs==null) 
			{
				thumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Thumbnails\\ObjectThumbnails.package"));
				thumbs.Persistent = true;
			}

			Image img = GetThumbnail(group, modelname, message, thumbs);	
			return img;
		}
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message, SimPe.Packages.File thumbs) 
		{
			uint inst = ThumbnailHash(group, modelname);
			Image img = GetThumbnail(message, new uint[] { 0xAC2950C1}, group, inst, thumbs);
 	
			//if (img==null) img = GetThumbnail(message, new uint[] { 0xAC2950C1}, Hashes.GetCrc32(Hashes.StripHashFromName(modelname.Trim().ToLower())), thumbs);

			return img;
		}
		
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(string message, uint type, uint group, uint inst, SimPe.Packages.File thumbs) 
		{
			return GetThumbnail(message, new uint[] { type }, group, inst, thumbs);
		}

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(string message, uint[] types, uint group, uint inst, SimPe.Packages.File thumbs) 
		{
			/*ArrayList types = new ArrayList();
			types.Add(0xAC2950C1); // Objects
			types.Add(0xEC3126C4); // Terrain
			types.Add(0xCC48C51F); //chimney
			types.Add(0x2C30E040); //fence Arch
			types.Add(0xCC30CDF8); //fences
			types.Add(0x8C311262); //floors
			types.Add(0x2C43CBD4); //foundtaion / pools
			types.Add(0xCC44B5EC); //modular Stairs
			types.Add(0xCC489E46); //roof
			types.Add(0x8C31125E); //wall*/

			foreach (uint type in types)
			{
				//0x6C2A22C3
				Interfaces.Files.IPackedFileDescriptor[] pfds = thumbs.FindFile(type, group, inst);
				if (pfds.Length==0) pfds = thumbs.FindFile(type, 0, inst);
				if (pfds.Length>0) 
				{
					Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
					try 
					{
						SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
						pic.ProcessData(pfd, thumbs);
						Bitmap bm = (Bitmap)ImageLoader.Preview(pic.Image, WaitingScreen.ImageSize);
						WaitingScreen.Update(bm, message);
						return pic.Image;
					}
					catch(Exception){}
				}
			}
			return null;
		}
		#endregion

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <returns>The expansion which madkes this File available (<see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansions FileFrom(string flname)
		{
			if (flname==null) flname = "";
			else flname = flname.Trim().ToLower();

            foreach (ExpansionItem ei in PathProvider.Global.Expansions)
            {
                if (flname.StartsWith(ei.InstallFolder.Trim().ToLower())) return (ei.Expansion);
            }
            if (flname.StartsWith(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Donwloads"))) return Expansions.Custom;
			return Expansions.None;
		}

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="pfd">Resource Descriptor</param>
		/// <returns>The expansion which madkes this File available (according to the FileTable, <see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansions FileFrom(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fiis = FileTable.FileIndex.FindFile(pfd, null);
			uint min = (uint)(Expansions.None);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in fiis) 
			{
				try 
				{
					min = Math.Min((uint)FileFrom(fii.Package.FileName), min);
				} 
				catch {}
			}
			

			return (Expansions)min;
		}

		protected void SetupCategories(string[][] catss)
		{
			cbCat.Items.Clear();
			foreach(string[] cats in catss) 
			{
				string res = "";
				foreach (string cat in cats)
				{
					if (res!="") res += " / ";
					res += cat.Trim();
				}

				if (res!="") this.cbCat.Items.Add(res);
			}

			cbCat.SelectedIndex = cbCat.Items.Count-1;
		}

		public static Image GenerateImage(Size sz, Image img, bool knockout)
		{
			if (img==null) return null;
			if (knockout) 
			{
				img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new Point(0,0), Color.Magenta);
				return Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(img, sz, 8, Color.FromArgb(90, Color.Black), Color.FromArgb(10, 10, 40), Color.White, Color.FromArgb(80, Color.White), true, 3, 3);
			} 
			else 
			{
				return Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(img, sz, 8, Color.FromArgb(90, Color.Black), SimPe.ThemeManager.Global.ThemeColorDark, Color.White, Color.FromArgb(80, Color.White), true, 3, 3);
			}
		}

		public virtual void SetFromObjectCacheItem(SimPe.Cache.ObjectCacheItem oci)
		{
			if (oci==null) 
			{
				objd = null;
				ClearScreen();
				return;
			}

			objd = null;
			if (oci.Tag!=null)
			if (oci.Tag is SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem) 
			{
				objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);
			} 			
		

			UpdateScreen();			
			if (oci.Thumbnail == null) pb.Image = defimg;
			else pb.Image = GenerateImage(pb.Size, oci.Thumbnail, true);
			lbName.Text = oci.Name;	
			lbVert.Text = "---";	
		}

		public virtual void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			
			if (pkg==null) 
			{
				objd = null;
				ClearScreen();
				return;
			}

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFile(Data.MetaData.OBJD_FILE, 0, 0x41A7);
			if (pfds.Length>0) 
			{
				objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData(pfds[0], pkg);				
			} 
			int fct = 0; int vct = 0;
			pfds = pkg.FindFiles(Data.MetaData.GMDC);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.Plugin.Rcol rcol = new GenericRcol();
				rcol.ProcessData(pfd, pkg, true);

				SimPe.Plugin.GeometryDataContainer gmdc = rcol.Blocks[0] as SimPe.Plugin.GeometryDataContainer;
				foreach (SimPe.Plugin.Gmdc.GmdcGroup g in gmdc.Groups)
				{
					fct += g.FaceCount;
					vct += g.UsedVertexCount;
				}

				rcol.Dispose();
			}
			lbVert.Text = vct.ToString()+" ("+fct.ToString()+" Faces)";


			UpdateScreen();
		}

		protected void ClearScreen()
		{
			pb.Image = defimg;
			this.lbAbout.Text = "";
			this.lbName.Text = "";
			this.lbPrice.Text = "";
			this.cbCat.Items.Clear();
		}

		

		public void UpdateScreen()
		{
			ClearScreen();
			if (objd==null) return;
			
			
			this.lbExpansion.Text = SimPe.Localization.GetString(FileFrom(objd.FileDescriptor).ToString());
			
			string[] mn = GetModelnames();			
			if (mn.Length>0) 
			{
				uint grp = objd.FileDescriptor.Group;
				/*if (grp==0xffffffff && objd.Package!=null && loadimg) 
					if (objd.Package.FileName!=null)
					{
						FileTable.FileIndex.Load();						
						SimPe.Interfaces.Wrapper.IGroupCacheItem gci = FileTable.GroupCache.GetItem(objd.Package.FileName);
						if (gci!=null) grp = gci.LocalGroup;
					}*/
				pb.Image =  GenerateImage(pb.Size, GetThumbnail(objd.FileDescriptor.Group, mn[0]), true);
			}
			else pb.Image = null;
			
			SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, objd.FunctionSubSort, objd.Type, SimPe.Cache.ObjectClass.Object));							

			SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
			if (strs!=null) 
			{
				if (strs.Count>0) this.lbName.Text = strs[0].Title;
				if (strs.Count>1) this.lbAbout.Text = strs[1].Title;
			} 
			else this.lbName.Text = objd.FileName;
			
			this.lbPrice.Text = objd.Price.ToString()+" $";

			if (pb.Image == null) pb.Image = defimg;
		}

		protected string[] GetModelnames()
		{
			if (objd==null) return new string[0];
			if (objd.Package == null) return new string[0];

			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = objd.Package.FindFile(Data.MetaData.STRING_FILE, 0, objd.FileDescriptor.Group, 0x85);
			ArrayList list = new ArrayList();
			if (pfd!=null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, objd.Package);
				SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
				for (int i=1; i<items.Length; i++) list.Add(items[i].Title);
				
			}
			string[] refname = new string[list.Count];
			list.CopyTo(refname);

			return refname;
		}

		protected virtual SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems(Interfaces.Files.IPackedFileDescriptor ctss, SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			if (ctss!= null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(ctss, pkg);

				return str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				
			} 

			return null;
		}

		protected virtual SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
		{
			if (objd==null) return null;
			if (objd.Package == null) return null;
			if (objd.FileDescriptor == null) return null;

			//Get the Name of the Object
			Interfaces.Files.IPackedFileDescriptor ctss = objd.Package.FindFile(Data.MetaData.CTSS_FILE, 0, objd.FileDescriptor.Group, objd.CTSSInstance);			
			
			return GetCtssItems(ctss, objd.Package);
		}

		protected Image defimg;
		protected void BuildDefaultImage()
		{
			defimg = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.demo.png"));
		}
	}
}
