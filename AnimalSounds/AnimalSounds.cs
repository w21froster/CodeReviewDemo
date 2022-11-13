// <copyright file="AnimalSounds.cs" company="Joe Bob @ PlaceholderCompany">
// Copyright (c) Joe Bob @ PlaceholderCompany. All rights reserved.
// </copyright>

using System.Data.Common;

namespace CodeReviewDemo;

// I am making changes i think wee should add to fix probelms and make code better :)
// I made animal class so we can treat animals like objects and make new animals dynamically

/// <summary>
/// Prints the sounds of different animals!
/// </summary>
public class AnimalSounds
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this animal Sounds Program!");
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.WriteLine("Please enter an animal from the options below: ");
            Console.WriteLine("|Cat|Dog|Mouse|Crow|Cow|");
            Console.WriteLine("Enter \"Q\" to quit");
            string userSelection = Console.ReadLine();

            switch (userSelection)
            {
                case "Cat":
                    Console.WriteLine("Meow!");
                    break;
                case "Dog":
                    Console.WriteLine("Woof!");
                    break;
                case "Mouse":
                    Console.WriteLine("Squeak!");
                    break;
                case "Crow":
                    Console.WriteLine("Caw!");
                    break;
                case "Cow":
                    Console.WriteLine("Moo!");
                    break;
                case "Q":
                    continueProgram = false;
                    break;
                default:
                    Console.WriteLine("Unknown Animal.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}