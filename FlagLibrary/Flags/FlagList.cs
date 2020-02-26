using System.Collections.Generic;
using FlagLibrary.Utils;

namespace FlagLibrary.Flags
{
    public struct ParsedFlagData
    {
        public string description { get; set; }
        public string currentOption { get; set; }
        public int value { get; set; }
        public bool isKnown { get; set; }

        public int bitNumber { get; set; }
        public int bitSize { get; set; }
        public Dictionary<string, int> options {get; set;}
    }

    public class FlagList
    {
        public string name;
        public Dictionary<int, BitGroup> flags = new Dictionary<int, BitGroup>();
        public int value = 0;

        public List<ParsedFlagData> Parse(int value)
        {
            List<ParsedFlagData> list = new List<ParsedFlagData>();
            foreach (KeyValuePair<int, BitGroup> kv in flags)
            {
                list.Add(ParseFlag(kv.Value, kv.Value.GetValue(value)));
            }
            return list;
        }

        private ParsedFlagData ParseFlag(BitGroup flag, int flagValue)
        {
            ParsedFlagData data = new ParsedFlagData();
            data.description = flag.description;
            data.bitNumber = flag.bitRefs[0];
            data.bitSize = flag.GetMaxSize();
            data.options = GetParsedFlagOptions(flag);
            if (flag.bitDescriptions.ContainsKey(flagValue))
                data.currentOption = flag.bitDescriptions[flagValue];
            else
                data.currentOption = "";
            data.value = flagValue;
            return data;
        }

        public Dictionary<string, int> GetParsedFlagOptions(BitGroup bit)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (KeyValuePair<int, string> kv in bit.bitDescriptions)
            {
                dict.Add(kv.Value, kv.Key);
            }

            return dict;
        }
    }
}
