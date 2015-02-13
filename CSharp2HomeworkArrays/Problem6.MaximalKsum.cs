using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the lenght of the array");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the lenght of the array that you want the max sum");
            int Max = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            int ressult = 0;
            int s = 0;
            Console.WriteLine("Now please write {0}  numbers in the array",lenght);
            for (int i = 0; i < lenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int i = lenght-1; i > lenght-1-Max; i--)
            {
                ressult += array[i];
                Console.Write(array[i]);
                s++;
                if (s ==  Max)
                {
                    Console.Write("=");
                }
                else 
                {
                    Console.Write("+");
                }
                
            }
            Console.WriteLine(ressult);
        }
    }
}
