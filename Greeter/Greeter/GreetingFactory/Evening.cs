using System;
using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public class Evening : IGreetingFactory
    {
        public string Greeting(string input, ITimeRetrievalService timeRetrievalService) => $"Good evening {input}";

        public bool CanHandle(ITimeRetrievalService timeRetrievalService)
        {
            var currentTime = timeRetrievalService.Now();
            var start = new TimeSpan(18, 0, 0);
            var end = new TimeSpan(22, 0, 0);
            return currentTime >= start && currentTime <= end;
        }
    }
}