using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Comparechararrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type first word:");
            
            char[] firstWord = Console.ReadLine().ToCharArray();
            string lexic = string.Join("", firstWord);

            Console.WriteLine("Type second word:");

            char[] secWord = Console.ReadLine().ToCharArray();
         
            int lenght = Math.Min(firstWord.Length, secWord.Length);

            for (int i = 0; i < lenght; i++)
            {
                if (firstWord[i]>secWord[i])
                {
                   lexic = string.Join("", secWord);
                }   
            }
            Console.WriteLine("Lexicographically first is: {0}" ,lexic);


        }
    }
}
