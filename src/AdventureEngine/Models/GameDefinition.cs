using System.Collections.Generic;

namespace AdventureEngine.Models
{
    public class GameDefinition
    {
        public List<Character> Characters { get; set; }

        public List<Location> Locations { get; set; }

        public double TimeSpeedFactor { get; set; }
    }
}