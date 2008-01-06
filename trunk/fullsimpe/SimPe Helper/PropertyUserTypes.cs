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
using System.Threading;
using System.Reflection;
using System.Reflection.Emit;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Drawing;

namespace Ambertation
{
	/// <summary>
	/// Stores a Floatingpoint Color
	/// </summary>
	public class FloatColor 
	{
		System.Drawing.Color cl;
		public System.Drawing.Color Color 
		{
			get { return cl; }
			set {cl = value; }
		}

		FloatColor(System.Drawing.Color cl) 
		{
			this.cl = cl;
		}

		FloatColor(string s)
		{
			cl = ToColor(s);
		}

		public static FloatColor FromColor(System.Drawing.Color cl) 
		{
			return new FloatColor(cl);
		}

		public static FloatColor FromString(string s) 
		{
			return new FloatColor(s);
		}

		float ToFloat(int cmp) 
		{
			double d = (double)cmp / (double)0xff;
			return (float)d;
		}

		public override string ToString()
		{
			return ToFloat(cl.R).ToString("N5", System.Globalization.CultureInfo.InvariantCulture)+","+
				ToFloat(cl.G).ToString("N5", System.Globalization.CultureInfo.InvariantCulture)+","+
				ToFloat(cl.B).ToString("N5", System.Globalization.CultureInfo.InvariantCulture);
		}

		// Explicit conversion from DBBool to bool. Throws an 
		// exception if the given DBBool is dbNull, otherwise returns
		// true or false:
		public static implicit operator System.Drawing.Color(FloatColor x) 
		{
			return x.Color;
		}

