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

        static long sumEvenFib(int limit)
        {
            long result = 0;
            List<long> fibList = new List<long>();

            for(int i = 1; i < limit; i++ )
            {
                
                if(((i-1)+i)%2 == 0 && )

            }

            return result;
        }
    }

}
