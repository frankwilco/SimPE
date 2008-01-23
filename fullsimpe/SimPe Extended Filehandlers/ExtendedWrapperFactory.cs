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
	class HelpTopic : IHelp
	{
		#region IHelp Member

		public void ShowHelp(ShowHelpEventArgs e)
		{
			Message.Show("Executed");
		}

		public override string ToString()
		{
			return "Test\\My Custom Help";
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		#endregion

	}

	class HelpTopic2 : IHelp
	{
		#region IHelp Member

		public void ShowHelp(ShowHelpEventArgs e)
		{
			Message.Show("Executed");
		}

		public override string ToString()
		{
			return "Test\\My Custom Help2";
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		#endregion

	}

	/// <summary>
	/// The Wrapper Factory for Default Wrappers that ship with SimPe
	/// </summary>
	public class ExtendedWrapperFactory : AbstractWrapperFactory, SimPe.Interfaces.Plugin.IHelpFactory
	{
		#region AbstractWrapperFactory Member
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{				
				IWrapper[] wrappers = {
										  new SimPe.PackedFiles.Wrapper.ExtObjd(),
										  new SimPe.PackedFiles.Wrapper.ObjLua(),
										  new SimPe.PackedFiles.Wrapper.Creg()
									  };
				return wrappers;
			}
		}

		#endregion

		#region IHelpFactory Member

		public IHelp[] KnownHelpTopics
		{
			get
			{
				return new IHelp[]{
									  /*new HelpTopic(),
									  new HelpTopic2()*/
								  };
			}
		}

		#endregion
	}
}
