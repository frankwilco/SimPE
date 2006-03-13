using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung f�r BnfoCustomerItem.
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
		int appraisal;
		public int LoyaltyScore
		{
			get {return appraisal;}
			set {appraisal = value;}
		}

		int loyalty;
		public int DisplayedLoyalty
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
			appraisal = reader.ReadInt32();
			data = reader.ReadBytes(data.Length);
			loyalty = reader.ReadInt32();

			endpos = reader.BaseStream.Position;
			
		}

		internal  void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(siminst);
			writer.Write(appraisal);
			writer.Write(data);
			writer.Write(loyalty);
		}

		public override string ToString()
		{
			string s = "";
			if (SimDescription!=null) 
				s = SimDescription.SimName+" "+SimDescription.SimFamilyName;

			return Helper.HexString((ushort)endpos)+": "+s + " (0x"+Helper.HexString(SimInstance)+"): "+" "+loyalty.ToString()+" "+appraisal.ToString();
		}

	}
}
