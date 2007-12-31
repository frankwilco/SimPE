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
using System.Text;
using System.Windows.Forms;
using SimPe.Geometry;
using SimPe.Plugin.Anim;
using SimPe.Plugin.Gmdc;

namespace SimPe.Plugin.Gmdc.Exporter
{
    /// <summary>
    /// This class provides the functionality to Export Data to the .obj FileFormat
    /// </summary>
    /// 
    public class GmdcExportToNorm : AbstractGmdcExporter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gmdc">The Gmdc File the Export is based on</param>
        /// <param name="groups">The list of Groups you want to export</param>
        /// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .obj File</remarks>
        public GmdcExportToNorm(GeometryDataContainer gmdc, GmdcGroups groups) : base(gmdc, groups) { }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="gmdc">The Gmdc File the Export is based on</param>
        /// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .obj File</remarks>
        public GmdcExportToNorm(GeometryDataContainer gmdc) : base(gmdc) { }
        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <remarks>The export has to be started Manual through a call to <see cref="AbstractGmdcExporter.Process"/></remarks>
        public GmdcExportToNorm() : base() { }

        //int modelnr, vertexoffset;

        /// <summary>
        /// Returns the suggested File Extension (including the . like .obj or .3ds)
        /// </summary>
        public override string FileExtension
        {
            get { return ".map"; }
        }

        /// <summary>
        /// Returns the File Description (the Name of the exported FileType)
        /// </summary>
        public override string FileDescription
        {
            get { return "BumpMapNormals"; }
        }

        /// <summary>
        /// Returns the name of the Author
        /// </summary>
        public override string Author
        {
            get { return "Skankyboy"; }
        }

        /// <summary>
        /// Called when a new File is started
        /// </summary>
        /// <remarks>
        /// you should use this to write Header Informations. 
        /// Use the writer member to write to the File
        /// </remarks>
        /// 

        protected override void InitFile()
        {
            if (this.Groups.Length > 1) throw new SimPe.Warning("Too Much Meshes Selected", "You've selected too much meshes\nSmd File only support 1 mesh per file");
            else if (this.Groups.Length < 1) throw new SimPe.Warning("No Mesh Selected", "You need to select one mesh");
        }


        /// <summary>
        /// This is called whenever a Group (=subSet) needs to processed
        /// </summary>
        /// <remarks>
        /// You can use the UVCoordinateElement, NormalElement, 
        /// VertexElement, Group and Link Members in this Method. 
        /// 
        /// This Method is only called, when the Group, Link and 
        /// Vertex Members are set (not null). The other still can 
        /// be Null!
        /// 
        /// Use the writer member to write to the File.
        /// </remarks>
        /// 

        //Return a string array with twin values removed
        string[] RemoveDuplicates(string[] tokens)
        {
            ArrayList tempa = new ArrayList();
            for (int i = 0; i < tokens.Length - 1; i++)
                if (tempa.Contains(tokens[i]) == false) tempa.Add(tokens[i]);
            string[] result = new string[tempa.Count];
            for (int i = 0; i < tempa.Count; i++) result[i] = tempa[i].ToString();
            return result;
        }

