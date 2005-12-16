using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using Direct3D=Microsoft.DirectX.Direct3D;

namespace Teichion.Graphics
{
	public delegate void PrepareEffectEventHandler(object sender, PrepareEffectEventArgs e);
	public class PrepareEffectEventArgs : EventArgs 
	{
		NodeBox mb;
		internal PrepareEffectEventArgs(NodeBox mb)
		{
			this.mb = mb;
		}

		public NodeBox MeshBox
		{
			get {return mb; }
		}
	}
	public class DirectXPanel : System.Windows.Forms.UserControl
	{
		// Our global variables for this project
		Device device = null; // Our rendering device		
		PresentParameters presentParams = new PresentParameters();
		ViewportSetting vp;
		bool pause, usefx = false;
		Effect effect;

		public bool Pasue 
		{
			get { return pause; }
			set { pause = value; }
		}

		MeshList meshes;
		public MeshList Meshes
		{
			get 
			{
				return meshes;
			}
		}

		public Device Device
		{
			get { return device; }
		}

		public Effect Effect
		{
			get { return effect; }
			set { effect = value; }
		}

		public bool UseEffect
		{
			get {return usefx;}
			set { usefx = value;}
		}

		public ViewportSetting Viewport
		{
			get { return vp; }
		}

		public DirectXPanel()
		{
			vp = new ViewportSetting();
			meshes = new MeshList();

			// Set the initial size of our form
			this.ClientSize = new System.Drawing.Size(400,300);
			// And it's caption
			this.Text = "Direct3D Panel";
			// And it's color
			this.BackColor = Color.Gray;
			

			InitializeGraphics();			
							
			this.ResetView();
		}

		
		/// <summary>
		/// Check if the Multisample Settings are Ok
		/// </summary>
		/// <param name="depthFmt"></param>
		/// <param name="backbufferFmt"></param>
		/// <param name="multisampleType"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		protected static bool IsDeviceMultiSampleOK (MultiSampleType multisampleType, DepthFormat depthFmt, Format backbufferFmt,out int result, out int qualityLevels)
		{
			AdapterInformation ai = Manager.Adapters.Default;			

			// Verify that the render target surface supports the given multisample type
			if ((backbufferFmt==Format.Unknown) || (Manager.CheckDeviceMultiSampleType(ai.Adapter, DeviceType.Hardware, backbufferFmt, false, multisampleType, out result, out qualityLevels)))
			{
				// Verify that the depth stencil surface supports the given multisample type
				if (Manager.CheckDeviceMultiSampleType(ai.Adapter, DeviceType.Hardware, (Format)depthFmt, false, multisampleType, out result, out qualityLevels))
				{
					return true;    // if both calls succeed
				}
			}

			return false;   // if either call fails.  NOTE: HRESULT passed back in result
		}

		/// <summary>
		/// Sets the passed MultiSampleType if supported by the current HW
		/// </summary>
		/// <param name="multisampleType">The type you want to set</param>
		protected void SetMultiSampleIfAvail(MultiSampleType multisampleType)
		{
			int result = 0;
			int qualityLevels = 0;
			if (IsDeviceMultiSampleOK( multisampleType, presentParams.AutoDepthStencilFormat, presentParams.BackBufferFormat, out result, out qualityLevels))
				if (result == (int)ResultCode.Success)
				{
					presentParams.MultiSample =  multisampleType;
					presentParams.MultiSampleQuality = qualityLevels-1;
				}
		}
		

		protected bool InitializeGraphics()
		{
			try
			{
				// Now let's setup our D3D stuff
				presentParams.Windowed = true;
				presentParams.SwapEffect = SwapEffect.Discard;
				presentParams.EnableAutoDepthStencil = true;    				
				presentParams.AutoDepthStencilFormat = DepthFormat.D16;

				// Test some formats				
				SetMultiSampleIfAvail(MultiSampleType.NonMaskable);
				SetMultiSampleIfAvail(MultiSampleType.TwoSamples);
				SetMultiSampleIfAvail(MultiSampleType.ThreeSamples);
				SetMultiSampleIfAvail(MultiSampleType.FourSamples);
				SetMultiSampleIfAvail(MultiSampleType.FiveSamples);
				SetMultiSampleIfAvail(MultiSampleType.SixSamples);
				SetMultiSampleIfAvail(MultiSampleType.SevenSamples);
				SetMultiSampleIfAvail(MultiSampleType.EightSamples);
				SetMultiSampleIfAvail(MultiSampleType.NineSamples);
				SetMultiSampleIfAvail(MultiSampleType.TenSamples);
				SetMultiSampleIfAvail(MultiSampleType.ElevenSamples);
				SetMultiSampleIfAvail(MultiSampleType.TwelveSamples);
				SetMultiSampleIfAvail(MultiSampleType.ThirteenSamples);
				SetMultiSampleIfAvail(MultiSampleType.FourteenSamples);
				SetMultiSampleIfAvail(MultiSampleType.FifteenSamples);
				SetMultiSampleIfAvail(MultiSampleType.SixteenSamples);

				device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, presentParams);
				device.DeviceReset += new System.EventHandler(this.OnResetDevice);
				this.OnCreateDevice(device, null);
				this.OnResetDevice(device, null);
		
				pause = false;
				return true;
			}
			catch (DirectXException)
            { 
                return false; 
            }
		}

