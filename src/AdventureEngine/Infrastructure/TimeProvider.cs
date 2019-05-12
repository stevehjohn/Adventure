using System;

namespace AdventureEngine.Infrastructure
{
    public class TimeProvider : ITimeProvider
    {
        public DateTime UtcTime()
        {
            return DateTime.UtcNow;
        }
    }
}