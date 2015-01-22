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

            Console.WriteLine("Write after how much seconds you want to wait");
            int timeForWake = int.Parse(Console.ReadLine());
            int time = timeForWake;
            for (int i = 0; i < (time + 1); i++)
            {
                Console.WriteLine("Second : {0}", timeForWake);
                timeForWake = timeForWake - 1;
                System.Threading.Thread.Sleep(1000);
            }
            for (int a = 1; a != 0; a++)
            {

                var h = DateTime.Now;
                Console.WriteLine("Time is up!! Its {0}", h);
                System.Threading.Thread.Sleep(1000);
                
            }




        }
    }
}
