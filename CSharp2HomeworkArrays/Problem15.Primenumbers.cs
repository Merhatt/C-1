using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10000000; i++)
            {
                if (i == 2  || i == 3  || i == 5  || i == 7 )
                {
                    Console.WriteLine(i + " ");
                }else if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0) 
                {
                    Console.WriteLine(i+" ");
                }
                
            }
        }
    }
}
