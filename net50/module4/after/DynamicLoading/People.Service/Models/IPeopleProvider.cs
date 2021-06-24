using PersonReader.Interface;
using System.Collections.Generic;

namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
