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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// This links to th eextended GUI for the Neighborhood Wrapper
	/// </summary>
	public class ExtNgbh : Ngbh
	{

		#region Value Descriptors, used for Badges and Hiden Skills
		static NgbhValueDescriptor[] vd;
		public static NgbhValueDescriptor[] ValueDescriptors
		{
			get 
			{
				if (vd==null) CreateValueDescriptors();
				return vd;
			}
		}

		protected static void CreateValueDescriptors()
		{
			System.Collections.ArrayList list = new ArrayList();
			foreach (SimPe.Cache.MemoryCacheItem mci in SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.List)
			{
				if (mci.IsBadge) 				
					list.Add(new NgbhValueDescriptor(mci.Name, true, NgbhValueDescriptorType.Badge, mci.Guid, 0, 0, 1000));				
			}

			list.AddRange( new NgbhValueDescriptor[] {
														 new NgbhValueDescriptor("Dance Skill", true, NgbhValueDescriptorType.Skill, 0xda265f4, 0, 0, 1000),
														 new NgbhValueDescriptor("Dance Experience", true, NgbhValueDescriptorType.Skill, 0x6fe7e453, 0, 0, 1000),
														 new NgbhValueDescriptor("Meditation Skill", false, NgbhValueDescriptorType.Skill, 0x4d8b0cc3, 2, 0, 1000),
														 new NgbhValueDescriptor("Study Skill", false, NgbhValueDescriptorType.Skill, 0x4d8b0cc3, 3, 0, 1000),
														 //new NgbhValueDescriptor("Swimming Skill", false, NgbhValueDescriptorType.Skill, 0x4d8b0cc3, 4, 0, 1000),
														 new NgbhValueDescriptor("Learned to walk", false, NgbhValueDescriptorType.ToddlerSkill, 0x4ddf0e12, 1, 0, 1000, 4),								
														 new NgbhValueDescriptor("Learned to talk", false, NgbhValueDescriptorType.ToddlerSkill, 0x4ddf0e12, 2, 0, 1000, 4),
														 new NgbhValueDescriptor("Pottytrained", false, NgbhValueDescriptorType.ToddlerSkill, 0x4ddf0e12, 3, 0, 1000, 4)
			});

			vd = new NgbhValueDescriptor[list.Count];
			list.CopyTo(vd);			
		}
		#endregion

		public ExtNgbh() : base(FileTable.ProviderRegistry)
		{			
		}

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new ExtNgbhUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Extended Neighborhood/Memory Wrapper",
				"Quaxi",
				"This File contains the Memories and Inventories of all Sims and Lots that Live in this Neighborhood.",
				2,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ngbh.png"))
				); 
		}
		#endregion		
	}
}
