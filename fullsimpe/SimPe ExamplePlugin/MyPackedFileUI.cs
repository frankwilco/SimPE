using System;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
    public partial class MyPackedFileUI :
        SimPe.Windows.Forms.WrapperBaseControl,     //This gives your Plugin the right look (gradient background, commit button)
        IPackedFileUI                              //This Interfaces is needed to provide a UI for your Wrapper
    {
        

        protected new MyPackedFileWrapper Wrapper
        {
            get { return base.Wrapper as MyPackedFileWrapper; }
        }

        #region WrapperBaseControl Member
        protected override void RefreshGUI()
        {
            base.RefreshGUI();
            ///
            /// TODO: Do soemthing to show the Content of this.Wrapper on your UI
            /// 
        }

        public override void OnCommit()
        {
            base.OnCommit();
            ///
            /// TODO: take the apropriate steps to commit the changes made on the GUI to the resource. 
            /// You most likley want to call Wrapper.SynchronizeUserData();
            /// 
            
        }
        #endregion

        #region IPackedFileUI Member

        System.Windows.Forms.Control IPackedFileUI.GUIHandle
        {
            get { return this; }
        }        

        #endregion

        #region IDisposable Member

        void IDisposable.Dispose()
        {
            ///
            /// TODO: Make sure all resources are disposed
            /// 
        }

        #endregion                        
    }
}
