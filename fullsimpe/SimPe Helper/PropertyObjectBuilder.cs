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

namespace Ambertation
{
	/// <summary>
	/// This is a typeconverter for the special Short class
	/// </summary>
	public class HexTypeConverter:TypeConverter
	{
		public override bool CanConvertTo(ITypeDescriptorContext context,
			System.Type destinationType) 
		{
			if (destinationType == typeof(BaseChangeShort))
				return true;

			return base.CanConvertTo(context, destinationType);
		}

		public override object ConvertTo(ITypeDescriptorContext context,
			CultureInfo culture, 
			object value, 
			System.Type destinationType) 
		{
			if (destinationType == typeof(System.String) && 
				value is BaseChangeShort)
			{

				BaseChangeShort so = (BaseChangeShort)value;

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
					return BaseChangeShort.Convert(s);
				}
				catch 
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value + "'. This is not a valid "+BaseChangeShort.BaseName+" Number!");						
				}
			}  
			return base.ConvertFrom(context, culture, value);
		}
	}

	/// <summary>
	/// This is a class that can present short Values in diffrent Ways
	/// </summary>
	[TypeConverterAttribute(typeof(HexTypeConverter)),
	DescriptionAttribute("This Values can be displayed in Dec, Hex and Bin")]
	public class BaseChangeShort 
	{
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
		/// <returns>a new Instance</returns>
		public static BaseChangeShort Convert(string s)
		{
			s = s.Trim().ToLower();
			short val = 0;
			if (s.StartsWith("0x")) 
			{
				val = System.Convert.ToInt16(s, 16);
			} 
			else if (s.StartsWith("b")) 
			{
				val = System.Convert.ToInt16(s.Substring(1), 2);
			}
			else 
			{
				val = System.Convert.ToInt16(s, 10);
			}
			
			return new BaseChangeShort(val);
		}

		int val;

		public BaseChangeShort(int v) { val = v;	}
		public BaseChangeShort(uint v) { val = (int)v;	}
		public BaseChangeShort(short v) { val = v;	}
		internal BaseChangeShort() { val = 0; }

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
			get { return val; }
			set { val = value; }
		}

		/// <summary>
		/// Return the String Representation of the stored Value
		/// </summary>
		/// <returns>A String</returns>
		public override string ToString()
		{
			if (digitbase==16) 
			{
				return "0x"+val.ToString("x");
			} 
			else if (digitbase==2) 
			{
				return "b"+System.Convert.ToString(val, 2);
			}
			else 
			{
				return val.ToString();
			}
		}

	}

	/// <summary>
	/// Used to Dynamicaly create an Object Displayed in a PropertyGrid
	/// </summary>
	public class PropertyObjectBuilder
	{
		Type custDataType;
		object instance = null;
		Hashtable ht;

		public PropertyObjectBuilder(Hashtable ht)
		{
			this.ht = ht;
			AppDomain myDomain = Thread.GetDomain();
			AssemblyName myAsmName = new AssemblyName();
			myAsmName.Name = "MyDynamicAssembly";

			AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
				AssemblyBuilderAccess.Run);

			ModuleBuilder myModBuilder = myAsmBuilder.DefineDynamicModule("MyModule");

			TypeBuilder myTypeBuilder = myModBuilder.DefineType("CustomerData", 
				TypeAttributes.Public);

			
			//Add all properties
			foreach (string k in ht.Keys) AddProperty(k, myTypeBuilder);

			//Creat type and an Instance
			custDataType = myTypeBuilder.CreateType();
			instance = Activator.CreateInstance(custDataType);
			
			foreach (string k in ht.Keys) 
			{
				BaseChangeShort val = new BaseChangeShort((short)ht[k]);
				custDataType.InvokeMember(k, BindingFlags.SetProperty,
					null, instance, new object[]{ val });
			}
    
		}

		/// <summary>
		/// Add a Property To the new Type
		/// </summary>
		/// <param name="name">name of the Property</param>
		/// <param name="myTypeBuilder">The TypeBuidler Object</param>
		public static void AddProperty(string name, TypeBuilder myTypeBuilder)
		{
			FieldBuilder customerNameBldr = myTypeBuilder.DefineField("_"+name.ToLower(),
				typeof(BaseChangeShort),
				FieldAttributes.Private);

			PropertyBuilder custNamePropBldr = myTypeBuilder.DefineProperty(name,
				PropertyAttributes.HasDefault,
				typeof(BaseChangeShort),
				new Type[] { typeof(BaseChangeShort) });

			// First, we'll define the behavior of the "get" property for CustomerName as a method.
			MethodBuilder custNameGetPropMthdBldr = myTypeBuilder.DefineMethod("Get"+name,
				MethodAttributes.Public,    
				typeof(BaseChangeShort),
				new Type[] { });

			ILGenerator custNameGetIL = custNameGetPropMthdBldr.GetILGenerator();

			custNameGetIL.Emit(OpCodes.Ldarg_0);
			custNameGetIL.Emit(OpCodes.Ldfld, customerNameBldr);
			custNameGetIL.Emit(OpCodes.Ret);

			// Now, we'll define the behavior of the "set" property for CustomerName.
			MethodBuilder custNameSetPropMthdBldr = myTypeBuilder.DefineMethod("Set"+name,
				MethodAttributes.Public,    
				null,
				new Type[] { typeof(BaseChangeShort) });

			ILGenerator custNameSetIL = custNameSetPropMthdBldr.GetILGenerator();

			custNameSetIL.Emit(OpCodes.Ldarg_0);
			custNameSetIL.Emit(OpCodes.Ldarg_1);
			custNameSetIL.Emit(OpCodes.Stfld, customerNameBldr);
			custNameSetIL.Emit(OpCodes.Ret);

			// Last, we must map the two methods created above to our PropertyBuilder to 
			// their corresponding behaviors, "get" and "set" respectively. 
			custNamePropBldr.SetGetMethod(custNameGetPropMthdBldr);
			custNamePropBldr.SetSetMethod(custNameSetPropMthdBldr);
		}

		/// <summary>
		/// All Properties stored in the object
		/// </summary>
		public Hashtable Properties
		{
			get 
			{
				if (instance == null) return new Hashtable();

				Hashtable ret = new Hashtable();
				foreach (string k in ht.Keys) 
				{
					BaseChangeShort val = (BaseChangeShort)custDataType.InvokeMember(k, BindingFlags.GetProperty,
						null, instance, new object[]{ });
					ret[k] = val.Value;
				}
				
				return ret;
			}
		}

		/// <summary>
		/// Returns the created Object
		/// </summary>
		public object Instance
		{
			get 
			{
				return instance;
			}
		}
	}
}
