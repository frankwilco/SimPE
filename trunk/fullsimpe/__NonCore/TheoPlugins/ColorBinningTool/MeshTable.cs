using System;
using System.Collections;
using System.Collections.Specialized;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;


namespace SimPe.Plugin
{
	/// <summary>
	/// Summary description for MeshTable.
	/// </summary>
	public class MeshTable : System.ComponentModel.Component
	{
		Hashtable loadedMeshes;
		Hashtable loadedReferences;

		public StringCollection FileNames
		{
			get
			{
				StringCollection ret = new StringCollection();
				foreach (string s in loadedMeshes.Keys)
					ret.Add(System.IO.Path.GetFileName(s));
				return ret;
			}
		}

		public MeshTable()
		{
			this.loadedMeshes = new Hashtable();
			this.loadedReferences = new Hashtable();
		}

		public MeshTable(System.ComponentModel.IContainer container) : this()
		{
			if (container != null)
				container.Add(this);
		}


		public IPackageFile LoadMesh(string filePath)
		{
			IPackageFile file = null;
			if (!this.loadedMeshes.ContainsKey(filePath))
			{
				file = File.LoadFromFile(filePath);
				MeshInfo[] meshes = this.GetMeshReferences(file);
				if (meshes.Length > 0)
				{
					this.loadedMeshes[filePath] = file;
					this.loadedReferences[filePath] = meshes;
				}
			}
			else
				file = this.FindPackage(filePath);
			return file;
		}


		public bool ValidatePackage(IPackageFile meshPackage)
		{
			return this.GetMeshReferences(meshPackage).Length > 0;
		}


		public bool IsLoaded(string filePath)
		{
			return this.loadedMeshes.ContainsKey(filePath);
		}


		public bool IsLoaded(IPackageFile meshPackage)
		{
			return this.loadedMeshes.ContainsValue(meshPackage);
		}


		public void ApplyMesh(RecolorItem item, MeshInfo mesh)
		{
			if (item.PropertySet == null)
				return;

			if (
				 !item.ContainsItem("resourcekeyidx")
			|| !item.ContainsItem("shapekeyidx")
				)
				return;

			//MeshInfo nodes = this.GetMeshReferences(meshPackage);
			if (mesh != null)
			{
				IPackedFileDescriptor pfd = this.Get3IDRResource(item);
				if (pfd != null)
				{
					RefFile refFile = new RefFile();
					refFile.ProcessData(pfd, item.PropertySet.Package, false);

					int idxCres = item.GetProperty("resourcekeyidx").IntegerValue;
					int idxShpe = item.GetProperty("shapekeyidx").IntegerValue;

					refFile.Items[idxCres] = mesh.ResourceNode;
					refFile.Items[idxShpe] = mesh.ShapeFile;

					refFile.SynchronizeUserData();
				}

			}

		}


		public void Clear()
		{
			this.loadedMeshes.Clear();
			this.loadedReferences.Clear();
		}


		public IPackageFile FindPackage(string filePathOrName)
		{
			if (!this.loadedMeshes.ContainsKey(filePathOrName))
			{
				foreach (DictionaryEntry de in this.loadedMeshes)
					if (
						String.Compare(
							System.IO.Path.GetFileName(Convert.ToString(de.Key)),
							System.IO.Path.GetFileName(filePathOrName),
							true
							) == 0
						)
						return (IPackageFile)de.Value;
			}
			else
			{
				return (IPackageFile)this.loadedMeshes[filePathOrName];
			}
			return null;
		}

		public MeshInfo[] FindMeshes(string filePathOrName)
		{
			if (!this.loadedReferences.ContainsKey(filePathOrName))
			{
				foreach (DictionaryEntry de in this.loadedReferences)
					if (
						String.Compare(
							System.IO.Path.GetFileName(Convert.ToString(de.Key)),
							System.IO.Path.GetFileName(filePathOrName),
							true
							) == 0
						)
						return (MeshInfo[])de.Value;
			}
			else
			{
				return (MeshInfo[])this.loadedReferences[filePathOrName];
			}
			return null;
		}

		public MeshInfo FindMeshByName(string name)
		{
			foreach (MeshInfo[] meshes in this.loadedReferences.Values)
				foreach (MeshInfo mesh in meshes)
					if (String.Compare(mesh.Description, name, true) == 0)
						return mesh;
			return null;
		}

		IPackedFileDescriptor Get3IDRResource(RecolorItem item)
		{
			if (item.PropertySet != null)
			{
				IPackedFileDescriptor[] pfds = Utility.FindFiles(item.PropertySet.Package, Data.MetaData.REF_FILE, item.PropertySet.FileDescriptor.Group, item.PropertySet.FileDescriptor.Instance);
				if (pfds.Length == 1)
					return pfds[0];
			}
			return null;
		}

