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
using System.Text;
using System.Runtime.InteropServices;

namespace SimPe
{
	/// <summary>
	/// Determins the Executable that was started
	/// </summary>
	public enum Executable : byte 
	{
		Classic = 1,
		Default = 2,
		WizardsOfSimpe = 3,
		Other = 4
	}
	/// <summary>
	/// Some Helper Functions frequently used in the handlers
	/// </summary>
	public static class Helper
	{
		/// <summary>
		/// Linebreaks
		/// </summary>
		public const string lbr = "\r\n";
		/// <summary>
		/// Tabs
		/// </summary>
		public const string tab = "    ";

		/// <summary>
		/// Characters allowd in a Filepath
		/// </summary>
		public const string PATH_CHARACTERS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzﬂ0123456789.-_ ";

		/// <summary>
		/// Character used to Seperate Folders in a Path
		/// </summary>
#if MAC
		public const string PATH_SEP = "/";
#else
		public const string PATH_SEP = "\\";
#endif

		/// <summary>
		/// Contains a Link to the Registry Object
		/// </summary>
		static Registry reg = null;

		/// <summary>
		/// Returns the Link to the Windows Registry
		/// </summary>
		public static Registry WindowsRegistry
		{
			get { 
				if (reg==null) reg = new Registry();
				return reg; 
			}
		}

		/// <summary>
		/// Contains a the Commandline Parameters
		/// </summary>
		static Parameters param;

		/// <summary>
		/// Returns /Sets the Commandline Parameters
		/// </summary>
		public static Parameters CommandlineParameters
		{
			get {return param; }
			set {param = value; }
		}

		/// <summary>
		/// Generates a BinaryReader from a Byte Buffer
		/// </summary>
		/// <param name="data">The Byte Buffer</param>
		/// <returns>The Binary Handler</returns>
		public static BinaryReader GetBinaryReader(Byte[] data)
		{
			return new BinaryReader(new MemoryStream(data));
		}

		/// <summary>
		/// Creates a HexString (with Leading 0) of the given Length
		/// </summary>
		/// <param name="input">The HexFormated String with arbitrary Length</param>
		/// <param name="length">The min. Length for the String</param>
		/// <returns>The input String with added zeros.</returns>
		public static string MinStrLength(string input, int length)
		{
			while (input.Length<length) input = "0"+input;
			return input;
		}
        /// <summary>
		/// Creates a HexString (with Leading 0) of the given Length
		/// </summary>
		/// <param name="input">The HexFormated String with arbitrary Length</param>
		/// <param name="length">The min. Length for the String</param>
		/// <returns>The input String with added zeros.</returns>
        public static string StrLength(string input, int length)
        {
            while (input.Length < length) input += "0";
            if (input.Length > length) input = input.Substring(0, length);
            return input;
        }

		/// <summary>
		/// Creates a HexString (with Leading 0) of the given Length
		/// </summary>
		/// <param name="input">The HexFormated String with arbitrary Length</param>
		/// <param name="length">The min. Length for the String</param>
		/// <returns>The input String with added zeros.</returns>
        /// <param name="left">True, if you want to add from the left, and cut from the right</param>
		public static string StrLength(string input, int length, bool left)
		{
            if (left) return StrLength(input, length);
			while (input.Length<length) input = "0"+input;
			if (input.Length>length) input = input.Substring(input.Length-length, length);
			return input;
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 8 Chars long)</returns>
		public static string HexString(long input)
		{
			return HexString((ulong) input);
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 8 Chars long)</returns>
		public static string HexString(ulong input)
		{
			return (MinStrLength(input.ToString("X"), 16));
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 8 Chars long)</returns>
		public static string HexString(int input)
		{
			return HexString((uint)input);
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 8 Chars long)</returns>
		public static string HexString(uint input)
		{
			return (MinStrLength(input.ToString("X"), 8));
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 4 Chars long)</returns>
		public static string HexString(short input)
		{
			return HexString((ushort)input);
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 4 Chars long)</returns>
		public static string HexString(ushort input)
		{
			return (MinStrLength(input.ToString("X"), 4));
		}

