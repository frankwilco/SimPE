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
using SimPe.Data;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// An Item stored in a CPF File
	/// </summary>
	public class CpfItem : System.IDisposable {
		/// <summary>
		/// Constructor
		/// </summary>
		public CpfItem ()
		{
			name = new byte[0];
			val = new byte[0];
		}

		Data.MetaData.DataTypes dt;
		/// <summary>
		/// Returns the
		/// </summary>
		public MetaData.DataTypes Datatype
		{
			get { return dt; }
			set { dt = value; }
		}
		
		byte[] name;
		/// <summary>
		/// Returns the Name
		/// </summary>
		public string Name
		{
			get
			{
				return Helper.ToString(name);
			}
			set 
			{
				name = Helper.ToBytes(value, 0);
			}

		}

		/// <summary>
		/// Returns the Name as a Byte Array
		/// </summary>
		public byte[] PlainName
		{
			get { return name; }
			set { name = value; }
		}


		#region value Handling
		byte[] val;
		/// <summary>
		/// Returns the
		/// </summary>
		public Byte[] Value
		{
			get { return val; }
			set { val = value; }
		}
		
		/// <summary>
		/// Returns the value as a String
		/// </summary>
		public string StringValue
		{
			get
			{
				switch (Datatype)
				{
					case MetaData.DataTypes.dtSingle:
					{
						return AsSingle().ToString();
					}
					case MetaData.DataTypes.dtInteger: 
					case Data.MetaData.DataTypes.dtUInteger:
					{
						return "0x"+Helper.HexString(AsInteger());
					}
					case MetaData.DataTypes.dtString:
					{
						return AsString();
					}
					default: 
					{
						return "";
					}
				} //switch;
				
			}
			
			set 
			{
				dt = Data.MetaData.DataTypes.dtString;
				val = Helper.ToBytes(value, 0);
			}
		}

		/// <summary>
		/// Returns the value as a String
		/// </summary>
		public uint UIntegerValue
		{
			get
			{
				switch (Datatype)
				{
					case MetaData.DataTypes.dtSingle:
					{
						return Convert.ToUInt32(AsSingle());
					}
					case MetaData.DataTypes.dtInteger: 
					case Data.MetaData.DataTypes.dtUInteger:
					{
						return AsUInteger();
					}
					case MetaData.DataTypes.dtString:
					{
						uint ret = 0;
						try 
						{
							ret = uint.Parse(AsString());
						} 
						catch (Exception){}
						return ret;
					}
					default: 
					{
						return 0;
					}
				} //switch;
				
			}
			
			set 
			{
				dt = Data.MetaData.DataTypes.dtUInteger;
				System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.MemoryStream());
				bw.Write(value);
				System.IO.BinaryReader br = new System.IO.BinaryReader(bw.BaseStream);
				br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
				val = br.ReadBytes((int)br.BaseStream.Length);
			}
		}

		/// <summary>
		/// Returns the value as a String
		/// </summary>
		public int IntegerValue
		{
			get
			{
				switch (Datatype)
				{
					case MetaData.DataTypes.dtSingle:
					{
						return Convert.ToInt32(AsSingle());
					}
					case MetaData.DataTypes.dtInteger: 
					case Data.MetaData.DataTypes.dtUInteger:
					{
						return AsInteger();
					}
					case MetaData.DataTypes.dtString:
					{
						int ret = 0;
						try 
						{
							ret = int.Parse(AsString());
						} 
						catch (Exception){}
						return ret;
					}
					default: 
					{
						return 0;
					}
				} //switch;
				
			}
			
			set 
			{
				dt = Data.MetaData.DataTypes.dtInteger;
				System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.MemoryStream());
				bw.Write(value);
				System.IO.BinaryReader br = new System.IO.BinaryReader(bw.BaseStream);
				br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
				val = br.ReadBytes((int)br.BaseStream.Length);
			}
		}

		/// <summary>
		/// Returns the value as a Single Floatingpoint (4Bytes)
		/// </summary>
		public Single SingleValue
		{
			get
			{
				switch (Datatype)
				{
					case MetaData.DataTypes.dtSingle:
					{
						return AsSingle();
					}
					case MetaData.DataTypes.dtInteger: 
					case Data.MetaData.DataTypes.dtUInteger:
					{
						return AsInteger();
					}
					case MetaData.DataTypes.dtString:
					{
						Single ret = 0;
						try 
						{
							ret = Single.Parse(AsString());
						} 
						catch (Exception){}
						return ret;
					}
					default: 
					{
						return 0;
					}
				} //switch;
				
			}
			set 
			{
				dt = Data.MetaData.DataTypes.dtSingle;
				System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.MemoryStream());
				bw.Write(value);
				System.IO.BinaryReader br = new System.IO.BinaryReader(bw.BaseStream);
				br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
				val = br.ReadBytes((int)br.BaseStream.Length);
			}
		}

		/// <summary>
		/// Returns the value as a Boolean
		/// </summary>
		public bool BooleanValue
		{
			get
			{
				switch (Datatype)
				{
					case MetaData.DataTypes.dtSingle:
					{
						return (AsSingle()!=0.0);
					}
					case MetaData.DataTypes.dtInteger: 
					case Data.MetaData.DataTypes.dtUInteger:
					{
						return (AsInteger()!=0);
					}
					case MetaData.DataTypes.dtString:
					{
						bool ret = false;
						try 
						{
							ret = (byte.Parse(AsString())!=0);
						} 
						catch (Exception){
						}
						return ret;
					}
					case MetaData.DataTypes.dtBoolean: 
					{
						return AsBoolean();
					}
					default: 
					{
						return false;
					}
				} //switch;
				
			}
			
			set 
			{
				dt = Data.MetaData.DataTypes.dtBoolean;
				System.IO.BinaryWriter bw = new System.IO.BinaryWriter(new System.IO.MemoryStream());
				bw.Write(value);
				System.IO.BinaryReader br = new System.IO.BinaryReader(bw.BaseStream);
				br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
				val = br.ReadBytes((int)br.BaseStream.Length);
			}
		}

		/// <summary>
		/// Returns Value as an Object of the defined type
		/// </summary>
		public object ObjectValue 
		{
			get 
			{
				switch (dt) 
				{
					case Data.MetaData.DataTypes.dtUInteger: 
					{
						return UIntegerValue;
					}
					case Data.MetaData.DataTypes.dtInteger:
					{
						return IntegerValue;
					}
					case Data.MetaData.DataTypes.dtSingle: 
					{
						return SingleValue;
					}
					case Data.MetaData.DataTypes.dtBoolean: 
					{
						return BooleanValue;
					}
					default: 
					{
						return StringValue;
					}
				}
			}
		}
		#endregion

		#region internal value Handling
		/// <summary>
		/// Interpretes the data as an Integer Value
		/// </summary>
		/// <returns>The Value interpreted as Integer</returns>
		protected int AsInteger()
		{
			try 
			{
				System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(val));
				return br.ReadInt32();
			} 
			catch (Exception)
			{
				return 0;
			}
		}

		/// <summary>
		/// Interpretes the data as an Integer Value
		/// </summary>
		/// <returns>The Value interpreted as Integer</returns>
		protected uint AsUInteger()
		{
			try 
			{
				System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(val));
				return br.ReadUInt32();
			} 
			catch (Exception)
			{
				return 0;
			}
		}

		/// <summary>
		/// Interpretes the data as a Boolean Value
		/// </summary>
		/// <returns>The Value interpreted as Boolean</returns>
		protected bool AsBoolean()
		{
			if (Value.Length<1) return false;
			else return (Value[0]==1);
		}

		/// <summary>
		/// Interpretes the data as an String Value
		/// </summary>
		/// <returns>The Value interpreted as String</returns>
		protected string AsString()
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(Value));
			try 
			{
				string ret = "";
				while (br.PeekChar()!=-1) ret+=br.ReadChar();
				return ret;
			} 
			catch (Exception) 
			{
				return "";
			}
		}

		/// <summary>
		/// Interpretes the data as a SingleFloat Value
		/// </summary>
		/// <returns>The Value interpreted as Singel</returns>
		protected Single AsSingle()
		{
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(Value));
			try 
			{
				return br.ReadSingle();
			} 
			catch (Exception) 
			{
				return 0;
			}
		}
		#endregion

		#region serialize/unserialize
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			//Load Datatype
			dt = (MetaData.DataTypes)reader.ReadUInt32();
			
			//Load the Name 
			int namelength = reader.ReadInt32();
			name = reader.ReadBytes(namelength);
			
			//Load Value
			int valuelength;
			switch (dt)
			{
				case (MetaData.DataTypes.dtString):
				{
					valuelength = reader.ReadInt32();
					break;
				}
				case (MetaData.DataTypes.dtBoolean): 
				{
					valuelength = 1;
					break;
				}
				default:
				{
					valuelength = 4;
					break;
				}
			} //switch
			val = reader.ReadBytes(valuelength);
		}

		/// <summary>
		/// Stores the Data in a Stream
		/// </summary>
		/// <param name="writer"></param>
		internal void Serialize(System.IO.BinaryWriter writer)
		{			
			//Store Datatype
			writer.Write((uint)dt);
			
			//Store the Name 
			writer.Write((uint)name.Length);
			writer.Write(name);

			//Store the Value
			switch (dt)
			{
				case (MetaData.DataTypes.dtString):
				{
					writer.Write((uint)val.Length);
					writer.Write(val);
					break;
				}
				default:
				{
					writer.Write(val);
					break;
				}
			} //switch
		}
		#endregion

		public override string ToString()
		{
			string ret =  Name+ " ("+dt.ToString()+") = ";

			switch (this.Datatype) 
			{
				case Data.MetaData.DataTypes.dtUInteger:
				case Data.MetaData.DataTypes.dtInteger:
				{
					ret += "0x"+Helper.HexString(this.UIntegerValue);
					break;
				}
				default: 
				{
					if (ObjectValue != null) ret += ObjectValue.ToString();
					break;
				}
			}

					return ret;
		}

		public void Dispose()
		{
			this.val = new byte[0];
			this.val= null;
			this.name = new byte[0];
			this.name = null;

		}
	}
}
