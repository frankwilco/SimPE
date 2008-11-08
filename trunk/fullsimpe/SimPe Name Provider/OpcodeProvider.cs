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
using System.IO;
using System.Collections;
using SimPe.Data;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Providers
{
	/// <summary>
	/// Provides an Alias Matching a SimID with it's Name
	/// </summary>
	public class Opcodes : SimCommonPackage, SimPe.Interfaces.Providers.IOpcodeProvider
	{
		/// <summary>
		/// List of known Opcode Names
		/// </summary>
		private ArrayList names;	
		
		/// <summary>
		/// List of known Operands for Expressions
		/// </summary>
		private ArrayList operands;

		/// <summary>
		/// List of known Data Owners
		/// </summary>
		private ArrayList dataowners;

		/// <summary>
		/// List aof all Fields contained in an ObjD File
		/// </summary>
		private ArrayList objddesc;

		/// <summary>
		/// List of all Motives
		/// </summary>
		private ArrayList motives;

		/// <summary>
		/// List of Objf Lines
		/// </summary>
		private ArrayList objf;

		/// <summary>
		/// List of all Available Memories
		/// </summary>
		private Hashtable memories;

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public Opcodes() : base(null) 
		{
			
		}

		/// <summary>
		/// Creates an Alias out of a Memory File
		/// </summary>
		/// <returns>the IAlias Object</returns>
		protected static void ProcessMemoryFile(Interfaces.Files.IPackedFileDescriptor pfd, SimPe.PackedFiles.Wrapper.ExtObjd objd, SimPe.PackedFiles.Wrapper.ExtObjd objd_pr, SimPe.PackedFiles.Wrapper.Str str, ArrayList list, ref Hashtable memories, SimPe.Interfaces.Files.IPackageFile BasePackage) 
		{
				

		}
		/// <summary>
		/// Loads Memory Files form the Object Package
		/// </summary>
		public void LoadMemories() 
		{
			memories = new Hashtable();
			//if (BasePackage==null) return;

			Registry reg = Helper.WindowsRegistry;
			ArrayList list = new ArrayList();
			Interfaces.Files.IPackedFileDescriptor pfd;					
			
			SimPe.PackedFiles.Wrapper.ExtObjd objd= new SimPe.PackedFiles.Wrapper.ExtObjd();
			SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
			
			FileTable.FileIndex.Load();
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileDiscardingGroup(Data.MetaData.OBJD_FILE, 0x00000000000041A7);

			string max = " / "+items.Length.ToString();
			int ct = 0;
			if (items.Length!=0) //found anything?
			{			
				bool wasrunning = WaitingScreen.Running;
				WaitingScreen.Wait();
                try
                {
                    foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
                    {
                        ct++;
                        if (ct % 137 == 1) WaitingScreen.UpdateMessage(ct.ToString() + max);
                        pfd = item.FileDescriptor;

                        string name = "";
                        objd.ProcessData(item);

                        if (memories.Contains(objd.Guid)) continue;
                        try
                        {
                            Interfaces.Scenegraph.IScenegraphFileIndexItem[] sitems = FileTable.FileIndex.FindFile(Data.MetaData.CTSS_FILE, pfd.Group, objd.CTSSInstance, null);
                            if (sitems.Length > 0)
                            {
                                str.ProcessData(sitems[0]);
                                SimPe.PackedFiles.Wrapper.StrItemList strs = str.LanguageItems(Helper.WindowsRegistry.LanguageCode);
                                if (strs.Length > 0) name = strs[0].Title;


                                //not found?
                                if (name == "")
                                {
                                    strs = str.LanguageItems(1);
                                    if (strs.Length > 0) name = strs[0].Title;
                                }
                            }
                        }
                        catch (Exception) { }
                        //still no name?
                        if (name == "") name = objd.FileName;

#if DEBUG
                        IAlias a = new Alias(objd.Guid, name, "{1}: {name} (0x{id})");
#else
							IAlias a = new Alias(objd.Guid, name, "{1}: {name}");
#endif

                        object[] o = new object[3];

                        o[0] = pfd;
                        o[1] = (Data.ObjectTypes)objd.Type;
                        o[2] = null;
                        SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
                        Interfaces.Scenegraph.IScenegraphFileIndexItem[] iitems = FileTable.FileIndex.FindFile(Data.MetaData.SIM_IMAGE_FILE, pfd.Group, 1, null);
                        if (iitems.Length > 0)
                        {
                            pic.ProcessData(iitems[0]);
                            System.Drawing.Image img = pic.Image;
                            o[2] = img;

                            WaitingScreen.Update(img, ct.ToString() + max);
                        }
                        a.Tag = o;
                        if (!memories.Contains(objd.Guid)) memories.Add(objd.Guid, a);

                    } //foreach item								
                }
                finally { if (!wasrunning) WaitingScreen.Stop(); }
			} // if items>0
			//System.Threading.Thread.CurrentThread.Priority = System.Threading.ThreadPriority.Normal;
		}


		/// <summary>
		/// Loads String Resource from the Package
		/// </summary>
		/// <param name="list">The List where you want to store the Resource</param>
		/// <param name="instance">The Instance of the TextFile</param>
		/// <param name="lang">The Language Number</param>
		public void LoadData(ref ArrayList list, ushort instance, ushort lang) 
		{
			list = new ArrayList();
			if (BasePackage==null) return;

			IPackedFileDescriptor pfd = BasePackage.FindFile(Data.MetaData.STRING_FILE, 0x00000000, 0x7FE59FD0, instance);
			SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
			str.ProcessData(pfd, BasePackage);
			SimPe.PackedFiles.Wrapper.StrItemList sis = str.FallbackedLanguageItems((SimPe.Data.MetaData.Languages)lang);
			for (ushort i=0; i<sis.Length; i++) 
			{						
				list.Add(sis[i].Title);								
			}	//for
		}

		/// <summary>
		/// Loads the name of all Fields stored in Objd Files
		/// </summary>
		/// <param name="type">The Type of the Object = Language Code</param>
		public void LoadObjdDescription(ushort type) {	LoadData(ref objddesc, 0xCC, type); }
		
		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadDataOwners() {	LoadData(ref dataowners, 0x84, 1); }

		/// <summary>
		/// Loads all package Files in the directory and scans them for OBJf Informations
		/// </summary>
		public void LoadObjf() {	LoadData(ref objf, 0xF5, 1); }
		

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadOperators() { LoadData(ref operands, 0x88, 1); }
		
		/// <summary>
		/// Loads the Motive File
		/// </summary>
		public void LoadMotives() { LoadData(ref motives, 0x86, 1); }
		

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadOpcodes() 
		{
			names = new ArrayList();
			if (BasePackage==null) return;

			//IPackedFileDescriptor pfd = BasePackage.FindFile(Data.MetaData.STRING_FILE, 0x00000000, 0x7FE59FD0, 0x0000008B);
			FileTable.FileIndex.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = SimPe.FileTable.FileIndex.FindFile(Data.MetaData.STRING_FILE, 0x7FE59FD0, 0x000000000000008B, null);
			SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();

			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
			{
				str.ProcessData(item.FileDescriptor, BasePackage);
			
				for (ushort i=0; i<str.Items.Length; i++) 
				{						
					SimPe.PackedFiles.Wrapper.StrToken si = str.Items[i];

					if (si.Language.Id==1) 
					{
						names.Add(si.Title);
					}				
				}	//for		
			}
		}

		/// <summary>
		/// Loads the ObjectsPackage if not already loaded
		/// </summary>
		public void LoadPackage() 
		{
			if (BasePackage==null) 
			{
				Registry reg = Helper.WindowsRegistry;
				string file = System.IO.Path.Combine(SimPe.PathProvider.Global.GetExpansion(Expansions.BaseGame).InstallFolder, "TSData\\Res\\Objects\\objects.package");				
				if (System.IO.File.Exists(file)) 
				{
					BasePackage = SimPe.Packages.File.LoadFromFile(file);
				} 
				else 
				{
					BasePackage = null;
				}
			}
		}

		/// <summary>
		/// Returns the the name of the function with the given Opcode
		/// </summary>
		/// <param name="opcode">The opcode of the Instruction</param>
		/// <returns>The Alias of the Sim</returns>
		public string FindName(ushort opcode) 
		{
			if (opcode>=0x2000) return "Unknown Semi Global";
			LoadPackage();

			if (opcode>=0x0100) 
			{
				if (BasePackage==null) return "Unknown Global";
				//IPackedFileDescriptor pfd = BasePackage.FindFile(Data.MetaData.BHAV_FILE, 0x0, 0x7FD46CD0, opcode);
				FileTable.FileIndex.Load();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.BHAV_FILE, 0x7FD46CD0, (ulong)opcode, null);

				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					if (item.FileDescriptor!=null) 
					{
						byte[] data = new byte[0];
						IPackedFile pf = item.Package.Read(item.FileDescriptor);
						if (pf.IsCompressed) data = pf.Decompress(0x40);
						else data = pf.Data;

						return Helper.ToString(data);
					}
				}

				return "Unknown Global";
			}

			if (names==null) LoadOpcodes();
			
			object o = null;
			if (opcode<names.Count) o = names[opcode];
			
			if (o!=null) return (string)o;
			else return Localization.Manager.GetString("unknown");			
		}	

		/// <summary>
		/// Returns the the name of all Fileds in an Objd File
		/// </summary>
		public ArrayList OBJDDescription(ushort type)
		{
			LoadPackage();
			if (BasePackage==null) return new ArrayList();

			LoadObjdDescription(type);
			if (objddesc!=null) return objddesc;
			else return new ArrayList();
						
		}

		/// <summary>
		/// Returns the the a Memory Alias
		/// </summary>
		/// <param name="guid">Guid of the Memory</param>
		/// <returns>An IAlias Object describing the Memory</returns>
		public IAlias FindMemory(uint guid)
		{
			/*LoadPackage();
			if (BasePackage==null) return new Alias(guid, Localization.Manager.GetString("unknown"));	*/
			

			if (memories==null) LoadMemories();
			
			object o = null;
			o = memories[guid];
			
			if (o!=null) return (IAlias)o;
			else return new Alias(guid, Localization.Manager.GetString("unknown"));	
		}

		/// <summary>
		/// Returns a list of all known memories
		/// </summary>
		public Hashtable StoredMemories
		{
			get 
			{ 
				//LoadPackage();
				if (memories==null) LoadMemories();
				return memories; 
			}			
		}

		/// <summary>
		/// Returns the List of known Primitives
		/// </summary>
		public ArrayList StoredMotives
		{
			get 
			{
				LoadPackage();
				if (motives==null)this.LoadMotives();
				return motives; 
			}
		}

		/// <summary>
		/// Returns the List of known Primitives
		/// </summary>
		public ArrayList StoredPrimitives
		{
			get 
			{
				LoadPackage();
				if (names==null)this.LoadOpcodes();
				return names; 
			}
		}

		/// <summary>
		/// Returns a list of all known Objf Lines
		/// </summary>
		public ArrayList StoredObjfLines
		{
			get 
			{ 
				LoadPackage();
				if (objf==null) LoadObjf();
				return objf; 
			}			
		}
	
		/// <summary>
		/// Returns the the name of the Expression Operator
		/// </summary>
		/// <param name="op">Numerical Value of the Operator</param>
		/// <returns>The Name of The Operator</returns>
		public string FindExpressionOperator(byte op)
		{
			LoadPackage();
			if (BasePackage==null) return Localization.Manager.GetString("unk");
			

			if (operands==null) LoadOperators();
			
			object o = null;
			if (op<operands.Count) o = operands[op];
			
			if (o!=null) return o.ToString();
			else return Localization.Manager.GetString("unk");	
		}		

		/// <summary>
		/// Returns the names Operatores in Expression Primitives
		/// </summary>
		public ArrayList StoredExpressionOperators
		{
			get { return operands;}
		}

		/// <summary>
		/// Returns the the name of a Data Owner
		/// </summary>
		/// <param name="owner">Numerical Value of the Owner</param>
		/// <returns>The Name</returns>
		public string FindExpressionDataOwners(byte owner)
		{
			LoadPackage();
			if (BasePackage==null) return Localization.Manager.GetString("unk");
			

			if (dataowners==null) LoadDataOwners();
			
			object o = null;
			if (owner<dataowners.Count) o = dataowners[owner];
			
			if (o!=null) return o.ToString();
			else return Localization.Manager.GetString("unk");	
		}

		/// <summary>
		/// Returns the names of the Data in an Expression Primitive
		/// </summary>
		public ArrayList StoredDataNames
		{
			get { return dataowners;}
		}

		/// <summary>
		/// Returns the the name of a Motive
		/// </summary>
		/// <param name="owner">Numerical Value</param>
		/// <returns>The Name</returns>
		public string FindMotives(ushort nr)
		{
			LoadPackage();
			if (BasePackage==null) return Localization.Manager.GetString("unk");
			

			if (motives==null) LoadMotives();
			
			object o = null;
			if (nr<motives.Count) o = motives[nr];
			
			if (o!=null) return o.ToString();
			else return Localization.Manager.GetString("unk");	
		}

		/// <summary>
		/// returns null or a Mathcing global BHAV File
		/// </summary>
		/// <param name="opcode">the Opcode of the BHAV</param>
		/// <returns>The Descriptor for the Bhav File in the BasePackage or null</returns>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem LoadGlobalBHAV(ushort opcode)
		{
			return  LoadSemiGlobalBHAV(opcode, 0x7FD46CD0);
		}

		/// <summary>
		/// Returns the Bhav for a Semi Global Opcode
		/// </summary>
		/// <param name="opcode">The Opcode</param>
		/// <param name="group">The group of the SemiGlobal</param>
		/// <returns>The Descriptor of the Bhaf File in the Base Packagee or null</returns>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem LoadSemiGlobalBHAV(ushort opcode, uint group)
		{
			//LoadPackage();
			//if (BasePackage==null) return null;
			FileTable.FileIndex.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.BHAV_FILE, group, opcode, null);
			if (items.Length>0) return items[0];
			return null;
		}



		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected override void OnChangedPackage() 
		{
			names = null;
		}
	}
}
