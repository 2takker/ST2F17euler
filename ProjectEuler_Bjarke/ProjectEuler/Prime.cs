using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Prime
    {
        private List<int> primes_;

        public Prime()
        {
            primes_ = new List<int>();

            
        }



        public List<int> generatePrime(int numberOfPrimes)
        {
            Console.WriteLine("Generating primes, please wait");
            int count;
            for (int i = 1; primes_.Count < numberOfPrimes; i++)
            {
                count = i;
                while (count > 0 && i != 1)
                {
                    if (count > 1 && i > 1)
                    {
                        if (i % count == 0 && i != count)
                        {
                            break;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        primes_.Add(i);
                        break;
                    }
                }
            }
            return primes_;
        }



        private int generateNextPrime()
        {
            int nxtPrime = 1;
            Console.WriteLine("Generating primes, please wait");
            int count;
            for (int i = primes_.Max() + 1; primes_.Max() > nxtPrime; i++)
            {
                count = i;
                while (count > 0 && i != 1)
                {
                    if (count > 1 && i > 1)
                    {
                        if (i % count == 0 && i != count)
                        {
                            break;
                        }
                        else
                        {
                            count--;
                        }
                    }
                    else
                    {
                        nxtPrime = i;
                        break;
                    }
                }
            }
            return nxtPrime;
        }
    }
}
