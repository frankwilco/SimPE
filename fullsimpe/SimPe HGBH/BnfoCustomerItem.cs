using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für BnfoCustomerItem.
	/// </summary>
	public class BnfoCustomerItem
	{
		ushort siminst;
		public ushort SimInstance
		{
			get {return siminst;}
			set {
				siminst = value;
				sdsc = null;
			}
		}
		int loyalty;
		public int LoyaltyScore
		{
			get {return loyalty;}
			set {loyalty = value;}
		}

		public int LoyaltyStars
		{
			get {return (int)Math.Ceiling((float)LoyaltyScore / 200.0);}
			set {LoyaltyScore = (value * 200);}
		}

		int lloyalty;
		public int LoadedLoyalty
		{
			get {return loyalty;}
			set {loyalty = value;}
		}
		
		byte[] data;

		internal byte[] Data 
		{
			get {return data;}
		}

		Bnfo parent;
		SimPe.PackedFiles.Wrapper.ExtSDesc sdsc;
		public SimPe.PackedFiles.Wrapper.ExtSDesc SimDescription
		{
			get 
			{
				if (sdsc==null) 				
					sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance[SimInstance] as SimPe.PackedFiles.Wrapper.ExtSDesc;				
				return sdsc;
			}
		}		

		internal BnfoCustomerItem(Bnfo parent)
		{
			this.parent = parent;
			data = new byte[0x60];			
		}

		long endpos;
		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			SimInstance = reader.ReadUInt16();
			loyalty = reader.ReadInt32();
			data = reader.ReadBytes(data.Length);
			lloyalty = reader.ReadInt32();

			endpos = reader.BaseStream.Position;
			
		}

		internal  void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(siminst);
			writer.Write(loyalty);
			writer.Write(data);
			writer.Write(this.LoyaltyStars);
		}

		public override string ToString()
		{
			string s = "";
			if (SimDescription!=null) 
				s = SimDescription.SimName+" "+SimDescription.SimFamilyName;

			return /*Helper.HexString((ushort)endpos)+": "+*/s + " (0x"+Helper.HexString(SimInstance)+"): "+" "+loyalty.ToString()+" ("+lloyalty.ToString()+")";
		}

	}
}
