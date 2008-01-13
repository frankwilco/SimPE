using System;
using System.Collections;
using System.Globalization;

using SimPe.Interfaces.Files;


namespace SimPe.Plugin
{
	/// <summary>
	/// Helper class
	/// </summary>
	public sealed class ResourceReference
	{
		IPackedFileDescriptor pfd;
		public uint Type;
		public uint Group;
		public uint Instance;
		public uint SubType;

		public IPackedFileDescriptor FileDescriptor
		{
			get { return this.pfd; }
		}

		public ResourceReference(IPackedFileDescriptor file)
		{
			this.Type = file.Type;
			this.Group = file.Group;
			this.Instance = file.Instance;
			this.SubType = file.SubType;
			this.pfd = file;
		}

		public override bool Equals(object obj)
		{
			if (obj is ResourceReference)
			{
				ResourceReference sr = (ResourceReference)obj;
				return this.GetHashCode() == sr.GetHashCode();
			}
			return false;
		}

		public override int GetHashCode()
		{
			return BitConverter.ToInt32(
				BitConverter.GetBytes(
					this.Type ^
					this.Group ^
					this.SubType ^
					this.Instance),
				0
				);
		}


		public override string ToString()
		{
			return String.Format("{0:X8}-{1:X8}-{2:X8}-{3:X8}", this.Type, this.Group, this.SubType, this.Instance);
		}

		public static uint GetHash(IPackedFileDescriptor pfd)
		{
			return 
				pfd.Type ^
				pfd.Group ^
				pfd.SubType ^
				pfd.Instance;
		}

		public static ResourceReference Parse(string s)
		{
			ResourceReference ret = null;
			if (!Utility.IsNullOrEmpty(s))
			{
				string[] parts = s.Split('-');
				if (parts.Length != 4)
					throw new FormatException("The specified string was not in the correct format for a ResourceReference");

				NumberStyles format = NumberStyles.AllowHexSpecifier | NumberStyles.HexNumber;
				ret.Type = uint.Parse(parts[0], format);
				ret.Group = uint.Parse(parts[1], format);
				ret.SubType = uint.Parse(parts[2], format);
				ret.Instance = uint.Parse(parts[3], format);
			}
			return ret;
		}


	}

}
