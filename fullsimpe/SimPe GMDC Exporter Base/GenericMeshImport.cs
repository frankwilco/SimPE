using System;
using Ambertation.Scenes;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Zusammenfassung für GenericMeshImport.
	/// </summary>
	public class GenericMeshImport 
	{
		public enum ImportAction 
		{			
			Ignore,
			Update,
			Replace,
			Add
		}

		public enum JointImportAction 
		{			
			Ignore,
			Update					
		}

		Scene scn;
		GeometryDataContainer gmdc;

		MeshListViewItemExt[] meshes;
		BoneListViewItemExt[] bones;
		ElementOrder eo;

		public bool ClearGroupsOnImport;

		internal void SetMeshList(MeshListViewItemExt[] m)
		{
			meshes = m;
		}

		internal void SetBoneList(BoneListViewItemExt[] b)
		{
			bones = b;
		}

		public GenericMeshImport(Scene scn, GeometryDataContainer gmdc, ElementOrder component)
		{
			eo = component;
			this.scn = scn;
			this.gmdc = gmdc;
			ClearGroupsOnImport = false;

		}

		public ElementOrder Component
		{
			get {return eo;}
		}

		public Scene Scene
		{
			get {return scn;}
		}

		public GeometryDataContainer Gmdc
		{
			get {return gmdc;}
		}

		public bool Run()
		{
			scn.ClearTags();
			meshes = new MeshListViewItemExt[0];
			bones = new BoneListViewItemExt[0];

			GenericImportForm.Execute(this);

			if (meshes.Length==0) return false;

			if (this.ClearGroupsOnImport)		
			{	
				for (int i=Gmdc.Groups.Length-1; i>=0; i--) Gmdc.RemoveGroup(i);		
				foreach (MeshListViewItemExt m in meshes)
					m.Group = null;
			}

			foreach (BoneListViewItemExt b in bones)
				b.AssignVertices();

			foreach (MeshListViewItemExt m in meshes)		
				m.BuildGroup();			
						
			scn.ClearTags();
			return true;
		}
	}
}
