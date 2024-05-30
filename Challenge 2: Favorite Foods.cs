using System;

public class Program
{
    public static void Main()
    {
        // Ask the user how many favorite foods they want to enter
        Console.WriteLine("How many favorite foods do you want to list?");
        int numFoods;

        // Validate user input to ensure it's a positive integer
        while (!int.TryParse(Console.ReadLine(), out numFoods) || numFoods <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer:");
        }

        // Create an array to store the favorite foods
        string[] favoriteFoods = new string[numFoods];

        // Loop to get the favorite foods from the user
        for (int i = 0; i < numFoods; i++)
        {
            // Prompt the user to enter each favorite food
            Console.WriteLine(string.Format("Enter favorite food #{0}:", i + 1));
            favoriteFoods[i] = Console.ReadLine();
        }

        // Loop to display each favorite food with a message
        Console.WriteLine("\nHere are your favorite foods:");
        foreach (string food in favoriteFoods)
        {
            // Print a message for each favorite food using string.Format
            Console.WriteLine(string.Format("I love {0}!", food));
        }
    }
}
