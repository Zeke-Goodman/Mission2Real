using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Real
{
    // define class for rolling the dice
    public class rollDice
    {
        public int[] Simulator(int numRolls)
        {

            int[] rollTotals = new int[13];

            // initialize variables
            int die1 = 0;
            int die2 = 0;
            int diceTotal = 0;
            // create an instance of the random object class
            Random random = new Random();

            // loop to generate a random number per die as many times as the user selected
            // add the dice together and count how many times each possible combination showed up
            for (int count = 1; count <= numRolls; count++)
            {
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);
                diceTotal = die1 + die2;

                rollTotals[diceTotal]++;
            }

            return rollTotals;
        }
    }
}