		/// <summary>
		/// Returns the Value as HexString
		/// </summary>
		/// <param name="input">the Input Value</param>
		/// <returns>value as HexString (allways 4 Chars long)</returns>
		public static string HexString(byte input)
		{
			return (MinStrLength(input.ToString("X"), 2));
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static uint HexStringToUInt(string txt)
		{
			return StringToUInt32(txt, 0, 16);
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static uint StringToUInt32(string txt, uint def, byte bbase)
		{
			try 
			{
				return Convert.ToUInt32(txt, bbase);
			} 
			catch 
			{
				return def;
			}
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static float StringToFloat(string txt, float def)
		{
			try 
			{
				return Convert.ToSingle(txt);
			} 
			catch 
			{
				return def;
			}
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static int StringToInt32(string txt, int def, byte bbase)
		{
			try 
			{
				return Convert.ToInt32(txt, bbase);
			} 
			catch 
			{
				return def;
			}
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static ushort StringToUInt16(string txt, ushort def, byte bbase)
		{
			try 
			{
				return Convert.ToUInt16(txt, bbase);
			} 
			catch 
			{
				return def;
			}
		}

		/// <summary>
		/// Returns the Value represented by the HexString
		/// </summary>
		/// <param name="txt">The hex String</param>
		/// <returns>the represented value</returns>
		public static short StringToInt16(string txt, short def, byte bbase)
		{
			try 
			{
				return Convert.ToInt16(txt, bbase);
			} 
			catch 
			{
				return def;
			}
		}

		/// <summary>
		/// Removes all Characters that are not present in the allowd String
		/// </summary>
		/// <param name="input">The String you want to change</param>
		/// <param name="allowed">A string coinatining all Allowed Charactres</param>
		/// <returns>the string without illegal Charactres</returns>
		public static string RemoveUnlistedCharacters(string input, string allowed) 
		{
			string output = "";
			for (int i=0; i<input.Length; i++) 
			{
				char c = input[i];
				if (allowed.IndexOf(c)!=-1) output += c;
			}

			return output;
		}

		/// <summary>
		/// Returns a Caharcter that can be displayed
		/// </summary>
		/// <param name="c">The Charcatre to convert</param>
		/// <returns>a displayable character</returns>
		public static char DisplayableCharactre(char c) 
		{
			if ((c>0x1F) && (c<0xff) && (c!=0xAD) && ((c<0x7F) || (c>0x9F)))  return c;
			else return '.';
		}

		/// <summary>
		/// Shows an Exception Message for the User
		/// </summary>
		/// <param name="ex">The Exception</param>
		public static void ExceptionMessage(Exception ex) 
		{
			ExceptionForm.Execute("", ex);
		}

		/// <summary>
		/// Shows an Exception Message for the User
		/// </summary>
		/// <param name="ex">The Exception</param>
		/// <param name="message">An operation Description (when did the Exception occur)</param>
		public static void ExceptionMessage(string message, Exception ex) 
		{
			ExceptionForm.Execute(message, ex);
		}

		/// <summary>
		/// Creates a String from an Object
		/// </summary>
		/// <param name="o">The Input Object</param>
		/// <returns>The stored value as String</returns>
		public static string ToString(object o) 
		{
			if (o==null) return "";
			else return o.ToString();
		}

		/// <summary>
		/// Creates a String from a Byte Array
		/// </summary>
		/// <param name="ba">The Aray</param>
		/// <returns>The stored value as String</returns>
		/*public static string ToString(byte[] ba) 
		{
			if (ba==null) return "";

			string s = "";
			foreach(byte b in ba) if (b!=0) s += (char)b;
			return s;
		}*/

		/// <summary>
		/// Returns the Path SimPe is located in
		/// </summary>
		public static string SimPePath 
		{
			get
			{
				return System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
			}
		}

		/// <summary>
		/// Returns the Path SimPe Plugins are located in
		/// </summary>
		public static string SimPePluginPath 
		{
			get
			{
				return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "Plugins");
			}
		}

		/// <summary>
		/// Returns the Path for SimPe Teleports
		/// </summary>
		public static string SimPeTeleportPath 
		{
			get
			{
				string dir = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "Teleport");
				try 
				{
					if (!System.IO.Directory.Exists(dir))
						System.IO.Directory.CreateDirectory(dir);
				} 
				catch {}
				return dir;
			}
		}		

		/// <summary>
		/// Returns the Name of a Language Cache File with the passed Prefix
		/// </summary>
		/// <param name="prefix"></param>
		/// <returns></returns>
		public static string GetSimPeLanguageCache(string prefix) 
		{
			return System.IO.Path.Combine(Helper.SimPeDataPath, prefix+Helper.HexString((byte)Helper.WindowsRegistry.LanguageCode)+".simpepkg");
		}

		/// <summary>
		/// Returns the Name of the Cache File for the current Language
		/// </summary>
		public static string SimPeLanguageCache 
		{
			get { return GetSimPeLanguageCache("objcache_"); }
		}

		/// <summary>
		/// Returns the Name of a Cache File with the passed Prefix
		/// </summary>
		/// <param name="prefix"></param>
		/// <returns></returns>
		public static string GetSimPeCache(string prefix) 
		{
			return System.IO.Path.Combine(Helper.SimPeDataPath, prefix+".simpepkg");
		}

		/// <summary>
		/// Returns the Name of the Language independent Cache File
		/// </summary>
		public static string SimPeCache 
		{
			get { return GetSimPeCache("objcache"); }
		}

		/// <summary>
		/// Returns the Path additional SimPe Files are located in
		/// </summary>
		public static string SimPeDataPath 
		{
			get
			{
				string path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath), "Data");
				try 
				{
					if (!System.IO.Directory.Exists(path))
						System.IO.Directory.CreateDirectory(path);
				} 
				catch {}
				return path;
			}
		}

		/// <summary>
		/// Returns the Path additional SimPe Files are located in
		/// </summary>
		public static string SimPePluginDataPath 
		{
			get
			{
				string path =  System.IO.Path.Combine(SimPeDataPath, "Plugins");
				try 
				{
					if (!System.IO.Directory.Exists(path))
						System.IO.Directory.CreateDirectory(path);
				} 
				catch {}
				return path;
			}
		}

		/// <summary>
		/// Returns the File, that holds the users Viewport Data
		/// </summary>
		public static string SimPeViewportFile
		{
			get
			{
				return System.IO.Path.Combine(SimPeDataPath, "vport.set");
			}
		}

		/// <summary>
		/// Returns the Version Information for the started Executable
		/// </summary>
		public static System.Diagnostics.FileVersionInfo ExecutableVersion 
		{
			get 
			{
				return System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Windows.Forms.Application.ExecutablePath); 
			}
		}
		/// <summary>
		/// Returns the the overall SimPe Version
		/// </summary>
		public static System.Diagnostics.FileVersionInfo SimPeVersion 
		{
			get { 
				try 
				{
					return System.Diagnostics.FileVersionInfo.GetVersionInfo(typeof(Helper).Assembly.Location);
				} 
				catch 
				{
					return ExecutableVersion;
				}
			}
		}

