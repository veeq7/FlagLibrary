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
        public string GenerateInsert(Dictionary<int, ParsedFlagData> data, string flagName)
        {
            string insertString = "";

            return insertString;
        }

        public string GenerateUpdate(Dictionary<int, ParsedFlagData> data, string flagName)
        {
            string updateStringSet = flagName + "=" + flagName +"|";
            string updateStringUnset = flagName + "=" + flagName + "&(~(";


            foreach (KeyValuePair<int, ParsedFlagData> kv in data)
            {
                ParsedFlagData pFlag = kv.Value;
                foreach (int bitRef in pFlag.flag.bitRefs)
                {

                }
            }

            updateStringSet += ")";
            updateStringUnset += "))"; ;
            return updateStringSet + "; " + updateStringUnset + ";";
        }
    }
}
