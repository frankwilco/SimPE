using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    [System.ComponentModel.ToolboxItem(false)]
    public  partial  class AScorItem : UserControl
    {
        ScorItem parent;
        string name;
        public string TokenName
        {
            get { return name; }
        }
        public ScorItem ParentItem
        {
            get { return parent; }
        }

        [DesignerSerializationVisibility( DesignerSerializationVisibility.Hidden), Browsable(false)]
        public bool Changed
        {
            get { 
                if (parent!=null)
                    if (parent.Parent !=null)
                        return parent.Parent.Changed;

                return false;
            }
            set {
                if (parent != null)
                    if (parent.Parent != null)                        
                        parent.Parent.Changed = value; 
            }
        }

        internal AScorItem()
            : this(new ScorItem(null))
        {
            name = "";
        }

        internal AScorItem(ScorItem si)
        {
            this.parent = si;
            InitializeComponent();
        }

        internal virtual void SetData(string name, System.IO.BinaryReader reader)
        {
            this.name = name;
        }

        internal virtual void Serialize(System.IO.BinaryWriter writer)
        {
            StreamHelper.WriteString(writer, name);
        }
    }
}
