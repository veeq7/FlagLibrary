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
                value += ReadBitValue(bitRef, i32, bitIndex++);
            }

            return value;
        }

        /// <summary>
        /// Reads bit of Value of current Flag
        /// </summary>
        /// <param name="bitPosition">Bit Position in key</param>
        /// <param name="key">Key from which we read from</param>
        /// <param name="bitIndex">Bit Index of Flag</param>
        /// <returns>Bit of Value of Flag</returns>
        private int ReadBitValue(int bitPosition, int key, int bitIndex)
        {
            int value = MathUtils.GetValueOfBit(bitPosition);
            return ((value & key) != 0 ? 1 : 0) << bitIndex;
        }

        public int GetModifiedValue(int i32, int value)
        {
            int newi32 = i32;
            value = MathUtils.Clamp(value, 0, maxSize);

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                newi32 = MathUtils.SetBitInNumber(newi32, bitRef, MathUtils.GetBitFromNumber(value, bitIndex++));
            }

            return newi32;
        }
        


        public void SetDefaultBitDescriptions()
        {
            bitDescriptions.Clear();
            bitDescriptions.Add(0, "Off");
            bitDescriptions.Add(1, "On");
        }
    }
}
