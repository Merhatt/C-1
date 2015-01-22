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
            int n = int.Parse(Console.ReadLine());
            if (n < 100)
            {
                Console.WriteLine("false");
            }
            else 
            {
                n = n / 100;
                int h = 99999999;
                int s = 7;
                while (n != s && h != -1)
                {
                    s = s + 10;
                    if (h < s)
                    {
                        h = -1;
                    }
                    
                }
                if (n == s)
                {
                    Console.WriteLine("true");
                }
                else {
                    Console.WriteLine("false");
                }

            
            
            
            }




        }
    }
}
