using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp2HomeworkArrays
{
    class Problem1
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;

            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array[{0}] * 5 = {1}", i, array[i]);
            }

        }
    }
}
