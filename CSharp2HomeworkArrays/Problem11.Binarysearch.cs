using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good Luck! :)
            Console.WriteLine("Please type the lenght of the array"); 
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now type the numbers in the array");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.Write("After sort your nums are:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine("Write the number that you want to see his index");
            int num = int.Parse(Console.ReadLine());
           int s = Array.BinarySearch(array, num);
            Console.WriteLine("Your num: {0} is in {1} place ",num,s);
           
        }
    }
}
