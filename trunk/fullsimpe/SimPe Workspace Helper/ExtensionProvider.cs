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

namespace SimPe
{
	/// <summary>
	/// Which ExtensionType dou you want to have
	/// </summary>
	public enum ExtensionType : short 
	{
		Package = 0x01,
		DisabledPackage = 0x02,
		ExtractedFile = 0x04,
		ExtractedFileDescriptor = 0x08,
		ExtrackedPackageDescriptor = 0x10,
		Sim2Pack = 0x20,
		Sim2PackCommunity = 0x40,
		AllFiles = 0x80
	}

	/// <summary>
	/// Describes one Extension
	/// </summary>
	public class ExtensionDescriptor 
	{
		/// <summary>
		/// Create an Instance
		/// </summary>
		/// <param name="name">Description</param>
		/// <param name="ext">; seperated List of Extensions (like *.bmp;*.gif;*.tmp)</param>
		internal ExtensionDescriptor(string name, string ext)
		{
			extensions = new ArrayList();
			string[] p = ext.Split(";".ToCharArray());

			foreach (string s in p) if (s.Trim()!="") extensions.Add(s.Trim());
			this.text = SimPe.Localization.GetString(name);
		}

		/// <summary>
		/// Create an Instance
		/// </summary>
		internal ExtensionDescriptor(string name, ArrayList ext)
		{
			this.extensions = ext;
			this.text = SimPe.Localization.GetString(name);
		}

		ArrayList extensions;
		/// <summary>
		/// Returns a List of allowed Extensions for this Type (like *.bmp, *.gif, *.jpg)
		/// </summary>
		public ArrayList Extensions 
		{
			get { return extensions; }
		}

		string text;
		/// <summary>
		/// Returns the Name of this Extension
		/// </summary>
		public string Text
		{
			get { return text; }
		}

		/// <summary>
		/// Returns the ExtensionList as string
		/// </summary>
		/// <returns></returns>
		public string GetExtensionList()
		{
			string res = "";
			for (int i=0;i<extensions.Count; i++)
			{
				if (i!=0) res += ";";
				res += extensions[i];
			}

			return res;
		}

		/// <summary>
		/// Returens a string that can be used as a Filter in an open/save Dialog
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return text+" ("+GetExtensionList()+")|"+GetExtensionList();
		}

		/// <summary>
		/// true, fi the passed File has one of the allowe dExtensions
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public bool AllowedExtension(string filename) 
		{
#if MAC
			filename = filename.Trim();
#else
			filename = filename.Trim().ToLower();
#endif
			for (int i=0;i<extensions.Count; i++)
				if (filename.EndsWith(extensions[i].ToString().Replace("*", ""))) return true;			

			return false;
		}
	}

	/// <summary>
	/// Used to get some Default Extensions
	/// </summary>
	public class ExtensionProvider
	{
		static Hashtable map;
		/// <summary>
		/// Creates the Extension Map
		/// </summary>
		static void BuildMap()
		{
			map = new Hashtable();
			map.Add(ExtensionType.Package, new ExtensionDescriptor("DBPF Package", "*.package;*.cache;*.template"));
			map.Add(ExtensionType.DisabledPackage, new ExtensionDescriptor("Disabled DBPF Package", "*.packagedisabled;*.simpedis"));
			map.Add(ExtensionType.ExtractedFile, new ExtensionDescriptor("Extracted File", GetExtractExtensions("")));
			map.Add(ExtensionType.ExtractedFileDescriptor, new ExtensionDescriptor("Extracted File Descriptor", GetExtractExtensions(".xml")));
			map.Add(ExtensionType.ExtrackedPackageDescriptor, new ExtensionDescriptor("Extracted Package", "package.xml"));
			map.Add(ExtensionType.Sim2Pack, new ExtensionDescriptor("Packed Objects", "*.sims2pack"));
			map.Add(ExtensionType.Sim2PackCommunity, new ExtensionDescriptor("Sims 2 Community Package", "*.s2cp"));
			map.Add(ExtensionType.AllFiles, new ExtensionDescriptor("All Files", "*.*"));
		}

		/// <summary>
		/// Returns a list of all extractable Extensions
		/// </summary>
		/// <returns></returns>
		static ArrayList GetExtractExtensions(string suffix)
		{
			ArrayList exts = new ArrayList();
			exts.Add("*.simpe"+suffix);

			SimPe.Data.TypeAlias[] types = Helper.TGILoader.FileTypes;
			foreach (SimPe.Data.TypeAlias type in types) 
			{
				string ext = type.Extension.Trim().ToLower();
				if (ext=="") continue;
				ext = "*."+ext+suffix;
				if (!exts.Contains(ext)) exts.Add(ext);
			}

			return exts;
		}

		/// <summary>
		/// Returns a List of known Extensions (key=ExtensionType, value =ExtensionDescriptor) 
		/// </summary>
		public static Hashtable ExtensionMap 
		{
			get 
			{
				if (map==null) BuildMap();
				return map;
			}
		}

		/// <summary>
		/// Returns the descriptor for a given Type (returns a default Extension when the type was not found)
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static ExtensionDescriptor GetExtension(ExtensionType type) 
		{
			ExtensionDescriptor res = (ExtensionDescriptor)ExtensionMap[type];
			if (res==null) res = new ExtensionDescriptor("Unknown Type", "*.*");
			return res;
		}	
	
		/// <summary>
		/// returns the Filter String that provides the passed Types
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static string BuildFilterString(ExtensionType[] types)
		{
			string s = "";
			for (int i=0; i<types.Length; i++) 
			{
				if (i!=0) s+="|";
				s += GetExtension(types[i]).ToString();
			}

			return s;
		}

		/// <summary>
		/// Returns the Type of the passed File
		/// </summary>
		/// <param name="filename">The Filename you want to test</param>
		/// <returns></returns>
		public static ExtensionType GetExtension(string filename)
		{
			foreach (ExtensionType et in ExtensionMap.Keys) 
			{
				ExtensionDescriptor ed = (ExtensionDescriptor)ExtensionMap[et];
				if (ed.AllowedExtension(filename)) return et;
			}

			return ExtensionType.AllFiles;
		}
	}
}
