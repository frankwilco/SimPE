using System;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ScenegraphException.
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
