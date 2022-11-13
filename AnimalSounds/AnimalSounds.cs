// <copyright file="AnimalSounds.cs" company="Joe Bob">
// Copyright (c) Joe Bob. All rights reserved.
// </copyright>

namespace CodeReviewDemo;

/// <summary>
/// Prints the sounds of different animals!
/// </summary>
public class AnimalSounds
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to this Animal Sounds Program!");

        while (true)
        {
            Console.WriteLine("Please enter an animal from the options below: ");
            Console.WriteLine("|Cat|Dog|Mouse|Crow|Cow|");
            Console.WriteLine("Enter \"Q\" to quit");
            string userSelection = Console.ReadLine();

            if (userSelection!.Equals("Cat"))
            {
                Console.WriteLine("Meow!");
            }

            if (userSelection!.Equals("Dog"))
            {
                Console.WriteLine("Woof!");
            }

            if (userSelection!.Equals("Mouse"))
            {
                Console.WriteLine("Squeak!");
            }

            if (userSelection.Equals("Crow"))
            {
                Console.WriteLine("Caw!");
            }

            if (userSelection.Equals("Cow"))
            {
                Console.WriteLine("Moo!");
            }

            if (userSelection.Equals("Q"))
            {
                break;
            }
        }
        
        Console.WriteLine("Goodbye!");
    }
}