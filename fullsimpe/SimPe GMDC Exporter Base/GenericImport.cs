using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Zusammenfassung für GenericImport.
	/// </summary>
	class GenericImportForm : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ListViewEx lvmesh;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ColumnHeader chMeshName;
		private System.Windows.Forms.ColumnHeader chMeshAction;
		private System.Windows.Forms.ColumnHeader chMeshTarget;
		private System.Windows.Forms.ColumnHeader chFaces;
		private System.Windows.Forms.ColumnHeader chVertices;
		private System.Windows.Forms.ColumnHeader chImportEnvelope;
		private SteepValley.Windows.Forms.XPLine xpLine1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader chJointCount;
		private System.Windows.Forms.Label label2;
		private SteepValley.Windows.Forms.XPLine xpLine2;
		private System.Windows.Forms.ListViewEx lvbones;
		private System.Windows.Forms.ColumnHeader clBoneName;
		private System.Windows.Forms.ColumnHeader clBoneAction;
		private System.Windows.Forms.ColumnHeader clImportBone;
		private System.Windows.Forms.ColumnHeader clAssignedVertices;
		private System.Windows.Forms.Label label3;
		private SteepValley.Windows.Forms.XPLine xpLine3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private Ambertation.Windows.Forms.TransparentCheckBox cbClear;

		SimPe.ThemeManager tm;
		 GenericImportForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			tm = ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);						

			ComboBox cb = new ComboBox();
			this.imageList1.ImageSize = new Size(1, cb.Height+2);
			cb.Dispose();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if (tm!=null)
			{
				tm.Clear();
				tm.Parent = null;
				tm = null;
			}
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GenericImportForm));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbClear = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.xpLine3 = new SteepValley.Windows.Forms.XPLine();
			this.lvbones = new System.Windows.Forms.ListViewEx();
			this.clBoneName = new System.Windows.Forms.ColumnHeader();
			this.clBoneAction = new System.Windows.Forms.ColumnHeader();
			this.clImportBone = new System.Windows.Forms.ColumnHeader();
			this.clAssignedVertices = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.xpLine2 = new SteepValley.Windows.Forms.XPLine();
			this.label1 = new System.Windows.Forms.Label();
			this.xpLine1 = new SteepValley.Windows.Forms.XPLine();
			this.lvmesh = new System.Windows.Forms.ListViewEx();
			this.chMeshName = new System.Windows.Forms.ColumnHeader();
			this.chMeshAction = new System.Windows.Forms.ColumnHeader();
			this.chMeshTarget = new System.Windows.Forms.ColumnHeader();
			this.chFaces = new System.Windows.Forms.ColumnHeader();
			this.chVertices = new System.Windows.Forms.ColumnHeader();
			this.chImportEnvelope = new System.Windows.Forms.ColumnHeader();
			this.chJointCount = new System.Windows.Forms.ColumnHeader();
			this.xpGradientPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.panel1);
			this.xpGradientPanel1.Controls.Add(this.label3);
			this.xpGradientPanel1.Controls.Add(this.xpLine3);
			this.xpGradientPanel1.Controls.Add(this.lvbones);
			this.xpGradientPanel1.Controls.Add(this.label2);
			this.xpGradientPanel1.Controls.Add(this.xpLine2);
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Controls.Add(this.xpLine1);
			this.xpGradientPanel1.Controls.Add(this.lvmesh);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(752, 486);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.cbClear);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Location = new System.Drawing.Point(0, 384);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(752, 100);
			this.panel1.TabIndex = 10;
			// 
			// cbClear
			// 
			this.cbClear.Location = new System.Drawing.Point(8, 8);
			this.cbClear.Name = "cbClear";
			this.cbClear.Size = new System.Drawing.Size(192, 24);
			this.cbClear.TabIndex = 1;
			this.cbClear.Text = "Clear Meshgroups before Import";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(672, 72);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "Import";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label3.Location = new System.Drawing.Point(648, 352);
			this.label3.Name = "label3";
			this.label3.TabIndex = 9;
			this.label3.Text = "Options";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// xpLine3
			// 
			this.xpLine3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpLine3.BackColor = System.Drawing.Color.Transparent;
			this.xpLine3.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.xpLine3.Location = new System.Drawing.Point(8, 376);
			this.xpLine3.Name = "xpLine3";
			this.xpLine3.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.xpLine3.Size = new System.Drawing.Size(740, 8);
			this.xpLine3.TabIndex = 8;
			// 
			// lvbones
			// 
			this.lvbones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvbones.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvbones.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					  this.clBoneName,
																					  this.clBoneAction,
																					  this.clImportBone,
																					  this.clAssignedVertices});
			this.lvbones.FullRowSelect = true;
			this.lvbones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvbones.HideSelection = false;
			this.lvbones.Location = new System.Drawing.Point(8, 216);
			this.lvbones.Name = "lvbones";
			this.lvbones.Size = new System.Drawing.Size(736, 128);
			this.lvbones.SmallImageList = this.imageList1;
			this.lvbones.TabIndex = 7;
			this.lvbones.View = System.Windows.Forms.View.Details;
			// 
			// clBoneName
			// 
			this.clBoneName.Text = "Name";
			this.clBoneName.Width = 106;
			// 
			// clBoneAction
			// 
			this.clBoneAction.Text = "";
			this.clBoneAction.Width = 102;
			// 
			// clImportBone
			// 
			this.clImportBone.Text = "Import as";
			this.clImportBone.Width = 277;
			// 
			// clAssignedVertices
			// 
			this.clAssignedVertices.Text = "Vertices";
			this.clAssignedVertices.Width = 67;
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(1, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label2.Location = new System.Drawing.Point(648, 184);
			this.label2.Name = "label2";
			this.label2.TabIndex = 6;
			this.label2.Text = "Skeleton";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// xpLine2
			// 
			this.xpLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpLine2.BackColor = System.Drawing.Color.Transparent;
			this.xpLine2.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.xpLine2.Location = new System.Drawing.Point(8, 208);
			this.xpLine2.Name = "xpLine2";
			this.xpLine2.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.xpLine2.Size = new System.Drawing.Size(740, 8);
			this.xpLine2.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label1.Location = new System.Drawing.Point(648, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "Mesh Groups";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// xpLine1
			// 
			this.xpLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.xpLine1.BackColor = System.Drawing.Color.Transparent;
			this.xpLine1.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.xpLine1.Location = new System.Drawing.Point(8, 32);
			this.xpLine1.Name = "xpLine1";
			this.xpLine1.ShadowColor = System.Drawing.Color.FromArgb(((System.Byte)(127)), ((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.xpLine1.Size = new System.Drawing.Size(740, 8);
			this.xpLine1.TabIndex = 3;
			// 
			// lvmesh
			// 
			this.lvmesh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvmesh.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvmesh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																					 this.chMeshName,
																					 this.chMeshAction,
																					 this.chMeshTarget,
																					 this.chFaces,
																					 this.chVertices,
																					 this.chImportEnvelope,
																					 this.chJointCount});
			this.lvmesh.FullRowSelect = true;
			this.lvmesh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvmesh.HideSelection = false;
			this.lvmesh.Location = new System.Drawing.Point(8, 40);
			this.lvmesh.Name = "lvmesh";
			this.lvmesh.Size = new System.Drawing.Size(736, 136);
			this.lvmesh.SmallImageList = this.imageList1;
			this.lvmesh.TabIndex = 2;
			this.lvmesh.View = System.Windows.Forms.View.Details;
			// 
			// chMeshName
			// 
			this.chMeshName.Text = "Name";
			this.chMeshName.Width = 106;
			// 
			// chMeshAction
			// 
			this.chMeshAction.Text = "";
			this.chMeshAction.Width = 102;
			// 
			// chMeshTarget
			// 
			this.chMeshTarget.Text = "Import as";
			this.chMeshTarget.Width = 277;
			// 
			// chFaces
			// 
			this.chFaces.Text = "Faces";
			this.chFaces.Width = 67;
			// 
			// chVertices
			// 
			this.chVertices.Text = "Vertices";
			this.chVertices.Width = 67;
			// 
			// chImportEnvelope
			// 
			this.chImportEnvelope.Text = "Boneweight Import";
			this.chImportEnvelope.Width = 20;
			// 
			// chJointCount
			// 
			this.chJointCount.Text = "Joint Count";
			this.chJointCount.Width = 79;
			// 
			// GenericImportForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(752, 486);
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GenericImportForm";
			this.ShowInTaskbar = false;
			this.Text = "Mesh Import";
			this.xpGradientPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		GenericMeshImport gmi;
		public static void Execute(GenericMeshImport gmi)
		{
			GenericImportForm f = new GenericImportForm();
			f.gmi = gmi;			
			f.Setup();
			f.ShowDialog();
			f.Dispose();
		}

		MeshListViewItem.ActionChangedEvent chg ;
		BoneListViewItem.ActionChangedEvent bonechg ;
		void Setup()
		{
			this.cbClear.Checked = gmi.ClearGroupsOnImport;
			if (chg==null) 
				chg = new MeshListViewItem.ActionChangedEvent(ActionChangedEvent);
			if (bonechg==null)
				bonechg = new SimPe.Plugin.Gmdc.BoneListViewItem.ActionChangedEvent(BoneActionChangedEvent);


			foreach (Ambertation.Scenes.Mesh m in gmi.Scene.MeshCollection)
				new MeshListViewItemExt(lvmesh, m, gmi, chg);

			foreach (Ambertation.Scenes.Joint j in gmi.Scene.JointCollection)
				new BoneListViewItemExt(this.lvbones, j, gmi, bonechg);
		}

		bool ignore =false;
		void ActionChangedEvent(MeshListViewItem sender)
		{
			if (ignore) return;
			ignore = true;
			foreach (MeshListViewItem mlvi in lvmesh.SelectedItems)
			{
				if (mlvi==sender) continue;
				mlvi.Action = sender.Action;
			}
			ignore = false;
		}

		void BoneActionChangedEvent(BoneListViewItem sender)
		{
			if (ignore) return;
			ignore = true;
			foreach (BoneListViewItem blvi in lvbones.SelectedItems)
			{
				if (blvi==sender) continue;
				blvi.Action = sender.Action;
			}
			ignore = false;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			MeshListViewItemExt[] meshes = new MeshListViewItemExt[lvmesh.Items.Count];
			lvmesh.Items.CopyTo(meshes, 0);
			gmi.SetMeshList(meshes);

			BoneListViewItemExt[] bones = new BoneListViewItemExt[lvbones.Items.Count];
			lvbones.Items.CopyTo(bones, 0);
			gmi.SetBoneList(bones);

			gmi.ClearGroupsOnImport = this.cbClear.Checked;

			Close();
		}
	}
}
