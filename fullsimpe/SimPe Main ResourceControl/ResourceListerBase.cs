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
using System.Windows.Forms;
using System.Collections;
using System.Threading;
using Ambertation.Threading;

namespace SimPe
{
	public abstract class ResourceListerBase 
	{
		protected ListView lv;
		protected SimPe.Interfaces.Files.IPackedFileDescriptor p;
		protected object tag;
		protected LoadedPackage pkg;
		protected ViewFilter filter;

		protected ResourceListerBase (LoadedPackage pkg, ViewFilter filter)
		{			
			this.pkg = pkg;
			this.filter = filter;	
			run = new ManualResetEvent(false);
			stop = new ManualResetEvent(false);
		}

		public void Prepare(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			this.lv = lv;
			this.p = p;
			this.tag = tag;
		}

		protected ListViewItem CreateItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd) 
		{			
			UpdatableListViewItem lvi = new UpdatableListViewItem(pfd, pkg.Package);
			return lvi;
		}

		protected delegate void AddItemDelegate(ListView lv, ListViewItem lvi);
		protected void AddItem(ListView lv, ListViewItem lvi)
		{
			lv.Items.Add(lvi);
		}

		protected void ClearList(ListView lv, ListViewItem lvi)
		{
			TreeBuilder.ClearListView(lv);			
		}

		internal event System.EventHandler Finished;		
		protected abstract bool BuildItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, int ct);

		

		
		

		internal void Start()
		{
			System.Collections.IComparer cmp = lv.ListViewItemSorter;
			lv.ListViewItemSorter = null;
			DateTime start = DateTime.Now;
			run.Set();				
			bool startedwait = false;
			try 
			{			
				stop.Reset();			
				
					
				int step = Math.Max(1, pkg.Package.Index.Length/100);
				Wait.Message = "Loading Resource List...";
				int ct = 0;
				int rct = 0;
					
				lv.Invoke(new AddItemDelegate(ClearList), new object[] {lv, null});
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
				{						
					if (BuildItem(pfd, ct++)) rct++;	
					if (rct==50 && !startedwait) 
					{
						startedwait = true;
						Wait.SubStart(pkg.Package.Index.Length);						
					} 
					if (startedwait && ct%step==1) Wait.Progress = ct;												
					
					if (Helper.WindowsRegistry.AsynchronLoad) 
						if (stop.WaitOne(0, false)) 
							break;
				}				
						
			}
			catch (ThreadAbortException)
			{	
				Thread.ResetAbort();	
				Wait.Stop();
			}
			finally 
			{				
				if (Finished!=null) Finished(this, new EventArgs());
				if (startedwait) 
					Wait.SubStop();					
			}	
 
			TimeSpan dur = DateTime.Now-start;
			lv.ListViewItemSorter = cmp;
#if DEBUG
			Message.Show(dur.ToString());
#endif
		}

		ManualResetEvent run;
		protected ManualResetEvent Running
		{
			get {return run;}
		}

		ManualResetEvent stop = new ManualResetEvent(false);
		
		protected ManualResetEvent StopEvent
		{			
			get { return stop; }
		}

		#region Statics
		static ResourceListerBase last = null;
		static Thread lastthread = null;
		
		public static void Start(ResourceListerBase rlb)
		{
			Stop();
			if (Helper.WindowsRegistry.AsynchronLoad) 
			{			
				last = rlb;							
				lastthread = new Thread(new ThreadStart(last.Start));	
				lastthread.Name = "Resource Loader "+rlb.GetType().Name;
				last.Running.Set();
				lastthread.Start();
			} else rlb.Start();
		}

		public static void Stop()
		{			
			if (last!=null) 
			{		
				last.StopEvent.Set();					
				last.Running.WaitOne();
				last.Running.Reset();
					

				last = null;
				lastthread = null;
			}
		}
		#endregion
	}
}
