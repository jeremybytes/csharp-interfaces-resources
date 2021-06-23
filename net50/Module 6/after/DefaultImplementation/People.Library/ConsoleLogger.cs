using System;

namespace People.Library
{
    public class ConsoleLogger : IPeopleLogger
    {
        public void Log(PeopleLogLevel level, string message)
        {
            Console.WriteLine($"{DateTimeOffset.Now:T} - {level}: {message}");
        }

        public void LogException(Exception ex)
        {
            Console.WriteLine($"{DateTimeOffset.Now:T} - Error: ");
            Console.WriteLine($"  Exception Type: {ex.GetType()}");
            Console.WriteLine($"  {ex.Message}");
        }
    }
}
