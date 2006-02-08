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
using System.Drawing;
using System.Collections;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// Describes the Type of a MipMap
	/// </summary>
	public enum MipMapType:byte
	{
		Texture = 0x0,
		LifoReference = 0x1,
		SimPE_PlainData = 0xff
	}

	/// <summary>
	/// A MipMap contains one Texture in a specific Size
	/// </summary>
	public class MipMap : System.IDisposable
	{
		
		#region Attributes
		byte[] data = null;
		Image img = null;
		MipMapType datatype;
		string lifofile;

		public MipMapType DataType
		{
			get{ return datatype; }
		}

		/// <summary>
		/// Force a Reload of the Texture
		/// </summary>
		public void ReloadTexture()
		{
			if ((datatype!=MipMapType.LifoReference) && (data!=null)) 
			{
				System.IO.BinaryReader sr = new System.IO.BinaryReader(new System.IO.MemoryStream(data));
				img = ImageLoader.Load(this.parent.TextureSize, data.Length, this.parent.Format, sr, index, mapcount);
			}
		}

		public Image Texture 
		{
			get { 				
				if (img==null) 
				{
					ReloadTexture();
				}
				return img; 
			}
			set 
			{
				if (value!=null) datatype = MipMapType.Texture;
				img = value;
			}
		}

		public byte[] Data
		{
			get { return data; }
			set { 
				if (value!=null) datatype = MipMapType.SimPE_PlainData;
				data = value; 
			}
		}

		public string LifoFile 
		{
			get { return lifofile; }
			set 
			{
				if (value!=null) datatype = MipMapType.LifoReference;
				lifofile = value;
			}
		}
		#endregion

		ImageData parent;

		/// <summary>
		/// Constructore
		/// </summary>
		public MipMap(ImageData parent)
		{
			this.parent = parent;
			this.datatype = MipMapType.SimPE_PlainData;
			data = new Byte[0];
		}

		

		#region IRcolBlock Member
		int index, mapcount;
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="index">Index of this Map in the Block</param>
		/// <param name="mapcount">Number of Maps in the block (0 is the smallest map)</param>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader, int index, int mapcount)
		{
			this.index = index;
			this.mapcount = mapcount;
			datatype = (MipMapType)reader.ReadByte();

			switch (datatype) 
			{
				case MipMapType.Texture: 
				{
					int imgsize = reader.ReadInt32();
					//data = reader.ReadBytes(imgsize);
					long pos = reader.BaseStream.Position;
					//System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(data));


					if (!parent.Parent.Fast) 
					{
						try 
						{
							data = reader.ReadBytes(imgsize);

							/*if (!Helper.DebugMode) 
							{
								// this is derefered now, until application reads the Texture Property
								reader.BaseStream.Seek(-imgsize, System.IO.SeekOrigin.Current);
								img = ImageLoader.Load(parent.TextureSize, imgsize, parent.Format, reader, index, mapcount);
							} 
							else*/ 
							{
								datatype = MipMapType.SimPE_PlainData;
								img = null;
							}
							
						} 
						catch (Exception ex) 
						{
							Helper.ExceptionMessage("", ex);
						}
					}

					byte[] over = reader.ReadBytes((int)Math.Max(0, pos + imgsize - reader.BaseStream.Position));
					reader.BaseStream.Seek(pos + imgsize, System.IO.SeekOrigin.Begin);
					
					break;
				}
				case MipMapType.LifoReference: 
				{
					/*byte len = reader.ReadByte();
					lifofile = Helper.ToString(reader.ReadBytes(len));*/
					lifofile = reader.ReadString();
					break;
				}
				default: 
				{
					throw new Exception("Unknown MipMap Datatype 0x"+Helper.HexString((byte)datatype));
				}
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
		public void Serialize(System.IO.BinaryWriter writer)
		{
			if (datatype==MipMapType.SimPE_PlainData) writer.Write((byte)MipMapType.Texture);
			else writer.Write((byte)datatype);

			switch (datatype) 
			{
				case MipMapType.SimPE_PlainData: 
				case MipMapType.Texture:
				{
					try 
					{
						if (datatype==MipMapType.Texture) 
							data = ImageLoader.Save(parent.Format, img);
					} 
					catch (Exception ex) 
					{
						Helper.ExceptionMessage("", ex);
					}
					

					if (data==null) data=new byte[0];
					//if (data.Length<0x10) data = Helper.SetLength(data, 0x10);

					writer.Write((int)data.Length);
					writer.Write(data);
					
					break;
				}
				case MipMapType.LifoReference: 
				{
					/*writer.Write((byte)lifofile.Length);
					writer.Write(Helper.ToBytes(lifofile, 0));*/
					writer.Write(lifofile);
					break;
				}
				default: 
				{
					throw new Exception("Unknown MipMap Datatype 0x"+Helper.HexString((byte)datatype));
				}
			}
		}
		#endregion

		public override string ToString()
		{
			if (this.datatype==MipMapType.LifoReference) return this.LifoFile;

			string name;
			if (img==null) name = "";
			else name = "Image "+img.Size.Width.ToString()+"x"+img.Size.Height.ToString() + " - ";

			name += parent.NameResource.FileName;
			return name;
		}

		/// <summary>
		/// If this MipMap is a LifoReference, then this Method will try to load the Lifo Data
		/// </summary>
		public void GetReferencedLifo()
		{
			if (datatype == MipMapType.LifoReference) 
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndex nfi = FileTable.FileIndex.AddNewChild();
				nfi.AddIndexFromPackage(this.parent.Parent.Package);
				bool succ = GetReferencedLifo_NoLoad();
				FileTable.FileIndex.RemoveChild(nfi);
				nfi.Clear();

				if (!succ && !FileTable.FileIndex.Loaded)
				{
					FileTable.FileIndex.Load();
					GetReferencedLifo_NoLoad();
				}
			}
		}

		/// <summary>
		/// If this MipMap is a LifoReference, then this Method will try to load the Lifo Data
		/// </summary>
		protected bool GetReferencedLifo_NoLoad()
		{
			if (datatype == MipMapType.LifoReference) 
			{
				
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(this.lifofile, SimPe.Data.MetaData.LIFO, SimPe.Data.MetaData.LOCAL_GROUP, true);				
				GenericRcol rcol = null;

				if (item!=null) //we have a global LIFO (loads faster)
				{
					rcol = new GenericRcol(null, false);
					rcol.ProcessData(item.FileDescriptor, item.Package);

					
				} 
				else //the lifo wasn't found globaly, so we look for it in the local package
				{
					SimPe.Interfaces.Files.IPackageFile pkg = parent.Parent.Package;
					SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFile(this.lifofile, SimPe.Data.MetaData.LIFO);
					if (pfds.Length>0) 
					{
						rcol = new GenericRcol(null, false);
						rcol.ProcessData(pfds[0], pkg);
					}
				}

				//process the Lifo File if found
				if (rcol!=null) 
				{
					LevelInfo li = (LevelInfo)rcol.Blocks[0];

					this.img = null;
					this.Data = li.Data;

					return true;
				}
			} else return true;

			return false;
		}

		#region IDisposable Member

		public void Dispose()
		{
			this.data = new byte[0];
			if (this.img!=null) img.Dispose();
			img = null;
		}

		#endregion
	}

	/// <summary>
	/// MipMap Blocks contain all MipMaps in given sizes
	/// </summary>
	public class MipMapBlock : System.IDisposable
	{
		#region Attributes
		MipMap[] mipmaps;
		uint creator;
		uint unknown_1;

		public MipMap[] MipMaps
		{
			get { return mipmaps; }
			set { mipmaps = value; }
		}

		
		#endregion

		ImageData parent;

		/// <summary>
		/// Constructore
		/// </summary>
		public MipMapBlock(ImageData parent)
		{
			this.parent = parent;
			mipmaps = new MipMap[0];
			creator = 0xffffffff;
			unknown_1 = 0x41200000;
		}

		/// <summary>
		/// Creats MipMaps based on the passed Data
		/// </summary>
		/// <param name="data">the MipMap Data</param>
		public void AddDDSData(DDSData[] data) 
		{
			MipMaps = new MipMap[data.Length];
			int ct = 0;
			for (int i=data.Length-1; i>=0; i--)
			{
				DDSData item = data[i];
				MipMap mm = new MipMap(this.parent);
				mm.Texture = item.Texture;
				mm.Data = item.Data;

				MipMaps[ct++] = mm;
			}
		}

		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			uint innercount;
			switch (parent.Version)
			{
				case 0x09: 
				{
					innercount = reader.ReadUInt32();
					break;
				}
				case 0x07: 
				{
					innercount = parent.MipMapLevels;
					break;
				}
				default: 
				{
					throw new Exception("Unknown MipMap version 0x"+Helper.HexString(parent.Version));
				}
			}

			mipmaps = new MipMap[innercount];
			for (int i=0; i<mipmaps.Length; i++)
			{
				mipmaps[i] = new MipMap(parent);
				mipmaps[i].Unserialize(reader, i, mipmaps.Length);
			}

			creator = reader.ReadUInt32();
			if ((parent.Version==0x08) || (parent.Version==0x09)) unknown_1 = reader.ReadUInt32();	
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public void Serialize(System.IO.BinaryWriter writer)
		{
			switch (parent.Version)
			{
				case 0x09: 
				{
					writer.Write((uint)mipmaps.Length);
					break;
				}
			}

			for (int i=0; i<mipmaps.Length; i++)
			{
				mipmaps[i].Serialize(writer);
			}

			writer.Write(creator);
			if (parent.Version==0x09) writer.Write(unknown_1);	
		}
		#endregion

		/// <summary>
		/// Returns the Biggest MipMap in the first MipMap Block (null if no Texture was available)
		/// </summary>
		public MipMap LargestTexture
		{
			get 
			{		
				MipMap large = null;
				foreach (MipMap mm in this.MipMaps) 
				{
					if (mm.DataType != MipMapType.LifoReference) 
					{
						Image img = mm.Texture;
						if (large!=null) 
						{
							if (large.Texture.Size.Width<img.Size.Width)
								large = mm;
						} else large = mm;
					}
				}

				return large;
			}
		}

		/// <summary>
		/// Returns the Biggest MipMap in the first MipMap Block (null if no Texture was available)
		/// </summary>
		/// <param name="zs">The wanted Size for the Texture</param>
		public MipMap GetLargestTexture(Size zs)
		{
			MipMap large = null;
				foreach (MipMap mm in this.MipMaps) 
				{
					if (mm.DataType != MipMapType.LifoReference) 
					{
						Image img = mm.Texture;
						if (large!=null) 
						{
							if (large.Texture.Size.Width<img.Size.Width)
								large = mm;
						} 
						else large = mm;

						if ((img.Size.Width>zs.Width) || (img.Size.Height>zs.Height)) break;
					}
				}

				return large;
			
		}

		/// <summary>
		/// Will try to load all Lifo References in the MipMpas stored in this Block
		/// </summary>
		public void GetReferencedLifos() 
		{
			foreach (MipMap mm in this.MipMaps)
				mm.GetReferencedLifo();
		}

		public override string ToString()
		{
			if (mipmaps.Length==1)return "0x"+Helper.HexString(this.creator)+" - 0x"+Helper.HexString(this.unknown_1)+" (1 Item)";
			return "0x"+Helper.HexString(this.creator)+" - 0x"+Helper.HexString(this.unknown_1)+" ("+this.mipmaps.Length+" Items)";
		}

		#region IDisposable Member

		public void Dispose()
		{
			foreach (MipMap mm in this.mipmaps)		
				mm.Dispose();			

			mipmaps = new MipMap[0];
		}

		#endregion
	}


	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class ImageData
		: AbstractRcolBlock, IScenegraphBlock, System.IDisposable
	{
		#region Attributes
		
		Size texturesize;
		ImageLoader.TxtrFormats format;
		uint mipmaplevels;
		float unknown_0;
		uint unknown_1;
		string filenamerep;
		MipMapBlock[] mipmapblocks;

		public MipMapBlock[] MipMapBlocks
		{
			get { return mipmapblocks; }
			set { mipmapblocks = value; }
		}

		public Size TextureSize 
		{
			get { return texturesize; }
			set { texturesize = value; }
		}


		public uint MipMapLevels 
		{
			get { return mipmaplevels; }
			set { mipmaplevels = value; }
		}

		public ImageLoader.TxtrFormats Format 
		{
			get { return format; }
			set { 
				if (format!=value) 
				{
					//when the Format changes we need to get the Picturedta FIRST
					foreach (MipMapBlock mmp in this.MipMapBlocks)
						foreach (MipMap mm in mmp.MipMaps)
						{
							Image img = mm.Texture;
							mm.Texture = img;
						}					
				}
				format = value; 
			}
		}

		public string FileNameRepeat 
		{
			get { return filenamerep; }
			set { filenamerep = value; }
		}

		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public ImageData(Rcol parent) : base(parent)
		{
			texturesize = new Size(0, 0);
			mipmapblocks = new MipMapBlock[0];
			sgres = new SGResource(null);
			BlockID = 0x1c4a276c;
			filenamerep = "";
			this.version = 0x09;
			unknown_0 = (float)1.0;
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			/*byte len = reader.ReadByte();
			string s = Helper.ToString(reader.ReadBytes(len));*/
			string s = reader.ReadString();

			sgres.BlockID = reader.ReadUInt32();
			sgres.Unserialize(reader);

			if (Parent.Fast) 
			{
				texturesize = new Size(0, 0);
				mipmapblocks = new MipMapBlock[0];
				return;
			}

			int w = reader.ReadInt32();
			int h = reader.ReadInt32();
			texturesize = new Size(w, h);

			format = (ImageLoader.TxtrFormats)reader.ReadUInt32();
			mipmaplevels = reader.ReadUInt32();
			unknown_0 = reader.ReadSingle();
			mipmapblocks = new MipMapBlock[reader.ReadUInt32()];
			unknown_1 = reader.ReadUInt32();

			if (version==0x09) filenamerep = reader.ReadString();

			for (int i=0; i<mipmapblocks.Length; i++)
			{
				mipmapblocks[i] = new MipMapBlock(this);
				mipmapblocks[i].Unserialize(reader);
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
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			switch (version)
			{
				case 0x07: 
				{
					if (mipmapblocks.Length>0)
						mipmaplevels = (uint)mipmapblocks[0].MipMaps.Length;
					else 
						mipmaplevels = 0;
					break;
				}
			}
			writer.Write(version);
			string s = sgres.Register(null);
			writer.Write(s);
			/*writer.Write((byte)sgres.Register(null).Length);
			writer.Write(Helper.ToBytes(sgres.Register(null), 0));*/

			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);

			writer.Write((int)texturesize.Width);
			writer.Write((int)texturesize.Height);

			writer.Write((uint)format);
			writer.Write(mipmaplevels);
			writer.Write(unknown_0);
			writer.Write((uint)mipmapblocks.Length);
			writer.Write(unknown_1);

			if (version==0x09) writer.Write(filenamerep);

			for (int i=0; i<mipmapblocks.Length; i++)
			{
				mipmapblocks[i].Serialize(writer);
			}
		}
		#endregion

		/*public override string ToString()
		{
			return this.NameResource.FileName;
		}*/

		#region IScenegraphBlock Member

		public void ReferencedItems(Hashtable refmap, uint parentgroup)
		{
			ArrayList list = new ArrayList();
			foreach (MipMapBlock mmp in this.MipMapBlocks) 
			{
				foreach (MipMap mm in mmp.MipMaps)
				{
					if (mm.DataType == MipMapType.LifoReference)
						list.Add(ScenegraphHelper.BuildPfd(mm.LifoFile, SimPe.Plugin.ScenegraphHelper.LIFO, parentgroup));
				}
			}
			refmap["LIFO"] = list;
		}

		#endregion

		/// <summary>
		/// Returns the Biggest MipMap in the first MipMap Block (null if no Texture was available)
		/// </summary>
		public MipMap LargestTexture
		{
			get 
			{
				if (this.MipMapBlocks.Length==0) return null;
			
				return MipMapBlocks[0].LargestTexture;
			}
		}

		/// <summary>
		/// Returns the Biggest MipMap in the first MipMap Block (null if no Texture was available)
		/// </summary>
		/// <param name="zs">The wanted Size for the Texture</param>
		public MipMap GetLargestTexture(Size zs)
		{
			if (this.MipMapBlocks.Length==0) return null;
			
			return MipMapBlocks[0].GetLargestTexture(zs);
		}

		/// <summary>
		/// Will try to load all Lifo References in the MipMpas in all Blocks
		/// </summary>
		public void GetReferencedLifos() 
		{
			foreach (MipMapBlock mmp in this.MipMapBlocks)
				mmp.GetReferencedLifos();
		}

		#region IDisposable Member

		public override void Dispose()
		{
			foreach (MipMapBlock mmb in this.mipmapblocks)
				mmb.Dispose();

			mipmapblocks = new MipMapBlock[0];
		}

		#endregion
	}
}
