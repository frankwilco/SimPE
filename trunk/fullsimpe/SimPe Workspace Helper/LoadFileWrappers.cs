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
using System.Reflection;
using System.Collections;
using System.IO;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;

namespace SimPe
{
	public class PackageArg : System.EventArgs 
	{
		Interfaces.Files.IPackageFile package;
		public Interfaces.Files.IPackageFile Package 
		{
			get { return package; }
			set { package = value; }
		}

		Interfaces.Files.IPackedFileDescriptor pfd;
		public Interfaces.Files.IPackedFileDescriptor FileDescriptor 
		{
			get { return pfd; }
			set { pfd = value; }
		}

		Interfaces.Plugin.IToolResult res;
		public Interfaces.Plugin.IToolResult Result 
		{
			get { return res; }
			set { res = value; }
		}
	}

	public class ToolMenuItem  : System.Windows.Forms.MenuItem
	{
		

		ITool tool;
		Interfaces.Files.IPackedFileDescriptor pfd;
		Interfaces.Files.IPackageFile package;
		/// <summary>
		/// null or a Function to call when the Pacakge was changed by an Tool Plugin
		/// </summary>
		EventHandler chghandler;

		EventHandler ChangeHandler 
		{
			get { return chghandler; }
			set {chghandler = value; }
		}

		public ToolMenuItem(ITool tool, EventHandler chghnd) 
		{
			this.tool = tool;


			string name = tool.ToString();
			string[] parts = name.Split("\\".ToCharArray());
			name = SimPe.Localization.GetString(parts[parts.Length-1]);
			this.Text = name;

			Click += new EventHandler(ClickItem);
			chghandler = chghnd;
		}
		
		private void ClickItem(object sender, System.EventArgs e) 
		{
			try 
			{
				if (tool.IsEnabled(pfd, package)) 
				{
					SimPe.Interfaces.Plugin.IToolResult tr = tool.ShowDialog(ref pfd, ref package);
					WaitingScreen.Stop();
					if (tr.ChangedAny) 
					{
						PackageArg p = new PackageArg();
						p.Package = package;
						p.FileDescriptor = pfd;
						p.Result = tr;
						if (chghandler!=null) chghandler(this, p);
					}
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to Start ToolPlugin.", ex);
			}
		}

		public override string ToString()
		{
			try 
			{
				return tool.ToString();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to Load ToolPlugin.", ex);
			}

			return "Plugin Error";
		}

		public Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get { return pfd; }
			set { pfd = value; }
		}

		public Interfaces.Files.IPackageFile Package
		{
			get { return package; }
			set { package = value; }
		}

		public void UpdateEnabledState()
		{
			try 
			{
				Enabled = tool.IsEnabled(pfd, package);
			} 
			catch (Exception)
			{
				Enabled = false;
			}
		}
	}

	/// <summary>
	/// Class that can be used to Load external Filewrappers int the given Registry
	/// </summary>
	public class LoadFileWrappers
	{
		/// <summary>
		/// The Type Registry
		/// </summary>
		IWrapperRegistry reg;

		/// <summary>
		/// The Tool Registry
		/// </summary>
		IToolRegistry treg;

		System.Collections.ArrayList ignore;

		void CreateIgnoreList(){
			ignore = new ArrayList();
			ignore.Add("simpe.3d.plugin.dll");
		}

		/// <summary>
		/// Constructor of The class
		/// </summary>
		/// <param name="registry">
		/// Registry the External Data should be added to
		/// </param>
		/// <param name="toolreg">Registry the tools should be added to</param>
		public LoadFileWrappers(IWrapperRegistry registry, IToolRegistry toolreg)
		{
			CreateIgnoreList();

			reg = registry;
			treg = toolreg;
		}

