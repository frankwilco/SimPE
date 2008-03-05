using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin.Tool.Dockable.Finder
{
    public partial class FindInNref : FindInStr
    {
        public FindInNref(SimPe.Interfaces.IFinderResultGui rgui)
            : base(rgui)
        {
            InitializeComponent();
        }

        public FindInNref() : this(null) { }

        public override bool ProcessParalell
        {
            get
            {
                return true;
            }
        }



        public override void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
        {
            if (pfd.Type != 0x4E524546) return;
            SimPe.PackedFiles.Wrapper.Nref nref = new Nref();
            nref.ProcessData(pfd, pkg);


            bool found = false;
            string n = nref.FileName.Trim().ToLower();
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