		protected void OnCreateDevice(object sender, EventArgs e)
		{
			Device dev = (Device)sender;						
		}

		public event System.EventHandler ResetDevice;
		public void ReloadMeshes()
		{
			OnResetDevice(this.device, new EventArgs());
			Render();
		}

		public void AddLightMesh()
		{
			Direct3D.Material mat = new Direct3D.Material();
			mat.Diffuse = Color.Yellow;
			mat.Ambient = Color.Yellow;
			mat.Specular = Color.Yellow;
			mat.SpecularSharpness = 1;

			Direct3D.Material matoff = new Direct3D.Material();
			matoff.Diffuse = Color.DarkGray;
			matoff.Ambient = Color.DarkGray;
			matoff.Specular = Color.DarkGray;
			matoff.SpecularSharpness = 1;
			Mesh m = Mesh.Sphere(Device, 0.2f, 10, 4);
			Mesh mp = Mesh.Box(Device, 0.2f, 0.2f, 0.2f);

			MeshBox mb;

			for (int i=0; i<Device.Lights.Count; i++)
			{
				Light l = Device.Lights[i];
				if (!l.Enabled) mb = new MeshBox("Light", m, 1, matoff);
				else mb = new MeshBox("Light", m, 1, mat);

				Vector3 v = l.Position;

				mb.Transform = MeshTransform.Translation(v);
				this.Meshes.Add(mb);

				if (!l.Enabled) mb = new MeshBox("Light", mp, 1, matoff);
				else mb = new MeshBox("Light", mp, 1, mat);
                mb.Transform = MeshTransform.Translation(l.Position + 0.4f * l.Direction);
				this.Meshes.Add(mb);

				if (!l.Enabled) mb = new MeshBox("Light", mp, 1, matoff);
				else mb = new MeshBox("Light", mp, 1, mat);
                mb.Transform = MeshTransform.Translation(l.Position + 0.5f * l.Direction);
				this.Meshes.Add(mb);
			}
		}

		public void AddAxisMesh()
		{
			Direct3D.Material mat = new Direct3D.Material();
			mat.Diffuse = Color.Red;
			mat.Ambient = mat.Diffuse;
			mat.Specular = mat.Diffuse;
			mat.SpecularSharpness = 1;

			

			Mesh m = Mesh.Cylinder(device, 0.001f, 0.001f, 1, 6, 1);			
			MeshBox mb = new MeshBox("Axis", m, 1, mat);
            mb.Transform = MeshTransform.Translation(new Vector3(0, 0, 0));
			mb.Wire = false;
			this.Meshes.Add(mb);			

			mat.Diffuse = Color.Green;
			mat.Ambient = mat.Diffuse;
			mat.Specular = mat.Diffuse;
			m = Mesh.Cylinder(device, 0.001f, 0.001f, 1, 6, 1);			
			mb = new MeshBox("Axis", m, 1, mat);
            mb.Transform = MeshTransform.RotationYawPitchRoll(
                0, 				
				-Math.PI/2.0,
                0
			);
			mb.Wire = false;
			this.Meshes.Add(mb);	

			mat.Diffuse = Color.Blue;
			mat.Ambient = mat.Diffuse;
			mat.Specular = mat.Diffuse;
			m = Mesh.Cylinder(device, 0.001f, 0.001f, 1, 6, 1);			
			mb = new MeshBox("Axis", m, 1, mat);
            mb.Transform = MeshTransform.RotationYawPitchRoll(
                -Math.PI / 2.0,
                0,
                0
            );
			mb.Wire = false;
			this.Meshes.Add(mb);			
		}

