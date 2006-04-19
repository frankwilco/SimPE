using System;
using System.Drawing;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für PackageInfo.
	/// </summary>
	public class PackageInfo : Downloads.IPackageInfo	, System.IDisposable
	{
		public const int IMAGESIZE = 128;
		/// <summary>
		/// Known Expansions
		/// </summary>
		public enum Expansion : ushort
		{
			Unknown = 0xFF,			
			Original = 0x02,
			University = 0x04,
			Nightlife = 0x08,
			Business = 0x10,
			FamilyFun = 0x20,
			Custom = 0x01
		}

		protected static Image defimg;
		public static Image DefaultImage
		{
			get 
			{
				if (defimg==null) BuildDefaultImage();
				return defimg;
			}
		}
		protected static void BuildDefaultImage()
		{
            if (defimg == null)
            {
                System.IO.Stream s = typeof(PackageInfo).Assembly.GetManifestResourceStream("SimPe.Plugin.Downloads.demo.png");
                if (s!=null)
                    defimg = Image.FromStream(s);
            }
		}

		/// <summary>
		/// Returns the Type of a given Package.
		/// </summary>
		/// <param name="filename">The package you want to classify</param>
		/// <returns>The Type of the Package</returns>
		public static SimPe.Cache.PackageType ClassifyPackage(string filename)
		{
			if (!System.IO.File.Exists(filename)) return SimPe.Cache.PackageType.Undefined;

			SimPe.Interfaces.Files.IPackageFile pkg = SimPe.Packages.GeneratableFile.LoadFromFile(filename);
			return ClassifyPackage(pkg);
		}

		/// <summary>
		/// Returns the Type of a given Package.
		/// </summary>
		/// <param name="pkg">The package you want to classify</param>
		/// <returns>The Type of the Package</returns>
		public static SimPe.Cache.PackageType ClassifyPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Cache.PackageType type = SimPe.Cache.PackageType.Undefined;
			foreach (SimPe.Interfaces.Plugin.Scanner.IIdentifier ident in SimPe.Plugin.Scanner.ScannerRegistry.Global.Identifiers)
			{
				if (type != SimPe.Cache.PackageType.Unknown && type != SimPe.Cache.PackageType.Undefined) break;
				type = ident.GetType(pkg);	
			}

			return type;
		}

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="pfd">Resource Descriptor</param>
		/// <returns>The expansion which madkes this File available (according to the FileTable, <see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansion FileFrom(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fiis = FileTable.FileIndex.FindFile(pfd, null);
			ushort min = (ushort)(Expansion.Unknown);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in fiis) 
			{
				try 
				{
					min = Math.Min((ushort)FileFrom(fii.Package.FileName), min);
				} 
				catch {}
			}
			

			return (Expansion)min;
		}

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <returns>The expansion which madkes this File available (<see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansion FileFrom(string flname)
		{
			if (flname==null) flname = "";
			else flname = Helper.CompareableFileName(flname);

			if (flname.StartsWith(Helper.CompareableFileName(Helper.WindowsRegistry.SimsPath))) return Expansion.Original;
			if (flname.StartsWith(Helper.CompareableFileName(Helper.WindowsRegistry.SimsEP1Path))) return Expansion.University;
			if (flname.StartsWith(Helper.CompareableFileName(Helper.WindowsRegistry.SimsEP2Path))) return Expansion.Nightlife;
			if (flname.StartsWith(Helper.CompareableFileName(Helper.WindowsRegistry.SimsEP3Path))) return Expansion.Business;
			if (flname.StartsWith(Helper.CompareableFileName(Helper.WindowsRegistry.SimsSP1Path))) return Expansion.FamilyFun;
			if (flname.StartsWith(Helper.CompareableFileName(System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Donwloads")))) return Expansion.Custom;
			return Expansion.Unknown;
		}

        string flname;
		public PackageInfo(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			guid = new uint[0];
            flname = pkg.SaveFileName;
			knockout = true;
			BuildDefaultImage();
			Reset();
		}

		Expansion exp;
		public Expansion FirstExpansion
		{
			get {return exp;}
			set {exp = value;}
		}

		string name;
		public string Name
		{
			get {return name;}
			set {name = value;}
		}

		string desc;
		public string Description
		{
			get {return desc;}
			set {desc = value;}
		}

		string cat;
		public string Category
		{
			get { return cat;}
			set { cat = value;}
		}

		Image img;
		Image myrender;
		public Image Image
		{
			get { 				
				if (img==null)
				{
					/*if (myrender==null) return defimg;
					else*/ return myrender;
				}

				return img;
			}
			set { 
				img = value;								
			}
		}

        public bool HasThumbnail
        {
            get { return img != null; }
        }
		public Image RenderedImage
		{
			get { return myrender;}
			set { myrender = value;	}
		}

		int vertct;
		public int VertexCount
		{
			get { return vertct;}
			set { vertct = value;}
		}
		public bool HighVertexCount
		{
			get {return(VertexCount>8000); }
		}

		int facect;
		public int FaceCount
		{
			get { return facect;}
			set { facect = value;}
		}
		public bool HighFaceCount
		{
			get {return(VertexCount>8000); }
		}

		int price;
		public int Price
		{
			get { return price;}
			set { price = value;}
		}

		uint[] guid;
		public uint[] Guids
		{
			get { return guid;}
			set { guid = value;}
		}

		internal void ClearGuidList()
		{
			guid = new uint[0];
		}

		public void AddGuid(uint guid)
		{
			this.guid = Helper.Add(this.guid, guid) as uint[];
		}

		SimPe.Cache.PackageType type;
		public SimPe.Cache.PackageType Type
		{
			get { return type;}
			set { type = value;}
		}


		public void Reset()
		{			
			RenderData = null;
			PostponedRenderer = null;
			this.Description = "";
			this.Name = "";
			this.Price = 0;
			this.Category = "";
			this.VertexCount = 0;
			this.FaceCount = 0;
			this.Image = null;	
			type = SimPe.Cache.PackageType.Undefined;
			exp = Expansion.Unknown;
			ClearGuidList();
		}

		public static Image GeneratePreviewImage(Size sz, Image img, bool knockout, bool aspect)
		{
			if (img==null) return null;

			if (aspect)
			{
				double a = (double)img.Width / (double)img.Height;
				if (img.Height>img.Width)
					sz = new Size((int)(a * sz.Height), sz.Height);
				else
					sz = new Size(sz.Width, (int)(sz.Width / a));
			}
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

		bool knockout;
		/// <summary>
		/// 
		/// </summary>
		public bool KnockoutThumbnail
		{
			get{ return knockout;}
			set {knockout = value;}
		}

		public Image GetThumbnail()
		{
			return GetThumbnail(new Size(IMAGESIZE, IMAGESIZE));
		}

		public Image GetThumbnail(Size sz)
		{
			if (Image==null) return null;
			return GeneratePreviewImage(sz, Image, KnockoutThumbnail, true);
		}

        public override string ToString()
        {
            return Type.ToString()+": "+Name;
        }

		#region postponed 3dPreview
		object rd;
		internal object RenderData
		{
			get {return rd;}
			set { 
				rd = value;
			}
		}
		internal System.EventHandler PostponedRenderer;
		public void CreatePostponed3DPreview()
		{
			if (RenderData==null) return;
			if (PostponedRenderer==null) return;
			
			PostponedRenderer(this, new System.EventArgs());
			PostponedRenderer = null;
			RenderData = null;
		}
		#endregion

        #region IDisposable Member

        public virtual void Dispose()
        {
            name = null;
            desc = null;
            cat = null;
            img = null;
            myrender = null;
            flname = null;

			RenderData = null;
			PostponedRenderer = null;
        }

        #endregion
    }
}
