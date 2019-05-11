using System.Collections.Generic;

namespace AdventureEngine.Parser
{
    public interface ICommandParser
    {
        List<Action> Parse(string input);
    }
}