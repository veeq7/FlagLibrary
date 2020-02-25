using FlagLibrary.Flags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace FlagLibrary.Connections
{
    public class XMLLoader
    {
        XmlDocument xmlDoc = new XmlDocument();

        public XMLLoader(string filePath)
        {
            try
            {
                xmlDoc.Load(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public Dictionary<string, FlagList> GetFlagLists()
        {
            Dictionary<string, FlagList> list = new Dictionary<string, FlagList>();
            foreach (XmlNode Flag in xmlDoc.DocumentElement.ChildNodes)
            {
                if (ReadFlagHeader(Flag, list))
                    continue;
            }
            return list;
        }

        private bool ReadFlagHeader(XmlNode Flag, Dictionary<string, FlagList> list)
        {
            if (Flag.Name != "Flag")
                return false;

            FlagList flagList = new FlagList();
            flagList.name = Flag.Attributes["Column"].Value;
            foreach (XmlNode Bit in Flag.ChildNodes)
            {
                if (Bit.Name != "Bit")
                    continue;

                BitGroup flag = GetFlagFromNode(Bit);
                flagList.flags.Add(flag.bitRefs[0], flag);
            }

            list.Add(flagList.name, flagList);
            return true;
        }

        BitGroup GetFlagFromNode(XmlNode Bit)
        {
            BitGroup flag = new BitGroup();
            string[] indexes = Bit.Attributes["Index"].Value.Split(',');
            flag.bitRefs = GetBitRefs(indexes);
            flag.maxSize = flag.bitRefs.Count() << 0;
            foreach (XmlNode Attribute in Bit.ChildNodes)
            {
                if (Attribute.Name == "Comment")
                {
                    flag.description = Attribute.InnerText;
                }
                else if (Attribute.Name == "Option")
                {
                    flag.bitDescriptions.Add(int.Parse(Attribute.Attributes["value"].Value), Attribute.InnerText);
                }
            }
            if (flag.bitDescriptions.Count == 0)
            {
                flag.SetDefaultBitDescriptions();
            }
            return flag;
        }

        List<int> GetBitRefs(string[] indexes)
        {
            List<int> list = new List<int>();
            foreach (string index in indexes)
            {
                list.Add(int.Parse(index));
            }
            return list;
        }
    }
}
