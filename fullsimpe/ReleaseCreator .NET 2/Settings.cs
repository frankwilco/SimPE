using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace ReleaseCreator
{
    class Settings
    {
        string rdir, udir, idir;
        string ftpu, ftpp, ftps, ftpd;
        bool autoletter;
        public Settings(String flname)
        {
            System.Xml.XmlDocument xml = new System.Xml.XmlDocument();
            xml.Load(flname);
            rdir = "";
            udir = "";
            idir = "";

            ftpu = "";
            ftpd = "";
            ftpp = "";
            ftps = "";

            autoletter = false;

            XmlNode n = xml.FirstChild;
            StartParsing(n);

            if (udir == "") udir = rdir;
        }

        void StartParsing(XmlNode root)
        {
            foreach (XmlNode n in root.ChildNodes)
            {
                if (n.Name == "ReleasePath") rdir = n.InnerText.Trim();
                else if (n.Name == "UpdateInfoPath") udir = n.InnerText.Trim();
                else if (n.Name == "InnoPath") idir = n.InnerText.Trim();
                else if (n.Name == "FTPServer") ftps = n.InnerText.Trim();
                else if (n.Name == "FTPUser") ftpu = n.InnerText.Trim();
                else if (n.Name == "FTPPassword") ftpp = n.InnerText.Trim();
                else if (n.Name == "FTPPath") ftpd = n.InnerText.Trim();
                else if (n.Name == "AutoSetLetterForQA") autoletter = true;
            }
        }

        public String ReleaseDir
        {
            get {
                return rdir.Trim();
            }
        }

        public String UpdateInfoDir
        {
            get
            {
                return udir.Trim();
            }
        }

        public String InnoDir
        {
            get
            {
                return idir.Trim();
            }
        }

        public String FtpServer
        {
            get
            {
                return ftps;
            }
        }

        public String FtpUser
        {
            get
            {
                return ftpu;
            }
        }

        public String FtpPassword
        {
            get
            {
                return ftpp;
            }
        }

        public String FtpPath
        {
            get
            {
                return ftpd;
            }
        }

        public bool AutoSelectLetter
        {
            get
            {
                return autoletter;
            }
        }
    }
}
