/***************************************************************************
 *   Copyright (C) 2005 by Theo                                            *
 *   teophilus.gottlieb@gmail.com                                          *
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
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	
	/// <summary>
	/// Extends the basic Neighborhood Plugin by some usefull Features
	/// </summary>
	public class EnhancedNgbh : SimPe.Plugin.ExtNgbh
	{
		public EnhancedNgbh() : base()
		{
			//
			// TODO: Fügen Sie hier die Konstruktorlogik hinzu
			//
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Extended Neighborhood/Memory Wrapper",
				"Quaxi (with extensions developed by Theo)",
				"This File contains the Memories and Inventories of all Sims and Lots that Live in this Neighborhood.",
				1,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ngbh.png"))
				); 
		}		

		class ExceptionBuilder : ApplicationException
		{
			System.Text.StringBuilder msg = new System.Text.StringBuilder();

			public override string Message
			{
				get { return msg.ToString(); }
			}

			public ExceptionBuilder()
			{
			}

			public void Append(string str)
			{
				this.msg.Append(str);
			}

			public void AppendFormat(string format, params object[] args)
			{
				this.msg.AppendFormat(format, args);
			}

		}

		class AliasList : CollectionBase
		{
			public AliasList()
			{
			}

			public int Add(IAlias alias)
			{
				return this.List.Add(alias);
			}

			public bool Contains(IAlias alias)
			{
				return this.List.Contains(alias);
			}

			public bool Contains(uint id)
			{
				return (this.FindById(id) != null);
			}

			public IAlias FindById(uint id)
			{
				IAlias ret = null;
				int i = -1;
				while (++i < this.List.Count)
				{
					IAlias alias = (IAlias)this.List[i];
					if (alias.Id == id)
					{
						ret = alias;
						break;
					}
				}
				return ret;
			}

		}



		public void FixNeighborhoodMemories()
		{
			int deletedCount = 0;
			int fixedCount = 0;

			ExceptionBuilder trace = new ExceptionBuilder();
			trace.Append("Invalid memories found:"+Helper.lbr);
			
			Collections.NgbhSlots slots = this.GetSlots(Data.NeighborhoodSlots.Sims);			

			foreach (NgbhSlot slot in slots)
			{
				SDesc simDesc = FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance[slot.SlotID] as SDesc;
				Collections.NgbhItems simMemories = slot.ItemsB;

				ArrayList memoryToRemove = new ArrayList();
				ArrayList memoryToFix = new ArrayList();


				NgbhItem lastSpamMemory = null;

				for (int j = 0; j < simMemories.Length; j++)
				{
					NgbhItem simMemory = simMemories[j];

					// skip tokens...
					if (simMemory.IsMemory)
					{
						// ...and the lame "Met Unknown" memories
						if (simMemory.SimInstance != 0)
						{
							// fix invalid sim instances
							ushort inst = FileTable.ProviderRegistry.SimDescriptionProvider.GetInstance(simMemory.SimID);
							if (simMemory.SimInstance != inst)
							{
								simMemory.SimInstance = inst;
								memoryToFix.Add(simMemory);
							}
							

							if (simDesc==null)
							{
								memoryToRemove.Add(simMemory);
							}
							
						}

						// it could be spam...
						// collapse duplicate items
						if (simMemory.IsSpam)
						{
							if (
								lastSpamMemory != null &&
								lastSpamMemory.Guid == simMemory.Guid &&
								lastSpamMemory.SimInstance == simMemory.SimInstance
								)
								memoryToRemove.Add(simMemory);

							lastSpamMemory = simMemory;
						}
						else
						{
							lastSpamMemory = null;
						}
						

					}

				} // for simMemories


				if (memoryToRemove.Count > 0 || memoryToFix.Count > 0)
				{
					deletedCount += memoryToRemove.Count;
					fixedCount += memoryToFix.Count;

					trace.AppendFormat("{0} {1}: {2} \r\n", simDesc.SimName, simDesc.SimFamilyName, memoryToRemove.Count + memoryToFix.Count);

					foreach (NgbhItem item in memoryToFix)
						trace.AppendFormat("[FIX]- {0}\r\n", item.ToString());

					NgbhItem[] itemsToRemove = (NgbhItem[])memoryToRemove.ToArray(typeof(NgbhItem));
					foreach (NgbhItem item in itemsToRemove)
						trace.AppendFormat("[DEL]- {0}\r\n", item.ToString());

					trace.Append("\t\r\n\r\n");					
					slot.ItemsB.Remove(itemsToRemove);
				}


			}

			if (deletedCount > 0 || fixedCount > 0)
			{
				Helper.ExceptionMessage(String.Format("Fixed/Deleted {0} invalid memories.", deletedCount+fixedCount), trace);				
			}
		}

		static bool ArrayEquals(ushort[] a, ushort[] b)
		{
			if (a.Length != b.Length)
				return false;

			for (int i = 0; i < a.Length; i++)
				if (a[i] != b[i])
					return false;

			return true;
		}

		public void DeleteMemoryEchoes(Collections.NgbhItems items, uint ownerID)
		{
			int deletedCount = 0;
			ExceptionBuilder trace = new ExceptionBuilder();
			trace.Append("Memories found:"+Helper.lbr);
			
			Collections.NgbhSlots slots = this.GetSlots(Data.NeighborhoodSlots.Sims);
			foreach (NgbhSlot slot in slots)
			{
				// skip my own memories?
				if (ownerID == slot.SlotID) continue;

				SDesc simDesc = FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance[(ushort)slot.SlotID] as SDesc;
				Collections.NgbhItems simMemories = slot.ItemsB;

				Collections.NgbhItems memoryToRemove = new SimPe.Plugin.Collections.NgbhItems(null);
				for (int j = 0; j < simMemories.Length; j++)
				{
					for (int i = 0; i < items.Length; i++)
					{
						NgbhItem item = items[i];
						NgbhItem simMemory = simMemories[j];

						if (
							simMemory.IsMemory && item.IsMemory &&
							simMemory.Guid == item.Guid &&
							ArrayEquals(simMemory.Data, item.Data) &&
							!simMemory.Flags.IsVisible
							)
						{
							memoryToRemove.Add(simMemory); // simMemory.RemoveFromParentB();
						}
					}
				}

				if (memoryToRemove.Count > 0)
				{
					deletedCount += memoryToRemove.Count;
					trace.AppendFormat("{0} {1}: {2} \r\n", simDesc.SimName, simDesc.SimFamilyName, memoryToRemove.Count);
					foreach (NgbhItem item in memoryToRemove)
						trace.AppendFormat("\t- {0}\r\n", item.ToString());
					trace.Append("\t\r\n\r\n");
					slot.ItemsB.Remove(memoryToRemove);
				}

			}

			if (deletedCount > 0)
				Message.Show(String.Format("Deleted {0} memories from the sim pool", deletedCount)+Helper.lbr+Helper.lbr+trace.ToString());
		}
	}


	namespace NgbhMetaData
	{
		internal sealed class Memory
		{
			Memory()
			{
			}

			/// <summary>
			/// A memory's subject can be of three different types
			/// </summary>
			const ushort
				Sim = 0,
				Food = 1,
				Career = 2;

			static Hashtable memorySubjectType = BuildMemorySubjectTypeCache();
			static ArrayList spamGuid = BuildSpamMemoryList();

			static Hashtable BuildMemorySubjectTypeCache()
			{
				Hashtable ret = new Hashtable();

				// reached top of $career
				ret[0x2323232] = Career;

				// learned how to make $food
				ret[0x3248932] = Food;
				// burned $food
				ret[0x2378482] = Food;

				return ret;
			}
			static ArrayList BuildSpamMemoryList()
			{
				ArrayList ret = new ArrayList();

				// Had family reunion
				ret.Add(0x2DD3B15Fu);

				// got A+ 
				ret.Add(0x4CAB11D3u);

				// subject got A+
				ret.Add(0x8DB6545Du);

				// got D
				ret.Add(0xEDB65A89u);

				// subject got D
				ret.Add(0X6DB654ACu);

				// subject got abducted
				ret.Add(0xEDD35A61u);

				// vermin!
				ret.Add(0x6CAB0E82u);

				return ret;
			}

			/// <summary>
			/// Returns an identifier for the type of Subject the memory refers to.
			/// </summary>
			public static ushort GetSubjectType(NgbhItem item)
			{
				return GetSubjectType(item.Guid);
			}

			public static ushort GetSubjectType(uint itemGuid)
			{
				if (memorySubjectType.ContainsKey(itemGuid))
					return (ushort)memorySubjectType[itemGuid];
				return 0;
			}

			public static bool IsSpamMemory(NgbhItem item)
			{
				return IsSpamMemory(item.Guid);
			}

			public static bool IsSpamMemory(uint guid)
			{
				return spamGuid.Contains(guid);
			}

		}



		internal enum FoodType : uint
		{
			Unknown = 0x0000,
			InstantMeal,

			//breakfast
			Cereal,
			Pancake,
			Omelette,


			// lunch
			TVDinner,
			LunchSandwich,
			GrilledCheese,
			Hamburger,
			Hotdog,
			MacAndCheese,
			Chilli,

			//dinner
			Spaghetti,
			Lobster,
			PorkChop,
			Salmon,
			Turkey,


			// dessert
			Gelatin

		}
	}
}

