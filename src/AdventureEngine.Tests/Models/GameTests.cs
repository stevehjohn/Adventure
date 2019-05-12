using AdventureEngine.Infrastructure;
using AdventureEngine.Models;
using Moq;
using NUnit.Framework;
using System;

namespace AdventureEngine.Tests.Models
{
    [TestFixture]
    public class GameTests
    {
        private Mock<ITimeProvider> _timeProvider;

        private Game _game;

        [SetUp]
        public void SetUp()
        {
            _timeProvider = new Mock<ITimeProvider>();

            _timeProvider.Setup(tp => tp.UtcTime())
                         .Returns(new DateTime(2019, 5, 12, 14, 30, 0));

            _game = new Game(_timeProvider.Object);
        }

        [Test]
        public void GetTime_returns_time_advanced_by_TimeSpeedFactor()
        {
            _timeProvider.Setup(tp => tp.UtcTime())
                         .Returns(new DateTime(2019, 5, 12, 15, 30, 0));

            _game.GameDefinition = new GameDefinition
                                   {
                                       TimeSpeedFactor = 2.5
                                   };

            Assert.That(_game.GameTime, Is.EqualTo(new DateTime(2019, 5, 12, 17, 0, 0)));
        }
    }
}