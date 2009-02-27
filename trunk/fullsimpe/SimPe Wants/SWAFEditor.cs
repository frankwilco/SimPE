/***************************************************************************
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   peter@users.sf.net                                                    *
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
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SimPe.Interfaces.Plugin;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Wants
{
    public partial class SWAFEditor : Form, IPackedFileUI
    {
        public SWAFEditor()
        {
            InitializeComponent();

            internalchg = true;
            lvItems.Sorting = SortOrder.Ascending;
            groupColumn = Settings.SWAFSortColumn;

            lbtn = new List<Button>(new Button[] { btnAddWant, btnAddFear, btnAddLTWant, });
            lincs = new List<CheckBox>(new CheckBox[] { ckbIncWants, ckbIncFears, ckbIncLTWants, ckbIncHistory, });
            lflags = new List<CheckBox>(new CheckBox[] {
                ckbFlag1, ckbFlag2, ckbFlag3, ckbFlag4, ckbFlag5, ckbFlag6, ckbFlag7, ckbFlag8,
            });
            ltbUint32 = new List<TextBox>(new TextBox[] {
                tbMaxFears, tbMaxWants, tbUnknown1, tbUnknown2, tbUnknown3,
                tbSICounter,
            });
            lgc = new List<SimPe.Plugin.GUIDChooser>(new SimPe.Plugin.GUIDChooser[]{
                gcSIWant, gcSIObject, gcSICategory, gcSICareer, gcSIBadge,
            });

            int[] ai = Settings.SWAFColumns;
            if (ai != null) for (int i = 0; i < ai.Length; i++)
                    lvItems.Columns[i].Width = ai[i];

            bool[] ab = Settings.SWAFItemTypes;
            if (ab != null) for (int i = 0; i < ab.Length; i++)
                    lincs[i].Checked = ab[i];

            //int sd = Settings.SplitterDistance;
            //if (sd != -1)
            //    splitContainer1.SplitterDistance = sd;

            cbFileVersion.Items.Clear();
            foreach (uint v in SWAFWrapper.ValidVersions)
                cbFileVersion.Items.Add("0x" + Helper.HexString((byte)v));

            cbSIVersion.Items.Clear();
            foreach (uint v in SWAFItem.ValidVersions)
                cbSIVersion.Items.Add("0x" + Helper.HexString((byte)v));

            cbSIArgType.Items.Clear();
            cbSIArgType.Items.AddRange(Enum.GetNames(typeof(SWAFItem.ArgTypes)));

            tbSIArg.Location = flpSimID2.Location = gcSICategory.Location = gcSIObject.Location = cbSISkill.Location = gcSIBadge.Location = gcSICareer.Location =
                new Point(0, 0);


            #region Want names
            if (wantNames == null)
            {
                List<KeyValuePair<string, uint>> wants = new List<KeyValuePair<string, uint>>();
                xwnts = new Dictionary<uint, object[]>();
                pjse.FileTable.Entry[] ae = pjse.FileTable.GFT[XWNTWrapper.XWNTType];

                Wait.Start(ae.Length / 10);
                Wait.Message = "Want names...";

                int ctr = 0;
                foreach (pjse.FileTable.Entry e in ae)
                {
                    try
                    {
                        Application.DoEvents();

                        XWNTWrapper xwnt = e.Wrapper as XWNTWrapper;
                        if (xwnt == null) continue;

                        if (xwnt["id"] == null) continue;
                        uint i = 0;
                        try { i = Convert.ToUInt32(xwnt["id"].Value, xwnt["id"].Value.StartsWith("0x") ? 16 : 10); }
                        catch { continue; }
                        if (xwnts.ContainsKey(i)) continue;

                        string s = "";
                        if (xwnt["objectType"] != null) s += (s.Length > 0 ? " " : "") + "(" + xwnt["objectType"].Value + ")";
                        if (xwnt["folder"] != null) s += (s.Length > 0 ? " " : "") + xwnt["folder"].Value;
                        if (xwnt["nodeText"] != null) s += (s.Length > 0 ? " / " : "") + xwnt["nodeText"].Value;
                        if (s.Length == 0) continue;

                        xwnts.Add(i, new object[] { e.FileDescriptor, e.Package, });
                        wants.Add(new KeyValuePair<string, uint>(s, i));
                    }
                    finally { if (++ctr == 10) { Wait.Progress++; ctr = 0; } }
                }
                wants.Sort(new byKey());
                wantNames = new List<string>();
                wantIDs = new List<uint>();
                foreach (KeyValuePair<string, uint> kvp in wants) { wantNames.Add(kvp.Key); wantIDs.Add(kvp.Value); }

                Wait.Stop();
            }
            gcSIWant.KnownObjects = new object[] { wantNames, wantIDs, };
            #endregion

            #region Category, Skill and Badge names (and careers if no GUID Index)
            if (categoryNames == null)
            {
                Wait.Start();
                Wait.Message = "Category, Skill and Badge names...";

                pjse.FileTable.Entry[] ae = pjse.FileTable.GFT[0x00000000, 0xCDA53B6F, 0x2D7EE26B];
                XmlReaderSettings xrs = new XmlReaderSettings();
                xrs.IgnoreWhitespace = xrs.IgnoreProcessingInstructions = xrs.IgnoreComments = true;
                XmlDocument doc = new XmlDocument();
                doc.Load(XmlReader.Create(ae[0].Wrapper.StoredData.BaseStream, xrs));

                List<KeyValuePair<string, uint>> categories = new List<KeyValuePair<string, uint>>();
                XmlNode xn = doc["wantSimulator"]["categories"];
                if (xn != null) foreach (XmlNode cat in xn.ChildNodes)
                {
                    if (cat.Name != "category") continue;
                    categories.Add(new KeyValuePair<string, uint>(cat.Attributes["name"].Value, Convert.ToUInt32(cat.Attributes["id"].Value)));
                }
                categories.Sort(new byKey());
                categoryNames = new List<string>();
                categoryIDs = new List<uint>();
                foreach (KeyValuePair<string, uint> kvp in categories) { categoryNames.Add(kvp.Key); categoryIDs.Add(kvp.Value); }

                skills = new List<KeyValuePair<ushort, string>>();
                xn = doc["wantSimulator"]["skills"];
                if (xn != null) foreach (XmlNode cat in xn.ChildNodes)
                {
                    if (cat.Name != "skill") continue;
                    skills.Add(new KeyValuePair<ushort, string>(Convert.ToUInt16(cat.Attributes["id"].Value), cat.Attributes["name"].Value));
                }

                // Career fallback
                List<KeyValuePair<string, uint>> careers = new List<KeyValuePair<string, uint>>();
                xn = doc["wantSimulator"]["careers"];
                if (xn != null) foreach (XmlNode cat in xn.ChildNodes)
                {
                    if (cat.Name != "career") continue;
                    careers.Add(new KeyValuePair<string, uint>(cat.Attributes["name"].Value + " (" + cat.Attributes["type"].Value + ")",
                        Convert.ToUInt32(cat.Attributes["id"].Value, 16)));
                }
                careers.Sort(new byKey());
                careerNames = new List<string>();
                careerIDs = new List<uint>();
                foreach (KeyValuePair<string, uint> kvp in careers) { careerNames.Add(kvp.Key); careerIDs.Add(kvp.Value); }

                List<KeyValuePair<string, uint>> badges = new List<KeyValuePair<string, uint>>();
                xn = doc["wantSimulator"]["badges"];
                if (xn != null) foreach (XmlNode cat in xn.ChildNodes)
                {
                    if (cat.Name != "badge") continue;
                    badges.Add(new KeyValuePair<string, uint>(cat.Attributes["name"].Value, Convert.ToUInt32(cat.Attributes["id"].Value, 16)));
                }
                badges.Sort(new byKey());
                badgeNames = new List<string>();
                badgeIDs = new List<uint>();
                foreach (KeyValuePair<string, uint> kvp in badges) { badgeNames.Add(kvp.Key); badgeIDs.Add(kvp.Value); }

                Wait.Stop();
            }
            gcSICategory.KnownObjects = new object[] { categoryNames, categoryIDs, };
            //--later--gcSICareer.KnownObjects = new object[] { careerNames, careerIDs, };
            gcSIBadge.KnownObjects = new object[] { badgeNames, badgeIDs, };

            cbSISkill.Items.Clear();
            skills.Insert(0, new KeyValuePair<ushort, string>(0, "?any?"));
            foreach (KeyValuePair<ushort, string> kvp in skills)
                cbSISkill.Items.Add(kvp.Value);
            #endregion

            #region The GUID Index
            if (objectNames == null)
            {
                Wait.Start();
                Wait.Message = "The GUID Index...";
                if (!pjse.GUIDIndex.TheGUIDIndex.IsLoaded)
                    pjse.GUIDIndex.TheGUIDIndex.Load();

                if (!pjse.GUIDIndex.TheGUIDIndex.IsLoaded)
                {
                    // Oh well...
                    objectIDs = new List<uint>();
                    objectNames = new List<string>();
                    //careerIDs = new List<uint>();
                    //careerNames = new List<string>();
                }
                else
                {
                    Wait.Message = "Object names...";
                    objectIDs = new List<uint>(pjse.GUIDIndex.TheGUIDIndex.Keys);
                    objectIDs.Sort(new byValue(pjse.GUIDIndex.TheGUIDIndex));
                    objectNames = new List<string>();
                    foreach (uint k in objectIDs) objectNames.Add(pjse.GUIDIndex.TheGUIDIndex[k]);

                    // These should actually be from the CTSS is the same group as the OBJD
                    Wait.Message = "Career names...";
                    careerIDs = new List<uint>(pjse.GUIDIndex.TheGUIDIndex.BySemiGlobal("JobDataGlobals").Keys);
                    careerIDs.Sort(new byValue(pjse.GUIDIndex.TheGUIDIndex));
                    careerNames = new List<string>();
                    foreach (uint k in careerIDs) careerNames.Add(pjse.GUIDIndex.TheGUIDIndex[k].Replace("JobData - ", ""));
                }

                Wait.Stop();
            }
            gcSIObject.KnownObjects = new object[] { objectNames, objectIDs, };
            gcSICareer.KnownObjects = new object[] { careerNames, careerIDs, };
            #endregion

            internalchg = false;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (setHandler && wrapper != null)
            {
                //wrapper.FileDescriptor.DescriptionChanged -= new EventHandler(FileDescriptor_DescriptionChanged);
                wrapper.WrapperChanged -= new System.EventHandler(this.WrapperChanged);
                setHandler = false;
            }
            wrapper = null;
        }

        #region SWAFEditor
        private SWAFWrapper wrapper = null;
        private IDictionary<uint, List<SWAFItem>> history = null;
        private IList<SWAFItem> current = null;
        private bool setHandler = false;
        private bool internalchg;

        private List<Button> lbtn = null;
        private List<CheckBox> lincs = null;
        private List<CheckBox> lflags = null;
        private List<TextBox> ltbUint32 = null;
        private List<SimPe.Plugin.GUIDChooser> lgc = null;

        static List<string> wantNames = null;
        static List<uint> wantIDs = null;
        static Dictionary<uint, object[]> xwnts = null;
        static List<string> objectNames = null;
        static List<uint> objectIDs = null;
        static List<string> categoryNames = null;
        static List<uint> categoryIDs = null;
        static List<KeyValuePair<ushort, string>> skills = null;
        static List<string> badgeNames = null;
        static List<uint> badgeIDs = null;
        static List<string> careerNames = null;
        static List<uint> careerIDs = null;


        // Determine whether Windows XP or a later operating system is present.
        private bool isRunningXPOrLater = OSFeature.Feature.IsPresent(OSFeature.Themes);
        // Declare a Hashtable array in which to store the groups.
        private Hashtable[] groupTables;
        // Declare a variable to store the current grouping column.
        int groupColumn = 0;


        class byKey : Comparer<KeyValuePair<string, uint>>
        {
            public override int Compare(KeyValuePair<string, uint> x, KeyValuePair<string, uint> y) { return String.Compare(x.Key, y.Key); }
        }

        class byValue : Comparer<uint>
        {
            IDictionary<uint, string> objects = null;
            public byValue(IDictionary<uint, string> objects) : base() { this.objects = objects; }
            public override int Compare(uint x, uint y) { return String.Compare(objects[x], objects[y]); }
        }

        private string getName(List<string> names, List<uint> ids, uint value)
        {
            return ids.IndexOf(value) >= 0 ? names[ids.IndexOf(value)] : "0x" + Helper.HexString(value);
        }
        private string ArgValue(SWAFItem i)
        {
            switch (i.ArgType)
            {
                case SWAFItem.ArgTypes.None: return "-";
                case SWAFItem.ArgTypes.Sim: return SimName(i.Version < 0x08 ? (ushort)0 : i.Sim);
                case SWAFItem.ArgTypes.Guid: return getName(objectNames, objectIDs, i.Guid);
                case SWAFItem.ArgTypes.Category: return getName(categoryNames, categoryIDs, i.Category);
                case SWAFItem.ArgTypes.Skill: foreach (KeyValuePair<ushort, string> kvp in skills) if (kvp.Key == i.Skill) return kvp.Value; return "0x" + Helper.HexString(i.Skill);
                case SWAFItem.ArgTypes.Badge: return getName(badgeNames, badgeIDs, i.Badge);
                case SWAFItem.ArgTypes.Career: return getName(careerNames, careerIDs, i.Career);
            }
            return "{argValue}";
        }
        private string SimName(ushort i)
        {
            if (i == 0) return "?any sim?";
            ExtSDesc sdsc = i != 0 ? FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i) as ExtSDesc : null;
            return (sdsc == null) ? "0x" + Helper.HexString(i) : sdsc.SimName + " " + sdsc.SimFamilyName;
        }
        private ListViewItem MakeLVI(SWAFItem i)
        {
            ListViewItem lvi = new ListViewItem(new string[] {
                    ""+i.ItemType,
                    getName(wantNames, wantIDs, i.WantId),
                    ArgValue(i),
                    "0x"+Helper.HexString(i.Arg2),
                    "0x"+Helper.HexString(i.Counter),
                    ""+i.Score,
                    ""+i.Influence,
                    "0x"+Helper.HexString((byte)i.Flags),
                    "0x"+Helper.HexString((byte)i.Version),
                    "0x"+Helper.HexString(i.SimID),
                    ""+i.ArgType,
                });
            lvi.Tag = i;
            UpdateGroups(lvi);
            return lvi;
        }
        private bool incItem(SWAFItem.SWAFItemType t)
        {
            if (t == SWAFItem.SWAFItemType.Wants) return ckbIncWants.Checked;
            if (t == SWAFItem.SWAFItemType.Fears) return ckbIncFears.Checked;
            if (t == SWAFItem.SWAFItemType.LifetimeWants) return ckbIncLTWants.Checked;
            if (t == SWAFItem.SWAFItemType.History) return ckbIncHistory.Checked;
            return false;
        }
        private void setLV()
        {
            btnAddWant.Enabled = ckbIncWants.Checked && wrapper.Wants.Count < wrapper.MaxWants;
            btnAddFear.Enabled = ckbIncFears.Checked && wrapper.Fears.Count < wrapper.MaxFears;
            btnAddLTWant.Enabled = ckbIncLTWants.Checked && wrapper.Version >= 0x05;
            btnAddHistory.Enabled = ckbIncHistory.Checked;

            lvItems.BeginUpdate();
            lvItems.Items.Clear();
            foreach (SWAFItem i in current)
                if (incItem(i.ItemType)) lvItems.Items.Add(MakeLVI(i));
            foreach (KeyValuePair<uint, List<SWAFItem>> kvp in history)
                foreach (SWAFItem i in kvp.Value)
                    if (incItem(i.ItemType)) lvItems.Items.Add(MakeLVI(i));
            lvItems.EndUpdate();
        }

        private void SISimID2(SWAFItem i)
        {
            Image noone = System.Drawing.Image.FromStream(typeof(SimPoolControl).Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png"));
            ExtSDesc sdsc = i.Sim != 0 ? FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i.Sim) as ExtSDesc : null;
            if (sdsc == null) { btnSim2.Image = null; llSimName2.Text = "?any sim?"; llSREL.Visible = false; }
            else { Image img = sdsc.Image; btnSim2.Image = ((Image)(img == null ? noone : img)).GetThumbnailImage(64, 64, null, System.IntPtr.Zero); llSimName2.Text = sdsc.SimName + " " + sdsc.SimFamilyName; llSREL.Visible = true; }
        }
        private int findSkill(ushort skill)
        {
            for (int i = 0; i < skills.Count; i++) if (skills[i].Key == skill) return i;
            return -1;
        }
        private void SIArg(SWAFItem i)
        {
            pnArg.Enabled = true;
            switch (i.ArgType)
            {
                case SWAFItem.ArgTypes.None:
                    pnArg.Enabled = false;
                    tbSIArg.Visible = true;
                    flpSimID2.Visible = gcSIObject.Visible = gcSICategory.Visible = cbSISkill.Visible = gcSIBadge.Visible = gcSICareer.Visible = false;
                    tbSIArg.Text = "";
                    break;
                case SWAFItem.ArgTypes.Sim:
                    flpSimID2.Visible = true;
                    tbSIArg.Visible = gcSIObject.Visible = gcSICategory.Visible = cbSISkill.Visible = gcSIBadge.Visible = gcSICareer.Visible = false;
                    if (i.Version < 0x08)
                    {
                        flpSimID2.Enabled = false;
                        tbSISimID2.Text = llSimName2.Text = ""; llSREL.Visible = false;
                        btnSim2.Image = null;
                    }
                    else
                    {
                        flpSimID2.Enabled = true;
                        tbSISimID2.Text = "0x" + Helper.HexString(i.Sim);
                        SISimID2(i);
                    }
                    break;
                case SWAFItem.ArgTypes.Guid:
                    gcSIObject.Visible = true;
                    tbSIArg.Visible = flpSimID2.Visible = gcSICategory.Visible = cbSISkill.Visible = gcSIBadge.Visible = gcSICareer.Visible = false;
                    gcSIObject.Value = i.Guid;
                    break;
                case SWAFItem.ArgTypes.Category:
                    gcSICategory.Visible = true;
                    tbSIArg.Visible = flpSimID2.Visible = gcSIObject.Visible = cbSISkill.Visible = gcSIBadge.Visible = gcSICareer.Visible = false;
                    gcSICategory.Value = i.Category;
                    break;
                case SWAFItem.ArgTypes.Skill:
                    cbSISkill.Visible = true;
                    tbSIArg.Visible = flpSimID2.Visible = gcSIObject.Visible = gcSICategory.Visible = gcSIBadge.Visible = gcSICareer.Visible = false;
                    cbSISkill.SelectedIndex = findSkill(i.Skill);
                    break;
                case SWAFItem.ArgTypes.Badge:
                    gcSIBadge.Visible = true;
                    tbSIArg.Visible = flpSimID2.Visible = gcSIObject.Visible = gcSICategory.Visible = cbSISkill.Visible = gcSICareer.Visible = false;
                    gcSIBadge.Value = i.Badge;
                    break;
                case SWAFItem.ArgTypes.Career:
                    gcSICareer.Visible = true;
                    tbSIArg.Visible = flpSimID2.Visible = gcSIObject.Visible = gcSICategory.Visible = cbSISkill.Visible = gcSIBadge.Visible = false;
                    gcSICareer.Value = i.Career;
                    break;
            }
        }
        private void SIWant(SWAFItem i, uint newWantId)
        {
            if (i.WantId != newWantId)
            {
                if (i.ItemType == SWAFItem.SWAFItemType.History)
                    history[i.WantId].Remove(i);
                i.WantId = newWantId;
                if (i.ItemType == SWAFItem.SWAFItemType.History)
                    history[i.WantId].Add(i);
            }

            if (!xwnts.ContainsKey(i.WantId))
            {
                lbXWNTIntOp.Text = "(Unknown want)";
                lbTimes.Visible = lbXWNTIntMult.Visible = false;
                return;
            }

            XWNTWrapper xwnt = pjse.FileTable.GFT[xwnts[i.WantId][1] as SimPe.Interfaces.Files.IPackageFile,
                xwnts[i.WantId][0] as SimPe.Interfaces.Files.IPackedFileDescriptor][0].Wrapper as XWNTWrapper;
            if (xwnt["integerType"] == null || xwnt["integerType"].Value.Equals("None"))
            {
                lbXWNTIntOp.Text = "(Not used)";
                lbTimes.Visible = lbXWNTIntMult.Visible = false;
            }
            else
            {
                lbXWNTIntOp.Text = xwnt["integerOperator"] != null ? xwnt["integerOperator"].Value : "Equals";
                lbTimes.Visible = lbXWNTIntMult.Visible = true;
                lbXWNTIntMult.Text = xwnt["integerMultiplier"] != null ? xwnt["integerMultiplier"].Value : "1";
            }
            lbXWNTType.Text = xwnt["objectType"] != null ? xwnt["objectType"].Value : "(Unknown)";
        }
        #endregion

        #region IPackedFileUI Members

        public Control GUIHandle { get { return pnSWAFEditor; } }

        public void UpdateGUI(IFileWrapper wrp)
        {
            wrapper = (SWAFWrapper)wrp;
            current = wrapper;
            history = wrapper;

            WrapperChanged(wrapper, null);

            internalchg = true;

            tbUnknown3.Enabled = tbMaxWants.Enabled = tbMaxFears.Enabled = wrapper.Version >= 0x05;

            cbFileVersion.SelectedIndex = SWAFWrapper.ValidVersions.IndexOf(wrapper.Version);

            tbMaxWants.Text = "0x" + Helper.HexString(wrapper.MaxWants);
            tbMaxFears.Text = "0x" + Helper.HexString(wrapper.MaxFears);
            tbUnknown1.Text = "0x" + Helper.HexString(wrapper.Unknown1);
            tbUnknown2.Text = "0x" + Helper.HexString(wrapper.Unknown2);
            tbUnknown3.Text = "0x" + Helper.HexString(wrapper.Unknown3);
            tbUnknown4.Text = Helper.BytesToHexList(wrapper.Unknown4);

            groupTables = new Hashtable[lvItems.Columns.Count];
            setLV();
            SetGroups(groupColumn);

            internalchg = false;

            if (lvItems.Items.Count > 0)
                lvItems.Items[0].Selected = true;
            else
                lvItems_SelectedIndexChanged(null, null);

            // I don't like this being here
            int sd = Settings.SWAFSplitterDistance;
            if (sd != -1)
                splitContainer1.SplitterDistance = sd;

            if (!setHandler)
            {
                wrapper.WrapperChanged += new System.EventHandler(this.WrapperChanged);
                setHandler = true;
            }
        }

        private void WrapperChanged(object sender, System.EventArgs e)
        {
            this.btnCommit.Enabled = wrapper.Changed;

            if (internalchg) return;
            internalchg = true;
            try
            {
                if (sender.Equals(wrapper))
                {
                }
                else
                {
                }
            }
            finally { internalchg = false; }
        }
        #endregion

        #region Grouping
        // Groups the items using the groups created for the clicked column.
        private void lvItems_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Set the sort order to ascending when changing
            // column groups; otherwise, reverse the sort order.
            if (lvItems.Sorting == SortOrder.Descending ||
                (isRunningXPOrLater && (e.Column != groupColumn)))
            {
                lvItems.Sorting = SortOrder.Ascending;
            }
            else
            {
                lvItems.Sorting = SortOrder.Descending;
            }
            Settings.SWAFSortColumn = groupColumn = e.Column;

            // Set the groups to those created for the clicked column.
            if (isRunningXPOrLater)
            {
                SetGroups(e.Column);
            }
        }

        private void UpdateGroups(ListViewItem lvi)
        {
            if (!isRunningXPOrLater) return;
            for (int column = 0; column < lvItems.Columns.Count; column++)
                UpdateGroupsColumn(lvi, column);
        }

        private void UpdateGroupsColumn(ListViewItem lvi, int column)
        {
            SWAFItem i = lvi.Tag as SWAFItem;
            if (groupTables[column] == null)
                groupTables[column] = new Hashtable();
            Hashtable groups = groupTables[column];

            string subItemText = lvi.SubItems[column].Text;

            if (column == 1 && xwnts.ContainsKey(i.WantId))
            {
                XWNTWrapper xwnt = pjse.FileTable.GFT[xwnts[i.WantId][1] as SimPe.Interfaces.Files.IPackageFile,
                    xwnts[i.WantId][0] as SimPe.Interfaces.Files.IPackedFileDescriptor][0].Wrapper as XWNTWrapper;
                if (xwnt != null && xwnt["folder"] != null)
                    subItemText = xwnt["folder"].Value;
            }
            else if (column == 2 && i.ArgType == SWAFItem.ArgTypes.Sim && i.Version >= 0x08)
            {
                ExtSDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i.Sim) as ExtSDesc;
                if (sdsc != null && sdsc.SimFamilyName != null)
                    subItemText = sdsc.SimFamilyName;
            }

            if (!groups.Contains(subItemText))
                groups.Add(subItemText, new ListViewGroup(subItemText, HorizontalAlignment.Left));
        }

        // Sets myListView to the groups created for the specified column.
        private void SetGroups(int column)
        {
            if (!isRunningXPOrLater) return;

            // Remove the current groups.
            lvItems.Groups.Clear();

            // Retrieve the hash table corresponding to the column.
            Hashtable groups = (Hashtable)groupTables[column];

            // Copy the groups for the column to an array.
            ListViewGroup[] groupsArray = new ListViewGroup[groups.Count];
            groups.Values.CopyTo(groupsArray, 0);

            // Sort the groups and add them to myListView.
            Array.Sort(groupsArray, new ListViewGroupSorter(lvItems.Sorting, column));
            lvItems.Groups.AddRange(groupsArray);

            // Iterate through the items in myListView, assigning each 
            // one to the appropriate group.
            foreach (ListViewItem item in lvItems.Items)
            {
                SWAFItem i = item.Tag as SWAFItem;

                // Retrieve the subitem text corresponding to the column.
                string subItemText = item.SubItems[column].Text;

                if (i != null)
                {
                    if (column == 1)
                    {
                        XWNTWrapper xwnt = pjse.FileTable.GFT[xwnts[i.WantId][1] as SimPe.Interfaces.Files.IPackageFile,
                            xwnts[i.WantId][0] as SimPe.Interfaces.Files.IPackedFileDescriptor][0].Wrapper as XWNTWrapper;
                        if (xwnt != null && xwnt["folder"] != null)
                            subItemText = xwnt["folder"].Value;
                    }
                    else if (column == 2 && i.ArgType == SWAFItem.ArgTypes.Sim && i.Version >= 0x08)
                    {
                        ExtSDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i.Sim) as ExtSDesc;
                        if (sdsc != null && sdsc.SimFamilyName != null)
                            subItemText = sdsc.SimFamilyName;
                    }
                }

                // Assign the item to the matching group.
                item.Group = (ListViewGroup)groups[subItemText];
            }

            lvItems.ShowGroups = true;
        }


        // Sorts ListViewGroup objects by header value.
        private class ListViewGroupSorter : IComparer
        {
            private SortOrder order;
            private int column;
            List<string> col0hdrs = new List<string>(new string[] { "Wants", "Fears", "LifetimeWants", "History", });

            // Stores the sort order.
            public ListViewGroupSorter(SortOrder theOrder, int column)
            {
                order = theOrder;
                this.column = column;
            }

            // Compares the groups by header value, using the saved sort
            // order to return the correct value.
            public int Compare(object x, object y)
            {
                int result;
                if (column != 0)
                    result = String.Compare(((ListViewGroup)x).Header, ((ListViewGroup)y).Header);
                else
                    result = col0hdrs.IndexOf(((ListViewGroup)x).Header).CompareTo(col0hdrs.IndexOf(((ListViewGroup)y).Header));

                if (order == SortOrder.Ascending)
                    return result;
                else if (order == SortOrder.Descending)
                    return -result;
                return 0;
            }
        }
        #endregion

        private void btnCommit_Click(object sender, EventArgs e)
        {
            wrapper.SynchronizeUserData();
            btnCommit.Enabled = wrapper.Changed;
        }

        private void llSimName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!sender.Equals(llSimName) && !sender.Equals(llSimName2)) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;
            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            ExtSDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(sender.Equals(llSimName) ? i.SimID : i.Sim) as ExtSDesc;
            if (sdsc == null) return;

            SimPe.RemoteControl.OpenPackedFile(sdsc.FileDescriptor, sdsc.Package);
        }

        private void llXWNT_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;
            if (!xwnts.ContainsKey(i.WantId)) return;

            XWNTWrapper xwnt = new XWNTWrapper();
            xwnt.ProcessData(xwnts[i.WantId][0] as SimPe.Interfaces.Files.IPackedFileDescriptor, xwnts[i.WantId][1] as SimPe.Interfaces.Files.IPackageFile);

            Form xwntForm = xwnt.UIHandler as Form;
            if (xwntForm == null) return;
            xwnt.RefreshUI();
            xwntForm.Show();
        }

        private void llSREL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;
            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            ExtSDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i.SimID) as ExtSDesc;
            if (sdsc == null) return;

            SimPe.Interfaces.Files.IPackedFileDescriptor pfd1 = sdsc.Package.FindFile(
                Data.MetaData.RELATION_FILE,
                0,
                sdsc.FileDescriptor.Group,
                (uint)((i.SimID << 16) + i.Sim)
                );
            SimPe.RemoteControl.OpenPackedFile(pfd1, sdsc.Package);
        }


        private void cbFileVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (cbFileVersion.SelectedIndex < 0) return;
            internalchg = true;
            try
            {
                wrapper.Version = SWAFWrapper.ValidVersions[cbFileVersion.SelectedIndex];
                btnAddLTWant.Enabled = tbUnknown3.Enabled = tbMaxWants.Enabled = tbMaxFears.Enabled = wrapper.Version >= 0x05;
            }
            finally { internalchg = false; }
        }


        private void btnAddWantFear_Click(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (sender as Button == null || lbtn.IndexOf((Button)sender) < 0) return;
            internalchg = true;
            try
            {
                SWAFItem i = null;
                switch (lbtn.IndexOf((Button)sender))
                {
                    case 0: //Want
                        i = new SWAFItem(wrapper, SWAFItem.SWAFItemType.Wants);
                        btnAddWant.Enabled = wrapper.Wants.Count < wrapper.MaxWants;
                        break;
                    case 1: //Fear
                        i = new SWAFItem(wrapper, SWAFItem.SWAFItemType.Fears);
                        btnAddFear.Enabled = wrapper.Fears.Count < wrapper.MaxFears;
                        break;
                    case 2: //LifetimeWant
                        i = new SWAFItem(wrapper, SWAFItem.SWAFItemType.LifetimeWants);
                        break;
                    case 3: //History
                        i = new SWAFItem(wrapper, SWAFItem.SWAFItemType.History);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                i.SimID = (ushort)wrapper.FileDescriptor.Instance;
                if (i.ItemType == SWAFItem.SWAFItemType.History)
                    history[i.WantId].Add(i);
                else
                    current.Add(i);
                lvItems.Items.Add(MakeLVI(i));
            }
            finally { internalchg = false; }
            lvItems.Items[lvItems.Items.Count - 1].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;
            int pos = lvItems.SelectedIndices[0];

            internalchg = true;
            try
            {
                SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

                if (i.ItemType == SWAFItem.SWAFItemType.History)
                    history[i.WantId].Remove(i);
                else
                    current.Remove(i);

                lvItems.Items.RemoveAt(pos);
                pos--;
                if (pos < 0) pos = 0;
                if (pos >= lvItems.Items.Count) pos = -1;
            }
            finally { internalchg = false; }

            if (pos == -1) lvItems.SelectedIndices.Clear();
            else lvItems.Items[pos].Selected = true;
        }

        private void lvItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            internalchg = true;
            try
            {
                if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                {
                    gbSelectedItem.Enabled = btnDelete.Enabled = false;
                    lbSIItemType.Text = tbSISimID.Text = llSimName.Text =
                        tbSIArg.Text = tbSIArg2.Text =
                        tbSICounter.Text = tbSIScore.Text = tbSIInfluence.Text = "";
                    cbSIArgType.SelectedIndex = cbSIVersion.SelectedIndex = -1;
                    gcSIWant.Value = 0;
                    gcSICareer.Visible = flpSimID2.Visible = false;
                    tbSIArg.Visible = true;
                    foreach (CheckBox ckb in lflags) ckb.CheckState = CheckState.Indeterminate;
                }
                else
                {
                    ExtSDesc sdsc = null;
                    Image noone = System.Drawing.Image.FromStream(typeof(SimPoolControl).Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png"));
                    gbSelectedItem.Enabled = btnDelete.Enabled = true;

                    SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;
                    lbSIItemType.Text = "" + i.ItemType;
                    cbSIVersion.SelectedIndex = SWAFItem.ValidVersions.IndexOf(i.Version);

                    tbSISimID.Text = "0x" + Helper.HexString(i.SimID);
                    sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim(i.SimID) as ExtSDesc;
                    if (sdsc == null) { btnSim.Image = noone; llSimName.Text = ""; }
                    else { Image img = sdsc.Image; btnSim.Image = ((Image)(img == null ? noone : img)).GetThumbnailImage(64, 64, null, System.IntPtr.Zero); llSimName.Text = sdsc.SimName + " " + sdsc.SimFamilyName; }

                    gcSIWant.Value = i.WantId;
                    SIWant(i, i.WantId);

                    tbSIArg2.Text = "0x" + Helper.HexString(i.Arg2);

                    cbSIArgType.SelectedIndex = (new List<string>(Enum.GetNames(typeof(SWAFItem.ArgTypes)))).IndexOf("" + i.ArgType);

                    SIArg(i);

                    tbSICounter.Text = "0x" + Helper.HexString(i.Counter);
                    tbSIScore.Text = "" + i.Score;
                    tbSIInfluence.Enabled = i.Version >= 0x09;
                    tbSIInfluence.Text = i.Version >= 0x09 ? "" + i.Influence : "";
                    for (int f = 0; f < i.Flags.Length; f++) lflags[f].CheckState = i.Flags[f] ? CheckState.Checked : CheckState.Unchecked;
                }
            }
            finally { internalchg = false; }
        }

        private void lvItems_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            int[] ai = Settings.SWAFColumns;
            if (ai == null)
            {
                ai = new int[lvItems.Columns.Count];
                for (int i = 0; i < ai.Length; i++) ai[i] = lvItems.Columns[i].Width;
            }
            else
                ai[e.ColumnIndex] = lvItems.Columns[e.ColumnIndex].Width;
            Settings.SWAFColumns = ai;
        }

        private void ckbInc_CheckedChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            CheckBox ckb = sender as CheckBox;
            if (ckb == null || lincs.IndexOf(ckb) < 0) return;

            ListViewItem lvi = lvItems.SelectedItems[0];

            internalchg = true;
            try
            {
                bool[] ab = Settings.SWAFItemTypes;
                ab[lincs.IndexOf(ckb)] = ckb.Checked;
                Settings.SWAFItemTypes = ab;

                groupTables = new Hashtable[lvItems.Columns.Count];
                setLV();
                SetGroups(groupColumn);
            }
            finally { internalchg = false; }

            if (lvi != null && lvItems.Items.Contains(lvi)) lvi.Selected = true;
            else if (lvItems.Items.Count > 0)
                lvItems.Items[0].Selected = true;
            else
                lvItems_SelectedIndexChanged(null, null);

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (wrapper == null) return;
            Settings.SWAFSplitterDistance = splitContainer1.SplitterDistance;
        }


        private void tbSISimID2_TextChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                ushort simID2 = 0;
                try { simID2 = Convert.ToUInt16(tbSISimID2.Text, tbSISimID2.Text.StartsWith("0x") ? 16 : 10); }
                catch { return; }

                i.Sim = simID2;
                lvItems.SelectedItems[0].SubItems[2].Text = ArgValue(i); UpdateGroupsColumn(lvItems.SelectedItems[0], 2);
                SISimID2(i);
            }
            finally { internalchg = false; }
        }

        private void btnSim2_Click(object sender, EventArgs e)
        {
            SimPe.Interfaces.Files.IPackedFileDescriptor pfd = null;
            SimPe.Interfaces.Files.IPackageFile package = wrapper.Package;
            SimPe.Plugin.Sims sims = new SimPe.Plugin.Sims();
            sims.Text = Localization.Manager.GetString("simsbrowser");
            Interfaces.Plugin.IToolResult res = sims.Execute(ref pfd, ref package, FileTable.ProviderRegistry);
            if (pfd == null) return;

            tbSISimID2.Text = "0x" + Helper.HexString((ushort)pfd.Instance);
        }

        private void cbSISkill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (!sender.Equals(cbSISkill)) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                i.Skill = skills[cbSISkill.SelectedIndex].Key;
                lvItems.SelectedItems[0].SubItems[2].Text = ArgValue(i); UpdateGroupsColumn(lvItems.SelectedItems[0], 2);
            }
            finally { internalchg = false; }
        }

        private void tbUInt_TextChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (sender as TextBox == null || ltbUint32.IndexOf(sender as TextBox) < 0) return;

            TextBox tb = sender as TextBox;
            uint value = 0;
            try { value = Convert.ToUInt32(tb.Text, tb.Text.StartsWith("0x") ? 16 : 10); }
            catch { return; }

            internalchg = true;
            try
            {
                switch (ltbUint32.IndexOf(tb))
                {
                    case 0: wrapper.MaxFears = value; btnAddFear.Enabled = wrapper.Fears.Count < wrapper.MaxFears; break;
                    case 1: wrapper.MaxWants = value; btnAddWant.Enabled = wrapper.Wants.Count < wrapper.MaxWants; break;
                    case 2: wrapper.Unknown1 = value; break;
                    case 3: wrapper.Unknown2 = value; break;
                    case 4: wrapper.Unknown3 = value; break;
                    case 5:
                        if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                            return;
                        (lvItems.SelectedItems[0].Tag as SWAFItem).Counter = value;
                        lvItems.SelectedItems[0].SubItems[4].Text = "0x" + Helper.HexString((lvItems.SelectedItems[0].Tag as SWAFItem).Counter);
                        UpdateGroupsColumn(lvItems.SelectedItems[0], 4);
                        break;
                    default:
                        return;
                }
            }
            finally { internalchg = false; }
        }

        private void tbSIArg2_TextChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (!sender.Equals(tbSIArg2)) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            ushort value = 0;
            try { value = Convert.ToUInt16(tbSIArg2.Text, tbSIArg2.Text.StartsWith("0x") ? 16 : 10); }
            catch { return; }

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                i.Arg2 = value;
                lvItems.SelectedItems[0].SubItems[3].Text = "0x" + Helper.HexString(i.Arg2);
                UpdateGroupsColumn(lvItems.SelectedItems[0], 3);
            }
            finally { internalchg = false; }
        }

        private void gc_GUIDChooserValueChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (sender as SimPe.Plugin.GUIDChooser == null || lgc.IndexOf(sender as SimPe.Plugin.GUIDChooser) < 0) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SimPe.Plugin.GUIDChooser gc = sender as SimPe.Plugin.GUIDChooser;
            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                switch (lgc.IndexOf(gc))
                {
                    case 0: SIWant(i, gc.Value); break;
                    case 1: i.Guid = gc.Value; break;
                    case 2: i.Category = gc.Value; break;
                    case 3: i.Career = gc.Value; break;
                    case 4: i.Badge = gc.Value; break;
                }
                if (lgc.IndexOf(gc) == 0)
                {
                    lvItems.SelectedItems[0].SubItems[1].Text = getName(wantNames, wantIDs, i.WantId);
                    UpdateGroupsColumn(lvItems.SelectedItems[0], 1);
                }
                else
                {
                    lvItems.SelectedItems[0].SubItems[2].Text = ArgValue(i);
                    UpdateGroupsColumn(lvItems.SelectedItems[0], 2);
                }
            }
            finally { internalchg = false; }
        }

        private void tbInt_TextChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (sender as TextBox == null) return;

            TextBox tb = sender as TextBox;
            int value = 0;
            try { value = Convert.ToInt32(tb.Text); }
            catch { return; }

            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                if (tb.Equals(tbSIScore)) { i.Score = value; lvItems.SelectedItems[0].SubItems[5].Text = "" + i.Score; UpdateGroupsColumn(lvItems.SelectedItems[0], 5); }
                else if (tb.Equals(tbSIInfluence)) { i.Influence = value; lvItems.SelectedItems[0].SubItems[6].Text = "" + i.Influence; UpdateGroupsColumn(lvItems.SelectedItems[0], 6); }
                else return;
            }
            finally { internalchg = false; }
        }

        private void ckbFlag_CheckedChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (sender as CheckBox == null || lflags.IndexOf(sender as CheckBox) < 0) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            CheckBox ckb = sender as CheckBox;
            if (ckb.CheckState == CheckState.Indeterminate) return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                i.Flags[lflags.IndexOf(ckb)] = ckb.Checked;
                lvItems.SelectedItems[0].SubItems[7].Text = "0x" + Helper.HexString((byte)i.Flags);
                UpdateGroupsColumn(lvItems.SelectedItems[0], 7);
            }
            finally { internalchg = false; }
        }

        private void cbSIVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (cbSIVersion.SelectedIndex < 0) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                i.Version = SWAFItem.ValidVersions[cbSIVersion.SelectedIndex];
                lvItems.SelectedItems[0].SubItems[8].Text = "0x" + Helper.HexString((byte)i.Version);
                UpdateGroupsColumn(lvItems.SelectedItems[0], 8);
            }
            finally { internalchg = false; }


            tbSIInfluence.Enabled = false;
            tbSIInfluence.Text = "";
            if (i.ArgType == SWAFItem.ArgTypes.Sim)
            {
                flpSimID2.Enabled = false;
                tbSISimID2.Text = llSimName2.Text = ""; llSREL.Visible = false;
                btnSim2.Image = null;
            }
            if (i.Version >= 0x08)
            {
                if (i.ArgType == SWAFItem.ArgTypes.Sim)
                {
                    flpSimID2.Enabled = true;
                    tbSISimID2.Text = "0x" + Helper.HexString(i.Sim);
                    SISimID2(i);
                }
                if (i.Version >= 0x09)
                {
                    tbSIInfluence.Enabled = true;
                    tbSIInfluence.Text = "" + i.Influence;
                }
            }
        }

        private void cbSIArgType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (cbSIArgType.SelectedIndex < 0) return;
            if (lvItems.SelectedIndices.Count == 0 || lvItems.SelectedItems[0].Tag as SWAFItem == null)
                return;

            SWAFItem i = lvItems.SelectedItems[0].Tag as SWAFItem;

            internalchg = true;
            try
            {
                i.ArgType = (SWAFItem.ArgTypes)cbSIArgType.SelectedIndex;
                switch (i.ArgType)
                {
                    case SWAFItem.ArgTypes.None: break;
                    case SWAFItem.ArgTypes.Sim: if (i.Version >= 0x08) i.Sim = 0; break;
                    case SWAFItem.ArgTypes.Guid: i.Guid = 0; break;
                    case SWAFItem.ArgTypes.Category: i.Category = 0; break;
                    case SWAFItem.ArgTypes.Skill: i.Skill = 0; break;
                    case SWAFItem.ArgTypes.Badge: i.Badge = 0; break;
                    case SWAFItem.ArgTypes.Career: i.Career = 0; break;
                    default:
                        throw new InvalidOperationException();
                }
                lvItems.SelectedItems[0].SubItems[2].Text = ArgValue(i); UpdateGroupsColumn(lvItems.SelectedItems[0], 2); 
                lvItems.SelectedItems[0].SubItems[10].Text = "" + i.ArgType; UpdateGroupsColumn(lvItems.SelectedItems[0], 10);
                SIArg(i);
            }
            finally { internalchg = false; }
        }
    }
}