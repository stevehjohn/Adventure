using AdventureEngine.Models;
using System.Collections.Generic;

namespace AdventureEngine.Localisation
{
    public abstract class Language
    {
        public abstract Dictionary<Verb, string[]> Verbs { get; }

        public abstract string[] Fillers { get; }
    }
}