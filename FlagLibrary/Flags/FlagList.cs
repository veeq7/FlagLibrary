using System;
using System.Collections.Generic;
using System.Text;
using FlagLibrary.Connections;
using System.Xml;

namespace FlagLibrary.Flags
{
    public struct ParsedFlagData
    {
        public string description;
        public string currentOption;
        public int value;
    }

    public class FlagList
    {
        public string name;
        public List<FlagDescriptor> flags = new List<FlagDescriptor>();
        public int value = 0;

        public List<ParsedFlagData> Parse(int value)
        {
            List<ParsedFlagData> list = new List<ParsedFlagData>();
            foreach (FlagDescriptor flag in flags)
            {
                list.Add(ParseFlag(flag, flag.GetValue(value)));
            }
            return list;
        }

        private ParsedFlagData ParseFlag(FlagDescriptor flag, int flagValue)
        {
            ParsedFlagData data = new ParsedFlagData();
            data.description = flag.description;
            if (flag.bitDescriptions.ContainsKey(flagValue))
                data.currentOption = flag.bitDescriptions[flagValue];
            else
                data.currentOption = "";
            data.value = flagValue;
            return data;
        }


        /*public void SetBit(int bit, bool value)
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
        }*/
    }
}
