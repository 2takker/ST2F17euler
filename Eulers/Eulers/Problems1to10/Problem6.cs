using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem6
    {
        public static int SumSquareDifference(int inclusiveThreshold)
        {
            var sumOfSquares = 0;
            var squareOfSums = 0;

            for (int i = 1; i <= inclusiveThreshold; i++)
            {
                sumOfSquares += Convert.ToInt32(Math.Pow(i, 2));
                squareOfSums += i;
            }
            squareOfSums = Convert.ToInt32(Math.Pow(squareOfSums, 2));

            var result = squareOfSums - sumOfSquares;
            return result;
        }

    }
}
