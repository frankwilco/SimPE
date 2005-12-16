using System;
using SimPe.Plugin.Anim;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für AnimationData.
	/// </summary>
	class AnimationData
	{
		SimPe.Plugin.Anim.AnimationFrameBlock afb;
		Teichion.Graphics.NodeBox nb;
		Teichion.Graphics.MeshTransform mt;
		int fct;
		SimPe.Geometry.Vectors3f frames;
		SimPe.Geometry.Vector3f scale;
		public AnimationData(SimPe.Plugin.Anim.AnimationFrameBlock afb, Teichion.Graphics.NodeBox nb, int framecount)
		{
			Console.WriteLine(nb.ToString());
			this.afb = afb;
			this.nb = nb;
			mt = (Teichion.Graphics.MeshTransform)nb.Transform.Clone();
			this.fct = framecount;
			frames = new SimPe.Geometry.Vectors3f();

			SimPe.Plugin.Anim.AnimationFrame[] iframes = afb.Frames;			

			/*scale = new SimPe.Geometry.Vector3f();
			scale.X = nb.Transform.TranslationVector.X / (float)iframes[0].X;
			scale.Y = nb.Transform.TranslationVector.Y / (float)iframes[0].Y;
			scale.Z = nb.Transform.TranslationVector.Z / (float)iframes[0].Z;*/

			SimPe.Plugin.Anim.AnimationFrameBlock afb2 = new AnimationFrameBlock(afb.Parent);
			for (int i=0; i<=framecount; i++) 
			{
				frames.Add(new SimPe.Geometry.Vector3f());    
			}

			InterpolateFrames(iframes, 0); //X-Axis
			InterpolateFrames(iframes, 1); //Y-Axis
			InterpolateFrames(iframes, 2); //Z-Axis
			
		}

		int FindNext(SimPe.Plugin.Anim.AnimationFrame[] frames, byte axis, int start)
		{
			for (int i=start; i<frames.Length; i++)
			{
				if (frames[i].GetBlock(axis)!=null) return i;
			}

			return -1;
		}

		AnimationFrame GetFrame(SimPe.Plugin.Anim.AnimationFrame[] frames, int index)
		{
			if (index<0||index>=frames.Length) return null;
			return frames[index];
		}

		void InterpolateFrames(SimPe.Plugin.Anim.AnimationFrame[] iframes, byte axis)
		{
			int index = 0;
			AnimationFrame first = iframes[index];			
			AnimationFrame last = null;
			index = FindNext(iframes, axis, index+1);
			last = GetFrame(iframes, index);

			if (last==null) return;
			while (last!=null)
			{
				InterpolateFrames(axis, first, last);

				first = last;
				index = FindNext(iframes, axis, index+1);
				last = GetFrame(iframes, index);				
			}

			InterpolateFrames(axis, first, last);
		}

		void InterpolateFrames(byte axis, AnimationFrame first, AnimationFrame last)
		{
			
			short max = (short)(frames.Length-1);
			if (last!=null) max = last.TimeCode;
			else 
			{
				last = new AnimationFrame(max, first.Type);
				last.X = first.X;
				last.Y = first.Y;
				last.Z = first.Z;
			}			
			
			for (short i=(short)(first.TimeCode); i<=max; i++)
				CreaetInterpolatedFrame(axis, i, first, last);

		}

		void CreaetInterpolatedFrame(byte axis, short index, AnimationFrame first, AnimationFrame last)
		{									
			double pos = (index-first.TimeCode) / (double)(last.TimeCode - first.TimeCode);
			double v = Interpolate(axis, pos, first.GetBlock(axis), last.GetBlock(axis));

			frames[index].SetComponent(axis, v);			
		}

		double Interpolate(byte axis, double pos, AnimationAxisTransform first, AnimationAxisTransform last)
		{
			double f = 0;
			if (first!=null) f = (float)first.ParameterFloat;
			double l = f;
			if (last!=null) l = (float)last.ParameterFloat;
			return  (f + (pos*(l-f)));
		}

		public void SetFrame(int timecode)
		{
			SimPe.Geometry.Vector3f v = this.frames[timecode];
			if (afb.TransformationType == FrameType.Translation)
			{
				
				Microsoft.DirectX.Matrix m = Microsoft.DirectX.Matrix.Translation((float)v.X, (float)v.Y, (float)v.Z);
				if (timecode!=0) nb.Transform =  m ;
				//else nb.Transform = mt;
					//this.nb.Transform.SetTranslation(af.Float_X, af.Float_Y, af.Float_Z);
			}
			else
				this.nb.Transform.SetRotation((float)v.X, (float)v.Y, (float)v.Z);

			nb.Transform.IsAbsolute = true;
		}
	}
}
