using PersonReader.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonReader.CSV
{
    public class CSVReader : IPersonReader
    {
        public ICSVFileLoader FileLoader { get; set; }

        public CSVReader()
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "People.txt";
            FileLoader = new CSVFileLoader(filePath);
        }

        public IEnumerable<Person> GetPeople()
        {
            var fileData = FileLoader.LoadFile();
            var people = ParseData(fileData);
            return people;
        }

        public Person GetPerson(int id)
        {
            var people = GetPeople();
            return people.Single(p => p.Id == id);
        }

        private List<Person> ParseData(IReadOnlyCollection<string> csvData)
        {
            var people = new List<Person>();

            foreach (string line in csvData)
            {
                try
                {
                    var elems = line.Split(',');
                    var per = new Person()
                    {
                        Id = Int32.Parse(elems[0]),
                        GivenName = elems[1],
                        FamilyName = elems[2],
                        StartDate = DateTime.Parse(elems[3]),
                        Rating = Int32.Parse(elems[4]),
                        FormatString = elems[5],
                    };
                    people.Add(per);
                }
                catch (Exception)
                {
                    // Skip the bad record, log it, and move to the next record
                    // log.write("Unable to parse record", per);
                }
            }
            return people;
        }
    }
}
