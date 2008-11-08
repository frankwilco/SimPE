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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin.Scanner;
using SimPe.Plugin.Scanner;

namespace SimPe.Plugin
{
    /// <summary>
    /// Zusammenfassung für ScannerForm.
    /// </summary>
    internal class ScannerForm : System.Windows.Forms.Form
    {
        #region Windows Form Designer generated code
        private System.Windows.Forms.Button btclear;
        private System.Windows.Forms.TabPage tbcache;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btscan;
        private System.Windows.Forms.TabPage tbidentify;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbid;
        private System.Windows.Forms.ListBox lbscandebug;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbflname;
        private System.Windows.Forms.ComboBox lbprop;
        private Skybound.VisualStyles.VisualStyleLinkLabel llSave;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.CheckBox cbrec;
        private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cbfolder;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbscanners;
        private System.Windows.Forms.CheckedListBox lbscanners;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList ilist;
        private System.Windows.Forms.PictureBox thumb;
        private System.Windows.Forms.GroupBox gbinfo;
        private Skybound.VisualStyles.VisualStyleLinkLabel llopen;
        private System.Windows.Forms.CheckBox cbenable;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.TabPage tboperations;
        private System.Windows.Forms.Panel pnop;
        private ToolTip toolTip1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;
        #endregion

        /// <summary>
        /// Create a new Instance
        /// </summary>
        public ScannerForm()
        {
            //
            // Erforderlich für die Windows Form-Designerunterstützung
            //
            InitializeComponent();



            //hide the Identifier Tab in non Hiden Mode
            if (!Helper.WindowsRegistry.HiddenMode)
            {
                this.tabControl1.TabPages.Remove(this.tbidentify);
                this.tabControl1.TabIndex = 0;
            }

            //load the Group Cache
            SimPe.Plugin.ScenegraphWrapperFactory.LoadGroupCache();

            this.cbfolder.SelectedIndex = 0;

            cachefile = new SimPe.Cache.PackageCacheFile();
            try
            {
                cachefile.Load(SimPe.Cache.PackageCacheFile.CacheFileName);
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("Unable to reload the Cache File.", ex);
            }




            //display the list of identifiers
            foreach (IIdentifier id in ScannerRegistry.Global.Identifiers)
            {
                lbid.Items.Add(id.GetType().Name + " (version=" + id.Version.ToString() + ", index=" + id.Index.ToString() + ")");
            }

            //add the scanners to the Selection and show the Scanner Controls (if available)
            SimPe.Plugin.Scanner.AbstractScanner.UpdateList finishcallback = new SimPe.Plugin.Scanner.AbstractScanner.UpdateList(this.UpdateList);
            ArrayList uids = new ArrayList();
            foreach (IScanner i in ScannerRegistry.Global.Scanners)
            {
                string name = i.GetType().Name + " (version=" + i.Version.ToString() + ", uid=0x" + Helper.HexString(i.Uid) + ", index=" + i.Index.ToString() + ")";
                if (!uids.Contains(i.Uid))
                {
                    if (!i.OnTop) lbscanners.Items.Add(i, i.IsActiveByDefault);
                    else
                    {
                        lbscanners.Items.Insert(0, i);
                        lbscanners.SetItemChecked(0, i.IsActiveByDefault);
                    }
                    ShowControls(i);
                    i.SetFinishCallback(finishcallback);

                    uids.Add(i.Uid);
                }
                else
                {
                    name = "--- " + name;
                }

                this.lbscandebug.Items.Add(name);
            }

            pnop.Enabled = false;
            sorter = new ColumnSorter();
            lv.ListViewItemSorter = sorter;

            llSave.Left = lv.Right - llSave.Width;
        }

        SimPe.Cache.PackageCacheFile cachefile;

        string flname;
        string folder;
        string errorlog;
        bool cachechg;
        ColumnSorter sorter;
        int controltop = 0;
        ScannerItem lastitem;

        public string FileName
        {
            get { return flname; }
        }

