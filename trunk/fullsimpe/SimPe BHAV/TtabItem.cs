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

namespace SimPe.Plugin
{
	public class TtabFlags : FlagBase
	{
		public TtabFlags(ushort flags) : base(flags) {}

		public bool ByVisitors
		{
			get { return GetBit(0); }
			set { SetBit(0, value); }
		}

		public bool Joinable
		{
			get { return GetBit(1); }
			set { SetBit(1, value); }
		}

		public bool RunImmediately
		{
			get { return GetBit(2); }
			set { SetBit(2, value); }
		}

		public bool AvailConsecutive
		{
			get { return GetBit(3); }
			set { SetBit(3, value); }
		}

		public bool ByChildren
		{
			get { return !GetBit(4); }
			set { SetBit(4, !value); }
		}

		public bool ByDemoChild
		{
			get { return !GetBit(5); }
			set { SetBit(5, !value); }
		}

		public bool ByAdults
		{
			get { return !GetBit(6); }
			set { SetBit(6, !value); }
		}

		public bool DebugMenu
		{
			get { return GetBit(7); }
			set { SetBit(7, value); }
		}

		public bool AutoFirstSelect
		{
			get { return GetBit(8); }
			set { SetBit(8, value); }
		}

		public bool ByToddlers
		{
			get { return GetBit(9); }
			set { SetBit(9, value); }
		}

		public bool ByElders
		{
			get { return GetBit(10); }
			set { SetBit(10, value); }
		}

		public bool ByTeens
		{
			get { return GetBit(11); }
			set { SetBit(11, value); }
		}

		public bool Unknown1
		{
			get { return GetBit(12); }
			set { SetBit(12, value); }
		}

		public bool Unknown2
		{
			get { return GetBit(13); }
			set { SetBit(13, value); }
		}

		public bool Unknown3
		{
			get { return GetBit(14); }
			set { SetBit(14, value); }
		}

		public bool Unknown4
		{
			get { return GetBit(15); }
			set { SetBit(15, value); }
		}
	}
	/// <summary>
	/// An Item that can be stored in a Ttab Item
	/// </summary>
	public class TtabListItem 
	{
		SimPe.Interfaces.Providers.IOpcodeProvider opcodes;
		public TtabListItem(int index, SimPe.Interfaces.Providers.IOpcodeProvider opcodes) 
		{
			this.index = index;
			this.opcodes = opcodes;
		}

		int index;
		public int Index
		{
			get {return index; }
			set {index = value;}
		}

		short min;
		public short Minimum 
		{
			get {return min; }
			set {min = value;}
		}

		short delta;
		public short Delta 
		{
			get {return delta; }
			set {delta = value;}
		}

		short type;
		public short Type 
		{
			get {return type; }
			set {type = value;}
		}

		/// <summary>
		/// Reads Data from the Stream
		/// </summary>
		/// <param name="reader"></param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			min = reader.ReadInt16();
			delta = reader.ReadInt16();
			type = reader.ReadInt16();
		}

