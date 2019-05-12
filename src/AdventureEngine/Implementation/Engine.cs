using AdventureEngine.Infrastructure;
using AdventureEngine.Interfaces;
using AdventureEngine.Parser;

namespace AdventureEngine.Implementation
{
    public class Engine : IEngine
    {
        private readonly IInputOutput _io;
        private readonly ICommandParser _parser;

        public Engine(IInputOutput io, ICommandParser parser)
        {
            _io = io;
            _parser = parser;
        }
    }
}