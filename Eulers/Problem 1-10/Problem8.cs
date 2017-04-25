using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem8
    {
        private List<int> _enkelttal;
        private List<string> _langetalstring;
        private List<long> _productlist;
        private string _temp;
        private StringBuilder builder;
        public List<string> Opdel(string talrække)
        {
            builder = new StringBuilder();
            _langetalstring = new List<string>();
            _temp = "";
            for (int i = 0; i < talrække.Length - 12; i++)
            {
                _temp = builder.Append(talrække, i, 13).ToString();
                _langetalstring.Add(_temp);
                _temp = "";
                builder.Clear();
            }
            return _langetalstring;
        }

        public long LargestProduct(List<string> liste)
        {
            int x = 0;
            _enkelttal = new List<int>();
            _productlist = new List<long>();
            long product = 1;


            foreach (var element in liste)
            {
                for (int i = 0; i < element.Length; i++)
                {
                    x = Int32.Parse(Convert.ToString(element[i]));
                    _enkelttal.Add(x);
                }
                for (int i = 0; i < _enkelttal.Count; i++)
                {
                    product = product * _enkelttal[i];
                }
                _productlist.Add(product);
                _enkelttal.Clear();
                product = 1;
            }
            return _productlist.Max();
        }


    }
}
