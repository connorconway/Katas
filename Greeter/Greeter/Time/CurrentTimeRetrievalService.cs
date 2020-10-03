using System;

namespace Greeter.Time
{
    public class CurrentTimeRetrievalService : ITimeRetrievalService
    {
        public TimeSpan Now() => DateTime.UtcNow.TimeOfDay;
    }
}