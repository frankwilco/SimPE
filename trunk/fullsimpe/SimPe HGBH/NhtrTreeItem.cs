using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TileItem.
	/// </summary>
	public class NhtrTreeItem : NhtrDecorationItem
	{
		
		internal NhtrTreeItem(NhtrList parent) : base(parent)
		{					
		}		
		
		protected override void DoUnserialize(System.IO.BinaryReader reader)
		{				
			rot = reader.ReadSingle();			
			guid = reader.ReadUInt32();
		}

		protected override void DoSerialize(System.IO.BinaryWriter writer) 
		{								
			writer.Write(rot);			
			writer.Write(guid);
		}
	}
}
