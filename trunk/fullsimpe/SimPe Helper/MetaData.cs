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
using System.Drawing;
using System.Collections;

namespace SimPe.Data
{
	/// <summary>
	/// Determins the concrete Type of an Overlay Item (texture or mesh overlay)
	/// </summary>
	public enum TextureOverlayTypes : uint
	{
		Beard = 0x00,
		EyeBrow = 0x01,
		Lipstick = 0x02,
        Eye = 0x03,
		Mask = 0x04,
		Glasses = 0x05,
		Blush = 0x06,
        EyeShadow = 0x07
	}
	
	/// <summary>
	/// Ages used for Property Sets (Character Data, Skins)
	/// </summary>
	public enum Ages:uint
	{
		Baby = 0x20,
		Toddler = 0x01,
		Child = 0x02,
		Teen = 0x04,
		Adult = 0x08,
		Elder = 0x10,
		YoungAdult = 0x40
	}

	/// <summary>
	/// Categories used for Property Sets (Skins)
	/// </summary>
	public enum SkinCategories:uint
	{
		Everyday = 0x07,
		Swimmwear = 0x08,
		PJ = 0x10,
		Formal = 0x20,
		Undies = 0x40,
		Skin = 0x80,
		Pregnant = 0x100,
		Activewear = 0x200
	}

	/// <summary>
	/// 
	/// </summary>
	public enum Majors:uint 
	{
		Unset = 0,
		Unknown = 0xffffffff,
		Art = 0x2e9cf007,
		Biology = 0x4e9cf02b,
		Drama = 0x4e9cf04d,
		Economics = 0xEe9cf044,
		History = 0x2e9cf074,
		Literature = 0xce9cf085,
		Mathematics = 0xee9cf08d,
		Philosophy = 0x2e9cf057,
		Physics = 0xae9cf063,
		PoliticalScience = 0x4e9cf06d,
		Psychology = 0xCE9CF07C,
		Undeclared = 0x8e97bf1d
	}

	/// <summary>
	/// Room Sort Flag
	/// </summary>
	public enum ObjRoomSortBits:byte
	{
		Kitchen = 0x00,
		Bedroom = 0x01,
		Bathroom = 0x02,
		LivingRoom = 0x03,
		Outside = 0x04,
		DiningRoom = 0x05,
		Misc = 0x06,
		Study = 0x07,
		Kids = 0x08
	}

	/// <summary>
	/// Function Sort Flag 
	/// </summary>
	public enum ObjFunctionSortBits:byte
	{
		Seating = 0x00,
		Surfaces = 0x01,
		Appliances = 0x02,
		Electronics = 0x03,
		Plumbing = 0x04,
		Decorative = 0x05,
		General = 0x06,
		Lighting = 0x07,
		Hobbies = 0x08,
		AspirationRewards = 0x0a,
		CareerRewards = 0x0b
	}

	/// <summary>
	/// Enumerates known Object Types
	/// </summary>
	public enum ObjectTypes:ushort 
	{
		Unknown = 0x0000,
		Person = 0x0002,
		Normal = 0x0004,
		ArchitecturalSupport = 0x0005,
		SimType = 0x0007,
		Door = 0x0008,
		Window = 0x0009,
		Stairs = 0x000A,
		ModularStairs = 0x000B,
		ModularStairsPortal = 0x000C,
		Vehicle = 0x000D,
		Outfit = 0x000E,
		Memory = 0x000F,
		Template = 0x0010
	}

	/// <summary>
	/// Hold Constants, Enumerations and other Metadata
	/// </summary>
	public class MetaData
	{
		/// <summary>
		/// Color of a Sim that is either Unlinked or does not have Character Data
		/// </summary>
		public static Color SpecialSimColor = Color.FromArgb(0xD0, Color.Black);

		/// <summary>
		/// Color of a Sim that is unlinked
		/// </summary>
		public static Color UnlinkedSim = Color.FromArgb(0xEF, Color.SteelBlue);

		/// <summary>
		/// Color of a Sim that has no Character Data
		/// </summary>
		public static Color InactiveSim = Color.FromArgb(0xEF, Color.LightCoral);

		#region Constants

		/// <summary>
		/// Group for Costum Content
		/// </summary>
		public const UInt32 CUSTOM_GROUP = 0x1C050000;

		/// <summary>
		/// Group for Global Content
		/// </summary>
		public const UInt32 GLOBAL_GROUP = 0x1C0532FA;

		/// <summary>
		/// Group for Local Content
		/// </summary>
		public const UInt32 LOCAL_GROUP = 0xffffffff;

		/// <summary>
		/// A Directory file will have this Type in the fileindex.
		/// </summary>
		public const UInt32 DIRECTORY_FILE = 0xE86B1EEF; //0xEF1E6BE8;

		/// <summary>
		/// Stores the relationship Value for a Sim
		/// </summary>
		public const UInt32 RELATION_FILE = 0xCC364C2A;

		/// <summary>
		/// File Containing Strings
		/// </summary>
		public const UInt32 STRING_FILE = 0x53545223;

		/// <summary>
		/// File Containing Pie Strings
		/// </summary>
		public const UInt32 PIE_STRING_FILE = 0x54544173;

		/// <summary>
		/// File Containing Sim Descriptions
		/// </summary>
		public const UInt32 SIM_DESCRIPTION_FILE = 0xAACE2EFB;

		/// <summary>
		/// Files Containing Sim Images
		/// </summary>
		public const UInt32 SIM_IMAGE_FILE = 0x856DDBAC;

		/// <summary>
		/// The File containing all Family Ties
		/// </summary>
		public const UInt32 FAMILY_TIES_FILE = 0x8C870743;

		/// <summary>
		/// File containing BHAV Informations
		/// </summary>
		public const UInt32 BHAV_FILE = 0x42484156;

		/// <summary>
		/// File containng Global Data
		/// </summary>
		public const UInt32 GLOB_FILE = 0x474C4F42;

		/// <summary>
		/// File Containing Object Data
		/// </summary>
		public const UInt32 OBJD_FILE = 0x4F424A44;

		/// <summary>
		/// File Containing Catalog Strings
		/// </summary>
		public const UInt32 CTSS_FILE = 0x43545353;

		/// <summary>
		/// File Containing Name Maps
		/// </summary>
		public const UInt32 NAME_MAP = 0x4E6D6150;

		


		/// <summary>
		/// Signature identifying a compressed PackedFile
		/// </summary>
		public const ushort COMPRESS_SIGNATURE = 0xFB10;

