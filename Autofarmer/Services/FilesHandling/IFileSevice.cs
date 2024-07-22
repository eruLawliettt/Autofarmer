using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Services.FilesHandling
{
    internal interface IFileSevice
    {
        public List<string> ReadFileByLines(string filePath);

        public Dictionary<string, string> GetDictionaryFromFile(string filePath);
    }
}
