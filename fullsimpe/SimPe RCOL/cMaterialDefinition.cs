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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class MaterialDefinition
		: AbstractRcolBlock, IScenegraphBlock
	{
		#region Attributes
		
		
		string fldsc;
		public string FileDescription 
		{
			get { return fldsc; }
			set { fldsc = value; }
		}

		string mattype;
		public string MatterialType
		{
			get { return mattype; }
			set { mattype = value; }
		}

		MaterialDefinitionProperty[] properties;
		public MaterialDefinitionProperty[] Properties
		{
			get { return properties; } 
			set { properties = value; }
		}

		string[] listing;
		public string[] Listing 
		{
			get { return listing; }
			set { listing = value; }
		}
		#endregion

		

		/// <summary>
		/// Constructor
		/// </summary>
		public MaterialDefinition(Rcol parent) : base(parent)
		{
			properties = new MaterialDefinitionProperty[0];
			listing = new String[0];
			sgres = new SGResource(null);
			BlockID = 0x49596978;
			fldsc = "";
			mattype = "";
		}

		/// <summary>
		/// Returns the Property Item 
		/// </summary>
		/// <param name="name">The Property name</param>
		/// <returns>The Item or an Item with no Name if the property dies not exits</returns>
		public MaterialDefinitionProperty FindProperty(string name)
		{
			name = name.Trim().ToLower();
			foreach (MaterialDefinitionProperty mdp in properties) 
			{
				if (mdp.Name.Trim().ToLower()==name) return mdp;
			}

			return new MaterialDefinitionProperty();
		}

		public MaterialDefinitionProperty GetProperty(string name) 
		{
			return FindProperty(name);
			/*name = name.ToLower();
			foreach (MaterialDefinitionProperty mdp in properties)
			{
				if (name==mdp.Name.ToLower()) return mdp;
			}
			return new MaterialDefinitionProperty();*/
		}

		/// <summary>
		/// Add a new Property
		/// </summary>
		/// <param name="prop">The propery to add</param>
		/// <remarks>If the property already exists, it's value will be overwritten</remarks>
		public void Add(MaterialDefinitionProperty prop)
		{
			Add(prop, false);
		}

		/// <summary>
		/// Add a new Property
		/// </summary>
		/// <param name="prop">The propery to add</param>
		/// <param name="duplicate">true, if you want to allow two occurences of the same Property</param>
		/// <remarks>If duplicate is false, and the property already exists, it's value will be overwritten</remarks>
		public void Add(MaterialDefinitionProperty prop, bool duplicate)
		{
			if (!duplicate) 
			{
				MaterialDefinitionProperty ex = null;
				foreach (MaterialDefinitionProperty mdp in properties) 
				{
					if (mdp.Name.Trim().ToLower()==prop.Name.Trim().ToLower()) 
					{
						ex = mdp;
						break;
					}
				}

				if (ex!=null) ex.Value = prop.Value;
				else this.properties = (MaterialDefinitionProperty[])Helper.Add(properties, prop);
			} 
			else 
			{
				this.properties = (MaterialDefinitionProperty[])Helper.Add(properties, prop);
			}
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			/*byte len = reader.ReadByte();
			fldsc = Helper.ToString(reader.ReadBytes(len));*/
			fldsc = reader.ReadString();
			uint myid = reader.ReadUInt32();
			sgres.Unserialize(reader);
			sgres.BlockID = myid;

			/*len = reader.ReadByte();
			fldsc = Helper.ToString(reader.ReadBytes(len));*/
			fldsc = reader.ReadString();
			/*len = reader.ReadByte();
			mattype = Helper.ToString(reader.ReadBytes(len));*/
			mattype = reader.ReadString();

			properties = new MaterialDefinitionProperty[reader.ReadUInt32()];
			for (int i=0; i<properties.Length; i++)
			{
				properties[i] = new MaterialDefinitionProperty();
				properties[i].Unserialize(reader);
			}

			if (version==8)
			{
				listing = new String[0];
			} 
			else 
			{
				listing = new String[reader.ReadUInt32()];
				for (int i=0; i<listing.Length; i++) 
				{
					/*len = reader.ReadByte();
					listing[i] = Helper.ToString(reader.ReadBytes(len));*/
					listing[i] = reader.ReadString();
				}
			}
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);
			string name = sgres.Register(null);
			/*writer.Write((byte)name.Length);
			writer.Write(Helper.ToBytes(name, (byte)name.Length));*/
			writer.Write(name);
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);

			/*writer.Write((byte)fldsc.Length);
			writer.Write(Helper.ToBytes(fldsc, (byte)fldsc.Length));
			writer.Write((byte)mattype.Length);
			writer.Write(Helper.ToBytes(mattype, (byte)mattype.Length));*/
			writer.Write(fldsc);
			writer.Write(mattype);

			writer.Write((uint)properties.Length);
			for (int i=0; i<properties.Length; i++)
			{
				properties[i].Serialize(writer);
			}

			if (version!=8)
			{
				writer.Write((uint)listing.Length);
				for (int i=0; i<listing.Length; i++) 
				{
					/*writer.Write((byte)listing[i].Length);
					writer.Write(Helper.ToBytes(listing[i], (byte)listing[i].Length));*/
					writer.Write(listing[i]);
				}
			}
		}

		MatdForm form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new MatdForm(); 
				return form.tabPage3;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new MatdForm(); 
			form.tbname.Tag = true;
			try 
			{
				form.tb_ver.Text = "0x"+Helper.HexString(this.version);
		
				form.lldel.Enabled = false;
				form.lbprop.Items.Clear();
				foreach (MaterialDefinitionProperty mdp in this.Properties) form.lbprop.Items.Add(mdp);
				
				form.tbdsc.Text = FileDescription;
				form.tbtype.Text = MatterialType;

				form.lbfl.Items.Clear();
				foreach (string fl in Listing) form.lbfl.Items.Add(fl);

				//if (Helper.WindowsRegistry.HiddenMode) 
				{
					form.SetupGrid(this);
				}				
			} 
			finally 
			{
				form.tbname.Tag = null;
			}
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			form.tabPage1.Tag = this;
			tc.TabPages.Add(form.tabPage1);

			
			form.tabPage2.Tag = this;
			tc.TabPages.Add(form.tabPage2);
			

			//if (Helper.WindowsRegistry.HiddenMode) 
		{
			form.tGrid.Tag = this;
			tc.TabPages.Add(form.tGrid);
		}

			tc.SelectedIndex = 1;			
			if (parent!=null) parent.CallWhenTabPageChanged = new System.EventHandler(form.TxmtChangeTab);
		}

		#region IScenegraphBlock Member

		public void ReferencedItems(Hashtable refmap, uint parentgroup)
		{
			ArrayList list = new ArrayList();
			foreach (string name in Listing) 
			{
				list.Add(ScenegraphHelper.BuildPfd(name+"_txtr", SimPe.Plugin.ScenegraphHelper.TXTR, parentgroup));
			}
			refmap["TXTR"] = list;
			
			string refname = this.GetProperty("stdMatBaseTextureName").Value;
			if (refname.Trim()!="") 
			{
				list = new ArrayList();
				list.Add(ScenegraphHelper.BuildPfd(refname+"_txtr", SimPe.Plugin.ScenegraphHelper.TXTR, parentgroup));
				refmap["stdMatBaseTextureName"] = list;
			}

			refname = this.GetProperty("stdMatNormalMapTextureName").Value;
			if (refname.Trim()!="") 
			{
				list = new ArrayList();
				list.Add(ScenegraphHelper.BuildPfd(refname+"_txtr", SimPe.Plugin.ScenegraphHelper.TXTR, parentgroup));
				refmap["stdMatNormalMapTextureName"] = list;
			}

			refname = this.GetProperty("stdMatEnvCubeTextureName").Value;
			if (refname.Trim()!="")
			{
				list = new ArrayList();
				list.Add(ScenegraphHelper.BuildPfd(refname+"_txtr", SimPe.Plugin.ScenegraphHelper.TXTR, parentgroup));
				refmap["stdMatEnvCubeTextureName"] = list;
			}


			//for characters
			int count = 0;
			try 
			{
				string s = this.GetProperty("numTexturesToComposite").Value;
				if (s!="") count = Convert.ToInt32(this.GetProperty("numTexturesToComposite").Value);
			} 
			catch {}
			list = new ArrayList();	
			refmap["baseTexture"] = list;
			for (int i=0; i<count; i++)
			{
				refname = this.GetProperty("baseTexture"+i.ToString()).Value.Trim();
				if (refname!="")
				{
					if (!refname.EndsWith("_txtr")) refname+="_txtr";
					list.Add(ScenegraphHelper.BuildPfd(refname, SimPe.Plugin.ScenegraphHelper.TXTR, parentgroup));					
				}
			}						
		}

		#endregion

		#region Property Grid
		static Ambertation.PropertyParser tpp;

		/// <summary>
		/// Return a PropertyParser, that enumerates all known Properties as <see cref="Ambertation.PropertyDescription"/> Objects
		/// </summary>
		public static Ambertation.PropertyParser PropertyParser
		{
			get 
			{
				if (tpp==null) tpp = new Ambertation.PropertyParser(System.IO.Path.Combine(Helper.SimPeDataPath, "txmtdefinition.xml"));
				return tpp;
			}
		}

		#endregion

		/// <summary>
		/// Sort the Properties in Alphabetic Order
		/// </summary>
		public void Sort()
		{
			for (int i=0; i<this.properties.Length-1; i++) 
				for (int j=i+1; j<this.properties.Length; j++)
				{
					if (properties[i].Name.CompareTo(properties[j].Name)>0)
					{
						MaterialDefinitionProperty dum = properties[i];
						 properties[i] =  properties[j];
						 properties[j] = dum;
					}
				}
		}

		/// <summary>
		/// Creates a Material Object form this Block
		/// </summary>
		/// <returns></returns>
		public Ambertation.Scenes.Material ToSceneMaterial(Ambertation.Scenes.Scene scn, string name)
		{
			MaterialDefinitionProperty p;
			Ambertation.Scenes.Material mat = scn.CreateMaterial(name);
			p = this.GetProperty("stdMatSpecCoef");	if (p!=null) mat.Specular = p.ToARGB();
			p = this.GetProperty("stdMatDiffCoef");	if (p!=null) mat.Diffuse = p.ToARGB();
			p = this.GetProperty("stdMatEmissiveCoef");	if (p!=null) mat.Emmissive = p.ToARGB();
			p = this.GetProperty("stdMatSpecPower");	if (p!=null) mat.SpecularPower = p.ToValue();

			p = this.GetProperty("stdMatAlphaBlendMode");
			if (p!=null)
			{
				if (p.Value=="blend")
					mat.Mode = Ambertation.Scenes.Material.TextureModes.ShadowTexture;
				//if (mat.Texture.AlphaBlend) mat.Diffuse = System.Drawing.Color.FromArgb(0x10, mat.Diffuse);
			}
			return mat;
		}
		

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}

	public class MaterialDefinitionProperty
	{
		#region Attributes
		string name;
		string val;

		public string Name 
		{
			get { return name; }
			set { name = value; }
		}

		public string Value 
		{
			get { return val; }
			set { val = value; }
		}
		#endregion

		public MaterialDefinitionProperty()
		{
			name = "";
			val = "";
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			
			name = reader.ReadString();
			val = reader.ReadString();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(name);
			writer.Write(val);
		}

		public double ToValue()
		{
			double[] list = ToFloat();
			if (list.Length>0) return list[0];			
			return 0;
		}

		public Ambertation.Geometry.Vector2 ToVector2()
		{
			double[] list = ToFloat();
			Ambertation.Geometry.Vector2 v = Ambertation.Geometry.Vector2.Zero;
			if (list.Length>0) v.X=list[0];
			if (list.Length>1) v.Y=list[1];
			return v;
		}

		public System.Drawing.Color ToRGB()
		{			
			Ambertation.Geometry.Vector3 v = ToVector3();
			return System.Drawing.Color.FromArgb((int)(v.X*0xff), (int)(v.Y*0xff), (int)(v.Z*0xff));
		}

		public System.Drawing.Color ToARGB()
		{			
			if (this.ToFloat().Length<4) return ToRGB();
			Ambertation.Geometry.Vector4 v = ToVector4();
			return System.Drawing.Color.FromArgb((int)(v.X*0xff), (int)(v.Y*0xff), (int)(v.Z*0xff), (int)(v.W*0xff));
		}

		public Ambertation.Geometry.Vector3 ToVector3()
		{
			double[] list = ToFloat();
			Ambertation.Geometry.Vector3 v = Ambertation.Geometry.Vector3.Zero;
			if (list.Length>0) v.X=list[0];
			if (list.Length>1) v.Y=list[1];
			if (list.Length>2) v.Z=list[2];
			return v;
		}

		public Ambertation.Geometry.Vector4 ToVector4()
		{
			double[] list = ToFloat();
			Ambertation.Geometry.Vector4 v = Ambertation.Geometry.Vector4.Zero;
			if (list.Length>0) v.X=list[0];
			if (list.Length>1) v.Y=list[1];
			if (list.Length>2) v.Z=list[2];
			if (list.Length>3) v.W=list[3];
			return v;
		}

		public double[] ToFloat()
		{
			Ambertation.Collections.DoubleCollection dc = new Ambertation.Collections.DoubleCollection();
			string[] parts = val.Split(new char[]{','});
			foreach (string s in parts)
				try 
				{
					dc.Add(Convert.ToDouble(s, System.Globalization.CultureInfo.InvariantCulture));
				} 
				catch {}

			double[] ret = new double[dc.Count];
			for (int i=0; i<dc.Count; i++) ret[i]=dc[i];
			return ret;
		}

		public override string ToString()
		{
			return name + ": " + val;
		}		
	}
}