		/// <summary>
		/// Returns the long Version Number
		/// </summary>
		public static long SimPeVersionLong 
		{
			get { return  VersionToLong(SimPeVersion); }				
		}

		/// <summary>
		/// Returns the long Version Number
		/// </summary>
		public static long VersionToLong(System.Diagnostics.FileVersionInfo ver)
		{
			long lver = ver.FileMajorPart;
			lver = (lver << 16) + ver.FileMinorPart;
			lver = (lver << 16) + ver.FileBuildPart;
			lver = (lver << 16) + ver.FilePrivatePart;
			return lver;
			
		}		

		/// <summary>
		/// Formats the Version and returns it
		/// </summary>
		/// <param name="ver"></param>
		/// <returns></returns>
		public static string VersionToString(System.Diagnostics.FileVersionInfo ver)
		{
			return ver.FileMajorPart+"."+ver.FileMinorPart+"."+ver.FileBuildPart+"."+ver.FilePrivatePart;
		}

		/// <summary>
		/// Formats a Long Version Number to a String
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public static string LongVersionToString(long l)
		{	
			string res = "";
			res = (l & 0xffff).ToString();
			l = l>>16;
			res = (l & 0xffff).ToString()+"."+res;
			l = l>>16;
			res = (l & 0xffff).ToString()+"."+res;
			l = l>>16;
			res = (l & 0xffff).ToString()+"."+res;		
			return res;
		}

		/// <summary>
		/// Formats a Long Version Number to a String
		/// </summary>
		/// <param name="l"></param>
		/// <returns></returns>
		public static string LongVersionToShortString(long l)
		{	
			string res = "";			
			l = l>>16;			
			l = l>>16;
			res = (l & 0xffff).ToString();
			l = l>>16;
			res = (l & 0xffff).ToString()+"."+res;		
			return res;
		}

		/// <summary>
		/// Returns the Version Number as Text
		/// </summary>
		public static string SimPeVersionString 
		{
			get 
			{ 
				System.Diagnostics.FileVersionInfo ver = SimPeVersion;
				return VersionToString(ver);				
			}
		}

		/// <summary>
		/// true if this is a QA Release
		/// </summary>
		public static bool QARelease
		{
			get 
			{
				return ((SimPeVersion.ProductMinorPart % 2)==1);
			}
		}

