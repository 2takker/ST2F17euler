using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem10
    {
        public static long SummationOfPrimes(int N)
        {
            long sum = 2;

            //Already made a method to check for primes in problem 7, so that makes this one pretty simple
            for (int i = 1; i < N; i += 2)
            {
                if (Problem7.CheckIfPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

    }
}
