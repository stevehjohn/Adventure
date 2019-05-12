using System;

namespace AdventureEngine.Infrastructure
{
    public interface ITimeProvider
    {
        DateTime UtcTime();
    }
}