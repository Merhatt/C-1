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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            if (a > b && b >= c) 
            {
                Console.WriteLine(a);
            }else if (c > b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b > a && a >= c  )
            {
                Console.WriteLine(b);
            }
            else if (b > c && c >= a) 
            {
                Console.WriteLine(b);
            }
            else if (b >= a && a >= c  )
            {
                Console.WriteLine(b);
            }else
            {
                Console.WriteLine(c);
            }

        }
    }
}
