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
	public partial class HairBrowser : ClothingBrowser
	{
		Guid colorFilter = Guid.Empty;

		public HairBrowser() : base()
		{
			InitializeComponent();
		}

		public HairBrowser(FileDatabase database, Ages ageFilter, SimGender genderFilter, Guid selectedHaircolor)
			: this()
		{
			this.AgeFilter = ageFilter;
			this.GenderFilter = genderFilter;
			this.CategoryFilter = (SkinCategories)0xFFFF;
			this.OutfitFilter = OutfitType.Hair;

			this.FileDatabase = database;

			// custom hair color?
			if (!StandardHairColors.Contains(selectedHaircolor) && selectedHaircolor != ElderHairColor)
				selectedHaircolor = Guid.Empty;

			ToolStripButton selectedButton = null;
			foreach (ToolStripButton button in this.tsHairColor.Items)
			{
				Guid hairColor = (Guid)button.Tag;
				if (this.AgeFilter == Ages.Elder)
				{
					if (StandardHairColors.Contains(hairColor))
						button.Visible = false;
				}
				else
				{
					if (!StandardHairColors.Contains(hairColor) && hairColor != Guid.Empty)
						button.Visible = false;
				}

				if (hairColor == selectedHaircolor)
					selectedButton = button;
			}

			if (selectedButton != null)
				selectedButton.PerformClick();
			
		}

		public HairBrowser(FileDatabase database) : this(database, (Ages)0x7F, SimGender.Both, Guid.Empty)
		{
		}

		protected override ListViewItem CreateListItem(GenericCpfInfo cpfInfo)
		{
			// TODO: redo this function: search for a TextureOverlayItem that matches
			// the criteria, then call the base.CreateListItem if found
			if (cpfInfo is TextureOverlayInfo)
			{
				TextureOverlayInfo item = cpfInfo as TextureOverlayInfo;
				Guid itemHairtone = item.Hairtone;
				// custom hair color?
				if (!StandardHairColors.Contains(itemHairtone) && itemHairtone != ElderHairColor)
					itemHairtone = Guid.Empty;

				if (StandardHairColors.Contains(this.colorFilter) || this.colorFilter == Guid.Empty)
				{
					if (itemHairtone != this.colorFilter)
						return null;
				}
				else
					if (
							StandardHairColors.Contains(itemHairtone) || (
								itemHairtone == ElderHairColor &&
								!Utility.EnumTest(this.AgeFilter, Ages.Elder)
							)
						)
						return null;

				// hack to allow any category
				// TODO: rewrite Enum test function
				this.CategoryFilter = item.Category;

				return base.CreateListItem(item);
			}

			return null;
		}


		private void tsHairColor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
			foreach (ToolStripItem item in this.tsHairColor.Items)
				if (item is ToolStripButton && e.ClickedItem != item)
					((ToolStripButton)item).Checked = false;

			this.ListControl.SuspendLayout();
			this.colorFilter = (Guid)e.ClickedItem.Tag;
			this.ListControl.Items.Clear();
			this.LoadItems();
			this.ListControl.ResumeLayout();
		}


		static List<Guid> StandardHairColors = new List<Guid>(new Guid[] {
			new Guid(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new Guid(2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new Guid(3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
			new Guid(4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
		});

		static Guid ElderHairColor = new Guid(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

	}


}