using System;
using System.Collections.Generic;
using System.Text;
using FlagLibrary.Connections;
using System.Xml;

namespace FlagLibrary.Flags
{
    public class FlagList
    {
        public Dictionary<int, Flag> flags = new Dictionary<int, Flag>();

        void Load(XMLConnection c, string column)
        {
            // TODO: Handle XML data of flag types, make Flag objects
        }
        
        string Parse(Flag value)
        {
            // TODO: Add parsing by flaglist
            /* Apply format:
             * 
             * {flags[0].name} : {true/false}
             * {flags[1].name} : {true/false}
             * {flags[2].name} : {true/false}
             * {flags[3].name} : {true/false}
             * 
             */

            return "";
        }
    }
}
