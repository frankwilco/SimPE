using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// This Interface is provided by classes, that can read, process and install a file of a certain type
	/// </summary>
	/// <remarks>Defining classes must have a public Constructur that takes a Filename stirng</remarks>
	public interface IPackageHandler
	{		
		IPackageInfo[] Objects
		{
			get;
		}

		void FreeResources();
	}
}
