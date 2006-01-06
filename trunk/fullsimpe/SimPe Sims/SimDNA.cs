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

namespace SimPe.PackedFiles.Wrapper
{
	public class Gene : Serializer
	{
		Cpf dna;
		uint b;
		internal Gene(Cpf dna, uint b)
		{
			this.dna = dna;
			this.b = b;
		}

		string GetName(uint line)
		{
			line += b;
			if (b==0x10000005) b = 4;
			if (b==0x10000007) b = 10;
			return line.ToString();
		}

		string GetItem(uint line)
		{
			return dna.GetSaveItem(GetName(line)).StringValue;
		}

		void SetItem(uint line, string val)
		{
			string name = GetName(line);
			CpfItem i = dna.GetItem(name);
			if (i==null) 
			{
				i = new CpfItem();
				i.Name = name;
				dna.AddItem(i, false);
			}

			i.StringValue = val;
		}

		public string Hair
		{
			get { return GetItem(1);}
			set { SetItem(1, value); }
		}

		public string SkintoneRange
		{
			get { return GetItem(2);}
			set { SetItem(2, value); }
		}

		public string Eye
		{
			get { return GetItem(3);}
			set { SetItem(3, value); }
		}

		public string FacialFeature
		{
			get { return GetItem(5);}
			set { SetItem(5, value); }
		}

		public string Skintone
		{
			get { return GetItem(6);}
			set { SetItem(6, value); }
		}
		
		internal string Description
		{
			get 
			{
				return SimPe.Serializer.Serialize(this);
			}
		}
	}
	/// <summary>
	/// Contains the SimDNA Data
	/// </summary>
	public class SimDNA : Cpf
	{
		Gene dominant, recessive;
		public SimDNA() : base()
		{
			dominant = new Gene(this, 0);
			recessive = new Gene(this, 0x10000000);
		}

		public Gene Dominant
		{
			get {return dominant;}
		}

		public Gene Recessive
		{
			get {return recessive;}
		}

		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new UserInterface.SimDNAUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Sim DNA Wrapper",
				"Quaxi",
				"This File contains the DNA of a Sim.",
				1,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.dna.png"))				
				);   
		}

		public override byte[] FileSignature
		{
			get
			{
				return new Byte[0];				
			}
		}

		public override uint[] AssignableTypes
		{
			get
			{
				return new uint[]  { Data.MetaData.SDNA };
			}
		}

		public override string DescriptionHeader
		{
			get
			{
				System.Collections.ArrayList list = new System.Collections.ArrayList();
				
				list.Add("Dominant "+Serializer.SerializeTypeHeader(this.Dominant));
				list.Add("Recessive "+Serializer.SerializeTypeHeader(this.Recessive));

				return Serializer.ConcatHeader(Serializer.ConvertArrayList(list));
			}
		}


		public override string Description
		{
			get
			{
				System.Collections.ArrayList list = new System.Collections.ArrayList();
				list.Add(this.Dominant.ToString("Dominant"));
				list.Add(this.Recessive.ToString("Recessive"));

				return Serializer.Concat(Serializer.ConvertArrayList(list));
			}
		}


	}
}
