using AdventureEngine.Models;
using Newtonsoft.Json;
using System.IO;

namespace AdventureEngine.Infrastructure
{
    public static class GameDefinitionLoader
    {
        public static GameDefinition Load(string path)
        {
            var data = File.ReadAllText(path);

            return JsonConvert.DeserializeObject<GameDefinition>(data);
        }
    }
}