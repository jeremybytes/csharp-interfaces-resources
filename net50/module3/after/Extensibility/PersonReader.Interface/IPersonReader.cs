using System.Collections.Generic;

namespace PersonReader.Interface
{
    public interface IPersonReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}
