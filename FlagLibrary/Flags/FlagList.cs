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
        public Dictionary<int, FlagDescriptor> flags = new Dictionary<int, FlagDescriptor>(); public int value = 0;

        int key = 0;

        public void SetBit(int bit, bool value)
        {
            if (value)
            {
                key |= FlagUtils.GetFlagBit(bit);
            }
            else
            {
                key &= ~(FlagUtils.GetFlagBit(bit));
            }
        }

        public int GetBit(int bit)
        {
            return key | FlagUtils.GetFlagBit(bit);
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
    }
}
