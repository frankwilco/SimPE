using System;
using System.Collections;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using System.Drawing;
using SimPe.Data;
using System.Text;


namespace SimPe.Plugin.Helper
{
	/// <summary>
	/// The dump for all functions that didn't found
	/// any place to stay.
	/// </summary>
	public sealed class Utility
	{

		public static bool IsNullOrEmpty(ICollection @value)
		{
			return (@value == null || @value.Count == 0);
		}

		/// <summary>
		/// Directly from the pre-dotNET 2.0 era.
		/// Please use String.IsNullOrEmpty(string) instead.
		/// </summary>
		public static bool IsNullOrEmpty(string @value)
		{
			return (@value == null || @value.Length == 0);
		}

		/// <summary>
		/// return ( value & Enum.A ) == Enum.A 
		/// </summary>
		/// <param name="compositeValue"></param>
		/// <param name="discreteValue"></param>
		/// <returns></returns>
		public static bool EnumTest(Enum compositeValue, Enum discreteValue)
		{
			uint c = Convert.ToUInt32(compositeValue);
			uint d = Convert.ToUInt32(discreteValue);
			if (d == 0)
				return (c == 0);
			return (c & d) == d;
		}


		/// <remarks>
		/// I'm lazy :P
		/// </remarks>
		public static Guid ParseGuid(CpfItem item)
		{
			Guid ret = Guid.Empty;
			if (item != null)
				ret = ParseGuid(item.StringValue);
			return ret;
		}

		public static Guid ParseGuid(string guidString)
		{
			if (guidString != null)
			{
				try
				{
					if (!Utility.IsNullOrEmpty(guidString))
						return new Guid(guidString);
				}
				catch
				{
				}
			}
			return Guid.Empty;
		}


		/// <summary>
		/// Contains common resource types.
		/// Some duplicated from SimPe.Data.MetaData class.
		/// </summary>
		public class DataType
		{
			DataType() {
			}
			
			/// <summary>
			/// Property Set, 0xEBCF3E27
			/// </summary>
			public const uint GZPS = 0xEBCF3E27u;

			/// <summary>
			/// Hair Tone XML, 0x8C1580B5
			/// </summary>
			public const uint XHTN = 0x8C1580B5u;

			/// <summary>
			/// Texture Overlay XML, 0x2C1FD8A1
			/// </summary>
			public const uint XTOL = 0x2C1FD8A1u;

			/// <summary>
			/// Mesh Overlay XML, 0x0C1FE246
			/// </summary>
			public const uint XMOL = 0x0C1FE246u;

			/// <summary>
			/// Skin Tone XML, 0x4C158081
			/// </summary>
			public const uint XSTN = 0x4C158081u;

			/// <summary>
			/// Age Data, 0xAC598EAC
			/// </summary>
			public const uint AGED = 0xAC598EACu;

			/// <summary>
			/// Facial Data, 0xCCCEF852
			/// </summary>
			public const uint LxNR = 0xCCCEF852u;

			/// <summary>
			/// JPEG/TGA/PNG Image, 0x856DDBAC
			/// </summary>
			public const uint IMG = 0x856DDBACu;

			/// <summary>
			/// Compressed File Directory, 0xE86B1EEF
			/// </summary>
			public const uint CLST = 0xE86B1EEFu;

			/// <summary>
			/// Slot File, 0x534C4F54
			/// </summary>
			public const uint SLOT = 0x534C4F54u;

			/// <summary>
			/// Material Definition, 0x49596978
			/// </summary>
			public const uint TXMT = 0x49596978u;

			/// <summary>
			/// Texture Image, 0x1C4A276C
			/// </summary>
			public const uint TXTR = 0x1C4A276Cu;

			/// <summary>
			/// Binary Index, 0x0C560F39
			/// </summary>
			public const uint BINX = 0x0C560F39u;

			/// <summary>
			/// Geometric Data Container, 0xAC4F8687
			/// </summary>
			public const uint GMDC = 0xAC4F8687u;

			/// <summary>
			/// Geometric Node, 0x7BA3838C
			/// </summary>
			public const uint GMND = 0x7BA3838Cu;

			/// <summary>
			/// Shape, 0xFC6EB1F7
			/// </summary>
			public const uint SHPE = 0xFC6EB1F7u;

			/// <summary>
			/// Resource Node, 0xE519C933
			/// </summary>
			public const uint CRES = 0xE519C933u;

			/// <summary>
			/// Sim DNA, 0xEBFEE33F
			/// </summary>
			public const uint SDNA = 0xEBFEE33Fu;

			/// <summary>
			/// Material Override, 0x4C697E5A
			/// </summary>
			public const uint MMAT = 0x4C697E5Au;

		}


		public static bool CompareDescriptor(IPackedFileDescriptor x, IPackedFileDescriptor y)
		{
			if (x == null)
				return (y == null);

			return (
				x.Type == y.Type &&
				x.Group == y.Group &&
				x.LongInstance == y.LongInstance
				);
		}

	}



}
