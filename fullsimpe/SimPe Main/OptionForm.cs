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
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe
{
    /// <summary>
    /// Zusammenfassung für OptionForm.
    /// </summary>
    public partial class OptionForm : System.Windows.Forms.Form
    {
        

        public OptionForm()
        {
            Application.UseWaitCursor = true;
            try
            {
                Application.DoEvents();
                //
                // Erforderlich für die Windows Form-Designerunterstützung
                //
                InitializeComponent();

                this.cbRLExt.ResourceManager = SimPe.Localization.Manager;
                this.cbRLNames.ResourceManager = SimPe.Localization.Manager;
                this.cbRLTGI.ResourceManager = SimPe.Localization.Manager;

                this.cbRLExt.Enum = typeof(SimPe.Registry.ResourceListExtensionFormats);
                this.cbRLNames.Enum = typeof(SimPe.Registry.ResourceListFormats);
                this.cbRLTGI.Enum = typeof(SimPe.Registry.ResourceListUnnamedFormats);
                this.pgPaths.SelectedObject = SimPe.PathSettings.Global;


                for (byte i = 1; i < 0x44; i++) this.cblang.Items.Add(new SimPe.PackedFiles.Wrapper.StrLanguage(i));
                SelectCategory(nbFolders, null);

                SimPe.GuiTheme[] gts = (SimPe.GuiTheme[])System.Enum.GetValues(typeof(SimPe.GuiTheme));
                foreach (SimPe.GuiTheme gt in gts) cbThemes.Items.Add(gt);
                cbThemes.SelectedIndex = 0;

                SimPe.Registry.ReportFormats[] rfs = (SimPe.Registry.ReportFormats[])System.Enum.GetValues(typeof(SimPe.Registry.ReportFormats));
                foreach (SimPe.Registry.ReportFormats rf in rfs) cbReport.Items.Add(rf);
                cbReport.SelectedIndex = 0;

                foreach (SimPe.Interfaces.ISettings settings in FileTable.SettingsRegistry.Settings)
                    this.cbCustom.Items.Add(settings);
                if (cbCustom.Items.Count > 0) cbCustom.SelectedIndex = 0;

                CreateFileTableCheckboxes();
            }
            finally { Application.UseWaitCursor = false; }
        }


        void Execute()
        {
            this.Tag = true;
            //linkLabel3.Enabled = (Helper.WindowsRegistry.EPInstalled>=1);
            tbgame.Text = PathProvider.Global[Expansions.BaseGame].InstallFolder;
            tbep1.Text = PathProvider.Global[Expansions.University].InstallFolder;
            tbep2.Text = PathProvider.Global[Expansions.Business].InstallFolder;
            //tbep1.Text = Helper.WindowsRegistry.RealEP1GamePath;
            tbsavegame.Text = PathProvider.SimSavegameFolder;
            tbdds.Text = PathProvider.Global.NvidiaDDSPath;
            this.cbdebug.Checked = Helper.WindowsRegistry.GameDebug;
            cbautobak.Checked = Helper.WindowsRegistry.AutoBackup;
            cbblur.Checked = Helper.WindowsRegistry.BlurNudity;
            cbsound.Checked = Helper.WindowsRegistry.EnableSound;
            cbwait.Checked = Helper.WindowsRegistry.WaitingScreen;
            cbow.Checked = Helper.WindowsRegistry.LoadOWFast;
            cbsilent.Checked = Helper.WindowsRegistry.Silent;
            cbcache.Checked = Helper.WindowsRegistry.UseCache;
            cbshowobjd.Checked = Helper.WindowsRegistry.ShowObjdNames;
            cbhidden.Checked = Helper.WindowsRegistry.HiddenMode;
            cbjointname.Checked = Helper.WindowsRegistry.ShowJointNames;
            tbthumb.Text = Helper.WindowsRegistry.OWThumbSize.ToString();
            tbscale.Text = Helper.WindowsRegistry.ImportExportScaleFactor.ToString();
            cbupdate.Checked = Helper.WindowsRegistry.CheckForUpdates;
            cbpkgmaint.Checked = Helper.WindowsRegistry.UsePackageMaintainer;
            cbmulti.Checked = Helper.WindowsRegistry.MultipleFiles;
            cbSimple.Checked = Helper.WindowsRegistry.SimpleResourceSelect;
            cbFirefox.Checked = Helper.WindowsRegistry.FirefoxTabbing;
            cbDeep.Checked = Helper.WindowsRegistry.DeepSimScan;
            cbSimTemp.Checked = Helper.WindowsRegistry.DeepSimTemplateScan;
            cbAsync.Checked = Helper.WindowsRegistry.AsynchronLoad;

            cbLock.Checked = Helper.WindowsRegistry.LockDocks;
            cbsplash.Checked = Helper.WindowsRegistry.ShowStartupSplash;
            cbAsyncSort.Checked = Helper.WindowsRegistry.AsynchronSort;
            cbRLTGI.SelectedValue = Helper.WindowsRegistry.ResourceListUnknownDescriptionFormat;
            cbRLNames.SelectedValue = Helper.WindowsRegistry.ResourceListFormat;
            cbRLExt.SelectedValue = Helper.WindowsRegistry.ResourceListExtensionFormat;

            this.cbLock_CheckedChanged(cbLock, null);

            this.tbUserId.Text = "0x" + Helper.HexString(Helper.WindowsRegistry.CachedUserId);
            this.tbUsername.Text = Helper.WindowsRegistry.Username;
            this.tbPassword.Text = Helper.WindowsRegistry.Password;

            this.tbep1.ReadOnly = (PathProvider.Global.EPInstalled < 1);
            this.tbep2.ReadOnly = (PathProvider.Global.EPInstalled < 2);
            this.button5.Enabled = (PathProvider.Global.EPInstalled >= 1);
            this.btNightlife.Enabled = (PathProvider.Global.EPInstalled >= 2);
            llsetep1.Enabled = button5.Enabled;
            llNightlife.Enabled = btNightlife.Enabled;

            if (((byte)Helper.WindowsRegistry.LanguageCode <= cblang.Items.Count) && ((byte)Helper.WindowsRegistry.LanguageCode > 0))
            {
                cblang.SelectedIndex = (byte)Helper.WindowsRegistry.LanguageCode - 1;
            }

            lbext.Items.Clear();
            foreach (ToolLoaderItemExt tli in ToolLoaderExt.Items) lbext.Items.Add(tli);

            //FileTable
            ArrayList folders = FileTable.DefaultFolders;
            lbfolder.Items.Clear();
            foreach (FileTableItem fti in folders)
            {
                lbfolder.Items.Add(fti, !fti.Ignore);
            }
            lbfolder.SelectedIndex = lbfolder.Items.Count > 0 ? 0 : -1;

            //Favorite Theme
            GuiTheme gt = (GuiTheme)Helper.WindowsRegistry.Layout.SelectedTheme;
            for (int i = 0; i < cbThemes.Items.Count; i++)
                if ((GuiTheme)cbThemes.Items[i] == gt)
                    cbThemes.SelectedIndex = i;

            //Report Format
            SimPe.Registry.ReportFormats rf = (SimPe.Registry.ReportFormats)Helper.WindowsRegistry.ReportFormat;
            for (int i = 0; i < cbReport.Items.Count; i++)
                if ((SimPe.Registry.ReportFormats)cbReport.Items[i] == rf)
                    cbReport.SelectedIndex = i;

            //state
            cbSimTemp.Enabled = cbDeep.Checked;

            this.Tag = null;
            btReload.Enabled = Helper.LocalMode; // When in LocalMode, default the Reload button to enabled.
            SetupFileTableCheckboxes();
            this.ShowDialog();
        }

        private void SaveOptionsClick(object sender, System.EventArgs e)
        {
            /*Helper.WindowsRegistry.SimsPath = this.tbgame.Text;
            Helper.WindowsRegistry.SimsEP1Path = this.tbep1.Text;
            Helper.WindowsRegistry.SimsEP2Path = this.tbep2.Text;
            Helper.WindowsRegistry.SimSavegameFolder = this.tbsavegame.Text;*/
            PathProvider.Global.NvidiaDDSPath = tbdds.Text;
            Helper.WindowsRegistry.LanguageCode = (Data.MetaData.Languages)cblang.SelectedIndex + 1;
            Helper.WindowsRegistry.GameDebug = cbdebug.Checked;
            Helper.WindowsRegistry.AutoBackup = cbautobak.Checked;
            //Helper.WindowsRegistry.BlurNudity = cbblur.Checked;
            Helper.WindowsRegistry.EnableSound = cbsound.Checked;
            Helper.WindowsRegistry.WaitingScreen = cbwait.Checked;
            Helper.WindowsRegistry.LoadOWFast = cbow.Checked;
            Helper.WindowsRegistry.Silent = cbsilent.Checked;
            Helper.WindowsRegistry.UseCache = cbcache.Checked;
            Helper.WindowsRegistry.ShowObjdNames = cbshowobjd.Checked;
            Helper.WindowsRegistry.HiddenMode = cbhidden.Checked;
            Helper.WindowsRegistry.ShowJointNames = cbjointname.Checked;
            Helper.WindowsRegistry.CheckForUpdates = cbupdate.Checked;
            Helper.WindowsRegistry.UsePackageMaintainer = cbpkgmaint.Checked;
            Helper.WindowsRegistry.MultipleFiles = cbmulti.Checked;
            Helper.WindowsRegistry.Layout.SelectedTheme = (byte)cbThemes.Items[cbThemes.SelectedIndex];
            Helper.WindowsRegistry.SimpleResourceSelect = cbSimple.Checked;
            Helper.WindowsRegistry.FirefoxTabbing = cbFirefox.Checked;
            Helper.WindowsRegistry.DeepSimScan = cbDeep.Checked;
            Helper.WindowsRegistry.DeepSimTemplateScan = cbSimTemp.Checked;
            Helper.WindowsRegistry.AsynchronLoad = cbAsync.Checked;
            Helper.WindowsRegistry.ReportFormat = (Registry.ReportFormats)cbReport.SelectedItem;
            Helper.WindowsRegistry.LockDocks = cbLock.Checked;
            Helper.WindowsRegistry.ShowStartupSplash = cbsplash.Checked;

            Helper.WindowsRegistry.AsynchronSort = cbAsyncSort.Checked;
            Helper.WindowsRegistry.ResourceListExtensionFormat = (Registry.ResourceListExtensionFormats)cbRLExt.SelectedValue;
            Helper.WindowsRegistry.ResourceListFormat = (Registry.ResourceListFormats)cbRLNames.SelectedValue;
            Helper.WindowsRegistry.ResourceListUnknownDescriptionFormat = (Registry.ResourceListUnnamedFormats)cbRLTGI.SelectedValue;

            Helper.WindowsRegistry.Username = tbUsername.Text;
            Helper.WindowsRegistry.Password = tbPassword.Text;
            Helper.WindowsRegistry.CachedUserId = Helper.StringToUInt32(tbUserId.Text, 0, 16);

            System.Collections.Generic.List<FileTableItem> lfti = new System.Collections.Generic.List<FileTableItem>();
            foreach (FileTableItem fti in lbfolder.Items) lfti.Add(fti);
            FileTable.StoreFoldersXml(lfti);
            try
            {
                Helper.WindowsRegistry.OWThumbSize = Convert.ToInt32(tbthumb.Text);
                Helper.WindowsRegistry.ImportExportScaleFactor = Convert.ToSingle(tbscale.Text);
            }
            catch { }



            ToolLoaderExt.Items = new ToolLoaderItemExt[0];
            foreach (ToolLoaderItemExt tli in lbext.Items) ToolLoaderExt.Add(tli); ;
            ToolLoaderExt.StoreTools();

            Helper.WindowsRegistry.Flush();

            FileTable.FileIndex.BaseFolders.Clear();
            FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;

            Close();
        }

        private void DeleteExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbext.SelectedIndex < 0) return;
            lbext.Items.Remove(lbext.Items[lbext.SelectedIndex]);
        }

        private void AddExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            AddExtTool aet = new AddExtTool();
            ToolLoaderItemExt tli = aet.Execute();

            if (tli != null) lbext.Items.Add(tli);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbgame.Text)) fbd.SelectedPath = tbgame.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbgame.Text = fbd.SelectedPath;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbsavegame.Text)) fbd.SelectedPath = tbsavegame.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbsavegame.Text = fbd.SelectedPath;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbdds.Text)) ofd.InitialDirectory = tbdds.Text;
            if (ofd.ShowDialog() == DialogResult.OK) this.tbdds.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
        }

        private void label2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbgame.Text = PathProvider.Global[Expansions.BaseGame].RealInstallFolder;
        }

        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep1.Text = PathProvider.Global[Expansions.University].RealInstallFolder;
        }

        private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbsavegame.Text = PathProvider.RealSavegamePath;
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbep1.Text)) fbd.SelectedPath = tbep1.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbep1.Text = fbd.SelectedPath;
        }

        private void ClearCaches(object sender, System.EventArgs e)
        {
            SimPe.CheckControl.ClearCache();
        }

        private void DDSChanged(object sender, System.EventArgs e)
        {
            string name = System.IO.Path.Combine(this.tbdds.Text, "nvdxt.exe");
            lldds.Visible = (!System.IO.File.Exists(name));
            lldds2.Visible = lldds.Visible;
        }

        private void LoadDDS(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "http://developer.nvidia.com/object/nv_texture_tools.html");
        }

        private void visualStyleLinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep1.Text = SimPe.PathProvider.Global[Expansions.University].RealInstallFolder;
        }

        void EnablePanel(Divelements.Navisight.NavigationButton panel)
        {
            hcFolders.Visible = (panel == nbFolders);
            hcSettings.Visible = (panel == nbSettings);
            hcTools.Visible = (panel == nbTools);
            hcFileTable.Visible = (panel == nbFileTable);
            hcSceneGraph.Visible = (panel == nbSceneGraph);
            hcPlugins.Visible = (panel == nbPlugins);
            hcIdent.Visible = (panel == nbIdent);
            hcCheck.Visible = (panel == nbCheck);
            hcCustom.Visible = (panel == nbCustom);
        }

        private void SelectCategory(object sender, System.EventArgs e)
        {
            foreach (Divelements.Navisight.NavigationButton nb in bb.Buttons)
            {
                nb.Checked = (nb == sender);

                if (nb.Checked)
                {
                    if (nb == nbFolders) EnablePanel(nbFolders);
                    else if (nb == nbSettings) EnablePanel(nbSettings);
                    else if (nb == nbTools) EnablePanel(nbTools);
                    else if (nb == nbFileTable) EnablePanel(nbFileTable);
                    else if (nb == nbSceneGraph) EnablePanel(nbSceneGraph);
                    else if (nb == nbPlugins) EnablePanel(nbPlugins);
                    else if (nb == nbIdent) EnablePanel(nbIdent);
                    else if (nb == nbCheck) EnablePanel(nbCheck);
                    else if (nb == nbCustom) EnablePanel(nbCustom);
                }
            }
        }

        private void ChangedThemeHandler(object sender, System.EventArgs e)
        {
            if (NewTheme != null) NewTheme((SimPe.GuiTheme)cbThemes.Items[cbThemes.SelectedIndex]);
        }

        private void ResetLayoutClick(object sender, System.EventArgs e)
        {
            if (ResetLayout != null) ResetLayout(this, e);
        }

        private void LockDocksClick(object sender, System.EventArgs e)
        {
            if (LockDocks != null) LockDocks(this, e);
        }

        private void UnlockDocksClick(object sender, System.EventArgs e)
        {
            if (UnlockDocks != null) UnlockDocks(this, e);
        }

        #region Events
        public event SimPe.Events.ChangedThemeEvent NewTheme;
        public event System.EventHandler ResetLayout;
        public event System.EventHandler LockDocks;
        public event System.EventHandler UnlockDocks;
        #endregion

        #region Plugins
        public Image GetImage(SimPe.Interfaces.IWrapper wrapper)
        {
            if (uids.Contains(wrapper.WrapperDescription.UID))
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png"));

            if (wrapper.Priority >= 0)
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.enabled.png"));

            return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.disabled.png"));
        }

        public void SetPanel(SimPe.Interfaces.IWrapper wrapper, TD.Eyefinder.HeaderControl pn)
        {


            if (wrapper.Priority < 0)
            {
                pn.Text = "(" + wrapper.WrapperDescription.Name + ")";
                pn.ForeColor = SystemColors.ControlDarkDark;
            }
            else
            {
                pn.Text = wrapper.WrapperDescription.Name;
                pn.ForeColor = SystemColors.ControlText;
            }
            pn.Text = "     " + pn.Text;

        }

        public Image GetShrinkImage(TD.Eyefinder.HeaderControl pn)
        {
            if (pn.Height == pn.DisplayRectangle.Top + 1)
            {
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.expand.png"));
            }
            else
            {
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.shrink.png"));
            }

        }

        public bool ThumbnailCallback()
        {
            return false;
        }


        System.Collections.ArrayList uids;
        System.Collections.ArrayList wrappers;
