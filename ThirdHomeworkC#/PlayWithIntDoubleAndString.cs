using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please chose a type \n1 For int \n2 For double \n3 For string");
            int s = int.Parse(Console.ReadLine());
            if (s == 1) 
            {
                Console.WriteLine("Please enter a int");
                int a = int.Parse(Console.ReadLine());
                a++;
                Console.WriteLine(a);
            }
            else if (s == 2)
            {
                Console.WriteLine("Please enter a double");
                double a = double.Parse(Console.ReadLine());
                a++;
                Console.WriteLine(a);
            }
            if (s == 3)
            {
                Console.WriteLine("Please enter a string");
                string a = Console.ReadLine();           
                Console.WriteLine("{0}*",a);
            }



        }
    }
}
