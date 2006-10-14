using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Plugin
{
    /// <summary>
    /// An instance of this class will hook into SimPEs Tools Menu, allowing the users to start your Plugin
    /// </summary>
    public class MyWindowPlugin : SimPe.Interfaces.IToolPlus
    {
        #region IToolPlus Member

        public void Execute(object sender, SimPe.Events.ResourceEventArgs e)
        {
            if (!ChangeEnabledStateEventHandler(sender, e)) return;


            MyWindowPluginForm f = new MyWindowPluginForm();
            ///
            /// TODO: Do some initialization work with your Form
            /// 
            f.ShowDialog();
            ///
            /// TODO: Do some finalization work with your Form
            /// 
            f.Dispose();
        }

        public bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
        {
            ///
            /// TODO: return true here, if the Plugin should be enabled, and false otherwise
            /// e contains a List of Resources selected in the SimPE GUI as well as the currently 
            /// loaded package
            /// 
            return true;
        }

        #endregion

        #region IToolExt Member

        public System.Drawing.Image Icon
        {
            get { 
                ///
                /// TODO: You can return an Image here, that will be displayed as the ICon for your Plugin in the SimPE Plugin Menu.
                /// 
                return null; 
            }
        }

        public System.Windows.Forms.Shortcut Shortcut
        {
            get {
                ///
                /// TODO: Return the Shurtcut key, that will start your Plugin
                /// 
                return System.Windows.Forms.Shortcut.None;
            }
        }

        public bool Visible
        {
            get { 
                ///
                /// TODO: Return false here, if you donÄt want your Plugin to show up in the Plugins Menus, but still want to catch the 
                /// ChangeEnabledStateEventHandler Event
                /// 
                return true; 
            }
        }

        #endregion

        public override string ToString()
        {
            ///
            /// TODO: Return the Name of your Plugin here
            /// 
            return "Object Creation\\Example Plugin";
        }
    }
}
