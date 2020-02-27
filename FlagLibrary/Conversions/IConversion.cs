using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibrary.Conversions
{
    public interface IConversion
    {
        void Convert(Dictionary<string, FlagList> source, string sourceFileName, string targetFilePath, string errorFilePath = "");
    }
}
