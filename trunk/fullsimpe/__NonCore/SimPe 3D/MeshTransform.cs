using System;
using System.Text;

namespace Teichion.Graphics
{
    public class MeshTransform : System.ICloneable
    {
        Microsoft.DirectX.Vector3 t;
        Microsoft.DirectX.Quaternion r;
		Microsoft.DirectX.Matrix m;
		bool mset;

        public MeshTransform() : this(new Microsoft.DirectX.Vector3(0, 0, 0), new Microsoft.DirectX.Vector3(0, 0, 0)) { }
        public MeshTransform(double tx, double ty, double tz) : this(tx, ty, tz, 0, 0, 0) { }
        public MeshTransform(double tx, double ty, double tz, double rx, double ry, double rz) : this(new Microsoft.DirectX.Vector3((float)tx, (float)ty, (float)tz), new Microsoft.DirectX.Vector3((float)rx, (float)ry, (float)rz)) { }
        public MeshTransform(Microsoft.DirectX.Vector3 tr, Microsoft.DirectX.Vector3 rot)
        {
            this.SetTranslation(tr);
            this.SetRotation(rot);
			abs = false;
        }

		bool abs;
		public bool IsAbsolute
		{
			get { return abs;}
			set { abs = value; }
		}

		public Microsoft.DirectX.Vector3 TranslationVector
		{
			get {return t;}
		}
        /// <summary>
        /// Set the Translation Parameters
        /// </summary>
        /// <param name="tx"></param>
        /// <param name="ty"></param>
        /// <param name="tz"></param>
        public void SetTranslation(double tx, double ty, double tz)
        {
            SetTranslation(new Microsoft.DirectX.Vector3((float)tx, (float)ty, (float)tz));
        }

        /// <summary>
        /// Set the Translation Parameters
        /// </summary>
        /// <param name="tr"></param>
        public void SetTranslation(Microsoft.DirectX.Vector3 tr)
        {
			mset = false;
            t = tr;
        }

        /// <summary>
        /// Set the Rotation Parameters
        /// </summary>
        /// <param name="rx"></param>
        /// <param name="ry"></param>
        /// <param name="rz"></param>
        public void SetRotation(double rx, double ry, double rz)
        {
            SetRotation(new Microsoft.DirectX.Vector3((float)rx, (float)ry, (float)rz));
        }

        /// <summary>
        /// Set the Rotation Parameters
        /// </summary>
        /// <param name="rot"></param>
        public void SetRotation(Microsoft.DirectX.Vector3 rot)
        {
            SetRotation(
				Microsoft.DirectX.Quaternion.RotationMatrix(
				Microsoft.DirectX.Matrix.Multiply(
					Microsoft.DirectX.Matrix.RotationX(rot.X),
					Microsoft.DirectX.Matrix.Multiply(
						Microsoft.DirectX.Matrix.RotationY(rot.Y),
						Microsoft.DirectX.Matrix.RotationZ(rot.Z)
					)
				)				
				));
        }

        /// <summary>
        /// Set the Rotation Parameters
        /// </summary>
        /// <param name="q"></param>
        public void SetRotation(Microsoft.DirectX.Quaternion q)
        {
			mset = false;
            r = q;
        }

        /// <summary>
        /// Convert into a Matrix
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static implicit operator Microsoft.DirectX.Matrix(MeshTransform m)
        {
			if (m.mset) return m.m;
            return Microsoft.DirectX.Matrix.Multiply(
                Microsoft.DirectX.Matrix.RotationQuaternion(m.r),
                Microsoft.DirectX.Matrix.Translation(m.t)
            );
        }

		/// <summary>
		/// Convert into a Matrix
		/// </summary>
		/// <param name="m"></param>
		/// <returns></returns>
		public static implicit operator MeshTransform(Microsoft.DirectX.Matrix m)
		{
			MeshTransform mt = new MeshTransform();
			mt.m = m;
			mt.mset = true;

			return mt;
		}

        /// <summary>
        /// Create a new Identity Transformation
        /// </summary>
        /// <returns></returns>
        public static MeshTransform Identity
        {
            get { return new MeshTransform(); }
        }

        /// <summary>
        /// Create a new Translation
        /// </summary>
        /// <param name="tx"></param>
        /// <param name="ty"></param>
        /// <param name="tz"></param>
        /// <returns></returns>
        public static MeshTransform Translation(double tx, double ty, double tz)
        {
            return new MeshTransform(tx, ty, tz);
        }

        /// <summary>
        /// Create a new Translation
        /// </summary>
        /// <param name="tr"></param>
        /// <returns></returns>
        public static MeshTransform Translation(Microsoft.DirectX.Vector3 tr)
        {
            return new MeshTransform(tr, new Microsoft.DirectX.Vector3(0, 0,0));
        }

        /// <summary>
        /// Create a new Euler Rotation
        /// </summary>
        /// <param name="rx"></param>
        /// <param name="ry"></param>
        /// <param name="rz"></param>
        /// <returns></returns>
        public static MeshTransform RotationYawPitchRoll(double y, double p, double r)
        {
            return new MeshTransform(0, 0, 0, p, y, r);
		}

		#region ICloneable Member

		public object Clone()
		{
			MeshTransform mt = new MeshTransform();
			mt.SetTranslation(new Microsoft.DirectX.Vector3(t.X, t.Y, t.Z));
			mt.SetRotation(new Microsoft.DirectX.Quaternion(r.X, r.Y, r.Z, r.W));
			if (mset) mt.m = Microsoft.DirectX.Matrix.Multiply(Microsoft.DirectX.Matrix.Identity, this.m);
			mt.mset = this.mset;
			return mt;
		}

		#endregion
	}
}
