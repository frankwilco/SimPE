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
using SimPe.Interfaces.Files;

namespace SimPe.Interfaces.Providers
{
	/// <summary>
	/// Interface to obtain the SimFamilyNames Alias List from the Type Registry
	/// </summary>
	public interface IOpcodeProvider : ICommonPackage
	{		
		/// <summary>
		/// Returns the the name of the Function
		/// </summary>
		/// <param name="id">The opcode of the primitive</param>
		/// <returns>The name of the Primitive</returns>
		string FindName(ushort opcode);

		// <summary>
		/// Returns the List of known Primitivess
		/// </summary>
		ArrayList StoredPrimitives
		{
			get;
		}

		/// <summary>
		/// Returns the the name of the Expression Operator
		/// </summary>
		/// <param name="op">Numerical Value of the Operator</param>
		/// <returns>The Name of The Operator</returns>
		string FindExpressionOperator(byte op);

		/// <summary>
		/// Returns the the name of a Data Owner
		/// </summary>
		/// <param name="owner">Numerical Value of the Owner</param>
		/// <returns>The Name</returns>
		string FindExpressionDataOwners(byte owner);

		/// <summary>
		/// Returns the the name of a Motive
		/// </summary>
		/// <param name="owner">Numerical Value</param>
		/// <returns>The Name</returns>
		string FindMotives(ushort nr);

		/// <summary>
		/// Returns the the a Memory Alias
		/// </summary>
		/// <param name="guid">Guid of the Memory</param>
		/// <returns>An IAlias Object describing the Memory</returns>
		/// <remarks>
		/// The Tage returns an  Object Array:
		///    0: IPackedFileDescriptor for the Object File in the BasePackage
		/// </remarks>
		IAlias FindMemory(uint guid);

		/// <summary>
		/// Returns a list of all known memories
		/// </summary>
		Hashtable StoredMemories
		{
			get;
		}

		/// <summary>
		/// returns null or a Matching global BHAV File
		/// </summary>
		/// <param name="opcode">the Opcode of the BHAV</param>
		/// <returns>The Descriptor for the Bhav File in the BasePackage</returns>
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem LoadGlobalBHAV(ushort opcode);

		/// <summary>
		/// Returns the Bhav for a Semi Global Opcode
		/// </summary>
		/// <param name="opcode">The Opcode</param>
		/// <param name="group">The group of the SemiGlobal</param>
		/// <returns>The Descriptor of the Bhaf File in the Base Packagee or null</returns>
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem LoadSemiGlobalBHAV(ushort opcode, uint group);

		/// <summary>
		/// Returns the the name of all Fileds in an Objd File
		/// </summary>
		/// <param name="type">The Objects type</param>
		ArrayList OBJDDescription(ushort type);		

		/// <summary>
		/// Returns a list of all known Objf Lines
		/// </summary>
		ArrayList StoredObjfLines
		{
			get;
		}

		/// <summary>
		/// Returns the names Operatores in Expression Primitives
		/// </summary>
		ArrayList StoredExpressionOperators
		{
			get;
		}

		/// <summary>
		/// Returns the names of the Data in an Expression Primitive
		/// </summary>
		ArrayList StoredDataNames
		{
			get;
		}

		/// <summary>
		/// Returns the List of known Motives
		/// </summary>
		ArrayList StoredMotives
		{
			get ;
		}

		/// <summary>
		/// Call this to manually initialize the BasePacakhe
		/// </summary>
		void LoadPackage(); 
	}
}
