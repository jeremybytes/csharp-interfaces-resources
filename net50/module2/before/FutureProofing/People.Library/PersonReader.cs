using Common;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;

namespace People.Library
{
    public class PersonReader
    {
        #region Service initializers
        WebClient client = new WebClient();
        string baseUri = "http://localhost:9874";
        JsonSerializerOptions options =
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        #endregion

        public Person[] GetPeople()
        {
            string address = $"{baseUri}/people";
            string reply = client.DownloadString(address);
            var result = JsonSerializer.Deserialize<List<Person>>(reply, options);
            if (result is null)
            {
                result = new List<Person>();
            }
            return result.ToArray();
        }

        public Person GetPerson(int id)
        {
            var address = $"{baseUri}/people/{id}";
            string reply = client.DownloadString(address);
            var result = JsonSerializer.Deserialize<Person>(reply, options);
            if (result is null)
            {
                result = new Person();
            }
            return result;
        }
    }
}
