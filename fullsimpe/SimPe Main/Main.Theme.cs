using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe
{
    partial class MainForm
    {
        void InitTheme()
        {
            //setup the Theme Manager
            ThemeManager.Global.AddControl(this.sdm);
            ThemeManager.Global.AddControl(this.tbResource);
            ThemeManager.Global.AddControl(this.xpGradientPanel1);
            ThemeManager.Global.AddControl(this.xpGradientPanel2);
            ThemeManager.Global.AddControl(this.xpGradientPanel3);
            ThemeManager.Global.AddControl(this.menuBar1);
            ThemeManager.Global.AddControl(this.miAction);

            ThemeManager.Global.AddControl(tbAction);
            ThemeManager.Global.AddControl(tbTools);
            ThemeManager.Global.AddControl(tbWindow);
            ThemeManager.Global.AddControl(toolBar1);
            ThemeManager.Global.AddControl(tbResource);
            ThemeManager.Global.AddControl(tbContainer);
        }

        private void StoreLayout()
        {
            Ambertation.Windows.Forms.Serializer.Global.ToFile(SimPe.Helper.LayoutFileName);
            ////RECHECK
            Helper.WindowsRegistry.Layout.SandBarLayout = "";
            Helper.WindowsRegistry.Layout.SandDockLayout = sdm.GetLayout();
            MyButtonItem.SetLayoutInformations(this);

            Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = this.tbPlugAction.IsExpanded;
            Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = this.tbDefaultAction.IsExpanded;
            Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = this.tbExtAction.IsExpanded;

            Helper.WindowsRegistry.Layout.TypeColumnWidth = this.lv.Columns[0].Width;
            Helper.WindowsRegistry.Layout.GroupColumnWidth = this.lv.Columns[1].Width;
            Helper.WindowsRegistry.Layout.InstanceHighColumnWidth = this.lv.Columns[2].Width;
            Helper.WindowsRegistry.Layout.InstanceColumnWidth = this.lv.Columns[3].Width;

            if (lv.Columns.Count > 4)
            {
                Helper.WindowsRegistry.Layout.OffsetColumnWidth = this.lv.Columns[4].Width;
                Helper.WindowsRegistry.Layout.SizeColumnWidth = this.lv.Columns[5].Width;
            }
        }


        void ChangedTheme(GuiTheme gt)
        {
            ThemeManager.Global.CurrentTheme = gt;
        }

        string sdmdef;
        System.IO.Stream defaultlayout;
        /// <summary>
        /// Wrapper needed to call the Layout Change through an Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ResetLayout(object sender, EventArgs e)
        {
            Helper.WindowsRegistry.Layout.SandBarLayout = "";
            Helper.WindowsRegistry.Layout.SandDockLayout = sdmdef;
            if (defaultlayout != null)
            {
                Ambertation.Windows.Forms.Serializer.Global.FromStream(defaultlayout);
                Ambertation.Windows.Forms.Serializer.Global.ToFile(Helper.LayoutFileName);
            }
            Commandline.ForceModernLayout();

            Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = false;
            Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = true;
            Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = false;

            Helper.WindowsRegistry.Layout.TypeColumnWidth = 204;
            Helper.WindowsRegistry.Layout.GroupColumnWidth = 100;
            Helper.WindowsRegistry.Layout.InstanceHighColumnWidth = 100;
            Helper.WindowsRegistry.Layout.InstanceColumnWidth = 100;
            Helper.WindowsRegistry.Layout.OffsetColumnWidth = 100;
            Helper.WindowsRegistry.Layout.SizeColumnWidth = 100;

            ReloadLayout();
        }


        /// <summary>
        /// Reload the Layout from the Registry
        /// </summary>
        void ReloadLayout()
        {
            //store defaults
            if (sdmdef == null) sdmdef = sdm.GetLayout();
            if (defaultlayout == null) 
                defaultlayout = Ambertation.Windows.Forms.Serializer.Global.ToStream();

            try
            {
                Ambertation.Windows.Forms.Serializer.Global.FromFile(Helper.LayoutFileName);                
                if (Helper.WindowsRegistry.Layout.SandDockLayout != "") sdm.SetLayout(Helper.WindowsRegistry.Layout.SandDockLayout);
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }           


            this.lv.Columns[0].Width = Helper.WindowsRegistry.Layout.TypeColumnWidth;
            this.lv.Columns[1].Width = Helper.WindowsRegistry.Layout.GroupColumnWidth;
            this.lv.Columns[2].Width = Helper.WindowsRegistry.Layout.InstanceHighColumnWidth;
            this.lv.Columns[3].Width = Helper.WindowsRegistry.Layout.InstanceColumnWidth;

            if (this.lv.Columns.Count > 4)
            {
                this.lv.Columns[4].Width = Helper.WindowsRegistry.Layout.OffsetColumnWidth;
                this.lv.Columns[5].Width = Helper.WindowsRegistry.Layout.SizeColumnWidth;
            }

            UpdateDockMenus();
            MyButtonItem.GetLayoutInformations(this);
        }
    }
}
