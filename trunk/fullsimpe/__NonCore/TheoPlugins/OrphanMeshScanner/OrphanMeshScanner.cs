using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using SimPe.Cache;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Scanner;
using SimPe.Interfaces.Scenegraph;
using SimPe.Plugin;
using SimPe.Plugin.Wrapper;
using SimPe.Plugin.Helper;

using System.Reflection;
using System.Runtime.CompilerServices;



[assembly: AssemblyTitle("Orphan Mesh Scanner")]
[assembly: AssemblyDescription("Orphan Mesh package scanner for SimPE's Scan Folder tool.")]
[assembly: AssemblyCopyright("This software is licensed under the GNU GPL license.")]
[assembly: AssemblyVersion("0.2.4.1")]


namespace SimPe.Plugin.Scanner
{
	
	public class OrphanMeshScanner : AbstractScanner, IScanner
	{
		Hashtable cresFiles = new Hashtable(); // Dictionary<ScannerItem, List<IPackedFileDescriptor>>();
		ArrayList propertySets = new ArrayList(); // List<OverlayInfo>();
		ArrayList materialOverrides = new ArrayList(); // List<MaterialOverrideInfo>();

		public OrphanMeshScanner() : base()
		{
		}

		public int Index
		{
			get { return 1000; }
		}

		public uint Version
		{
			get { return 1; }
		}

		public override bool IsActiveByDefault
		{
			get { return false; }
		}

		public override string ToString()
		{
			return "Orphan Mesh Scanner";
		}

		/// <summary>
		/// This method is invoked at the beginning of the scan process.
		/// Reset the GUID indexes.
		/// </summary>
		protected override void DoInitScan()
		{
			AbstractScanner.AddColumn(base.ListView, "Contains Mesh", 120);
			AbstractScanner.AddColumn(base.ListView, "Mesh References", 220);

			cresFiles.Clear();
			propertySets.Clear();
			materialOverrides.Clear();
		}


		/// <summary>
		/// This method is called for each package file.
		/// It searches for 3IDR and CRES files, but does not determine if they are related.
		/// The cross-referencing can only be done at the end of the scanning process, when
		/// all of the package files have been scanned.
		/// For now it just builds an index of the GUID's of the relevant files.
		/// </summary>
		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{
			ps.State = TriState.Null;
			ps.Info = "";

			if (si.PackageCacheItem.Enabled)
			{
				IPackageFile package = si.Package;

/*
 * Part I: Does this package contain a mesh?
 */
				IPackedFileDescriptor[] pfdCres = package.FindFiles(Utility.DataType.CRES);
				foreach (IPackedFileDescriptor pfd in pfdCres)
				{
					if (!this.cresFiles.ContainsKey(si))
						this.cresFiles.Add(si, new ArrayList()); //<IPackedFileDescriptor>());

					((ArrayList)this.cresFiles[si]).Add(pfd);

					// TODO: Localize string
					ps.Info = "yes"; //.State = TriState.True;
				}

/*
 * Part II: Is this package referencing a mesh?
 */
				IPackedFileDescriptor[] pfdGzps = package.FindFiles(Utility.DataType.GZPS);
				for (int i = 0; i < pfdGzps.Length; i++)
				{
					OverlayInfo info = new OverlayInfo();
					info.ProcessPackage(package, pfdGzps[i]);
					this.propertySets.Add(info);
				}

				IPackedFileDescriptor[] pfdXmol = package.FindFiles(Utility.DataType.XMOL);
				for (int i = 0; i < pfdXmol.Length; i++)
				{
					OverlayInfo info = new OverlayInfo();
					info.ProcessPackage(package, pfdXmol[i]);
					this.propertySets.Add(info);
				}

/*
				IPackedFileDescriptor[] pfdMmat = package.FindFiles(Utility.DataType.MMAT);
				for (int i = 0; i < pfdMmat.Length; i++)
				{
					MaterialOverrideInfo info = new MaterialOverrideInfo();
					info.ProcessPackage(package, pfdMmat[i]);
					this.materialOverrides.Add(info);
				}
*/

			}

			this.UpdateState(si, ps, lvi);
		}




		/// <summary>
		/// After the file indices have been built, this method will do all the cross-referencing
		/// to determine if a GMND item is by any means referenced by a 3IDR file.
		/// Finally, update the text of all the ListViewItem instances
		/// </summary>
		public void FinishScan()
		{
			this.ScanPropertySets();
			//this.ScanMaterials();

		}


		void ScanPropertySets()
		{
			for (int i = 0; i < this.propertySets.Count; i++)
			{
				if (WaitingScreen.Running)
					WaitingScreen.UpdateMessage(String.Format("Scanning Property Sets ({0}/{1})", i + 1, this.propertySets.Count));

				OverlayInfo pset = (OverlayInfo)this.propertySets[i];

				if (pset.ReferenceFile != null)
				{
					IPackedFileDescriptor idxItem = pset.ReferenceFile.Items[pset.ResourceKeyIndex];

					foreach (ScannerItem si in this.cresFiles.Keys)
					{
						ArrayList pfdCres = (ArrayList)this.cresFiles[si];

						for (int j = 0; j < pfdCres.Count; j++)
						{
							if (Utility.CompareDescriptor(idxItem, (IPackedFileDescriptor)pfdCres[j]))
								this.AddPropertySet(si, pset);

							if (pset.Type == CpfType.MeshOverlay)
							{
								IPackedFileDescriptor item2 = pset.ReferenceFile.Items[pset.MaskResourceKeyIndex];
								if (Utility.CompareDescriptor(item2, (IPackedFileDescriptor)pfdCres[j]))
									this.AddPropertySet(si, pset);
							}

						}

					}

				}

			}
			
		}
		
		

		void ScanMaterials()
		{
			for (int i = 0; i < this.materialOverrides.Count; i++)
			{
				if (WaitingScreen.Running)
					WaitingScreen.UpdateMessage(String.Format("Scanning Material Overrides ({0}/{1})", i + 1, this.materialOverrides.Count));

				MaterialOverrideInfo mmat = (MaterialOverrideInfo)this.materialOverrides[i];
				foreach (ScannerItem si in this.cresFiles.Keys)
				{
					ArrayList pfdCres = (ArrayList)this.cresFiles[si];
					for (int j = 0; j < pfdCres.Count; j++)
					{
						GenericRcol rcol = new GenericRcol();
						rcol.ProcessData((IPackedFileDescriptor)pfdCres[j], si.Package);

						string modelName = SimPe.Hashes.StripHashFromName(mmat.ModelName);
						if (modelName.Equals(rcol.FileName))
							this.AddPropertySet(si, mmat);
					}

				}

			}

		}
		

		void AddPropertySet(ScannerItem si, GenericCpfInfo pset)
		{
			int index = this.StartColum + 1;
			string filename = System.IO.Path.GetFileName(pset.Package.FileName);
			string text = si.ListViewItem.SubItems[index].Text;
			if (text.IndexOf(filename) == -1)
			{
				StringBuilder currentText = new StringBuilder(text);
				if (currentText.Length != 0)
					currentText.Append(", ");

				currentText.Append(filename);
				AbstractScanner.SetSubItem(si.ListViewItem, index, currentText.ToString());
			}

		}

		public void UpdateState(ScannerItem si, PackageState ps, ListViewItem lvi)
		{
			string text = ps.Info;

			AbstractScanner.SetSubItem(lvi, this.StartColum, text);
			AbstractScanner.SetSubItem(lvi, this.StartColum + 1, "");
		}


	}


}
