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
using System.Threading;
using SimPe;

namespace Ambertation.Threading
{
	public class OldThreadBuffer
	{
		// Anzahl der Elemente
		internal static bool finished_create;
		internal static bool finished_consume;
  
		// Thread - Lock - Variablen
		private static object buffer_free = "";
		private static object buffer_not_empty = "";
		private static object consuming = "";
  
		// Buffer - Variables
		private const int N = 50; // maximum Number of Elements in the Buffer
		private static int counter=0; // Number of Elements in the Buffer
		internal static object[] buffer = new object[N]; // Buffer
  
		// Synchronisierte create - Methode
		public static void Produce(Object o)
		{
			lock(buffer_not_empty)
			{
				if(OldThreadBuffer.counter==N) // Is Buffer full
				{
					// wait until a slot is available
					Monitor.Wait(buffer_free);
				}

				// Add Data to the Buffer
				buffer[OldThreadBuffer.counter] = o;			
				// -------------
				OldThreadBuffer.counter++;
    
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}

		internal static void Init()
		{			
			finished_create = false;
			finished_consume = false;
		}

		internal static void Finish()
		{
			lock(buffer_not_empty)
			{
				finished_create = true; 
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}
  
		// Synchronisierte consume - Methode
		internal static Object Consume()
		{
			Object o = new Object();
   
			lock(buffer_free)
			{
				lock(consuming)
				{
					while (OldThreadBuffer.counter==0 ) // is Buffer Empty
					{
						if (!OldThreadBuffer.finished_create) 
						{
							// wait until an Element is added
							Monitor.Wait(buffer_not_empty);
						} 
						else 
						{
							OldThreadBuffer.finished_consume = true;
							return null;
						}
					}

				
					// Hole Daten ab
					o = buffer[OldThreadBuffer.counter-1];
					buffer[OldThreadBuffer.counter-1] = null;
				
					// -------------
					OldThreadBuffer.counter--;	
				
					Monitor.PulseAll(consuming);
				}

				// Signal that we have removed an Element from the Buffer
				Monitor.PulseAll(buffer_free);
			}
   
			return o;
		}
	}

	public abstract class ProducerThread
	{
		#region ThreadBuffer
		// Anzahl der Elemente
		internal bool finished_create;
		internal bool finished_consume;
  
		// Thread - Lock - Variablen
		private object buffer_free = "";
		private object buffer_not_empty = "";
		private object consuming = "";
  
		// Buffer - Variables
		private const int N = 50; // maximum Number of Elements in the Buffer
		private int counter=0; // Number of Elements in the Buffer
		internal object[] buffer = new object[N]; // Buffer
  
		// Synchronisierte create - Methode
		protected void AddToBuffer(Object o)
		{
			lock(buffer_not_empty)
			{
				if(counter==N) // Is Buffer full
				{
					// wait until a slot is available
					Monitor.Wait(buffer_free);
				}

				// Add Data to the Buffer
				buffer[counter] = o;			
				// -------------
				counter++;
    
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}

		internal void Init()
		{			
			finished_create = false;
			finished_consume = false;
		}

		internal void Finish()
		{
			lock(buffer_not_empty)
			{
				finished_create = true; 
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}
  
		// Synchronisierte consume - Methode
		internal Object Consume()
		{
			Object o = new Object();
   
			lock(buffer_free)
			{
				lock(consuming)
				{
					while (counter==0 ) // is Buffer Empty
					{
						if (!finished_create) 
						{
							// wait until an Element is added
							Monitor.Wait(buffer_not_empty);
						} 
						else 
						{
							finished_consume = true;
							return null;
						}
					}

				
					// Hole Daten ab
					o = buffer[counter-1];
					buffer[counter-1] = null;
				
					// -------------
					counter--;	
				
					Monitor.PulseAll(consuming);
				}

				// Signal that we have removed an Element from the Buffer
				Monitor.PulseAll(buffer_free);
			}
   
			return o;
		}
	
		#endregion
		public event System.EventHandler Finished;

		/// <summary>
		/// Use this Method top Produces objects, add the Objects to the 
		/// Buffer, by calling <see cref="AddToBuffer"/>
		/// </summary>
		protected abstract void Produce();
		protected virtual void OnFinish() {}
		
		public void start()
		{
			Init();
			bool run = WaitingScreen.Running;
			WaitingScreen.Wait();
			Produce();
					
			Finish();
			while (!finished_consume)
				Thread.Sleep(500);
		
			if (!run) WaitingScreen.Stop();
			OnFinish();
			if (Finished!=null) Finished(this, new System.EventArgs());
		}
	}
 
	public abstract class ConsumerThread
	{
		ProducerThread pt;

		public ConsumerThread(ProducerThread producer)
		{
			this.pt = producer;
		}

		/// <summary>
		/// Implements the Consume Action for this Thread
		/// </summary>
		/// <param name="o">The Object that should be consumed (can never be NULL)</param>
		/// <returns>false if all active Consumers should stop Consuming</returns>
		/// <remarks>
		/// you should only return false if you know what you are 
		/// doing, as this could block the Producer Thread!
		/// </remarks>
		protected abstract bool Consume(Object o);

		public void start()
		{				
			while(!pt.finished_consume)
			{
				// consume Data
				Object o = pt.Consume();				
				if (o==null) break;

				pt.finished_consume = !Consume(o);
			}

			pt.finished_consume = true;
		}
	}
}
