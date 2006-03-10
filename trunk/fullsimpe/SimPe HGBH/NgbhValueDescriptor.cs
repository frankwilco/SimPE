using System;	

namespace SimPe.Plugin
{
	public enum NgbhValueDescriptorType : byte
	{
		Skill,
		ToddlerSkill,
		Badge
	}
	/// <summary>
	/// Describes Skills, and Badges
	/// </summary>
	public class NgbhValueDescriptor
	{
		
		string name;
		uint guid, fullguid;
		int valuenr, fullnr;
		short min, max;
		NgbhValueDescriptorType type;
		bool intern;
		
		public NgbhValueDescriptor(string name, bool intern, NgbhValueDescriptorType type, uint guid, int valuenr, short min, short max, int fullnr) : this (name, intern, type, guid, valuenr, min, max, guid, fullnr) {}
		public NgbhValueDescriptor(string name, bool intern, NgbhValueDescriptorType type, uint guid) : this (name, intern, type, guid, 0, -1, -1, 0xffffffff, -1) {}		
		public NgbhValueDescriptor(string name, bool intern, NgbhValueDescriptorType type, uint guid, int valuenr) : this (name, intern, type, guid, valuenr, -1, -1, 0xffffffff, -1) {}		
		public NgbhValueDescriptor(string name, bool intern, NgbhValueDescriptorType type, uint guid, int valuenr, short min, short max) : this (name, intern, type, guid, valuenr, min, max, 0xffffffff, -1) {}		
		NgbhValueDescriptor(string name, bool intern, NgbhValueDescriptorType type, uint guid, int valuenr, short min, short max, uint fullguid, int fullnr)
		{
			this.name = name;
			this.guid = guid;
			this.fullguid = fullguid;
			this.valuenr = valuenr;
			this.fullnr = fullnr;
			this.max = max;
			this.min = min;
			this.type = type;
			this.intern = intern;
		}

		public bool Intern
		{
			get {return intern;}
		}

		public NgbhValueDescriptorType Type
		{
			get 
			{
				return type;
			}
		}

		public bool HasComplededFlag
		{
			get {return fullnr>=0;}
		}

		 uint CompletedGuid
		{
			get {return fullguid;}
		}

		public uint Guid
		{
			get {return guid;}
		}

		public int CompletedDataNumber
		{
			get {return fullnr;}
		}

		public int DataNumber
		{
			get {return valuenr;}
		}

		public short Minimum
		{
			get {return min;}
		}

		public short Maximum
		{
			get {return max;}
		}


		public override string ToString()
		{
			return name;
		}

	}
}
