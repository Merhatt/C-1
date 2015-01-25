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
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool s = a - b >= 0;
            bool d = b - a >= 0;
            double g = 0;
            if (s)
            {
                 g = a - b;
                 if (g <= eps)
                 {

                     Console.WriteLine("true");
                 }
                 else 
                 {
                     Console.WriteLine("false");
                 }
            }
            else if (d)
            {
                g = b - a;
                if (g <= eps)
                {

                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
          



        }
    }
}
