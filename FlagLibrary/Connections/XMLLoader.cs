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
        public string FlagGroupNode = "";
        
        public string DescriptionNode = "Comment";
        public string OptionNode = "Option";
        public string ValueNode = "";
        public string BitNode = "";
        public string NameAttr = "";
        public string IndexAttr = "Index";
    }

    // Used by Vendo Programmers
    public class XMLVendoStandard : XMLStandard
    {
        public XMLVendoStandard()
        {
            NameAttr = "Name";
            FlagGroupNode = "//Column";
            ValueNode = "Value";
            BitNode = "Flag";
        }
    }

    // Used by BitwiseCalculator app
    public class XMLCalcStandard : XMLStandard
    {
        public XMLCalcStandard()
        {
            NameAttr = "Column";
            FlagGroupNode = "//Flag";
            ValueNode = "value";
            BitNode = "Bit";
        }
    }

    public class XMLDynamicLoader : ILoader
    {
        public XMLDynamicLoader()
        {
        
        }

        public Dictionary<string, FlagList> GetFlagLists(string filePath)
        {
            Dictionary<string, FlagList> list;
            XMLLoader loader = new XMLLoader(new XMLCalcStandard());
            list = loader.GetFlagLists(filePath);
            if (list.Count == 0)
            {
                loader = new XMLLoader(new XMLVendoStandard());
                list = loader.GetFlagLists(filePath);
            }

            return list;
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
            foreach (XmlNode Flag in xmlDoc.SelectNodes(standard.FlagGroupNode))
            {
                FlagList flagList = new FlagList();
                try // this is needed for dynamic loader to work
                {
                    flagList.name = Flag.Attributes[standard.NameAttr].Value;
                }
                catch
                {
                    return list;
                }
                foreach (XmlNode Bit in Flag.ChildNodes)
                {
                    BitGroup flag = GetFlagFromNode(Bit);
                    if (flag == null) continue;
                    flagList.flags.Add(flag.bitRefs[0], flag);
                }

                if (flagList.flags.Count > 0) list.Add(flagList.name, flagList);
            }
            return list;
        }

        BitGroup GetFlagFromNode(XmlNode Bit)
        {
            if (Bit.Name != standard.BitNode) return null;
            BitGroup flag = new BitGroup();
            if (Bit.Attributes[standard.IndexAttr] == null) return null;
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
                    flag.bitDescriptions.Add(int.Parse(Attribute.Attributes[standard.ValueNode].Value), Attribute.InnerText);
                }
            }
            flag.FillDescriptions();
            return flag;
        }
    }
}
