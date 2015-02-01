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
            Console.WriteLine("Welcome to 6/49");
            Console.WriteLine("Type first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type sec number");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type third number");
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type fourth number");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type fifth number");
            int n5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type sixth number");
            int n6 = int.Parse(Console.ReadLine());
            Random random1 = new Random();
            int randomNumber1 = random1.Next(1, 49);
            Random random2 = new Random();
            int randomNumber2 = random2.Next(1, 49);
            Random random3 = new Random();
            int randomNumber3 = random3.Next(1, 49);
            Random random4 = new Random();
            int randomNumber4 = random4.Next(1, 49);
            Random random5 = new Random();
            int randomNumber5 = random5.Next(1, 49);
            Random random6 = new Random();
            int randomNumber6 = random6.Next(1, 49);
            while (randomNumber1 == randomNumber2 || randomNumber1 == randomNumber3 || randomNumber1 == randomNumber4 || randomNumber1 == randomNumber5 ||randomNumber1 == randomNumber6 ) 
            {
                randomNumber1 = random1.Next(1, 49);
            }
            while (randomNumber2 == randomNumber1 || randomNumber2 == randomNumber3 || randomNumber2 == randomNumber4 || randomNumber2 == randomNumber5 ||randomNumber2 == randomNumber6 ) 
            {
                randomNumber2 = random2.Next(1, 49);
            }
            while (randomNumber3 == randomNumber1 || randomNumber3== randomNumber2|| randomNumber3 == randomNumber4 || randomNumber3 == randomNumber5 ||randomNumber3 == randomNumber6 ) 
            {
                randomNumber3 = random3.Next(1, 49);
            }
            while (randomNumber4 == randomNumber1 || randomNumber4 == randomNumber2 || randomNumber4 == randomNumber5 || randomNumber4 == randomNumber3 ||randomNumber4 == randomNumber6 ) 
            {
                randomNumber4 = random4.Next(1, 49);
            }
            while (randomNumber5 == randomNumber2 || randomNumber5 == randomNumber3 || randomNumber5 == randomNumber4 || randomNumber5 == randomNumber1 || randomNumber1 == randomNumber6)
            {
                randomNumber5 = random5.Next(1, 49);
            }
            while (randomNumber6 == randomNumber2 || randomNumber6 == randomNumber3 || randomNumber6 == randomNumber4 || randomNumber6 == randomNumber5 || randomNumber6 == randomNumber1)
            {
                randomNumber6 = random6.Next(1, 49);
            }
            Console.WriteLine("Droping Toto");
            System.Threading.Thread.Sleep(1355);
            Console.WriteLine("First num is: " + randomNumber1);
            System.Threading.Thread.Sleep(1111);
            Console.WriteLine("Sec num is: "+ randomNumber2);
            System.Threading.Thread.Sleep(1320);
            Console.WriteLine("Third num is: "+ randomNumber3);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Fourth num is: " + randomNumber4);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Fifth num is: " + randomNumber5);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Sixth num is: " + randomNumber6);
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Toto nums are: {0} {1} {2} {3} {4} {5}",randomNumber1,randomNumber2,randomNumber3,randomNumber4,randomNumber5,randomNumber6);
            Console.WriteLine("Your nums are: {0} {1} {2} {3} {4} {5}", n1, n2, n3, n4, n5, n6);
        }
    }
}
