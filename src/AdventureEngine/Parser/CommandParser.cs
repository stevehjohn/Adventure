using AdventureEngine.Localisation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventureEngine.Parser
{
    public class CommandParser : ICommandParser
    {
        private readonly Language _language;

        public CommandParser(Language language)
        {
            _language = language;
        }

        public List<Action> Parse(string input)
        {
            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(w => ! _language.Fillers.Contains(w)).ToArray();

            var actions = new List<Action>();

            foreach (var word in words)
            {
                
            }

            return actions;
        }
    }
}