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
		Ambertation.Graphics.MeshBox mb;
		int fct;
		SimPe.Geometry.Vectors3f frames;
		public AnimationData(SimPe.Plugin.Anim.AnimationFrameBlock afb, Ambertation.Graphics.MeshBox mb, int framecount)
		{
			//Console.WriteLine(mb.ToString());
			this.afb = afb;
			this.mb = mb;
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
			if (first!=null) f = AnimationAxisTransformBlock.GetCompressedFloat(first.Parameter, AnimationAxisTransformBlock.GetScale(first.ParentLocked, afb.TransformationType));
			double l = f;
			if (last!=null) l = (float)AnimationAxisTransformBlock.GetCompressedFloat(last.Parameter, AnimationAxisTransformBlock.GetScale(last.ParentLocked, afb.TransformationType));
			return  (f + (pos*(l-f)));
		}

		public void SetFrame(int timecode)
		{
			SimPe.Geometry.Vector3f v = this.frames[timecode];
			Ambertation.Scenes.Transformation trans = new Ambertation.Scenes.Transformation();
			if (afb.TransformationType == FrameType.Translation)
			{				
				if (timecode!=0) 
				{
					trans.Translation.X = v.X;
					trans.Translation.Y = v.Y;
					trans.Translation.Z = v.Z;
				}
				//else nb.Transform = mt;				
			}
			else 
			{
				if (timecode!=0) 
				{
					trans.Rotation.X = v.X;
					trans.Rotation.Y = v.Y;
					trans.Rotation.Z = v.Z;
				}
			}

			//mb.Transform = Microsoft.DirectX.Matrix.Multiply(mb.Transform, Ambertation.Scenes.Converter.ToDx(trans));
			mb.Transform = Ambertation.Scenes.Converter.ToDx(trans);
		}
	}
}