		/// <summary>
		/// Gets the mesh references.
		/// </summary>
		/// <param name="items">Items.</param>
		public MeshInfo[] GetMeshReferences(RecolorItem[] items)
		{
			ArrayList ret = new ArrayList();

			ArrayList tidr = new ArrayList();
			foreach (RecolorItem item in items)
			{
				if (
					 !item.ContainsItem("resourcekeyidx")
				|| !item.ContainsItem("shapekeyidx")
					)
					continue;


				IPackedFileDescriptor idr = this.Get3IDRResource(item);
				if (idr != null)
				{
					RefFile refFile = new RefFile();
					refFile.ProcessData(idr, item.PropertySet.Package, false);

					MeshInfo mi = new MeshInfo();
					//mi.Description = "<not found in FileTable>";

					int idxCres = item.GetProperty("resourcekeyidx").IntegerValue;
					int idxShpe = item.GetProperty("shapekeyidx").IntegerValue;

					mi.ResourceNode = refFile.Items[idxCres];
					mi.ShapeFile = refFile.Items[idxShpe];

					if (mi.ResourceNode != null && mi.ShapeFile != null)
					{
						ret.Add(mi);
						mi.Description = new ResourceReference(mi.ResourceNode).ToString();

						IScenegraphFileIndexItem idx = this.FindFileByReference(mi.ResourceNode);
						if (idx != null)
						{
							mi.FileName = idx.Package.FileName;
							using (GenericRcol rcol = new GenericRcol()) 
							{
								rcol.ProcessData(idx.FileDescriptor, idx.Package, false);
								mi.Description = rcol.FileName.Replace("_cres", "");
							}
						}

					}
					
				}

			}


			return (MeshInfo[])ret.ToArray(typeof(MeshInfo));
		}


		public MeshInfo[] GetMeshReferences(IPackageFile meshPackage)
		{
			if (meshPackage == null)
				return null;

			ArrayList ret = new ArrayList();

			IPackedFileDescriptor[] cresFiles = meshPackage.FindFiles(SimPe.Data.MetaData.CRES);
			using (GenericRcol rcol = new GenericRcol())
			{

				foreach (IPackedFileDescriptor cresFile in cresFiles)
				{
					try 
					{
						rcol.ProcessData(cresFile, meshPackage, false);
						if (!Utility.IsNullOrEmpty(rcol.ReferencedFiles))
						{
							IPackedFileDescriptor shpeFile = rcol.ReferencedFiles[0];

							MeshInfo rp = new MeshInfo();
							rp.ResourceNode = cresFile;
							rp.ShapeFile = shpeFile;
							rp.Description = rcol.FileName.Replace("_cres", "");
							rp.FileName = meshPackage.FileName;
							ret.Add(rp);
						}
					}
					finally 
					{
						rcol.FileDescriptor = null;
						rcol.Package = null;
					}
				}

			}

			return (MeshInfo[])ret.ToArray(typeof(MeshInfo));
		}

		IScenegraphFileIndexItem FindFileByReference(IPackedFileDescriptor reference)
		{
			if (!FileTable.FileIndex.Loaded)
				FileTable.FileIndex.Load();

			IScenegraphFileIndexItem ret = null;

			// find in all packages
			IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileByGroupAndInstance(reference.Group, reference.LongInstance);
			if (!Utility.IsNullOrEmpty(items))
			{
				foreach (IScenegraphFileIndexItem sfi in items)
				{
					if (sfi.FileDescriptor.Type == reference.Type)
					{
						ret = sfi;
						break;
					}
				}

			}

			if (ret == null)
			{
				IScenegraphFileIndexItem[] sfi = FileTable.FileIndex.FindFileDiscardingGroup(reference); //, pnfo.Package);
				if (!Utility.IsNullOrEmpty(sfi))
					ret = sfi[0];
			}

			return ret;
		}



		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				// dispose loaded package files
				foreach (IDisposable file in this.loadedMeshes.Values)
					file.Dispose();
				this.Clear();
			}
			base.Dispose (disposing);
		}


		public class MeshInfo
		{
			IPackedFileDescriptor cresFile = null;
			IPackedFileDescriptor shpeFile = null;
			string description;
			string fileName;

			public IPackedFileDescriptor ResourceNode
			{
				get { return this.cresFile; }
				set { this.cresFile = value; }
			}

			public IPackedFileDescriptor ShapeFile
			{
				get { return this.shpeFile; }
				set { this.shpeFile = value; }
			}

			public string Description
			{
				get { return this.description; }
				set { this.description = value; }
			}

			public string FileName
			{
				get { return this.fileName; }
				set { this.fileName = value; }
			}

		}

	}


}
