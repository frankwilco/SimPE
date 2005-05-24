using System;
using System.Collections;

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// Specialization of an IRcol Interface, providing additional Methods to find refereced Scenegraph Resources
	/// </summary>
	public interface IScenegraphBlock
	{
		/// <summary>
		/// Adds all Referenced Scenegraph Resources sorted by type of Reference
		/// </summary>
		/// <param name="refmap"></param>
		/// <param name="parentgroup"></param>
		/// <remarks>The Key is the name of the Reference Type, the value is an ArrayList containing all ReferencedFiles</remarks>
		void ReferencedItems(Hashtable refmap, uint parentgroup);				
	}
}
