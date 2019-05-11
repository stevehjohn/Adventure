using AdventureEngine.Localisation;
using AdventureEngine.Parser;
using NUnit.Framework;

namespace AdventureEngine.Tests.Parser
{
    public class CommandParserTests
    {
        private CommandParser _parser;

        [SetUp]
        public void SetUp()
        {
            _parser = new CommandParser(new English());
        }

        [Test]
        public void Parser_removes_filler_words()
        {
            var result = _parser.Parse("take the axe then move north");

            Assert.That(result.Count, Is.EqualTo(2));
        }
    }
}