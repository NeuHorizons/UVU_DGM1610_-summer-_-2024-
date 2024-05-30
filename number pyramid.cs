using System; 

public class Program
{
    public static void Main()
    {
        // Display a message asking the user to enter the number of rows for the pyramid.
        Console.WriteLine("Enter the number of rows for the pyramid (positive integer):");
        int numRows; // Declare an integer variable named numRows to store the user's input.

        // This while loop continues to prompt the user for input until a valid positive integer is entered.
        // int.TryParse attempts to convert the user's input into an integer. If the conversion fails, it returns false.
        // The loop also checks if the input is greater than 0 to ensure it's a positive integer.
        while (!int.TryParse(Console.ReadLine(), out numRows) || numRows <= 0)
        {
            // If the user's input is invalid (not a positive integer), display an error message and prompt them again.
            Console.WriteLine("Invalid input. Please enter a positive integer:");
        }

        // Call the PrintNumberPyramid method, passing the user's valid input as an argument.
        // This will generate and display the number pyramid.
        PrintNumberPyramid(numRows);
    }

    // This method generates and prints a number pyramid based on the specified number of rows.
    // The number of rows is provided as an argument to the method.
    public static void PrintNumberPyramid(int numRows)
    {
        // The outer loop iterates over each row of the pyramid.
        // It starts from 1 and goes up to the number of rows specified by the user.
        for (int i = 1; i <= numRows; i++)
        {
            // The inner loop iterates over each column in the current row.
            // For each row i, it prints the row number i, i times.
            for (int j = 1; j <= i; j++)
            {
                // Print the current row number i without moving to the next line.
                // This means all the numbers in the current row will be printed on the same line.
                Console.Write(i);
            }

            // After printing all the numbers in the current row, move to the next line.
            // This prepares the console to print the next row of the pyramid.
            Console.WriteLine();
        }
    }
}
