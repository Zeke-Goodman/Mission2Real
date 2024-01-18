using Mission2Real;
using System.Runtime.InteropServices;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? (Please enter a number)");

        // collect dice roll count from user and convert to integer
        string rollCount = "";
        rollCount = Console.ReadLine();
        int iRollCount = int.Parse(rollCount);

        // create new instance of the rollDice class from mission2Real namespace, create list and pass the number of rolls
        rollDice rollDice = new rollDice();
        int[] rollTotals = rollDice.Simulator(iRollCount);


        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + rollCount);
        double percentage = 0.0;

        // iterate through the possible die roll totals
        for (int position = 2; position < rollTotals.Length; position++)
        {
            // calculate what percent of the total rolls each possible die roll was
            percentage = ((float)rollTotals[position] / iRollCount) * 100;

            // create a string of asterisks equal to the number of the percentage, write the possible die rolls to the console with an asterisk for each 1% of the total rolls
            int asterisksCount = (int)Math.Round(percentage);
            Console.Write(position + ": ");
            for (int i = 0; i < asterisksCount; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator.   Goodbye!");
    }
}