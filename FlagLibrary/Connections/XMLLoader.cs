using FlagLibrary.Flags;
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Windows.Forms;

namespace FlagLibrary.Connections
{
    public class XMLLoader
    {

        public Dictionary<string, FlagList> GetFlagListsFromFolder(string folderPath)
        {
            Dictionary<string, FlagList> flagList = new Dictionary<string, FlagList>();

            string[] fileEntries = Directory.GetFiles(folderPath);
            foreach (string fileName in fileEntries)
            {
                if (fileName.EndsWith(".xml"))
                {
                    foreach (KeyValuePair<string, FlagList> kv in GetFlagLists(fileName))
                    {
                        flagList.Add(kv.Key, kv.Value);
                    }
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(folderPath);
            foreach (string subdirectory in subdirectoryEntries)
            {
                GetFlagListsFromFolder(subdirectory);
            }

            return flagList;
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
                flag.FillDescriptions();
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
