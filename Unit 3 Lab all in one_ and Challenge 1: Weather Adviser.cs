using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is the Temperature at your location using Celsius");

        // Read the user input from the console and convert it to an integer
        string userInput = Console.ReadLine();
        int number;

        // Check if the input is a valid integer
        if (int.TryParse(userInput, out number))
        {
            // Check the temperature range and provide feedback
            if (number < 0)
            {
                Console.WriteLine("It's freezing outside! Make sure to bundle up.");
            }
            else if (number >= 0 && number <= 10)
            {
                Console.WriteLine("It's cold outside. Wear warm clothes.");
            }
            else if (number > 10 && number <= 20)
            {
                Console.WriteLine("It's cool outside. A light jacket should be fine.");
            }
            else if (number > 20 && number <= 30)
            {
                Console.WriteLine("It's warm outside. Dress comfortably.");
            }
            else if (number > 30 && number <= 40)
            {
                Console.WriteLine("It's hot outside! Stay hydrated and wear light clothing.");
            }
            else
            {
                Console.WriteLine("You're going to die... Good luck... unless you have a space suit.");
                // Get the person's choice
                Console.Write("Wait... do you have a space suit? (Yes or No): ");

                // Read the user's choice from the console
                string userChoice = Console.ReadLine();

                // Check the user's choice
                if (userChoice == "Yes")
                {
                    Console.WriteLine("Well, that's kind of weird but okay... I guess you survive... for now :)");
                }
                else if (userChoice == "No")
                {
                    Console.WriteLine("Sorry to say this but you're going to die");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please restart the program and choose either Yes or No.");
                }
            }
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("That's not a valid temperature. Please enter a valid number.");
        }
    }
}
