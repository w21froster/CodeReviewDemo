using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Player
    {
        private string name;
        private int points;
        private Random rnd;
        private int highestDice;
        public Player()
        {
            this.name = "Player 1";
            highestDice = 19;
            points = 0;
            rnd = new Random();
        }

        public string Name { get; set; }
        public int Points { get; set; }

        public int PlayerRoll()
        {
            int returnVar = rnd.Next(highestDice+1);
            return returnVar;
        }
        
    }
}
