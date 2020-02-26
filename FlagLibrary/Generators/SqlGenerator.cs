using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibrary.Generators
{
    class SqlGenerator
    {
        public string GenerateInsert(Dictionary<int, ParsedFlagData> data)
        {
            string insertString = "";

            return insertString;
        }

        public string GenerateUpdate(Dictionary<string, FlagList> flags, int value)
        {
            string updateString = "";

            return updateString;
        }
    }
}
