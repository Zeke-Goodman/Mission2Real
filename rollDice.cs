using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Real
{
    public class rollDice
    {
        public int[] Simulator(int numRolls)
        {

            int[] rollTotals = new int[13];

            int die1 = 0;
            int die2 = 0;
            int diceTotal = 0;
            Random random = new Random();

            //put for loop here for int.Parse(rollCount)

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
