using System;
using System.Threading;

namespace Ambertation.Threading
{
	/// <summary>
	/// Implements a Thread that can be stopped
	/// </summary>
	public abstract class StoppableThread : System.IDisposable
	{
		bool async;

		public StoppableThread() : this(SimPe.Helper.WindowsRegistry.AsynchronLoad) {}
		public StoppableThread(bool async)
		{
			this.async = async;
			stop = new ManualResetEvent(false);
			ended = new ManualResetEvent(true);
		}

		protected ManualResetEvent stop;
		protected ManualResetEvent ended;

		/// <summary>
		/// block until the loader thread is cancled
		/// </summary>
		protected void WaitForEnd()
		{
			if (!async) return;
			if (stop==null) return;
			stop.Set();
			const int wait = 100;
			int ct=0;
			while (!ended.WaitOne(SimPe.Wait.TIMEOUT/(2*wait), false) && ct<wait) 
			{
				ct++;
				stop.Set();
				System.Windows.Forms.Application.DoEvents();
				Thread.Sleep(SimPe.Wait.TIMEOUT/(2*wait));				
			}
			ended.Set();
		}

		public virtual void Dispose()
		{
			WaitForEnd();
		}

		protected abstract void StartThread();

		void ThreadEntry()
		{
			stop.Reset();
			ended.Reset();

			try 
			{
				StartThread();
			} 
			finally 
			{
				ended.Set();
			}
		}

		protected bool HaveToStop
		{
			get 
			{
				if (async)
					if (stop.WaitOne(0, true)) return true;
				return false;
			}
		}

		protected void ExecuteThread(ThreadPriority tp, string name)
		{
			ExecuteThread(tp, name, false, true, 500);
		}

		protected void ExecuteThread(ThreadPriority tp, string name, bool sync)
		{
			ExecuteThread(tp, name, sync, true, 500);
		}

		protected void ExecuteThread(ThreadPriority tp, string name, bool sync, bool events)
		{
			ExecuteThread(tp, name, sync, events, 500);
		}

        protected Thread worker;
		protected void ExecuteThread(ThreadPriority tp, string name, bool sync, bool events, int synctime)
		{
			WaitForEnd();
			if (!async) 
			{
				ThreadEntry();
			} 
			else 
			{
                worker = new Thread(new ThreadStart(ThreadEntry));
                worker.Priority = tp;
                worker.Name = name;
                //worker.SetApartmentState(ApartmentState.STA);
                worker.Start();

				if (sync)
                    while (worker.IsAlive) 
					{
                        worker.Join(synctime);
						if (events) System.Windows.Forms.Application.DoEvents();
					}
			}
		}
	}
}
