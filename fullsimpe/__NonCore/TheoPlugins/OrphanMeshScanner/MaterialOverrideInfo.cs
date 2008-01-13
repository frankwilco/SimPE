using System;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Scenegraph;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin.Wrapper
{
	public class MaterialOverrideInfo : GenericCpfInfo
	{
		public string ModelName
		{
			get { return this.CpfItem("modelName").StringValue; }
			set { this.SetValue("modelName", value); }
		}

		public string SubsetName
		{
			get { return this.CpfItem("subsetName").StringValue; }
			set { this.SetValue("subsetName", value); }
		}

		public uint ObjectGuid
		{
			get { return this.CpfItem("objectGUID").UIntegerValue; }
			set { this.SetValue("objectGUID", value); }
		}


		// TODO: create bit-field enumeration
		public uint StateFlags
		{
			get { return this.CpfItem("materialStateFlags").UIntegerValue; }
			set { this.SetValue("materialStateFlags", value); }
		}


		public uint ObjectStateIndex
		{
			get { return this.CpfItem("objectStateIndex").UIntegerValue; }
			set { this.SetValue("objectStateIndex", value); }
		}

		public MaterialOverrideInfo()
		{
		}

		public MaterialOverrideInfo(Cpf propertySet)
		{
			this.PropertySet = propertySet;
		}

		public MaterialOverrideInfo(IScenegraphFileIndexItem item)
		{
			this.ProcessPackage(item.Package, item.FileDescriptor);
		}

		public override void ProcessPackage(IPackageFile package, IPackedFileDescriptor pfd)
		{
			if (pfd == null)
				throw new ArgumentNullException();

			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package, false);
		}

	}
}
