/***************************************************************************
 *   Copyright (C) 2008 by Peter L Jones                                   *
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
using System.Collections.Generic;
using System.Text;
using System.Xml;
using SimPe.Interfaces.Plugin;

namespace SimPe.Wants
{
    public class XWNTWrapper : pjse.ExtendedWrapper<XWNTItem, XWNTWrapper>, IFileWrapper, IFileWrapperSaveExtension
    {
        #region Attributes
        private string version;
        #endregion

        #region Accessor Methods
        public string Version { get { return version; } set { if (version != value) { setVersion(value); OnWrapperChanged(this, new EventArgs()); } } }
        void setVersion(string value) { if (IsValidVersion(value)) version = value; else throw new ArgumentOutOfRangeException("version"); }
        #endregion

        #region ValidVersions
        static List<string> lValidVersions = null;
        public static List<String> ValidVersions
        {
            get
            {
                if (lValidVersions == null)
                    lValidVersions = new List<string>(new string[]{
                        "5",
                        "6",
                        "7",
                    });
                return lValidVersions;
            }
        }
        static bool IsValidVersion(string value) { return ValidVersions.Contains(value); }
        #endregion


        public XWNTWrapper()
            : base()
        {
            version = "7";
            items.Add(new XWNTItem(this, "<!--editor parameters-->", ""));
            items.Add(new XWNTItem(this, "id", "0x00000000"));
            items.Add(new XWNTItem(this, "folder", "folder"));
            items.Add(new XWNTItem(this, "nodeText", "nodeText"));
            items.Add(new XWNTItem(this, "<!--primaryIcon: used in UI when there is a single icon shown-->", ""));
            items.Add(new XWNTItem(this, "primaryIcon", "0x00000000"));
            items.Add(new XWNTItem(this, "<!--secondaryIcon: used in UI when there are two icons, e.g., if a person is the primary icon-->", ""));
            items.Add(new XWNTItem(this, "secondaryIcon", "0x00000000"));
            items.Add(new XWNTItem(this, "<!--Game Edition Flag to determine if the Want should be loaded by the Simulator-->", ""));
            items.Add(new XWNTItem(this, "gameVersionFlags", "1"));
            items.Add(new XWNTItem(this, "<!--stringSet: a 15 bit GUID that points to a string set resource.-->", ""));
            items.Add(new XWNTItem(this, "stringSet", "0x0B36"));
            items.Add(new XWNTItem(this, "checkTree", "checkTree"));
            items.Add(new XWNTItem(this, "feedbackTree", "feedbackTree"));
            items.Add(new XWNTItem(this, "simArrayTree", "simArrayTree"));
            items.Add(new XWNTItem(this, "level", XWNTItem.ValidLevels[0]));
            items.Add(new XWNTItem(this, "score", "0"));
            items.Add(new XWNTItem(this, "influence", "0"));
            items.Add(new XWNTItem(this, "<!--Node Properties-->", ""));
            items.Add(new XWNTItem(this, "objectType", XWNTItem.ValidObjectTypes[0]));
            items.Add(new XWNTItem(this, "integerType", XWNTItem.ValidIntegerTypes[0]));
            items.Add(new XWNTItem(this, "integerMultiplier", "1"));
            items.Add(new XWNTItem(this, "integerOperator", XWNTItem.ValidIntegerOperators[0]));
            items.Add(new XWNTItem(this, "<!--Event Properties-->", ""));
            items.Add(new XWNTItem(this, "eventRequiresObject", Boolean.FalseString));
            items.Add(new XWNTItem(this, "eventRequiresSim", Boolean.FalseString));
            items.Add(new XWNTItem(this, "deprecated", Boolean.FalseString));
            this.SynchronizeUserData();
        }

        protected override void Unserialize(System.IO.BinaryReader reader)
        {
            items = new List<XWNTItem>();

            #region Un-break Quaxified XWNTs
            // Because Quaxi's CPF wrapper rewrites XML as binary, we handle that case here
            byte[] hdr = reader.ReadBytes(6);
			reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

            bool isCpf = true;
            byte[] id = new byte[] { 0xE0, 0x50, 0xE7, 0xCB, 0x02, 0x00, };
            for (int i = 0; i < hdr.Length && isCpf; i++) isCpf = hdr[i] == id[i];

            if (isCpf)
            {
                SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
                cpf.ProcessData(this.FileDescriptor, this.Package);
                XWNTWrapper xwnt = new XWNTWrapper();
                foreach (XWNTItem item in xwnt)
                {
                    if (item.Key.StartsWith("<!"))
                        Add(new XWNTItem(this, item.Key, ""));
                    else
                    {
                        SimPe.PackedFiles.Wrapper.CpfItem cpfitem = cpf.GetItem(item.Key);
                        if (cpfitem != null)
                        {
                            string value = "";
                            switch (cpfitem.Datatype) // Argh... So broken...
                            {
                                case SimPe.Data.MetaData.DataTypes.dtInteger: value = cpfitem.IntegerValue.ToString(); break;
                                case SimPe.Data.MetaData.DataTypes.dtBoolean: value = cpfitem.BooleanValue.ToString(); break;
                                default: value = cpfitem.StringValue; break;
                            }
                            items.Add(new XWNTItem(this, item.Key, value));
                        }
                        else
                            items.Add(new XWNTItem(this, item.Key, item.Value));
                    }
                }
                return;
            }
            #endregion

            XmlReaderSettings xrs = new XmlReaderSettings();
            //xrs.IgnoreComments = true;
            xrs.IgnoreProcessingInstructions = true;
            xrs.IgnoreWhitespace = true;
            XmlReader xr = XmlReader.Create(reader.BaseStream, xrs);

            if (xr.IsStartElement() && xr.NodeType.Equals(XmlNodeType.Element) && xr.Name.Equals("cGZPropertySetString"))
                setVersion(xr["version"]);
            else throw new Exception("Invalid XWNT format");
            xr.Read();

            while (xr.IsStartElement())
            {
                items.Add(new XWNTItem(this, xr));

                if (!xr.IsEmptyElement)
                    xr.ReadEndElement();
                else
                    xr.Skip();
            }
            xr.ReadEndElement();
        }

        protected override void Serialize(System.IO.BinaryWriter writer)
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Encoding = Encoding.ASCII;
            xws.Indent = true;
            XmlWriter xw = XmlWriter.Create(writer.BaseStream);

            xw.WriteStartElement("cGZPropertySetString");
            xw.WriteAttributeString("version", version);
            foreach (XWNTItem xi in this)
            {
                if (xi.Key.StartsWith("<"))
                    xw.WriteRaw("  " + xi.Key);
                else
                {
                    xw.WriteStartElement(xi.Stype);
                    xw.WriteAttributeString("key", xi.Key);
                    xw.WriteAttributeString("type", xi.Utype);
                    if (xi.Value.Length > 0)
                        xw.WriteValue(xi.Value);
                    xw.WriteEndElement();
                }
            }
            xw.WriteEndElement();
            xw.Flush();
        }

        protected override IPackedFileUI CreateDefaultUIHandler() { return new XWNTEditor(); }

        /// <summary>
        /// Returns a Human Readable Description of this Wrapper
        /// </summary>
        /// <returns>Human Readable Description</returns>
        protected override IWrapperInfo CreateWrapperInfo()
        {
            return new AbstractWrapperInfo(
                "PJSE XWNT Wrapper",
                "Peter L Jones",
                "",
                1
                );
        }

        public const uint XWNTType = 0xED7D7B4D;
        #region IFileWrapper Member
        /// <summary>
        /// Returns a list of File Types this Plugin can process
        /// </summary>
        public uint[] AssignableTypes { get { return new uint[] { XWNTType, }; } }

        /// <summary>
        /// Returns the Signature that can be used to identify Files processable with this Plugin
        /// </summary>
        public byte[] FileSignature { get { return new byte[0]; } }

        #endregion

        #region IFileWrapperSaveExtension Member
        protected override string GetResourceName(Data.TypeAlias ta)
        {
            //if (!SimPe.Helper.FileFormat) return base.GetResourceName(ta);
            if (!this.Processed) this.ProcessData(FileDescriptor, Package);
            string s = "";
            if (SimPe.Helper.FileFormat) s += version + ":";
            if (this["objectType"] != null) s += (s.Length > 0 ? " " : "") + "(" + this["objectType"].Value + ")";
            if (this["folder"] != null) s += (s.Length > 0 ? " " : "") + this["folder"].Value;
            if (this["nodeText"] != null) s += (s.Length > 0 ? " / " : "") + this["nodeText"].Value;
            return s;
        }
        #endregion

        public XWNTItem this[string value] { get { foreach (XWNTItem xi in this) if (xi.Key.Equals(value)) return xi; return null; } }
    }

    public class XWNTItem : pjse.ExtendedWrapperItem<XWNTWrapper, XWNTItem>
    {
        #region Attributes
        string key;
        string type;
        string utype;
        string value;
        #endregion

        #region Accessor Methods
        public string Key { get { return key; } set { if (key != value) { setKey(value); parent.OnWrapperChanged(this, new EventArgs()); } } }
        void setKey(string value) { if (value.StartsWith("<!") || IsValidKey(value)) key = value; else throw new ArgumentOutOfRangeException("key"); }

        public string Stype { get { return type; } set { if (type != value) { setType(value); parent.OnWrapperChanged(this, new EventArgs()); } } }
        void setType(string value) { if (IsValidType(value)) this.type = value; else throw new ArgumentOutOfRangeException("type"); }

        public string Utype { get { return utype; } set { if (utype != value) { setUtype(value); parent.OnWrapperChanged(this, new EventArgs()); } } }
        void setUtype(string value) { if (IsValidUtype(type, value)) this.utype = value; else throw new ArgumentOutOfRangeException("utype"); }

        public string Value { get { return value; } set { if (this.value != value) { setValue(value); parent.OnWrapperChanged(this, new EventArgs()); } } }
        void setValue(string value)
        {
            switch (key)
            {
                case "integerOperator": if (!IsValidIntegerOperator(value)) throw new ArgumentOutOfRangeException("value (integerOperator)"); break;
                case "integerType": if (!IsValidIntegerType(value)) throw new ArgumentOutOfRangeException("value (integerType)"); break;
                case "level": if (!IsValidLevel(value)) throw new ArgumentOutOfRangeException("value (level)"); break;
                case "objectType": if (!IsValidObjectType(value)) throw new ArgumentOutOfRangeException("value (objectType)"); break;
                default:
                    switch (type)
                    {
                        case "AnyBoolean": Convert.ToBoolean(value); break;
                        case "AnySint32": Convert.ToInt32(value); break;
                        case "AnyString": break;
                        case "AnyUint32": Convert.ToUInt32(value, value.StartsWith("0x") ? 16 : 10); break;
                    }
                    break;
            }
            this.value = value;
        }
        #endregion

        /// <summary>
        /// Create a new XWNTItem from an XML stream
        /// </summary>
        /// <param name="parent">The XWNT owning this XWNTItem</param>
        /// <param name="xr">The XML stream</param>
        /// <remarks>Set item&apos;s <paramref name="parent"/> and calls <see cref="Unserialize"/> with <paramref name="xr"/></remarks>
        public XWNTItem(XWNTWrapper parent, XmlReader xr)
        {
            this.parent = parent;
            Unserialize(xr);
        }
        /// <summary>
        /// Create an XWNTItem
        /// </summary>
        /// <param name="parent">The XWNT owning this XWNTItem</param>
        /// <param name="key">Either an XML comment or a valid XWNTItem key</param>
        /// <param name="value">A valid value for this key and type</param>
        public XWNTItem(XWNTWrapper parent, string key, string value)
        {
            this.parent = parent;
            setKey(key);
            if (key.StartsWith("<!")) return;

            setType(StypeForKey(key));
            setUtype(TypeUtype[type]);
            setValue(value);
        }

        private void Unserialize(XmlReader xr)
        {
            if (!xr.NodeType.Equals(XmlNodeType.Element)) setKey(xr.ReadOuterXml());
            else
            {
                setKey(xr["key"]);
                setType(xr.Name);
                setUtype(xr["type"]);
                setValue(xr.ReadString());
            }
        }

        #region IsUint32Long
        private static Dictionary<string, bool> lLongUint32 = null;
        private static Dictionary<string, bool> LongUint32
        {
            get
            {
                if (lLongUint32 == null)
                {
                    lLongUint32 = new Dictionary<string, bool>();
                    lLongUint32.Add("id", true);
                    lLongUint32.Add("primaryIcon", true);
                    lLongUint32.Add("secondaryIcon", true);
                }
                return lLongUint32;
            }
        }
        public static bool IsUint32Long(string value) { return LongUint32.ContainsKey(value) && LongUint32[value]; }
        #endregion

        #region ValidKeys
        private static Dictionary<string, string> lKeyType = null;
        private static Dictionary<string, string> KeyType
        {
            get
            {
                if (lKeyType == null)
                {
                    lKeyType = new Dictionary<string, string>();
                    lKeyType.Add("checkTree", "AnyString");
                    lKeyType.Add("deprecated", "AnyBoolean");
                    lKeyType.Add("eventRequiresObject", "AnyBoolean");
                    lKeyType.Add("eventRequiresSim", "AnyBoolean");
                    lKeyType.Add("feedbackTree", "AnyString");
                    lKeyType.Add("folder", "AnyString");
                    lKeyType.Add("gameVersionFlags", "AnyUint32");
                    lKeyType.Add("id", "AnyUint32");
                    lKeyType.Add("influence", "AnySint32");
                    lKeyType.Add("integerMultiplier", "AnySint32");
                    lKeyType.Add("integerOperator", "AnyString");
                    lKeyType.Add("integerType", "AnyString");
                    lKeyType.Add("level", "AnyString");
                    lKeyType.Add("nodeText", "AnyString");
                    lKeyType.Add("objectType", "AnyString");
                    lKeyType.Add("primaryIcon", "AnyUint32");
                    lKeyType.Add("score", "AnySint32");
                    lKeyType.Add("secondaryIcon", "AnyUint32");
                    lKeyType.Add("simArrayTree", "AnyString");
                    lKeyType.Add("stringSet", "AnyUint32");
                }
                return lKeyType;
            }
        }
        public static List<string> ValidKeys { get { return new List<string>(KeyType.Keys); } }
        private static bool IsValidKey(string value) { return KeyType.ContainsKey(value); }
        public static string StypeForKey(string key) { string stype; if (KeyType.TryGetValue(key, out stype)) return stype; else throw new ArgumentOutOfRangeException("key"); }
        #endregion

        #region Valid Types and Utypes
        private static Dictionary<string, string> lTypeUtype = null;
        private static Dictionary<string, string> TypeUtype
        {
            get
            {
                if (lTypeUtype == null)
                {
                    lTypeUtype = new Dictionary<string, string>();
                    lTypeUtype.Add("AnyBoolean", "0xcba908e1");
                    lTypeUtype.Add("AnySint32", "0x0c264712");
                    lTypeUtype.Add("AnyString", "0x0b8bea18");
                    lTypeUtype.Add("AnyUint32", "0xeb61e4f7");
                }
                return lTypeUtype;
            }
        }
        public static List<string> ValidTypes { get { return new List<string>(TypeUtype.Keys); } }
        public static List<string> ValidUtypes { get { return new List<string>(TypeUtype.Values); } }
        private static bool IsValidType(string value) { return TypeUtype.ContainsKey(value); }
        private static bool IsValidUtype(string type, string value) { return IsValidType(type) && TypeUtype[type].Equals(value); }
        #endregion

        #region ValidIntegerOperators
        static List<string> lValidIntegerOperators = null;
        public static List<String> ValidIntegerOperators
        {
            get
            {
                if (lValidIntegerOperators == null)
                    lValidIntegerOperators = new List<string>(new string[]{
                        "None",
                        "Equals",
                        "Greater_Then_Or_Equals",
                        "Less_Then",
                    });
                return lValidIntegerOperators;
            }
        }
        static bool IsValidIntegerOperator(string value) { return ValidIntegerOperators.Contains(value); }
        #endregion

        #region ValidIntegerTypes
        static List<string> lValidIntegerTypes = null;
        public static List<String> ValidIntegerTypes
        {
            get
            {
                if (lValidIntegerTypes == null)
                    lValidIntegerTypes = new List<string>(new string[]{
                        "None",
                        "Number",
                    });
                return lValidIntegerTypes;
            }
        }
        static bool IsValidIntegerType(string value) { return ValidIntegerTypes.Contains(value); }
        #endregion

        #region ValidLevels
        static List<string> lValidLevels = null;
        public static List<String> ValidLevels
        {
            get
            {
                if (lValidLevels == null)
                    lValidLevels = new List<string>(new string[]{
                        "Memorable",
                        "Power",
                        "Transitory",
                    });
                return lValidLevels;
            }
        }
        static bool IsValidLevel(string value) { return ValidLevels.Contains(value); }
        #endregion

        #region ValidObjectTypes
        static List<string> lValidObjectTypes = null;
        public static List<String> ValidObjectTypes
        {
            get
            {
                if (lValidObjectTypes == null)
                    lValidObjectTypes = new List<string>(new string[]{
                        "Badge",
                        "Career",
                        "Category",
                        "Guid",
                        "None",
                        "Sim",
                        "Skill",
                    });
                return lValidObjectTypes;
            }
        }
        static bool IsValidObjectType(string value) { return ValidObjectTypes.Contains(value); }
        #endregion
    }
}
