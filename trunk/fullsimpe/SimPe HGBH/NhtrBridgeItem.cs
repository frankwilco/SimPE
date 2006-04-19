using System;
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TileItem.
	/// </summary>
	public class NhtrBridgeItem : NhtrRoadItem
	{		
		byte marker3;	
		byte[] data2;
		internal NhtrBridgeItem(NhtrList parent) : base(parent)
		{					
			marker3 = 3;
			data2 = new byte[40];
		}					

		public byte[] Data2
		{
			get {return data2;}
		}

		public byte Marker3
		{
			get {return marker3;}
		}

		protected override void DoUnserialize(System.IO.BinaryReader reader)
		{	
			base.DoUnserialize(reader);
			
			marker3 = reader.ReadByte();
			data2 = reader.ReadBytes(data2.Length);
		}

		protected override void DoSerialize(System.IO.BinaryWriter writer) 
		{		
			base.DoSerialize(writer);

			writer.Write(marker3);
			writer.Write(data2);
		}

		public override string ToLongString()
		{
			string s = base.ToLongString()+Helper.lbr;
			s += "Marker 3: "+Helper.HexString(marker3)+Helper.lbr;	
			s += Helper.BytesToHexList(data2, 4);
			return s;
		}

				
		public override string ToString()
		{
			string s =base.ToString()+"   ";
			s += Helper.HexString(marker3)+"   ";
			s += Helper.BytesToHexList(data2);
						
			if (s.Length>0xff) s = s.Substring(0, 0xff)+"...";
			return s;
		}

	}
}
