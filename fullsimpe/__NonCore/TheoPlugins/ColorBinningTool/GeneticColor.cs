using System;
using System.Collections;

namespace SimPe.Plugin
{
	// TODO: rename to haircolor
	public enum HairColor
	{
		Black = 1,
		Brown = 2,
		Blond = 3,
		Red = 4,
		Grey = 5,
		Custom = 6
	}

	public enum SimGender
	{
		Unspecified = 0,
		Female = 1,
		Male = 2,
		Both = Female | Male
	}

	public enum ShoeType : uint
	{
		None = 0,
		Barefoot = 1,
		HeavyBoot = 2,
		Heeled = 3,
		Normal = 4,
		Sandal = 5,
		Armored = 7
	}


	public enum OutfitType : int
	{
		None = 0x0000,
		Hair = 0x0001,
		Face = 0x0002,

		Top = 0x0004,
		Body = 0x0008,
		Bottom = 0x0010,

		Accessory = 0x0020,

		TailLong = 0x0040,
		EarsUp = 0x0080,
		TailShort = 0x0100,
		EarsDown = 0x0200,
		BrushTailLong = 0x0400,
		BrushTailShort = 0x0800,
		SpitzTail = 0x1000,
		BrushSpitzTail = 0x2000
	}


	public enum SpeciesType : uint
	{
		Unspecified = 0x00,
		Human = 0x01,
		LargeDog = 0x02,
		SmallDog = 0x04,
		Wolf = 0x06,
		Cat = 0x08
	}

}
