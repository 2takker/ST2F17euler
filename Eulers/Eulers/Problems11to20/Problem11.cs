using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers.Problems11to20
{
    public class Problem11
    {

        public static int LargestProductInGrid(int gridSize, int numbersToMultiply, string gridFileName)
        {
            var grid = new int[gridSize, gridSize];

            ReadGridFromFile(gridFileName, ref grid);

            var max = 0;
            var horizontalProduct = 1;
            var verticalProduct = 1;
            var diagonalProductLeftToRight = 1;
            var diagonalProductRightToLeft = 1;

            for (int i = 0; i < gridSize - numbersToMultiply; i++)
            {
                for (int j = 0; j < gridSize - numbersToMultiply; j++)
                {
                    for (int k = 0; k < numbersToMultiply; k++)
                    {
                        horizontalProduct *= grid[i, j + k];
                        verticalProduct *= grid[i + k, j];
                        diagonalProductLeftToRight *= grid[i + k, j + k];
                        diagonalProductRightToLeft *= grid[(i + (numbersToMultiply - 1)) - k, (i + k)];
                    }
                    CheckIfLargerThanMax(ref max, horizontalProduct);
                    CheckIfLargerThanMax(ref max, verticalProduct);
                    CheckIfLargerThanMax(ref max, diagonalProductLeftToRight);
                    CheckIfLargerThanMax(ref max, diagonalProductRightToLeft);
                    ResetProducts(ref horizontalProduct, ref verticalProduct, ref diagonalProductLeftToRight, ref diagonalProductRightToLeft);
                }
            }
            return max;
        }

        private static void CheckIfLargerThanMax(ref int max, int product)
        {
            if (product > max)
            {
                max = product;
            }
        }

        private static void ResetProducts(ref int horizontalProduct, ref int verticalProduct,
            ref int diagonalProductLeftToRight, ref int diagonalProductRightToLeft)
        {
            horizontalProduct = 1;
            verticalProduct = 1;
            diagonalProductLeftToRight = 1;
            diagonalProductRightToLeft = 1;
        }
        private static void ReadGridFromFile(string fileName, ref int[,] grid)
        {
            string temp;
            var stringList = new List<string>();
            using (var streamReader = new StreamReader(fileName))
            {
                while (!streamReader.EndOfStream)
                {
                    temp = streamReader.ReadLine();
                    stringList.Add(temp);
                }
            }

            for (int i = 0; i < stringList.Count; i++)
            {
                var numbers = stringList[i].Split(' ');

                for (int j = 0; j < numbers.Length; j++)
                {
                    grid[i, j] = Convert.ToInt32(numbers[j]);
                }
            }

           
        }

    }
}
