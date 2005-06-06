/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Threading;

namespace Ambertation
{
	
	/// <summary>
	/// Zusammenfassung für Panel3D.
	/// </summary>
	public class Panel3D : Panel
	{
		Device device = null; // Our rendering device
		Mesh mesh = null; // Our mesh object in sysmem
		Microsoft.DirectX.Direct3D.Material[] meshMaterials; // Materials for our mesh
		Texture[] meshTextures; // Textures for our mesh
		PresentParameters presentParams = new PresentParameters(); //Device Parameters
		Stream xfile;  //the File Stream
		Hashtable txtrmap; //Texture Replacement map

		ViewportSetting vp;

		/// <summary>
		/// Returns the current Viewport Settings
		/// </summary>
		public ViewportSetting ViewportSetting
		{
			get { return vp; }
		}

		/// <summary>
		/// Conatins a Arraylist of all active Panels (used by the Display thread)
		/// </summary>
		static ArrayList panels = null;

		bool pause = false;
		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The name of the .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		public Panel3D(Control parent, Point pos, Size size, string xfile, Hashtable txtrmap)
		{
			System.IO.FileStream fs = System.IO.File.OpenRead(xfile);
			Init(parent, pos, size, fs, txtrmap, null);
		}

		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The name of the .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		/// <param name="vp">the viewport Settings to start with</param>
		public Panel3D(Control parent, Point pos, Size size, string xfile, Hashtable txtrmap, ViewportSetting vp)
		{
			System.IO.FileStream fs = System.IO.File.OpenRead(xfile);
			Init(parent, pos, size, fs, txtrmap, vp);
		}

		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		/// <param name="vp">the viewport Settings to start with</param>
		public Panel3D(Control parent, Point pos, Size size, Stream xfile, Hashtable txtrmap, ViewportSetting vp)
		{
			Init(parent, pos, size, xfile, txtrmap, vp);
		}

		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		public Panel3D(Control parent, Point pos, Size size, Stream xfile, Hashtable txtrmap)
		{
			Init(parent, pos, size, xfile, txtrmap, null);
		}

		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		public void Init(Control parent, Point pos, Size size, Stream xfile, Hashtable txtrmap, ViewportSetting vp)
		{
			this.Size = size;
			this.Location = pos;
			this.Parent = parent;
			this.xfile = xfile;
			this.txtrmap = txtrmap;

			if (!InitializeGraphics()) // Initialize Direct3D
			{
				throw new Exception("Could not initialize Direct3D.");
			}

			try 
			{
				OnResetDevice(device, null);
			} 
#if DEBUG
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message + "\n\n" +ex.StackTrace + "\n\n" + ex.Source);
				return;
			}
#else 
			catch (Exception)
			{
				return;
			}
#endif

			if (vp==null) this.vp = new ViewportSetting();
			else this.vp = vp;

			Monitor.Enter(render);
			Render();

