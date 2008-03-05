using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable.Finder
{
    public partial class FindInSG : FindInStr
    {
        public FindInSG(SimPe.Interfaces.IFinderResultGui rgui)
            : base(rgui)
        {
            InitializeComponent();

            cbtypes.Items.Add("--- All ---");
            foreach (uint t in SimPe.Data.MetaData.RcolList)
            {
                cbtypes.Items.Add(SimPe.Data.MetaData.FindTypeAlias(t));
            }
            cbtypes.SelectedIndex = 0;
        }

        public FindInSG() : this(null) { }

        public override bool ProcessParalell
        {
            get
            {
                return false;
            }
        }

        uint type;
        protected override bool OnPrepareStart()
        {
            type = 0;
            if (cbtypes.SelectedIndex > 0)
            {
                type = ((SimPe.Data.TypeAlias)cbtypes.SelectedItem).Id;
            }
            return base.OnPrepareStart();
        }



        public override void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
        {
            bool found = false;
            
            if (type==0)
            {
                foreach (uint tt in SimPe.Data.MetaData.RcolList)
                    if (tt == pfd.Type)
                    {
                        found = true;
                        break;
                    }
            }
            else
            {
                found = type == pfd.Type;
            }

            if (!found) return;
            SimPe.Plugin.GenericRcol rcol = new GenericRcol(null, true);
            rcol.ProcessData(pfd, pkg);


            found = false;
            string n = rcol.FileName.Trim().ToLower();
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

            //we have a match, so add the result item
            if (found)
            {
                ResultGui.AddResult(pkg, pfd);
            }




        }
    }
}
