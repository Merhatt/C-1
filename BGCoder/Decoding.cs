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
            //int c = (char)item;
            double salt = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int oddOrEven = 0;
            
            foreach (char item in text)
            {
                if (item == '@') 
                {
                    break;
                }
                else if (char.IsDigit(item)) 
                {
                    if (oddOrEven % 2 == 0)
                    {
                        double c = ((char)item + salt + 500)/100;
                        Console.WriteLine("{0:f2}",c);
                    }
                    else if (oddOrEven % 2 != 0) 
                    {
                        double c = ((char)item + salt + 500) * 100;
                        Console.WriteLine("{0}", c);
                    }
                }
                else if (char.IsLetter(item)) 
                {
                    if (oddOrEven % 2 == 0)
                    {
                        double c = ((char)item * salt + 1000)/100;
                        Console.WriteLine("{0:f2}",c);
                    }else 
                    {
                    double c = ((char)item * salt + 1000)*100;
                        Console.WriteLine("{0}",c);
                    }
                }else if (!char.IsLetter(item) && !char.IsDigit(item))
                {
                    if (oddOrEven % 2 == 0)
                    {
                        double c = ((char)item - salt)/100;
                        Console.WriteLine("{0:f2}",c);
                    }
                    else
                    {
                        double c = ((char)item - salt) * 100;
                        Console.WriteLine("{0}", c);
                    }
                }

                oddOrEven++;
            }
      
        }
    }
}
