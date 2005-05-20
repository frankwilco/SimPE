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

		public PreviewForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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
			// 
			// PreviewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			this.ClientSize = new System.Drawing.Size(634, 448);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PreviewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recolor Preview";

		}
		#endregion

		static Ambertation.Panel3D p3d;
		public static void Execute(SimPe.PackedFiles.Wrapper.Cpf cmmat, SimPe.Interfaces.Files.IPackageFile package) 
		{
			try 
			{
				WaitingScreen.Wait();
				FileTable.FileIndex.Load();
				SimPe.Plugin.MmatWrapper mmat = (SimPe.Plugin.MmatWrapper)cmmat;

				string subset = mmat.SubsetName.Trim().ToLower();
				string modelname = mmat.ModelName.Trim().ToLower();
				string txmtname = Hashes.StripHashFromName(mmat.Name.Trim().ToLower());
				if (!txmtname.EndsWith("_txmt")) txmtname += "_txmt";

				PreviewForm pf = new PreviewForm();

				WaitingScreen.UpdateMessage("Walking Scenegraph");

				//add the passed package temporary to the Filetable
				Interfaces.Scenegraph.IScenegraphFileIndex fi = FileTable.FileIndex.Clone();
				fi.AddIndexFromPackage(package);

				Interfaces.Scenegraph.IScenegraphFileIndex old = FileTable.FileIndex;
				FileTable.FileIndex = fi;

				Scenegraph sg = new Scenegraph(modelname);
				SimPe.Packages.GeneratableFile pkg = sg.BuildPackage();
				WaitingScreen.UpdateMessage("Loading available Recolors");
				sg.AddMaterialOverrides(pkg, false, true, false);

				//pkg.Save("c:\\mmat_preview.package");

				FileTable.FileIndex = old;

				WaitingScreen.UpdateMessage("Loading current Texture");				
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(Hashes.StripHashFromName(txmtname), Data.MetaData.TXMT);
				//SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(txmtname, Data.MetaData.TXMT, Data.MetaData.LOCAL_GROUP, true);

				bool found = false;
				if (pfds.Length>0) 
				{
					GenericRcol txmt = new GenericRcol(null, false);
					txmt.ProcessData(pfds[0], package);


					ArrayList txtrs = (ArrayList)txmt.ReferenceChains["stdMatBaseTextureName"];//["TXTR"];
					if (txtrs.Count>0) 
					{
						//get the Texture File
						string txtrname = Hashes.StripHashFromName(((SimPe.Packages.PackedFileDescriptor)txtrs[0]).Filename);						
						if (!txtrname.EndsWith("_txtr")) txtrname += "_txtr";
						pfds = pkg.FindFile(txtrname, Data.MetaData.TXTR);
						if (pfds.Length>0) 
						{
							GenericRcol txtr = new GenericRcol(null, false);
							txtr.ProcessData(pfds[0], pkg);

							WaitingScreen.UpdateMessage("Find Meshdata");
							//now get all Mesh Files and find one with the passed subset in it
							pfds = pkg.FindFiles(Data.MetaData.GMDC);
							foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
							{
								GenericRcol gmdc = new GenericRcol(null, false);
								gmdc.ProcessData(pfd, pkg);

								GeometryDataContainer gdc = (GeometryDataContainer)gmdc.Blocks[0];
								foreach (SimPe.Plugin.Gmdc.GmdcGroup gdc3 in gdc.Groups) 
								{
									//found a mesh File
									if (gdc3.Name.Trim().ToLower()==subset) 
									{
										TextureLocator tl = new TextureLocator(pkg);
										Hashtable txtrmap = tl.FindTextures(gmdc);
										txtrmap[subset] = txtr;
										txtrmap = tl.GetLargestImages(txtrmap);

										WaitingScreen.UpdateMessage("Build Mesh");
										System.IO.Stream xfile = gdc.GenerateX(gdc.Groups);
											
										try 
										{
											Ambertation.Panel3D.StopAll();
											WaitingScreen.UpdateMessage("Show Preview");
											p3d = new Ambertation.Panel3D(pf, new Point(0, 0), pf.Size, xfile, txtrmap);
											found = true;
											break;
										} 
										catch (System.IO.FileNotFoundException)
										{
											WaitingScreen.Stop();
											if (MessageBox.Show("The Microsoft Managed DirectX Extensions were not found on your System. Without them, the Preview is not available.\n\nYou can install them manually, by extracting the content of the DirectX\\ManagedDX.CAB on your Sims 2 Installation CD #1. If you double click on the extracted msi File, all needed Files will be installed.\n\nYou can also let SimPE install it automatically. SimPE will download the needed Files (3.5MB) from the SimPE Homepage and install them. Do you want SimPE to download and install the Files?", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
											{
												if (WebUpdate.InstallMDX()) MessageBox.Show("Managed DirectX Extension were installed succesfully!");
											}
					
											return;
										}
										catch (Exception ex)
										{
											WaitingScreen.Stop();
											Helper.ExceptionMessage("", ex);
											return;
										}
									}
								} //foreach 
							} //foreach (pfd);
						}
					} // if txtrs
				}

				WaitingScreen.Stop();
				if (found) pf.ShowDialog();
				else throw new ScenegraphException("This Item can't be previed! SimPE was unable to build the Scengraph.", null);

				if (p3d!=null) 
				{
					p3d.Stop();
					p3d=null;
				}
			} 
			finally 
			{
				WaitingScreen.Stop();
			}
		}
	}
}
