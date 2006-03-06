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
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;


namespace SimPe.PackedFiles
{
	/// <summary>
	/// Holds the index of available Handlers
	/// </summary>
	/// <remarks>
	/// The TypeRegistry is the main Communication Point for all Plugins, so if you want to 
	/// provide Infoformations from the Main Application to the Plugins, you have to use the 
	/// TypeRegistry!
	/// </remarks>	 
	public sealed class TypeRegistry : IWrapperRegistry, IProviderRegistry, IToolRegistry
	{		
		/// <summary>
		/// Coontains all available handler Objects
		/// </summary>
		/// <remarks>All handlers are stored as IPackedFileHandler Objects</remarks>
		ArrayList handlers;

		/// <summary>
		/// Contains all available Tool Plugins
		/// </summary>
		ArrayList tools, toolsp;

		/// <summary>
		/// Contains all available dockable Tool Plugins
		/// </summary>
		ArrayList dtools;

		/// <summary>
		/// Contains all available action Tool Plugins
		/// </summary>
		ArrayList atools;

		/// <summary>
		/// Contains all available Listeners
		/// </summary>
		SimPe.Collections.InternalListeners listeners;

		/// <summary>
		/// Used to access the Windows Registry
		/// </summary>
		Registry reg;

		/// <summary>
		/// Wrapper ImageList
		/// </summary>
		System.Windows.Forms.ImageList il;

