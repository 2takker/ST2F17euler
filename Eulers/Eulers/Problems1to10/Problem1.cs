using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem1
    {
        public static int FindMultiplesSum(int a, int b, int threshold)
        {
            var sum = 0;
            for (int i = 0; i < threshold; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
