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

namespace SimPe.Plugin
{
	
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class LevelInfo
		: AbstractRcolBlock
	{
		#region Attributes
		byte[] data;
		Size texturesize;
		ImageLoader.TxtrFormats format;
		int zlevel;
		Image img;
		MipMapType datatype;
		

		public Size TextureSize 
		{
			get { return texturesize; }
		}

		public int ZLevel 
		{
			get { return zlevel; }
			set {zlevel = value; }
		}

		public ImageLoader.TxtrFormats Format 
		{
			get { return format; }
			set { format = value; }
		}

		public Image Texture 
		{
			get { 
				if (img==null) 
				{
					System.IO.BinaryReader sr = new System.IO.BinaryReader(new System.IO.MemoryStream(data));
					img = ImageLoader.Load(this.TextureSize, data.Length, format, sr, 1, -1);
				}
				return img; 
			}
			set 
			{ 
				datatype = MipMapType.Texture;
				data = null;
				img = value; 
			}
		}

		public byte[] Data 
		{
			get { return data; }
			set { 
				datatype = MipMapType.SimPE_PlainData;
				data = value; 
			}
		}

		#endregion

		//Rcol parent;
		/*public Rcol Parent 
		{
			get { return parent; }
		}*/

		/// <summary>
		/// Constructor
		/// </summary>
		public LevelInfo(Interfaces.IProviderRegistry provider, Rcol parent) : base(provider, parent)
		{
			texturesize = new Size(0, 0);
			zlevel =0;
			sgres = new SGResource(provider, null);
			BlockID = 0xED534136;
			data = new byte[0];
			datatype = MipMapType.SimPE_PlainData;
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			string s = reader.ReadString();

			sgres.BlockID = reader.ReadUInt32();
			sgres.Unserialize(reader);
			

			if (Parent.Fast) 
			{
				texturesize = new Size(0, 0);
				img = null;
				return;
			}

			int w = reader.ReadInt32();
			int h = reader.ReadInt32();
			texturesize = new Size(w, h);
			zlevel = reader.ReadInt32();

			int size = reader.ReadInt32();
			
			
			/*if (size == w*h) format = ImageLoader.TxtrFormats.DXT3Format;
			else*/ format = ImageLoader.TxtrFormats.DXT1Format;
			//Pumckl Contribution
			//-- 8< --------------------------------------------- 8< -----
			if (size == 4 * w * h) format = ImageLoader.TxtrFormats.Raw32Bit;
			else if (size == 3 * w * h) format = ImageLoader.TxtrFormats.Raw24Bit;
			else if (size == w * h)  // could be RAW8, DXT3 or DXT5
			{ 
				// it seems to be difficult to determine the right format
				if (sgres.FileName.IndexOf("bump")>0)
				{ // its a bump-map
					format = ImageLoader.TxtrFormats.Raw8Bit;
				}
				else
				{
					// i expect the upper left 4x4 corner of the pichture have
					// all the same alpha so i can determine if it's DXT5 
					// i guess, it's somewhat dirty but what can i do else?
					long pos = reader.BaseStream.Position;  
					ulong alpha = reader.ReadUInt64(); // read the first 8 byte of the image
					reader.BaseStream.Position = pos;
					// on DXT5 if all alpha are the same the bytes 0 or 1 are not zero
					// and the bytes 2-7 (codebits) ara all zero
					if (((alpha & 0xffffffffffff0000) == 0) && ((alpha & 0xffff) != 0))
						format = ImageLoader.TxtrFormats.DXT5Format;
					else
						format = ImageLoader.TxtrFormats.DXT3Format;
				}
			}
			else format = ImageLoader.TxtrFormats.DXT1Format; // size < w*h
			//-- 8< --------------------------------------------- 8< -----

			
			long p1 =reader.BaseStream.Position;
			size = (int)(reader.BaseStream.Length-p1);

			/*if (!Helper.DebugMode) 
			{
				datatype = MipMapType.Texture;
				img = ImageLoader.Load(texturesize, size, format, reader, -1, 1);
				reader.BaseStream.Seek(p1, System.IO.SeekOrigin.Begin);
			} 
			else */
			{
				datatype = MipMapType.SimPE_PlainData;
			}
			
			data = reader.ReadBytes(size);			
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
			writer.Write(version);
			string s = sgres.Register(null);
			writer.Write(s);
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);

			writer.Write((int)texturesize.Width);
			writer.Write((int)texturesize.Height);
			writer.Write(zlevel);

			if (datatype == MipMapType.Texture) data = ImageLoader.Save(format, img);
			
			if (data==null) data = new byte[0];
			writer.Write((int)data.Length);
			writer.Write(data);
		}
		#endregion

	}
}
