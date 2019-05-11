using AdventureEngine.Localisation;
using AdventureEngine.Models;
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
            var result = _parser.Parse("I want to take the axe then move north.");

            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].Verb, Is.EqualTo(Verb.Pickup));
            Assert.That(result[0].Subject, Is.EqualTo("axe"));
            Assert.That(result[1].Verb, Is.EqualTo(Verb.Move));
            Assert.That(result[1].Subject, Is.EqualTo("north"));
        }
    }
}