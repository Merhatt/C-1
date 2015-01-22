using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int div7And5 = int.Parse(Console.ReadLine());
            if (div7And5 % 7 == 0 && div7And5 % 5 == 0)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }

        }
    }
}
