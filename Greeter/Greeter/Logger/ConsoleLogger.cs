using System;

namespace Greeter.Logger
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message) => Console.WriteLine(message);
    }
}