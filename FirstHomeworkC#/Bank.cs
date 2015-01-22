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
            double sum = 0;
            Console.WriteLine("Type money that you want to add in your account");
            double  i = double.Parse(Console.ReadLine());
            while (i != -1) 
            {
                sum = sum + i;
                Console.WriteLine("Now you have {0} money in your accont if you want to stop adding type -1 or type next value that you want to add",sum);
                

                i = double.Parse(Console.ReadLine());

            }
            
            Console.WriteLine("Your total moneys are {0}",sum);

          
        }


    }
}
