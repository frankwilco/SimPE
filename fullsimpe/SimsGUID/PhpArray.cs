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

namespace Ambertation.Soap
{
	/// <summary>
	/// Zusammenfassung für PhpArray.
	/// </summary>
	public class PhpSerialized
	{
		/// <summary>
		/// This Delegate can be used to register new token Handlers
		/// </summary>
		public delegate object SerializedTokenHandler(string str, ref int index);

		/// <summary>
		/// Erzeugt einen int Datentypen aus dem übergebenem String
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <returns>Der Zahlenwert</returns>
		protected static int ToInt(string str)
		{
			int val = 0;
			try {val = int.Parse(str);}
			catch{}
			return val;
		}

		/// <summary>
		/// Erzeugt einen double Datentypen aus dem übergebenem String
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <returns>Der Zahlenwert</returns>
		protected static double ToDouble(string str)
		{
			double val = 0;
			try {val = double.Parse(str);}
			catch{}
			return val;
		}

		#region Token Handler
		/// <summary>
		/// Behandelt ein Array Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">Data enthält das Hashtableelement das initialisiert werden soll</param>
		/// <returns>Ein neuer Hashtable welcher das Array darstellt</returns>
		/// <remarks>
		///		Ein serialisiertes Array hat z.B. die Form 
		///		<code>
		///			a:4:{s:4:"code";s:6:"700666";i:1;s:10:"16.09.1978";i:2;b:0;s:4:"test";s:23:"Das ist: {} "ein" test;";}
		///		</code>
		///	</remarks>
		protected static object ArrayHandler(string str, ref int index)
		{
			str = str.Substring(index);
			string[] tokens = str.Split(":".ToCharArray(), 3);
			if (tokens.Length<3) throw new Exception("Ungültiger Array Token");
			int len = ToInt(tokens[1]);
			
			index += 3; //2x':', 1x'{'
			index += tokens[0].Length;
			index += tokens[1].Length;

			//jetzt die Elemente des Array erzeugen
			Hashtable ret = new Hashtable();
			Hashtable sths = BuildSerializedArrayTokenHandlers();
			SerializedTokenHandler sth = null;
			object key = null;
			int itemcount = 0;

			//go throug the string character wise
			while ((index < str.Length) && (itemcount<len))
			{
				int oldindex = index;
				char curToken = str[index];

				if (curToken=='}') break;
				sth = (SerializedTokenHandler)sths[curToken];
				
				if (sth!=null) 
				{
					key = sth(str, ref index);
					if (key!=null) 
					{
						index++; //1x';'
						curToken = str[index];
						
						sth = (SerializedTokenHandler)sths[curToken];
						if (sth!=null) 
						{
							ret[key] = sth(str, ref index);
							itemcount++;
						} 
						else 
						{
							throw new Exception("Der Werttoken '"+curToken+"' ist nicht bekannt!");
						}
					} 
					else 
					{
						throw new Exception("Der Schlüssel darf nicht null sein!");
					}
				} 
				else 
				{
					throw new Exception("Der Schlüsseltoken '"+curToken+"' ist nicht bekannt!");
				}

				index++; //1x';'
			}

			index++; //1x'}';
			if (itemcount!=len) throw new Exception("Das Array konnte nicht korrekt verarbeitet werden. Die Anzahl der Elemente ist zu klein!");
			
			return ret;
		}

		/// <summary>
		/// Behandelt ein Object Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">Data enthält das Hashtableelement das initialisiert werden soll</param>
		/// <returns>Ein neuer Hashtable welcher die Attribute des Objektes darstellt</returns>
		/// <remarks>
		///		Ein serialisiertes Objekt hat z.B. die Form 
		///		<code>
		///			O:7:"Updater":2:{s:5:"tests";N;s:4:"else";N;}
		///		</code>
		///	</remarks>
		protected static object ObjectHandler(string str, ref int index)
		{
			string sstr = str.Substring(index);
			string[] tokens = sstr.Split(":".ToCharArray(), 5);
			if (tokens.Length<5) throw new Exception("Ungültiger Objekt Token");
			int namelen = ToInt(tokens[1]);
			int len = ToInt(tokens[3]);

			index += 7; //4x':', 1x'{', 2x'"'
			index += tokens[0].Length;
			index += tokens[1].Length;
			index += tokens[3].Length;
			index += namelen;

			//jetzt die Elemente des Array erzeugen
			Hashtable ret = new Hashtable();
			Hashtable sths = BuildSerializedArrayTokenHandlers();
			SerializedTokenHandler sth = null;
			object key = null;
			int itemcount = 0;



			//go throug the string character wise
			while ((index < str.Length) && (itemcount<len))
			{
				int oldindex = index;
				char curToken = str[index];

				if (curToken=='}') break;
				sth = (SerializedTokenHandler)sths[curToken];
				
				if (sth!=null) 
				{
					key = sth(str, ref index);
					if (key!=null) 
					{
						index++; //1x';'
						curToken = str[index];
						sth = (SerializedTokenHandler)sths[curToken];
						if (sth!=null) 
						{
							ret.Add(key, sth(str, ref index));
							itemcount++;
						} 
						else 
						{
							throw new Exception("Der Werttoken '"+curToken+"' ist nicht bekannt!");
						}
					} 
					else 
					{
						throw new Exception("Der Schlüssel darf nicht null sein!");
					}
				} 
				else 
				{
					throw new Exception("Der Schlüsseltoken '"+curToken+"' ist nicht bekannt!");
				}

				index++; //1x';'
			}

			index++; //1x'}';
			if (itemcount!=len) throw new Exception("Das Objekt konnte nicht korrekt verarbeitet werden. Die Anzahl der Elemente ist zu klein!");
			
