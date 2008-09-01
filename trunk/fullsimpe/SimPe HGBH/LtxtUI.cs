/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 Peter L Jones                                      *
 *   pljones@users.sf.net                                                  *
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
using SimPe.Interfaces.Plugin;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class LtxtUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		internal LtxtForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public LtxtUI()
		{
			//form = WrapperFactory.form;
			form = new LtxtForm();

			Ltxt.LotType[] ts = (Ltxt.LotType[])System.Enum.GetValues(typeof(Ltxt.LotType));
			foreach (Ltxt.LotType t in ts)
				if (t==Ltxt.LotType.Unknown) form.cbtype.Items.Insert(0, t);
				else form.cbtype.Items.Add(t);			
		}
		#endregion

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get
			{
				return form.ltxtPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <param name="wrapper">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrapper)
		{
            Ltxt wrp = (Ltxt)wrapper;
            form.wrapper = null;
            //form.ltxtPanel.Enabled = !(wrp.Version >= LtxtVersion.Apartment || wrp.SubVersion >= LtxtSubVersion.Apartment);

            form.pb.Image = wrp.LotDescription.Image;

            form.tbver.Text = wrp.Version.ToString();
            form.tbsubver.Text = wrp.SubVersion.ToString();
            
			form.tbu0.Text = "0x"+Helper.HexString(wrp.Unknown0);
            form.tbu3.Text = wrp.Unknown3.ToString();
            form.tbu4.Text = "0x"+Helper.HexString(wrp.Unknown4);

			form.tbinst.Text = "0x"+Helper.HexString(wrp.LotInstance);
            form.tbu5.Text = Helper.BytesToHexList(wrp.Unknown5);

			form.cbtype.SelectedIndex = -1;
            if ((byte)wrp.Type < form.cbtype.Items.Count) form.cbtype.SelectedIndex = (byte)wrp.Type;
            form.tbtype.Text = "0x" + Helper.HexString((byte)wrp.Type);

			form.lb.Items.Clear();
            int x = 0, y = 0;
            foreach (float i in wrp.Unknown1)// form.lb.Items.Add("0x" + Helper.HexString(i));
            {
                form.lb.Items.Add("(" + x + "," + y + ") " + i);
                x++;
                if ((y + 1) * (wrp.LotSize.Width + 1) == form.lb.Items.Count)
                {
                    y++;
                    x = 0;
                }
            }

			form.tbRoads.Text = "0x"+Helper.HexString(wrp.LotRoads);
			form.tbrotation.Text = "0x"+Helper.HexString(wrp.LotRotation);

            form.tbwd.Text = wrp.LotSize.Width.ToString();
			form.tbleft.Text = wrp.LotPosition.X.ToString();
			form.tbz.Text = wrp.LotElevation.ToString();

            form.tbhg.Text = wrp.LotSize.Height.ToString();
			form.tbtop.Text = wrp.LotPosition.Y.ToString();

			form.cborient.SelectedValue = wrp.Orientation;
            form.tbData.Text = Helper.BytesToHexList(wrp.Followup);

			form.tblotname.Text = wrp.LotName;
			form.tbdesc.Text = wrp.LotDesc;
            form.tbTexture.Text = wrp.Texture;
            form.tbu2.Text = "0x" + Helper.HexString(wrp.Unknown2);
            form.tbowner.Text = "0x" + Helper.HexString(wrp.OwnerInstance);

            form.tbowner.ReadOnly = !(wrp.Version >= LtxtVersion.Business);
            form.tbu3.ReadOnly = !(wrp.SubVersion >= LtxtSubVersion.Voyage);
            form.tbu4.ReadOnly = !(wrp.SubVersion >= LtxtSubVersion.Freetime);
            form.tbu5.ReadOnly = !(wrp.Version >= LtxtVersion.Apartment || wrp.SubVersion >= LtxtSubVersion.Apartment);

			form.wrapper = wrp;
		}		

		#endregion
		
		#region IDisposable Member
		public virtual void Dispose()
		{
			this.form.Dispose();
		}
		#endregion
	}
}
