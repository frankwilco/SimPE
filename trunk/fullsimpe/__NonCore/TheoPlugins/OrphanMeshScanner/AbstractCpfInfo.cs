using System;
using System.Collections;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using SimPe.Plugin.Helper;

namespace SimPe.Plugin.Wrapper
{

	/// <summary>
	/// Defines a wrapper for a <see cref="Cpf"/> instance, providing
	/// methods for the most common operations.
	/// </summary>
	public abstract class AbstractCpfInfo : IDisposable
	{
		private Cpf propertySet;
		private bool enabled;
		private bool changed;

		private bool disposed = false;


		public Cpf PropertySet
		{
			get { return this.propertySet; }
			set
			{
				if (value == null)
					throw new ArgumentNullException("PropertySet", "The provided Cpf instance cannot be null");
				this.propertySet = value;
			}
		}

		public IPackageFile Package
		{
			get { return this.propertySet.Package; }
		}

		public bool Enabled
		{
			get { return this.enabled; }
			set { this.enabled = value; }
		}

		public bool HasChanges
		{
			get { return this.changed; }
			set { this.changed = value; }
		}


		protected AbstractCpfInfo()
		{
			this.enabled = true;
		}

		public AbstractCpfInfo(Cpf propertySet)
			: this()
		{
			this.PropertySet = propertySet;
		}

		public CpfItem GetProperty(string name)
		{
			return this.propertySet.GetSaveItem(name);
		}

		public CpfItem GetItem(string name)
		{
			return this.propertySet.GetItem(name);
		}

		protected CpfItem CpfItem(string name)
		{
			CpfItem ret = this.propertySet.GetItem(name);
			if (ret == null)
			{
				ret = new CpfItem();
				ret.Name = name;
				this.propertySet.AddItem(ret);
			}
			return ret;
		}

		public void SetValue(string propertyName, string value)
		{
			if (this.propertySet != null)
			{
				CpfItem item = this.CpfItem(propertyName);
				if (item.StringValue != value)
				{
					item.StringValue = value;
					this.changed = true;
				}

			}
		}

		public void SetValue(string propertyName, uint value)
		{
			CpfItem item = this.CpfItem(propertyName);
			if (item.UIntegerValue != value)
			{
				item.UIntegerValue = value;
				this.changed = true;
			}
		}

		public void SetValue(string propertyName, float value)
		{
			CpfItem item = this.CpfItem(propertyName);
			if (item.SingleValue != value)
			{
				item.SingleValue = value;
				this.changed = true;
			}
		}


		public virtual void CommitChanges()
		{
			this.propertySet.SynchronizeUserData();
		}

		/// <summary>
		/// Finds a property contained in a GZPS resource of a given <paramref name="type"/>,
		/// contained in a <see cref="IPackageFile"/> object.
		/// </summary>
		public static string GetCpfProperty(IPackageFile pkg, uint type, string key)
		{
			foreach (IPackedFileDescriptor pfd in pkg.Index)
			{
				if (pfd.Type == type)
				{
					using (Cpf cpf = new Cpf())
					{
						cpf.ProcessData(pfd, pkg);
						CpfItem item = cpf.GetItem(key);
						if (item != null)
							return item.StringValue;
					}

				}
			}

			return "";
		}



		#region IDisposable Members

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		private void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing && this.propertySet != null)
				{
					this.propertySet.Dispose();
					this.propertySet = null;
				}

				disposed = true;
			}

		}

		~AbstractCpfInfo()
		{
			Dispose(false);
		}


		#endregion
	}


	public enum CpfFlags : uint
	{
		Default = 0,
		HideFromCatalog = 1,
		IsHat = 2,
		Unknown1 = 4,
		Unknown2 = 8
	}



}
