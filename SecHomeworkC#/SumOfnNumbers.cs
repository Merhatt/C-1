
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
            int s = 1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                s = int.Parse(Console.ReadLine());
                sum = sum + s;
            }
            Console.WriteLine(sum);
        }
    }
}
