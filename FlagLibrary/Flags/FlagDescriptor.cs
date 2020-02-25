using System;
using System.Collections.Generic;
using System.Text;

namespace FlagLibrary.Flags
{
   
    public class FlagDescriptor
    {
        // includes first bit
        public List<int> bitRefs = new List<int>();
        public string description = "";
        public int maxSize = 1;
        public Dictionary<int, string> bitDescriptions = new Dictionary<int, string>();

        public int GetValue(int i32)
        {
            int value = 0;

            foreach (int bitRef in bitRefs)
            {
                value += GetBit(i32, 1 << bitRef);
            }

            return value;
        }

        public int GetBit(int value, int i32)
        {
            return (value & i32) != 0 ? 1 : 0;
        }
    }
}
