using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Engine
    {
        private int highestDice { get; set; }
        private Random rnd;

        public Engine()
        {
            // Changed this up because Joe Bob always wants to win!
            highestDice = -1;
            rnd = new Random();
        }

        public int Roll()
        {
            int returnVar = rnd.Next(highestDice+1);
            return returnVar;
        }  
        
        
    }
}
