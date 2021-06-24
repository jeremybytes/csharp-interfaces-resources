using PersonReader.Interface;

namespace PeopleViewer
{
    public static class PersonFormatter
    {
        public static string ToConsoleRecord(this Person person)
        {
            string output = string.Empty;

            output += $"  {person}  \n";
            output += $"  Rating: {person.Rating}/10     Year: {person.StartDate.Year}\n";
            output += $"----------------------------------";

            return output;
        }
    }
}
