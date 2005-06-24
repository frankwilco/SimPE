using System;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ImportSemiTool.
	/// </summary>
	public class CareerTool : Interfaces.ITool
	{
		/// <summary>
		/// Windows Registry Link
		/// </summary>
		static SimPe.Registry registry;
		internal static Registry WindowsRegistry 
		{
			get { return registry; }
		}

		IWrapperRegistry reg;
		IProviderRegistry prov;

		internal CareerTool(IWrapperRegistry reg, IProviderRegistry prov) 
		{
			this.reg = reg;
			this.prov = prov;

			if (registry==null) registry = Helper.WindowsRegistry;
		}

		#region ITool Member

		internal static string DefaultCareerFile		
		{
			get 
			{
				if (Helper.WindowsRegistry.EPInstalled==1)
					return System.IO.Path.Combine(Helper.SimPeDataPath, "ep1base.career");
				else
					return System.IO.Path.Combine(Helper.SimPeDataPath, "base.career");
			}
		}

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			if (System.IO.File.Exists(DefaultCareerFile)) return true;

			if (package==null) return false;
			Interfaces.Files.IPackedFileDescriptor[] globals  = package.FindFiles(Data.MetaData.GLOB_FILE); //global data
			if (globals.Length!=1) return false;
			SimPe.Plugin.Glob glob = new SimPe.Plugin.Glob();
			glob.ProcessData(globals[0], package);
			return (glob.SemiGlobalName == "JobDataGlobals");
		}

		public Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			CareerEditor careerEditor = new CareerEditor();			
			return careerEditor.Execute(ref pfd, ref package, prov);
		}

		public override string ToString()
		{
			return "Bidou's Career Editor...";
		}

		#endregion
	}
}
