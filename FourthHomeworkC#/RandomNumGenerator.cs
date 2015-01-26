using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type how much random digits you want to see");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Type minimum random number");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Type maximum random number");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();
            int randomNumber = random.Next(min, max);
           
           Console.Write("Your Random numbers are: ");
           for (int i = 0; i < n; i++)
           {
               
               Console.Write(randomNumber + " ");
               randomNumber = random.Next(min, max + 1);
           }
           
        }
    }
}
