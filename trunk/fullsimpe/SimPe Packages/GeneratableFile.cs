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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Packages
{
	
	/// <summary>
	/// Extends the Packges Files with writing Support
	/// </summary>
	public class GeneratableFile : ExtractableFile
	{
		/// <summary>
		/// Size of the Blocks written to the Filesystem
		/// </summary>
		private const uint BLOCKSIZE = 0x200;

		/// <summary>
		/// Cosntructor of the Class
		/// </summary>
		/// <param name="br">The BinaryReader representing the Package File</param>
		internal GeneratableFile(BinaryReader br) : base(br) {}	
		internal GeneratableFile(string flname) : base(flname) {}


		/// <summary>
		/// Init the Clone for this Package
		/// </summary>
		/// <returns>An INstance of this Class</returns>
		protected override Interfaces.Files.IPackageFile NewCloneBase() 
		{
			GeneratableFile fl = new GeneratableFile((BinaryReader)null);
			fl.header = this.header;
			
			return fl;
		}

		/// <summary>
		/// Compiles a new Package File from the currently stored Information
		/// </summary>
		/// <param name="flname">Filename for the Package</param>
		public void Build(string flname)
		{
			MemoryStream ms = Build();
			Save(ms, flname);
		}

		/// <summary>
		/// Stores the internal reader to the passed File (IncrementalBuild() will be called!)
		/// </summary>
		/// <remarks>This is Experimental and might not work properly</remarks>
		public void Save()
		{
			Save(this.FileName);
		}

		/// <summary>
		/// Stores the internal reader to the passed File (IncrementalBuild() will be called!)
		/// </summary>
		/// <param name="flname">The Filename you want to save the Package to</param>
		/// <remarks>This is Experimental and might not work properly</remarks>
		public void Save(string flname)
		{
			//this.IncrementalBuild();						
			System.IO.MemoryStream ms = this.Build();
			if (Reader!=null) 
				this.Reader.Close();
			this.Save(ms, flname);

			//this.reader =  new System.IO.BinaryReader(System.IO.File.OpenRead(flname));			
			this.FileName = flname;
			type = PackageBaseType.Filename;

			this.OpenReader();
			this.CloseReader();			
		}

		/// <summary>
		/// Compiles a new Package File from the currently stored Information
		/// </summary>
		/// <param name="ms">The Memory Stream you want to write</param>
		/// <param name="flname">Filename for the Package</param>
		protected void Save(MemoryStream ms, string flname)
		{
			string bakfile = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(flname), System.IO.Path.GetFileNameWithoutExtension(flname)+".bak");
			string tmpfile = System.IO.Path.GetTempFileName();
			try 
			{
				System.IO.FileStream fs = new FileStream(tmpfile, FileMode.Create);
				try 
				{
					Save(ms, fs);
				} 
				finally 
				{
					fs.Close();
				}

				if (System.IO.File.Exists(bakfile)) System.IO.File.Delete(bakfile);
				if (System.IO.File.Exists(flname)) 
				{
					StreamFactory.CloseStream(flname);
					
					if (Helper.WindowsRegistry.AutoBackup) System.IO.File.Copy(flname, bakfile, true);
					System.IO.File.Delete(flname);
				}
				
				System.IO.File.Move(tmpfile, flname);

				if (!Helper.WindowsRegistry.AutoBackup) 
					if (System.IO.File.Exists(bakfile)) System.IO.File.Delete(bakfile);
			} 
			catch (Exception ex) 
			{
				System.IO.File.Delete(tmpfile);
				throw ex;
			}

			StreamItem si = StreamFactory.UseStream(flname, FileAccess.Read);
		}

		/// <summary>
		/// Compiles a new Package File from the currently stored Information
		/// </summary>
		/// <param name="ms">The Memory Stream you want to write</param>
		/// <param name="fs">The Filestream you want to write the File to</param>
		public void Save(MemoryStream ms, FileStream fs)
		{			
			try 
			{
				fs.Seek(0, SeekOrigin.Begin);
				fs.SetLength(0);
				byte[] b = ms.ToArray();
				//fs.Lock(0, reader.BaseStream.Length);
				fs.Write(b, 0, b.Length);
				//fs.Unlock(0, reader.BaseStream.Length);
				
			} 
			finally 
			{
				fs.Close();
			}
		}

		/// <summary>
		/// Compiles a new Package File from the currently stored Information
		/// </summary>
		/// <returns>The MemoryStream representing the new Package File</returns>
		public MemoryStream Build()
		{
			this.LockStream();
			OpenReader();
			System.IO.MemoryStream ms = new MemoryStream(10000);
			System.IO.BinaryWriter writer = new BinaryWriter(ms);

			
			//make sure we write the correct Version!
			if ((header.majorversion==1) && (header.minorversion==0))
			{
				header.minorversion = 1;
				header.majorversion = 1;
				filelist = null;
			}

			//now save the stuff	
			header.Save(writer);

			//now save the files
			ArrayList tmpindex = new ArrayList();
			ArrayList tmpcmp = new ArrayList();
			if (this.fileindex==null) fileindex = new PackedFileDescriptor[0];
			foreach(PackedFileDescriptor pfd in this.fileindex)
			{				
				pfd.Changed = false;

				//we write the filelist as last File
				if (pfd==this.filelist) continue;
				if (pfd.Type == Data.MetaData.DIRECTORY_FILE) continue;
				if (pfd.MarkForDelete) continue;

				//PackedFileDescriptor newpfd = (PackedFileDescriptor)pfd.Clone();				
				PackedFileDescriptor newpfd = (PackedFileDescriptor)pfd;								

				PackedFile pf = null;
				if (pfd.HasUserdata && pfd.MarkForReCompress) 
				{
					try 
					{
						pf = new PackedFile(PackedFile.Compress(pfd.UserData));
						pf.size = pf.data.Length;
						pf.uncsize = (uint)pfd.UserData.Length;
						pf.signature = Data.MetaData.COMPRESS_SIGNATURE;
						pf.headersize = 9;
						newpfd.size = pf.data.Length;

						//recreate the FileList
						filelist = null;
					} 
					catch (Exception ex) 
					{
						pf = (PackedFile)this.Read(pfd);
						newpfd.size = pf.data.Length;
						newpfd.UserData = pfd.UserData;

						if (Helper.DebugMode) Helper.ExceptionMessage("", ex);
					}																			
				} 
				else 
				{
					pf = (PackedFile)this.Read(pfd);
					newpfd.size = pf.data.Length;
					newpfd.UserData = pfd.UserData;
				}
				
				newpfd.offset = (uint)writer.BaseStream.Position;
				newpfd.Changed = false;
				newpfd.MarkForReCompress = false;
				newpfd.fldata = pf;
				
				

				tmpcmp.Add(pf.IsCompressed);
				tmpindex.Add(newpfd);		
				
				writer.Write(pf.data);
			}

			//Last Entry should be the Filelist			
			WriteFileList(writer, ref tmpindex, tmpcmp);

			//create a new Index
			IPackedFileDescriptor[] myindex = new PackedFileDescriptor[tmpindex.Count];
			tmpindex.CopyTo(myindex);

			//write the hole index
			header.HoleIndex.Offset = 0;
			header.HoleIndex.Size = (int)(header.HoleIndex.ItemSize * 0);
			header.HoleIndex.Count = 0;
			holeindex = new HoleIndexItem[0];

			//write the packed Fileindex
			header.Index.Offset = (uint)writer.BaseStream.Position;
			header.Index.Size = (int)(header.Index.ItemSize * myindex.Length);
			header.Index.Count = myindex.Length;
			SaveIndex(writer, myindex);
			Index = myindex;
			

			//rewrite Header
			ms.Seek(0, SeekOrigin.Begin);
			header.Save(writer);

			ms.Seek(0, SeekOrigin.Begin);
			this.UnLockStream();
			CloseReader();
			return ms;
		}

		#region Index and Hole Writing
		
		/// <summary>
		/// Writes the Index to the Package File
		/// </summary>
		/// <param name="writer">The BinaryWriter to use</param>
		/// <param name="tmpcmp">the index you want to write</param>
		/// <param name="tmpindex">listing of the compressin state for each packed File</param>
		protected void WriteFileList(BinaryWriter writer, ref ArrayList tmpindex, ArrayList tmpcmp)
		{
			if (this.filelist==null) 
			{
				filelist = new PackedFileDescriptor();
				filelist.instance = 0x286B1F03;
				filelist.Group = Data.MetaData.DIRECTORY_FILE;
				filelist.Type = Data.MetaData.DIRECTORY_FILE;
			}

			//we use the fact, taht packed files that were altered by SimPe will not be compressed, 
			//so we only need to delete entries in the Filelist that do not exist any longer. The Size 
			//won't change!
			byte[] b = this.Read(filelist).UncompressedData;
			SimPe.PackedFiles.Wrapper.CompressedFileList fl = new SimPe.PackedFiles.Wrapper.CompressedFileList(filelist, this);			
			if (filelist.MarkForDelete) fl.Items = new SimPe.PackedFiles.Wrapper.ClstItem[0];

			SimPe.PackedFiles.Wrapper.CompressedFileList newfl = new SimPe.PackedFiles.Wrapper.CompressedFileList(this.Header.IndexType);
			newfl.FileDescriptor = filelist;

			for (int i=0; i<tmpcmp.Count; i++)
			{
				if ((bool)tmpcmp[i]) 
				{
					int pos = fl.FindFile((IPackedFileDescriptor)tmpindex[i]);

					if (pos!=-1) //the file did already exist, so the size did not change!
					{
						SimPe.PackedFiles.Wrapper.ClstItem fi = (SimPe.PackedFiles.Wrapper.ClstItem)fl.Items[pos];						
						newfl.Add(fi);
					} 
					else //the file is new but compressed
					{						
						//IPackedFile pf = this.Read((IPackedFileDescriptor)tmpindex[i]);
						SimPe.PackedFiles.Wrapper.ClstItem fi = new SimPe.PackedFiles.Wrapper.ClstItem(newfl.IndexType);
						PackedFileDescriptor pfd = (PackedFileDescriptor)tmpindex[i];
						fi.Type = pfd.Type;
						fi.Group = pfd.Group;
						fi.Instance = pfd.Instance;
						fi.SubType = pfd.SubType;
						fi.UncompressedSize = (uint)pfd.fldata.UncompressedSize;
						newfl.Add(fi);
					}
				}
			}

			
			
			//no compressed Files, so remove the (empty) Filelist
			if (newfl.Items.Length!=0) 
			{
				//tmpindex[tmpindex.Length-1] = filelist;	
				tmpindex.Add(filelist);

				newfl.SynchronizeUserData();					
				filelist.offset = (uint)writer.BaseStream.Position;					
				filelist.size = filelist.UserData.Length;
				writer.Write(filelist.UserData);
				filelist.Changed = false;
			}

			this.filelistfile = newfl;
		}

		/// <summary>
		/// Writes the Index to the Package File
		/// </summary>
		/// <param name="writer">The BinaryWriter to use</param>
		/// <param name="tmpcmp">the index you want to write</param>
		protected void SaveIndex(BinaryWriter writer, IPackedFileDescriptor[] tmpindex)
		{
			long pos = writer.BaseStream.Position;
			foreach (PackedFileDescriptor item in tmpindex) 
			{
				writer.Write((uint)item.Type);
				writer.Write((uint)item.Group);
				writer.Write((uint)item.Instance);
				if ((Header.IsVersion0101) && (Header.IndexType==Data.MetaData.IndexTypes.ptLongFileIndex)) writer.Write((uint)item.SubType);
				writer.Write(item.Offset);
				writer.Write(item.Size);			
			}

			header.Index.Size = (int)(writer.BaseStream.Position - pos);
		}

		/// <summary>
		/// Writes the HoleIndex to the Package File
		/// </summary>
		/// <param name="writer">The BinaryWriter to use</param>
		/// <param name="tmpcmp">the holeindex you want to write</param>
		protected void SaveHoleIndex(BinaryWriter writer, HoleIndexItem[] tmpindex)
		{
			long pos = writer.BaseStream.Position;
			foreach (HoleIndexItem item in tmpindex) 
			{
				writer.Write(item.Offset);
				writer.Write(item.Size);			
			}

			header.HoleIndex.Size = (int)(writer.BaseStream.Position - pos);
		}
		#endregion
		
	}
}
