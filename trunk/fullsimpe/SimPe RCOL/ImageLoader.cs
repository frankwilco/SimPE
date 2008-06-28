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
	/// Class used to return DDS Data
	/// </summary>
	public class DDSData 
	{
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="data">The Image Data</param>
		/// <param name="sz">The ParentSize (biggest MipMap Size)</param>
		/// <param name="format">the Format it uses</param>
		/// <param name="level">Index of theis Map in the Block (0 beeing the smallest Map)</param>
		/// <param name="count">Number of Items in the Block</param>
		public DDSData (byte[] data, Size sz, ImageLoader.TxtrFormats format, int level, int count) 
		{
			this.format = format;
			this.size = sz;
			this.data = data;
			img = null;
			this.level = level;
			this.count = count;
		}

		int level, count;

		/// <summary>
		/// Contains the Format of the Data
		/// </summary>
		ImageLoader.TxtrFormats format;
		/// <summary>
		/// Returns / Sets the format of the Textures
		/// </summary>
		public ImageLoader.TxtrFormats Format
		{
			get { return format; }
			set { format = value; }
		}

		//image Size
		Size size;
		/// <summary>
		/// Returns / Sets the Size of the Image
		/// </summary>
		public Size ParentSize 
		{
			get { return size; }
			set { size = value; }
		}

		/// <summary>
		/// Image Data
		/// </summary>
		byte[] data;
		/// <summary>
		/// Returns sets the Image Data
		/// </summary>
		public byte[] Data 
		{
			get { return data; }
			set { data = value; }
		}

		Image img;
		/// <summary>
		/// This will generate the Image
		/// </summary>
		public Image Texture 
		{
			get 
			{
				if (img == null) 
					img = ImageLoader.Load(size, data.Length, format, new System.IO.BinaryReader(new System.IO.MemoryStream(data)), -1, count);
				return img;
			}
		}
	}

	/// <summary>
	/// Provides static Methods to process severeal Image Data
	/// </summary>
	public class ImageLoader
	{
		public enum TxtrFormats:uint 
		{
			Unknown = 0x0,
			Raw32Bit = 0x1,
			Raw24Bit = 0x2,
			ExtRaw8Bit = 0x3,
			DXT1Format = 0x4,
			DXT3Format = 0x5,
			Raw8Bit = 0x6,
			DXT5Format = 0x8,
			ExtRaw24Bit =0x9
		}

		/// <summary>
		/// Lodas the MipMap Data from a DDS File
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <returns>all Datablocks (Biggest Map first)</returns>
		/// <exception cref="Exception">Thrown if the Signature is unknown</exception>
		public static DDSData[] ParesDDS(string flname) 
		{
			if (!System.IO.File.Exists(flname)) return new DDSData[0];

			DDSData[] maps = new DDSData[0];
			//open the File
			System.IO.FileStream fs = System.IO.File.OpenRead(flname);
			try 
			{
				System.IO.BinaryReader reader = new System.IO.BinaryReader(fs);
				fs.Seek(0x0c, System.IO.SeekOrigin.Begin);
				int hg = reader.ReadInt32();
				int wd = reader.ReadInt32();
				Size sz = new Size(wd, hg);
				int firstsize = reader.ReadInt32();
				int unknown = reader.ReadInt32();
				maps = new DDSData[reader.ReadInt32()];

				fs.Seek(0x54, System.IO.SeekOrigin.Begin);
				string sig = Helper.ToString(reader.ReadBytes(0x04));
				TxtrFormats format;
				if (sig=="DXT1") format = TxtrFormats.DXT1Format;
				else if (sig=="DXT3") format = TxtrFormats.DXT3Format;
				else if (sig=="DXT5") format = TxtrFormats.DXT5Format;
				else throw new Exception("Unknown DXT Format "+sig);

				fs.Seek(0x80, System.IO.SeekOrigin.Begin);
				int blocksize = 0x10;
				if (format == TxtrFormats.DXT1Format) blocksize = 0x8;
				for (int i=0; i<maps.Length; i++) 
				{
					byte [] d = reader.ReadBytes(firstsize);
					maps[i] = new DDSData(d, sz, format, (maps.Length-(i+1)), maps.Length);

					sz = new Size(Math.Max(1, sz.Width / 2), Math.Max(1, sz.Height / 2));					
					firstsize = Math.Max(1, sz.Width / 4) * Math.Max(1, sz.Height / 4) * blocksize;	
				}
			} 
			finally 
			{
				fs.Close();
				fs.Dispose();
				fs = null;
			}

			return maps;
		}

		/// <summary>
		/// Tries to load an Image from the datasource
		/// </summary>
		/// <param name="imgDimension">Maximum Dimensions of the Image (used to determin the aspect ration</param>
		/// <param name="datasize">Number of bytes used for the image in the Stream</param>
		/// <param name="format">FOrmat of the Image</param>
		/// <param name="reader">A Binary Reader. Position must be the start of the Image Data</param>
		/// <param name="level">The index of the Texture in the current MipMap use -1 if you don't want to specify an Level</param>
		/// <param name="levelcount">Number of Levels stored in the MipMap</param>
		/// <returns>null or a valid Image</returns>
		public static Image Load(Size imgDimension, int datasize, TxtrFormats format, System.IO.BinaryReader reader, int level, int levelcount) 
		{
			Image img = null;
			
			int wd = imgDimension.Width;
			int hg = imgDimension.Height;
			if (level!=-1) 
			{
				int revlevel = Math.Max(0, levelcount - (level+1));

				
				for (int i=0; i<revlevel; i++) 
				{
					wd /= 2;
					hg /= 2;
				}
			}
					
			wd = Math.Max(1, wd);
			hg = Math.Max(1, hg);

			if (format==ImageLoader.TxtrFormats.DXT1Format) datasize = (wd * hg) / 2;			
			else if (format==ImageLoader.TxtrFormats.Raw24Bit) datasize = (wd * hg)* 3;
			else if (format==ImageLoader.TxtrFormats.Raw32Bit) datasize = (wd * hg) * 4;
			else datasize = (wd * hg);
				
			if ((format==ImageLoader.TxtrFormats.DXT1Format)  || (format==ImageLoader.TxtrFormats.DXT3Format)|| (format==ImageLoader.TxtrFormats.DXT5Format))
			{
				img = ImageLoader.DXT3Parser(imgDimension, format, datasize, reader, wd, hg);
			}
			else if ((format == ImageLoader.TxtrFormats.ExtRaw8Bit) || (format==ImageLoader.TxtrFormats.Raw8Bit)  || (format==ImageLoader.TxtrFormats.Raw24Bit)  ||(format==ImageLoader.TxtrFormats.Raw32Bit) || (format==ImageLoader.TxtrFormats.ExtRaw24Bit)) 
			{
				img = ImageLoader.RAWParser(imgDimension, format,  datasize, reader, wd, hg);
			}
			

			return img;
		}

		/// <summary>
		/// Creates a Byte array for the passed Image
		/// </summary>
		/// <param name="format">The Format you want to store the Image in</param>
		/// <param name="img">The Image</param>
		/// <returns>A Byte array containing the Image Data</returns>
		public static byte[] Save(TxtrFormats format, Image img)
		{
			byte[] data = new byte[0];

			if (img!=null) 
			{
				if ((format==ImageLoader.TxtrFormats.DXT1Format)  || (format==ImageLoader.TxtrFormats.DXT3Format)|| (format==ImageLoader.TxtrFormats.DXT5Format))
				{
					data = ImageLoader.DXT3Writer(img, format);
				} 
				else if ((format == ImageLoader.TxtrFormats.ExtRaw8Bit) || (format==ImageLoader.TxtrFormats.Raw8Bit)  || (format==ImageLoader.TxtrFormats.Raw24Bit)  ||(format==ImageLoader.TxtrFormats.Raw32Bit) || (format==ImageLoader.TxtrFormats.ExtRaw24Bit)) 
				{
					data = ImageLoader.RAWWriter(img, format);
				} 
			}

			return data;
		}

		

		public static Image RAWParser(Size parentsize, TxtrFormats format, int imgsize, System.IO.BinaryReader reader, int w, int h)
		{
			double scale = ((double)parentsize.Width / (double)parentsize.Height);

			/*int w = 0;
			int h = 0;
			if ( (format == TxtrFormats.Raw24Bit)  || (format == TxtrFormats.ExtRaw24Bit))
			{
				h = Convert.ToInt32(Math.Sqrt((imgsize/3) / scale));
				w = Convert.ToInt32(h * scale);
			} 
			else if ( format == TxtrFormats.Raw32Bit)
			{
				h = Convert.ToInt32(Math.Sqrt((imgsize/4) / scale));
				w = Convert.ToInt32(h * scale);
			}
			else 
			{
				h = Convert.ToInt32(Math.Sqrt((imgsize) / scale));
				w = Convert.ToInt32(h * scale);
			}
			if ((w==0) || (h==0)) return new Bitmap(1, 1);*/

			w = Math.Max(1, w);
			h = Math.Max(1, h);

			
			Bitmap bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			for (int y=0; y<bmp.Height; y++) 
			{
				for (int x=0; x<bmp.Width; x++) 
				{
					byte a = 0xff;
					byte r = 0;
					byte g = 0;
					byte b = 0;
					
					
					b = reader.ReadByte();
					if ((format != TxtrFormats.Raw8Bit) && (format != TxtrFormats.ExtRaw8Bit) )
					{
						g = reader.ReadByte();
						r = reader.ReadByte();
						
						if ( (format == TxtrFormats.Raw32Bit)) a=reader.ReadByte();
						bmp.SetPixel(x, y, Color.FromArgb(a, r, g, b));
					} 
					else 
					{
						
						bmp.SetPixel(x, y, Color.FromArgb(a, b, b, b));
					}	
				}
			}

			return bmp;
		}

		public static byte[] RAWWriter(Image img, TxtrFormats format)
		{
			if (img==null) return new byte[0];
			
			System.IO.BinaryWriter writer = new System.IO.BinaryWriter(new System.IO.MemoryStream());

			Bitmap bmp = (Bitmap)img;
			for (int y=0; y<bmp.Height; y++) 
			{
				for (int x=0; x<bmp.Width; x++) 
				{
					Color c = bmp.GetPixel(x, y);
					
					writer.Write((byte)c.B);
					if ((format != TxtrFormats.Raw8Bit) && (format != TxtrFormats.ExtRaw8Bit))
					{
						writer.Write((byte)c.G);
						writer.Write((byte)c.R);
						if ( (format == TxtrFormats.Raw32Bit)) writer.Write((byte)c.A);
					}	
				}
			}

			System.IO.BinaryReader reader = new System.IO.BinaryReader(writer.BaseStream);
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
			return reader.ReadBytes((int)reader.BaseStream.Length);
		}

		//
		// DXT1 RGB, DXT3, DXT5 Parser
		// DXT1 RGBA ist nicht behandelt weil nicht bekannt ist welchen Wert
		// 	format hat. Code ist auskommentiert!
		//
		public static Image DXT3Parser(Size parentsize, TxtrFormats format, int imgsize, System.IO.BinaryReader reader, int wd, int hg)
		{						
			Bitmap bm = null;			
			try 
			{
				double ration =	((double) parentsize.Width) / 
					((double) parentsize.Height);

				if ((format == TxtrFormats.DXT3Format) || (format == TxtrFormats.DXT5Format) /* || (format == DXT1 RGBA) */)
				{
					//hg = Convert.ToInt32(Math.Sqrt(((double) imgsize) / ration));
					//wd = Convert.ToInt32((double) (hg * ration));
					if ((wd == 0) || (hg == 0))
					{
						return new Bitmap(Math.Max(1, wd), Math.Max(1, hg));
					}
					bm = new Bitmap(wd, hg, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
				}
				else
				{
					//hg = Convert.ToInt32(Math.Sqrt(((double) (2 * imgsize)) / ration));
					//wd = Convert.ToInt32((double) (hg * ration));
					if ((wd == 0) || (hg == 0))
					{
						return new Bitmap(Math.Max(1, wd), Math.Max(1, hg));
					}
					bm = new Bitmap(wd, hg, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
				}
			
				//
				int[] Alpha = new int[16]; // FH: für Alpha reicht hier [4 * 4] !!!!
				for (int y = 0; y < bm.Height; y += 4) // DXT encodes 4x4 blocks of pixel
				{
					for (int x = 0; x < bm.Width; x += 4)
					{
						// decode the alpha data (DXT3)
						if (format == TxtrFormats.DXT3Format) 
						{
							long abits = reader.ReadInt64();
							// 16 alpha values are here, one for each pixel, each 4 bits long
							for (int i = 0; i < 16; i++)
							{
								Alpha[i] = (int) ((abits & 0xf) * 0x11);	// je 4 bit herausschieben
								abits >>= 4;
							} // for by
						} 					
						else if (format == TxtrFormats.DXT5Format) // DXT5
						{
							int alpha1 = reader.ReadByte();
							int alpha2 = reader.ReadByte();
							long abits = (long)reader.ReadUInt32() | ((long)reader.ReadUInt16() << 32);
							int[] alphas = new int[8]; // holds the calculated alpha values
							alphas[0] = alpha1;
							alphas[1] = alpha2;
							if (alpha1 > alpha2)
							{
								alphas[2] = (6 * alpha1 + alpha2) / 7;
								alphas[3] = (5 * alpha1 + 2 * alpha2) / 7;
								alphas[4] = (4 * alpha1 + 3 * alpha2) / 7;
								alphas[5] = (3 * alpha1 + 4 * alpha2) / 7;
								alphas[6] = (2 * alpha1 + 5 * alpha2) / 7;
								alphas[7] = (alpha1 + 6 * alpha2) / 7;							
							} 
							else 
							{
								alphas[2] = (4 * alpha1 + alpha2) / 5;
								alphas[3] = (3 * alpha1 + 2 * alpha2) / 5;
								alphas[4] = (2 * alpha1 + 3 * alpha2) / 5;
								alphas[5] = (1 * alpha1 + 4 * alpha2) / 5;
								alphas[6] = 0;
								alphas[7] = 0xff;
							}
							for (int i = 0; i < 16; i++)
							{
								Alpha[i] = alphas[abits & 7];	// je 3 bit als Code herausschieben
								abits >>= 3;
							}						
						} // if format..
				
						// decode the DXT1 RGB data
						// two 16 bit encoded colors (red 5, green 6, blue 5 bits)
			
						int c1packed16 = reader.ReadUInt16(); 
						int c2packed16 = reader.ReadUInt16(); 
						// separate R,G,B
						int color1r = Convert.ToByte(((c1packed16 >> 11) & 0x1F) * 8.2258064516129032258064516129032);
						int color1g = Convert.ToByte(((c1packed16 >> 5) & 0x3F) * 4.047619047619047619047619047619);
						int color1b = Convert.ToByte((c1packed16 & 0x1F) * 8.2258064516129032258064516129032);
					
						int color2r = Convert.ToByte(((c2packed16 >> 11) & 0x1F) * 8.2258064516129032258064516129032);
						int color2g = Convert.ToByte(((c2packed16 >> 5) & 0x3F) * 4.047619047619047619047619047619);
						int color2b = Convert.ToByte((c2packed16 & 0x1F) * 8.2258064516129032258064516129032);
				
						// FH: colors definieren wir gleich als Color
						Color[] colors = new Color[4];
						// colors 0 and 1 point to the two 16 bit colors we read in
						colors[0] = Color.FromArgb(color1r, color1g, color1b);
						colors[1] = Color.FromArgb(color2r, color2g, color2b);
					
						// FH: DXT1 RGB? Reihenfolge wichtig!
						/*if ((format == TxtrFormats.DXT1Format) && (c1packed16 <= c2packed16)) 
						{
							// 1/2 color 1, 1/2 color2					
							colors[2] = Color.FromArgb(
								((color1r + color2r) >> 1) & 0xff,
								((color1g + color2g) >> 1) & 0xff,
								((color1b + color2b) >> 1) & 0xff);
							// BLACK
							colors[3] = Color.Black;
						} 
						else // Alle anderen*/
					{
						// 2/3 color 1, 1/3 color2					
						colors[2] = Color.FromArgb(
							(((color1r << 1) + color2r) / 3) & 0xff,
							(((color1g << 1) + color2g) / 3) & 0xff,
							(((color1b << 1) + color2b) / 3) & 0xff);
			
						// 2/3 color2, 1/3 color1
						colors[3] = Color.FromArgb(
							(((color2r << 1) + color1r) / 3) & 0xff,
							(((color2g << 1) + color1g) / 3) & 0xff,
							(((color2b << 1) + color1b) / 3) & 0xff);					
					}
			
						// read in the color code bits, 16 values, each 2 bits long
						// then look up the color in the color table we built
						uint cbits = reader.ReadUInt32(); 
						for (int by = 0; by < 4; by++)
						{
							for (int bx = 0; bx < 4; bx++)
							{
								try
								{
									if (((x + bx) < wd) && ((y + by) < hg))
									{
										uint code = (cbits >> (((by << 2) + bx) << 1)) & 3;
										if ((format == TxtrFormats.DXT3Format) || (format == TxtrFormats.DXT5Format))
										{
											bm.SetPixel(x + bx, y + by, Color.FromArgb(Alpha[(by << 2) + bx], colors[code]));
										}
										else
										{
											// if (format == DXT1_RGBA)
											// {
											//	if ((c1packed16 <= c2packed16) && (code == 3))
											//	{
											//		bm.SetPixel(x + bx, y + by, Color.FromArgb(0, colors[code]);
											//	} else {
											//		bm.SetPixel(x + bx, y + by, Color.FromArgb(255, colors[code]);
											//	}
											// } else {
											bm.SetPixel(x + bx, y + by, colors[code]);
											// }
										}
									}
								}
								catch (Exception exception1)
								{
									Helper.ExceptionMessage("", exception1);
								}
							}
						} // for by
					} // for x
				} // for y
				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}

			return bm;
		}

		protected static void DXT3WriteTransparencyBlock(System.IO.BinaryWriter writer, Color[] alphas) 
		{
			ushort col = 0;
			for (int i=alphas.Length-1; i>=0; i--) 
			{
				byte a = (byte)((alphas[i].A * 0xf) / 0xff);
				col = (ushort)(col << 4);
				col = (ushort)(col | (byte)(a & 0x0f));
			}

			writer.Write(col);
		}

		protected static void DXT5WriteTransparencyBlock(System.IO.BinaryWriter writer, Color[] alphas) 
		{
			byte[] table = new byte[8];
			table[0] = 0x00;
			table[1] = 0xff;

			// find extremes
			foreach (Color c in alphas) 
			{
				if (c.A>table[0]) table[0]=c.A;
				if (c.A<table[1]) table[1]=c.A;
			}

			//calculate interpolated Alphas
			table[2] = (byte)((6 * table[0] + table[1]) / 7);
			table[3] = (byte)((5 * table[0] + 2 * table[1]) / 7);
			table[4] = (byte)((4 * table[0] + 3 * table[1]) / 7);
			table[5] = (byte)((3 * table[0] + 4 * table[1]) / 7);
			table[6] = (byte)((2 * table[0] + 5 * table[1]) / 7);
			table[7] = (byte)((table[0] + 6 * table[1]) / 7);
	
			long abits = 0;
			for(int k=alphas.Length-1; k>=0; k--)
			{
				Color c = alphas[k];
				int index = 0;
				int delta = int.MaxValue;
				for (int i=0; i<table.Length; i++)
				{
					if (Math.Abs(c.A - table[i])<delta) 
					{
						delta = Math.Abs(c.A - table[i]);
						index = i;
					}
				}

				abits = abits << 3;
				abits = abits | (uint)index;
			}

			ushort abits1 = (ushort)((abits >> 32) & 0x0000ffff);
			uint abits2 = (uint)(abits & 0xffffffff);

			writer.Write(table[0]);
			writer.Write(table[1]);
			writer.Write(abits2);
			writer.Write(abits1);
		}

		/// <summary>
		/// Calculates the §D Distance of two Colors
		/// </summary>
		/// <param name="table">First Color</param>
		/// <param name="test">Second Color</param>
		/// <returns>Distanc Value</returns>
		protected static double DXT3ColorDist(Color table, Color test) 
		{
			return Math.Pow(table.R - test.R, 2) + Math.Pow(table.G - test.G, 2) + Math.Pow(table.B - test.B, 2);
		}

		protected static byte DXT3NearestTableColor(Color[] table, Color col)
		{
			double delta = double.MaxValue;
			int dindex = 0;

			for (int i=0; i<4; i++)
			{
				//float dumdelta = Math.Abs(table[i].GetBrightness() - col.GetBrightness());
				//float dumdelta = Math.Abs(table[i].ToArgb() - col.ToArgb());
				double dumdelta = DXT3ColorDist(table[i], col);
				/*int dumdelta = 0;

				dumdelta += Math.Abs(table[i].R - col.R);
				dumdelta += Math.Abs(table[i].G - col.G);
				dumdelta += Math.Abs(table[i].B - col.B);*/

				if (dumdelta < delta) 
				{
					delta = dumdelta;
					dindex = i;
				}

				
			}

			return (byte)(dindex & 3);
		}

		protected static void DXT3MinColor(ref Color table, Color test)
		{
			//if (DXT3ColorDist(table, test) > DXT3ColorDist(test, table)) table= test;
			//if (table.GetBrightness() > test.GetBrightness()) table=test;
			if (table.ToArgb() > test.ToArgb()) table=test;
			/*if (test.R<table.R) table = Color.FromArgb(table.A, test.R, table.G, table.B);
			if (test.G<table.G) table = Color.FromArgb(table.A, table.R, test.G, table.B);
			if (test.B<table.B) table = Color.FromArgb(table.A, table.R, table.G, test.B);*/
		}

		

		protected static void DXT3MaxColor(ref Color table, Color test)
		{
			//if (DXT3ColorDist(table, test) < DXT3ColorDist(test, table)) table= test;
			//if (table.GetBrightness() < test.GetBrightness()) table=test;
			if (table.ToArgb() < test.ToArgb()) table=test;
			/*if (test.R>table.R) table = Color.FromArgb(table.A, test.R, table.G, table.B);
			if (test.G>table.G) table = Color.FromArgb(table.A, table.R, test.G, table.B);
			if (test.B>table.B) table = Color.FromArgb(table.A, table.R, table.G, test.B);*/
		}

		protected static Color DXT3MixColors(Color c1, Color c2, double f1, double f2)
		{
			byte r = Convert.ToByte(c1.R * f1 + c2.R * f2);
			byte g = Convert.ToByte(c1.G * f1 + c2.G * f2);
			byte b = Convert.ToByte(c1.B * f1 + c2.B * f2);

			return Color.FromArgb(0xff, r, g, b);
		}

		protected static short DXT3Get565Color(Color col)
		{
			int res = 0;

			res = ((col.R * 0x1f) / 0xff) & 0x1f;

			res = res << 6;
			res |= ((col.G * 0x3f) / 0xff) & 0x3f;
			
			res = res << 5;
			res |= ((col.B * 0x1f) / 0xff) & 0x1f;

			return (short)res;
		}

		protected static void DXT3WriteTexel(System.IO.BinaryWriter writer, Color[,] colors, TxtrFormats format) 
		{
			Color[] table = new Color[4];
			table[0] = Color.White;
			table[1] = Color.Black;
			

			//find extreme Colors
			for (byte y=0; y<4; y++) 
			{
				for (byte x=0; x<4; x++) 
				{
					Color dum = colors[x, y];

					DXT3MinColor(ref table[0], dum);
					DXT3MaxColor(ref table[1], dum);
				}
			}

			//invert the Color Order
			//if ((format==TxtrFormats.DXT1Format) && (table[0].ToArgb()<=table[1].ToArgb()) )
			if ((table[0].ToArgb()<=table[1].ToArgb()) )
			{
				table[2] = DXT3MixColors(table[0], table[1], 1.0/2, 1.0/2);
				table[3] = Color.Black;
			} 
			else 
			{
				//build color table
				table[2] = DXT3MixColors(table[0], table[1], 2.0/3, 1.0/3);
				table[3] = DXT3MixColors(table[0], table[1], 1.0/3, 2.0/3);
			}

			writer.Write(DXT3Get565Color(table[0]));
			writer.Write(DXT3Get565Color(table[1]));

			//write Colors
			for (short y=0; y<4; y++) 
			{
				int dum = 0;
				for (short x=3; x>=0; x--) 
				{
					dum = dum << 2;
					dum = dum | (DXT3NearestTableColor(table, colors[x, y]));
				}
				writer.Write((byte)dum);
			}
		}

		public static byte[] DXT3Writer(Image img, TxtrFormats format)
		{
			if (img==null) return new byte[0];
			System.IO.BinaryWriter writer = new System.IO.BinaryWriter(new System.IO.MemoryStream());

			Bitmap bmp = (Bitmap)img;

			int[] imageSourceAlpha = new int[bmp.Width * bmp.Height];

			for (int y=0;y<bmp.Height;y+=4) // DXT encodes 4x4 blocks of pixels
			{
				for (int x=0;x<bmp.Width;x+=4)
				{
					// decode the alpha data
					if (format == TxtrFormats.DXT3Format) // DXT3 has 64 bits of alpha data, then 64 bits of DXT1 RGB data
					{
						// DXT3 Alpha
						// 16 alpha values are here, one for each pixel, each is 4 bits long
						Color[] alphas = new Color[4];

						for (int by=0;by<4;++by)
						{
							for (int bx=0;bx<4;++bx)
							{

								if ((x+bx<bmp.Width) && (y+by<bmp.Height)) 
								{
									alphas[bx] = bmp.GetPixel(x+bx, y+by);
								} 
								else 
								{
									alphas[bx] = Color.Black;
								}
							}

							DXT3WriteTransparencyBlock(writer, alphas);
						}
					} 
					else if (format == TxtrFormats.DXT5Format) 
					{
						Color[] alphas = new Color[16];
						for (int by=0;by<4;++by)
						{
							for (int bx=0;bx<4;++bx)
							{

								if ((x+bx<bmp.Width) && (y+by<bmp.Height)) 
								{
									alphas[by*4 + bx] = bmp.GetPixel(x+bx, y+by);
								} 
								else 
								{
									alphas[by*4 + bx] = Color.Black;
								}
							}
						}
						DXT5WriteTransparencyBlock(writer, alphas);
					}

					Color[,] colors = new Color[4,4];
					for (int by=0;by<4;++by)
					{
						for (int bx=0;bx<4;++bx)
						{
							try 
							{
								if ((x+bx<bmp.Width) && (y+by<bmp.Height)) 
								{
									colors[bx,by] = bmp.GetPixel(x+bx, y+by);
								} 
								else 
								{
									colors[bx,by] = Color.Black;
								}
							} 
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("", ex);
							}
						}
					}

					DXT3WriteTexel(writer, colors, format);
				} // for x
			}// for y
			
			System.IO.BinaryReader reader = new System.IO.BinaryReader(writer.BaseStream);
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
			return reader.ReadBytes((int)reader.BaseStream.Length);
		}

		/// <summary>
		/// Creates a Preview with the correct Aspect Ration
		/// </summary>
		/// <param name="img">The Image you want to preview</param>
		/// <param name="sz">Size of te Preview Image</param>
		/// <returns>The Preview image</returns>
		public static Image Preview(Image img, Size sz)
		{
			Image prev = new Bitmap(sz.Width, sz.Height);

			if (img==null) return prev;
			Graphics g = Graphics.FromImage(prev);
			g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

			double ratio = (double)img.Height / (double)img.Width;
			int wd = sz.Width;
			int hg = (int)Math.Round(wd * ratio);

			if (hg>sz.Height) 
			{
				hg = sz.Height;
				wd = (int)Math.Round(hg / ratio);
			}

			//g.FillRectangle(new Pen(Color.Black).Brush, 0, 0, sz.Width, sz.Height);
			g.DrawImage(img, new Rectangle((sz.Width - wd) / 2, (sz.Height - hg) / 2, wd, hg), new Rectangle(0, 0, img.Width, img.Height), System.Drawing.GraphicsUnit.Pixel);
				
			return prev;
		}

		#region OldCode
		/*
		protected static byte Get5Bits(System.IO.BinaryReader reader, ref int tmp, ref int bitct) 
		{
			if ((bitct+5)<=0x10) 
			{
				int ret = tmp & 0x1F;
				tmp = tmp >> 5; bitct += 5;
				return (byte)ret;
			} 
			else if (bitct==0x10)
			{
				tmp = reader.ReadUInt16();
				bitct = 5;
				int ret = tmp & 0x1F;
				tmp = tmp >> 5;
				return (byte)ret;
			} 
			else
			{
				bitct = 0x10 - bitct;
				int mask = (1 << bitct) - 1;

				int ret = tmp & mask;

				tmp = reader.ReadUInt16();
				bitct = 5-bitct;
				mask = (1 << bitct) - 1;
				ret = (ret << bitct) + (tmp & mask);
				tmp = tmp >> bitct;
				return (byte)ret;
			} 
			
		}

		protected static Image RAW15Parser(Size parentsize, TxtrFormats format, int imgsize, System.IO.BinaryReader reader)
		{
			double scale = ((double)parentsize.Width / (double)parentsize.Height);

			int w = 0;
			int h = 0;
			if ((uint)format == 0x09) 
			{
				h = Convert.ToInt32(Math.Sqrt((imgsize/1.875) / scale));
				w = Convert.ToInt32(h * scale);
			}

			Bitmap bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			int tmp = reader.ReadUInt16();
			int bitct = 0;
			for (int y=0; y<bmp.Height; y++) 
			{
				for (int x=0; x<bmp.Width; x++) 
				{
					byte r = Get5Bits(reader, ref tmp, ref bitct);
					byte g = Get5Bits(reader, ref tmp, ref bitct);
					byte b = Get5Bits(reader, ref tmp, ref bitct);

					bmp.SetPixel(x, y, Color.FromArgb(r, g, b));
				}
			}

			return bmp;
		}*/
		/*protected Image DXT3Parser(int imgsize, System.IO.BinaryReader reader)
		{
			double scale = ((double)parentsize.Width / (double)parentsize.Height);

			int w;
			int h;
			Bitmap bmp;
			if ((format == TxtrFormats.DXT3Format) || (format == TxtrFormats.ExtDXT3Format)) 
			{
				h = Convert.ToInt32(Math.Sqrt(imgsize / scale));
				w = Convert.ToInt32(h * scale);
				if ((w==0) || (h==0)) return new Bitmap(1, 1);
				bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
			} 
			else 
			{
				h = Convert.ToInt32(Math.Sqrt((2*imgsize) / scale));
				w = Convert.ToInt32(h * scale);
				if ((w==0) || (h==0)) return new Bitmap(1, 1);
				bmp = new Bitmap(w, h, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			}

			
			

			int[] imageSourceAlpha = new int[bmp.Width * bmp.Height];

			for (int y=0;y<bmp.Height;y+=4) // DXT encodes 4x4 blocks of pixels
			{
				for (int x=0;x<bmp.Width;x+=4)
				{
					// decode the alpha data
					if ((format == TxtrFormats.DXT3Format) || (format == TxtrFormats.ExtDXT3Format)) // DXT3 has 64 bits of alpha data, then 64 bits of DXT1 RGB data
					{
						// DXT3 Alpha
						// 16 alpha values are here, one for each pixel, each is 4 bits long
						int abits1 = reader.ReadByte() | (reader.ReadByte() << 8) | (reader.ReadByte() << 16) | (reader.ReadByte() << 24);
						int abits2 = reader.ReadByte() | (reader.ReadByte() << 8) | (reader.ReadByte() << 16) | (reader.ReadByte() << 24);
						for (int by=0;by<4;++by)
						{
							for (int bx=0;bx<4;++bx)
							{
								if ((x+bx<w) && (y+by<h)) 
								{
									int bits;
									if (by < 2)
										bits = ((abits1 >> (((by<<2)+bx)<<2))&0xF)<<4;
									else
										bits = ((abits2 >> ((((by-2)<<2)+bx)<<2))&0xF)<<4;
								
								
									int col = (int)(0xFF000000 | (bits << 16) | (bits << 8) | bits);
									imageSourceAlpha[(y+by)*bmp.Width+x+bx] = col  >> 24;
								
								}
							}
						}
					}

					// decode the DXT1 RGB data

					// two 16 bit encoded colors (red 5 bits, green 6 bits, blue 5 bits)
					int c1packed16 = reader.ReadByte() | (reader.ReadByte() << 8);
					int c2packed16 = reader.ReadByte() | (reader.ReadByte() << 8);

					// separate the R,G,B values
					int color1r = (c1packed16 >> 8) & 0xF8;
					int color1g = (c1packed16 >> 3) & 0xFC;
					int color1b = (c1packed16 << 3) & 0xF8;

					int color2r = (c2packed16 >> 8) & 0xF8;
					int color2g = (c2packed16 >> 3) & 0xFC;
					int color2b = (c2packed16 << 3) & 0xF8;

					int[] colors = new int[8]; // color table for all possible codes
						// colors 0 and 1 point to the two 16 bit colors we read in
					colors[0] = (int)(((color1r << 16) | (color1g << 8)) | (color1b | 0xFF000000));
					colors[1] = (int)((color2r << 16) | (color2g << 8) | color2b  | 0xFF000000);

					// 2/3 Color1, 1/3 color2
					int colorr = (((color1r<<1) + color2r) / 3) & 0xFF;
					int colorg = (((color1g<<1) + color2g) / 3) & 0xFF;
					int colorb = (((color1b<<1) + color2b) / 3) & 0xFF;
					colors[2] = (int)((colorr << 16) | (colorg << 8) | colorb  | 0xFF000000);

					// 2/3 Color2, 1/3 color1
					colorr = (((color2r<<1) + color1r) / 3) & 0xFF;
					colorg = (((color2g<<1) + color1g) / 3) & 0xFF;
					colorb = (((color2b<<1) + color1b) / 3) & 0xFF;
					colors[3] = (int)((colorr << 16) | (colorg << 8) | colorb  | 0xFF000000);

					// read in the color code bits, 16 values, each 2 bits long
					// then look up the color in the color table we built
					int bts = reader.ReadByte() + (reader.ReadByte() << 8) + (reader.ReadByte() << 16) + (reader.ReadByte() << 24);

					for (int by=0;by<4;++by)
					{
						for (int bx=0;bx<4;++bx)
						{
							try 
							{
								if ((x+bx<w) && (y+by<h)) 
								{
									int code = (bts >> (((by<<2)+bx)<<1))&0x3;

									if ((format == TxtrFormats.DXT3Format) || (format == TxtrFormats.ExtDXT3Format)) bmp.SetPixel(x+bx, y+by, Color.FromArgb((byte)imageSourceAlpha[(y+by)*bmp.Width+x+bx], Color.FromArgb(colors[code]& 0x00ffffff)));
									else bmp.SetPixel(x+bx, y+by, Color.FromArgb(colors[code] & 0x00ffffff));
								}
							} 
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("", ex);
							}
						}
					}
				} // for x
			}// for y
			
			img = bmp;
			return bmp;
		}*/
		#endregion

		public static System.Drawing.Imaging.ImageFormat GetImageFormat(string name) 
		{
			name = name.Trim().ToLower();

			if (name.EndsWith(".png")) return System.Drawing.Imaging.ImageFormat.Png;
			if (name.EndsWith(".bmp")) return System.Drawing.Imaging.ImageFormat.Bmp;
			if (name.EndsWith(".gif")) return System.Drawing.Imaging.ImageFormat.Gif;
			if (name.EndsWith(".jpg")) return System.Drawing.Imaging.ImageFormat.Jpeg;
			if (name.EndsWith(".jpeg")) return System.Drawing.Imaging.ImageFormat.Jpeg;
			if (name.EndsWith(".tif")) return System.Drawing.Imaging.ImageFormat.Tiff;
			if (name.EndsWith(".tiff")) return System.Drawing.Imaging.ImageFormat.Tiff;
			if (name.EndsWith(".emf")) return System.Drawing.Imaging.ImageFormat.Emf;
			if (name.EndsWith(".wmf")) return System.Drawing.Imaging.ImageFormat.Wmf;

			return System.Drawing.Imaging.ImageFormat.Png;
		}
	}
}
