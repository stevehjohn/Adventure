using AdventureEngine.Implementation;
using AdventureEngine.Interfaces;
using AdventureEngine.Parser;
using Moq;
using NUnit.Framework;

namespace AdventureEngine.Tests.Implementation
{
    [TestFixture]
    public class AdventureEngineTests
    {
        private Mock<IInputOutput> _io;
        private Mock<ICommandParser> _parser;

        private IEngine _engine;

        [SetUp]
        public void SetUp()
        {
            _io = new Mock<IInputOutput>();
            _parser = new Mock<ICommandParser>();
            
            _engine = new Engine(_io.Object, _parser.Object);
        }
    }
}