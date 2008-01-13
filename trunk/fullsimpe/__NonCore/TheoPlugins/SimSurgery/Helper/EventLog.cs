using System;
using System.Collections;

namespace SimPe.Plugin.Helper
{
	/// <summary>
	/// Summary description for EventLog.
	/// </summary>
	public sealed class EventLog : CollectionBase
	{

		public Exception this[int index]
		{
			get { return this.List[index] as Exception; }
			set { this.List[index] = value; }
		}

		public EventLog()
		{
		}

		public int Add(string message)
		{
			Exception e = new Exception(message);
			return this.Add(e);
		}

		public int Add(string format, params object[] args)
		{
			return this.Add(String.Format(format, args));
		}

		public int Add(System.Exception e)
		{
			return this.List.Add(e);
		}

		public int Add(Exception e, string message)
		{
			return this.Add(new ApplicationException(message, e));
		}

		public int Add(Exception e, string format, params object[] args)
		{
			return this.Add(e, String.Format(format, args));
		}

		public void AddRange(EventLog log)
		{
			foreach (Exception e in log)
				this.Add(e);
		}

		public string[] GetMessages(bool detailed)
		{
			string[] ret = new string[this.List.Count];
			for (int i = 0; i < this.List.Count; i++)
			{
				Exception e = this[i];
				if (detailed)
					ret[i] = e.ToString();
				else
					ret[i] = e.Message;
			}
			return ret;
		}

	}


	/// <summary>
	/// Defines the EventLog property of the type <see cref="EventLog"/>.
	/// </summary>
	public interface IEventLogContainer
	{
		/// <summary>
		/// Gets a <see cref="EventLog"/> instance containing a
		/// list of exceptions that occurred.
		/// </summary>
		EventLog EventLog { get; }
	}

}
