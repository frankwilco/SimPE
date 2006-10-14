#define WRAPPER_PLUGIN  //Disable this line, if you do not want to offer a Packed File Wrapper
#define WINDOW_PLUGIN   //Disable this line if you do not want to offer a Windowed Plugin
#define DOCKED_PLUGIN   //Disable this line if you do not want to offer a Docked Plugin

using System;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// Lists all Plugins (=FileType Wrappers) available in this Package
	/// </summary>
	/// <remarks>
	/// GetWrappers() has to return a list of all Plugins provided by this Library. 
	/// If a Plugin isn't returned, SimPe won't recognize it!
	/// </remarks>
	public class MyWrapperFactory 
        : 
        SimPe.Interfaces.Plugin.AbstractWrapperFactory   //This Interface allows your Plugin to offer packed File Wrappers
        , SimPe.Interfaces.Plugin.IToolFactory           //This Interface allows your Plugin to offer a Windowed Plugin
	{


		#region AbstractWrapperFactory Member
		/// <summary>
		/// Returns a List of all available Plugins in this Package
		/// </summary>
		/// <returns>A List of all provided Plugins (=FileType Wrappers)</returns>
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{
				// TODO:  You can add more Wrappers here
				IWrapper[] wrappers = {
#if WRAPPER_PLUGIN
										  new MyPackedFileWrapper()
#endif
									  };
				return wrappers;
			}
		}

		#endregion


        #region IToolFactory Member

        public IToolPlugin[] KnownTools
        {
            get { 
                // TODO: You can add mor windowsd Plugins here
                IToolPlugin[] tools = {
#if WINDOW_PLUGIN
                    new MyWindowPlugin(),
#endif
#if DOCKED_PLUGIN
                    new MyDockPlugin(),
#endif
                };

                return tools;
            }
        }

        #endregion

    }
}
