using System;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace Teichion.Graphics
{
	/// <summary>
	/// Collection for NodeBox Objects
	/// </summary>
	public class MeshList : System.Collections.IEnumerable
	{
		System.Collections.ArrayList list = new System.Collections.ArrayList();
		public MeshList()
		{
			list = new System.Collections.ArrayList();
		}

		/// <summary>
		/// Integer Indexer 
		/// </summary>
		public NodeBox this[int index]
		{
			get { return (NodeBox)list[index]; }
			set { list[index] = value; }
		}

		/// <summary>
		/// Add a new Mesh to the Collection
		/// </summary>
		/// <param name="m"></param>
		public void Add(NodeBox m)
		{
			list.Add(m);
		}

		/// <summary>
		/// Remove the passed Mesh from the List
		/// </summary>
		/// <param name="m"></param>
		public void Remove(NodeBox m)
		{
			list.Remove(m);
		}

		/// <summary>
		/// Remove the Vector at the given Index
		/// </summary>
		/// <param name="index"></param>
		public void RemoveAt(int index)
		{
			list.RemoveAt(index);
		}

		/// <summary>
		/// Remove all stored Vectos
		/// </summary>
		public void Clear()
		{
			list.Clear();
		}

		/// <summary>
		/// Number of stored Meshes
		/// </summary>
		public int Count
		{
			get { return list.Count; }
		}

		/// <summary>
		/// True if the Collection contains an instance of this Vector
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		public bool Contains(NodeBox m)
		{
			return list.Contains(m);
		}

		#region IEnumerable Members
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return list.GetEnumerator();
		}
		#endregion
	}
}
