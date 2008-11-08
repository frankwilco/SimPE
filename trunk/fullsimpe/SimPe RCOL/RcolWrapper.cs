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
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public abstract class Rcol
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
		, IMultiplePackedFileWrapper	//Allow Multiple Instances
		, System.IDisposable
	{
		#region Attributes
		byte[] oversize;
		uint[] index;

		Interfaces.Files.IPackedFileDescriptor[] reffiles;
        public Interfaces.Files.IPackedFileDescriptor[] ReferencedFiles
        {
            get { return duff ? new Interfaces.Files.IPackedFileDescriptor[0] : reffiles; }
            set { if (duff) return; reffiles = value; }
        }

		IRcolBlock[] blocks;
		public IRcolBlock[] Blocks 
		{
			get { return duff ? new IRcolBlock[0] : blocks; }
            set { if (duff) return; blocks = value; } 
		}

		uint count;
		public uint Count 
		{
			get {return count;}
		}

        bool duff = false;
        Exception e = null;
        public bool Duff { get { return duff; } }
		#endregion

		/// <summary>
		/// contains null or a delegate that should be called when the TabPage did change
		/// </summary>		
		public event EventHandler TabPageChanged;

		internal void ClearTabPageChanged()
		{
			if (TabPageChanged==null) return;

			System.Delegate[] list = TabPageChanged.GetInvocationList();
			foreach (EventHandler d in list)
				TabPageChanged -= d;
		}

		internal void ChildTabPageChanged(object sender, System.EventArgs e)
		{
			if (TabPageChanged!=null) TabPageChanged(sender, e);	
		}
		

		static Hashtable tokens;
		public static Hashtable Tokens 
		{
			get { 
				if (tokens==null) LoadTokens();
				return tokens; 
			}
		}

		Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		/// <summary>
		/// Filename of the First Block (or an empty string)
		/// </summary>
		public string FileName 
		{
			get 
			{
                if (duff) return SimPe.Localization.GetString("InvalidCRES").Replace("{0}", e.Message);
				if (blocks.Length>0) if (blocks[0].NameResource!=null) return blocks[0].NameResource.FileName;
				return "";
			}

			set 
			{
                if (duff) return;
				if (blocks.Length>0) if (blocks[0].NameResource!=null) blocks[0].NameResource.FileName = value;
			}
		}

		bool fast;
		public bool Fast 
		{
			get { return fast; }
			set { fast = value; }
		}

		/// <summary>
		/// Loads all Tokens in the assemblies given in the <see cref="TokenAssemblies"/> List
		/// </summary>
		static void LoadTokens() 
		{
			tokens = new Hashtable();
			foreach (System.Reflection.Assembly a in assemblies) LoadTokens(a);
		}

		static ArrayList assemblies;
		/// <summary>
		/// keeps a List of all <see cref="System.Reflection.Assembly"/>, SimPE should use to look for Tokens
		/// </summary>
		public static ArrayList TokenAssemblies
		{
			get 
			{
				if (assemblies==null) 
				{
					assemblies = new ArrayList();
					assemblies.Add(typeof(Rcol).Assembly);
				}
				return assemblies;
			}
		}

		/// <summary>
		/// Creates the Tokenlist for the given Assembly
		/// </summary>
		static void LoadTokens(System.Reflection.Assembly a)
		{
			if (tokens==null) tokens = new Hashtable();
			
			object[] args = new object[1]; args[0] = null;
			object[] statics = SimPe.LoadFileWrappers.LoadPlugins(a, typeof(SimPe.Interfaces.Scenegraph.IRcolBlock), args);
			foreach (SimPe.Interfaces.Scenegraph.IRcolBlock isb in statics) isb.Register(tokens);
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		public Rcol(Interfaces.IProviderRegistry provider, bool fast) : base()
		{
			this.fast = fast;
			this.provider = provider;
			reffiles = new Interfaces.Files.IPackedFileDescriptor[0];
			index = new uint[0];
			blocks = new IRcolBlock[0];
			oversize = new byte[0];
            duff = false;
		}

		public Rcol() : this(null, false) {	}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			if ( (version==0012) //0.10
				|| (version==0013) //0.12
				) 
			{
				return true;
			}

			return false;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new RcolUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"RCOL Wrapper",
				"Quaxi",
				"This File is part of the Scenegraph. The Scenegraph is used to build the 3D Objects in \"The Sims 2\".",
				10,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.resource.png"))
				); 
		}

		/// <summary>
		/// Read a RCOl Block
		/// </summary>
		/// <param name="id">expected ID</param>
		/// <param name="reader">the reader</param>
        internal IRcolBlock ReadBlock(uint id, System.IO.BinaryReader reader)
        {
            long pos = reader.BaseStream.Position;
            string s = reader.ReadString();
            Type tp = (Type)Tokens[s];
            if (tp == null)
                throw new Exception("Unknown embedded RCOL Block Name at Offset=0x" + Helper.HexString((uint)pos),
                    new Exception("RCOL Block Name: " + s));

            pos = reader.BaseStream.Position;
            uint myid = reader.ReadUInt32();
            if (myid == 0xffffffff) return null;
            if (id != myid)
                throw new Exception("Unexpected embedded RCOL Block ID at Offset=0x" + Helper.HexString((uint)pos),
                    new Exception("Read: 0x" + Helper.HexString(myid) + "; Expected: 0x" + Helper.HexString(id)));

            IRcolBlock wrp = AbstractRcolBlock.Create(tp, this, myid);
            wrp.Unserialize(reader);
            return wrp;
        }

		/// <summary>
		/// Write a Rcol Block
		/// </summary>
		/// <param name="wrp">The content of the Block</param>
		/// <param name="writer">the writer</param>
		internal void WriteBlock(IRcolBlock wrp, System.IO.BinaryWriter writer)
		{
			writer.Write(wrp.BlockName);
            writer.Write(wrp.BlockID);
			wrp.Serialize(writer);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
        {
            duff = false;
            this.e = null;

            count = reader.ReadUInt32();

            try
            {

                reffiles = new Interfaces.Files.IPackedFileDescriptor[count == 0xffff0001 ? reader.ReadUInt32() : count];
                for (int i = 0; i < reffiles.Length; i++)
                {
                    SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();

                    pfd.Group = reader.ReadUInt32();
                    pfd.Instance = reader.ReadUInt32();
                    pfd.SubType = (count == 0xffff0001) ? reader.ReadUInt32() : 0;
                    pfd.Type = reader.ReadUInt32();

                    reffiles[i] = pfd;
                }

                uint nn = reader.ReadUInt32();
                index = new uint[nn];
                blocks = new IRcolBlock[index.Length];
                for (int i = 0; i < index.Length; i++) index[i] = reader.ReadUInt32();


                for (int i = 0; i < index.Length; i++)
                {
                    uint id = index[i];
                    IRcolBlock wrp = ReadBlock(id, reader);
                    if (wrp == null) break;
                    blocks[i] = wrp;
                }

                if (!fast)
                {
                    long size = reader.BaseStream.Length - reader.BaseStream.Position;
                    if (size > 0) oversize = reader.ReadBytes((int)size);
                    else oversize = new byte[0];
                }
            }
            catch (Exception e)
            {
                duff = true;
                this.e = e;
                //SimPe.Helper.ExceptionMessage(e);
            }
            finally { }

        }

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		protected override void Serialize(System.IO.BinaryWriter writer)
		{
            if (duff) return;
            writer.Write(count == 0xffff0001 ? count : (uint)reffiles.Length);
            writer.Write((uint)reffiles.Length);
			for (int i=0; i<reffiles.Length; i++) 
			{
				SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor)reffiles[i];
				writer.Write(pfd.Group);
				writer.Write(pfd.Instance);
				if (count==0xffff0001) writer.Write(pfd.SubType);
				writer.Write(pfd.Type);
			}

            writer.Write((uint)blocks.Length);
            for (int i = 0; i < blocks.Length; i++) writer.Write(blocks[i].BlockID);


            for (int i = 0; i < blocks.Length; i++)
			{
				IRcolBlock wrp = blocks[i];
                WriteBlock(wrp, writer);
			}

			writer.Write(oversize);
		}

		public static ArrayList list;
		/// <summary>
		/// Fixes SubType and Instance hashes of the RCOL
		/// </summary>
		public override void Fix(Interfaces.IWrapperRegistry registry)
		{
			if (list==null)  list = new ArrayList();

			base.Fix (registry);

			//first we need to fix all referenced Files
			for (int i=0; i<this.ReferencedFiles.Length; i++)
			{
				Interfaces.Files.IPackedFileDescriptor lpfd = this.ReferencedFiles[i];
				Interfaces.Files.IPackedFileDescriptor pfd = this.Package.FindFile(lpfd);
				if (pfd!=null) 
				{
					//make sure we don't get into an Endless Loop
					if (list.Contains(pfd)) continue;

					list.Add(pfd);
					SimPe.Interfaces.Plugin.IFileWrapper wrapper = (SimPe.Interfaces.Plugin.IFileWrapper)registry.FindHandler(pfd.Type);
					if (wrapper!=null) 
					{
						wrapper.ProcessData(pfd, package);
						wrapper.Fix(registry);
						lpfd.SubType = wrapper.FileDescriptor.SubType;
						lpfd.Group = wrapper.FileDescriptor.Group;
						lpfd.Instance = wrapper.FileDescriptor.Instance;
					}
					list.Remove(pfd);
				}
			}

			//so now we do fix the Instances
			this.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(this.FileName));
			this.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(this.FileName));

			//commit
			this.SynchronizeUserData();
		}

		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public virtual byte[] FileSignature
		{
			get
			{
				return new byte[0];
			}
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public virtual uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
							   };
				return types;
			}
		}

		/// <summary>
		/// Override this to add your own Implementation for <see cref="ResourceName"/>
		/// </summary>
		/// <returns>null, if the Default Name should be generated</returns>
		protected override string GetResourceName(Data.TypeAlias ta)
		{
			if (!this.Processed) ProcessData(FileDescriptor, Package, false);
			return this.FileName;
		}
		


		#endregion		

		#region IMultiplePackedFileWrapper
		public override object[] GetConstructorArguments()
		{
			object[] o = new object[2];
			o[0] = this.provider;
			o[1] = this.fast;
			return o;
		}
		#endregion

		public override void Dispose()
		{			
			foreach (IRcolBlock irb in this.blocks)
				if (irb is IDisposable) 
					((IDisposable)irb).Dispose();

			
			base.Dispose();
		}
	}	
}
