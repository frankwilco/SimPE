using System;
using System.Collections;
using System.Collections.Specialized;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{

	public class PackageInfo : AbstractCpfInfo, IDisposable
	{
		// Track whether Dispose has been called.
		private bool disposed = false;

		private IPackageFile package;
		private Str stringList;
		private uint packageHash;
		private RecolorItem[] items;

		public IPackageFile Package
		{
			get { return package; }
			set 
			{
				package = value;
				ProcessPackage(value);
			}
		}

		public string Description
		{
			get
			{
				if (this.stringList != null) 
				{
					StrItemList items = this.stringList.Items;
					if (!Utility.IsNullOrEmpty(items))
						return ((StrToken)items[0]).Title;
				}
				return String.Empty;
			}
			set
			{
				if (this.stringList != null) 
				{
					StrItemList items = this.stringList.Items;
					
					if (!Utility.IsNullOrEmpty(items))
						((StrToken)items[0]).Title = value;
					else
					{
						StrToken item = new StrToken(0, Convert.ToByte(SimPe.Data.MetaData.Languages.English), value, String.Empty);
						this.stringList.Add(item);
					}
				}

			}
		}

		public RecolorItem[] RecolorItems
		{
			get { return this.items; }
			set { this.items = value; }
		}

		public uint PackageHash
		{
			get { return this.packageHash; }
			set { this.packageHash = value; }
		}


		private PackageInfo()
		{
		}

		public PackageInfo(IPackageFile package)
		{
			this.Package = package;
		}


		void ProcessPackage(IPackageFile package)
		{
			IPackedFileDescriptor[] strList = package.FindFiles(SimPe.Data.MetaData.STRING_FILE);
			if (Utility.IsNullOrEmpty(strList))
			{
				IPackedFileDescriptor textFile = this.CreateTextResource(package);
				if (textFile != null)
					strList = new IPackedFileDescriptor[] { textFile };
			}

			if (!Utility.IsNullOrEmpty(strList))
			{
				this.stringList = new Str();
				this.stringList.ProcessData(strList[0], package);
			}

			IPackedFileDescriptor[] keyPfd = package.FindFiles(Utility.DataType.XHTN); // Hairtone XML
			if (Utility.IsNullOrEmpty(keyPfd))
				keyPfd = package.FindFiles(Utility.DataType.XSTN); // Skintone XML

			if (!Utility.IsNullOrEmpty(keyPfd))
			{
				this.PropertySet = new Cpf();
				this.PropertySet.ProcessData(keyPfd[0], package, false);

				//this.packageHash = this.GetPackageHash();
			}

		}

		public IPackedFileDescriptor[] FindFiles(uint type)
		{
			if (this.package != null)
				return this.package.FindFiles(type);
			return new IPackedFileDescriptor[0];
		}

		public override void CommitChanges()
		{
			base.CommitChanges();
			if (this.stringList != null)
				this.stringList.SynchronizeUserData();
		}


		private uint GetPackageHash()
		{
			Random rn = new Random();
			uint ret = ((uint)rn.Next(0xffffff)|0xff000000u);
			foreach (IPackedFileDescriptor pfd in this.package.Index) 
			{
				///This is a scenegraph Resource so get the Hash from there!
				if (MetaData.RcolList.Contains(pfd.Type)) 
				{
					using (Rcol rcol = new GenericRcol(null, false))
					{
						rcol.ProcessData(pfd, this.package);
						ret = Hashes.GroupHash(rcol.FileName);
					}
					break;

				}
			}
			return ret;
		}

		/// <summary>
		/// Creates an empty text list resource and adds it to the specified package.
		/// </summary>
		/// <param name="package">An <see cref="IPackageFile"/> instance.</param>
		/// <returns>The FileDescriptor for the newly created text list.</returns>
		IPackedFileDescriptor CreateTextResource(IPackageFile package)
		{
			IPackedFileDescriptor ret = null;
			if (package == null)
				return null;

			uint group = this.GetScenegraphGroup(package);
			if (group != 0)
			{

				ret = package.NewDescriptor(
					SimPe.Data.MetaData.STRING_FILE,
					0x00000000u,
					group,
					0x00000001u
					);

				package.Add(ret, true);

				try 
				{
					// link the newly created resource
					IPackedFileDescriptor[] pfd3IDR = package.FindFiles(SimPe.Data.MetaData.REF_FILE);
					foreach (IPackedFileDescriptor pfd in pfd3IDR)
					{
						using (RefFile refFile = new RefFile())
						{
							refFile.ProcessData(pfd, package, false);

							ArrayList temp = new ArrayList();
							foreach (IPackedFileDescriptor item in refFile.Items)
							{
								temp.Add(item);
								// insert reference node to TextList after the UIData node
								if (item.Type == 0)
									temp.Add(ret);
							}

							refFile.Items = (IPackedFileDescriptor[])temp.ToArray(typeof(IPackedFileDescriptor));

							refFile.SynchronizeUserData();
						}

					}
				}
				catch
				{
					package.Remove(ret);
					ret = null;
				}

			
			}

			return ret;
		}


		uint GetScenegraphGroup(IPackageFile package)
		{
			uint ret = 0;
			foreach (IPackedFileDescriptor pfd in this.package.Index) 
				if (MetaData.RcolList.Contains(pfd.Type))
				{
					ret = pfd.Group;
					break;
				}
			return ret;
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
				if (disposing)
				{
					if (this.package is IDisposable)
						((IDisposable)this.package).Dispose();
				}
				disposed = true;         
			}

		}

		#endregion

	}

	public class PackageInfoTable : ListDictionary, IDisposable
	{
		// Track whether Dispose has been called.
		private bool disposed = false;


		public new PackageInfo this[object key]
		{
			get { return base[key] as PackageInfo; }
			set { base[key] = value; }
		}

		public PackageInfoTable()
		{
		}

		public void Add(object key, PackageInfo pnfo)
		{
			base.Add(key, pnfo);
		}


		public void RemovePackage(object key)
		{
			if (this.ContainsKey(key))
			{
				PackageInfo pnfo = this[key];
				pnfo.Dispose();
				this.Remove(key);
			}
		}

		public void RemoveAll()
		{
			foreach (PackageInfo pnfo in this.Values)
				pnfo.Dispose();
			this.Clear();
		}


		public bool ContainsKey(object key)
		{
			return this.Contains(key);
		}

		public bool ContainsValue(PackageInfo pnfo)
		{
			foreach (PackageInfo p in this)
				if (p == pnfo)
					return true;
			return false;
		}

		public bool ContainsPackage(IPackageFile package)
		{
			foreach (PackageInfo pnfo in this.Values)
				if (Object.ReferenceEquals(pnfo.Package, package))
					return true;
			return false;
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
				if (disposing)
				{
					// Dispose managed resources.
					foreach (PackageInfo pnfo in this.Values)
						if (pnfo.Package is IDisposable)
							((IDisposable)pnfo.Package).Dispose();
				}
			}
			disposed = true;         
		}


		#endregion
	}
	
}
