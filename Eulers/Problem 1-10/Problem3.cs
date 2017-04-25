using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem3
    {
        private long _counter;
        private long _prime;
        private long _result;

        public long LargePrimeFactor(long n)
        {
            _counter = 0;
            _prime = 0;
            _result = 0;
            for (long i = (n - 1 / 2); i < n; i++)
            {
                for (long j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        _counter++;
                    }
                    if (_counter > 2)
                    {
                        break;
                    }
                }

                if (_counter == 2 && i > _prime)
                {
                    _prime = i;
                }
                if (n % _prime == 0)
                {
                    _result = _prime;
                }

                _counter = 0;
            }
            return _result;
        }
    }
}
