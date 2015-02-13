using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write the lenght of the array");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please enter the numbers in array");
            int count = 0;
            int maxCount = 0;
            int numNow = 0;
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                count = 0;
                
                for (int j = 0; j < length; j++)
                {
                    if (array[i] == array[j]) 
                    {
                        count++;
                    }

                }
                if (count > maxCount) 
                {
                    maxCount = count;
                    numNow = array[i];
                }


            }
            Console.WriteLine("{0}({1}Times)",numNow,maxCount);






        }
    }
}
