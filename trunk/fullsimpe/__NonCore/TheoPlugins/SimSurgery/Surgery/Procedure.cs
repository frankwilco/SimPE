using System;
using SimPe.Interfaces.Files;
using SimPe.PackedFiles.Wrapper;
using SimPe.Plugin.Helper;
using System.Resources;
using SimPe.Data;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	/// <summary>
	/// Implements the properties defined in the <see cref="IProcedure"/> interface.
	/// <para>Defines but does not implement the <see cref="ApplyItem"/> methods.</para>
	/// <para>This is the default implementation of the <see cref="IProcedure"/> interface.</para>
	/// </summary>
	/// <remarks>
	/// A class that inherits from <see cref="Procedure"/> may change a variety of resources
	/// contained in one or more packages, but should not take the responsibility of
	/// persisting those changes to the filesystem.
	/// </remarks>
	public abstract class Procedure : LocalizableObject, IProcedure, IEventLogContainer
	{
		IPackageFile package;
		EventLog log;
		bool enabled;
		string name;
		FileDatabase files;
		
		/// <summary>
		/// Gets or sets the <see cref="IPackageFile"/> instance
		/// associated with the patient sim.
		/// </summary>
		public IPackageFile SimPackage
		{
			get { return package; }
			set { package = value; }
		}

		/// <summary>
		/// Gets or sets whether the procedure is enabled and will run.
		/// </summary>
		public bool Enabled
		{
			get { return this.enabled; }
			set { this.enabled = value; }
		}

		/// <summary>
		/// Gets a <see cref="EventLog"/> instance containing a
		/// list of exceptions that occurred.
		/// </summary>
		public EventLog EventLog
		{
			get {
				if (this.log == null)
					this.log = new EventLog();
				return this.log;
			}
		}

		/// <summary>
		/// Gets a descriptive title for this procedure.
		/// </summary>
		public virtual string DisplayName
		{
			get	{
				if (this.name != null)
					return name;
				try
				{
					return (name = this.GetString("$DisplayName"));
				}
				catch
				{

				}
				return (name = this.GetType().Name);
			}
		}


		public FileDatabase FileDatabase
		{
			get { return this.files; }
			set { this.files = value; }
		}

		/// <summary>
		/// The default constructor, visible only to inheritors.
		/// </summary>
		protected Procedure()
		{
		}

		/// <summary>
		/// Prepares a selection of resources from the supplied <paramref name="archetype" /> parameter,
		/// and copies them to the target <see cref="SimPackage"/>.
		/// </summary>
		/// <param name="archetype">A <see cref="IPackageFile"/> instance of the archetype sim package.</param>
		public virtual void ApplyItem(IPackageFile archetype)
		{
			throw new NotImplementedException("The method or operation is not implemented.");
		}

		/// <summary>
		/// Processes the data from the <paramref name="cpfInfo"/> parameter, and
		/// copies the relevant resources to the target <see cref="SimPackage"/>.
		/// </summary>
		/// <param name="cpfInfo">A <see cref="GenericCpfInfo"/> instance containing the resource links.</param>
		public virtual void ApplyItem(GenericCpfInfo cpfInfo)
		{
			throw new NotImplementedException("The method or operation is not implemented.");
		}

		/// <summary>
		/// Builds a <see cref="AgeData"/> object from an existing AGED resource
		/// in a sim package.
		/// </summary>
		/// <param name="package"></param>
		/// <returns></returns>
		public AgeData GetAgeData(IPackageFile package)
		{
			if (package == null)
				throw new ArgumentNullException();

			IPackedFileDescriptor pfd = package.FindFile(
				Utility.DataType.AGED,
				0x00,
				MetaData.LOCAL_GROUP,
				0x01);

			if (pfd != null)
				return new AgeData(pfd, package);

			return null;	
		}


		/// <summary>
		/// Overriden. Returns the <see cref="DisplayName"/> of the current object.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return this.DisplayName;
		}


	}


	/// <summary>
	/// Defines the set of members of a class that will process the resources either
	/// contained in an archetype sim package, or pointed by a <see cref="GenericCpfInfo"/> instance,
	/// and applies them to the target sim package.
	/// </summary>
	/// <remarks>
	/// Although the two <see cref="ApplyItem"/> methods can be called arbitrarily, it is recommended
	/// that the implementor should allow only one execution from either one of the methods to occur.
	/// </remarks>
	public interface IProcedure : IEventLogContainer
	{
		/// <summary>
		/// Gets a descriptive title for the procedure.
		/// </summary>
		string DisplayName { get; }

		/// <summary>
		/// Gets or sets whether the procedure is enabled and will run.
		/// </summary>
		bool Enabled { get; set; }

		/// <summary>
		/// Gets or sets the <see cref="IPackageFile"/> instance
		/// associated with the patient sim.
		/// </summary>
		IPackageFile SimPackage { get; set; }

		/// <summary>
		/// Prepares a selection of resources from the supplied <paramref name="archetype" /> parameter,
		/// and copies them to the target <see cref="SimPackage"/>.
		/// </summary>
		/// <param name="archetype">A <see cref="IPackageFile"/> instance of the archetype sim package.</param>
		void ApplyItem(IPackageFile archetype);

		/// <summary>
		/// Processes the data from the <paramref name="cpfInfo"/> parameter, and
		/// copies the relevant resources to the target <see cref="SimPackage"/>.
		/// </summary>
		/// <param name="cpfInfo">A <see cref="GenericCpfInfo"/> instance containing the resource links.</param>
		void ApplyItem(GenericCpfInfo cpfInfo);


	}


}
