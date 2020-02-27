using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FlagLibrary.Flags;
using FlagLibrary.Connections;

namespace FlagLibrary.Conversions
{
    public class ToXmlConversion : IConversion
    {
        XMLStandard standard = new XMLCalcStandard();

        /// <summary>
        /// Loads data from Multiple Xml files and save it to single Xml File ready for distribution
        /// </summary>
        /// <param name="sourceFilePath">Filepath to folder with xmls</param>
        /// <param name="targetFilePath">Filepath to folder to save xml within</param>
        public void Convert(Dictionary<string, FlagList> source, string targetFilePath, string errorFilePath = "")
        {
            XmlDocument xmlDoc = new XmlDocument();

            XmlNode root = xmlDoc.CreateElement("Flags");

            foreach(var kv in source)
            {
                var flagList = kv.Value;

                //XmlNode flagNode = root.AppendChild("Flag");

                foreach (var flag in flagList.flags)
                {
                    
                }
            }

            xmlDoc.Save(targetFilePath);
        }
    }
}
