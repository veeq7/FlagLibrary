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

        /*
        public int value = 0;
        public void SetBit(int bit, bool value)
        {
            if (value)
            {
                this.value |= FlagUtils.GetFlagBit(bit);
            } else
            {
                this.value &= ~(FlagUtils.GetFlagBit(bit));
            }
        }

        public int GetBit(int bit)
        {
            return value | FlagUtils.GetFlagBit(bit);
        }

        // Sets int from binary integer string
        public void SetValue(params int[] bits)
        {
            int val = 0;
            int offset = 0;

            for (int i = bits.Length - 1; i >= 0; i--)
            {
                bool bit = bits[i] != 0;
                if (bit) val += 1 << offset;
                offset++;
            }

            value = val;
        }

        public string GetBitDescription()
        {
            return bitDescriptions[value];
        }
        */
    }
}
