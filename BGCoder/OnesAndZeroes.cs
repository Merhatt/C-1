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
            long n = long.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2).PadLeft(16, '0');

            int i = 0;
            int j = 0;
            int j1 = 0;
            int j2 = 0;
            int j3 = 0;
            string oneRow0 = ".#.";
            string oneRow1 = "##.";
            string oneRow2 = ".#.";
            string oneRow3 = ".#.";
            string oneRow4 = "###";
            int s = 0;
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            int s4 = 0;

            string zeroRow0 = "###";
            string zeroRow1 = "#.#";
            string zeroRow2 = "#.#";
            string zeroRow3 = "#.#";
            string zeroRow4 = "###";


            //0Row
            foreach (var item in binary)
            {
                if (s == 16) { break; }

                if (item == '0')
                {
                    Console.Write(zeroRow0);
                    if (i != 15)
                    {

                        Console.Write(".");

                    }

                }
                else if (item == '1')
                {
                    Console.Write(oneRow0);
                    if (i != 15)
                    {


                        Console.Write(".");

                    }

                }

                i++;
                s++;

            }
            Console.WriteLine();
            //Row 1

            foreach (var item in binary)
            {

                if (s1 == 16) { break; }
                if (item == '0')
                {
                    Console.Write(zeroRow1);
                    if (j != 15)
                    {
                        Console.Write(".");
                    }

                }
                else if (item == '1')
                {
                    Console.Write(oneRow1);
                    if (j != 15)
                    {
                        Console.Write(".");
                    }
                }

                j++;
                s1++;

            }
            Console.WriteLine();

            //Row 2
            foreach (var item in binary)
            {
                if (s2 == 16) { break; }

                if (item == '0')
                {
                    Console.Write(zeroRow2);
                    if (j1 != 15)
                    {
                        Console.Write(".");
                    }

                }
                else if (item == '1')
                {
                    Console.Write(oneRow2);
                    if (j1 != 15)
                    {
                        Console.Write(".");
                    }
                }

                j1++;
                s2++;

            }
            Console.WriteLine();

            //Row 3
            foreach (var item in binary)
            {

                if (s3 == 16) { break; }
                if (item == '0')
                {
                    Console.Write(zeroRow3);
                    if (j2 != 15)
                    {
                        Console.Write(".");
                    }

                }
                else if (item == '1')
                {
                    Console.Write(oneRow3);
                    if (j2 != 15)
                    {
                        Console.Write(".");
                    }
                }

                j2++;
                s3++;

            }
            Console.WriteLine();
            //Row 4
            foreach (var item in binary)
            {

                if (s4 == 16) { break; }
                if (item == '0')
                {
                    Console.Write(zeroRow4);
                    if (j3 != 15)
                    {
                        Console.Write(".");
                    }

                }
                else if (item == '1')
                {
                    Console.Write(oneRow4);
                    if (j3 != 15)
                    {
                        Console.Write(".");
                    }
                }

                j3++;
                s4++;

            }
            Console.WriteLine();


        }
    }
}