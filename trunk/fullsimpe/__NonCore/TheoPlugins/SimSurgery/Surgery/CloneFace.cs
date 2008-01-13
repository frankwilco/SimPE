using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Plugin.Helper;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	public class CloneFace : GeneticProcedure
	{

		public CloneFace()
		{
		}

		public override void ApplyItem(IPackageFile archetype)
		{
			this.UpdateFaceStructure(archetype);

			this.UpdateFaceMesh(archetype);

			this.UpdateDNA();
		}


		void UpdateFaceStructure(IPackageFile archetype)
		{
			IPackedFileDescriptor lxnrArch = null;

			// copy the current (highest instance) LxNR of the archetype,
			// and save into the patient, making the changes
			// genetically transmissible

			IPackedFileDescriptor[] lxnr = archetype.FindFiles(Utility.DataType.LxNR);

			// get the highest instance LxNR resource from the archetype.
			for (int i = 0; i < lxnr.Length; i++)
				if (
					lxnrArch == null ||
					lxnr[i].Instance > lxnrArch.Instance
					)
					lxnrArch = lxnr[i];


			if (lxnrArch != null)
			{
				// delete the patient's facial structure(s)
				lxnr = this.SimPackage.FindFiles(Utility.DataType.LxNR);
				for (int i = 0; i < lxnr.Length; i++)
					lxnr[i].MarkForDelete = true;

				IPackedFile fl = archetype.Read(lxnrArch);
				IPackedFileDescriptor newpfd = this.SimPackage.NewDescriptor(
					lxnrArch.Type,
					lxnrArch.SubType,
					lxnrArch.Group,
					0x00000001u
					);

				newpfd.UserData = fl.UncompressedData;
				this.SimPackage.Add(newpfd, true);
			}

		} // UpdateFaceStructure

		void UpdateFaceMesh(IPackageFile archetype)
		{
			IPackedFileDescriptor[] pfdRefs = archetype.FindFiles(MetaData.REF_FILE);

			for (int i = 0; i < pfdRefs.Length; i++)
			{
				RefFile idr = new RefFile();
				idr.ProcessData(pfdRefs[i], archetype);

				MeshChain mc = new MeshChain(idr);

				// TODO: Finish this :P
				
			}

		} // UpdateFaceMesh

		void UpdateDNA()
		{
			/* Alas, the archetype's package does not 
			 * contain enough information, so the lack
			 * of a SDNA resource is fatal.
			 */
			if (this.ArchetypeInstance.HasValue)
			{
				// other procedures may change the same resource,
				// so it's of best interest that we dispose of
				// these objects as soon as possible
				using (SimDNA
					dnaArch = this.GetSimDNA(this.ArchetypeInstance.Value),
					dnaPat = this.GetSimDNA(this.SimDescription.Instance)
					)
				{
					dnaPat.Dominant.FacialFeature = dnaArch.Dominant.FacialFeature;
					// although the recessive gene for the facial data seems 
					// to be empty in all occasions, it's better to include 
					// that data for processing
					if (this.OverrideRecessiveGenes)
						dnaPat.Recessive.FacialFeature = dnaArch.Recessive.FacialFeature;
					dnaPat.SynchronizeUserData();
				}

			}

		} // UpdateDNA



	}

}
