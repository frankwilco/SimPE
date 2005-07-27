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
using System.Windows.Forms;
using System.Drawing;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// handles Packed SDSC Files
	/// </summary>
	public class Objd : UIBase, IPackedFileUI
	{
		

		#region IPackedFileHandler Member

		public Control GUIHandle
		{
			get 
			{
				return form.objdPanel;
			}
		}

		public void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			Wrapper.Objd objd = (Wrapper.Objd)wrapper;
			form.wrapper = objd;

			form.tbsimid.Text = "0x"+Helper.HexString(objd.SimId);	
			form.tbsimname.Text = objd.FileName;
			form.tblottype.Text = "0x"+Helper.HexString(objd.Type);
			form.lbtypename.Text = ((Data.ObjectTypes)objd.Type).ToString().Trim();
			form.tborgguid.Text = "0x"+Helper.HexString(objd.OriginalGuid);
			form.tbproxguid.Text = "0x"+Helper.HexString(objd.ProxyGuid);

			Hashtable list = objd.Attributes;
			form.pnelements.Controls.Clear();

			int top = 4;
			ArrayList keys = new ArrayList();
			foreach (string k in list.Keys) keys.Add("0x"+Helper.HexString((ushort)objd.GetAttributePosition(k))+": "+k);
			keys.Sort();

			foreach (string k in keys)
			{
				string[] s = k.Split(":".ToCharArray(), 2);
				Label lb = new Label();
				lb.Parent = form.pnelements;
				lb.AutoSize = true;
				lb.Text = k+" = ";
				lb.Top = top;
				lb.Visible = true;

				TextBox tb = new TextBox();
				tb.BorderStyle = BorderStyle.None;
				tb.Parent = form.pnelements;
				tb.Left = lb.Left + lb.Width;
				tb.Top = lb.Bottom - tb.Height;
				tb.Width = 50;
				tb.Text = "0x"+Helper.HexString(objd.GetAttributeShort(s[1].Trim()));
				tb.Tag = s[1].Trim();
				tb.Visible = true;				
				tb.TextChanged += new EventHandler(HexTextChanged);

				TextBox tb2 = new TextBox();
				tb2.BorderStyle = BorderStyle.None;
				tb2.Parent = form.pnelements;
				tb2.Left = tb.Left + tb.Width + 4;
				tb2.Top = lb.Bottom - tb.Height;
				tb2.Width = 100;
				tb2.Text = ((short)objd.GetAttributeShort(s[1].Trim())).ToString();
				tb2.Tag = null;
				tb2.Visible = true;
				tb2.TextChanged += new EventHandler(DecTextChanged);
				

				top += Math.Max(lb.Height, tb.Height) + 2;
			}
		}

		
		#endregion

		bool systentextupdate = false;

		/// <summary>
		/// Updates the Decimal View
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HexTextChanged(object sender, EventArgs e)
		{
			if (systentextupdate) return;
			systentextupdate = true;
			TextBox tb = (TextBox) sender;

			foreach (Control c in tb.Parent.Controls) 
			{
				if (c.GetType()==typeof(TextBox)) 
				{
					TextBox tb2 = (TextBox)c;
					if ((tb2.Top == tb.Top) && (tb2!=tb))
					{
						try 
						{
							tb2.Text = Convert.ToInt16(tb.Text, 16).ToString();
						} 
						catch (Exception) {}
						break;
					}
				}
			} //foreach
			systentextupdate = false;
		}

		/// <summary>
		/// Updates the Hex View
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DecTextChanged(object sender, EventArgs e)
		{
			if (systentextupdate) return;
			systentextupdate = true;
			TextBox tb = (TextBox) sender;

			foreach (Control c in tb.Parent.Controls) 
			{
				if (c.GetType()==typeof(TextBox)) 
				{
					TextBox tb2 = (TextBox)c;
					if ((tb2.Top == tb.Top) && (tb2!=tb))
					{
						try 
						{
							tb2.Text = "0x"+Helper.HexString((ushort)Convert.ToInt16(tb.Text));
						} 
						catch (Exception) {}
						break;
					}
				}
			} //foreach
			systentextupdate = false;
		}
	}
}
