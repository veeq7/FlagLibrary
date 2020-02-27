using FlagLibrary.Flags;
using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using FlagLibrary.Utils;

namespace FlagLibrary.Connections
{
    public class FolderLoader : ILoader
    {
        ILoader xmlLoader = new XMLDynamicLoader();
        ILoader lstLoader = new LSTLoader();

        public Dictionary<string, FlagList> GetFlagLists(string folderPath)
        {
            Dictionary<string, FlagList> flagList = new Dictionary<string, FlagList>();

            string[] fileEntries = Directory.GetFiles(folderPath);
            foreach (string fileName in fileEntries)
            {
                Dictionary<string, FlagList> flagLists = new Dictionary<string, FlagList>();
                if (fileName.EndsWith(".xml"))
                {
                    AddToFlagList(flagList, xmlLoader.GetFlagLists(fileName));
                }
                else
                {
                    continue;
                }

                foreach (KeyValuePair<string, FlagList> kv in flagLists)
                {
                    flagList.Add(kv.Key, kv.Value);
                }
            }

            string[] subdirectoryEntries = Directory.GetDirectories(folderPath);
            foreach (string subdirectory in subdirectoryEntries)
            {
                GetFlagLists(subdirectory);
            }

            return flagList;
        }

        void AddToFlagList(Dictionary<string, FlagList> source, Dictionary<string, FlagList> target)
        {
            foreach (KeyValuePair<string, FlagList> kv in source)
                target.Add(kv.Key, kv.Value);
        }
    }
}
