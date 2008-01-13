using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Data;
using SimPe.Interfaces.Scenegraph;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{

	public class CloneMakeup : Procedure
	{
		List<MaterialDefinitionInfo> txmtListArchetype;

		public CloneMakeup()
		{
		}

		public override void ApplyItem(IPackageFile archetype)
		{
			txmtListArchetype = MaterialDefinitionInfo.FindMaterials(archetype);
			List<MaterialDefinitionInfo> txmtListPatient = MaterialDefinitionInfo.FindMaterials(this.SimPackage);
			foreach (MaterialDefinitionInfo txmtPatient in txmtListPatient)
			{
				MaterialDefinitionInfo txmtArchetype = MaterialDefinitionInfo.FindMaterial(
					txmtListArchetype,
					txmtPatient.Age,
					txmtPatient.Gender);

				if (txmtArchetype != null)
				{
					this.UpdateMakeup(txmtPatient, txmtArchetype);
					try
					{
						// problem can happen here...
						txmtPatient.CommitChanges();
					}
					catch (Exception x)
					{
						// TODO: provide more detailed information
						this.EventLog.Add(x);
					}
				}

			}
		
		}

		void UpdateMakeup(MaterialDefinitionInfo mdTarget, MaterialDefinitionInfo mdSource)
		{

			string[] names = new string[mdSource.TextureNames.Count - 2];
			for (int i = 2; i < mdSource.TextureNames.Count; i++)
				//         |
				//         V
				// skip skintone and eyecolor layers
				names[i - 2] = mdSource.TextureNames[i];

			if (mdTarget.TextureNames.Count > 2)
				mdTarget.TextureNames.RemoveRange(2, mdTarget.TextureNames.Count - 2);
			mdTarget.TextureNames.AddRange(names);

			

			Guid[] layers = new Guid[mdSource.OverlayGuids.Count - 1];
			for (int i = 1; i < mdSource.OverlayGuids.Count; i++)
				//         |
				//         V
				// skip eyecolor layer (skintone is in another property)
				layers[i - 1] = mdSource.OverlayGuids[i];

			if (mdTarget.OverlayGuids.Count > 1)
				mdTarget.OverlayGuids.RemoveRange(1, mdSource.OverlayGuids.Count - 1);
			mdTarget.OverlayGuids.AddRange(layers);

		}


	}

}
