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
			set { treg = value;}
		}

		static ThemeManager tm;
		/// <summary>
		/// Returns the Main ThemeManager
		/// </summary>
		public static ThemeManager ThemeManager 
		{
			get 
			{ 
				if (tm==null) tm = new ThemeManager((GuiTheme)Helper.WindowsRegistry.SelectedTheme);
				return tm;
			}
		}
	}
}
