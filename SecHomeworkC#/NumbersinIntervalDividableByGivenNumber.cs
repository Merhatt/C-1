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
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            int i = start;
            int a = 1;
            int[] s = new int[a];  
            
          
            while (end >= i) 
            {
                
                if (i % 5 == 0) 
                {
                    p++;
                    
                    
                }
                i++;
                
            }
            Console.WriteLine("Numbers are  {0}",p);
            
            


        }
    }
}
