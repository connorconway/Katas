using System.Collections.Generic;
using Greeter.Logger;

namespace Greeter.Test.Logger
{
    public class TestLogger : ILogger
    {
        private readonly List<string> _logs = new List<string>();
        public void Log(string message) => _logs.Add(message);
        public List<string> Messages => _logs;
    }
}