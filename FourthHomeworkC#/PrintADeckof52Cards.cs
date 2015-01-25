using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int a = 2;
            int d = 0;
            
            string J = "J";
            string Q = "Q";
            string K = "K"; 
            string A = "A";
            for ( int i = 0; i < 9; i++)
            {
                
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", a);
                a = a + 1;
                
            }
           
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", J);
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", Q);
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", K);
                Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", A);
            



        }
    }
}
