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
using System.IO;

namespace SimPe.Plugin
{
	/// <summary>
	/// Class representing an Instruction
	/// </summary>
	public class InstructionName : BhavBaseItem
	{
		/// <summary>
		/// The BHAV this Instruction is stored in
		/// </summary>
		protected Bhav parent;

		/// <summary>
		/// The Parent BHAV
		/// </summary>
		public Bhav Parent 
		{
			get { return parent; }
		}

		/// <summary>
		/// contains the list of Opcode Names
		/// </summary>
		protected static SimPe.Interfaces.Providers.IOpcodeProvider opcodes;

		/// <summary>
		/// Returns /Setst the OpcodeProvider
		/// </summary>
		public static SimPe.Interfaces.Providers.IOpcodeProvider OpcodeProvider 
		{
			get { return opcodes; }
			set { opcodes = value; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public InstructionName (Bhav parent)
		{
			this.parent = parent;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public InstructionName (Objf parent)
		{
			this.parent = new Bhav(parent.Opcodes);
			this.parent.Package = parent.Package;
			this.parent.FileDescriptor = parent.FileDescriptor;
		}

		/// <summary>
		/// True if this instruction describes a Global Behavior File
		/// </summary>
		public static bool IsGlobalBhav(ushort opcode)
		{
			return ((opcode>=0x0100) && (opcode<0x1000));
		}

		/// <summary>
		/// True if this instruction describes a Local Behavior File
		/// </summary>
		public static bool IsLocalBhav(ushort opcode)
		{
			return ((opcode>=0x1000) && (opcode<0x2000));
		}

		/// <summary>
		/// True if this instruction describes a Semi Global Bhav
		/// </summary>
		public static bool IsSemiGlobalBhav(ushort opcode)
		{
			return (opcode>=0x2000); 
		}

		/// <summary>
		/// Returns the Semi Global Group attached to this Item
		/// </summary>
		public uint SemiGlobalGroup
		{
			get 
			{
				if (parent==null) return 0;
				if (opcodes==null) return 0;
				
				Interfaces.Files.IPackedFileDescriptor[] pfds = parent.Package.FindFiles(Data.MetaData.GLOB_FILE);
				Interfaces.Files.IPackedFileDescriptor pfd = null;
				if (pfds.Length>0) pfd=pfds[0];

				foreach (Interfaces.Files.IPackedFileDescriptor p in pfds) 
				{
					if (p.Group == parent.FileDescriptor.Group) pfd = p;
				}
				if (pfd==null) return 0;

				Glob g = new Glob();
				g.ProcessData(pfd, parent.Package);
				return g.SemiGlobalGroup;
			}
		}

		/// <summary>
		/// Returns the name of a Global BHAV
		/// </summary>
		/// <param name="instance"></param>
		/// <returns></returns>
		protected string GetLocalBhavName(ushort instance)
		{
			Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(Data.MetaData.BHAV_FILE, 0, 0xffffffff, instance);
			if (pfd!=null) 
			{
				Bhav bhav = new Bhav(opcodes);
				bhav.ProcessData(pfd, package);
				return bhav.FileName;
			}
			return Localization.Manager.GetString("Unknown");
		}

		/// <summary>
		/// returns null or a matching global BHAV File
		/// </summary>
		/// <param name="opcode">the Opcode of the BHAV</param>
		/// <returns>The Bhav File or null</returns>
		public static Bhav LoadGlobalBHAV(ushort opcode) 
		{
			if (opcodes==null) return null;
			Interfaces.Files.IPackedFileDescriptor pfd =  opcodes.LoadGlobalBHAV(opcode);
			if (pfd==null) return null;

			Bhav b = new Bhav(opcodes);
			b.ProcessData(pfd, opcodes.BasePackage);
			return b;
		}

		/// returns null or a matching Semi global BHAV File
		/// </summary>
		/// <param name="opcode">the Opcode of the BHAV</param>
		/// <returns>The Bhav File or null</returns>
		public Bhav LoadSemiGlobalBHAV(ushort opcode) 
		{
			if (parent==null) return null;
			if (opcodes==null) return null;
			Interfaces.Files.IPackedFileDescriptor pfd = parent.Package.FindFile(Data.MetaData.BHAV_FILE, 0, parent.FileDescriptor.Group, opcode);
			if (pfd==null)  
			{
				pfd = parent.Package.FindFile(Data.MetaData.GLOB_FILE, 0, parent.FileDescriptor.Group, 0x01);
				if (pfd==null) 
				{
					Interfaces.Files.IPackedFileDescriptor[] pfds = parent.Package.FindFiles(Data.MetaData.GLOB_FILE);
					if (pfds.Length>0) pfd=pfds[0];

					foreach (Interfaces.Files.IPackedFileDescriptor p in pfds) 
					{
						if (p.Group == parent.FileDescriptor.Group) pfd = p;
					}
				}
				if (pfd==null) return null;

				Glob g = new Glob();
				g.ProcessData(pfd, parent.Package);
				pfd = opcodes.LoadSemiGlobalBHAV(opcode, g.SemiGlobalGroup);
			
				if (pfd==null) return null;
				Bhav b = new Bhav(opcodes);
				b.ProcessData(pfd, opcodes.BasePackage);
				return b;
			} 
			else 
			{
				Bhav b = new Bhav(opcodes);
				b.ProcessData(pfd, parent.Package);
				return b;
			}
			
		}

		/// <summary>
		/// returns null or a matching global BHAV File
		/// </summary>
		/// <param name="opcode">the Opcode of the BHAV</param>
		/// <returns>The Bhav File or null</returns>
		public Bhav LoadLocalBHAV(ushort opcode) 
		{
			if (parent==null) return new Bhav(opcodes);
			if (parent.Package==null) return new Bhav(opcodes);
			Interfaces.Files.IPackedFileDescriptor pfd =  parent.Package.FindFile(Data.MetaData.BHAV_FILE, 0, parent.FileDescriptor.Group, opcode);
			if (pfd==null) return new Bhav(opcodes);

			Bhav b = new Bhav(opcodes);
			b.ProcessData(pfd, parent.Package);
			return b;
		}

		/// <summary>
		/// The Name the given Opceode
		/// </summary>
		/// <param name="opcode">An opcode</param>
		/// <param name="operands">Operands or null</param>
		/// <returns>The Name of the Opcode</returns>
		public string OpcodeName(ushort opcode, byte[] operands)
		{
			string add="";
			if ((opcode==0x0002) && (parent !=null))
			{
				return ExpressionToString(operands);					   
			}

			if (opcodes==null) 
			{
				if (add.Trim()!="") return "0x"+Helper.HexString(opcode)+ " ("+add+")";
				else return "0x"+Helper.HexString(opcode);
			} 
			else 
			{				
				string name = "";

				if (IsLocalBhav(opcode)) 
				{
					name = "[private] "+LoadLocalBHAV(opcode).FileName;
				}
				else if (IsSemiGlobalBhav(opcode)) 
				{
					Bhav b = this.LoadSemiGlobalBHAV(opcode);
					name = "[semiglobal] ";
					if (b!=null) name += b.FileName;
					else name += Localization.Manager.GetString("Unknown");
				}
				else 
				{
					name = opcodes.FindName((ushort)(opcode));
				}
				if (add.Trim()!="")	return name+" (0x"+Helper.HexString(opcode)+", "+add+")";
				else return name+" (0x"+Helper.HexString(opcode)+")";
			}
		}

		#region Expression Primitive
		public static ushort[] ConstantValueParser(ushort val) 
		{
			ushort[] ret = new ushort[2];

			ret[0] = (ushort)((val >> 7) & 0x3f);
			ret[1] = (ushort)(val & 0x7F);
			int t = (val >> 13) & 0x7;

			if (t==0) ret[0] += 0x1000;
			else if (t==1) ret[0] += 0x2000;
			else ret[0] += 0x0100;

			return ret;
		}

		public static ushort ConstantValueParser(ushort[] values) 
		{
			int t = 2;
			if ((values[0]>=0x1000) && (values[0]<0x2000)) 
			{
				values[0] = (ushort)(values[0]-0x1000);
				t = 0;
			} 
			else if (values[0]>0x2000) 
			{
				values[0] = (ushort)(values[0]-0x2000);
				t = 1;
			} 
			else 
			{
				values[0] = (ushort)(values[0]-0x100);
			}
			ushort ret = 0;

			ret = (ushort)(t << 13);
			ret += (ushort)((values[0] & 0x3f)  << 7);
			ret += (ushort)(values[1] & 0x7F);
			
			return ret;
		}

		protected ushort ToShort(byte lower, byte higher)
		{
			return (ushort)((higher << 8) + lower);
		}

		protected string ExpressionToString(byte[] operands)
		{			
			if (operands==null) return Localization.Manager.GetString("Unknown");
			if (opcodes != null) 
			{
				string obj1 = opcodes.FindExpressionDataOwners(operands[6]);
				ushort op1 = ToShort(operands[0], operands[1]);
				string val1 = " 0x" + Helper.HexString(op1);
				string obj2 = opcodes.FindExpressionDataOwners(operands[7]); 
				ushort op2 = ToShort(operands[2], operands[3]);
				string val2 = " 0x" + Helper.HexString(op2);
				string name = opcodes.FindExpressionOperator(operands[5]);

				if (obj1.ToLower()=="my motives") val1 = " "+opcodes.FindMotives(op1)+ " ("+val1.Trim()+")";
				if (obj2.ToLower()=="my motives") val2 = " "+opcodes.FindMotives(op2)+ " ("+val2.Trim()+")";

				if (obj1.ToLower()=="constant value") val1 = " 0x"+Helper.HexString(ConstantValueParser(op1)[0])+":0x"+Helper.HexString((byte)ConstantValueParser(op1)[1]);
				if (obj2.ToLower()=="constant value") val2 = " 0x"+Helper.HexString(ConstantValueParser(op2)[0])+":0x"+Helper.HexString((byte)ConstantValueParser(op2)[1]);
				

				return obj1+val1+" "+name+" "+obj2+val2;
			} 
			else return "";
		}

		#endregion
	}
}
