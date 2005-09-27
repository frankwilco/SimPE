using System;
using SimPe.Plugin;
using System.Drawing;
using SimPe.Interfaces.Scenegraph;

namespace SimPe
{
	/// <summary>
	/// This class handles the Comandline Arguments of SimPE
	/// </summary>
	public class Commandline
	{
		/// <summary>
		/// Tries to process the CommandLine
		/// </summary>
		/// <param name="args">Commandline Arguments</param>
		/// <returns>true if simpe should stop now</returns>
		public static bool Start(string[] args)
		{
			if (args.Length<1) return false;

			if (Help(args)) return true;
			if (BuildPackage(args)) return true;
			if (BuildTxtr(args)) return true;
			if (FixPackage(args)) return true;
			return false;
		}

		static bool Help(string[] args) 
		{
			if (args[0]!="-help") return false;

			Console.WriteLine("SimPE Commandline Parameters:");
			Console.WriteLine("-----------------------------");
			Console.WriteLine();
			Console.WriteLine("  -build -desc [packag.xml] -out [output].package");
			Console.WriteLine("  -txtr -image [imgfile] -out [output].package -name [textureNam] -format [dxt1|dxt3|dxt5|raw8|raw24|raw32] -levels [nr] -width [max. Width] -height [max. Height]");
			return true;
		}

		#region Fix
		public static void FixPackage(string flname, string modelname, FixVersion ver)
		{
			if (System.IO.File.Exists(flname))
			{
				SimPe.Packages.GeneratableFile pkg = SimPe.Packages.GeneratableFile.LoadFromFile(flname);

				System.Collections.Hashtable map = RenameForm.GetNames((modelname.Trim()!=""), pkg, null, modelname);
				FixObject fo = new FixObject(pkg, ver, false);
				fo.Fix(map, false);
				fo.CleanUp();
				fo.FixGroup();

				pkg.Save();
			}
		}

		static bool FixPackage(string[] args) 
		{
			if (args[0]!="-fix") return false;

			string modelname = "";
			string prefix = "";
			string package = "";
			FixVersion ver = FixVersion.UniversityReady;

			#region Parse Arguments
			for (int i=0; i<args.Length; i++) 
			{
				if (args[i]=="-package") 
				{
					if (args.Length>i+1) 
					{
						package = args[++i];
						continue;
					}
				}

				if (args[i]=="-modelname") 
				{
					if (args.Length>i+1) 
					{
						modelname = args[++i];
						continue;
					}
				}

				if (args[i]=="-prefix") 
				{
					if (args.Length>i+1) 
					{
						prefix = args[++i];
						continue;
					}
				}

				if (args[i]=="-fixversion") 
				{
					if (args.Length>i+1) 
					{
						if (args[++i].Trim().ToLower()=="uni1") ver = FixVersion.UniversityReady;
						else if (args[++i].Trim().ToLower()=="uni2") ver = FixVersion.UniversityReady2;
						continue;
					}
				}
			}
			#endregion

			FixPackage(package, prefix+modelname,  ver);
			return true;
		}
		#endregion

		#region Build Package
		static bool BuildPackage(string[] args) 
		{
			if (args[0]!="-build") return false;

			string output = "";
			string input = "";

			#region Parse Arguments
			for (int i=0; i<args.Length; i++) 
			{
				if (args[i]=="-desc") 
				{
					if (args.Length>i+1) 
					{
						input = args[++i];
						continue;
					}
				}
				if (args[i]=="-out") 
				{
					if (args.Length>i+1) 
					{
						output = args[++i];
						continue;
					}
				}
			}
			#endregion

			if (!System.IO.File.Exists(input)) 
			{
				Console.WriteLine(input + " existiert nicht.");
				return true;
			}

			SimPe.Packages.GeneratableFile pkg = SimPe.Packages.GeneratableFile.LoadFromStream(XmlPackageReader.OpenExtractedPackage(null, input));
			pkg.Save(output);

			return true;
		}
		#endregion

