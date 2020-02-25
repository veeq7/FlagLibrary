using System;
using System.Collections.Generic;
using System.Text;

namespace FlagLibrary
{
    public static class FlagUtils
    {
        static public int GetFlagBit(int flag)
        {
            return 1 << flag;
        }
    }
}
