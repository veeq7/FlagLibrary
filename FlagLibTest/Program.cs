using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;
using FlagLibrary.Connections;

namespace FlagLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            XMLLoader xml = new XMLLoader("C:\\Users\\praktykant\\source\\repos\\FlagLibrary2\\flags.xml");
            List<FlagList> list = xml.GetFlagLists();
            foreach (FlagList fl in list) {
                Console.WriteLine(fl.name);
                foreach (KeyValuePair<int, FlagDescriptor> flag in fl.flags)
                {
                    Console.WriteLine("    " + flag.Value.description);
                    foreach (KeyValuePair<int, string> bitDesc in flag.Value.bitDescriptions)
                    {
                        Console.WriteLine("        " + bitDesc.Value);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
