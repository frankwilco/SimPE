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
	public class WrapperFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory
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
										  new MyPackedFileWrapper()
									  };
				return wrappers;
			}
		}

		#endregion

	}
}
