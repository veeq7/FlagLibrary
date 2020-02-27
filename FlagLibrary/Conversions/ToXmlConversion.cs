using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using FlagLibrary.Flags;
using FlagLibrary.Connections;
using FlagLibrary.Utils;

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
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";
            using (XmlWriter writer = XmlWriter.Create(targetFilePath, settings))
            {
                writer.WriteStartElement("Flags");
                foreach (var kvSource in source)
                {
                    writer.WriteStartElement("Flag");
                    var flagList = kvSource.Value;
                    writer.WriteAttributeString("Column", flagList.name);

                    foreach (var kvFlags in flagList.flags)
                    {
                        var flag = kvFlags.Value;
                        writer.WriteStartElement("Bit");
                        writer.WriteAttributeString("Index", MakeBitRefString(flag.bitRefs));
                        writer.WriteElementString("Comment", flag.description);
                        foreach (var desc in flag.bitDescriptions)
                        {
                            if (desc.Value != "???" && CommonUtils.ReturnIfStringContainsLetters(desc.Value))
                            {
                                writer.WriteStartElement("Option");
                                writer.WriteAttributeString("Value", desc.Key.ToString());
                                writer.WriteString(desc.Value);
                                writer.WriteEndElement();
                            }
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.Flush();
            }
        }

        string MakeBitRefString(List<int> bitRefs)
        {
            string str = "";

            int i = 0;
            foreach (var rf in bitRefs)
            {
                if (i != 0) str += ",";
                str += rf;
                i++;
            }

            return str;
        }
    }
}
