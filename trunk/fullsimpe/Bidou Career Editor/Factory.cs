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
	public class WrapperFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory, SimPe.Interfaces.Plugin.IToolFactory
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
										  
									  };
				return wrappers;
			}
		}

		#endregion

		#region IToolFactory Member

		public ITool[] KnownTools
		{
			get
			{
				ITool[] tools = {
									new CareerTool(this.LinkedRegistry, this.LinkedProvider)
								};
				return tools;
			}
		}

		#endregion
	}
}