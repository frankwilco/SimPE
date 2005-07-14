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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms
{
	internal class EnumComboBoxItem 
	{
		string name;
		object obj;

		public object Content 
		{
			get { return obj;}
		}

		public string Name 
		{
			get {return name;}
		}

		internal EnumComboBoxItem(Type type, object obj, System.Resources.ResourceManager rm)
		{
			this.name = obj.ToString();
			if (rm!=null) 			
			{
				string nname = rm.GetString(type.Namespace+"."+type.Name+"."+this.name);
				if (nname!=null) name = nname;
			}
			this.obj = obj;
		}

		public override string ToString()
		{
			return Name;
		}

	}
	/// <summary>
	/// Zusammenfassung für UserControl1.
	/// </summary>
	public class EnumComboBox : TD.SandBar.FlatComboBox
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public EnumComboBox()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			// TODO: Initialisierungen nach dem Aufruf von InitComponent hinzufügen

		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region public Properties
		Type myenum;
		public Type Enum 
		{
			get {return myenum;}
			set 
			{
				if (value!=myenum) 
				{
					myenum=value;
					UpdateContent(false);
				}
			}
		}

		System.Resources.ResourceManager rm;
		public System.Resources.ResourceManager ResourceManager
		{
			get { return rm; }
			set 
			{
				if (value!=rm)
				{
					rm = value;
					UpdateContent(true);
				}
			}
		}

		public object SelectedValue
		{
			get 
			{
				if (this.SelectedIndex<0) return null;
				object o = Items[SelectedIndex];
				if (o is EnumComboBoxItem)
					return ((EnumComboBoxItem)o).Content;

				return o;
			}
			set
			{
				if (value==null) 
				{
					SelectedIndex = -1;
				} 
				else 
				{
					Type vtype = value.GetType();					
					int sel = -1;
					if (vtype.IsEnum)
					{
						for (int i=0; i<Items.Count; i++) 
						{
							object o = Items[i];
							if (o is EnumComboBoxItem) o = ((EnumComboBoxItem)o).Content;
							if (((System.Enum)o).CompareTo(value)==0) 
							{
								sel = i;
								break;
							}
						}
					}
					SelectedIndex = sel;
				}
			}
		}
		#endregion

		#region Vom Komponenten-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// EnumComboBox
			// 
			this.Name = "EnumComboBox";

		}
		#endregion

		public void UpdateContent(bool keepselection)
		{
			this.Items.Clear();
			int last = this.SelectedIndex;
			if (myenum!=null) 
			{
				Array ls = System.Enum.GetValues(myenum);

				foreach (object o in ls)
				{
					Items.Add(new EnumComboBoxItem(myenum, o, rm));
				}
			}

			if (keepselection)
			{
				if ( last<this.Items.Count) this.SelectedIndex = last;
				else this.SelectedIndex = Items.Count-1;
			}
		}
	}
}
