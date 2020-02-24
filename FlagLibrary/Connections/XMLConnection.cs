using System;
using System.Collections.Generic;
using System.Text;
using FlagLibrary.Flags;

namespace FlagLibrary.Connections
{
    public class XMLConnection
    {
        string filePath = "";

        public XMLConnection(string filePath)
        {
            this.filePath = filePath;
        }

        public FlagList LoadFlagList(string flagListName)
        {
            // TODO: Return some type of object with all data needed to 
            throw new NotImplementedException();
        }

        public Flag MakeFlag(string description)
        {
            Flag flag = new Flag();
            flag.description = description;

            return flag;
        }
    }
}
