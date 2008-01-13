using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Files;
using System;
using SimPe.Plugin.Helper;
using SimPe.Data;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	/// <summary>
	/// Defines a Procedure that modifies the target <see cref="SimPackage"/> and
	/// the sim's SDNA resources.
	/// </summary>
	public abstract class GeneticProcedure : Procedure, IGeneticProcedure
	{
		bool overrideRecessiveGenes = false;
		IPackageFile ngbh;
		SDesc simDescription;
		Nullable<uint> dnaInstance = null;


		/// <summary>
		/// Gets or sets a value indicating whether the Procedure should
		/// modify the patient sim's recessive genes, along with the dominant genes.
		/// </summary>
		public bool OverrideRecessiveGenes
		{
			get { return this.overrideRecessiveGenes; }
			set { this.overrideRecessiveGenes = value; }
		}

		/// <summary>
		/// Gets or sets a <see cref="IPackageFile"/> instance that should contain
		/// the SDNA resources associated with the patient and archetype (if applicable) sims.
		/// </summary>
		public IPackageFile NeighborhoodPackage
		{
			get { return this.ngbh; }
			set { this.ngbh = value; }
		}

		/// <summary>
		/// Gets or sets a <see cref="SDesc"/> instance associated with the patient sim.
		/// </summary>
		public SDesc SimDescription
		{
			get { return simDescription; }
			set { simDescription = value; }
		}

		/// <summary>
		/// Gets or sets the archetype sim's instance.
		/// </summary>
		public Nullable<uint> ArchetypeInstance
		{
			get { return this.dnaInstance; }
			set { this.dnaInstance = value; }
		}


		protected GeneticProcedure() : base()
		{
		}

		/// <summary>
		/// Builds a <see cref="SimDNA"/> object from a provided sim instance in the
		/// current <see cref="NeighborhoodPackage"/>.
		/// </summary>
		/// <param name="simInstance">The instance number of a sim.</param>
		/// <returns>A <see cref="SimDNA"/> object of the provided sim.</returns>
		public SimDNA GetSimDNA(uint simInstance)
		{
			// TODO: Localize messages?
			if (this.ngbh == null)
			{
				this.EventLog.Add("The NeighborhoodPackage object is not set to an IPackageFile instance.");
				return null;
			}

			IPackedFileDescriptor pfd = this.ngbh.FindFile(Utility.DataType.SDNA, 0, MetaData.LOCAL_GROUP, simInstance);
			if (pfd == null)
			{
				this.EventLog.Add(String.Format("The SDNA resource #{0:X8} was not found.", simInstance));
				return null;
			}

			SimDNA ret = new SimDNA();
			ret.ProcessData(pfd, this.ngbh);
			return ret;
		}



		protected SimDNA BuildSimDNA(IPackageFile archetype)
		{
			SimDNA ret = null;

			if (this.ArchetypeInstance.HasValue)
			{
				ret = this.GetSimDNA(this.ArchetypeInstance.Value);
			}
			else
			{
				using (AgeData data = this.GetAgeData(archetype))
				{
					if (data != null)
					{
						ret = new SimDNA();
						Gene gd = ret.Dominant;
						Gene gr = ret.Recessive;

						gd.Eye = data.Eyecolor.ToString();
						gd.Hair = data.Hairtone.ToString();
						gd.Skintone = data.Skintone.ToString();
						gd.SkintoneRange = data.Skintone.ToString();

						gr.Eye = gd.Eye;
						gr.Hair = gd.Hair;
						gr.Skintone = gd.Skintone;
						gr.SkintoneRange = gd.SkintoneRange;
						
					}
				}

			}

			return ret;
		}

	}


	/// <summary>
	/// Defines the set of members of a <see cref="IProcedure"/> implementing class
	/// that will also modify the patient sim's genetic data.
	/// </summary>
	public interface IGeneticProcedure : IProcedure
	{
		/// <summary>
		/// Gets or sets a value indicating whether the Procedure should
		/// modify the patient sim's recessive genes, along with the dominant genes.
		/// </summary>
		bool OverrideRecessiveGenes { get; set; }

		/// <summary>
		/// Gets or sets a <see cref="IPackageFile"/> instance that should contain
		/// the SDNA resources associated with the patient and archetype (if applicable) sims.
		/// </summary>
		IPackageFile NeighborhoodPackage { get; set; }

		/// <summary>
		/// Gets or sets a <see cref="SDesc"/> instance associated with the patient sim.
		/// </summary>
		SDesc SimDescription { get; set; }

		/// <summary>
		/// Gets or sets the archetype sim's instance.
		/// </summary>
		Nullable<uint> ArchetypeInstance { get; set; }

	}


}
