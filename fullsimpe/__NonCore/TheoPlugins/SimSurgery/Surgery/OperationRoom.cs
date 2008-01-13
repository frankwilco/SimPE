using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.PackedFiles.Wrapper;
using SimPe.Packages;
using SimPe.Plugin.Helper;
using SimPe.Data;
using SimPe.Plugin.Properties;
using System.Collections;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	/// <summary>
	/// The OperationRoom class holds the Patient instance
	/// and performs a series of Procedures on it,
	/// using the Archetype's data.
	/// </summary>
	public sealed class OperationRoom : LocalizableObject, IEventLogContainer	
	{
		List<IProcedure> procedures;
		Dictionary<IProcedure, GenericCpfInfo> customItems;
		IPackageFile filePatient;
		IPackageFile fileArchetype;
		IPackageFile ngbh;
		SDesc sdescPatient;
		SDesc sdescArchetype;
		bool overrideRecessiveGenes = false;
		EventLog log;

		public event EventHandler ProcedureRun;

		/// <summary>
		/// Gets a list of <see cref="IProcedure"/> instances to be performed
		/// on the patient sim.
		/// </summary>
		internal List<IProcedure> Procedures
		{
			get
			{
				if (this.procedures == null)
					this.procedures = new List<IProcedure>();
				return this.procedures;
			}
		}

		internal Dictionary<IProcedure, GenericCpfInfo> CustomItems
		{
			get
			{
				if (this.customItems == null)
					this.customItems = new Dictionary<IProcedure, GenericCpfInfo>();
				return this.customItems;
			}

		}

		/// <summary>
		/// Gets or sets whether GeneticProcedure instances may overwrite
		/// the recessive genes of the patient sim (if applicable).
		/// </summary>
		public bool OverrideRecessiveGenes
		{
			get { return this.overrideRecessiveGenes; }
			set { this.overrideRecessiveGenes = value; }
		}

		/// <summary>
		/// Gets or sets an <see cref="IPackageFile"/> instance containing the 
		/// neighborhood database.
		/// </summary>
		public IPackageFile NeighborhoodPackage
		{
			get { return this.ngbh; }
			set { this.ngbh = value; }
		}

		/// <summary>
		/// Gets or sets an <see cref="IPackageFile"/> instance of the
		/// patient  sim's character file.
		/// </summary>
		public IPackageFile PatientSimPackage
		{
			get { return this.filePatient; }
			set { this.filePatient = value; }
		}

		/// <summary>
		/// Gets or sets a <see cref="SDesc"/> instance of the patient sim.
		/// </summary>
		public SDesc PatientSim
		{
			get { return this.sdescPatient; }
			set { this.sdescPatient = value; }
		}

		/// <summary>
		/// Gets or sets an <see cref="IPackageFile"/> instance of the
		/// archetype's character or template file.
		/// </summary>
		public IPackageFile ArchetypeSimPackage
		{
			get { return this.fileArchetype; }
			set { this.fileArchetype = value; }
		}

		/// <summary>
		/// Gets or sets a <see cref="SDesc"/> instance of the archetype sim.
		/// </summary>
		public SDesc ArchetypeSim
		{
			get { return this.sdescArchetype; }
			set { this.sdescArchetype = value; }
		}

		public EventLog EventLog
		{
			get
			{
				if (this.log == null)
					this.log = new EventLog();
				return this.log;
			}
		}

		public OperationRoom()
		{

		}

		public void AddProcedure(IProcedure procedure)
		{
			if (procedure != null)
			{
				if (!this.Procedures.Contains(procedure))
				{
					procedure.Enabled = true;
					this.Procedures.Add(procedure);
				}
			}
		}

		public void SetCustomItem(IProcedure procedure, GenericCpfInfo item)
		{
			if (item != null)
			{
				if (!this.Procedures.Contains(procedure))
					this.AddProcedure(procedure);

				this.CustomItems[procedure] = item;
			}
			else
			{
				if (this.CustomItems.ContainsKey(procedure))
					this.CustomItems.Remove(procedure);
			}
		}

		public void RemoveCustomItem(IProcedure procedure)
		{
			this.SetCustomItem(procedure, null);
		}

		public bool CanPerform()
		{
			// TODO: Localize messages
			// DONE
			if (this.ngbh == null)
			{
				this.EventLog.Add(this.GetString("msg01"));
				return false;
			}

			if (this.sdescPatient == null)
			{
				this.EventLog.Add(this.GetString("msg02"));
				return false;
			}

			if (this.filePatient == null)
			{
				this.EventLog.Add(this.GetString("msg03"));
				return false;
			}

			if (!Utility.IsNullOrEmpty(this.customItems))
				return true;

			if (this.sdescArchetype == null)
				if (this.fileArchetype == null)
				{
					this.EventLog.Add(this.GetString("msg04"));
					return false;
				}

			return true;
		}

		public void PerformSurgery()
		{
			this.EventLog.Clear();

			if (!this.CanPerform())
				return;

			// This special procedure is needed to copy the remaining
			// resources from a proper sim package.
			// If no sim is selected, this procedure isn't needed.
			if (this.ArchetypeSim != null)
				this.AddProcedure(new Finalize());

			WaitingScreen.Wait();

			foreach (IProcedure procedure in this.procedures)
			{
				if (!procedure.Enabled)
					continue;

				// TODO: Localize messsage
				// DONE
				WaitingScreen.UpdateMessage(String.Format(this.GetString("fmt01"), procedure.DisplayName));
				procedure.SimPackage = this.PatientSimPackage;

				if (procedure is IGeneticProcedure)
				{
					IGeneticProcedure gp = (IGeneticProcedure)procedure;
					gp.NeighborhoodPackage = this.NeighborhoodPackage;
					gp.OverrideRecessiveGenes = this.OverrideRecessiveGenes;
					gp.SimDescription = this.PatientSim;
					if (this.ArchetypeSim != null)
						gp.ArchetypeInstance = this.ArchetypeSim.Instance;

				}

				try
				{
					if (this.CustomItems.ContainsKey(procedure))
					{
						GenericCpfInfo customItem = this.CustomItems[procedure];
						procedure.ApplyItem(customItem);
					}
					else
					{
						procedure.ApplyItem(this.ArchetypeSimPackage);
					}
				}
				catch (NotImplementedException)
				{
					// the procedure wasn't supposed to run anyway,
					// so *this time* we won't make a fuss about it ;)
				}
				catch (Exception x)
				{
					// Ooops! Prepare to be sued for malpractice.
					this.EventLog.Add(x, this.GetString("fmt02"), procedure.DisplayName);
				}
				finally
				{
					if (this.ProcedureRun != null)
						this.ProcedureRun(this, EventArgs.Empty);
					this.EventLog.AddRange(procedure.EventLog);
				}

			}

			WaitingScreen.Stop();
		}


		#region Export Sim Template

		public File GenerateTemplate()
		{
			GeneratableFile ret = null;

			try
			{
				//list of all Files top copy from the Archetype
				List<uint> list = new List<uint>();
				list.Add(MetaData.REF_FILE); //3IDR
				list.Add(Utility.DataType.CRES); //CRES
				list.Add(Utility.DataType.GZPS); //GZPS, Property Set
				list.Add(Utility.DataType.AGED); //AGED
				list.Add(Utility.DataType.LxNR); //LxNR, Face
				list.Add(Utility.DataType.BINX); //BINX
				list.Add(Utility.DataType.GMDC); //GMDC
				list.Add(Utility.DataType.GMND); //GMND				
				list.Add(Utility.DataType.TXMT); //MATD
				list.Add(Utility.DataType.SHPE); //SHPE

				PackedFileDescriptor pfd1 = new PackedFileDescriptor();
				pfd1.Group = MetaData.LOCAL_GROUP; // 0xFFFFFFFFu;
				pfd1.SubType = 0x00000000;
				pfd1.Instance = 0xFF123456u;
				pfd1.Type = MetaData.REF_FILE;
				pfd1.UserData = Resources.Export3IDR;

				PackedFileDescriptor pfd2 = new PackedFileDescriptor();
				pfd2.Group = MetaData.LOCAL_GROUP;
				pfd2.SubType = 0x00000000;
				pfd2.Instance = 0xFF123456u;
				pfd2.Type = Utility.DataType.BINX;
				pfd2.UserData = Resources.ExportBINX;


				GeneratableFile source = GeneratableFile.LoadFromFile(sdescPatient.CharacterFileName);

				ret = GeneratableFile.LoadFromStream(null);
				ret.FileName = "";
				ret.Add(pfd1);
				ret.Add(pfd2);

				foreach (IPackedFileDescriptor pfd in source.Index)
				{
					if (list.Contains(pfd.Type))
					{
						IPackedFile file = source.Read(pfd);
						pfd.UserData = file.UncompressedData;
						ret.Add(pfd);

						if (
							pfd.Type == MetaData.GZPS ||
							pfd.Type == MetaData.REF_FILE
							) //property set and 3IDR
						{
							Cpf cpf = new Cpf();
							cpf.ProcessData(pfd, ret);

							CpfItem ci = new CpfItem();
							ci.Name = "product";
							ci.UIntegerValue = 0;
							cpf.AddItem(ci, false);

							ci = cpf.GetItem("version");
							if (ci == null)
							{
								ci = new CpfItem();
								ci.Name = "version";
								if ((cpf.GetSaveItem("age").UIntegerValue & (uint)Ages.YoungAdult) != 0)
									ci.UIntegerValue = 2;
								else
									ci.UIntegerValue = 1;

								cpf.AddItem(ci);
							}


							cpf.SynchronizeUserData();
						}
					}
				}

			}
			catch (Exception ex)
			{
				SimPe.Helper.ExceptionMessage("", ex);
			}

			return ret;
		}

		#endregion



	}

}
