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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Packages
{
	/// <summary>
	/// Structure of a FileIndex Item
	/// </summary>
	public class PackedFileDescriptor : HoleIndexItem, IPackedFileDescriptor
	{
		/// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Cloned Object</returns>
		public IPackedFileDescriptor Clone() 
		{
			PackedFileDescriptor pfd = new PackedFileDescriptor();			
			pfd.filename = filename;
			pfd.group = group;
			pfd.instance = instance;
			pfd.offset = offset;
			pfd.size = size;
			pfd.subtype = subtype;
			pfd.type = type;
			pfd.changed = changed;

			return (IPackedFileDescriptor)pfd;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public PackedFileDescriptor () 
		{
			subtype = 0;
			markdeleted = false;
			markcompress = false;
			changed = false;
		}

		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		public override int Size
		{
			get 
			{
				if (userdata==null)
					return size;
				else
					return (int)userdata.Length;
			}
		}

		/// <summary>
		/// Returns the size stored in teh index
		/// </summary>
		public int IndexedSize 
		{
			get
			{
				return size;
			}
		}

		/// <summary>
		/// Type of the referenced File
		/// </summary>
		internal UInt32 type;

		/// <summary>
		/// Returns/Sets the Type of the referenced File
		/// </summary>
		public UInt32 Type
		{
			get 
			{
				return type;
			}
			set 
			{
				type = value;
			}
		}

		/// <summary>
		/// Returns the Name of the represented Type
		/// </summary>
		public Data.TypeAlias TypeName 
		{
			get 
			{
				return Data.MetaData.FindTypeAlias(Type);
			}
		}

		/// <summary>
		/// Group the referenced file is assigned to
		/// </summary>
		internal UInt32 group;

		/// <summary>
		/// Returns/Sets the Group the referenced file is assigned to
		/// </summary>
		public UInt32 Group
		{
			get 
			{
				return group;
			}
			set 
			{
				group = value;
			}
		}



		/// <summary>
		/// Instance Data
		/// </summary>
		internal UInt32 instance;

		/// <summary>
		/// Returns or sets the Instance Data
		/// </summary>
		public UInt32 Instance
		{
			get 
			{
				return instance;
			}
			set 
			{
				instance = value;
			}
		}



		/// <summary>
		/// An yet unknown Type
		/// </summary>
		/// <remarks>Only in Version 1.1 of package Files</remarks>
		internal UInt32 subtype;

		/// <summary>
		/// Returns/Sets an yet unknown Type
		/// </summary>		
		/// <remarks>Only in Version 1.1 of package Files</remarks>
		public UInt32 SubType
		{
			get 
			{
				return subtype;
			}
			set 
			{
				subtype = value;
			}
		}

		/// <summary>
		/// Returns the Long Instance
		/// </summary>
		/// <remarks>Combination of SubType and Instance</remarks>
		public UInt64 LongInstance
		{
			get
			{
				ulong ret = instance;
				ret = (((ulong)subtype << 32) & 0xffffffff00000000) | (ulong)ret;
				return ret;
			}

			set
			{
				instance = (uint)(value & 0xffffffff);
				subtype = (uint)((value >> 32) & 0xffffffff);
			}
		}

		/// <summary>
		/// The proposed Filename
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		private string filename = null;

		/// <summary>
		/// Returns or Sets the Filename
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		public string Filename 
		{
			get 
			{
				if (filename==null) 
				{
					filename = Helper.HexString(SubType)+"-"+Helper.HexString(Group)+"-"+Helper.HexString(Instance);					
					filename += "."+TypeName.Extension;
				} 

				return filename;				
			}
			set 
			{
				filename = value;
			}
		}

		/// <summary>
		/// The proposed FilePath
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		private string path = null;

		/// <summary>
		/// Returns or Setst the File Path
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		public string Path
		{
			get 
			{
				if (path==null) 
				{
					path = Helper.HexString(Type);
					path += " - "+Helper.RemoveUnlistedCharacters(this.TypeName.Name, Helper.PATH_CHARACTERS);		
				} 

				return path;	
			}
			set
			{
				path = value;
			}
		}


		/// <summary>
		/// Generates MetInformations about a Packed File
		/// </summary>
		/// <param name="pfd">The description of the File</param>
		/// <returns>A String representing the Description as XML output</returns>
		public string GenerateXmlMetaInfo()
		{
			
			string xml = "";
			xml += Helper.tab + "<packedfile path=\""+Path.Replace("&", "&amp;")+"\" name=\""+Filename+"\">" + Helper.lbr;
			/*xml += Helper.tab + Helper.tab + "<offset>"+this.Offset.ToString()+"</offset>" + Helper.lbr;
			xml += Helper.tab + Helper.tab + "<size>"+this.Size.ToString()+"</size>" + Helper.lbr;*/
			xml += Helper.tab + Helper.tab + "<type>" + Helper.lbr;
			/*Data.TypeAlias a = this.TypeName;
			xml += Helper.tab + Helper.tab + Helper.tab + "<name>"+a.Name+"</name>" + Helper.lbr;			
			xml += Helper.tab + Helper.tab + Helper.tab + "<short>"+a.shortname+"</short>" + Helper.lbr;			*/
			/*xml += Helper.tab + Helper.tab + Helper.tab + "<name></name>" + Helper.lbr;			
			xml += Helper.tab + Helper.tab + Helper.tab + "<short></short>" + Helper.lbr;*/
			xml += Helper.tab + Helper.tab + Helper.tab + "<number>"+this.Type.ToString()+"</number>" + Helper.lbr;			
			xml += Helper.tab + Helper.tab + "</type>" + Helper.lbr;
			xml += Helper.tab + Helper.tab + "<classid>"+this.SubType.ToString()+"</classid>" + Helper.lbr;
			xml += Helper.tab + Helper.tab + "<group>"+this.Group.ToString()+"</group>" + Helper.lbr;
			xml += Helper.tab + Helper.tab + "<instance>"+this.Instance.ToString()+"</instance>" + Helper.lbr;			
			xml += Helper.tab + "</packedfile>" + Helper.lbr;
			return xml;
		}

		public override string ToString()
		{
			string name = this.TypeName + ": " + Helper.HexString(this.Type) + " - " + Helper.HexString(this.SubType) +
				" - " + Helper.HexString(this.Group) + " - " + Helper.HexString(this.Instance) ;

			//if ((this.Size==0) && (this.Offset==0)) name += " [UserFile]";
			return name;
		}

		#region Compare Methods
		/// <summary>
		/// Allow compare with IPackedFileWrapper and IPackedFileDescriptor Objects
		/// </summary>
		/// <param name="obj">The Object to compare to</param>
		/// <returns>true if the TGI Values are the same</returns>
		public override bool Equals(object obj)
		{
			if (obj==null) return false;

			//passed a FileWrapper, so extract the FileDescriptor
			if (typeof(IPackedFileWrapper) == obj.GetType().GetInterface("IPackedFileWrapper"))
			{
				IPackedFileWrapper pfw = (IPackedFileWrapper)obj;
				obj = pfw.FileDescriptor;
			} 
			else 
			{
				// Check for null values and compare run-time types.
				if ((obj == null) || ((typeof(IPackedFileDescriptor) != obj.GetType().GetInterface("IPackedFileDescriptor")) && (GetType() != obj.GetType()))) 
					return false;
			}

			IPackedFileDescriptor pfd = (IPackedFileDescriptor)obj;			
			return ((Type == pfd.Type) && (LongInstance == pfd.LongInstance) && (Group == pfd.Group));
		}

		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}


		/*public static bool operator ==(PackedFileDescriptor x, IPackedFileDescriptor y) 
		{
			if (x==null) return (y==null);
			return x.Equals(y);
		}

		public static bool operator !=(PackedFileDescriptor x, IPackedFileDescriptor y) 
		{
			if (x==null) return (y!=null);
			return !x.Equals(y);
		}*/

		/*public static bool operator ==(PackedFileDescriptor x, IPackedFileWrapper y) 
		{
			return x.Equals(y);
		}

		public static bool operator !=(PackedFileDescriptor x, IPackedFileWrapper y) 
		{
			return !x.Equals(y);
		}*/
		#endregion



		#region UserData Extensions
		/// <summary>
		/// true if this file should be marked as deleted
		/// </summary>
		bool markdeleted;

		/// <summary>
		/// Returns/sets if this file should be keept in the Index for the next Save
		/// </summary>
		public bool MarkForDelete 
		{
			get { return markdeleted; }
			set { markdeleted = value; }
		}

		bool markcompress;
		/// <summary>
		/// Returns/sets if this File should be Recompressed during the next Save Operation
		/// </summary>
		public bool MarkForReCompress
		{
			get { return markcompress; }
			set { markcompress = value; }
		}

		/// <summary>
		/// Returns true, if Userdate is available
		/// </summary>
		/// <remarks>This happens when a user assigns new Data</remarks>
		public bool HasUserdata
		{
			get
			{
				return (userdata!=null);
			}
		}

		/// <summary>
		/// contains alternative Userdata
		/// </summary>
		private byte[] userdata = null;		

		/// <summary>
		/// Puts Userdefined Data into the File
		/// </summary>
		public Byte[] UserData 
		{
			get 
			{
				return userdata;
			}
			set 
			{
				changed = true;
				userdata = value;								
			}
		}

		/// <summary>
		/// true if changed
		/// </summary>
		bool changed;

		/// <summary>
		/// Returns true if theis File was changed since the last Save
		/// </summary>
		public bool Changed
		{
			get {return changed; }
			set {changed = value; }
		}

		/// <summary>
		/// Used during saving Operations to qickly determin the umcompressed Size
		/// </summary>
		internal PackedFile fldata;
		#endregion 
	}
}
