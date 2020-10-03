using System;
using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public class Morning : IGreetingFactory
    {
        public string Greeting(string input, ITimeRetrievalService timeRetrievalService) => $"Good morning {input}";

        public bool CanHandle(ITimeRetrievalService timeRetrievalService)
        {
            var currentTime = timeRetrievalService.Now();
            var start = new TimeSpan(06, 0, 0);
            var end = new TimeSpan(12, 0, 0);
            return currentTime >= start && currentTime <= end;
        }
    }
}