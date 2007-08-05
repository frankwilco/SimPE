using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SimPe.Data
{

    public class SemiGlobalListing : System.Collections.Generic.List<SemiGlobalAlias>
    {
        string flname;
        public SemiGlobalListing() : this(Helper.SimPeSemiGlobalFile) { }

        public SemiGlobalListing(string flname)
        {
            this.flname = flname;
            LoadXML();
        }

        void LoadXML()
        {
            //read XML File
            System.Xml.XmlDocument xmlfile = new XmlDocument();
            xmlfile.Load(flname);

            //seek Root Node
            XmlNodeList XMLData = xmlfile.GetElementsByTagName("semiglobals");

            //Process all Root Node Entries
            for (int i = 0; i < XMLData.Count; i++)
            {
                XmlNode node = XMLData.Item(i);
                foreach (XmlNode subnode in node.ChildNodes)
                    ProcessItem(subnode);
                
            }
        }

        void ProcessItem(XmlNode node)
        {
            bool known = false;
            uint group = 0;
            string name = "";
            foreach (XmlNode subnode in node)
            {
                if (subnode.Name == "known")
                {
                    known = true;
                }
                else if (subnode.Name == "group")
                {
                    group = Helper.StringToUInt32(subnode.InnerText, 0, 16);
                }
                else if (subnode.Name == "name")
                {
                    name = subnode.InnerText.Trim();
                }
            }

            if (name!="" && group !=0)
                this.Add(new SemiGlobalAlias(known, group, name));
        }
    }
}
