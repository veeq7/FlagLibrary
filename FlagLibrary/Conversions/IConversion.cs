using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagLibrary.Conversions
{
    interface IConversion
    {
        void Convert(string sourceFilePath, string targetFilePath, string errorFilePath = "");
    }
}
