using System;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class MyPackedFileUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		private MyPackedFileForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public MyPackedFileUI()
		{
			form = new MyPackedFileForm();

			//
			// TODO: Add your Contructor Stuff here (if needed)
			//
		}
		#endregion

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Panel GUIHandle
		{
			get
			{
				return form.wrapperPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <param name="wrapper">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrapper)
		{
			form.wrapper = (IFileWrapperSaveExtension)wrapper;

			MyPackedFileWrapper mywrapper = (MyPackedFileWrapper) wrapper;
			form.rtb.Text = mywrapper.Data;
		}		

		#endregion
	}
}
