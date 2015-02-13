using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger sum = 1;
            BigInteger sum2 = 1;
           int s = 0;
            string[] n = new string[99999];

            for (long i = 0; i < 999999999; i++)
            {
                n[i] = Console.ReadLine();
                if (n[i] == "END"|| n[i] == "end") 
                {
                    break;
                }
                else if (i % 2 != 0) 
                {
                    if (n[i] == "0") 
                    {
                        n[i] = "1";
                    }
                    foreach (var item in n[i])
                    {
                        if (s < 10)
                        {
                            if (item == '0')
                            {

                            }
                            else
                            {
                                sum = sum * (item - '0');
                            }
                        }
                        else 
                        {
                            if (item == '0')
                            {

                            }
                            else
                            {
                                sum2 = sum2 * (item - '0');
                            }
                        }
                        
                    }
                   
                }
                s++;
            }
            Console.WriteLine(sum);
            
            if (s > 10)
            {
                Console.WriteLine(sum2);
            }



        }
    }
}
