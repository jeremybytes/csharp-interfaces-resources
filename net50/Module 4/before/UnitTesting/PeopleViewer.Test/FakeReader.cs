using PersonReader.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PeopleViewer.Test
{
    public class FakeReader : IPersonReader
    {
        public IEnumerable<Person> GetPeople()
        {
            var people = new List<Person>()
            {
                new Person() {Id = 1,
                    GivenName = "John", FamilyName = "Smith",
                    Rating = 7, StartDate = new DateTime(2000, 10, 1)},
                new Person() {Id = 2,
                    GivenName = "Mary", FamilyName = "Thomas",
                    Rating = 9, StartDate = new DateTime(1971, 7, 23)},
            };

            return people;
        }

        public Person GetPerson(int id)
        {
            return GetPeople().First(p => p.Id == id);
        }
    }
}
