using System;
using System.Collections.Generic;
using System.Text;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Interfaces.Files;
using SimPe.Plugin.Helper;
using SimPe.Plugin;
using System.Collections;

namespace SimPe.Plugin.Wrapper
{

	/// <remarks>
	/// Wrapper for AGED resources.
	/// </remarks>
	public sealed class AgeData : AbstractCpfInfo, IReferenceInfo
	{
		RefFile refFile;
		List<ReferenceIndex> list;
		bool petsMode = false;

		string cntKey;
		string lsKey;
		string lkKey;
		string leKey;

		public RefFile ReferenceFile
		{
			get
			{
				if (this.refFile == null)
				{
					try
					{
						IPackedFileDescriptor pfd = this.Package.FindFile(MetaData.REF_FILE, this.PropertySet.FileDescriptor.SubType, this.PropertySet.FileDescriptor.Group, this.PropertySet.FileDescriptor.Instance);
						if (pfd != null)
						{
							refFile = new RefFile();
							refFile.ProcessData(pfd, this.Package);
						}
					}
					catch
					{
					}
				}
				return refFile;
			}
			set
			{
				throw new NotSupportedException();
			}
		}

		public Guid Hairtone
		{
			get { return Utility.ParseGuid(CpfItem("haircolor")); }
			set { this.SetValue("haircolor", value.ToString()); }
		}

		public Guid Skintone
		{
			get { return Utility.ParseGuid(CpfItem("skincolor")); }
			set { this.SetValue("skincolor", value.ToString()); }
		}

		public Guid Eyecolor
		{
			get { return Utility.ParseGuid(CpfItem("eyecolor")); }
			set { this.SetValue("eyecolor", value.ToString()); }
		}

		public Ages Age
		{
			get { return (Ages)CpfItem("age").UIntegerValue; }
			set { this.SetValue("age", Convert.ToUInt32(value)); }
		}

		public SimGender Gender
		{
			get { return (SimGender)CpfItem("gender").UIntegerValue; }
			set { this.SetValue("gender", Convert.ToUInt32(value)); }
		}

		public SdscNightlife.SpeciesType Species
		{
			get { return (SdscNightlife.SpeciesType)CpfItem("species").UIntegerValue; }
			set { this.SetValue("species", Convert.ToUInt32(value)); }
		}

		public float HeightMultiplier
		{
			get { return this.CpfItem("stretch").SingleValue; }
			set { this.SetValue("stretch", value); }
		}

		/// <summary>
		/// Gets the index in the ReferenceFile that links to
		/// the CRES resource of the sim's skeleton.
		/// </summary>
		public uint SkeletonResourceIndex
		{
			get { return this.CpfItem("skeletonkeyidx").UIntegerValue; }
		}

		internal List<ReferenceIndex> List
		{
			get
			{
				if (this.list == null)
				{
					this.list = new List<ReferenceIndex>();

					uint count = this.CpfItem(cntKey).UIntegerValue;
					for (int i = 0; i < count; i++)
					{
						ReferenceIndex item = new ReferenceIndex(
							this.CpfItem(String.Format("{0}{1}", lsKey, i)).IntegerValue,
							this.CpfItem(String.Format("{0}{1}", lkKey, i)).UIntegerValue
							);

						for (int j = 0; j < item.Length; j++)
							item.Indices[j] = this.CpfItem(String.Format("{0}{1}_{2}", leKey, i, j)).IntegerValue;

						this.list.Add(item);
					}
				}
				return this.list;
			}
		}

		internal bool PetsMode
		{
			get { return this.petsMode; }
			set
			{
				this.petsMode = value;
				if (this.petsMode)
				{
					cntKey = "listcntStd";
					lsKey = "lss";
					lkKey = "lks";
					leKey = "les";
				}
				else
				{
					cntKey = "listcnt";
					lsKey = "ls";
					lkKey = "lk";
					leKey = "le";
				}
			}
		}


		public AgeData()
		{
			try
			{
				// is the current EP at least Pets?
				// set this as expected mode, but...
				this.PetsMode = Comparer.Default.Compare(PathProvider.Global.Latest.Expansion, Expansions.Pets) >= 0;
			}
			catch
			{

			}

		}