		/// <summary>
		/// Returns the color represented by a string like 1.0,1.0,1.0
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static System.Drawing.Color ToColor(string s) 
		{
			System.Drawing.Color o = System.Drawing.Color.Black;

			while (s.IndexOf(" ")!=-1) s = s.Replace(" ", "");

			if (s.IndexOf(";")==-1) 
			{
				string[] parts = s.Split(",".ToCharArray(), 4);
				if (parts.Length<3) o=System.Drawing.Color.Black;
				else if (parts.Length==3) o = System.Drawing.Color.FromArgb(
											  (int)(System.Convert.ToSingle(parts[0], System.Globalization.CultureInfo.InvariantCulture) * 0xff),
											  (int)(System.Convert.ToSingle(parts[1], System.Globalization.CultureInfo.InvariantCulture) * 0xff),
											  (int)(System.Convert.ToSingle(parts[2], System.Globalization.CultureInfo.InvariantCulture) * 0xff)
											  );
				else o = System.Drawing.Color.FromArgb(
						 (int)(System.Convert.ToSingle(parts[0], System.Globalization.CultureInfo.InvariantCulture) * 0xff),
						 (int)(System.Convert.ToSingle(parts[1], System.Globalization.CultureInfo.InvariantCulture) * 0xff),
						 (int)(System.Convert.ToSingle(parts[2], System.Globalization.CultureInfo.InvariantCulture) * 0xff),
						 (int)(System.Convert.ToSingle(parts[3], System.Globalization.CultureInfo.InvariantCulture) * 0xff)
						 );
			} 
			else 
			{
				string[] parts = s.Split(";".ToCharArray(), 4);
				if (parts.Length<3) o=System.Drawing.Color.Black;
				else if (parts.Length==3) o = System.Drawing.Color.FromArgb(
											  (int)(System.Convert.ToInt16(parts[0], System.Globalization.CultureInfo.InvariantCulture)),
											  (int)(System.Convert.ToInt16(parts[1], System.Globalization.CultureInfo.InvariantCulture)),
											  (int)(System.Convert.ToInt16(parts[2], System.Globalization.CultureInfo.InvariantCulture))
											  );
				else o = System.Drawing.Color.FromArgb(
						 (int)(System.Convert.ToInt16(parts[0], System.Globalization.CultureInfo.InvariantCulture)),
						 (int)(System.Convert.ToInt16(parts[1], System.Globalization.CultureInfo.InvariantCulture)),
						 (int)(System.Convert.ToInt16(parts[2], System.Globalization.CultureInfo.InvariantCulture)),
						 (int)(System.Convert.ToInt16(parts[3], System.Globalization.CultureInfo.InvariantCulture))
						 );
			}

			return o;
		}

		
	}
	/// <summary>
	/// This is a typeconverter for the special Short class
	/// </summary>
	public class NumberBaseTypeConverter:TypeConverter
	{
		Type type;
		public override bool CanConvertTo(ITypeDescriptorContext context,
			System.Type destinationType) 
		{
			if (destinationType == typeof(BaseChangeableNumber))
				return true;

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context,
			CultureInfo culture, 
			object value, 
			System.Type destinationType) 
		{
			if (destinationType == typeof(System.String) && 
				value is BaseChangeableNumber)
			{

				BaseChangeableNumber so = (BaseChangeableNumber)value;
				type = so.Type;

				return so.ToString();
			}
			else if (destinationType == typeof(System.String))
			{
				BaseChangeableNumber so = new BaseChangeableNumber(value);
				return so.ToString();
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		public override bool CanConvertFrom(ITypeDescriptorContext context,
			System.Type sourceType) 
		{
			if (sourceType == typeof(string))
				return true;

			return base.CanConvertFrom(context, sourceType);
		}

		public override object ConvertFrom(ITypeDescriptorContext context,
			CultureInfo culture, object value) 
		{
			if (value is string) 
			{
				try 
				{
					string s = (string) value;					
					
					if (type == null) type = context.PropertyDescriptor.PropertyType;

					BaseChangeableNumber bcn =  BaseChangeableNumber.Convert(s, type);
					if (context.PropertyDescriptor.PropertyType == typeof(long)) return bcn.LongValue;
					if (context.PropertyDescriptor.PropertyType == typeof(ulong)) return (ulong)bcn.LongValue;					
					if (context.PropertyDescriptor.PropertyType == typeof(int)) return bcn.IntegerValue;
					if (context.PropertyDescriptor.PropertyType == typeof(uint)) return (uint)bcn.IntegerValue;
					if (context.PropertyDescriptor.PropertyType == typeof(short)) return (short)bcn.IntegerValue;
					if (context.PropertyDescriptor.PropertyType == typeof(ushort)) return (ushort)bcn.IntegerValue;
					if (context.PropertyDescriptor.PropertyType == typeof(byte)) return (byte)bcn.IntegerValue;
					if (context.PropertyDescriptor.PropertyType == typeof(sbyte)) return (sbyte)bcn.IntegerValue;
					return bcn;
				}
				catch 
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value + "'. This is not a valid "+BaseChangeableNumber.BaseName+" Number of Type "+type.Name+"!");						
				}
			}  
			return base.ConvertFrom(context, culture, value);
		}
	}

	/// <summary>
	/// This is a class that can present short Values in diffrent Ways
	/// </summary>
	[TypeConverterAttribute(typeof(NumberBaseTypeConverter)),
	DescriptionAttribute("This Values can be displayed in Dec, Hex and Bin")]
	public class BaseChangeableNumber 
	{
		/// <summary>
		/// What kind of number was it to begin with?
		/// </summary>
		Type type;

		internal Type Type 
		{
			get { return type; }
		}

		static int digitbase = 16;
		/// <summary>
		/// The Number Base used for Display 
		/// </summary>
		public static int DigitBase
		{
			get { return digitbase; }
			set { digitbase = value; }
		}

		/// <summary>
		/// Name of this Number Representation
		/// </summary>
		public static string BaseName 
		{
			get 
			{
				if (digitbase==16) return "Hexadecimal";
				if (digitbase==2) return "Binary";
				return "Decimal";
			}
		}

