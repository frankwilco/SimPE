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
using System.Globalization;
using System.Collections;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Implement this abstract class to create a new Gmdc Importer Plugin, however 
	/// you can also base your new Importer on <see cref="GmdcImporterBase"/>, which 
	/// offers a more simple Interface, as you only have to implement the
	/// reading of the vertice, normals... Data
	/// </summary>
	/// <remarks>
	/// SimPE offers diffrent Importer Abstraction classes. The most common 
	/// one is AbstractGmdcImporter. It is used whenever you just want to 
	/// import/overwrite Mesh Groups (vertext data...) but want to leave the 
	/// rest of the Gmdc File alone.
	/// 
	/// However, if you want to create a complete new (or altered) gmdc File
	/// you need to implement the IGmdcReplacementImporter.	
	/// </remarks>
	public abstract class AbstractGmdcImporter : IGmdcImporter
	{				
		/// <summary>
		/// Returns the Culture that should be used during the Import
		/// </summary>
		/// <remarks>The Culure is needed whenever you read floatingpoint 
		/// Values from a Text File</remarks>
		public static CultureInfo DefaultCulture 
		{			
			get 
			{
				return AbstractGmdcExporter.DefaultCulture;
			}
		}

		/// <summary>
		/// Good Objects should not have more than this number of Faces
		/// </summary>
		public const int CRITICAL_FACE_AMOUNT = 10000;

		/// <summary>
		/// Good Objects should not have more than this number of Vertices
		/// </summary>
		public const int CRITICAL_VERTEX_AMOUNT = CRITICAL_FACE_AMOUNT;

		/// <summary>
		/// Returns a Version Number for the used Interface
		/// </summary>
		public int Version 
		{
			get { return 1; }
		}

		#region abstract Methods
		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		public abstract string FileExtension
		{
			get;
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		public abstract string FileDescription
		{
			get;
		}

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		public abstract string Author
		{
			get;
		}

		/// <summary>
		/// This Method is called during the Import to process the input Data and 
		/// generate a vaild Groups ArrayList.
		/// </summary>
		/// <returns>A List of all available Groups</returns>
		/// <remarks>You can use the <see cref="Input"/> and <see cref="Gmdc"/> Member to acces the Stream and 
		/// the Gmdc File that should be changed</remarks>
		protected abstract ImportedGroups LoadGroups();

		/// <summary>
		/// This Method is called during the Import to process the input Data and 
		/// showl generate a List of all Joints that should be Imported.
		/// </summary>
		/// <returns>A List of all available Joints</returns>
		/// <remarks>You can use the <see cref="Input"/> and <see cref="Gmdc"/> Member to acces the Stream and 
		/// the Gmdc File that should be changed. This Method is allways called AFTER <see cref="LoadGroups"/>.</remarks>
		protected virtual ImportedBones LoadBones() 
		{
			return new ImportedBones();
		}
		#endregion

		/// <summary>
		/// stores the Error Message that should be presented
		/// </summary>
		protected string error;

		/// <summary>
		/// Returns the Error Message Produced by the Last Parsing attempt
		/// </summary>
		public string ErrorMessage
		{
			get { return error; }
		}
	
		System.IO.StreamReader input;
		/// <summary>
		/// The current Input (when LoadGroups() or ChangeGmdc() is called, this is never null)
		/// </summary>
		protected System.IO.StreamReader Input 
		{
			get { return input; }
		}

		GeometryDataContainer gmdc;
		/// <summary>
		/// The Gmdc that should be changed (when LoadGroups() or ChangeGmdc() is called, this is never null)
		/// </summary>
		protected GeometryDataContainer Gmdc 
		{
			get { return gmdc; }
		}

		/// <summary>
		/// Process the Data stored in the passed Stream, and change/replace the passed Gmdc
		/// </summary>
		/// <param name="input">A Stream with the Input Data</param>
		/// <param name="gmdc">The Gmdc that should receive the Data</param>
		public virtual void Process(System.IO.Stream input, GeometryDataContainer gmdc)
		{
			this.input = new System.IO.StreamReader(input);
			this.gmdc = gmdc;

			if (gmdc==null || input==null) return;

			ImportedGroups g = LoadGroups();
			ImportedBones b = LoadBones();
			if (ValidateImportedGroups(g, b)) ChangeGmdc(g, b);
		}

		ImportOptions importoptionsresult;
		/// <summary>
		/// Returns Global Import Options
		/// </summary>
		/// <remarks>
		/// This Member is usually set in the <see cref="ValidateImportedGroups"/> Method
		/// </remarks>
		protected ImportOptions Options 
		{
			get 
			{
				if (importoptionsresult==null) importoptionsresult = new ImportOptions(System.Windows.Forms.DialogResult.Cancel, false, false);
				return importoptionsresult;
			}
			set 
			{
				importoptionsresult = value;
			}
		}

		/// <summary>
		/// This is called after the Groups were Imported to validate the Content
		/// </summary>
		/// <param name="grps">The imported Groups</param>
		/// <param name="bns">The imported Joints</param>
		/// <returns>true, if the Import should be continued</returns>
		/// <remarks>This Implementation will show the ImportGmdcGroups Dialog to 
		/// let the User validate the Content. Override this Method, if you want a 
		/// diffrent Import Dialog</remarks>
		protected virtual bool ValidateImportedGroups(ImportedGroups grps, ImportedBones bns)
		{
			foreach (ImportedGroup g in grps) 
			{
				//add all populated Element Lists
				for (int k=0; k<g.Elements.Count; k++) 
				{
					g.Elements[k].Number = g.Elements[k].Values.Count;
					if (g.Elements[k].Values.Length>0)  g.Link.ReferencedElement.Add(k);					
				} // for k
				//if (minct==int.MaxValue) minct=0;							
			}

			importoptionsresult = ImportGmdcGroupsForm.Execute(gmdc, grps, bns);
			return importoptionsresult.Result == System.Windows.Forms.DialogResult.OK;
		}

		
		/// <summary>
		/// This Method is called when the Imported Data should be written to the 
		/// passed Gmdc File
		/// </summary>
		/// <param name="grps">The imported Groups</param>
		/// <param name="bns">The imported Joints</param>
		/// <remarks>
		/// Override This Method if you want a diffrent Behaviour when writing the Data
		/// to the Gmdc. Override AddGroup(), ReplaceGroup() or RenameGroup() if you just 
		/// want to alter a specific Behaviuour.
		/// </remarks>
		protected virtual void ChangeGmdc(ImportedGroups grps, ImportedBones bns)
		{
			//remove all existing Groups and Elements
			if (this.Options.CleanGroups) 
			{
				for (int i=Gmdc.Groups.Length-1; i>=0; i--) Gmdc.RemoveGroup(i);
			}

			//Add the Joints
			Hashtable boneIndexMap = new Hashtable(); 
			for (int i=0; i<bns.Length; i++)
			{
				ImportedBone b = bns[i];
				if (b.Action == GmdcImporterAction.Add) boneIndexMap[i] = AddBone(grps, b, i);
				else if (b.Action == GmdcImporterAction.Rename) boneIndexMap[i] = AddBone(grps, b, i);
				else if (b.Action == GmdcImporterAction.Replace) boneIndexMap[i] = ReplaceBone(grps, b, i);
				else if (b.Action == GmdcImporterAction.Update) boneIndexMap[i] = UpdateBone(grps, b, i);
				else boneIndexMap[i] = NothingBone(grps, b, i);

				//make sure the Target Index is set correct, and the parrent is set up
				b.TargetIndex = (int)boneIndexMap[i];
				b.Bone.Parent = Gmdc;
			}

			//Update the Boned Indices
			foreach (ImportedGroup g in grps)
			{
				for(int i=0; i<g.Group.UsedJoints.Length; i++) 
				{
					int index = g.Group.UsedJoints[i];
					if (boneIndexMap.ContainsKey(index)) g.Group.UsedJoints[i] = (int)boneIndexMap[index];				
				}
			}

			//Add the Groups
			foreach (ImportedGroup g in grps) 
			{
				if (g.Action == GmdcImporterAction.Add) AddGroup(g);
				else if (g.Action == GmdcImporterAction.Rename) RenameGroup(g);
				else if (g.Action == GmdcImporterAction.Replace) ReplaceGroup(g);
				else if (g.Action == GmdcImporterAction.Update) UpdateGroup(g);
			}	
		
			//Make sure the Elements are assigned to the correct Bones
			for (int i=0; i<bns.Length; i++)
			{
				ImportedBone b = bns[i];
				if (b.Action == GmdcImporterAction.Add || b.Action == GmdcImporterAction.Rename || b.Action == GmdcImporterAction.Replace) 
				{
					b.Bone.CollectVertices();
				}				
			}
			if (this.Options.CleanBones) Gmdc.CleanupBones();
		}

		#region Mesh
		/// <summary>
		/// Add the passed Group to the Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void AddGroup(ImportedGroup g)
		{			
			for (int i=0; i<g.Link.ReferencedElement.Count; i++) 
			{
				GmdcElement e = g.Elements[g.Link.ReferencedElement[i]];
				//foreach (GmdcElementValueBase evb in e.Values) evb *= g.Scale;

				gmdc.Elements.Add(e);
				g.Link.ReferencedElement[i] = gmdc.Elements.Length-1;				
			}
			g.Group.LinkIndex = gmdc.Links.Length;
			gmdc.Links.Add(g.Link);
			gmdc.Groups.Add(g.Group);

			g.Link.ReferencedSize = g.Link.GetReferencedSize();
			g.Link.ActiveElements = g.Link.ReferencedElement.Count;
		}

		

		/// <summary>
		/// Replace an existing Group with  the passed Group in the current Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void ReplaceGroup(ImportedGroup g)
		{
			int index = Gmdc.FindGroupByName(g.TargetName);
			if (index>=0) gmdc.RemoveGroup(index);
			RenameGroup(g);
		}

		/// <summary>
		/// RUpdate an existing Group with  the passed Group in the current Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void UpdateGroup(ImportedGroup g)
		{
			int index = Gmdc.FindGroupByName(g.TargetName);

			GmdcGroup grp = Gmdc.Groups[index];
			GmdcLink lnk = Gmdc.Links[grp.LinkIndex];

			g.Group.LinkIndex = grp.LinkIndex;
			

			for (int i=0; i<g.Link.ReferencedElement.Count; i++) 
			{
				GmdcElement e = g.Elements[g.Link.ReferencedElement[i]];
				//foreach (GmdcElementValueBase evb in e.Values) evb *= g.Scale;
				GmdcElement old = lnk.FindElementType(e.Identity);

				//found an existing Element?
				if (old == null) 
				{
					gmdc.Elements.Add(e);
					lnk.ReferencedElement.Add(gmdc.Elements.Length-1);					
				} 
				else 
				{
					int id = lnk.GetElementNr(old);					
					Gmdc.Elements[lnk.ReferencedElement[id]] = e;
				}
			}

			Gmdc.Groups[index] = g.Group;
			lnk.ReferencedSize = lnk.GetReferencedSize();
			lnk.ActiveElements = lnk.ReferencedElement.Count;	
		}

		/// <summary>
		/// set the Name of the Group to a diffrent Value and Add it to the Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void RenameGroup(ImportedGroup g)
		{
			g.Group.Name = g.TargetName;
			AddGroup(g);
		}
		#endregion

		#region Bone
		/// <summary>
		/// Add the passed Bone to the Gmdc and Fix the UseBone Indices to apropriate Values
		/// </summary>
		/// <param name="grps">List of all Imported Groups (needed to fix the UseBone Indices)</param>
		/// <param name="b"></param>
		/// <param name="index">The Number of the Bone that should be added</param>
		/// <returns>the real Bone Index</returns>
		protected virtual int AddBone(ImportedGroups grps, ImportedBone b, int index)
		{			
			int nindex = gmdc.Joints.Length;
			gmdc.Joints.Add(b.Bone);
			gmdc.Model.Quaternions.Add(b.Quaternion);
			gmdc.Model.Transformations.Add(b.Translation);			

			return nindex;
		}

		/// <summary>
		/// Replace an exiting bone with the passed one
		/// </summary>
		/// <param name="grps">List of all Imported Groups (needed to fix the UseBone Indices)</param>
		/// <param name="b"></param>
		/// <param name="index">The Number of the Bone that should be added</param>
		/// <returns>the real Bone Index</returns>
		protected virtual int ReplaceBone(ImportedGroups grps, ImportedBone b, int index)
		{			
			int nindex = b.TargetIndex;
			gmdc.Joints[nindex] = b.Bone;
			gmdc.Model.Quaternions[nindex] = b.Quaternion;
			gmdc.Model.Transformations[nindex] = b.Translation;

			return nindex;
		}

		/// <summary>
		/// Replace an exiting bone with the passed one
		/// </summary>
		/// <param name="grps">List of all Imported Groups (needed to fix the UseBone Indices)</param>
		/// <param name="b"></param>
		/// <param name="index">The Number of the Bone that should be added</param>
		/// <returns>the real Bone Index</returns>
		protected virtual int UpdateBone(ImportedGroups grps, ImportedBone b, int index)
		{			
			int nindex = b.TargetIndex;						
			return nindex;
		}

		/// <summary>
		/// Remove the Links to the NothingBones
		/// </summary>
		/// <param name="grps">List of all Imported Groups (needed to fix the UseBone Indices)</param>
		/// <param name="b"></param>
		/// <param name="index">The Number of the Bone that should be added</param>
		/// <returns>the real Bone Index</returns>
		protected virtual int NothingBone(ImportedGroups grps, ImportedBone b, int index)
		{			
			return -1;
		}
		#endregion		

		/// <summary>
		/// Creates a new <see cref="ImportedGroup"/> Instance with Default Settings
		/// </summary>
		/// <returns>a new Container for an Imported MeshGroup</returns>
		/// <remarks>
		/// You should use this whenever you have to add a new Group!
		/// </remarks>
		protected ImportedGroup PrepareGroup()
		{
			ImportedGroup g = new ImportedGroup(Gmdc);
				
			//Vertex Element-----
			GmdcElement e = new GmdcElement(Gmdc);
			g.Elements.Add(e);
			e.Identity = ElementIdentity.Vertex;
			e.BlockFormat = BlockFormat.ThreeFloat;
			e.SetFormat = SetFormat.Secondary;

			//Normal Element-----
			e = new GmdcElement(Gmdc);
			g.Elements.Add(e);
			e.Identity = ElementIdentity.Normal;
			e.BlockFormat = BlockFormat.ThreeFloat;
			e.SetFormat = SetFormat.Normals;

			//UVCoord Element-----
			e = new GmdcElement(Gmdc);
			g.Elements.Add(e);
			e.Identity = ElementIdentity.UVCoordinate;
			e.BlockFormat = BlockFormat.TwoFloat;
			e.SetFormat = SetFormat.Mapping;				
				
			g.Group.PrimitiveType = PrimitiveType.Triangle;
			g.Group.Opacity = 0xffffffff;

			return g;
		}
	}
}
