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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using System.Collections;
using System.Collections.Generic;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// An Item as stored in a Scor Resource
	/// </summary>
	public class ScorItem
    {
        #region GuiWrappers
        static Dictionary<string, Type> guis;
        internal static Dictionary<string, Type> GuiElements
        {
            get
            {
                if (guis == null) LoadGuielements();
                return guis;
            }
        }

        static void LoadGuielements(){
            guis = new Dictionary<string, Type>();

            guis.Add("Learned Behaviors", typeof(SCOR.ScoreItemLearnedBehaviour));
        }

        internal void LoadGuiElement(string name)            
        {
            gui = GetGuiElement(name, null);
        }

        protected  SCOR.AScorItem GetGuiElement(string name, byte[] data)
        {
            SCOR.AScorItem ret = null;
            if (GuiElements.ContainsKey(name))
            {
                ret = System.Activator.CreateInstance(GuiElements[name], new object[] { this }) as SCOR.AScorItem;                
            }
            if (ret==null) ret = new SCOR.ScoreItemDefault(this);
            if (data != null)
            {
                System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(data));
                ret.SetData(name, br);
                br.Close();
            }

            return ret;
        }
        #endregion

        SCOR.AScorItem gui;
        public SCOR.AScorItem Gui
        {
            get {
                if (gui == null) SetGui("", new byte[0]);
                return gui; 
            }
        }


        Scor parent;
        public Scor Parent
        {
            get { return parent; }
        }
		
		
		/// <summary>
		/// Constructor
		/// </summary>
		public ScorItem(string name, Scor parent) : this(parent)
		{
			SetGui(name, new byte[0]);
		}

		internal ScorItem(Scor parent) 
		{
			this.parent = parent;
            SetGui("", new byte[0]);
		}

        ~ScorItem()
        {
            //if (gui != null) gui.Dispose();
        }

        protected void SetGui(string name, byte[] data)
        {
            //if (gui != null) gui.Dispose();
            gui = GetGuiElement(name, data);
        }
						
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			string name = StreamHelper.ReadString(reader);
            
			if (reader.BaseStream.Position > reader.BaseStream.Length-1) return;
			System.Collections.ArrayList bytes = new ArrayList();
			
			byte test = reader.ReadByte();			
			byte last = test;
			while (last!=0x00 || test!=0x04) 
			{				
				bytes.Add(test);
				if (reader.BaseStream.Position > reader.BaseStream.Length-1) break;
				last = test;
				test = reader.ReadByte();
			}		
	
			if (reader.BaseStream.Position <= reader.BaseStream.Length-1)
				if (bytes.Count>0) 
					bytes.RemoveAt(bytes.Count-1);

			byte[] data = new byte[bytes.Count];
			bytes.CopyTo(data);

            SetGui(name, data);
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		internal  void Serialize(System.IO.BinaryWriter writer, bool last)
		{
            Gui.Serialize(writer);
			if (!last) writer.Write((ushort)0x0400);			
		}		

		public override string ToString()
		{
            return Gui.TokenName;
		}

	}

	public class ScorItems : 
        System.Collections.Generic.IEnumerable<ScorItem>
        , System.IDisposable
	{
		System.Collections.Generic.List<ScorItem> list;
		public ScorItems()
		{
            list = new List<ScorItem>();
		}

		public void Add(ScorItem si)
		{
			list.Add(si);
		}

		public void Remove(ScorItem si)
		{
			list.Remove(si);
		}

		public void Clear()
		{
			list.Clear();
		}

		public int Count
		{
			get {return list.Count;}
		}

		public bool Contains(ScorItem si)
		{
			return list.Contains(si);
		}

		protected int FindIndex(string name)
		{
			for (int i=0; i< list.Count; i++)
				if (this[i].Gui.Name==name) return i;

			return -1;
		}

		public ScorItem this[string name]
		{
			get { return list[FindIndex(name)] as ScorItem;}
			set 
			{
				list[FindIndex(name)] = value;
			}
		}

		public ScorItem this[int index]
		{
			get { return list[index] as ScorItem;}
			set 
			{
				list[index] = value;
			}
		}

		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			list.Clear();
			list = null;
		}

		#endregion

        #region IEnumerable<ScorItem> Members

        IEnumerator<ScorItem> IEnumerable<ScorItem>.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        internal IEnumerator<ScorItem> GetScorItemEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion
    }

}
