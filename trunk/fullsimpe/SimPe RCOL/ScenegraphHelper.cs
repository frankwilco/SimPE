using System;

namespace SimPe.Plugin
{	
	/// <summary>
	/// Some Helper Methods for the Scenegraph Files
	/// </summary>
	public class ScenegraphHelper
	{
		#region Constant Repeat
		public const uint GMND = Data.MetaData.GMND;
		public const uint TXMT = Data.MetaData.TXMT;
		public const uint TXTR = Data.MetaData.TXTR;
		public const uint LIFO = Data.MetaData.LIFO;
		public const uint ANIM = Data.MetaData.ANIM;
		public const uint SHPE = Data.MetaData.SHPE;
		public const uint CRES = Data.MetaData.CRES;
		public const uint GMDC = Data.MetaData.GMDC;

		public const uint MMAT = Data.MetaData.MMAT;

		public static string GMND_PACKAGE = Data.MetaData.GMND_PACKAGE;
		public static string MMAT_PACKAGE = Data.MetaData.MMAT_PACKAGE;		
		#endregion
		
		/// <summary>
		/// Returns a PackedFile Descriptor for the given filename
		/// </summary>
		/// <param name="flname"></param>
		/// <param name="type"></param>
		/// <param name="defgroup"></param>
		/// <returns></returns>
		public static Interfaces.Files.IPackedFileDescriptor BuildPfd(string flname, uint type, uint defgroup)
		{
			string name = Hashes.StripHashFromName(flname);
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Type = type;
			pfd.Group = Hashes.GetHashGroupFromName(flname, defgroup);
			pfd.Instance = Hashes.InstanceHash(name);
			pfd.SubType = Hashes.SubTypeHash(name);
			pfd.Filename = flname;

			pfd.UserData = new byte[0];

			return pfd;
		}
	}
}
