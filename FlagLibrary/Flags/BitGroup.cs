using System.Collections.Generic;
using FlagLibrary.Utils;

namespace FlagLibrary.Flags
{

    public class BitGroup
    {
        // includes first bit
        public List<int> bitRefs = new List<int>();
        public string description = "";
        public int maxSize = 1;
        public Dictionary<int, string> bitDescriptions = new Dictionary<int, string>();

        public int GetValue(int i32)
        {
            int value = 0;

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                value += GetBit(i32, bitRef, bitIndex++);
            }

            return value;
        }

        public int GetModifiedValue(int i32, int value)
        {
            int newi32 = i32;
            value = MathUtils.Clamp(value, 0, maxSize);

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                int bit = GetBit(value, i32, bitIndex++);
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

        public int GetBit(int value, int i32, int bitIndex)
        {
            i32 = MathUtils.GetBitValue(i32);
            return ((value & i32) != 0 ? 1 : 0) << bitIndex;
        }

        public void SetDefaultBitDescriptions()
        {
            bitDescriptions.Clear();
            bitDescriptions.Add(0, "Off");
            bitDescriptions.Add(1, "On");
        }
    }
}
