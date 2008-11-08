using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Gmdc
{

	class MeshListViewItem : ListViewItem, System.IDisposable
	{
		protected Ambertation.Scenes.Mesh mesh;
		protected GenericMeshImport gmi;
		ListViewEx parent;
		ComboBox cbact, cbgroup;
		CheckBox cbenv;
		public delegate void ActionChangedEvent(MeshListViewItem sender);
		ActionChangedEvent fkt;

		public MeshListViewItem(ListViewEx lv, Ambertation.Scenes.Mesh mesh, GenericMeshImport gmi, ActionChangedEvent fkt) : base()
		{
			this.fkt = fkt;
			parent = lv;
			this.mesh = mesh;
			this.gmi = gmi;
				
			cbact = new ComboBox();			
			cbact.DropDownStyle = ComboBoxStyle.DropDownList;
			cbact.SelectedIndexChanged += new EventHandler(cbact_SelectedIndexChanged);
			GenericMeshImport.ImportAction[] acts = (GenericMeshImport.ImportAction[])Enum.GetValues(typeof(GenericMeshImport.ImportAction));
			foreach (GenericMeshImport.ImportAction a in acts)
				cbact.Items.Add(a);
			cbact.SelectedItem = GenericMeshImport.ImportAction.Add;

			cbgroup = new ComboBox();			
			cbgroup.DropDownStyle = ComboBoxStyle.DropDownList;
			cbgroup.Items.Add("["+SimPe.Localization.GetString("none")+"]");
			foreach (GmdcGroup  g in gmi.Gmdc.Groups)
				cbgroup.Items.Add(g);
			cbgroup.SelectedItem = 0;

			cbenv = new Ambertation.Windows.Forms.TransparentCheckBox();
			cbenv.BackColor = Color.Transparent;
			cbenv.Checked = mesh.Envelopes.Count>0;			

			
			int i = gmi.Gmdc.FindGroupByName(mesh.Name);
			if (i>=0) 
			{				
				Group = gmi.Gmdc.Groups[i];
				Action = GenericMeshImport.ImportAction.Replace;
			}
								
			Setup();
			parent.Items.Add(this);
			parent.AddEmbeddedControl(cbact, 1, parent.Items.Count-1);
			parent.AddEmbeddedControl(cbgroup, 2, parent.Items.Count-1);
			parent.AddEmbeddedControl(cbenv, 5, parent.Items.Count-1);
		}

		~MeshListViewItem()
		{
			Dispose();
		}

		public bool ImportEnvelope
		{
			get {return cbenv.Checked;}
			set {cbenv.Checked = value;}
		}

		public bool Shadow
		{
			get {return false;}
			set {}
		}

		public GenericMeshImport.ImportAction Action
		{
			get {return (GenericMeshImport.ImportAction)cbact.SelectedItem;}
			set {cbact.SelectedItem = value;}
		}

		public new GmdcGroup Group
		{
			get 
			{
				if (cbgroup.SelectedItem==null) return null;
				if (!(cbgroup.SelectedItem is GmdcGroup)) return null;
				return cbgroup.SelectedItem as GmdcGroup;
			}
			set 
			{
				if (value==null) cbgroup.SelectedIndex=0;
				else cbgroup.SelectedItem = value;
					
				if (cbgroup.SelectedIndex<0) cbgroup.SelectedIndex=0;
			}
		}

		void Setup()
		{
			this.SubItems.Clear();
			this.Text = mesh.Name;
			this.SubItems.Add(Action.ToString()); //action
			if (Group!=null) this.SubItems.Add(Group.Name); //target
			else this.SubItems.Add("["+SimPe.Localization.GetString("none")+"]");
			this.SubItems.Add(mesh.FaceIndices.Count.ToString());
			this.SubItems.Add(mesh.Vertices.Count.ToString());			
			this.SubItems.Add("");
			this.SubItems.Add(mesh.Envelopes.Count.ToString());

			this.ForeColor = MyColor();
		}

		Color MyColor()
		{
			if (mesh.Vertices.Count>SimPe.Plugin.Gmdc.AbstractGmdcImporter.CRITICAL_VERTEX_AMOUNT) return Color.Red;
			if (mesh.FaceIndices.Count>SimPe.Plugin.Gmdc.AbstractGmdcImporter.CRITICAL_FACE_AMOUNT) return Color.Red;
			return Color.Black;
		}

		#region IDisposable Member

		public virtual void Dispose()
		{
			if (cbact!=null) 
			{
				cbact.SelectedIndexChanged -= new EventHandler(cbact_SelectedIndexChanged);
				cbact.Dispose();
			}
			cbact = null;

			if (cbgroup!=null) 
			{
				cbgroup.Dispose();
			}

			if (cbenv!=null)
				cbenv.Dispose();

			parent = null;
			mesh = null;
			gmi = null;
			fkt = null;
		}

		#endregion


		private void cbact_SelectedIndexChanged(object sender, EventArgs e)
		{
			fkt(this);
		}


	}
}
