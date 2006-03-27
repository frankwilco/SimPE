using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TileItem.
	/// </summary>
	public class NhtrItem
	{
		uint offset;
		byte[] data;		
		byte type;
		
		public NhtrItem()
		{
			offset = 0xffffffff;
			data = new byte[0];
		}
		public byte[] Data 
		{
			get {return data;}
		}

		internal void Unserialize(System.IO.BinaryReader reader, int ct)
		{	
			offset = (uint)reader.BaseStream.Position;
			type = reader.ReadByte();
										
			data = reader.ReadBytes(ct);
		}

		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(data);
		}

		public override string ToString()
		{
			string s = Helper.HexString(offset)+": "+Helper.HexString(type)+"   "+Helper.BytesToHexList(data);
			if (s.Length>0xff) s = s.Substring(0, 0xff)+"...";
			return s;
		}

	}
}
