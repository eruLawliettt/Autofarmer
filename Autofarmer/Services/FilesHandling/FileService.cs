using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autofarmer.Services.FilesHandling
{
    internal class FileService : IFileSevice
    {
        public List<string> ReadFileByLines(string filePath)
        {
            const Int32 BufferSize = 512;

            using var fileStream = File.OpenRead(filePath);
            using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);

            bool IsProcessing = true;
            string line;
            List<string> list = [];

            while (IsProcessing)
            {
                line = streamReader.ReadLine();

                if (line != null)
                {
                    if (line == String.Empty || line == " ")
                        continue;
                    list.Add(line);
                }

                else
                    IsProcessing = false;
            }

            return list;
        }

        public Dictionary<string, string> GetDictionaryFromFile(string filePath)
        {
            List<string> fileByLines = ReadFileByLines(filePath);
            Dictionary<string, string> pairs = [];

            foreach (string str in fileByLines)
            {
                var item = str.Split('-');
                pairs.Add(item[0], item[1]);
            }

            return pairs;
        }

    }
}
