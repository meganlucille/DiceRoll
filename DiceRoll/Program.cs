
using System;
class DiceRollingSimulator
{
    static void Main()
        // Megan Johnson - IS 413 - Hilton
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        int numRolls = 0; // setting the default to zero

        // Input number of dice rolls 
        Console.Write("How many dice rolls would you like to simulate? ");
        numRolls = int.Parse(Console.ReadLine()); //had to do this parse becuase it wasn't a string

        // Create array to store number of times the total
        int[] totals = new int[13];

        // Roll the dice the specified number of times, adding the totals to the array 
        Random randNum = new Random();
        for (int i = 0; i < numRolls; i++)
        {
            int diceOne = randNum.Next(1, 7);
            int diceTwo = randNum.Next(1, 7);
            int total = diceOne + diceTwo;
            totals[total]++;
        }

        // print totals
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".");
        for (int i = 2; i <= 12; i++) // loop to print the histogram
        {
            Console.Write(i + ": ");
            int numStars = (int)Math.Round(totals[i] / (double)numRolls * 100);
            for (int j = 0; j < numStars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}