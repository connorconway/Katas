using System;

namespace RockPaperScissors.ConsoleApp
{
    public class ConsoleLogger : ILogger
    {
        public string Log(string message)
        {
            Console.WriteLine(message);
            return message;
        }
    }
}