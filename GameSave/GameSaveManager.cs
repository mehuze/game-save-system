using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace GameSave
{
    public class GameSaveManager
    {
        public string Save(GameState state)
        {
            return JsonSerializer.Serialize(state);
        }
        public GameState? Load(string json)
        {
            return JsonSerializer.Deserialize<GameState>(json);
        }
    }
}
