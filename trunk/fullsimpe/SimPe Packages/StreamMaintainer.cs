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
using System.IO;

namespace SimPe.Packages
{
	/// <summary>
	/// State of a FileStream
	/// </summary>
	public enum StreamState : byte
	{
		/// <summary>
		/// The Stream is Opene
		/// </summary>
		Opened,
		/// <summary>
		/// The Stream is Closed
		/// </summary>
		Closed,
		/// <summary>
		/// The stream is not available
		/// </summary>
		Removed
	}

	/// <summary>
	/// Contains one FIleStream
	/// </summary>
	public class StreamItem 
	{
		FileStream fs;
		
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="fs">The FIlestream you want to use</param>
		internal StreamItem(FileStream fs) 
		{
			SetFileStream(fs);					
		}

		/// <summary>
		/// Returns the FIleStream
		/// </summary>
		public FileStream FileStream
		{
			get {return fs;}			
		}

		/// <summary>
		/// Change the internal FileStream
		/// </summary>
		/// <param name="fs"></param>
		internal void SetFileStream(FileStream fs)
		{
			this.fs = fs;		
		}

		/// <summary>
		/// Chnages the Permissions for this Stream
		/// </summary>
		/// <param name="fa">File Acces you need</param>
		/// <remarks>won't do anything if thhe Stream is null!</remarks>
		/// <returns>true if the FIleMode was changed</returns>
		public bool SetFileAccess(FileAccess fa) 
		{
			if (fs==null) return false;

			switch (fa) 
			{
				case FileAccess.Read:
				{
					if (fs.CanRead) return true;
					if (fs.CanWrite) fa=FileAccess.ReadWrite;
					break;
				}

				case FileAccess.Write:
				{
					if (fs.CanWrite) return true;
					if (fs.CanRead) fa=FileAccess.ReadWrite;
					break;
				}
				default: 
				{
					if (fs.CanRead && fs.CanWrite) return true;
					break;
				}
			}

			try 
			{
				if (this.StreamState==StreamState.Opened) fs.Close();					
				
				string name = fs.Name;
				fs = null;
				fs = new FileStream(name, System.IO.FileMode.OpenOrCreate, fa);
			} 
			catch (Exception ex){
				if (Helper.DebugMode) Helper.ExceptionMessage("", ex);
				return false;
			}
			return true;
		}

		/// <summary>
		/// Returns the current State of this Stream
		/// </summary>
		public StreamState StreamState
		{
			get 
			{
				if (fs==null) return StreamState.Removed;

				if (fs.CanSeek) return StreamState.Opened;
				return StreamState.Closed;
			}
		}	
		
		/// <summary>
		/// Closes the Stream if opened
		/// </summary>
		public void Close()
		{
			if (this.StreamState==StreamState.Opened) fs.Close();
		}
	}

	/// <summary>
	/// Holds a list of all Streams SimPe did ever open.
	/// </summary>
	public class StreamFactory
	{
		internal static Hashtable streams;
		static ArrayList locked = new ArrayList();

		/// <summary>
		/// marks a stream locked, which means, that it cannot be closed
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static bool LockStream(string filename)
		{
			InitTable();
			filename = filename.Trim().ToLower();
			if (streams.ContainsKey(filename)) 
			{
				if (!locked.Contains(filename)) locked.Add(filename);
				return true;
			}
			return false;
		}

		/// <summary>
		/// marks a stream unlocked, which means, that it can be closed
		/// </summary>
		/// <param name="filename"></param>
		/// <returns></returns>
		public static bool UnlockStream(string filename)
		{
			InitTable();
			filename = filename.Trim().ToLower();
			if (streams.ContainsKey(filename)) 
			{
				if (locked.Contains(filename)) 
				{
					locked.Remove(filename);
					return true;
				}
			}
			return false;
		}

		/// <summary>
		/// Returns true, if the passed Stream is locked
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="checkfiletable">true, if you want to check the FileTable for references (which counta s locked)</param>
		/// <returns></returns>
		public static bool IsLocked(string filename, bool checkfiletable)
		{
			filename = filename.Trim().ToLower();
			bool res = locked.Contains(filename);
			if (res || !checkfiletable) return res;

			return SimPe.FileTableBase.FileIndex.Contains(filename);			
		}

		/// <summary>
		/// Unlocks all Streams
		/// </summary>
		public static void UnlockAll()
		{
			InitTable();
			InitTable();
			foreach (string k in streams.Keys) 			
				UnlockStream(k);			
		}

		public static void WriteToConsole()
		{
			InitTable();
			System.Windows.Forms.Form f = new System.Windows.Forms.Form();
			System.Windows.Forms.ListBox lb = new System.Windows.Forms.ListBox();
			f.Controls.Add(lb);
			lb.Dock = System.Windows.Forms.DockStyle.Fill;

			foreach (string k in streams.Keys) 
			{
				StreamItem si = streams[k] as StreamItem;
				string add = k;
				if (si!=null) add +=" ["+si.StreamState+"]";	
				if (IsLocked(k, false)) add = "[locked] "+add;
				else if (IsLocked(k, true)) add = "[ftlocked] "+add;
				if (PackageMaintainer.Maintainer.Contains(k)) add += "[managed]";
				lb.Items.Add(add);
			}

			lb.Sorted = true;
			f.ShowDialog();
			f.Dispose();
		}
		/// <summary>
		/// Removes all Files from the Teleport Folder
		/// </summary>
		public static void CleanupTeleport()
		{
			string[] files = System.IO.Directory.GetFiles(Helper.SimPeTeleportPath);
			foreach (string file in files)
			{
				try 
				{
					SimPe.Packages.StreamFactory.CloseStream(file);
					System.IO.File.Delete(file);
				} 
				catch (Exception ex)
				{
					Console.WriteLine(ex);
				}
			}
		}

