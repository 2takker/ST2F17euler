using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem7
    {
        public static int NthPrimeNumber(int N)
        {
            var primeCount = 1;
            var check = 1;

            while (primeCount < N)
            {
                if (CheckIfPrime(check))
                {
                    primeCount++;
                }
                check += 2;
            }
            //Subtract 2 as 2 is added on the last iteration of the loop, after reaching Nth primecount.
            return check - 2;
        }

        public static bool CheckIfPrime(int number)
        {
            var limit = Convert.ToInt32(Math.Sqrt(number) + 1);

            if (number < 2)
            {
                return false;
            }

            //If divisible by any number below the limit, it's not a prime 
            for (int i = 3; i < limit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
