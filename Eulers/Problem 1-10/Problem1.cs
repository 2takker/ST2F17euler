using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem1
    {
        private int _sum;
        public int Multiple()
        {
            _sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    _sum += i;
                }
            }
            return _sum;
        }
    }
}
