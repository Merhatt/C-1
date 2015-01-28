using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());
            long iN = 1;
            long d = (n - k);
            long iK = 1;
            long iD = 1;
            long iF = 1;
            for (long i = 1; i <= n; i++)
            {
                iN = iN * i;
                
            }
            for (long i = 1; i <= d; i++)
            {
                iD = iD * i;

            }
            for (long i = 1; i <= k; i++)
            {
                iK = iK * i;

            }
            Console.WriteLine(iN / (iK * iD));
           
            




        }
    }
}