		#region Build TXTR
		/// <summary>
		/// Assemble a Picture File
		/// </summary>
		/// <param name="data"></param>
		public static void LoadTXTR(ImageData id, string flname, System.Drawing.Size sz, int levels, SimPe.Plugin.ImageLoader.TxtrFormats format) 
		{
			try 
			{
				System.Drawing.Image src = Image.FromFile(flname);
				LoadTXTR(id, src, sz, levels, format);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		/// <summary>
		/// Assemble a Picture File
		/// </summary>
		/// <param name="data"></param>
		public static void LoadTXTR(ImageData id, System.Drawing.Image src, System.Drawing.Size sz, int levels, SimPe.Plugin.ImageLoader.TxtrFormats format) 
		{
			try 
			{					
				id.TextureSize = sz;
				id.Format = format;
				id.MipMapLevels = (uint)levels;

				System.Drawing.Image img = new Bitmap(sz.Width, sz.Height);
				
				Graphics gr = Graphics.FromImage(img);

				gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
				gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				gr.DrawImage(src, new Rectangle(new Point(0,0), img.Size), new Rectangle(new Point(0,0), src.Size), GraphicsUnit.Pixel);
						

				MipMap[] maps = new MipMap[levels];
				int wd = 1;
				int hg = 1;

				//build default Sizes
				for (int i=0; i<levels; i++)
				{
					MipMap mm = new MipMap(id);
					mm.Texture = new Bitmap(wd, hg);

					if ((wd==hg) && (wd==1))
					{
						wd = id.TextureSize.Width/id.TextureSize.Height;
						hg = 1;

						if ((wd==hg) && (wd==1)) 
						{
							wd *= 2; hg *= 2;
						}
					} 
					else 
					{
						wd *= 2; hg *= 2;
					}

					maps[i] = mm;
				}

				//create a Scaled Version for each testure
				for (int i=0; i< maps.Length; i++) 
				{
					MipMap mm  = maps[i];
					if (img!=null)
					{
						Image bm = mm.Texture;
						gr = Graphics.FromImage(bm);

						gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
						gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
						gr.DrawImage(img, new Rectangle(new Point(0,0), bm.Size), new Rectangle(new Point(0,0), img.Size), GraphicsUnit.Pixel);

						
						id.TextureSize = new Size(bm.Width, bm.Height);
					}
				} // for i

				MipMapBlock[] mmps = new MipMapBlock[1];
				mmps[0] = new MipMapBlock(id);
				mmps[0].MipMaps = maps;

				id.MipMapBlocks = mmps;
			} 
			catch (Exception ex) 
			{
				Console.WriteLine("Exception: "+ex.Message);
			}
		}
		

		/// <summary>
		/// Assemble a Picture File
		/// </summary>
		/// <param name="data"></param>
		public static void LoadDDS(ImageData id, DDSData[] data) 
		{
			if (data==null) return;
			if (data.Length>0) 
			{
				try 
				{					
					id.TextureSize = data[0].ParentSize;
					id.Format = data[0].Format;
					id.MipMapLevels = (uint)data.Length;

					MipMap[] maps = new MipMap[data.Length];
					int ct=0;
					for (int i=data.Length-1; i>=0; i--)
					{
						DDSData item = data[i];
						MipMap mm = new MipMap(id);
						mm.Texture = item.Texture;
						mm.Data = item.Data;

						maps[ct++] = mm;
					}
	
					MipMapBlock[] mmps = new MipMapBlock[1];
					mmps[0] = new MipMapBlock(id);
					mmps[0].MipMaps = maps;

					id.MipMapBlocks = mmps;
				}
				catch (Exception ex) 
				{
					Console.WriteLine("Exception: "+ex.Message);
				}						
			}

		}

		/// <summary>
		/// Build a Texture
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public static bool BuildTxtr(string[] args)
		{
			if (args[0]!="-txtr") return false;

			//get Parameters
			string filename = "";
			string output = "";
			string texturename = "";
			int levels = 9;
			System.Drawing.Size sz = new System.Drawing.Size(512, 512);
			SimPe.Plugin.ImageLoader.TxtrFormats format = SimPe.Plugin.ImageLoader.TxtrFormats.DXT1Format;

			#region Parse Arguments
			for (int i=0; i<args.Length; i++) 
			{
				if (args[i]=="-image") 
				{
					if (args.Length>i+1) 
					{
						filename = args[++i];
						continue;
					}
				}

				if (args[i]=="-out") 
				{
					if (args.Length>i+1) 
					{
						output = args[++i];
						continue;
					}
				}

				if (args[i]=="-name") 
				{
					if (args.Length>i+1) 
					{
						texturename = args[++i];
						continue;
					}
				}

				if (args[i]=="-levels") 
				{
					if (args.Length>i+1) 
					{
						levels = Convert.ToInt32(args[++i]);
						continue;
					}
				}

				if (args[i]=="-width") 
				{
					if (args.Length>i+1) 
					{
						sz.Width = Convert.ToInt32(args[++i]);
						continue;
					}
				}

				if (args[i]=="-height") 
				{
					if (args.Length>i+1) 
					{
						sz.Height = Convert.ToInt32(args[++i]);
						continue;
					}
				}

				if (args[i]=="-format") 
				{
					if (args.Length>i+1) 
					{
						switch (args[++i]) 
						{
							case "dxt1": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.DXT1Format;
								break;
							}
							case "dxt3": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.DXT3Format;
								break;
							}
							case "dxt5": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.DXT5Format;
								break;
							}
							case "raw24": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.Raw24Bit;
								break;
							}
							case "raw32": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.Raw32Bit;
								break;
							}
							case "raw8": 
							{
								format = SimPe.Plugin.ImageLoader.TxtrFormats.Raw8Bit;
								break;
							}
						}
						continue;
					}
				}
			}
			#endregion

			//check if the File exists
			if (!System.IO.File.Exists(filename)) 
			{
				System.Console.WriteLine(filename+" was not found.");
				return true;
			}
			if (output.Trim()=="") 
			{
				System.Console.WriteLine("Please specify a output File using -out.");
				return true;
			}

			//build TXTR File
			ImageData id = new SimPe.Plugin.ImageData(null);

			if ((System.IO.File.Exists(Helper.WindowsRegistry.NvidiaDDSTool)) && ((format == ImageLoader.TxtrFormats.DXT1Format) || (format == ImageLoader.TxtrFormats.DXT3Format) || (format == ImageLoader.TxtrFormats.DXT5Format)))
			{
				LoadDDS(id, DDSTool.BuildDDS(filename, levels, format, "-sharpenMethod Smoothen"));
			} 
			else 
			{
				LoadTXTR(id, filename, sz, levels, format);
			}

			Rcol rcol = new GenericRcol(null, false);
			rcol.FileName = texturename;
			rcol.FileDescriptor = new SimPe.Packages.PackedFileDescriptor();
			rcol.Blocks = new IRcolBlock[1];
			rcol.Blocks[0] = id;

			rcol.SynchronizeUserData();
			System.IO.BinaryWriter bw = new System.IO.BinaryWriter(System.IO.File.Create(output));
			bw.Write(rcol.FileDescriptor.UserData);
			bw.Close();

			return true;
		}
		#endregion

		#region Import Data
		public static void ConvertData()
		{
			if (Helper.WindowsRegistry.PreviousVersion<=210590783739) 
			{
				string name = System.IO.Path.Combine(Helper.SimPeDataPath, "folders.xreg");
				if (System.IO.File.Exists(name)) 
				{
					if (Message.Show("In order to support the new Expansion \"Nightlife\", SimPE need to reset your FileTable.\nThis means, that SimPe will delete the File \""+name+"\".\n\nDo you want SimPe to reset your FileTable?", "Update", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
					{
						try 
						{						
							System.IO.File.Delete(name);
						} 
						catch (Exception ex)
						{
							Helper.ExceptionMessage(ex);
						}
					}
				}
			}
		}

		static void CheckXML(string file)
		{
			System.Xml.XmlDocument xmlfile = new System.Xml.XmlDocument();
						
			if (System.IO.File.Exists(file)) 
			{
				xmlfile.Load(file);
				System.Xml.XmlNodeList XMLData = xmlfile.GetElementsByTagName("registry");	
			}
		}

		public static void CheckFiles()
		{
			//check if the settings File is available
			string file = System.IO.Path.Combine(Helper.SimPeDataPath, @"simpe.xreg");
			try 
			{
				CheckXML(file);
			}
			catch
			{
				if (System.Windows.Forms.MessageBox.Show("The Settings File was not readable. SimPE will generate a new one, which means that all your Settings made in \"Extra->Preferences\" get lost.\n\nShould SimPe reset the Settings File?", "Error", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
					System.IO.File.Delete(file);
			}

			//check if the layout File is available
			file = System.IO.Path.Combine(Helper.SimPeDataPath, @"layout.xreg");
			try 
			{
				CheckXML(file);
			}
			catch
			{
				if (System.Windows.Forms.MessageBox.Show("The Layout File was not readable. SimPE will generate a new one, which means that your Window Layout will be reset to the Default.\n\nShould SimPe reset the Settings File?", "Error", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes)
					System.IO.File.Delete(file);
			}
		}

		public static void ImportOldData()
		{
			if (!System.IO.Directory.Exists(Helper.SimPeDataPath)) 
				System.IO.Directory.CreateDirectory(Helper.SimPeDataPath);

			if (!System.IO.File.Exists(System.IO.Path.Combine(Helper.SimPeDataPath, "simpe.xreg")))
			{
				if (System.IO.Directory.Exists(Helper.WindowsRegistry.PreviousDataFolder))
					if (Helper.WindowsRegistry.PreviousDataFolder.Trim().ToLower()!=Helper.SimPeDataPath.Trim().ToLower())
						if (Helper.SimPeVersionLong>Helper.WindowsRegistry.PreviousVersion && Helper.WindowsRegistry.PreviousVersion>0) 
						{
							if (Message.Show("Should SimPE import old Settings from \""+Helper.WindowsRegistry.PreviousDataFolder+"\"?", "Import Settings", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.Yes) 
							{
								WaitingScreen.Wait();
								try 
								{
									int ct = 0;
									string[] files = System.IO.Directory.GetFiles(Helper.WindowsRegistry.PreviousDataFolder, "*.*");
									foreach (string file in files) 
									{
										string newfile = file.Trim().ToLower().Replace(Helper.WindowsRegistry.PreviousDataFolder.Trim().ToLower(),Helper.SimPeDataPath.Trim()); 
										WaitingScreen.UpdateMessage((ct++).ToString()+" / "+files.Length);
										System.IO.File.Copy(file, newfile, true);
									}

									Helper.WindowsRegistry.Reload();
									ThemeManager.Global.CurrentTheme = (SimPe.GuiTheme)Helper.WindowsRegistry.Layout.SelectedTheme;
								} 
								catch (Exception ex) 
								{
									Helper.ExceptionMessage(new Warning("Unable to import Settings.", ex.Message, ex));
								}
								finally 
								{
									WaitingScreen.Stop();
								}
							}
						}
			}

			ConvertData();
		}
		#endregion
	}
}
