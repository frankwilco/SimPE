using System;

namespace ReleaseCreator
{
	/// <summary>
	/// Zusammenfassung für FileDescriptor.
	/// </summary>
	public class FileDescriptor
	{
		string flname;
		string bp;
		public string FileName 
		{
			get {return flname.Replace(bp, ""); }
		}

		System.Diagnostics.FileVersionInfo ver;
		public System.Diagnostics.FileVersionInfo Version
		{
			get {return ver; }
		}

		
		long size;
		public long Size
		{
			get {return size;}
		}

		bool exists;
		public bool Exists
		{
			get {return exists; }
		}

		public FileDescriptor(string basepath, string filename)
		{
			this.flname = filename.Trim().ToLower();
			this.bp = basepath.Trim().ToLower();;
			if (!bp.EndsWith(@"\")) bp += @"\";
			exists = false;
			LoadInfo();
		}

		void LoadInfo()
		{
			if (!System.IO.File.Exists(flname)) return;
			exists = true;

			System.IO.Stream s = System.IO.File.OpenRead(flname);
			size = s.Length;
			s.Close();

			ver = System.Diagnostics.FileVersionInfo.GetVersionInfo(flname);
		}

		public override string ToString()
		{
			string res = "\t<file name=\""+FileName+"\">"+SimPe.Helper.lbr;
			res += "\t\t<version>"+SimPe.Helper.VersionToLong(Version)+"</version>"+SimPe.Helper.lbr;
			res += "\t\t<size>"+Size.ToString()+"</size>"+SimPe.Helper.lbr;
			res += "\t</file>"+SimPe.Helper.lbr+SimPe.Helper.lbr;
			return res;
		}

	}
}
