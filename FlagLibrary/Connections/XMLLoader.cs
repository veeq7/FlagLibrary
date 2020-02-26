using FlagLibrary.Flags;
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using FlagLibrary.Utils;

namespace FlagLibrary.Connections
{
    public class XMLStandard
    {
        public bool hasTableNode = false;
        public string TableNode = "";
        public string BitNode = "";
        public string FlagNode = "";
        public string DescriptionNode = "";
        public string OptionNode = "";
        public string ColumnAttr = "";
        public string IndexAttr = "";
    }

    // Used by Vendo Programmers
    public class XMLVendoStandard : XMLStandard
    {
        public XMLVendoStandard()
        {
            BitNode = "Flag";
            FlagNode = "Column";
            DescriptionNode = "Comment";
            OptionNode = "Option";
            ColumnAttr = "Name";
            IndexAttr = "Index";
            hasTableNode = true;
            TableNode = "Table";
    }
    }
    
    // Used by BitwiseCalculator app
    public class XMLCalcStandard : XMLStandard
    {
        public XMLCalcStandard()
        {
            BitNode = "Bit";
            FlagNode = "Flag";
            DescriptionNode = "Comment";
            OptionNode = "Option";
            ColumnAttr = "Column";
            IndexAttr = "Index";
        }
    }

    public class XMLLoader : ILoader
    {
        XMLStandard standard;

        public XMLLoader(XMLStandard standard)
        {
            this.standard = standard;
        }
        public Dictionary<string, FlagList> GetFlagLists(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Dictionary<string, FlagList> list = new Dictionary<string, FlagList>();
            if (xmlDoc.ChildNodes.Count == 0) return list;
            foreach (XmlNode Flag in xmlDoc.DocumentElement.ChildNodes)
            {
                if (standard.hasTableNode)
                {
                    if (Flag.Name == standard.TableNode)
                        if (TryReadFlag(Flag, list))
                            continue;
                }
                if (TryReadFlag(Flag, list))
                    continue;
            }
            return list;
        }

        private bool TryReadFlag(XmlNode Flag, Dictionary<string, FlagList> list)
        {
            if (Flag.Name != standard.FlagNode)
                return false;

            FlagList flagList = new FlagList();
            flagList.name = Flag.Attributes[standard.ColumnAttr].Value;
            foreach (XmlNode Bit in Flag.ChildNodes)
            {
                if (Bit.Name != standard.BitNode)
                    continue;

                BitGroup flag = GetFlagFromNode(Bit);
                flagList.flags.Add(flag.bitRefs[0], flag);
            }

            if (flagList.flags.Count > 0) list.Add(flagList.name, flagList);
            return true;
        }

        BitGroup GetFlagFromNode(XmlNode Bit)
        {
            BitGroup flag = new BitGroup();
            string[] indexes = Bit.Attributes[standard.IndexAttr].Value.Split(',');
            flag.bitRefs = CommonUtils.ParseStringArrayToIntArray(indexes);
            foreach (XmlNode Attribute in Bit.ChildNodes)
            {
                if (Attribute.Name == standard.DescriptionNode)
                {
                    flag.description = Attribute.InnerText;
                }
                else if (Attribute.Name == standard.OptionNode)
                {
                    flag.bitDescriptions.Add(int.Parse(Attribute.Attributes["value"].Value), Attribute.InnerText);
                }
            }
            flag.FillDescriptions();
            return flag;
        }
    }
}
