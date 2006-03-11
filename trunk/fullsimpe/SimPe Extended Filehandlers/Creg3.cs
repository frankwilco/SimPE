using System;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für Creg3.
	/// </summary>
	public class Creg3 : ICregGroup
	{
		public class Creg3Item
		{
			string n, v;
			public Creg3Item(string name, string val)
			{
				n = name;
				v = val;
			}

			public string Name
			{
				get {return n;}				
			}

			public string Value
			{
				get {return v;}
				set {v = value;}
			}
		}


		Creg3Item[] items;
		public Creg3()
		{
			items = new Creg3Item[3];
			
			items[0] = new Creg3Item("GUID", System.Guid.NewGuid().ToString().Replace("-", ""));
			items[1] = new Creg3Item("CRC", "00000000000000000000000000000000");
			items[2] = new Creg3Item("Version", "01");
		}

		public Guid Guid
		{
			get 
			{
				Creg3Item i = FindItem("GUID");
				return new System.Guid(i.Value);
			}
			set 
			{
				Creg3Item i = FindItem("GUID");
				i.Value = value.ToString().Replace("-", "");
			}
		}

		public Guid Crc
		{
			get 
			{
				Creg3Item i = FindItem("CRC");
				return new System.Guid(i.Value);
			}
			set 
			{
				Creg3Item i = FindItem("CRC");
				i.Value = value.ToString().Replace("-", "");
			}
		}

		public int Version
		{
			get 
			{
				Creg3Item i = FindItem("Version");
				return Helper.StringToInt32(i.Value, 1, 10);
			}
			set 
			{
				Creg3Item i = FindItem("Version");
				i.Value = value.ToString();
			}
		}


		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			int ct = reader.ReadInt32();
			items = new Creg3Item[ct];
			for (int i=0; i<ct; i++)
			{
				string s1 = StreamHelper.ReadString(reader);
				string s2 = StreamHelper.ReadString(reader);

				items[i] = new Creg3Item(s1, s2);
			}
		}

		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write((int)items.Length);
			foreach (Creg3Item i in items) 
			{
				StreamHelper.WriteString(writer, i.Name);
				StreamHelper.WriteString(writer, i.Value);
			}
		}	

		Creg3Item FindItem(string n)
		{
			for (int i=0; i<items.Length; i++)
				if (items[i].Name == n)
					return items[i];

			return null;
		}

		public bool Contains(string name)
		{
			Creg3Item i = FindItem(name);
			return i!=null;
		}

		public Creg3Item this[string name]
		{
			get { return FindItem(name);}
			set 
			{
				for (int i=0; i<items.Length; i++)
					if (items[i].Name == name)
						items[i] = value;				
			}
		}

		#region ICregGroup Member

		public uint Group
		{
			get
			{
				return 3;
			}
		}		

		#endregion
	}
}