#if DEBUG
        const int height = 148;
#else
		const int height = 116;
#endif
        public Control BuildPanel(SimPe.Interfaces.IWrapper wrapper, ThemeManager tm, int index)
        {
            if (uids == null) uids = new ArrayList();
            if (wrappers == null) wrappers = new ArrayList();

            if (wrapper.Priority >= 0) wrapper.Priority = index + 1;
            else wrapper.Priority = -1 * (index + 1);



            const int imgwidth = 22;
            int top = 4 + index * (height + 4);
            TD.Eyefinder.HeaderControl pn = new TD.Eyefinder.HeaderControl();
            pn.Parent = cnt;
            pn.Top = top;
            pn.Left = 4;
            pn.Width = cnt.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth - 2 - 2 * pn.Left;
            pn.Height = height;
            pn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            pn.HeaderStyle = TD.Eyefinder.HeaderStyle.SubHeading;
            pn.Click += new EventHandler(pn_Click);
            pn.LostFocus += new EventHandler(pn_LostFocus);
            pn.GotFocus += new EventHandler(pn_Focused);
            pn.Enter += new EventHandler(pn_Focused);
            pn.Leave += new EventHandler(pn_LostFocus);
            pn_LostFocus(pn, null);
            SetPanel(wrapper, pn);
            pn.Tag = wrapper;
            pn.Dock = DockStyle.Top;

            wrappers.Add(pn);

            #region Author
            Label lbauthor = new Label();
            lbauthor.Parent = pn;
            lbauthor.Top = pn.DisplayRectangle.Top + 8;
            lbauthor.Left = 8;
            lbauthor.Text = "Author:";
            lbauthor.Width = 85;
            lbauthor.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Bold, cnt.Font.Unit);
            lbauthor.Height = (int)lbauthor.Font.SizeInPoints * 2;
            lbauthor.ForeColor = SystemColors.ControlDarkDark;
            lbauthor.TextAlign = ContentAlignment.TopRight;
            lbauthor.Click += new EventHandler(pn_Click);

            Label lb = new Label();
            lb.Parent = pn;
            lb.Top = lbauthor.Top;
            lb.Left = lbauthor.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperDescription.Author;
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region Version
            Label lbversion = new Label();
            lbversion.Parent = pn;
            lbversion.Top = lbauthor.Top;
            lbversion.Left = lb.Right + 16;
            lbversion.Width = lbauthor.Width;
            lbversion.Height = lbauthor.Height;
            lbversion.Text = "Version:";
            lbversion.Font = lbauthor.Font;
            lbversion.ForeColor = lbauthor.ForeColor;
            lbversion.TextAlign = lbauthor.TextAlign;
            lbversion.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbversion.Top;
            lb.Left = lbversion.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperDescription.Version.ToString();
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region FileName
            Label lbfile = new Label();
            lbfile.Parent = pn;
            lbfile.Top = lbversion.Bottom;
            lbfile.Left = lbauthor.Left;
            lbfile.Width = lbauthor.Width;
            lbfile.Height = lbauthor.Height;
            lbfile.Text = "Filename:";
            lbfile.Font = lbauthor.Font;
            lbfile.ForeColor = lbauthor.ForeColor;
            lbfile.TextAlign = lbauthor.TextAlign;
            lbfile.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbfile.Top;
            lb.Left = lbfile.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperFileName;
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region UID
            Label lbui = new Label();
            lbui.Parent = pn;
            lbui.Top = lbfile.Bottom;
            lbui.Left = lbauthor.Left;
            lbui.Width = lbauthor.Width;
            lbui.Height = lbauthor.Height;
            lbui.Text = "UID:";
            lbui.Font = lbauthor.Font;
            lbui.ForeColor = lbauthor.ForeColor;
            lbui.TextAlign = lbauthor.TextAlign;
            lbui.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbui.Top;
            lb.Left = lbui.Right + 4;
            lb.AutoSize = true;
            lb.Text = "0x" + Helper.HexString(wrapper.WrapperDescription.UID);
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region Description
            Label lbdesc = new Label();
            lbdesc.Parent = pn;
            lbdesc.Top = lbui.Bottom;
            lbdesc.Left = lbauthor.Left;
            lbdesc.Width = lbauthor.Width;
            lbdesc.Height = lbauthor.Height;
            lbdesc.Text = "Description:";
            lbdesc.Font = lbauthor.Font;
            lbdesc.ForeColor = lbauthor.ForeColor;
            lbdesc.TextAlign = lbauthor.TextAlign;
            lbdesc.Click += new EventHandler(pn_Click);

            TextBox tb = new TextBox();
            tb.Parent = pn;
            tb.Top = lbdesc.Top;
            tb.Left = lbdesc.Right + 4;
            tb.Width = pn.Width - lb.Left - imgwidth - 12;
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            tb.Text = wrapper.WrapperDescription.Description;
#if DEBUG
            tb.Text += Helper.lbr + wrapper.GetType().FullName + " " + wrapper.GetType().Assembly.FullName;
