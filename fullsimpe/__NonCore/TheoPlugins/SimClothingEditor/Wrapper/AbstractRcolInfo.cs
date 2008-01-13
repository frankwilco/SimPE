using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin.Wrapper
{


	public abstract class AbstractRcolInfo
	{
		GenericRcol rcol;

		public virtual GenericRcol RcolFile
		{
			get { return this.rcol; }
			set {
				if (value == null)
					throw new ArgumentNullException();
				this.rcol = value;
			}
		}

		public IPackageFile Package
		{
			get { return this.rcol.Package; }
		}

		protected AbstractRcolInfo()
		{
		}

		protected AbstractRcolInfo(GenericRcol rcol)
		{
			this.RcolFile = rcol;
		}


		public virtual void CommitChanges()
		{
			this.rcol.SynchronizeUserData();
		}

	}
}
