using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimPe.Windows.Forms;
using SimPe.PackedFiles.Wrapper;
using SimPe.Packages;
using SimPe.Interfaces.Files;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;
using SimPe.Data;
using SimPe.Plugin;
using SimPe.Plugin.UI;
using SimPe.Interfaces.Scenegraph;


namespace SimPe.PackedFiles.UserInterface
{
	public partial class ClothingEditor : WrapperBaseControl
	{
		File simPackage;
		SkinReferenceTable table;
		SkinCategory selectedCategory;
		OutfitType selectedOutfit;
		SimGender genderFilter;
		Ages ageFilter;

		ClothingDatabase skins;

		/// <summary>
		/// We need an unified package browsing control!
		/// </summary>
		public ClothingDatabase ClothingFiles
		{
			get
			{
				if (this.skins == null)
					this.skins = new ClothingDatabase();
				return this.skins;
			}
		}

		public File SimPackage
		{
			get { return this.simPackage; }
			set {
				if (value == null)
					return;

				this.simPackage = value;
				AgeData ageData = AgeData.GetAgeData(this.simPackage);
				if (ageData != null)
					this.UpdateGUI(ageData);
			}
		}

		public ClothingEditor()
		{
			InitializeComponent();
			InitControl();
		}

		bool CheckState()
		{
			return this.table != null;
		}


		void RefreshClothing(SDesc sdesc)
		{
			this.SimPackage = File.LoadFromFile(sdesc.CharacterFileName);
		}

		void InitControl()
		{
			if (
				SimPe.Helper.WindowsRegistry != null &&
			 !SimPe.Helper.WindowsRegistry.HiddenMode
				)
			{
				this.btOutfitFace.Visible = false;
				this.btOutfitHead.Visible = false;
				this.btCatUnknown.Visible = false;
			}

			// categories
			this.btCatActivewear.Tag = SkinCategory.Activewear;
			this.btCatEveryday.Tag = SkinCategory.Everyday;
			this.btCatFormal.Tag = SkinCategory.Formal;
			this.btCatPJ.Tag = SkinCategory.PJ;
			this.btCatSwimwear.Tag = SkinCategory.Swimwear;
			this.btCatUndies.Tag = SkinCategory.Undies;
			this.btCatPregnant.Tag = SkinCategory.Pregnant;
			this.btCatUnknown.Tag = SkinCategory.Unknown;
			
			// outfit types
			this.btOutfitBody.Tag = OutfitType.Body;
			this.btOutfitBottom.Tag = OutfitType.Bottom;
			this.btOutfitFace.Tag = OutfitType.Face;
			this.btOutfitHead.Tag = OutfitType.Hair;
			this.btOutfitTop.Tag = OutfitType.Top;
		}

		void UpdateGUI(AgeData ageData)
		{
			this.table = new SkinReferenceTable(ageData);
			this.genderFilter = ageData.Gender;
			this.ageFilter = ageData.Age;

			//defaults
			this.selectedCategory = SkinCategory.Everyday;
			this.selectedOutfit = OutfitType.Body;

			this.btSelectPackage.Enabled = true;

			this.btCatEveryday.Checked = true;
			this.btOutfitBody.Checked = true;

			this.DisplayClothingInfo();
		
		}

		protected void DisplayClothingInfo()
		{
			if (!this.CheckState())
				return;

			this.lvTextures.Items.Clear();
			this.ilTexturePreview.Images.Clear();

			Cpf cpf = this.GetCurrentPropertySet();
			if (cpf != null)
			{
				TextureOverlayInfo info = new TextureOverlayInfo(cpf);
				this.pgMain.SelectedObject = info;

				if (this.checkBox1.Checked)
				{
					this.Cursor = Cursors.WaitCursor;

					this.BuildImageList(info);

					this.Cursor = Cursors.Default;

				}


			}

		}

		private void BuildImageList(TextureOverlayInfo info)
		{

			if (!Utility.IsNullOrEmpty(info.MaterialDefinitions))
			{
				for (int i = 0; i < info.MaterialDefinitions.Count; i++)
				{
					MaterialDefinitionInfo mmat = info.MaterialDefinitions[i];

					ListViewItem li = new ListViewItem();
					li.Text = mmat.BaseTextureName;

					Image img = this.GetTexture(mmat);
					if (img != null)
					{
						this.ilTexturePreview.Images.Add(ImageLoader.Preview(img, this.ilTexturePreview.ImageSize));
						li.ImageIndex = this.ilTexturePreview.Images.Count - 1;
					}

					this.lvTextures.Items.Add(li);
				}

			}


		}