		protected virtual void OnResetDevice(object sender, EventArgs e)
		{
			Device dev = (Device)sender;			
			
			dev.RenderState.CullMode = Cull.Clockwise;
			dev.RenderState.ZBufferEnable = true;
			dev.RenderState.Lighting = true;    // Make sure lighting is enable
			dev.RenderState.AlphaBlendEnable = true;
			dev.RenderState.SeparateAlphaBlendEnabled = true;
			dev.RenderState.AlphaSourceBlend = Blend.SourceAlpha;
			dev.RenderState.AlphaDestinationBlend = Blend.InvSourceAlpha;						
			dev.RenderState.AlphaBlendOperation = BlendOperation.Add;
			dev.RenderState.LocalViewer = true;			
			//dev.RenderState.DiffuseMaterialSource = ColorSource.Material;
    
			// Turn on ambient lighting.
			dev.RenderState.Ambient = System.Drawing.Color.White;
			
			this.SetupLights();		
			

			if (ResetDevice!=null) ResetDevice(this, new System.EventArgs());			
		}
		

		public event PrepareEffectEventHandler PrepareEffect;
        void DoRender(NodeBox nbox, Matrix basem, int effectct)
        {
            MeshBox box = null;
            if (nbox is MeshBox) box = (MeshBox)nbox;

            if (box != null)
            {
                if (box.Wire) device.RenderState.FillMode = FillMode.WireFrame;
                else device.RenderState.FillMode = FillMode.Solid;

                device.Material = box.Material;
            }


            Matrix tr = Matrix.Multiply(nbox.Transform, basem);
			if (nbox.Transform.IsAbsolute) 
				tr = nbox.Transform;
            device.Transform.World = tr;

            if (box != null)
            {
                if (effect != null && PrepareEffect != null && this.usefx) PrepareEffect(this, new PrepareEffectEventArgs(box));

                for (int s = 0; s < effectct; s++)
                {
                    if (effect != null && this.usefx) effect.BeginPass(s);
                    for (int i = 0; i < box.SubSetCount; i++)
                        box.Mesh.DrawSubset(i);
                    if (effect != null && this.usefx) effect.EndPass();
                }
            }

            foreach (NodeBox cld in nbox)
                DoRender(cld, tr, effectct);
        }

		public void Render()
		{
			if (device == null) 
				return;

			if (pause)
				return;									
			
			
			
			//Clear the backbuffer 			
			device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, BackColor, 1.0f, 0);
			
			//Begin the scene
			device.BeginScene();
			// Setup the world, view, and projection Matrices

			int ct = 1;
			if (effect!=null && this.usefx) ct = effect.Begin(0);
			
			
			{
				SetupLights();
				SetupMatrices();
													
				foreach (NodeBox box in meshes)
				{
                    DoRender(box, Matrix.Identity, ct);
				}		
				
			}

			if (effect!=null && this.usefx) effect.End();