			Monitor.Enter(panelaccess);
			//the first Panel is created
			if (panels==null) 
			{
				panels = new ArrayList();
				panels.Add(this);

				InitThread();
			} 
			else 
			{
				WaitForThreadRenderEnd();
				panels.Add(this);
			}
			Monitor.Exit(panelaccess);
			Monitor.Exit(render);
		}

		/// <summary>
		/// Use the destructor to remove this Object from the List of active Threads
		/// </summary>
		~ Panel3D() 
		{
			Stop();
		}

		/// <summary>
		/// Removes this Display Panel from the Thread
		/// </summary>
		public void Stop() 
		{
			WaitForThreadRenderEnd();
			if (panels!=null) panels.Remove(this);
		}

		/// <summary>
		/// Check if the Multisample Settings are Ok
		/// </summary>
		/// <param name="depthFmt"></param>
		/// <param name="backbufferFmt"></param>
		/// <param name="multisampleType"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		public static bool IsDeviceMultiSampleOK (MultiSampleType multisampleType, DepthFormat depthFmt, Format backbufferFmt,out int result, out int qualityLevels)
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

		/// <summary>
		/// Setup the DirectX Device
		/// </summary>
		/// <returns></returns>
		bool InitializeGraphics()
		{
			// Get the current desktop display mode, so we can set up a back
			// buffer of the same format
			try
			{
				// Set up the structure used to create the D3DDevice. Since we are now
				// using more complex geometry, we will create a device with a zbuffer.
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

				

				// Create the D3DDevice
				device = new Device(0, DeviceType.Hardware, this, CreateFlags.SoftwareVertexProcessing, presentParams);
				device.DeviceReset += new System.EventHandler(this.OnResetDevice);

				device.RenderState.ZBufferEnable = true; //Have Depth
				device.RenderState.Lighting = true;    // Make sure lighting is enabled
				device.RenderState.AlphaBlendEnable = true;
				device.RenderState.AlphaBlendOperation = BlendOperation.Add;
				device.RenderState.AlphaSourceBlend = Blend.SourceAlpha;
				device.RenderState.AlphaDestinationBlend = Blend.One;
				device.RenderState.LocalViewer = false;
				device.RenderState.Ambient = Color.White;

				pause = false;
			}
			catch (DirectXException)
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// This Event is called when the Device was changed
		/// </summary>
		/// <param name="sender">The device that changed</param>
		/// <param name="e"></param>
		void OnResetDevice(object sender, EventArgs e)
		{
			//Monitor.Enter(render);
			ExtendedMaterial[] materials = null;

			Device dev = (Device)sender;

			// Turn on the zbuffer
			dev.RenderState.ZBufferEnable = true;

			// Turn on ambient lighting 
			dev.RenderState.Ambient = System.Drawing.Color.White;				
			mesh = Mesh.FromStream(this.xfile, MeshFlags.SystemMemory, device, out materials);
			

			ResetDefaultViewport();
			SetupLights();

			if (meshTextures == null)
			{
				// We need to extract the material properties and texture names 
				meshTextures  = new Texture[materials.Length];
				meshMaterials = new Microsoft.DirectX.Direct3D.Material[materials.Length];
				for( int i=0; i<materials.Length; i++ )
				{
					meshMaterials[i] = materials[i].Material3D;
					// Set the ambient color for the material (D3DX does not do this)
					meshMaterials[i].Ambient = Color.Black;					
					meshMaterials[i].Diffuse = Color.DarkGray;
					meshMaterials[i].Specular = Color.Silver;
					meshMaterials[i].Emissive = Color.Black;
					meshMaterials[i].SpecularSharpness = (float)100.0;
     
					// Create the texture
					string txtrname = materials[i].TextureFilename;
					if (txtrname==null) txtrname="";
					object mapped = txtrmap[txtrname];

					if (mapped==null) mapped = txtrname;
					if (mapped==null) continue;
					if (mapped.GetType()==typeof(string)) 
					{
						if (System.IO.File.Exists(mapped.ToString()))
							meshTextures[i] = TextureLoader.FromFile(dev, mapped.ToString());						
					} 
					else 
					{
						meshTextures[i] = TextureLoader.FromStream(dev, (Stream)mapped);
					}					
				}
			}
			
			//Monitor.Exit(render);
		}

		

		/// <summary>
		/// this is called to Render the Scene
		/// </summary>
		public void Render()
		{
			try 
			{
				if (!this.Created) 
					return;
				if (device == null) 
					return;
				if (pause)
					return;
				if (meshMaterials==null) return;

				//Clear the backbuffer to a blue color 
				device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, this.BackColor, 1.0f, 0);
				//Begin the scene
				device.BeginScene();
				// Setup the world, view, and projection matrices
				SetupMatrices();
           
				// Meshes are divided into subsets, one for each material. Render them in
				// a loop
				for( int i=0; i<meshMaterials.Length; i++ )
				{
					// Set the material and texture for this subset
					device.Material = meshMaterials[i];
					device.SetTexture(0, meshTextures[i]);
        
					// Draw the mesh subset
					mesh.DrawSubset(i);

					if (bbox!=null) 
					{
						Material myMaterial = new Material();
						myMaterial.Diffuse = myMaterial.Ambient = Color.Red;
						myMaterial.Diffuse = Color.FromArgb(0x20, 0x20, 0x40, 0x30);
						device.Material = myMaterial;
						device.SetTexture(0, null);
						bbox.DrawSubset(0);
					}
				}

				//End the scene
				device.EndScene();
				device.Present();
			} 
#if DEBUG
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message + "\n\n" +ex.StackTrace + "\n\n" + ex.Source);
			}
