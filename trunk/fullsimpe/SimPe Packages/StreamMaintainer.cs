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
				fs = new FileStream(name, System.IO.FileMode.Open, fa, StreamFactory.GetFileShare(fa));
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
		public static Hashtable streams;

		static void InitTable()
		{
			if (streams==null) streams = new Hashtable();
		}

		/// <summary>
		/// Returns the Suggested ShareMode for the passed Access Mode
		/// </summary>
		/// <param name="fa">The Acces Mode</param>
		/// <returns>The Suggeste Share Mode</returns>
		public static FileShare GetFileShare(FileAccess fa)
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
		}

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
			StreamItem si = GetStreamItem(filename);
			//File does not exists, so set State to removed
			if (!System.IO.File.Exists(filename)) 
			{
				if (si.StreamState == StreamState.Opened) si.FileStream.Close();
				si.SetFileStream(null);

				return si;
			}

			if (si.StreamState==StreamState.Removed) 
			{
				FileStream fs = new FileStream(filename, FileMode.Open, fa, StreamFactory.GetFileShare(fa));
				si.SetFileStream(fs);
			} 
			else 
			{
				si.SetFileAccess(fa);				
			}

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
			StreamItem si = GetStreamItem(filename, false);
			if (si!=null) 
			{
				try 
				{
					si.Close();
					return (si.StreamState!=StreamState.Opened);
				}
				catch {}
			}
			return false;
		}

		/// <summary>
		/// Closes all opened Streams
		/// </summary>
		public static void CloseAll()
		{
			InitTable();
			foreach (StreamItem si in streams.Values) 
			{
				si.Close();
			}
		}
	}
}
