using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem4
    {
        private int result = 0;
        private int endresult = 0;
        public int ReverseInt(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            return result;
        }

        public int Palindrome()
        {
            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    result = i * j;
                    if (result == ReverseInt(result))
                    {
                        if (result > endresult)
                        {
                            endresult = result;
                        }
                    }
                }

            }
            return endresult;
            //for (int i = 999; i >= 100; i--)
            //{
            //    for (int j = 100; j <= 999; j++)
            //    {
            //        if (i * j > result)
            //        {
            //            result = i * j;
            //        }
            //        if (result == ReverseInt(result) && result > endresult)
            //        {
            //            endresult = result;
            //        }
            //    }
            //}
            //return endresult;
        }
    }
}
