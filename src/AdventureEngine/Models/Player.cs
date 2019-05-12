using System.Collections.Generic;

namespace AdventureEngine.Models
{
    public class Player
    {
        public int Health { get; set; }

        public int Location { get; set; }

        public List<Item> Items { get; set; }
    }
}