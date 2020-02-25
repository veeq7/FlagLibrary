using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using FlagLibrary.Flags;
using System.Windows.Forms;
using System.Linq;

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

        public List<FlagList> GetFlagLists()
        {
            List<FlagList> list = new List<FlagList>();
            foreach (XmlNode Flag in xmlDoc.DocumentElement.ChildNodes)
            {
                if (Flag.Name == "Flag")
                {
                    FlagList flagList = new FlagList();
                    flagList.name = Flag.Attributes["Column"].Value;
                    foreach (XmlNode Bit in Flag.ChildNodes)
                    {
                        if (Bit.Name != "Bit")
                            continue;

                        FlagDescriptor flag = MakeFlag(Bit);
                        flagList.flags.Add(flag);
                    }
                    list.Add(flagList);
                }
            }
            return list;
        }

        FlagDescriptor MakeFlag(XmlNode Bit)
        {
            FlagDescriptor flag = new FlagDescriptor();
            string[] indexes = Bit.Attributes["Index"].Value.Split(',');
            flag.bitID = int.Parse(indexes[0]);
            flag.bitRefs = GetBitRefs(indexes);
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
