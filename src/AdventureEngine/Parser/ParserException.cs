using System;

namespace AdventureEngine.Parser
{
    public class ParserException : Exception
    {
        public ParserException(string message) : base (message)
        {
        }
    }
}