		/// <summary>
		/// Returnst the Gui that was started
		/// </summary>
		public static Executable StartedGui 
		{
			get
			{
				if (System.Windows.Forms.Application.ExecutablePath.Trim().ToLower().EndsWith("simpe.exe")) return Executable.Default;
				else if (System.Windows.Forms.Application.ExecutablePath.Trim().ToLower().EndsWith("simpe classic.exe")) return Executable.Classic;
				else if (System.Windows.Forms.Application.ExecutablePath.Trim().ToLower().EndsWith("wizards of simpe.exe")) return Executable.WizardsOfSimpe;
				else return Executable.Other;
			}
		}

		/// <summary>
		/// Creates a String from a byte Array
		/// </summary>
		/// <param name="data">The Byte Array</param>
		/// <returns>the String Representation</returns>
		public static string ToString(byte[] data) 
		{
			if (data==null) return "";

			string text = "";
			System.IO.BinaryReader ms = new BinaryReader(new MemoryStream(data));
			try 
			{
				while (ms.BaseStream.Position<ms.BaseStream.Length) 
				{
					if (ms.PeekChar()==0) break;
					if (ms.PeekChar()==-1) break;
					text += ms.ReadChar();
				}
			} 
			catch ( Exception) {}	
	
			return text;
		}

		/// <summary>
		/// Returns the passed String as a Byte Array of the given Length
		/// </summary>
		/// <param name="str">The String to Convert</param>
		/// <returns>A Byte Array of the given Length (filled with 0)</returns>
		public static byte[] ToBytes(string str) 
		{
			return ToBytes(str, 0);
		}

		/// <summary>
		/// Returns the passed String as a Byte Array of the given Length
		/// </summary>
		/// <param name="str">The String to Convert</param>
		/// <param name="len">Length of the Array (the returned Array will have this exact Length)</param>
		/// <returns>A Byte Array of the given Length (filled with 0)</returns>
		public static byte[] ToBytes(string str, int len) 
		{
			
			/*System.IO.MemoryStream ms = new MemoryStream();
			System.IO.BinaryWriter bw = new BinaryWriter(ms);
			foreach (char c in str) 
			{
				if ((len==0) || (bw.BaseStream.Position<len)) bw.Write(c);
			}
			if (len!=0) ms.SetLength(len);

			bw.Flush();
			System.IO.BinaryReader br = new BinaryReader(ms);
			br.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
			ret = br.ReadBytes((int)br.BaseStream.Length);*/

			byte[] ret = null;
			if (len!=0) 
			{
				ret = new byte[len];
				System.Text.Encoding.ASCII.GetBytes(str, 0, Math.Min(len, str.Length), ret, 0);
			}
			else ret = System.Text.Encoding.ASCII.GetBytes(str);

			return ret;
		}

		/// <summary>
		/// Copy a Complete directory
		/// </summary>
		/// <param name="sourcePath"></param>
		/// <param name="destinationPath"></param>
		/// <param name="recurse"></param>
		/// <remarks>created by Mark (daviesma@qca.org.uk)</remarks>
		public static void CopyDirectory(string sourcePath, string destinationPath, bool recurse)
		{
			String[] files;
			if (destinationPath[destinationPath.Length-1] != Path.DirectorySeparatorChar)
				destinationPath+=Path.DirectorySeparatorChar;
			if(!Directory.Exists(destinationPath)) Directory.CreateDirectory(destinationPath);
			files = Directory.GetFileSystemEntries (sourcePath);
			foreach(string element in files)
			{
				if (recurse)
				{
					// copy sub directories (recursively)
					if(Directory.Exists(element))
						CopyDirectory(element,destinationPath+Path.GetFileName(element), recurse);
						// copy files in directory
					else
						File.Copy(element,destinationPath+Path.GetFileName(element),true);
				}
				else
				{
					// only copy files in directory
					if(!Directory.Exists(element))
						File.Copy(element,destinationPath+Path.GetFileName(element),true);
				}
			}
		} 

