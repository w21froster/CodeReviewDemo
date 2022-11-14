using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class AI_Engine
    {
        private int highestDice { get; set; }
        private Random rnd;

        public AI_Engine()
        {
            highestDice = 19;
            rnd = new Random();
        }

        public int AI_Roll()
        {
            int returnVar = rnd.Next(highestDice+1);
            return returnVar;
        }   
    }
}
