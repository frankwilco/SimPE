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
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Threading;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// This is a Panel you can use to display a Direct X Device
	/// </summary>
	[ToolboxBitmapAttribute(typeof(PictureBox))]
	public class DirectXPanel : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DirectXPanel()
		{
			SetStyle(
				//ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			BackColor = Color.DarkGray;
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			pause = false;			
			vp = new ViewportSetting();

		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region Fields
		/// <summary>
		/// string that is starting a Comment
		/// </summary>
		public const string COMMENTSTART = "-AMBERTATION";

		Device device = null; // Our rendering device
		Mesh mesh = null; // Our mesh object in sysmem
		Microsoft.DirectX.Direct3D.Material[] meshMaterials; // Materials for our mesh
		Texture[] meshTextures; // Textures for our mesh
		PresentParameters presentParams = new PresentParameters(); //Device Parameters
		Stream xfile;  //the File Stream
		Hashtable txtrmap; //Texture Replacement map

		ViewportSetting vp;
		bool pause;
		#endregion

		#region Public Properties
		/// <summary>
		/// Returns the current Viewport Settings
		/// </summary>
		public ViewportSetting ViewportSetting
		{
			get { return vp; }
		}

		/// <summary>
		/// True if a Mesh was loaded
		/// </summary>
		public bool LoadedMesh
		{
			get {return mesh!=null; }
		}
		#endregion

		public bool LoadMesh(string xfile, Hashtable txtrmap) 
		{
			System.IO.FileStream fs = System.IO.File.OpenRead(xfile);
			return LoadMesh(fs, txtrmap);
		}

		public bool LoadMesh(Stream xfile, Hashtable txtrmap)
		{
			try 
			{
				Init(xfile, txtrmap);
			}
#if DEBUG
			catch (Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message + "\n\n" +ex.StackTrace + "\n\n" + ex.Source);
				return false;
			}
#else
			catch {
				return false;
			}
#endif			
			return true;
		}
		/// <summary>
		/// Initializes a new Panel containing one 3D Mesh
		/// </summary>
		/// <param name="XFile">The .x File you want to display</param>
		/// <param name="txtrmap">
		/// A replacementmap for Filenames. This hashtable mappes the Textures Filename 
		/// as stored in the xFile, to another Filename or to a Stream containing the Texture
		/// </param>
		protected void Init(Stream xfile, Hashtable txtrmap)
		{
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
				
			ResetDefaultViewport();	
			SetupLights();
			this.DoRender();
		}

		/// <summary>
		/// Use the destructor to remove this Object from the List of active Threads
		/// </summary>
		~ DirectXPanel() 
		{
			Stop();
		}

		/// <summary>
		/// Removes this Display Panel from the Thread
		/// </summary>
		public void Stop() 
		{
			
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

		void SetupTexture()
		{
			
			device.TextureState[0].ColorOperation = TextureOperation.Modulate2X;
			device.TextureState[0].ColorArgument1 = TextureArgument.TextureColor;
			device.TextureState[0].ColorArgument2 = TextureArgument.Diffuse;
			device.TextureState[0].AlphaOperation = TextureOperation.SelectArg2;
			device.TextureState[0].AlphaArgument1 = TextureArgument.TextureColor;
			device.TextureState[0].AlphaArgument2 = TextureArgument.Diffuse;
							
			device.TextureState[1].ColorOperation = TextureOperation.Disable;
			device.TextureState[1].AlphaOperation = TextureOperation.Disable;
		}

		void SetupRenderstate() 
		{
			device.RenderState.CullMode = Cull.Clockwise;
			device.RenderState.ZBufferEnable = true;			
			device.RenderState.AlphaBlendEnable = true;
			device.RenderState.SeparateAlphaBlendEnabled = true;
			device.RenderState.AlphaSourceBlend = Blend.SourceAlpha;
			device.RenderState.AlphaDestinationBlend = Blend.InvSourceAlpha;			
			device.RenderState.Lighting = true;    // Make sure lighting is enabled			
			device.RenderState.AlphaBlendOperation = BlendOperation.Add;
			device.RenderState.LocalViewer = true;
			device.RenderState.Ambient = Color.White;
			device.RenderState.DiffuseMaterialSource = ColorSource.Material;			
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

				SetupRenderstate();

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
			if (xfile==null) 
			{
				mesh = null;
				Refresh();
				return;
			}
			ExtendedMaterial[] materials = null;

			Device dev = (Device)sender;

			// Turn on the zbuffer
			dev.RenderState.ZBufferEnable = true;

			// Turn on ambient lighting 
			dev.RenderState.Ambient = System.Drawing.Color.White;
			xfile.Seek(0, System.IO.SeekOrigin.Begin);	
			mesh = Mesh.FromStream(this.xfile, MeshFlags.SystemMemory, device, out materials);
						
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
					
					if (txtrname.IndexOf(Panel3D.COMMENTSTART)!=-1)  txtrname = txtrname.Substring(0, txtrname.IndexOf(Panel3D.COMMENTSTART));						

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
						((Stream)mapped).Seek(0, System.IO.SeekOrigin.Begin);
						meshTextures[i] = TextureLoader.FromStream(dev, (Stream)mapped);
					}					
				}
			}
		}		

		/// <summary>
		/// this is called to Render the Scene
		/// </summary>
		public void DoRender()
		{
			try 
			{
				if (!this.Created || device == null || pause || meshMaterials==null || !LoadedMesh) 					
					return;				
				

				//Clear the backbuffer to a blue color 
				device.Clear(ClearFlags.Target | ClearFlags.ZBuffer, this.BackColor, 1.0f, 0);				

				//Begin the scene
				device.BeginScene();
				// Setup the world, view, and projection matrices
				SetupMatrices(false);

				SetupRenderstate();
				SetupTexture();
           
				// Meshes are divided into subsets, one for each material. Render them in
				// a loop
				for( int i=0; i<meshMaterials.Length; i++ )
				{
					// Set the material and texture for this subset
					device.Material = meshMaterials[i];
					device.SetTexture(0, meshTextures[i]);
        
					// Draw the mesh subset
					mesh.DrawSubset(i);					
				}

				SetupMatrices(true);
				if (bbox!=null) 
				{
					Material myMaterial = new Material();
					myMaterial.Diffuse = myMaterial.Ambient = Color.Red;
					myMaterial.Diffuse = Color.FromArgb(0x20, 0x20, 0x40, 0x30);
					myMaterial.Specular = Color.FromArgb(0x20, 0xff, 0xff, 0xff);

					device.SetTexture(0, null);
					device.Material = myMaterial;	
					SetupRenderstate();
					SetupTexture();
					bbox.DrawSubset(0);
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
			base.OnPaint(e);
			if (!this.LoadedMesh) 
			{
				e.Graphics.FillRectangle(new SolidBrush(this.BackColor), e.ClipRectangle);
			} 
			else this.DoRender(); // Render on painting			
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged (e);
			pause = !this.Visible;
		}


		/// <summary>
		/// Called upon a Resize event
		/// </summary>
		/// <param name="e"></param>
		protected override void OnResize(System.EventArgs e)
		{
			if (this.Height==0 || this.Width==0) vp.Aspect = 1;
			else vp.Aspect = Math.Max(this.Width / this.Height , this.Size.Height / this.Size.Width);			
			//pause = ((this.WindowState == FormWindowState.Minimized) || !this.Visible);
		}

		#region ligh Control
		private void SetupLights()
		{
			
			// Set up a colored directional light, with an oscillating direction.
			// Note that many lights may be active at a time (but each one slows down
			// the rendering of the scene). However, here just one is used.
			device.Lights[0].Type = LightType.Point;
			device.Lights[0].Attenuation0 = 0.9f;
			//device.Lights[0].Falloff =0.6f;
			device.Lights[0].Diffuse = System.Drawing.Color.DarkGray;
			device.Lights[0].Specular = System.Drawing.Color.White;			
			device.Lights[0].Position = vp.CameraPosition;
			device.Lights[0].Direction = device.Lights[0].Position -vp.CameraTarget ;
			device.Lights[0].Range = 2*(vp.ObjectCenter - device.Lights[0].Position).Length();
			device.Lights[0].Enabled = true; // Turn it on

			device.Lights[1].Type = device.Lights[0].Type;
			device.Lights[1].Attenuation0 = 0.9f;
			device.Lights[1].Falloff =device.Lights[0].Falloff;
			device.Lights[1].Diffuse = device.Lights[0].Diffuse;
			device.Lights[1].Specular = device.Lights[0].Specular;			
			device.Lights[1].Position = vp.CameraPosition * 3 + new Vector3(10*vp.CameraPosition.X, -vp.CameraPosition.Y*10, 0);
			device.Lights[1].Direction = new Vector3( 0.0f, +3.0f, -5.0f );
			device.Lights[1].Range = 2*(vp.ObjectCenter - device.Lights[1].Position).Length();
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
			ResetView();
			this.DoRender();
		}

		protected void ResetView()
		{						
			vp.Reset();

			try 
			{
				Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
				Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

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
					CustomVertex.PositionNormal[] vertices = (CustomVertex.PositionNormal[])mesh.LockVertexBuffer(typeof(CustomVertex.PositionNormalTextured), LockFlags.None, rank);
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
				
				if (min == max)
				{
					max.X = min.X+1;
					max.Y = min.Y+1;
					max.Z = min.Z+1;
				}


				Vector3 center = new Vector3((float)((max.X+min.X)/2.0), (float)((max.Y+min.Y)/2.0), (float)((max.Z+min.Z)/2.0));
				//vp.Aspect = 1;//this.Size.Width / this.Size.Height;			
				//vp.Aspect = Math.Max(this.Width / this.Height , this.Size.Height / this.Size.Width);
			
				Vector3 boundingSphereRadius = new Vector3(min.X-center.X, min.Y-center.Y, min.Z-center.Z);
				double radius = boundingSphereRadius.Length() / vp.Aspect;
				double dist = radius / Math.Sin(vp.FoV/2.0);

				//for (int i=0; i< mesh.NumberVertices; i++) vertices[i].Subtract(center);
			
				vp.ObjectCenter = center;
				vp.X = -center.X;
				vp.Y = -center.Y;
				vp.Z = -center.Z;
				vp.CameraTarget = new Vector3(0,0,0);
				vp.CameraPosition = new Vector3(
					0, //center.X,
					0, //center.Y,
					(float)dist); // + center.Z);
				vp.NearPlane = 0.01f;//(float)(dist-radius);
				vp.FarPlane = (float)((dist+radius));
			
			
				//bbox = Mesh.Box(device, max.X-min.X, max.Y-min.Y, max.Z-min.Z);
#if DEBUG
				bbox = Mesh.Sphere(device, 0.05f, 12, 4);			
#endif

				//Unlock the buffer
				
			} 
			catch {}
		}
		/// <summary>
		/// Used to Transfor the View of the Scene
		/// </summary>
		void SetupMatrices(bool bb)
		{
			if (vp==null) vp = new ViewportSetting();


			if (true || (!bb))
			{
				device.Transform.World =  Matrix.Multiply(	
					
					Matrix.Translation(-vp.ObjectCenter.X, -vp.ObjectCenter.Y, -vp.ObjectCenter.Z),
					Matrix.Multiply(
					Matrix.Scaling(-vp.Scale, vp.Scale, vp.Scale),
					Matrix.Multiply(
					Matrix.RotationZ( vp.AngelZ ),
					Matrix.Multiply(
					Matrix.RotationX( vp.AngelX ),
					Matrix.Multiply(
					Matrix.RotationY( vp.AngelY ),
					Matrix.Translation(vp.X+vp.ObjectCenter.X, vp.Y+vp.ObjectCenter.Y, vp.Z+vp.ObjectCenter.Z)									
					)
					)
					)
					)
					);	
			} 
			else 
			{
				device.Transform.World =  Matrix.Multiply(	
					Matrix.Scaling(vp.Scale, vp.Scale, vp.Scale),
					Matrix.Multiply(
					Matrix.Translation(-vp.X, -vp.Y, -vp.Z),
					Matrix.Multiply(
					Matrix.RotationZ( vp.AngelZ ),
					Matrix.Multiply(
					Matrix.RotationX( vp.AngelX ),
					Matrix.Multiply(
					Matrix.RotationY( vp.AngelY ),
					Matrix.Multiply(
					Matrix.Scaling(vp.Scale, vp.Scale, vp.Scale),
					Matrix.Translation(vp.X, vp.Y, vp.Z)
					)								
					)
					)
					)
					)
					);	
			}

			device.Transform.View = Matrix.Multiply(
				Matrix.RotationX(0.3f),
				Matrix.Multiply(
				Matrix.RotationY(-0.2f),
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
			device.Transform.Projection = Matrix.PerspectiveFovLH( vp.FoV, vp.Aspect, vp.NearPlane, vp.FarPlane*1000f );
		}

		System.Windows.Forms.MouseEventArgs last;					

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
					vp.AngelY -= (dx / vp.InputRotationScale);
					vp.AngelX += (dy / vp.InputRotationScale);
				}

				if (e.Button == MouseButtons.Left) 
				{
					vp.X -= (dx / vp.InputTranslationScale);
					vp.Y -= (dy / vp.InputTranslationScale);					
				}

				if (e.Button == MouseButtons.Middle) 
				{
					vp.Scale += (dy / vp.InputScaleScale);
					vp.AngelZ += (dx / vp.InputRotationScale);
				}

				this.DoRender();
			}
			last = e;
		}
		#endregion
	}
}
