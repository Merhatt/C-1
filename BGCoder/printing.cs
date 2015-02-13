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
            double n = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double realm = 500;
            double students = n * s;
            double papers = students / realm;
            double price = papers * p;
            Console.WriteLine("{0:f2}",price);
  
        }
    }
}
