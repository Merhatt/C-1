using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can try it :)
            Console.WriteLine("Please write the numbers");
            string s = Console.ReadLine();//2, 1, 1, 2, 3, 3, 2, 2, 2, 1
            string[] numStr = s.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums =new int[numStr.Length];
            for (int i = 0; i < nums.Length; i++)
			{
			 nums[i] = int.Parse(numStr[i]);

			}

            int[] numbers = s
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select (n => int.Parse(n)).ToArray();
            int currentNum , maxNums = nums[0];
            int currentCout , maxCout = 0;
            for (int i = 0; i < nums.Length; )
			{
			    currentNum = nums[i];
                currentCout= 0;
                for (;i < nums.Length; i++)
			        {
		                if (currentNum != nums[i])
	                       {
	                        	 break;
	                       }
                    currentCout++;
			        }
                if (maxCout < currentCout)
                {
                maxCout = currentCout;
                maxNums=currentNum;
                }
	
		 
	

			}
            for (int i = 0; i < maxCout ; i++)
			{
			 Console.Write(maxNums+", ");
			}
            Console.WriteLine();


        }
    }
}
