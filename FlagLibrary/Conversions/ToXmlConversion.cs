using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibrary.Conversions
{
    public class ToXmlConversion : IConversion
    {
        /// <summary>
        /// Loads data from Multiple Xml files and save it to single Xml File ready for distribution
        /// </summary>
        /// <param name="sourceFilePath">Filepath to folder with xmls</param>
        /// <param name="targetFilePath">Filepath to folder to save xml within</param>
        public void Convert(Dictionary<string, FlagList> source, string targetFilePath, string errorFilePath = "")
        {

        }
    }
}
