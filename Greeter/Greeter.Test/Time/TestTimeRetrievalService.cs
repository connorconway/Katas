using System;
using Greeter.Time;

namespace Greeter.Test.Time
{
    public class TestTimeRetrievalService : ITimeRetrievalService
    {
        private readonly TimeSpan _currentTime;

        public TestTimeRetrievalService(TimeSpan currentTime)
        {
            _currentTime = currentTime;
        }

        public TimeSpan Now() => _currentTime;
    }
}