using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem12
    {
        //Ikke færdig

        private long _triangle;
        private int _counter;
        public long TriangleNumbers()
        {
            _triangle = 0;
            _counter = 0;
            for (long i = 1; i < long.MaxValue; i++)
            {
                _triangle += i;
                for (int j = 1; j < i; j++)
                {
                    if (_triangle % j == 0)
                    {
                        _counter++;
                        if (_counter > 500)
                        {
                            return _triangle;
                        }
                    }
                }
                _counter = 0;
            }
            return _triangle;
        }


    }
}
