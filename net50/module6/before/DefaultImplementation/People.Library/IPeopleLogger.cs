using Common;
using System;
using System.Collections.Generic;

namespace People.Library
{
    public enum PeopleLogLevel
    {
        Critical,
        Error,
        Warning,
        Information,
        Debug,
        Trace
    }

    public interface IPeopleLogger
    {
        public void Log(PeopleLogLevel level, string message);
    }
}
