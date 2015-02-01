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
           long num = Convert.ToInt64(n);
           if (num < 0) 
           {
               num = -num;
           }
           n = Convert.ToString(num);
            
           long sumOfEven = 0;
           long sumOfOdd = 0;
           foreach (var item in n)
           {
               if (item % 2 == 0) 
               {
                   sumOfEven = sumOfEven + (item - '0');
               }
               else if (item % 2 != 0)
               {
                   sumOfOdd = sumOfOdd + (item - '0');
               }

           }
           if (sumOfOdd > sumOfEven) 
           {
               Console.WriteLine("left {0}" , sumOfOdd);
           }
           else if (sumOfOdd < sumOfEven)
           {
               Console.WriteLine("right {0}", sumOfEven);
           }
           else
           {
               Console.WriteLine("straight {0}",sumOfEven);
           
           }




        }
    }
}
