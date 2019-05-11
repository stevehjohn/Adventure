using System.Collections.Generic;

namespace AdventureEngine.Models
{
    public class Location
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public Dictionary<Direction, int> Moves { get; set; }

        public List<Item> Items { get; set; }

        public Location()
        {
            Moves = new Dictionary<Direction, int>();
            Items = new List<Item>();
        }
    }
}