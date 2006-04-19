using System;
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TileItem.
	/// </summary>
	public class NhtrDecorationItem : NhtrBaseItem
	{		
		protected uint guid;
		protected float rot;
		internal NhtrDecorationItem(NhtrList parent) : base(parent, 8)
		{								
		}

		[System.ComponentModel.TypeConverter(typeof(Ambertation.NumberBaseTypeConverter))]
		public uint GUID
		{
			get { return guid;}
			set { guid = value;}
		}		

		public float Rotation
		{
			get { return rot; }
			set { rot = value; }
		}		

		protected override void DoUnserialize(System.IO.BinaryReader reader)
		{	
			guid = reader.ReadUInt32();
			rot = reader.ReadSingle();			
		}

		protected override void DoSerialize(System.IO.BinaryWriter writer) 
		{					
			writer.Write(guid);
			writer.Write(rot);			
		}

		public override string ToLongString()
		{
			string s = "";
			s += "Marker: "+Helper.HexString(marker)+Helper.lbr;
			s += "Marker 2: "+Helper.HexString(marker2)+Helper.lbr;
			s += "GUID: "+Helper.HexString(this.guid)+Helper.lbr;
			s += "Rotation: "+this.rot+Helper.lbr;
			s += "Position: "+pos.ToString()+Helper.lbr;
			s += "BoundingBox: "+min.ToString()+" / "+max.ToString()+Helper.lbr;
			return s;
		}

				
		public override string ToString()
		{
			string s = Helper.HexString(marker)+"   ";
			s += Helper.HexString(marker2)+"   ";
			s += Helper.HexString(GUID)+"   ";
			s += this.rot+"   ";
			s += pos.ToString()+"   ";
			s += min.ToString()+"   ";
			s += max.ToString()+"   ";

			if (s.Length>0xff) s = s.Substring(0, 0xff)+"...";
			return s;
		}

	}
}
