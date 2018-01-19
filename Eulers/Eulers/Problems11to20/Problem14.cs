using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.Problems11to20
{
    public class Problem14
    {
        private static int[] _calculatedSequences;

        public static CollatzData LongestCollatzSequence(int nonInclusiveThreshold)
        {
            //Create an array holding the calculated sequence lengths of the starting numbers equal to the
            //index in the array, to avoid checking already calculated sequence lengths again
            _calculatedSequences = new int[nonInclusiveThreshold];

            var collatzNumber = 0;
            var sequenceLength = 0;
            long temp;

            //Start at 2 as 1 just has a sequence length of 1
            for (int i = 2; i < nonInclusiveThreshold; i++)
            {
                temp = i;
                var count = 1;
                while (temp != 1 && temp >= i)
                {
                    count++;
                    if (temp % 2 == 0)
                    {
                        temp /= 2;
                    }
                    else
                    {
                        temp = temp * 3 + 1;
                    }
                }
                //Add to already calculated sequences
                _calculatedSequences[i] = count + _calculatedSequences[temp];

                if (_calculatedSequences[i] > sequenceLength)
                {
                    sequenceLength = _calculatedSequences[i];
                    collatzNumber = i;
                }
            }
            return new CollatzData() {CollatzSequenceStartNumber = collatzNumber, SequenceLength = sequenceLength};
        }

        public static CollatzData CollatzSequence(int start)
        {
            var count = 1;
            var temp = start;

            while (temp != 1)
            {
                if (temp % 2 == 0)
                {
                    temp /= 2;
                }
                else
                {
                    temp = temp * 3 + 1;
                }
                count++;
            }
            return new CollatzData() {CollatzSequenceStartNumber = start, SequenceLength = count};
        }

    }
}
