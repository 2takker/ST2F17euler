using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Fib
    {


        public long sumEvenFib(long limit)
        {
            long result = 0;
            int count = 1;
            long fib = 0;
            List<long> fibList = new List<long>() { 1, 2 };

            while (fib < limit)
            {
                fib = (fibList[count] + fibList[count - 1]);
                fibList.Add(fib);
                count++;
            }

            foreach (long e in fibList)
            {
                if (e % 2 == 0)
                {
                    result += e;
                }
            }
            return result;
        }
    }
}
