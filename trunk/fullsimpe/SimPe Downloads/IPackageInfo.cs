using System;
using System.Drawing;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// This Interface is used to Describe the Content of a given Package
	/// </summary>
	public interface IPackageInfo: System.IDisposable
	{
		/// <summary>
		/// Name of this Object
		/// </summary>
		string Name
		{
			get;
		}

		/// <summary>
		/// Description of this Object
		/// </summary>
		string Description
		{
			get;
		}

		/// <summary>
		/// Categorystring of this Object
		/// </summary>
        string Category
        {
            get;
        }		

		Image GetThumbnail();
		Image GetThumbnail(System.Drawing.Size sz);

		/// <summary>
		/// Returns the gameThumbnail or a SimPe Created 3D Preview, or null
		/// </summary>
		Image Image
		{
			get;		
		}

		/// <summary>
		/// Makes sure, the 3D Preview ic created
		/// </summary>
		void CreatePostponed3DPreview();

		/// <summary>
		/// A Game-Thumbnail was defined
		/// </summary>
        bool HasThumbnail
        {
            get;
        }

		/// <summary>
		/// Price of the Object
		/// </summary>
        int Price
        {
            get;
        }

		/// <summary>
		/// Number of vertices defined by GMDCs in the package
		/// </summary>
		int VertexCount
        {
            get;
        }

		/// <summary>
		/// Number of Vertices is high
		/// </summary>
		bool HighVertexCount
		{
			get;
		}

		/// <summary>
		/// Number of faces defined by GMDCs in the package
		/// </summary>
        int FaceCount
        {
            get;
        }

		/// <summary>
		/// Number of Faces is high
		/// </summary>
		bool HighFaceCount
		{
			get;
		}

		/// <summary>
		/// List of GUIDs used in the package
		/// </summary>
		uint[] Guids
		{
			get;
		}

		/// <summary>
		/// Type of the Package content
		/// </summary>
		SimPe.Cache.PackageType Type
		{
			get;
		}
	}
}