#else 
			catch (Exception){}
#endif
		}

		/// <summary>
		/// Called when the scene need to be redisplayed
		/// </summary>
		/// <param name="e"></param>
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			this.Render(); // Render on painting
		}

		/// <summary>
		/// Called upon a Resize event
		/// </summary>
		/// <param name="e"></param>
		protected override void OnResize(System.EventArgs e)
		{
			//pause = ((this.WindowState == FormWindowState.Minimized) || !this.Visible);
		}
		#region ligh Control
		private void SetupLights()
		{
			
			// Set up a colored directional light, with an oscillating direction.
			// Note that many lights may be active at a time (but each one slows down
			// the rendering of the scene). However, here just one is used.
			device.Lights[0].Type = LightType.Point;
			device.Lights[0].Attenuation0 = 0.05f;
			device.Lights[0].Falloff =0.6f;
			device.Lights[0].Diffuse = System.Drawing.Color.DarkGray;
			device.Lights[0].Specular = System.Drawing.Color.White;
			device.Lights[0].Range = 30000;
			device.Lights[0].Position = vp.CameraPosition;;
			device.Lights[0].Direction = vp.CameraTarget - device.Lights[0].Position ;
			device.Lights[0].Enabled = true; // Turn it on

			device.Lights[1].Type = device.Lights[0].Type;
			device.Lights[1].Attenuation0 = device.Lights[0].Attenuation0;
			device.Lights[1].Falloff =device.Lights[0].Falloff;
			device.Lights[1].Diffuse = device.Lights[0].Diffuse;
			device.Lights[1].Specular = device.Lights[0].Specular;
			device.Lights[1].Range = device.Lights[0].Range/2;
			device.Lights[1].Position = new Vector3( -300.0f, -350.0f, 200.0f );
			device.Lights[1].Direction = new Vector3( 0.0f, +3.0f, -5.0f );
			device.Lights[1].Enabled = true; // Turn it on
			
			
    
			// Finally, turn on some ambient light.
			// Ambient light is light that scatters and lights all objects evenly.
			device.RenderState.Ambient = System.Drawing.Color.Gray;
		}
		#endregion

		#region camera Control
		Mesh bbox;
		public void ResetDefaultViewport() 
		{
			if (vp==null) vp = new ViewportSetting();
			vp.Reset();

			int[] rank = {mesh.NumberVertices};
		
			Vector3[] vertices = (Vector3[])mesh.LockVertexBuffer(typeof(Vector3), LockFlags.None, rank);
			
			Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			
			foreach (Vector3 v in vertices) 
			{
				if (v.X<min.X) min.X = v.X;
				if (v.Y<min.Y) min.Y = v.Y;
				if (v.Z<min.Z) min.Z = v.Z;

				if (v.X>max.X) max.X = v.X;
				if (v.Y>max.Y) max.Y = v.Y;
				if (v.Z>max.Z) max.Z = v.Z;
			}
			


			Vector3 center = new Vector3((float)((max.X+min.X)/2.0), (float)((max.Y+min.Y)/2.0), (float)((max.Z+min.Z)/2.0));
			vp.Aspect = this.Size.Width / this.Size.Height;			
			
			Vector3 boundingSphereRadius = new Vector3(min.X-center.X, min.Y-center.Y, min.Z-center.Z);
			double radius = boundingSphereRadius.Length() / vp.Aspect;
			double dist = radius / Math.Sin(vp.FoV);

			//foreach (Vector3 v in vertices) v.Subtract(center);
			vp.X = center.X;
			vp.Y = center.Y;
			vp.Z = center.Z;
			vp.CameraTarget = new Vector3(0,0,0);
			vp.CameraPosition = new Vector3(
				center.X,
				center.Y,
				(float)dist + center.Z);
			vp.NearPlane = (float)(dist-radius);
			vp.FarPlane = (float)(dist+radius);
			
			
			//bbox = Mesh.Box(device, max.X-min.X, max.Y-min.Y, max.Z-min.Z);
#if DEBUG
			bbox = Mesh.Sphere(device, 0.05f, 12, 4);			
#endif

			//Unlock the buffer
			mesh.UnlockVertexBuffer();

			SetupMatrices();
		}
		/// <summary>
		/// Used to Transfor the View of the Scene
		/// </summary>
		void SetupMatrices()
		{
			if (vp==null) vp = new ViewportSetting();


			device.Transform.World =  Matrix.Multiply(
				Matrix.RotationX( vp.AngelX ),
				Matrix.Multiply(
					Matrix.RotationY( vp.AngelY ),
					Matrix.Multiply(
						Matrix.Scaling(vp.Scale, vp.Scale, vp.Scale), 
						Matrix.Translation(vp.X, vp.Y, vp.Z)
					)
				)
			);

			device.Transform.View = Matrix.Multiply(
				Matrix.RotationX(-0.8f),
				Matrix.Multiply(
					Matrix.RotationY(0),
					Matrix.Multiply(
						Matrix.RotationZ(0),
						Matrix.LookAtLH(vp.CameraPosition, vp.CameraTarget, vp.CameraUpVector)
					)
				)
			);

			// For the projection matrix, we set up a perspective transform (which
			// transforms geometry from 3D view space to 2D viewport space, with
			// a perspective divide making objects smaller in the distance). To build
			// a perpsective transform, we need the field of view (1/4 pi is common),
			// the aspect ratio, and the near and far clipping planes (which define at
			// what distances geometry should be no longer be rendered).
			device.Transform.Projection = Matrix.PerspectiveFovLH( vp.FoV, vp.Aspect, vp.NearPlane, vp.FarPlane );
		}

		System.Windows.Forms.MouseEventArgs last;
		

		/// <summary>
		/// Resets the View
		/// </summary>
		public void ResetView()
		{
			vp.Reset();
		}

		/// <summary>
		/// Called when the Mouse in the Display moved
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (last!=null)
			{
				int dx = e.X - last.X;
				int dy = e.Y - last.Y;

				if (e.Button == MouseButtons.Right) 
				{
					vp.AngelY += (dx / 100.0f);
					vp.AngelX += (dy / 100.0f);
				}

				if (e.Button == MouseButtons.Left) 
				{
					vp.X += (dx / 100.0f);
					vp.Y += (dy / 100.0f);					
				}

				if (e.Button == MouseButtons.Middle) 
				{
					vp.Scale += (dx / 100.0f);
					vp.Z += (dy / 100.0f);
				}
			}
			last = e;
		}
		#endregion


		#region Display Thread
		/// <summary>
		/// Waits until the Thread finished the rendering
		/// </summary>
		public static void WaitForThreadRenderEnd()
		{
			while (render) {};
		}

		static System.Threading.Thread thread;
		protected void InitThread()
		{
			thread = new System.Threading.Thread(new System.Threading.ThreadStart(StartThread));
			thread.Start();
		}

		static bool render;
		static bool panelaccess = false;
		protected static void StartThread()
		{
			render = false;
			while(panels.Count>0) 
			{
				Monitor.Enter(render);
				render = true;
				foreach(Panel3D panel in panels)
				{
					panel.Render();
				}
				render = false;
				Monitor.Exit(render);
				System.Threading.Thread.Sleep(new TimeSpan(0, 0, 0, 0, 10));
			}

			panels = null;
		}
		/// <summary>
		/// Remove all Panels from the Display Queue
		/// </summary>
		public static void StopAll()
		{
			try 
			{
				if (thread!=null)
				{
					Monitor.Enter(render);
					WaitForThreadRenderEnd();;
					Monitor.Enter(panelaccess);
					Monitor.Exit(render);
					foreach (Panel3D pn in panels)
					{
						pn.Stop();
						pn.Dispose();
					}

					//panels = new ArrayList();
					if (thread!=null) while (thread.IsAlive) {};
					while (panels!=null) {};
					Monitor.Exit(panelaccess);
				} 
				panels = null;
				
			} 
			catch (Exception) {}
		}
		#endregion
	}
}
