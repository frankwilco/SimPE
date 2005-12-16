using System;
using System.Collections;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Direct3D=Microsoft.DirectX.Direct3D;

namespace Teichion.Graphics
{
    
    /// <summary>
    /// Holds Information about a Mesh 
    /// </summary>
    /// <remarks>
    /// Holds Informations like the actual Mesh Data, the Material, the Transforms...
    /// </remarks>
    public class NodeBox : System.Collections.IEnumerable
    {
        MeshTransform trans;
		string name;
        ArrayList parents, childs;

        public NodeBox(string name) : this(name, MeshTransform.Identity) { }
        public NodeBox(string name, MeshTransform transform) 
        {
            this.trans = transform;
			this.name = name;

            parents = new ArrayList();
            childs = new ArrayList();
        }

        public MeshTransform Transform
        {
            get { return trans; }
            set { trans = value; }
        }

		

        #region Hierarchy
		public Microsoft.DirectX.Matrix GetEffectiveTransform()
		{
			if (this.Transform.IsAbsolute) return this.Transform;

			Microsoft.DirectX.Matrix m = Microsoft.DirectX.Matrix.Identity;
			foreach (NodeBox nb in parents)
			{	
				m.Multiply(nb.GetEffectiveTransform());
			}

			m.Multiply(this.Transform);
			return m;
		}

        public void AddChild(NodeBox cld)
        {
            this.childs.Add(cld);
            cld.AddParent(this);
        }

        public void RemoveChild(NodeBox cld)
        {
            cld.RemoveParent(this);
            this.childs.Remove(cld);
        }

        protected void AddParent(NodeBox par)
        {
            this.parents.Add(par);
        }

        protected void RemoveParent(NodeBox par)
        {
            this.parents.Remove(par);
        }

        #endregion

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return childs.GetEnumerator();
        }

        #endregion

		public override string ToString()
		{
			return name;
		}

    }

	/// <summary>
	/// Holds Information about a Mesh 
	/// </summary>
	/// <remarks>
	/// Holds Informations like the actual Mesh Data, the Material, the Transforms...
	/// </remarks>
	public class MeshBox : NodeBox  
	{
		Mesh mesh;
		Material mat;
        
		int ssc;
		bool wire;

       

        public MeshBox(string name, Mesh mesh, int subsetcount) : this(name, mesh, subsetcount, new Material(), MeshTransform.Identity) { }
		public MeshBox(string name, Mesh mesh) : this (name, mesh, new Material(),  MeshTransform.Identity) {}
		public MeshBox(string name, Mesh mesh, Material mat) : this (name, mesh, mat, MeshTransform.Identity) {}
        public MeshBox(string name, Mesh mesh, int subsetcount, Material mat) : this(name, mesh, subsetcount, mat, MeshTransform.Identity) { }
        public MeshBox(string name, Mesh mesh, Material mat, MeshTransform transform) : this(name, mesh, mesh.NumberAttributes, mat, transform) { }

        public MeshBox(string name, Mesh mesh, int subsetcount, Material mat, MeshTransform transform) : base (name, transform)
		{
			this.mesh = mesh;
			this.mat = mat;
			this.ssc = subsetcount;
			this.wire = true;
		}

		public bool Wire
		{
			get {return wire;}
			set {wire=value;}
		}

		public Mesh Mesh
		{
			get {return mesh;}
		}

		public Material Material
		{
			get {return mat;}
			set { mat = value; }
		}
       

		public int SubSetCount
		{
			get { return ssc; }
        }
    }
}
