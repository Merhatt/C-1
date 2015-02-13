using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the lenght of the array");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Please write the numbers in the array"); 
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your array was {0}",string.Join(", ",array));
            Array.Sort(array);
            Console.WriteLine("Now your array is {0}", string.Join(", ", array));


        }
    }
}
