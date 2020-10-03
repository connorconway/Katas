using System.Collections.Generic;
using System.Linq;
using Greeter.GreetingFactory;
using Greeter.Logger;
using Greeter.NameTransformations;
using Greeter.Time;

namespace Greeter
{
    public class Greeter
    {
        private readonly ITimeRetrievalService _timeRetrievalService;
        private readonly ILogger _logger;

        public Greeter(ITimeRetrievalService timeRetrievalService, ILogger logger)
        {
            _timeRetrievalService = timeRetrievalService;
            _logger = logger;
        }

        public string Greet(string name)
        {
            _logger.Log("Greeting has been called");
            var transformations = new List<INameTransformation>
            {
                new Trim(), 
                new Capitalise()
            };

            return new Morning()
                .Then(new Evening())
                .Then(new Night())
                .Then(new Other())
                .Greeting(transformations.Aggregate(name, (current, filter) => filter.Apply(current)), _timeRetrievalService);
        }
    }
}