			return ret;
		}

		/// <summary>
		/// Behandelt einen NULL Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <returns>Der Wert null</returns>
		/// <remarks>
		///		Ein serialisiertes NULL hat die Form 
		///		<code>
		///			N
		///		</code>
		///	</remarks>
		protected static object NullHandler(string str, ref int index)
		{
			string[] tokens = str.Split(":".ToCharArray(), 2);
			if (str[index]!='N') throw new Exception("Ungültiges NULL Token");
			
						
			index += 1; //1x':'
			return null;
		}

		/// <summary>
		/// Behandelt einen String Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">wird ignoriert</param>
		/// <returns>eine neue Zeichenkette</returns>
		/// <remarks>
		///		Ein serialisierter String hat z.B. die Form 
		///		<code>
		///			s:23:"Das ist: {} "ein" test;"
		///		</code>
		///	</remarks>
		protected static object StringHandler(string str, ref int index)
		{
			str = str.Substring(index);
			string[] tokens = str.Split(":".ToCharArray(), 3);
			if (tokens.Length<3) throw new Exception("Ungültiger String Token");
			int len = ToInt(tokens[1]);
			
			index += 4; //2x':', 2x'"'
			index += tokens[0].Length;
			index += tokens[1].Length;
			index += len;

			

			return tokens[2].Substring(1, len);
		}

		/// <summary>
		/// Behandelt einen Integer Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">wird ignoriert</param>
		/// <returns>eine int Wert</returns>
		/// <remarks>
		///		Ein serialisierter Integer hat z.B. die Form 
		///		<code>
		///			i:2
		///		</code>
		///	</remarks>
		protected static object IntegerHandler(string str, ref int index)
		{
			str = str.Substring(index);
			string[] tokens = str.Split(":".ToCharArray(), 2);
			if (tokens.Length<2) throw new Exception("Ungültiger Integer Token");
			tokens[1] = tokens[1].Split(";".ToCharArray(), 2)[0];
						
			index += 1; //1x':'
			index += tokens[0].Length;
			index += tokens[1].Length;
			return ToInt(tokens[1]);
		}

		/// <summary>
		/// Behandelt einen Integer Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">wird ignoriert</param>
		/// <returns>eine double Wert</returns>
		/// <remarks>
		///		Ein serialisierter Float hat z.B. die Form 
		///		<code>
		///			d:0.34000000000000003552713678800500929355621337890625
		///		</code>
		///	</remarks>
		protected static object FloatHandler(string str, ref int index)
		{
			str = str.Substring(index);
			string[] tokens = str.Split(":".ToCharArray(), 2);
			if (tokens.Length<2) throw new Exception("Ungültiger Integer Token");
			tokens[1] = tokens[1].Split(";".ToCharArray(), 2)[0];
						
			index += 1; //1x':'
			index += tokens[0].Length;
			index += tokens[1].Length;
			return ToDouble(tokens[1]);
		}

		/// <summary>
		/// Behandelt einen Boolean Token
		/// </summary>
		/// <param name="str">Die Zeichenkette</param>
		/// <param name="index">Der aktuelle Index der Zeichenkette</param>
		/// <param name="data">wird ignoriert</param>
		/// <returns>eine bool Wert</returns>
		/// <remarks>
		///		Ein serialisierter Boolean hat z.B. die Form 
		///		<code>
		///			b:0
		///		</code>
		///	</remarks>
		protected static object BoolHandler(string str, ref int index)
		{
			str = str.Substring(index);
			string[] tokens = str.Split(":".ToCharArray(), 2);
			if (tokens.Length<2) throw new Exception("Ungültiger Boolean Token");
			tokens[1] = tokens[1].Split(";".ToCharArray(), 2)[0];
						
			index += 1; //1x':'
			index += tokens[0].Length;
			index += tokens[1].Length;
			return (tokens[1]!="0");
		}
		#endregion

		/// <summary>
		/// Erzeugt eine Delegaten Liste für TokenHandler der Funktion GetHashtableFromSerializedArray()
		/// </summary>
		/// <returns>Einen Hastable der einerm Tokenwert eine Funcktion (delegate) zuordnet.</returns>
		protected static Hashtable BuildSerializedArrayTokenHandlers()
		{
			Hashtable sth = new Hashtable();

			sth.Add('N', new SerializedTokenHandler(NullHandler));
			sth.Add('O', new SerializedTokenHandler(ObjectHandler));
			sth.Add('a', new SerializedTokenHandler(ArrayHandler));
			sth.Add('s', new SerializedTokenHandler(StringHandler));
			sth.Add('i', new SerializedTokenHandler(IntegerHandler));
			sth.Add('d', new SerializedTokenHandler(FloatHandler));
			sth.Add('b', new SerializedTokenHandler(BoolHandler));

			return sth;
		}


		/// <summary>
		/// Creates a new Hastable from the Information stored in a Serialized Array String generated by php.
		/// </summary>
		/// <param name="str">The serialized Array</param>
		/// <returns>The generated Hashtable</returns>
		public static Hashtable GetHashtableFromSerializedArray(string str)
		{
			Hashtable sths = BuildSerializedArrayTokenHandlers();
			SerializedTokenHandler sth = null;
			int index = 0;

			//go throug the string character wise
			while (index < str.Length) 
			{
				int oldindex = index;
				char curToken = str[index];
				sth = (SerializedTokenHandler)sths[curToken];
				
				if (sth!=null) 
				{
					object obj  = sth(str, ref index);
					if (obj!=null) 
					{
						return (Hashtable)obj;
					}
				} 

				if (index==oldindex) index++;
			}

			return null;
		}
	}
}
