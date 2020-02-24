using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Flag f = new Flag();
            f.SetValue(0, 1, 0, 1);
            Console.WriteLine(f.value);
        }
    }
}
