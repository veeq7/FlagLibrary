using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FlagLibrary.Connections;
using FlagLibrary.Conversions;

namespace BitwiseFlagConventer
{
    class Program
    {
        static void Main(string[] args)
        {
            var source = "";
            var target = "";

            if (args.Length == 2)
            {
                source = args[0];
                target = args[1];
            }
            while (!isValid(source))
            {
                Console.Write("Source File: ");
                source = Console.ReadLine();
            }
            while (!isValid(target))
            {
                Console.Write("Target File: ");
                target = Console.ReadLine();
            }

            try
            {
                ILoader loader = GetLoader(target);
                var flagList = loader.GetFlagLists(source);
                IConversion conversion = GetConversion(Path.GetExtension(target));
                conversion.Convert(flagList, Path.GetFileName(source), target, "error.txt");
                Console.WriteLine("Success!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static ILoader GetLoader(string targetFilePath)
        {
            if (Path.GetExtension(targetFilePath) == "")
            {
                return new FolderLoader();
            }
            if (Path.GetExtension(targetFilePath) == ".xml")
            {
                return new XMLDynamicLoader();
            }
            else if (Path.GetExtension(targetFilePath) == ".lst")
            {
                return new LSTLoader();
            }
            throw new NotSupportedException();
        }

        static IConversion GetConversion(string targetFilePath)
        {
            if (Path.GetExtension(targetFilePath) == ".xml")
            {
                return new ToXmlConversion();
            }
            else if (Path.GetExtension(targetFilePath) == ".lst")
            {
                return new ToLstConversion();
            }
            throw new NotSupportedException();
        }


        static bool isValid(string filePath)
<<<<<<< HEAD
        {
            if (Path.GetFileName(filePath) == "") return false;
=======
        {    
            if (Path.GetFileName(filePath) == "") return false;
            if (!File.Exists(filePath) && !Directory.Exists(filePath)) return false;
>>>>>>> f088605914f379a613e9608e1916eca115964f23
            var ext = Path.GetExtension(filePath);
            return ext == ".xml" || ext == ".lst" || ext == "";
        }
    }
}
