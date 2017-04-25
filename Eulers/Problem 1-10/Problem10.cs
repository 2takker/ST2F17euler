using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem10
    {
        private long _result;
        public long FindSum()
        {
            _result = 2;

            List<long> primeNumbers = new List<long>() { 2 };
            for (long i = 3; i < 2000000; i += 2)
            {
                if (!primeNumbers.Any(p => (i % p) == 0))
                {
                    primeNumbers.Add(i);
                    //_result += i;
                }
            }
            return primeNumbers.Sum();
        }

    }
}
