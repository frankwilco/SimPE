using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin.Wrapper
{
	public abstract class AbstractRefInfo : IReferenceInfo
	{
		IPackageFile package;

		#region IReferenceInfo Members

		RefFile refFile;

		public virtual RefFile ReferenceFile
		{
			get { return this.refFile; }
			set {
				if (value == null)
					throw new ArgumentNullException();
				this.refFile = value;
				this.Package = value.Package;
			}
		}

		#endregion

		protected virtual IPackageFile Package
		{
			get { return this.package; }
			set	{ this.package = value; }
		}

		protected AbstractRefInfo()
		{
		}

		protected AbstractRefInfo(RefFile refFile)
		{
			this.ReferenceFile = refFile;
		}

	}

	public interface IReferenceInfo
	{
		RefFile ReferenceFile { get; set; }
	}
}
