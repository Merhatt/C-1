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
            double min = 300100000;
            double max = -300000100;
            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                double n = double.Parse(Console.ReadLine());
                sum = sum + n;
                if (n < min) 
                {
                    min = n;
                }
                if (max < n) 
                {
                    max = n;
                }
            }
            double avarage = sum / 3;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine("{0:f2}",avarage);

        }
    }
}
