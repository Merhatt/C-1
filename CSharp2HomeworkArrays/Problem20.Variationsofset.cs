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
            Console.WriteLine("Write maximum number N");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("Write  number K");
            int K = int.Parse(Console.ReadLine());
            int min = 0;
            int mis = 0;
            for (int i = 0; i < max; i++)
            {
                min = 0;
                mis++;         
                for (int s = 0; s < max; s++)
                {
                    min++;
                    Console.WriteLine("{"+mis + ", " + min+"}");
                }
            }

        }
    }
}
