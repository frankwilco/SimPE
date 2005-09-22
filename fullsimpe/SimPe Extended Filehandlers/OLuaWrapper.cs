/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Collections;
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.Wrapper
{
	
	/// <summary>
	/// Represents a PackedFile in SDsc Format
	/// </summary>
	public class ObjLua : AbstractWrapper
		, System.Collections.IEnumerable
		, SimPe.Interfaces.Plugin.IFileWrapper
		, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper		
	{
		enum Endian : byte 
		{
			big = 0x0,
			little = 0x1
		}

		#region Attributes
		string flname; //this is only for the convenience of SimPE!

		uint id;
		byte version;
		Endian byteorder;
		byte intsz;
		byte sztsz;
		byte instsz;
		byte operandbits;
		public byte OpcodeBits
		{
			get {return operandbits; }
		}

		byte bits1;
		public byte ABits
		{
			get {return bits1; }
		}
		byte bits2;
		public byte BBits
		{
			get {return bits2; }
		}
		byte bits3;	
		public byte CBits
		{
			get {return bits3; }
		}

		byte nrsz;
		public byte NumberSize
		{
			get {return nrsz; }
		}
		byte[] sample;

		ArrayList items;	
	
		ObjLuaFunction root;
		public ObjLuaFunction Root 
		{
			get { return root; }
		}
		#endregion

		#region Code Properties 
		internal uint OpcodeMaks
		{
			get { return (uint)Math.Pow(2, this.OpcodeBits)-1;}
		}
		internal byte OpcodeShift 
		{
			get { return 0; }
		}

		internal uint AMaks
		{
			get { return (uint)Math.Pow(2, this.ABits)-1;}
		}
		internal byte AShift 
		{
			get { return (byte)(this.BShift + this.BBits); }
		}

		internal uint BMaks
		{
			get { return (uint)Math.Pow(2, this.BBits)-1;}
		}
		internal byte BShift 
		{
			get { return (byte)(this.CShift + this.CBits); }
		}
	
		internal uint CMaks
		{
			get { return (uint)Math.Pow(2, this.CBits)-1;}
		}
		internal byte CShift 
		{
			get { return (byte)(this.OpcodeShift+this.OpcodeBits); }			
		}

		internal int Bias
		{
			get 
			{
				return ((int)Math.Pow(2, BBits+CBits)-1) / 2;
			}
		}
		#endregion
	

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Object LUA Wrapper",
				"Quaxi",
				"LUA Resources are external Resources, which contain additional SimAntic Scripts.",
				1,
				null
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.ObjLua();
		}
		

		public ObjLua() : base()
		{			
			version = 0x50;
			byteorder = Endian.little;
			intsz = 4;
			sztsz = 4;
			instsz = 4;
			operandbits = 6;
			bits1 = 8;
			bits2 = 9;
			bits3 = 9;
			nrsz = 8;
			sample = new byte[] {0xb6, 0x09, 0x93, 0x68, 0xe7, 0xf5, 0x7d, 0x41};
			
			items = new ArrayList();
			flname = "";

			root = new ObjLuaFunction(this);
		}

		
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			items.Clear();

			flname = Helper.ToString(reader.ReadBytes(0x40));
			id = reader.ReadUInt32();
			
			version = reader.ReadByte();
			byteorder = (Endian)reader.ReadByte();

			intsz = reader.ReadByte();
			sztsz = reader.ReadByte();
			instsz = reader.ReadByte();

			operandbits = reader.ReadByte();
			bits1 = reader.ReadByte();
			bits2 = reader.ReadByte();
			bits3 = reader.ReadByte();

			nrsz = reader.ReadByte();
			sample = reader.ReadBytes(sample.Length);

			
			root.Unserialize(reader);
		}


		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			///TODO: complete this write
		}

		internal static string ReadString(System.IO.BinaryReader reader)
		{
			int ct = reader.ReadInt32();
			return Helper.ToString(reader.ReadBytes(ct));
		}

		internal static void WriteString(string s, System.IO.BinaryWriter writer)
		{
			writer.Write((uint)(s.Length+1));
			writer.Write(Helper.ToBytes(s, s.Length));
			writer.Write((byte)0);
		}
		#endregion

		#region IPackedFileWrapper Member

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0x61754C1B
							   };
				return Types;
			}
		}


		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {					 
							 };
				return sig;
			}
		}		
		#endregion

		#region IEnumerable Members
		public System.Collections.IEnumerator GetEnumerator ()
		{
			return items.GetEnumerator();
		}
		#endregion
	}

	public class ObjLuaFunction : System.IDisposable, System.Collections.IEnumerable
	{
	

		#region Attributes
		ObjLua parent;
		public ObjLua Parent
		{
			get {return parent;}
		}
	
		string name;
		uint linedef;
		byte nups;
		byte argc;
		byte isinout;
		byte stacksz;

		ArrayList contants, functions, codes, srcln, upval, local;

		public ArrayList Constants 
		{
			get { return contants; }
		}

		public ArrayList UpValues 
		{
			get { return upval; }
		}

		public ArrayList Locals 
		{
			get { return local; }
		}

		public ArrayList SourceLine 
		{
			get { return srcln; }
		}

		public ArrayList Functions 
		{
			get { return functions; }
		}

		public ArrayList Codes 
		{
			get { return codes; }
		}
		#endregion

		public ObjLuaFunction(ObjLua parent) 
		{
			this.parent = parent;
			name = "";

			contants = new ArrayList();
			functions = new ArrayList();
			codes = new ArrayList();
			srcln = new ArrayList();
			local = new ArrayList();
			upval = new ArrayList();
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			contants.Clear();
			functions.Clear();
			codes.Clear();
			srcln.Clear();
			local.Clear();
			upval.Clear();
			
			name = ObjLua.ReadString(reader);

			linedef = reader.ReadUInt32();
			nups = reader.ReadByte();
			argc = reader.ReadByte();
			isinout = reader.ReadByte();
			stacksz = reader.ReadByte();
			
			uint linenfosz = reader.ReadUInt32();
			for (uint i=0; i<linenfosz; i++)
			{
				ObjLuaSourceLine item = new ObjLuaSourceLine(this);
				item.Unserialize(reader);

				srcln.Add(item);
			}

			uint locvarsz = reader.ReadUInt32();
			for (uint i=0; i<locvarsz; i++)
			{
				ObjLuaLocalVar item = new ObjLuaLocalVar(this);
				item.Unserialize(reader);

				local.Add(item);
			}

			uint upvalsz = reader.ReadUInt32();
			for (uint i=0; i<upvalsz; i++)
			{
				ObjLuaUpValue item = new ObjLuaUpValue(this);
				item.Unserialize(reader);

				upval.Add(item);
			}

			uint constsz = reader.ReadUInt32();
			for (uint i=0; i<constsz; i++)
			{
				ObjLuaConstant item = new ObjLuaConstant(this);
				item.Unserialize(reader);

				contants.Add(item);
			}

			uint fncsz = reader.ReadUInt32();
			for (uint i=0; i<fncsz; i++)
			{
				ObjLuaFunction item = new ObjLuaFunction(this.parent);
				item.Unserialize(reader);

				functions.Add(item);
			}

			uint codesz = reader.ReadUInt32();
			for (uint i=0; i<codesz; i++)
			{
				ObjLuaCode item = new ObjLuaCode(this);
				item.Unserialize(reader);
				
				codes.Add(item);
			}

		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			
		}

		

		#region IDisposable Member

		public void Dispose()
		{
			parent = null;
			if (contants!=null) contants.Clear();
			contants = null;
		}

		#endregion

		public override string ToString()
		{
			return name+": "+contants.Count.ToString()+" Constants, "+functions.Count.ToString()+" Functions, "+codes.Count.ToString()+" Codes";
		}
		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return contants.GetEnumerator();
		}

		#endregion
	}


	public class ObjLuaConstant : System.IDisposable
	{
		public enum Type : byte
		{
			Empty = 0x00,
			Number = 0x03,
			String = 0x04
		}

		#region Attributes
		ObjLuaFunction parent;
		public ObjLuaFunction Parent
		{
			get {return parent;}
		}
	
		Type type;
		public Type InstructionType
		{
			get { return type; }
			set { type = value; }
		}

		string str;
		public string String
		{
			get { return str; }
			set { str = value; }
		}

		uint[] data;
		public uint Unknown1
		{
			get { return data[0]; }
			set { data[0] = value; }
		}
		public uint Unknown2
		{
			get { return data[1]; }
			set { data[1] = value; }
		}

		uint[] bdata;
		byte[] badd;
		byte[] bheader;
		
		#endregion

		public ObjLuaConstant(ObjLuaFunction parent) 
		{
			this.parent = parent;
			str = "";
			data = new uint[2];
			bdata = new uint[0];
			badd = new byte[0];
			bheader = new byte[3];
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			type = (Type)reader.ReadByte();

			str = "";
			bdata = new uint[0];
			badd = new byte[0];
			if (type==Type.String) 
			{
				int ct = reader.ReadInt32();
				byte[] data = reader.ReadBytes(ct);
				str = Helper.ToString(data);
			} 
			else if (type==Type.Number) 
			{
				if (parent.Parent.NumberSize==8) 
				{
					data[0] = reader.ReadUInt32();
					data[1] = reader.ReadUInt32();
				} 
				else if (parent.Parent.NumberSize==4) 
				{
					data[0] = reader.ReadUInt32();
					data[1] = 0;
				} else throw new Exception("Number Size "+parent.Parent.NumberSize.ToString()+" is not supported!");
			}
			else if (type==Type.Empty) 
			{				
			} 
			else 
			{
				throw new Exception("Unknown Constant Type: 0x"+Helper.HexString((byte)type)+", 0x"+Helper.HexString(reader.BaseStream.Position-0x40));
			}
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			
		}
		#region IDisposable Member

		public void Dispose()
		{
			parent = null;
			str = null;

			badd = null;
			bheader = null;
			bdata = null;
			data = null;
		}

		#endregion

		public override string ToString()
		{
			string s = type.ToString()+": ";
			if (type == Type.String) s += str;
			else if (type == Type.Number) s += "0x"+Helper.HexString(this.Unknown1)+", "+"0x"+Helper.HexString(this.Unknown2);			
										 
			return s;
		}

	}

	public class ObjLuaSourceLine : System.IDisposable
	{			

		#region Attributes
		ObjLuaFunction parent;
	
		uint val;
		public uint Value
		{
			get { return val; }
			set { val = value; }
		}

		
		
		#endregion

		public ObjLuaSourceLine(ObjLuaFunction parent) 
		{
			this.parent = parent;				
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			val = reader.ReadUInt32();
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(val);
		}
		#region IDisposable Member

		public void Dispose()
		{
			
		}

		#endregion

		public override string ToString()
		{
			return "0x"+Helper.HexString(val);
		}

	}

	public class ObjLuaLocalVar : System.IDisposable
	{			

		#region Attributes
		ObjLuaFunction parent;
	
		uint start, end;
		public uint Start
		{
			get { return start; }
			set { start = value; }
		}

		public uint End
		{
			get { return end; }
			set { end = value; }
		}

		string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		
		
		#endregion

		public ObjLuaLocalVar(ObjLuaFunction parent) 
		{
			this.parent = parent;
			name = "";	
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			name = ObjLua.ReadString(reader);
			start = reader.ReadUInt32();
			end = reader.ReadUInt32();
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{	
			ObjLua.WriteString(name, writer);
			writer.Write(start);
			writer.Write(end);
		}
		#region IDisposable Member

		public void Dispose()
		{
			name = null;
		}

		#endregion

		public override string ToString()
		{
			return Name+": 0x"+Helper.HexString(start)+" - 0x"+Helper.HexString(end);
		}

	}

	public class ObjLuaUpValue : ObjLuaSourceLine
	{			
		public ObjLuaUpValue(ObjLuaFunction parent) : base(parent)
		{			
		}
	}

	public class ObjLuaCode : System.IDisposable
	{		
		#region OpCodes		
		static string[] opcodes = new string[]{
												  "MOVE",
												  "LOADK",
												  "LOADBOOL",
												  "LOADNIL",
												  "GETUPVAL",
												  "GETGLOBAL",
												  "GETTABLE",
												  "SETGLOBAL",
												  "SETUPVAL",
												  "SETTABLE",
												  "NEWTABLE",
												  "SELF",
												  "ADD",
												  "SUB",
												  "MUL",
												  "DIV",
												  "POW",
												  "UNM",
												  "NOT",
												  "CONCAT",
												  "JMP",
												  "EQ",
												  "LT",
												  "LE",
												  "TEST",
												  "CALL",
												  "TAILCALL",
												  "RETURN",
												  "FORLOOP",
												  "TFORLOOP",
												  "TFORREP",
												  "SETLIST",
												  "SETLISTO",
												  "CLOSE",
												  "CLOSURE"
											  };
		static string[] opcodedesc = new string[]{
												  "Copy a value between registers",
												  "Load a constant into a register",
												  "Load a boolean into a register",
												  "Load null values into a range of registers",
												  "Read an upvalue into a register",
												  "Read a global variable into a register",
												  "Read a table element into a register",
												  "Write a register value into a global variable",
												  "Write a register value into an upvalue",
												  "Write a register value into a table element",
												  "Create a new table",
												  "Prepare an object method for calling",
												  "Addition",
												  "Subtraction",
												  "Multiplication",
												  "Division",
												  "Exponentiation",
												  "Unary minus",
												  "Logical NOT",
												  "Concatenate a range of registers",
												  "Unconditional jump",
												  "Equality test",
												  "Less than test",
												  "Less than or equal to test",
												  "Test for short-circuit logical and and or evaluation",
												  "Call a closure",
												  "Perform a tail call",
												  "Return from function call",
												  "Iterate a numeric for loop",
												  "Iterate a generic for loop",
												  "Initialization for a generic for loop",
												  "Set a range of array elements for a table",
												  "Set a variable number of table elements",
												  "Close a range of locals being used as upvalues",
												  "Create a closure of a function prototype"
											  };
												  
		#endregion

		#region Attributes
		ObjLuaFunction parent;
	
		uint val;
		public uint Value
		{
			get { return val; }
			set { val = value; }
		}

		public byte Opcode 
		{
			get 
			{				
				return (byte)((val & (parent.Parent.OpcodeMaks << parent.Parent.OpcodeShift)) >> parent.Parent.OpcodeShift);
			}
			set 
			{
				val = ((uint)(val & (0xFFFFFFFF - (parent.Parent.OpcodeMaks << parent.Parent.OpcodeShift))) | (uint)((value & parent.Parent.OpcodeMaks)<< parent.Parent.OpcodeShift));
			}
		}

		public ushort A
		{
			get 
			{				
				return (ushort)((val & (parent.Parent.AMaks << parent.Parent.AShift)) >> parent.Parent.AShift);
			}
			set 
			{
				val = ((uint)(val & (0xFFFFFFFF - (parent.Parent.AMaks << parent.Parent.AShift))) | (uint)((value & parent.Parent.AMaks)<< parent.Parent.AShift));
			}
		}

		public ushort B
		{
			get 
			{				
				return (ushort)((val & (parent.Parent.BMaks << parent.Parent.BShift)) >> parent.Parent.BShift);
			}
			set 
			{
				val = ((uint)(val & (0xFFFFFFFF - (parent.Parent.BMaks << parent.Parent.BShift))) | (uint)((value & parent.Parent.BMaks)<< parent.Parent.BShift));
			}
		}

		public ushort C
		{
			get 
			{				
				return (ushort)((val & (parent.Parent.CMaks << parent.Parent.CShift)) >> parent.Parent.CShift);
			}
			set 
			{
				val = ((uint)(val & (0xFFFFFFFF - (parent.Parent.CMaks << parent.Parent.CShift))) | (uint)((value & parent.Parent.CMaks)<< parent.Parent.CShift));
			}
		}

		public string GetOpcodeName(byte oc)
		{
			if (oc>=0 && oc<opcodes.Length) return opcodes[oc];
			else return "UNK_"+Helper.HexString(oc);			
		}

		public string GetOpcodeDescription(byte oc)
		{
			if (oc>=0 && oc<opcodedesc.Length) return opcodedesc[oc];
			else return SimPe.Localization.GetString("Unknown");			
		}
		
		#endregion

		#region Opcode Translation
		string R(ushort v)
		{
			return "R"+v.ToString();
		}
		
		string RK(ushort v)
		{
			return v.ToString();
		}
		string Kst(uint v)
		{
			if (v>=0 && v<parent.Constants.Count) 
			{
				ObjLuaConstant oci = (ObjLuaConstant)parent.Constants[(int)v];
				if (oci.InstructionType==ObjLuaConstant.Type.String) return oci.String;
				else if (oci.InstructionType==ObjLuaConstant.Type.Number) return oci.ToString();
				else return "null";				
			}
			return v.ToString();
		}

		string UpValue(ushort v)
		{
			if (v>=0 && v<parent.UpValues.Count) return parent.UpValues[v].ToString();
			return v.ToString();
		}

		string Bool(ushort v)
		{
			if (v==0) return "false";
			else return "true";
		}

		string Gbl(string n)
		{
			return "(Global)"+n;
		}

		string Tbl(ushort v) 
		{
			return "Tbl"+v.ToString();
		}

		string TblFbp(ushort v)
		{
			int m = (v & 0x00F8) >> 3;
			int b = (v & 0x0007);

			double d = b * Math.Pow(2, m);
			return ((int)Math.Round(d)).ToString();
		}

		string TblSz(ushort v)
		{
			return ((int)(Math.Log(5, 2) + 1)).ToString();
		}

		string TranslateOpcode(byte oc, ushort a, ushort b, ushort c) 
		{
			uint bx = ((b & parent.Parent.BMaks) << parent.Parent.CBits) | (c & parent.Parent.CMaks);
			int sbx = (int)((long)bx - parent.Parent.Bias);
			
			string name = GetOpcodeName(oc);
			string ret = "";			
			if (name=="MOVE") ret =  R(a) + " := " + R(b);
			else if (name=="LOADNIL") ret = R(a) + " :=  ... :=  " + R(b) + " := null";
			else if (name=="LOADK") ret = R(a) +" := " + Kst(bx);
			else if (name=="LOADBOOL") ret = R(a) + " := " + Bool(b) +"; if ("+Bool(c)+") PC++";
			else if (name=="GETGLOBAL") ret = R(a) + " := " + Gbl(Kst(bx));
			else if (name=="SETGLOBAL") ret = Gbl(Kst(bx)) + " := " + R(a);
			else if (name=="GETUPVAL") ret = R(a) + " := " + UpValue(b);
			else if (name=="SETUPVAL") ret = UpValue(b) + " := " + R(a);
			else if (name=="GETTABLE") ret = R(a) + " := " + Tbl(b)+"["+RK(c)+"]";
			else if (name=="SETTABLE") ret = Tbl(b)+"["+RK(c)+"]" + " := " + R(a);
			else if (name=="ADD") ret = R(a) + " := " + RK(b) + " + " + RK(c);
			else if (name=="SUB") ret = R(a) + " := " + RK(b) + " - " + RK(c);
			else if (name=="MUL") ret = R(a) + " := " + RK(b) + " * " + RK(c);
			else if (name=="DIV") ret = R(a) + " := " + RK(b) + " / " + RK(c);
			else if (name=="POW") ret = R(a) + " := " + RK(b) + " ^ " + RK(c);
			else if (name=="UNM") ret = R(a) + " := -" + R(b);
			else if (name=="NOT") ret = R(a) + " := !" + R(b);
			else if (name=="CONCAT") ret = R(a) + " := " + R(b) + " + ... + " + R(c);
			else if (name=="JMP") ret = " PC += " + sbx.ToString();
			else if (name=="CALL") ret = R(a) + ", ... ," + R((ushort)(a+c+2)) + " := " + R(a) + "("+R((ushort)(a+1))+", ..., "+R((ushort)(a+b-1))+")";
			else if (name=="RETURN") ret = "return " + R(a) + ", ..., " + R((ushort)(a+b+2));
			else if (name=="TAILCALL") ret = "return " + R(a) + "(" + R((ushort)(a+1)) + ", ..., " + R((ushort)(a+b-1)) + ")";
			else if (name=="SELF") ret = R((ushort)(a+1)) + " := " + R(b) + "; " + R(a) + " := " + R(b) + "["+RK(c)+"]";			
			else if (name=="EQ") ret = "if ((" + RK(b) + " == " + RK(c) + ") == " + Bool(a) + " then PC++";
			else if (name=="LT") ret = "if ((" + RK(b) + " < " + RK(c) + ") == " + Bool(a) + " then PC++";
			else if (name=="LE") ret = "if ((" + RK(b) + " <= " + RK(c) + ") == " + Bool(a) + " then PC++";
			else if (name=="TEST") ret = "if (" + R(b) + " <=> " + c.ToString() + ") then " + R(a) + " := " + R(b) + " else PC++";
			else if (name=="FORLOOP") ret = R(a) + " += " + R((ushort)(a+2)) + "; if " + R(a) + " <= " +  R((ushort)(a+1)) + " then PC += " + sbx.ToString();
			else if (name=="TFORPREP") ret = "if type("+R(a)+") == table then " + R((ushort)(a+1)) + " := " + R(a) + "; " + R(a) + ":= next; PC += " + sbx.ToString();
			else if (name=="TFORLOOP") ret = R((ushort)(a+2)) + ", ..., " + R((ushort)(a+2+c)) + " := " + R(a) + "("+R(a)+", "+R((ushort)(a+2))+"); if " +  R((ushort)(a+2)) + " == null then PC++";
			else if (name=="NEWTABLE") ret = R(a) + " := new table["+TblFbp(b)+", "+TblSz(c)+"]";
			else if (name=="CLOSURE") ret = R(a) + " := closure(KPROTO["+bx.ToString()+"], "+R(a)+", ...)";
			else if (name=="CLOSE") ret = "close all to "+R(a);

			return ret+"; //"+name+" (a=0x"+Helper.HexString(a)+", b=0x"+Helper.HexString(b)+", c=0x"+Helper.HexString(c)+", bx="+bx.ToString()+", sbx="+sbx.ToString()+") "+GetOpcodeDescription(oc);
		}
		#endregion

		public ObjLuaCode(ObjLuaFunction parent) 
		{
			this.parent = parent;				
		}

		internal void Unserialize(System.IO.BinaryReader reader)
		{	
			val = reader.ReadUInt32();
		}


		internal void Serialize(System.IO.BinaryWriter writer) 
		{		
			writer.Write(val);
		}
		#region IDisposable Member

		public void Dispose()
		{
			
		}

		#endregion

		public override string ToString()
		{
			return "0x"+Helper.HexString(val)+": "+TranslateOpcode(this.Opcode, this.A, this.B, this.C);
		}

	}
}
