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

namespace SimPe.Data
{
	/// <summary>
	/// Localized Version of the Grades Enum
	/// </summary>
	public class LocalizedRelationshipTypes
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.RelationshipTypes data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedRelationshipTypes(MetaData.RelationshipTypes data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedRelationshipTypes(MetaData.RelationshipTypes item)
		{
			return new LocalizedRelationshipTypes(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.RelationshipTypes(LocalizedRelationshipTypes item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedRelationshipTypes(ushort item)
		{
			return new LocalizedRelationshipTypes((MetaData.RelationshipTypes)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator ushort(LocalizedRelationshipTypes item)
		{
			return (ushort)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString("RT_"+data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

		public override bool Equals(object obj)
		{	bool ret = base.Equals(obj);
			if (ret) ret = (((LocalizedRelationshipTypes)obj).data == data);
			return ret;
		}

		public static bool operator ==(MetaData.RelationshipTypes op1, LocalizedRelationshipTypes op2)
		{
			return (op1 == op2.data);
		}

		public static bool operator !=(MetaData.RelationshipTypes op1, LocalizedRelationshipTypes op2)
		{
			return (op1 != op2.data);
		}

		public static bool operator ==(LocalizedRelationshipTypes op1, MetaData.RelationshipTypes op2)
		{
			return (op1.data == op2);
		}

		public static bool operator !=(LocalizedRelationshipTypes op1, MetaData.RelationshipTypes op2)
		{
			return (op1.data != op2);
		}

		public static bool operator ==(LocalizedRelationshipTypes op1, LocalizedRelationshipTypes op2)
		{
			return (op1.data == op2.data);
		}

		public static bool operator !=(LocalizedRelationshipTypes op1, LocalizedRelationshipTypes op2)
		{
			return (op1.data != op2.data);
		}

		public static bool operator ==(object op1, LocalizedRelationshipTypes op2)
		{
			if (op1.GetType() != typeof(LocalizedRelationshipTypes)) return false;
			LocalizedRelationshipTypes op = (LocalizedRelationshipTypes)op1;
			return (op.data == op2.data);
		}

		public static bool operator !=(object op1, LocalizedRelationshipTypes op2)
		{
			if (op1.GetType() != typeof(LocalizedRelationshipTypes)) return true;
			LocalizedRelationshipTypes op = (LocalizedRelationshipTypes)op1;
			return (op.data != op2.data);
		}

		public static bool operator ==(LocalizedRelationshipTypes op2, object op1)
		{
			if (op1.GetType() != typeof(LocalizedRelationshipTypes)) return false;
			LocalizedRelationshipTypes op = (LocalizedRelationshipTypes)op1;
			return (op.data == op2.data);
		}

		public static bool operator !=(LocalizedRelationshipTypes op2, object op1)
		{
			if (op1.GetType() != typeof(LocalizedRelationshipTypes)) return true;
			LocalizedRelationshipTypes op = (LocalizedRelationshipTypes)op1;
			return (op.data != op2.data);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}		
	}

	/// <summary>
	/// Localized Version of the Grades Enum
	/// </summary>
	public class LocalizedGrades
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.Grades data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedGrades(MetaData.Grades data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedGrades(MetaData.Grades item)
		{
			return new LocalizedGrades(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.Grades(LocalizedGrades item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedGrades(ushort item)
		{
			return new LocalizedGrades((MetaData.Grades)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator ushort(LocalizedGrades item)
		{
			return (ushort)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString("Grade_"+data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the SchoolType Enum
	/// </summary>
	public class LocalizedSchoolType
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.SchoolTypes data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedSchoolType(MetaData.SchoolTypes data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedSchoolType(MetaData.SchoolTypes item)
		{
			return new LocalizedSchoolType(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.SchoolTypes(LocalizedSchoolType item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedSchoolType(uint item)
		{
			return new LocalizedSchoolType((MetaData.SchoolTypes)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator uint(LocalizedSchoolType item)
		{
			return (uint)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString(data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the AspirationType Enum
	/// </summary>
	public class LocalizedAspirationTypes
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.AspirationTypes data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedAspirationTypes(MetaData.AspirationTypes data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedAspirationTypes(MetaData.AspirationTypes item)
		{
			return new LocalizedAspirationTypes(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.AspirationTypes(LocalizedAspirationTypes item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedAspirationTypes(ushort item)
		{
			return new LocalizedAspirationTypes((MetaData.AspirationTypes)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator ushort(LocalizedAspirationTypes item)
		{
			return (ushort)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString(data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the ZodiacSignes Enum
	/// </summary>
	public class LocalizedZodiacSignes
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.ZodiacSignes data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedZodiacSignes(MetaData.ZodiacSignes data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedZodiacSignes(MetaData.ZodiacSignes item)
		{
			return new LocalizedZodiacSignes(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.ZodiacSignes(LocalizedZodiacSignes item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedZodiacSignes(ushort item)
		{
			return new LocalizedZodiacSignes((MetaData.ZodiacSignes)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator ushort(LocalizedZodiacSignes item)
		{
			return (ushort)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString(data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the LifeSections Enum
	/// </summary>
	public class LocalizedLifeSections
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.LifeSections data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedLifeSections(MetaData.LifeSections data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedLifeSections(MetaData.LifeSections item)
		{
			return new LocalizedLifeSections(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.LifeSections(LocalizedLifeSections item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedLifeSections(ushort item)
		{
			return new LocalizedLifeSections((MetaData.LifeSections)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator ushort(LocalizedLifeSections item)
		{
			return (ushort)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString(data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the Careers Enum
	/// </summary>
	public class LocalizedCareers
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.Careers data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedCareers(MetaData.Careers data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedCareers(MetaData.Careers item)
		{
			return new LocalizedCareers(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.Careers(LocalizedCareers item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedCareers(uint item)
		{
			return new LocalizedCareers((MetaData.Careers)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator uint(LocalizedCareers item)
		{
			return (uint)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = Localization.Manager.GetString(data.ToString());
			if (s!=null) return s;
			else return data.ToString();
		}

	}


	/// <summary>
	/// Localized Version of the FamilyTieTypes Enum
	/// </summary>
	public class LocalizedFamilyTieTypes
	{
		/// <summary>
		/// Contains the value
		/// </summary>
		MetaData.FamilyTieTypes data;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="data">The Value of the Enum</param>
		public LocalizedFamilyTieTypes(MetaData.FamilyTieTypes data)
		{
			this.data = data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedFamilyTieTypes(MetaData.FamilyTieTypes item)
		{
			return new LocalizedFamilyTieTypes(item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator MetaData.FamilyTieTypes(LocalizedFamilyTieTypes item)
		{
			return item.data;
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator LocalizedFamilyTieTypes(uint item)
		{
			return new LocalizedFamilyTieTypes((MetaData.FamilyTieTypes)item);
		}

		/// <summary>
		/// Implicit Assignement of Enum Values
		/// </summary>
		/// <param name="item">the value</param>
		/// <returns>the new Object</returns>
		public static implicit operator uint(LocalizedFamilyTieTypes item)
		{
			return (uint)item.data;
		}

		/// <summary>
		/// Overrides the Default to string Members
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			if (Helper.StartedGui == Executable.Default) 
			{
				Type type = typeof(MetaData.FamilyTieTypes);
				string s = Localization.Manager.GetString(type.Namespace+"."+type.Name+"."+data.ToString());
				if (s!=null) return s;
				else return data.ToString();
			} 
			else 
			{
				string s = Localization.Manager.GetString(data.ToString());
				if (s!=null) return s;
				else return data.ToString();
			}
		}

	}
}
