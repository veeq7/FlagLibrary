using System;
using System.Collections.Generic;
using System.Text;

namespace FlagLibrary.Flags
{
   
    public class FlagDescriptor
    {
        public int bitID = -1;
        public List<int> bitRefs = new List<int>();
        public string description = "";
        public Dictionary<int, string> bitDescriptions = new Dictionary<int, string>();
    }
}