		public override void OnCommit()
		{
			try
			{
				this.table.CommitChanges();
				this.simPackage.Save();
			}
			finally
			{
				base.OnCommit();
			}
		}

		protected Image GetTexture(MaterialDefinitionInfo mmatd)
		{
			if (mmatd.BaseTexture != null)
			{
				MipMap map = ((ImageData)mmatd.BaseTexture.Blocks[0]).LargestTexture;
				if (map != null)
					return map.Texture;
			}
			return null;
		}


		Cpf GetCurrentPropertySet()
		{
			Cpf wrapper = null;

			SkinReferenceItem item = this.table.FindItem(this.selectedCategory, this.selectedOutfit);
			if (item != null)
			{
				IPackedFileDescriptor pfd = item.FileDescriptor;
				this.pgMain.SelectedObject = pfd;

				IScenegraphFileIndexItem[] sfi = FileTable.FileIndex.FindFile(pfd, this.simPackage);
				if (Utility.IsNullOrEmpty(sfi))
				{
					IPackedFileDescriptor pfd1 = this.simPackage.FindExactFile(pfd);
					if (pfd1 != null)
					{
						FileIndexItem fii = new FileIndexItem(pfd1, this.simPackage);
						sfi = new IScenegraphFileIndexItem[] { fii };
					}
				}
				if (!Utility.IsNullOrEmpty(sfi))
				{
					wrapper = new Cpf();
					wrapper.ProcessData(sfi[0]);
				}
			}
			else
				this.pgMain.SelectedObject = null;

			return wrapper;
		}


		private void CategorySelect(object sender, EventArgs e)
		{
			ToolStripButton c = sender as ToolStripButton;
			if (c != null)
			{
				try
				{
					this.selectedCategory = (SkinCategory)c.Tag;
				}
				catch
				{
				}

				foreach (ToolStripButton tsb in this.tsCategory.Items)
					tsb.Checked = false;
				
				c.Checked = true;
			}

			this.DisplayClothingInfo();
		}

		private void OutfitSelect(object sender, EventArgs e)
		{
			ToolStripButton c = sender as ToolStripButton;
			if (c != null)
			{
				try
				{
					this.selectedOutfit = (OutfitType)c.Tag;
				}
				catch
				{
				}

				foreach (ToolStripButton tsb in this.tsOutfit.Items)
					tsb.Checked = false;

				c.Checked = true;
			}

			this.DisplayClothingInfo();
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			this.SelectPackage(sender, e);
		}

		/*
 * Select Skintone
 */
		private void SelectPackage(object sender, EventArgs e)
		{
			WaitingScreen.Wait();
			// TODO: Localize message
			WaitingScreen.UpdateMessage("Loading...");

			PackageBrowser browser = null;

			if (this.selectedOutfit != OutfitType.Hair)
				browser = new ClothingBrowser(
					this.ClothingFiles,
					this.ageFilter,
					this.genderFilter,
					this.selectedCategory,
					this.selectedOutfit
					);
			else
				browser = new HairBrowser(
				  this.ClothingFiles,
				  this.ageFilter,
				  this.genderFilter,
				  this.table.AgeData.Hairtone
				  );

			browser.FormClosed += new FormClosedEventHandler(packageBrowser_FormClosed);
			browser.Show(this);

			WaitingScreen.Stop();
		}

		void packageBrowser_FormClosed(object sender, FormClosedEventArgs e)
		{
			PackageBrowser browser = (PackageBrowser)sender;
			DialogResult result = browser.DialogResult;
			if (result == DialogResult.OK)
			{
				GenericCpfInfo selectedItem = browser.SelectedItem;
				if (selectedItem is TextureOverlayInfo)
				{
					// change in the current category and outfit
					this.table.Add(
						selectedItem.PropertySet.FileDescriptor,
						this.selectedCategory,
						this.selectedOutfit
						);

					// a few quirks...
					switch (this.selectedOutfit)
					{
						case OutfitType.Body:
							this.table.Remove(this.selectedCategory, OutfitType.Top);
							this.table.Remove(this.selectedCategory, OutfitType.Bottom);
							break;

						case OutfitType.Top:
						case OutfitType.Bottom:
							this.table.Remove(this.selectedCategory, OutfitType.Body);
							break;
					}

					this.DisplayClothingInfo();
				}

			}

		}


	}
}
