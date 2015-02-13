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
            Console.WriteLine("Please write count of First array:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please write {0} count of arrays:",n);
            int[] array1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Type array number: {0}",i);
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Please write count of Second array:");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please write {0} count of arrays:", n2);
            int[] array2 = new int[n];
            for (int i = 0; i < n2; i++)
            {
                Console.WriteLine("Type array number: {0}", i);
                array2[i] = int.Parse(Console.ReadLine());
            }
            bool isEqual = true;
            if (array1.Length != array2.Length)
            {
                isEqual = false;
            }
            else 
            {
                for (int i = 0; i < n2; i++)
                {
                    if (array1[i] != array2[i]) 
                    {
                        isEqual = false;
                    
                    }
                }
            }



      Console.WriteLine("Are arrays are equal: {0}",isEqual);
            
            
            
            }
            




        }
    }

