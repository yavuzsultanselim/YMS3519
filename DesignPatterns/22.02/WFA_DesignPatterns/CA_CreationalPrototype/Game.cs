using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_CreationalPrototype
{
    public class Game : ProtoTypeGame
    {
        public int PlayerID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool IsActive { get; set; }
   
        public Game(int playerId, string gameName, string gameType, bool isActive)
        {
            PlayerID = playerId;
            GameName = gameName;
            GameType = gameType;
            IsActive = isActive;
        }

        public override ProtoTypeGame Clone()
        {
            return this.MemberwiseClone() as ProtoTypeGame;
        }
    }
}