		/// <summary>
		/// Looks in the given Folder for Files that can be added to the registry
		/// </summary>
		/// <param name="folder">The Folder you want to scan</param>
		public void Scan(string folder) 
		{
			if (!Directory.Exists(folder)) return;

			string[] files = System.IO.Directory.GetFiles(folder, "*.plugin.dll");

			foreach(string file in files) 
			{
				string flname = System.IO.Path.GetFileName(file).Trim().ToLower();

				//this is a manua List of Wrappers that are know to cause Problems
				if (ignore.Contains(flname)) continue;

				try 
				{
					IWrapperFactory factory = LoadWrapperFactory(file);
					if (factory!=null) reg.Register(factory);
				
				} 
				catch (Exception ex) 
				{
					Exception e = new Exception("Unable to load WrapperFactory", new Exception("Invalid Interface in "+file, ex));
					reg.Register(new SimPe.PackedFiles.Wrapper.ErrorWrapper(file, ex));
#if DEBUG
					Helper.ExceptionMessage(ex);
#endif
				}

				try 
				{
					IToolFactory tfactory = LoadToolFactory(file);
					if (tfactory!=null) treg.Register(tfactory);
				} 
				catch (Exception ex) 
				{
					Exception e = new Exception("Unable to load ToolFactory", new Exception("Invalid Interface in "+file, ex));
#if DEBUG
					Helper.ExceptionMessage(e);
#endif

				}
			}
		}

		/// <summary>
		/// Tries to load the IWrapperFactory from the passed File
		/// </summary>
		/// <param name="file">The File where to look in</param>
		/// <returns>null or a Wrapper Factory</returns>
		public static IWrapperFactory LoadWrapperFactory(string file)
		{
			Type interfaceType = typeof(IWrapperFactory);
			object o = LoadPlugin(file, interfaceType);

			if (o!=null) return (IWrapperFactory)o;
			else return null;
		}

		/// <summary>
		/// Tries to load the IWrapperFactory from the passed File
		/// </summary>
		/// <param name="file">The File where to look in</param>
		/// <returns>null or a Wrapper Factory</returns>
		public static IToolFactory LoadToolFactory(string file)
		{
			Type interfaceType = typeof(IToolFactory);
			object o = LoadPlugin(file, interfaceType);

			if (o!=null) return (IToolFactory)o;
			else return null;
		}

		/// <summary>
		/// Loads the First Class form a File implementing the passed Interface
		/// </summary>
		/// <param name="file">The File the Class is stored in</param>
		/// <param name="interfaceType">The Type of the FIle</param>
		/// <returns>The Class Implementing the given type or null if none was found</returns>
		public static object LoadPlugin(string file, Type interfaceType)
		{
			if (!File.Exists(file)) return null;
            if (Helper.LocalMode == Helper.RunModes.LocalNoPlugins)
                if (!Helper.CanLoadPlugin(file)) return null;

			AssemblyName myAssemblyName;
			try 
			{
				myAssemblyName = AssemblyName.GetAssemblyName(file);
			} 
			catch 
			{
				return null;
			}
			
			Assembly a = System.Reflection.Assembly.LoadFrom(file);
			try 
			{
				Type[] mytypes = a.GetTypes();

				foreach(Type t in mytypes)
				{
					Type mit = t.GetInterface(interfaceType.FullName);
					if (mit != null) 
					{
					
						object obj = Activator.CreateInstance(t);
						return obj;
					
					}
				}
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
			
			return null;
		}

		/// <summary>
		/// Loads the First Class form a File implementing the passed Interface
		/// </summary>
		/// <param name="file">The File the Class is stored in</param>
		/// <param name="interfaceType">The Type of the FIle</param>
		/// <returns>All Classes implementing the given interface</returns>
		public static object[] LoadPlugins(string file, Type interfaceType)
		{
			return LoadPlugins(file, interfaceType, new object[0]);
		}

