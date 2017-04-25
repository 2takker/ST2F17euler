using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem2
    {
        private int _sum;
        private int _a;
        private int _b;
        public int Fibbonacci()
        {
            _sum = 0;
            _a = 1;
            _b = 1;

            for (int i = 0; _b < 4000000; i++)
            {
                _b = _a + _b;
                _a = _b - _a;
                if (_b % 2 == 0)
                {
                    _sum += _b;
                }
            }
            return _sum;

            //int j = 1;
            //for (int i = 1; i < 4000001; i = j)
            //{
            //    if (i < 1000)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    j += i;
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    //if (j % 2 == 0)
            //    //{
            //    //    sum += j;
            //    //}
            //}
            //return sum;

            //List<int> liste = new List<int>() {1, 2};

            //for (int i = 1; liste[i] < 4000000; i++)
            //{
            //    liste.Add(liste[i] + liste[i-1]);
            //}
            //foreach (int element in liste)
            //{
            //    if (element % 2 == 0)
            //    {
            //        sum += element;
            //    }
            //}
            //return sum;
        }


    }
}
