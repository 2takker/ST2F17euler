using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem5
    {
        public static int SmallestMultiple(int divisibleBy)
        {
            var found = false;
            var number = 0;
            var counter = 0;

            while (!found)
            {
                //If it has to be evenly divisible by even numbers too, we can rule out all uneven numbers.
                number += 2;
                for (int i = 1; i <= divisibleBy; i++)
                {
                    if (number % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 20)
                {
                    found = true;
                }
                counter = 0;
            }
            return number;
        }


    }
}
