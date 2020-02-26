using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;
using System.IO;

namespace FlagLibrary.Connections
{
    public class LSTLoader : ILoader
    {
        public Dictionary<string, FlagList> GetFlagListsFromFolder(string folderPath)
        {
            throw new NotSupportedException("GetFlagListsFromFolder supports only Vendo Xmls");
        }

        public Dictionary<string, FlagList> GetFlagLists(string filePath)
        {
            Dictionary<string, FlagList> list = new Dictionary<string, FlagList>();
            //foreach (XmlNode Flag in xmlDoc.DocumentElement.ChildNodes)
            //{
            //    if (ReadFlagHeader(Flag, list))
            //        continue;
            //}
            return list;
        }

        private bool ReadFlagHeader(Dictionary<string, FlagList> list)
        {
            FlagList flagList = new FlagList();
            

            list.Add(flagList.name, flagList);
            return true;
        }

        void GetFlagFromNode()
        {
            
        }
    }
}
