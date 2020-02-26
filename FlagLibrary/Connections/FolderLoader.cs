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
        XMLLoader xmlLoader = new XMLLoader(new XMLCalcStandard());
        //XMLLoader xmlLoader = new XMLLoader(new XMLVendoStandard());
        LSTLoader lstLoader = new LSTLoader();

        public Dictionary<string, FlagList> GetFlagLists(string folderPath)
        {
            Dictionary<string, FlagList> flagList = new Dictionary<string, FlagList>();

            string[] fileEntries = Directory.GetFiles(folderPath);
            foreach (string fileName in fileEntries)
            {
                Dictionary<string, FlagList> flagLists;
                if (fileName.EndsWith(".xml"))
                {
                    flagLists = xmlLoader.GetFlagLists(fileName);
                }
                else if(fileName.EndsWith(".lst"))
                {
                    flagLists = lstLoader.GetFlagLists(fileName);
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
    }
}
