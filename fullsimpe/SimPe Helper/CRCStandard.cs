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
// $Id$

#region License
/* ***** BEGIN LICENSE BLOCK *****
 * Version: MPL 1.1
 *
 * The contents of this file are subject to the Mozilla Public License Version
 * 1.1 (the "License"); you may not use this file except in compliance with
 * the License. You may obtain a copy of the License at
 * http://www.mozilla.org/MPL/
 *
 * Software distributed under the License is distributed on an "AS IS" basis,
 * WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
 * for the specific language governing rights and limitations under the
 * License.
 *
 * The Original Code is Classless.Hasher - C#/.NET Hash and Checksum Algorithm Library.
 *
 * The Initial Developer of the Original Code is Classless.net.
 * Portions created by the Initial Developer are Copyright (C) 2004 the Initial
 * Developer. All Rights Reserved.
 *
 * Contributor(s):
 *		Jason Simeone (jay@classless.net)
 * 
 * ***** END LICENSE BLOCK ***** */
#endregion

using System;

namespace Classless.Hasher {
	/// <summary>Predefined standards for CRC algorithms.</summary>
	public enum CRCStandard {
		/// <summary>The standard CRC8 algorithm.</summary>
		CRC8,

		/// <summary>The reversed CRC8 algorithm.</summary>
		CRC8_REVERSED,

		/// <summary>The standard CRC16 algorithm.</summary>
		CRC16,

		/// <summary>The reversed CRC8 algorithm.</summary>
		CRC16_REVERSED,

		/// <summary>The standard CRC16-CCITT algorithm. Used in things such as X.25, SDLC, and HDLC.</summary>
		CRC16_CCITT,

		/// <summary>The reversed CRC16-CCITT algorithm. Used in things such as XMODEM and Kermit.</summary>
		CRC16_CCITT_REVERSED,

		/// <summary>The standard CRC24 algorithm. Used in things such as PGP.</summary>
		CRC24,

		/// <summary>The standard CRC32 algorithm. Used in things such as AUTODIN II, Ethernet, and FDDI.</summary>
		CRC32,

		/// <summary>The reversed CRC32 algorithm. Used in things such as PKZip and SFV.</summary>
		CRC32_REVERSED,

		/// <summary>A variation on the CRC16 algorithm. Used in ARC.</summary>
		CRC16_ARC,

		/// <summary>A variation on the CRC16 algorithm. Used in ZMODEM.</summary>
		CRC16_ZMODEM,

		/// <summary>A variation on the CRC32 algorithm. Used in JAMCRC.</summary>
		CRC32_JAMCRC,

		/// <summary>A variation on the CRC32 algorithm. Used in BZip2.</summary>
		CRC32_BZIP2
	}
}
