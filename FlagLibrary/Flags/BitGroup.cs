﻿using System.Collections.Generic;
using FlagLibrary.Utils;

namespace FlagLibrary.Flags
{

    public class BitGroup
    {
        // includes first bit
        public List<int> bitRefs = new List<int>();
        public string description = "";
        public SortedDictionary<int, string> bitDescriptions = new SortedDictionary<int, string>();

        public int GetValue(int i32)
        {
            int value = 0;

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                value += CommonUtils.GetBitFromNumber(i32, bitRef) << bitIndex++;
            }

            return value;
        }

        public int GetModifiedValue(int i32, int value)
        {
            int newi32 = i32;
            value = Utils.CommonUtils.Clamp(value, 0, GetMaxSize());

            int bitIndex = 0;
            foreach (int bitRef in bitRefs)
            {
                newi32 = Utils.CommonUtils.SetBitInNumber(newi32, bitRef, Utils.CommonUtils.GetBitFromNumber(value, bitIndex++));
            }

            return newi32;
        }
        
        public int GetMaxSize()
        {
            return (1 << bitRefs.Count) - 1;
        }


        public void FillDescriptions()
        {
            if (!bitDescriptions.ContainsKey(-1)) bitDescriptions.Add(-1, "???");
            for (int i = 0; i <= GetMaxSize(); i++)
            {
                if (!bitDescriptions.ContainsKey(i)) bitDescriptions.Add(i, i.ToString());
            }
        }
    }
}
