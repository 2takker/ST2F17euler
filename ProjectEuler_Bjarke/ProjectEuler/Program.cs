using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumEvenFib(4000000)); 
        }

        static long sumMultiple3t5(int limit)
        {
            long result = 0;

            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }

        static long sumEvenFib(long limit)
        {
            long result = 0;
            int count = 1;
            long fib = 0;
            List<long> fibList = new List<long>();
            fibList.Add(1);
            fibList.Add(2);

            while(fib < limit)
            {
                fib = (fibList[count] + fibList[count - 1]);
                fibList.Add(fib);
                count++;
            }

            foreach(long e in fibList)
            {
                if(e%2 == 0)
                {
                    result += e;
                }
            }
            return result;
        }
    }

}
