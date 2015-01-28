using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            char dot = '.';
            char left = '/';
            char right = '\\';
            char l = '-';
            int count = 0;
            int count2 = 0;
            int d = 2;
            int s =1 ;
            int s2 = 1;
            int d2 = 2;
            for (int i = 0; i < n; i++)
            {

                Console.Write(new string(dot, n - (i+1)));
                Console.Write(new string(left, 1));
                if (i == s)
                {
                    Console.Write(new string(l, count));
                    s = s + d;
                    d++;
                    
                   
                }else
                {
                    Console.Write(new string(dot, count));
                }
                count++;
                if (i == s2)
                {
                    Console.Write(new string(l, count-1));
                    s2 = s2 + d2;
                    d2++;


                }
                else
                {
                    Console.Write(new string(dot, count2 ));
                }
                count2++;
                Console.Write(new string(right, 1));
                Console.Write(new string(dot, n - (i+1)));
               


                

                Console.WriteLine();
            }
        }
    }
}