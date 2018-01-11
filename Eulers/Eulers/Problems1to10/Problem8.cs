using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eulers
{
    public class Problem8
    {
        public static long AdjacentSum(int adjacentNumbers, string fileName)
        {
            string sequence;
            using (var streamReader = new StreamReader(fileName))
            {
                sequence = streamReader.ReadToEnd();
                sequence = Regex.Replace(sequence, @"\r\n|\n", "");
            }

            long max = 0;
            long product = 1;
            string subString;
            for (int i = 0; i <= sequence.Length - adjacentNumbers; i++)
            {
                subString = sequence.Substring(i, adjacentNumbers);
                for (int j = 0; j < subString.Length; j++)
                {
                    product *= Convert.ToInt32(subString[j]) - 48;
                }
                if (product > max)
                {
                    max = product;
                }
                product = 1;
            }
            return max;
        }


    }
}
