using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem2
    {
        public static int EvenFibonacciSum(int threshold)
        {
            var sum = 0;
            for (int i = 2, n = 1; i <= threshold; i += n)
            {
                n = i - n;
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