        //This function create a Vector3f array named verttangent which contain bumpmapnormal value for each vertex
        protected override void ProcessGroup()
        {
            int nr = Link.GetElementNr(VertexElement);
            int nn = Link.GetElementNr(NormalElement);
            int nm = Link.GetElementNr(UVCoordinateElement);

            int nbfaces = Group.Faces.Count / 3;
            int nbvert = Link.ReferencedSize;

            string[] faceforvert = new string[nbvert];

            Vector3f[] facetangent = new Vector3f[nbfaces];
            Vector3f[] verttangent = new Vector3f[nbvert];

            int facenumber = 0;
            for (int i = 0; i < Group.Faces.Count; i += 3)
            {
                int j1 = Group.Faces[i]; // get vertex 1 index number
                int j2 = Group.Faces[i + 1]; // get vertex 2 index number
                int j3 = Group.Faces[i + 2]; // get vertex 3 index number
                faceforvert[j1] += facenumber.ToString() + " "; // add this face number to vert num array
                faceforvert[j2] += facenumber.ToString() + " "; // add this face number to vert num array
                faceforvert[j3] += facenumber.ToString() + " "; // add this face number to vert num array

                //get vert position v1,v2,v3 and vert uvmap uv1,uv2,uv3
                Vector3f v1 = new Vector3f(Link.GetValue(nr, j1).Data[0], Link.GetValue(nr, j1).Data[1], Link.GetValue(nr, j1).Data[2]);
                Vector3f uv1 = new Vector3f(Link.GetValue(nm, j1).Data[0], 1 - Link.GetValue(nm, j1).Data[1], 0);

                Vector3f v2 = new Vector3f(Link.GetValue(nr, j2).Data[0], Link.GetValue(nr, j2).Data[1], Link.GetValue(nr, j2).Data[2]);
                Vector3f uv2 = new Vector3f(Link.GetValue(nm, j2).Data[0], 1 - Link.GetValue(nm, j2).Data[1], 0);

                Vector3f v3 = new Vector3f(Link.GetValue(nr, j3).Data[0], Link.GetValue(nr, j3).Data[1], Link.GetValue(nr, j3).Data[2]);
                Vector3f uv3 = new Vector3f(Link.GetValue(nm, j3).Data[0], 1 - Link.GetValue(nm, j3).Data[1], 0);

                //calculate vectors v1,v2 and uv1 and uv2
                v3 = v3 - v1;
                v1 = v2 - v1;
                v2 = v3;

                uv3 = uv3 - uv1;
                uv1 = uv2 - uv1;
                uv2 = uv3;

                //Calculate Face Tangent "Factor" 
                double r = 1f / (uv1.X * uv2.Y - uv2.X * uv1.Y);

                //correct extrem values of "Factor"
                if (r > (double)10000000000000000)
                    r = (double)10000000000000000;
                if (r < (double)-10000000000000000)
                    r = (double)-10000000000000000;

                //Calculate Face Tangent
                Vector3f tangent = uv2.Y * v1 - uv1.Y * v2;
                tangent = tangent * r;
                facetangent[facenumber] = tangent;

                facenumber++;
            }

            //Search doubled vertices (this algo is very slow but I didn't found other way to do this)
            for (int i = 0; i < nbvert; i++)
            {
                for (int j = 0; j < nbvert; j++)
                {
                    if (i != j &&
                       Link.GetValue(nr, i).Data[0].ToString("N5") == Link.GetValue(nr, j).Data[0].ToString("N5") &&
                       Link.GetValue(nr, i).Data[1].ToString("N5") == Link.GetValue(nr, j).Data[1].ToString("N5") &&
                       Link.GetValue(nr, i).Data[2].ToString("N5") == Link.GetValue(nr, j).Data[2].ToString("N5") &&
                       Link.GetValue(nn, i).Data[0].ToString("N5") == Link.GetValue(nn, j).Data[0].ToString("N5") &&
                       Link.GetValue(nn, i).Data[1].ToString("N5") == Link.GetValue(nn, j).Data[1].ToString("N5") &&
                       Link.GetValue(nn, i).Data[2].ToString("N5") == Link.GetValue(nn, j).Data[2].ToString("N5") &&
                       Link.GetValue(nm, i).Data[0].ToString("N5") == Link.GetValue(nm, j).Data[0].ToString("N5") &&
                       Link.GetValue(nm, i).Data[1].ToString("N5") == Link.GetValue(nm, j).Data[1].ToString("N5"))
                    {
                        faceforvert[i] += faceforvert[j];
                    }
                }
            }

            //Convert Faces Tangent to Vertices Tangent
            for (int i = 0; i < nbvert; i++)
            {
                //Get Gmdc Vertex Normal Informations
                Vector3f vertnormalgmdc = new Vector3f(Link.GetValue(nn, i).Data[0], Link.GetValue(nn, i).Data[1], Link.GetValue(nn, i).Data[2]);

                //Get faces numbers used by this vertex in array faceused
                string[] tokens = faceforvert[i].Split(" ".ToCharArray());
                tokens = RemoveDuplicates(tokens);
                int nbfaceused = tokens.Length;
                int[] faceused = new int[nbfaceused];
                for (int j = 0; j < nbfaceused; j++) faceused[j] = Convert.ToInt16(tokens[j]);

                //Add face tangent for each face used
                Vector3f tangent = new Vector3f(0, 0, 0);
                for (int j = 0; j < nbfaceused; j++)
                    tangent += facetangent[faceused[j]];

                //Finalize tangent calculation
                tangent = tangent.UnitVector;
                tangent = tangent - vertnormalgmdc * (tangent * vertnormalgmdc);
                tangent = tangent.UnitVector;

                verttangent[i] = tangent;
            }

            /* Not needed for internal usage ;)
            //
            //Write each vert tangent in c;\bumpcheck.txt file
            //like this : "VertNumber TangentX TangentY TangentZ"
            StreamWriter sr = new StreamWriter(File.Create("c:\\bumpcheck.txt"));
            for(int i=0; i< nbvert;i++)
                sr.WriteLine(i.ToString()+" "+verttangent[i].ToString2());
            sr.Close();
            //
            */

            //Note : 
            //Algo creation inspired by the one found here : http://www.c4engine.com/code/tangent.html

        }

        protected override void FinishFile()
        {

        }
    }
}




