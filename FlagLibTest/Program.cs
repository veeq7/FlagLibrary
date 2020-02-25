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
            foreach (FlagList fl in list)
            {
                Console.WriteLine(fl.name);
                Console.WriteLine();
                foreach (ParsedFlagData data in fl.Parse(7))
                {
                    Console.WriteLine("   " + "Wartość: " + data.value);
                    Console.WriteLine("   " + "Opis: " + data.description);
                    Console.WriteLine("   " + "Opcja: " + data.currentOption);
                    Console.WriteLine();
                }
            }
        }  
    }
}
