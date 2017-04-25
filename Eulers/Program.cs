using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Program
    {

       static Problem18 p18 = new Problem18();
        static void Main(string[] args)
        {
            p18.FillJaggedArray();
            Console.WriteLine(Convert.ToString(p18.FindMaxConnectedSum(p18.GetArray())));
        }
    }
}
