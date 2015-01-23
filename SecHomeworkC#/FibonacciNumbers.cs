using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          int  n = int.Parse(Console.ReadLine());
          int[] s = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233 };
           int k = 0;
           while (s[n] != s[k])
           {
               Console.Write(s[k]);
               k++;
           }
           Console.WriteLine();
          
            

        }
    }
}