        /// <summary>
        /// Die verwendeten Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Display a control on the Panel
        /// </summary>
        /// <param name="ctrl">The control you want to show</param>
        /// <param name="indent">should the control be indented?</param>
        /// <param name="space">should we add an additional 8 Pixels to the controltop</param>
        void ShowControl(System.Windows.Forms.Control ctrl, bool indent, bool space)
        {
            ctrl.Parent = this.pnop;

            if (indent) ctrl.Left = 16;
            else ctrl.Left = 0;

            if (ctrl.GetType() == typeof(Panel))
            {
                ctrl.Width = pnop.Width - ctrl.Left;
                //this.visualStyleProvider1.SetVisualStyleSupport(ctrl, true);
            }

            ctrl.Top = controltop;
            controltop += ctrl.Height;
            if (space) controltop += 8;

            ctrl.Visible = true;
        }

        /// <summary>
        /// Display the Controls of a Scanner
        /// </summary>
        /// <param name="scanner"></param>
        void ShowControls(IScanner scanner)
        {
            System.Windows.Forms.Control ctrl = scanner.OperationControl;
            if (ctrl == null) return;

            Label lb = new Label();
            lb.AutoSize = true;
            lb.Text = scanner.ToString() + ":";
            lb.Font = new Font(Font.Name, Font.Size, FontStyle.Bold);
            lb.ForeColor = this.gbinfo.ForeColor;
            //this.visualStyleProvider1.SetVisualStyleSupport(lb, true);

            Panel pn = new Panel();
            pn.Width = pnop.Width - 20;
            pn.Height = 1;
            pn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            pn.BackColor = Color.FromArgb(0x77, lb.ForeColor);

            ShowControl(lb, false, false);
            ShowControl(pn, false, true);
            ShowControl(ctrl, true, true);

            controltop += 16;
        }

        /// <summary>
        /// Returns the last selected Scanner Item (can be null)
        /// </summary>
        internal ScannerItem SelectedScannerItem
        {
            get { return lastitem; }
        }

        /// <summary>
        /// Displays the Information about this Scanenr Item
        /// </summary>
        /// <param name="si"></param>
        void ShowInfo(ScannerItem si, ListViewItem lvi)
        {
            if (si == null) return;

            this.cbenable.Tag = true;
            try
            {
                this.thumb.Image = si.PackageCacheItem.Thumbnail;
                this.cbenable.Checked = si.PackageCacheItem.Enabled;
                this.lbname.Text = si.PackageCacheItem.Name;
                this.lbtype.Text = si.PackageCacheItem.Type.ToString();

                tbflname.Text = si.FileName;
                if (tbflname.Text.Length > 0) tbflname.SelectionStart = tbflname.Text.Length - 1;

                lbname.ForeColor = lvi.ForeColor;
                lbtype.ForeColor = lvi.ForeColor;

                lbprop.Items.Clear();
                if (System.IO.File.Exists(si.FileName))
                {
                    string mod = " Modification Date: ";
                    mod += System.IO.File.GetLastWriteTime(si.FileName).ToShortDateString() + " ";
                    mod += System.IO.File.GetLastWriteTime(si.FileName).ToLongTimeString();
                    lbprop.Items.Add(mod);
                }
                for (int i = 3; i < lv.Columns.Count; i++)
                {
                    if (lvi.SubItems[i].Text.Trim() != "")
                        lbprop.Items.Add(lv.Columns[i].Text + ": " + lvi.SubItems[i].Text);
                }
            }
            finally
            {
                this.cbenable.Tag = null;
            }
        }

        private void Scan(string folder, bool rec, ScannerCollection usedscanners)
        {

            //scan all Files
            pb.Value = 0;
            string[] files = System.IO.Directory.GetFiles(folder, "*.package");
            string[] dfiles = System.IO.Directory.GetFiles(folder, "*.simpedis");
            string[] dofiles = System.IO.Directory.GetFiles(folder, "*.packagedisabled");
            string[] tfiles = System.IO.Directory.GetFiles(folder, "*.Sims2Tmp");

            int ct = files.Length + dfiles.Length + dofiles.Length + tfiles.Length;
            Scan(files, true, 0, ct, usedscanners);
            Scan(dfiles, false, files.Length, ct, usedscanners);
            Scan(dofiles, false, files.Length + dfiles.Length, ct, usedscanners);
            Scan(tfiles, false, files.Length + dfiles.Length + dofiles.Length, ct, usedscanners);
            pb.Value = 0;

            //issue a recursive Scan
            if (rec)
            {
                string[] dirs = System.IO.Directory.GetDirectories(folder, "*");
                foreach (string dir in dirs) Scan(dir, true, usedscanners);
            }

        }

