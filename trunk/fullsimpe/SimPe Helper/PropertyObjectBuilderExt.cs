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

namespace Ambertation
{
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
					return BaseChangeableNumber.Convert(s, type);
				}
				catch 
				{
					throw new ArgumentException(
						"Can not convert '" + (string)value + "'. This is not a valid "+BaseChangeableNumber.BaseName+" Number!");						
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
			long val = 0;
			if (s.StartsWith("0x")) 
			{
				val = System.Convert.ToInt64(s, 16);
			} 
			else if (s.StartsWith("b")) 
			{
				val = System.Convert.ToInt64(s.Substring(1), 2);
			}
			else 
			{
				val = System.Convert.ToInt64(s, 10);
			}
			
			return new BaseChangeableNumber(val, type);
		}

		long val;

		public BaseChangeableNumber(object v) { 
			ObjectValue = v;
		}

		internal BaseChangeableNumber(object v, Type t) 
		{ 
			SetValue(v, t);
		}

		internal BaseChangeableNumber() { 
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

		internal void SetValue(object o, Type t) 
		{
			type = o.GetType();
			
			if (type==typeof(int)) val = (int)o;
			else if (type==typeof(uint)) val = (uint)o;
			else if (type==typeof(short)) val = (short)o;
			else if (type==typeof(ushort)) val = (ushort)o;				
			else if (type==typeof(byte)) val = (byte)o;								
			else if (type==typeof(ulong)) val = (long)((ulong)o);
			else val = (long)o;		

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
	/// Meta Descriptions for a Property
	/// </summary>
	public class PropertyDescription 
	{
		string desc;
		/// <summary>
		/// The Description of the Property (=Help Text)
		/// </summary>
		public string Description
		{
			get { return desc; }
		}

		string cat;
		/// <summary>
		/// The Category of the Property 
		/// </summary>
		public string Category
		{
			get { return cat; }
		}

		object prop;
		/// <summary>
		/// The Property (=Content)
		/// </summary>
		public object Property
		{
			get { 
				if (prop.GetType()==typeof(byte) ||
					prop.GetType()==typeof(short) ||
					prop.GetType()==typeof(ushort) ||
					prop.GetType()==typeof(int) ||
					prop.GetType()==typeof(uint) ||
					prop.GetType()==typeof(long) ||
					prop.GetType()==typeof(ulong)
					) 
				{
					return new BaseChangeableNumber(prop);
				}
				return prop; 
			}
			set { 
				if (value.GetType()==typeof(BaseChangeableNumber)) 
				{
					prop = ((BaseChangeableNumber)value).ObjectValue;
				} 
				else { 
					try 
					{
						if (type.IsEnum) 
						{
							if (value.GetType()!=typeof(int))								
								prop = System.Enum.ToObject(type, type.GetField(value.ToString()).GetValue(null));
							else
								prop = System.Enum.ToObject(type, System.Convert.ToInt32(value));

						} 
						else 
						{
							prop = System.Convert.ChangeType(value, type); 
						}
					} 
					catch 
					{
						//this is a special Handle for Booleans
						if (type==typeof(bool) && value.GetType()==typeof(string)) 
						{
							string s=(string)value;
							s=s.Trim();
							if (s=="0") prop = false;
							else prop = true;
						} 
						else 
						{
							prop = value;
							type = value.GetType();
						}
					}
				}
			}
		}

		Type type;
		/// <summary>
		/// Returns the Type of the Object
		/// </summary>
		public Type Type 
		{
			get { return type; }
		}


		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="category"></param>
		/// <param name="description"></param>
		/// <param name="property"></param>
		public PropertyDescription(string category, string description, object property) :
			this(category, description, property, property.GetType())
		{
			
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="category"></param>
		/// <param name="description"></param>
		/// <param name="property"></param>
		/// <param name="type">type of the Object</param>
		public PropertyDescription(string category, string description, object property, Type type) 
		{
			desc = description;
			cat = category;
			prop = property;
			this.type = type;
		}

		/// <summary>
		/// Create a clone (this will NOT copy the property, but set it to null!!!)
		/// </summary>
		/// <returns>The cloned Object</returns>
		public PropertyDescription Clone() 
		{
			return new PropertyDescription(cat, desc, null, type);
		}
	}

	/// <summary>
	/// Used to Dynamicaly create an Object Displayed in a PropertyGrid
	/// </summary>
	public class PropertyObjectBuilderExt
	{
		Type custDataType;
		object instance = null;
		Hashtable ht;

		public PropertyObjectBuilderExt(Hashtable ht)
		{
			this.ht = ht;
			AppDomain myDomain = Thread.GetDomain();
			AssemblyName myAsmName = new AssemblyName();
			myAsmName.Name = "EmittedAssembly";

			AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
				AssemblyBuilderAccess.Run);

			ModuleBuilder myModBuilder = myAsmBuilder.DefineDynamicModule("EmittedModule");

			TypeBuilder myTypeBuilder = myModBuilder.DefineType("Ambertation", 
				TypeAttributes.Public);

			
			//Add all properties
			foreach (string k in ht.Keys) 
			{
				object o = ht[k];
				if (o.GetType()==typeof(PropertyDescription)) 
				{
					PropertyDescription pd = (PropertyDescription)o;
					AddProperty(k, myTypeBuilder, pd.Property.GetType(), pd.Description, pd.Category);
				} 
				else 
				{
					AddProperty(k, myTypeBuilder, o.GetType(), "[Unknown Property]", null);
				}
			}

			//Creat type and an Instance
			custDataType = myTypeBuilder.CreateType();
			instance = Activator.CreateInstance(custDataType);
			
			foreach (string k in ht.Keys) 
			{
				Object val = ht[k];

				if (val.GetType()==typeof(PropertyDescription))  
				{
					PropertyDescription pd = (PropertyDescription)val;
					val = pd.Property;
				} 

				custDataType.InvokeMember(
						k, 
						BindingFlags.SetProperty,
						null, 
						instance, 
						new object[]{ val }
						);
								
			}
    
		}

		/// <summary>
		/// Add an Attribute
		/// </summary>
		/// <param name="custNamePropBldr"></param>
		/// <param name="attrType"></param>
		/// <param name="val"></param>
		static void AddAttribute(PropertyBuilder custNamePropBldr, Type attrType, string val)
		{
			ConstructorInfo classCtorCat =
				attrType.GetConstructor(new Type[] { typeof(string) });
			CustomAttributeBuilder myCABuilder = new CustomAttributeBuilder(
				classCtorCat,
				new object[] { val });
			custNamePropBldr.SetCustomAttribute(myCABuilder);
		}

		/// <summary>
		/// Add a Property To the new Type
		/// </summary>
		/// <param name="name">name of the Property</param>
		/// <param name="myTypeBuilder">The TypeBuidler Object</param>
		/// <param name="type">Type of the Property</param>
		/// <param name="category">Category the Property is assigned to</param>
		/// <param name="description">Description for this Category</param>
		public static void AddProperty(string name, TypeBuilder myTypeBuilder, Type type, string description, string category)
		{
			FieldBuilder customerNameBldr = myTypeBuilder.DefineField("_"+name.ToLower(),
				type,
				FieldAttributes.Private);

			
			PropertyBuilder custNamePropBldr = myTypeBuilder.DefineProperty(
				name,
				PropertyAttributes.HasDefault,
				type,
				new Type[] { });			

			//Define Category-Attribute
			if (category!=null) AddAttribute(custNamePropBldr, typeof(CategoryAttribute), category);

			//Define Description-Attribute
			if (description!=null) AddAttribute(custNamePropBldr, typeof(DescriptionAttribute), description);
			

			// First, we'll define the behavior of the "get" property for CustomerName as a method.
			MethodBuilder custNameGetPropMthdBldr = myTypeBuilder.DefineMethod("Get"+name,
				MethodAttributes.Public,    
				type,
				new Type[] { });

			ILGenerator custNameGetIL = custNameGetPropMthdBldr.GetILGenerator();

			custNameGetIL.Emit(OpCodes.Ldarg_0);
			custNameGetIL.Emit(OpCodes.Ldfld, customerNameBldr);
			custNameGetIL.Emit(OpCodes.Ret);

			// Now, we'll define the behavior of the "set" property for CustomerName.
			MethodBuilder custNameSetPropMthdBldr = myTypeBuilder.DefineMethod("Set"+name,
				MethodAttributes.Public,    
				null,
				new Type[] { type });

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
					object val = custDataType.InvokeMember(k, BindingFlags.GetProperty,
						null, instance, new object[]{ });

					if (val.GetType()==typeof(BaseChangeableNumber)) val = ((BaseChangeableNumber)val).ObjectValue;				
					ret[k] = val;
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
