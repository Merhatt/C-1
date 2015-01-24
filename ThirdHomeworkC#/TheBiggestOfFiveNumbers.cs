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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            if (a >= b && a >= c && a >= d && a >= e)
            {
                Console.WriteLine(a);
            }else if (a <= b && b >= c && b >= d && b >= e)
            {
                Console.WriteLine(b);
            }
            else if (a <= c && c >= b && c >= d && c >= e)
            {
                Console.WriteLine(c);
            }
            else if (a <= d && d >= b && d >= c && d >= e)
            {
                Console.WriteLine(d);
            }
            else
            {

                Console.WriteLine(e);
            }

        }
    }
}
