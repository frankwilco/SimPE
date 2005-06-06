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

namespace SimPe.Geometry
{
	/// <summary>
	/// Zusammenfassung für Matrices.
	/// </summary>
	public class Matrixd
	{
		double[][] m;
		/// <summary>
		/// Representation of a Matrix
		/// </summary>
		/// <param name="col">Number of Columns</param>
		/// <param name="row">Number of Rows</param>
		/// <remarks>Minimum is a 1x1 (rowxcol)Matrix</remarks>
		public Matrixd(int row, int col)
		{
			m = new double[row][];
			for (int i=0; i<row; i++) 
				m[i] = new double[col];
		}

		/// <summary>
		/// Create a new 3x1 Matrix
		/// </summary>
		/// <param name="v">the vecotor that should be represented as a Matrix</param>
		public Matrixd(Vector3f v) : this(3, 1)
		{
			this[0,0] = v.X;
			this[1,0] = v.Y;
			this[2,0] = v.Z;
		}

		/// <summary>
		/// Returns the Vector stored in this matrix or null if not possible!
		/// </summary>
		/// <returns></returns>
		public Vector3f GetVector()
		{
			if ((Rows!=3 || Columns!=1) && ((Rows!=1 || Columns!=3)))return null;
			if (Rows==3) return new Vector3f(m[0][0], m[1][0], m[2][0]);
			return new Vector3f(m[0][1], m[0][1], m[0][2]);
		}

		/// <summary>
		/// Create the Transpose of this Matrix
		/// </summary>
		public Matrixd GetTranspose()
		{
			Matrixd res = new Matrixd(Rows, Columns);
			for (int r=0; r<Rows; r++) 
				for (int c=0; c<Columns; c++) 
					res[c, r] = this[r, c];				

			return res;
		}

		/// <summary>
		/// Create an identity Mareix
		/// </summary>
		/// <param name="row"></param>
		/// <param name="col"></param>
		/// <returns></returns>
		public static Matrixd GetIdentity(int row, int col)
		{
			Matrixd i = new Matrixd(row, col);
			
			for (int r=0; r<row; r++) 
				for (int c=0; c<col; c++) 
				{
					if (r==c) i[r, c] = 1;
					else i[r, c] = 0;
				}

			return i;
		}

		/// <summary>
		/// Number of stored Rows
		/// </summary>
		public int Rows 
		{
			get { return m.Length; }
		}

		/// <summary>
		/// Numbner of stored Columns
		/// </summary>
		public int Columns 
		{
			get {
				if (Rows==0) return 0;
				return m[0].Length; 
			}
		}

		/// <summary>
		/// Integer Indexer (row, column)
		/// </summary>
		public double this[int row, int col]
		{
			get { return m[row][col]; }
			set { m[row][col] = value;; }
		}		

		/// <summary>
		/// SMatirx Multiplication
		/// </summary>
		/// <param name="m1">First Matrix</param>
		/// <param name="m2">Second Matrix</param>
		/// <returns>The resulting Matrix</returns>
		public static Matrixd operator *(Matrixd m1, Matrixd m2) 
		{
			if (m1.Columns!=m2.Rows) throw new Exception("Unable to multiplicate Matrices (" + m1.ToString()+" * "+m2.ToString()+")");

			Matrixd m = new Matrixd(m1.Rows, m2.Columns);
			for (int r=0; r<m.Rows; r++) 
				for (int c=0; c<m.Columns; c++)
				{
					double res = 0;
 
					for (int i=0; i<m1.Columns; i++)
						//for (int j=0; j<m2.Rows; j++) 
						{
							res += m1[r, i] * m2[i, c];
						}//for m1, m2

					m[r, c] = res;
				}//for m
			return m;
		}

		public override string ToString()
		{
			return Rows+"x"+Columns+"-Matrix";
		}


		/// <summary>
		/// SMatirx Multiplication
		/// </summary>
		/// <param name="m1">First Matrix</param>
		/// <param name="v">Vector</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator *(Matrixd m1, Vector3f v) 
		{
			Matrixd m2 = new Matrixd(v);
			m2 = m1 * m2;
			return m2.GetVector();
		}
	}
}