		public const uint GZPS = 0xEBCF3E27;
		public const uint XWNT = 0xED7D7B4D;
		public const uint REF_FILE = 0xAC506764;
		public const uint IDNO = 0xAC8A7A2E;
		public const uint HOUS = 0x484F5553;

		public const uint GMND = 0x7BA3838C;
		public const uint TXMT = 0x49596978;
		public const uint TXTR = 0x1C4A276C;
		public const uint LIFO = 0xED534136;
		public const uint ANIM = 0xFB00791E;
		public const uint SHPE = 0xFC6EB1F7;
		public const uint CRES = 0xE519C933;
		public const uint GMDC = 0xAC4F8687;
		public const uint LDIR = 0xC9C81B9B;
		public const uint LAMB = 0xC9C81BA3;
		public const uint LPNT = 0xC9C81BA9;
		public const uint LSPT = 0xC9C81BAD;

		public const uint MMAT = 0x4C697E5A;

		public static string GMND_PACKAGE = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads\\_EnableColorOptionsGMND.package");
		public static string MMAT_PACKAGE = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res\\Sims3D\\_EnableColorOptionsMMAT.package");
		
		#endregion

		#region Enums

		/// <summary>
		/// Type of school a Sim attends
		/// </summary>
		public enum SchoolTypes:uint 
		{
			Unknown = 0x00000000,
			PublicSchool = 0xD06788B5,
			PrivateSchool = 0xCC8F4C11
		}

		/// <summary>
		/// Available Grades
		/// </summary>
		public enum Grades:ushort
		{
			Unknown = 0x00,
			F = 0x01,
			DMinus = 0x02,
			D = 0x03,
			DPlus = 0x04,
			CMinus = 0x05,
			C = 0x06,
			CPlus = 0x07,
			BMinus = 0x08,
			B = 0x09,
			BPlus = 0x0A,
			AMinus = 0x0B,
			A = 0x0C,
			APlus = 0x0D
		}

		

		/// <summary>
		/// Enumerates known Languages
		/// </summary>
		public enum Languages:byte 
		{
			Unknown = 0x00,
			English = 0x01,
			English_uk = 0x02,
			French = 0x03,
			German = 0x04,
			Italian = 0x05,
			Spanish = 0x06,
			Dutch = 0x07,
			Danish = 0x08,
			Swedish = 0x09,
			Norwegian = 0x0a,
			Finish = 0x0b,
			Hebrew = 0x0c,
			Russian = 0x0d,
			Portuguese = 0x0e,
			Japanese = 0x0f,
			Polish = 0x10,
			SimplifiedChinese = 0x11,
			TraditionalChinese = 0x12,
			Thai = 0x13,
			Korean = 0x14,
			Brazilian = 0x23
		}

		/// <summary>
		/// Enumerates available Datatypes
		/// </summary>
		public enum DataTypes:uint
		{
			dtUInteger = 0xEB61E4F7,
			dtString = 0x0B8BEA18,
			dtSingle = 0xABC78708,
			dtBoolean = 0xCBA908E1,
			dtInteger = 0x0C264712
		}

		/// <summary>
		/// Available Format Codes
		/// </summary>
		public enum FormatCode:ushort
		{
			normal = 0xFFFD,			
		};

		/// <summary>
		/// Is an Item within the PackedFile Index new Alias(0x20 , "or 0x24 Bytes long"),
		/// </summary>
		public enum IndexTypes:uint
		{
			ptShortFileIndex = 0x01,
			ptLongFileIndex = 0x02
		}

		/// <summary>
		/// Which general apiration does a Sim have
		/// </summary>
		public enum  AspirationTypes:ushort
		{
			Nothing = 0x00,
			Romance = 0x01,
			Family = 0x02,
			Fortune = 0x04,
			Reputation = 0x10,
			Knowledge = 0x20,
			Growup = 0x40
		}

		/// <summary>
		/// Relationships a Sim can have
		/// </summary>
		public enum RelationshipStateBits:byte
		{
			Enemy = 0x07,
			Friends = 0x04,
			Buddies = 0x05,
			Crush = 0x00,
			Love = 0x01,
			Steady = 0x06,
			Engaged = 0x02,
			Married = 0x03,
			Known = 0x0F,
			Family = 0x0E
		}

		/// <summary>
		/// Available Zodia Signes
		/// </summary>
		public enum ZodiacSignes:ushort
		{
			Aries = 0x01,		 //de: Widder
			Taurus = 0x02,
			Gemini = 0x03,
			Cancer = 0x04,	
			Leo = 0x05,
			Virgo = 0x06,		 //de: Jungfrau
			Libra = 0x07,		 //de: Waage
			Scorpio = 0x08,
			Sagittarius = 0x09,  //de: Schütze
			Capricorn = 0x0A,	 //de: Steinbock
			Aquarius = 0x0B,
			Pisces = 0x0C		 //de: Fische
		}

		/// <summary>
		/// Known Types for Family ties
		/// </summary>
		public enum FamilyTieTypes:uint
		{
			MyMotherIs = 0x00,
			MyFatherIs = 0x01,
			ImMarriedTo = 0x02,
			MySiblingIs = 0x03,
			MyChildIs = 0x04
		}

		/// <summary>
		/// Detailed Relationships between Sims
		/// </summary>
		public enum RelationshipTypes:uint
		{
			Unset_Unknown = 0x00,
			Parent = 0x01,
			Child = 0x02,
			Sibling = 0x03,
			Gradparent = 0x04,
			Grandchild = 0x05,
			Nice_Nephew = 0x06,
			Aunt = 0x07,
			Cousin = 0x08,
			Spouses = 0x09
		}

		/// <summary>
		/// How old (in Life Sections) is the Sim
		/// </summary>
		public enum LifeSections:ushort 
		{
			Unknown = 0x00,
			Baby = 0x01,
			Toddler = 0x02,
			Child = 0x03,
			Teen = 0x10,
			Adult = 0x13,
			Elder = 0x33,
			YoungAdult = 0x40
		}

		/// <summary>
		/// Gender of a Sim
		/// </summary>
		public enum Gender:ushort
		{
			Male = 0x00,
			Female = 0x01
		}

