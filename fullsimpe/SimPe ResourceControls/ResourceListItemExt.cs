using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public class ResourceListItemExt : System.Windows.Forms.ListViewItem
    {
        static System.Drawing.Font regular = null;
        static System.Drawing.Font strike = null;

        bool vis;
        NamedPackedFileDescriptor pfd;
        ResourceViewManager manager;
        internal ResourceListItemExt(NamedPackedFileDescriptor pfd, ResourceViewManager manager, bool visible)
            : base()
        {
            this.vis = visible;
            if (regular == null)
            {
                regular = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Regular, Font.Unit);
                strike = new System.Drawing.Font(Font.FontFamily, Font.Size, System.Drawing.FontStyle.Strikeout, Font.Unit);
            }

            this.manager = manager;
            this.pfd = pfd;


            object[] subitems = new object[7];
            subitems[0] = visible ? pfd.GetRealName() : pfd.Descriptor.ToResListString(); // Name
            subitems[1] = GetExtText(); // Type
            subitems[2] = "0x" + Helper.HexString(pfd.Descriptor.Group); // Group
            subitems[3] = "0x" + Helper.HexString(pfd.Descriptor.SubType); // InstHi

            // Inst
            if (Helper.WindowsRegistry.ResourceListInstanceFormatHexOnly)
                subitems[4] = "0x" + Helper.HexString(pfd.Descriptor.Instance);
            else if (Helper.WindowsRegistry.ResourceListInstanceFormatDecOnly)
                subitems[4] = ((int)pfd.Descriptor.Instance).ToString();
            else
                subitems[4] = "0x" + Helper.HexString(pfd.Descriptor.Instance) + " (" + ((int)pfd.Descriptor.Instance).ToString() + ")";

            subitems[5] = "0x" + Helper.HexString(pfd.Descriptor.Offset);
            subitems[6] = "0x" + Helper.HexString(pfd.Descriptor.Size);


            List<string> order = Helper.WindowsRegistry.Layout.ColumnOrder;
            List<string> cn = new List<string>(colNames);
            this.SubItems.Clear();
            this.Text = (string)subitems[cn.IndexOf(order[0])];
            for (int i = 1; i < order.Count; i++)
                SubItems.Add((string)subitems[cn.IndexOf(order[i])]);


            this.ImageIndex = ResourceViewManager.GetIndexForResourceType(pfd.Descriptor.Type);

            /*pfd.Descriptor.ChangedData += new SimPe.Events.PackedFileChanged(Descriptor_ChangedData);
            pfd.Descriptor.ChangedUserData += new SimPe.Events.PackedFileChanged(Descriptor_ChangedUserData);
            pfd.Descriptor.DescriptionChanged += new EventHandler(Descriptor_DescriptionChanged);*/

            ChangeDescription(true);
        }
        static string[] colNames = new string[] { "Name", "Type", "Group", "InstHi", "Inst", "Offset", "Size" };

        string GetExtText()
        {
            if (Helper.WindowsRegistry.ResourceListExtensionFormat == Registry.ResourceListExtensionFormats.Short)
                return pfd.Descriptor.TypeName.shortname;
            if (Helper.WindowsRegistry.ResourceListExtensionFormat == Registry.ResourceListExtensionFormats.Long)
                return pfd.Descriptor.TypeName.Name;
            if (Helper.WindowsRegistry.ResourceListExtensionFormat == Registry.ResourceListExtensionFormats.Hex)
                return "0x"+Helper.HexString(pfd.Descriptor.Type);

            return "";
        }

        /*void Descriptor_DescriptionChanged(object sender, EventArgs e)
        {
            ChangeDescription(false);
        }

        void Descriptor_ChangedUserData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
        {         
            ChangeDescription(false);
        }

        void Descriptor_ChangedData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
        {            
            ChangeDescription(false);
        }        */

        ~ResourceListItemExt()
        {
            FreeResources();
        }

        internal bool Visible
        {
            get { return vis; }
            set
            {
                if (vis != value)
                {
                    vis = value;
                    if (vis) ChangeDescription(false);
                }
            }
        }
        internal void FreeResources(){
            /*pfd.Descriptor.ChangedData -= new SimPe.Events.PackedFileChanged(Descriptor_ChangedData);
            pfd.Descriptor.ChangedUserData -= new SimPe.Events.PackedFileChanged(Descriptor_ChangedUserData);
            pfd.Descriptor.DescriptionChanged -= new EventHandler(Descriptor_DescriptionChanged);*/
        }

        /// <summary>
        /// Set the Description for this ListViewItem
        /// </summary>
        void ChangeDescription(bool justfont)
        {
            if (!justfont)
            {
                pfd.ResetRealName();
                if (Visible)
                    this.Text = pfd.GetRealName();
                else
                    this.Text = pfd.Descriptor.ToResListString();

                if (Helper.WindowsRegistry.ResourceListShowExtensions) this.SubItems[1].Text = GetExtText();
                this.SubItems[2].Text = "0x" + Helper.HexString(pfd.Descriptor.Group);
                this.SubItems[3].Text = "0x" + Helper.HexString(pfd.Descriptor.SubType);
	            if (Helper.WindowsRegistry.ResourceListInstanceFormatHexOnly)
	                this.SubItems[4].Text = "0x" + Helper.HexString(pfd.Descriptor.Instance);
	            else if (Helper.WindowsRegistry.ResourceListInstanceFormatDecOnly)
	                this.SubItems[4].Text = ((int)pfd.Descriptor.Instance).ToString();
	            else
	                this.SubItems[4].Text = "0x" + Helper.HexString(pfd.Descriptor.Instance) + " (" + ((int)pfd.Descriptor.Instance).ToString() + ")";
                this.SubItems[5].Text = "0x" + Helper.HexString(pfd.Descriptor.Offset);
                this.SubItems[6].Text = "0x" + Helper.HexString(pfd.Descriptor.Size);
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