		/// <summary>
		/// Returns the Language Code that matches the current Culture best
		/// </summary>
		/// <returns>The language Code</returns>
		public static Data.MetaData.Languages GetMatchingLanguage()
		{
			Data.MetaData.Languages lng = Data.MetaData.Languages.English;

			string s = System.Threading.Thread.CurrentThread.CurrentCulture.ThreeLetterISOLanguageName.ToUpper();
			switch (s) 
			{
				case "DEU": return Data.MetaData.Languages.German;
				case "ESP": return Data.MetaData.Languages.Spanish;
				case "FIN": return Data.MetaData.Languages.Finnish;
				case "CHS": return Data.MetaData.Languages.SimplifiedChinese;
				case "CHT": return Data.MetaData.Languages.TraditionalChinese;
				case "FRE": return Data.MetaData.Languages.French;
				case "JPN": return Data.MetaData.Languages.Japanese;
				case "ITA": return Data.MetaData.Languages.Italian;
				case "DUT": return Data.MetaData.Languages.Dutch;
				case "DAN": return Data.MetaData.Languages.Danish;
				case "NOR": return Data.MetaData.Languages.Norwegian;
				case "HEB": return Data.MetaData.Languages.Hebrew;
				case "RUS": return Data.MetaData.Languages.Russian;
				case "POR": return Data.MetaData.Languages.Portuguese;
				case "POL": return Data.MetaData.Languages.Polish;
				case "THA": return Data.MetaData.Languages.Thai;
				case "KOR": return Data.MetaData.Languages.Korean;
			}

			return lng;
		}
		/// <summary>
		/// Creates a HexList from teh Byte Array
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string  BytesToHexList(byte[] data) 
		{
			return BytesToHexList(data, -1);
		}


		/// <summary>
		/// Creates a HexList from teh Byte Array
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public static string  BytesToHexList(byte[] data, int dwordperrow) 
		{
			if (dwordperrow>0) dwordperrow++;
			string s = "";
			int dwords = 0;
			for (int i=0; i<data.Length; i++) 
			{
				byte b = data[i];
				s += HexString(b)+" ";
				if (i % 4 == 3) 
				{
					s += " ";
					dwords++;
				}
				if (dwordperrow>0)
					if (dwords%dwordperrow == dwordperrow-1) 	
					{		
						dwords = 0;
						s += Helper.lbr;
					}
					
			}
			return s.Trim();
		}

		/// <summary>
		/// Converts a string like "AF 23 12 B3" to a Byte Array
		/// </summary>
		/// <param name="hexlist"></param>
		/// <returns>The Byte Array</returns>
		public static byte[] HexListToBytes(string hexlist) 
		{
			while (hexlist.IndexOf("  ")!=-1) hexlist = hexlist.Replace("  ", " ");

			string[] tokens = hexlist.Split(" ".ToCharArray());
			byte[] data = new byte[tokens.Length];

			for(int i=0; i<tokens.Length; i++)
			{
				if (tokens[i].Trim()!="")
					data[i] = Convert.ToByte(tokens[i], 16);
				else
					data[i] = 0;
			}
			return data;
		}

		/// <summary>
		/// Changes the Length of the ByteArray
		/// </summary>
		/// <param name="array"></param>
		/// <param name="len"></param>
		/// <returns></returns>
		public static byte[] SetLength(byte[] array, int len) 
		{
			if (array.Length == len) return array;

			byte[] ret = new byte[len];
			for(int i=0; i<Math.Min(array.Length, ret.Length); i++)
			{
				ret[i] = array[i];
			}

			return ret;
		}

		/// <summary>
		/// Extends the given arry by one item
		/// </summary>
		/// <param name="source">The Sourec Array</param>
		/// <param name="item">The new Item</param>
		/// <param name="elementType">Type of the Array Elements</param>
		/// <returns>The extended Array</returns>
		public static Array Add(Array source, object item, System.Type elementType) 
		{
			
			Array a = Array.CreateInstance(elementType, source.Length+1);
			source.CopyTo(a, 0);
			a.SetValue(item, a.Length-1);
			return a;
		}

		/// <summary>
		/// Extends the given arry by one item
		/// </summary>
		/// <param name="source">The Sourec Array</param>
		/// <param name="item">The new Item</param>
		/// <returns>The extended Array</returns>
		public static Array Add(Array source, object item) 
		{
			
			return Add(source, item, item.GetType());
		}

		/// <summary>
		/// Deletes the given Item from the Object (if it exists!)
		/// </summary>
		/// <param name="source">The Sourec Array</param>
		/// <param name="item">The Item delete</param>
		/// <param name="elementType">Type of the Array Elements</param>
		/// <returns>The Source Array without any Element that Equals item</returns>
		public static Array Delete(Array source, object item, System.Type elementType) 
		{
			System.Collections.ArrayList a = new System.Collections.ArrayList();
			foreach (object i in source) 
			{
				if (i==null) 
				{
					if (item==null)
						a.Add(i);
				}
				else if (!i.Equals(item)) a.Add(i);
			}

			Array ar = Array.CreateInstance(elementType, a.Count);
			a.CopyTo(ar);
			return ar;
		}

		/// <summary>
		/// Deletes the given Item from the Object (if it exists!)
		/// </summary>
		/// <param name="source">The Sourec Array</param>
		/// <param name="item">The Item delete</param>
		/// <returns>The Source Array without any Element that Equals item</returns>
		public static Array Delete(Array source, object item) 
		{
			return Delete(source, item, item.GetType());
		}

