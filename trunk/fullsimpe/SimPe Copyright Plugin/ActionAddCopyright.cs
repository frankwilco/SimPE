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

namespace SimPe.Plugin.Tool.Action
{

	/// <summary>
	/// The ReloadFileTable Action
	/// </summary>
	public class ActionAddCopyright : Interfaces.AbstractTool, Interfaces.IToolPlugin, Interfaces.IToolExt, Interfaces.IToolPlus
	{
		StringsForm form;
		public ActionAddCopyright() 
		{
			form = new StringsForm();
		}
		#region IToolAction Member

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (!es.Loaded) return false;	
			if (!es.HasFileDescriptor) return false;

			return true;
		}
				
		public void Execute(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;
			
			form.ShowDialog();
			foreach (SimPe.Events.ResourceContainer rc in e)
			{
				if (rc.Resource.FileDescriptor.Type==Data.MetaData.MMAT) AddToMMAT(rc);
				else if (rc.Resource.FileDescriptor.Type==Data.MetaData.GMND) AddToGMND(rc);
			}	
		}

		#endregion		
		
		#region MMAT
		void RemoveFromMMAT(SimPe.PackedFiles.Wrapper.Cpf mmat)
		{
		}
		void AddToMMAT(SimPe.Events.ResourceContainer rc)
		{
			SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
			mmat.ProcessData(rc.Resource);
			RemoveFromMMAT(mmat);

			if (mmat.GetItem("copyright")==null) 
			{
				SimPe.PackedFiles.Wrapper.CpfItem item = new SimPe.PackedFiles.Wrapper.CpfItem();
				item.Name = "copyright";
				mmat.Items = (SimPe.PackedFiles.Wrapper.CpfItem[]) Helper.Add(mmat.Items, item);
			}

			mmat.GetItem("copyright").StringValue = form.tbMMAT.Text;
			mmat.SynchronizeUserData(true, true);
		}
		#endregion

		#region GMND
		void RemoveFromGMND(SimPe.Plugin.GenericRcol rcol)
		{
			uint ct = 0;
			
			GeometryNode gn = (GeometryNode)rcol.Blocks[0];
			ArrayList delete = new ArrayList();
			foreach (SimPe.Interfaces.Scenegraph.IRcolBlock irb in rcol.Blocks)
			{
				if (irb is DataListExtension)
				{
					DataListExtension dle = (DataListExtension)irb;
					if (dle.Extension.VarName=="copyright") 
					{
						ArrayList list = new ArrayList();
						foreach (ObjectGraphNodeItem ogni in gn.ObjectGraphNode.Items)
							if (ogni.Index!=ct)
								list.Add(ogni);

						gn.ObjectGraphNode.Items = new ObjectGraphNodeItem[list.Count];
						list.CopyTo(gn.ObjectGraphNode.Items);

						delete.Add(dle);
					}
				}
				ct++;
			}

			foreach (DataListExtension dle in delete)
				rcol.Blocks = (SimPe.Interfaces.Scenegraph.IRcolBlock[])Helper.Delete(rcol.Blocks, dle, typeof(SimPe.Interfaces.Scenegraph.IRcolBlock));

			if (delete.Count>0) rcol.SynchronizeUserData();
		}
		void AddToGMND(SimPe.Events.ResourceContainer rc)
		{
			SimPe.Plugin.GenericRcol rcol = new GenericRcol();
			rcol.ProcessData(rc.Resource);
			RemoveFromGMND(rcol);

			GeometryNode gn = (GeometryNode)rcol.Blocks[0];
			DataListExtension dle = new DataListExtension(rcol);
			dle.Extension.VarName = "copyright";
			dle.Extension.Items = new ExtensionItem[4];

			dle.Extension.Items[0] = new ExtensionItem();
			dle.Extension.Items[0].Typecode = ExtensionItem.ItemTypes.String;
			dle.Extension.Items[0].Name = "created by";
			dle.Extension.Items[0].String = form.tbCreator.Text;
			
			dle.Extension.Items[1] = new ExtensionItem();
			dle.Extension.Items[1].Typecode = ExtensionItem.ItemTypes.String;
			dle.Extension.Items[1].Name = "license";
			dle.Extension.Items[1].String = form.tbLicense.Text;

			dle.Extension.Items[2] = new ExtensionItem();
			dle.Extension.Items[2].Typecode = ExtensionItem.ItemTypes.String;
			dle.Extension.Items[2].Name = "release date";
			dle.Extension.Items[2].String = form.tbDate.Text;

			dle.Extension.Items[3] = new ExtensionItem();
			dle.Extension.Items[3].Typecode = ExtensionItem.ItemTypes.String;
			dle.Extension.Items[3].Name = "version";
			dle.Extension.Items[3].String = form.tbVersion.Text;
			rcol.Blocks = (SimPe.Interfaces.Scenegraph.IRcolBlock[])Helper.Add(rcol.Blocks, dle, typeof(SimPe.Interfaces.Scenegraph.IRcolBlock));
			
			
			ObjectGraphNodeItem ogni = new ObjectGraphNodeItem();
			ogni.Index = (uint)(rcol.Blocks.Length-1);
			ogni.Enabled = 0x01;
			ogni.Dependant = 0x00;
			gn.ObjectGraphNode.Items = (ObjectGraphNodeItem[])Helper.Add(gn.ObjectGraphNode.Items, ogni);

			rcol.SynchronizeUserData(true, true);
		}
		#endregion

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Object Tool\\Add Copyright Notice";
		}
		#endregion

		#region IToolExt Member
		public override System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.CtrlShiftC;
			}
		}

		public override System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		public override bool Visible 
		{
			get {return true;}
		}

		#endregion
	}
}
