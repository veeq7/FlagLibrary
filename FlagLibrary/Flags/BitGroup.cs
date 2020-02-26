﻿using System.Collections.Generic;
using FlagLibrary.Utils;

namespace FlagLibrary.Flags
{

    public class BitGroup
    {
        // includes first bit
        public List<int> bitRefs = new List<int>();
        public string description = "";
        public Dictionary<int, string> bitDescriptions = new Dictionary<int, string>();

        public int GetValue(int i32)
        {
            int value = 0;

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                value += MathUtils.GetBitFromNumber(i32, bitRef) << bitIndex++;
            }

            return value;
        }

        public int GetModifiedValue(int i32, int value)
        {
            int newi32 = i32;
            value = MathUtils.Clamp(value, 0, GetMaxSize());

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                newi32 = MathUtils.SetBitInNumber(newi32, bitRef, MathUtils.GetBitFromNumber(value, bitIndex++));
            }

            return newi32;
        }
        
        public int GetMaxSize()
        {
            return (1 << bitRefs.Count) - 1;
        }


        public void FillDescriptions()
        {
            if (bitRefs.Count == 1 && bitDescriptions.Count == 0)
            {
                bitDescriptions.Add(0, "Off");
                bitDescriptions.Add(1, "On");
            }
            else
            {
                for (int i = 0; i <= GetMaxSize(); i++)
                {
                    if (!bitDescriptions.ContainsKey(i)) bitDescriptions.Add(i, i.ToString());
                }
            }
        }
    }
}
