using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public class Other : IGreetingFactory
    {
        public string Greeting(string input, ITimeRetrievalService timeRetrievalService) => $"Hello {input}";

        public bool CanHandle(ITimeRetrievalService timeRetrievalService) => true;
    }
}