using System;

namespace AdventureEngine.Models
{
    public class Item
    {
        public string Description { get; set; }

        public Func<string, Game> Use { get; set; }
    }
}