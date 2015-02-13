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
            Console.WriteLine("Please write the array lenght");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
         
            Console.WriteLine("Now please write nummbers in array");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());    
            }
            Array.Sort(array);
            foreach (int i in array) 
            { 
                Console.Write(i + " "); 
            }

         
        }
    }
}
