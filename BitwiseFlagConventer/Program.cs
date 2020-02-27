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
            try
            {
                if (args.Length != 2) return;
                var source = args[0];
                var target = args[1];
                if (!isValid(source)) return;
                if (!isValid(target)) return;

                XMLDynamicLoader loader = new XMLDynamicLoader();
                var flagList = loader.GetFlagLists(source);
                IConversion conversion = GetConversion(Path.GetExtension(target));
                conversion.Convert(flagList, target, "error.txt");
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
        {
            var ext = Path.GetExtension(filePath);
            return ext == ".xml" || ext == ".lst" || ext == "";
        }
    }
}
