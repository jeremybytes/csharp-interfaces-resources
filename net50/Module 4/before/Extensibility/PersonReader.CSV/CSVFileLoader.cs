using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonReader.CSV
{
    public interface ICSVFileLoader
    {
        IReadOnlyCollection<string> LoadFile();
    }

    public class CSVFileLoader : ICSVFileLoader
    {
        private string filePath;

        public CSVFileLoader(string filePath)
        {
            this.filePath = filePath;
        }

        public IReadOnlyCollection<string> LoadFile()
        {
            var data = new List<string>();

            using (var reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    data.Add(line);
                }
            }

            return data;
        }
    }
}
