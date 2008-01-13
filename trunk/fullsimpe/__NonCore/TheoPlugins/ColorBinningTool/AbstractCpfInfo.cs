using System;
using System.Collections;
using System.Text;

using SimPe.Data;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	public abstract class AbstractCpfInfo
	{
		private Cpf propertySet;
		private bool enabled;
		private bool pinned;
		private bool changed;

		public Cpf PropertySet
		{
			get { return this.propertySet; }
			set {
				if (value == null)
					throw new ArgumentNullException("PropertySet", "The provided Cpf instance cannot be null");
				this.propertySet = value;
			}
		}

		public bool Enabled
		{
			get { return this.enabled; }
			set { this.enabled = value; }
		}

		public bool HasChanges
		{
			get { return this.changed; }
			set { this.changed = value; }
		}

		/// <summary>
		/// If pinned, PropertySet cannot be deleted.
		/// </summary>
		public bool Pinned
		{
			get { return this.pinned; }
			set { this.pinned = value; }
		}

		#region Lazy properties, use them sparingly

		public RecolorType Type
		{
			get
			{
				RecolorType ret = RecolorType.Unsupported;
				if (this.propertySet != null) 
				{
					try
					{
						ret = (RecolorType)Enum.Parse(
							typeof(RecolorType),
							CpfItem("type").StringValue,
							true
							);
					}
					catch
					{
					}
				}
				return ret;
			}
		}


		public Guid Family
		{
			get {
				if (this.propertySet != null)
					return ParseGuidValue(CpfItem("family"));
				return Guid.Empty;
			}
			set {
				this.SetValue("family", value.ToString());
			}
		}


		public string Name
		{
			get {
				if (this.propertySet != null)
					return CpfItem("name").StringValue;
				return null;
			}
			set {
				this.SetValue("name", value);
			}
		}

		public PropertySetFlags Flags
		{
			get
			{
				if (this.propertySet != null)
					return (PropertySetFlags)CpfItem("flags").UIntegerValue;
				return PropertySetFlags.Default;
			}
			set
			{
				this.SetValue("flags", Convert.ToUInt32(value));
			}
		}


		#endregion


		protected AbstractCpfInfo()
		{
			this.enabled = true;
		}

		public AbstractCpfInfo(Cpf propertySet) : this()
		{
			this.PropertySet = propertySet;
		}

		public bool ContainsItem(string name)
		{
			return (this.propertySet.GetItem(name) != null);
		}

		public CpfItem GetProperty(string name)
		{
			if (this.propertySet == null)
				return null;

			return this.propertySet.GetSaveItem(name);
		}

		protected CpfItem CpfItem(string name)
		{
			if (this.propertySet == null)
				return null;

			CpfItem ret = this.propertySet.GetItem(name);
			if (ret == null)
			{
				ret = new CpfItem();
				ret.Name = name;
				this.propertySet.AddItem(ret);
			}
			return ret;
		}

		public void SetValue(string propertyName, string value)
		{
			if (this.propertySet != null)
			{
				CpfItem item = this.CpfItem(propertyName);
				if (item.StringValue != value) 
				{
					item.StringValue = value;
					this.changed = true;
				}

			}
		}

		public void SetValue(string propertyName, uint value)
		{
			if (this.propertySet != null)
			{
				CpfItem item = this.CpfItem(propertyName);
				if (item.UIntegerValue != value)
				{
					item.UIntegerValue = value;
					this.changed = true;
				}
			}
		}

		public void SetValue(string propertyName, float value)
		{
			if (this.propertySet != null)
			{
				CpfItem item = this.CpfItem(propertyName);
				if (item.SingleValue != value)
				{
					item.SingleValue = value;
					this.changed = true;
				}
			}
		}


		public static Guid ParseGuidValue(CpfItem item)
		{
			Guid ret = Guid.Empty;
			if (item != null)
			{
				try
				{
					string guid = item.StringValue;
					if (!Utility.IsNullOrEmpty(guid))
						ret = new Guid(guid);
				}
				catch
				{
				}
			}
			return ret;
		}

		/*
		public void SetValue(string name, string value)
		{
			if (this.propertySet != null)
				this.CpfItem(name).StringValue = value;
		}
		*/

		public virtual void CommitChanges()
		{
			if (this.propertySet != null)
			{
				if (this.enabled)
				{
					// clear HideFromCatalogFlag
					// some packages seem to keep this flag set for some unknown reason (hence the flag's name) 
					// this.Flags &= ~(PropertySetFlags.HideFromCatalog | PropertySetFlags.Unknown2);
					this.Flags &= ~PropertySetFlags.HideFromCatalog;
					this.propertySet.SynchronizeUserData();
				}
				else
				{
					if (!this.pinned)
						this.propertySet.FileDescriptor.MarkForDelete = true;
					else
					{
						this.Flags |= (PropertySetFlags.HideFromCatalog | PropertySetFlags.Unknown2); //.CpfItem("flags").UIntegerValue = 0x09; // TODO: research on bitfield
						this.propertySet.SynchronizeUserData();
					}
				}

			}

		}


	}


	public enum PropertySetFlags : uint
	{
		Default = 0,
		HideFromCatalog = 1,
		IsHat = 2,
		Unknown1 = 4,
		Unknown2 = 8
	}


}
