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
            char[] alphabet = 
            {
            'A',
            'B',
            'C',
            'D',
            'E',
            'F',
            'G',
            'H',
            'I',
            'J',
            'K',
            'L',
            'M',
            'N',
            'O',
            'P',
            'Q',
            'R',
            'S',
            'T',
            'U',
            'V',
            'W',
            'X',
            'Y',
            'Z'                           
            };
            Console.WriteLine("Please write some upper letter between A-Z");
            char n = char.Parse(Console.ReadLine());
            int s=Array.BinarySearch(alphabet, n);
            Console.WriteLine("The letter {0} is at {1} Index ",n,s);




        }
    }
}