			//End the scene
			device.EndScene();
			device.Present();
		}


        public event System.EventHandler ChangedLights;
		protected virtual void SetupLights()
		{					
			Vector3 cp1 = vp.CameraPosition;
			cp1.TransformCoordinate(Matrix.RotationX((float)(Math.PI/3)));

			Vector3 cp2 = vp.CameraPosition;
			cp2.TransformCoordinate(Matrix.RotationY((float)(Math.PI/3.4)));

			Vector3 cp3 = -1*vp.CameraPosition;
			cp3.TransformCoordinate(Matrix.RotationZ((float)(Math.PI/3.2)));
            cp3.TransformCoordinate(Matrix.RotationX((float)(Math.PI / 4.2)));
            cp3.TransformCoordinate(Matrix.RotationY((float)(Math.PI / 3.5)));
			// Set up a colored directional light, with an oscillating direction.
			// Note that many lights may be active at a time (but each one slows down
			// the rendering of the scene). However, here just one is used.
			device.Lights[0].Type = LightType.Directional;
			//device.Lights[0].Attenuation0 = 0.9f;
			//device.Lights[0].Falloff =0.6f;
			device.Lights[0].Diffuse = System.Drawing.Color.White;
			device.Lights[0].Specular = System.Drawing.Color.White;	
			
			device.Lights[0].Position =2*cp1;
			device.Lights[0].Direction = vp.CameraTarget - device.Lights[0].Position;
			device.Lights[0].Range = 3*(vp.ObjectCenter - device.Lights[0].Position).Length();
			device.Lights[0].Enabled = true; // Turn it on

			device.Lights[1].Type = device.Lights[0].Type;
			//device.Lights[1].Attenuation0 = 0.9f;
			device.Lights[1].Falloff =device.Lights[0].Falloff;
			device.Lights[1].Diffuse = device.Lights[0].Diffuse;
			device.Lights[1].Specular = device.Lights[0].Specular;			
			device.Lights[1].Position = 3*cp2;
			device.Lights[1].Direction = vp.CameraTarget - device.Lights[1].Position;			
			device.Lights[1].Range = 4*(vp.ObjectCenter - device.Lights[1].Position).Length();
			device.Lights[1].Enabled = true; // Turn it on	
			
			device.Lights[2].Type = LightType.Directional;
			//device.Lights[2].Attenuation0 = 0.9f;
			device.Lights[2].Falloff =device.Lights[0].Falloff;
			device.Lights[2].Diffuse = device.Lights[0].Diffuse;
			device.Lights[2].Specular = device.Lights[0].Specular;			
			device.Lights[2].Position = 2*cp3;
			device.Lights[2].Direction = vp.CameraTarget - device.Lights[2].Position;			
			device.Lights[2].Range = 4*(vp.ObjectCenter - device.Lights[2].Position).Length();
			device.Lights[2].Enabled = true; // Turn it on							

            if (ChangedLights != null) ChangedLights(this, new EventArgs());
		}

		private void SetupMatrices()
		{			
			device.Transform.World = Matrix.Identity;

			device.Transform.View = Matrix.Multiply(			
				Matrix.RotationY(vp.AngelY),
				Matrix.Multiply(
				Matrix.RotationX(vp.AngelX),
				Matrix.Multiply(
				Matrix.RotationZ(vp.AngelZ),
				//Matrix.Multiply(				
				//Matrix.LookAtLH(vp.CameraPosition, vp.CameraTarget, vp.CameraUpVector),
				Matrix.Translation(vp.CameraPosition.X+vp.X, vp.CameraPosition.Y+vp.Y, vp.CameraPosition.Z+vp.Z)
				//)
				)
				)
				);

			


			// For the projection matrix, we set up a perspective transform (which
			// transforms geometry from 3D view space to 2D viewport space, with
			// a perspective divide making objects smaller in the distance). To build
			// a perpsective transform, we need the field of view (1/4 pi is common),
			// the aspect ratio, and the near and far clipping planes (which define at
			// what distances geometry should be no longer be rendered).
			device.Transform.Projection = 
				//Matrix.OrthoLH(this.Width/15, this.Height/15, vp.NearPlane, vp.FarPlane*100f);
				Matrix.PerspectiveFovRH( vp.FoV, 1/vp.Aspect, vp.NearPlane, vp.FarPlane*1000f );
		}

		public void Reset()
		{
			this.OnResetDevice(this.device, null);
			this.Render();
		}

		public void ResetDefaultViewport() 
		{
			this.ResetView();
			this.OnResetDevice(this.device, null);
			this.Render();
		}

		public void ResetViewport(Vector3 min, Vector3 max) 
		{
			this.ResetView(min, max);
			this.OnResetDevice(this.device, null);
			this.Render();
		}

		protected void ResetView()
		{					
			vp.Reset();

			try 
			{
				Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
				Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

				foreach (NodeBox n in meshes) 
				{
					MeshBox m = null;
					if (n is MeshBox) m = (MeshBox)n;
					else continue;

					Mesh mesh = m.Mesh;

					int[] rank = {mesh.NumberVertices};	
					if (mesh.VertexBuffer.Description.VertexFormat == (VertexFormats)0x112) 
					{
						CustomVertex.PositionNormalTextured[] vertices = (CustomVertex.PositionNormalTextured[])mesh.LockVertexBuffer(typeof(CustomVertex.PositionNormalTextured), LockFlags.None, rank);
						try 
						{							
							foreach (CustomVertex.PositionNormalTextured v in vertices) 
							{
				
								if (v.X<min.X) min.X = v.X;
								if (v.Y<min.Y) min.Y = v.Y;
								if (v.Z<min.Z) min.Z = v.Z;

								if (v.X>max.X) max.X = v.X;
								if (v.Y>max.Y) max.Y = v.Y;
								if (v.Z>max.Z) max.Z = v.Z;
							}
						} 
						finally 
						{
							mesh.UnlockVertexBuffer();
						}
					} 
					else if (mesh.VertexBuffer.Description.VertexFormat == VertexFormats.PositionNormal) 
					{
						CustomVertex.PositionNormal[] vertices = (CustomVertex.PositionNormal[])mesh.LockVertexBuffer(typeof(CustomVertex.PositionNormal), LockFlags.None, rank);
						try 
						{							
							foreach (CustomVertex.PositionNormal v in vertices) 
							{
				
								if (v.X<min.X) min.X = v.X;
								if (v.Y<min.Y) min.Y = v.Y;
								if (v.Z<min.Z) min.Z = v.Z;

								if (v.X>max.X) max.X = v.X;
								if (v.Y>max.Y) max.Y = v.Y;
								if (v.Z>max.Z) max.Z = v.Z;
							}
						} 
						finally 
						{
							mesh.UnlockVertexBuffer();
						}
					} 		
				}
				
				if (min == max)
				{
					max.X = min.X+1;
					max.Y = min.Y+1;
					max.Z = min.Z+1;
				}

				ResetView(min, max);
			} 
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
			}
		}

		protected void ResetView(Vector3 min, Vector3 max)
		{
			try 
			{
				Vector3 center = new Vector3((float)((max.X+min.X)/2.0), (float)((max.Y+min.Y)/2.0), (float)((max.Z+min.Z)/2.0));
				//vp.Aspect = 1;//this.Size.Width / this.Size.Height;			
				
			
				Vector3 boundingSphereRadius = new Vector3(min.X-center.X, min.Y-center.Y, min.Z-center.Z);
				double radius = boundingSphereRadius.Length() / vp.Aspect;
				double dist = radius / Math.Sin(vp.FoV/2.0);

				//for (int i=0; i< mesh.NumberVertices; i++) vertices[i].Subtract(center);
			
				vp.ObjectCenter = center;
				vp.X = center.X/2;
				vp.Y = center.Y/2;
				vp.Z = center.Z/2;
				vp.CameraTarget = new Vector3(0,0,0);
				vp.CameraPosition = new Vector3(
					0, //center.X,
					0, //center.Y,
					(float)-dist); // + center.Z);
				vp.NearPlane = 0.01f;//(float)(dist-radius);
				vp.FarPlane = (float)((dist+radius));

				vp.AngelX = (float)(Math.PI/2.0f);
				vp.AngelZ = (float)(Math.PI);
                vp.BoundingSphereRadius = (float)radius;
					
				//Unlock the buffer
				
			} 
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n\n" + ex.StackTrace);
			}
		}

		System.Windows.Forms.MouseEventArgs last;					

		public event System.EventHandler RotationChanged;
        
		/// <summary>
		/// Called when the Mouse in the Display moved
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (last!=null)
			{
				int dx = e.X - last.X;
				int dy = e.Y - last.Y;

				if (e.Button == MouseButtons.Right) 
				{
					vp.AngelY -= (dx / vp.InputRotationScale);
					vp.AngelX += (dy / vp.InputRotationScale);

					if (RotationChanged!=null) RotationChanged(this, new EventArgs());
				}

				if (e.Button == MouseButtons.Left) 
				{

                    vp.X += ((float)dx / ((float)this.Width * vp.InputTranslationScale / vp.BoundingSphereRadius) );
                    vp.Y -= ((float)dy / ((float)this.Height * vp.InputTranslationScale / vp.BoundingSphereRadius));					
				}

				if (e.Button == MouseButtons.Middle) 
				{
                    vp.Z += ((float)dy / ((float)this.Height * vp.InputTranslationScale / vp.BoundingSphereRadius));	
					vp.AngelZ += (dx / vp.InputRotationScale);

					if (RotationChanged!=null) RotationChanged(this, new EventArgs());
				}

				this.Render();
			}
			last = e;
		}

		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			this.Render(); // Render on painting
		}
		
        protected override void OnResize(System.EventArgs e)
        {
			vp.Aspect = Math.Max(this.Width / this.Height , this.Size.Height / this.Size.Width);            
			if (device!=null) 
			{
				Viewport vpr = new Viewport();
				vpr.Width = this.Width;
				vpr.Height = this.Height;
				device.Viewport = vpr;

				vp.Aspect = Math.Max(vpr.Width/vpr.Height, vp.Aspect);
            
			}
			
            this.Render();
        }

        public Image Screenshot()
        {
            return Screenshot(ImageFileFormat.Png);
        }

        public Image Screenshot(ImageFileFormat format)
        {
            Surface backbuffer = device.GetBackBuffer(0, 0, BackBufferType.Mono);
            System.IO.Stream s = SurfaceLoader.SaveToStream(format, backbuffer);

            Image i = Image.FromStream(s);
            backbuffer.Dispose();

            return i;
        }
		
	}
}
