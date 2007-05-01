using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable.Finder
{
    public partial class FindObj : FindInStr
    {
        public FindObj(SimPe.Interfaces.IFinderResultGui rgui)
            : base(rgui)
        {
            InitializeComponent();
            name = "";
            guid = 0;
        }

        public FindObj() : this(null) { }


        uint guid;
        protected override bool OnPrepareStart()
        {
            base.OnPrepareStart();

            guid = Helper.StringToUInt32(tbGUID.Text, 0, 16);

            return name != "" || guid > 0;
        }

        public override void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
        {
            if (pfd.Type != Data.MetaData.OBJD_FILE) return;

            SimPe.PackedFiles.Wrapper.ExtObjd obj = new SimPe.PackedFiles.Wrapper.ExtObjd();
            obj.ProcessData(pfd, pkg);

            bool found = false;

            if (name != "")
            {
                string n = obj.FileName.Trim().ToLower();
                if (compareType == CompareType.Equal)
                {
                    found = n == name;
                }
                else if (compareType == CompareType.Start)
                {
                    found = n.StartsWith(name);
                }
                else if (compareType == CompareType.End)
                {
                    found = n.EndsWith(name);
                }
                else if (compareType == CompareType.Contain)
                {
                    found = n.IndexOf(name) > -1;
                }
                else if (compareType == CompareType.RegExp && reg != null)
                {
                    found = reg.IsMatch(n);
                }
            }

            if (guid > 0 && (found || name==""))
            {
                found = obj.Guid == guid;
                
            }

            //we have a match, so add the result item
            if (found)
            {
                ResultGui.AddResult(pkg, pfd);
            }
        }
    }
}
