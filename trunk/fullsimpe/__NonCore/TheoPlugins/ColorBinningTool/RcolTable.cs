using System;
using System.Collections;
using System.Collections.Specialized;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for RcolTable.
	/// </summary>
	public class RcolTable : CollectionBase
	{

		public Rcol this[int index]
		{
			get { return this.List[index] as Rcol; }
			set	{ this.List[index] = value; }
		}


		public RcolTable()
		{
			
		}

		public int Add(Rcol rcol)
		{
			return this.List.Add(rcol);
		}

		public void AddRange(Rcol[] rcols)
		{
			this.InnerList.AddRange(rcols);
		}


		public Rcol FindByReference(string reference)
		{
			ResourceReference r = ResourceReference.Parse(reference);
			return FindByReference(r);
		}

		public Rcol FindByReference(ResourceReference reference)
		{
			foreach (Rcol rcol in this.List)
			{
				if (rcol.FileDescriptor != null)
				{
					ResourceReference rcolRef = new ResourceReference(rcol.FileDescriptor);
					if (rcolRef == reference)
						return rcol;
				}
			}

			return null;
		}

		public Rcol FindByInstance(uint instance)
		{
			foreach (Rcol rcol in this.List)
			{
				if (rcol.FileDescriptor != null)
				{
					if (rcol.FileDescriptor.Instance == instance)
						return rcol;
				}
			}

			return null;
		}

		public IPackedFileDescriptor[] GetFileDescriptor()
		{
			ArrayList ret = new ArrayList();

			foreach (Rcol rcol in this.List)
				ret.Add(rcol.FileDescriptor);

			return (IPackedFileDescriptor[])ret.ToArray(typeof(IPackedFileDescriptor));
		}

		public void SynchronizeAll()
		{
			foreach (Rcol rcol in this.List)
			{
				rcol.SynchronizeUserData();
			}
		}

	}


}
