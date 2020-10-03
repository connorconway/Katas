using System;
using Greeter.Time;

namespace Greeter.GreetingFactory
{
    public class CompositeGreetingFactory : IGreetingFactory
    {
        private readonly IGreetingFactory _one;
        private readonly IGreetingFactory _two;

        public CompositeGreetingFactory(IGreetingFactory one, IGreetingFactory two)
        {
            _one = one;
            _two = two;
        }

        public string Greeting(string name, ITimeRetrievalService timeRetrievalService)
        {
            if (_one.CanHandle(timeRetrievalService))
                return _one.Greeting(name, timeRetrievalService);
            if (_two.CanHandle(timeRetrievalService))
                return _two.Greeting(name, timeRetrievalService);
            throw new InvalidOperationException();
        }

        public bool CanHandle(ITimeRetrievalService timeRetrievalService) => 
            _one.CanHandle(timeRetrievalService) || _two.CanHandle(timeRetrievalService);
    }
}