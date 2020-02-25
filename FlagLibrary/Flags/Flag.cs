using System.Collections.Generic;
using FlagLibrary.Utils;

namespace FlagLibrary.Flags
{

    public class Flag
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
                value += GetBit(i32, bitRef);
            }

            return value;
        }

        public int GetModifiedValue(int i32, int value)
        {
            int newi32 = i32;
            value = MathUtils.Clamp(value, 0, maxSize);

            foreach (int bitRef in bitRefs)
            {
                int bit = GetBit(value, i32);
                if (bit == 0)
                {
                    newi32 &= (~bit);
                }
                else
                {
                    newi32 |= bit;
                }
            }

            return newi32;
        }

        int GetFlagBit(int bit)
        {
            return 1 << bit;
        }

        public int GetBit(int value, int i32)
        {
            i32 = 1 << i32;
            return (value & i32) != 0 ? 1 : 0;
        }
    }
}
