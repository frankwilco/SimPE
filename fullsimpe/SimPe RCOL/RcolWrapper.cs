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
	{
		#region Attributes
		byte[] oversize;
		ushort language;
		ushort strformat;
		uint[] index;

		Interfaces.Files.IPackedFileDescriptor[] reffiles;
		public Interfaces.Files.IPackedFileDescriptor[] ReferencedFiles 
		{
			get { return reffiles; }
			set { reffiles = value;} 
		}

		IRcolBlock[] blocks;
		public IRcolBlock[] Blocks 
		{
			get { return blocks; }
			set { blocks = value;} 
		}
		#endregion

		Hashtable tokens;
		public Hashtable Tokens 
		{
			get { return tokens; }
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
				if (blocks.Length>0) if (blocks[0].NameResource!=null) return blocks[0].NameResource.FileName;
				return "";
			}

			set 
			{
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

			//add Token Handlers
			tokens = new Hashtable();
			ImageData cid = new ImageData(provider, this);
			SGResource csgr = new SGResource(provider, this);
			MaterialDefinition cmd = new MaterialDefinition(provider, this);
			LevelInfo li = new LevelInfo(provider, this);
			Shape sh = new Shape(provider, this);
			ReferentNode rn = new ReferentNode(provider, this);
			ObjectGraphNode ogn = new ObjectGraphNode(provider, this);
			ResourceNode rnn = new ResourceNode(provider, this);
			CompositionTreeNode ctn = new CompositionTreeNode(provider, this);
			DataListExtension dle = new DataListExtension(provider, this);
			BoneDataExtension bde = new BoneDataExtension(provider, this);
			ShapeRefNode srn = new ShapeRefNode(provider, this);
			TransformNode tn = new TransformNode(provider, this);
			RenderableNode rnnn = new RenderableNode(provider, this);
			BoundedNode bn = new BoundedNode(provider, this);
			GeometryNode gnn = new GeometryNode(provider, this);
#if DEBUG
			//GeometryDataContainer gdc = new GeometryDataContainer(provider, this);
			GeometryDataContainerExt gdc = new GeometryDataContainerExt(provider, this);
#else
			GeometryDataContainer gdc = new GeometryDataContainer(provider, this);			
#endif
			AnimResourceConst arc = new AnimResourceConst(provider, this);
			CinematicScene cs = new CinematicScene(provider, this);
			LightRefNode lrf = new LightRefNode(provider, this);
			ViewerRefNode vrn = new ViewerRefNode(provider, this);
			ViewerRefNodeBase vrnb = new ViewerRefNodeBase(provider, this);
			ViewerRefNodeRecursive vrnr = new ViewerRefNodeRecursive(provider, this);
			DirectionalLight dl = new DirectionalLight(provider, this);
			AmbientLight al = new AmbientLight(provider, this);
			PointLight pl = new PointLight(provider, this);
			SpotLight sl = new SpotLight(provider, this);
		}

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
				"---",
				4
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			uint type = reader.ReadUInt32();
			uint count = type; 
			if (type==0xffff0001) 
			{
				language = (ushort)(type & 0x0000ffff);
				strformat = (ushort)((type >> 16) & 0x0000ffff);
				count = reader.ReadUInt32();
			} 
			else 
			{
				language = 0;
				strformat = 0;
			}

			reffiles = new Interfaces.Files.IPackedFileDescriptor[count];
			for (int i=0; i<reffiles.Length; i++) 
			{
				SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
				
				pfd.Group = reader.ReadUInt32();
				pfd.Instance = reader.ReadUInt32();
				if (type==0xffff0001) pfd.SubType = reader.ReadUInt32();
				pfd.Type = reader.ReadUInt32();

				reffiles[i] = pfd;
			}

			index = new uint[reader.ReadUInt32()];
			blocks = new IRcolBlock[index.Length];
			for (int i=0; i<index.Length; i++) index[i] = reader.ReadUInt32();
			

			for (int i=0; i<index.Length; i++)
			{
				uint id = index[i];
				/*byte len = reader.ReadByte();
				string s = Helper.ToString(reader.ReadBytes(len));*/
				string s = reader.ReadString();
				uint myid = reader.ReadUInt32();
				if (myid==0xffffffff) break;
				if (id!=myid) throw new Exception("Not matching ID Field in RCOL File.\n\nID=0x"+Helper.HexString(myid)+"\nLooked for=0x"+Helper.HexString(id)+"\nOffset=0x"+Helper.HexString((uint)(reader.BaseStream.Position-4)));

				IRcolBlock wrp = (IRcolBlock)tokens[s];
				if (wrp==null) throw new Exception("Unknown embedded RCOL Block "+s+".\n\nOffset=0x"+Helper.HexString(reader.BaseStream.Length-4));

				wrp = wrp.Create(myid);
				wrp.Unserialize(reader);
				blocks[i] = wrp;
			}

			if (!fast) 
			{
				long size = reader.BaseStream.Length - reader.BaseStream.Position;
				if (size>0) oversize = reader.ReadBytes((int)size);
				else oversize = new byte[0];
			}
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
			uint type = (uint)(language | (strformat << 16));
			if (type==0xffff0001) 
			{
				writer.Write(language);
				writer.Write(strformat);	
			} 
			writer.Write((uint)reffiles.Length);
			for (int i=0; i<reffiles.Length; i++) 
			{
				SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor)reffiles[i];
				writer.Write(pfd.Group);
				writer.Write(pfd.Instance);
				if (type==0xffff0001) writer.Write(pfd.SubType);
				writer.Write(pfd.Type);
			}

			//rebuild the Index Block
			index = new uint[blocks.Length];
			for (int i=0; i<index.Length; i++) index[i] = blocks[i].BlockID;

			writer.Write((uint)index.Length);
			for (int i=0; i<index.Length; i++) writer.Write(index[i]);
			

			for (int i=0; i<index.Length; i++)
			{
				IRcolBlock wrp = blocks[i];
				/*writer.Write((byte)wrp.Register(null).Length);
				writer.Write(Helper.ToBytes(wrp.Register(null), 0));*/
				writer.Write(wrp.BlockName);
				writer.Write(index[i]);

				wrp.Serialize(writer);
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

		#endregion		
	}
}
