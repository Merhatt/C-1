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
            long result = 0;
            int m = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            foreach (var item in s)
            {
                if (item == '@')
                {
                    break;
                }
                else if (char.IsDigit(item))
                {
                    result = result * (item - '0');
                }
                else if (char.IsLetter(item))
                {
                    if (char.IsUpper(item))
                    {
                        result = result + item - 'A';
                    }
                    else if (char.IsLower(item))
                    {
                        result = result + item - 'a';
                    }
                }
                else 
                {
                    result = result % m;
                }


            }
            Console.WriteLine(result);

        }
    }
}
