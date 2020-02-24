using System;
using System.Collections.Generic;
using System.Text;
using FlagLibrary.Connections;
using System.Xml;

namespace FlagLibrary.Flags
{
    public class FlagList
    {
        public string name;
        public Dictionary<int, FlagDescriptor> flags = new Dictionary<int, FlagDescriptor>();
    }
}
