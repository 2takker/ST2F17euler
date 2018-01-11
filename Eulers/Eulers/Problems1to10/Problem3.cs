using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem3
    {
        public static long LargestPrimeFactor(long number)
        {
            var max = number / 2 + 1;

            for (var i = number / 2 + 1; i > 0; i--)
            {
                if (number % i == 0)
                {
                    return i;
                }
            }
            throw new Exception("No prime factor found");
        }
    }
}
