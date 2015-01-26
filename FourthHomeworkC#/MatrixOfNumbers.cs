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
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i < n+1; i++)
            {
                for (int d = 0 + s; d < n + s;d++)
                {
                    
                    Console.Write(d + 1);
                }
                Console.WriteLine();
                s++;
                
                
                
            }
            
            
            

        }
    }
}
