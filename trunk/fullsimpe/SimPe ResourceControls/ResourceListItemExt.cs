using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    public class ResourceListItemExt : System.Windows.Forms.ListViewItem
    {
        static System.Drawing.Font regular = null;
        static System.Drawing.Font strike = null;

        NamedPackedFileDescriptor pfd;
        ResourceViewManager manager;
        internal ResourceListItemExt(NamedPackedFileDescriptor pfd, ResourceViewManager manager, bool visible)
            : base()
        {
            if (regular == null)
            {
                regular = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Regular, Font.Unit);
                strike = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Strikeout, Font.Unit);
            }

            this.manager = manager;
            this.pfd = pfd;
            if (visible)
                this.Text = pfd.GetRealName();
            else
                this.Text = pfd.ToString();

            this.SubItems.Add("0x" + Helper.HexString(pfd.Descriptor.Group));
            this.SubItems.Add("0x" + Helper.HexString(pfd.Descriptor.SubType));
            this.SubItems.Add("0x" + Helper.HexString(pfd.Descriptor.Instance));
            this.SubItems.Add("0x" + Helper.HexString(pfd.Descriptor.Offset));
            this.SubItems.Add("0x" + Helper.HexString(pfd.Descriptor.Size));

            this.ImageIndex = ResourceViewManager.GetIndexForResourceType(pfd.Descriptor.Type);

            ChangeDescription(true);
        }        

        ~ResourceListItemExt()
        {
            
        }                

        /// <summary>
        /// Set the Description for this ListViewItem
        /// </summary>
        void ChangeDescription(bool justfont)
        {
            if (!justfont)
            {
                this.SubItems[1].Text = "0x" + Helper.HexString(pfd.Descriptor.Group);
                this.SubItems[2].Text = "0x" + Helper.HexString(pfd.Descriptor.SubType);
                this.SubItems[3].Text = "0x" + Helper.HexString(pfd.Descriptor.Instance);
                this.SubItems[4].Text = "0x" + Helper.HexString(pfd.Descriptor.Offset);
                this.SubItems[5].Text = "0x" + Helper.HexString(pfd.Descriptor.Size);
            }

            System.Drawing.Color fg = System.Drawing.SystemColors.WindowText;
            System.Drawing.Font font = regular;

            if (pfd.Descriptor.MarkForDelete)
            {
                fg = System.Drawing.SystemColors.GrayText;
                font = strike;
            }
            if (pfd.Descriptor.MarkForReCompress || (pfd.Descriptor.WasCompressed && !pfd.Descriptor.HasUserdata))
            {
                fg = System.Drawing.SystemColors.Highlight;
                //font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style, font.Unit);
            }

            if (pfd.Descriptor.MarkForReCompress)
                font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style | System.Drawing.FontStyle.Bold, font.Unit);

            if (pfd.Descriptor.Changed)
                font = new System.Drawing.Font(font.FontFamily, font.Size, font.Style | System.Drawing.FontStyle.Italic, font.Unit);

            this.Font = font;
            this.ForeColor = fg;
        }
    }
}