		static void InitTable()
		{
			if (streams==null) streams = new Hashtable();
		}

		/// <summary>
		/// Returns the Suggested ShareMode for the passed Access Mode
		/// </summary>
		/// <param name="fa">The Acces Mode</param>
		/// <returns>The Suggeste Share Mode</returns>
		/*public static FileShare GetFileShare(FileAccess fa)
		{
			switch (fa) 
			{
				case FileAccess.Read:
				{
					return FileShare.Read;
				}
				default:
				{
					return FileShare.Read;
				}
			}
		}*/

		/// <summary>
		/// Returns a valid stream Item for the passed Filename
		/// </summary>
		/// <param name="filename">The name of the FIle you want to open</param>
		/// <returns>a valid StreamItem</returns>
		/// <remarks>
		/// If this File was not know yet, a new StreamItem will 
		/// be generated for it and returned. The StreamItem will 
		/// not contain a Stream in that case!
		/// </remarks>
		public static StreamItem GetStreamItem(string filename) 
		{
			return GetStreamItem(filename, true);
		}

		/// <summary>
		/// Returns a valid stream Item for the passed Filename
		/// </summary>
		/// <param name="filename">The name of the FIle you want to open</param>
		/// <returns>a valid StreamItem or null if not found and createnew was set</returns>
		/// <param name="createnew">
		/// If true and this File was not know yet, a new StreamItem will be generated 
		/// for it and returned. The StreamItem will 
		/// not contain a Stream in that case!
		/// </param>
		public static StreamItem GetStreamItem(string filename, bool createnew) 
		{
			InitTable();
			if (filename==null) filename="";
			filename = filename.Trim().ToLower();
			StreamItem si = (StreamItem)streams[filename];
			if ((si==null) && createnew)
			{
				si = new StreamItem(null);
				streams[filename] = si;
			}

			return si;
		}

		/// <summary>
		/// Returns true if a FileStream for this file exists
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool IsStreamAvailable(string name) 
		{			
			StreamItem si = GetStreamItem(name, false);
			return (si!=null);
		}

		/// <summary>
		/// Returns a Usable Stream for that File
		/// </summary>
		/// <param name="filename">The name of the File</param>
		/// <param name="fa">The Acces Attributes</param>
		/// <returns>a StreamItem (StreamState is Removed if the File did not exits!</returns>
		public static StreamItem UseStream(string filename, FileAccess fa) 
		{
			return UseStream(filename, fa, false);
		}

		/// <summary>
		/// Returns a Usable Stream for that File
		/// </summary>
		/// <param name="filename">The name of the File</param>
		/// <param name="fa">The Acces Attributes</param>
		/// <param name="create">true if the file should be created if not available</param>
		/// <returns>a StreamItem (StreamState is Removed if the File did not exits!</returns>
		public static StreamItem UseStream(string filename, FileAccess fa, bool create) 
		{
			StreamItem si = GetStreamItem(filename);
			//File does not exists, so set State to removed
			if (!System.IO.File.Exists(filename)) 
			{
				if (si.StreamState == StreamState.Opened) si.FileStream.Close();

				if (create) 
				{
					si.SetFileStream(new FileStream(filename, System.IO.FileMode.OpenOrCreate, fa));
				} else si.SetFileStream(null);

				return si;
			}

			if (si.StreamState==StreamState.Removed) 
			{
				FileStream fs = new FileStream(filename, FileMode.Open, fa);
				si.SetFileStream(fs);
			} 
			else 
			{
				if (!si.SetFileAccess(fa))
					si.Close();				
			}

			if (si.StreamState==StreamState.Opened)
				si.FileStream.Seek(0, SeekOrigin.Begin);
			return si;
		}

		/// <summary>
		/// Returns null or a StreamItem that was already created
		/// </summary>
		/// <param name="fs">The Stream you are looking for</param>
		/// <returns>the Stream Item or null if none was found</returns>
		public static StreamItem FindStreamItem(FileStream fs) 
		{
			if (fs==null) return null;

			return GetStreamItem(fs.Name, false);
		}

		/// <summary>
		/// Closes a FileStream if opened and known by the Factory
		/// </summary>
		/// <param name="filename">The name of the File</param>
		/// <returns>true if the File is closed now</returns>
		public static bool CloseStream(string filename)
		{
			if (IsLocked(filename, false))  return false;

			StreamItem si = GetStreamItem(filename, false);
			if (si!=null) 
			{
				try 
				{
					si.Close();
					if (!IsLocked(filename, true)) 
						PackageMaintainer.Maintainer.RemovePackage(filename);
					return (si.StreamState!=StreamState.Opened);
				}
				catch {}
			}
			return false;
		}

		/// <summary>
		/// Closes all opened Streams (that are not locked and not referenced in the FileTable)
		/// </summary>
		public static void CloseAll()
		{
			CloseAll(false);
		}

		/// <summary>
		/// Closes all opened Streams (that are not locked and not referenced in the FileTable)
		/// </summary>
		/// <param name="force">true, if you want to close all Resources without checking the lock state</param>
		public static void CloseAll(bool force)
		{
			InitTable();
			foreach (string k in streams.Keys) 
			{				
				if (!IsLocked(k, true) || force) 
				{
					StreamItem si = streams[k] as StreamItem;
					si.Close();
					PackageMaintainer.Maintainer.RemovePackage(k);
				}
			}
		}
	}
}
