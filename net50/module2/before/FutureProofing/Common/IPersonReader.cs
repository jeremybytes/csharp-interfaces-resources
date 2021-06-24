using System.Collections.Generic;
using System.Threading.Tasks;

namespace Common
{
    public interface IPersonReader
    {
        IEnumerable<Person> GetPeople();
        Person GetPerson(int id);
    }
}
