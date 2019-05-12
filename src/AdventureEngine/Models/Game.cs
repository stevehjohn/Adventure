using AdventureEngine.Infrastructure;
using System;

namespace AdventureEngine.Models
{
    public class Game
    {
        private readonly ITimeProvider _timeProvider;

        public Game(ITimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
            GameStartTime = _timeProvider.UtcTime();
        }

        public GameDefinition GameDefinition { get; set; }

        public DateTime GameStartTime { get; }

        public Player Player { get; set; }

        public DateTime GameTime => new DateTime(GameStartTime.Ticks + (long) ((_timeProvider.UtcTime().Ticks - GameStartTime.Ticks) * GameDefinition.TimeSpeedFactor));
    }
}