using Common;
using System.Net;
using System.Text.Json;

namespace People.Library;

public class PersonReader
{
    #region Service initializers
    WebClient client = new WebClient();
    string baseUri = "http://localhost:9874";
    JsonSerializerOptions options =
        new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    #endregion

    public List<Person> GetPeople()
    {
        string address = $"{baseUri}/people";
        string reply = client.DownloadString(address);
        var result = JsonSerializer.Deserialize<List<Person>>(reply, options);
        if (result is null)
        {
            result = new List<Person>();
        }
        return result;
    }
}
