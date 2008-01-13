using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Text;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Packages;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	public sealed class SimDNASanitizer : Component, SimPe.Interfaces.IToolAction
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		private bool hasChanges = false;
		private GuidTable guidTable;

		public GuidTable GuidTable
		{
			get {
				if (this.guidTable == null)
					this.guidTable = new GuidTable();
				return this.guidTable;
			}
		}

		public bool HasChanges
		{
			get { return this.hasChanges; }
		}


		public SimDNASanitizer()
		{
			InitializeComponent();
		}
		public SimDNASanitizer(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}


		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#endregion

		#region IToolAction Members

		public bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			return (!Utility.IsNullOrEmpty(this.guidTable));
		}

		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			this.hasChanges = false;
			if (e.Loaded)
			{
				GeneratableFile file = e.LoadedPackage.Package;

				IPackedFileDescriptor[] pfdList = file.FindFiles(SimPe.Data.MetaData.SDNA);
				if (!Utility.IsNullOrEmpty(pfdList))
				{
					using (SimDNA dna = new SimDNA())
					{
						foreach (IPackedFileDescriptor pfd in pfdList)
							this.hasChanges |= this.ProcessDNA(dna, pfd, file);
					}

					
				}

			}

		}

		#endregion

		#region IToolExt Members

		public System.Drawing.Image Icon
		{
			get { return null;  }
		}

		public System.Windows.Forms.Shortcut Shortcut
		{
			get { return System.Windows.Forms.Shortcut.None; }
		}

		public bool Visible
		{
			get { return false; }
		}

		#endregion

		bool ProcessDNA(SimDNA dna, IPackedFileDescriptor pfd, GeneratableFile file)
		{
			bool ret = false;
			try
			{
				dna.ProcessData(pfd, file, false);

				if (this.guidTable.Contains(dna.Dominant.Hair))
				{
					dna.Dominant.Hair = Convert.ToString(this.guidTable[dna.Dominant.Hair]);
					ret = true; // grrrr
				}

				if (this.guidTable.Contains(dna.Recessive.Hair))
				{
					dna.Recessive.Hair = Convert.ToString(this.guidTable[dna.Recessive.Hair]);
					ret = true;
				}

				if (ret)
					dna.SynchronizeUserData();
			}
			finally
			{
				dna.FileDescriptor = null;
				dna.Package = null;
			}

			return ret;
		}

	}

	public sealed class GuidTable : NameObjectCollectionBase
	{

		public void Add(Guid key, Guid value)
		{
			this.BaseAdd(key.ToString(), value);
		}
		public bool Contains(Guid key)
		{
			return this.Contains(key.ToString());
		}
		public bool Contains(string key)
		{
			if (!this.BaseHasKeys())
				return false;

			foreach (string strKey in this.Keys)
				if (String.Compare(strKey, key, true) == 0)
					return true;

			return false;
		}
		public Guid this[string key]
		{
			get
			{
				object ret = this.BaseGet(key);
				if (ret != null)
					return (Guid)ret;
				return Guid.Empty;
			}
			set
			{
				this.BaseSet(key, value);
			}
		}
		public Guid this[Guid key]
		{
			get
			{
				return this[key.ToString()];
			}
			set
			{
				this[key.ToString()] = value;
			}
		}

		public GuidTable()
		{
		}


	}

}
