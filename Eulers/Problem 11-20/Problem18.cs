using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eulers
{
    class Problem18
    {
        //Ikke færdig

        int[][] jaggedarray = new int[15][];
        private int _result;
        private int _largest;
        private int _index1;
        private int _index2;

        private List<int> liste = new List<int>()
        {
            75,
            95,
            64,
            17,
            47,
            82,
            18,
            35,
            87,
            10,
            20,
            04,
            82,
            47,
            65,
            19,
            01,
            23,
            75,
            03,
            34,
            88,
            02,
            77,
            73,
            07,
            63,
            67,
            99,
            65,
            04,
            28,
            06,
            16,
            70,
            92,
            41,
            41,
            26,
            56,
            83,
            40,
            80,
            70,
            33,
            41,
            48,
            72,
            33,
            47,
            32,
            37,
            16,
            94,
            29,
            53,
            71,
            44,
            65,
            25,
            43,
            91,
            52,
            97,
            51,
            14,
            70,
            11,
            33,
            28,
            77,
            73,
            17,
            78,
            39,
            68,
            17,
            57,
            91,
            71,
            52,
            38,
            17,
            14,
            91,
            43,
            58,
            50,
            27,
            29,
            48,
            63,
            66,
            04,
            68,
            89,
            53,
            67,
            30,
            73,
            16,
            69,
            87,
            40,
            31,
            04,
            62,
            98,
            27,
            23,
            09,
            70,
            98,
            73,
            93,
            38,
            53,
            60,
            04,
            23
        };

        private int _smallest;

        public void FillJaggedArray()
        {
            for (int i = 0; i < 15; i++)
            {
                jaggedarray[i] = new int[i+1];
            }

            int counter = 0;
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    jaggedarray[i][j] = liste[counter];
                    counter++;
                }
            }
        }

        public int[][] GetArray()
        {
            return jaggedarray;
        }
        public int FindMaxSum(int[][] jaggedarray)
        {
            foreach (var VARIABLE in jaggedarray)
            {
                _result += VARIABLE.Max();
            }
            return _result;
        }

        public int FindLargest(int[] array, int n1, int n2)
        {
            _largest = 0;
            if (array[n1] > array[n2])
            {
                _largest = array[n1];
            }
            else
            {
                _largest = array[n2];
            }
            return _largest;
        }

        public int FindSmallest(int[] array, int n1, int n2)
        {
            _smallest = 0;
            if (array[n1] < array[n2])
            {
                _smallest = array[n1];
            }
            else
            {
                _smallest = array[n2];
            }
            return _smallest;
        }


        public int FindMaxConnectedSum(int[][] triangle)
        {
            _result = jaggedarray[0][0];
            _index1 = 0;
            _index2 = 1;
            for (int i = 1; i < jaggedarray.Length; i++)
            {
       //         if (i < 14)
       //         {
       //             if (jaggedarray[i + 1][_index2] - jaggedarray[i + 1][_index1] >
       //jaggedarray[i][_index2] - jaggedarray[i][_index1] || jaggedarray[i + 1][_index1] - jaggedarray[i + 1][_index2] > jaggedarray[i][_index1] - jaggedarray[i][_index2])
       //             {
       //                 _result += FindSmallest(jaggedarray[i], _index1, _index2);
       //                 _index1 = Array.IndexOf(jaggedarray[i], FindSmallest(jaggedarray[i], _index1, _index2), _index1, 2);
       //                 _index2 = _index1 + 1;
       //             }
       //             else
       //             {
       //                 _result += FindLargest(jaggedarray[i], _index1, _index2);
       //                 _index1 = Array.IndexOf(jaggedarray[i], FindLargest(jaggedarray[i], _index1, _index2), _index1, 2);
       //                 _index2 = _index1 + 1;
       //             }
       //         }
       //         else
       //         {
                    _result += FindLargest(jaggedarray[i], _index1, _index2);
                    _index1 = Array.IndexOf(jaggedarray[i], FindLargest(jaggedarray[i], _index1, _index2), _index1, 2);
                    _index2 = _index1 + 1;
                //}

            }
            return _result;
        }


    }
}
