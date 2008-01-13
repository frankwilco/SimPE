using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;
using SimPe.Plugin.Helper;
using System.Collections;
using SimPe.Data;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin
{

	/// <summary>
	/// This class serves to link the four types of resources that
	/// constitute a mesh: CRES, SHPE, GMND and GMDC. (PS: oh, and TXMT too ;)
	/// </summary>
	/// <remarks>
	/// The intent of this class is to facilitate the manipulation of
	/// meshes inside a package, allowing to modify the different
	/// types of resources as a single mesh unit.
	/// </remarks>
	public class MeshChain : AbstractRefInfo
	{
		GenericRcol cres;
		GenericRcol shpe;
		GenericRcol gmnd;
		GenericRcol gmdc;
		List<GenericRcol> models;
		List<MaterialDefinitionInfo> subsets;

		RcolFactory<GenericRcol> genericRcolFactory;

		/// <remarks>
		/// For some unknown reason, the pointers to the GMND resources stored
		/// it the shape's "Models" list have the group id set to a value that is 
		/// apparently dependent on the sim package (whether it's a sim or a sim template package).
		/// 
		/// On every analyzed package, the group id is in the form 0x6F00XXXX, with
		/// the high word 0x6F00 being constant, while the low word is different
		/// for each package.
		/// 
		/// Of course the GMND resources themselves have the group id set to
		/// the custom group (0xFFFFFFFF), but until the purpose of that strange
		/// value is known, it's better to keep it...
		/// </remarks>
		uint customModelGroup = MetaData.LOCAL_GROUP;


		/// <summary>
		/// Gets or sets a <see cref="IPackageFile"/> object that contains
		/// the mesh resources.
		/// </summary>
		protected override IPackageFile Package
		{
			get { return base.Package; }
			set
			{
				base.Package = value;
				this.genericRcolFactory = new RcolFactory<GenericRcol>(value);
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="GenericRcol"/> object that 
		/// represents the ResourceNode (CRES) resource.
		/// </summary>
		public GenericRcol ResourceNode
		{
			get { return this.cres; }
			set
			{
				this.cres = value;
				this.Shape = this.GetSHPE();
			}
		}

		/// <summary>
		/// Gets or sets the <see cref="GenericRcol"/> object that
		/// represents the Shape (SHPE) resource.
		/// </summary>
		public GenericRcol Shape
		{
			get { return this.shpe; }
			set
			{
				this.shpe = value;
				this.models = this.GetModels();
				this.subsets = this.GetSubsets();
				if (!Utility.IsNullOrEmpty(this.models))
					this.GeometricNode = this.models[0];
			}

		}

		/// <summary>
		/// Gets or sets the first item in the model list.
		/// </summary>
		public GenericRcol GeometricNode
		{
			get { return this.gmnd; }
			set	{
				this.gmnd = value;
				if (!Utility.IsNullOrEmpty(this.models))
					this.models[0] = value;
				this.GeometricData = this.GetGMDC();
			}
		}

		/// <summary>
		/// Gets a list of <see cref="GenericRcol"/> objects, each one representing
		/// a GeomentricNode (GMND) resource referenced by the <see cref="Shape"/>
		/// property.
		/// </summary>
		public List<GenericRcol> Models
		{
			get { return this.models; }
		}

		/// <summary>
		/// Gets a list of <see cref="MaterialDefinitionRcol"/> objects, each one representing
		/// a MaterialDefinition (TXMT) resource referenced by the <see cref="Shape"/> property.
		/// </summary>
		public List<MaterialDefinitionInfo> Subsets
		{
			get { return this.subsets; }
		}

		public GenericRcol GeometricData
		{
			get { return this.gmdc; }
			set { this.gmdc = value; }
		}

		public override RefFile ReferenceFile
		{
			get
			{
				return base.ReferenceFile;
			}
			set
			{
				base.ReferenceFile = value;
				this.ResourceNode = this.GetCRES();
			}
		}

		protected MeshChain()
		{
		}

		public MeshChain(RefFile index) : base(index)
		{
		}

		public MeshChain(GenericRcol cres)
		{
			if (cres != null)
			{
				this.Package = cres.Package;
				this.ResourceNode = cres;
			}
		}

		public MeshChain(IPackedFileDescriptor pfdCres, IPackageFile package)
		{
			GenericRcol cres = new GenericRcol();
			cres.ProcessData(pfdCres, package);
			
			this.Package = package;
			this.ResourceNode = cres;
		}

		public MeshChain(IScenegraphFileIndexItem item)
		{
			GenericRcol cres = new GenericRcol();
			cres.ProcessData(item);

			this.Package = item.Package;
			this.ResourceNode = cres;

		}

		GenericRcol GetCRES()
		{
			if (this.ReferenceFile != null)
			{
				foreach (IPackedFileDescriptor pfd in this.ReferenceFile.Items)
					if (pfd.Type == Utility.DataType.CRES)
						return this.genericRcolFactory.GetRcol(pfd);
			}

			return null;
		}

		GenericRcol GetSHPE()
		{
			if (this.cres != null)
			{
				ArrayList shapes = this.cres.ReferenceChains["Generic"] as ArrayList;
				if (shapes != null)
				{
					foreach (IPackedFileDescriptor pfd in shapes)
						if (pfd.Type == Utility.DataType.SHPE)
							return this.genericRcolFactory.GetRcol(pfd);
				}
			}
			return null;
		}

		GenericRcol GetGMDC()
		{
			if (this.gmnd != null)
			{
				ArrayList gen = this.gmnd.ReferenceChains["Generic"] as ArrayList;
				if (gen != null)
				{
					foreach (IPackedFileDescriptor pfd in gen)
					{
						if (pfd.Type == Utility.DataType.GMDC)
							return this.genericRcolFactory.GetRcol(pfd);
					}
				}
			}
			return null;
		}

		List<GenericRcol> GetModels()
		{
			List<GenericRcol> ret = null;
			if (this.shpe != null)
			{
				ret = new List<GenericRcol>();

				ArrayList models = this.shpe.ReferenceChains["Models"] as ArrayList;
				if (models != null)
				{
					foreach (IPackedFileDescriptor pfd in models)
					{
						if (pfd.Type == Utility.DataType.GMND)
						{
							if (this.customModelGroup == MetaData.LOCAL_GROUP)
								this.customModelGroup = pfd.Group;

							GenericRcol model = this.genericRcolFactory.GetRcol(pfd);
							if (model != null)
								ret.Add(model);
						}
					}
				}

			}
			return ret;
		}

		List<MaterialDefinitionInfo> GetSubsets()
		{
			List<MaterialDefinitionInfo> ret = null;
			if (this.shpe != null)
			{
				ret = new List<MaterialDefinitionInfo>();

				ArrayList models = this.shpe.ReferenceChains["Subsets"] as ArrayList;
				if (models != null)
				{
					//RcolFactory<MaterialDefinitionRcol> mmatFactory = new RcolFactory<MaterialDefinitionRcol>(package);
					foreach (IPackedFileDescriptor pfd in models)
					{
						if (pfd.Type == Utility.DataType.TXMT)
						{
							GenericRcol rcol = this.genericRcolFactory.GetRcol(pfd);
							if (rcol != null)
								ret.Add(new MaterialDefinitionInfo(rcol));
						}
					}
				}

			}
			return ret;
		}


	}

	internal class RcolFactory<T> where T : Rcol, new()
	{
		IPackageFile package;

		public IPackageFile Package
		{
			get { return this.package; }
			set { this.package = value; }
		}

		public RcolFactory()
		{
		}

		public RcolFactory(IPackageFile package)
		{
			this.package = package;
		}

		public T GetRcol(IPackedFileDescriptor pfd)
		{
			return this.GetRcol(pfd, true);
		}

		public T GetRcol(IPackedFileDescriptor pfd, bool localOnly)
		{
			if (pfd != null)
			{
				IPackedFileDescriptor desc = package.FindFile(pfd);
				if (desc == null)
				{
					// *sigh* see the explanation of the "customModelGroup" field
					desc = package.FindFile(pfd.Type, pfd.SubType, MetaData.LOCAL_GROUP, pfd.Instance);
				}

				if (desc == null && !localOnly)
				{
					IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileDiscardingGroup(pfd);
					if (!Utility.IsNullOrEmpty(items))
					{
						foreach (IScenegraphFileIndexItem item in items)
						{
							if (item.FileDescriptor.Group == pfd.Group)
							{
								desc = item.FileDescriptor;
								break;
							}
						}
					}
				}

				if (desc != null)
				{
					T rcol = new T();
					rcol.ProcessData(desc, package);
					return rcol;
				}

			}
			return default(T);
		}

	}




}
