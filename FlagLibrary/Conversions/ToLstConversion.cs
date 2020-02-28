using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlagLibrary.Flags;
using FlagLibrary.Utils;

namespace FlagLibrary.Conversions
{
    public class ToLstConversion : IConversion
    {
        /// <summary>
        /// Loads data from Multiple Xml files and save it to single Xml File ready for distribution
        /// </summary>
        /// <param name="sourceFilePath">Filepath to folder with xmls</param>
        /// <param name="targetFilePath">Filepath to folder to save xml within</param>
        public void Convert(Dictionary<string, FlagList> source, string sourceFileName, string targetFilePath, string errorFilePath = "")
        {
            string text = "";

            foreach (var kv in source)
            {
                text += kv.Value.name;
                text += Environment.NewLine;

                try
                {
                    foreach (var k in kv.Value.flags)
                    {
                        int j = 0;
                        foreach (var bitRef in k.Value.bitRefs)
                        {
                            if (j==0) text += "\t";

                            text += bitRef.ToString();
                            if (k.Value.bitRefs.Count - j > 1) text += ", ";
                            else text += " bit:   \t";
                            j++;
                        }

                        text += k.Value.description;
                        //text += Environment.NewLine;

                        foreach (var description in k.Value.bitDescriptions)
                        {
                            //text += "++++" + description.Value;
                            if (description.Value != "???" && CommonUtils.ReturnIfStringContainsLetters(description.Value))   //pominąć liczby
                            {
                                text += "\n\t\t\t\t";
                                text += description.Value;
                                //MessageBox.Show("a");
                            }
                        }
                        text += Environment.NewLine;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                text += "\n <===============================================================================>\n" + Environment.NewLine;
            }
            
            File.WriteAllText(targetFilePath, text);
        }

   
    }
}
