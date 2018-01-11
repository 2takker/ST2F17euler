using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eulers.Problems11to20;

namespace Eulers.Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Problem1.FindMultiplesSum(3, 5, 1000));
            //Console.WriteLine(Problem2.EvenFibonacciSum(4000000));
            //Console.WriteLine(Problem3.LargestPrimeFactor(600851475143));
            //Console.WriteLine(Problem4.LargestPalindrome(999));
            //Console.WriteLine(Problem5.SmallestMultiple(20));
            //Console.WriteLine(Problem6.SumSquareDifference(100));
            Console.WriteLine(Problem7.NthPrimeNumber(10001));
            //Console.WriteLine(Problem8.AdjacentSum(13, "NumbersSequence.txt"));
            //Console.WriteLine(Problem10.SummationOfPrimes(2000000));
            Console.WriteLine(Problem11.LargestProductInGrid(20, 4, "Grid.txt"));
            Console.ReadKey();
        }
    }
}
