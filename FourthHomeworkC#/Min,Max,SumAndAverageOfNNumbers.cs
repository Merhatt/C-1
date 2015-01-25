using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] s = new double[n];
            double min = 10000000;
            double max = 0;
            double sum = 0;    
            double avg = 0;
            
            for (int i = 0; i < n; i++)
            {
                s[i] = double.Parse(Console.ReadLine());
                if (s[i] < min) 
                {
                    min = s[i];
                }
                if (s[i] > max) 
                {
                    max = s[i];
                }
                sum = sum + s[i];
               
                
                
                

            }
          
            avg = sum / n;
            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avarage = {0:0.00}", avg);
            
        }
    }
}
