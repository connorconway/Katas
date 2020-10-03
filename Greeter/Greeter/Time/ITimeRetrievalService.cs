using System;

namespace Greeter.Time
{
    public interface ITimeRetrievalService
    {
        TimeSpan Now();
    }
}