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
	/// You can use this Class to dynamically create a Flag Class based on an Enum
	/// </summary>
	public class FlagObjectBuilder : SimPe.FlagBase
	{
		public FlagObjectBuilder() :base(0)
		{
		}

		public static object ActivateType(Type t,object[] o)
		{			
			if (o!=null)
				return System.Activator.CreateInstance(t, o);
			else 
				return System.Activator.CreateInstance(t);
		}

		public static Type BuildFlagObject(string classname, Type useenum)
		{
			
			if (!useenum.IsEnum) return typeof(SimPe.FlagBase);

			Array values = System.Enum.GetValues(useenum);

			AppDomain myDomain = Thread.GetDomain();
			AssemblyName myAsmName = typeof(FlagObjectBuilder).Assembly.GetName();

			AssemblyBuilder myAsmBuilder = myDomain.DefineDynamicAssembly(myAsmName,
				AssemblyBuilderAccess.Run);

			ModuleBuilder myModBuilder = myAsmBuilder.DefineDynamicModule("FlagModules.dll");			

			TypeBuilder myTypeBuilder = myModBuilder.DefineType(classname, 
				TypeAttributes.Public, typeof(FlagObjectBuilder));

			
			
			foreach (object v in values)
			{
				string name = v.ToString();
				string[] parts = name.Split("_".ToCharArray(), 2);
				if (parts.Length==1)
					AddProperty(name, myTypeBuilder, false, "", "", false);
				else if(parts.Length==2) 
					AddProperty(name, myTypeBuilder, false, "", parts[0], false);
					

			}

			//Creat type and an Instance
			Type custDataType = myTypeBuilder.CreateType();			
						

			return custDataType;
		}

		/// <summary>
		/// Add a Property To the new Type
		/// </summary>
		/// <param name="name">name of the Property</param>
		/// <param name="myTypeBuilder">The TypeBuidler Object</param>
		/// <param name="o">The default value for that Property</param>
		/// <param name="category">Category the Property is assigned to</param>
		/// <param name="description">Description for this Category</param>
		/// <param name="ro">true if this Item should be ReadOnly</param>
		protected static void AddProperty(string name, TypeBuilder myTypeBuilder, object o, string description, string category, bool ro)
		{
			Type type = o.GetType();
			FieldBuilder customerNameBldr = myTypeBuilder.DefineField("_"+name.ToLower(),
				type,
				FieldAttributes.Private);

			PropertyBuilder custNamePropBldr = myTypeBuilder.DefineProperty(
				name,
				PropertyAttributes.HasDefault,
				type,
				new Type[] { });			

			//Define Category-Attribute
			if (category!=null) if (category!="") PropertyObjectBuilderExt.AddAttribute(custNamePropBldr, typeof(CategoryAttribute), category);

			//Define Description-Attribute
			if (description!=null) PropertyObjectBuilderExt.AddAttribute(custNamePropBldr, typeof(DescriptionAttribute), description);
			PropertyObjectBuilderExt.AddAttribute(custNamePropBldr, typeof(ReadOnlyAttribute), ro);
			//AddAttribute(custNamePropBldr, typeof(DefaultValueAttribute), o, true);
			

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
	}
}
