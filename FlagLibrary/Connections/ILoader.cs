using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlagLibrary.Flags;

namespace FlagLibrary.Connections
{
    public interface ILoader
    {
        Dictionary<string, FlagList> GetFlagLists(string filePath);
    }
}