#endif
            tb.Multiline = true;
            tb.WordWrap = true;
            tb.ScrollBars = ScrollBars.Vertical;
            tb.BorderStyle = BorderStyle.None;
            tb.BackColor = pn.BackColor;

            tb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            tb.Height = pn.Height - tb.Top - 8;
            tb.ForeColor = lbauthor.ForeColor;
            tb.GotFocus += new EventHandler(tb_GotFocus);
            tb.Enter += new EventHandler(tb_GotFocus);
            tb.ReadOnly = true;
            #endregion

            PictureBox pb = null;

            if (wrapper.AllowMultipleInstances)
            {
                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = imgwidth;
                pb.Height = imgwidth;
                pb.Left = pn.Width - 2 * pb.Width - 16;
                pb.Top = pn.DisplayRectangle.Top + 4; //pn.DisplayRectangle.Top + 4 + pb.Height + 4; //pn.Height - 2*pb.Height -16;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.multienabled.png"));
                pb.Click += new EventHandler(pn_Click);
                this.toolTip1.SetToolTip(pb, "Allows Multiple instance");


                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = pn.DisplayRectangle.Top + 1;
                pb.Height = pn.DisplayRectangle.Top;
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
                pb.Left = pn.Width - 3 * pb.Width - pb.Top;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.smallmultienabled.png"));
                pb.BackColor = Color.Transparent;

                this.toolTip1.SetToolTip(pb, "Allows Multiple instance.");
            }

            if (wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper)
            {
                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = pn.DisplayRectangle.Top + 1;
                pb.Height = pn.DisplayRectangle.Top;
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
                if (wrapper.AllowMultipleInstances) pb.Left = pn.Width - 4 * pb.Width - pb.Top;
                else pb.Left = pn.Width - 3 * pb.Width - pb.Top;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png")).GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero); ;
                pb.BackColor = Color.Transparent;
                this.toolTip1.SetToolTip(pb, "This wrapper caused an Error while loading.");
            }

            PictureBox ipb = new PictureBox();
            ipb.Parent = pn;
            ipb.Left = 2;
            ipb.Top = 1;
            ipb.BackColor = Color.Transparent;
            ipb.SizeMode = PictureBoxSizeMode.StretchImage;
            if (wrapper.WrapperDescription.Icon != null)
            {
                ipb.Height = Math.Min(wrapper.WrapperDescription.Icon.Height, pn.DisplayRectangle.Top - 2);
                ipb.Width = Math.Min(wrapper.WrapperDescription.Icon.Width, pn.DisplayRectangle.Top - 2);
                ipb.Image = wrapper.WrapperDescription.Icon;
            }
            else
            {
                ipb.Height = 16;
                ipb.Width = 16;
                //				ipb.Image = FileTable.WrapperRegistry.WrapperImageList.Images[1];
            }

            PictureBox pbe = new PictureBox();
            pbe.Parent = pn;
            pbe.Width = pn.DisplayRectangle.Top + 1;
            pbe.Height = pn.DisplayRectangle.Top;
            pbe.SizeMode = PictureBoxSizeMode.CenterImage;
            pbe.Top = (pn.DisplayRectangle.Top + 1 - pbe.Height) / 2;
            pbe.Left = pn.Width - pbe.Width - pbe.Top;
            pbe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbe.Image = GetShrinkImage(pn);
            pbe.Tag = pn;
            pbe.BackColor = Color.Transparent;
            pbe.Click += new EventHandler(pb_ExpandClick);
            this.toolTip1.SetToolTip(pbe, "Collapse/Expand");

            pb = new PictureBox();
            pb.Parent = pn;
            pb.Width = imgwidth;
            pb.Height = imgwidth;
            pb.Left = pn.Width - pb.Width - 8;
            pb.Top = pn.DisplayRectangle.Top + 4; //pn.Height - pb.Height -8;
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb.Image = GetImage(wrapper);
            pb.Tag = pn;
            pb.BackColor = Color.Transparent;
            pb.Click += new EventHandler(pb_Click);
            this.toolTip1.SetToolTip(pb, "Enable/Disable");

            pb = new PictureBox();
            pb.Parent = pn;
            pb.Width = pn.DisplayRectangle.Top + 1;
            pb.Height = pn.DisplayRectangle.Top;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
            pb.Left = pn.Width - 2 * pb.Width - pb.Top;
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb.Image = GetImage(wrapper).GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            pb.BackColor = Color.Transparent;
            pb.Tag = pn;
            pb.Click += new EventHandler(pb_Click);
            this.toolTip1.SetToolTip(pb, "Enable/Disable");

            Panel pan = new Panel();
            pan.BackColor = this.cnt.BackColor;
            pan.Parent = pn;
            pan.Height = 4;
            pan.Dock = DockStyle.Bottom;

            uids.Add(wrapper.WrapperDescription.UID);
            pb_ExpandClick(pbe, null);
            return pn;
        }

        public void Execute(Icon icon)
        {
            ThemeManager tm = new ThemeManager(ThemeManager.Global.CurrentTheme);
            tm.Parent = ThemeManager.Global;

            OptionForm f = this;
            if (icon != null) f.Icon = icon;
            SimPe.Interfaces.IWrapper[] wrappers = FileTable.WrapperRegistry.AllWrappers;

            for (int ct = wrappers.Length - 1; ct >= 0; ct--)
            {
                SimPe.Interfaces.IWrapper wrapper = wrappers[ct];
                f.cnt.Controls.Add(f.BuildPanel(wrapper, tm, ct));
            }

            f.uids.Clear();
            if (f.cnt.Controls.Count > 0) f.cnt.Controls[0].Focus();

            f.Execute();

            foreach (SimPe.Interfaces.IWrapper wrapper in wrappers)
            {
                if (!(wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper))
                    Helper.WindowsRegistry.SetWrapperPriority(wrapper.WrapperDescription.UID, wrapper.Priority);
            }
        }

        private void pn_Click(object sender, EventArgs e)
        {
            if (sender is TD.Eyefinder.HeaderControl)
            {
                TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
                pn.Focus();
            }
            else if (sender is Control)
            {
                TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)((Control)sender).Parent;
                pn.Focus();
            }
        }

        TD.Eyefinder.HeaderControl lastpn;
        private void pn_Focused(object sender, EventArgs e)
        {
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
            pn.BackColor = SystemColors.Window;
            pn.Font = new Font(pn.Font.Name, pn.Font.Size, FontStyle.Bold, pn.Font.Unit);

            btpup.Enabled = wrappers[0] != pn;
            btpdown.Enabled = wrappers[wrappers.Count - 1] != pn;

            lastpn = pn;
            if (pn.Controls.Count > 9) pn.Controls[9].BackColor = pn.BackColor;
        }

        private void pn_LostFocus(object sender, EventArgs e)
        {
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
            pn.BackColor = SystemColors.ControlLight;
            pn.Font = new Font(pn.Font.Name, pn.Font.Size, FontStyle.Regular, pn.Font.Unit);
            if (pn.Controls.Count > 9) pn.Controls[9].BackColor = pn.BackColor;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;
            SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;

            wrapper.Priority *= -1;
            SetPanel(wrapper, pn);

            Image i = this.GetImage(wrapper);

            SetBackgroundColor(pn.Controls[pn.Controls.Count - 2], i, true);
            SetBackgroundColor(pn.Controls[pn.Controls.Count - 3], i, false);
        }

        int FindPanelIndex(TD.Eyefinder.HeaderControl pn)
        {
            for (int i = 0; i < wrappers.Count; i++)
            {
                if (wrappers[i] == pn) return i;
            }

            return -1;
        }

        void Exchange(int index, int o)
        {
            TD.Eyefinder.HeaderControl pn1 = (TD.Eyefinder.HeaderControl)wrappers[index];
            TD.Eyefinder.HeaderControl pn2 = (TD.Eyefinder.HeaderControl)wrappers[index + o];

            int d = pn1.Top;
            pn1.Top = pn2.Top;
            pn2.Top = d;
            SimPe.Interfaces.IWrapper w1 = (SimPe.Interfaces.IWrapper)pn1.Tag;
            SimPe.Interfaces.IWrapper w2 = (SimPe.Interfaces.IWrapper)pn2.Tag;

            int p1 = w1.Priority;
            int p2 = w2.Priority;

            if (p1 >= 0) w1.Priority = Math.Abs(p2);
            else w1.Priority = -1 * Math.Abs(p2);

            if (p2 >= 0) w2.Priority = Math.Abs(p1);
            else w2.Priority = -1 * Math.Abs(p1);

            wrappers[index] = pn2;
            wrappers[index + o] = pn1;

            cnt.Controls.SetChildIndex(pn1, index + o);
        }

        private void btpup_Click(object sender, System.EventArgs e)
        {
            if (lastpn == null) return;

            int index = FindPanelIndex(lastpn);
            if (index < 1) return;

            Exchange(index, -1);

            lastpn.Focus();
        }

        private void btpdown_Click(object sender, System.EventArgs e)
        {
            if (lastpn == null) return;

            int index = FindPanelIndex(lastpn);
            if (index < 0) return;
            if (index >= wrappers.Count - 1) return;

            Exchange(index, 1);

            lastpn.Focus();
        }

        void SetBackgroundColor(object sender, Image i, bool small)
        {
            PictureBox pb = (PictureBox)sender;
            if (small) pb.Image = i.GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            else pb.Image = i;
            /*if (wrapper.Priority<0) pb.BackColor = Color.FromArgb(0x70FF5B60);
            else pb.BackColor = Color.FromArgb(0x7087D300);*/
        }

        private void pb_ExpandClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;

            if (pn.Height == pn.DisplayRectangle.Top + 1)
            {
                pn.Controls[pn.Controls.Count - 1].Visible = true;
                pn.Height = height;
            }
            else
            {
                pn.Controls[pn.Controls.Count - 1].Visible = false;
                pn.Height = pn.DisplayRectangle.Top + 1;
            }


            pb.Image = GetShrinkImage(pn);
            SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;
            //SetBackgroundColor(pb, wrapper);
        }


        private void tb_GotFocus(object sender, EventArgs e)
        {
            if (lastpn != null)
            {
                this.pn_Focused(lastpn, null);
            }
        }

        #endregion

        private void cbmulti_CheckedChanged(object sender, System.EventArgs e)
        {
            cbFirefox.Enabled = cbmulti.Checked;
            cbFirefox.Refresh();
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            Helper.WindowsRegistry.ClearRecentFileList();
        }

        private void tbPassword_Leave(object sender, System.EventArgs e)
        {
            tbUserId_TextChanged(null, null);
            if (this.Tag != null) return;

            uint guid = Sims.GUID.GUIDGetterForm.GetUserGuid(tbUsername.Text, tbPassword.Text);
            uint uid = UserVerification.GenerateUserId(guid, tbUsername.Text, tbPassword.Text);

            tbUserId.Text = "0x" + Helper.HexString(uid);
            tbUserId_TextChanged(null, null);
        }

        private void linkLabel3_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbPassword_Leave(null, null);
        }

        private void tbUserId_TextChanged(object sender, System.EventArgs e)
        {
            uint i = Helper.StringToUInt32(tbUserId.Text, 0, 16);
            cbValid.Checked = UserVerification.ValidUserId(i, tbUsername.Text, tbPassword.Text);
        }

        private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbUserId.Text = "0x" + Helper.HexString(0);
        }

        private void llNightlife_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep2.Text = PathProvider.Global[Expansions.Nightlife].RealInstallFolder;
        }

        private void btNightlife_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbep2.Text)) fbd.SelectedPath = tbep2.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbep2.Text = fbd.SelectedPath;
        }

        private void cbblur_CheckedChanged(object sender, System.EventArgs e)
        {
            Helper.WindowsRegistry.BlurNudity = cbblur.Checked;
            cbblur.Checked = Helper.WindowsRegistry.BlurNudity;
        }

        private void cbDeep_CheckedChanged(object sender, System.EventArgs e)
        {
            cbSimTemp.Enabled = cbDeep.Checked;
        }

        #region Simpe FileTable Settings
        private Dictionary<string, CheckBox> lcb = null;
        private CheckBox CreateFileTableCheckbox(ref int left, ref int top, string key, string text)
        {
            if (left + cbIncCep.Width > cbIncCep.Parent.Width - cbIncCep.Left)
            {
                left = cbIncCep.Left;
                top += cbIncCep.Height - 2;
            }

            CheckBox cb = new CheckBox();

            cb.SetBounds(left, top, cbIncCep.Width, cbIncCep.Height);
            left += cb.Width + 4;

            lcb.Add(key, cb);
            cb.Text = text;
            cb.CheckedChanged += new System.EventHandler(this.cbIncNightlife_CheckedChanged);

            cb.Visible = true;
            cb.Parent = cbIncCep.Parent;
            cb.Font = cbIncCep.Font;

            return cb;
        }
        private void CreateFileTableCheckboxes()
        {
            this.Enabled = false;
            try
            {
                lcb = new Dictionary<string, CheckBox>();

                int cwd = cbIncCep.Parent.Width - 2 * cbIncCep.Left + 4;
                cbIncCep.Width = (cwd / 4) - 4;
                int left = cbIncCep.Right + 4;
                int top = cbIncCep.Top;

                CreateFileTableCheckbox(ref left, ref top, "cbIncGraphics", SimPe.Localization.GetString("FileTableIncludeGraphics"));

                foreach (ExpansionItem ei in PathProvider.Global.Expansions)
                {
                    CheckBox cb = CreateFileTableCheckbox(ref left, ref top, ei.NameShort,
                        SimPe.Localization.GetString("FileTableSectionInclude").Replace("{what}", ei.NameShort));
                    cb.Tag = ei;

                    if (!ei.Exists)
                    {
                        cb.CheckState = CheckState.Unchecked;
                        cb.Enabled = false;
                    }
                }

                top += cbIncCep.Height + 2;
                groupBox8.Height = top;
                groupBox9.Top = groupBox8.Bottom + 8;
                groupBox9.Height = hcFileTable.Height - groupBox9.Top - 8;
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }




        private void btReload_Click(object sender, System.EventArgs e)
        {
            this.Enabled = false;
            try
            {
                Helper.LocalMode = btReload.Enabled = false; // We're no longer in LocalMode after a filetable reload
                System.Collections.Generic.List<FileTableItem> lfti = new System.Collections.Generic.List<FileTableItem>();
                foreach (FileTableItem fti in lbfolder.Items) lfti.Add(fti);
                FileTable.StoreFoldersXml(lfti);
                FileTable.Reload();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        private void linkLabel6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            try
            {
                FileTable.BuildFolderXml();
                FileTable.FileIndex.BaseFolders.Clear();
                FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;

                RebuildFileTableList();

                btReload.Enabled = true;
                SetupFileTableCheckboxes();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        void RebuildFileTableList()
        {
            lbfolder.Items.Clear();
            foreach (FileTableItem fti in FileTable.FileIndex.BaseFolders)
            {
                lbfolder.Items.Add(fti, !fti.Ignore);
            }
        }


        private static bool isCEP(FileTableItem fti)
        {
            if (fti.IsFile)
            {
                if (Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.GMND_PACKAGE)
                    || Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.MMAT_PACKAGE))
                    return true;
            }
            else
            {
                if (fti.Type.AsExpansions == Expansions.Custom)
                {
                    if (Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.ZCEP_FOLDER))
                        return true;
                }
                else
                {
                    if (Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.CTLG_FOLDER))
                        return true;
                }
            }
            return false;
        }

        private bool IsFtiGraphic(FileTableItem fti)
        {
            ExpansionItem ei = PathProvider.Global[fti.Type.AsExpansions];
            if (ei == null || PathProvider.Nil.Equals(ei)) return false;
            CheckBox cb = lcb[ei.NameShort];
            if (cb == null) return false;
            if (cb.CheckState == CheckState.Unchecked) return false;

            string cfn = Helper.CompareableFileName(fti.Name);
            return cfn.EndsWith("\\3d") || cfn.EndsWith("\\sims3d") || cfn.EndsWith("\\skins") ||
                cfn.EndsWith("\\materials") || cfn.EndsWith("\\patterns");
        }

        private bool IsEP(FileTableItem fti, FileTableItemType epver)
        {
            string cfn = Helper.CompareableFileName(fti.Name);
            bool isFtiGraphic = cfn.EndsWith("\\3d") || cfn.EndsWith("\\sims3d") || cfn.EndsWith("\\skins") ||
                cfn.EndsWith("\\materials") || cfn.EndsWith("\\patterns");
            bool state = fti.Type == epver;

            if (isFtiGraphic)
            {
                ExpansionItem ei = PathProvider.Global[fti.Type.AsExpansions];
                if (ei == null || PathProvider.Nil.Equals(ei)) return state;
                CheckBox cb = lcb["cbIncGraphics"];
                if (cb == null) return state;
                if (cb.CheckState == CheckState.Unchecked) return false;
            }
            return state;
        }

        private bool IsMatch(CheckBox cb, FileTableItem fti, FileTableItemType epver)
        {
            if (isCEP(fti)) return cb == this.cbIncCep;
            if (cb == lcb["cbIncGraphics"]) return IsFtiGraphic(fti);
            return IsEP(fti, epver);
        }

        private void SetupFileTableCheckboxes(CheckBox cb, FileTableItemType epver)
        {
            if (this.cbIncCep.Tag != null) return;

            int found = 0;
            int ignored = 0;

            foreach (FileTableItem fti in lbfolder.Items)
            {
                if (IsMatch(cb, fti, epver))
                {
                    found++;
                    if (fti.Ignore) ignored++;
                }
            }

            this.cbIncCep.Tag = true;
            cb.CheckState = ignored == 0 ? CheckState.Checked : ignored == found ? CheckState.Unchecked : CheckState.Indeterminate;
            this.cbIncCep.Tag = null;
        }

        private void SetupFileTableCheckboxes()
        {
            SetupFileTableCheckboxes(this.cbIncCep, null);
            foreach (CheckBox cb in lcb.Values)
            {
                ExpansionItem ei = cb.Tag as ExpansionItem;
                if (ei != null) SetupFileTableCheckboxes(cb, ei.Expansion);
            }
            SetupFileTableCheckboxes(lcb["cbIncGraphics"], null); // Must be last as refs back to expansion CBs
        }

        private void lbfolder_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (this.Tag != null) return;
            if (lbfolder.SelectedItem == null) return;

            this.Enabled = false;
            try
            {
                ((FileTableItem)lbfolder.SelectedItem).Ignore = e.NewValue != CheckState.Checked;
                btReload.Enabled = true;
                SetupFileTableCheckboxes();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }


        private void lbfolder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btdn.Enabled = lbfolder.SelectedIndex < lbfolder.Items.Count - 1;
            btup.Enabled = lbfolder.SelectedIndex > 0;
        }

        private void btup_Click(object sender, System.EventArgs e)
        {
            if (lbfolder.SelectedIndex < 1) return;
            this.Enabled = false;
            try
            {
                object o = lbfolder.Items[lbfolder.SelectedIndex - 1];
                lbfolder.Items[lbfolder.SelectedIndex - 1] = lbfolder.Items[lbfolder.SelectedIndex];
                lbfolder.Items[lbfolder.SelectedIndex] = o;

                bool sel = lbfolder.GetItemChecked(lbfolder.SelectedIndex - 1);
                lbfolder.SetItemChecked(lbfolder.SelectedIndex - 1, lbfolder.GetItemChecked(lbfolder.SelectedIndex));
                lbfolder.SetItemChecked(lbfolder.SelectedIndex, sel);

                lbfolder.SelectedIndex--;
                this.btReload.Enabled = true;
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        private void btdn_Click(object sender, System.EventArgs e)
        {
            if (lbfolder.SelectedIndex > lbfolder.Items.Count - 2) return;
            this.Enabled = false;
            try
            {
                object o = lbfolder.Items[lbfolder.SelectedIndex + 1];
                lbfolder.Items[lbfolder.SelectedIndex + 1] = lbfolder.Items[lbfolder.SelectedIndex];
                lbfolder.Items[lbfolder.SelectedIndex] = o;

                bool sel = lbfolder.GetItemChecked(lbfolder.SelectedIndex + 1);
                lbfolder.SetItemChecked(lbfolder.SelectedIndex + 1, lbfolder.GetItemChecked(lbfolder.SelectedIndex));
                lbfolder.SetItemChecked(lbfolder.SelectedIndex, sel);

                lbfolder.SelectedIndex++;
                this.btReload.Enabled = true;
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }


        void ChangeFileTable(CheckBox cb, FileTableItemType epver)
        {
            bool firstobjpkg = true;
            this.cbIncCep.Tag = true;
            for (int i = 0; i < lbfolder.Items.Count; i++)
            {
                FileTableItem fti = (FileTableItem)lbfolder.Items[i];

                if (IsMatch(cb, fti, epver))
                    lbfolder.SetItemChecked(i, cb.CheckState != CheckState.Unchecked);
                fti.Ignore = !lbfolder.GetItemChecked(i);

                #region I have no idea what this section of code does
                ExpansionItem ei = null;
                bool fullobj = true;
                int thisepver = FileTableItem.GetEPVersion(fti.Type);
                if (thisepver > 0)
                {
                    ei = PathProvider.Global.GetExpansion(thisepver);
                    fullobj = ei.Flag.FullObjectsPackage;
                }
                if (fti.Exists && !fti.Ignore && fullobj && (Helper.CompareableFileName(fti.Name).EndsWith("\\objects")))
                {
                    if (firstobjpkg)
                    {
                        firstobjpkg = false;
                        fti.EpVersion = -1;
                    }
                    else
                    {
                        fti.EpVersion = FileTableItem.GetEPVersion(fti.Type);
                    }

                    if (FileTableItem.GetEPVersion(fti.Type) == PathProvider.Global.GameVersion)
                        fti.EpVersion = FileTableItem.GetEPVersion(fti.Type);

                    lbfolder.Items[i] = fti;
                }
                #endregion
            }
            this.cbIncCep.Tag = null;
        }

        private void cbIncNightlife_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.cbIncCep.Tag != null) return;
            this.Enabled = false;
            try
            {
                CheckBox cb = (CheckBox)sender;

                this.Tag = true;

                btReload.Enabled = true;
                if (cb == this.cbIncCep) ChangeFileTable(cb, null);
                else if (cb == lcb["cbIncGraphics"]) ChangeFileTable(cb, null);
                else
                {
                    #region FileTableSimpleSelectUseGroups
                    ExpansionItem ei = cb.Tag as ExpansionItem;
                    if (cb.Checked && Helper.WindowsRegistry.FileTableSimpleSelectUseGroups)
                    {
                        foreach (Control c in groupBox8.Controls)
                        {
                            CheckBox cbs = c as CheckBox;
                            if (cbs != null)
                            {
                                ExpansionItem eis = cbs.Tag as ExpansionItem;
                                if (eis != null)
                                    if (cbs.Checked && !ei.ShareOneGroup(eis)) cbs.Checked = false;
                            }
                        } //foreach
                    }
                    #endregion
                    ChangeFileTable(cb, ei.Expansion);
                }

                this.Tag = null;
                SetupFileTableCheckboxes();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        private void lladddown_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            try
            {
                FileTableItem fti = new FileTableItem("Downloads", true, false, -1);
                fti.Name = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Downloads");
                fti.Type = FileTablePaths.SaveGameFolder;
                lbfolder.Items.Insert(0, fti);
                this.btReload.Enabled = true;
                SetupFileTableCheckboxes();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        private void lldel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbfolder.SelectedIndex < 0) return;
            this.Enabled = false;
            try
            {
                lbfolder.Items.RemoveAt(lbfolder.SelectedIndex);
                this.btReload.Enabled = true;
                SetupFileTableCheckboxes();
            }
            finally { Application.DoEvents(); this.Enabled = true; }
        }

        private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            FileTableItem fti = FileTableItemForm.Execute();
            if (fti != null)
            {
                this.Enabled = false;
                try
                {
                    lbfolder.Items.Insert(0, fti);
                    this.btReload.Enabled = true;
                    SetupFileTableCheckboxes();
                }
                finally { Application.DoEvents(); this.Enabled = true; }
            }
        }

        private void llchg_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbfolder.SelectedItem != null)
                if (FileTableItemForm.Execute((FileTableItem)lbfolder.SelectedItem))
                {
                    this.Enabled = false;
                    try
                    {
                        lbfolder.Items[lbfolder.SelectedIndex] = (FileTableItem)lbfolder.SelectedItem;
                        this.btReload.Enabled = true;
                        SetupFileTableCheckboxes();
                    }
                    finally { Application.DoEvents(); this.Enabled = true; }
                }
        }
        #endregion

        private void cbLock_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked) this.LockDocksClick(sender, e);
            else this.UnlockDocksClick(sender, e);
        }

        private void checkControl1_FixedFileTable(object sender, System.EventArgs e)
        {
            RebuildFileTableList();
        }

        private void cbCustom_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.pgcustom.SelectedObject = cbCustom.SelectedItem;
        }

        void cbautobak_CheckedChanged(object sender, EventArgs e)
        {
            if (cbautobak.CheckState == CheckState.Checked && Helper.WindowsRegistry.AutoBackup == false)
                MessageBox.Show(Localization.GetString("cbautobak_CheckedChanged"), this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        class MyPropertyGrid : PropertyGrid
        {

        }
    }
}