		/// <summary>
		/// Deletes the given Item from the Object (if it exists!)
		/// </summary>
		/// <param name="source">The Sourec Array</param>
		/// <param name="item">The Item delete</param>
		/// <param name="elementType">Type of the Array Elements</param>
		/// <returns>The Source Array without any Element that Equals item</returns>
		public static Array Merge(Array source1, Array source2, System.Type elementType) 
		{
			Array a = Array.CreateInstance(elementType, source1.Length + source2.Length);
			source1.CopyTo(a, 0);
			source2.CopyTo(a, source1.Length);
			return a;
		}

		/// <summary>
		/// Creates a Short Value from the given bytes
		/// </summary>
		/// <param name="low">Lower Byte</param>
		/// <param name="high">Higher Byte</param>
		/// <returns>Short Walue</returns>
		public static short ToShort(byte low, byte high)
		{
			return (short)(low + (high << 8));
		}

		/// <summary>
		/// Retursn the lower and Higher Byte Value of a Short Type
		/// </summary>
		/// <param name="val">The Short value</param>
		/// <returns>Byte arra, index 0 contains the lower byte </returns>
		public static byte[] ToByte(short val) 
		{
			byte[] ret = new byte[2];
			ret[1] = (byte)(val & 0xff);
			ret[2] = (byte)((val >> 8) & 0xff);
			return ret;
		}

		/// <summary>
		/// Creates a Integer Value from the given shorts
		/// </summary>
		/// <param name="low">Lower Short</param>
		/// <param name="high">Higher Short</param>
		/// <returns>Integer Walue</returns>
		public static int ToInt(short low, short high)
		{
			return (int)(low + (high << 16));
		}

		/// <summary>
		/// Retursn the lower and Higher Short Value of a Integer Type
		/// </summary>
		/// <param name="val">The Short value</param>
		/// <returns>Byte arra, index 0 contains the lower byte </returns>
		public static short[] Toshort(int val) 
		{
			short[] ret = new short[2];
			ret[1] = (short)(val & 0xffff);
			ret[2] = (short)((val >> 16) & 0xffff);
			return ret;
		}

		/// <summary>
		/// Returns true, if the Helper dll was compiled with the DEBUG Flag
		/// </summary>
		public static bool DebugMode
		{
			get 
			{
#if DEBUG
				return true;
#else
				return false;
#endif
			}
		}

		/// <summary>
		/// Returns filename of the Main Neighborhood
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		public static string GetMainNeighborhoodFile(string filename) 
		{
			if (filename==null) return "";
			string flname = System.IO.Path.GetFileName(filename);
			flname = flname.Trim().ToLower();

			if (flname.EndsWith("neighborhood.package")) return filename;	
			flname = System.IO.Path.GetFileNameWithoutExtension(flname);
			string[] parts = flname.Split(new char[] {'_'}, 2);
			if (parts.Length==0) return filename;
			return System.IO.Path.Combine(System.IO.Path.GetDirectoryName(filename), parts[0]+"_Neighborhood.package");
		}

		
		/// <summary>
		/// Returns true if this is a Neighborhood File
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		public static bool IsNeighborhoodFile(string filename) 
		{
			if (filename==null) return false;
			filename = System.IO.Path.GetFileName(filename);
			filename = filename.Trim().ToLower();

			if (filename.EndsWith("neighborhood.package")) return true;
			if ((filename.IndexOf("_university")!=-1) && filename.EndsWith(".package") && filename.StartsWith("n")) return true;
			if ((filename.IndexOf("_downtown")!=-1) && filename.EndsWith(".package") && filename.StartsWith("n")) return true;
			if ((filename.IndexOf("_suburb")!=-1) && filename.EndsWith(".package") && filename.StartsWith("n")) return true;

			return false;
		}

		/// <summary>
		/// Returns either the Game Path or the installation Path of the EP if found
		/// </summary>
		/// <returns></returns>
		public static string NewestGamePath
		{
			get 
			{
                return PathProvider.Global.Latest.InstallFolder;
			}
		}

		static SimPe.TGILoader tgiload;
		/// <summary>
		/// Retrns the TGI Loader Class
		/// </summary>
		public static SimPe.TGILoader TGILoader 
		{
			get 
			{
				if (tgiload==null) tgiload = new TGILoader();
				return tgiload;
			}
		}

