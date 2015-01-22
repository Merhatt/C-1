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
            int n = int.Parse(Console.ReadLine());
            
            {
                if (n == 2 || n == 3 || n == 5)
                {
                    Console.WriteLine("true");
                }
                else if (n % 2 == 0 || n % 3 == 0 || n % 5 == 0)
                {
                    Console.WriteLine("false");
                }
                else if (n % 2 != 0 || n % 3 != 0)
                {
                    Console.WriteLine("true");
                }
            }
            
            



            
        }
    }
}
