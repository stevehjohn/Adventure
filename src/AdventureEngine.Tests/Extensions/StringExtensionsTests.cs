using AdventureEngine.Extensions;
using NUnit.Framework;

namespace AdventureEngine.Tests.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        [Test]
        public void RemovePunctuation_removes_punctuation()
        {
            Assert.That("This, string. has: varying' punctuation% characters".RemovePunctuation(), Is.EqualTo("This string has varying punctuation characters"));
        }
    }
}