		/// <summary>
		/// Returns a Save FileName
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		public static string SaveFileName(string flname)
		{
			if (flname==null) flname="";
			flname = flname.Replace("\\", "_");
			flname = flname.Replace("/", "_");
			flname = flname.Replace(":", "_");			
			return flname;
		}

		/// <summary>
		/// Compares tow Filenames, or parts of FileNames
		/// </summary>
		/// <param name="fl1"></param>
		/// <param name="fl2"></param>
		/// <returns></returns>
		public static bool EqualFileName(string fl1, string fl2)
		{
#if MAC
			return fl1.Trim()==fl2.Trim();
#else
			return fl1.Trim().ToLower()==fl2.Trim().ToLower();
#endif
		}

        public static bool IsAbsolutePath(string path)
        {
            if (path == null) return false;
            path = path.Trim();
#if MAC
            if (path.IndexOf("/") == 0) return true;
#else
			if (path.IndexOf(":")==1) return true;
#endif
            return false;
        }

		/// <summary>
		/// Returns a compareable Filename
		/// </summary>
		/// <param name="fl"></param>
		/// <returns></returns>
		public static string CompareableFileName(string fl)
		{
#if MAC
			return fl.Trim();
#else
			return fl.Trim().ToLower();
#endif
		}

		#region Folders
#if MAC
		public static string ToLongPathName(string shortName)
		{
			return shortName;
		}
		
#else
		
