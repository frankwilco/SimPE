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

namespace SimPe.Packages
{
	public class IndexDetails
	{
		protected SimPe.Interfaces.Files.IPackageHeader hd;
		internal IndexDetails(SimPe.Interfaces.Files.IPackageHeader hd)
		{			
			this.hd = hd;
		}		

		

		/// <summary>
		/// Returns the Identifier of the File
		/// </summary>
		/// <remarks>This value should be DBPF</remarks>
		public string Identifier
		{
			get {return hd.Identifier;}
		}
				

		/// <summary>
		/// Returns the Overall Version of this Package
		/// </summary>
		public string Version 
		{
			get { return "0x"+Helper.HexString(hd.Version);}
		}

		/// <summary>
		/// Returns or Sets the Type of the Package
		/// </summary>
		public SimPe.Data.MetaData.IndexTypes IndexType
		{
			get {return hd.IndexType;}
			set {hd.IndexType = value;}
		}		

		/// <summary>
		/// This is missused in SimPE as a Unique Creator ID
		/// </summary>
		public uint Ident
		{
			get {return hd.Created;}			
		}
	}

	public class IndexDetailsAdvanced : IndexDetails
	{
		internal IndexDetailsAdvanced(SimPe.Interfaces.Files.IPackageHeader hd) : base (hd)
		{					
		}				
	
		public string IndexOffset
		{
			get {return "0x"+Helper.HexString( hd.Index.Offset);}
		}

		public string IndexSize
		{
			get {return "0x"+Helper.HexString(hd.Index.Size);}
		}

		public int ResourceCount
		{
			get {return hd.Index.Count;}
		}

		public string IndexVersion
		{
			get {return "0x"+Helper.HexString(hd.Index.Type);}
		}

		public string IndexItemSize
		{
			get {return "0x"+Helper.HexString( hd.Index.ItemSize) +" (0x"+Helper.HexString(hd.Index.Size / hd.Index.Count)+")";}
		}		
		

		/// <summary>
		/// Returns the Major Version of The Packages FileFormat
		/// </summary>
		/// <remarks>This value should be 1</remarks>
		public int MajorVersion
		{
			get {return hd.MajorVersion;}
		}



		/// <summary>
		/// Returns the Minor Version of The Packages FileFormat 
		/// </summary>
		/// <remarks>This value should be 0 or 1</remarks>
		public int MinorVersion
		{
			get {return hd.MinorVersion;}
		}						
	}


	/// <summary>
	/// This offers some Repair Methods for .packages
	/// </summary>
	public class PackageRepair : System.IDisposable
	{
		SimPe.Interfaces.Files.IPackageFile pkg;
		static ArrayList types;
		public PackageRepair(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			this.pkg = pkg;
			InitTypes();
		}

		void InitTypes()
		{
			types = new ArrayList();
			SimPe.Data.TypeAlias[] ftis = Helper.TGILoader.FileTypes;
			foreach (SimPe.Data.TypeAlias ta in ftis)
				types.Add(ta.Id);
		}

		bool CouldBeIndexItem(BinaryReader br, long pos, int step, bool strict)
		{
			if (pos<0) return false;			

			for (int i =0; i<4; i++) 
			{
				br.BaseStream.Seek(pos+i*step, SeekOrigin.Begin);
				SimPe.Packages.PackedFileDescriptor pfd = new PackedFileDescriptor();
				pfd.LoadFromStream(pkg.Header, br);
				

				if (!types.Contains(pfd.Type)) return false;
				if (pfd.Size<=0) return false;
				if (pfd.Offset<=0 || pfd.Offset>=br.BaseStream.Length) return false;

				if (strict)
				{
					if (pfd.Type==0x00000000) return false;
					if (pfd.Type==0xffffffff) return false;
				}
			}

			return true;
		}

		/// <summary>
		/// Returns the Offset of the ResourceIndex in the current package
		/// </summary>
		/// <returns></returns>
		public HeaderIndex FindIndexOffset()
		{
			HeaderIndex hi = new HeaderIndex(pkg.Header);

			if (pkg is File)
				((File)pkg).ReloadReader();
			BinaryReader br = pkg.Reader;
			int step = 0x18;
			if (pkg.Header.IndexType == SimPe.Data.MetaData.IndexTypes.ptShortFileIndex) step = 0x14;
			long pos = br.BaseStream.Length - (4*step +1);

			long lastitem = -1;
			long firstitem = -1;			
			SimPe.WaitingScreen.Wait();
			
			try 
			{
				while (pos>0x04)
				{
					WaitingScreen.UpdateMessage("0x"+Helper.HexString(pos)+" / 0x"+Helper.HexString(br.BaseStream.Length));					

					bool hit = CouldBeIndexItem(br, pos, step, lastitem==-1);
					if (hit && lastitem==-1)
					{
						lastitem = br.BaseStream.Position;
					}

					if (!hit && lastitem!=-1)
					{
						firstitem = pos+step;
						break;
					}

					if (lastitem==-1) pos --;
					else pos -= step;
				}		
			} 
			finally 
			{
				WaitingScreen.Stop();
			}
			
			hi.offset = (uint)firstitem;
			hi.size = (int)(lastitem-firstitem);
			hi.count = hi.size / step;

			if (firstitem==-1) hi = pkg.Header.Index as HeaderIndex;

			return hi;
		}

		public void UseIndexData(HeaderIndex hi)
		{
			if (hi.Parent == pkg.Header && Package!=null) 
			{
				hi.UseInParent();
				((HeaderData)hi.Parent).LockIndexDuringLoad = true;
				Package.Reload();
				((HeaderData)hi.Parent).LockIndexDuringLoad = false;
			}
		}

		public IndexDetails IndexDetails
		{
			get 
			{
				return new IndexDetails(pkg.Header);
			}
		}

		public IndexDetailsAdvanced IndexDetailsAdvanced
		{
			get {return new IndexDetailsAdvanced(pkg.Header);}
		}

		public SimPe.Packages.GeneratableFile Package
		{
			get 
			{
				if (pkg is SimPe.Packages.GeneratableFile) return (SimPe.Packages.GeneratableFile)pkg;
				return null;
			}
		}

		#region IDisposable Member

		public void Dispose()
		{
			pkg = null;
		}

		#endregion
	}
}
