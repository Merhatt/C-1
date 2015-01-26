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
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int odd = 1;
            int even = 1;
            for (int i = 0; i < array.Length; i++)
            {
                int s = int.Parse(array[i]);
                if (i % 2 == 0 || i == 0)
                {
                    even = even * s;
                }
                else 
                {
                    odd = odd * s;
                }
                    
            }

            if (odd == even)
            {
                Console.WriteLine("yes");
                Console.WriteLine("Product = {0}", odd);
            }
            else {

                Console.WriteLine("no");
                Console.WriteLine("Odd product : {0}", odd);
                Console.WriteLine("Even product : {0}",even);
            }
        }
    }
}