        /// <summary>
        /// Scan for all Files and display the Result
        /// </summary>
        /// <param name="files"></param>
        /// <param name="enabled"></param>
        /// <param name="pboffset"></param>
        /// <param name="count"></param>
        void Scan(string[] files, bool enabled, int pboffset, int count, ScannerCollection usedscanners)
        {
            int ct = pboffset;
            foreach (string file in files)
            {
                pb.Value = Math.Max(Math.Min(((ct++) * pb.Maximum) / count, pb.Maximum), pb.Minimum);
                Application.DoEvents();
                try
                {
                    //Load the Item from the cache (if possible)
                    ScannerItem si = cachefile.LoadItem(file);
                    si.PackageCacheItem.Enabled = enabled;

                    if (si.PackageCacheItem.Thumbnail != null) { if (WaitingScreen.Running) WaitingScreen.Update(si.PackageCacheItem.Thumbnail, si.PackageCacheItem.Name); }
                    else { if (WaitingScreen.Running) WaitingScreen.UpdateMessage(si.PackageCacheItem.Name); }

                    //determin Type
                    SimPe.Cache.PackageType pt = si.PackageCacheItem.Type;
                    foreach (IIdentifier id in ScannerRegistry.Global.Identifiers)
                    {
                        if ((si.PackageCacheItem.Type != SimPe.Cache.PackageType.Unknown) && (si.PackageCacheItem.Type != SimPe.Cache.PackageType.Undefined))
                            break;


                        if ((si.PackageCacheItem.Type == SimPe.Cache.PackageType.Unknown) || (si.PackageCacheItem.Type == SimPe.Cache.PackageType.Undefined))
                            si.PackageCacheItem.Type = id.GetType(si.Package);
                    }

                    if (pt != si.PackageCacheItem.Type) cachechg = true;

                    //setup the ListView Item
                    ListViewItem lvi = new ListViewItem();
                    si.ListViewItem = lvi;
                    lvi.Text = System.IO.Path.GetFileNameWithoutExtension(si.FileName);
                    lvi.SubItems.Add(si.PackageCacheItem.Enabled.ToString());
                    lvi.SubItems.Add(si.PackageCacheItem.Type.ToString());
                    lvi.Tag = si;
                    if (!si.PackageCacheItem.Enabled) lvi.ForeColor = Color.Gray;

                    //run file through available scanners
                    foreach (IScanner s in usedscanners)
                    {
                        SimPe.Cache.PackageState ps = si.PackageCacheItem.FindState(s.Uid, true);
                        if (ps.State == SimPe.Cache.TriState.Null)
                        {
                            s.ScanPackage(si, ps, lvi);
                            if (ps.State != SimPe.Cache.TriState.Null) cachechg = true;
                        }
                        else s.UpdateState(si, ps, lvi);
                    }

                    lv.Items.Add(lvi);



                    Application.DoEvents();
                }
                catch (Exception ex)
                {
                    /*if (Helper.DebugMode) 
                    {
                        Helper.ExceptionMessage("", ex);
                    } 
                    else 
                    {*/
                    errorlog += file + ": " + ex.Message + Helper.lbr + "----------------------------------------" + Helper.lbr;
                    //}
                }
            } //foreach			
        }

        void UpdateList(bool savecache, bool rescan)
        {
            if (Helper.WindowsRegistry.UseCache && savecache) cachefile.Save();
            if (rescan) Scan(null, (System.Windows.Forms.LinkLabelLinkClickedEventArgs)null);
            else SelectItem(lv, null);
        }

