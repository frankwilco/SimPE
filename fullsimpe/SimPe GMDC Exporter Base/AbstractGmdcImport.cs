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

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// This class is the base for all Importers that want to reuse the Default 
	/// SimPE Import Dialog.
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
		/// <remarks>You can use the Input and Gmdc Member to acces the Stream and 
		/// the Gmdc File that should be changed</remarks>
		protected abstract ImportedGroups LoadGroups();
		#endregion

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
			if (ValidateImportedGroups(g)) ChangeGmdc(g);
		}

		/// <summary>
		/// This is called after the Groups were Imported to validate the Content
		/// </summary>
		/// <param name="grps">The imported Groups</param>
		/// <returns></returns>
		/// <remarks>This Implementation will show the ImportGmdcGroups Dialog to 
		/// let the User validate the Content. Override this Method, if you want a 
		/// diffrent Import Dialog</remarks>
		protected virtual bool ValidateImportedGroups(ImportedGroups grps)
		{
			return ImportGmdcGroupsForm.Execute(gmdc, grps) == System.Windows.Forms.DialogResult.OK;
		}

		/// <summary>
		/// This Method is called when the Imported Data should be written to the 
		/// passed Gmdc File
		/// </summary>
		/// <param name="grps">The imported Groups</param>
		/// <remarks>
		/// Override This Method if you want a diffrent Behaviour when writing the Data
		/// to the Gmdc. Override AddGroup(), ReplaceGroup() or RenameGroup() if you just 
		/// want to alter a specific Behaviuour.
		/// </remarks>
		protected virtual void ChangeGmdc(ImportedGroups grps)
		{
			foreach (ImportedGroup g in grps) 
			{
				if (g.Action == GmdcImporterAction.Add) AddGroup(g);
				else if (g.Action == GmdcImporterAction.Rename) RenameGroup(g);
				else if (g.Action == GmdcImporterAction.Replace) ReplaceGroup(g);				
			}
		}

		/// <summary>
		/// Add the passed Group to the Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void AddGroup(ImportedGroup g)
		{			
			for (int i=0; i<g.Link.Items1.Count; i++) 
			{
				gmdc.Elements.Add(g.Elements[g.Link.Items1[i]]);
				g.Link.Items1[i] = gmdc.Elements.Length-1;				
			}
			g.Group.LinkIndex = gmdc.Links.Length;
			gmdc.Links.Add(g.Link);
			gmdc.Groups.Add(g.Group);
		}

		/// <summary>
		/// Replace an existing Group with  the passed Group in the current Gmdc
		/// </summary>
		/// <param name="g"></param>
		protected virtual void ReplaceGroup(ImportedGroup g)
		{
			int index = -1;
			for (int i=0; i<gmdc.Groups.Count; i++)
			{
				if (gmdc.Groups[i].Name == g.TargetName) 
				{
					index = i;
					break;
				}
			}

			if (index>=0) gmdc.RemoveGroup(index);
			RenameGroup(g);
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
	}
}
