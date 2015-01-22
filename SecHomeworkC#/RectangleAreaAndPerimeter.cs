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
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double p = (2 * width) + (2 * height);
            double s = (width) * (height);

            Console.WriteLine(p);                       //Perimeter of rectangle
            Console.WriteLine(s);                       //Area of rectangle

        }
    }
}
