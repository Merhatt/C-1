using System;

class Program
{
    static void Main()
    {
        string number = Console.ReadLine();
        int evenCount = 0;
        int s = 0;
        int sum = 0;
        foreach (var item in number)
        {
            if (s % 2 == 0) 
            {
                if (char.IsDigit(item))
                {
                    evenCount++;
                    sum = (item - '0') + sum;
                }
                
                
            }
            s++;

        }
        Console.WriteLine("{0} {1}",evenCount,sum);





    }


}