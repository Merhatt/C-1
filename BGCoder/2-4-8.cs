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
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal r = 0;
            switch ((int)b)
            {
                case 2:
                    r = a % c;
                    break;
                case 4:
                    r = a + c;
                    break;
                case 8:
                    r = a * c;
                    break;
            }
            if (r % 4 == 0)
            {

                Console.WriteLine(r / 4);

            }
            else
            {

                Console.WriteLine(r % 4);

            }
            Console.WriteLine(r);

        }
    }
}
