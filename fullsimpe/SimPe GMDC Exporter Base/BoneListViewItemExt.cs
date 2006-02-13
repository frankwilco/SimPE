using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Gmdc
{

	class BoneListViewItemExt : BoneListViewItem
	{		
		public BoneListViewItemExt(ListViewEx lv, Ambertation.Scenes.Joint joint, GenericMeshImport gmi, ActionChangedEvent fkt)
			:base(lv, joint, gmi, fkt)		
		{
		}				

		public void AssignVertices()
		{			
			joint.Tag = -1;
			if (this.Joint==null && this.Action == GenericMeshImport.JointImportAction.Update) this.Action = GenericMeshImport.JointImportAction.Ignore;
			if (Action == GenericMeshImport.JointImportAction.Ignore) return;

			joint.Tag = Joint.Index;
		}

		#region IDisposable Member

		public override void Dispose()
		{			
			base.Dispose();
		}

		#endregion
	}
}
