using System;
using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public class Night : IGreetingFactory
    {
        public string Greeting(string input, ITimeRetrievalService timeRetrievalService) => $"Good night {input}";

        public bool CanHandle(ITimeRetrievalService timeRetrievalService)
        {
            var currentTime = timeRetrievalService.Now();
            var start = new TimeSpan(22, 0, 0);
            var end = new TimeSpan(06, 0, 0);
            if (start < end)
                return start <= currentTime && currentTime <= end;
            return !(end < currentTime && currentTime < start);
        }
    }
}