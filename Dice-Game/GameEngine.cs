using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class GameEngine
    {
        internal Player Player;
        internal AI_Engine AI_Engine;

        public GameEngine()
        {
            // Create a new player class.
            Player = new Player();

            // Create a new AI_Engine.
            AI_Engine = new AI_Engine();
        }

        public bool MainMenu()
        {
            Console.Clear();
            // Print off the menu.
            PrintMenu();
            
            // Get the user input.
            string userInput = Console.ReadLine();

            switch (userInput)
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
            Console.WriteLine(Player.Name + " SCORE: " + Player.Points);
            Console.WriteLine("Rollllllinnnggggg..........");

            playerRoll = this.Player.PlayerRoll();
            aiRoll = this.AI_Engine.AI_Roll();

            result = Winner(playerRoll, aiRoll);

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
            Console.WriteLine(Player.Name + "Rolled a " + playerRoll);
            Console.WriteLine("The Computer scored a " + aiRoll);
        }

        private bool Winner(int playerRoll, int aiRoll)
        {
            if (playerRoll >= aiRoll)
            {
                this.Player.Points++;
                return true;
            }
            else if (aiRoll <= playerRoll)
            {
                return false;
            }

            return false;
        }

        private void GameOver()
        {
            Console.WriteLine("Sorry " + this.Player.Name + "maybe next time!" );
            Console.WriteLine("Press any button to continue");
            Console.ReadLine();
            MainMenu();
        }

        private void ChangeName()
        {
            string n;
            n = Console.ReadLine();
            Player.Name = n;
        }

        private void PrintMenu()
        {
            Console.WriteLine("***** MAIN MENU *****");
            Console.WriteLine("GREETINGS " + Player.Name + "!");
            Console.WriteLine("   Press 1 to play!   ");
            Console.WriteLine("   Press 2 to change your name");
        }
    }
}
