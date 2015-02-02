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
            int n = int.Parse(Console.ReadLine());
            char dot = '.';
            char left = '/';
            char star = '*';
            char right = '\\';
            char up = '|';
            char dash = '-';

            //top
            for (int i = 0; i <= n / 2; i++)
            {
                for (int j = 0; j <n / 2; j++)
                {
                    if (i == j)
                    {
                        Console.Write(right);
                    }
                    else if (i != n / 2)
                    {
                        Console.Write(dot);
                    }
                }
                if (i != n / 2)
                {
                    Console.Write(up);
                }
                for (int s = n/2; s > 0; s--)
                {
                    if (i == s-1)
                    {
                        Console.Write(left);
                    }
                    else if (i != n / 2)
                    {
                        Console.Write(dot);
                    }
                }


                if (i != n / 2)
                {
                    Console.WriteLine();
                }
            }



            //Middle
            Console.Write(new string(dash, n / 2));
            Console.Write(new string(star, 1));
            Console.Write(new string(dash, n / 2));
            Console.WriteLine();

            //Bottom


            for (int i = 0; i <= n/2; i++)
            {
                for (int s = n / 2; s > 0; s--)
                {
                    if (i == s - 1)
                    {
                        Console.Write(left);
                    }
                    else if (i != n / 2)
                    {
                        Console.Write(dot);
                    }
                   
                }
                if (i != n / 2)
                {
                    Console.Write(up);
                }
                for (int j = 0; j < n / 2; j++)
                {
                    if (i == j)
                    {
                        Console.Write(right);
                    }
                    else if (i != n / 2)
                    {
                        Console.Write(dot);
                    }
                }
                


                if (i != n / 2)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}