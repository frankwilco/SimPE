using System;
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NhtrLocation.
	/// </summary>
	[System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
	public class NhtrLocation
	{
		Vector3f pos;
		float o1, o2;

		public NhtrLocation()
		{
			pos = Vector3f.Zero;
		}

		public Vector3f Position
		{
			get {return pos;}
			set {pos = value;}
		}

		public float Orientation1
		{
			get { return o1;}
			set { o1 = value;}
		}

		public float Orientation2
		{
			get { return o2;}
			set { o2 = value;}
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{						
			pos.Y = reader.ReadSingle();
			pos.X = reader.ReadSingle();
			pos.Z = reader.ReadSingle();

			o1 = reader.ReadSingle();
			o2 = reader.ReadSingle();
		}

		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write((float)pos.Y);
			writer.Write((float)pos.X);
			writer.Write((float)pos.Z);

			writer.Write(o1);
			writer.Write(o2);
		}

		public override string ToString()
		{
			return pos.ToString()+" ["+o1.ToString()+", "+o1.ToString()+"]";
		}

	}
}