		public enum Careers:uint 
		{
			Unknown = 0xFFFFFFFF,
			Unemployed = 0x00000000,
			Military = 0x6C9EBD32,
			Politics = 0x2C945B14,
			Science = 0x0C9EBD47,
			Medical = 0x0C7761FD,
			Athletic = 0x2C89E95F,			
			Business = 0x45196555,
			LawEnforcement = 0xAC9EBCE3,
			Culinary = 0xEC9EBD5F,
			Slacker = 0xEC77620B,
			Criminal = 0x6C9EBD0E,
			TeenElderAthletic = 0xAC89E947,
			TeenElderBusiness = 0x4C1E0577,
			TeenElderCriminal = 0xACA07ACD,
			TeenElderCulinary = 0x4CA07B0C,
			TeenElderLawEnforcement = 0x6CA07B39,
			TeenElderMedical = 0xAC89E918,
			TeenElderMilitary = 0xCCA07B66,
			TeenElderPolitics = 0xCCA07B8D,
			TeenElderScience = 0xECA07BB0,
			TeenElderSlacker = 0x6CA07BDC,
			Paranormal = 0x2E6FFF87,
			NaturalScientist = 0xEE70001C,
			ShowBiz = 0xAE6FFFB0, 
			Artist = 0x4E6FFFBC
		}
		#endregion

		#region Arrays

