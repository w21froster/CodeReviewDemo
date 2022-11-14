// Copy Right: Joe Bob if the boss takes this code im sueing 
namespace Dice_Game
{
    internal class Joebobsplayer
    {
        private string name;
        private int points;
        private Random rnd;
        private int highestDice;
        public Joebobsplayer()
        {
            this.name = "Player 1";
            highestDice = 100; // Im always 100
            points = 0;
            rnd = new Random();
        }

        public string Name { get; set; }
        public int Points { get; set; }

        public int RizzyRoll()
        {
            int returnVar = rnd.Next(highestDice + 100);
            return returnVar;
        }

    }
}
