using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;
using SimPe.Data;

namespace SimPe.Plugin.UI
{
	public partial class ClothingBrowser : PackageBrowser
	{
		Ages ageFilter = (Ages)0x7F;
		SimGender genderFilter = SimGender.Both;
		SkinCategories categoryFilter = SkinCategories.Everyday;
		OutfitType outfitFilter = OutfitType.None;


		public SkinCategories CategoryFilter
		{
			get { return categoryFilter; }
			set { categoryFilter = value; }
		}

		public OutfitType OutfitFilter
		{
			get { return outfitFilter; }
			set { outfitFilter = value; }
		}

		public Ages AgeFilter
		{
			get { return ageFilter; }
			set { ageFilter = value; }
		}
		
		public SimGender GenderFilter
		{
			get { return genderFilter; }
			set { genderFilter = value; }
		}


		public ClothingBrowser() : base()
		{
			InitializeComponent();
		}

		public ClothingBrowser(
			FileDatabase database,
			Ages ageFilter,
			SimGender genderFilter,
			SkinCategory categoryFilter,
			OutfitType outfitFilter
			)
			: this()
		{
			this.ageFilter = ageFilter;
			this.genderFilter = genderFilter;
			this.categoryFilter = AgeData.CategoryConvert(categoryFilter);
			this.outfitFilter = outfitFilter;

			this.FileDatabase = database;

			this.LoadItems();
		}

		public ClothingBrowser(FileDatabase database) : this(database, (Ages)0x7F, SimGender.Both, SkinCategory.Everyday, OutfitType.Body)
		{
		}

		protected override ListViewItem CreateListItem(GenericCpfInfo cpfInfo)
		{
			// TODO: redo this function: search for a TextureOverlayItem that matches
			// the criteria, then call the base.CreateListItem if found
			if (cpfInfo is TextureOverlayInfo)
			{
				TextureOverlayInfo item = cpfInfo as TextureOverlayInfo;

				if (!Utility.EnumTest(item.Category, this.categoryFilter))
					return null;

				if (!Utility.EnumTest(item.OutfitType, this.outfitFilter))
					return null;

				if (!this.TestAge(item))
					return null;

				if (!this.TestGender(item))
					return null;

				return base.CreateListItem(item);
			}
			return null;
		}

		protected override Image GetListItemIcon(GenericCpfInfo cpfInfo)
		{
			if (cpfInfo.Icon != null)
				return cpfInfo.Icon;

			if (false)
			{
				TextureOverlayInfo item = cpfInfo as TextureOverlayInfo;
				if (item == null)
					return null;

				if (!Utility.IsNullOrEmpty(item.MaterialDefinitions))
				{
					MaterialDefinitionInfo mmatd = item.MaterialDefinitions[0];
					if (mmatd.BaseTexture != null)
					{
						MipMap map = ((ImageData)mmatd.BaseTexture.Blocks[0]).LargestTexture;
						if (map != null)
						{
							Image ret = map.Texture;
							cpfInfo.Icon = ret;
							return ret;
						}
					}

				}
			}

			//cpfInfo.Icon = Resources.NotAvailable;
			return cpfInfo.Icon;
		}

		bool TestAge(TextureOverlayInfo info)
		{
			return Utility.EnumTest(info.Age, this.ageFilter);
		}

		bool TestGender(TextureOverlayInfo info)
		{
			return Utility.EnumTest(info.Gender, this.genderFilter);
		}

	}


}