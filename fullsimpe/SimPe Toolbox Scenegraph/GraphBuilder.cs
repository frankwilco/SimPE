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
using System.Drawing;
using SimPe.Interfaces;
using Ambertation.Graph;

namespace SimPe.Plugin
{
	/// <summary>
	/// Creates a visual representation of the SceneGraph
	/// </summary>
	public class GraphBuilder
	{
		Hashtable colors;
		GraphControl gc;
		System.EventHandler click;

		/// <summary>
		/// tracks the left coordinates for each top coordinate (key)
		/// </summary>
		Hashtable coords;

		/// <summary>
		/// Keeps the names of all added Files
		/// </summary>
		Hashtable names;


		/// <summary>
		/// Create a new instance an prepare the some Datatypes
		/// </summary>
		/// <param name="pb"></param>
		/// <param name="click"></param>
		public GraphBuilder (System.Windows.Forms.PictureBox pb, System.EventHandler click) 
		{
			colors = new Hashtable();
			names = new Hashtable();

			colors.Add("CRES", Color.RoyalBlue);
			colors.Add("SHPE", Color.GreenYellow);
			colors.Add("GMND", Color.Yellow);
			colors.Add("GMDC", Color.Thistle);
			colors.Add("TXMT", Color.Orange);
			colors.Add("TXTR", Color.MediumVioletRed);
			colors.Add("LIFO", Color.PaleVioletRed);
			colors.Add("LGHT", Color.White);

			gc = new GraphControl(pb);
			this.click = click;

			coords = new Hashtable();
		}

		SimPe.Interfaces.Scenegraph.IScenegraphItem BuildRcol(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg, GraphItem gi)
		{
			GenericRcol rcol = new GenericRcol(null, false);
			rcol.ProcessData(pfd, pkg);

			gi.Caption = Hashes.StripHashFromName(rcol.FileName);
			gi.Tag = rcol;

			if (pfd.Type == Data.MetaData.TXTR) 
			{
				ImageData id = (ImageData)rcol.Blocks[0];
				gi.Size = new Size(gi.Size.Width, 80);
				gi.Thumbnail = ImageLoader.Preview(id.LargestTexture.Texture, new Size(48, 48));
			}
			return rcol;
		}

		SimPe.Interfaces.Scenegraph.IScenegraphItem BuildMmat(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg, GraphItem gi)
		{
			SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
			mmat.ProcessData(pfd, pkg);

			gi.Caption = mmat.GetSaveItem("subsetName").StringValue +" (family="+mmat.GetSaveItem("family").StringValue+", objectStateIndex="+Helper.HexString(mmat.GetSaveItem("objectStateIndex").UIntegerValue)+", materialStateFlags="+Helper.HexString(mmat.GetSaveItem("materialStateFlags").UIntegerValue)+", objectGuid="+Helper.HexString(mmat.GetSaveItem("objectGUID").UIntegerValue)+")";
			gi.Properties["Default"] = mmat.GetSaveItem("defaultMaterial").BooleanValue.ToString();
			gi.Properties["cres"] = mmat.GetSaveItem("modelName").StringValue.ToString();
			gi.Properties["txmt"] = mmat.GetSaveItem("name").StringValue.ToString();

			gi.Size = new Size(gi.Size.Width, 96);
			gi.Tag = mmat;
			return mmat;
		}

