using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Data;
using SimPe.Plugin.Helper;
using System.Collections;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{

	/// <summary>
	/// Use this procedure to copy the archetype's resources that are
	/// not processed by any of the other Procedures.
	/// <example>IMG, SLOT</example>
	/// </summary>
	class Finalize : Procedure
	{
		internal static readonly List<uint> TypeList = GetTypeList();

		static List<uint> GetTypeList()
		{
			List<uint> ret = new List<uint>();
			ret.Add(Utility.DataType.IMG);
			ret.Add(Utility.DataType.SLOT);
			return ret;
		}
		
		public Finalize()
		{
			this.Enabled = true;
		}

		/// <summary>
		/// Copy the remaining resources from the archetype to the patient
		/// </summary>
		/// <param name="archetype"></param>
		public override void ApplyItem(IPackageFile archetype)
		{
			ReplaceResources(archetype, this.SimPackage, TypeList);
		}

		internal static void ReplaceResources(IPackageFile source, IPackageFile target, List<uint> resourceTypes)
		{
			// delete the original resources from the patient
			foreach (IPackedFileDescriptor pfd in target.Index)
				if (resourceTypes.Contains(pfd.Type))
					pfd.MarkForDelete = true;

			// copy the resources 
			foreach (IPackedFileDescriptor pfd in source.Index)
			{
				if (resourceTypes.Contains(pfd.Type))
				{
					IPackedFile fl = source.Read(pfd);

					IPackedFileDescriptor newpfd = target.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
					newpfd.UserData = fl.UncompressedData;
					target.Add(newpfd);
				}
			}

		}


	}

}
