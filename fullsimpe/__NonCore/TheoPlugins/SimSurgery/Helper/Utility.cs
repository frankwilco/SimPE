using System;
using System.Collections;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using System.Drawing;
using System.Collections.Generic;
using SimPe.Plugin.Properties;
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
		[Obsolete("Please use String.IsNullOrEmpty(string) instead.", false)]
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



		/// <summary>
		/// Evicted from the PlasticSurgery class.
		/// Waiting for a new home ;)
		/// </summary>
		/// <remarks>
		/// Used by the makeup and eyecolor cloning procedures.
		/// </remarks>
		public static string FindTxtrName(string name)
		{
			StringBuilder ret = new StringBuilder();
			IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(name, Utility.DataType.TXTR, MetaData.LOCAL_GROUP, true);
			if (item != null)
			{
				Rcol txtr = new GenericRcol(null, false);
				txtr.ProcessData(item);
				ret.Append(txtr.FileName.Trim());
				if (txtr.FileName.EndsWith("_txtr", StringComparison.InvariantCultureIgnoreCase))
					ret.Remove(txtr.FileName.Length - 5, 5);

				if (txtr.FileName.StartsWith("#"))
					ret.Insert(0, "_");
			}
			ret.Replace("-", "_");
			return ret.ToString();
		}

		#region Check Sim Template Package
		/// <summary>
		/// Contains a list of mandatory resource types 
		/// that must be present in a sim template package.
		/// </summary>
		static readonly uint[] RequiredTemplateResourceType = new uint[] {
			MetaData.REF_FILE,			// 0xAC506764u, 3IDR
			Utility.DataType.AGED,		//0xAC598EACu, AGED
			Utility.DataType.GMDC
			//Data.MetaData.GZPS,		//GZPS, Property Set
			//0xCCCEF852u,					//LxNR, Face
			//0x856DDBACu,					//IMG
			//0x534C4F54u						//SLOT
		};

		/// <summary>
		/// Checks if an arbitrary package contains the file types required
		/// for archetype elegibility.
		/// </summary>
		/// <param name="archeFile"></param>
		/// <returns>True if the provided package can be a surgery archetype, otherwise false.</returns>
		public static bool CheckArchetypeFile(File archeFile)
		{
			bool ret = false;
			if (archeFile == null)
				return ret;

			// For now we disregard the user options, and consider
			// all the required types mandatory.
			for (
				int i = 0;

				i < RequiredTemplateResourceType.Length &&
				(ret = ContainsType(archeFile.Index, RequiredTemplateResourceType[i]));

				i++
				) ;

			return ret;
		}

		static bool ContainsType(IPackedFileDescriptor[] index, uint type)
		{
			for (int i = 0; i < index.Length; i++)
				if (index[i].Type == type)
					return true;
			return false;
		}

		#endregion

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
					if (!String.IsNullOrEmpty(guidString))
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
		public static class DataType
		{
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

		}

		/// <summary>
		/// This is cheating :P
		/// </summary>
		/// <remarks>
		/// The referenced resources were extracted from \TSData\Res\UI\CaSIEUI.data,
		/// but no direct reference to them was possible,
		/// hence the need for this magic table.
		/// The actual images should be contained in SwatchIcons.resx
		/// </remarks>
		internal static class BaseIconTable
		{
			static Dictionary<Guid, Image> eyeImages = BuildEyeIconTable();
			static Dictionary<Guid, Image> skinImages = BuildSkinIconTable();

			static Dictionary<Guid, Image> BuildEyeIconTable()
			{
				Dictionary<Guid, Image> ret = new Dictionary<Guid, Image>(8);
				ret.Add(new Guid("32dee745-b6ce-419f-9e86-ae93802d2682"), SwatchIcons.Eye_Brown);
				ret.Add(new Guid("2d6839c5-0b7c-48a1-9c55-4bd9cc873b0f"), SwatchIcons.Eye_DarkBlue);
				ret.Add(new Guid("51c4a750-c9f4-4cfe-801c-898efc360cb7"), SwatchIcons.Eye_Green);
				ret.Add(new Guid("e43f3360-3a08-4755-8b83-a0d37a6c424b"), SwatchIcons.Eye_LightBlue);
				ret.Add(new Guid("0758508c-7111-40f9-b33b-706464626ac9"), SwatchIcons.Eye_Gray);
				ret.Add(new Guid("12d4f3e1-fdbe-4fe7-ace3-46dd9ff52b51"), SwatchIcons.Eye_Alien);
				return ret;
			}

			static Dictionary<Guid, Image> BuildSkinIconTable()
			{
				Dictionary<Guid, Image> ret = new Dictionary<Guid, Image>(8);
				ret.Add(new Guid("00000001-0000-0000-0000-000000000000"), SwatchIcons.Skin_Light);
				ret.Add(new Guid("00000002-0000-0000-0000-000000000000"), SwatchIcons.Skin_Tan);
				ret.Add(new Guid("00000003-0000-0000-0000-000000000000"), SwatchIcons.Skin_Medium);
				ret.Add(new Guid("00000004-0000-0000-0000-000000000000"), SwatchIcons.Skin_Dark);
				ret.Add(new Guid("6baf064a-85ad-4e37-8d81-a987e9f8da46"), SwatchIcons.Skin_Alien);
				ret.Add(new Guid("b6ee1dbc-5bb3-4146-8315-02bd64eda707"), SwatchIcons.Skin_Zombie);
				ret.Add(new Guid("b9a94827-7544-450c-a8f4-6f643ae89a71"), SwatchIcons.Skin_Mannequin);
				ret.Add(new Guid("6eea47c7-8a35-4be7-9242-dcd082f53b55"), SwatchIcons.Skin_Mannequin);
				return ret;
			}

			public static Image GetEyeIcon(Guid familyGuid)
			{
				if (eyeImages.ContainsKey(familyGuid))
					return eyeImages[familyGuid];
				return null;
			}

			public static Image GetSkinIcon(Guid familyGuid)
			{
				if (skinImages.ContainsKey(familyGuid))
					return skinImages[familyGuid];
				return null;
			}

		}

	}



}
