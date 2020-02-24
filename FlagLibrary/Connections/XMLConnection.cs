using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using FlagLibrary.Flags;
using System.Windows.Forms;

namespace FlagLibrary.Connections
{
    public class XMLConnection
    {
        string filePath = "";
        XmlDocument xmlDoc;

        public XMLConnection(string filePath)
        {
            this.filePath = filePath;
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

                        FlagDescriptor flag = MakeFlag(Bit, ref flagList);
                    }
                    list.Add(flagList);
                }
            }
            return list;
        }

        FlagDescriptor MakeFlag(XmlNode Bit, ref FlagList flagList)
        {
            FlagDescriptor flag = new FlagDescriptor();
            string[] indexes = Bit.Attributes["Index"].Value.Split(',');
            flag.bitID = int.Parse(Bit.Attributes["Index"].Value.Split(',')[0]);
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
            flagList.flags.Add(flag.bitID, flag);
            return flag;
        }
    }
}
