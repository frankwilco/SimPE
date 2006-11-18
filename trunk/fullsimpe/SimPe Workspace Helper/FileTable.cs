using System;
using System.Collections;
using System.Xml;
using SimPe.Interfaces.Wrapper;

namespace SimPe
{

	/// <summary>
	/// use this Class to access the FileIndex
	/// </summary>
	public class FileTable : FileTableBase
	{
		static SimPe.Interfaces.IToolRegistry treg;
		/// <summary>
		/// Returns/Sets a ToolRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IToolRegistry ToolRegistry
		{
			get { return treg; }
			set { 
				treg = value;
			}
		}

		static SimPe.Interfaces.IHelpRegistry hreg;
		/// <summary>
		/// Returns/Sets a HelpTopicRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IHelpRegistry HelpTopicRegistry
		{
			get { return hreg; }
			set { hreg = value;}
		}
		

		static SimPe.Interfaces.ISettingsRegistry sreg;
		/// <summary>
		/// Returns/Sets a SettingsRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.ISettingsRegistry SettingsRegistry
		{
			get { return sreg; }
			set { sreg = value;}
		}

		public static void Reload()
		{
			FileTable.FileIndex.BaseFolders.Clear();			
			FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;
			FileTable.FileIndex.ForceReload();
		}

       
		
	}
}