		/// <summary>
		/// Converts a String Back to a type of this Class
		/// </summary>
		/// <param name="s">The string Representation</param>
		/// <param name="type">the type of the Target Number</param>
		/// <returns>a new Instance</returns>
		public static BaseChangeableNumber Convert(string s, Type type)
		{
			s = s.Trim().ToLower();
			object val = 0;

			int b = 10;
			int o = 0;
			if (s.StartsWith("0x")) 
			{
				b = 16;
				o=0;				
			} 
			else if (s.StartsWith("b")) 
			{
				b = 2;
				o = 1;
			}

			s = s.Substring(o);
			if (type==typeof(byte)) val = System.Convert.ToByte(s, b);			
			else if (type==typeof(sbyte)) val = System.Convert.ToSByte(s, b);			
			else if (type==typeof(short)) val = System.Convert.ToInt16(s, b);
			else if (type==typeof(ushort)) val = System.Convert.ToUInt16(s, b);
			else if (type==typeof(int)) val = System.Convert.ToInt32(s, b);
			else if (type==typeof(uint)) val = System.Convert.ToUInt32(s, b);
			else if (type==typeof(long)) val = System.Convert.ToInt64(s, b);
			else if (type==typeof(ulong)) val = (long)System.Convert.ToUInt64(s, b);
			
			//SetValue(val, type);
			return new BaseChangeableNumber(val, type);
		}

		long val;

		public BaseChangeableNumber(object v) 
		{ 
			ObjectValue = v;
			if (v!=null) type = v.GetType();
		}

		internal BaseChangeableNumber(object v, Type t) 
		{ 
			SetValue(v, t);
		}

		internal BaseChangeableNumber() 
		{ 
			val = 0; 
			type = typeof(int);
		}

		/// <summary>
		/// The actual Value (as short)
		/// </summary>
		public short Value 
		{
			get { return (short)(val & 0xffff); ; }
			set { val = (short)(value & 0xffff); }
		}

		/// <summary>
		/// The actual Value (as Integer)
		/// </summary>
		public int IntegerValue 
		{
			get { return (int)val; }
			set { val = value; }
		}

		/// <summary>
		/// The actual Value (as Long)
		/// </summary>
		public long LongValue 
		{
			get { return val; }
			set { val = value; }
		}
		

		internal  void SetValue(object o, Type t) 
		{
			type = t;//o.GetType();			


			if (type==typeof(byte)) val = System.Convert.ToByte(o);			
			else if (type==typeof(sbyte)) val = System.Convert.ToSByte(o);			
			else if (type==typeof(short)) val = System.Convert.ToInt16(o);
			else if (type==typeof(ushort)) val = System.Convert.ToUInt16(o);
			else if (type==typeof(int)) val = System.Convert.ToInt32(o);
			else if (type==typeof(uint)) val = System.Convert.ToUInt32(o);
			else if (type==typeof(long)) val = System.Convert.ToInt64(o);
			else val = (long)System.Convert.ToUInt64(o);			

			type = t;
		}
		/// <summary>
		/// The actual value (same type as this value was created with, or last set)
		/// </summary>
		public object ObjectValue 
		{
			set 
			{
				SetValue(value, value.GetType());
			}
			get 
			{
				if (type==typeof(int)) return (int)val;
				if (type==typeof(uint)) return (uint)val;
				if (type==typeof(short)) return (short)val;
				if (type==typeof(ushort)) return (ushort)val;				
				if (type==typeof(byte)) return (byte)val;								
				if (type==typeof(ulong)) return (ulong)val;
				return (long)val;				
			}
		}

		/// <summary>
		/// Return the String Representation of the stored Value
		/// </summary>
		/// <returns>A String</returns>
		public override string ToString()
		{
			int len = 64;
			if (type==typeof(byte)) len = 8;		
			else if (type==typeof(sbyte)) len = 8;			
			else if (type==typeof(short)) len = 16;	
			else if (type==typeof(ushort)) len = 16;
			else if (type==typeof(int)) len = 32;
			else if (type==typeof(uint)) len = 32;
			else if (type==typeof(long)) len = 64;
			else if (type==typeof(ulong)) len = 64;

			if (digitbase==16) 
			{
				len = len / 4;
				return "0x"+SimPe.Helper.StrLength(val.ToString("x"), len, false);
			} 
			else if (digitbase==2) 
			{
				return "b"+SimPe.Helper.StrLength(System.Convert.ToString(val, 2), len, false);
			}
			else 
			{
				return val.ToString();
			}
		}

		public static implicit operator uint(BaseChangeableNumber bcn)
		{
			return (uint)bcn.IntegerValue;
		}
	}
}
