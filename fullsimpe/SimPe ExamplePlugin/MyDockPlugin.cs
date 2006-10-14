using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Plugin
{
    /// <summary>
    /// This class provides a dockable Plugin
    /// </summary>
    public partial class MyDockPlugin 
        : Ambertation.Windows.Forms.DockPanel   //This makes sure this class is a Dock
        , SimPe.Interfaces.IDockableTool        //This interface is used to interact with SimPE
    {
        public MyDockPlugin()
            : base()
        {
            ///
            /// TODO: Make sure to set the apropriate names for your Plugins here
            /// 
            this.CaptionText = "Example Dock";
            this.ButtonText = "Example";
        }
        #region IDockableTool Member

        public event SimPe.Events.ChangedResourceEvent ShowNewResource;

        public Ambertation.Windows.Forms.DockPanel GetDockableControl()
        {
            return this;
        }

        public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs e)
        {
            ///
            /// TODO: Implemet everything you need to react on selection/package changes in the SimPE GUI
        }

        #endregion

        #region IToolExt Member

        public System.Drawing.Image Icon
        {
            get
            {
                ///
                /// TODO: You can return an Image here, that will be displayed as the Icon for your Plugin in the SimPE 
                /// Window Menu, and on teh Dock's Button.
                /// 
                return null;
            }
        }

        public System.Windows.Forms.Shortcut Shortcut
        {
            get
            {
                ///
                /// TODO: Return the Shurtcut key, that will show your Dock
                /// 
                return System.Windows.Forms.Shortcut.None;
            }
        }

        #endregion        
    }
}
