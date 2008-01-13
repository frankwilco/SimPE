using System;
using System.Collections;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for Utility.
	/// </summary>
	public sealed class Utility
	{
		private Utility()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public static bool IsNullOrEmpty(ICollection @value)
		{
			return (@value == null || @value.Count == 0);
		}

		public static bool IsNullOrEmpty(string @value)
		{
			return (@value == null || @value.Length == 0);
		}

		public static bool EnumTest(Enum compositeValue, Enum discreteValue)
		{
			uint c = Convert.ToUInt32(compositeValue);
			uint d = Convert.ToUInt32(discreteValue);
			if (d == 0) return (c == 0);
			return (c & d) == d;
		}

		/// <summary>
		/// Finds file descriptors of a given type, group or instance in a given package.
		/// </summary>
		/// <param name="package"></param>
		/// <param name="type">Required type id of the resource to find</param>
		/// <param name="group">Optional group id (optional=0)</param>
		/// <param name="instance">Optional instance id (optional=0)</param>
		/// <returns></returns>
		public static IPackedFileDescriptor[] FindFiles(IPackageFile package, uint type, uint group, uint instance)
		{
			ArrayList ret = new ArrayList();
			IPackedFileDescriptor[] files = package.FindFiles(type);
			foreach (IPackedFileDescriptor file in files)
			{
				switch (group)
				{
					case 0: break;
					default: if (group != file.Group) continue; break;
				}

				switch (instance)
				{
					case 0: break;
					default: if (instance != file.Instance) continue; break;
				}

				ret.Add(file);
			}

			return (IPackedFileDescriptor[])ret.ToArray(typeof(IPackedFileDescriptor));
		}

		public sealed class DataType
		{
			public const uint XHTN = 0x8C1580B5u;
			public const uint XTOL = 0x2C1FD8A1u;
			public const uint XMOL = 0x0C1FE246u;
			public const uint XSTN = 0x4C158081u;
		}

		public sealed class HairtoneGuid
		{
			public static readonly Guid Black = new Guid(1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
			public static readonly Guid Brown = new Guid(2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
			public static readonly Guid Blond = new Guid(3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
			public static readonly Guid Red   = new Guid(4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
			public static readonly Guid Grey  = new Guid(5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}

	}



}
