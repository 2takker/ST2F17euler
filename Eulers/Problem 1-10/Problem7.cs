using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem7
    {
        public void Prime()
        {
            List<long> primeNumbers = new List<long>() { 2 };
            for (long i = 3; i < long.MaxValue; i += 2)
            {
                bool any = false;
                foreach (var p in primeNumbers)
                {
                    if ((i % p) == 0)
                    {
                        any = true;
                        break;
                    }
                }
                if (!any)
                {
                    primeNumbers.Add(i);
                    if (primeNumbers.Count == 10001)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }


    }
}
