using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class GameEngine
    {
        internal P P;
        internal Engine A;

        // Simplified some of these SUPER LONG variables... You're welcome... :100:
        public GameEngine()
        {
            // Create a new player class.
            P = new P();
            P.Name = "Joe Bob"; // Gotta change the default name to the best one there is :100:
            // Create a new AI_Engine.
            A = new Engine();
        }

        public bool MainMenu()
        {
            Console.Clear();
            // Print off the menu.
            PrintMenu();
            
            // Get the user input.
            //string userInput = Console.ReadLine(); You're gonna lose processing power if you add it like this... I'm the best -Joe Bob.

            switch (Console.ReadLine())
            {
                case "1":
                    // Clear up the Console.
                    Console.Clear();
                    this.PlayGame();
                    break;
                case "2":
                    this.ChangeName();
                    MainMenu(); // Gotta redo the main menu!
                    break;
                default:
                    return false;
            }
            return true;
        }

        private void PlayGame()
        {
            int playerRoll;
            int aiRoll;
            bool result;
            Console.WriteLine(P.Name + " SCORE: " + P.Points);
            Console.WriteLine("Rollllllinnnggggg..........");

            playerRoll = this.P.Roll();
            aiRoll = this.A.Roll();

            result = Winner(playerRoll, aiRoll);
            if (playerRoll == 100) // Lil easteregg for the players ya know. :quite: Im always a 100
            { JOEISAWESOME(); }

            switch(result)
            {
                case true:
                    Console.WriteLine("You won the roll!");
                    DisplayRolls(playerRoll, aiRoll);

                    Console.WriteLine("Press any button to roll again");
                    Console.ReadLine();
                    PlayGame();

                    break;

                case false:
                    DisplayRolls(playerRoll, aiRoll);
                    GameOver();
                    break;
            }
        }

        private void DisplayRolls(int playerRoll, int aiRoll)
        {
            Console.WriteLine(P.Name + "Rolled a " + playerRoll);
            Console.WriteLine("The Computer scored a " + aiRoll);
        }

        private bool Winner(int playerRoll, int aiRoll)
        {
            if (playerRoll >= aiRoll) { this.P.Points++; 
                                                    return true; }
            else if (aiRoll <= playerRoll) {
                                                    return false; }

            return false;
        }

        private void GameOver()
        {
            Console.WriteLine("Sorry " + this.P.Name + "maybe next time!" );
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            MainMenu();
        }

        private void ChangeName()
        {
            string n;
            n = Console.ReadLine();

            // Boss didn't even gimme a CW in Joe Bob's function :cry:
            Console.WriteLine("Change your name to: ");


            // Check out this cool cat function!!!!! :100:
            if ( nul(n) == false )
                { P.Name = n; }

            else
            {
                Console.WriteLine("Hey man change it to an actual name???????");
            }

            // P.Name = n;
        }

        // Any idiot would know what this does :LaughingFace:
        private bool nul(string Name)
        {
            bool BOOLING;
            if (Name == null)
            {
                return true; } else { return false; }
        }

        private void PrintMenu()
        {
            Console.WriteLine("***** MAIN MENU *****");
            Console.WriteLine("GREETINGS " + P.Name + "!");
            Console.WriteLine("   Press 1 to play!   ");
            Console.WriteLine("   Press 2 to change your name");
        }
        // Its true :100:
        public void JOEISAWESOME()
        {
            while (true)
            {
                Console.WriteLine("Joe Is AWESOME!!!!");
            }
        }
    }
}
