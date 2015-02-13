using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good Luck ! :)
            Console.WriteLine("Please write sum in the array");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please write the length of the array");
            int sumOther = 0;
            int cout = 0;

            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Now please write the numbers in the array");
            int sum = 0;
            int countt = 0;
            int[] array3 = new int[length];

            int[] array = new int[length];
            int[] array2 = new int[length];
            int cs = 0;
            for (int i = 0; i < length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < length; i++)
            {
                cs = 0;
                sum = 0;
                cout = 0;
                for (int j = i; j < length; j++)
                {
                    sum = sum + array[j];
                   
                    if (sum == s)
                    {
                        sumOther = s;
                        for (int c = 0; c < length - i - cs; c++)
                        {
                            if (cout < length - i  )
                            {
                                
                                array2[c] = array[i + c];
                                cout++;
                                countt = cout;
                                
                               
                            }
                        }
                        
                    }
                   

                }
                cs++;


            }
            int Z;
            int sumz = 0;
            for (Z = 0; Z <length-cs; Z++)
            {
                sumz = sumz + array2[Z];
                if (length != countt)
                {
                    if (Z < countt && sumz <= s)
                    {
                        Console.Write(array2[Z] + " ");

                    }
                    else
                    {
                        break;
                    }
                }
              
               
            }
            for (int i = 0; i < countt; i++)
            {
                if (length == countt)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();

        }
    }
}