		/// <summary>
		/// all Known SemiGlobal Groups
		/// </summary>
		public static Alias[] SemiGlobals = {
												#region Old SemiGlobal
												/*new SemiGlobalAlias(0x7F0136DC , "transport to and from homeGlobals"),
												new SemiGlobalAlias(true, 0x7F01EC29 , "PersonGlobals"),
												new SemiGlobalAlias(true, 0x7F026EBD , "dartboardGlobals"),
												new SemiGlobalAlias(true, 0x7F033984 , "stoveGlobals"),
												new SemiGlobalAlias(true, 0x7F074B38 , "chattingGlobals"),
												new SemiGlobalAlias(0x7F0B2AE7 , "video games I think"),
												new SemiGlobalAlias(true, 0x7F0B61F3 , "chairGlobals"),
												new SemiGlobalAlias(0x7F0C60C8 , "stair globals. Fixed stairs?"),
												new SemiGlobalAlias(0x7F1059B4 , "champagne globals?"),
												new SemiGlobalAlias(0x7F117CD9 , "stair globals. Connecting stairs?"),
												new SemiGlobalAlias(0x7F119F0A , "toy (from toybox)Globals"),
												new SemiGlobalAlias(0x7F12A804 , "counter or surfaceGlobals"),
												new SemiGlobalAlias(true, 0x7F16556B , "toiletGlobals"),
												new SemiGlobalAlias(true, 0x7F18E0F0 , "easelGlobals"),
												new SemiGlobalAlias(true, 0x7F1A9ECC , "shrubGlobals"),
												new SemiGlobalAlias(true, 0x7F20C1E4 , "magazineGlobals"),
												new SemiGlobalAlias(0x7F23B01B , "some sort of foodGlobals"),
												new SemiGlobalAlias(true, 0x7F277790 , "toyboxGlobals"),
												new SemiGlobalAlias(0x7F28EEB6 , "teach to speakGlobals"),
												new SemiGlobalAlias(true, 0x7F293E85 , "puddleGlobals"),
												new SemiGlobalAlias(0x7F2FEFCC , "not sure - only 3 BHAVs"),
												new SemiGlobalAlias(true, 0x7F327BCE , "bookGlobals"),
												new SemiGlobalAlias(0x7F347DAB , "food spoiling globals?"),
												new SemiGlobalAlias(0x7F38B8A7 , "urn and graveGlobals"),
												new SemiGlobalAlias(0x7F39D7FB , "some or other game"),
												new SemiGlobalAlias(0x7F3C9675 , "some sort of foodGlobals"),
												new SemiGlobalAlias(true, 0x7F441294 , "computerGlobals"),
												new SemiGlobalAlias(true, 0x7F4437F2 , "bedGlobals"),
												new SemiGlobalAlias(0x7F48AF7A , "changing boothGlobals"),
												new SemiGlobalAlias(0x7F48CA31 , "init floor, init ceiling, init table... what the heck?"),
												new SemiGlobalAlias(true, 0x7F496A24 , "dancingGlobals"),
												new SemiGlobalAlias(0x7F4EA230 , "more transportGlobals"),
												new SemiGlobalAlias(true, 0x7F4F06CA , "stereoGlobals"),
												new SemiGlobalAlias(true, 0x7F545E8D , "dollshouseGlobals"),
												new SemiGlobalAlias(0x7F553580 , "not sure"),
												new SemiGlobalAlias(0x7F575EBF , "something to do with parties"),
												new SemiGlobalAlias(0x7F5BB15F , "just two BHAVs"),
												new SemiGlobalAlias(true, 0x7F60C397 , "lampGlobals"),
												new SemiGlobalAlias(0x7F61CD20 , "TV video games"),
												new SemiGlobalAlias(0x7F63E3F2 , "event detection - like is someone on the phone. Weird"),
												new SemiGlobalAlias(0x7F675EF2 , "stuff about Maya models"),
												new SemiGlobalAlias(0x7F67FE05 , "drinks barGlobals"),
												new SemiGlobalAlias(true, 0x7F6B7BD0 , "lightningGlobals"),
												new SemiGlobalAlias(true, 0x7F6E333B , "dishwasherGlobals"),
												new SemiGlobalAlias(0x7F6E998E , "might be for the grandfather clock"),
												new SemiGlobalAlias(0x7F70D280 , "buying food at shop"),
												new SemiGlobalAlias(0x7F7234D0 , "finding somewhere to eat/serve food?"),
												new SemiGlobalAlias(true, 0x7F7638B3 , "sinkGlobals"),
												new SemiGlobalAlias(0x7F7A8450 , "guns? Might be a career reward"),
												new SemiGlobalAlias(0x7F7BA762 , "no idea!!! all about animations and “overlays”"),
												new SemiGlobalAlias(0x7F7D730B , "toaster globals?"),
												new SemiGlobalAlias(0x7F7FA83D , "more animations and overlays"),
												new SemiGlobalAlias(true, 0x7F83411E , "highchairGlobals"),
												new SemiGlobalAlias(true, 0x7F84A9F4 , "mirrorGlobals"),
												new SemiGlobalAlias(0x7F85C391 , "something to do with yoga"),
												new SemiGlobalAlias(0x7F8834C8 , "eating"),
												new SemiGlobalAlias(true, 0x7F890CAC , "cribGlobals"),
												new SemiGlobalAlias(0x7F8A5209 , "plant (flowerbed)Globals"),
												new SemiGlobalAlias(0x7F8B4A08 , "small one bit of sofa bit of kissing"),
												new SemiGlobalAlias(0x7F8C6EDA , "candy machine globals - reward object?"),
												new SemiGlobalAlias(0x7F8F4EB6 , "job/schoolGlobals"),
												new SemiGlobalAlias(0x0000200B , "something you put on and take off and then put on a surface."),
												new SemiGlobalAlias(0x7F92832C , "TVGlobals"),
												new SemiGlobalAlias(true, 0x7F9A5330 , "fridgeGlobals"),
												new SemiGlobalAlias(0x7F9A5831 , "feeding bottle globals?"),
												new SemiGlobalAlias(true, 0x7F9A625F , "aquariumGlobals"),
												new SemiGlobalAlias(0x7F9AB517 , "exercise bench globals?"),
												new SemiGlobalAlias(true, 0x7FA1DF44 , "chessGlobals"),
												new SemiGlobalAlias(0x7FA3FCFE , "trashcan (outdoor only?)Globals"),
												new SemiGlobalAlias(true, 0x7FA53DF6 , "pianoGlobals"),
												new SemiGlobalAlias(0x7FA6640C , "not sure... something you play or play with"),
												new SemiGlobalAlias(0x7FA815EA , "table globals? some sort of surface anyway"),
												new SemiGlobalAlias(0x7FACC12B , "no idea but it includes a “throw up” BHAV"),
												new SemiGlobalAlias(true, 0x7FAE06B0 , "sofaGlobals"),
												new SemiGlobalAlias(true, 0x7FAF5F74 , "glassesGlobals"),
												new SemiGlobalAlias(0x7FB01AF3 , "alarm clockGlobals"),
												new SemiGlobalAlias(true, 0x7FB208FA , "phoneGlobals"),
												new SemiGlobalAlias(0x7FB81D46 , "just 3 bhavs no idea what"),
												new SemiGlobalAlias(0x7FBD3903 , "phone lineGlobals"),
												new SemiGlobalAlias(0x7FBE051B , "educationGlobals"),
												new SemiGlobalAlias(true, 0x7FC026B4 , "artGlobals"),
												new SemiGlobalAlias(0x7FC9DC08 , "some game"),
												new SemiGlobalAlias(0x7FCDD99D , "small one something to do with roses"),
												new SemiGlobalAlias(0x7FCFF92E , "something you play with and kick"),
												new SemiGlobalAlias(0x7FD0A90D , "wedding cakeGlobals"),
												new SemiGlobalAlias(true, 0x7FD0DEBA , "DoorGlobalsNew"),
												new SemiGlobalAlias(0x7FD178FF , "coffee?"),
												new SemiGlobalAlias(0x7FD2752D , "small one. Dunno"),
												new SemiGlobalAlias(0x7FD3AF67 , "weird small one about thoughts"),
												new SemiGlobalAlias(0x7FD90EDB , "person-to-person interactions and routing"),
												new SemiGlobalAlias(true, 0x7FDA22BB , "grillGlobals"),
												new SemiGlobalAlias(0x7FDB80FC , "teddy bearGlobals"),
												new SemiGlobalAlias(0x7FDE81DC , "cashier stuff"),
												new SemiGlobalAlias(true, 0x7FE10572 , "dresserGlobals"),
												new SemiGlobalAlias(true, 0x7FE1C9FB , "microwaveGlobals"),
												new SemiGlobalAlias(0x7FE49F9B , "swimming poolGlobals"),
												new SemiGlobalAlias(0x7FE64A8D , "reading books"),
												new SemiGlobalAlias(0x7FE69E23 , "bath and showerGlobals"),
												new SemiGlobalAlias(0x7FE6D20D , "playing with child"),
												new SemiGlobalAlias(0x7FE6EE0D , "just an init BHAV"),
												new SemiGlobalAlias(0x7FEABABA , "hot tubGlobals"),
												new SemiGlobalAlias(true, 0x7FEC2140 , "cockroachGlobals"),
												new SemiGlobalAlias(true, 0x7FF616D0 , "windowGlobals"),
												new SemiGlobalAlias(0x7FF941DF , "something to do with visibility and emitters and awareness"),
												new SemiGlobalAlias(0x7FF9DF6B , "clearing up spoiled food?"),
												new SemiGlobalAlias(true, 0x7FFD4F2D , "fireplaceGlobals"),
												new SemiGlobalAlias(true, 0x7FFEA664 , "telescopeGlobals")*/
												#endregion
												new SemiGlobalAlias(true, 0x7FE6EE0D,"Accessory_Globals"),
												new SemiGlobalAlias(true, 0x7F9A625F,"AquariumGlobals"),
												new SemiGlobalAlias(true, 0x7FC026B4,"ArtGlobals"),
												new SemiGlobalAlias(true, 0x7FAF5F74,"Aspiration_CoolShadesGlobals"),
												new SemiGlobalAlias(true, 0x7F8FA50E,"AspirationsHatGlobals"),
												new SemiGlobalAlias(true, 0x7F67FE05,"BarGlobals"),
												new SemiGlobalAlias(true, 0x7F4437F2,"BedGlobals"),
												new SemiGlobalAlias(true, 0x7F327BCE,"BookCaseGlobals"),
												new SemiGlobalAlias(true, 0x7FE64A8D,"BookGlobals"),
												new SemiGlobalAlias(true, 0x7FF9DF6B,"BuffetGlobals"),
												new SemiGlobalAlias(true, 0x7FD0A90D,"CakeGlobals"),
												new SemiGlobalAlias(true, 0x7F7A8450,"Career_FingerprintGlobals"),
												new SemiGlobalAlias(true, 0x7F8C6EDA,"CareerCandyFactoryGlobals"),
												new SemiGlobalAlias(true, 0x7F4EA230,"CarGlobals"),
												new SemiGlobalAlias(true, 0x7F56BB72,"CarGlobalsNew"),
												new SemiGlobalAlias(true, 0x7FDE81DC,"CashRegisterGlobals"),
												new SemiGlobalAlias(true, 0x7F0B61F3,"ChairGlobals"),
												new SemiGlobalAlias(true, 0x7FA1DF44,"ChessGlobal"),
												new SemiGlobalAlias(true, 0x7FB01AF3,"Clock_Alarm_Globals"),
												new SemiGlobalAlias(true, 0x7F48AF7A,"ClothingBoothGlobals"),
												new SemiGlobalAlias(true, 0x7F2FEFCC,"CoffeeMachineGlobals"),
												new SemiGlobalAlias(true, 0x7F441294,"ComputerGlobals"),
												new SemiGlobalAlias(true, 0x7F074B38,"ConversationPersonalityGlobals"),
												new SemiGlobalAlias(true, 0x7F12A804,"CounterGlobals"),
												new SemiGlobalAlias(true, 0x7F890CAC,"CribGlobals"),
												new SemiGlobalAlias(true, 0x7F3B9D51,"CurtainGlobals"),
												new SemiGlobalAlias(true, 0x7F3B9D51,"urtainGlobals"), // GLOB-Resource fehlerhaft?!
												new SemiGlobalAlias(true, 0x7F496A24,"DanceGlobals"),
												new SemiGlobalAlias(true, 0x7F026EBD,"DartboardGlobal"),
												new SemiGlobalAlias(true, 0x7FA815EA,"DeskGlobals"),
												new SemiGlobalAlias(true, 0x7F6E333B,"DishwasherGlobals"),
												new SemiGlobalAlias(true, 0x7F545E8D,"DollHouseGlobals"),
												new SemiGlobalAlias(true, 0x7FD0DEBA,"DoorGlobalsNew"),
												new SemiGlobalAlias(true, 0x7F376D8B,"EaselGlobals"),
												new SemiGlobalAlias(true, 0x7FF941DF,"EmitterGlobals"),
												new SemiGlobalAlias(true, 0x7F9AB517,"ExercisemachineGlobals"),
												new SemiGlobalAlias(true, 0x7FFD4F2D,"FireplaceGlobals"),
												new SemiGlobalAlias(true, 0x7FCFF92E,"FlamingoGlobals"),
												new SemiGlobalAlias(true, 0x7F8A5209,"FlowerGlobals"),
												new SemiGlobalAlias(true, 0x7F3C9675,"Food_Globals"),
												new SemiGlobalAlias(true, 0x7F347DAB,"FoodContainer_Globals"),
												new SemiGlobalAlias(true, 0x7F8834C8,"FoodDish_Globals"),
												new SemiGlobalAlias(true, 0x7F70D280,"FoodDisplayGlobals"),
												new SemiGlobalAlias(true, 0x7F23B01B,"FoodProcessor_Globals"),
												new SemiGlobalAlias(true, 0x7F9A5330,"FridgeGlobals"),
												new SemiGlobalAlias(true, 0x7F6E998E,"GrandfatherClockGlobals"),
												new SemiGlobalAlias(true, 0x7F83411E,"HighChairGlobals"),
												new SemiGlobalAlias(true, 0x7FEABABA,"HottubGlobals"),
												new SemiGlobalAlias(true, 0x7F7FA83D,"IdleGlobals"),
												new SemiGlobalAlias(true, 0x7F4899DB,"LightGlobals"), 
												new SemiGlobalAlias(true, 0x7F4899DB,"ightGlobals"), // GLOB-Resource fehlerhaft?!
												new SemiGlobalAlias(true, 0x7F8F4EB6,"JobDataGlobals"),
												new SemiGlobalAlias(true, 0x7FBE051B,"JobDataSchoolGlobals"),
												new SemiGlobalAlias(true, 0x7F60C397,"LampGlobals"),
												new SemiGlobalAlias(true, 0x7F0136DC,"LotTransitionGlobals"),
												new SemiGlobalAlias(true, 0x7F20C1E4,"MagazineGlobals"),
												new SemiGlobalAlias(true, 0x7F3A03A4,"MailBoxGlobals"),
												new SemiGlobalAlias(true, 0x7F575EBF,"MemoryGlobals"),
												new SemiGlobalAlias(true, 0x7FE1C9FB,"MicrowaveGlobals"),
												new SemiGlobalAlias(true, 0x7F84A9F4,"MirrorGlobals"),
												new SemiGlobalAlias(true, 0x7F18E0F0,"PaintingGlobals"),
												new SemiGlobalAlias(true, 0x7F553580,"PersonalityGlobals"),
												new SemiGlobalAlias(true, 0x7F01EC29,"PersonGlobals"),
												new SemiGlobalAlias(true, 0x7FBD3903,"PhoneCallGlobals"),
												new SemiGlobalAlias(true, 0x7FB208FA,"PhoneGlobals"),
												new SemiGlobalAlias(true, 0x7FA53DF6,"PianoGlobals"),
												new SemiGlobalAlias(true, 0x7FC9DC08,"PinballMachineGlobals"),
												new SemiGlobalAlias(true, 0x7F48CA31,"PlantGlobals"),
												new SemiGlobalAlias(true, 0x7FE49F9B,"Pool_Globals"),
												new SemiGlobalAlias(true, 0x7F293E85,"PuddleGlobal"),
												new SemiGlobalAlias(true, 0x7F7BA762,"ReactionGlobals"),
												new SemiGlobalAlias(true, 0x7FA6640C,"RemoteControlCarGlobals"),
												new SemiGlobalAlias(true, 0x7FEC2140,"RoachGlobals"),
												new SemiGlobalAlias(true, 0x7F5BB15F,"RouteBehaviorGlobals"),
												new SemiGlobalAlias(true, 0x7FE10572,"ShoppingRackGlobals"),
												new SemiGlobalAlias(true, 0x7F1A9ECC,"ShrubGlobals"),
												new SemiGlobalAlias(true, 0x7FD2752D,"SignGlobals"),
												new SemiGlobalAlias(true, 0x7F7638B3,"SinkGlobals"),
												new SemiGlobalAlias(true, 0x7FD90EDB,"SocialGlobals"),
												new SemiGlobalAlias(true, 0x7F675EF2,"SocialMarkerGlobals"),
												new SemiGlobalAlias(true, 0x7FAE06B0,"SofaGlobals"),
												new SemiGlobalAlias(true, 0x7F8B4A08,"SofaSocialGlobals"),
												new SemiGlobalAlias(true, 0x7F117CD9,"StairModularGlobals"),
												new SemiGlobalAlias(true, 0x7F0C60C8,"StairsStraightGlobals"),
												new SemiGlobalAlias(true, 0x7F4F06CA,"StereoGlobals"),
												new SemiGlobalAlias(true, 0x7F033984,"Stove_Globals"),
												new SemiGlobalAlias(true, 0x7FDA22BB,"StoveGrill_Globals"),
												new SemiGlobalAlias(true, 0x7FDB80FC,"StuffedAnimal_Globals"),
												new SemiGlobalAlias(true, 0x7F85C391,"TableCoffee_Globals"),
												new SemiGlobalAlias(true, 0x7F7234D0,"TableDining_Globals"),
												new SemiGlobalAlias(true, 0x7FD178FF,"TableEnd_Globals"),
												new SemiGlobalAlias(true, 0x7FFEA664,"TelescopeGlobals"),
												new SemiGlobalAlias(true, 0x7FE69D2A,"TelevisionChannelGlobals"),
												new SemiGlobalAlias(true, 0x7F92832C,"TelevisionGlobals"),
												new SemiGlobalAlias(true, 0x7FD3AF67,"ThoughtGlobals"),
												new SemiGlobalAlias(true, 0x7F7D730B,"ToasterOvenGlobals"),
												new SemiGlobalAlias(true, 0x7F1059B4,"ToastingSetGlobals"),
												new SemiGlobalAlias(true, 0x7F16556B,"ToiletGlobals"),
												new SemiGlobalAlias(true, 0x7F277790,"ToyBoxGlobals"),
												new SemiGlobalAlias(true, 0x7F119F0A,"ToyboxToysGlobals"),
												new SemiGlobalAlias(true, 0x7F28EEB6,"ToyLanguageGlobals"),
												new SemiGlobalAlias(true, 0x7F39D7FB,"ToyXylophoneGlobals"),
												new SemiGlobalAlias(true, 0x7FA3FCFE,"TrashGlobals"),
												new SemiGlobalAlias(true, 0x7F6B7BD0,"TreeGlobals"),
												new SemiGlobalAlias(true, 0x7FACC12B,"TriggerHandler_Global"),
												new SemiGlobalAlias(true, 0x7FE69E23,"TubAndShowerGlobals"),
												new SemiGlobalAlias(true, 0x7F63E3F2,"TutorialScriptingGlobals"),
												new SemiGlobalAlias(true, 0x7F38B8A7,"UrnStoneGlobals"),
												new SemiGlobalAlias(true, 0x7F0B2AE7,"VideoGame_CD_Globals"),
												new SemiGlobalAlias(true, 0x7F9A5831,"VideoGame_Controller_Globals"),
												new SemiGlobalAlias(true, 0x7F61CD20,"VideoGame_Globals"),
												new SemiGlobalAlias(true, 0x7F62606D,"WeatherGlobals"),
												new SemiGlobalAlias(true, 0x7FF616D0,"Windowglobals"),
												new SemiGlobalAlias(0x7FB81D46, "just 3 bhavs no idea what"),
												new SemiGlobalAlias(0x7FCDD99D, "small one something to do with roses"),
												new SemiGlobalAlias(0x7FE6D20D, "playing with child")
											};
											
