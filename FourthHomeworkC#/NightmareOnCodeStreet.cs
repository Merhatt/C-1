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
            string n = Console.ReadLine();
           int odd = 0;
           int oddSum = 0;
           int count = 0;
            foreach (var item in n)
            {
                if (char.IsDigit(item)) 
                {
                    if (count % 2 != 0) 
                    {
                        odd++;
                        oddSum = oddSum + (item - '0');
                    }
                }
                count++;

            }
            Console.WriteLine("{0} {1}",odd,oddSum);




        }
    }
}