		void AddItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg, GraphItem parent, SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fileindex)
		{
			#region Default Setup
			int top = -128;			
			int left = 0;

			if (parent!=null) top = parent.Location.Y;
			do 
			{				
				top += 128;				
				if (coords.ContainsKey(top)) left = (int)coords[top];
				if (parent!=null) if (left<parent.Location.X) left = parent.Location.X;
			} while (left>gc.Parent.Width);

			GraphItem gi = new GraphItem(gc, Hashes.StripHashFromName(pfd.Filename), new Hashtable());
			gi.BeginUpdate();
			gi.Location = new Point(left, top);
			gi.Click = click;
			gi.Tag = Hashes.StripHashFromName(pfd.Filename);
			gi.LinkColor = Color.FromArgb(35, Color.Black);
			gi.SelectedLinkColor = Color.FromArgb(0xff, Color.DarkBlue);

			SimPe.Data.TypeAlias ta = Data.MetaData.FindTypeAlias(pfd.Type);
			gi.Properties["Type"] = ta.shortname;
			gi.Properties["Available"] = "false";
			#endregion			
			
			//check if we already have a reource of that kind
			string name = gi.Caption.Trim().ToLower();
			if (names.ContainsKey(name)) 
			{
				gi.EndUpdate();
				gi = (GraphItem)names[name]; 

				if (parent!=null) parent.AddChild(gi);
			} 
			else 
			{

				#region find File
				SimPe.Interfaces.Scenegraph.IScenegraphItem item = null;
				SimPe.Interfaces.Files.IPackedFileDescriptor pkgpfd = pkg.FindFile(pfd);

				//not found in the passed package, look for a global File with that Name
				if (pkgpfd==null) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem items = FileTable.FileIndex.FindFileByName(pfd.Filename, pfd.Type, pfd.Group, true);
					if (items!=null) 
					{
						gi.Properties["Available"] = "extern";
						gi.Properties["File"] = items.Package.FileName;
						gi.Size = new Size(gi.Size.Width, 70);
						gi.BackgroundColor = Color.Black;
					}
				}
				#endregion

				//the file is available, so add it
				if (pkgpfd!=null) 
				{
					gi.Properties["Available"] = "true";
					if (colors.ContainsKey(ta.shortname))gi.BackgroundColor = (Color)colors[ta.shortname];

					if (Data.MetaData.RcolList.Contains(pfd.Type)) item = BuildRcol(pkgpfd, pkg, gi);
					else if (pfd.Type==Data.MetaData.MMAT) item = BuildMmat(pkgpfd, pkg, gi);	
					/*} 
					else 
					{
						if (Data.MetaData.RcolList.Contains(pfd.Type)) item = BuildRcol(pkgpfd, altpkg, gi);
						else if (pfd.Type==Data.MetaData.MMAT) item = BuildMmat(pkgpfd, altpkg, gi);
					}*/
			
					//check again if we still don't have that file
					name = gi.Caption.Trim().ToLower();
					if (names.ContainsKey(name)) 
					{
						gi.EndUpdate();
						gi = (GraphItem)names[name];
					}
					else 
					{
											

						//now process the Reference Files
						if (item!=null) 
						{
							Hashtable ht = item.ReferenceChains;
							foreach (ArrayList list in ht.Values)
								foreach (SimPe.Interfaces.Files.IPackedFileDescriptor spfd in list) 
								{
									AddItem(spfd, pkg, gi, fileindex);
								}
						}
					}
				} 

				if (!names.ContainsKey(name)) 
				{
					names.Add(name, gi);	
					gc.Add(gi);
					coords[top] = left + 8 + gi.Size.Width;		
								
					if (pkgpfd==null) 
					{
						gi.BackgroundColor = Color.DarkRed;
						gi.ForegroundColor = Color.White;

						if ((string)gi.Properties["Available"]=="extern") gi.BackgroundColor = Color.Black;
					}
				}
				

				if (parent!=null) parent.AddChild(gi);
			}
			
			gi.EndUpdate();			
		}

		/// <summary>
		/// Show the Graph
		/// </summary>
		/// <param name="pkg"></param>
		/// <param name="fileindex"></param>
		/// <remarks>Do not run twice</remarks>
		public void BuildGraph(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fileindex) 
		{

			WaitingScreen.UpdateMessage("Scaning MMAT Tree");
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.MMAT);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				AddItem(pfd, pkg, null, fileindex);
			}

			WaitingScreen.UpdateMessage("Scaning CRES Tree");
			pfds = pkg.FindFiles(Data.MetaData.CRES);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				AddItem(pfd, pkg, null, fileindex);
			}			

			gc.Update();
		}

		/// <summary>
		/// Adds all Orphants to the Tree
		/// </summary>
		/// <param name="pkg"></param>
		public void FindUnused(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			int top = 0;
			int left = 0;
			foreach (int t in coords.Keys) if (t>top) top=t;

			top += 128;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
			{
				if ((pfd.Type == Data.MetaData.MMAT) || (Data.MetaData.RcolList.Contains(pfd.Type)))
				{
					GraphItem gi = new GraphItem(gc, Hashes.StripHashFromName(pfd.Filename), new Hashtable());
					gi.BeginUpdate();
					gi.Location = new Point(left, top);
					gi.Click = click;
					gi.Tag = Hashes.StripHashFromName(pfd.Filename);
					gi.LinkColor = Color.FromArgb(35, Color.Black);
					gi.SelectedLinkColor = Color.FromArgb(0xff, Color.DarkBlue);

					SimPe.Data.TypeAlias ta = Data.MetaData.FindTypeAlias(pfd.Type);
					gi.Properties["Type"] = ta.shortname;
					gi.Properties["Available"] = "true (orphan)";
					if (colors.ContainsKey(ta.shortname)) gi.BackgroundColor = (Color)colors[ta.shortname];

					SimPe.Interfaces.Scenegraph.IScenegraphItem item = null;
					if (Data.MetaData.RcolList.Contains(pfd.Type)) item = BuildRcol(pfd, pkg, gi);
					else if (pfd.Type==Data.MetaData.MMAT) item = BuildMmat(pfd, pkg, gi);

					if (item!=null) 
					{
						string name = gi.Caption.Trim().ToLower();
						if (!names.ContainsKey(name)) 
						{
							gc.Add(gi);							
							left += gi.Size.Width + 8;
							gi.EndUpdate();
						}
					}

					

				}
			}

			gc.Update();
		}
	}
}