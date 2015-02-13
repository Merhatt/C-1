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
            int n = int.Parse(Console.ReadLine());
            int d = n - 1;
            int s = n * 2 - 1;
            int j1 = n - 3;
            int j = n - 2;
            int m = n - 2;

            char left = '/';
            char dott = ':';
            char space = ' ';
            char x = 'X';

            //Top

            Console.Write(new string(space, s-n));
            Console.Write(new string(dott, n));
            Console.WriteLine();


            //Other Top
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string(space, j));
                Console.Write(new string(dott, 1));
                Console.Write(new string(left, m));
                Console.Write(new string(dott, 1));
                Console.Write(new string(x, i));
                Console.Write(new string(dott, 1));

                j--;
                Console.WriteLine();
            }







            //Middle
            Console.Write(new string (dott , n));
            Console.Write(new string(x, n-2));
            Console.Write(new string(dott, 1));
            Console.WriteLine();



            //Bottom
            for (int i = 0; i < n-2; i++)
            {
                Console.Write(new string(dott, 1));
                Console.Write(new string(space, n-2));
                Console.Write(new string(dott, 1));
                Console.Write(new string(x, j1));
                Console.Write(new string(dott, 1));
                j1--;
                Console.WriteLine();
            }




            //Verry Bottom
            Console.Write(new string(dott, n));
            Console.WriteLine();

        }
    }
}