		/// <summary>
		/// Contains Aliases for the packedFileTypes
		/// </summary>
		public static TypeAlias[] FileTypes = {
												  new TypeAlias(false, "----", 0xFFFFFFFF, "--- "+Localization.Manager.GetString("userdefined")+" ---", false),
												  new TypeAlias(false, "2ARY", 0xABCB5DA4, "2D Array"),
												  new TypeAlias(false, "2ARY", 0x6B943B43, "2D Array"),
												  new TypeAlias(false, "3ARY", 0x2A51171B, "3D Array"),
												  new TypeAlias(false, "AGED", 0xAC598EAC, "Age Data"),
												  new TypeAlias(false, "ANIM", ANIM, "Animation Resource", "5an"),
												  new TypeAlias(false, "AUDT", 0xEBFEE345, "Audio Test"),
												  new TypeAlias(true, "BCON", 0x42434F4E, "Behaviour Constant"),
												  new TypeAlias(true, "BHAV", BHAV_FILE, "Behaviour Function"),
												  new TypeAlias(false, "BINX", 0x0C560F39, "Binary Index"),
												  new TypeAlias(true, "BMP", 0x424D505F, "Bitmap Image", "bmp"),
												  new TypeAlias(false, "CATS", 0x43415453, "Catalog String"),
												  new TypeAlias(false, "COLL", 0x6C4F359D, "Collection"),
												  new TypeAlias(false, "CRES", CRES, "Resource Node", "5cr"),
												  new TypeAlias(false, "CTSS", CTSS_FILE, "Catalog Description"),
												  new TypeAlias(false, "LxNR", 0xCCCEF852, "Facial Structure"),
												  new TypeAlias(false, "DGRP", 0x44475250, "Layered Image"),
												  new TypeAlias(false, "FX", 0xEA5118B0, "Effects List", "fx"),
												  new TypeAlias(false, "FACE", 0x46414345, "Face Properties"),
												  new TypeAlias(false, "FAMI", 0x46414D49, "Family Information"),
												  new TypeAlias(false, "FCNS", 0x46434E53, "Function"),
												  new TypeAlias(false, "SWAF", 0xCD95548E, "Sim Wants and Fears"),
												  new TypeAlias(false, "FPST", 0xAB4BA572, "Fence Post Layer"),
												  new TypeAlias(true, "FWAV", 0x46574156, "Audio Reference"),
												  new TypeAlias(false, "FXSD", 0x8DB5E4C2, "FX Sound"),
												  new TypeAlias(true, "GLOB", GLOB_FILE, "Global Data"),
												  new TypeAlias(false, "GMDC", GMDC, "Geometric Data Container", "5gd"),
												  new TypeAlias(false, "GMND", GMND, "Geometric Node", "5gn"),
												  new TypeAlias(false, "GZPS", GZPS, "Property Set"),
												  new TypeAlias(false, "HOUS", HOUS, "House Descriptor"),
												  new TypeAlias(false, "IDNO", IDNO, "ID Number"),
												  new TypeAlias(false, "JPG", 0x0C7E9A76, "JPEG Image", "jpg"),
												  new TypeAlias(false, "JPG", 0x4D533EDD, "JPEG Image", "jpg"),
												  new TypeAlias(false, "JPG", 0x8C3CE95A, "JPEG Image", "jpg"),
												  new TypeAlias(false, "IMG", SIM_IMAGE_FILE, "jpg/tga/png Image", "jpg"),
												  new TypeAlias(false, "LGHT", LAMB, "Lighting (Ambient Light)", "5al"),
												  new TypeAlias(false, "LGHT", LDIR, "Lighting (Directional Light)", "5dl"),
												  new TypeAlias(false, "LGHT", LPNT, "Lighting (Point Light)", "5pl"),
												  new TypeAlias(false, "LGHT", LSPT, "Lighting (Spot Light)", "5sl"),
												  new TypeAlias(false, "LGHT", 0xAC06A676, "Lighting (Draw State Light)", "5ds"),
												  new TypeAlias(false, "LGHT", 0x6A97042F, "Lighting (Environment Cube Light)", "5el"),
												  new TypeAlias(false, "LGHT", 0xAC06A66F, "Lighting (Linear Fog Light)", "5lf"),
												  new TypeAlias(false, "LIFO", LIFO, "Large Image File", "6li"),
												  new TypeAlias(false, "NMAP", NAME_MAP, "Name Map"),
												  new TypeAlias(false, "CLST", DIRECTORY_FILE, "Directory of Compressed Files", "dir"),
												  new TypeAlias(false, "LTXT", 0x0BF999E7, "Lot Description"),
												  new TypeAlias(false, "LTTX", 0x4B58975B, "Lot Texture"),
												  new TypeAlias(false, "TXMT", TXMT, "Material Definition", "5tm"),
												  new TypeAlias(false, "MMAT", MMAT, "Material Override"),
												  new TypeAlias(false, "NGBH", 0x4E474248, "Neighborhood/Memory"),
												  new TypeAlias(true, "NREF", 0x4E524546, "Name Reference"),
												  new TypeAlias(true, "OBJD", OBJD_FILE, "Object Data"),
												  new TypeAlias(true, "OBJf", 0x4F424A66, "Object Functions"),
												  new TypeAlias(false, "OBJM", 0x4F626A4D, "Object Material?"),
												  new TypeAlias(false, "OBJT", 0x6F626A74, "Object"),
												  new TypeAlias(false, "OBJT", 0xFA1C39F7, "Object"),
												  new TypeAlias(false, "OBJX", 0x6C4F359D, "Object Index"),
												  new TypeAlias(false, "OBJX", 0x0C560F39, "Object Index"),
												  new TypeAlias(false, "PALT", 0x50414C54, "Image Color Palette (Version 1)"),
												  new TypeAlias(false, "3IDR", REF_FILE, "3D ID Referencing File"),
												  new TypeAlias(false, "POSI", 0x504F5349, "Stack Script"),
												  new TypeAlias(false, "MATSHAD", 0xCD7FE87A, "Maxis Material Shader", "matshad"),
												  new TypeAlias(false, "PTBP", 0x50544250, "Package Text"),
												  new TypeAlias(false, "RTEX", 0xACE46235, "Road Texture"),
												  new TypeAlias(false, "SDBA", 0x8CC0A14B, Localization.Manager.GetString("unk")+": 0x8CC0A14B", false),
												  new TypeAlias(false, "SDNA", 0xEBFEE33F, "Sim DNA"),
												  new TypeAlias(false, "SHPE", SHPE, "Shape", "5sh"),
												  new TypeAlias(false, "SIMI", 0x53494D49, "Sim Information"),
												  new TypeAlias(false, "SK3D", 0xAC506764, "Skin 3D Model?"),
												  new TypeAlias(false, "SKNX", 0xEBCF3E27, "Skin Index"),
												  new TypeAlias(true, "SLOT", 0x534C4F54, "Slot File", false),
												  new TypeAlias(false, "SMAP", 0xCAC4FC40, "String Map"),
												  new TypeAlias(true, "SPR2", 0x53505232, "Sprites"),
												  new TypeAlias(false, "MP3", 0x2026960B, "mp3 or xa Sound File", "mp3"),
												  new TypeAlias(true, "STR#", STRING_FILE, Localization.Manager.GetString("str")),
												  new TypeAlias(false, "TATT", 0x54415454, "TATT: 0x54415454", false),
												  new TypeAlias(false, "TPRP", 0x54505250, "Edith Simantics Behaviour Labels"),
												  new TypeAlias(true, "TREE", 0x54524545, "Edith Flowchart Trees"),
												  new TypeAlias(false, "TRKS", 0x0B9EB87E, "Track Settings"),
												  new TypeAlias(false, "TSSG", 0xBA353CE1, "TSSG System"),
												  new TypeAlias(true, "TTAB", 0x54544142, "Pie Menu Functions"),
												  new TypeAlias(true, "TTAs", PIE_STRING_FILE, "Pie Menu Strings"),
												  new TypeAlias(false, "TXTR", TXTR, "Texture Image", "6tx"),
												  new TypeAlias(false, "VERS", 0xEBFEE342, "Version Information"),
												  new TypeAlias(false, "VERT", 0xCB4387A1, "Vertex"),
												  new TypeAlias(false, "WGRA", 0x0A284D0B, "Wall Graph"),
												  new TypeAlias(false, "WLAY", 0x8A84D7B0, "Wall Layer"),
												  new TypeAlias(false, "WRLD", 0x49FF7D76, "World Database"),
												  new TypeAlias(false, "XFAC", 0xEBFEE33F, "Face XML"),
												  new TypeAlias(false, "XFCH", 0x8C93E35C, "Face Arch XML", "xml"),
												  new TypeAlias(false, "XFLR", 0x4DCADB7E, "Floor XML", "xml"),
												  new TypeAlias(false, "XFMD", 0x0C93E3DE, "Face Modifier XML", "xml"),
												  new TypeAlias(false, "XFNC", 0x2CB230B8, "Fence XML", "xml"),
												  new TypeAlias(false, "XFNU", 0x6C93B566, "Face Neural XML", "xml"),
												  new TypeAlias(false, "XFRG", 0x8C93BF6C, "Face Region XML", "xml"),
												  new TypeAlias(false, "XHTN", 0x8C1580B5, "Hair Tone XML", "xml"),
												  new TypeAlias(false, "XMOL", 0x0C1FE246, "Mesh Overlay XML", "xml"),
												  new TypeAlias(false, "XMTO", 0x584D544F, "Material Object?"),
												  new TypeAlias(false, "XNBH", 0x6D619378, "Neighborhood Object XML", "xml"),
												  new TypeAlias(false, "XOBJ", 0xCCA8E925, "Object XML", "xml"),
												  new TypeAlias(false, "XOBJ", 0x584F424A, "Object XML", "xml"),
												  new TypeAlias(false, "XROF", 0xACA8EA06, "Roof XML", "xml"),
												  new TypeAlias(false, "XSTN", 0x4C158081, "Skin Tone XML", "xml"),
												  new TypeAlias(false, "XTOL", 0x2C1FD8A1, "Texture Overlay XML", "xml"),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x6C589723, Localization.Manager.GetString("unk")+": 0x6C589723", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xCD8B6498, Localization.Manager.GetString("unk")+": 0xCD8B6498", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xAB9406AA, Localization.Manager.GetString("unk")+": 0xAB9406AA", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x0C900FDB, Localization.Manager.GetString("unk")+": 0x0C900FDB", false),
												  new TypeAlias(false, "SREL", RELATION_FILE, Localization.Manager.GetString("srel")),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x8B0C79D6, Localization.Manager.GetString("unk")+": 0x8B0C79D6", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x50455253, Localization.Manager.GetString("unk")+": 0x50455253", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xBC66BAEC, Localization.Manager.GetString("unk")+": 0xBC66BAEC", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xEC44BDDC, Localization.Manager.GetString("unk")+": 0xEC44BDDC", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x2C310F46, Localization.Manager.GetString("unk")+": 0x2C310F46", false),
												  new TypeAlias(false, "FAMT", FAMILY_TIES_FILE, Localization.Manager.GetString("famt")),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xABD0DC63, Localization.Manager.GetString("unk")+": 0xABD0DC63", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xCC2A6A34, Localization.Manager.GetString("unk")+": 0xCC2A6A34", false),
												  new TypeAlias(false, "UI", 0x00000000, "UI Data", "uiScript"),
												  new TypeAlias(false, "KEYD", 0xA2E3D533, "Accelerator Key Definitions"),
												  new TypeAlias(false, "SDSC", SIM_DESCRIPTION_FILE, Localization.Manager.GetString("sdesc")), 
												  new TypeAlias(true, "TRCN", 0x5452434E, "Behaviour Constant Labels", false),
												  new TypeAlias(false, "FAMH", 0x46414D68, "Family "+Localization.Manager.GetString("unknown")),
												  new TypeAlias(false, "XWNT", XWNT, "Wants XML", "xml"),
												  new TypeAlias(false, "WNTT", 0x6D814AFE, "Wants Tree Item", "xml"),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0x7B1ACFCD, Localization.Manager.GetString("unk")+": 0x7B1ACFCD", false),
												  new TypeAlias(false, Localization.Manager.GetString("unk"), 0xADEE8D84, Localization.Manager.GetString("unk")+": 0xADEE8D84", false),
												  new TypeAlias(false, "CINE", 0x4D51F042, "Cinematic Scene", "5cs"),
												  new TypeAlias(false, "THUB", 0xAC2950C1, "Thumbnail", "jpg"),
												  new TypeAlias(false, "SCEN", 0x25232B11, "Scene Node", "5sc"),
												  new TypeAlias(false, "THUB", 0x2C30E040, "Fence Arch Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0x2C43CBD4 , "Foundation or Pool Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0x2C488BCA, "Dormer Thmbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0x8C31125E, "Wall Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0x8C311262, "Floor Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0xCC30CDF8, "Fence Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0xCC44B5EC, "Modular Stair Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0xCC489E46, "Roof Thumbnail", "jpg"),
												  new TypeAlias(false, "THUB", 0xCC48C51F, "Chimney Thumbnail", "jpg"),
												  new TypeAlias(false, "GROP", 0x54535053, "Groups Cache"),
												  new TypeAlias(false, "POPS", 0x2C310F46, "Popups")
		};
		#endregion

		#region Supporting Methods
		/// <summary>
		/// Returns the describing TypeAlias for the passed Type
		/// </summary>
		/// <param name="type">The type you want to load the TypeAlias for</param>
		/// <returns>The TypeAlias representing the Type</returns>
		public static TypeAlias FindTypeAlias(UInt32 type) 
		{
			foreach (Data.TypeAlias a in Data.MetaData.FileTypes)
			{
				if (a.Id == type) return a;
			} //for
			
			//unknown Type
			string t = Helper.HexString(type);			
			return new Data.TypeAlias(false, Localization.Manager.GetString("unk")+"", type, "0x"+t);
		}

		/// <summary>
		/// Returns the Group Number of a SemiGlobal File
		/// </summary>
		/// <param name="name">the nme of the semi global</param>
		/// <returns>The group Vlue of the Global</returns>
		public static Alias FindSemiGlobal(string name) 
		{
			name = name.ToLower();
			foreach (Alias a in Data.MetaData.SemiGlobals)
			{
				if (a.Name.ToLower() == name) return a;
			} //for
			
			//unknown SemiGlobal
			return new Alias(0xffffffff, name.ToLower());
		}
		#endregion

		#region Map's
		static ArrayList rcollist;
		static ArrayList complist;
		static Hashtable agelist;

		//Returns a List of all RCOl Compatible File Types
		public static ArrayList RcolList 
		{
			get 
			{
				if (rcollist==null) 
				{
					rcollist = new ArrayList();
									
					rcollist.Add((uint)GMDC);	//GMDC
					rcollist.Add((uint)TXTR);	//TXTR
					rcollist.Add((uint)LIFO);	//LIFO
					rcollist.Add((uint)TXMT);	//MATD
					rcollist.Add((uint)ANIM);	//ANIM
					rcollist.Add((uint)GMND);	//GMND
					rcollist.Add((uint)SHPE);	//SHPE
					rcollist.Add((uint)CRES);	//CRES
					rcollist.Add(LDIR);
					rcollist.Add(LAMB);
					rcollist.Add(LSPT);
					rcollist.Add(LPNT);
				}

				return rcollist;
			}
		}

		//Returns a List of File Types that should be compressed
		public static ArrayList CompressionCandidates 
		{
			get 
			{
				if (complist==null) 
				{
					complist = RcolList;
									
					complist.Add(MetaData.STRING_FILE);
					complist.Add((uint)0x0C560F39); //Binary Index
					complist.Add((uint)0xAC506764); //3D IDR
				}

				return complist;
			}
		}

		/// <summary>
		/// translates the Ages from a SDesc to a Property Set age 
		/// </summary>
		public static Data.Ages AgeTranslation(MetaData.LifeSections age)
		{
			agelist = new Hashtable();
			if (age == MetaData.LifeSections.Adult) return Data.Ages.Adult;
			else if (age == MetaData.LifeSections.Baby) return Data.Ages.Baby;
			else if (age == MetaData.LifeSections.Child) return Data.Ages.Child;
			else if (age == MetaData.LifeSections.Elder) return Data.Ages.Elder;
			else if (age == MetaData.LifeSections.Teen) return Data.Ages.Teen;
			else if (age == MetaData.LifeSections.Toddler) return Data.Ages.Toddler;
			else return Data.Ages.Adult;
					
		}
		#endregion
	}
}