		[DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
		static extern uint GetLongPathName(
			string lpszShortPath,
			[Out] System.Text.StringBuilder lpszLongPath,
			uint cchBuffer);

		/// <summary>
		/// The ToShortPathNameToLongPathName function retrieves the long path form of a specified short input path
		/// </summary>
		/// <param name="shortName">The short name path</param>
		/// <returns>A long name path string</returns>
		public static string ToLongPathName(string shortName)
		{
			StringBuilder longNameBuffer = new StringBuilder(256);
			uint bufferSize = (uint)longNameBuffer.Capacity;

			GetLongPathName(shortName, longNameBuffer, bufferSize);

			return longNameBuffer.ToString();
		}
#endif

		public static string ToLongFileName(string shortName)
		{			
			return System.IO.Path.Combine(
				ToLongPathName(System.IO.Path.GetDirectoryName(shortName)),
				System.IO.Path.GetFileName(shortName));
		}

		#endregion

        public static System.Windows.Forms.Keys ToKeys(System.Windows.Forms.Shortcut sc)
        {
            System.Windows.Forms.Keys ret = System.Windows.Forms.Keys.None;
            string name = sc.ToString().ToLower();

            if (name == "none") return ret;

            SetKey(ref ret, ref name, "ctrl", System.Windows.Forms.Keys.Control);
            SetKey(ref ret, ref name, "shift", System.Windows.Forms.Keys.Shift);
            SetKey(ref ret, ref name, "alt", System.Windows.Forms.Keys.Alt);
            SetKey(ref ret, ref name, "ins", System.Windows.Forms.Keys.Insert);
            SetKey(ref ret, ref name, "del", System.Windows.Forms.Keys.Delete);
            SetKey(ref ret, ref name, "bksp", System.Windows.Forms.Keys.Back);

            if (SetKey(ref ret, ref name, "uparrow", System.Windows.Forms.Keys.Up)) return ret;
            if (SetKey(ref ret, ref name, "downarrow", System.Windows.Forms.Keys.Down)) return ret;
            if (SetKey(ref ret, ref name, "leftarrow", System.Windows.Forms.Keys.Left)) return ret;
            if (SetKey(ref ret, ref name, "rightarrow", System.Windows.Forms.Keys.Right)) return ret;

            if (SetKey(ref ret, ref name, "f1", System.Windows.Forms.Keys.F1)) return ret;
            if (SetKey(ref ret, ref name, "f2", System.Windows.Forms.Keys.F2)) return ret;
            if (SetKey(ref ret, ref name, "f3", System.Windows.Forms.Keys.F3)) return ret;
            if (SetKey(ref ret, ref name, "f4", System.Windows.Forms.Keys.F4)) return ret;
            if (SetKey(ref ret, ref name, "f5", System.Windows.Forms.Keys.F5)) return ret;
            if (SetKey(ref ret, ref name, "f6", System.Windows.Forms.Keys.F6)) return ret;
            if (SetKey(ref ret, ref name, "f7", System.Windows.Forms.Keys.F7)) return ret;
            if (SetKey(ref ret, ref name, "f8", System.Windows.Forms.Keys.F8)) return ret;
            if (SetKey(ref ret, ref name, "f9", System.Windows.Forms.Keys.F9)) return ret;
            if (SetKey(ref ret, ref name, "f10", System.Windows.Forms.Keys.F10)) return ret;
            if (SetKey(ref ret, ref name, "f11", System.Windows.Forms.Keys.F11)) return ret;
            if (SetKey(ref ret, ref name, "f11", System.Windows.Forms.Keys.F12)) return ret;

            if (SetKey(ref ret, ref name, "1", System.Windows.Forms.Keys.D1)) return ret;
            if (SetKey(ref ret, ref name, "2", System.Windows.Forms.Keys.D2)) return ret;
            if (SetKey(ref ret, ref name, "3", System.Windows.Forms.Keys.D3)) return ret; 
            if (SetKey(ref ret, ref name, "4", System.Windows.Forms.Keys.D4)) return ret;
            if (SetKey(ref ret, ref name, "5", System.Windows.Forms.Keys.D5)) return ret;
            if (SetKey(ref ret, ref name, "6", System.Windows.Forms.Keys.D6)) return ret;
            if (SetKey(ref ret, ref name, "7", System.Windows.Forms.Keys.D7)) return ret;
            if (SetKey(ref ret, ref name, "8", System.Windows.Forms.Keys.D8)) return ret;
            if (SetKey(ref ret, ref name, "9", System.Windows.Forms.Keys.D9)) return ret;
            if (SetKey(ref ret, ref name, "0", System.Windows.Forms.Keys.D0)) return ret;

            if (SetKey(ref ret, ref name, "a", System.Windows.Forms.Keys.A)) return ret;
            if (SetKey(ref ret, ref name, "b", System.Windows.Forms.Keys.B)) return ret;
            if (SetKey(ref ret, ref name, "c", System.Windows.Forms.Keys.C)) return ret;
            if (SetKey(ref ret, ref name, "d", System.Windows.Forms.Keys.D)) return ret;
            if (SetKey(ref ret, ref name, "e", System.Windows.Forms.Keys.E)) return ret;
            if (SetKey(ref ret, ref name, "f", System.Windows.Forms.Keys.F)) return ret;
            if (SetKey(ref ret, ref name, "g", System.Windows.Forms.Keys.G)) return ret;
            if (SetKey(ref ret, ref name, "h", System.Windows.Forms.Keys.H)) return ret;
            if (SetKey(ref ret, ref name, "i", System.Windows.Forms.Keys.I)) return ret;
            if (SetKey(ref ret, ref name, "j", System.Windows.Forms.Keys.J)) return ret;
            if (SetKey(ref ret, ref name, "k", System.Windows.Forms.Keys.K)) return ret;
            if (SetKey(ref ret, ref name, "l", System.Windows.Forms.Keys.L)) return ret;
            if (SetKey(ref ret, ref name, "m", System.Windows.Forms.Keys.M)) return ret;
            if (SetKey(ref ret, ref name, "n", System.Windows.Forms.Keys.N)) return ret;
            if (SetKey(ref ret, ref name, "o", System.Windows.Forms.Keys.O)) return ret;
            if (SetKey(ref ret, ref name, "p", System.Windows.Forms.Keys.P)) return ret;
            if (SetKey(ref ret, ref name, "q", System.Windows.Forms.Keys.Q)) return ret;
            if (SetKey(ref ret, ref name, "r", System.Windows.Forms.Keys.R)) return ret;
            if (SetKey(ref ret, ref name, "s", System.Windows.Forms.Keys.S)) return ret;
            if (SetKey(ref ret, ref name, "t", System.Windows.Forms.Keys.T)) return ret;
            if (SetKey(ref ret, ref name, "u", System.Windows.Forms.Keys.U)) return ret;
            if (SetKey(ref ret, ref name, "v", System.Windows.Forms.Keys.V)) return ret;
            if (SetKey(ref ret, ref name, "w", System.Windows.Forms.Keys.W)) return ret;
            if (SetKey(ref ret, ref name, "x", System.Windows.Forms.Keys.X)) return ret;
            if (SetKey(ref ret, ref name, "y", System.Windows.Forms.Keys.Y)) return ret; 
            if (SetKey(ref ret, ref name, "z", System.Windows.Forms.Keys.Z)) return ret;
            return ret;
        }

        private static bool SetKey(ref System.Windows.Forms.Keys ret, ref string name, string capt, System.Windows.Forms.Keys key)
        {
            if (name.IndexOf(capt) >= 0)
            {
                name = name.Replace(capt, "");
                ret |= key;

                //System.Diagnostics.Debug.WriteLine(name+": "+ret);
                return true;
            }

            return false;
        }
	}
}
