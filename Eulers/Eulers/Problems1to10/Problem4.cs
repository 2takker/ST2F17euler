using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem4
    {
        public static int LargestPalindrome(int inclusiveThreshold)
        {
            string str;
            var max = 0;
            var temp = 0;
            for (int i = 100; i <= inclusiveThreshold; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    str = Convert.ToString(i * j);
                    var charArray = str.ToCharArray();
                    Array.Reverse(charArray);
                    var reverse = new string(charArray);

                    if (str == reverse)
                    {
                        temp = Convert.ToInt32(str);
                        if (temp > max)
                        {
                            max = temp;
                        }
                    }
                }
            }

            return max;
        }
    }
}
