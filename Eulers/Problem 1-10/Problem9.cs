using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem9
    {
        private int _a;
        private int _b;
        private int _c;
        private bool _pythagoras;
        private int _product;


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
        }
    }

