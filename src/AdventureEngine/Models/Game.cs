using System;

namespace AdventureEngine.Models
{
    public class Game
    {
        public GameDefinition GameDefinition { get; set; }

        public DateTime GameTime { get; set; }

        public Player Player { get; set; }
    }
}