		/// <summary>
		/// Loads the First Class form a File implementing the passed Interface
		/// </summary>
		/// <param name="file">The File the Class is stored in</param>
		/// <param name="interfaceType">The Type of the FIle</param>
		/// <param name="args">nlist of argument you want to pass to the constructor</param>
		/// <returns>All Classes implementing the given interface</returns>
		public static object[] LoadPlugins(string file, Type interfaceType, object[] args)
		{
            if (!File.Exists(file)) return new object[0]; 
            if (Helper.LocalMode == Helper.RunModes.LocalNoPlugins)
                if (!Helper.CanLoadPlugin(file)) return new object[0];

			AssemblyName myAssemblyName;
			try 
			{
				myAssemblyName = AssemblyName.GetAssemblyName(file);
			} 
			catch 
			{
				return new object[0];
			}

			Assembly a = System.Reflection.Assembly.LoadFrom(file);
			return LoadPlugins(a, interfaceType, args);
		}

		/// <summary>
		/// Loads the First Class form a File implementing the passed Interface
		/// </summary>
		/// <param name="file">The File the Class is stored in</param>
		/// <param name="interfaceType">The Type of the FIle</param>
		/// <param name="args">nlist of argument you want to pass to the constructor</param>
		/// <returns>All Classes implementing the given interface</returns>
		public static object[] LoadPlugins(Assembly a, Type interfaceType, object[] args)
		{
			if (a==null) return new object[0];

			ArrayList list = new ArrayList();
			try 
			{
				Type[] mytypes = a.GetTypes();

				foreach(Type t in mytypes)
				{
					if (t.IsInterface || t.IsAbstract) continue;

					try 
					{
						Type mit = t.GetInterface(interfaceType.FullName);
						if (mit != null) 
						{
							try 
							{
								object obj = null;
								try
								{
									obj = Activator.CreateInstance(t, args);
								} 
								catch 
								{
									//could crtea the Object with the passed Argument List, 
									//try to call the default Cosntructor
									obj = Activator.CreateInstance(t);
								}

								if (obj!=null) list.Add(obj);
							}
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("Unable to load "+t.Name+".", new Exception("Unable to load "+t.Name+" from '"+a.ToString()+"'.", ex));
							}
						}
					} 
					catch (Exception ex)
					{
						Helper.ExceptionMessage("Unable to get Interface for "+t.Name+".",  ex);
					}
				}
			
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to load Plugin \""+a.FullName+"\".", ex);
			}

			object[] o = new object[list.Count];
			list.CopyTo(o);
			return o;
		}

		#region Old GUI
		/// <summary>
		/// Adds the Tool Plugins to the passed menu
		/// </summary>
		/// <param name="mi">The Menu you want to add Items to</param>
		/// <param name="chghandler">A Function to call when the Package was chaged by a Tool</param>
		public void AddMenuItems(System.Windows.Forms.MenuItem mi, System.EventHandler chghandler) 
		{
			ITool[] tools = treg.Tools;
			foreach (SimPe.Interfaces.ITool tool in tools)
			{
				ToolMenuItem item = new ToolMenuItem(tool, chghandler);
				mi.MenuItems.Add(item);
			}

			foreach (SimPe.Interfaces.IToolPlugin tool in treg.Docks)
			{
				if (tool.GetType().GetInterface("SimPe.Interfaces.ITool", true) == typeof(SimPe.Interfaces.ITool)) 
				{
					ToolMenuItem item = new ToolMenuItem((SimPe.Interfaces.ITool)tool, chghandler);
					mi.MenuItems.Add(item);
				}
			}

			EnableMenuItems(mi, null, null);
		}

		/// <summary>
		/// Set the Enabled state of the Toll MenuItems
		/// </summary>
		/// <param name="mi"></param>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		public void EnableMenuItems(System.Windows.Forms.MenuItem mi, Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package)
		{
			foreach(System.Windows.Forms.MenuItem item in mi.MenuItems) 
			{
				try 
				{
					ToolMenuItem tmi = (ToolMenuItem)item;
					tmi.Package = package;
					tmi.FileDescriptor = pfd;
					tmi.UpdateEnabledState();
				} 
				catch (Exception) {}
			}
		}
		#endregion
	}
}
