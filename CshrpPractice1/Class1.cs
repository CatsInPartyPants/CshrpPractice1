using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshrpPractice1
{
    internal class Matrix
    {
        int[] array;

        public Matrix()
        {
            
        }
        public Matrix(string str)
        {
            int i = 0;
            foreach(var s in str.Split(' '))
            {
                array[i] = Int32.Parse(s);
                i++;
            }
        }

        public void SumArr()
        {
            Console.WriteLine(array.Sum());
        }


    }
}
