using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int Age = int.Parse (Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be: {0}", Age + 10);


        }
    }
}
