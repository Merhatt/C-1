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
            Console.WriteLine("Please type lenght of array:");
            int n = int.Parse(Console.ReadLine());
            if (n > 1)
            {
                Console.WriteLine("Now please write numbers in the array");
                int[] array = new int[n];
                int s = 1;
                int d = 0;
                for (int i = 0; i < n; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
                foreach (var item in array)
                {
                    if (item == (array[s]-1))
                    {
                        if (d == 0)
                        {

                            Console.Write(item + ", " + (array[s]) + ", ");
                            d++;

                        }
                        else
                        {
                            if (s == n - 1)
                            {
                                Console.Write((array[s]));
                            }
                            else
                            {
                                Console.Write((array[s]) + ", ");
                            }


                        }

                    }
                    s++;

                    if (s == n)
                    {
                        break;
                    }
                }

            }


            Console.WriteLine();
        }
    }
}
