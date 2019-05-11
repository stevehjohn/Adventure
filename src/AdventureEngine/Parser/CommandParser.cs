using AdventureEngine.Extensions;
using AdventureEngine.Localisation;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            input = input.ToLower(CultureInfo.InvariantCulture)
                         .RemovePunctuation();

            var words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            words = words.Where(w => ! _language.Fillers.Contains(w)).ToArray();

            if (words.Length % 2 != 0)
            {
                return null;
            }

            var actions = new List<Action>();

            string currentWord = null;

            try
            {
                for (var i = 0; i < words.Length; i += 2)
                {
                    currentWord = words[i];

                    var verb = _language.Verbs.Single(v => v.Value.Contains(words[i])).Key;

                    actions.Add(new Action
                                {
                                    Verb = verb,
                                    Subject = words[i + 1]
                                });
                }
            }
            catch
            {
                throw new ParserException(currentWord);
            }

            return actions;
        }
    }
}