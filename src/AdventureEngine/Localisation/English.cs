using AdventureEngine.Models;
using System.Collections.Generic;

namespace AdventureEngine.Localisation
{
    public class English : Language
    {
        public override Dictionary<Verb, string[]> Verbs => new Dictionary<Verb, string[]>
                                                            {
                                                                { Verb.Move, new[] { "go", "move", "head", "walk" } },
                                                                { Verb.Pickup, new[] { "take", "pickup", "grab", "seize" } },
                                                                { Verb.Drop, new[] { "drop", "leave" } },
                                                                { Verb.Use, new[] { "use" } }
                                                            };

        public override string[] Fillers => new[] { "the", "a", "an", "then" };
    }
}