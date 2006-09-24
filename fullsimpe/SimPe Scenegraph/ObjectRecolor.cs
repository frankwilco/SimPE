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
using System.Collections;
using SimPe.Packages;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// ZOffers some Recolor Methods for Packages
	/// </summary>
	public class ObjectRecolor
	{
		/// <summary>
		/// The Base Package
		/// </summary>
		IPackageFile package;

		/// <summary>
		/// The Base Package
		/// </summary>
		public IPackageFile Package
		{
			get { return package; }
		}

		SimPe.Packages.GeneratableFile dn_pkg;
		public IPackageFile GMNDPackage
		{
			get { return dn_pkg; }
		}

		SimPe.Packages.GeneratableFile gm_pkg;
		public IPackageFile MMATPackage
		{
			get { return gm_pkg; }
		}

		/// <summary>
		/// Creates a new Isntance
		/// </summary>
		/// <param name="package">The Object you want to Recolor</param>
		public ObjectRecolor(IPackageFile package) 
		{
			this.package = package;

			if (System.IO.File.Exists(ScenegraphHelper.GMND_PACKAGE)) dn_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.GMND_PACKAGE);
			else 
			{
				dn_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
				dn_pkg.FileName = ScenegraphHelper.GMND_PACKAGE;
			}

			if (System.IO.File.Exists(ScenegraphHelper.MMAT_PACKAGE)) gm_pkg = SimPe.Packages.GeneratableFile.LoadFromFile(ScenegraphHelper.MMAT_PACKAGE);
			else 
			{
				gm_pkg = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
				gm_pkg.FileName = ScenegraphHelper.MMAT_PACKAGE;
			}
		}

		/// <summary>
		/// Chnages materialStateFlags and objectStateIndex according to the MaTD Reference Name
		/// </summary>
		/// <param name="mmat">The MMAT File to change the values in</param>
		public static void FixMMAT(SimPe.PackedFiles.Wrapper.Cpf mmat) 
		{
			string name = mmat.GetSaveItem("name").StringValue;
			if (name.EndsWith("_clean")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 0;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 0;
			} 
			else if (name.EndsWith("_dirty")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 2;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 1;
			}
			else if (name.EndsWith("_lit")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 1;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 3;
			}
			else if (name.EndsWith("_unlit")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 0;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 4;
			}
			else if (name.EndsWith("_on")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 2;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 6;
			}
			else if (name.EndsWith("_off")) 
			{
				mmat.GetSaveItem("materialStateFlags").UIntegerValue = 0;
				mmat.GetSaveItem("objectStateIndex").IntegerValue = 5;
			}
		}

		/// <summary>
		/// Returns a list of all GMNDs that need a tsDesignMode Block
		/// </summary>
		/// <returns>List of GMNDs</returns>
		/// <remarks>Will return an empty List if the Block is found in at least one of the GMNDs</remarks>
		protected SimPe.Plugin.Rcol[] GetGeometryNodes() 
		{
			ArrayList list = new ArrayList();
			Interfaces.Files.IPackedFileDescriptor[] pfds = this.package.FindFiles(0x7BA3838C);
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol gmnd = new GenericRcol(null, false);
				gmnd.ProcessData(pfd, package);
				foreach (IRcolBlock rb in gmnd.Blocks) 
				{
					if (rb.BlockName=="cDataListExtension") 
					{
						DataListExtension dle = (DataListExtension)rb;
						//if (dle.Extension.VarName.Trim().ToLower()=="tsnoshadow") list.Add(gmnd);
						if (dle.Extension.VarName.Trim().ToLower()=="tsdesignmodeenabled") return new Rcol[0];
					}					
				}
				list.Add(gmnd);
			}

			SimPe.Plugin.Rcol[] rcols = new Rcol[list.Count];
			list.CopyTo(rcols);
			return rcols;
		}

		/// <summary>
		/// Returns a List of all objects that Refer to the passed GMND
		/// </summary>
		/// <param name="gmnd">a GMND</param>
		/// <returns>List of SHPEs</returns>
		protected SimPe.Plugin.Rcol[] GetReferingShape(SimPe.Plugin.Rcol gmnd)
		{
			ArrayList list = new ArrayList();
			Interfaces.Files.IPackedFileDescriptor[] pfds = this.package.FindFiles(0xFC6EB1F7);
			
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol shpe = new GenericRcol(null, false);
				shpe.ProcessData(pfd, package);
				SimPe.Plugin.Shape sh = (SimPe.Plugin.Shape)shpe.Blocks[0];

				foreach (SimPe.Plugin.ShapeItem item in sh.Items) 
				{
					if (item.FileName.Trim().ToLower()==gmnd.FileName.Trim().ToLower()) 
					{
						list.Add(shpe);
						break;
					}
				}
			}

			SimPe.Plugin.Rcol[] rcols = new Rcol[list.Count];
			list.CopyTo(rcols);
			return rcols;
		}

		/// <summary>
		/// Adss a DesignMode Block and returns it
		/// </summary>
		/// <param name="gmnd"></param>
		/// <param name="dle"></param>
		protected void AddDesignModeBlock(SimPe.Plugin.Rcol gmnd, DataListExtension dle)
		{
			dle.Extension.VarName = "tsDesignModeEnabled";

			/*IRcolBlock[] newblock = new IRcolBlock[gmnd.Blocks.Length+1];
			for (int i=0; i<gmnd.Blocks.Length; i++) 
			{
				if (i==0) newblock[i] = gmnd.Blocks[i];
				else newblock[i+1] = gmnd.Blocks[i];
			}
			newblock[1] = dle;
			gmnd.Blocks = newblock;*/

			
			SimPe.Plugin.GeometryNode gn = (SimPe.Plugin.GeometryNode)gmnd.Blocks[0];
			
			ObjectGraphNodeItem item = new ObjectGraphNodeItem();
			item.Enabled = 0x01;
			item.Dependant = 0x00;
			item.Index = (uint)gmnd.Blocks.Length;

			gn.ObjectGraphNode.Items = (ObjectGraphNodeItem[])Helper.Add(gn.ObjectGraphNode.Items, item);
			gmnd.Blocks = (IRcolBlock[])Helper.Add(gmnd.Blocks, dle, typeof(IRcolBlock));
		}

		/// <summary>
		/// ind the ResourceNode that is referencing the passed Shape
		/// </summary>
		/// <param name="shpe"></param>
		/// <returns></returns>
		protected SimPe.Plugin.Rcol FindResourceNode(SimPe.Plugin.Rcol shpe) 
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0xE519C933);
			Interfaces.Files.IPackedFileDescriptor pfd = shpe.FileDescriptor;

			foreach(Interfaces.Files.IPackedFileDescriptor cpfd in pfds)
			{
				SimPe.Plugin.Rcol cres = new GenericRcol(null, false);
				cres.ProcessData(cpfd, package);

				foreach (Interfaces.Files.IPackedFileDescriptor rpfd in cres.ReferencedFiles) 
				{
					if ((rpfd.Group == pfd.Group) && (rpfd.Instance == pfd.Instance) && (rpfd.SubType == pfd.SubType) && (rpfd.Type == pfd.Type)) 
					{
						return cres;
					}
				}
			}

			return new GenericRcol(null, false);
		}

		

		/// <summary>
		/// adds the subsets to the tsDesignMode.. Block and returns a List of all added Subsets
		/// </summary>
		/// <param name="shpes"></param>
		/// <param name="gmnd"></param>
		/// <param name="subsets"></param>
		protected void GetSubsets(SimPe.Plugin.Rcol[] shpes, SimPe.Plugin.Rcol gmnd, ArrayList subsets) 
		{
			ArrayList list = new ArrayList();
			ArrayList localsubsets = new ArrayList();
			DataListExtension dle = new DataListExtension(gmnd);
			uint index = (uint)(gm_pkg.FindFiles(0x4C697E5A).Length+1);
			
			foreach (SimPe.Plugin.Rcol shpe in shpes) 
			{
				SimPe.Plugin.Shape sh = (SimPe.Plugin.Shape)shpe.Blocks[0];
				SimPe.Plugin.Rcol cres = FindResourceNode(shpe);

				foreach (SimPe.Plugin.ShapePart part in sh.Parts) 
				{
					if (subsets.Contains(part.Subset)) continue;
					if (localsubsets.Contains(part.Subset)) continue;

					//Read the MATD
					Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(part.FileName+"_txmt", 0x49596978);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
					{
						SimPe.Plugin.Rcol matd = new GenericRcol(null, false);
						matd.ProcessData(pfd, package);
						SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)matd.Blocks[0];

						//check that the Material is not transparent
						if (md.GetProperty("stdMatAlphaBlendMode").Value=="none") 
						{
							//check that the Material references a texture
							if (package.FindFile(md.GetProperty("stdMatBaseTextureName").Value+"_txtr", 0x1C4A276C).Length>0) 
							{
								localsubsets.Add(part.Subset);

								SimPe.Plugin.ExtensionItem ei = new ExtensionItem();
								ei.Name = part.Subset;
								ei.Typecode = ExtensionItem.ItemTypes.Array;
 
								WorkshopMMAT i = new WorkshopMMAT(part.Subset);
								object[] tag = new object[3];
								tag[0] = matd;
								tag[1] = cres.FileName;
								tag[2] = ei;
								i.Tag = tag;

								//if (md.GetProperty("stdMatAlphaBlendMode").Value!="none") i.AddObjectStateIndex(1);
								list.Add(i);
								//dle.Extension.Items = (ExtensionItem[])Helper.Add(dle.Extension.Items, ei);
								//AddMMAT(matd, part.Type, cres.FileName, index++);
							}
						}
					}
				}	
			}

			WorkshopMMAT[] mmats = new WorkshopMMAT[list.Count];
			list.CopyTo(mmats);

			Listing li = new Listing();
			if (mmats.Length>0) mmats = li.Execute(mmats);

			foreach (WorkshopMMAT mmat in mmats) 
			{
				subsets.Add(mmat.Subset);
				dle.Extension.Items = (ExtensionItem[])Helper.Add(dle.Extension.Items, (ExtensionItem)mmat.Tag[2]);
				AddMMAT((SimPe.Plugin.Rcol)mmat.Tag[0], mmat.Subset, (string)mmat.Tag[1], index++, false);
			}

			if (dle.Extension.Items.Length>0) 
			{
				AddDesignModeBlock(gmnd, dle);
				gmnd.SynchronizeUserData();
				dn_pkg.Add(gmnd.FileDescriptor);
			}
		}

		/// <summary>
		/// Add a MMAT to the package
		/// </summary>
		protected SimPe.PackedFiles.Wrapper.Cpf AddMMAT(SimPe.Plugin.Rcol matd, string subset, string cresname, uint instance, bool substate)
		{
			//now add the default MMAT
			System.IO.BinaryReader br = new System.IO.BinaryReader(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.mmat.simpe"));
			SimPe.Packages.PackedFileDescriptor pfd1 = new SimPe.Packages.PackedFileDescriptor();
			pfd1.Group = 0xffffffff; pfd1.SubType = 0x00000000; pfd1.Instance = instance; pfd1.Type = 0x4C697E5A; //MMAT
			pfd1.UserData = br.ReadBytes((int)br.BaseStream.Length);

			package.Add(pfd1);
			SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
			mmat.ProcessData(pfd1, package);

			if (!substate) mmat.GetSaveItem("family").StringValue = System.Guid.NewGuid().ToString();
			mmat.GetSaveItem("name").StringValue = matd.FileName.Substring(0, matd.FileName.Length-5);
			mmat.GetSaveItem("subsetName").StringValue = subset;
			mmat.GetSaveItem("modelName").StringValue = cresname;

			//Get the GUID
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			mmat.GetSaveItem("objectGUID").UIntegerValue = 0x00000000;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfds[0], package);
				mmat.GetSaveItem("objectGUID").UIntegerValue = objd.SimId;

				if (pfd.Instance == 0x000041A7) break;
			} 

			ObjectRecolor.FixMMAT(mmat);
			mmat.SynchronizeUserData();

			gm_pkg.Add(mmat.FileDescriptor);

			//alternate states
			if (!substate) 
			{
				string name = mmat.GetSaveItem("name").StringValue;
				pfds = ObjectCloner.FindStateMatchingMatd(name, package);
			

				if (pfds!=null) if (pfds.Length>0) 
								{
									SimPe.Plugin.Rcol submatd = new GenericRcol(null, false);
									submatd.ProcessData(pfds[0], package);

									SimPe.PackedFiles.Wrapper.Cpf mmat2 = AddMMAT(submatd, subset, cresname, instance, true);
									mmat2.GetSaveItem("family").StringValue = mmat.GetSaveItem("family").StringValue;
								}
			}

			return mmat;
		}

		/// <summary>
		/// Enables the Color Options for this Object
		/// </summary>
		public void EnableColorOptions()
		{
			SimPe.Plugin.Rcol[] gmnds = this.GetGeometryNodes();
			
			ArrayList subsets = new ArrayList();
			foreach (SimPe.Plugin.Rcol gmnd in gmnds) 
			{
				SimPe.Plugin.Rcol[] shpes = this.GetReferingShape(gmnd);
				this.GetSubsets(shpes, gmnd, subsets);
			}

			dn_pkg.Save();
			gm_pkg.Save();
		}

		/// <summary>
		/// Add the MATD referenced by the passed MMAT 
		/// </summary>
		/// <param name="mmat">A valid MMAT file</param>
		protected void AddMATD(SimPe.PackedFiles.Wrapper.Cpf mmat)
		{
			SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile( System.IO.Path.Combine(PathProvider.Global.GetExpansion(Expansions.BaseGame).InstallFolder, "TSData\\Res\\Sims3D\\Objects02.package"));
			ArrayList list = new ArrayList();
			string flname = Hashes.StripHashFromName(mmat.GetSaveItem("name").StringValue) + "_txmt";
			Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFile(flname, 0x49596978);

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol matd = new GenericRcol(null, false);
				matd.ProcessData(pfd, pkg);
				
				if (matd.FileName.Trim().ToLower() == flname.Trim().ToLower()) 
				{
					matd.SynchronizeUserData();
					if (package.FindFile(matd.FileDescriptor)==null)
					{
						package.Add(matd.FileDescriptor);
					}
				}
			}

			//pkg.Reader.Close();
		}

		/// <summary>
		/// Load all MATDs referenced by the passed MMATs
		/// </summary>
		/// <param name="pfds">List of MMAT Descriptors from the current Package</param>
		protected void LoadReferencedMATDs(Interfaces.Files.IPackedFileDescriptor[] pfds)
		{
			//WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Loading Material Overrides");
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
				mmat.ProcessData(pfd, package);
				AddMATD(mmat);
			}
			//WaitingScreen.Stop();
		}

		/// <summary>
		/// Load all MATDs referenced by the MMATs in the package
		/// </summary>
		public void LoadReferencedMATDs() 
		{
			this.LoadReferencedMATDs(package.FindFiles(0x4C697E5A));
		}
	}
}
