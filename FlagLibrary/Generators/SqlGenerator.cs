using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibrary.Generators
{
    public class SqlGenerator
    {
        private bool CheckIfBitStringIsEmpty(string bits)
        {
            if (!bits.Contains('1') && !bits.Contains('?'))
                return true;
            return false;
        }

        public string GenerateInsert(string bits, string flagName)
        {
            if (CheckIfBitStringIsEmpty(bits)) return "";
            string insertString = flagName + "=(";

            int i = 0;
            foreach (var ch in bits)
            {
                if (ch == '1')
                {
                    if (i != 0) insertString += '|';
                    insertString += "(1<<"+i+")";
                }
                i++;
            }
            insertString.Remove(insertString.Length - 1);

            insertString += ");";
            return insertString;
        }

        public string GenerateUpdate(string bits, string flagName)
        {
            if (CheckIfBitStringIsEmpty(bits)) return "";
            string updateStringSet = flagName + "=" + flagName +"|(";
            string updateStringUnset = flagName + "=" + flagName + "&(~(";

            int i = 0;
            foreach (var ch in bits)
            {
                if (ch == '1')
                {
                    if (i != 0) updateStringSet += '|';
                    updateStringSet += "(1<<" + i + ")";
                }
                else if (ch == '0')
                {
                    if (i != 0) updateStringUnset += '|';
                    updateStringUnset += "(1<<" + i + ")";
                }
                i++;
            }
            updateStringSet.Remove(updateStringSet.Length - 1);
            updateStringUnset.Remove(updateStringUnset.Length - 1);

            updateStringSet += ")"; ;
            updateStringUnset += "))"; ;
            return updateStringSet + "; " + updateStringUnset + ";";
        }
    }
}