		/// <summary>
		/// Constructor of the class
		/// </summary>
		public TypeRegistry()
		{
			reg = Helper.WindowsRegistry;
			handlers = new ArrayList();		
			opcodeprovider = new SimPe.Providers.Opcodes();
			simfamilynames = new SimPe.Providers.SimFamilyNames();
			simnames = new SimPe.Providers.SimNames(null); //opcodeprovider
			sdescprovider = new SimPe.Providers.SimDescriptions(simnames, simfamilynames);
			skinprovider = new SimPe.Providers.Skins();
			lotprov = new SimPe.Providers.LotProvider();
			
			tools = new ArrayList();
			toolsp = new ArrayList();
			dtools = new ArrayList();
			atools = new ArrayList();
			listeners = new SimPe.Collections.InternalListeners();

			il = new System.Windows.Forms.ImageList();
			il.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;

			il.Images.Add(System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Providers.empty.png")));
			il.Images.Add(System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Providers.binary.png")));									
		}

		#region IWrapperRegistry Member
		public void Register(IWrapper wrapper)
		{
			
			if (wrapper!=null)
				if (!handlers.Contains(wrapper)) 
				{
					((SimPe.Interfaces.IWrapper)wrapper).Priority = reg.GetWrapperPriority(((SimPe.Interfaces.IWrapper)wrapper).WrapperDescription.UID);
					handlers.Add((SimPe.Interfaces.Plugin.IFileWrapper)wrapper);
					if (wrapper.WrapperDescription is AbstractWrapperInfo) 
					{
						if (wrapper.WrapperDescription.Icon!=null) 
						{
						
							((AbstractWrapperInfo)wrapper.WrapperDescription).IconIndex = il.Images.Count;
							il.Images.Add(wrapper.WrapperDescription.Icon);
						}
						else 
							((AbstractWrapperInfo)wrapper.WrapperDescription).IconIndex = 1;				
					}
				}
		}

		public void Register(IWrapper[] wrappers, IWrapper[] guiwrappers)
		{
			if (wrappers!=null && guiwrappers==null)
				foreach (IWrapper wrapper in wrappers) Register(wrapper);
			else if (wrappers!=null && guiwrappers!=null) 
			{
				for (int i=0; i<wrappers.Length; i++) 
				{
					IWrapper wrapper = wrappers[i];
					//make sure whe have two instances of each Wrapper otherwise, 
					//AbstractWrapper.ResoureceName could corrupt a open Resource
					if (!wrapper.AllowMultipleInstances && wrapper is AbstractWrapper) 					
						((AbstractWrapper)wrapper).SingleGuiWrapper = (IFileWrapper)guiwrappers[i];
					
					Register(wrapper);Register(wrapper);
				}
			}
		}

		/// <summary>
		/// Registers all Wrappers supported by the Factory
		/// </summary>
		/// <param name="factory">The Factory Elements you want to register</param>
		/// <remarks>The wrapper must only be added if the Registry doesnt already contain it</remarks>
		public void Register(IWrapperFactory factory) 
		{
			factory.LinkedRegistry = this;
			factory.LinkedProvider = this;
			Register(factory.KnownWrappers, factory.KnownWrappers);
		}

		public IWrapper[] Wrappers
		{
			get 
			{
				IWrapper[] wrappers = AllWrappers;
				ArrayList wrap = new ArrayList();

				foreach (IWrapper w in wrappers) 
				{
					if (w.Priority>=0) wrap.Add(w);
				}

				wrappers = new IWrapper[wrap.Count];
				wrap.CopyTo(wrappers);
				return wrappers;
			}
		}


		public IWrapper[] AllWrappers
		{
			get 
			{
				IWrapper[] wrappers = new IWrapper[handlers.Count];
				handlers.CopyTo(wrappers);

				//sort the wrapper by priority
				for (int i=0; i<wrappers.Length-1; i++) 
				{
					for (int k=i+1; k<wrappers.Length; k++) 
					{
						if (Math.Abs(wrappers[i].Priority) > Math.Abs(wrappers[k].Priority)) 
						{
							IWrapper dum = wrappers[i];
							wrappers[i] = wrappers[k];
							wrappers[k] = dum;
						}
					}
				}
				return wrappers;
			}
		}

		/// <summary>
		/// Contains a Listing of all available Wrapper Icons
		/// </summary>
		public System.Windows.Forms.ImageList WrapperImageList
		{
			get {return il; }
		}		
		#endregion

		/// <summary>
		/// Returns the first Handler capable of processing a File of the given Type
		/// </summary>
		/// <param name="type">The Type of the PackedFile</param>
		/// <returns>The assigned Handler or null if none was found</returns>
		public IPackedFileWrapper FindHandler(uint type)
		{
			IWrapper[] wrappers = this.Wrappers;
			foreach (SimPe.Interfaces.Plugin.IFileWrapper h in wrappers)
			{
				foreach(uint atype in h.AssignableTypes) 
				{
					if (atype==type) return h;
				}
			}

			return null;
		}

		/// <summary>
		/// Returns the first Handler capable of processing a File
		/// </summary>
		/// <param name="data">The Data of the PackedFile</param>
		/// <returns>The assigned Handler or null if none was found</returns>
		/// <remarks>
		/// A handler is assigned if the first bytes of the Data are equal 
		/// to the signature provided by the Handler
		/// </remarks>
		public SimPe.Interfaces.Plugin.IFileWrapper FindHandler(Byte[] data)
		{
			IWrapper[] wrappers = this.Wrappers;
			foreach (SimPe.Interfaces.Plugin.IFileWrapper h in wrappers)
			{
				if (h.FileSignature==null) continue;
				if (h.FileSignature.Length==0) continue;

				bool check = true;
				for (int i=0; i<h.FileSignature.Length; i++)
				{
					if (i>=data.Length) break;
					if (data[i]!=h.FileSignature[i]) 
					{
						check = false;
						break;
					}
				}

				if (check==true) return h;
			}

			return null;
		}

		#region IProviderRegistry Member

		SimPe.Providers.LotProvider lotprov;
		public SimPe.Interfaces.Providers.ILotProvider LotProvider
		{
			get {return lotprov;}
		}

		/// <summary>
		/// Provider for Sim Names
		/// </summary>
		SimPe.Interfaces.Providers.ISimNames simnames;

		/// <summary>
		/// Returns the Provider for SimNames
		/// </summary>
		public SimPe.Interfaces.Providers.ISimNames SimNameProvider 
		{
			get { return simnames; }
		}

		/// <summary>
		/// Provider for Sim Family Names
		/// </summary>
		SimPe.Interfaces.Providers.ISimFamilyNames simfamilynames;

		/// <summary>
		/// Returns the Provider for Sim Family Names
		/// </summary>
		public SimPe.Interfaces.Providers.ISimFamilyNames  SimFamilynameProvider 
		{
			get { return simfamilynames; }
		}

		/// <summary>
		/// Provider for SimDescription Files
		/// </summary>
		SimPe.Interfaces.Providers.ISimDescriptions sdescprovider;

		/// <summary>
		/// Returns the Provider for SimDescription Files
		/// </summary>
		public SimPe.Interfaces.Providers.ISimDescriptions SimDescriptionProvider 
		{
			get { return sdescprovider;	}
		}

		/// <summary>
		/// Provider for Opcode Names
		/// </summary>
		SimPe.Interfaces.Providers.IOpcodeProvider opcodeprovider;

		/// <summary>
		/// Returns the Provider for Opcode Names
		/// </summary>
		public SimPe.Interfaces.Providers.IOpcodeProvider OpcodeProvider
		{
			get { return opcodeprovider; }
		}

		Interfaces.Providers.ISkinProvider skinprovider;

		/// <summary>
		/// Returns the Provider for Skin Data
		/// </summary>
		public Interfaces.Providers.ISkinProvider SkinProvider
		{
			get { return skinprovider; }
		}
		#endregion

		#region IToolRegistry Member
		public void Register(IToolPlugin tool)
		{
			
				if (tool!=null)
					if (tool.GetType().GetInterface("SimPe.Interfaces.IDockableTool", true) == typeof(SimPe.Interfaces.IDockableTool)) 
					{
						if (!dtools.Contains(tool)) 					
							dtools.Add((SimPe.Interfaces.IDockableTool)tool);	
					} 
					else if (tool.GetType().GetInterface("SimPe.Interfaces.IToolAction", true) == typeof(SimPe.Interfaces.IToolAction)) 
					{
						if (!atools.Contains(tool)) 					
							atools.Add((SimPe.Interfaces.IToolAction)tool);	
					} 					
					else if  (tool.GetType().GetInterface("SimPe.Interfaces.IToolPlus", true) == typeof(SimPe.Interfaces.IToolPlus)) 
					{
						if (!toolsp.Contains(tool)) 					
							toolsp.Add((SimPe.Interfaces.IToolPlus)tool);	
					} 
					else if (Helper.StartedGui != Executable.Classic && tool.GetType().GetInterface("SimPe.Interfaces.IListener", true) == typeof(SimPe.Interfaces.IListener)) 
					{
						if (!listeners.Contains((SimPe.Interfaces.IListener)tool)) 					
							listeners.Add((SimPe.Interfaces.IListener)tool);	
					} 
					else if (tool.GetType().GetInterface("SimPe.Interfaces.ITool", true) == typeof(SimPe.Interfaces.ITool)) 
					{
						if (!tools.Contains(tool)) 					
							tools.Add((SimPe.Interfaces.ITool)tool);										  
					}
					
			
		}		

		public void Register(IToolPlugin[] tools)
		{
			if (tools!=null)
				foreach (IToolPlugin tool in tools) Register(tool);
		}

		public void Register(IToolFactory factory)
		{
			factory.LinkedRegistry = this;
			factory.LinkedProvider = this;
			string s = SimPe.Localization.GetString("Unknown");
			try 
			{
				s = factory.FileName;
				Register(factory.KnownTools);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to load Tool \""+s+"\". You Probaly have a Plugin/Tool installed, that is not compatible with the current SimPE Release.", ex);
			}
		}

		public SimPe.Collections.Listeners Listeners
		{
			get
			{
				return listeners;
			}
		}
			

		public ITool[] Tools
		{
			get
			{
				ITool[] rtools = new ITool[tools.Count];
				tools.CopyTo(rtools);
				return rtools;
			}
		}

		public IToolPlus[] ToolsPlus
		{
			get
			{
				IToolPlus[] rtools = new IToolPlus[toolsp.Count];
				toolsp.CopyTo(rtools);
				return rtools;
			}
		}

		public IDockableTool[] Docks
		{
			get
			{
				IDockableTool[] rtools = new IDockableTool[dtools.Count];
				dtools.CopyTo(rtools);
				return rtools;
			}
		}

		public IToolAction[] Actions
		{
			get
			{
				IToolAction[] rtools = new IToolAction[atools.Count];
				atools.CopyTo(rtools);
				return rtools;
			}
		}

		#endregion
	}
}

namespace SimPe.Collections 
{
	internal class InternalListeners : SimPe.Collections.Listeners
	{		
		internal InternalListeners() : base() {}
		internal void Add(IListener lst)
		{
			list.Add(lst);
		}

		internal void Clear() 
		{
			list.Clear();
		}		
	}
}
