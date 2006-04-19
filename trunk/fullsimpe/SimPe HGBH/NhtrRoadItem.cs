using System;
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für TileItem.
	/// </summary>
	public class NhtrRoadItem : NhtrBaseItem
	{		
		
		NhtrLocation topleft, topright, botright, botleft;
		uint texture;
		byte[] data;
		internal NhtrRoadItem(NhtrList parent) : base(parent, 3)
		{		
			topleft = new NhtrLocation();
			topright = new NhtrLocation();
			botleft = new NhtrLocation();
			botright = new NhtrLocation();
			texture = 0x00000300;

			data = new byte[10];
		}	
		
		[System.ComponentModel.Category("Placement")]
		public NhtrLocation TopLeft
		{
			get {return topleft;}
			set {topleft = value;}
		}

		[System.ComponentModel.Category("Placement")]
		public NhtrLocation TopRight
		{
			get {return topright;}
			set {topright = value;}
		}

		[System.ComponentModel.Category("Placement")]
		public NhtrLocation BottomLeft
		{
			get {return botleft;}
			set {botleft = value;}
		}

		[System.ComponentModel.Category("Placement")]
		public NhtrLocation BottomRight
		{
			get {return botright;}
			set {botright = value;}
		}

		[System.ComponentModel.TypeConverter(typeof(Ambertation.NumberBaseTypeConverter))]
		public uint Texture
		{
			get {return texture;}
			set {texture = value;}
		}

		public byte[] Data
		{
			get {return data;}
		}

		protected override void DoUnserialize(System.IO.BinaryReader reader)
		{	
			topleft.Unserialize(reader);
			topright.Unserialize(reader);
			botleft.Unserialize(reader);
			botright.Unserialize(reader);

			texture = reader.ReadUInt32();
			data = reader.ReadBytes(data.Length);
			//reader.ReadByte();
		}

		protected override void DoSerialize(System.IO.BinaryWriter writer) 
		{		
			topleft.Serialize(writer);
			topright.Serialize(writer);
			botleft.Serialize(writer);
			botright.Serialize(writer);

			writer.Write(texture);
			writer.Write(data);
		}

		public override string ToLongString()
		{
			string s = "";
			s += "Marker: "+Helper.HexString(marker)+Helper.lbr;
			s += "Marker 2: "+Helper.HexString(marker2)+Helper.lbr;			
			s += "Position: "+pos.ToString()+Helper.lbr;
			s += "BoundingBox: "+min.ToString()+" / "+max.ToString()+Helper.lbr;
			s += "Top-Left: "+topleft.ToString()+Helper.lbr;
			s += "Top-Right: "+topright.ToString()+Helper.lbr;
			s += "Bottom-Left: "+botleft.ToString()+Helper.lbr;
			s += "Bottom-Right: "+botright.ToString()+Helper.lbr;
			s += "Texture: "+Helper.HexString(texture)+Helper.lbr;	
			s += Helper.BytesToHexList(data, 4);
			return s;
		}

				
		public override string ToString()
		{
			string s = Helper.HexString(marker)+"   ";
			s += Helper.HexString(marker2)+"   ";
			s += Helper.HexString(texture)+"   ";
			s += Helper.BytesToHexList(data);
			s += pos.ToString()+"   ";
			s += min.ToString()+"   ";
			s += max.ToString()+"   ";
			s += topleft.ToString()+"   ";
			s += topright.ToString()+"   ";
			s += botleft.ToString()+"   ";
			s += botright.ToString()+"   ";
			
			

			if (s.Length>0xff) s = s.Substring(0, 0xff)+"...";
			return s;
		}

	}
}