		public AgeData(IPackedFileDescriptor pfd, IPackageFile package) : this()
		{
			this.PropertySet = new Cpf();
			this.PropertySet.ProcessData(pfd, package);

			// ...but it can be overriden by individual package selection.
			this.PetsMode = this.ContainsItem("listcntStd");
		}

		public override void CommitChanges()
		{
			if (this.list != null)
			{
				for (int i = 0; i < this.list.Count; i++)
				{
					ReferenceIndex item = this.list[i];
					this.SetValue(String.Format("{0}{1}", lsKey, i), item.Length);
					this.SetValue(String.Format("{0}{1}", lkKey, i), item.K);
					for (int j=0; j<item.Length; j++)
						this.SetValue(String.Format("{0}{1}_{2}", leKey, i, j), item.Indices[j]);
				}

				this.SetValue(cntKey, (uint)this.list.Count);
			}
			base.CommitChanges();
		}



		public static SkinCategory CategoryConvert(SkinCategories category)
		{
			switch (category)
			{
				case SkinCategories.Everyday:
					return SkinCategory.Everyday;

				default:
					return (SkinCategory)Convert.ToUInt32(category);
			}
		}

		public static SkinCategories CategoryConvert(SkinCategory category)
		{
			switch (category)
			{
				case SkinCategory.Everyday:
				case SkinCategory.Unknown:
					return SkinCategories.Everyday;

				default:
					return (SkinCategories)Convert.ToUInt32(category);
			}
		}


		/// <summary>
		/// Builds a <see cref="AgeData"/> object from an existing AGED resource
		/// in a sim package.
		/// </summary>
		/// <param name="package"></param>
		/// <returns></returns>
		public static AgeData GetAgeData(IPackageFile package)
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


	}


	/// <summary>
	/// The purpose of this information is to build the sim's clothing wardrobe
	/// </summary>
	internal sealed class ReferenceIndex
	{
		/// <summary>
		/// Length of reference array
		/// </summary>
		int s;

		public int Length
		{
			get { return this.s; }
			set {
				this.s = value;
				if (this.e == null || this.e.Length != s)
				{
					int[] indices = new int[s];
					if (e != null)
						e.CopyTo(indices, 0);
					this.e = indices;
				}
			}
		}

		/// <summary>
		/// High word defines the SkinCategory, low word defines the OutfitType
		/// </summary>
		internal uint K;


		private int[] e;

		/// <summary>
		/// Index in the 3IDR resource
		/// </summary>
		public int Index
		{
			get { return e[0]; }
			set {
				if (this.s < 1)
					this.Length = 1;
				e[0] = value;
			}
		}

		public int[] Indices
		{
			get { return this.e; }
			set
			{
				if (value != null)
				{
					this.e = value;
					this.s = value.Length;
				}
			}
		}

		/// <summary>
		/// Attention! the coded category uses 0x01 as everyday instead of 0x07
		/// </summary>
		public SkinCategory Category
		{
			get
			{
				// TODO: use another enum :P
				return (SkinCategory)((K >> 0x10) & 0x0000FFFF);
			}
			set
			{
				K = (K & 0x0000FFFF) | (Convert.ToUInt32(value) << 0x10);
			}
		}

		public OutfitType Outfit
		{
			get
			{
				return (OutfitType)(K & 0x0000FFFF);
			}
			set
			{
				K = (uint)(K & 0xFFFF0000u) | (Convert.ToUInt32(value));
			}
		}

		public ReferenceIndex()
		{
		}

		public ReferenceIndex(int length, uint k, uint e0)
		{
			this.Length = length;
			this.K = k;
			this.Index = (int)e0;
		}

		public ReferenceIndex(int length, uint k)
		{
			this.Length = length;
			this.K = k;
		}

	}

	[Flags]
	public enum SkinCategory : uint
	{
		None = 0x00,
		Everyday = 0x01,
		Swimwear = 0x08,
		PJ = 0x10,
		Formal = 0x20,
		Undies = 0x40,
		Skin = 0x80,
		Pregnant = 0x100,
		Activewear = 0x200,
		Unknown = 0x400
	}


}
