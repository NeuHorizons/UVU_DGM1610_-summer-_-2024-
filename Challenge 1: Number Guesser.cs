using System; // Required to use the Console class

public class GuessingGame
{
    public static void Main()
    {
        // Makes a random number generator
        Random random = new Random();
        
        // Chooses a number between 1 and 10 for you to guess
        int targetNumber = random.Next(1, 11);
        
        // This will store your guesses
        int guess = 0;
        
        // This counts how many times you try
        int attempts = 0;
        
        // This keeps track of how many times you give weird inputs
        int invalidAttempts = 0;

        Console.WriteLine("I've picked a number between 1 and 10.");
        Console.WriteLine("Can you guess what it is?");

        // Here's where the loop starts, it will keep going until you guess right
        while (guess != targetNumber)
        {
            Console.Write("Enter your guess: "); // What's your guess?
            string userInput = Console.ReadLine(); // Reads the response

            // The program tries to understand what you typed
            if (int.TryParse(userInput, out guess)) // If it's a number
            {
                attempts++; // We'll count that as an attempt

                // Let's see if your guess is too high, too low, or just right
                if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed it.");
                    // This line of code prints the number of attempts the user made to guess the correct number
                    Console.WriteLine("It took you {0} attempts.", attempts);
                }
            }
            else // If what you typed wasn't a number
            {
                invalidAttempts++; // Adds how many times you failed

                // If you keep giving strange inputs, it will check if you're alright :)
                if (invalidAttempts >= 5)
                {
                    Console.WriteLine("Are you ok? Didn't I say put in a whole number?");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10.");
                }
            }
        }
    }
}
