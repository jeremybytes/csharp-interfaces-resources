using Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace People.Library
{
    public class FileLogger : IPeopleLogger
    {
        private string logPath;

        public FileLogger()
        {
            logPath = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
        }

        public void Log(PeopleLogLevel level, string message)
        {
            using var writer = new StreamWriter(logPath, true);
            writer.WriteLine($"{DateTimeOffset.Now:T} - {level}: {message}");
        }
    }
}
