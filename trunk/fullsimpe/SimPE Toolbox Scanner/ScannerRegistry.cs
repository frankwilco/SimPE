using System;
using SimPe.Interfaces.Plugin.Scanner;

namespace SimPe.Plugin.Scanner
{
	/// <summary>
	/// This is a Registry , that contains all available Scanners and Identifiers
	/// </summary>
	public class ScannerRegistry
	{
		static ScannerRegistry glob;
		public static ScannerRegistry Global
		{
			get 
			{
				if (glob==null) glob = new ScannerRegistry();
				return glob;
			}
		}

		ScannerCollection scanners, identifiers;
		ScannerRegistry()
		{
			scanners = new ScannerCollection();
			identifiers = new ScannerCollection();
			LoadScanners();
		}

		/// <summary>
		/// Load all available Scanners in the plugins Folder (everything with the Extension *.plugin.dll)
		/// </summary>
		void LoadScanners() 
		{
			string[] files = System.IO.Directory.GetFiles(Helper.SimPePluginPath, "*.plugin.dll");
			scanners.Clear();

			foreach (string file in files) 
			{
				object[] args = new object[0];				
				object[] scnrs = SimPe.LoadFileWrappers.LoadPlugins(file, typeof(SimPe.Interfaces.Plugin.Scanner.IScannerPluginBase), args);
				foreach (IScannerPluginBase isb in scnrs) 
				{
					if (isb.Version==1) 
					{
						if (((byte)isb.PluginType&(byte)ScannerPluginType.Scanner)!=0) 
						{
							try 
							{
								IScanner sc = (IScanner)isb;
								scanners.Add(sc);
							} 
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("Unable to load Scanner.", ex);
							}
						} 
						else 
						{
							try 
							{
								IIdentifier i = (IIdentifier)isb;
								identifiers.Add(i);
							} 
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("Unable to load Identifier.", ex);
							}
						}
					}
				}
			}

			scanners.Sort(new SimPe.Plugin.Identifiers.PluginScannerBaseComparer());
			identifiers.Sort(new SimPe.Plugin.Identifiers.PluginScannerBaseComparer());
		}

		public ScannerCollection Scanners
		{
			get { return scanners;}
		}

		public ScannerCollection Identifiers
		{
			get { return identifiers;}
		}
	}
}
