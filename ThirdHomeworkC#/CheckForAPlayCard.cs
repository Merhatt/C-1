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
            int[] s =  { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int v;
             string J = "J";
             string Q = "Q";
             string K = "K";
             string A = "A";
             bool successfullyParsed = int.TryParse(n, out v);
             if (successfullyParsed)
             {
                 if (s[0] == v || s[1] == v || s[2] == v || s[3] == v || s[4] == v || s[5] == v || s[6] == v || s[7] == v || s[8] == v)
                 {
                     Console.WriteLine("yes");
                 }
                 else
                 {
                     Console.WriteLine("no");
                 }
             }
             else {

                 if (n == J || n == Q || n == K || n == A)
                 {
                     Console.WriteLine("yes");

                 }
                 else 
                 {
                     Console.WriteLine("no");
                 }
             }
         
                 
            
           }

      }
}