        #region Vom Windows Form-Designer generierter Code
        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerForm));
            this.cbfolder = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new Skybound.VisualStyles.VisualStyleLinkLabel();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ilist = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbscanners = new System.Windows.Forms.TabPage();
            this.btscan = new System.Windows.Forms.Button();
            this.lbscanners = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbrec = new System.Windows.Forms.CheckBox();
            this.tboperations = new System.Windows.Forms.TabPage();
            this.pnop = new System.Windows.Forms.Panel();
            this.tbcache = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.tbidentify = new System.Windows.Forms.TabPage();
            this.lbscandebug = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.lbprop = new System.Windows.Forms.ComboBox();
            this.tbflname = new System.Windows.Forms.TextBox();
            this.cbenable = new System.Windows.Forms.CheckBox();
            this.lbtype = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.llopen = new Skybound.VisualStyles.VisualStyleLinkLabel();
            this.thumb = new System.Windows.Forms.PictureBox();
            this.llSave = new Skybound.VisualStyles.VisualStyleLinkLabel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tbscanners.SuspendLayout();
            this.tboperations.SuspendLayout();
            this.tbcache.SuspendLayout();
            this.tbidentify.SuspendLayout();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumb)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfolder
            // 
            this.cbfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbfolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfolder.Items.AddRange(new object[] {
            "Download Folder",
            "Teleport Folder",
            "Neighborhoods Folder",
            "Bodyshop Sim Templates Folder",
            "..."});
            this.cbfolder.Location = new System.Drawing.Point(11, 19);
            this.cbfolder.Name = "cbfolder";
            this.cbfolder.Size = new System.Drawing.Size(770, 24);
            this.cbfolder.TabIndex = 1;
            this.cbfolder.SelectedIndexChanged += new System.EventHandler(this.SelectFolder);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(742, 46);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 17);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "scan";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Scan);
            // 
            // fbd
            // 
            this.fbd.ShowNewFolderButton = false;
            // 
            // pb
            // 
            this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pb.Location = new System.Drawing.Point(0, 445);
            this.pb.Maximum = 1000;
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(792, 19);
            this.pb.TabIndex = 7;
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.LargeImageList = this.ilist;
            this.lv.Location = new System.Drawing.Point(11, 78);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(770, 103);
            this.lv.TabIndex = 3;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
            this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortList);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 177;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Enabled";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 79;
            // 
            // ilist
            // 
            this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ilist.ImageSize = new System.Drawing.Size(48, 48);
            this.ilist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbscanners);
            this.tabControl1.Controls.Add(this.tboperations);
            this.tabControl1.Controls.Add(this.tbcache);
            this.tabControl1.Controls.Add(this.tbidentify);
            this.tabControl1.Location = new System.Drawing.Point(11, 196);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(295, 243);
            this.tabControl1.TabIndex = 4;
            // 
            // tbscanners
            // 
            this.tbscanners.Controls.Add(this.lbscanners);
            this.tbscanners.Controls.Add(this.label1);
            this.tbscanners.Location = new System.Drawing.Point(4, 25);
            this.tbscanners.Name = "tbscanners";
            this.tbscanners.Size = new System.Drawing.Size(287, 214);
            this.tbscanners.TabIndex = 0;
            this.tbscanners.Text = "Scanner Settings";
            // 
            // btscan
            // 
            this.btscan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btscan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btscan.Location = new System.Drawing.Point(312, 411);
            this.btscan.Name = "btscan";
            this.btscan.Size = new System.Drawing.Size(96, 28);
            this.btscan.TabIndex = 6;
            this.btscan.Text = "Scan";
            this.btscan.Click += new System.EventHandler(this.Scan);
            // 
            // lbscanners
            // 
            this.lbscanners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbscanners.CheckOnClick = true;
            this.lbscanners.HorizontalScrollbar = true;
            this.lbscanners.Location = new System.Drawing.Point(14, 39);
            this.lbscanners.Name = "lbscanners";
            this.lbscanners.Size = new System.Drawing.Size(259, 157);
            this.lbscanners.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "active Scanners:";
            // 
            // cbrec
            // 
            this.cbrec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbrec.AutoSize = true;
            this.cbrec.Location = new System.Drawing.Point(414, 416);
            this.cbrec.Name = "cbrec";
            this.cbrec.Size = new System.Drawing.Size(90, 21);
            this.cbrec.TabIndex = 7;
            this.cbrec.Text = "Recursive";
            // 
            // tboperations
            // 
            this.tboperations.Controls.Add(this.pnop);
            this.tboperations.Location = new System.Drawing.Point(4, 25);
            this.tboperations.Name = "tboperations";
            this.tboperations.Size = new System.Drawing.Size(287, 214);
            this.tboperations.TabIndex = 1;
            this.tboperations.Text = "Operations";
            // 
            // pnop
            // 
            this.pnop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnop.AutoScroll = true;
            this.pnop.BackColor = System.Drawing.SystemColors.Window;
            this.pnop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnop.Location = new System.Drawing.Point(11, 10);
            this.pnop.Name = "pnop";
            this.pnop.Size = new System.Drawing.Size(263, 195);
            this.pnop.TabIndex = 0;
            // 
            // tbcache
            // 
            this.tbcache.Controls.Add(this.button3);
            this.tbcache.Controls.Add(this.button2);
            this.tbcache.Controls.Add(this.btclear);
            this.tbcache.Location = new System.Drawing.Point(4, 25);
            this.tbcache.Name = "tbcache";
            this.tbcache.Size = new System.Drawing.Size(287, 214);
            this.tbcache.TabIndex = 2;
            this.tbcache.Text = "Cache";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(60, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 28);
            this.button3.TabIndex = 11;
            this.button3.Text = "Reload FileTable";
            this.toolTip1.SetToolTip(this.button3, "Press this Button if you want to reload the FileTable.");
            this.button3.Click += new System.EventHandler(this.ReloadFileTable);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(60, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 28);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reload Cache";
            this.toolTip1.SetToolTip(this.button2, "Press this Button if you want to reload the Cache from your HD.");
            this.button2.Click += new System.EventHandler(this.ReloadCache);
            // 
            // btclear
            // 
            this.btclear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btclear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btclear.Location = new System.Drawing.Point(60, 62);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(160, 28);
            this.btclear.TabIndex = 9;
            this.btclear.Text = "Clear Cache";
            this.toolTip1.SetToolTip(this.btclear, "Press this Button if you want to clear the Scanner Cache.");
            this.btclear.Click += new System.EventHandler(this.ClearCache);
            // 
            // tbidentify
            // 
            this.tbidentify.Controls.Add(this.lbscandebug);
            this.tbidentify.Controls.Add(this.label6);
            this.tbidentify.Controls.Add(this.lbid);
            this.tbidentify.Controls.Add(this.label5);
            this.tbidentify.Location = new System.Drawing.Point(4, 25);
            this.tbidentify.Name = "tbidentify";
            this.tbidentify.Size = new System.Drawing.Size(287, 214);
            this.tbidentify.TabIndex = 3;
            this.tbidentify.Text = "Debug";
            // 
            // lbscandebug
            // 
            this.lbscandebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbscandebug.HorizontalScrollbar = true;
            this.lbscandebug.ItemHeight = 16;
            this.lbscandebug.Location = new System.Drawing.Point(3, 136);
            this.lbscandebug.Name = "lbscandebug";
            this.lbscandebug.Size = new System.Drawing.Size(281, 68);
            this.lbscandebug.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "loaded Scanners:";
            // 
            // lbid
            // 
            this.lbid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbid.HorizontalScrollbar = true;
            this.lbid.ItemHeight = 16;
            this.lbid.Location = new System.Drawing.Point(3, 29);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(281, 68);
            this.lbid.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "loaded Identifiers:";
            // 
            // gbinfo
            // 
            this.gbinfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbinfo.Controls.Add(this.lbprop);
            this.gbinfo.Controls.Add(this.tbflname);
            this.gbinfo.Controls.Add(this.cbenable);
            this.gbinfo.Controls.Add(this.lbtype);
            this.gbinfo.Controls.Add(this.lbname);
            this.gbinfo.Controls.Add(this.llopen);
            this.gbinfo.Controls.Add(this.thumb);
            this.gbinfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbinfo.Location = new System.Drawing.Point(312, 199);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Size = new System.Drawing.Size(459, 204);
            this.gbinfo.TabIndex = 2;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "Information";
            // 
            // lbprop
            // 
            this.lbprop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprop.Location = new System.Drawing.Point(149, 117);
            this.lbprop.MaxDropDownItems = 15;
            this.lbprop.Name = "lbprop";
            this.lbprop.Size = new System.Drawing.Size(299, 25);
            this.lbprop.Sorted = true;
            this.lbprop.TabIndex = 10;
            // 
            // tbflname
            // 
            this.tbflname.Location = new System.Drawing.Point(11, 165);
            this.tbflname.Name = "tbflname";
            this.tbflname.ReadOnly = true;
            this.tbflname.Size = new System.Drawing.Size(391, 22);
            this.tbflname.TabIndex = 9;
            // 
            // cbenable
            // 
            this.cbenable.AutoSize = true;
            this.cbenable.Location = new System.Drawing.Point(352, 19);
            this.cbenable.Name = "cbenable";
            this.cbenable.Size = new System.Drawing.Size(79, 21);
            this.cbenable.TabIndex = 7;
            this.cbenable.Text = "Enabled";
            this.cbenable.CheckedChanged += new System.EventHandler(this.SetEnabledState);
            // 
            // lbtype
            // 
            this.lbtype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.Location = new System.Drawing.Point(149, 29);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(197, 28);
            this.lbtype.TabIndex = 8;
            this.lbtype.Text = "Type";
            // 
            // lbname
            // 
            this.lbname.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.Location = new System.Drawing.Point(149, 58);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(299, 49);
            this.lbname.TabIndex = 7;
            this.lbname.Text = "Caption";
            // 
            // llopen
            // 
            this.llopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llopen.AutoSize = true;
            this.llopen.Location = new System.Drawing.Point(408, 168);
            this.llopen.Name = "llopen";
            this.llopen.Size = new System.Drawing.Size(40, 17);
            this.llopen.TabIndex = 8;
            this.llopen.TabStop = true;
            this.llopen.Text = "open";
            this.llopen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenPackage);
            // 
            // thumb
            // 
            this.thumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumb.Location = new System.Drawing.Point(11, 29);
            this.thumb.Name = "thumb";
            this.thumb.Size = new System.Drawing.Size(128, 117);
            this.thumb.TabIndex = 0;
            this.thumb.TabStop = false;
            // 
            // llSave
            // 
            this.llSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llSave.AutoSize = true;
            this.llSave.Location = new System.Drawing.Point(731, 186);
            this.llSave.Name = "llSave";
            this.llSave.Size = new System.Drawing.Size(50, 17);
            this.llSave.TabIndex = 8;
            this.llSave.TabStop = true;
            this.llSave.Text = "save...";
            this.llSave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSave_LinkClicked);
            // 
            // sfd
            // 
            this.sfd.Filter = "Comma Seperated Values (*.csv)|*.csv|All Files (*.*)|*.*";
            // 
            // ScannerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(792, 465);
            this.Controls.Add(this.btscan);
            this.Controls.Add(this.llSave);
            this.Controls.Add(this.cbrec);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.cbfolder);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.gbinfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScannerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Folder Scanner";
            this.tabControl1.ResumeLayout(false);
            this.tbscanners.ResumeLayout(false);
            this.tbscanners.PerformLayout();
            this.tboperations.ResumeLayout(false);
            this.tbcache.ResumeLayout(false);
            this.tbidentify.ResumeLayout(false);
            this.tbidentify.PerformLayout();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void SelectFolder(object sender, System.EventArgs e)
        {
            if (cbfolder.SelectedIndex == 0)
            {
                folder = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Downloads");
            }
            else if (cbfolder.SelectedIndex == 1)
            {
                folder = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Teleport");
            }
            else if (cbfolder.SelectedIndex == 2)
            {
                folder = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Neighborhoods");
            }
            else if (cbfolder.SelectedIndex == 3)
            {
                folder = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "SavedSims");
            }

            else
            {
                if (fbd.SelectedPath == "") fbd.SelectedPath = PathProvider.SimSavegameFolder;
                if (fbd.ShowDialog() == DialogResult.OK) folder = fbd.SelectedPath;
            }
        }

        private void Scan(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {

            errorlog = "";
            cachechg = false;
            lv.Items.Clear();
            lv.Columns.Clear();
            ilist.Images.Clear();

            lv.BeginUpdate();
            WaitingScreen.Wait();
            try
            {
                if (Helper.WindowsRegistry.UseCache) cachefile.LoadFiles();

                //Setup ListView
                lv.SmallImageList = null;
                lv.Refresh();
                SimPe.Plugin.Scanner.AbstractScanner.AddColumn(lv, "Filename", 180);
                SimPe.Plugin.Scanner.AbstractScanner.AddColumn(lv, "Enabled", 60);
                SimPe.Plugin.Scanner.AbstractScanner.AddColumn(lv, "Type", 80);



                //Select only checked Scanners
                ScannerCollection scanners = new ScannerCollection();
                for (int i = 0; i < lbscanners.Items.Count; i++)
                {
                    IScanner scanner = (IScanner)lbscanners.Items[i];
                    if (lbscanners.GetItemChecked(i))
                    {
                        scanners.Add(scanner);
                        scanner.EnableControl(true);
                    }
                    else scanner.EnableControl(false);
                }

                SimPe.Plugin.Scanner.AbstractScanner.AssignFileTable();
                //setup Scanners
                foreach (IScanner s in scanners) s.InitScan(this.lv);

                //scan all Files
                Scan(folder, cbrec.Checked, scanners);

                //finish Scanners
                foreach (IScanner s in scanners) s.FinishScan();
                SimPe.Plugin.Scanner.AbstractScanner.DeAssignFileTable();

                try
                {
                    if (Helper.WindowsRegistry.UseCache && cachechg) cachefile.Save();
                }
                catch (Exception ex)
                {
                    Helper.ExceptionMessage("", ex);
                }
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
            finally
            {
                WaitingScreen.Stop();
                lv.EndUpdate();
            }

            if (errorlog.Trim() != "") Helper.ExceptionMessage(new Warning("Unreadable Files were found", errorlog));
        }

        private void SelectItem(object sender, System.EventArgs e)
        {
            try
            {

                lastitem = null;
                gbinfo.Enabled = (lv.SelectedItems.Count != 0);
                pnop.Enabled = (lv.SelectedItems.Count != 0);

                if (lv.SelectedItems.Count == 0) return;

                ScannerItem si = (ScannerItem)lv.SelectedItems[0].Tag;
                ShowInfo(si, lv.SelectedItems[0]);
                lastitem = si;

                int encount = 0;

                //do something for all selected Items
                ScannerItem[] items = new ScannerItem[lv.SelectedItems.Count];
                int ct = 0;
                foreach (ListViewItem lvi in lv.SelectedItems)
                {
                    si = (ScannerItem)lvi.Tag;
                    items[ct++] = si;
                    if (si.PackageCacheItem.Enabled) encount++;
                }

                if (encount == lv.SelectedItems.Count) this.cbenable.CheckState = CheckState.Checked;
                else if (encount == 0) this.cbenable.CheckState = CheckState.Unchecked;
                else this.cbenable.CheckState = CheckState.Indeterminate;


                //Enable the Scanner Controls
                foreach (IScanner scanner in this.lbscanners.Items)
                {
                    scanner.EnableControl(items, ScannerRegistry.Global.Scanners.Contains(scanner));

                }//foreach
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("", ex);
            }
        }

        private void SortList(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if (sorter.CurrentColumn == e.Column)
            {
                if (lv.Sorting == SortOrder.Ascending) lv.Sorting = SortOrder.Descending;
                else lv.Sorting = SortOrder.Ascending;
            }
            else
            {
                sorter.CurrentColumn = e.Column;
                lv.ListViewItemSorter = sorter;
            }
            sorter.Sorting = lv.Sorting;
            lv.Sort();
        }

        private void Scan(object sender, System.EventArgs e)
        {
            Scan(null, (System.Windows.Forms.LinkLabelLinkClickedEventArgs)null);
        }

        private void ReloadFileTable(object sender, System.EventArgs e)
        {
            FileTable.FileIndex.ForceReload();
        }

        private void ReloadCache(object sender, System.EventArgs e)
        {
            if (Helper.WindowsRegistry.UseCache) cachefile.Load(SimPe.Cache.PackageCacheFile.CacheFileName);
        }

        private void SetEnabledState(object sender, System.EventArgs e)
        {
            if (this.cbenable.Tag != null) return;
            if (this.cbenable.CheckState == CheckState.Indeterminate) return;

            WaitingScreen.Wait();
            try
            {
                string ext = ".package";
                if (!this.cbenable.Checked) ext = ".packagedisabled";

                WaitingScreen.UpdateMessage("Disable/Enable Packges");
                int ct = 0;
                foreach (ListViewItem lvi in lv.SelectedItems)
                {
                    pb.Value = ((ct++) * pb.Maximum) / lv.SelectedItems.Count;
                    ScannerItem si = (ScannerItem)lvi.Tag;

                    string newname = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(si.FileName), System.IO.Path.GetFileNameWithoutExtension(si.FileName) + ext).Trim().ToLower();
                    string orgname = si.FileName.Trim().ToLower();

                    //si.Package.Save(newname);



                    //remove the old file if the name was changed names
                    if (!System.IO.File.Exists(newname))
                    {
                        SimPe.Packages.StreamItem stri = SimPe.Packages.StreamFactory.UseStream(orgname, System.IO.FileAccess.Read);
                        stri.Close();
                        SimPe.Packages.StreamItem strit = SimPe.Packages.StreamFactory.UseStream(newname, System.IO.FileAccess.Read);
                        strit.Close();
                        System.IO.File.Move(orgname, newname);


                        si.FileName = newname;
                        si.PackageCacheItem.Enabled = cbenable.Checked;
                        si.ParentContainer.FileName = newname;
                        si.ParentContainer.Added = DateTime.Now;
                    }

                    Application.DoEvents();
                }

                try
                {
                    WaitingScreen.UpdateMessage("Writing Cache");
                    if (Helper.WindowsRegistry.UseCache) cachefile.Save();
                }
                catch (Exception ex)
                {
                    Helper.ExceptionMessage("", ex);
                }
            }
            finally
            {
                WaitingScreen.Stop();
                pb.Value = 0;
            }
        }

        private void ClearCache(object sender, System.EventArgs e)
        {
            DialogResult dr = DialogResult.Yes;

            if (!Helper.WindowsRegistry.Silent) dr = MessageBox.Show("Do you really want to clear the Cache?", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    System.IO.File.Delete(SimPe.Cache.PackageCacheFile.CacheFileName);
                    cachefile.Load(SimPe.Cache.PackageCacheFile.CacheFileName);
                }
                catch (Exception ex)
                {
                    Helper.ExceptionMessage("", ex);
                }
            }
        }

        private void OpenPackage(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lastitem == null) return;

            this.flname = lastitem.FileName;
            Close();
        }

        private void llSave_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    System.IO.StreamWriter sw = System.IO.File.CreateText(sfd.FileName);
                    try
                    {
                        foreach (ColumnHeader ch in lv.Columns)
                            sw.Write(ch.Text.Replace(",", ";") + ",");
                        sw.WriteLine();

                        foreach (ListViewItem lvi in lv.Items)
                        {
                            //sw.Write(lvi.Text.Replace(",", ";")+",");
                            foreach (ListViewItem.ListViewSubItem lvsi in lvi.SubItems)
                                sw.Write(lvsi.Text.Replace(",", ";") + ",");
                            sw.WriteLine();
                        }
                    }
                    finally
                    {
                        sw.Close();
                        sw.Dispose();
                        sw = null;
                    }
                }
                catch (Exception ex)
                {
                    Helper.ExceptionMessage(ex);
                }
            }
        }
    }
}
