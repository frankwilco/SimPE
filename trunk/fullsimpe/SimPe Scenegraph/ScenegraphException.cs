using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// SimPe was unable to load a File
	/// </summary>
	public class CorruptedFileException : Exception 
	{
		static string GetFileName(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item)
		{
			if (item==null) return "";
			if (item.Package==null) return "";
			if (item.Package.FileName == null) return "";

			return item.Package.FileName;
		}

		public CorruptedFileException(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item, Exception inner)
			:base (
					"A corrupted PackedFile was found.", 
					new Exception("The File '"+GetFileName(item)+"' contains a Corrupted File ("+item.FileDescriptor.ToString()+").\n\n SimPE will Ignore this File, but the resulting Package might be broken!", inner)
			)
		{
			FileTable.FileIndex.RemoveItem(item);
		}
	}

	/// <summary>
	/// En Error occurd during the attempt of walking the Scenegraph
	/// </summary>
	public class ScenegraphException : Exception
	{
		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		public ScenegraphException(string message, SimPe.Interfaces.Files.IPackedFileDescriptor pfd) : base(message)
		{
			this.pfd = pfd;
		}

		public ScenegraphException(string message, Exception inner, SimPe.Interfaces.Files.IPackedFileDescriptor pfd) : base(message, inner)
		{
			this.pfd = pfd;
		}

		public override string Message
		{
			get
			{
				if (pfd!=null) 
				{
					return base.Message + " (in "+pfd+")";
				} 
				else 
				{
					return base.Message;
				}
			}
		}

	}
}
