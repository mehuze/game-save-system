using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSave
{
   public class GameState
    {
        public string PlayerName { get; set; } = string.Empty;
        public int Health { get; set; }
        public int Score { get; set; }
    }
}
