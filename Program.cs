using Mission2Real;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? (Please enter a number)");

        string rollCount = "";
        rollCount = Console.ReadLine();
        int iRollCount = int.Parse(rollCount);

        rollDice rollDice = new rollDice();
        int[] rollTotals = rollDice.Simulator(iRollCount);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + rollCount);
        double percentage = 0.0;

        for (int position = 2; position < rollTotals.Length; position++)
        {
            percentage = ((float)rollTotals[position] / iRollCount) * 100;

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