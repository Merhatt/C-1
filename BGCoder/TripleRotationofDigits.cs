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
            long k = long.Parse(Console.ReadLine());
            long m = k;
            if (k < 0)
            {
                k = -k;
            }
            string z = Convert.ToString(k);
            long s = 0;
            long d = 0;
            long l = 0;
            s = k % 10;
            k = k / 10;
            d = k % 10;
            k = k / 10;
            long f = k;
            l = k % 10;
            k = k / 10;

            if (z.Length == 3)
            {
                if (s != 0)
                {
                    Console.WriteLine(z);
                }
                else if (s == 0 && d != 0) 
                {
                    Console.WriteLine("{0}{1}",d,f);
                }
                else if (s == 0 && d == 0) 
                {
                    Console.WriteLine(l);
                }
            }
            else if (z.Length == 2)
            {
                Console.WriteLine("{0}{1}", s, d);
            }
            else if (z.Length == 1)
            {
                Console.WriteLine(s);
            }
            else
            {
                if (l != 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}", l, d, s, k);
                }
                if (l == 0 && d != 0)
                {
                    Console.WriteLine("{1}{2}{3}", d, s, k);
                }
                if (l == 0 && d == 0 && s != 0)
                {
                    Console.WriteLine("{0}{1}", s, k);
                }
                if (l == 0 && d == 0 && s == 0)
                {
                    Console.WriteLine("{0}", k);
                }
            }
        }




    }
}