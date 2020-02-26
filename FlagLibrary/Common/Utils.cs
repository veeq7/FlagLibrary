using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagLibrary.Utils
{
    public static class CommonUtils
    {
        public static int Clamp(int value, int min, int max)
        {
            return value < min ? min : value > max ? max : value;
        }
        public static int GetValueOfBit(int bit)
        {
            return 1 << bit;
        }

        public static int SetBitInNumber(int number, int bitPosition, int value)
        {
            if (value == 0)
            {
                number &= ~(1 << bitPosition);
            }
            else
            {
                number |= 1 << bitPosition;
            }
            return number;
        }

        public static int GetBitFromNumber(int number, int bitPosition)
        {
            return (number & 1 << bitPosition) != 0 ? 1 : 0;
        }

        public static List<int> ParseStringArrayToIntArray(string[] indexes)
        {
            List<int> list = new List<int>();
            foreach (string index in indexes)
            {
                list.Add(int.Parse(index));
            }
            return list;
        }
    }
}
