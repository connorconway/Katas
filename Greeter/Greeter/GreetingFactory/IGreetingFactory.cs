using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public interface IGreetingFactory
    {
        string Greeting(string name, ITimeRetrievalService timeRetrievalService);
        bool CanHandle(ITimeRetrievalService timeRetrievalService);
    }
}