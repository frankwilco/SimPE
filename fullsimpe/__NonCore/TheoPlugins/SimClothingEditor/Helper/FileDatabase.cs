using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Scenegraph;
using SimPe.Interfaces.Files;
using System.Collections;
using SimPe.Plugin.Helper;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Helper
{

	/// <summary>
	/// 
	/// </summary>
	public abstract class FileDatabase
	{
		static Dictionary<IScenegraphFileIndexItem, Cpf> cpfItems;
		List<GenericCpfInfo> items;

		internal static Dictionary<IScenegraphFileIndexItem, Cpf> PropertySets
		{
			get	{
				if (cpfItems == null)
				{
					cpfItems = new Dictionary<IScenegraphFileIndexItem, Cpf>();
					IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Utility.DataType.GZPS, true);
					for (int i = 0; i < items.Length; i++)
					{
						IScenegraphFileIndexItem item = items[i];
						cpfItems[item] = new Cpf();
					}
				}
				return cpfItems;
			}
		}

		public List<GenericCpfInfo> Items
		{
			get { return this.items; }
		}

		protected FileDatabase()
		{
			this.Initialize();
		}

		private void Initialize()
		{
			this.items = new List<GenericCpfInfo>();
			try
			{
				if (!FileTable.FileIndex.Loaded)
					FileTable.FileIndex.Load();

				List<IScenegraphFileIndexItem> items = this.GetPackageItems(null);
				for (int i = 0; i < items.Count; i++)
				{
					IScenegraphFileIndexItem item = items[i];
					this.AddFile(item);
				}

			}
			catch //(Exception x)
			{
			}
			finally
			{
			}

		}

		public void AddPackage(string filename)
		{
			IPackageFile package = File.LoadFromFile(filename);

			this.AddPackage(package);

		}

		public void AddPackage(IPackageFile package)
		{
			if (package != null)
			{
				FileTable.FileIndex.AddIndexFromPackage(package);

				List<IScenegraphFileIndexItem> items = this.GetPackageItems(package);
				if (!Utility.IsNullOrEmpty(items))
				{
					for (int i = 0; i < items.Count; i++)
						this.AddFile(items[i]);
				}

			}
		}

		protected abstract List<IScenegraphFileIndexItem> GetPackageItems(IPackageFile package);

		public abstract void AddFile(IScenegraphFileIndexItem item);

		public GenericCpfInfo FindItemByFamily(Guid family)
		{
			return this.items.Find(delegate(GenericCpfInfo item) {
				return (item.Family == family);
			});
		}


	}

	public class ClothingDatabase : FileDatabase
	{
		List<string> names = new List<string>();

		public ClothingDatabase()
			: base()
		{
		}


		protected override List<IScenegraphFileIndexItem> GetPackageItems(IPackageFile package)
		{
			List<IScenegraphFileIndexItem> ret = new List<IScenegraphFileIndexItem>();
			if (package != null)
			{
				IPackedFileDescriptor[] pfds = package.FindFiles(Utility.DataType.GZPS);
				if (pfds.Length > 0)
				{
					foreach (IPackedFileDescriptor pfd in pfds)
					{
						FileIndexItem item = new FileIndexItem(pfd, package);
						ret.Add(item);
					}
				}
			}
			else
			{
				ret.AddRange(FileTable.FileIndex.FindFile(Utility.DataType.GZPS, true));
			}
			return ret;
		}

		public override void AddFile(IScenegraphFileIndexItem item)
		{
			if (item == null)
				throw new ArgumentNullException();

			Cpf cpf = new Cpf();
			cpf.ProcessData(item);

			TextureOverlayInfo info = new TextureOverlayInfo(cpf);
			if (info.Type == CpfType.Skin) // && info.Family == Guid.Empty)
			{
				//this.names.Add(info.Name);
				this.Items.Add(info);
			}

		}


	}


}
