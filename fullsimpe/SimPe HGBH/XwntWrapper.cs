using System;
using System.Collections;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MmatWrapper.
	/// </summary>
	public class XWant : SimPe.PackedFiles.Wrapper.Cpf
	{
		
		static Hashtable wanttypelookup;
		static Hashtable wantnamelookup;

		/// <summary>
		/// creates a new Instance
		/// </summary>
		public XWant():base()
		{
			if (wanttypelookup==null) 
			{
				wanttypelookup = new Hashtable();
				wantnamelookup = new Hashtable();

				wantnamelookup[(byte)WantType.Career] = "Career";
				wanttypelookup["career"] = WantType.Career;

				wantnamelookup[(byte)WantType.Category] = "Category";
				wanttypelookup["category"] = WantType.Category;

				wantnamelookup[(byte)WantType.None] = "Guid";
				wanttypelookup["guid"] = WantType.None;

				wantnamelookup[(byte)WantType.Object] = "None";
				wanttypelookup["none"] = WantType.Object;

				wantnamelookup[(byte)WantType.Sim] = "Sim";
				wanttypelookup["sim"] = WantType.Sim;

				wantnamelookup[(byte)WantType.Skill] = "Skill";
				wanttypelookup["skill"] = WantType.Skill;				
			}
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override SimPe.Interfaces.Plugin.IWrapperInfo CreateWrapperInfo()
		{
			return new SimPe.Interfaces.Plugin.AbstractWrapperInfo(
				"XWNT Wrapper",
				"Quaxi",
				"---",
				2
				);   
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public override uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								   Data.MetaData.XWNT
							   };
			
				return types;
			}
		}		

		#region Default Attribute
		public uint StringInstance
		{
			get { return this.GetSaveItem("stringSet").UIntegerValue; }
			set { this.GetSaveItem("stringSet").UIntegerValue = value; }
		}

		public uint Guid
		{
			get { return this.GetSaveItem("id").UIntegerValue; }
			set { this.GetSaveItem("id").UIntegerValue = value; }
		}

		public uint IconInstance
		{
			get { return this.GetSaveItem("primaryIcon").UIntegerValue; }
			set { this.GetSaveItem("primaryIcon").UIntegerValue = value; }
		}

		public uint SecondaryIconInstance
		{
			get { return this.GetSaveItem("secondaryIcon").UIntegerValue; }
			set { this.GetSaveItem("secondaryIcon").UIntegerValue = value; }
		}

		public string Folder
		{
			get { return this.GetSaveItem("folder").StringValue; }
			set { this.GetSaveItem("folder").StringValue = value; }
		}

		public int Score
		{
			get { return this.GetSaveItem("score").IntegerValue; }
			set { this.GetSaveItem("score").IntegerValue = value; }
		}

		public int Influence
		{
			get { return this.GetSaveItem("influence").IntegerValue; }
			set { this.GetSaveItem("influence").IntegerValue = value; }
		}

		public string ObjectType
		{
			get { return this.GetSaveItem("objectType").StringValue; }
			set { this.GetSaveItem("objectType").StringValue = value; }
		}

		public string NodeText
		{
			get { return this.GetSaveItem("nodeText").StringValue; }
			set { this.GetSaveItem("nodeText").StringValue = value; }
		}

		
		public WantType WantType
		{
			get { 
				object o = wanttypelookup[ObjectType.Trim().ToLower()];
				if (o!=null)
					if (o.GetType()!=typeof(string)) 
						return (WantType)o;

				return WantType.None;
			}
			set { 
				object o = wantnamelookup[(byte)value];
				if (o!=null)
					if (o.GetType()==typeof(string)) 
						ObjectType = (string)o;
				ObjectType = "None";
			}
		}

		public Interfaces.Files.IPackedFileDescriptor IconFileDescriptor
		{
			get 
			{
				SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
				pfd.Type = Data.MetaData.SIM_IMAGE_FILE;
				pfd.LongInstance = IconInstance;
				if (pfd.Instance==0) pfd.Instance = SecondaryIconInstance;
				pfd.Group = 0x499DB772;

				return pfd;
			}
		}
		#endregion

		public override string Description
		{
			get
			{
				return "GUID=0x"+Helper.HexString(this.FileDescriptor.Instance)+", Folder="+this.Folder+", ObjectType="+this.ObjectType;
			}
		}

		protected override string GetResourceName(SimPe.Data.TypeAlias ta)
		{
			if (!this.Processed) ProcessData(FileDescriptor, Package);
			return this.Folder+" / "+this.NodeText+" ("+this.ObjectType+")";
		}
	}
}