		/// <summary>
		/// Writes Data to the Stream
		/// </summary>
		/// <param name="writer"></param>
		public void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(min);
			writer.Write(delta);
			writer.Write(type);
		}

		public override string ToString()
		{
			string name = "0x"+index.ToString("X");
			if (index>=0) 
			{
				if (opcodes!=null) 
				{
					name +=": "+opcodes.FindMotives((ushort)index)+" (min="+Helper.HexString(this.min)+", delta="+Helper.HexString(this.delta)+")";
				}

				return name;
			}
			
			
			return "N/A";
		}

	}

	/// <summary>
	/// An Item stored in an TTAB
	/// </summary>
	public class TtabItem : BhavBaseItem
	{
		int nr;
		public int LineNumber 
		{
			get {return nr; }
			set {nr = value;}
		}		

		ushort action;
		public ushort Action
		{
			get {return action; }
			set {action = value;}
		}

		ushort guard;
		public ushort Guardian
		{
			get {return guard; }
			set {guard = value;}
		}		

		ArrayList[] groups;
		public ArrayList[] Groups
		{
			get {return groups; }
			set {groups = value;}
		}

        ArrayList[] petgroups;
        public ArrayList[] PetGroups
        {
            get { return petgroups; }
            set { petgroups = value; }
        }

		TtabFlags flags;
		public TtabFlags Flags
		{
			get {return flags; }
			set {flags = value;}
		}

		ushort flags2;
		public ushort Flags2
		{
			get {return flags2; }
			set {flags2 = value;}
		}

		uint strindex;
		public uint StringIndex
		{
			get {return strindex; }
			set {strindex = value;}
		}

		/// <summary>
		/// Returns the Name of this Item according to the Pie Strings File
		/// </summary>
		public string Name
		{
			get 
			{
				try 
				{
					if (parent==null) return Localization.Manager.GetString("unknown");
					if (parent.StringResource == null) return Localization.Manager.GetString("unknown");

					PackedFiles.Wrapper.StrItemList items = parent.StringResource.LanguageItems(0x1);
					if (items == null) return Localization.Manager.GetString("unknown");
					if ((StringIndex>=items.Length) || (StringIndex<0)) return Localization.Manager.GetString("unknown");
				
					PackedFiles.Wrapper.StrItem item = items[StringIndex];
					if (item==null) return Localization.Manager.GetString("unknown");
					return item.Title;
				} 
				catch (Exception) { 
					return Localization.Manager.GetString("unk"); 
				}
			}
		}

		uint attenuationcode;
		public uint AttenuationCode
		{
			get {return attenuationcode; }
			set {attenuationcode = value;}
		}

		uint attenuationvalue;
		public uint AttenuationValue
		{
			get {return attenuationvalue; }
			set {attenuationvalue = value;}
		}		

		uint autonomy;
		public uint Autonomy
		{
			get {return autonomy; }
			set {autonomy = value;}
		}

		uint joinindex;
		public uint JoinIndex
		{
			get {return joinindex; }
			set {joinindex = value;}
		}

		uint res5;		
		public uint Res5
		{
			get {return res5; }
			set {res5 = value;}
		}

		uint res6;
		public uint Res6
		{
			get {return res6; }
			set {res6 = value;}
		}

		float res7;
		public float Res7
		{
			get {return res7; }
			set {res7 = value;}
		}

		uint res8;
		public uint Res8
		{
			get {return res8; }
			set {res8 = value;}
		}

		ushort res9;
		public ushort Res9
		{
			get {return res9; }
			set {res9 = value;}
		}

        ushort res10;
        public ushort Res10
        {
            get { return res10; }
            set { res10 = value; }
        }


		Ttab parent;
		public TtabItem(Ttab parent)
		{
			this.parent = parent;
			flags = new TtabFlags(0);
			guard = action = 0;
			groups = new ArrayList[7];
            petgroups = new ArrayList[0];

			for (int j=0; j<groups.Length; j++)
			{
				groups[j] = new ArrayList();
				for (int i=0; i<0x10; i++) 
				{
					TtabListItem listitem = new TtabListItem(i, parent.Opcodes);
					groups[j].Add(listitem);
				}
			}
		}

		/// <summary>
		/// Reads Data from the Stream
		/// </summary>
		/// <param name="reader"></param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			if (parent.Format<0x44) groups = new ArrayList[1];
			else groups = new ArrayList[7];
			int[] counts = new int[groups.Length];

			action = reader.ReadUInt16();
			guard = reader.ReadUInt16();

			for (int i=0; i<counts.Length; i++)
			{
				counts[i] = reader.ReadInt32();
				groups[i] = new ArrayList();
			}

			flags = new TtabFlags(reader.ReadUInt16());
			flags2 = reader.ReadUInt16();
			

			strindex = reader.ReadUInt32();
			attenuationcode = reader.ReadUInt32();
			attenuationvalue = reader.ReadUInt32();
			autonomy = reader.ReadUInt32();
			joinindex = reader.ReadUInt32(); //0xffffffff
			//if (joinindex!=0xffffffff) throw new Exception("Unknown TTAB Format 0x"+Helper.HexString(parent.Format)+".");
			if (parent.Format > 0x44) 
			{
                res5 = reader.ReadUInt32();
                if (parent.Format >= 0x46)
				{
					
					if (parent.Format >= 0x4a) 
					{
						res6 = reader.ReadUInt32();
						if (parent.Format >= 0x4c)
						{
							res7 = reader.ReadSingle(); //float
							res8 = reader.ReadUInt32();
						}
					}
				}
				res9 = reader.ReadUInt16();
			}

            int mct = counts.Length;
            if (parent.Format > 0x53) mct = reader.ReadInt32();
			for (int k=0; k<mct; k++) 
			{
				int count  = counts[k];
                if (parent.Format > 0x53) count = reader.ReadInt32();
				for (int i=0; i< count; i++) 
				{
					TtabListItem listitem = new TtabListItem(i, parent.Opcodes);
					listitem.Unserialize(reader);
					groups[k].Add(listitem);
				}
			}

			
		}

		/// <summary>
		/// Writes Data to the Stream
		/// </summary>
		/// <param name="reader"></param>
		public void Serialize(System.IO.BinaryWriter writer)
		{
			if ((parent.Format==0x43) || (parent.Format==0x3F)) 
			{

				ArrayList[] a = new ArrayList[1];
				if (groups.Length>0) a[0] = groups[0];
				else a[0] = new ArrayList();

				groups = a;
			}
			else 
			{
				ArrayList[] a  = new ArrayList[7];
				for (int i=0; i<a.Length; i++) 
				{
					if (i<groups.Length) a[i] = groups[i];
					else a[i] = new ArrayList();
				}
				groups = a;
			}
			
			writer.Write(action);
			writer.Write(guard);

			for (int i=0; i<groups.Length; i++)
			{
				writer.Write((uint)groups[i].Count);
			}

			writer.Write(flags.Value);
			writer.Write(flags2);
			

			writer.Write(strindex);
			writer.Write(attenuationcode);
			writer.Write(attenuationvalue);
			writer.Write(autonomy);
			writer.Write(joinindex); //0xffffffff
			//if (joinindex!=0xffffffff) throw new Exception("Unknown TTAB Format 0x"+Helper.HexString(parent.Format)+".");
			if (parent.Format >0x44) 
			{
                writer.Write(res5);
				if (parent.Format >= 0x46)
				{
					
					if (parent.Format >= 0x4a) 
					{
						writer.Write(res6);
						if (parent.Format >= 0x4c)
						{
							writer.Write(res7);
							writer.Write(res8);
						}
					}
				}
				writer.Write(res9);
			}

            if (parent.Format > 0x53) writer.Write((int)groups.Length);
			for (int k=0; k<groups.Length; k++) 
			{
				int count  = groups[k].Count;
                if (parent.Format > 0x53) writer.Write((int)count);
				for (int i=0; i< count; i++) 
				{
					TtabListItem listitem = (TtabListItem)groups[k][i];
					listitem.Serialize(writer);
				}
			}

			
		}

		/// <summary>
		/// Returns the Name of an Opcode in the Context of this Interaction
		/// </summary>
		/// <param name="opcode">The Opcode</param>
		/// <returns>The Name</returns>
		protected string OpcodeName(ushort opcode) 
		{
			Bhav bhav = new Bhav(parent.Opcodes);
			bhav.Package = parent.Package;
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Group = parent.FileDescriptor.Group;
			bhav.FileDescriptor = pfd;

			InstructionName name = new InstructionName(bhav);
			return name.OpcodeName(opcode, null);
		}

		public string GuardianName 
		{
			get { return this.OpcodeName(this.Guardian); }
		}

		public string ActionName 
		{
			get { return this.OpcodeName(this.Action); }
		}

		

		/// <summary>
		/// Creates a Human Readable String from the Objects Contents
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return "0x"+StringIndex.ToString("X")+": "+Name;// + " ("+this.ActionName+")";
		}

	}
}
