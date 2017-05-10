using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prime p = new Prime();

            //List<int> pList = p.generatePrime(20);   

            //foreach (int e in pList)
            //{
            //    Console.WriteLine(e);
            //}

            //Console.WriteLine("max:" + pList.Max());

            List<string> kommentar = new List<string>();

            kommentar.Add("...");
            kommentar.Add(" :c");

            Console.WriteLine(kommentar.ToString());

            string output = "Kommentarer: \n";

            foreach (string e in kommentar)
            {
                output += "" + e + "\n";
            }

            Console.WriteLine(output);



        }

    }

}
