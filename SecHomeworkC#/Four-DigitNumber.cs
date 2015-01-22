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

            int a = int.Parse(Console.ReadLine());
            int s = 1000;
            int first = 1;
            int sec = 0;
            int third = 0;
            int fourth = 0;
            int sum = 0;       
            while (a != s)
            {

                fourth = fourth + 1;
                s = s + 1;          
                if (fourth == 10)
                {
                    third = third + 1;
                    fourth = 0;
                }
                if (third == 10)
                {
                    sec = sec + 1;
                    third = 0;
                } 
                if (sec == 10)
                {
                    first = first + 1;
                    sec = 0;
                }
                
                                           

            }
            sum = first + sec + third + fourth;
            Console.WriteLine("Your dig is {0}{1}{2}{3}",first,sec,third,fourth);
            Console.WriteLine("Sum of dig {0}",sum);
            Console.WriteLine("Reversed dig {0}{1}{2}{3}", fourth,third,sec,first);
            Console.WriteLine("Last dig in front {0}{1}{2}{3}",fourth, first, sec, third);
            Console.WriteLine("Second and thirt dig exchanged {0}{1}{2}{3}", first, third, sec, fourth);
            





        }
    }
}
