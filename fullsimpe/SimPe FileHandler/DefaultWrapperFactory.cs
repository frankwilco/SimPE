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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;

namespace SimPe.PackedFiles.Wrapper.Factory
{

	/// <summary>
	/// The Wrapper Factory for Default Wrappers that ship with SimPe
	/// </summary>
	public class DefaultWrapperFactory : AbstractWrapperFactory, SimPe.Updates.IUpdatablePlugin
	{
		#region AbstractWrapperFactory Member
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{		
				if (Helper.StartedGui == Executable.Classic) 
				{
					IWrapper[] wrappers = {
											  new SimPe.PackedFiles.Wrapper.Picture(),
											  new SimPe.PackedFiles.Wrapper.Xml(),										 
											  new SimPe.PackedFiles.Wrapper.Fami(this.LinkedProvider.SimNameProvider),											  
											  new SimPe.PackedFiles.Wrapper.SRel(),
											  new SimPe.PackedFiles.Wrapper.Cpf(),
											  new SimPe.PackedFiles.Wrapper.FamilyTies(this.LinkedProvider.SimNameProvider),
											  new SimPe.PackedFiles.Wrapper.Nref()
										  };
					return wrappers;
				} 
				else 
				{
					IWrapper[] wrappers = {
											  new SimPe.PackedFiles.Wrapper.Picture(),
											  new SimPe.PackedFiles.Wrapper.Xml(),
										 
											  new SimPe.PackedFiles.Wrapper.Fami(this.LinkedProvider.SimNameProvider),											 										  
											  new SimPe.PackedFiles.Wrapper.Cpf(),
/*#if DEBUG
											  new SimPe.PackedFiles.Wrapper.SRel(),	
											  new SimPe.PackedFiles.Wrapper.SDesc(this.LinkedProvider.SimNameProvider, this.LinkedProvider.SimFamilynameProvider, this.LinkedProvider.SimDescriptionProvider),											  
											  new SimPe.PackedFiles.Wrapper.Objd(this.LinkedProvider.OpcodeProvider),
											  new SimPe.PackedFiles.Wrapper.FamilyTies(this.LinkedProvider.SimNameProvider),
#endif	*/
											  new SimPe.PackedFiles.Wrapper.Nref()
										  };
					return wrappers;
				}
				
			}
		}

		#endregion


        #region IUpdatablePlugin Member

        public SimPe.Updates.UpdateInfo GetUpdateInformation()
        {
            return new SimPe.Updates.UpdateInfo(10, "DefaultWrapperFactory", "Default SimPE Plugins");
        }

        #endregion
    }
}
