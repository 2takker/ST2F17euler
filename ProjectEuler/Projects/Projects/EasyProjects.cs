using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Projects
{
    class EasyProjects
    {
        private const string Opg8 =
            "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
        public int MultiplesOf3Or5(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            return sum;
        }

        public int FibonacciEvenSum(int n)
        {
            int a = 1;
            int b = 1;
            int sum = 0;
            for (int i = 0; b < n; i++)
            {
                b = a + b;
                a = b - a;
                if (b % 2 == 0)
                    sum += b;
            }
            return sum;
        }

        public long LargestPrimeFactor(long n)
        {
            long a = 0;
            for (long i = 1; i < n; i++)
            {
                long counter = 0;
                if (n % i == 0)
                {
                    for (long j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            counter++;
                        }
                    }
                    if (counter == 2 && a < i)
                        a = i;
                }
            }
            return a;
        }
        public void LargestPrimeFactor2(long n)
        {
            long t1 = Environment.TickCount;
            ArrayList PrimeFaktors = new ArrayList();
            long N = n;
            int MAX = (int)Math.Sqrt(n) + 10;

            BitArray T = new BitArray(MAX);
            T.Set(2, false);
            while (true)
            {
                if (N % 2 == 0)
                {
                    N = N / 2;
                    PrimeFaktors.Add((int)2);
                }
                else break;
            }

            for (int q = 3; q < MAX; q += 2)
            {
                if (!T.Get(q))
                {
                    while (true)
                    {
                        if (N % q == 0)
                        {
                            N = N / q;
                            PrimeFaktors.Add(q);
                            Console.Write(q + " ");
                        }
                        else break;
                    }
                }
                if (N == 1) break;
                for (int t = 2 * q; t < MAX; t += q) T.Set(t, true);
            }
            Console.WriteLine("Klart! Det tog: " + (Environment.TickCount - t1) + "ms");
            Console.ReadLine();
        }

        public int LargestPalindromeNumber()
        {
            int lP = 0;
            int q = 0;
            int w = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    if (CheckIfPalindrome(j * i) == true)
                    {
                        lP = j * i;
                    }
                }
                if (lP > q)
                {
                    q = lP;
                }
            }
            return q;
        }

        private bool CheckIfPalindrome(int p)
        {
            string s = Convert.ToString(p);
            char[] array = s.ToCharArray();
            char[] reverseArray = s.ToCharArray();
            Array.Reverse(reverseArray);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != reverseArray[i])
                    return false;
            }
            return true;

        }

        public int IsDivisibleWith(int n)
        {
            int smallestNumber = 1;
            while (true)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (smallestNumber % i != 0)
                        break;
                    if (i == 20)
                    {
                        return smallestNumber;
                    }
                }
                smallestNumber++;
            }
        }

        public int SumSquareDifference(int n)
        {
            int sumOfSquares = 0;
            int sum = 0;
            for (int i = 0; i < n + 1; i++)
            {
                sumOfSquares += Convert.ToInt32(Math.Pow(i, 2));
            }
            for (int i = 0; i < n + 1; i++)
            {
                sum += i;
            }
            return Convert.ToInt32(Math.Pow(sum, 2)) - sumOfSquares;
        }

        public void FindPrimeNumber10001()
        {
            List<long> primeNumbers = new List<long>() { 2 };
            for (long i = 3; i < long.MaxValue; i += 2)
            {
                bool any = false;
                foreach (var p in primeNumbers)
                {
                    if ((i % p) == 0)
                    {
                        any = true;
                        break;
                    }
                }
                if (!any)
                {
                    primeNumbers.Add(i);
                    if (primeNumbers.Count == 10001)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
        public void PythagorasTriplet()
        {
            int a = 1;
            int b = 2;
            int c = 3;

            for (int i = 0; i < 1000; i++)
            {
                a = i;
                if (CheckForPythagoras(a, b, c))
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine(b);
                        Console.WriteLine(c);
                        Console.WriteLine(a * b * c);
                        return;
                    }
                for (int j = i + 1; j < 1000; j++)
                {
                    b = j;
                    if (CheckForPythagoras(a, b, c))
                        if (a + b + c == 1000)
                        {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            Console.WriteLine(a * b * c);
                            return;
                        }
                    for (int k = j + 1; k < 1000; k++)
                    {
                        c = k;
                        if (CheckForPythagoras(a, b, c))
                            if (a + b + c == 1000)
                            {
                                Console.WriteLine(a);
                                Console.WriteLine(b);
                                Console.WriteLine(c);
                                Console.WriteLine(a * b * c);
                                return;
                            }
                    }
                }
            }
        }

        private bool CheckForPythagoras(int a, int b, int c)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                return true;
            else return false;
        }

        public long FindSumOfPrimesBelow()
        {
            List<long> primeNumbers = new List<long>() { 2 };
            for (long i = 3; i < 2000000; i += 2)
            {
                bool any = false;
                foreach (var p in primeNumbers)
                {
                    if ((i % p) == 0)
                    {
                        any = true;
                        break;
                    }
                }
                if (!any)
                {
                    primeNumbers.Add(i);
                }
            }
            long result = primeNumbers.Sum();
            return result;
        }

        public void LargestSum()
        {
            char[] array = Opg8.ToCharArray();
            long[] Aint = Array.ConvertAll(array, c => (long)Char.GetNumericValue(c));
            int UpperCounter = 12;
            int LowerCounter = 0;
            long sum = 0;
            long newSum = 1;

            while (UpperCounter < Aint.Length)
            {
                for (int i = LowerCounter; i <= UpperCounter; i++)
                {
                    newSum = newSum * Aint[i];
                }
                if (newSum > sum)
                {
                    sum = newSum;
                }
                newSum = 1;
                LowerCounter++;
                UpperCounter++;
            }
            Console.WriteLine(sum);
        }

    }
}
