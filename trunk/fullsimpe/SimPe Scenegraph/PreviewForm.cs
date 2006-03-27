using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für PreviewForm.
	/// </summary>
	public class PreviewForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		Ambertation.Graphics.DirectXPanel dx = null;

		public PreviewForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			dx.Settings.AddAxis = false;
			dx.LoadSettings(Helper.SimPeViewportFile);
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PreviewForm));
			this.dx = new Ambertation.Graphics.DirectXPanel();
			this.SuspendLayout();
			// 
			// dx
			// 
			this.dx.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.dx.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dx.Effect = null;
			this.dx.Location = new System.Drawing.Point(0, 0);
			this.dx.Name = "dx";
			this.dx.Size = new System.Drawing.Size(494, 476);
			this.dx.TabIndex = 0;
			this.dx.WorldMatrix = ((Microsoft.DirectX.Matrix)(resources.GetObject("dx.WorldMatrix")));
			// 
			// PreviewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(494, 476);
			this.Controls.Add(this.dx);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreviewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recolor Preview";
			this.ResumeLayout(false);

		}
		#endregion

		static void Exception()
		{
			throw new SimPe.Warning("This Item can't be previewed!", "SimPE was unable to build the Scengraph.");
		}

		//static Ambertation.Panel3D p3d;
		public static void Execute(SimPe.PackedFiles.Wrapper.Cpf cmmat, SimPe.Interfaces.Files.IPackageFile package) 
		{
			if (!(cmmat is MmatWrapper)) return;

			MmatWrapper mmat = cmmat as MmatWrapper;
			Wait.Start();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fii = FileTable.FileIndex.AddNewChild();			
			try 
			{
				FileTable.FileIndex.Load();
				fii.AddIndexFromPackage(package);
				fii.AddIndexFromFolder(System.IO.Path.GetDirectoryName(package.SaveFileName));


				GenericRcol rcol = mmat.GMDC;
				if (rcol!=null)
				{
					GeometryDataContainerExt gmdcext = new GeometryDataContainerExt(rcol.Blocks[0] as GeometryDataContainer);	
					gmdcext.UserTxmtMap[mmat.SubsetName] = mmat.TXMT;
					gmdcext.UserTxtrMap[mmat.SubsetName] = mmat.TXTR;
					Ambertation.Scenes.Scene scene = gmdcext.GetScene(new SimPe.Plugin.Gmdc.ElementOrder(Gmdc.ElementSorting.Preview));

					PreviewForm f = new PreviewForm();
					f.dx.AddScene(scene);
					f.dx.ResetDefaultViewport();
					f.ShowDialog();
					f.dx.Meshes.Clear(true);
				}
				else Exception();

			}
			catch (System.IO.FileNotFoundException)
			{
				Wait.Stop();
				if (MessageBox.Show("The Microsoft Managed DirectX Extensions were not found on your System. Without them, the Preview is not available.\n\nYou can install them manually, by extracting the content of the DirectX\\ManagedDX.CAB on your Sims 2 Installation CD #1. If you double click on the extracted msi File, all needed Files will be installed.\n\nYou can also let SimPE install it automatically. SimPE will download the needed Files (3.5MB) from the SimPE Homepage and install them. Do you want SimPE to download and install the Files?", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					if (WebUpdate.InstallMDX()) MessageBox.Show("Managed DirectX Extension were installed succesfully!");
				}
					
				return;
			}
			catch (Exception ex)
			{
				Wait.Stop();	
				Helper.ExceptionMessage(ex);
			}
			finally 
			{				
				FileTable.FileIndex.RemoveChild(fii);
				fii.Clear();
			}
			Wait.Stop();				
		}			
	}
}
