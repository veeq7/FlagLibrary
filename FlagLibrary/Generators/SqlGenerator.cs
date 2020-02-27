using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;
using System.Windows.Forms;

namespace FlagLibrary.Generators
{
    public class SqlGenerator
    {
        private bool CheckIfBitStringIsEmpty(string bits, char blankChar)
        {
            if (!bits.Contains('1') && !bits.Contains(blankChar))
                return true;
            return false;
        }

        public string GenerateInsert(string bits, string flagName)
        {
            if (CheckIfBitStringIsEmpty(bits, '0')) return flagName + "=()";
            string insertString = flagName + "=(";

            int i = 0;
            bool isFirst = true;
            foreach (var ch in bits)
            {
                if (ch == '1')
                {
                    insertString += GenerateCommandBitFragment(i, isFirst);
                    isFirst = false;
                }
                i++;
            }
            insertString.Remove(insertString.Length - 1);

            insertString += ")";
            return insertString;
        }

        public string GenerateUpdate(string bits, string flagName)
        {
            if (CheckIfBitStringIsEmpty(bits, '?')) return ""; ;

            string updateStringSet = "";
            string updateStringUnset = "";
            string returnString = "";

            int setBits = 0;
            int unsetBits = 0;
            int i = 0;
            foreach (var ch in bits)
            {
                if (ch == '1')
                {
                    updateStringSet += GenerateCommandBitFragment(i, setBits == 0);
                    setBits++;
                }
                else if (ch == '0')
                {
                    updateStringUnset += GenerateCommandBitFragment(i, unsetBits == 0);
                    unsetBits++;
                }
                i++;
            }
            if (setBits > 0) updateStringSet.Remove(updateStringSet.Length - 1);
            if (unsetBits > 0) updateStringUnset.Remove(updateStringUnset.Length - 1);

            if (setBits > 0 && unsetBits > 0)
            {
                returnString = "(" + flagName + "=" + flagName + "&(~(" + updateStringUnset + ")))|(" + updateStringSet + ")";
            } else if (setBits > 0)
            {
                returnString = flagName + "=" + flagName + "|(" + updateStringSet + ")";
            } else if (unsetBits > 0)
            {
                returnString = flagName + "=" + flagName + "&(~(" + updateStringUnset + "))";
            }

            return returnString;
        }

        string GenerateCommandBitFragment(int i, bool isFirst)
        {
            string str = "";
            if (!isFirst) str += '|';
            str += "(1<<" + i + ")";

            return str;
        }

    
    }
}
